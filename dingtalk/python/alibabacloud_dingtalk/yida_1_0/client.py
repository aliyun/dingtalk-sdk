# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
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
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def save_form_data(
        self,
        request: dingtalkyida__1__0_models.SaveFormDataRequest,
    ) -> dingtalkyida__1__0_models.SaveFormDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.SaveFormDataHeaders()
        return self.save_form_data_with_options(request, headers, runtime)

    async def save_form_data_async(
        self,
        request: dingtalkyida__1__0_models.SaveFormDataRequest,
    ) -> dingtalkyida__1__0_models.SaveFormDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.SaveFormDataHeaders()
        return await self.save_form_data_with_options_async(request, headers, runtime)

    def save_form_data_with_options(
        self,
        request: dingtalkyida__1__0_models.SaveFormDataRequest,
        headers: dingtalkyida__1__0_models.SaveFormDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.SaveFormDataResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.form_data_json):
            body['formDataJson'] = request.form_data_json
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
            dingtalkyida__1__0_models.SaveFormDataResponse(),
            self.do_roarequest('SaveFormData', 'yida_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/yida/forms/instances', 'json', req, runtime)
        )

    async def save_form_data_with_options_async(
        self,
        request: dingtalkyida__1__0_models.SaveFormDataRequest,
        headers: dingtalkyida__1__0_models.SaveFormDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.SaveFormDataResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.form_data_json):
            body['formDataJson'] = request.form_data_json
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
            dingtalkyida__1__0_models.SaveFormDataResponse(),
            await self.do_roarequest_async('SaveFormData', 'yida_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/yida/forms/instances', 'json', req, runtime)
        )

    def search_form_datas(
        self,
        request: dingtalkyida__1__0_models.SearchFormDatasRequest,
    ) -> dingtalkyida__1__0_models.SearchFormDatasResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.SearchFormDatasHeaders()
        return self.search_form_datas_with_options(request, headers, runtime)

    async def search_form_datas_async(
        self,
        request: dingtalkyida__1__0_models.SearchFormDatasRequest,
    ) -> dingtalkyida__1__0_models.SearchFormDatasResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.SearchFormDatasHeaders()
        return await self.search_form_datas_with_options_async(request, headers, runtime)

    def search_form_datas_with_options(
        self,
        request: dingtalkyida__1__0_models.SearchFormDatasRequest,
        headers: dingtalkyida__1__0_models.SearchFormDatasHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.SearchFormDatasResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.search_field_json):
            body['searchFieldJson'] = request.search_field_json
        if not UtilClient.is_unset(request.current_page):
            body['currentPage'] = request.current_page
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.originator_id):
            body['originatorId'] = request.originator_id
        if not UtilClient.is_unset(request.create_from_time_gmt):
            body['createFromTimeGMT'] = request.create_from_time_gmt
        if not UtilClient.is_unset(request.create_to_time_gmt):
            body['createToTimeGMT'] = request.create_to_time_gmt
        if not UtilClient.is_unset(request.modified_from_time_gmt):
            body['modifiedFromTimeGMT'] = request.modified_from_time_gmt
        if not UtilClient.is_unset(request.modified_to_time_gmt):
            body['modifiedToTimeGMT'] = request.modified_to_time_gmt
        if not UtilClient.is_unset(request.dynamic_order):
            body['dynamicOrder'] = request.dynamic_order
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
            dingtalkyida__1__0_models.SearchFormDatasResponse(),
            self.do_roarequest('SearchFormDatas', 'yida_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/yida/forms/instances/search', 'json', req, runtime)
        )

    async def search_form_datas_with_options_async(
        self,
        request: dingtalkyida__1__0_models.SearchFormDatasRequest,
        headers: dingtalkyida__1__0_models.SearchFormDatasHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.SearchFormDatasResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.search_field_json):
            body['searchFieldJson'] = request.search_field_json
        if not UtilClient.is_unset(request.current_page):
            body['currentPage'] = request.current_page
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.originator_id):
            body['originatorId'] = request.originator_id
        if not UtilClient.is_unset(request.create_from_time_gmt):
            body['createFromTimeGMT'] = request.create_from_time_gmt
        if not UtilClient.is_unset(request.create_to_time_gmt):
            body['createToTimeGMT'] = request.create_to_time_gmt
        if not UtilClient.is_unset(request.modified_from_time_gmt):
            body['modifiedFromTimeGMT'] = request.modified_from_time_gmt
        if not UtilClient.is_unset(request.modified_to_time_gmt):
            body['modifiedToTimeGMT'] = request.modified_to_time_gmt
        if not UtilClient.is_unset(request.dynamic_order):
            body['dynamicOrder'] = request.dynamic_order
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
            dingtalkyida__1__0_models.SearchFormDatasResponse(),
            await self.do_roarequest_async('SearchFormDatas', 'yida_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/yida/forms/instances/search', 'json', req, runtime)
        )

    def login_code_gen(
        self,
        request: dingtalkyida__1__0_models.LoginCodeGenRequest,
    ) -> dingtalkyida__1__0_models.LoginCodeGenResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.LoginCodeGenHeaders()
        return self.login_code_gen_with_options(request, headers, runtime)

    async def login_code_gen_async(
        self,
        request: dingtalkyida__1__0_models.LoginCodeGenRequest,
    ) -> dingtalkyida__1__0_models.LoginCodeGenResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.LoginCodeGenHeaders()
        return await self.login_code_gen_with_options_async(request, headers, runtime)

    def login_code_gen_with_options(
        self,
        request: dingtalkyida__1__0_models.LoginCodeGenRequest,
        headers: dingtalkyida__1__0_models.LoginCodeGenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.LoginCodeGenResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
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
            dingtalkyida__1__0_models.LoginCodeGenResponse(),
            self.do_roarequest('LoginCodeGen', 'yida_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/yida/authorizations/loginCodes', 'json', req, runtime)
        )

    async def login_code_gen_with_options_async(
        self,
        request: dingtalkyida__1__0_models.LoginCodeGenRequest,
        headers: dingtalkyida__1__0_models.LoginCodeGenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.LoginCodeGenResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
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
            dingtalkyida__1__0_models.LoginCodeGenResponse(),
            await self.do_roarequest_async('LoginCodeGen', 'yida_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/yida/authorizations/loginCodes', 'json', req, runtime)
        )

    def get_form_data_by_id(
        self,
        id: str,
        request: dingtalkyida__1__0_models.GetFormDataByIDRequest,
    ) -> dingtalkyida__1__0_models.GetFormDataByIDResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetFormDataByIDHeaders()
        return self.get_form_data_by_idwith_options(id, request, headers, runtime)

    async def get_form_data_by_id_async(
        self,
        id: str,
        request: dingtalkyida__1__0_models.GetFormDataByIDRequest,
    ) -> dingtalkyida__1__0_models.GetFormDataByIDResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetFormDataByIDHeaders()
        return await self.get_form_data_by_idwith_options_async(id, request, headers, runtime)

    def get_form_data_by_idwith_options(
        self,
        id: str,
        request: dingtalkyida__1__0_models.GetFormDataByIDRequest,
        headers: dingtalkyida__1__0_models.GetFormDataByIDHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetFormDataByIDResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
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
            dingtalkyida__1__0_models.GetFormDataByIDResponse(),
            self.do_roarequest('GetFormDataByID', 'yida_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/yida/forms/instances/{id}', 'json', req, runtime)
        )

    async def get_form_data_by_idwith_options_async(
        self,
        id: str,
        request: dingtalkyida__1__0_models.GetFormDataByIDRequest,
        headers: dingtalkyida__1__0_models.GetFormDataByIDHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetFormDataByIDResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
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
            dingtalkyida__1__0_models.GetFormDataByIDResponse(),
            await self.do_roarequest_async('GetFormDataByID', 'yida_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/yida/forms/instances/{id}', 'json', req, runtime)
        )

    def start_instance(
        self,
        request: dingtalkyida__1__0_models.StartInstanceRequest,
    ) -> dingtalkyida__1__0_models.StartInstanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.StartInstanceHeaders()
        return self.start_instance_with_options(request, headers, runtime)

    async def start_instance_async(
        self,
        request: dingtalkyida__1__0_models.StartInstanceRequest,
    ) -> dingtalkyida__1__0_models.StartInstanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.StartInstanceHeaders()
        return await self.start_instance_with_options_async(request, headers, runtime)

    def start_instance_with_options(
        self,
        request: dingtalkyida__1__0_models.StartInstanceRequest,
        headers: dingtalkyida__1__0_models.StartInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.StartInstanceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.form_data_json):
            body['formDataJson'] = request.form_data_json
        if not UtilClient.is_unset(request.process_code):
            body['processCode'] = request.process_code
        if not UtilClient.is_unset(request.department_id):
            body['departmentId'] = request.department_id
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
            dingtalkyida__1__0_models.StartInstanceResponse(),
            self.do_roarequest('StartInstance', 'yida_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/yida/processes/instances/start', 'json', req, runtime)
        )

    async def start_instance_with_options_async(
        self,
        request: dingtalkyida__1__0_models.StartInstanceRequest,
        headers: dingtalkyida__1__0_models.StartInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.StartInstanceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.form_data_json):
            body['formDataJson'] = request.form_data_json
        if not UtilClient.is_unset(request.process_code):
            body['processCode'] = request.process_code
        if not UtilClient.is_unset(request.department_id):
            body['departmentId'] = request.department_id
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
            dingtalkyida__1__0_models.StartInstanceResponse(),
            await self.do_roarequest_async('StartInstance', 'yida_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/yida/processes/instances/start', 'json', req, runtime)
        )
