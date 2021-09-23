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

    def validate_order_upgrade(
        self,
        request: dingtalkyida__1__0_models.ValidateOrderUpgradeRequest,
    ) -> dingtalkyida__1__0_models.ValidateOrderUpgradeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ValidateOrderUpgradeHeaders()
        return self.validate_order_upgrade_with_options(request, headers, runtime)

    async def validate_order_upgrade_async(
        self,
        request: dingtalkyida__1__0_models.ValidateOrderUpgradeRequest,
    ) -> dingtalkyida__1__0_models.ValidateOrderUpgradeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ValidateOrderUpgradeHeaders()
        return await self.validate_order_upgrade_with_options_async(request, headers, runtime)

    def validate_order_upgrade_with_options(
        self,
        request: dingtalkyida__1__0_models.ValidateOrderUpgradeRequest,
        headers: dingtalkyida__1__0_models.ValidateOrderUpgradeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ValidateOrderUpgradeResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
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
            dingtalkyida__1__0_models.ValidateOrderUpgradeResponse(),
            self.do_roarequest('ValidateOrderUpgrade', 'yida_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/yida/apps/orderUpgrade/validate', 'json', req, runtime)
        )

    async def validate_order_upgrade_with_options_async(
        self,
        request: dingtalkyida__1__0_models.ValidateOrderUpgradeRequest,
        headers: dingtalkyida__1__0_models.ValidateOrderUpgradeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ValidateOrderUpgradeResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
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
            dingtalkyida__1__0_models.ValidateOrderUpgradeResponse(),
            await self.do_roarequest_async('ValidateOrderUpgrade', 'yida_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/yida/apps/orderUpgrade/validate', 'json', req, runtime)
        )

    def get_corp_level_by_account_id(
        self,
        request: dingtalkyida__1__0_models.GetCorpLevelByAccountIdRequest,
    ) -> dingtalkyida__1__0_models.GetCorpLevelByAccountIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetCorpLevelByAccountIdHeaders()
        return self.get_corp_level_by_account_id_with_options(request, headers, runtime)

    async def get_corp_level_by_account_id_async(
        self,
        request: dingtalkyida__1__0_models.GetCorpLevelByAccountIdRequest,
    ) -> dingtalkyida__1__0_models.GetCorpLevelByAccountIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetCorpLevelByAccountIdHeaders()
        return await self.get_corp_level_by_account_id_with_options_async(request, headers, runtime)

    def get_corp_level_by_account_id_with_options(
        self,
        request: dingtalkyida__1__0_models.GetCorpLevelByAccountIdRequest,
        headers: dingtalkyida__1__0_models.GetCorpLevelByAccountIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetCorpLevelByAccountIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.account_id):
            query['accountId'] = request.account_id
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
            dingtalkyida__1__0_models.GetCorpLevelByAccountIdResponse(),
            self.do_roarequest('GetCorpLevelByAccountId', 'yida_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/yida/apps/corpLevel', 'json', req, runtime)
        )

    async def get_corp_level_by_account_id_with_options_async(
        self,
        request: dingtalkyida__1__0_models.GetCorpLevelByAccountIdRequest,
        headers: dingtalkyida__1__0_models.GetCorpLevelByAccountIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetCorpLevelByAccountIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.account_id):
            query['accountId'] = request.account_id
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
            dingtalkyida__1__0_models.GetCorpLevelByAccountIdResponse(),
            await self.do_roarequest_async('GetCorpLevelByAccountId', 'yida_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/yida/apps/corpLevel', 'json', req, runtime)
        )

    def update_status(
        self,
        request: dingtalkyida__1__0_models.UpdateStatusRequest,
    ) -> dingtalkyida__1__0_models.UpdateStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.UpdateStatusHeaders()
        return self.update_status_with_options(request, headers, runtime)

    async def update_status_async(
        self,
        request: dingtalkyida__1__0_models.UpdateStatusRequest,
    ) -> dingtalkyida__1__0_models.UpdateStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.UpdateStatusHeaders()
        return await self.update_status_with_options_async(request, headers, runtime)

    def update_status_with_options(
        self,
        request: dingtalkyida__1__0_models.UpdateStatusRequest,
        headers: dingtalkyida__1__0_models.UpdateStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.UpdateStatusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.import_sequence):
            body['importSequence'] = request.import_sequence
        if not UtilClient.is_unset(request.error_lines):
            body['errorLines'] = request.error_lines
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
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
            dingtalkyida__1__0_models.UpdateStatusResponse(),
            self.do_roarequest('UpdateStatus', 'yida_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/yida/forms/status', 'none', req, runtime)
        )

    async def update_status_with_options_async(
        self,
        request: dingtalkyida__1__0_models.UpdateStatusRequest,
        headers: dingtalkyida__1__0_models.UpdateStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.UpdateStatusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.import_sequence):
            body['importSequence'] = request.import_sequence
        if not UtilClient.is_unset(request.error_lines):
            body['errorLines'] = request.error_lines
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
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
            dingtalkyida__1__0_models.UpdateStatusResponse(),
            await self.do_roarequest_async('UpdateStatus', 'yida_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/yida/forms/status', 'none', req, runtime)
        )

    def execute_platform_task(
        self,
        request: dingtalkyida__1__0_models.ExecutePlatformTaskRequest,
    ) -> dingtalkyida__1__0_models.ExecutePlatformTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ExecutePlatformTaskHeaders()
        return self.execute_platform_task_with_options(request, headers, runtime)

    async def execute_platform_task_async(
        self,
        request: dingtalkyida__1__0_models.ExecutePlatformTaskRequest,
    ) -> dingtalkyida__1__0_models.ExecutePlatformTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ExecutePlatformTaskHeaders()
        return await self.execute_platform_task_with_options_async(request, headers, runtime)

    def execute_platform_task_with_options(
        self,
        request: dingtalkyida__1__0_models.ExecutePlatformTaskRequest,
        headers: dingtalkyida__1__0_models.ExecutePlatformTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ExecutePlatformTaskResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.out_result):
            body['outResult'] = request.out_result
        if not UtilClient.is_unset(request.no_execute_expressions):
            body['noExecuteExpressions'] = request.no_execute_expressions
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_data_json):
            body['formDataJson'] = request.form_data_json
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.process_instance_id):
            body['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            dingtalkyida__1__0_models.ExecutePlatformTaskResponse(),
            self.do_roarequest('ExecutePlatformTask', 'yida_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/yida/tasks/platformTasks/execute', 'none', req, runtime)
        )

    async def execute_platform_task_with_options_async(
        self,
        request: dingtalkyida__1__0_models.ExecutePlatformTaskRequest,
        headers: dingtalkyida__1__0_models.ExecutePlatformTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ExecutePlatformTaskResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.out_result):
            body['outResult'] = request.out_result
        if not UtilClient.is_unset(request.no_execute_expressions):
            body['noExecuteExpressions'] = request.no_execute_expressions
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_data_json):
            body['formDataJson'] = request.form_data_json
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.process_instance_id):
            body['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            dingtalkyida__1__0_models.ExecutePlatformTaskResponse(),
            await self.do_roarequest_async('ExecutePlatformTask', 'yida_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/yida/tasks/platformTasks/execute', 'none', req, runtime)
        )

    def save_form_remark(
        self,
        request: dingtalkyida__1__0_models.SaveFormRemarkRequest,
    ) -> dingtalkyida__1__0_models.SaveFormRemarkResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.SaveFormRemarkHeaders()
        return self.save_form_remark_with_options(request, headers, runtime)

    async def save_form_remark_async(
        self,
        request: dingtalkyida__1__0_models.SaveFormRemarkRequest,
    ) -> dingtalkyida__1__0_models.SaveFormRemarkResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.SaveFormRemarkHeaders()
        return await self.save_form_remark_with_options_async(request, headers, runtime)

    def save_form_remark_with_options(
        self,
        request: dingtalkyida__1__0_models.SaveFormRemarkRequest,
        headers: dingtalkyida__1__0_models.SaveFormRemarkHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.SaveFormRemarkResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.reply_id):
            body['replyId'] = request.reply_id
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.form_instance_id):
            body['formInstanceId'] = request.form_instance_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.at_user_id):
            body['atUserId'] = request.at_user_id
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
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
            dingtalkyida__1__0_models.SaveFormRemarkResponse(),
            self.do_roarequest('SaveFormRemark', 'yida_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/yida/forms/remarks', 'json', req, runtime)
        )

    async def save_form_remark_with_options_async(
        self,
        request: dingtalkyida__1__0_models.SaveFormRemarkRequest,
        headers: dingtalkyida__1__0_models.SaveFormRemarkHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.SaveFormRemarkResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.reply_id):
            body['replyId'] = request.reply_id
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.form_instance_id):
            body['formInstanceId'] = request.form_instance_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.at_user_id):
            body['atUserId'] = request.at_user_id
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
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
            dingtalkyida__1__0_models.SaveFormRemarkResponse(),
            await self.do_roarequest_async('SaveFormRemark', 'yida_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/yida/forms/remarks', 'json', req, runtime)
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

    def search_activation_code(
        self,
        request: dingtalkyida__1__0_models.SearchActivationCodeRequest,
    ) -> dingtalkyida__1__0_models.SearchActivationCodeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.SearchActivationCodeHeaders()
        return self.search_activation_code_with_options(request, headers, runtime)

    async def search_activation_code_async(
        self,
        request: dingtalkyida__1__0_models.SearchActivationCodeRequest,
    ) -> dingtalkyida__1__0_models.SearchActivationCodeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.SearchActivationCodeHeaders()
        return await self.search_activation_code_with_options_async(request, headers, runtime)

    def search_activation_code_with_options(
        self,
        request: dingtalkyida__1__0_models.SearchActivationCodeRequest,
        headers: dingtalkyida__1__0_models.SearchActivationCodeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.SearchActivationCodeResponse:
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.SearchActivationCodeResponse(),
            self.do_roarequest('SearchActivationCode', 'yida_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/yida/apps/activationCode/information', 'json', req, runtime)
        )

    async def search_activation_code_with_options_async(
        self,
        request: dingtalkyida__1__0_models.SearchActivationCodeRequest,
        headers: dingtalkyida__1__0_models.SearchActivationCodeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.SearchActivationCodeResponse:
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.SearchActivationCodeResponse(),
            await self.do_roarequest_async('SearchActivationCode', 'yida_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/yida/apps/activationCode/information', 'json', req, runtime)
        )

    def search_employee_field_values(
        self,
        request: dingtalkyida__1__0_models.SearchEmployeeFieldValuesRequest,
    ) -> dingtalkyida__1__0_models.SearchEmployeeFieldValuesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.SearchEmployeeFieldValuesHeaders()
        return self.search_employee_field_values_with_options(request, headers, runtime)

    async def search_employee_field_values_async(
        self,
        request: dingtalkyida__1__0_models.SearchEmployeeFieldValuesRequest,
    ) -> dingtalkyida__1__0_models.SearchEmployeeFieldValuesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.SearchEmployeeFieldValuesHeaders()
        return await self.search_employee_field_values_with_options_async(request, headers, runtime)

    def search_employee_field_values_with_options(
        self,
        request: dingtalkyida__1__0_models.SearchEmployeeFieldValuesRequest,
        headers: dingtalkyida__1__0_models.SearchEmployeeFieldValuesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.SearchEmployeeFieldValuesResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.target_field_json):
            body['targetFieldJson'] = request.target_field_json
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.modified_to_time_gmt):
            body['modifiedToTimeGMT'] = request.modified_to_time_gmt
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.modified_from_time_gmt):
            body['modifiedFromTimeGMT'] = request.modified_from_time_gmt
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.search_field_json):
            body['searchFieldJson'] = request.search_field_json
        if not UtilClient.is_unset(request.originator_id):
            body['originatorId'] = request.originator_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.create_to_time_gmt):
            body['createToTimeGMT'] = request.create_to_time_gmt
        if not UtilClient.is_unset(request.create_from_time_gmt):
            body['createFromTimeGMT'] = request.create_from_time_gmt
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
            dingtalkyida__1__0_models.SearchEmployeeFieldValuesResponse(),
            self.do_roarequest('SearchEmployeeFieldValues', 'yida_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/yida/forms/employeeFields', 'json', req, runtime)
        )

    async def search_employee_field_values_with_options_async(
        self,
        request: dingtalkyida__1__0_models.SearchEmployeeFieldValuesRequest,
        headers: dingtalkyida__1__0_models.SearchEmployeeFieldValuesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.SearchEmployeeFieldValuesResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.target_field_json):
            body['targetFieldJson'] = request.target_field_json
        if not UtilClient.is_unset(request.form_uuid):
            body['formUuid'] = request.form_uuid
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.modified_to_time_gmt):
            body['modifiedToTimeGMT'] = request.modified_to_time_gmt
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.modified_from_time_gmt):
            body['modifiedFromTimeGMT'] = request.modified_from_time_gmt
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.search_field_json):
            body['searchFieldJson'] = request.search_field_json
        if not UtilClient.is_unset(request.originator_id):
            body['originatorId'] = request.originator_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.create_to_time_gmt):
            body['createToTimeGMT'] = request.create_to_time_gmt
        if not UtilClient.is_unset(request.create_from_time_gmt):
            body['createFromTimeGMT'] = request.create_from_time_gmt
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
            dingtalkyida__1__0_models.SearchEmployeeFieldValuesResponse(),
            await self.do_roarequest_async('SearchEmployeeFieldValues', 'yida_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/yida/forms/employeeFields', 'json', req, runtime)
        )

    def update_form_data(
        self,
        request: dingtalkyida__1__0_models.UpdateFormDataRequest,
    ) -> dingtalkyida__1__0_models.UpdateFormDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.UpdateFormDataHeaders()
        return self.update_form_data_with_options(request, headers, runtime)

    async def update_form_data_async(
        self,
        request: dingtalkyida__1__0_models.UpdateFormDataRequest,
    ) -> dingtalkyida__1__0_models.UpdateFormDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.UpdateFormDataHeaders()
        return await self.update_form_data_with_options_async(request, headers, runtime)

    def update_form_data_with_options(
        self,
        request: dingtalkyida__1__0_models.UpdateFormDataRequest,
        headers: dingtalkyida__1__0_models.UpdateFormDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.UpdateFormDataResponse:
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
        if not UtilClient.is_unset(request.form_instance_id):
            body['formInstanceId'] = request.form_instance_id
        if not UtilClient.is_unset(request.use_latest_version):
            body['useLatestVersion'] = request.use_latest_version
        if not UtilClient.is_unset(request.update_form_data_json):
            body['updateFormDataJson'] = request.update_form_data_json
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
            dingtalkyida__1__0_models.UpdateFormDataResponse(),
            self.do_roarequest('UpdateFormData', 'yida_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/yida/forms/instances', 'none', req, runtime)
        )

    async def update_form_data_with_options_async(
        self,
        request: dingtalkyida__1__0_models.UpdateFormDataRequest,
        headers: dingtalkyida__1__0_models.UpdateFormDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.UpdateFormDataResponse:
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
        if not UtilClient.is_unset(request.form_instance_id):
            body['formInstanceId'] = request.form_instance_id
        if not UtilClient.is_unset(request.use_latest_version):
            body['useLatestVersion'] = request.use_latest_version
        if not UtilClient.is_unset(request.update_form_data_json):
            body['updateFormDataJson'] = request.update_form_data_json
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
            dingtalkyida__1__0_models.UpdateFormDataResponse(),
            await self.do_roarequest_async('UpdateFormData', 'yida_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/yida/forms/instances', 'none', req, runtime)
        )

    def get_operation_records(
        self,
        request: dingtalkyida__1__0_models.GetOperationRecordsRequest,
    ) -> dingtalkyida__1__0_models.GetOperationRecordsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetOperationRecordsHeaders()
        return self.get_operation_records_with_options(request, headers, runtime)

    async def get_operation_records_async(
        self,
        request: dingtalkyida__1__0_models.GetOperationRecordsRequest,
    ) -> dingtalkyida__1__0_models.GetOperationRecordsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetOperationRecordsHeaders()
        return await self.get_operation_records_with_options_async(request, headers, runtime)

    def get_operation_records_with_options(
        self,
        request: dingtalkyida__1__0_models.GetOperationRecordsRequest,
        headers: dingtalkyida__1__0_models.GetOperationRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetOperationRecordsResponse:
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
        if not UtilClient.is_unset(request.process_instance_id):
            query['processInstanceId'] = request.process_instance_id
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
            dingtalkyida__1__0_models.GetOperationRecordsResponse(),
            self.do_roarequest('GetOperationRecords', 'yida_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/yida/processes/operationRecords', 'json', req, runtime)
        )

    async def get_operation_records_with_options_async(
        self,
        request: dingtalkyida__1__0_models.GetOperationRecordsRequest,
        headers: dingtalkyida__1__0_models.GetOperationRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetOperationRecordsResponse:
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
        if not UtilClient.is_unset(request.process_instance_id):
            query['processInstanceId'] = request.process_instance_id
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
            dingtalkyida__1__0_models.GetOperationRecordsResponse(),
            await self.do_roarequest_async('GetOperationRecords', 'yida_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/yida/processes/operationRecords', 'json', req, runtime)
        )

    def get_platform_resource(
        self,
        request: dingtalkyida__1__0_models.GetPlatformResourceRequest,
    ) -> dingtalkyida__1__0_models.GetPlatformResourceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetPlatformResourceHeaders()
        return self.get_platform_resource_with_options(request, headers, runtime)

    async def get_platform_resource_async(
        self,
        request: dingtalkyida__1__0_models.GetPlatformResourceRequest,
    ) -> dingtalkyida__1__0_models.GetPlatformResourceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetPlatformResourceHeaders()
        return await self.get_platform_resource_with_options_async(request, headers, runtime)

    def get_platform_resource_with_options(
        self,
        request: dingtalkyida__1__0_models.GetPlatformResourceRequest,
        headers: dingtalkyida__1__0_models.GetPlatformResourceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetPlatformResourceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
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
            dingtalkyida__1__0_models.GetPlatformResourceResponse(),
            self.do_roarequest('GetPlatformResource', 'yida_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/yida/apps/platformResources', 'json', req, runtime)
        )

    async def get_platform_resource_with_options_async(
        self,
        request: dingtalkyida__1__0_models.GetPlatformResourceRequest,
        headers: dingtalkyida__1__0_models.GetPlatformResourceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetPlatformResourceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
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
            dingtalkyida__1__0_models.GetPlatformResourceResponse(),
            await self.do_roarequest_async('GetPlatformResource', 'yida_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/yida/apps/platformResources', 'json', req, runtime)
        )

    def get_running_tasks(
        self,
        request: dingtalkyida__1__0_models.GetRunningTasksRequest,
    ) -> dingtalkyida__1__0_models.GetRunningTasksResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetRunningTasksHeaders()
        return self.get_running_tasks_with_options(request, headers, runtime)

    async def get_running_tasks_async(
        self,
        request: dingtalkyida__1__0_models.GetRunningTasksRequest,
    ) -> dingtalkyida__1__0_models.GetRunningTasksResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetRunningTasksHeaders()
        return await self.get_running_tasks_with_options_async(request, headers, runtime)

    def get_running_tasks_with_options(
        self,
        request: dingtalkyida__1__0_models.GetRunningTasksRequest,
        headers: dingtalkyida__1__0_models.GetRunningTasksHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetRunningTasksResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.process_instance_id):
            query['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
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
            dingtalkyida__1__0_models.GetRunningTasksResponse(),
            self.do_roarequest('GetRunningTasks', 'yida_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/yida/processes/tasks/getRunningTasks', 'json', req, runtime)
        )

    async def get_running_tasks_with_options_async(
        self,
        request: dingtalkyida__1__0_models.GetRunningTasksRequest,
        headers: dingtalkyida__1__0_models.GetRunningTasksHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetRunningTasksResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.process_instance_id):
            query['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
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
            dingtalkyida__1__0_models.GetRunningTasksResponse(),
            await self.do_roarequest_async('GetRunningTasks', 'yida_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/yida/processes/tasks/getRunningTasks', 'json', req, runtime)
        )

    def list_navigation_by_form_type(
        self,
        request: dingtalkyida__1__0_models.ListNavigationByFormTypeRequest,
    ) -> dingtalkyida__1__0_models.ListNavigationByFormTypeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ListNavigationByFormTypeHeaders()
        return self.list_navigation_by_form_type_with_options(request, headers, runtime)

    async def list_navigation_by_form_type_async(
        self,
        request: dingtalkyida__1__0_models.ListNavigationByFormTypeRequest,
    ) -> dingtalkyida__1__0_models.ListNavigationByFormTypeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ListNavigationByFormTypeHeaders()
        return await self.list_navigation_by_form_type_with_options_async(request, headers, runtime)

    def list_navigation_by_form_type_with_options(
        self,
        request: dingtalkyida__1__0_models.ListNavigationByFormTypeRequest,
        headers: dingtalkyida__1__0_models.ListNavigationByFormTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ListNavigationByFormTypeResponse:
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
        if not UtilClient.is_unset(request.form_type):
            query['formType'] = request.form_type
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
            dingtalkyida__1__0_models.ListNavigationByFormTypeResponse(),
            self.do_roarequest('ListNavigationByFormType', 'yida_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/yida/apps/navigations', 'json', req, runtime)
        )

    async def list_navigation_by_form_type_with_options_async(
        self,
        request: dingtalkyida__1__0_models.ListNavigationByFormTypeRequest,
        headers: dingtalkyida__1__0_models.ListNavigationByFormTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ListNavigationByFormTypeResponse:
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
        if not UtilClient.is_unset(request.form_type):
            query['formType'] = request.form_type
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
            dingtalkyida__1__0_models.ListNavigationByFormTypeResponse(),
            await self.do_roarequest_async('ListNavigationByFormType', 'yida_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/yida/apps/navigations', 'json', req, runtime)
        )

    def terminate_instance(
        self,
        request: dingtalkyida__1__0_models.TerminateInstanceRequest,
    ) -> dingtalkyida__1__0_models.TerminateInstanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.TerminateInstanceHeaders()
        return self.terminate_instance_with_options(request, headers, runtime)

    async def terminate_instance_async(
        self,
        request: dingtalkyida__1__0_models.TerminateInstanceRequest,
    ) -> dingtalkyida__1__0_models.TerminateInstanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.TerminateInstanceHeaders()
        return await self.terminate_instance_with_options_async(request, headers, runtime)

    def terminate_instance_with_options(
        self,
        request: dingtalkyida__1__0_models.TerminateInstanceRequest,
        headers: dingtalkyida__1__0_models.TerminateInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.TerminateInstanceResponse:
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
        if not UtilClient.is_unset(request.process_instance_id):
            query['processInstanceId'] = request.process_instance_id
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
            dingtalkyida__1__0_models.TerminateInstanceResponse(),
            self.do_roarequest('TerminateInstance', 'yida_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/yida/processes/instances/terminate', 'none', req, runtime)
        )

    async def terminate_instance_with_options_async(
        self,
        request: dingtalkyida__1__0_models.TerminateInstanceRequest,
        headers: dingtalkyida__1__0_models.TerminateInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.TerminateInstanceResponse:
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
        if not UtilClient.is_unset(request.process_instance_id):
            query['processInstanceId'] = request.process_instance_id
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
            dingtalkyida__1__0_models.TerminateInstanceResponse(),
            await self.do_roarequest_async('TerminateInstance', 'yida_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/yida/processes/instances/terminate', 'none', req, runtime)
        )

    def expire_commodity(
        self,
        request: dingtalkyida__1__0_models.ExpireCommodityRequest,
    ) -> dingtalkyida__1__0_models.ExpireCommodityResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ExpireCommodityHeaders()
        return self.expire_commodity_with_options(request, headers, runtime)

    async def expire_commodity_async(
        self,
        request: dingtalkyida__1__0_models.ExpireCommodityRequest,
    ) -> dingtalkyida__1__0_models.ExpireCommodityResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ExpireCommodityHeaders()
        return await self.expire_commodity_with_options_async(request, headers, runtime)

    def expire_commodity_with_options(
        self,
        request: dingtalkyida__1__0_models.ExpireCommodityRequest,
        headers: dingtalkyida__1__0_models.ExpireCommodityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ExpireCommodityResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
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
            dingtalkyida__1__0_models.ExpireCommodityResponse(),
            self.do_roarequest('ExpireCommodity', 'yida_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/yida/appAuth/commodities/expire', 'json', req, runtime)
        )

    async def expire_commodity_with_options_async(
        self,
        request: dingtalkyida__1__0_models.ExpireCommodityRequest,
        headers: dingtalkyida__1__0_models.ExpireCommodityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ExpireCommodityResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
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
            dingtalkyida__1__0_models.ExpireCommodityResponse(),
            await self.do_roarequest_async('ExpireCommodity', 'yida_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/yida/appAuth/commodities/expire', 'json', req, runtime)
        )

    def validate_order_buy(
        self,
        request: dingtalkyida__1__0_models.ValidateOrderBuyRequest,
    ) -> dingtalkyida__1__0_models.ValidateOrderBuyResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ValidateOrderBuyHeaders()
        return self.validate_order_buy_with_options(request, headers, runtime)

    async def validate_order_buy_async(
        self,
        request: dingtalkyida__1__0_models.ValidateOrderBuyRequest,
    ) -> dingtalkyida__1__0_models.ValidateOrderBuyResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ValidateOrderBuyHeaders()
        return await self.validate_order_buy_with_options_async(request, headers, runtime)

    def validate_order_buy_with_options(
        self,
        request: dingtalkyida__1__0_models.ValidateOrderBuyRequest,
        headers: dingtalkyida__1__0_models.ValidateOrderBuyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ValidateOrderBuyResponse:
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ValidateOrderBuyResponse(),
            self.do_roarequest('ValidateOrderBuy', 'yida_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/yida/apps/orderBuy/validate', 'json', req, runtime)
        )

    async def validate_order_buy_with_options_async(
        self,
        request: dingtalkyida__1__0_models.ValidateOrderBuyRequest,
        headers: dingtalkyida__1__0_models.ValidateOrderBuyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ValidateOrderBuyResponse:
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.ValidateOrderBuyResponse(),
            await self.do_roarequest_async('ValidateOrderBuy', 'yida_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/yida/apps/orderBuy/validate', 'json', req, runtime)
        )

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

    def delete_form_data(
        self,
        request: dingtalkyida__1__0_models.DeleteFormDataRequest,
    ) -> dingtalkyida__1__0_models.DeleteFormDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.DeleteFormDataHeaders()
        return self.delete_form_data_with_options(request, headers, runtime)

    async def delete_form_data_async(
        self,
        request: dingtalkyida__1__0_models.DeleteFormDataRequest,
    ) -> dingtalkyida__1__0_models.DeleteFormDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.DeleteFormDataHeaders()
        return await self.delete_form_data_with_options_async(request, headers, runtime)

    def delete_form_data_with_options(
        self,
        request: dingtalkyida__1__0_models.DeleteFormDataRequest,
        headers: dingtalkyida__1__0_models.DeleteFormDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.DeleteFormDataResponse:
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
        if not UtilClient.is_unset(request.form_instance_id):
            query['formInstanceId'] = request.form_instance_id
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
            dingtalkyida__1__0_models.DeleteFormDataResponse(),
            self.do_roarequest('DeleteFormData', 'yida_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/yida/forms/instances', 'none', req, runtime)
        )

    async def delete_form_data_with_options_async(
        self,
        request: dingtalkyida__1__0_models.DeleteFormDataRequest,
        headers: dingtalkyida__1__0_models.DeleteFormDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.DeleteFormDataResponse:
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
        if not UtilClient.is_unset(request.form_instance_id):
            query['formInstanceId'] = request.form_instance_id
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
            dingtalkyida__1__0_models.DeleteFormDataResponse(),
            await self.do_roarequest_async('DeleteFormData', 'yida_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/yida/forms/instances', 'none', req, runtime)
        )

    def update_instance(
        self,
        request: dingtalkyida__1__0_models.UpdateInstanceRequest,
    ) -> dingtalkyida__1__0_models.UpdateInstanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.UpdateInstanceHeaders()
        return self.update_instance_with_options(request, headers, runtime)

    async def update_instance_async(
        self,
        request: dingtalkyida__1__0_models.UpdateInstanceRequest,
    ) -> dingtalkyida__1__0_models.UpdateInstanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.UpdateInstanceHeaders()
        return await self.update_instance_with_options_async(request, headers, runtime)

    def update_instance_with_options(
        self,
        request: dingtalkyida__1__0_models.UpdateInstanceRequest,
        headers: dingtalkyida__1__0_models.UpdateInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.UpdateInstanceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.process_instance_id):
            body['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.update_form_data_json):
            body['updateFormDataJson'] = request.update_form_data_json
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            dingtalkyida__1__0_models.UpdateInstanceResponse(),
            self.do_roarequest('UpdateInstance', 'yida_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/yida/processes/instances', 'none', req, runtime)
        )

    async def update_instance_with_options_async(
        self,
        request: dingtalkyida__1__0_models.UpdateInstanceRequest,
        headers: dingtalkyida__1__0_models.UpdateInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.UpdateInstanceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.process_instance_id):
            body['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.update_form_data_json):
            body['updateFormDataJson'] = request.update_form_data_json
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            dingtalkyida__1__0_models.UpdateInstanceResponse(),
            await self.do_roarequest_async('UpdateInstance', 'yida_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/yida/processes/instances', 'none', req, runtime)
        )

    def list_commodity(
        self,
        request: dingtalkyida__1__0_models.ListCommodityRequest,
    ) -> dingtalkyida__1__0_models.ListCommodityResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ListCommodityHeaders()
        return self.list_commodity_with_options(request, headers, runtime)

    async def list_commodity_async(
        self,
        request: dingtalkyida__1__0_models.ListCommodityRequest,
    ) -> dingtalkyida__1__0_models.ListCommodityResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ListCommodityHeaders()
        return await self.list_commodity_with_options_async(request, headers, runtime)

    def list_commodity_with_options(
        self,
        request: dingtalkyida__1__0_models.ListCommodityRequest,
        headers: dingtalkyida__1__0_models.ListCommodityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ListCommodityResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
        if not UtilClient.is_unset(request.current_page):
            query['currentPage'] = request.current_page
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
            dingtalkyida__1__0_models.ListCommodityResponse(),
            self.do_roarequest('ListCommodity', 'yida_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/yida/appAuth/commodities', 'json', req, runtime)
        )

    async def list_commodity_with_options_async(
        self,
        request: dingtalkyida__1__0_models.ListCommodityRequest,
        headers: dingtalkyida__1__0_models.ListCommodityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ListCommodityResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
        if not UtilClient.is_unset(request.current_page):
            query['currentPage'] = request.current_page
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
            dingtalkyida__1__0_models.ListCommodityResponse(),
            await self.do_roarequest_async('ListCommodity', 'yida_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/yida/appAuth/commodities', 'json', req, runtime)
        )

    def get_application_authorization_service_platform_resource(
        self,
        request: dingtalkyida__1__0_models.GetApplicationAuthorizationServicePlatformResourceRequest,
    ) -> dingtalkyida__1__0_models.GetApplicationAuthorizationServicePlatformResourceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetApplicationAuthorizationServicePlatformResourceHeaders()
        return self.get_application_authorization_service_platform_resource_with_options(request, headers, runtime)

    async def get_application_authorization_service_platform_resource_async(
        self,
        request: dingtalkyida__1__0_models.GetApplicationAuthorizationServicePlatformResourceRequest,
    ) -> dingtalkyida__1__0_models.GetApplicationAuthorizationServicePlatformResourceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetApplicationAuthorizationServicePlatformResourceHeaders()
        return await self.get_application_authorization_service_platform_resource_with_options_async(request, headers, runtime)

    def get_application_authorization_service_platform_resource_with_options(
        self,
        request: dingtalkyida__1__0_models.GetApplicationAuthorizationServicePlatformResourceRequest,
        headers: dingtalkyida__1__0_models.GetApplicationAuthorizationServicePlatformResourceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetApplicationAuthorizationServicePlatformResourceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
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
            dingtalkyida__1__0_models.GetApplicationAuthorizationServicePlatformResourceResponse(),
            self.do_roarequest('GetApplicationAuthorizationServicePlatformResource', 'yida_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/yida/authorization/platformResources', 'json', req, runtime)
        )

    async def get_application_authorization_service_platform_resource_with_options_async(
        self,
        request: dingtalkyida__1__0_models.GetApplicationAuthorizationServicePlatformResourceRequest,
        headers: dingtalkyida__1__0_models.GetApplicationAuthorizationServicePlatformResourceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetApplicationAuthorizationServicePlatformResourceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
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
            dingtalkyida__1__0_models.GetApplicationAuthorizationServicePlatformResourceResponse(),
            await self.do_roarequest_async('GetApplicationAuthorizationServicePlatformResource', 'yida_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/yida/authorization/platformResources', 'json', req, runtime)
        )

    def get_activity_list(
        self,
        request: dingtalkyida__1__0_models.GetActivityListRequest,
    ) -> dingtalkyida__1__0_models.GetActivityListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetActivityListHeaders()
        return self.get_activity_list_with_options(request, headers, runtime)

    async def get_activity_list_async(
        self,
        request: dingtalkyida__1__0_models.GetActivityListRequest,
    ) -> dingtalkyida__1__0_models.GetActivityListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetActivityListHeaders()
        return await self.get_activity_list_with_options_async(request, headers, runtime)

    def get_activity_list_with_options(
        self,
        request: dingtalkyida__1__0_models.GetActivityListRequest,
        headers: dingtalkyida__1__0_models.GetActivityListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetActivityListResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.process_code):
            query['processCode'] = request.process_code
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
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
            dingtalkyida__1__0_models.GetActivityListResponse(),
            self.do_roarequest('GetActivityList', 'yida_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/yida/processes/activities', 'json', req, runtime)
        )

    async def get_activity_list_with_options_async(
        self,
        request: dingtalkyida__1__0_models.GetActivityListRequest,
        headers: dingtalkyida__1__0_models.GetActivityListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetActivityListResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.process_code):
            query['processCode'] = request.process_code
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
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
            dingtalkyida__1__0_models.GetActivityListResponse(),
            await self.do_roarequest_async('GetActivityList', 'yida_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/yida/processes/activities', 'json', req, runtime)
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
        id = OpenApiUtilClient.get_encode_param(id)
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
        id = OpenApiUtilClient.get_encode_param(id)
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

    def execute_custom_api(
        self,
        request: dingtalkyida__1__0_models.ExecuteCustomApiRequest,
    ) -> dingtalkyida__1__0_models.ExecuteCustomApiResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ExecuteCustomApiHeaders()
        return self.execute_custom_api_with_options(request, headers, runtime)

    async def execute_custom_api_async(
        self,
        request: dingtalkyida__1__0_models.ExecuteCustomApiRequest,
    ) -> dingtalkyida__1__0_models.ExecuteCustomApiResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ExecuteCustomApiHeaders()
        return await self.execute_custom_api_with_options_async(request, headers, runtime)

    def execute_custom_api_with_options(
        self,
        request: dingtalkyida__1__0_models.ExecuteCustomApiRequest,
        headers: dingtalkyida__1__0_models.ExecuteCustomApiHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ExecuteCustomApiResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.data):
            query['data'] = request.data
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.service_id):
            query['serviceId'] = request.service_id
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
            dingtalkyida__1__0_models.ExecuteCustomApiResponse(),
            self.do_roarequest('ExecuteCustomApi', 'yida_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/yida/apps/customApi/execute', 'json', req, runtime)
        )

    async def execute_custom_api_with_options_async(
        self,
        request: dingtalkyida__1__0_models.ExecuteCustomApiRequest,
        headers: dingtalkyida__1__0_models.ExecuteCustomApiHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ExecuteCustomApiResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.data):
            query['data'] = request.data
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.service_id):
            query['serviceId'] = request.service_id
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
            dingtalkyida__1__0_models.ExecuteCustomApiResponse(),
            await self.do_roarequest_async('ExecuteCustomApi', 'yida_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/yida/apps/customApi/execute', 'json', req, runtime)
        )

    def refund_commodity(
        self,
        request: dingtalkyida__1__0_models.RefundCommodityRequest,
    ) -> dingtalkyida__1__0_models.RefundCommodityResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.RefundCommodityHeaders()
        return self.refund_commodity_with_options(request, headers, runtime)

    async def refund_commodity_async(
        self,
        request: dingtalkyida__1__0_models.RefundCommodityRequest,
    ) -> dingtalkyida__1__0_models.RefundCommodityResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.RefundCommodityHeaders()
        return await self.refund_commodity_with_options_async(request, headers, runtime)

    def refund_commodity_with_options(
        self,
        request: dingtalkyida__1__0_models.RefundCommodityRequest,
        headers: dingtalkyida__1__0_models.RefundCommodityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.RefundCommodityResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
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
            dingtalkyida__1__0_models.RefundCommodityResponse(),
            self.do_roarequest('RefundCommodity', 'yida_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/yida/appAuth/commodities/refund', 'json', req, runtime)
        )

    async def refund_commodity_with_options_async(
        self,
        request: dingtalkyida__1__0_models.RefundCommodityRequest,
        headers: dingtalkyida__1__0_models.RefundCommodityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.RefundCommodityResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
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
            dingtalkyida__1__0_models.RefundCommodityResponse(),
            await self.do_roarequest_async('RefundCommodity', 'yida_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/yida/appAuth/commodities/refund', 'json', req, runtime)
        )

    def delete_sequence(
        self,
        request: dingtalkyida__1__0_models.DeleteSequenceRequest,
    ) -> dingtalkyida__1__0_models.DeleteSequenceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.DeleteSequenceHeaders()
        return self.delete_sequence_with_options(request, headers, runtime)

    async def delete_sequence_async(
        self,
        request: dingtalkyida__1__0_models.DeleteSequenceRequest,
    ) -> dingtalkyida__1__0_models.DeleteSequenceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.DeleteSequenceHeaders()
        return await self.delete_sequence_with_options_async(request, headers, runtime)

    def delete_sequence_with_options(
        self,
        request: dingtalkyida__1__0_models.DeleteSequenceRequest,
        headers: dingtalkyida__1__0_models.DeleteSequenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.DeleteSequenceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        if not UtilClient.is_unset(request.sequence):
            query['sequence'] = request.sequence
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
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
            dingtalkyida__1__0_models.DeleteSequenceResponse(),
            self.do_roarequest('DeleteSequence', 'yida_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/yida/forms/deleteSequence', 'none', req, runtime)
        )

    async def delete_sequence_with_options_async(
        self,
        request: dingtalkyida__1__0_models.DeleteSequenceRequest,
        headers: dingtalkyida__1__0_models.DeleteSequenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.DeleteSequenceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        if not UtilClient.is_unset(request.sequence):
            query['sequence'] = request.sequence
        if not UtilClient.is_unset(request.system_token):
            query['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.language):
            query['language'] = request.language
        if not UtilClient.is_unset(request.app_type):
            query['appType'] = request.app_type
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
            dingtalkyida__1__0_models.DeleteSequenceResponse(),
            await self.do_roarequest_async('DeleteSequence', 'yida_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/yida/forms/deleteSequence', 'none', req, runtime)
        )

    def release_commodity(
        self,
        request: dingtalkyida__1__0_models.ReleaseCommodityRequest,
    ) -> dingtalkyida__1__0_models.ReleaseCommodityResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ReleaseCommodityHeaders()
        return self.release_commodity_with_options(request, headers, runtime)

    async def release_commodity_async(
        self,
        request: dingtalkyida__1__0_models.ReleaseCommodityRequest,
    ) -> dingtalkyida__1__0_models.ReleaseCommodityResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ReleaseCommodityHeaders()
        return await self.release_commodity_with_options_async(request, headers, runtime)

    def release_commodity_with_options(
        self,
        request: dingtalkyida__1__0_models.ReleaseCommodityRequest,
        headers: dingtalkyida__1__0_models.ReleaseCommodityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ReleaseCommodityResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
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
            dingtalkyida__1__0_models.ReleaseCommodityResponse(),
            self.do_roarequest('ReleaseCommodity', 'yida_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/yida/appAuth/commodities/release', 'json', req, runtime)
        )

    async def release_commodity_with_options_async(
        self,
        request: dingtalkyida__1__0_models.ReleaseCommodityRequest,
        headers: dingtalkyida__1__0_models.ReleaseCommodityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ReleaseCommodityResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.access_key):
            query['accessKey'] = request.access_key
        if not UtilClient.is_unset(request.caller_uid):
            query['callerUid'] = request.caller_uid
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
            dingtalkyida__1__0_models.ReleaseCommodityResponse(),
            await self.do_roarequest_async('ReleaseCommodity', 'yida_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/yida/appAuth/commodities/release', 'json', req, runtime)
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

    def get_sale_user_info_by_user_id(
        self,
        request: dingtalkyida__1__0_models.GetSaleUserInfoByUserIdRequest,
    ) -> dingtalkyida__1__0_models.GetSaleUserInfoByUserIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetSaleUserInfoByUserIdHeaders()
        return self.get_sale_user_info_by_user_id_with_options(request, headers, runtime)

    async def get_sale_user_info_by_user_id_async(
        self,
        request: dingtalkyida__1__0_models.GetSaleUserInfoByUserIdRequest,
    ) -> dingtalkyida__1__0_models.GetSaleUserInfoByUserIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.GetSaleUserInfoByUserIdHeaders()
        return await self.get_sale_user_info_by_user_id_with_options_async(request, headers, runtime)

    def get_sale_user_info_by_user_id_with_options(
        self,
        request: dingtalkyida__1__0_models.GetSaleUserInfoByUserIdRequest,
        headers: dingtalkyida__1__0_models.GetSaleUserInfoByUserIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetSaleUserInfoByUserIdResponse:
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetSaleUserInfoByUserIdResponse(),
            self.do_roarequest('GetSaleUserInfoByUserId', 'yida_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/yida/apps/saleUserInfo', 'json', req, runtime)
        )

    async def get_sale_user_info_by_user_id_with_options_async(
        self,
        request: dingtalkyida__1__0_models.GetSaleUserInfoByUserIdRequest,
        headers: dingtalkyida__1__0_models.GetSaleUserInfoByUserIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.GetSaleUserInfoByUserIdResponse:
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkyida__1__0_models.GetSaleUserInfoByUserIdResponse(),
            await self.do_roarequest_async('GetSaleUserInfoByUserId', 'yida_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/yida/apps/saleUserInfo', 'json', req, runtime)
        )

    def execute_task(
        self,
        request: dingtalkyida__1__0_models.ExecuteTaskRequest,
    ) -> dingtalkyida__1__0_models.ExecuteTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ExecuteTaskHeaders()
        return self.execute_task_with_options(request, headers, runtime)

    async def execute_task_async(
        self,
        request: dingtalkyida__1__0_models.ExecuteTaskRequest,
    ) -> dingtalkyida__1__0_models.ExecuteTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.ExecuteTaskHeaders()
        return await self.execute_task_with_options_async(request, headers, runtime)

    def execute_task_with_options(
        self,
        request: dingtalkyida__1__0_models.ExecuteTaskRequest,
        headers: dingtalkyida__1__0_models.ExecuteTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ExecuteTaskResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.out_result):
            body['outResult'] = request.out_result
        if not UtilClient.is_unset(request.no_execute_expressions):
            body['noExecuteExpressions'] = request.no_execute_expressions
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_data_json):
            body['formDataJson'] = request.form_data_json
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.process_instance_id):
            body['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.task_id):
            body['taskId'] = request.task_id
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
            dingtalkyida__1__0_models.ExecuteTaskResponse(),
            self.do_roarequest('ExecuteTask', 'yida_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/yida/tasks/execute', 'none', req, runtime)
        )

    async def execute_task_with_options_async(
        self,
        request: dingtalkyida__1__0_models.ExecuteTaskRequest,
        headers: dingtalkyida__1__0_models.ExecuteTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.ExecuteTaskResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.out_result):
            body['outResult'] = request.out_result
        if not UtilClient.is_unset(request.no_execute_expressions):
            body['noExecuteExpressions'] = request.no_execute_expressions
        if not UtilClient.is_unset(request.app_type):
            body['appType'] = request.app_type
        if not UtilClient.is_unset(request.form_data_json):
            body['formDataJson'] = request.form_data_json
        if not UtilClient.is_unset(request.system_token):
            body['systemToken'] = request.system_token
        if not UtilClient.is_unset(request.language):
            body['language'] = request.language
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.process_instance_id):
            body['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.task_id):
            body['taskId'] = request.task_id
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
            dingtalkyida__1__0_models.ExecuteTaskResponse(),
            await self.do_roarequest_async('ExecuteTask', 'yida_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/yida/tasks/execute', 'none', req, runtime)
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

    def delete_instance(
        self,
        request: dingtalkyida__1__0_models.DeleteInstanceRequest,
    ) -> dingtalkyida__1__0_models.DeleteInstanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.DeleteInstanceHeaders()
        return self.delete_instance_with_options(request, headers, runtime)

    async def delete_instance_async(
        self,
        request: dingtalkyida__1__0_models.DeleteInstanceRequest,
    ) -> dingtalkyida__1__0_models.DeleteInstanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyida__1__0_models.DeleteInstanceHeaders()
        return await self.delete_instance_with_options_async(request, headers, runtime)

    def delete_instance_with_options(
        self,
        request: dingtalkyida__1__0_models.DeleteInstanceRequest,
        headers: dingtalkyida__1__0_models.DeleteInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.DeleteInstanceResponse:
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
        if not UtilClient.is_unset(request.process_instance_id):
            query['processInstanceId'] = request.process_instance_id
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
            dingtalkyida__1__0_models.DeleteInstanceResponse(),
            self.do_roarequest('DeleteInstance', 'yida_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/yida/processes/instances', 'none', req, runtime)
        )

    async def delete_instance_with_options_async(
        self,
        request: dingtalkyida__1__0_models.DeleteInstanceRequest,
        headers: dingtalkyida__1__0_models.DeleteInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyida__1__0_models.DeleteInstanceResponse:
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
        if not UtilClient.is_unset(request.process_instance_id):
            query['processInstanceId'] = request.process_instance_id
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
            dingtalkyida__1__0_models.DeleteInstanceResponse(),
            await self.do_roarequest_async('DeleteInstance', 'yida_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/yida/processes/instances', 'none', req, runtime)
        )
