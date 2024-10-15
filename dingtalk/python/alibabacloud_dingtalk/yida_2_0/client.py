# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.yida_2_0 import models as dingtalkyida__2__0_models
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

    def create_or_update_form_data_with_options(
        self,
        request: dingtalkyida__2__0_models.CreateOrUpdateFormDataRequest,
        headers: dingtalkyida__2__0_models.CreateOrUpdateFormDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__2__0_models.CreateOrUpdateFormDataResponse:
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
        if not UtilClient.is_unset(request.use_alias):
            body['useAlias'] = request.use_alias
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
            version='yida_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/yida/forms/instances/insertOrUpdate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__2__0_models.CreateOrUpdateFormDataResponse(),
            self.execute(params, req, runtime)
        )

    async def create_or_update_form_data_with_options_async(
        self,
        request: dingtalkyida__2__0_models.CreateOrUpdateFormDataRequest,
        headers: dingtalkyida__2__0_models.CreateOrUpdateFormDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__2__0_models.CreateOrUpdateFormDataResponse:
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
        if not UtilClient.is_unset(request.use_alias):
            body['useAlias'] = request.use_alias
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
            version='yida_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/yida/forms/instances/insertOrUpdate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__2__0_models.CreateOrUpdateFormDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_or_update_form_data(
        self,
        request: dingtalkyida__2__0_models.CreateOrUpdateFormDataRequest,
    ) -> dingtalkyida__2__0_models.CreateOrUpdateFormDataResponse:
        """
        @summary 新增或更新表单实例
        
        @param request: CreateOrUpdateFormDataRequest
        @return: CreateOrUpdateFormDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__2__0_models.CreateOrUpdateFormDataHeaders()
        return self.create_or_update_form_data_with_options(request, headers, runtime)

    async def create_or_update_form_data_async(
        self,
        request: dingtalkyida__2__0_models.CreateOrUpdateFormDataRequest,
    ) -> dingtalkyida__2__0_models.CreateOrUpdateFormDataResponse:
        """
        @summary 新增或更新表单实例
        
        @param request: CreateOrUpdateFormDataRequest
        @return: CreateOrUpdateFormDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__2__0_models.CreateOrUpdateFormDataHeaders()
        return await self.create_or_update_form_data_with_options_async(request, headers, runtime)

    def get_form_component_alias_list_with_options(
        self,
        app_type: str,
        form_uuid: str,
        request: dingtalkyida__2__0_models.GetFormComponentAliasListRequest,
        headers: dingtalkyida__2__0_models.GetFormComponentAliasListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__2__0_models.GetFormComponentAliasListResponse:
        """
        @summary 获取表单组件别名列表
        
        @param request: GetFormComponentAliasListRequest
        @param headers: GetFormComponentAliasListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFormComponentAliasListResponse
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
            action='GetFormComponentAliasList',
            version='yida_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/yida/forms/component/alias/{app_type}/{form_uuid}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__2__0_models.GetFormComponentAliasListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_form_component_alias_list_with_options_async(
        self,
        app_type: str,
        form_uuid: str,
        request: dingtalkyida__2__0_models.GetFormComponentAliasListRequest,
        headers: dingtalkyida__2__0_models.GetFormComponentAliasListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__2__0_models.GetFormComponentAliasListResponse:
        """
        @summary 获取表单组件别名列表
        
        @param request: GetFormComponentAliasListRequest
        @param headers: GetFormComponentAliasListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFormComponentAliasListResponse
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
            action='GetFormComponentAliasList',
            version='yida_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/yida/forms/component/alias/{app_type}/{form_uuid}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__2__0_models.GetFormComponentAliasListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_form_component_alias_list(
        self,
        app_type: str,
        form_uuid: str,
        request: dingtalkyida__2__0_models.GetFormComponentAliasListRequest,
    ) -> dingtalkyida__2__0_models.GetFormComponentAliasListResponse:
        """
        @summary 获取表单组件别名列表
        
        @param request: GetFormComponentAliasListRequest
        @return: GetFormComponentAliasListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__2__0_models.GetFormComponentAliasListHeaders()
        return self.get_form_component_alias_list_with_options(app_type, form_uuid, request, headers, runtime)

    async def get_form_component_alias_list_async(
        self,
        app_type: str,
        form_uuid: str,
        request: dingtalkyida__2__0_models.GetFormComponentAliasListRequest,
    ) -> dingtalkyida__2__0_models.GetFormComponentAliasListResponse:
        """
        @summary 获取表单组件别名列表
        
        @param request: GetFormComponentAliasListRequest
        @return: GetFormComponentAliasListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__2__0_models.GetFormComponentAliasListHeaders()
        return await self.get_form_component_alias_list_with_options_async(app_type, form_uuid, request, headers, runtime)

    def get_form_data_by_idwith_options(
        self,
        id: str,
        request: dingtalkyida__2__0_models.GetFormDataByIDRequest,
        headers: dingtalkyida__2__0_models.GetFormDataByIDHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__2__0_models.GetFormDataByIDResponse:
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
        if not UtilClient.is_unset(request.form_uuid):
            query['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.use_alias):
            query['useAlias'] = request.use_alias
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
            version='yida_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/yida/forms/instances/{id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__2__0_models.GetFormDataByIDResponse(),
            self.execute(params, req, runtime)
        )

    async def get_form_data_by_idwith_options_async(
        self,
        id: str,
        request: dingtalkyida__2__0_models.GetFormDataByIDRequest,
        headers: dingtalkyida__2__0_models.GetFormDataByIDHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__2__0_models.GetFormDataByIDResponse:
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
        if not UtilClient.is_unset(request.form_uuid):
            query['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.use_alias):
            query['useAlias'] = request.use_alias
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
            version='yida_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/yida/forms/instances/{id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__2__0_models.GetFormDataByIDResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_form_data_by_id(
        self,
        id: str,
        request: dingtalkyida__2__0_models.GetFormDataByIDRequest,
    ) -> dingtalkyida__2__0_models.GetFormDataByIDResponse:
        """
        @summary 根据表单 ID 查询实例详情
        
        @param request: GetFormDataByIDRequest
        @return: GetFormDataByIDResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__2__0_models.GetFormDataByIDHeaders()
        return self.get_form_data_by_idwith_options(id, request, headers, runtime)

    async def get_form_data_by_id_async(
        self,
        id: str,
        request: dingtalkyida__2__0_models.GetFormDataByIDRequest,
    ) -> dingtalkyida__2__0_models.GetFormDataByIDResponse:
        """
        @summary 根据表单 ID 查询实例详情
        
        @param request: GetFormDataByIDRequest
        @return: GetFormDataByIDResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__2__0_models.GetFormDataByIDHeaders()
        return await self.get_form_data_by_idwith_options_async(id, request, headers, runtime)

    def get_instance_by_id_with_options(
        self,
        id: str,
        request: dingtalkyida__2__0_models.GetInstanceByIdRequest,
        headers: dingtalkyida__2__0_models.GetInstanceByIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__2__0_models.GetInstanceByIdResponse:
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
        if not UtilClient.is_unset(request.form_uuid):
            query['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.use_alias):
            query['useAlias'] = request.use_alias
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
            version='yida_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/yida/processes/instancesInfos/{id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__2__0_models.GetInstanceByIdResponse(),
            self.execute(params, req, runtime)
        )

    async def get_instance_by_id_with_options_async(
        self,
        id: str,
        request: dingtalkyida__2__0_models.GetInstanceByIdRequest,
        headers: dingtalkyida__2__0_models.GetInstanceByIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__2__0_models.GetInstanceByIdResponse:
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
        if not UtilClient.is_unset(request.form_uuid):
            query['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.use_alias):
            query['useAlias'] = request.use_alias
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
            version='yida_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/yida/processes/instancesInfos/{id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__2__0_models.GetInstanceByIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_instance_by_id(
        self,
        id: str,
        request: dingtalkyida__2__0_models.GetInstanceByIdRequest,
    ) -> dingtalkyida__2__0_models.GetInstanceByIdResponse:
        """
        @summary 根据实例 ID 获取流程实例详情
        
        @param request: GetInstanceByIdRequest
        @return: GetInstanceByIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__2__0_models.GetInstanceByIdHeaders()
        return self.get_instance_by_id_with_options(id, request, headers, runtime)

    async def get_instance_by_id_async(
        self,
        id: str,
        request: dingtalkyida__2__0_models.GetInstanceByIdRequest,
    ) -> dingtalkyida__2__0_models.GetInstanceByIdResponse:
        """
        @summary 根据实例 ID 获取流程实例详情
        
        @param request: GetInstanceByIdRequest
        @return: GetInstanceByIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__2__0_models.GetInstanceByIdHeaders()
        return await self.get_instance_by_id_with_options_async(id, request, headers, runtime)

    def get_instance_id_list_with_options(
        self,
        request: dingtalkyida__2__0_models.GetInstanceIdListRequest,
        headers: dingtalkyida__2__0_models.GetInstanceIdListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__2__0_models.GetInstanceIdListResponse:
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
        if not UtilClient.is_unset(request.use_alias):
            body['useAlias'] = request.use_alias
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
            version='yida_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/yida/processes/instanceIds',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__2__0_models.GetInstanceIdListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_instance_id_list_with_options_async(
        self,
        request: dingtalkyida__2__0_models.GetInstanceIdListRequest,
        headers: dingtalkyida__2__0_models.GetInstanceIdListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__2__0_models.GetInstanceIdListResponse:
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
        if not UtilClient.is_unset(request.use_alias):
            body['useAlias'] = request.use_alias
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
            version='yida_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/yida/processes/instanceIds',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__2__0_models.GetInstanceIdListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_instance_id_list(
        self,
        request: dingtalkyida__2__0_models.GetInstanceIdListRequest,
    ) -> dingtalkyida__2__0_models.GetInstanceIdListResponse:
        """
        @summary 根据条件搜索流程实例 ID
        
        @param request: GetInstanceIdListRequest
        @return: GetInstanceIdListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__2__0_models.GetInstanceIdListHeaders()
        return self.get_instance_id_list_with_options(request, headers, runtime)

    async def get_instance_id_list_async(
        self,
        request: dingtalkyida__2__0_models.GetInstanceIdListRequest,
    ) -> dingtalkyida__2__0_models.GetInstanceIdListResponse:
        """
        @summary 根据条件搜索流程实例 ID
        
        @param request: GetInstanceIdListRequest
        @return: GetInstanceIdListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__2__0_models.GetInstanceIdListHeaders()
        return await self.get_instance_id_list_with_options_async(request, headers, runtime)

    def get_instances_with_options(
        self,
        request: dingtalkyida__2__0_models.GetInstancesRequest,
        headers: dingtalkyida__2__0_models.GetInstancesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__2__0_models.GetInstancesResponse:
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
        if not UtilClient.is_unset(request.use_alias):
            body['useAlias'] = request.use_alias
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
            version='yida_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/yida/processes/instances',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__2__0_models.GetInstancesResponse(),
            self.execute(params, req, runtime)
        )

    async def get_instances_with_options_async(
        self,
        request: dingtalkyida__2__0_models.GetInstancesRequest,
        headers: dingtalkyida__2__0_models.GetInstancesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__2__0_models.GetInstancesResponse:
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
        if not UtilClient.is_unset(request.use_alias):
            body['useAlias'] = request.use_alias
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
            version='yida_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/yida/processes/instances',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__2__0_models.GetInstancesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_instances(
        self,
        request: dingtalkyida__2__0_models.GetInstancesRequest,
    ) -> dingtalkyida__2__0_models.GetInstancesResponse:
        """
        @summary 根据搜索条件获取流程表单实例详情
        
        @param request: GetInstancesRequest
        @return: GetInstancesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__2__0_models.GetInstancesHeaders()
        return self.get_instances_with_options(request, headers, runtime)

    async def get_instances_async(
        self,
        request: dingtalkyida__2__0_models.GetInstancesRequest,
    ) -> dingtalkyida__2__0_models.GetInstancesResponse:
        """
        @summary 根据搜索条件获取流程表单实例详情
        
        @param request: GetInstancesRequest
        @return: GetInstancesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__2__0_models.GetInstancesHeaders()
        return await self.get_instances_with_options_async(request, headers, runtime)

    def save_form_data_with_options(
        self,
        request: dingtalkyida__2__0_models.SaveFormDataRequest,
        headers: dingtalkyida__2__0_models.SaveFormDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__2__0_models.SaveFormDataResponse:
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
        if not UtilClient.is_unset(request.use_alias):
            body['useAlias'] = request.use_alias
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
            version='yida_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/yida/forms/instances',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__2__0_models.SaveFormDataResponse(),
            self.execute(params, req, runtime)
        )

    async def save_form_data_with_options_async(
        self,
        request: dingtalkyida__2__0_models.SaveFormDataRequest,
        headers: dingtalkyida__2__0_models.SaveFormDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__2__0_models.SaveFormDataResponse:
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
        if not UtilClient.is_unset(request.use_alias):
            body['useAlias'] = request.use_alias
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
            version='yida_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/yida/forms/instances',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__2__0_models.SaveFormDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def save_form_data(
        self,
        request: dingtalkyida__2__0_models.SaveFormDataRequest,
    ) -> dingtalkyida__2__0_models.SaveFormDataResponse:
        """
        @summary 新增表单实例
        
        @param request: SaveFormDataRequest
        @return: SaveFormDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__2__0_models.SaveFormDataHeaders()
        return self.save_form_data_with_options(request, headers, runtime)

    async def save_form_data_async(
        self,
        request: dingtalkyida__2__0_models.SaveFormDataRequest,
    ) -> dingtalkyida__2__0_models.SaveFormDataResponse:
        """
        @summary 新增表单实例
        
        @param request: SaveFormDataRequest
        @return: SaveFormDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__2__0_models.SaveFormDataHeaders()
        return await self.save_form_data_with_options_async(request, headers, runtime)

    def search_form_data_id_list_with_options(
        self,
        app_type: str,
        form_uuid: str,
        request: dingtalkyida__2__0_models.SearchFormDataIdListRequest,
        headers: dingtalkyida__2__0_models.SearchFormDataIdListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__2__0_models.SearchFormDataIdListResponse:
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
        if not UtilClient.is_unset(request.use_alias):
            body['useAlias'] = request.use_alias
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
            version='yida_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/yida/forms/instances/ids/{app_type}/{form_uuid}',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__2__0_models.SearchFormDataIdListResponse(),
            self.execute(params, req, runtime)
        )

    async def search_form_data_id_list_with_options_async(
        self,
        app_type: str,
        form_uuid: str,
        request: dingtalkyida__2__0_models.SearchFormDataIdListRequest,
        headers: dingtalkyida__2__0_models.SearchFormDataIdListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__2__0_models.SearchFormDataIdListResponse:
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
        if not UtilClient.is_unset(request.use_alias):
            body['useAlias'] = request.use_alias
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
            version='yida_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/yida/forms/instances/ids/{app_type}/{form_uuid}',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__2__0_models.SearchFormDataIdListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_form_data_id_list(
        self,
        app_type: str,
        form_uuid: str,
        request: dingtalkyida__2__0_models.SearchFormDataIdListRequest,
    ) -> dingtalkyida__2__0_models.SearchFormDataIdListResponse:
        """
        @summary 根据条件搜索表单实例 ID 列表
        
        @param request: SearchFormDataIdListRequest
        @return: SearchFormDataIdListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__2__0_models.SearchFormDataIdListHeaders()
        return self.search_form_data_id_list_with_options(app_type, form_uuid, request, headers, runtime)

    async def search_form_data_id_list_async(
        self,
        app_type: str,
        form_uuid: str,
        request: dingtalkyida__2__0_models.SearchFormDataIdListRequest,
    ) -> dingtalkyida__2__0_models.SearchFormDataIdListResponse:
        """
        @summary 根据条件搜索表单实例 ID 列表
        
        @param request: SearchFormDataIdListRequest
        @return: SearchFormDataIdListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__2__0_models.SearchFormDataIdListHeaders()
        return await self.search_form_data_id_list_with_options_async(app_type, form_uuid, request, headers, runtime)

    def search_form_data_second_generation_with_options(
        self,
        request: dingtalkyida__2__0_models.SearchFormDataSecondGenerationRequest,
        headers: dingtalkyida__2__0_models.SearchFormDataSecondGenerationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__2__0_models.SearchFormDataSecondGenerationResponse:
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
        if not UtilClient.is_unset(request.use_alias):
            body['useAlias'] = request.use_alias
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
            version='yida_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/yida/forms/instances/advances/queryAll',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__2__0_models.SearchFormDataSecondGenerationResponse(),
            self.execute(params, req, runtime)
        )

    async def search_form_data_second_generation_with_options_async(
        self,
        request: dingtalkyida__2__0_models.SearchFormDataSecondGenerationRequest,
        headers: dingtalkyida__2__0_models.SearchFormDataSecondGenerationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__2__0_models.SearchFormDataSecondGenerationResponse:
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
        if not UtilClient.is_unset(request.use_alias):
            body['useAlias'] = request.use_alias
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
            version='yida_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/yida/forms/instances/advances/queryAll',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__2__0_models.SearchFormDataSecondGenerationResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_form_data_second_generation(
        self,
        request: dingtalkyida__2__0_models.SearchFormDataSecondGenerationRequest,
    ) -> dingtalkyida__2__0_models.SearchFormDataSecondGenerationResponse:
        """
        @summary 通过高级检索条件查询表单实例
        
        @param request: SearchFormDataSecondGenerationRequest
        @return: SearchFormDataSecondGenerationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__2__0_models.SearchFormDataSecondGenerationHeaders()
        return self.search_form_data_second_generation_with_options(request, headers, runtime)

    async def search_form_data_second_generation_async(
        self,
        request: dingtalkyida__2__0_models.SearchFormDataSecondGenerationRequest,
    ) -> dingtalkyida__2__0_models.SearchFormDataSecondGenerationResponse:
        """
        @summary 通过高级检索条件查询表单实例
        
        @param request: SearchFormDataSecondGenerationRequest
        @return: SearchFormDataSecondGenerationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__2__0_models.SearchFormDataSecondGenerationHeaders()
        return await self.search_form_data_second_generation_with_options_async(request, headers, runtime)

    def search_form_datas_with_options(
        self,
        request: dingtalkyida__2__0_models.SearchFormDatasRequest,
        headers: dingtalkyida__2__0_models.SearchFormDatasHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__2__0_models.SearchFormDatasResponse:
        """
        @summary 根据条件搜索表单实例详情列表
        
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
        if not UtilClient.is_unset(request.use_alias):
            body['useAlias'] = request.use_alias
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
            version='yida_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/yida/forms/instances/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__2__0_models.SearchFormDatasResponse(),
            self.execute(params, req, runtime)
        )

    async def search_form_datas_with_options_async(
        self,
        request: dingtalkyida__2__0_models.SearchFormDatasRequest,
        headers: dingtalkyida__2__0_models.SearchFormDatasHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__2__0_models.SearchFormDatasResponse:
        """
        @summary 根据条件搜索表单实例详情列表
        
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
        if not UtilClient.is_unset(request.use_alias):
            body['useAlias'] = request.use_alias
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
            version='yida_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/yida/forms/instances/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__2__0_models.SearchFormDatasResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_form_datas(
        self,
        request: dingtalkyida__2__0_models.SearchFormDatasRequest,
    ) -> dingtalkyida__2__0_models.SearchFormDatasResponse:
        """
        @summary 根据条件搜索表单实例详情列表
        
        @param request: SearchFormDatasRequest
        @return: SearchFormDatasResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__2__0_models.SearchFormDatasHeaders()
        return self.search_form_datas_with_options(request, headers, runtime)

    async def search_form_datas_async(
        self,
        request: dingtalkyida__2__0_models.SearchFormDatasRequest,
    ) -> dingtalkyida__2__0_models.SearchFormDatasResponse:
        """
        @summary 根据条件搜索表单实例详情列表
        
        @param request: SearchFormDatasRequest
        @return: SearchFormDatasResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__2__0_models.SearchFormDatasHeaders()
        return await self.search_form_datas_with_options_async(request, headers, runtime)

    def start_instance_with_options(
        self,
        request: dingtalkyida__2__0_models.StartInstanceRequest,
        headers: dingtalkyida__2__0_models.StartInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__2__0_models.StartInstanceResponse:
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
        if not UtilClient.is_unset(request.use_alias):
            body['useAlias'] = request.use_alias
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
            version='yida_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/yida/processes/instances/start',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__2__0_models.StartInstanceResponse(),
            self.execute(params, req, runtime)
        )

    async def start_instance_with_options_async(
        self,
        request: dingtalkyida__2__0_models.StartInstanceRequest,
        headers: dingtalkyida__2__0_models.StartInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__2__0_models.StartInstanceResponse:
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
        if not UtilClient.is_unset(request.use_alias):
            body['useAlias'] = request.use_alias
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
            version='yida_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/yida/processes/instances/start',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyida__2__0_models.StartInstanceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def start_instance(
        self,
        request: dingtalkyida__2__0_models.StartInstanceRequest,
    ) -> dingtalkyida__2__0_models.StartInstanceResponse:
        """
        @summary 发起新的流程实例
        
        @param request: StartInstanceRequest
        @return: StartInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__2__0_models.StartInstanceHeaders()
        return self.start_instance_with_options(request, headers, runtime)

    async def start_instance_async(
        self,
        request: dingtalkyida__2__0_models.StartInstanceRequest,
    ) -> dingtalkyida__2__0_models.StartInstanceResponse:
        """
        @summary 发起新的流程实例
        
        @param request: StartInstanceRequest
        @return: StartInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__2__0_models.StartInstanceHeaders()
        return await self.start_instance_with_options_async(request, headers, runtime)

    def update_form_data_with_options(
        self,
        request: dingtalkyida__2__0_models.UpdateFormDataRequest,
        headers: dingtalkyida__2__0_models.UpdateFormDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__2__0_models.UpdateFormDataResponse:
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
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.update_form_data_json):
            body['updateFormDataJson'] = request.update_form_data_json
        if not UtilClient.is_unset(request.use_alias):
            body['useAlias'] = request.use_alias
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
            version='yida_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/yida/forms/instances',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkyida__2__0_models.UpdateFormDataResponse(),
            self.execute(params, req, runtime)
        )

    async def update_form_data_with_options_async(
        self,
        request: dingtalkyida__2__0_models.UpdateFormDataRequest,
        headers: dingtalkyida__2__0_models.UpdateFormDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__2__0_models.UpdateFormDataResponse:
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
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.update_form_data_json):
            body['updateFormDataJson'] = request.update_form_data_json
        if not UtilClient.is_unset(request.use_alias):
            body['useAlias'] = request.use_alias
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
            version='yida_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/yida/forms/instances',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkyida__2__0_models.UpdateFormDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_form_data(
        self,
        request: dingtalkyida__2__0_models.UpdateFormDataRequest,
    ) -> dingtalkyida__2__0_models.UpdateFormDataResponse:
        """
        @summary 更新表单实例
        
        @param request: UpdateFormDataRequest
        @return: UpdateFormDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__2__0_models.UpdateFormDataHeaders()
        return self.update_form_data_with_options(request, headers, runtime)

    async def update_form_data_async(
        self,
        request: dingtalkyida__2__0_models.UpdateFormDataRequest,
    ) -> dingtalkyida__2__0_models.UpdateFormDataResponse:
        """
        @summary 更新表单实例
        
        @param request: UpdateFormDataRequest
        @return: UpdateFormDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__2__0_models.UpdateFormDataHeaders()
        return await self.update_form_data_with_options_async(request, headers, runtime)
