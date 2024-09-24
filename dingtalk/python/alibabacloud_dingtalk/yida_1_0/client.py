# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.yida_1_0 import models as dingtalkyida__1__0_models
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

    def app_login_code_gen_with_options(
        self,
        request: dingtalkyida__1__0_models.AppLoginCodeGenRequest,
        headers: dingtalkyida__1__0_models.AppLoginCodeGenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.AppLoginCodeGenResponse:
        """
        @summary 生成登录态传递用的code
        
        @param request: AppLoginCodeGenRequest
        @param headers: AppLoginCodeGenHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AppLoginCodeGenResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.full_url):
            query['fullUrl'] = request.full_url
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.app_key):
            body['appKey'] = request.app_key
        if not UtilClient.is_unset(request.sign_timestamp_str):
            body['signTimestampStr'] = request.sign_timestamp_str
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
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
            action='AppLoginCodeGen',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/authorizations/appLoginCodes',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.AppLoginCodeGenResponse(),
            self.execute(params, req, runtime)
        )

    async def app_login_code_gen_with_options_async(
        self,
        request: dingtalkyida__1__0_models.AppLoginCodeGenRequest,
        headers: dingtalkyida__1__0_models.AppLoginCodeGenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.AppLoginCodeGenResponse:
        """
        @summary 生成登录态传递用的code
        
        @param request: AppLoginCodeGenRequest
        @param headers: AppLoginCodeGenHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AppLoginCodeGenResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.full_url):
            query['fullUrl'] = request.full_url
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.app_key):
            body['appKey'] = request.app_key
        if not UtilClient.is_unset(request.sign_timestamp_str):
            body['signTimestampStr'] = request.sign_timestamp_str
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
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
            action='AppLoginCodeGen',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/authorizations/appLoginCodes',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.AppLoginCodeGenResponse(),
            await self.execute_async(params, req, runtime)
        )

    def app_login_code_gen(
        self,
        request: dingtalkyida__1__0_models.AppLoginCodeGenRequest,
    ) -> dingtalkyida__1__0_models.AppLoginCodeGenResponse:
        """
        @summary 生成登录态传递用的code
        
        @param request: AppLoginCodeGenRequest
        @return: AppLoginCodeGenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.AppLoginCodeGenHeaders()
        return self.app_login_code_gen_with_options(request, headers, runtime)

    async def app_login_code_gen_async(
        self,
        request: dingtalkyida__1__0_models.AppLoginCodeGenRequest,
    ) -> dingtalkyida__1__0_models.AppLoginCodeGenResponse:
        """
        @summary 生成登录态传递用的code
        
        @param request: AppLoginCodeGenRequest
        @return: AppLoginCodeGenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.AppLoginCodeGenHeaders()
        return await self.app_login_code_gen_with_options_async(request, headers, runtime)

    def batch_get_form_data_by_id_list_with_options(
        self,
        request: dingtalkyida__1__0_models.BatchGetFormDataByIdListRequest,
        headers: dingtalkyida__1__0_models.BatchGetFormDataByIdListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.BatchGetFormDataByIdListResponse:
        """
        @summary 批量获取指定表单实例ID列表对应的表单实例数据
        
        @param request: BatchGetFormDataByIdListRequest
        @param headers: BatchGetFormDataByIdListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchGetFormDataByIdListResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_instance_id_list):
            body['formInstanceIdList'] = request.form_instance_id_list
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.need_form_instance_value):
            body['needFormInstanceValue'] = request.need_form_instance_value
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='BatchGetFormDataByIdList',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/instances/ids/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.BatchGetFormDataByIdListResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_get_form_data_by_id_list_with_options_async(
        self,
        request: dingtalkyida__1__0_models.BatchGetFormDataByIdListRequest,
        headers: dingtalkyida__1__0_models.BatchGetFormDataByIdListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.BatchGetFormDataByIdListResponse:
        """
        @summary 批量获取指定表单实例ID列表对应的表单实例数据
        
        @param request: BatchGetFormDataByIdListRequest
        @param headers: BatchGetFormDataByIdListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchGetFormDataByIdListResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_instance_id_list):
            body['formInstanceIdList'] = request.form_instance_id_list
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.need_form_instance_value):
            body['needFormInstanceValue'] = request.need_form_instance_value
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='BatchGetFormDataByIdList',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/instances/ids/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.BatchGetFormDataByIdListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_get_form_data_by_id_list(
        self,
        request: dingtalkyida__1__0_models.BatchGetFormDataByIdListRequest,
    ) -> dingtalkyida__1__0_models.BatchGetFormDataByIdListResponse:
        """
        @summary 批量获取指定表单实例ID列表对应的表单实例数据
        
        @param request: BatchGetFormDataByIdListRequest
        @return: BatchGetFormDataByIdListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.BatchGetFormDataByIdListHeaders()
        return self.batch_get_form_data_by_id_list_with_options(request, headers, runtime)

    async def batch_get_form_data_by_id_list_async(
        self,
        request: dingtalkyida__1__0_models.BatchGetFormDataByIdListRequest,
    ) -> dingtalkyida__1__0_models.BatchGetFormDataByIdListResponse:
        """
        @summary 批量获取指定表单实例ID列表对应的表单实例数据
        
        @param request: BatchGetFormDataByIdListRequest
        @return: BatchGetFormDataByIdListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.BatchGetFormDataByIdListHeaders()
        return await self.batch_get_form_data_by_id_list_with_options_async(request, headers, runtime)

    def batch_removal_by_form_instance_id_list_with_options(
        self,
        request: dingtalkyida__1__0_models.BatchRemovalByFormInstanceIdListRequest,
        headers: dingtalkyida__1__0_models.BatchRemovalByFormInstanceIdListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.BatchRemovalByFormInstanceIdListResponse:
        """
        @summary 批量删除指定的表单实例
        
        @param request: BatchRemovalByFormInstanceIdListRequest
        @param headers: BatchRemovalByFormInstanceIdListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchRemovalByFormInstanceIdListResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.asynchronous_execution):
            body['asynchronousExecution'] = request.asynchronous_execution
        if not UtilClient.is_unset(request.execute_expression):
            body['executeExpression'] = request.execute_expression
        if not UtilClient.is_unset(request.form_instance_id_list):
            body['formInstanceIdList'] = request.form_instance_id_list
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='BatchRemovalByFormInstanceIdList',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/instances/batchRemove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.BatchRemovalByFormInstanceIdListResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_removal_by_form_instance_id_list_with_options_async(
        self,
        request: dingtalkyida__1__0_models.BatchRemovalByFormInstanceIdListRequest,
        headers: dingtalkyida__1__0_models.BatchRemovalByFormInstanceIdListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.BatchRemovalByFormInstanceIdListResponse:
        """
        @summary 批量删除指定的表单实例
        
        @param request: BatchRemovalByFormInstanceIdListRequest
        @param headers: BatchRemovalByFormInstanceIdListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchRemovalByFormInstanceIdListResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.asynchronous_execution):
            body['asynchronousExecution'] = request.asynchronous_execution
        if not UtilClient.is_unset(request.execute_expression):
            body['executeExpression'] = request.execute_expression
        if not UtilClient.is_unset(request.form_instance_id_list):
            body['formInstanceIdList'] = request.form_instance_id_list
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='BatchRemovalByFormInstanceIdList',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/instances/batchRemove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.BatchRemovalByFormInstanceIdListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_removal_by_form_instance_id_list(
        self,
        request: dingtalkyida__1__0_models.BatchRemovalByFormInstanceIdListRequest,
    ) -> dingtalkyida__1__0_models.BatchRemovalByFormInstanceIdListResponse:
        """
        @summary 批量删除指定的表单实例
        
        @param request: BatchRemovalByFormInstanceIdListRequest
        @return: BatchRemovalByFormInstanceIdListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.BatchRemovalByFormInstanceIdListHeaders()
        return self.batch_removal_by_form_instance_id_list_with_options(request, headers, runtime)

    async def batch_removal_by_form_instance_id_list_async(
        self,
        request: dingtalkyida__1__0_models.BatchRemovalByFormInstanceIdListRequest,
    ) -> dingtalkyida__1__0_models.BatchRemovalByFormInstanceIdListResponse:
        """
        @summary 批量删除指定的表单实例
        
        @param request: BatchRemovalByFormInstanceIdListRequest
        @return: BatchRemovalByFormInstanceIdListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.BatchRemovalByFormInstanceIdListHeaders()
        return await self.batch_removal_by_form_instance_id_list_with_options_async(request, headers, runtime)

    def batch_save_form_data_with_options(
        self,
        request: dingtalkyida__1__0_models.BatchSaveFormDataRequest,
        headers: dingtalkyida__1__0_models.BatchSaveFormDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.BatchSaveFormDataResponse:
        """
        @summary 批量保存表单实例数据
        
        @param request: BatchSaveFormDataRequest
        @param headers: BatchSaveFormDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchSaveFormDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.asynchronous_execution):
            body['asynchronousExecution'] = request.asynchronous_execution
        if not UtilClient.is_unset(request.form_data_json_list):
            body['formDataJsonList'] = request.form_data_json_list
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.keep_running_after_exception):
            body['keepRunningAfterException'] = request.keep_running_after_exception
        if not UtilClient.is_unset(request.no_execute_expression):
            body['noExecuteExpression'] = request.no_execute_expression
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='BatchSaveFormData',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/instances/batchSave',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.BatchSaveFormDataResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_save_form_data_with_options_async(
        self,
        request: dingtalkyida__1__0_models.BatchSaveFormDataRequest,
        headers: dingtalkyida__1__0_models.BatchSaveFormDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.BatchSaveFormDataResponse:
        """
        @summary 批量保存表单实例数据
        
        @param request: BatchSaveFormDataRequest
        @param headers: BatchSaveFormDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchSaveFormDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.asynchronous_execution):
            body['asynchronousExecution'] = request.asynchronous_execution
        if not UtilClient.is_unset(request.form_data_json_list):
            body['formDataJsonList'] = request.form_data_json_list
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.keep_running_after_exception):
            body['keepRunningAfterException'] = request.keep_running_after_exception
        if not UtilClient.is_unset(request.no_execute_expression):
            body['noExecuteExpression'] = request.no_execute_expression
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='BatchSaveFormData',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/instances/batchSave',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.BatchSaveFormDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_save_form_data(
        self,
        request: dingtalkyida__1__0_models.BatchSaveFormDataRequest,
    ) -> dingtalkyida__1__0_models.BatchSaveFormDataResponse:
        """
        @summary 批量保存表单实例数据
        
        @param request: BatchSaveFormDataRequest
        @return: BatchSaveFormDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.BatchSaveFormDataHeaders()
        return self.batch_save_form_data_with_options(request, headers, runtime)

    async def batch_save_form_data_async(
        self,
        request: dingtalkyida__1__0_models.BatchSaveFormDataRequest,
    ) -> dingtalkyida__1__0_models.BatchSaveFormDataResponse:
        """
        @summary 批量保存表单实例数据
        
        @param request: BatchSaveFormDataRequest
        @return: BatchSaveFormDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.BatchSaveFormDataHeaders()
        return await self.batch_save_form_data_with_options_async(request, headers, runtime)

    def batch_update_form_data_by_instance_id_with_options(
        self,
        request: dingtalkyida__1__0_models.BatchUpdateFormDataByInstanceIdRequest,
        headers: dingtalkyida__1__0_models.BatchUpdateFormDataByInstanceIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.BatchUpdateFormDataByInstanceIdResponse:
        """
        @summary 将多条表单实例的指定表单组件更新成指定值
        
        @param request: BatchUpdateFormDataByInstanceIdRequest
        @param headers: BatchUpdateFormDataByInstanceIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchUpdateFormDataByInstanceIdResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.asynchronous_execution):
            body['asynchronousExecution'] = request.asynchronous_execution
        if not UtilClient.is_unset(request.form_instance_id_list):
            body['formInstanceIdList'] = request.form_instance_id_list
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.ignore_empty):
            body['ignoreEmpty'] = request.ignore_empty
        if not UtilClient.is_unset(request.no_execute_expression):
            body['noExecuteExpression'] = request.no_execute_expression
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.update_form_data_json):
            body['updateFormDataJson'] = request.update_form_data_json
        if not UtilClient.is_unset(request.use_latest_form_schema_version):
            body['useLatestFormSchemaVersion'] = request.use_latest_form_schema_version
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='BatchUpdateFormDataByInstanceId',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/instances/components',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.BatchUpdateFormDataByInstanceIdResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_update_form_data_by_instance_id_with_options_async(
        self,
        request: dingtalkyida__1__0_models.BatchUpdateFormDataByInstanceIdRequest,
        headers: dingtalkyida__1__0_models.BatchUpdateFormDataByInstanceIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.BatchUpdateFormDataByInstanceIdResponse:
        """
        @summary 将多条表单实例的指定表单组件更新成指定值
        
        @param request: BatchUpdateFormDataByInstanceIdRequest
        @param headers: BatchUpdateFormDataByInstanceIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchUpdateFormDataByInstanceIdResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.asynchronous_execution):
            body['asynchronousExecution'] = request.asynchronous_execution
        if not UtilClient.is_unset(request.form_instance_id_list):
            body['formInstanceIdList'] = request.form_instance_id_list
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.ignore_empty):
            body['ignoreEmpty'] = request.ignore_empty
        if not UtilClient.is_unset(request.no_execute_expression):
            body['noExecuteExpression'] = request.no_execute_expression
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.update_form_data_json):
            body['updateFormDataJson'] = request.update_form_data_json
        if not UtilClient.is_unset(request.use_latest_form_schema_version):
            body['useLatestFormSchemaVersion'] = request.use_latest_form_schema_version
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='BatchUpdateFormDataByInstanceId',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/instances/components',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.BatchUpdateFormDataByInstanceIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_update_form_data_by_instance_id(
        self,
        request: dingtalkyida__1__0_models.BatchUpdateFormDataByInstanceIdRequest,
    ) -> dingtalkyida__1__0_models.BatchUpdateFormDataByInstanceIdResponse:
        """
        @summary 将多条表单实例的指定表单组件更新成指定值
        
        @param request: BatchUpdateFormDataByInstanceIdRequest
        @return: BatchUpdateFormDataByInstanceIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.BatchUpdateFormDataByInstanceIdHeaders()
        return self.batch_update_form_data_by_instance_id_with_options(request, headers, runtime)

    async def batch_update_form_data_by_instance_id_async(
        self,
        request: dingtalkyida__1__0_models.BatchUpdateFormDataByInstanceIdRequest,
    ) -> dingtalkyida__1__0_models.BatchUpdateFormDataByInstanceIdResponse:
        """
        @summary 将多条表单实例的指定表单组件更新成指定值
        
        @param request: BatchUpdateFormDataByInstanceIdRequest
        @return: BatchUpdateFormDataByInstanceIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.BatchUpdateFormDataByInstanceIdHeaders()
        return await self.batch_update_form_data_by_instance_id_with_options_async(request, headers, runtime)

    def batch_update_form_data_by_instance_map_with_options(
        self,
        request: dingtalkyida__1__0_models.BatchUpdateFormDataByInstanceMapRequest,
        headers: dingtalkyida__1__0_models.BatchUpdateFormDataByInstanceMapHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.BatchUpdateFormDataByInstanceMapResponse:
        """
        @summary 通过表单实例数据批量更新表单实例
        
        @param request: BatchUpdateFormDataByInstanceMapRequest
        @param headers: BatchUpdateFormDataByInstanceMapHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchUpdateFormDataByInstanceMapResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.asynchronous_execution):
            body['asynchronousExecution'] = request.asynchronous_execution
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.ignore_empty):
            body['ignoreEmpty'] = request.ignore_empty
        if not UtilClient.is_unset(request.no_execute_expression):
            body['noExecuteExpression'] = request.no_execute_expression
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.update_form_data_json_map):
            body['updateFormDataJsonMap'] = request.update_form_data_json_map
        if not UtilClient.is_unset(request.use_latest_form_schema_version):
            body['useLatestFormSchemaVersion'] = request.use_latest_form_schema_version
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='BatchUpdateFormDataByInstanceMap',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/instances/datas',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.BatchUpdateFormDataByInstanceMapResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_update_form_data_by_instance_map_with_options_async(
        self,
        request: dingtalkyida__1__0_models.BatchUpdateFormDataByInstanceMapRequest,
        headers: dingtalkyida__1__0_models.BatchUpdateFormDataByInstanceMapHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.BatchUpdateFormDataByInstanceMapResponse:
        """
        @summary 通过表单实例数据批量更新表单实例
        
        @param request: BatchUpdateFormDataByInstanceMapRequest
        @param headers: BatchUpdateFormDataByInstanceMapHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchUpdateFormDataByInstanceMapResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.asynchronous_execution):
            body['asynchronousExecution'] = request.asynchronous_execution
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.ignore_empty):
            body['ignoreEmpty'] = request.ignore_empty
        if not UtilClient.is_unset(request.no_execute_expression):
            body['noExecuteExpression'] = request.no_execute_expression
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.update_form_data_json_map):
            body['updateFormDataJsonMap'] = request.update_form_data_json_map
        if not UtilClient.is_unset(request.use_latest_form_schema_version):
            body['useLatestFormSchemaVersion'] = request.use_latest_form_schema_version
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='BatchUpdateFormDataByInstanceMap',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/instances/datas',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.BatchUpdateFormDataByInstanceMapResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_update_form_data_by_instance_map(
        self,
        request: dingtalkyida__1__0_models.BatchUpdateFormDataByInstanceMapRequest,
    ) -> dingtalkyida__1__0_models.BatchUpdateFormDataByInstanceMapResponse:
        """
        @summary 通过表单实例数据批量更新表单实例
        
        @param request: BatchUpdateFormDataByInstanceMapRequest
        @return: BatchUpdateFormDataByInstanceMapResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.BatchUpdateFormDataByInstanceMapHeaders()
        return self.batch_update_form_data_by_instance_map_with_options(request, headers, runtime)

    async def batch_update_form_data_by_instance_map_async(
        self,
        request: dingtalkyida__1__0_models.BatchUpdateFormDataByInstanceMapRequest,
    ) -> dingtalkyida__1__0_models.BatchUpdateFormDataByInstanceMapResponse:
        """
        @summary 通过表单实例数据批量更新表单实例
        
        @param request: BatchUpdateFormDataByInstanceMapRequest
        @return: BatchUpdateFormDataByInstanceMapResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.BatchUpdateFormDataByInstanceMapHeaders()
        return await self.batch_update_form_data_by_instance_map_with_options_async(request, headers, runtime)

    def buy_authorization_order_with_options(
        self,
        request: dingtalkyida__1__0_models.BuyAuthorizationOrderRequest,
        headers: dingtalkyida__1__0_models.BuyAuthorizationOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.BuyAuthorizationOrderResponse:
        """
        @summary 多渠道新购(通过应用授权服务)
        
        @param request: BuyAuthorizationOrderRequest
        @param headers: BuyAuthorizationOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BuyAuthorizationOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.access_key):
            body['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.account_number):
            body['accountNumber'] = request.account_number
        if not UtilClient.is_unset(request.begin_time_gmt):
            body['beginTimeGMT'] = request.begin_time_gmt
        if not UtilClient.is_unset(request.caller_union_id):
            body['callerUnionId'] = request.caller_union_id
        if not UtilClient.is_unset(request.charge_type):
            body['chargeType'] = request.charge_type
        if not UtilClient.is_unset(request.commerce_type):
            body['commerceType'] = request.commerce_type
        if not UtilClient.is_unset(request.commodity_type):
            body['commodityType'] = request.commodity_type
        if not UtilClient.is_unset(request.end_time_gmt):
            body['endTimeGMT'] = request.end_time_gmt
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.instance_name):
            body['instanceName'] = request.instance_name
        if not UtilClient.is_unset(request.produce_code):
            body['produceCode'] = request.produce_code
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
            action='BuyAuthorizationOrder',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/appAuthorizations/order',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.BuyAuthorizationOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def buy_authorization_order_with_options_async(
        self,
        request: dingtalkyida__1__0_models.BuyAuthorizationOrderRequest,
        headers: dingtalkyida__1__0_models.BuyAuthorizationOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.BuyAuthorizationOrderResponse:
        """
        @summary 多渠道新购(通过应用授权服务)
        
        @param request: BuyAuthorizationOrderRequest
        @param headers: BuyAuthorizationOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BuyAuthorizationOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.access_key):
            body['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.account_number):
            body['accountNumber'] = request.account_number
        if not UtilClient.is_unset(request.begin_time_gmt):
            body['beginTimeGMT'] = request.begin_time_gmt
        if not UtilClient.is_unset(request.caller_union_id):
            body['callerUnionId'] = request.caller_union_id
        if not UtilClient.is_unset(request.charge_type):
            body['chargeType'] = request.charge_type
        if not UtilClient.is_unset(request.commerce_type):
            body['commerceType'] = request.commerce_type
        if not UtilClient.is_unset(request.commodity_type):
            body['commodityType'] = request.commodity_type
        if not UtilClient.is_unset(request.end_time_gmt):
            body['endTimeGMT'] = request.end_time_gmt
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.instance_name):
            body['instanceName'] = request.instance_name
        if not UtilClient.is_unset(request.produce_code):
            body['produceCode'] = request.produce_code
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
            action='BuyAuthorizationOrder',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/appAuthorizations/order',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.BuyAuthorizationOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def buy_authorization_order(
        self,
        request: dingtalkyida__1__0_models.BuyAuthorizationOrderRequest,
    ) -> dingtalkyida__1__0_models.BuyAuthorizationOrderResponse:
        """
        @summary 多渠道新购(通过应用授权服务)
        
        @param request: BuyAuthorizationOrderRequest
        @return: BuyAuthorizationOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.BuyAuthorizationOrderHeaders()
        return self.buy_authorization_order_with_options(request, headers, runtime)

    async def buy_authorization_order_async(
        self,
        request: dingtalkyida__1__0_models.BuyAuthorizationOrderRequest,
    ) -> dingtalkyida__1__0_models.BuyAuthorizationOrderResponse:
        """
        @summary 多渠道新购(通过应用授权服务)
        
        @param request: BuyAuthorizationOrderRequest
        @return: BuyAuthorizationOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.BuyAuthorizationOrderHeaders()
        return await self.buy_authorization_order_with_options_async(request, headers, runtime)

    def buy_fresh_order_with_options(
        self,
        request: dingtalkyida__1__0_models.BuyFreshOrderRequest,
        headers: dingtalkyida__1__0_models.BuyFreshOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.BuyFreshOrderResponse:
        """
        @summary 新购宜搭产品
        
        @param request: BuyFreshOrderRequest
        @param headers: BuyFreshOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BuyFreshOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.access_key):
            body['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.account_number):
            body['accountNumber'] = request.account_number
        if not UtilClient.is_unset(request.begin_time_gmt):
            body['beginTimeGMT'] = request.begin_time_gmt
        if not UtilClient.is_unset(request.caller_union_id):
            body['callerUnionId'] = request.caller_union_id
        if not UtilClient.is_unset(request.charge_type):
            body['chargeType'] = request.charge_type
        if not UtilClient.is_unset(request.commerce_type):
            body['commerceType'] = request.commerce_type
        if not UtilClient.is_unset(request.commodity_type):
            body['commodityType'] = request.commodity_type
        if not UtilClient.is_unset(request.end_time_gmt):
            body['endTimeGMT'] = request.end_time_gmt
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.instance_name):
            body['instanceName'] = request.instance_name
        if not UtilClient.is_unset(request.produce_code):
            body['produceCode'] = request.produce_code
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
            action='BuyFreshOrder',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/freshOrders',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.BuyFreshOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def buy_fresh_order_with_options_async(
        self,
        request: dingtalkyida__1__0_models.BuyFreshOrderRequest,
        headers: dingtalkyida__1__0_models.BuyFreshOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.BuyFreshOrderResponse:
        """
        @summary 新购宜搭产品
        
        @param request: BuyFreshOrderRequest
        @param headers: BuyFreshOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BuyFreshOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.access_key):
            body['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.account_number):
            body['accountNumber'] = request.account_number
        if not UtilClient.is_unset(request.begin_time_gmt):
            body['beginTimeGMT'] = request.begin_time_gmt
        if not UtilClient.is_unset(request.caller_union_id):
            body['callerUnionId'] = request.caller_union_id
        if not UtilClient.is_unset(request.charge_type):
            body['chargeType'] = request.charge_type
        if not UtilClient.is_unset(request.commerce_type):
            body['commerceType'] = request.commerce_type
        if not UtilClient.is_unset(request.commodity_type):
            body['commodityType'] = request.commodity_type
        if not UtilClient.is_unset(request.end_time_gmt):
            body['endTimeGMT'] = request.end_time_gmt
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.instance_name):
            body['instanceName'] = request.instance_name
        if not UtilClient.is_unset(request.produce_code):
            body['produceCode'] = request.produce_code
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
            action='BuyFreshOrder',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/freshOrders',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.BuyFreshOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def buy_fresh_order(
        self,
        request: dingtalkyida__1__0_models.BuyFreshOrderRequest,
    ) -> dingtalkyida__1__0_models.BuyFreshOrderResponse:
        """
        @summary 新购宜搭产品
        
        @param request: BuyFreshOrderRequest
        @return: BuyFreshOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.BuyFreshOrderHeaders()
        return self.buy_fresh_order_with_options(request, headers, runtime)

    async def buy_fresh_order_async(
        self,
        request: dingtalkyida__1__0_models.BuyFreshOrderRequest,
    ) -> dingtalkyida__1__0_models.BuyFreshOrderResponse:
        """
        @summary 新购宜搭产品
        
        @param request: BuyFreshOrderRequest
        @return: BuyFreshOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.BuyFreshOrderHeaders()
        return await self.buy_fresh_order_with_options_async(request, headers, runtime)

    def check_cloud_account_status_with_options(
        self,
        caller_uid: str,
        request: dingtalkyida__1__0_models.CheckCloudAccountStatusRequest,
        headers: dingtalkyida__1__0_models.CheckCloudAccountStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.CheckCloudAccountStatusResponse:
        """
        @summary 根据阿里云账号验证激活结果
        
        @param request: CheckCloudAccountStatusRequest
        @param headers: CheckCloudAccountStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CheckCloudAccountStatusResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
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
            action='CheckCloudAccountStatus',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/cloudAccountStatus/{caller_uid}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.CheckCloudAccountStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def check_cloud_account_status_with_options_async(
        self,
        caller_uid: str,
        request: dingtalkyida__1__0_models.CheckCloudAccountStatusRequest,
        headers: dingtalkyida__1__0_models.CheckCloudAccountStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.CheckCloudAccountStatusResponse:
        """
        @summary 根据阿里云账号验证激活结果
        
        @param request: CheckCloudAccountStatusRequest
        @param headers: CheckCloudAccountStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CheckCloudAccountStatusResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
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
            action='CheckCloudAccountStatus',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/cloudAccountStatus/{caller_uid}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.CheckCloudAccountStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def check_cloud_account_status(
        self,
        caller_uid: str,
        request: dingtalkyida__1__0_models.CheckCloudAccountStatusRequest,
    ) -> dingtalkyida__1__0_models.CheckCloudAccountStatusResponse:
        """
        @summary 根据阿里云账号验证激活结果
        
        @param request: CheckCloudAccountStatusRequest
        @return: CheckCloudAccountStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.CheckCloudAccountStatusHeaders()
        return self.check_cloud_account_status_with_options(caller_uid, request, headers, runtime)

    async def check_cloud_account_status_async(
        self,
        caller_uid: str,
        request: dingtalkyida__1__0_models.CheckCloudAccountStatusRequest,
    ) -> dingtalkyida__1__0_models.CheckCloudAccountStatusResponse:
        """
        @summary 根据阿里云账号验证激活结果
        
        @param request: CheckCloudAccountStatusRequest
        @return: CheckCloudAccountStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.CheckCloudAccountStatusHeaders()
        return await self.check_cloud_account_status_with_options_async(caller_uid, request, headers, runtime)

    def create_or_update_form_data_with_options(
        self,
        request: dingtalkyida__1__0_models.CreateOrUpdateFormDataRequest,
        headers: dingtalkyida__1__0_models.CreateOrUpdateFormDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.CreateOrUpdateFormDataResponse:
        """
        @summary 新增或更新表单实例
        
        @param request: CreateOrUpdateFormDataRequest
        @param headers: CreateOrUpdateFormDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateOrUpdateFormDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_data_json):
            body['formDataJson'] = request.form_data_json
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.no_execute_expression):
            body['noExecuteExpression'] = request.no_execute_expression
        if not UtilClient.is_unset(request.search_condition):
            body['searchCondition'] = request.search_condition
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='CreateOrUpdateFormData',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/instances/insertOrUpdate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.CreateOrUpdateFormDataResponse(),
            self.execute(params, req, runtime)
        )

    async def create_or_update_form_data_with_options_async(
        self,
        request: dingtalkyida__1__0_models.CreateOrUpdateFormDataRequest,
        headers: dingtalkyida__1__0_models.CreateOrUpdateFormDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.CreateOrUpdateFormDataResponse:
        """
        @summary 新增或更新表单实例
        
        @param request: CreateOrUpdateFormDataRequest
        @param headers: CreateOrUpdateFormDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateOrUpdateFormDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_data_json):
            body['formDataJson'] = request.form_data_json
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.no_execute_expression):
            body['noExecuteExpression'] = request.no_execute_expression
        if not UtilClient.is_unset(request.search_condition):
            body['searchCondition'] = request.search_condition
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='CreateOrUpdateFormData',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/instances/insertOrUpdate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.CreateOrUpdateFormDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_or_update_form_data(
        self,
        request: dingtalkyida__1__0_models.CreateOrUpdateFormDataRequest,
    ) -> dingtalkyida__1__0_models.CreateOrUpdateFormDataResponse:
        """
        @summary 新增或更新表单实例
        
        @param request: CreateOrUpdateFormDataRequest
        @return: CreateOrUpdateFormDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.CreateOrUpdateFormDataHeaders()
        return self.create_or_update_form_data_with_options(request, headers, runtime)

    async def create_or_update_form_data_async(
        self,
        request: dingtalkyida__1__0_models.CreateOrUpdateFormDataRequest,
    ) -> dingtalkyida__1__0_models.CreateOrUpdateFormDataResponse:
        """
        @summary 新增或更新表单实例
        
        @param request: CreateOrUpdateFormDataRequest
        @return: CreateOrUpdateFormDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.CreateOrUpdateFormDataHeaders()
        return await self.create_or_update_form_data_with_options_async(request, headers, runtime)

    def delete_form_data_with_options(
        self,
        request: dingtalkyida__1__0_models.DeleteFormDataRequest,
        headers: dingtalkyida__1__0_models.DeleteFormDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.DeleteFormDataResponse:
        """
        @summary 删除表单实例
        
        @param request: DeleteFormDataRequest
        @param headers: DeleteFormDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteFormDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_instance_id):
            query['formInstanceId'] = request.form_instance_id
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='DeleteFormData',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/instances',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.DeleteFormDataResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_form_data_with_options_async(
        self,
        request: dingtalkyida__1__0_models.DeleteFormDataRequest,
        headers: dingtalkyida__1__0_models.DeleteFormDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.DeleteFormDataResponse:
        """
        @summary 删除表单实例
        
        @param request: DeleteFormDataRequest
        @param headers: DeleteFormDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteFormDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_instance_id):
            query['formInstanceId'] = request.form_instance_id
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='DeleteFormData',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/instances',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.DeleteFormDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_form_data(
        self,
        request: dingtalkyida__1__0_models.DeleteFormDataRequest,
    ) -> dingtalkyida__1__0_models.DeleteFormDataResponse:
        """
        @summary 删除表单实例
        
        @param request: DeleteFormDataRequest
        @return: DeleteFormDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.DeleteFormDataHeaders()
        return self.delete_form_data_with_options(request, headers, runtime)

    async def delete_form_data_async(
        self,
        request: dingtalkyida__1__0_models.DeleteFormDataRequest,
    ) -> dingtalkyida__1__0_models.DeleteFormDataResponse:
        """
        @summary 删除表单实例
        
        @param request: DeleteFormDataRequest
        @return: DeleteFormDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.DeleteFormDataHeaders()
        return await self.delete_form_data_with_options_async(request, headers, runtime)

    def delete_instance_with_options(
        self,
        request: dingtalkyida__1__0_models.DeleteInstanceRequest,
        headers: dingtalkyida__1__0_models.DeleteInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.DeleteInstanceResponse:
        """
        @summary 删除流程实例
        
        @param request: DeleteInstanceRequest
        @param headers: DeleteInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteInstanceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.process_instance_id):
            query['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='DeleteInstance',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/processes/instances',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.DeleteInstanceResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_instance_with_options_async(
        self,
        request: dingtalkyida__1__0_models.DeleteInstanceRequest,
        headers: dingtalkyida__1__0_models.DeleteInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.DeleteInstanceResponse:
        """
        @summary 删除流程实例
        
        @param request: DeleteInstanceRequest
        @param headers: DeleteInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteInstanceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.process_instance_id):
            query['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='DeleteInstance',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/processes/instances',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.DeleteInstanceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_instance(
        self,
        request: dingtalkyida__1__0_models.DeleteInstanceRequest,
    ) -> dingtalkyida__1__0_models.DeleteInstanceResponse:
        """
        @summary 删除流程实例
        
        @param request: DeleteInstanceRequest
        @return: DeleteInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.DeleteInstanceHeaders()
        return self.delete_instance_with_options(request, headers, runtime)

    async def delete_instance_async(
        self,
        request: dingtalkyida__1__0_models.DeleteInstanceRequest,
    ) -> dingtalkyida__1__0_models.DeleteInstanceResponse:
        """
        @summary 删除流程实例
        
        @param request: DeleteInstanceRequest
        @return: DeleteInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.DeleteInstanceHeaders()
        return await self.delete_instance_with_options_async(request, headers, runtime)

    def delete_sequence_with_options(
        self,
        request: dingtalkyida__1__0_models.DeleteSequenceRequest,
        headers: dingtalkyida__1__0_models.DeleteSequenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.DeleteSequenceResponse:
        """
        @summary deleteSequence
        
        @param request: DeleteSequenceRequest
        @param headers: DeleteSequenceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteSequenceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.sequence):
            query['sequence'] = request.sequence
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='DeleteSequence',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/deleteSequence',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.DeleteSequenceResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_sequence_with_options_async(
        self,
        request: dingtalkyida__1__0_models.DeleteSequenceRequest,
        headers: dingtalkyida__1__0_models.DeleteSequenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.DeleteSequenceResponse:
        """
        @summary deleteSequence
        
        @param request: DeleteSequenceRequest
        @param headers: DeleteSequenceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteSequenceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.sequence):
            query['sequence'] = request.sequence
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='DeleteSequence',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/deleteSequence',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.DeleteSequenceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_sequence(
        self,
        request: dingtalkyida__1__0_models.DeleteSequenceRequest,
    ) -> dingtalkyida__1__0_models.DeleteSequenceResponse:
        """
        @summary deleteSequence
        
        @param request: DeleteSequenceRequest
        @return: DeleteSequenceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.DeleteSequenceHeaders()
        return self.delete_sequence_with_options(request, headers, runtime)

    async def delete_sequence_async(
        self,
        request: dingtalkyida__1__0_models.DeleteSequenceRequest,
    ) -> dingtalkyida__1__0_models.DeleteSequenceResponse:
        """
        @summary deleteSequence
        
        @param request: DeleteSequenceRequest
        @return: DeleteSequenceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.DeleteSequenceHeaders()
        return await self.delete_sequence_with_options_async(request, headers, runtime)

    def deploy_function_callback_with_options(
        self,
        request: dingtalkyida__1__0_models.DeployFunctionCallbackRequest,
        headers: dingtalkyida__1__0_models.DeployFunctionCallbackHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.DeployFunctionCallbackResponse:
        """
        @summary 云开发平台函数计算部署完成回调宜搭
        
        @param request: DeployFunctionCallbackRequest
        @param headers: DeployFunctionCallbackHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeployFunctionCallbackResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.custom_domain):
            body['customDomain'] = request.custom_domain
        if not UtilClient.is_unset(request.deploy_stage):
            body['deployStage'] = request.deploy_stage
        if not UtilClient.is_unset(request.gate_way_app_key):
            body['gateWayAppKey'] = request.gate_way_app_key
        if not UtilClient.is_unset(request.gate_way_app_secret):
            body['gateWayAppSecret'] = request.gate_way_app_secret
        if not UtilClient.is_unset(request.gate_way_domain):
            body['gateWayDomain'] = request.gate_way_domain
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
            action='DeployFunctionCallback',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/functionComputeConnectors/completeDeployments/notify',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.DeployFunctionCallbackResponse(),
            self.execute(params, req, runtime)
        )

    async def deploy_function_callback_with_options_async(
        self,
        request: dingtalkyida__1__0_models.DeployFunctionCallbackRequest,
        headers: dingtalkyida__1__0_models.DeployFunctionCallbackHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.DeployFunctionCallbackResponse:
        """
        @summary 云开发平台函数计算部署完成回调宜搭
        
        @param request: DeployFunctionCallbackRequest
        @param headers: DeployFunctionCallbackHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeployFunctionCallbackResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.custom_domain):
            body['customDomain'] = request.custom_domain
        if not UtilClient.is_unset(request.deploy_stage):
            body['deployStage'] = request.deploy_stage
        if not UtilClient.is_unset(request.gate_way_app_key):
            body['gateWayAppKey'] = request.gate_way_app_key
        if not UtilClient.is_unset(request.gate_way_app_secret):
            body['gateWayAppSecret'] = request.gate_way_app_secret
        if not UtilClient.is_unset(request.gate_way_domain):
            body['gateWayDomain'] = request.gate_way_domain
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
            action='DeployFunctionCallback',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/functionComputeConnectors/completeDeployments/notify',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.DeployFunctionCallbackResponse(),
            await self.execute_async(params, req, runtime)
        )

    def deploy_function_callback(
        self,
        request: dingtalkyida__1__0_models.DeployFunctionCallbackRequest,
    ) -> dingtalkyida__1__0_models.DeployFunctionCallbackResponse:
        """
        @summary 云开发平台函数计算部署完成回调宜搭
        
        @param request: DeployFunctionCallbackRequest
        @return: DeployFunctionCallbackResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.DeployFunctionCallbackHeaders()
        return self.deploy_function_callback_with_options(request, headers, runtime)

    async def deploy_function_callback_async(
        self,
        request: dingtalkyida__1__0_models.DeployFunctionCallbackRequest,
    ) -> dingtalkyida__1__0_models.DeployFunctionCallbackResponse:
        """
        @summary 云开发平台函数计算部署完成回调宜搭
        
        @param request: DeployFunctionCallbackRequest
        @return: DeployFunctionCallbackResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.DeployFunctionCallbackHeaders()
        return await self.deploy_function_callback_with_options_async(request, headers, runtime)

    def execute_batch_task_with_options(
        self,
        request: dingtalkyida__1__0_models.ExecuteBatchTaskRequest,
        headers: dingtalkyida__1__0_models.ExecuteBatchTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ExecuteBatchTaskResponse:
        """
        @summary 批量审批
        
        @param request: ExecuteBatchTaskRequest
        @param headers: ExecuteBatchTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExecuteBatchTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.out_result):
            body['outResult'] = request.out_result
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.task_information_list):
            body['taskInformationList'] = request.task_information_list
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='ExecuteBatchTask',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/tasks/batches/execute',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ExecuteBatchTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def execute_batch_task_with_options_async(
        self,
        request: dingtalkyida__1__0_models.ExecuteBatchTaskRequest,
        headers: dingtalkyida__1__0_models.ExecuteBatchTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ExecuteBatchTaskResponse:
        """
        @summary 批量审批
        
        @param request: ExecuteBatchTaskRequest
        @param headers: ExecuteBatchTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExecuteBatchTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.out_result):
            body['outResult'] = request.out_result
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.task_information_list):
            body['taskInformationList'] = request.task_information_list
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='ExecuteBatchTask',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/tasks/batches/execute',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ExecuteBatchTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def execute_batch_task(
        self,
        request: dingtalkyida__1__0_models.ExecuteBatchTaskRequest,
    ) -> dingtalkyida__1__0_models.ExecuteBatchTaskResponse:
        """
        @summary 批量审批
        
        @param request: ExecuteBatchTaskRequest
        @return: ExecuteBatchTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ExecuteBatchTaskHeaders()
        return self.execute_batch_task_with_options(request, headers, runtime)

    async def execute_batch_task_async(
        self,
        request: dingtalkyida__1__0_models.ExecuteBatchTaskRequest,
    ) -> dingtalkyida__1__0_models.ExecuteBatchTaskResponse:
        """
        @summary 批量审批
        
        @param request: ExecuteBatchTaskRequest
        @return: ExecuteBatchTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ExecuteBatchTaskHeaders()
        return await self.execute_batch_task_with_options_async(request, headers, runtime)

    def execute_custom_api_with_options(
        self,
        request: dingtalkyida__1__0_models.ExecuteCustomApiRequest,
        headers: dingtalkyida__1__0_models.ExecuteCustomApiHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ExecuteCustomApiResponse:
        """
        @summary 执行用户自定义的API接口
        
        @param request: ExecuteCustomApiRequest
        @param headers: ExecuteCustomApiHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExecuteCustomApiResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.data):
            query['data'] = request.data
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.service_id):
            query['serviceId'] = request.service_id
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='ExecuteCustomApi',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/customApi/execute',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ExecuteCustomApiResponse(),
            self.execute(params, req, runtime)
        )

    async def execute_custom_api_with_options_async(
        self,
        request: dingtalkyida__1__0_models.ExecuteCustomApiRequest,
        headers: dingtalkyida__1__0_models.ExecuteCustomApiHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ExecuteCustomApiResponse:
        """
        @summary 执行用户自定义的API接口
        
        @param request: ExecuteCustomApiRequest
        @param headers: ExecuteCustomApiHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExecuteCustomApiResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.data):
            query['data'] = request.data
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.service_id):
            query['serviceId'] = request.service_id
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='ExecuteCustomApi',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/customApi/execute',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ExecuteCustomApiResponse(),
            await self.execute_async(params, req, runtime)
        )

    def execute_custom_api(
        self,
        request: dingtalkyida__1__0_models.ExecuteCustomApiRequest,
    ) -> dingtalkyida__1__0_models.ExecuteCustomApiResponse:
        """
        @summary 执行用户自定义的API接口
        
        @param request: ExecuteCustomApiRequest
        @return: ExecuteCustomApiResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ExecuteCustomApiHeaders()
        return self.execute_custom_api_with_options(request, headers, runtime)

    async def execute_custom_api_async(
        self,
        request: dingtalkyida__1__0_models.ExecuteCustomApiRequest,
    ) -> dingtalkyida__1__0_models.ExecuteCustomApiResponse:
        """
        @summary 执行用户自定义的API接口
        
        @param request: ExecuteCustomApiRequest
        @return: ExecuteCustomApiResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ExecuteCustomApiHeaders()
        return await self.execute_custom_api_with_options_async(request, headers, runtime)

    def execute_platform_task_with_options(
        self,
        request: dingtalkyida__1__0_models.ExecutePlatformTaskRequest,
        headers: dingtalkyida__1__0_models.ExecutePlatformTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ExecutePlatformTaskResponse:
        """
        @summary 执行宜搭平台的审批任务
        
        @param request: ExecutePlatformTaskRequest
        @param headers: ExecutePlatformTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExecutePlatformTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_data_json):
            body['formDataJson'] = request.form_data_json
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.no_execute_expressions):
            body['noExecuteExpressions'] = request.no_execute_expressions
        if not UtilClient.is_unset(request.out_result):
            body['outResult'] = request.out_result
        if not UtilClient.is_unset(request.process_instance_id):
            body['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='ExecutePlatformTask',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/tasks/platformTasks/execute',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ExecutePlatformTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def execute_platform_task_with_options_async(
        self,
        request: dingtalkyida__1__0_models.ExecutePlatformTaskRequest,
        headers: dingtalkyida__1__0_models.ExecutePlatformTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ExecutePlatformTaskResponse:
        """
        @summary 执行宜搭平台的审批任务
        
        @param request: ExecutePlatformTaskRequest
        @param headers: ExecutePlatformTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExecutePlatformTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_data_json):
            body['formDataJson'] = request.form_data_json
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.no_execute_expressions):
            body['noExecuteExpressions'] = request.no_execute_expressions
        if not UtilClient.is_unset(request.out_result):
            body['outResult'] = request.out_result
        if not UtilClient.is_unset(request.process_instance_id):
            body['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='ExecutePlatformTask',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/tasks/platformTasks/execute',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ExecutePlatformTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def execute_platform_task(
        self,
        request: dingtalkyida__1__0_models.ExecutePlatformTaskRequest,
    ) -> dingtalkyida__1__0_models.ExecutePlatformTaskResponse:
        """
        @summary 执行宜搭平台的审批任务
        
        @param request: ExecutePlatformTaskRequest
        @return: ExecutePlatformTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ExecutePlatformTaskHeaders()
        return self.execute_platform_task_with_options(request, headers, runtime)

    async def execute_platform_task_async(
        self,
        request: dingtalkyida__1__0_models.ExecutePlatformTaskRequest,
    ) -> dingtalkyida__1__0_models.ExecutePlatformTaskResponse:
        """
        @summary 执行宜搭平台的审批任务
        
        @param request: ExecutePlatformTaskRequest
        @return: ExecutePlatformTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ExecutePlatformTaskHeaders()
        return await self.execute_platform_task_with_options_async(request, headers, runtime)

    def execute_task_with_options(
        self,
        request: dingtalkyida__1__0_models.ExecuteTaskRequest,
        headers: dingtalkyida__1__0_models.ExecuteTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ExecuteTaskResponse:
        """
        @summary 执行审批任务
        
        @param request: ExecuteTaskRequest
        @param headers: ExecuteTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExecuteTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.digital_sign_url):
            body['digitalSignUrl'] = request.digital_sign_url
        if not UtilClient.is_unset(request.form_data_json):
            body['formDataJson'] = request.form_data_json
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.no_execute_expressions):
            body['noExecuteExpressions'] = request.no_execute_expressions
        if not UtilClient.is_unset(request.out_result):
            body['outResult'] = request.out_result
        if not UtilClient.is_unset(request.process_instance_id):
            body['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.task_id):
            body['taskId'] = request.task_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='ExecuteTask',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/tasks/execute',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ExecuteTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def execute_task_with_options_async(
        self,
        request: dingtalkyida__1__0_models.ExecuteTaskRequest,
        headers: dingtalkyida__1__0_models.ExecuteTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ExecuteTaskResponse:
        """
        @summary 执行审批任务
        
        @param request: ExecuteTaskRequest
        @param headers: ExecuteTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExecuteTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.digital_sign_url):
            body['digitalSignUrl'] = request.digital_sign_url
        if not UtilClient.is_unset(request.form_data_json):
            body['formDataJson'] = request.form_data_json
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.no_execute_expressions):
            body['noExecuteExpressions'] = request.no_execute_expressions
        if not UtilClient.is_unset(request.out_result):
            body['outResult'] = request.out_result
        if not UtilClient.is_unset(request.process_instance_id):
            body['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.task_id):
            body['taskId'] = request.task_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='ExecuteTask',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/tasks/execute',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ExecuteTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def execute_task(
        self,
        request: dingtalkyida__1__0_models.ExecuteTaskRequest,
    ) -> dingtalkyida__1__0_models.ExecuteTaskResponse:
        """
        @summary 执行审批任务
        
        @param request: ExecuteTaskRequest
        @return: ExecuteTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ExecuteTaskHeaders()
        return self.execute_task_with_options(request, headers, runtime)

    async def execute_task_async(
        self,
        request: dingtalkyida__1__0_models.ExecuteTaskRequest,
    ) -> dingtalkyida__1__0_models.ExecuteTaskResponse:
        """
        @summary 执行审批任务
        
        @param request: ExecuteTaskRequest
        @return: ExecuteTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ExecuteTaskHeaders()
        return await self.execute_task_with_options_async(request, headers, runtime)

    def expire_commodity_with_options(
        self,
        request: dingtalkyida__1__0_models.ExpireCommodityRequest,
        headers: dingtalkyida__1__0_models.ExpireCommodityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ExpireCommodityResponse:
        """
        @summary 多渠道到期
        
        @param request: ExpireCommodityRequest
        @param headers: ExpireCommodityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExpireCommodityResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
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
            action='ExpireCommodity',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/appAuth/commodities/expire',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ExpireCommodityResponse(),
            self.execute(params, req, runtime)
        )

    async def expire_commodity_with_options_async(
        self,
        request: dingtalkyida__1__0_models.ExpireCommodityRequest,
        headers: dingtalkyida__1__0_models.ExpireCommodityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ExpireCommodityResponse:
        """
        @summary 多渠道到期
        
        @param request: ExpireCommodityRequest
        @param headers: ExpireCommodityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExpireCommodityResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
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
            action='ExpireCommodity',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/appAuth/commodities/expire',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ExpireCommodityResponse(),
            await self.execute_async(params, req, runtime)
        )

    def expire_commodity(
        self,
        request: dingtalkyida__1__0_models.ExpireCommodityRequest,
    ) -> dingtalkyida__1__0_models.ExpireCommodityResponse:
        """
        @summary 多渠道到期
        
        @param request: ExpireCommodityRequest
        @return: ExpireCommodityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ExpireCommodityHeaders()
        return self.expire_commodity_with_options(request, headers, runtime)

    async def expire_commodity_async(
        self,
        request: dingtalkyida__1__0_models.ExpireCommodityRequest,
    ) -> dingtalkyida__1__0_models.ExpireCommodityResponse:
        """
        @summary 多渠道到期
        
        @param request: ExpireCommodityRequest
        @return: ExpireCommodityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ExpireCommodityHeaders()
        return await self.expire_commodity_with_options_async(request, headers, runtime)

    def get_activation_code_by_caller_union_id_with_options(
        self,
        caller_uid: str,
        request: dingtalkyida__1__0_models.GetActivationCodeByCallerUnionIdRequest,
        headers: dingtalkyida__1__0_models.GetActivationCodeByCallerUnionIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetActivationCodeByCallerUnionIdResponse:
        """
        @summary 根据阿里云账号获取激活码
        
        @param request: GetActivationCodeByCallerUnionIdRequest
        @param headers: GetActivationCodeByCallerUnionIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetActivationCodeByCallerUnionIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
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
            action='GetActivationCodeByCallerUnionId',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/applications/activationCodes/{caller_uid}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetActivationCodeByCallerUnionIdResponse(),
            self.execute(params, req, runtime)
        )

    async def get_activation_code_by_caller_union_id_with_options_async(
        self,
        caller_uid: str,
        request: dingtalkyida__1__0_models.GetActivationCodeByCallerUnionIdRequest,
        headers: dingtalkyida__1__0_models.GetActivationCodeByCallerUnionIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetActivationCodeByCallerUnionIdResponse:
        """
        @summary 根据阿里云账号获取激活码
        
        @param request: GetActivationCodeByCallerUnionIdRequest
        @param headers: GetActivationCodeByCallerUnionIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetActivationCodeByCallerUnionIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
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
            action='GetActivationCodeByCallerUnionId',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/applications/activationCodes/{caller_uid}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetActivationCodeByCallerUnionIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_activation_code_by_caller_union_id(
        self,
        caller_uid: str,
        request: dingtalkyida__1__0_models.GetActivationCodeByCallerUnionIdRequest,
    ) -> dingtalkyida__1__0_models.GetActivationCodeByCallerUnionIdResponse:
        """
        @summary 根据阿里云账号获取激活码
        
        @param request: GetActivationCodeByCallerUnionIdRequest
        @return: GetActivationCodeByCallerUnionIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetActivationCodeByCallerUnionIdHeaders()
        return self.get_activation_code_by_caller_union_id_with_options(caller_uid, request, headers, runtime)

    async def get_activation_code_by_caller_union_id_async(
        self,
        caller_uid: str,
        request: dingtalkyida__1__0_models.GetActivationCodeByCallerUnionIdRequest,
    ) -> dingtalkyida__1__0_models.GetActivationCodeByCallerUnionIdResponse:
        """
        @summary 根据阿里云账号获取激活码
        
        @param request: GetActivationCodeByCallerUnionIdRequest
        @return: GetActivationCodeByCallerUnionIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetActivationCodeByCallerUnionIdHeaders()
        return await self.get_activation_code_by_caller_union_id_with_options_async(caller_uid, request, headers, runtime)

    def get_activity_button_list_with_options(
        self,
        app_type: str,
        process_code: str,
        activity_id: str,
        request: dingtalkyida__1__0_models.GetActivityButtonListRequest,
        headers: dingtalkyida__1__0_models.GetActivityButtonListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetActivityButtonListResponse:
        """
        @summary 获取流程实例可操作功能列表
        
        @param request: GetActivityButtonListRequest
        @param headers: GetActivityButtonListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetActivityButtonListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='GetActivityButtonList',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/processDefinitions/buttons/{app_type}/{process_code}/{activity_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetActivityButtonListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_activity_button_list_with_options_async(
        self,
        app_type: str,
        process_code: str,
        activity_id: str,
        request: dingtalkyida__1__0_models.GetActivityButtonListRequest,
        headers: dingtalkyida__1__0_models.GetActivityButtonListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetActivityButtonListResponse:
        """
        @summary 获取流程实例可操作功能列表
        
        @param request: GetActivityButtonListRequest
        @param headers: GetActivityButtonListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetActivityButtonListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='GetActivityButtonList',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/processDefinitions/buttons/{app_type}/{process_code}/{activity_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetActivityButtonListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_activity_button_list(
        self,
        app_type: str,
        process_code: str,
        activity_id: str,
        request: dingtalkyida__1__0_models.GetActivityButtonListRequest,
    ) -> dingtalkyida__1__0_models.GetActivityButtonListResponse:
        """
        @summary 获取流程实例可操作功能列表
        
        @param request: GetActivityButtonListRequest
        @return: GetActivityButtonListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetActivityButtonListHeaders()
        return self.get_activity_button_list_with_options(app_type, process_code, activity_id, request, headers, runtime)

    async def get_activity_button_list_async(
        self,
        app_type: str,
        process_code: str,
        activity_id: str,
        request: dingtalkyida__1__0_models.GetActivityButtonListRequest,
    ) -> dingtalkyida__1__0_models.GetActivityButtonListResponse:
        """
        @summary 获取流程实例可操作功能列表
        
        @param request: GetActivityButtonListRequest
        @return: GetActivityButtonListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetActivityButtonListHeaders()
        return await self.get_activity_button_list_with_options_async(app_type, process_code, activity_id, request, headers, runtime)

    def get_activity_list_with_options(
        self,
        request: dingtalkyida__1__0_models.GetActivityListRequest,
        headers: dingtalkyida__1__0_models.GetActivityListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetActivityListResponse:
        """
        @summary 获取流程设计的节点信息
        
        @param request: GetActivityListRequest
        @param headers: GetActivityListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetActivityListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.process_code):
            query['processCode'] = request.process_code
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='GetActivityList',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/processes/activities',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetActivityListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_activity_list_with_options_async(
        self,
        request: dingtalkyida__1__0_models.GetActivityListRequest,
        headers: dingtalkyida__1__0_models.GetActivityListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetActivityListResponse:
        """
        @summary 获取流程设计的节点信息
        
        @param request: GetActivityListRequest
        @param headers: GetActivityListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetActivityListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.process_code):
            query['processCode'] = request.process_code
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='GetActivityList',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/processes/activities',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetActivityListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_activity_list(
        self,
        request: dingtalkyida__1__0_models.GetActivityListRequest,
    ) -> dingtalkyida__1__0_models.GetActivityListResponse:
        """
        @summary 获取流程设计的节点信息
        
        @param request: GetActivityListRequest
        @return: GetActivityListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetActivityListHeaders()
        return self.get_activity_list_with_options(request, headers, runtime)

    async def get_activity_list_async(
        self,
        request: dingtalkyida__1__0_models.GetActivityListRequest,
    ) -> dingtalkyida__1__0_models.GetActivityListResponse:
        """
        @summary 获取流程设计的节点信息
        
        @param request: GetActivityListRequest
        @return: GetActivityListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetActivityListHeaders()
        return await self.get_activity_list_with_options_async(request, headers, runtime)

    def get_all_auth_cubes_with_options(
        self,
        request: dingtalkyida__1__0_models.GetAllAuthCubesRequest,
        headers: dingtalkyida__1__0_models.GetAllAuthCubesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetAllAuthCubesResponse:
        """
        @summary 查询表单的接口，支持分页、表单名称模糊查询
        
        @param request: GetAllAuthCubesRequest
        @param headers: GetAllAuthCubesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAllAuthCubesResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.keywords):
            body['keywords'] = request.keywords
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='GetAllAuthCubes',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/metadata/allAuthCubes/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetAllAuthCubesResponse(),
            self.execute(params, req, runtime)
        )

    async def get_all_auth_cubes_with_options_async(
        self,
        request: dingtalkyida__1__0_models.GetAllAuthCubesRequest,
        headers: dingtalkyida__1__0_models.GetAllAuthCubesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetAllAuthCubesResponse:
        """
        @summary 查询表单的接口，支持分页、表单名称模糊查询
        
        @param request: GetAllAuthCubesRequest
        @param headers: GetAllAuthCubesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAllAuthCubesResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.keywords):
            body['keywords'] = request.keywords
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='GetAllAuthCubes',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/metadata/allAuthCubes/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetAllAuthCubesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_all_auth_cubes(
        self,
        request: dingtalkyida__1__0_models.GetAllAuthCubesRequest,
    ) -> dingtalkyida__1__0_models.GetAllAuthCubesResponse:
        """
        @summary 查询表单的接口，支持分页、表单名称模糊查询
        
        @param request: GetAllAuthCubesRequest
        @return: GetAllAuthCubesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetAllAuthCubesHeaders()
        return self.get_all_auth_cubes_with_options(request, headers, runtime)

    async def get_all_auth_cubes_async(
        self,
        request: dingtalkyida__1__0_models.GetAllAuthCubesRequest,
    ) -> dingtalkyida__1__0_models.GetAllAuthCubesResponse:
        """
        @summary 查询表单的接口，支持分页、表单名称模糊查询
        
        @param request: GetAllAuthCubesRequest
        @return: GetAllAuthCubesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetAllAuthCubesHeaders()
        return await self.get_all_auth_cubes_with_options_async(request, headers, runtime)

    def get_application_authorization_service_platform_resource_with_options(
        self,
        request: dingtalkyida__1__0_models.GetApplicationAuthorizationServicePlatformResourceRequest,
        headers: dingtalkyida__1__0_models.GetApplicationAuthorizationServicePlatformResourceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetApplicationAuthorizationServicePlatformResourceResponse:
        """
        @summary 多渠道平台概览接口
        
        @param request: GetApplicationAuthorizationServicePlatformResourceRequest
        @param headers: GetApplicationAuthorizationServicePlatformResourceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetApplicationAuthorizationServicePlatformResourceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
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
            action='GetApplicationAuthorizationServicePlatformResource',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/authorization/platformResources',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetApplicationAuthorizationServicePlatformResourceResponse(),
            self.execute(params, req, runtime)
        )

    async def get_application_authorization_service_platform_resource_with_options_async(
        self,
        request: dingtalkyida__1__0_models.GetApplicationAuthorizationServicePlatformResourceRequest,
        headers: dingtalkyida__1__0_models.GetApplicationAuthorizationServicePlatformResourceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetApplicationAuthorizationServicePlatformResourceResponse:
        """
        @summary 多渠道平台概览接口
        
        @param request: GetApplicationAuthorizationServicePlatformResourceRequest
        @param headers: GetApplicationAuthorizationServicePlatformResourceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetApplicationAuthorizationServicePlatformResourceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
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
            action='GetApplicationAuthorizationServicePlatformResource',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/authorization/platformResources',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetApplicationAuthorizationServicePlatformResourceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_application_authorization_service_platform_resource(
        self,
        request: dingtalkyida__1__0_models.GetApplicationAuthorizationServicePlatformResourceRequest,
    ) -> dingtalkyida__1__0_models.GetApplicationAuthorizationServicePlatformResourceResponse:
        """
        @summary 多渠道平台概览接口
        
        @param request: GetApplicationAuthorizationServicePlatformResourceRequest
        @return: GetApplicationAuthorizationServicePlatformResourceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetApplicationAuthorizationServicePlatformResourceHeaders()
        return self.get_application_authorization_service_platform_resource_with_options(request, headers, runtime)

    async def get_application_authorization_service_platform_resource_async(
        self,
        request: dingtalkyida__1__0_models.GetApplicationAuthorizationServicePlatformResourceRequest,
    ) -> dingtalkyida__1__0_models.GetApplicationAuthorizationServicePlatformResourceResponse:
        """
        @summary 多渠道平台概览接口
        
        @param request: GetApplicationAuthorizationServicePlatformResourceRequest
        @return: GetApplicationAuthorizationServicePlatformResourceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetApplicationAuthorizationServicePlatformResourceHeaders()
        return await self.get_application_authorization_service_platform_resource_with_options_async(request, headers, runtime)

    def get_auto_flow_log_detail_with_options(
        self,
        request: dingtalkyida__1__0_models.GetAutoFlowLogDetailRequest,
        headers: dingtalkyida__1__0_models.GetAutoFlowLogDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetAutoFlowLogDetailResponse:
        """
        @summary 获取自动化流日志详情
        
        @param request: GetAutoFlowLogDetailRequest
        @param headers: GetAutoFlowLogDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAutoFlowLogDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.proc_instance_id):
            query['procInstanceId'] = request.proc_instance_id
        if not UtilClient.is_unset(request.token):
            query['token'] = request.token
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
            action='GetAutoFlowLogDetail',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/logs/automations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetAutoFlowLogDetailResponse(),
            self.execute(params, req, runtime)
        )

    async def get_auto_flow_log_detail_with_options_async(
        self,
        request: dingtalkyida__1__0_models.GetAutoFlowLogDetailRequest,
        headers: dingtalkyida__1__0_models.GetAutoFlowLogDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetAutoFlowLogDetailResponse:
        """
        @summary 获取自动化流日志详情
        
        @param request: GetAutoFlowLogDetailRequest
        @param headers: GetAutoFlowLogDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAutoFlowLogDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.proc_instance_id):
            query['procInstanceId'] = request.proc_instance_id
        if not UtilClient.is_unset(request.token):
            query['token'] = request.token
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
            action='GetAutoFlowLogDetail',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/logs/automations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetAutoFlowLogDetailResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_auto_flow_log_detail(
        self,
        request: dingtalkyida__1__0_models.GetAutoFlowLogDetailRequest,
    ) -> dingtalkyida__1__0_models.GetAutoFlowLogDetailResponse:
        """
        @summary 获取自动化流日志详情
        
        @param request: GetAutoFlowLogDetailRequest
        @return: GetAutoFlowLogDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetAutoFlowLogDetailHeaders()
        return self.get_auto_flow_log_detail_with_options(request, headers, runtime)

    async def get_auto_flow_log_detail_async(
        self,
        request: dingtalkyida__1__0_models.GetAutoFlowLogDetailRequest,
    ) -> dingtalkyida__1__0_models.GetAutoFlowLogDetailResponse:
        """
        @summary 获取自动化流日志详情
        
        @param request: GetAutoFlowLogDetailRequest
        @return: GetAutoFlowLogDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetAutoFlowLogDetailHeaders()
        return await self.get_auto_flow_log_detail_with_options_async(request, headers, runtime)

    def get_corp_accomplishment_tasks_with_options(
        self,
        corp_id: str,
        user_id: str,
        request: dingtalkyida__1__0_models.GetCorpAccomplishmentTasksRequest,
        headers: dingtalkyida__1__0_models.GetCorpAccomplishmentTasksHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetCorpAccomplishmentTasksResponse:
        """
        @summary 查询已完成任务列表
        
        @param request: GetCorpAccomplishmentTasksRequest
        @param headers: GetCorpAccomplishmentTasksHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCorpAccomplishmentTasksResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_types):
            query['appTypes'] = request.app_types
        if not UtilClient.is_unset(request.create_from_time_gmt):
            query['createFromTimeGMT'] = request.create_from_time_gmt
        if not UtilClient.is_unset(request.create_to_time_gmt):
            query['createToTimeGMT'] = request.create_to_time_gmt
        if not UtilClient.is_unset(request.keyword):
            query['keyword'] = request.keyword
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.process_codes):
            query['processCodes'] = request.process_codes
        if not UtilClient.is_unset(request.token):
            query['token'] = request.token
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
            action='GetCorpAccomplishmentTasks',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/tasks/completedTasks/{corp_id}/{user_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetCorpAccomplishmentTasksResponse(),
            self.execute(params, req, runtime)
        )

    async def get_corp_accomplishment_tasks_with_options_async(
        self,
        corp_id: str,
        user_id: str,
        request: dingtalkyida__1__0_models.GetCorpAccomplishmentTasksRequest,
        headers: dingtalkyida__1__0_models.GetCorpAccomplishmentTasksHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetCorpAccomplishmentTasksResponse:
        """
        @summary 查询已完成任务列表
        
        @param request: GetCorpAccomplishmentTasksRequest
        @param headers: GetCorpAccomplishmentTasksHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCorpAccomplishmentTasksResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_types):
            query['appTypes'] = request.app_types
        if not UtilClient.is_unset(request.create_from_time_gmt):
            query['createFromTimeGMT'] = request.create_from_time_gmt
        if not UtilClient.is_unset(request.create_to_time_gmt):
            query['createToTimeGMT'] = request.create_to_time_gmt
        if not UtilClient.is_unset(request.keyword):
            query['keyword'] = request.keyword
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.process_codes):
            query['processCodes'] = request.process_codes
        if not UtilClient.is_unset(request.token):
            query['token'] = request.token
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
            action='GetCorpAccomplishmentTasks',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/tasks/completedTasks/{corp_id}/{user_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetCorpAccomplishmentTasksResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_corp_accomplishment_tasks(
        self,
        corp_id: str,
        user_id: str,
        request: dingtalkyida__1__0_models.GetCorpAccomplishmentTasksRequest,
    ) -> dingtalkyida__1__0_models.GetCorpAccomplishmentTasksResponse:
        """
        @summary 查询已完成任务列表
        
        @param request: GetCorpAccomplishmentTasksRequest
        @return: GetCorpAccomplishmentTasksResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetCorpAccomplishmentTasksHeaders()
        return self.get_corp_accomplishment_tasks_with_options(corp_id, user_id, request, headers, runtime)

    async def get_corp_accomplishment_tasks_async(
        self,
        corp_id: str,
        user_id: str,
        request: dingtalkyida__1__0_models.GetCorpAccomplishmentTasksRequest,
    ) -> dingtalkyida__1__0_models.GetCorpAccomplishmentTasksResponse:
        """
        @summary 查询已完成任务列表
        
        @param request: GetCorpAccomplishmentTasksRequest
        @return: GetCorpAccomplishmentTasksResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetCorpAccomplishmentTasksHeaders()
        return await self.get_corp_accomplishment_tasks_with_options_async(corp_id, user_id, request, headers, runtime)

    def get_corp_level_by_account_id_with_options(
        self,
        request: dingtalkyida__1__0_models.GetCorpLevelByAccountIdRequest,
        headers: dingtalkyida__1__0_models.GetCorpLevelByAccountIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetCorpLevelByAccountIdResponse:
        """
        @summary 根据accountId获取企业等级
        
        @param request: GetCorpLevelByAccountIdRequest
        @param headers: GetCorpLevelByAccountIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCorpLevelByAccountIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.account_id):
            query['accountId'] = request.account_id
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
            action='GetCorpLevelByAccountId',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/corpLevel',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetCorpLevelByAccountIdResponse(),
            self.execute(params, req, runtime)
        )

    async def get_corp_level_by_account_id_with_options_async(
        self,
        request: dingtalkyida__1__0_models.GetCorpLevelByAccountIdRequest,
        headers: dingtalkyida__1__0_models.GetCorpLevelByAccountIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetCorpLevelByAccountIdResponse:
        """
        @summary 根据accountId获取企业等级
        
        @param request: GetCorpLevelByAccountIdRequest
        @param headers: GetCorpLevelByAccountIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCorpLevelByAccountIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.account_id):
            query['accountId'] = request.account_id
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
            action='GetCorpLevelByAccountId',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/corpLevel',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetCorpLevelByAccountIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_corp_level_by_account_id(
        self,
        request: dingtalkyida__1__0_models.GetCorpLevelByAccountIdRequest,
    ) -> dingtalkyida__1__0_models.GetCorpLevelByAccountIdResponse:
        """
        @summary 根据accountId获取企业等级
        
        @param request: GetCorpLevelByAccountIdRequest
        @return: GetCorpLevelByAccountIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetCorpLevelByAccountIdHeaders()
        return self.get_corp_level_by_account_id_with_options(request, headers, runtime)

    async def get_corp_level_by_account_id_async(
        self,
        request: dingtalkyida__1__0_models.GetCorpLevelByAccountIdRequest,
    ) -> dingtalkyida__1__0_models.GetCorpLevelByAccountIdResponse:
        """
        @summary 根据accountId获取企业等级
        
        @param request: GetCorpLevelByAccountIdRequest
        @return: GetCorpLevelByAccountIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetCorpLevelByAccountIdHeaders()
        return await self.get_corp_level_by_account_id_with_options_async(request, headers, runtime)

    def get_corp_tasks_with_options(
        self,
        request: dingtalkyida__1__0_models.GetCorpTasksRequest,
        headers: dingtalkyida__1__0_models.GetCorpTasksHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetCorpTasksResponse:
        """
        @summary 查询待办任务列表
        
        @param request: GetCorpTasksRequest
        @param headers: GetCorpTasksHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCorpTasksResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_types):
            query['appTypes'] = request.app_types
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.create_from_time_gmt):
            query['createFromTimeGMT'] = request.create_from_time_gmt
        if not UtilClient.is_unset(request.create_to_time_gmt):
            query['createToTimeGMT'] = request.create_to_time_gmt
        if not UtilClient.is_unset(request.keyword):
            query['keyword'] = request.keyword
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.process_codes):
            query['processCodes'] = request.process_codes
        if not UtilClient.is_unset(request.token):
            query['token'] = request.token
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
            action='GetCorpTasks',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/corpTasks',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetCorpTasksResponse(),
            self.execute(params, req, runtime)
        )

    async def get_corp_tasks_with_options_async(
        self,
        request: dingtalkyida__1__0_models.GetCorpTasksRequest,
        headers: dingtalkyida__1__0_models.GetCorpTasksHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetCorpTasksResponse:
        """
        @summary 查询待办任务列表
        
        @param request: GetCorpTasksRequest
        @param headers: GetCorpTasksHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCorpTasksResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_types):
            query['appTypes'] = request.app_types
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.create_from_time_gmt):
            query['createFromTimeGMT'] = request.create_from_time_gmt
        if not UtilClient.is_unset(request.create_to_time_gmt):
            query['createToTimeGMT'] = request.create_to_time_gmt
        if not UtilClient.is_unset(request.keyword):
            query['keyword'] = request.keyword
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.process_codes):
            query['processCodes'] = request.process_codes
        if not UtilClient.is_unset(request.token):
            query['token'] = request.token
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
            action='GetCorpTasks',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/corpTasks',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetCorpTasksResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_corp_tasks(
        self,
        request: dingtalkyida__1__0_models.GetCorpTasksRequest,
    ) -> dingtalkyida__1__0_models.GetCorpTasksResponse:
        """
        @summary 查询待办任务列表
        
        @param request: GetCorpTasksRequest
        @return: GetCorpTasksResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetCorpTasksHeaders()
        return self.get_corp_tasks_with_options(request, headers, runtime)

    async def get_corp_tasks_async(
        self,
        request: dingtalkyida__1__0_models.GetCorpTasksRequest,
    ) -> dingtalkyida__1__0_models.GetCorpTasksResponse:
        """
        @summary 查询待办任务列表
        
        @param request: GetCorpTasksRequest
        @return: GetCorpTasksResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetCorpTasksHeaders()
        return await self.get_corp_tasks_with_options_async(request, headers, runtime)

    def get_db_config_with_options(
        self,
        request: dingtalkyida__1__0_models.GetDbConfigRequest,
        headers: dingtalkyida__1__0_models.GetDbConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetDbConfigResponse:
        """
        @summary 获取数据库连接串信息
        
        @param request: GetDbConfigRequest
        @param headers: GetDbConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDbConfigResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='GetDbConfig',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/metadata/dbConfigs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetDbConfigResponse(),
            self.execute(params, req, runtime)
        )

    async def get_db_config_with_options_async(
        self,
        request: dingtalkyida__1__0_models.GetDbConfigRequest,
        headers: dingtalkyida__1__0_models.GetDbConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetDbConfigResponse:
        """
        @summary 获取数据库连接串信息
        
        @param request: GetDbConfigRequest
        @param headers: GetDbConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDbConfigResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='GetDbConfig',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/metadata/dbConfigs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetDbConfigResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_db_config(
        self,
        request: dingtalkyida__1__0_models.GetDbConfigRequest,
    ) -> dingtalkyida__1__0_models.GetDbConfigResponse:
        """
        @summary 获取数据库连接串信息
        
        @param request: GetDbConfigRequest
        @return: GetDbConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetDbConfigHeaders()
        return self.get_db_config_with_options(request, headers, runtime)

    async def get_db_config_async(
        self,
        request: dingtalkyida__1__0_models.GetDbConfigRequest,
    ) -> dingtalkyida__1__0_models.GetDbConfigResponse:
        """
        @summary 获取数据库连接串信息
        
        @param request: GetDbConfigRequest
        @return: GetDbConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetDbConfigHeaders()
        return await self.get_db_config_with_options_async(request, headers, runtime)

    def get_field_def_by_uuid_with_options(
        self,
        request: dingtalkyida__1__0_models.GetFieldDefByUuidRequest,
        headers: dingtalkyida__1__0_models.GetFieldDefByUuidHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetFieldDefByUuidResponse:
        """
        @summary 根据表单ID获取字段信息
        
        @param request: GetFieldDefByUuidRequest
        @param headers: GetFieldDefByUuidHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFieldDefByUuidResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_uuid):
            query['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='GetFieldDefByUuid',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/formFields',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetFieldDefByUuidResponse(),
            self.execute(params, req, runtime)
        )

    async def get_field_def_by_uuid_with_options_async(
        self,
        request: dingtalkyida__1__0_models.GetFieldDefByUuidRequest,
        headers: dingtalkyida__1__0_models.GetFieldDefByUuidHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetFieldDefByUuidResponse:
        """
        @summary 根据表单ID获取字段信息
        
        @param request: GetFieldDefByUuidRequest
        @param headers: GetFieldDefByUuidHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFieldDefByUuidResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_uuid):
            query['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='GetFieldDefByUuid',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/formFields',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetFieldDefByUuidResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_field_def_by_uuid(
        self,
        request: dingtalkyida__1__0_models.GetFieldDefByUuidRequest,
    ) -> dingtalkyida__1__0_models.GetFieldDefByUuidResponse:
        """
        @summary 根据表单ID获取字段信息
        
        @param request: GetFieldDefByUuidRequest
        @return: GetFieldDefByUuidResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetFieldDefByUuidHeaders()
        return self.get_field_def_by_uuid_with_options(request, headers, runtime)

    async def get_field_def_by_uuid_async(
        self,
        request: dingtalkyida__1__0_models.GetFieldDefByUuidRequest,
    ) -> dingtalkyida__1__0_models.GetFieldDefByUuidResponse:
        """
        @summary 根据表单ID获取字段信息
        
        @param request: GetFieldDefByUuidRequest
        @return: GetFieldDefByUuidResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetFieldDefByUuidHeaders()
        return await self.get_field_def_by_uuid_with_options_async(request, headers, runtime)

    def get_form_component_definition_list_with_options(
        self,
        app_type: str,
        form_uuid: str,
        request: dingtalkyida__1__0_models.GetFormComponentDefinitionListRequest,
        headers: dingtalkyida__1__0_models.GetFormComponentDefinitionListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetFormComponentDefinitionListResponse:
        """
        @summary 获取表单定义
        
        @param request: GetFormComponentDefinitionListRequest
        @param headers: GetFormComponentDefinitionListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFormComponentDefinitionListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        if not UtilClient.is_unset(request.version):
            query['version'] = request.version
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
            action='GetFormComponentDefinitionList',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/definitions/{app_type}/{form_uuid}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetFormComponentDefinitionListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_form_component_definition_list_with_options_async(
        self,
        app_type: str,
        form_uuid: str,
        request: dingtalkyida__1__0_models.GetFormComponentDefinitionListRequest,
        headers: dingtalkyida__1__0_models.GetFormComponentDefinitionListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetFormComponentDefinitionListResponse:
        """
        @summary 获取表单定义
        
        @param request: GetFormComponentDefinitionListRequest
        @param headers: GetFormComponentDefinitionListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFormComponentDefinitionListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        if not UtilClient.is_unset(request.version):
            query['version'] = request.version
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
            action='GetFormComponentDefinitionList',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/definitions/{app_type}/{form_uuid}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetFormComponentDefinitionListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_form_component_definition_list(
        self,
        app_type: str,
        form_uuid: str,
        request: dingtalkyida__1__0_models.GetFormComponentDefinitionListRequest,
    ) -> dingtalkyida__1__0_models.GetFormComponentDefinitionListResponse:
        """
        @summary 获取表单定义
        
        @param request: GetFormComponentDefinitionListRequest
        @return: GetFormComponentDefinitionListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetFormComponentDefinitionListHeaders()
        return self.get_form_component_definition_list_with_options(app_type, form_uuid, request, headers, runtime)

    async def get_form_component_definition_list_async(
        self,
        app_type: str,
        form_uuid: str,
        request: dingtalkyida__1__0_models.GetFormComponentDefinitionListRequest,
    ) -> dingtalkyida__1__0_models.GetFormComponentDefinitionListResponse:
        """
        @summary 获取表单定义
        
        @param request: GetFormComponentDefinitionListRequest
        @return: GetFormComponentDefinitionListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetFormComponentDefinitionListHeaders()
        return await self.get_form_component_definition_list_with_options_async(app_type, form_uuid, request, headers, runtime)

    def get_form_data_by_idwith_options(
        self,
        id: str,
        request: dingtalkyida__1__0_models.GetFormDataByIDRequest,
        headers: dingtalkyida__1__0_models.GetFormDataByIDHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetFormDataByIDResponse:
        """
        @summary 根据表单 ID 查询实例详情
        
        @param request: GetFormDataByIDRequest
        @param headers: GetFormDataByIDHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFormDataByIDResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='GetFormDataByID',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/instances/{id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetFormDataByIDResponse(),
            self.execute(params, req, runtime)
        )

    async def get_form_data_by_idwith_options_async(
        self,
        id: str,
        request: dingtalkyida__1__0_models.GetFormDataByIDRequest,
        headers: dingtalkyida__1__0_models.GetFormDataByIDHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetFormDataByIDResponse:
        """
        @summary 根据表单 ID 查询实例详情
        
        @param request: GetFormDataByIDRequest
        @param headers: GetFormDataByIDHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFormDataByIDResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='GetFormDataByID',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/instances/{id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetFormDataByIDResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_form_data_by_id(
        self,
        id: str,
        request: dingtalkyida__1__0_models.GetFormDataByIDRequest,
    ) -> dingtalkyida__1__0_models.GetFormDataByIDResponse:
        """
        @summary 根据表单 ID 查询实例详情
        
        @param request: GetFormDataByIDRequest
        @return: GetFormDataByIDResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetFormDataByIDHeaders()
        return self.get_form_data_by_idwith_options(id, request, headers, runtime)

    async def get_form_data_by_id_async(
        self,
        id: str,
        request: dingtalkyida__1__0_models.GetFormDataByIDRequest,
    ) -> dingtalkyida__1__0_models.GetFormDataByIDResponse:
        """
        @summary 根据表单 ID 查询实例详情
        
        @param request: GetFormDataByIDRequest
        @return: GetFormDataByIDResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetFormDataByIDHeaders()
        return await self.get_form_data_by_idwith_options_async(id, request, headers, runtime)

    def get_form_list_in_app_with_options(
        self,
        request: dingtalkyida__1__0_models.GetFormListInAppRequest,
        headers: dingtalkyida__1__0_models.GetFormListInAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetFormListInAppResponse:
        """
        @summary 获取应用内表单列表信息
        
        @param request: GetFormListInAppRequest
        @param headers: GetFormListInAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFormListInAppResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_types):
            query['formTypes'] = request.form_types
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='GetFormListInApp',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetFormListInAppResponse(),
            self.execute(params, req, runtime)
        )

    async def get_form_list_in_app_with_options_async(
        self,
        request: dingtalkyida__1__0_models.GetFormListInAppRequest,
        headers: dingtalkyida__1__0_models.GetFormListInAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetFormListInAppResponse:
        """
        @summary 获取应用内表单列表信息
        
        @param request: GetFormListInAppRequest
        @param headers: GetFormListInAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFormListInAppResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_types):
            query['formTypes'] = request.form_types
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='GetFormListInApp',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetFormListInAppResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_form_list_in_app(
        self,
        request: dingtalkyida__1__0_models.GetFormListInAppRequest,
    ) -> dingtalkyida__1__0_models.GetFormListInAppResponse:
        """
        @summary 获取应用内表单列表信息
        
        @param request: GetFormListInAppRequest
        @return: GetFormListInAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetFormListInAppHeaders()
        return self.get_form_list_in_app_with_options(request, headers, runtime)

    async def get_form_list_in_app_async(
        self,
        request: dingtalkyida__1__0_models.GetFormListInAppRequest,
    ) -> dingtalkyida__1__0_models.GetFormListInAppResponse:
        """
        @summary 获取应用内表单列表信息
        
        @param request: GetFormListInAppRequest
        @return: GetFormListInAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetFormListInAppHeaders()
        return await self.get_form_list_in_app_with_options_async(request, headers, runtime)

    def get_instance_by_id_with_options(
        self,
        id: str,
        request: dingtalkyida__1__0_models.GetInstanceByIdRequest,
        headers: dingtalkyida__1__0_models.GetInstanceByIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetInstanceByIdResponse:
        """
        @summary 根据实例 ID 获取流程实例详情
        
        @param request: GetInstanceByIdRequest
        @param headers: GetInstanceByIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetInstanceByIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='GetInstanceById',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/processes/instancesInfos/{id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetInstanceByIdResponse(),
            self.execute(params, req, runtime)
        )

    async def get_instance_by_id_with_options_async(
        self,
        id: str,
        request: dingtalkyida__1__0_models.GetInstanceByIdRequest,
        headers: dingtalkyida__1__0_models.GetInstanceByIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetInstanceByIdResponse:
        """
        @summary 根据实例 ID 获取流程实例详情
        
        @param request: GetInstanceByIdRequest
        @param headers: GetInstanceByIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetInstanceByIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='GetInstanceById',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/processes/instancesInfos/{id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetInstanceByIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_instance_by_id(
        self,
        id: str,
        request: dingtalkyida__1__0_models.GetInstanceByIdRequest,
    ) -> dingtalkyida__1__0_models.GetInstanceByIdResponse:
        """
        @summary 根据实例 ID 获取流程实例详情
        
        @param request: GetInstanceByIdRequest
        @return: GetInstanceByIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetInstanceByIdHeaders()
        return self.get_instance_by_id_with_options(id, request, headers, runtime)

    async def get_instance_by_id_async(
        self,
        id: str,
        request: dingtalkyida__1__0_models.GetInstanceByIdRequest,
    ) -> dingtalkyida__1__0_models.GetInstanceByIdResponse:
        """
        @summary 根据实例 ID 获取流程实例详情
        
        @param request: GetInstanceByIdRequest
        @return: GetInstanceByIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetInstanceByIdHeaders()
        return await self.get_instance_by_id_with_options_async(id, request, headers, runtime)

    def get_instance_id_list_with_options(
        self,
        request: dingtalkyida__1__0_models.GetInstanceIdListRequest,
        headers: dingtalkyida__1__0_models.GetInstanceIdListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetInstanceIdListResponse:
        """
        @summary 根据条件搜索流程实例 ID
        
        @param request: GetInstanceIdListRequest
        @param headers: GetInstanceIdListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetInstanceIdListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.approved_result):
            body['approvedResult'] = request.approved_result
        if not UtilClient.is_unset(request.create_from_time_gmt):
            body['createFromTimeGMT'] = request.create_from_time_gmt
        if not UtilClient.is_unset(request.create_to_time_gmt):
            body['createToTimeGMT'] = request.create_to_time_gmt
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.instance_status):
            body['instanceStatus'] = request.instance_status
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.modified_from_time_gmt):
            body['modifiedFromTimeGMT'] = request.modified_from_time_gmt
        if not UtilClient.is_unset(request.modified_to_time_gmt):
            body['modifiedToTimeGMT'] = request.modified_to_time_gmt
        if not UtilClient.is_unset(request.originator_id):
            body['originatorId'] = request.originator_id
        if not UtilClient.is_unset(request.search_field_json):
            body['searchFieldJson'] = request.search_field_json
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.task_id):
            body['taskId'] = request.task_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='GetInstanceIdList',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/processes/instanceIds',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetInstanceIdListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_instance_id_list_with_options_async(
        self,
        request: dingtalkyida__1__0_models.GetInstanceIdListRequest,
        headers: dingtalkyida__1__0_models.GetInstanceIdListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetInstanceIdListResponse:
        """
        @summary 根据条件搜索流程实例 ID
        
        @param request: GetInstanceIdListRequest
        @param headers: GetInstanceIdListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetInstanceIdListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.approved_result):
            body['approvedResult'] = request.approved_result
        if not UtilClient.is_unset(request.create_from_time_gmt):
            body['createFromTimeGMT'] = request.create_from_time_gmt
        if not UtilClient.is_unset(request.create_to_time_gmt):
            body['createToTimeGMT'] = request.create_to_time_gmt
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.instance_status):
            body['instanceStatus'] = request.instance_status
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.modified_from_time_gmt):
            body['modifiedFromTimeGMT'] = request.modified_from_time_gmt
        if not UtilClient.is_unset(request.modified_to_time_gmt):
            body['modifiedToTimeGMT'] = request.modified_to_time_gmt
        if not UtilClient.is_unset(request.originator_id):
            body['originatorId'] = request.originator_id
        if not UtilClient.is_unset(request.search_field_json):
            body['searchFieldJson'] = request.search_field_json
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.task_id):
            body['taskId'] = request.task_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='GetInstanceIdList',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/processes/instanceIds',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetInstanceIdListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_instance_id_list(
        self,
        request: dingtalkyida__1__0_models.GetInstanceIdListRequest,
    ) -> dingtalkyida__1__0_models.GetInstanceIdListResponse:
        """
        @summary 根据条件搜索流程实例 ID
        
        @param request: GetInstanceIdListRequest
        @return: GetInstanceIdListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetInstanceIdListHeaders()
        return self.get_instance_id_list_with_options(request, headers, runtime)

    async def get_instance_id_list_async(
        self,
        request: dingtalkyida__1__0_models.GetInstanceIdListRequest,
    ) -> dingtalkyida__1__0_models.GetInstanceIdListResponse:
        """
        @summary 根据条件搜索流程实例 ID
        
        @param request: GetInstanceIdListRequest
        @return: GetInstanceIdListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetInstanceIdListHeaders()
        return await self.get_instance_id_list_with_options_async(request, headers, runtime)

    def get_instances_with_options(
        self,
        request: dingtalkyida__1__0_models.GetInstancesRequest,
        headers: dingtalkyida__1__0_models.GetInstancesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetInstancesResponse:
        """
        @summary 根据搜索条件获取流程表单实例详情
        
        @param request: GetInstancesRequest
        @param headers: GetInstancesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetInstancesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.approved_result):
            body['approvedResult'] = request.approved_result
        if not UtilClient.is_unset(request.create_from_time_gmt):
            body['createFromTimeGMT'] = request.create_from_time_gmt
        if not UtilClient.is_unset(request.create_to_time_gmt):
            body['createToTimeGMT'] = request.create_to_time_gmt
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.instance_status):
            body['instanceStatus'] = request.instance_status
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.modified_from_time_gmt):
            body['modifiedFromTimeGMT'] = request.modified_from_time_gmt
        if not UtilClient.is_unset(request.modified_to_time_gmt):
            body['modifiedToTimeGMT'] = request.modified_to_time_gmt
        if not UtilClient.is_unset(request.order_config_json):
            body['orderConfigJson'] = request.order_config_json
        if not UtilClient.is_unset(request.originator_id):
            body['originatorId'] = request.originator_id
        if not UtilClient.is_unset(request.search_field_json):
            body['searchFieldJson'] = request.search_field_json
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.task_id):
            body['taskId'] = request.task_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='GetInstances',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/processes/instances',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetInstancesResponse(),
            self.execute(params, req, runtime)
        )

    async def get_instances_with_options_async(
        self,
        request: dingtalkyida__1__0_models.GetInstancesRequest,
        headers: dingtalkyida__1__0_models.GetInstancesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetInstancesResponse:
        """
        @summary 根据搜索条件获取流程表单实例详情
        
        @param request: GetInstancesRequest
        @param headers: GetInstancesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetInstancesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.approved_result):
            body['approvedResult'] = request.approved_result
        if not UtilClient.is_unset(request.create_from_time_gmt):
            body['createFromTimeGMT'] = request.create_from_time_gmt
        if not UtilClient.is_unset(request.create_to_time_gmt):
            body['createToTimeGMT'] = request.create_to_time_gmt
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.instance_status):
            body['instanceStatus'] = request.instance_status
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.modified_from_time_gmt):
            body['modifiedFromTimeGMT'] = request.modified_from_time_gmt
        if not UtilClient.is_unset(request.modified_to_time_gmt):
            body['modifiedToTimeGMT'] = request.modified_to_time_gmt
        if not UtilClient.is_unset(request.order_config_json):
            body['orderConfigJson'] = request.order_config_json
        if not UtilClient.is_unset(request.originator_id):
            body['originatorId'] = request.originator_id
        if not UtilClient.is_unset(request.search_field_json):
            body['searchFieldJson'] = request.search_field_json
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.task_id):
            body['taskId'] = request.task_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='GetInstances',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/processes/instances',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetInstancesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_instances(
        self,
        request: dingtalkyida__1__0_models.GetInstancesRequest,
    ) -> dingtalkyida__1__0_models.GetInstancesResponse:
        """
        @summary 根据搜索条件获取流程表单实例详情
        
        @param request: GetInstancesRequest
        @return: GetInstancesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetInstancesHeaders()
        return self.get_instances_with_options(request, headers, runtime)

    async def get_instances_async(
        self,
        request: dingtalkyida__1__0_models.GetInstancesRequest,
    ) -> dingtalkyida__1__0_models.GetInstancesResponse:
        """
        @summary 根据搜索条件获取流程表单实例详情
        
        @param request: GetInstancesRequest
        @return: GetInstancesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetInstancesHeaders()
        return await self.get_instances_with_options_async(request, headers, runtime)

    def get_instances_by_id_list_with_options(
        self,
        request: dingtalkyida__1__0_models.GetInstancesByIdListRequest,
        headers: dingtalkyida__1__0_models.GetInstancesByIdListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetInstancesByIdListResponse:
        """
        @summary 根据实例 ID 列表批量获取流程实例详情
        
        @param request: GetInstancesByIdListRequest
        @param headers: GetInstancesByIdListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetInstancesByIdListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.process_instance_ids):
            query['processInstanceIds'] = request.process_instance_ids
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='GetInstancesByIdList',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/processes/instances/searchWithIds',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetInstancesByIdListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_instances_by_id_list_with_options_async(
        self,
        request: dingtalkyida__1__0_models.GetInstancesByIdListRequest,
        headers: dingtalkyida__1__0_models.GetInstancesByIdListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetInstancesByIdListResponse:
        """
        @summary 根据实例 ID 列表批量获取流程实例详情
        
        @param request: GetInstancesByIdListRequest
        @param headers: GetInstancesByIdListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetInstancesByIdListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.process_instance_ids):
            query['processInstanceIds'] = request.process_instance_ids
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='GetInstancesByIdList',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/processes/instances/searchWithIds',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetInstancesByIdListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_instances_by_id_list(
        self,
        request: dingtalkyida__1__0_models.GetInstancesByIdListRequest,
    ) -> dingtalkyida__1__0_models.GetInstancesByIdListResponse:
        """
        @summary 根据实例 ID 列表批量获取流程实例详情
        
        @param request: GetInstancesByIdListRequest
        @return: GetInstancesByIdListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetInstancesByIdListHeaders()
        return self.get_instances_by_id_list_with_options(request, headers, runtime)

    async def get_instances_by_id_list_async(
        self,
        request: dingtalkyida__1__0_models.GetInstancesByIdListRequest,
    ) -> dingtalkyida__1__0_models.GetInstancesByIdListResponse:
        """
        @summary 根据实例 ID 列表批量获取流程实例详情
        
        @param request: GetInstancesByIdListRequest
        @return: GetInstancesByIdListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetInstancesByIdListHeaders()
        return await self.get_instances_by_id_list_with_options_async(request, headers, runtime)

    def get_me_corp_submission_with_options(
        self,
        user_id: str,
        request: dingtalkyida__1__0_models.GetMeCorpSubmissionRequest,
        headers: dingtalkyida__1__0_models.GetMeCorpSubmissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetMeCorpSubmissionResponse:
        """
        @summary 查询已提交任务列表
        
        @param request: GetMeCorpSubmissionRequest
        @param headers: GetMeCorpSubmissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetMeCorpSubmissionResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_types):
            query['appTypes'] = request.app_types
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.create_from_time_gmt):
            query['createFromTimeGMT'] = request.create_from_time_gmt
        if not UtilClient.is_unset(request.create_to_time_gmt):
            query['createToTimeGMT'] = request.create_to_time_gmt
        if not UtilClient.is_unset(request.keyword):
            query['keyword'] = request.keyword
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.process_codes):
            query['processCodes'] = request.process_codes
        if not UtilClient.is_unset(request.token):
            query['token'] = request.token
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
            action='GetMeCorpSubmission',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/tasks/myCorpSubmission/{user_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetMeCorpSubmissionResponse(),
            self.execute(params, req, runtime)
        )

    async def get_me_corp_submission_with_options_async(
        self,
        user_id: str,
        request: dingtalkyida__1__0_models.GetMeCorpSubmissionRequest,
        headers: dingtalkyida__1__0_models.GetMeCorpSubmissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetMeCorpSubmissionResponse:
        """
        @summary 查询已提交任务列表
        
        @param request: GetMeCorpSubmissionRequest
        @param headers: GetMeCorpSubmissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetMeCorpSubmissionResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_types):
            query['appTypes'] = request.app_types
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.create_from_time_gmt):
            query['createFromTimeGMT'] = request.create_from_time_gmt
        if not UtilClient.is_unset(request.create_to_time_gmt):
            query['createToTimeGMT'] = request.create_to_time_gmt
        if not UtilClient.is_unset(request.keyword):
            query['keyword'] = request.keyword
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.process_codes):
            query['processCodes'] = request.process_codes
        if not UtilClient.is_unset(request.token):
            query['token'] = request.token
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
            action='GetMeCorpSubmission',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/tasks/myCorpSubmission/{user_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetMeCorpSubmissionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_me_corp_submission(
        self,
        user_id: str,
        request: dingtalkyida__1__0_models.GetMeCorpSubmissionRequest,
    ) -> dingtalkyida__1__0_models.GetMeCorpSubmissionResponse:
        """
        @summary 查询已提交任务列表
        
        @param request: GetMeCorpSubmissionRequest
        @return: GetMeCorpSubmissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetMeCorpSubmissionHeaders()
        return self.get_me_corp_submission_with_options(user_id, request, headers, runtime)

    async def get_me_corp_submission_async(
        self,
        user_id: str,
        request: dingtalkyida__1__0_models.GetMeCorpSubmissionRequest,
    ) -> dingtalkyida__1__0_models.GetMeCorpSubmissionResponse:
        """
        @summary 查询已提交任务列表
        
        @param request: GetMeCorpSubmissionRequest
        @return: GetMeCorpSubmissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetMeCorpSubmissionHeaders()
        return await self.get_me_corp_submission_with_options_async(user_id, request, headers, runtime)

    def get_notify_me_with_options(
        self,
        user_id: str,
        request: dingtalkyida__1__0_models.GetNotifyMeRequest,
        headers: dingtalkyida__1__0_models.GetNotifyMeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetNotifyMeResponse:
        """
        @summary 查询抄送我的任务列表（企业维度）
        
        @param request: GetNotifyMeRequest
        @param headers: GetNotifyMeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetNotifyMeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_types):
            query['appTypes'] = request.app_types
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.create_from_time_gmt):
            query['createFromTimeGMT'] = request.create_from_time_gmt
        if not UtilClient.is_unset(request.create_to_time_gmt):
            query['createToTimeGMT'] = request.create_to_time_gmt
        if not UtilClient.is_unset(request.instance_create_from_time_gmt):
            query['instanceCreateFromTimeGMT'] = request.instance_create_from_time_gmt
        if not UtilClient.is_unset(request.instance_create_to_time_gmt):
            query['instanceCreateToTimeGMT'] = request.instance_create_to_time_gmt
        if not UtilClient.is_unset(request.keyword):
            query['keyword'] = request.keyword
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.process_codes):
            query['processCodes'] = request.process_codes
        if not UtilClient.is_unset(request.token):
            query['token'] = request.token
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
            action='GetNotifyMe',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/corpNotifications/{user_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetNotifyMeResponse(),
            self.execute(params, req, runtime)
        )

    async def get_notify_me_with_options_async(
        self,
        user_id: str,
        request: dingtalkyida__1__0_models.GetNotifyMeRequest,
        headers: dingtalkyida__1__0_models.GetNotifyMeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetNotifyMeResponse:
        """
        @summary 查询抄送我的任务列表（企业维度）
        
        @param request: GetNotifyMeRequest
        @param headers: GetNotifyMeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetNotifyMeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_types):
            query['appTypes'] = request.app_types
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.create_from_time_gmt):
            query['createFromTimeGMT'] = request.create_from_time_gmt
        if not UtilClient.is_unset(request.create_to_time_gmt):
            query['createToTimeGMT'] = request.create_to_time_gmt
        if not UtilClient.is_unset(request.instance_create_from_time_gmt):
            query['instanceCreateFromTimeGMT'] = request.instance_create_from_time_gmt
        if not UtilClient.is_unset(request.instance_create_to_time_gmt):
            query['instanceCreateToTimeGMT'] = request.instance_create_to_time_gmt
        if not UtilClient.is_unset(request.keyword):
            query['keyword'] = request.keyword
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.process_codes):
            query['processCodes'] = request.process_codes
        if not UtilClient.is_unset(request.token):
            query['token'] = request.token
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
            action='GetNotifyMe',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/corpNotifications/{user_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetNotifyMeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_notify_me(
        self,
        user_id: str,
        request: dingtalkyida__1__0_models.GetNotifyMeRequest,
    ) -> dingtalkyida__1__0_models.GetNotifyMeResponse:
        """
        @summary 查询抄送我的任务列表（企业维度）
        
        @param request: GetNotifyMeRequest
        @return: GetNotifyMeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetNotifyMeHeaders()
        return self.get_notify_me_with_options(user_id, request, headers, runtime)

    async def get_notify_me_async(
        self,
        user_id: str,
        request: dingtalkyida__1__0_models.GetNotifyMeRequest,
    ) -> dingtalkyida__1__0_models.GetNotifyMeResponse:
        """
        @summary 查询抄送我的任务列表（企业维度）
        
        @param request: GetNotifyMeRequest
        @return: GetNotifyMeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetNotifyMeHeaders()
        return await self.get_notify_me_with_options_async(user_id, request, headers, runtime)

    def get_open_url_with_options(
        self,
        app_type: str,
        request: dingtalkyida__1__0_models.GetOpenUrlRequest,
        headers: dingtalkyida__1__0_models.GetOpenUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetOpenUrlResponse:
        """
        @summary 附件地址转临时免登地址
        
        @param request: GetOpenUrlRequest
        @param headers: GetOpenUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetOpenUrlResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.file_url):
            query['fileUrl'] = request.file_url
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.timeout):
            query['timeout'] = request.timeout
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
            action='GetOpenUrl',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/temporaryUrls/{app_type}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetOpenUrlResponse(),
            self.execute(params, req, runtime)
        )

    async def get_open_url_with_options_async(
        self,
        app_type: str,
        request: dingtalkyida__1__0_models.GetOpenUrlRequest,
        headers: dingtalkyida__1__0_models.GetOpenUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetOpenUrlResponse:
        """
        @summary 附件地址转临时免登地址
        
        @param request: GetOpenUrlRequest
        @param headers: GetOpenUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetOpenUrlResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.file_url):
            query['fileUrl'] = request.file_url
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.timeout):
            query['timeout'] = request.timeout
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
            action='GetOpenUrl',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/temporaryUrls/{app_type}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetOpenUrlResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_open_url(
        self,
        app_type: str,
        request: dingtalkyida__1__0_models.GetOpenUrlRequest,
    ) -> dingtalkyida__1__0_models.GetOpenUrlResponse:
        """
        @summary 附件地址转临时免登地址
        
        @param request: GetOpenUrlRequest
        @return: GetOpenUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetOpenUrlHeaders()
        return self.get_open_url_with_options(app_type, request, headers, runtime)

    async def get_open_url_async(
        self,
        app_type: str,
        request: dingtalkyida__1__0_models.GetOpenUrlRequest,
    ) -> dingtalkyida__1__0_models.GetOpenUrlResponse:
        """
        @summary 附件地址转临时免登地址
        
        @param request: GetOpenUrlRequest
        @return: GetOpenUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetOpenUrlHeaders()
        return await self.get_open_url_with_options_async(app_type, request, headers, runtime)

    def get_operation_records_with_options(
        self,
        request: dingtalkyida__1__0_models.GetOperationRecordsRequest,
        headers: dingtalkyida__1__0_models.GetOperationRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetOperationRecordsResponse:
        """
        @summary 获取审批记录
        
        @param request: GetOperationRecordsRequest
        @param headers: GetOperationRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetOperationRecordsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.process_instance_id):
            query['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='GetOperationRecords',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/processes/operationRecords',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetOperationRecordsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_operation_records_with_options_async(
        self,
        request: dingtalkyida__1__0_models.GetOperationRecordsRequest,
        headers: dingtalkyida__1__0_models.GetOperationRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetOperationRecordsResponse:
        """
        @summary 获取审批记录
        
        @param request: GetOperationRecordsRequest
        @param headers: GetOperationRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetOperationRecordsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.process_instance_id):
            query['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='GetOperationRecords',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/processes/operationRecords',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetOperationRecordsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_operation_records(
        self,
        request: dingtalkyida__1__0_models.GetOperationRecordsRequest,
    ) -> dingtalkyida__1__0_models.GetOperationRecordsResponse:
        """
        @summary 获取审批记录
        
        @param request: GetOperationRecordsRequest
        @return: GetOperationRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetOperationRecordsHeaders()
        return self.get_operation_records_with_options(request, headers, runtime)

    async def get_operation_records_async(
        self,
        request: dingtalkyida__1__0_models.GetOperationRecordsRequest,
    ) -> dingtalkyida__1__0_models.GetOperationRecordsResponse:
        """
        @summary 获取审批记录
        
        @param request: GetOperationRecordsRequest
        @return: GetOperationRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetOperationRecordsHeaders()
        return await self.get_operation_records_with_options_async(request, headers, runtime)

    def get_platform_resource_with_options(
        self,
        request: dingtalkyida__1__0_models.GetPlatformResourceRequest,
        headers: dingtalkyida__1__0_models.GetPlatformResourceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetPlatformResourceResponse:
        """
        @summary 多渠道平台概览接口
        
        @param request: GetPlatformResourceRequest
        @param headers: GetPlatformResourceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPlatformResourceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
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
            action='GetPlatformResource',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/platformResources',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetPlatformResourceResponse(),
            self.execute(params, req, runtime)
        )

    async def get_platform_resource_with_options_async(
        self,
        request: dingtalkyida__1__0_models.GetPlatformResourceRequest,
        headers: dingtalkyida__1__0_models.GetPlatformResourceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetPlatformResourceResponse:
        """
        @summary 多渠道平台概览接口
        
        @param request: GetPlatformResourceRequest
        @param headers: GetPlatformResourceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPlatformResourceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
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
            action='GetPlatformResource',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/platformResources',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetPlatformResourceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_platform_resource(
        self,
        request: dingtalkyida__1__0_models.GetPlatformResourceRequest,
    ) -> dingtalkyida__1__0_models.GetPlatformResourceResponse:
        """
        @summary 多渠道平台概览接口
        
        @param request: GetPlatformResourceRequest
        @return: GetPlatformResourceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetPlatformResourceHeaders()
        return self.get_platform_resource_with_options(request, headers, runtime)

    async def get_platform_resource_async(
        self,
        request: dingtalkyida__1__0_models.GetPlatformResourceRequest,
    ) -> dingtalkyida__1__0_models.GetPlatformResourceResponse:
        """
        @summary 多渠道平台概览接口
        
        @param request: GetPlatformResourceRequest
        @return: GetPlatformResourceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetPlatformResourceHeaders()
        return await self.get_platform_resource_with_options_async(request, headers, runtime)

    def get_print_app_info_with_options(
        self,
        request: dingtalkyida__1__0_models.GetPrintAppInfoRequest,
        headers: dingtalkyida__1__0_models.GetPrintAppInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetPrintAppInfoResponse:
        """
        @summary 查询用户开通打印模板的应用信息
        
        @param request: GetPrintAppInfoRequest
        @param headers: GetPrintAppInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPrintAppInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.name_like):
            query['nameLike'] = request.name_like
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
            action='GetPrintAppInfo',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/printTemplates/printAppInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetPrintAppInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_print_app_info_with_options_async(
        self,
        request: dingtalkyida__1__0_models.GetPrintAppInfoRequest,
        headers: dingtalkyida__1__0_models.GetPrintAppInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetPrintAppInfoResponse:
        """
        @summary 查询用户开通打印模板的应用信息
        
        @param request: GetPrintAppInfoRequest
        @param headers: GetPrintAppInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPrintAppInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.name_like):
            query['nameLike'] = request.name_like
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
            action='GetPrintAppInfo',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/printTemplates/printAppInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetPrintAppInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_print_app_info(
        self,
        request: dingtalkyida__1__0_models.GetPrintAppInfoRequest,
    ) -> dingtalkyida__1__0_models.GetPrintAppInfoResponse:
        """
        @summary 查询用户开通打印模板的应用信息
        
        @param request: GetPrintAppInfoRequest
        @return: GetPrintAppInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetPrintAppInfoHeaders()
        return self.get_print_app_info_with_options(request, headers, runtime)

    async def get_print_app_info_async(
        self,
        request: dingtalkyida__1__0_models.GetPrintAppInfoRequest,
    ) -> dingtalkyida__1__0_models.GetPrintAppInfoResponse:
        """
        @summary 查询用户开通打印模板的应用信息
        
        @param request: GetPrintAppInfoRequest
        @return: GetPrintAppInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetPrintAppInfoHeaders()
        return await self.get_print_app_info_with_options_async(request, headers, runtime)

    def get_print_dictionary_with_options(
        self,
        request: dingtalkyida__1__0_models.GetPrintDictionaryRequest,
        headers: dingtalkyida__1__0_models.GetPrintDictionaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetPrintDictionaryResponse:
        """
        @summary 获取打印所需的表单与流程节点
        
        @param request: GetPrintDictionaryRequest
        @param headers: GetPrintDictionaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPrintDictionaryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_uuid):
            query['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        if not UtilClient.is_unset(request.version):
            query['version'] = request.version
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
            action='GetPrintDictionary',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/printTemplates/printDictionaries',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetPrintDictionaryResponse(),
            self.execute(params, req, runtime)
        )

    async def get_print_dictionary_with_options_async(
        self,
        request: dingtalkyida__1__0_models.GetPrintDictionaryRequest,
        headers: dingtalkyida__1__0_models.GetPrintDictionaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetPrintDictionaryResponse:
        """
        @summary 获取打印所需的表单与流程节点
        
        @param request: GetPrintDictionaryRequest
        @param headers: GetPrintDictionaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPrintDictionaryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_uuid):
            query['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        if not UtilClient.is_unset(request.version):
            query['version'] = request.version
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
            action='GetPrintDictionary',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/printTemplates/printDictionaries',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetPrintDictionaryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_print_dictionary(
        self,
        request: dingtalkyida__1__0_models.GetPrintDictionaryRequest,
    ) -> dingtalkyida__1__0_models.GetPrintDictionaryResponse:
        """
        @summary 获取打印所需的表单与流程节点
        
        @param request: GetPrintDictionaryRequest
        @return: GetPrintDictionaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetPrintDictionaryHeaders()
        return self.get_print_dictionary_with_options(request, headers, runtime)

    async def get_print_dictionary_async(
        self,
        request: dingtalkyida__1__0_models.GetPrintDictionaryRequest,
    ) -> dingtalkyida__1__0_models.GetPrintDictionaryResponse:
        """
        @summary 获取打印所需的表单与流程节点
        
        @param request: GetPrintDictionaryRequest
        @return: GetPrintDictionaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetPrintDictionaryHeaders()
        return await self.get_print_dictionary_with_options_async(request, headers, runtime)

    def get_process_definition_with_options(
        self,
        process_instance_id: str,
        request: dingtalkyida__1__0_models.GetProcessDefinitionRequest,
        headers: dingtalkyida__1__0_models.GetProcessDefinitionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetProcessDefinitionResponse:
        """
        @summary 获取流程定义
        
        @param request: GetProcessDefinitionRequest
        @param headers: GetProcessDefinitionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetProcessDefinitionResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.group_id):
            query['groupId'] = request.group_id
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.name_space):
            query['nameSpace'] = request.name_space
        if not UtilClient.is_unset(request.order_number):
            query['orderNumber'] = request.order_number
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.system_type):
            query['systemType'] = request.system_type
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
            action='GetProcessDefinition',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/processes/definitions/{process_instance_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetProcessDefinitionResponse(),
            self.execute(params, req, runtime)
        )

    async def get_process_definition_with_options_async(
        self,
        process_instance_id: str,
        request: dingtalkyida__1__0_models.GetProcessDefinitionRequest,
        headers: dingtalkyida__1__0_models.GetProcessDefinitionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetProcessDefinitionResponse:
        """
        @summary 获取流程定义
        
        @param request: GetProcessDefinitionRequest
        @param headers: GetProcessDefinitionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetProcessDefinitionResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.group_id):
            query['groupId'] = request.group_id
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.name_space):
            query['nameSpace'] = request.name_space
        if not UtilClient.is_unset(request.order_number):
            query['orderNumber'] = request.order_number
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.system_type):
            query['systemType'] = request.system_type
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
            action='GetProcessDefinition',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/processes/definitions/{process_instance_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetProcessDefinitionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_process_definition(
        self,
        process_instance_id: str,
        request: dingtalkyida__1__0_models.GetProcessDefinitionRequest,
    ) -> dingtalkyida__1__0_models.GetProcessDefinitionResponse:
        """
        @summary 获取流程定义
        
        @param request: GetProcessDefinitionRequest
        @return: GetProcessDefinitionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetProcessDefinitionHeaders()
        return self.get_process_definition_with_options(process_instance_id, request, headers, runtime)

    async def get_process_definition_async(
        self,
        process_instance_id: str,
        request: dingtalkyida__1__0_models.GetProcessDefinitionRequest,
    ) -> dingtalkyida__1__0_models.GetProcessDefinitionResponse:
        """
        @summary 获取流程定义
        
        @param request: GetProcessDefinitionRequest
        @return: GetProcessDefinitionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetProcessDefinitionHeaders()
        return await self.get_process_definition_with_options_async(process_instance_id, request, headers, runtime)

    def get_process_design_with_options(
        self,
        process_id: str,
        request: dingtalkyida__1__0_models.GetProcessDesignRequest,
        headers: dingtalkyida__1__0_models.GetProcessDesignHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetProcessDesignResponse:
        """
        @summary 根据流程ID获取流程设计结构
        
        @param request: GetProcessDesignRequest
        @param headers: GetProcessDesignHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetProcessDesignResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='GetProcessDesign',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/processes/{process_id}definitions/designs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetProcessDesignResponse(),
            self.execute(params, req, runtime)
        )

    async def get_process_design_with_options_async(
        self,
        process_id: str,
        request: dingtalkyida__1__0_models.GetProcessDesignRequest,
        headers: dingtalkyida__1__0_models.GetProcessDesignHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetProcessDesignResponse:
        """
        @summary 根据流程ID获取流程设计结构
        
        @param request: GetProcessDesignRequest
        @param headers: GetProcessDesignHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetProcessDesignResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='GetProcessDesign',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/processes/{process_id}definitions/designs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetProcessDesignResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_process_design(
        self,
        process_id: str,
        request: dingtalkyida__1__0_models.GetProcessDesignRequest,
    ) -> dingtalkyida__1__0_models.GetProcessDesignResponse:
        """
        @summary 根据流程ID获取流程设计结构
        
        @param request: GetProcessDesignRequest
        @return: GetProcessDesignResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetProcessDesignHeaders()
        return self.get_process_design_with_options(process_id, request, headers, runtime)

    async def get_process_design_async(
        self,
        process_id: str,
        request: dingtalkyida__1__0_models.GetProcessDesignRequest,
    ) -> dingtalkyida__1__0_models.GetProcessDesignResponse:
        """
        @summary 根据流程ID获取流程设计结构
        
        @param request: GetProcessDesignRequest
        @return: GetProcessDesignResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetProcessDesignHeaders()
        return await self.get_process_design_with_options_async(process_id, request, headers, runtime)

    def get_running_task_list_with_options(
        self,
        request: dingtalkyida__1__0_models.GetRunningTaskListRequest,
        headers: dingtalkyida__1__0_models.GetRunningTaskListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetRunningTaskListResponse:
        """
        @summary 通过实例id批量获取待办任务
        
        @param request: GetRunningTaskListRequest
        @param headers: GetRunningTaskListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRunningTaskListResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.process_instance_id_list):
            body['processInstanceIdList'] = request.process_instance_id_list
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_corp_id):
            body['userCorpId'] = request.user_corp_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='GetRunningTaskList',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/tasks/runningTasks/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetRunningTaskListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_running_task_list_with_options_async(
        self,
        request: dingtalkyida__1__0_models.GetRunningTaskListRequest,
        headers: dingtalkyida__1__0_models.GetRunningTaskListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetRunningTaskListResponse:
        """
        @summary 通过实例id批量获取待办任务
        
        @param request: GetRunningTaskListRequest
        @param headers: GetRunningTaskListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRunningTaskListResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.process_instance_id_list):
            body['processInstanceIdList'] = request.process_instance_id_list
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_corp_id):
            body['userCorpId'] = request.user_corp_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='GetRunningTaskList',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/tasks/runningTasks/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetRunningTaskListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_running_task_list(
        self,
        request: dingtalkyida__1__0_models.GetRunningTaskListRequest,
    ) -> dingtalkyida__1__0_models.GetRunningTaskListResponse:
        """
        @summary 通过实例id批量获取待办任务
        
        @param request: GetRunningTaskListRequest
        @return: GetRunningTaskListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetRunningTaskListHeaders()
        return self.get_running_task_list_with_options(request, headers, runtime)

    async def get_running_task_list_async(
        self,
        request: dingtalkyida__1__0_models.GetRunningTaskListRequest,
    ) -> dingtalkyida__1__0_models.GetRunningTaskListResponse:
        """
        @summary 通过实例id批量获取待办任务
        
        @param request: GetRunningTaskListRequest
        @return: GetRunningTaskListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetRunningTaskListHeaders()
        return await self.get_running_task_list_with_options_async(request, headers, runtime)

    def get_running_tasks_with_options(
        self,
        request: dingtalkyida__1__0_models.GetRunningTasksRequest,
        headers: dingtalkyida__1__0_models.GetRunningTasksHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetRunningTasksResponse:
        """
        @summary 查询流程运行任务（vpc）
        
        @param request: GetRunningTasksRequest
        @param headers: GetRunningTasksHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRunningTasksResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.process_instance_id):
            query['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='GetRunningTasks',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/processes/tasks/getRunningTasks',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetRunningTasksResponse(),
            self.execute(params, req, runtime)
        )

    async def get_running_tasks_with_options_async(
        self,
        request: dingtalkyida__1__0_models.GetRunningTasksRequest,
        headers: dingtalkyida__1__0_models.GetRunningTasksHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetRunningTasksResponse:
        """
        @summary 查询流程运行任务（vpc）
        
        @param request: GetRunningTasksRequest
        @param headers: GetRunningTasksHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRunningTasksResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.process_instance_id):
            query['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='GetRunningTasks',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/processes/tasks/getRunningTasks',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetRunningTasksResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_running_tasks(
        self,
        request: dingtalkyida__1__0_models.GetRunningTasksRequest,
    ) -> dingtalkyida__1__0_models.GetRunningTasksResponse:
        """
        @summary 查询流程运行任务（vpc）
        
        @param request: GetRunningTasksRequest
        @return: GetRunningTasksResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetRunningTasksHeaders()
        return self.get_running_tasks_with_options(request, headers, runtime)

    async def get_running_tasks_async(
        self,
        request: dingtalkyida__1__0_models.GetRunningTasksRequest,
    ) -> dingtalkyida__1__0_models.GetRunningTasksResponse:
        """
        @summary 查询流程运行任务（vpc）
        
        @param request: GetRunningTasksRequest
        @return: GetRunningTasksResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetRunningTasksHeaders()
        return await self.get_running_tasks_with_options_async(request, headers, runtime)

    def get_sale_user_info_by_user_id_with_options(
        self,
        request: dingtalkyida__1__0_models.GetSaleUserInfoByUserIdRequest,
        headers: dingtalkyida__1__0_models.GetSaleUserInfoByUserIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetSaleUserInfoByUserIdResponse:
        """
        @summary 根据用户employeeCode获取所在企业信息(包含售卖版本)
        
        @param request: GetSaleUserInfoByUserIdRequest
        @param headers: GetSaleUserInfoByUserIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSaleUserInfoByUserIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.namespace):
            query['namespace'] = request.namespace
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
            action='GetSaleUserInfoByUserId',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/saleUserInfo',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetSaleUserInfoByUserIdResponse(),
            self.execute(params, req, runtime)
        )

    async def get_sale_user_info_by_user_id_with_options_async(
        self,
        request: dingtalkyida__1__0_models.GetSaleUserInfoByUserIdRequest,
        headers: dingtalkyida__1__0_models.GetSaleUserInfoByUserIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetSaleUserInfoByUserIdResponse:
        """
        @summary 根据用户employeeCode获取所在企业信息(包含售卖版本)
        
        @param request: GetSaleUserInfoByUserIdRequest
        @param headers: GetSaleUserInfoByUserIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSaleUserInfoByUserIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.namespace):
            query['namespace'] = request.namespace
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
            action='GetSaleUserInfoByUserId',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/saleUserInfo',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetSaleUserInfoByUserIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_sale_user_info_by_user_id(
        self,
        request: dingtalkyida__1__0_models.GetSaleUserInfoByUserIdRequest,
    ) -> dingtalkyida__1__0_models.GetSaleUserInfoByUserIdResponse:
        """
        @summary 根据用户employeeCode获取所在企业信息(包含售卖版本)
        
        @param request: GetSaleUserInfoByUserIdRequest
        @return: GetSaleUserInfoByUserIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetSaleUserInfoByUserIdHeaders()
        return self.get_sale_user_info_by_user_id_with_options(request, headers, runtime)

    async def get_sale_user_info_by_user_id_async(
        self,
        request: dingtalkyida__1__0_models.GetSaleUserInfoByUserIdRequest,
    ) -> dingtalkyida__1__0_models.GetSaleUserInfoByUserIdResponse:
        """
        @summary 根据用户employeeCode获取所在企业信息(包含售卖版本)
        
        @param request: GetSaleUserInfoByUserIdRequest
        @return: GetSaleUserInfoByUserIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetSaleUserInfoByUserIdHeaders()
        return await self.get_sale_user_info_by_user_id_with_options_async(request, headers, runtime)

    def get_simple_cube_model_list_with_options(
        self,
        request: dingtalkyida__1__0_models.GetSimpleCubeModelListRequest,
        headers: dingtalkyida__1__0_models.GetSimpleCubeModelListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetSimpleCubeModelListResponse:
        """
        @summary 表单的元数据(字段)查询接口
        
        @param request: GetSimpleCubeModelListRequest
        @param headers: GetSimpleCubeModelListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSimpleCubeModelListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.cube_code):
            query['cubeCode'] = request.cube_code
        if not UtilClient.is_unset(request.cube_tenant_id):
            query['cubeTenantId'] = request.cube_tenant_id
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='GetSimpleCubeModelList',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/metadata/simpleCubeModelLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetSimpleCubeModelListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_simple_cube_model_list_with_options_async(
        self,
        request: dingtalkyida__1__0_models.GetSimpleCubeModelListRequest,
        headers: dingtalkyida__1__0_models.GetSimpleCubeModelListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetSimpleCubeModelListResponse:
        """
        @summary 表单的元数据(字段)查询接口
        
        @param request: GetSimpleCubeModelListRequest
        @param headers: GetSimpleCubeModelListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSimpleCubeModelListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.cube_code):
            query['cubeCode'] = request.cube_code
        if not UtilClient.is_unset(request.cube_tenant_id):
            query['cubeTenantId'] = request.cube_tenant_id
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='GetSimpleCubeModelList',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/metadata/simpleCubeModelLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetSimpleCubeModelListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_simple_cube_model_list(
        self,
        request: dingtalkyida__1__0_models.GetSimpleCubeModelListRequest,
    ) -> dingtalkyida__1__0_models.GetSimpleCubeModelListResponse:
        """
        @summary 表单的元数据(字段)查询接口
        
        @param request: GetSimpleCubeModelListRequest
        @return: GetSimpleCubeModelListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetSimpleCubeModelListHeaders()
        return self.get_simple_cube_model_list_with_options(request, headers, runtime)

    async def get_simple_cube_model_list_async(
        self,
        request: dingtalkyida__1__0_models.GetSimpleCubeModelListRequest,
    ) -> dingtalkyida__1__0_models.GetSimpleCubeModelListResponse:
        """
        @summary 表单的元数据(字段)查询接口
        
        @param request: GetSimpleCubeModelListRequest
        @return: GetSimpleCubeModelListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetSimpleCubeModelListHeaders()
        return await self.get_simple_cube_model_list_with_options_async(request, headers, runtime)

    def get_task_copies_with_options(
        self,
        request: dingtalkyida__1__0_models.GetTaskCopiesRequest,
        headers: dingtalkyida__1__0_models.GetTaskCopiesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetTaskCopiesResponse:
        """
        @summary 查询抄送我的任务列表（应用维度）
        
        @param request: GetTaskCopiesRequest
        @param headers: GetTaskCopiesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTaskCopiesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.create_from_time_gmt):
            query['createFromTimeGMT'] = request.create_from_time_gmt
        if not UtilClient.is_unset(request.create_to_time_gmt):
            query['createToTimeGMT'] = request.create_to_time_gmt
        if not UtilClient.is_unset(request.keyword):
            query['keyword'] = request.keyword
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.process_codes):
            query['processCodes'] = request.process_codes
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='GetTaskCopies',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/tasks/taskCopies',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetTaskCopiesResponse(),
            self.execute(params, req, runtime)
        )

    async def get_task_copies_with_options_async(
        self,
        request: dingtalkyida__1__0_models.GetTaskCopiesRequest,
        headers: dingtalkyida__1__0_models.GetTaskCopiesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetTaskCopiesResponse:
        """
        @summary 查询抄送我的任务列表（应用维度）
        
        @param request: GetTaskCopiesRequest
        @param headers: GetTaskCopiesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTaskCopiesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.create_from_time_gmt):
            query['createFromTimeGMT'] = request.create_from_time_gmt
        if not UtilClient.is_unset(request.create_to_time_gmt):
            query['createToTimeGMT'] = request.create_to_time_gmt
        if not UtilClient.is_unset(request.keyword):
            query['keyword'] = request.keyword
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.process_codes):
            query['processCodes'] = request.process_codes
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='GetTaskCopies',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/tasks/taskCopies',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetTaskCopiesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_task_copies(
        self,
        request: dingtalkyida__1__0_models.GetTaskCopiesRequest,
    ) -> dingtalkyida__1__0_models.GetTaskCopiesResponse:
        """
        @summary 查询抄送我的任务列表（应用维度）
        
        @param request: GetTaskCopiesRequest
        @return: GetTaskCopiesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetTaskCopiesHeaders()
        return self.get_task_copies_with_options(request, headers, runtime)

    async def get_task_copies_async(
        self,
        request: dingtalkyida__1__0_models.GetTaskCopiesRequest,
    ) -> dingtalkyida__1__0_models.GetTaskCopiesResponse:
        """
        @summary 查询抄送我的任务列表（应用维度）
        
        @param request: GetTaskCopiesRequest
        @return: GetTaskCopiesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetTaskCopiesHeaders()
        return await self.get_task_copies_with_options_async(request, headers, runtime)

    def list_application_with_options(
        self,
        request: dingtalkyida__1__0_models.ListApplicationRequest,
        headers: dingtalkyida__1__0_models.ListApplicationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ListApplicationResponse:
        """
        @summary 获取组织下的宜搭应用列表
        
        @param request: ListApplicationRequest
        @param headers: ListApplicationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListApplicationResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_filter):
            query['appFilter'] = request.app_filter
        if not UtilClient.is_unset(request.app_name_search_keyword):
            query['appNameSearchKeyword'] = request.app_name_search_keyword
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.token):
            query['token'] = request.token
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
            action='ListApplication',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/organizations/applications',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ListApplicationResponse(),
            self.execute(params, req, runtime)
        )

    async def list_application_with_options_async(
        self,
        request: dingtalkyida__1__0_models.ListApplicationRequest,
        headers: dingtalkyida__1__0_models.ListApplicationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ListApplicationResponse:
        """
        @summary 获取组织下的宜搭应用列表
        
        @param request: ListApplicationRequest
        @param headers: ListApplicationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListApplicationResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_filter):
            query['appFilter'] = request.app_filter
        if not UtilClient.is_unset(request.app_name_search_keyword):
            query['appNameSearchKeyword'] = request.app_name_search_keyword
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.token):
            query['token'] = request.token
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
            action='ListApplication',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/organizations/applications',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ListApplicationResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_application(
        self,
        request: dingtalkyida__1__0_models.ListApplicationRequest,
    ) -> dingtalkyida__1__0_models.ListApplicationResponse:
        """
        @summary 获取组织下的宜搭应用列表
        
        @param request: ListApplicationRequest
        @return: ListApplicationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ListApplicationHeaders()
        return self.list_application_with_options(request, headers, runtime)

    async def list_application_async(
        self,
        request: dingtalkyida__1__0_models.ListApplicationRequest,
    ) -> dingtalkyida__1__0_models.ListApplicationResponse:
        """
        @summary 获取组织下的宜搭应用列表
        
        @param request: ListApplicationRequest
        @return: ListApplicationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ListApplicationHeaders()
        return await self.list_application_with_options_async(request, headers, runtime)

    def list_application_authorization_service_application_information_with_options(
        self,
        instance_id: str,
        request: dingtalkyida__1__0_models.ListApplicationAuthorizationServiceApplicationInformationRequest,
        headers: dingtalkyida__1__0_models.ListApplicationAuthorizationServiceApplicationInformationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ListApplicationAuthorizationServiceApplicationInformationResponse:
        """
        @summary 多渠道应用概览
        
        @param request: ListApplicationAuthorizationServiceApplicationInformationRequest
        @param headers: ListApplicationAuthorizationServiceApplicationInformationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListApplicationAuthorizationServiceApplicationInformationResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_union_id):
            query['callerUnionId'] = request.caller_union_id
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
            action='ListApplicationAuthorizationServiceApplicationInformation',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/authorizations/applicationInfos/{instance_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ListApplicationAuthorizationServiceApplicationInformationResponse(),
            self.execute(params, req, runtime)
        )

    async def list_application_authorization_service_application_information_with_options_async(
        self,
        instance_id: str,
        request: dingtalkyida__1__0_models.ListApplicationAuthorizationServiceApplicationInformationRequest,
        headers: dingtalkyida__1__0_models.ListApplicationAuthorizationServiceApplicationInformationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ListApplicationAuthorizationServiceApplicationInformationResponse:
        """
        @summary 多渠道应用概览
        
        @param request: ListApplicationAuthorizationServiceApplicationInformationRequest
        @param headers: ListApplicationAuthorizationServiceApplicationInformationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListApplicationAuthorizationServiceApplicationInformationResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_union_id):
            query['callerUnionId'] = request.caller_union_id
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
            action='ListApplicationAuthorizationServiceApplicationInformation',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/authorizations/applicationInfos/{instance_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ListApplicationAuthorizationServiceApplicationInformationResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_application_authorization_service_application_information(
        self,
        instance_id: str,
        request: dingtalkyida__1__0_models.ListApplicationAuthorizationServiceApplicationInformationRequest,
    ) -> dingtalkyida__1__0_models.ListApplicationAuthorizationServiceApplicationInformationResponse:
        """
        @summary 多渠道应用概览
        
        @param request: ListApplicationAuthorizationServiceApplicationInformationRequest
        @return: ListApplicationAuthorizationServiceApplicationInformationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ListApplicationAuthorizationServiceApplicationInformationHeaders()
        return self.list_application_authorization_service_application_information_with_options(instance_id, request, headers, runtime)

    async def list_application_authorization_service_application_information_async(
        self,
        instance_id: str,
        request: dingtalkyida__1__0_models.ListApplicationAuthorizationServiceApplicationInformationRequest,
    ) -> dingtalkyida__1__0_models.ListApplicationAuthorizationServiceApplicationInformationResponse:
        """
        @summary 多渠道应用概览
        
        @param request: ListApplicationAuthorizationServiceApplicationInformationRequest
        @return: ListApplicationAuthorizationServiceApplicationInformationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ListApplicationAuthorizationServiceApplicationInformationHeaders()
        return await self.list_application_authorization_service_application_information_with_options_async(instance_id, request, headers, runtime)

    def list_application_authorization_service_connector_information_with_options(
        self,
        instance_id: str,
        request: dingtalkyida__1__0_models.ListApplicationAuthorizationServiceConnectorInformationRequest,
        headers: dingtalkyida__1__0_models.ListApplicationAuthorizationServiceConnectorInformationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ListApplicationAuthorizationServiceConnectorInformationResponse:
        """
        @summary 多渠道插件概览
        
        @param request: ListApplicationAuthorizationServiceConnectorInformationRequest
        @param headers: ListApplicationAuthorizationServiceConnectorInformationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListApplicationAuthorizationServiceConnectorInformationResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
            action='ListApplicationAuthorizationServiceConnectorInformation',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/applicationAuthorizations/plugs/{instance_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ListApplicationAuthorizationServiceConnectorInformationResponse(),
            self.execute(params, req, runtime)
        )

    async def list_application_authorization_service_connector_information_with_options_async(
        self,
        instance_id: str,
        request: dingtalkyida__1__0_models.ListApplicationAuthorizationServiceConnectorInformationRequest,
        headers: dingtalkyida__1__0_models.ListApplicationAuthorizationServiceConnectorInformationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ListApplicationAuthorizationServiceConnectorInformationResponse:
        """
        @summary 多渠道插件概览
        
        @param request: ListApplicationAuthorizationServiceConnectorInformationRequest
        @param headers: ListApplicationAuthorizationServiceConnectorInformationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListApplicationAuthorizationServiceConnectorInformationResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
            action='ListApplicationAuthorizationServiceConnectorInformation',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/applicationAuthorizations/plugs/{instance_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ListApplicationAuthorizationServiceConnectorInformationResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_application_authorization_service_connector_information(
        self,
        instance_id: str,
        request: dingtalkyida__1__0_models.ListApplicationAuthorizationServiceConnectorInformationRequest,
    ) -> dingtalkyida__1__0_models.ListApplicationAuthorizationServiceConnectorInformationResponse:
        """
        @summary 多渠道插件概览
        
        @param request: ListApplicationAuthorizationServiceConnectorInformationRequest
        @return: ListApplicationAuthorizationServiceConnectorInformationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ListApplicationAuthorizationServiceConnectorInformationHeaders()
        return self.list_application_authorization_service_connector_information_with_options(instance_id, request, headers, runtime)

    async def list_application_authorization_service_connector_information_async(
        self,
        instance_id: str,
        request: dingtalkyida__1__0_models.ListApplicationAuthorizationServiceConnectorInformationRequest,
    ) -> dingtalkyida__1__0_models.ListApplicationAuthorizationServiceConnectorInformationResponse:
        """
        @summary 多渠道插件概览
        
        @param request: ListApplicationAuthorizationServiceConnectorInformationRequest
        @return: ListApplicationAuthorizationServiceConnectorInformationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ListApplicationAuthorizationServiceConnectorInformationHeaders()
        return await self.list_application_authorization_service_connector_information_with_options_async(instance_id, request, headers, runtime)

    def list_application_information_with_options(
        self,
        instance_id: str,
        request: dingtalkyida__1__0_models.ListApplicationInformationRequest,
        headers: dingtalkyida__1__0_models.ListApplicationInformationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ListApplicationInformationResponse:
        """
        @summary 多渠道应用概览
        
        @param request: ListApplicationInformationRequest
        @param headers: ListApplicationInformationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListApplicationInformationResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
            action='ListApplicationInformation',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/infos/{instance_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ListApplicationInformationResponse(),
            self.execute(params, req, runtime)
        )

    async def list_application_information_with_options_async(
        self,
        instance_id: str,
        request: dingtalkyida__1__0_models.ListApplicationInformationRequest,
        headers: dingtalkyida__1__0_models.ListApplicationInformationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ListApplicationInformationResponse:
        """
        @summary 多渠道应用概览
        
        @param request: ListApplicationInformationRequest
        @param headers: ListApplicationInformationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListApplicationInformationResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
            action='ListApplicationInformation',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/infos/{instance_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ListApplicationInformationResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_application_information(
        self,
        instance_id: str,
        request: dingtalkyida__1__0_models.ListApplicationInformationRequest,
    ) -> dingtalkyida__1__0_models.ListApplicationInformationResponse:
        """
        @summary 多渠道应用概览
        
        @param request: ListApplicationInformationRequest
        @return: ListApplicationInformationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ListApplicationInformationHeaders()
        return self.list_application_information_with_options(instance_id, request, headers, runtime)

    async def list_application_information_async(
        self,
        instance_id: str,
        request: dingtalkyida__1__0_models.ListApplicationInformationRequest,
    ) -> dingtalkyida__1__0_models.ListApplicationInformationResponse:
        """
        @summary 多渠道应用概览
        
        @param request: ListApplicationInformationRequest
        @return: ListApplicationInformationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ListApplicationInformationHeaders()
        return await self.list_application_information_with_options_async(instance_id, request, headers, runtime)

    def list_commodity_with_options(
        self,
        request: dingtalkyida__1__0_models.ListCommodityRequest,
        headers: dingtalkyida__1__0_models.ListCommodityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ListCommodityResponse:
        """
        @summary 多渠道列出商品列表
        
        @param request: ListCommodityRequest
        @param headers: ListCommodityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListCommodityResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
            action='ListCommodity',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/appAuth/commodities',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ListCommodityResponse(),
            self.execute(params, req, runtime)
        )

    async def list_commodity_with_options_async(
        self,
        request: dingtalkyida__1__0_models.ListCommodityRequest,
        headers: dingtalkyida__1__0_models.ListCommodityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ListCommodityResponse:
        """
        @summary 多渠道列出商品列表
        
        @param request: ListCommodityRequest
        @param headers: ListCommodityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListCommodityResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
            action='ListCommodity',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/appAuth/commodities',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ListCommodityResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_commodity(
        self,
        request: dingtalkyida__1__0_models.ListCommodityRequest,
    ) -> dingtalkyida__1__0_models.ListCommodityResponse:
        """
        @summary 多渠道列出商品列表
        
        @param request: ListCommodityRequest
        @return: ListCommodityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ListCommodityHeaders()
        return self.list_commodity_with_options(request, headers, runtime)

    async def list_commodity_async(
        self,
        request: dingtalkyida__1__0_models.ListCommodityRequest,
    ) -> dingtalkyida__1__0_models.ListCommodityResponse:
        """
        @summary 多渠道列出商品列表
        
        @param request: ListCommodityRequest
        @return: ListCommodityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ListCommodityHeaders()
        return await self.list_commodity_with_options_async(request, headers, runtime)

    def list_connector_information_with_options(
        self,
        instance_id: str,
        request: dingtalkyida__1__0_models.ListConnectorInformationRequest,
        headers: dingtalkyida__1__0_models.ListConnectorInformationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ListConnectorInformationResponse:
        """
        @summary 多渠道插件概览
        
        @param request: ListConnectorInformationRequest
        @param headers: ListConnectorInformationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListConnectorInformationResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
            action='ListConnectorInformation',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/plugins/infos/{instance_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ListConnectorInformationResponse(),
            self.execute(params, req, runtime)
        )

    async def list_connector_information_with_options_async(
        self,
        instance_id: str,
        request: dingtalkyida__1__0_models.ListConnectorInformationRequest,
        headers: dingtalkyida__1__0_models.ListConnectorInformationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ListConnectorInformationResponse:
        """
        @summary 多渠道插件概览
        
        @param request: ListConnectorInformationRequest
        @param headers: ListConnectorInformationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListConnectorInformationResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
            action='ListConnectorInformation',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/plugins/infos/{instance_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ListConnectorInformationResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_connector_information(
        self,
        instance_id: str,
        request: dingtalkyida__1__0_models.ListConnectorInformationRequest,
    ) -> dingtalkyida__1__0_models.ListConnectorInformationResponse:
        """
        @summary 多渠道插件概览
        
        @param request: ListConnectorInformationRequest
        @return: ListConnectorInformationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ListConnectorInformationHeaders()
        return self.list_connector_information_with_options(instance_id, request, headers, runtime)

    async def list_connector_information_async(
        self,
        instance_id: str,
        request: dingtalkyida__1__0_models.ListConnectorInformationRequest,
    ) -> dingtalkyida__1__0_models.ListConnectorInformationResponse:
        """
        @summary 多渠道插件概览
        
        @param request: ListConnectorInformationRequest
        @return: ListConnectorInformationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ListConnectorInformationHeaders()
        return await self.list_connector_information_with_options_async(instance_id, request, headers, runtime)

    def list_form_remarks_with_options(
        self,
        request: dingtalkyida__1__0_models.ListFormRemarksRequest,
        headers: dingtalkyida__1__0_models.ListFormRemarksHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ListFormRemarksResponse:
        """
        @summary 查询表单实例评论列表
        
        @param request: ListFormRemarksRequest
        @param headers: ListFormRemarksHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListFormRemarksResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_instance_id_list):
            body['formInstanceIdList'] = request.form_instance_id_list
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='ListFormRemarks',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/remarks/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ListFormRemarksResponse(),
            self.execute(params, req, runtime)
        )

    async def list_form_remarks_with_options_async(
        self,
        request: dingtalkyida__1__0_models.ListFormRemarksRequest,
        headers: dingtalkyida__1__0_models.ListFormRemarksHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ListFormRemarksResponse:
        """
        @summary 查询表单实例评论列表
        
        @param request: ListFormRemarksRequest
        @param headers: ListFormRemarksHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListFormRemarksResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_instance_id_list):
            body['formInstanceIdList'] = request.form_instance_id_list
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='ListFormRemarks',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/remarks/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ListFormRemarksResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_form_remarks(
        self,
        request: dingtalkyida__1__0_models.ListFormRemarksRequest,
    ) -> dingtalkyida__1__0_models.ListFormRemarksResponse:
        """
        @summary 查询表单实例评论列表
        
        @param request: ListFormRemarksRequest
        @return: ListFormRemarksResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ListFormRemarksHeaders()
        return self.list_form_remarks_with_options(request, headers, runtime)

    async def list_form_remarks_async(
        self,
        request: dingtalkyida__1__0_models.ListFormRemarksRequest,
    ) -> dingtalkyida__1__0_models.ListFormRemarksResponse:
        """
        @summary 查询表单实例评论列表
        
        @param request: ListFormRemarksRequest
        @return: ListFormRemarksResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ListFormRemarksHeaders()
        return await self.list_form_remarks_with_options_async(request, headers, runtime)

    def list_navigation_by_form_type_with_options(
        self,
        request: dingtalkyida__1__0_models.ListNavigationByFormTypeRequest,
        headers: dingtalkyida__1__0_models.ListNavigationByFormTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ListNavigationByFormTypeResponse:
        """
        @summary 获取应用下的页面列表
        
        @param request: ListNavigationByFormTypeRequest
        @param headers: ListNavigationByFormTypeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListNavigationByFormTypeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_type):
            query['formType'] = request.form_type
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='ListNavigationByFormType',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/navigations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ListNavigationByFormTypeResponse(),
            self.execute(params, req, runtime)
        )

    async def list_navigation_by_form_type_with_options_async(
        self,
        request: dingtalkyida__1__0_models.ListNavigationByFormTypeRequest,
        headers: dingtalkyida__1__0_models.ListNavigationByFormTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ListNavigationByFormTypeResponse:
        """
        @summary 获取应用下的页面列表
        
        @param request: ListNavigationByFormTypeRequest
        @param headers: ListNavigationByFormTypeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListNavigationByFormTypeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_type):
            query['formType'] = request.form_type
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='ListNavigationByFormType',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/navigations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ListNavigationByFormTypeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_navigation_by_form_type(
        self,
        request: dingtalkyida__1__0_models.ListNavigationByFormTypeRequest,
    ) -> dingtalkyida__1__0_models.ListNavigationByFormTypeResponse:
        """
        @summary 获取应用下的页面列表
        
        @param request: ListNavigationByFormTypeRequest
        @return: ListNavigationByFormTypeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ListNavigationByFormTypeHeaders()
        return self.list_navigation_by_form_type_with_options(request, headers, runtime)

    async def list_navigation_by_form_type_async(
        self,
        request: dingtalkyida__1__0_models.ListNavigationByFormTypeRequest,
    ) -> dingtalkyida__1__0_models.ListNavigationByFormTypeResponse:
        """
        @summary 获取应用下的页面列表
        
        @param request: ListNavigationByFormTypeRequest
        @return: ListNavigationByFormTypeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ListNavigationByFormTypeHeaders()
        return await self.list_navigation_by_form_type_with_options_async(request, headers, runtime)

    def list_operation_logs_with_options(
        self,
        request: dingtalkyida__1__0_models.ListOperationLogsRequest,
        headers: dingtalkyida__1__0_models.ListOperationLogsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ListOperationLogsResponse:
        """
        @summary 查询表单的变更记录
        
        @param request: ListOperationLogsRequest
        @param headers: ListOperationLogsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListOperationLogsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_instance_id_list):
            body['formInstanceIdList'] = request.form_instance_id_list
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='ListOperationLogs',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/operationsLogs/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ListOperationLogsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_operation_logs_with_options_async(
        self,
        request: dingtalkyida__1__0_models.ListOperationLogsRequest,
        headers: dingtalkyida__1__0_models.ListOperationLogsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ListOperationLogsResponse:
        """
        @summary 查询表单的变更记录
        
        @param request: ListOperationLogsRequest
        @param headers: ListOperationLogsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListOperationLogsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_instance_id_list):
            body['formInstanceIdList'] = request.form_instance_id_list
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='ListOperationLogs',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/operationsLogs/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ListOperationLogsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_operation_logs(
        self,
        request: dingtalkyida__1__0_models.ListOperationLogsRequest,
    ) -> dingtalkyida__1__0_models.ListOperationLogsResponse:
        """
        @summary 查询表单的变更记录
        
        @param request: ListOperationLogsRequest
        @return: ListOperationLogsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ListOperationLogsHeaders()
        return self.list_operation_logs_with_options(request, headers, runtime)

    async def list_operation_logs_async(
        self,
        request: dingtalkyida__1__0_models.ListOperationLogsRequest,
    ) -> dingtalkyida__1__0_models.ListOperationLogsResponse:
        """
        @summary 查询表单的变更记录
        
        @param request: ListOperationLogsRequest
        @return: ListOperationLogsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ListOperationLogsHeaders()
        return await self.list_operation_logs_with_options_async(request, headers, runtime)

    def list_table_data_by_form_instance_id_table_id_with_options(
        self,
        form_instance_id: str,
        request: dingtalkyida__1__0_models.ListTableDataByFormInstanceIdTableIdRequest,
        headers: dingtalkyida__1__0_models.ListTableDataByFormInstanceIdTableIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ListTableDataByFormInstanceIdTableIdResponse:
        """
        @summary 获取子表单数据
        
        @param request: ListTableDataByFormInstanceIdTableIdRequest
        @param headers: ListTableDataByFormInstanceIdTableIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListTableDataByFormInstanceIdTableIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_uuid):
            query['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.table_field_id):
            query['tableFieldId'] = request.table_field_id
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
            action='ListTableDataByFormInstanceIdTableId',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/innerTables/{form_instance_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ListTableDataByFormInstanceIdTableIdResponse(),
            self.execute(params, req, runtime)
        )

    async def list_table_data_by_form_instance_id_table_id_with_options_async(
        self,
        form_instance_id: str,
        request: dingtalkyida__1__0_models.ListTableDataByFormInstanceIdTableIdRequest,
        headers: dingtalkyida__1__0_models.ListTableDataByFormInstanceIdTableIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ListTableDataByFormInstanceIdTableIdResponse:
        """
        @summary 获取子表单数据
        
        @param request: ListTableDataByFormInstanceIdTableIdRequest
        @param headers: ListTableDataByFormInstanceIdTableIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListTableDataByFormInstanceIdTableIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_uuid):
            query['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.table_field_id):
            query['tableFieldId'] = request.table_field_id
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
            action='ListTableDataByFormInstanceIdTableId',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/innerTables/{form_instance_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ListTableDataByFormInstanceIdTableIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_table_data_by_form_instance_id_table_id(
        self,
        form_instance_id: str,
        request: dingtalkyida__1__0_models.ListTableDataByFormInstanceIdTableIdRequest,
    ) -> dingtalkyida__1__0_models.ListTableDataByFormInstanceIdTableIdResponse:
        """
        @summary 获取子表单数据
        
        @param request: ListTableDataByFormInstanceIdTableIdRequest
        @return: ListTableDataByFormInstanceIdTableIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ListTableDataByFormInstanceIdTableIdHeaders()
        return self.list_table_data_by_form_instance_id_table_id_with_options(form_instance_id, request, headers, runtime)

    async def list_table_data_by_form_instance_id_table_id_async(
        self,
        form_instance_id: str,
        request: dingtalkyida__1__0_models.ListTableDataByFormInstanceIdTableIdRequest,
    ) -> dingtalkyida__1__0_models.ListTableDataByFormInstanceIdTableIdResponse:
        """
        @summary 获取子表单数据
        
        @param request: ListTableDataByFormInstanceIdTableIdRequest
        @return: ListTableDataByFormInstanceIdTableIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ListTableDataByFormInstanceIdTableIdHeaders()
        return await self.list_table_data_by_form_instance_id_table_id_with_options_async(form_instance_id, request, headers, runtime)

    def login_code_gen_with_options(
        self,
        request: dingtalkyida__1__0_models.LoginCodeGenRequest,
        headers: dingtalkyida__1__0_models.LoginCodeGenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.LoginCodeGenResponse:
        """
        @summary 生成宜搭登录态穿透用的code
        
        @param request: LoginCodeGenRequest
        @param headers: LoginCodeGenHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: LoginCodeGenResponse
        """
        UtilClient.validate_model(request)
        query = {}
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
            action='LoginCodeGen',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/authorizations/loginCodes',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.LoginCodeGenResponse(),
            self.execute(params, req, runtime)
        )

    async def login_code_gen_with_options_async(
        self,
        request: dingtalkyida__1__0_models.LoginCodeGenRequest,
        headers: dingtalkyida__1__0_models.LoginCodeGenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.LoginCodeGenResponse:
        """
        @summary 生成宜搭登录态穿透用的code
        
        @param request: LoginCodeGenRequest
        @param headers: LoginCodeGenHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: LoginCodeGenResponse
        """
        UtilClient.validate_model(request)
        query = {}
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
            action='LoginCodeGen',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/authorizations/loginCodes',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.LoginCodeGenResponse(),
            await self.execute_async(params, req, runtime)
        )

    def login_code_gen(
        self,
        request: dingtalkyida__1__0_models.LoginCodeGenRequest,
    ) -> dingtalkyida__1__0_models.LoginCodeGenResponse:
        """
        @summary 生成宜搭登录态穿透用的code
        
        @param request: LoginCodeGenRequest
        @return: LoginCodeGenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.LoginCodeGenHeaders()
        return self.login_code_gen_with_options(request, headers, runtime)

    async def login_code_gen_async(
        self,
        request: dingtalkyida__1__0_models.LoginCodeGenRequest,
    ) -> dingtalkyida__1__0_models.LoginCodeGenResponse:
        """
        @summary 生成宜搭登录态穿透用的code
        
        @param request: LoginCodeGenRequest
        @return: LoginCodeGenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.LoginCodeGenHeaders()
        return await self.login_code_gen_with_options_async(request, headers, runtime)

    def notify_authorization_result_with_options(
        self,
        request: dingtalkyida__1__0_models.NotifyAuthorizationResultRequest,
        headers: dingtalkyida__1__0_models.NotifyAuthorizationResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.NotifyAuthorizationResultResponse:
        """
        @summary 通知宜搭授权(购买)结果
        
        @param request: NotifyAuthorizationResultRequest
        @param headers: NotifyAuthorizationResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: NotifyAuthorizationResultResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.access_key):
            body['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.account_number):
            body['accountNumber'] = request.account_number
        if not UtilClient.is_unset(request.begin_time_gmt):
            body['beginTimeGMT'] = request.begin_time_gmt
        if not UtilClient.is_unset(request.caller_uid):
            body['callerUid'] = request.caller_uid
        if not UtilClient.is_unset(request.charge_type):
            body['chargeType'] = request.charge_type
        if not UtilClient.is_unset(request.commerce_type):
            body['commerceType'] = request.commerce_type
        if not UtilClient.is_unset(request.commodity_type):
            body['commodityType'] = request.commodity_type
        if not UtilClient.is_unset(request.end_time_gmt):
            body['endTimeGMT'] = request.end_time_gmt
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.instance_name):
            body['instanceName'] = request.instance_name
        if not UtilClient.is_unset(request.produce_code):
            body['produceCode'] = request.produce_code
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
            action='NotifyAuthorizationResult',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/authorizationResults/notify',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.NotifyAuthorizationResultResponse(),
            self.execute(params, req, runtime)
        )

    async def notify_authorization_result_with_options_async(
        self,
        request: dingtalkyida__1__0_models.NotifyAuthorizationResultRequest,
        headers: dingtalkyida__1__0_models.NotifyAuthorizationResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.NotifyAuthorizationResultResponse:
        """
        @summary 通知宜搭授权(购买)结果
        
        @param request: NotifyAuthorizationResultRequest
        @param headers: NotifyAuthorizationResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: NotifyAuthorizationResultResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.access_key):
            body['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.account_number):
            body['accountNumber'] = request.account_number
        if not UtilClient.is_unset(request.begin_time_gmt):
            body['beginTimeGMT'] = request.begin_time_gmt
        if not UtilClient.is_unset(request.caller_uid):
            body['callerUid'] = request.caller_uid
        if not UtilClient.is_unset(request.charge_type):
            body['chargeType'] = request.charge_type
        if not UtilClient.is_unset(request.commerce_type):
            body['commerceType'] = request.commerce_type
        if not UtilClient.is_unset(request.commodity_type):
            body['commodityType'] = request.commodity_type
        if not UtilClient.is_unset(request.end_time_gmt):
            body['endTimeGMT'] = request.end_time_gmt
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.instance_name):
            body['instanceName'] = request.instance_name
        if not UtilClient.is_unset(request.produce_code):
            body['produceCode'] = request.produce_code
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
            action='NotifyAuthorizationResult',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/authorizationResults/notify',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.NotifyAuthorizationResultResponse(),
            await self.execute_async(params, req, runtime)
        )

    def notify_authorization_result(
        self,
        request: dingtalkyida__1__0_models.NotifyAuthorizationResultRequest,
    ) -> dingtalkyida__1__0_models.NotifyAuthorizationResultResponse:
        """
        @summary 通知宜搭授权(购买)结果
        
        @param request: NotifyAuthorizationResultRequest
        @return: NotifyAuthorizationResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.NotifyAuthorizationResultHeaders()
        return self.notify_authorization_result_with_options(request, headers, runtime)

    async def notify_authorization_result_async(
        self,
        request: dingtalkyida__1__0_models.NotifyAuthorizationResultRequest,
    ) -> dingtalkyida__1__0_models.NotifyAuthorizationResultResponse:
        """
        @summary 通知宜搭授权(购买)结果
        
        @param request: NotifyAuthorizationResultRequest
        @return: NotifyAuthorizationResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.NotifyAuthorizationResultHeaders()
        return await self.notify_authorization_result_with_options_async(request, headers, runtime)

    def page_auto_flow_log_with_options(
        self,
        request: dingtalkyida__1__0_models.PageAutoFlowLogRequest,
        headers: dingtalkyida__1__0_models.PageAutoFlowLogHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.PageAutoFlowLogResponse:
        """
        @summary 分页查询宜搭流程自动化运行记录
        
        @param request: PageAutoFlowLogRequest
        @param headers: PageAutoFlowLogHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PageAutoFlowLogResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.end_time_gmt):
            body['endTimeGMT'] = request.end_time_gmt
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.process_code):
            body['processCode'] = request.process_code
        if not UtilClient.is_unset(request.start_time_gmt):
            body['startTimeGMT'] = request.start_time_gmt
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.token):
            body['token'] = request.token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='PageAutoFlowLog',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/logs/automations/paginationQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.PageAutoFlowLogResponse(),
            self.execute(params, req, runtime)
        )

    async def page_auto_flow_log_with_options_async(
        self,
        request: dingtalkyida__1__0_models.PageAutoFlowLogRequest,
        headers: dingtalkyida__1__0_models.PageAutoFlowLogHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.PageAutoFlowLogResponse:
        """
        @summary 分页查询宜搭流程自动化运行记录
        
        @param request: PageAutoFlowLogRequest
        @param headers: PageAutoFlowLogHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PageAutoFlowLogResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.end_time_gmt):
            body['endTimeGMT'] = request.end_time_gmt
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.process_code):
            body['processCode'] = request.process_code
        if not UtilClient.is_unset(request.start_time_gmt):
            body['startTimeGMT'] = request.start_time_gmt
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.token):
            body['token'] = request.token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='PageAutoFlowLog',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/logs/automations/paginationQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.PageAutoFlowLogResponse(),
            await self.execute_async(params, req, runtime)
        )

    def page_auto_flow_log(
        self,
        request: dingtalkyida__1__0_models.PageAutoFlowLogRequest,
    ) -> dingtalkyida__1__0_models.PageAutoFlowLogResponse:
        """
        @summary 分页查询宜搭流程自动化运行记录
        
        @param request: PageAutoFlowLogRequest
        @return: PageAutoFlowLogResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.PageAutoFlowLogHeaders()
        return self.page_auto_flow_log_with_options(request, headers, runtime)

    async def page_auto_flow_log_async(
        self,
        request: dingtalkyida__1__0_models.PageAutoFlowLogRequest,
    ) -> dingtalkyida__1__0_models.PageAutoFlowLogResponse:
        """
        @summary 分页查询宜搭流程自动化运行记录
        
        @param request: PageAutoFlowLogRequest
        @return: PageAutoFlowLogResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.PageAutoFlowLogHeaders()
        return await self.page_auto_flow_log_with_options_async(request, headers, runtime)

    def page_form_base_infos_with_options(
        self,
        request: dingtalkyida__1__0_models.PageFormBaseInfosRequest,
        headers: dingtalkyida__1__0_models.PageFormBaseInfosHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.PageFormBaseInfosResponse:
        """
        @summary 分页获取应用下表单列表
        
        @param request: PageFormBaseInfosRequest
        @param headers: PageFormBaseInfosHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PageFormBaseInfosResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_key):
            body['appKey'] = request.app_key
        if not UtilClient.is_unset(request.form_type_list):
            body['formTypeList'] = request.form_type_list
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.page_index):
            body['pageIndex'] = request.page_index
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='PageFormBaseInfos',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/forms/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.PageFormBaseInfosResponse(),
            self.execute(params, req, runtime)
        )

    async def page_form_base_infos_with_options_async(
        self,
        request: dingtalkyida__1__0_models.PageFormBaseInfosRequest,
        headers: dingtalkyida__1__0_models.PageFormBaseInfosHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.PageFormBaseInfosResponse:
        """
        @summary 分页获取应用下表单列表
        
        @param request: PageFormBaseInfosRequest
        @param headers: PageFormBaseInfosHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PageFormBaseInfosResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_key):
            body['appKey'] = request.app_key
        if not UtilClient.is_unset(request.form_type_list):
            body['formTypeList'] = request.form_type_list
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.page_index):
            body['pageIndex'] = request.page_index
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='PageFormBaseInfos',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/forms/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.PageFormBaseInfosResponse(),
            await self.execute_async(params, req, runtime)
        )

    def page_form_base_infos(
        self,
        request: dingtalkyida__1__0_models.PageFormBaseInfosRequest,
    ) -> dingtalkyida__1__0_models.PageFormBaseInfosResponse:
        """
        @summary 分页获取应用下表单列表
        
        @param request: PageFormBaseInfosRequest
        @return: PageFormBaseInfosResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.PageFormBaseInfosHeaders()
        return self.page_form_base_infos_with_options(request, headers, runtime)

    async def page_form_base_infos_async(
        self,
        request: dingtalkyida__1__0_models.PageFormBaseInfosRequest,
    ) -> dingtalkyida__1__0_models.PageFormBaseInfosResponse:
        """
        @summary 分页获取应用下表单列表
        
        @param request: PageFormBaseInfosRequest
        @return: PageFormBaseInfosResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.PageFormBaseInfosHeaders()
        return await self.page_form_base_infos_with_options_async(request, headers, runtime)

    def preview_published_process_with_options(
        self,
        request: dingtalkyida__1__0_models.PreviewPublishedProcessRequest,
        headers: dingtalkyida__1__0_models.PreviewPublishedProcessHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.PreviewPublishedProcessResponse:
        """
        @summary 预览审批流程
        
        @param request: PreviewPublishedProcessRequest
        @param headers: PreviewPublishedProcessHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PreviewPublishedProcessResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.department_id):
            body['departmentId'] = request.department_id
        if not UtilClient.is_unset(request.form_data_json):
            body['formDataJson'] = request.form_data_json
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.process_code):
            body['processCode'] = request.process_code
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='PreviewPublishedProcess',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/processes/preview',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.PreviewPublishedProcessResponse(),
            self.execute(params, req, runtime)
        )

    async def preview_published_process_with_options_async(
        self,
        request: dingtalkyida__1__0_models.PreviewPublishedProcessRequest,
        headers: dingtalkyida__1__0_models.PreviewPublishedProcessHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.PreviewPublishedProcessResponse:
        """
        @summary 预览审批流程
        
        @param request: PreviewPublishedProcessRequest
        @param headers: PreviewPublishedProcessHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PreviewPublishedProcessResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.department_id):
            body['departmentId'] = request.department_id
        if not UtilClient.is_unset(request.form_data_json):
            body['formDataJson'] = request.form_data_json
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.process_code):
            body['processCode'] = request.process_code
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='PreviewPublishedProcess',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/processes/preview',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.PreviewPublishedProcessResponse(),
            await self.execute_async(params, req, runtime)
        )

    def preview_published_process(
        self,
        request: dingtalkyida__1__0_models.PreviewPublishedProcessRequest,
    ) -> dingtalkyida__1__0_models.PreviewPublishedProcessResponse:
        """
        @summary 预览审批流程
        
        @param request: PreviewPublishedProcessRequest
        @return: PreviewPublishedProcessResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.PreviewPublishedProcessHeaders()
        return self.preview_published_process_with_options(request, headers, runtime)

    async def preview_published_process_async(
        self,
        request: dingtalkyida__1__0_models.PreviewPublishedProcessRequest,
    ) -> dingtalkyida__1__0_models.PreviewPublishedProcessResponse:
        """
        @summary 预览审批流程
        
        @param request: PreviewPublishedProcessRequest
        @return: PreviewPublishedProcessResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.PreviewPublishedProcessHeaders()
        return await self.preview_published_process_with_options_async(request, headers, runtime)

    def query_service_record_with_options(
        self,
        request: dingtalkyida__1__0_models.QueryServiceRecordRequest,
        headers: dingtalkyida__1__0_models.QueryServiceRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.QueryServiceRecordResponse:
        """
        @summary 查询服务调用记录
        
        @param request: QueryServiceRecordRequest
        @param headers: QueryServiceRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryServiceRecordResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_uuid):
            query['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.hook_type):
            query['hookType'] = request.hook_type
        if not UtilClient.is_unset(request.hook_uuid):
            query['hookUuid'] = request.hook_uuid
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.invoke_after_date_gmt):
            query['invokeAfterDateGMT'] = request.invoke_after_date_gmt
        if not UtilClient.is_unset(request.invoke_before_date_gmt):
            query['invokeBeforeDateGMT'] = request.invoke_before_date_gmt
        if not UtilClient.is_unset(request.invoke_status):
            query['invokeStatus'] = request.invoke_status
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.request_url):
            query['requestUrl'] = request.request_url
        if not UtilClient.is_unset(request.source_uuid):
            query['sourceUuid'] = request.source_uuid
        if not UtilClient.is_unset(request.success):
            query['success'] = request.success
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='QueryServiceRecord',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/services/invocationRecords',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.QueryServiceRecordResponse(),
            self.execute(params, req, runtime)
        )

    async def query_service_record_with_options_async(
        self,
        request: dingtalkyida__1__0_models.QueryServiceRecordRequest,
        headers: dingtalkyida__1__0_models.QueryServiceRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.QueryServiceRecordResponse:
        """
        @summary 查询服务调用记录
        
        @param request: QueryServiceRecordRequest
        @param headers: QueryServiceRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryServiceRecordResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_uuid):
            query['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.hook_type):
            query['hookType'] = request.hook_type
        if not UtilClient.is_unset(request.hook_uuid):
            query['hookUuid'] = request.hook_uuid
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.invoke_after_date_gmt):
            query['invokeAfterDateGMT'] = request.invoke_after_date_gmt
        if not UtilClient.is_unset(request.invoke_before_date_gmt):
            query['invokeBeforeDateGMT'] = request.invoke_before_date_gmt
        if not UtilClient.is_unset(request.invoke_status):
            query['invokeStatus'] = request.invoke_status
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.request_url):
            query['requestUrl'] = request.request_url
        if not UtilClient.is_unset(request.source_uuid):
            query['sourceUuid'] = request.source_uuid
        if not UtilClient.is_unset(request.success):
            query['success'] = request.success
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='QueryServiceRecord',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/services/invocationRecords',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.QueryServiceRecordResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_service_record(
        self,
        request: dingtalkyida__1__0_models.QueryServiceRecordRequest,
    ) -> dingtalkyida__1__0_models.QueryServiceRecordResponse:
        """
        @summary 查询服务调用记录
        
        @param request: QueryServiceRecordRequest
        @return: QueryServiceRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.QueryServiceRecordHeaders()
        return self.query_service_record_with_options(request, headers, runtime)

    async def query_service_record_async(
        self,
        request: dingtalkyida__1__0_models.QueryServiceRecordRequest,
    ) -> dingtalkyida__1__0_models.QueryServiceRecordResponse:
        """
        @summary 查询服务调用记录
        
        @param request: QueryServiceRecordRequest
        @return: QueryServiceRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.QueryServiceRecordHeaders()
        return await self.query_service_record_with_options_async(request, headers, runtime)

    def redirect_task_with_options(
        self,
        request: dingtalkyida__1__0_models.RedirectTaskRequest,
        headers: dingtalkyida__1__0_models.RedirectTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.RedirectTaskResponse:
        """
        @summary 执行转交任务
        
        @param request: RedirectTaskRequest
        @param headers: RedirectTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RedirectTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.by_manager):
            body['byManager'] = request.by_manager
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.now_action_executor_id):
            body['nowActionExecutorId'] = request.now_action_executor_id
        if not UtilClient.is_unset(request.process_instance_id):
            body['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.task_id):
            body['taskId'] = request.task_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='RedirectTask',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/tasks/redirect',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.RedirectTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def redirect_task_with_options_async(
        self,
        request: dingtalkyida__1__0_models.RedirectTaskRequest,
        headers: dingtalkyida__1__0_models.RedirectTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.RedirectTaskResponse:
        """
        @summary 执行转交任务
        
        @param request: RedirectTaskRequest
        @param headers: RedirectTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RedirectTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.by_manager):
            body['byManager'] = request.by_manager
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.now_action_executor_id):
            body['nowActionExecutorId'] = request.now_action_executor_id
        if not UtilClient.is_unset(request.process_instance_id):
            body['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.task_id):
            body['taskId'] = request.task_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='RedirectTask',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/tasks/redirect',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.RedirectTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def redirect_task(
        self,
        request: dingtalkyida__1__0_models.RedirectTaskRequest,
    ) -> dingtalkyida__1__0_models.RedirectTaskResponse:
        """
        @summary 执行转交任务
        
        @param request: RedirectTaskRequest
        @return: RedirectTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.RedirectTaskHeaders()
        return self.redirect_task_with_options(request, headers, runtime)

    async def redirect_task_async(
        self,
        request: dingtalkyida__1__0_models.RedirectTaskRequest,
    ) -> dingtalkyida__1__0_models.RedirectTaskResponse:
        """
        @summary 执行转交任务
        
        @param request: RedirectTaskRequest
        @return: RedirectTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.RedirectTaskHeaders()
        return await self.redirect_task_with_options_async(request, headers, runtime)

    def refund_commodity_with_options(
        self,
        request: dingtalkyida__1__0_models.RefundCommodityRequest,
        headers: dingtalkyida__1__0_models.RefundCommodityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.RefundCommodityResponse:
        """
        @summary 多渠道退款
        
        @param request: RefundCommodityRequest
        @param headers: RefundCommodityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RefundCommodityResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
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
            action='RefundCommodity',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/appAuth/commodities/refund',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.RefundCommodityResponse(),
            self.execute(params, req, runtime)
        )

    async def refund_commodity_with_options_async(
        self,
        request: dingtalkyida__1__0_models.RefundCommodityRequest,
        headers: dingtalkyida__1__0_models.RefundCommodityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.RefundCommodityResponse:
        """
        @summary 多渠道退款
        
        @param request: RefundCommodityRequest
        @param headers: RefundCommodityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RefundCommodityResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
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
            action='RefundCommodity',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/appAuth/commodities/refund',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.RefundCommodityResponse(),
            await self.execute_async(params, req, runtime)
        )

    def refund_commodity(
        self,
        request: dingtalkyida__1__0_models.RefundCommodityRequest,
    ) -> dingtalkyida__1__0_models.RefundCommodityResponse:
        """
        @summary 多渠道退款
        
        @param request: RefundCommodityRequest
        @return: RefundCommodityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.RefundCommodityHeaders()
        return self.refund_commodity_with_options(request, headers, runtime)

    async def refund_commodity_async(
        self,
        request: dingtalkyida__1__0_models.RefundCommodityRequest,
    ) -> dingtalkyida__1__0_models.RefundCommodityResponse:
        """
        @summary 多渠道退款
        
        @param request: RefundCommodityRequest
        @return: RefundCommodityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.RefundCommodityHeaders()
        return await self.refund_commodity_with_options_async(request, headers, runtime)

    def register_accounts_with_options(
        self,
        request: dingtalkyida__1__0_models.RegisterAccountsRequest,
        headers: dingtalkyida__1__0_models.RegisterAccountsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.RegisterAccountsResponse:
        """
        @summary 多渠道注册
        
        @param request: RegisterAccountsRequest
        @param headers: RegisterAccountsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RegisterAccountsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.access_key):
            body['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.active_code):
            body['activeCode'] = request.active_code
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
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
            action='RegisterAccounts',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/applicationAuthorizations/accounts/register',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.RegisterAccountsResponse(),
            self.execute(params, req, runtime)
        )

    async def register_accounts_with_options_async(
        self,
        request: dingtalkyida__1__0_models.RegisterAccountsRequest,
        headers: dingtalkyida__1__0_models.RegisterAccountsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.RegisterAccountsResponse:
        """
        @summary 多渠道注册
        
        @param request: RegisterAccountsRequest
        @param headers: RegisterAccountsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RegisterAccountsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.access_key):
            body['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.active_code):
            body['activeCode'] = request.active_code
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
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
            action='RegisterAccounts',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/applicationAuthorizations/accounts/register',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.RegisterAccountsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def register_accounts(
        self,
        request: dingtalkyida__1__0_models.RegisterAccountsRequest,
    ) -> dingtalkyida__1__0_models.RegisterAccountsResponse:
        """
        @summary 多渠道注册
        
        @param request: RegisterAccountsRequest
        @return: RegisterAccountsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.RegisterAccountsHeaders()
        return self.register_accounts_with_options(request, headers, runtime)

    async def register_accounts_async(
        self,
        request: dingtalkyida__1__0_models.RegisterAccountsRequest,
    ) -> dingtalkyida__1__0_models.RegisterAccountsResponse:
        """
        @summary 多渠道注册
        
        @param request: RegisterAccountsRequest
        @return: RegisterAccountsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.RegisterAccountsHeaders()
        return await self.register_accounts_with_options_async(request, headers, runtime)

    def release_commodity_with_options(
        self,
        request: dingtalkyida__1__0_models.ReleaseCommodityRequest,
        headers: dingtalkyida__1__0_models.ReleaseCommodityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ReleaseCommodityResponse:
        """
        @summary 多渠道释放
        
        @param request: ReleaseCommodityRequest
        @param headers: ReleaseCommodityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ReleaseCommodityResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
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
            action='ReleaseCommodity',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/appAuth/commodities/release',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ReleaseCommodityResponse(),
            self.execute(params, req, runtime)
        )

    async def release_commodity_with_options_async(
        self,
        request: dingtalkyida__1__0_models.ReleaseCommodityRequest,
        headers: dingtalkyida__1__0_models.ReleaseCommodityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ReleaseCommodityResponse:
        """
        @summary 多渠道释放
        
        @param request: ReleaseCommodityRequest
        @param headers: ReleaseCommodityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ReleaseCommodityResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
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
            action='ReleaseCommodity',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/appAuth/commodities/release',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ReleaseCommodityResponse(),
            await self.execute_async(params, req, runtime)
        )

    def release_commodity(
        self,
        request: dingtalkyida__1__0_models.ReleaseCommodityRequest,
    ) -> dingtalkyida__1__0_models.ReleaseCommodityResponse:
        """
        @summary 多渠道释放
        
        @param request: ReleaseCommodityRequest
        @return: ReleaseCommodityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ReleaseCommodityHeaders()
        return self.release_commodity_with_options(request, headers, runtime)

    async def release_commodity_async(
        self,
        request: dingtalkyida__1__0_models.ReleaseCommodityRequest,
    ) -> dingtalkyida__1__0_models.ReleaseCommodityResponse:
        """
        @summary 多渠道释放
        
        @param request: ReleaseCommodityRequest
        @return: ReleaseCommodityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ReleaseCommodityHeaders()
        return await self.release_commodity_with_options_async(request, headers, runtime)

    def remove_tenant_resource_with_options(
        self,
        caller_uid: str,
        request: dingtalkyida__1__0_models.RemoveTenantResourceRequest,
        headers: dingtalkyida__1__0_models.RemoveTenantResourceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.RemoveTenantResourceResponse:
        """
        @summary 租户到期30天后, 删除租户关联的资源
        
        @param request: RemoveTenantResourceRequest
        @param headers: RemoveTenantResourceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RemoveTenantResourceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
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
            action='RemoveTenantResource',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/applications/tenantRelatedResources/{caller_uid}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.RemoveTenantResourceResponse(),
            self.execute(params, req, runtime)
        )

    async def remove_tenant_resource_with_options_async(
        self,
        caller_uid: str,
        request: dingtalkyida__1__0_models.RemoveTenantResourceRequest,
        headers: dingtalkyida__1__0_models.RemoveTenantResourceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.RemoveTenantResourceResponse:
        """
        @summary 租户到期30天后, 删除租户关联的资源
        
        @param request: RemoveTenantResourceRequest
        @param headers: RemoveTenantResourceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RemoveTenantResourceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
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
            action='RemoveTenantResource',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/applications/tenantRelatedResources/{caller_uid}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.RemoveTenantResourceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def remove_tenant_resource(
        self,
        caller_uid: str,
        request: dingtalkyida__1__0_models.RemoveTenantResourceRequest,
    ) -> dingtalkyida__1__0_models.RemoveTenantResourceResponse:
        """
        @summary 租户到期30天后, 删除租户关联的资源
        
        @param request: RemoveTenantResourceRequest
        @return: RemoveTenantResourceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.RemoveTenantResourceHeaders()
        return self.remove_tenant_resource_with_options(caller_uid, request, headers, runtime)

    async def remove_tenant_resource_async(
        self,
        caller_uid: str,
        request: dingtalkyida__1__0_models.RemoveTenantResourceRequest,
    ) -> dingtalkyida__1__0_models.RemoveTenantResourceResponse:
        """
        @summary 租户到期30天后, 删除租户关联的资源
        
        @param request: RemoveTenantResourceRequest
        @return: RemoveTenantResourceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.RemoveTenantResourceHeaders()
        return await self.remove_tenant_resource_with_options_async(caller_uid, request, headers, runtime)

    def render_batch_callback_with_options(
        self,
        request: dingtalkyida__1__0_models.RenderBatchCallbackRequest,
        headers: dingtalkyida__1__0_models.RenderBatchCallbackHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.RenderBatchCallbackResponse:
        """
        @summary 宜搭vpc批量打印回调
        
        @param request: RenderBatchCallbackRequest
        @param headers: RenderBatchCallbackHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RenderBatchCallbackResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.file_size):
            body['fileSize'] = request.file_size
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.namespace):
            body['namespace'] = request.namespace
        if not UtilClient.is_unset(request.oss_url):
            body['ossUrl'] = request.oss_url
        if not UtilClient.is_unset(request.sequence_id):
            body['sequenceId'] = request.sequence_id
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.time_zone):
            body['timeZone'] = request.time_zone
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='RenderBatchCallback',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/printings/callbacks/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.RenderBatchCallbackResponse(),
            self.execute(params, req, runtime)
        )

    async def render_batch_callback_with_options_async(
        self,
        request: dingtalkyida__1__0_models.RenderBatchCallbackRequest,
        headers: dingtalkyida__1__0_models.RenderBatchCallbackHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.RenderBatchCallbackResponse:
        """
        @summary 宜搭vpc批量打印回调
        
        @param request: RenderBatchCallbackRequest
        @param headers: RenderBatchCallbackHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RenderBatchCallbackResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.file_size):
            body['fileSize'] = request.file_size
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.namespace):
            body['namespace'] = request.namespace
        if not UtilClient.is_unset(request.oss_url):
            body['ossUrl'] = request.oss_url
        if not UtilClient.is_unset(request.sequence_id):
            body['sequenceId'] = request.sequence_id
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.time_zone):
            body['timeZone'] = request.time_zone
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='RenderBatchCallback',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/printings/callbacks/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.RenderBatchCallbackResponse(),
            await self.execute_async(params, req, runtime)
        )

    def render_batch_callback(
        self,
        request: dingtalkyida__1__0_models.RenderBatchCallbackRequest,
    ) -> dingtalkyida__1__0_models.RenderBatchCallbackResponse:
        """
        @summary 宜搭vpc批量打印回调
        
        @param request: RenderBatchCallbackRequest
        @return: RenderBatchCallbackResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.RenderBatchCallbackHeaders()
        return self.render_batch_callback_with_options(request, headers, runtime)

    async def render_batch_callback_async(
        self,
        request: dingtalkyida__1__0_models.RenderBatchCallbackRequest,
    ) -> dingtalkyida__1__0_models.RenderBatchCallbackResponse:
        """
        @summary 宜搭vpc批量打印回调
        
        @param request: RenderBatchCallbackRequest
        @return: RenderBatchCallbackResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.RenderBatchCallbackHeaders()
        return await self.render_batch_callback_with_options_async(request, headers, runtime)

    def renew_application_authorization_service_order_with_options(
        self,
        request: dingtalkyida__1__0_models.RenewApplicationAuthorizationServiceOrderRequest,
        headers: dingtalkyida__1__0_models.RenewApplicationAuthorizationServiceOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.RenewApplicationAuthorizationServiceOrderResponse:
        """
        @summary 多渠道续费
        
        @param request: RenewApplicationAuthorizationServiceOrderRequest
        @param headers: RenewApplicationAuthorizationServiceOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RenewApplicationAuthorizationServiceOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.access_key):
            body['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_union_id):
            body['callerUnionId'] = request.caller_union_id
        if not UtilClient.is_unset(request.end_time_gmt):
            body['endTimeGMT'] = request.end_time_gmt
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
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
            action='RenewApplicationAuthorizationServiceOrder',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/applicationAuthorizations/orders/renew',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.RenewApplicationAuthorizationServiceOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def renew_application_authorization_service_order_with_options_async(
        self,
        request: dingtalkyida__1__0_models.RenewApplicationAuthorizationServiceOrderRequest,
        headers: dingtalkyida__1__0_models.RenewApplicationAuthorizationServiceOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.RenewApplicationAuthorizationServiceOrderResponse:
        """
        @summary 多渠道续费
        
        @param request: RenewApplicationAuthorizationServiceOrderRequest
        @param headers: RenewApplicationAuthorizationServiceOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RenewApplicationAuthorizationServiceOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.access_key):
            body['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_union_id):
            body['callerUnionId'] = request.caller_union_id
        if not UtilClient.is_unset(request.end_time_gmt):
            body['endTimeGMT'] = request.end_time_gmt
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
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
            action='RenewApplicationAuthorizationServiceOrder',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/applicationAuthorizations/orders/renew',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.RenewApplicationAuthorizationServiceOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def renew_application_authorization_service_order(
        self,
        request: dingtalkyida__1__0_models.RenewApplicationAuthorizationServiceOrderRequest,
    ) -> dingtalkyida__1__0_models.RenewApplicationAuthorizationServiceOrderResponse:
        """
        @summary 多渠道续费
        
        @param request: RenewApplicationAuthorizationServiceOrderRequest
        @return: RenewApplicationAuthorizationServiceOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.RenewApplicationAuthorizationServiceOrderHeaders()
        return self.renew_application_authorization_service_order_with_options(request, headers, runtime)

    async def renew_application_authorization_service_order_async(
        self,
        request: dingtalkyida__1__0_models.RenewApplicationAuthorizationServiceOrderRequest,
    ) -> dingtalkyida__1__0_models.RenewApplicationAuthorizationServiceOrderResponse:
        """
        @summary 多渠道续费
        
        @param request: RenewApplicationAuthorizationServiceOrderRequest
        @return: RenewApplicationAuthorizationServiceOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.RenewApplicationAuthorizationServiceOrderHeaders()
        return await self.renew_application_authorization_service_order_with_options_async(request, headers, runtime)

    def renew_tenant_order_with_options(
        self,
        request: dingtalkyida__1__0_models.RenewTenantOrderRequest,
        headers: dingtalkyida__1__0_models.RenewTenantOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.RenewTenantOrderResponse:
        """
        @summary 续费租户
        
        @param request: RenewTenantOrderRequest
        @param headers: RenewTenantOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RenewTenantOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.access_key):
            body['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_union_id):
            body['callerUnionId'] = request.caller_union_id
        if not UtilClient.is_unset(request.end_time_gmt):
            body['endTimeGMT'] = request.end_time_gmt
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
            action='RenewTenantOrder',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/tenants/reorder',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.RenewTenantOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def renew_tenant_order_with_options_async(
        self,
        request: dingtalkyida__1__0_models.RenewTenantOrderRequest,
        headers: dingtalkyida__1__0_models.RenewTenantOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.RenewTenantOrderResponse:
        """
        @summary 续费租户
        
        @param request: RenewTenantOrderRequest
        @param headers: RenewTenantOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RenewTenantOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.access_key):
            body['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_union_id):
            body['callerUnionId'] = request.caller_union_id
        if not UtilClient.is_unset(request.end_time_gmt):
            body['endTimeGMT'] = request.end_time_gmt
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
            action='RenewTenantOrder',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/tenants/reorder',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.RenewTenantOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def renew_tenant_order(
        self,
        request: dingtalkyida__1__0_models.RenewTenantOrderRequest,
    ) -> dingtalkyida__1__0_models.RenewTenantOrderResponse:
        """
        @summary 续费租户
        
        @param request: RenewTenantOrderRequest
        @return: RenewTenantOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.RenewTenantOrderHeaders()
        return self.renew_tenant_order_with_options(request, headers, runtime)

    async def renew_tenant_order_async(
        self,
        request: dingtalkyida__1__0_models.RenewTenantOrderRequest,
    ) -> dingtalkyida__1__0_models.RenewTenantOrderResponse:
        """
        @summary 续费租户
        
        @param request: RenewTenantOrderRequest
        @return: RenewTenantOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.RenewTenantOrderHeaders()
        return await self.renew_tenant_order_with_options_async(request, headers, runtime)

    def save_form_data_with_options(
        self,
        request: dingtalkyida__1__0_models.SaveFormDataRequest,
        headers: dingtalkyida__1__0_models.SaveFormDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.SaveFormDataResponse:
        """
        @summary 新增表单实例
        
        @param request: SaveFormDataRequest
        @param headers: SaveFormDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveFormDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_data_json):
            body['formDataJson'] = request.form_data_json
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='SaveFormData',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/instances',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.SaveFormDataResponse(),
            self.execute(params, req, runtime)
        )

    async def save_form_data_with_options_async(
        self,
        request: dingtalkyida__1__0_models.SaveFormDataRequest,
        headers: dingtalkyida__1__0_models.SaveFormDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.SaveFormDataResponse:
        """
        @summary 新增表单实例
        
        @param request: SaveFormDataRequest
        @param headers: SaveFormDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveFormDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_data_json):
            body['formDataJson'] = request.form_data_json
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='SaveFormData',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/instances',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.SaveFormDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def save_form_data(
        self,
        request: dingtalkyida__1__0_models.SaveFormDataRequest,
    ) -> dingtalkyida__1__0_models.SaveFormDataResponse:
        """
        @summary 新增表单实例
        
        @param request: SaveFormDataRequest
        @return: SaveFormDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.SaveFormDataHeaders()
        return self.save_form_data_with_options(request, headers, runtime)

    async def save_form_data_async(
        self,
        request: dingtalkyida__1__0_models.SaveFormDataRequest,
    ) -> dingtalkyida__1__0_models.SaveFormDataResponse:
        """
        @summary 新增表单实例
        
        @param request: SaveFormDataRequest
        @return: SaveFormDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.SaveFormDataHeaders()
        return await self.save_form_data_with_options_async(request, headers, runtime)

    def save_form_remark_with_options(
        self,
        request: dingtalkyida__1__0_models.SaveFormRemarkRequest,
        headers: dingtalkyida__1__0_models.SaveFormRemarkHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.SaveFormRemarkResponse:
        """
        @summary 提交表单/流程实例下的评论
        
        @param request: SaveFormRemarkRequest
        @param headers: SaveFormRemarkHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveFormRemarkResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.at_user_id):
            body['atUserId'] = request.at_user_id
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.form_instance_id):
            body['formInstanceId'] = request.form_instance_id
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.reply_id):
            body['replyId'] = request.reply_id
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='SaveFormRemark',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/remarks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.SaveFormRemarkResponse(),
            self.execute(params, req, runtime)
        )

    async def save_form_remark_with_options_async(
        self,
        request: dingtalkyida__1__0_models.SaveFormRemarkRequest,
        headers: dingtalkyida__1__0_models.SaveFormRemarkHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.SaveFormRemarkResponse:
        """
        @summary 提交表单/流程实例下的评论
        
        @param request: SaveFormRemarkRequest
        @param headers: SaveFormRemarkHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveFormRemarkResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.at_user_id):
            body['atUserId'] = request.at_user_id
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.form_instance_id):
            body['formInstanceId'] = request.form_instance_id
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.reply_id):
            body['replyId'] = request.reply_id
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='SaveFormRemark',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/remarks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.SaveFormRemarkResponse(),
            await self.execute_async(params, req, runtime)
        )

    def save_form_remark(
        self,
        request: dingtalkyida__1__0_models.SaveFormRemarkRequest,
    ) -> dingtalkyida__1__0_models.SaveFormRemarkResponse:
        """
        @summary 提交表单/流程实例下的评论
        
        @param request: SaveFormRemarkRequest
        @return: SaveFormRemarkResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.SaveFormRemarkHeaders()
        return self.save_form_remark_with_options(request, headers, runtime)

    async def save_form_remark_async(
        self,
        request: dingtalkyida__1__0_models.SaveFormRemarkRequest,
    ) -> dingtalkyida__1__0_models.SaveFormRemarkResponse:
        """
        @summary 提交表单/流程实例下的评论
        
        @param request: SaveFormRemarkRequest
        @return: SaveFormRemarkResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.SaveFormRemarkHeaders()
        return await self.save_form_remark_with_options_async(request, headers, runtime)

    def save_print_tpl_detail_info_with_options(
        self,
        request: dingtalkyida__1__0_models.SavePrintTplDetailInfoRequest,
        headers: dingtalkyida__1__0_models.SavePrintTplDetailInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.SavePrintTplDetailInfoResponse:
        """
        @summary 保存用户设计的模板结构
        
        @param request: SavePrintTplDetailInfoRequest
        @param headers: SavePrintTplDetailInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SavePrintTplDetailInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.file_name_config):
            body['fileNameConfig'] = request.file_name_config
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.form_version):
            body['formVersion'] = request.form_version
        if not UtilClient.is_unset(request.setting):
            body['setting'] = request.setting
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.vm):
            body['vm'] = request.vm
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
            action='SavePrintTplDetailInfo',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/printTemplates/printTplDetailInfos',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.SavePrintTplDetailInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def save_print_tpl_detail_info_with_options_async(
        self,
        request: dingtalkyida__1__0_models.SavePrintTplDetailInfoRequest,
        headers: dingtalkyida__1__0_models.SavePrintTplDetailInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.SavePrintTplDetailInfoResponse:
        """
        @summary 保存用户设计的模板结构
        
        @param request: SavePrintTplDetailInfoRequest
        @param headers: SavePrintTplDetailInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SavePrintTplDetailInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.file_name_config):
            body['fileNameConfig'] = request.file_name_config
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.form_version):
            body['formVersion'] = request.form_version
        if not UtilClient.is_unset(request.setting):
            body['setting'] = request.setting
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.vm):
            body['vm'] = request.vm
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
            action='SavePrintTplDetailInfo',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/printTemplates/printTplDetailInfos',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.SavePrintTplDetailInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def save_print_tpl_detail_info(
        self,
        request: dingtalkyida__1__0_models.SavePrintTplDetailInfoRequest,
    ) -> dingtalkyida__1__0_models.SavePrintTplDetailInfoResponse:
        """
        @summary 保存用户设计的模板结构
        
        @param request: SavePrintTplDetailInfoRequest
        @return: SavePrintTplDetailInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.SavePrintTplDetailInfoHeaders()
        return self.save_print_tpl_detail_info_with_options(request, headers, runtime)

    async def save_print_tpl_detail_info_async(
        self,
        request: dingtalkyida__1__0_models.SavePrintTplDetailInfoRequest,
    ) -> dingtalkyida__1__0_models.SavePrintTplDetailInfoResponse:
        """
        @summary 保存用户设计的模板结构
        
        @param request: SavePrintTplDetailInfoRequest
        @return: SavePrintTplDetailInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.SavePrintTplDetailInfoHeaders()
        return await self.save_print_tpl_detail_info_with_options_async(request, headers, runtime)

    def search_activation_code_with_options(
        self,
        request: dingtalkyida__1__0_models.SearchActivationCodeRequest,
        headers: dingtalkyida__1__0_models.SearchActivationCodeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.SearchActivationCodeResponse:
        """
        @summary 获取阿里云账号购买宜搭的账号信息
        
        @param request: SearchActivationCodeRequest
        @param headers: SearchActivationCodeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchActivationCodeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
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
            action='SearchActivationCode',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/activationCode/information',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.SearchActivationCodeResponse(),
            self.execute(params, req, runtime)
        )

    async def search_activation_code_with_options_async(
        self,
        request: dingtalkyida__1__0_models.SearchActivationCodeRequest,
        headers: dingtalkyida__1__0_models.SearchActivationCodeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.SearchActivationCodeResponse:
        """
        @summary 获取阿里云账号购买宜搭的账号信息
        
        @param request: SearchActivationCodeRequest
        @param headers: SearchActivationCodeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchActivationCodeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
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
            action='SearchActivationCode',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/activationCode/information',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.SearchActivationCodeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_activation_code(
        self,
        request: dingtalkyida__1__0_models.SearchActivationCodeRequest,
    ) -> dingtalkyida__1__0_models.SearchActivationCodeResponse:
        """
        @summary 获取阿里云账号购买宜搭的账号信息
        
        @param request: SearchActivationCodeRequest
        @return: SearchActivationCodeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.SearchActivationCodeHeaders()
        return self.search_activation_code_with_options(request, headers, runtime)

    async def search_activation_code_async(
        self,
        request: dingtalkyida__1__0_models.SearchActivationCodeRequest,
    ) -> dingtalkyida__1__0_models.SearchActivationCodeResponse:
        """
        @summary 获取阿里云账号购买宜搭的账号信息
        
        @param request: SearchActivationCodeRequest
        @return: SearchActivationCodeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.SearchActivationCodeHeaders()
        return await self.search_activation_code_with_options_async(request, headers, runtime)

    def search_employee_field_values_with_options(
        self,
        request: dingtalkyida__1__0_models.SearchEmployeeFieldValuesRequest,
        headers: dingtalkyida__1__0_models.SearchEmployeeFieldValuesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.SearchEmployeeFieldValuesResponse:
        """
        @summary 搜索表单中指定人员组件的值
        
        @param request: SearchEmployeeFieldValuesRequest
        @param headers: SearchEmployeeFieldValuesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchEmployeeFieldValuesResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.create_from_time_gmt):
            body['createFromTimeGMT'] = request.create_from_time_gmt
        if not UtilClient.is_unset(request.create_to_time_gmt):
            body['createToTimeGMT'] = request.create_to_time_gmt
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.modified_from_time_gmt):
            body['modifiedFromTimeGMT'] = request.modified_from_time_gmt
        if not UtilClient.is_unset(request.modified_to_time_gmt):
            body['modifiedToTimeGMT'] = request.modified_to_time_gmt
        if not UtilClient.is_unset(request.originator_id):
            body['originatorId'] = request.originator_id
        if not UtilClient.is_unset(request.search_field_json):
            body['searchFieldJson'] = request.search_field_json
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.target_field_json):
            body['targetFieldJson'] = request.target_field_json
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='SearchEmployeeFieldValues',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/employeeFields',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.SearchEmployeeFieldValuesResponse(),
            self.execute(params, req, runtime)
        )

    async def search_employee_field_values_with_options_async(
        self,
        request: dingtalkyida__1__0_models.SearchEmployeeFieldValuesRequest,
        headers: dingtalkyida__1__0_models.SearchEmployeeFieldValuesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.SearchEmployeeFieldValuesResponse:
        """
        @summary 搜索表单中指定人员组件的值
        
        @param request: SearchEmployeeFieldValuesRequest
        @param headers: SearchEmployeeFieldValuesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchEmployeeFieldValuesResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.create_from_time_gmt):
            body['createFromTimeGMT'] = request.create_from_time_gmt
        if not UtilClient.is_unset(request.create_to_time_gmt):
            body['createToTimeGMT'] = request.create_to_time_gmt
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.modified_from_time_gmt):
            body['modifiedFromTimeGMT'] = request.modified_from_time_gmt
        if not UtilClient.is_unset(request.modified_to_time_gmt):
            body['modifiedToTimeGMT'] = request.modified_to_time_gmt
        if not UtilClient.is_unset(request.originator_id):
            body['originatorId'] = request.originator_id
        if not UtilClient.is_unset(request.search_field_json):
            body['searchFieldJson'] = request.search_field_json
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.target_field_json):
            body['targetFieldJson'] = request.target_field_json
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='SearchEmployeeFieldValues',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/employeeFields',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.SearchEmployeeFieldValuesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_employee_field_values(
        self,
        request: dingtalkyida__1__0_models.SearchEmployeeFieldValuesRequest,
    ) -> dingtalkyida__1__0_models.SearchEmployeeFieldValuesResponse:
        """
        @summary 搜索表单中指定人员组件的值
        
        @param request: SearchEmployeeFieldValuesRequest
        @return: SearchEmployeeFieldValuesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.SearchEmployeeFieldValuesHeaders()
        return self.search_employee_field_values_with_options(request, headers, runtime)

    async def search_employee_field_values_async(
        self,
        request: dingtalkyida__1__0_models.SearchEmployeeFieldValuesRequest,
    ) -> dingtalkyida__1__0_models.SearchEmployeeFieldValuesResponse:
        """
        @summary 搜索表单中指定人员组件的值
        
        @param request: SearchEmployeeFieldValuesRequest
        @return: SearchEmployeeFieldValuesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.SearchEmployeeFieldValuesHeaders()
        return await self.search_employee_field_values_with_options_async(request, headers, runtime)

    def search_form_data_id_list_with_options(
        self,
        app_type: str,
        form_uuid: str,
        request: dingtalkyida__1__0_models.SearchFormDataIdListRequest,
        headers: dingtalkyida__1__0_models.SearchFormDataIdListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.SearchFormDataIdListResponse:
        """
        @summary 根据条件搜索表单实例 ID 列表
        
        @param request: SearchFormDataIdListRequest
        @param headers: SearchFormDataIdListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchFormDataIdListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        body = {}
        if not UtilClient.is_unset(request.create_from_time_gmt):
            body['createFromTimeGMT'] = request.create_from_time_gmt
        if not UtilClient.is_unset(request.create_to_time_gmt):
            body['createToTimeGMT'] = request.create_to_time_gmt
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.modified_from_time_gmt):
            body['modifiedFromTimeGMT'] = request.modified_from_time_gmt
        if not UtilClient.is_unset(request.modified_to_time_gmt):
            body['modifiedToTimeGMT'] = request.modified_to_time_gmt
        if not UtilClient.is_unset(request.originator_id):
            body['originatorId'] = request.originator_id
        if not UtilClient.is_unset(request.search_field_json):
            body['searchFieldJson'] = request.search_field_json
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='SearchFormDataIdList',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/instances/ids/{app_type}/{form_uuid}',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.SearchFormDataIdListResponse(),
            self.execute(params, req, runtime)
        )

    async def search_form_data_id_list_with_options_async(
        self,
        app_type: str,
        form_uuid: str,
        request: dingtalkyida__1__0_models.SearchFormDataIdListRequest,
        headers: dingtalkyida__1__0_models.SearchFormDataIdListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.SearchFormDataIdListResponse:
        """
        @summary 根据条件搜索表单实例 ID 列表
        
        @param request: SearchFormDataIdListRequest
        @param headers: SearchFormDataIdListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchFormDataIdListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        body = {}
        if not UtilClient.is_unset(request.create_from_time_gmt):
            body['createFromTimeGMT'] = request.create_from_time_gmt
        if not UtilClient.is_unset(request.create_to_time_gmt):
            body['createToTimeGMT'] = request.create_to_time_gmt
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.modified_from_time_gmt):
            body['modifiedFromTimeGMT'] = request.modified_from_time_gmt
        if not UtilClient.is_unset(request.modified_to_time_gmt):
            body['modifiedToTimeGMT'] = request.modified_to_time_gmt
        if not UtilClient.is_unset(request.originator_id):
            body['originatorId'] = request.originator_id
        if not UtilClient.is_unset(request.search_field_json):
            body['searchFieldJson'] = request.search_field_json
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='SearchFormDataIdList',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/instances/ids/{app_type}/{form_uuid}',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.SearchFormDataIdListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_form_data_id_list(
        self,
        app_type: str,
        form_uuid: str,
        request: dingtalkyida__1__0_models.SearchFormDataIdListRequest,
    ) -> dingtalkyida__1__0_models.SearchFormDataIdListResponse:
        """
        @summary 根据条件搜索表单实例 ID 列表
        
        @param request: SearchFormDataIdListRequest
        @return: SearchFormDataIdListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.SearchFormDataIdListHeaders()
        return self.search_form_data_id_list_with_options(app_type, form_uuid, request, headers, runtime)

    async def search_form_data_id_list_async(
        self,
        app_type: str,
        form_uuid: str,
        request: dingtalkyida__1__0_models.SearchFormDataIdListRequest,
    ) -> dingtalkyida__1__0_models.SearchFormDataIdListResponse:
        """
        @summary 根据条件搜索表单实例 ID 列表
        
        @param request: SearchFormDataIdListRequest
        @return: SearchFormDataIdListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.SearchFormDataIdListHeaders()
        return await self.search_form_data_id_list_with_options_async(app_type, form_uuid, request, headers, runtime)

    def search_form_data_removal_table_data_with_options(
        self,
        request: dingtalkyida__1__0_models.SearchFormDataRemovalTableDataRequest,
        headers: dingtalkyida__1__0_models.SearchFormDataRemovalTableDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.SearchFormDataRemovalTableDataResponse:
        """
        @summary 查询表单实例数据(不返回表单的子表单组件数据)
        
        @param request: SearchFormDataRemovalTableDataRequest
        @param headers: SearchFormDataRemovalTableDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchFormDataRemovalTableDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.create_from_time_gmt):
            body['createFromTimeGMT'] = request.create_from_time_gmt
        if not UtilClient.is_unset(request.create_to_time_gmt):
            body['createToTimeGMT'] = request.create_to_time_gmt
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.modified_from_time_gmt):
            body['modifiedFromTimeGMT'] = request.modified_from_time_gmt
        if not UtilClient.is_unset(request.modified_to_time_gmt):
            body['modifiedToTimeGMT'] = request.modified_to_time_gmt
        if not UtilClient.is_unset(request.order_config_json):
            body['orderConfigJson'] = request.order_config_json
        if not UtilClient.is_unset(request.originator_id):
            body['originatorId'] = request.originator_id
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_field_json):
            body['searchFieldJson'] = request.search_field_json
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='SearchFormDataRemovalTableData',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/instances/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.SearchFormDataRemovalTableDataResponse(),
            self.execute(params, req, runtime)
        )

    async def search_form_data_removal_table_data_with_options_async(
        self,
        request: dingtalkyida__1__0_models.SearchFormDataRemovalTableDataRequest,
        headers: dingtalkyida__1__0_models.SearchFormDataRemovalTableDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.SearchFormDataRemovalTableDataResponse:
        """
        @summary 查询表单实例数据(不返回表单的子表单组件数据)
        
        @param request: SearchFormDataRemovalTableDataRequest
        @param headers: SearchFormDataRemovalTableDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchFormDataRemovalTableDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.create_from_time_gmt):
            body['createFromTimeGMT'] = request.create_from_time_gmt
        if not UtilClient.is_unset(request.create_to_time_gmt):
            body['createToTimeGMT'] = request.create_to_time_gmt
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.modified_from_time_gmt):
            body['modifiedFromTimeGMT'] = request.modified_from_time_gmt
        if not UtilClient.is_unset(request.modified_to_time_gmt):
            body['modifiedToTimeGMT'] = request.modified_to_time_gmt
        if not UtilClient.is_unset(request.order_config_json):
            body['orderConfigJson'] = request.order_config_json
        if not UtilClient.is_unset(request.originator_id):
            body['originatorId'] = request.originator_id
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_field_json):
            body['searchFieldJson'] = request.search_field_json
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='SearchFormDataRemovalTableData',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/instances/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.SearchFormDataRemovalTableDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_form_data_removal_table_data(
        self,
        request: dingtalkyida__1__0_models.SearchFormDataRemovalTableDataRequest,
    ) -> dingtalkyida__1__0_models.SearchFormDataRemovalTableDataResponse:
        """
        @summary 查询表单实例数据(不返回表单的子表单组件数据)
        
        @param request: SearchFormDataRemovalTableDataRequest
        @return: SearchFormDataRemovalTableDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.SearchFormDataRemovalTableDataHeaders()
        return self.search_form_data_removal_table_data_with_options(request, headers, runtime)

    async def search_form_data_removal_table_data_async(
        self,
        request: dingtalkyida__1__0_models.SearchFormDataRemovalTableDataRequest,
    ) -> dingtalkyida__1__0_models.SearchFormDataRemovalTableDataResponse:
        """
        @summary 查询表单实例数据(不返回表单的子表单组件数据)
        
        @param request: SearchFormDataRemovalTableDataRequest
        @return: SearchFormDataRemovalTableDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.SearchFormDataRemovalTableDataHeaders()
        return await self.search_form_data_removal_table_data_with_options_async(request, headers, runtime)

    def search_form_data_second_generation_with_options(
        self,
        request: dingtalkyida__1__0_models.SearchFormDataSecondGenerationRequest,
        headers: dingtalkyida__1__0_models.SearchFormDataSecondGenerationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.SearchFormDataSecondGenerationResponse:
        """
        @summary 通过高级检索条件查询表单实例
        
        @param request: SearchFormDataSecondGenerationRequest
        @param headers: SearchFormDataSecondGenerationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchFormDataSecondGenerationResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.create_from_time_gmt):
            body['createFromTimeGMT'] = request.create_from_time_gmt
        if not UtilClient.is_unset(request.create_to_time_gmt):
            body['createToTimeGMT'] = request.create_to_time_gmt
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.modified_from_time_gmt):
            body['modifiedFromTimeGMT'] = request.modified_from_time_gmt
        if not UtilClient.is_unset(request.modified_to_time_gmt):
            body['modifiedToTimeGMT'] = request.modified_to_time_gmt
        if not UtilClient.is_unset(request.order_config_json):
            body['orderConfigJson'] = request.order_config_json
        if not UtilClient.is_unset(request.originator_id):
            body['originatorId'] = request.originator_id
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_condition):
            body['searchCondition'] = request.search_condition
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='SearchFormDataSecondGeneration',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/instances/advances/queryAll',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.SearchFormDataSecondGenerationResponse(),
            self.execute(params, req, runtime)
        )

    async def search_form_data_second_generation_with_options_async(
        self,
        request: dingtalkyida__1__0_models.SearchFormDataSecondGenerationRequest,
        headers: dingtalkyida__1__0_models.SearchFormDataSecondGenerationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.SearchFormDataSecondGenerationResponse:
        """
        @summary 通过高级检索条件查询表单实例
        
        @param request: SearchFormDataSecondGenerationRequest
        @param headers: SearchFormDataSecondGenerationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchFormDataSecondGenerationResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.create_from_time_gmt):
            body['createFromTimeGMT'] = request.create_from_time_gmt
        if not UtilClient.is_unset(request.create_to_time_gmt):
            body['createToTimeGMT'] = request.create_to_time_gmt
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.modified_from_time_gmt):
            body['modifiedFromTimeGMT'] = request.modified_from_time_gmt
        if not UtilClient.is_unset(request.modified_to_time_gmt):
            body['modifiedToTimeGMT'] = request.modified_to_time_gmt
        if not UtilClient.is_unset(request.order_config_json):
            body['orderConfigJson'] = request.order_config_json
        if not UtilClient.is_unset(request.originator_id):
            body['originatorId'] = request.originator_id
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_condition):
            body['searchCondition'] = request.search_condition
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='SearchFormDataSecondGeneration',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/instances/advances/queryAll',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.SearchFormDataSecondGenerationResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_form_data_second_generation(
        self,
        request: dingtalkyida__1__0_models.SearchFormDataSecondGenerationRequest,
    ) -> dingtalkyida__1__0_models.SearchFormDataSecondGenerationResponse:
        """
        @summary 通过高级检索条件查询表单实例
        
        @param request: SearchFormDataSecondGenerationRequest
        @return: SearchFormDataSecondGenerationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.SearchFormDataSecondGenerationHeaders()
        return self.search_form_data_second_generation_with_options(request, headers, runtime)

    async def search_form_data_second_generation_async(
        self,
        request: dingtalkyida__1__0_models.SearchFormDataSecondGenerationRequest,
    ) -> dingtalkyida__1__0_models.SearchFormDataSecondGenerationResponse:
        """
        @summary 通过高级检索条件查询表单实例
        
        @param request: SearchFormDataSecondGenerationRequest
        @return: SearchFormDataSecondGenerationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.SearchFormDataSecondGenerationHeaders()
        return await self.search_form_data_second_generation_with_options_async(request, headers, runtime)

    def search_form_data_second_generation_no_table_field_with_options(
        self,
        request: dingtalkyida__1__0_models.SearchFormDataSecondGenerationNoTableFieldRequest,
        headers: dingtalkyida__1__0_models.SearchFormDataSecondGenerationNoTableFieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.SearchFormDataSecondGenerationNoTableFieldResponse:
        """
        @summary 通过高级查询条件查询表单实例数据(不返回子表单组件数据)
        
        @param request: SearchFormDataSecondGenerationNoTableFieldRequest
        @param headers: SearchFormDataSecondGenerationNoTableFieldHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchFormDataSecondGenerationNoTableFieldResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.create_from_time_gmt):
            body['createFromTimeGMT'] = request.create_from_time_gmt
        if not UtilClient.is_unset(request.create_to_time_gmt):
            body['createToTimeGMT'] = request.create_to_time_gmt
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.modified_from_time_gmt):
            body['modifiedFromTimeGMT'] = request.modified_from_time_gmt
        if not UtilClient.is_unset(request.modified_to_time_gmt):
            body['modifiedToTimeGMT'] = request.modified_to_time_gmt
        if not UtilClient.is_unset(request.order_config_json):
            body['orderConfigJson'] = request.order_config_json
        if not UtilClient.is_unset(request.originator_id):
            body['originatorId'] = request.originator_id
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_condition):
            body['searchCondition'] = request.search_condition
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='SearchFormDataSecondGenerationNoTableField',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/instances/advances/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.SearchFormDataSecondGenerationNoTableFieldResponse(),
            self.execute(params, req, runtime)
        )

    async def search_form_data_second_generation_no_table_field_with_options_async(
        self,
        request: dingtalkyida__1__0_models.SearchFormDataSecondGenerationNoTableFieldRequest,
        headers: dingtalkyida__1__0_models.SearchFormDataSecondGenerationNoTableFieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.SearchFormDataSecondGenerationNoTableFieldResponse:
        """
        @summary 通过高级查询条件查询表单实例数据(不返回子表单组件数据)
        
        @param request: SearchFormDataSecondGenerationNoTableFieldRequest
        @param headers: SearchFormDataSecondGenerationNoTableFieldHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchFormDataSecondGenerationNoTableFieldResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.create_from_time_gmt):
            body['createFromTimeGMT'] = request.create_from_time_gmt
        if not UtilClient.is_unset(request.create_to_time_gmt):
            body['createToTimeGMT'] = request.create_to_time_gmt
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.modified_from_time_gmt):
            body['modifiedFromTimeGMT'] = request.modified_from_time_gmt
        if not UtilClient.is_unset(request.modified_to_time_gmt):
            body['modifiedToTimeGMT'] = request.modified_to_time_gmt
        if not UtilClient.is_unset(request.order_config_json):
            body['orderConfigJson'] = request.order_config_json
        if not UtilClient.is_unset(request.originator_id):
            body['originatorId'] = request.originator_id
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_condition):
            body['searchCondition'] = request.search_condition
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='SearchFormDataSecondGenerationNoTableField',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/instances/advances/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.SearchFormDataSecondGenerationNoTableFieldResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_form_data_second_generation_no_table_field(
        self,
        request: dingtalkyida__1__0_models.SearchFormDataSecondGenerationNoTableFieldRequest,
    ) -> dingtalkyida__1__0_models.SearchFormDataSecondGenerationNoTableFieldResponse:
        """
        @summary 通过高级查询条件查询表单实例数据(不返回子表单组件数据)
        
        @param request: SearchFormDataSecondGenerationNoTableFieldRequest
        @return: SearchFormDataSecondGenerationNoTableFieldResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.SearchFormDataSecondGenerationNoTableFieldHeaders()
        return self.search_form_data_second_generation_no_table_field_with_options(request, headers, runtime)

    async def search_form_data_second_generation_no_table_field_async(
        self,
        request: dingtalkyida__1__0_models.SearchFormDataSecondGenerationNoTableFieldRequest,
    ) -> dingtalkyida__1__0_models.SearchFormDataSecondGenerationNoTableFieldResponse:
        """
        @summary 通过高级查询条件查询表单实例数据(不返回子表单组件数据)
        
        @param request: SearchFormDataSecondGenerationNoTableFieldRequest
        @return: SearchFormDataSecondGenerationNoTableFieldResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.SearchFormDataSecondGenerationNoTableFieldHeaders()
        return await self.search_form_data_second_generation_no_table_field_with_options_async(request, headers, runtime)

    def search_form_datas_with_options(
        self,
        request: dingtalkyida__1__0_models.SearchFormDatasRequest,
        headers: dingtalkyida__1__0_models.SearchFormDatasHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.SearchFormDatasResponse:
        """
        @summary 根据条件搜索表单实例详情列表,对应原searchFormDatas
        
        @param request: SearchFormDatasRequest
        @param headers: SearchFormDatasHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchFormDatasResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.create_from_time_gmt):
            body['createFromTimeGMT'] = request.create_from_time_gmt
        if not UtilClient.is_unset(request.create_to_time_gmt):
            body['createToTimeGMT'] = request.create_to_time_gmt
        if not UtilClient.is_unset(request.current_page):
            body['currentPage'] = request.current_page
        if not UtilClient.is_unset(request.dynamic_order):
            body['dynamicOrder'] = request.dynamic_order
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.logic_operator):
            body['logicOperator'] = request.logic_operator
        if not UtilClient.is_unset(request.modified_from_time_gmt):
            body['modifiedFromTimeGMT'] = request.modified_from_time_gmt
        if not UtilClient.is_unset(request.modified_to_time_gmt):
            body['modifiedToTimeGMT'] = request.modified_to_time_gmt
        if not UtilClient.is_unset(request.originator_id):
            body['originatorId'] = request.originator_id
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_field_json):
            body['searchFieldJson'] = request.search_field_json
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='SearchFormDatas',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/instances/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.SearchFormDatasResponse(),
            self.execute(params, req, runtime)
        )

    async def search_form_datas_with_options_async(
        self,
        request: dingtalkyida__1__0_models.SearchFormDatasRequest,
        headers: dingtalkyida__1__0_models.SearchFormDatasHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.SearchFormDatasResponse:
        """
        @summary 根据条件搜索表单实例详情列表,对应原searchFormDatas
        
        @param request: SearchFormDatasRequest
        @param headers: SearchFormDatasHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchFormDatasResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.create_from_time_gmt):
            body['createFromTimeGMT'] = request.create_from_time_gmt
        if not UtilClient.is_unset(request.create_to_time_gmt):
            body['createToTimeGMT'] = request.create_to_time_gmt
        if not UtilClient.is_unset(request.current_page):
            body['currentPage'] = request.current_page
        if not UtilClient.is_unset(request.dynamic_order):
            body['dynamicOrder'] = request.dynamic_order
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.logic_operator):
            body['logicOperator'] = request.logic_operator
        if not UtilClient.is_unset(request.modified_from_time_gmt):
            body['modifiedFromTimeGMT'] = request.modified_from_time_gmt
        if not UtilClient.is_unset(request.modified_to_time_gmt):
            body['modifiedToTimeGMT'] = request.modified_to_time_gmt
        if not UtilClient.is_unset(request.originator_id):
            body['originatorId'] = request.originator_id
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_field_json):
            body['searchFieldJson'] = request.search_field_json
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='SearchFormDatas',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/instances/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.SearchFormDatasResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_form_datas(
        self,
        request: dingtalkyida__1__0_models.SearchFormDatasRequest,
    ) -> dingtalkyida__1__0_models.SearchFormDatasResponse:
        """
        @summary 根据条件搜索表单实例详情列表,对应原searchFormDatas
        
        @param request: SearchFormDatasRequest
        @return: SearchFormDatasResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.SearchFormDatasHeaders()
        return self.search_form_datas_with_options(request, headers, runtime)

    async def search_form_datas_async(
        self,
        request: dingtalkyida__1__0_models.SearchFormDatasRequest,
    ) -> dingtalkyida__1__0_models.SearchFormDatasResponse:
        """
        @summary 根据条件搜索表单实例详情列表,对应原searchFormDatas
        
        @param request: SearchFormDatasRequest
        @return: SearchFormDatasResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.SearchFormDatasHeaders()
        return await self.search_form_datas_with_options_async(request, headers, runtime)

    def start_instance_with_options(
        self,
        request: dingtalkyida__1__0_models.StartInstanceRequest,
        headers: dingtalkyida__1__0_models.StartInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.StartInstanceResponse:
        """
        @summary 发起新的流程实例
        
        @param request: StartInstanceRequest
        @param headers: StartInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: StartInstanceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.department_id):
            body['departmentId'] = request.department_id
        if not UtilClient.is_unset(request.form_data_json):
            body['formDataJson'] = request.form_data_json
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.process_code):
            body['processCode'] = request.process_code
        if not UtilClient.is_unset(request.process_data):
            body['processData'] = request.process_data
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='StartInstance',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/processes/instances/start',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.StartInstanceResponse(),
            self.execute(params, req, runtime)
        )

    async def start_instance_with_options_async(
        self,
        request: dingtalkyida__1__0_models.StartInstanceRequest,
        headers: dingtalkyida__1__0_models.StartInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.StartInstanceResponse:
        """
        @summary 发起新的流程实例
        
        @param request: StartInstanceRequest
        @param headers: StartInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: StartInstanceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.department_id):
            body['departmentId'] = request.department_id
        if not UtilClient.is_unset(request.form_data_json):
            body['formDataJson'] = request.form_data_json
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.process_code):
            body['processCode'] = request.process_code
        if not UtilClient.is_unset(request.process_data):
            body['processData'] = request.process_data
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='StartInstance',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/processes/instances/start',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.StartInstanceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def start_instance(
        self,
        request: dingtalkyida__1__0_models.StartInstanceRequest,
    ) -> dingtalkyida__1__0_models.StartInstanceResponse:
        """
        @summary 发起新的流程实例
        
        @param request: StartInstanceRequest
        @return: StartInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.StartInstanceHeaders()
        return self.start_instance_with_options(request, headers, runtime)

    async def start_instance_async(
        self,
        request: dingtalkyida__1__0_models.StartInstanceRequest,
    ) -> dingtalkyida__1__0_models.StartInstanceResponse:
        """
        @summary 发起新的流程实例
        
        @param request: StartInstanceRequest
        @return: StartInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.StartInstanceHeaders()
        return await self.start_instance_with_options_async(request, headers, runtime)

    def terminate_cloud_authorization_with_options(
        self,
        request: dingtalkyida__1__0_models.TerminateCloudAuthorizationRequest,
        headers: dingtalkyida__1__0_models.TerminateCloudAuthorizationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.TerminateCloudAuthorizationResponse:
        """
        @summary 阿里云合同到期终止
        
        @param request: TerminateCloudAuthorizationRequest
        @param headers: TerminateCloudAuthorizationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TerminateCloudAuthorizationResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.access_key):
            body['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_union_id):
            body['callerUnionId'] = request.caller_union_id
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
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
            action='TerminateCloudAuthorization',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/cloudAuthorizations/terminate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.TerminateCloudAuthorizationResponse(),
            self.execute(params, req, runtime)
        )

    async def terminate_cloud_authorization_with_options_async(
        self,
        request: dingtalkyida__1__0_models.TerminateCloudAuthorizationRequest,
        headers: dingtalkyida__1__0_models.TerminateCloudAuthorizationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.TerminateCloudAuthorizationResponse:
        """
        @summary 阿里云合同到期终止
        
        @param request: TerminateCloudAuthorizationRequest
        @param headers: TerminateCloudAuthorizationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TerminateCloudAuthorizationResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.access_key):
            body['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_union_id):
            body['callerUnionId'] = request.caller_union_id
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
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
            action='TerminateCloudAuthorization',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/cloudAuthorizations/terminate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.TerminateCloudAuthorizationResponse(),
            await self.execute_async(params, req, runtime)
        )

    def terminate_cloud_authorization(
        self,
        request: dingtalkyida__1__0_models.TerminateCloudAuthorizationRequest,
    ) -> dingtalkyida__1__0_models.TerminateCloudAuthorizationResponse:
        """
        @summary 阿里云合同到期终止
        
        @param request: TerminateCloudAuthorizationRequest
        @return: TerminateCloudAuthorizationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.TerminateCloudAuthorizationHeaders()
        return self.terminate_cloud_authorization_with_options(request, headers, runtime)

    async def terminate_cloud_authorization_async(
        self,
        request: dingtalkyida__1__0_models.TerminateCloudAuthorizationRequest,
    ) -> dingtalkyida__1__0_models.TerminateCloudAuthorizationResponse:
        """
        @summary 阿里云合同到期终止
        
        @param request: TerminateCloudAuthorizationRequest
        @return: TerminateCloudAuthorizationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.TerminateCloudAuthorizationHeaders()
        return await self.terminate_cloud_authorization_with_options_async(request, headers, runtime)

    def terminate_instance_with_options(
        self,
        request: dingtalkyida__1__0_models.TerminateInstanceRequest,
        headers: dingtalkyida__1__0_models.TerminateInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.TerminateInstanceResponse:
        """
        @summary 终止流程实例
        
        @param request: TerminateInstanceRequest
        @param headers: TerminateInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TerminateInstanceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.process_instance_id):
            query['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='TerminateInstance',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/processes/instances/terminate',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.TerminateInstanceResponse(),
            self.execute(params, req, runtime)
        )

    async def terminate_instance_with_options_async(
        self,
        request: dingtalkyida__1__0_models.TerminateInstanceRequest,
        headers: dingtalkyida__1__0_models.TerminateInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.TerminateInstanceResponse:
        """
        @summary 终止流程实例
        
        @param request: TerminateInstanceRequest
        @param headers: TerminateInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TerminateInstanceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.process_instance_id):
            query['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
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
            action='TerminateInstance',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/processes/instances/terminate',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.TerminateInstanceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def terminate_instance(
        self,
        request: dingtalkyida__1__0_models.TerminateInstanceRequest,
    ) -> dingtalkyida__1__0_models.TerminateInstanceResponse:
        """
        @summary 终止流程实例
        
        @param request: TerminateInstanceRequest
        @return: TerminateInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.TerminateInstanceHeaders()
        return self.terminate_instance_with_options(request, headers, runtime)

    async def terminate_instance_async(
        self,
        request: dingtalkyida__1__0_models.TerminateInstanceRequest,
    ) -> dingtalkyida__1__0_models.TerminateInstanceResponse:
        """
        @summary 终止流程实例
        
        @param request: TerminateInstanceRequest
        @return: TerminateInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.TerminateInstanceHeaders()
        return await self.terminate_instance_with_options_async(request, headers, runtime)

    def update_cloud_account_information_with_options(
        self,
        request: dingtalkyida__1__0_models.UpdateCloudAccountInformationRequest,
        headers: dingtalkyida__1__0_models.UpdateCloudAccountInformationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.UpdateCloudAccountInformationResponse:
        """
        @summary 变配阿里云账号对应的租户信息
        
        @param request: UpdateCloudAccountInformationRequest
        @param headers: UpdateCloudAccountInformationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateCloudAccountInformationResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.access_key):
            body['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.account_number):
            body['accountNumber'] = request.account_number
        if not UtilClient.is_unset(request.caller_union_id):
            body['callerUnionId'] = request.caller_union_id
        if not UtilClient.is_unset(request.commodity_type):
            body['commodityType'] = request.commodity_type
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
            action='UpdateCloudAccountInformation',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/cloudAccountInfos',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.UpdateCloudAccountInformationResponse(),
            self.execute(params, req, runtime)
        )

    async def update_cloud_account_information_with_options_async(
        self,
        request: dingtalkyida__1__0_models.UpdateCloudAccountInformationRequest,
        headers: dingtalkyida__1__0_models.UpdateCloudAccountInformationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.UpdateCloudAccountInformationResponse:
        """
        @summary 变配阿里云账号对应的租户信息
        
        @param request: UpdateCloudAccountInformationRequest
        @param headers: UpdateCloudAccountInformationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateCloudAccountInformationResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.access_key):
            body['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.account_number):
            body['accountNumber'] = request.account_number
        if not UtilClient.is_unset(request.caller_union_id):
            body['callerUnionId'] = request.caller_union_id
        if not UtilClient.is_unset(request.commodity_type):
            body['commodityType'] = request.commodity_type
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
            action='UpdateCloudAccountInformation',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/cloudAccountInfos',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.UpdateCloudAccountInformationResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_cloud_account_information(
        self,
        request: dingtalkyida__1__0_models.UpdateCloudAccountInformationRequest,
    ) -> dingtalkyida__1__0_models.UpdateCloudAccountInformationResponse:
        """
        @summary 变配阿里云账号对应的租户信息
        
        @param request: UpdateCloudAccountInformationRequest
        @return: UpdateCloudAccountInformationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.UpdateCloudAccountInformationHeaders()
        return self.update_cloud_account_information_with_options(request, headers, runtime)

    async def update_cloud_account_information_async(
        self,
        request: dingtalkyida__1__0_models.UpdateCloudAccountInformationRequest,
    ) -> dingtalkyida__1__0_models.UpdateCloudAccountInformationResponse:
        """
        @summary 变配阿里云账号对应的租户信息
        
        @param request: UpdateCloudAccountInformationRequest
        @return: UpdateCloudAccountInformationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.UpdateCloudAccountInformationHeaders()
        return await self.update_cloud_account_information_with_options_async(request, headers, runtime)

    def update_form_data_with_options(
        self,
        request: dingtalkyida__1__0_models.UpdateFormDataRequest,
        headers: dingtalkyida__1__0_models.UpdateFormDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.UpdateFormDataResponse:
        """
        @summary 更新表单实例
        
        @param request: UpdateFormDataRequest
        @param headers: UpdateFormDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateFormDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_instance_id):
            body['formInstanceId'] = request.form_instance_id
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.update_form_data_json):
            body['updateFormDataJson'] = request.update_form_data_json
        if not UtilClient.is_unset(request.use_latest_version):
            body['useLatestVersion'] = request.use_latest_version
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='UpdateFormData',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/instances',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.UpdateFormDataResponse(),
            self.execute(params, req, runtime)
        )

    async def update_form_data_with_options_async(
        self,
        request: dingtalkyida__1__0_models.UpdateFormDataRequest,
        headers: dingtalkyida__1__0_models.UpdateFormDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.UpdateFormDataResponse:
        """
        @summary 更新表单实例
        
        @param request: UpdateFormDataRequest
        @param headers: UpdateFormDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateFormDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_instance_id):
            body['formInstanceId'] = request.form_instance_id
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.update_form_data_json):
            body['updateFormDataJson'] = request.update_form_data_json
        if not UtilClient.is_unset(request.use_latest_version):
            body['useLatestVersion'] = request.use_latest_version
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='UpdateFormData',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/instances',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.UpdateFormDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_form_data(
        self,
        request: dingtalkyida__1__0_models.UpdateFormDataRequest,
    ) -> dingtalkyida__1__0_models.UpdateFormDataResponse:
        """
        @summary 更新表单实例
        
        @param request: UpdateFormDataRequest
        @return: UpdateFormDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.UpdateFormDataHeaders()
        return self.update_form_data_with_options(request, headers, runtime)

    async def update_form_data_async(
        self,
        request: dingtalkyida__1__0_models.UpdateFormDataRequest,
    ) -> dingtalkyida__1__0_models.UpdateFormDataResponse:
        """
        @summary 更新表单实例
        
        @param request: UpdateFormDataRequest
        @return: UpdateFormDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.UpdateFormDataHeaders()
        return await self.update_form_data_with_options_async(request, headers, runtime)

    def update_instance_with_options(
        self,
        request: dingtalkyida__1__0_models.UpdateInstanceRequest,
        headers: dingtalkyida__1__0_models.UpdateInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.UpdateInstanceResponse:
        """
        @summary 更新流程实例
        
        @param request: UpdateInstanceRequest
        @param headers: UpdateInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateInstanceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.process_instance_id):
            body['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.update_form_data_json):
            body['updateFormDataJson'] = request.update_form_data_json
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='UpdateInstance',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/processes/instances',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.UpdateInstanceResponse(),
            self.execute(params, req, runtime)
        )

    async def update_instance_with_options_async(
        self,
        request: dingtalkyida__1__0_models.UpdateInstanceRequest,
        headers: dingtalkyida__1__0_models.UpdateInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.UpdateInstanceResponse:
        """
        @summary 更新流程实例
        
        @param request: UpdateInstanceRequest
        @param headers: UpdateInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateInstanceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.process_instance_id):
            body['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.update_form_data_json):
            body['updateFormDataJson'] = request.update_form_data_json
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='UpdateInstance',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/processes/instances',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.UpdateInstanceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_instance(
        self,
        request: dingtalkyida__1__0_models.UpdateInstanceRequest,
    ) -> dingtalkyida__1__0_models.UpdateInstanceResponse:
        """
        @summary 更新流程实例
        
        @param request: UpdateInstanceRequest
        @return: UpdateInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.UpdateInstanceHeaders()
        return self.update_instance_with_options(request, headers, runtime)

    async def update_instance_async(
        self,
        request: dingtalkyida__1__0_models.UpdateInstanceRequest,
    ) -> dingtalkyida__1__0_models.UpdateInstanceResponse:
        """
        @summary 更新流程实例
        
        @param request: UpdateInstanceRequest
        @return: UpdateInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.UpdateInstanceHeaders()
        return await self.update_instance_with_options_async(request, headers, runtime)

    def update_status_with_options(
        self,
        request: dingtalkyida__1__0_models.UpdateStatusRequest,
        headers: dingtalkyida__1__0_models.UpdateStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.UpdateStatusResponse:
        """
        @summary 未知
        
        @param request: UpdateStatusRequest
        @param headers: UpdateStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.error_lines):
            body['errorLines'] = request.error_lines
        if not UtilClient.is_unset(request.import_sequence):
            body['importSequence'] = request.import_sequence
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='UpdateStatus',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/status',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.UpdateStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def update_status_with_options_async(
        self,
        request: dingtalkyida__1__0_models.UpdateStatusRequest,
        headers: dingtalkyida__1__0_models.UpdateStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.UpdateStatusResponse:
        """
        @summary 未知
        
        @param request: UpdateStatusRequest
        @param headers: UpdateStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.error_lines):
            body['errorLines'] = request.error_lines
        if not UtilClient.is_unset(request.import_sequence):
            body['importSequence'] = request.import_sequence
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='UpdateStatus',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/forms/status',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.UpdateStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_status(
        self,
        request: dingtalkyida__1__0_models.UpdateStatusRequest,
    ) -> dingtalkyida__1__0_models.UpdateStatusResponse:
        """
        @summary 未知
        
        @param request: UpdateStatusRequest
        @return: UpdateStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.UpdateStatusHeaders()
        return self.update_status_with_options(request, headers, runtime)

    async def update_status_async(
        self,
        request: dingtalkyida__1__0_models.UpdateStatusRequest,
    ) -> dingtalkyida__1__0_models.UpdateStatusResponse:
        """
        @summary 未知
        
        @param request: UpdateStatusRequest
        @return: UpdateStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.UpdateStatusHeaders()
        return await self.update_status_with_options_async(request, headers, runtime)

    def upgrade_tenant_information_with_options(
        self,
        request: dingtalkyida__1__0_models.UpgradeTenantInformationRequest,
        headers: dingtalkyida__1__0_models.UpgradeTenantInformationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.UpgradeTenantInformationResponse:
        """
        @summary 变配阿里云账号对应的租户信息
        
        @param request: UpgradeTenantInformationRequest
        @param headers: UpgradeTenantInformationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpgradeTenantInformationResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.access_key):
            body['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.account_number):
            body['accountNumber'] = request.account_number
        if not UtilClient.is_unset(request.caller_union_id):
            body['callerUnionId'] = request.caller_union_id
        if not UtilClient.is_unset(request.commodity_type):
            body['commodityType'] = request.commodity_type
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
            action='UpgradeTenantInformation',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/tenantInfos',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.UpgradeTenantInformationResponse(),
            self.execute(params, req, runtime)
        )

    async def upgrade_tenant_information_with_options_async(
        self,
        request: dingtalkyida__1__0_models.UpgradeTenantInformationRequest,
        headers: dingtalkyida__1__0_models.UpgradeTenantInformationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.UpgradeTenantInformationResponse:
        """
        @summary 变配阿里云账号对应的租户信息
        
        @param request: UpgradeTenantInformationRequest
        @param headers: UpgradeTenantInformationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpgradeTenantInformationResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.access_key):
            body['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.account_number):
            body['accountNumber'] = request.account_number
        if not UtilClient.is_unset(request.caller_union_id):
            body['callerUnionId'] = request.caller_union_id
        if not UtilClient.is_unset(request.commodity_type):
            body['commodityType'] = request.commodity_type
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
            action='UpgradeTenantInformation',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/tenantInfos',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.UpgradeTenantInformationResponse(),
            await self.execute_async(params, req, runtime)
        )

    def upgrade_tenant_information(
        self,
        request: dingtalkyida__1__0_models.UpgradeTenantInformationRequest,
    ) -> dingtalkyida__1__0_models.UpgradeTenantInformationResponse:
        """
        @summary 变配阿里云账号对应的租户信息
        
        @param request: UpgradeTenantInformationRequest
        @return: UpgradeTenantInformationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.UpgradeTenantInformationHeaders()
        return self.upgrade_tenant_information_with_options(request, headers, runtime)

    async def upgrade_tenant_information_async(
        self,
        request: dingtalkyida__1__0_models.UpgradeTenantInformationRequest,
    ) -> dingtalkyida__1__0_models.UpgradeTenantInformationResponse:
        """
        @summary 变配阿里云账号对应的租户信息
        
        @param request: UpgradeTenantInformationRequest
        @return: UpgradeTenantInformationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.UpgradeTenantInformationHeaders()
        return await self.upgrade_tenant_information_with_options_async(request, headers, runtime)

    def validate_application_authorization_order_with_options(
        self,
        instance_id: str,
        request: dingtalkyida__1__0_models.ValidateApplicationAuthorizationOrderRequest,
        headers: dingtalkyida__1__0_models.ValidateApplicationAuthorizationOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ValidateApplicationAuthorizationOrderResponse:
        """
        @summary 多渠道续费前校验
        
        @param request: ValidateApplicationAuthorizationOrderRequest
        @param headers: ValidateApplicationAuthorizationOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ValidateApplicationAuthorizationOrderResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_union_id):
            query['callerUnionId'] = request.caller_union_id
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
            action='ValidateApplicationAuthorizationOrder',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/applicationOrderUpdateAuthorizations/{instance_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ValidateApplicationAuthorizationOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def validate_application_authorization_order_with_options_async(
        self,
        instance_id: str,
        request: dingtalkyida__1__0_models.ValidateApplicationAuthorizationOrderRequest,
        headers: dingtalkyida__1__0_models.ValidateApplicationAuthorizationOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ValidateApplicationAuthorizationOrderResponse:
        """
        @summary 多渠道续费前校验
        
        @param request: ValidateApplicationAuthorizationOrderRequest
        @param headers: ValidateApplicationAuthorizationOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ValidateApplicationAuthorizationOrderResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_union_id):
            query['callerUnionId'] = request.caller_union_id
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
            action='ValidateApplicationAuthorizationOrder',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/applicationOrderUpdateAuthorizations/{instance_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ValidateApplicationAuthorizationOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def validate_application_authorization_order(
        self,
        instance_id: str,
        request: dingtalkyida__1__0_models.ValidateApplicationAuthorizationOrderRequest,
    ) -> dingtalkyida__1__0_models.ValidateApplicationAuthorizationOrderResponse:
        """
        @summary 多渠道续费前校验
        
        @param request: ValidateApplicationAuthorizationOrderRequest
        @return: ValidateApplicationAuthorizationOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ValidateApplicationAuthorizationOrderHeaders()
        return self.validate_application_authorization_order_with_options(instance_id, request, headers, runtime)

    async def validate_application_authorization_order_async(
        self,
        instance_id: str,
        request: dingtalkyida__1__0_models.ValidateApplicationAuthorizationOrderRequest,
    ) -> dingtalkyida__1__0_models.ValidateApplicationAuthorizationOrderResponse:
        """
        @summary 多渠道续费前校验
        
        @param request: ValidateApplicationAuthorizationOrderRequest
        @return: ValidateApplicationAuthorizationOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ValidateApplicationAuthorizationOrderHeaders()
        return await self.validate_application_authorization_order_with_options_async(instance_id, request, headers, runtime)

    def validate_application_authorization_service_order_with_options(
        self,
        caller_uid: str,
        request: dingtalkyida__1__0_models.ValidateApplicationAuthorizationServiceOrderRequest,
        headers: dingtalkyida__1__0_models.ValidateApplicationAuthorizationServiceOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ValidateApplicationAuthorizationServiceOrderResponse:
        """
        @summary 多渠道新购校验
        
        @param request: ValidateApplicationAuthorizationServiceOrderRequest
        @param headers: ValidateApplicationAuthorizationServiceOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ValidateApplicationAuthorizationServiceOrderResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
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
            action='ValidateApplicationAuthorizationServiceOrder',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/appsAuthorizations/freshOrderInfoReviews/{caller_uid}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ValidateApplicationAuthorizationServiceOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def validate_application_authorization_service_order_with_options_async(
        self,
        caller_uid: str,
        request: dingtalkyida__1__0_models.ValidateApplicationAuthorizationServiceOrderRequest,
        headers: dingtalkyida__1__0_models.ValidateApplicationAuthorizationServiceOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ValidateApplicationAuthorizationServiceOrderResponse:
        """
        @summary 多渠道新购校验
        
        @param request: ValidateApplicationAuthorizationServiceOrderRequest
        @param headers: ValidateApplicationAuthorizationServiceOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ValidateApplicationAuthorizationServiceOrderResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
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
            action='ValidateApplicationAuthorizationServiceOrder',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/appsAuthorizations/freshOrderInfoReviews/{caller_uid}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ValidateApplicationAuthorizationServiceOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def validate_application_authorization_service_order(
        self,
        caller_uid: str,
        request: dingtalkyida__1__0_models.ValidateApplicationAuthorizationServiceOrderRequest,
    ) -> dingtalkyida__1__0_models.ValidateApplicationAuthorizationServiceOrderResponse:
        """
        @summary 多渠道新购校验
        
        @param request: ValidateApplicationAuthorizationServiceOrderRequest
        @return: ValidateApplicationAuthorizationServiceOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ValidateApplicationAuthorizationServiceOrderHeaders()
        return self.validate_application_authorization_service_order_with_options(caller_uid, request, headers, runtime)

    async def validate_application_authorization_service_order_async(
        self,
        caller_uid: str,
        request: dingtalkyida__1__0_models.ValidateApplicationAuthorizationServiceOrderRequest,
    ) -> dingtalkyida__1__0_models.ValidateApplicationAuthorizationServiceOrderResponse:
        """
        @summary 多渠道新购校验
        
        @param request: ValidateApplicationAuthorizationServiceOrderRequest
        @return: ValidateApplicationAuthorizationServiceOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ValidateApplicationAuthorizationServiceOrderHeaders()
        return await self.validate_application_authorization_service_order_with_options_async(caller_uid, request, headers, runtime)

    def validate_application_service_order_upgrade_with_options(
        self,
        caller_unionid: str,
        request: dingtalkyida__1__0_models.ValidateApplicationServiceOrderUpgradeRequest,
        headers: dingtalkyida__1__0_models.ValidateApplicationServiceOrderUpgradeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ValidateApplicationServiceOrderUpgradeResponse:
        """
        @summary 校验变配
        
        @param request: ValidateApplicationServiceOrderUpgradeRequest
        @param headers: ValidateApplicationServiceOrderUpgradeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ValidateApplicationServiceOrderUpgradeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
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
            action='ValidateApplicationServiceOrderUpgrade',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/applications/orderValidations/{caller_unionid}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ValidateApplicationServiceOrderUpgradeResponse(),
            self.execute(params, req, runtime)
        )

    async def validate_application_service_order_upgrade_with_options_async(
        self,
        caller_unionid: str,
        request: dingtalkyida__1__0_models.ValidateApplicationServiceOrderUpgradeRequest,
        headers: dingtalkyida__1__0_models.ValidateApplicationServiceOrderUpgradeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ValidateApplicationServiceOrderUpgradeResponse:
        """
        @summary 校验变配
        
        @param request: ValidateApplicationServiceOrderUpgradeRequest
        @param headers: ValidateApplicationServiceOrderUpgradeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ValidateApplicationServiceOrderUpgradeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
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
            action='ValidateApplicationServiceOrderUpgrade',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/applications/orderValidations/{caller_unionid}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ValidateApplicationServiceOrderUpgradeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def validate_application_service_order_upgrade(
        self,
        caller_unionid: str,
        request: dingtalkyida__1__0_models.ValidateApplicationServiceOrderUpgradeRequest,
    ) -> dingtalkyida__1__0_models.ValidateApplicationServiceOrderUpgradeResponse:
        """
        @summary 校验变配
        
        @param request: ValidateApplicationServiceOrderUpgradeRequest
        @return: ValidateApplicationServiceOrderUpgradeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ValidateApplicationServiceOrderUpgradeHeaders()
        return self.validate_application_service_order_upgrade_with_options(caller_unionid, request, headers, runtime)

    async def validate_application_service_order_upgrade_async(
        self,
        caller_unionid: str,
        request: dingtalkyida__1__0_models.ValidateApplicationServiceOrderUpgradeRequest,
    ) -> dingtalkyida__1__0_models.ValidateApplicationServiceOrderUpgradeResponse:
        """
        @summary 校验变配
        
        @param request: ValidateApplicationServiceOrderUpgradeRequest
        @return: ValidateApplicationServiceOrderUpgradeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ValidateApplicationServiceOrderUpgradeHeaders()
        return await self.validate_application_service_order_upgrade_with_options_async(caller_unionid, request, headers, runtime)

    def validate_order_buy_with_options(
        self,
        request: dingtalkyida__1__0_models.ValidateOrderBuyRequest,
        headers: dingtalkyida__1__0_models.ValidateOrderBuyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ValidateOrderBuyResponse:
        """
        @summary 多渠道新购校验
        
        @param request: ValidateOrderBuyRequest
        @param headers: ValidateOrderBuyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ValidateOrderBuyResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
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
            action='ValidateOrderBuy',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/orderBuy/validate',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ValidateOrderBuyResponse(),
            self.execute(params, req, runtime)
        )

    async def validate_order_buy_with_options_async(
        self,
        request: dingtalkyida__1__0_models.ValidateOrderBuyRequest,
        headers: dingtalkyida__1__0_models.ValidateOrderBuyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ValidateOrderBuyResponse:
        """
        @summary 多渠道新购校验
        
        @param request: ValidateOrderBuyRequest
        @param headers: ValidateOrderBuyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ValidateOrderBuyResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
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
            action='ValidateOrderBuy',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/orderBuy/validate',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ValidateOrderBuyResponse(),
            await self.execute_async(params, req, runtime)
        )

    def validate_order_buy(
        self,
        request: dingtalkyida__1__0_models.ValidateOrderBuyRequest,
    ) -> dingtalkyida__1__0_models.ValidateOrderBuyResponse:
        """
        @summary 多渠道新购校验
        
        @param request: ValidateOrderBuyRequest
        @return: ValidateOrderBuyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ValidateOrderBuyHeaders()
        return self.validate_order_buy_with_options(request, headers, runtime)

    async def validate_order_buy_async(
        self,
        request: dingtalkyida__1__0_models.ValidateOrderBuyRequest,
    ) -> dingtalkyida__1__0_models.ValidateOrderBuyResponse:
        """
        @summary 多渠道新购校验
        
        @param request: ValidateOrderBuyRequest
        @return: ValidateOrderBuyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ValidateOrderBuyHeaders()
        return await self.validate_order_buy_with_options_async(request, headers, runtime)

    def validate_order_update_with_options(
        self,
        instance_id: str,
        request: dingtalkyida__1__0_models.ValidateOrderUpdateRequest,
        headers: dingtalkyida__1__0_models.ValidateOrderUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ValidateOrderUpdateResponse:
        """
        @summary 多渠道续费前校验
        
        @param request: ValidateOrderUpdateRequest
        @param headers: ValidateOrderUpdateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ValidateOrderUpdateResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
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
            action='ValidateOrderUpdate',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/orders/renewalReviews/{instance_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ValidateOrderUpdateResponse(),
            self.execute(params, req, runtime)
        )

    async def validate_order_update_with_options_async(
        self,
        instance_id: str,
        request: dingtalkyida__1__0_models.ValidateOrderUpdateRequest,
        headers: dingtalkyida__1__0_models.ValidateOrderUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ValidateOrderUpdateResponse:
        """
        @summary 多渠道续费前校验
        
        @param request: ValidateOrderUpdateRequest
        @param headers: ValidateOrderUpdateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ValidateOrderUpdateResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
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
            action='ValidateOrderUpdate',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/orders/renewalReviews/{instance_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ValidateOrderUpdateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def validate_order_update(
        self,
        instance_id: str,
        request: dingtalkyida__1__0_models.ValidateOrderUpdateRequest,
    ) -> dingtalkyida__1__0_models.ValidateOrderUpdateResponse:
        """
        @summary 多渠道续费前校验
        
        @param request: ValidateOrderUpdateRequest
        @return: ValidateOrderUpdateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ValidateOrderUpdateHeaders()
        return self.validate_order_update_with_options(instance_id, request, headers, runtime)

    async def validate_order_update_async(
        self,
        instance_id: str,
        request: dingtalkyida__1__0_models.ValidateOrderUpdateRequest,
    ) -> dingtalkyida__1__0_models.ValidateOrderUpdateResponse:
        """
        @summary 多渠道续费前校验
        
        @param request: ValidateOrderUpdateRequest
        @return: ValidateOrderUpdateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ValidateOrderUpdateHeaders()
        return await self.validate_order_update_with_options_async(instance_id, request, headers, runtime)

    def validate_order_upgrade_with_options(
        self,
        request: dingtalkyida__1__0_models.ValidateOrderUpgradeRequest,
        headers: dingtalkyida__1__0_models.ValidateOrderUpgradeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ValidateOrderUpgradeResponse:
        """
        @summary 多渠道升配前校验
        
        @param request: ValidateOrderUpgradeRequest
        @param headers: ValidateOrderUpgradeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ValidateOrderUpgradeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
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
            action='ValidateOrderUpgrade',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/orderUpgrade/validate',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ValidateOrderUpgradeResponse(),
            self.execute(params, req, runtime)
        )

    async def validate_order_upgrade_with_options_async(
        self,
        request: dingtalkyida__1__0_models.ValidateOrderUpgradeRequest,
        headers: dingtalkyida__1__0_models.ValidateOrderUpgradeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ValidateOrderUpgradeResponse:
        """
        @summary 多渠道升配前校验
        
        @param request: ValidateOrderUpgradeRequest
        @param headers: ValidateOrderUpgradeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ValidateOrderUpgradeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
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
            action='ValidateOrderUpgrade',
            version='yida_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yida/apps/orderUpgrade/validate',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ValidateOrderUpgradeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def validate_order_upgrade(
        self,
        request: dingtalkyida__1__0_models.ValidateOrderUpgradeRequest,
    ) -> dingtalkyida__1__0_models.ValidateOrderUpgradeResponse:
        """
        @summary 多渠道升配前校验
        
        @param request: ValidateOrderUpgradeRequest
        @return: ValidateOrderUpgradeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ValidateOrderUpgradeHeaders()
        return self.validate_order_upgrade_with_options(request, headers, runtime)

    async def validate_order_upgrade_async(
        self,
        request: dingtalkyida__1__0_models.ValidateOrderUpgradeRequest,
    ) -> dingtalkyida__1__0_models.ValidateOrderUpgradeResponse:
        """
        @summary 多渠道升配前校验
        
        @param request: ValidateOrderUpgradeRequest
        @return: ValidateOrderUpgradeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ValidateOrderUpgradeHeaders()
        return await self.validate_order_upgrade_with_options_async(request, headers, runtime)
