# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.workflow_1_0 import models as dingtalkworkflow__1__0_models
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

    def batch_update_process_instance(
        self,
        request: dingtalkworkflow__1__0_models.BatchUpdateProcessInstanceRequest,
    ) -> dingtalkworkflow__1__0_models.BatchUpdateProcessInstanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.BatchUpdateProcessInstanceHeaders()
        return self.batch_update_process_instance_with_options(request, headers, runtime)

    async def batch_update_process_instance_async(
        self,
        request: dingtalkworkflow__1__0_models.BatchUpdateProcessInstanceRequest,
    ) -> dingtalkworkflow__1__0_models.BatchUpdateProcessInstanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.BatchUpdateProcessInstanceHeaders()
        return await self.batch_update_process_instance_with_options_async(request, headers, runtime)

    def batch_update_process_instance_with_options(
        self,
        request: dingtalkworkflow__1__0_models.BatchUpdateProcessInstanceRequest,
        headers: dingtalkworkflow__1__0_models.BatchUpdateProcessInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.BatchUpdateProcessInstanceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.update_process_instance_requests):
            body['updateProcessInstanceRequests'] = request.update_process_instance_requests
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
            dingtalkworkflow__1__0_models.BatchUpdateProcessInstanceResponse(),
            self.do_roarequest('BatchUpdateProcessInstance', 'workflow_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/workflow/processCentres/instances/batch', 'json', req, runtime)
        )

    async def batch_update_process_instance_with_options_async(
        self,
        request: dingtalkworkflow__1__0_models.BatchUpdateProcessInstanceRequest,
        headers: dingtalkworkflow__1__0_models.BatchUpdateProcessInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.BatchUpdateProcessInstanceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.update_process_instance_requests):
            body['updateProcessInstanceRequests'] = request.update_process_instance_requests
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
            dingtalkworkflow__1__0_models.BatchUpdateProcessInstanceResponse(),
            await self.do_roarequest_async('BatchUpdateProcessInstance', 'workflow_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/workflow/processCentres/instances/batch', 'json', req, runtime)
        )

    def cancel_integrated_task(
        self,
        request: dingtalkworkflow__1__0_models.CancelIntegratedTaskRequest,
    ) -> dingtalkworkflow__1__0_models.CancelIntegratedTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.CancelIntegratedTaskHeaders()
        return self.cancel_integrated_task_with_options(request, headers, runtime)

    async def cancel_integrated_task_async(
        self,
        request: dingtalkworkflow__1__0_models.CancelIntegratedTaskRequest,
    ) -> dingtalkworkflow__1__0_models.CancelIntegratedTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.CancelIntegratedTaskHeaders()
        return await self.cancel_integrated_task_with_options_async(request, headers, runtime)

    def cancel_integrated_task_with_options(
        self,
        request: dingtalkworkflow__1__0_models.CancelIntegratedTaskRequest,
        headers: dingtalkworkflow__1__0_models.CancelIntegratedTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.CancelIntegratedTaskResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.activity_id):
            body['activityId'] = request.activity_id
        if not UtilClient.is_unset(request.activity_ids):
            body['activityIds'] = request.activity_ids
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
        return TeaCore.from_map(
            dingtalkworkflow__1__0_models.CancelIntegratedTaskResponse(),
            self.do_roarequest('CancelIntegratedTask', 'workflow_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/workflow/processCentres/tasks/cancel', 'json', req, runtime)
        )

    async def cancel_integrated_task_with_options_async(
        self,
        request: dingtalkworkflow__1__0_models.CancelIntegratedTaskRequest,
        headers: dingtalkworkflow__1__0_models.CancelIntegratedTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.CancelIntegratedTaskResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.activity_id):
            body['activityId'] = request.activity_id
        if not UtilClient.is_unset(request.activity_ids):
            body['activityIds'] = request.activity_ids
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
        return TeaCore.from_map(
            dingtalkworkflow__1__0_models.CancelIntegratedTaskResponse(),
            await self.do_roarequest_async('CancelIntegratedTask', 'workflow_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/workflow/processCentres/tasks/cancel', 'json', req, runtime)
        )

    def copy_process(
        self,
        request: dingtalkworkflow__1__0_models.CopyProcessRequest,
    ) -> dingtalkworkflow__1__0_models.CopyProcessResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.CopyProcessHeaders()
        return self.copy_process_with_options(request, headers, runtime)

    async def copy_process_async(
        self,
        request: dingtalkworkflow__1__0_models.CopyProcessRequest,
    ) -> dingtalkworkflow__1__0_models.CopyProcessResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.CopyProcessHeaders()
        return await self.copy_process_with_options_async(request, headers, runtime)

    def copy_process_with_options(
        self,
        request: dingtalkworkflow__1__0_models.CopyProcessRequest,
        headers: dingtalkworkflow__1__0_models.CopyProcessHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.CopyProcessResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.copy_options):
            body['copyOptions'] = request.copy_options
        if not UtilClient.is_unset(request.source_corp_id):
            body['sourceCorpId'] = request.source_corp_id
        if not UtilClient.is_unset(request.source_process_volist):
            body['sourceProcessVOList'] = request.source_process_volist
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
            dingtalkworkflow__1__0_models.CopyProcessResponse(),
            self.do_roarequest('CopyProcess', 'workflow_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/workflow/processes/copy', 'json', req, runtime)
        )

    async def copy_process_with_options_async(
        self,
        request: dingtalkworkflow__1__0_models.CopyProcessRequest,
        headers: dingtalkworkflow__1__0_models.CopyProcessHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.CopyProcessResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.copy_options):
            body['copyOptions'] = request.copy_options
        if not UtilClient.is_unset(request.source_corp_id):
            body['sourceCorpId'] = request.source_corp_id
        if not UtilClient.is_unset(request.source_process_volist):
            body['sourceProcessVOList'] = request.source_process_volist
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
            dingtalkworkflow__1__0_models.CopyProcessResponse(),
            await self.do_roarequest_async('CopyProcess', 'workflow_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/workflow/processes/copy', 'json', req, runtime)
        )

    def create_integrated_task(
        self,
        request: dingtalkworkflow__1__0_models.CreateIntegratedTaskRequest,
    ) -> dingtalkworkflow__1__0_models.CreateIntegratedTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.CreateIntegratedTaskHeaders()
        return self.create_integrated_task_with_options(request, headers, runtime)

    async def create_integrated_task_async(
        self,
        request: dingtalkworkflow__1__0_models.CreateIntegratedTaskRequest,
    ) -> dingtalkworkflow__1__0_models.CreateIntegratedTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.CreateIntegratedTaskHeaders()
        return await self.create_integrated_task_with_options_async(request, headers, runtime)

    def create_integrated_task_with_options(
        self,
        request: dingtalkworkflow__1__0_models.CreateIntegratedTaskRequest,
        headers: dingtalkworkflow__1__0_models.CreateIntegratedTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.CreateIntegratedTaskResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.activity_id):
            body['activityId'] = request.activity_id
        if not UtilClient.is_unset(request.process_instance_id):
            body['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.tasks):
            body['tasks'] = request.tasks
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
            dingtalkworkflow__1__0_models.CreateIntegratedTaskResponse(),
            self.do_roarequest('CreateIntegratedTask', 'workflow_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/workflow/processCentres/tasks', 'json', req, runtime)
        )

    async def create_integrated_task_with_options_async(
        self,
        request: dingtalkworkflow__1__0_models.CreateIntegratedTaskRequest,
        headers: dingtalkworkflow__1__0_models.CreateIntegratedTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.CreateIntegratedTaskResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.activity_id):
            body['activityId'] = request.activity_id
        if not UtilClient.is_unset(request.process_instance_id):
            body['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.tasks):
            body['tasks'] = request.tasks
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
            dingtalkworkflow__1__0_models.CreateIntegratedTaskResponse(),
            await self.do_roarequest_async('CreateIntegratedTask', 'workflow_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/workflow/processCentres/tasks', 'json', req, runtime)
        )

    def delete_process(
        self,
        request: dingtalkworkflow__1__0_models.DeleteProcessRequest,
    ) -> dingtalkworkflow__1__0_models.DeleteProcessResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.DeleteProcessHeaders()
        return self.delete_process_with_options(request, headers, runtime)

    async def delete_process_async(
        self,
        request: dingtalkworkflow__1__0_models.DeleteProcessRequest,
    ) -> dingtalkworkflow__1__0_models.DeleteProcessResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.DeleteProcessHeaders()
        return await self.delete_process_with_options_async(request, headers, runtime)

    def delete_process_with_options(
        self,
        request: dingtalkworkflow__1__0_models.DeleteProcessRequest,
        headers: dingtalkworkflow__1__0_models.DeleteProcessHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.DeleteProcessResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.clean_running_task):
            query['cleanRunningTask'] = request.clean_running_task
        if not UtilClient.is_unset(request.process_code):
            query['processCode'] = request.process_code
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
            dingtalkworkflow__1__0_models.DeleteProcessResponse(),
            self.do_roarequest('DeleteProcess', 'workflow_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/workflow/processCentres/schemas', 'json', req, runtime)
        )

    async def delete_process_with_options_async(
        self,
        request: dingtalkworkflow__1__0_models.DeleteProcessRequest,
        headers: dingtalkworkflow__1__0_models.DeleteProcessHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.DeleteProcessResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.clean_running_task):
            query['cleanRunningTask'] = request.clean_running_task
        if not UtilClient.is_unset(request.process_code):
            query['processCode'] = request.process_code
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
            dingtalkworkflow__1__0_models.DeleteProcessResponse(),
            await self.do_roarequest_async('DeleteProcess', 'workflow_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/workflow/processCentres/schemas', 'json', req, runtime)
        )

    def form_create(
        self,
        request: dingtalkworkflow__1__0_models.FormCreateRequest,
    ) -> dingtalkworkflow__1__0_models.FormCreateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.FormCreateHeaders()
        return self.form_create_with_options(request, headers, runtime)

    async def form_create_async(
        self,
        request: dingtalkworkflow__1__0_models.FormCreateRequest,
    ) -> dingtalkworkflow__1__0_models.FormCreateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.FormCreateHeaders()
        return await self.form_create_with_options_async(request, headers, runtime)

    def form_create_with_options(
        self,
        request: dingtalkworkflow__1__0_models.FormCreateRequest,
        headers: dingtalkworkflow__1__0_models.FormCreateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.FormCreateResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.form_components):
            body['formComponents'] = request.form_components
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.process_code):
            body['processCode'] = request.process_code
        if not UtilClient.is_unset(request.template_config):
            body['templateConfig'] = request.template_config
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
            dingtalkworkflow__1__0_models.FormCreateResponse(),
            self.do_roarequest('FormCreate', 'workflow_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/workflow/forms', 'json', req, runtime)
        )

    async def form_create_with_options_async(
        self,
        request: dingtalkworkflow__1__0_models.FormCreateRequest,
        headers: dingtalkworkflow__1__0_models.FormCreateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.FormCreateResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.form_components):
            body['formComponents'] = request.form_components
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.process_code):
            body['processCode'] = request.process_code
        if not UtilClient.is_unset(request.template_config):
            body['templateConfig'] = request.template_config
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
            dingtalkworkflow__1__0_models.FormCreateResponse(),
            await self.do_roarequest_async('FormCreate', 'workflow_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/workflow/forms', 'json', req, runtime)
        )

    def get_crm_proc_codes(self) -> dingtalkworkflow__1__0_models.GetCrmProcCodesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.GetCrmProcCodesHeaders()
        return self.get_crm_proc_codes_with_options(headers, runtime)

    async def get_crm_proc_codes_async(self) -> dingtalkworkflow__1__0_models.GetCrmProcCodesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.GetCrmProcCodesHeaders()
        return await self.get_crm_proc_codes_with_options_async(headers, runtime)

    def get_crm_proc_codes_with_options(
        self,
        headers: dingtalkworkflow__1__0_models.GetCrmProcCodesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.GetCrmProcCodesResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkworkflow__1__0_models.GetCrmProcCodesResponse(),
            self.do_roarequest('GetCrmProcCodes', 'workflow_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/workflow/crm/processes', 'json', req, runtime)
        )

    async def get_crm_proc_codes_with_options_async(
        self,
        headers: dingtalkworkflow__1__0_models.GetCrmProcCodesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.GetCrmProcCodesResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkworkflow__1__0_models.GetCrmProcCodesResponse(),
            await self.do_roarequest_async('GetCrmProcCodes', 'workflow_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/workflow/crm/processes', 'json', req, runtime)
        )

    def get_process_code_by_name(
        self,
        request: dingtalkworkflow__1__0_models.GetProcessCodeByNameRequest,
    ) -> dingtalkworkflow__1__0_models.GetProcessCodeByNameResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.GetProcessCodeByNameHeaders()
        return self.get_process_code_by_name_with_options(request, headers, runtime)

    async def get_process_code_by_name_async(
        self,
        request: dingtalkworkflow__1__0_models.GetProcessCodeByNameRequest,
    ) -> dingtalkworkflow__1__0_models.GetProcessCodeByNameResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.GetProcessCodeByNameHeaders()
        return await self.get_process_code_by_name_with_options_async(request, headers, runtime)

    def get_process_code_by_name_with_options(
        self,
        request: dingtalkworkflow__1__0_models.GetProcessCodeByNameRequest,
        headers: dingtalkworkflow__1__0_models.GetProcessCodeByNameHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.GetProcessCodeByNameResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.name):
            query['name'] = request.name
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
            dingtalkworkflow__1__0_models.GetProcessCodeByNameResponse(),
            self.do_roarequest('GetProcessCodeByName', 'workflow_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/workflow/processCentres/schemaNames/processCodes', 'json', req, runtime)
        )

    async def get_process_code_by_name_with_options_async(
        self,
        request: dingtalkworkflow__1__0_models.GetProcessCodeByNameRequest,
        headers: dingtalkworkflow__1__0_models.GetProcessCodeByNameHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.GetProcessCodeByNameResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.name):
            query['name'] = request.name
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
            dingtalkworkflow__1__0_models.GetProcessCodeByNameResponse(),
            await self.do_roarequest_async('GetProcessCodeByName', 'workflow_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/workflow/processCentres/schemaNames/processCodes', 'json', req, runtime)
        )

    def get_process_config(
        self,
        request: dingtalkworkflow__1__0_models.GetProcessConfigRequest,
    ) -> dingtalkworkflow__1__0_models.GetProcessConfigResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.GetProcessConfigHeaders()
        return self.get_process_config_with_options(request, headers, runtime)

    async def get_process_config_async(
        self,
        request: dingtalkworkflow__1__0_models.GetProcessConfigRequest,
    ) -> dingtalkworkflow__1__0_models.GetProcessConfigResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.GetProcessConfigHeaders()
        return await self.get_process_config_with_options_async(request, headers, runtime)

    def get_process_config_with_options(
        self,
        request: dingtalkworkflow__1__0_models.GetProcessConfigRequest,
        headers: dingtalkworkflow__1__0_models.GetProcessConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.GetProcessConfigResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.proc_code):
            query['procCode'] = request.proc_code
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
            dingtalkworkflow__1__0_models.GetProcessConfigResponse(),
            self.do_roarequest('GetProcessConfig', 'workflow_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/workflow/crm/processes/configurations', 'json', req, runtime)
        )

    async def get_process_config_with_options_async(
        self,
        request: dingtalkworkflow__1__0_models.GetProcessConfigRequest,
        headers: dingtalkworkflow__1__0_models.GetProcessConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.GetProcessConfigResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.proc_code):
            query['procCode'] = request.proc_code
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
            dingtalkworkflow__1__0_models.GetProcessConfigResponse(),
            await self.do_roarequest_async('GetProcessConfig', 'workflow_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/workflow/crm/processes/configurations', 'json', req, runtime)
        )

    def grant_cspace_authorization(
        self,
        request: dingtalkworkflow__1__0_models.GrantCspaceAuthorizationRequest,
    ) -> dingtalkworkflow__1__0_models.GrantCspaceAuthorizationResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.GrantCspaceAuthorizationHeaders()
        return self.grant_cspace_authorization_with_options(request, headers, runtime)

    async def grant_cspace_authorization_async(
        self,
        request: dingtalkworkflow__1__0_models.GrantCspaceAuthorizationRequest,
    ) -> dingtalkworkflow__1__0_models.GrantCspaceAuthorizationResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.GrantCspaceAuthorizationHeaders()
        return await self.grant_cspace_authorization_with_options_async(request, headers, runtime)

    def grant_cspace_authorization_with_options(
        self,
        request: dingtalkworkflow__1__0_models.GrantCspaceAuthorizationRequest,
        headers: dingtalkworkflow__1__0_models.GrantCspaceAuthorizationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.GrantCspaceAuthorizationResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.duration_seconds):
            body['durationSeconds'] = request.duration_seconds
        if not UtilClient.is_unset(request.space_id):
            body['spaceId'] = request.space_id
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
        return TeaCore.from_map(
            dingtalkworkflow__1__0_models.GrantCspaceAuthorizationResponse(),
            self.do_roarequest('GrantCspaceAuthorization', 'workflow_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/workflow/spaces/authorize', 'none', req, runtime)
        )

    async def grant_cspace_authorization_with_options_async(
        self,
        request: dingtalkworkflow__1__0_models.GrantCspaceAuthorizationRequest,
        headers: dingtalkworkflow__1__0_models.GrantCspaceAuthorizationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.GrantCspaceAuthorizationResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.duration_seconds):
            body['durationSeconds'] = request.duration_seconds
        if not UtilClient.is_unset(request.space_id):
            body['spaceId'] = request.space_id
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
        return TeaCore.from_map(
            dingtalkworkflow__1__0_models.GrantCspaceAuthorizationResponse(),
            await self.do_roarequest_async('GrantCspaceAuthorization', 'workflow_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/workflow/spaces/authorize', 'none', req, runtime)
        )

    def process_forecast(
        self,
        request: dingtalkworkflow__1__0_models.ProcessForecastRequest,
    ) -> dingtalkworkflow__1__0_models.ProcessForecastResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.ProcessForecastHeaders()
        return self.process_forecast_with_options(request, headers, runtime)

    async def process_forecast_async(
        self,
        request: dingtalkworkflow__1__0_models.ProcessForecastRequest,
    ) -> dingtalkworkflow__1__0_models.ProcessForecastResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.ProcessForecastHeaders()
        return await self.process_forecast_with_options_async(request, headers, runtime)

    def process_forecast_with_options(
        self,
        request: dingtalkworkflow__1__0_models.ProcessForecastRequest,
        headers: dingtalkworkflow__1__0_models.ProcessForecastHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.ProcessForecastResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.form_component_values):
            body['formComponentValues'] = request.form_component_values
        if not UtilClient.is_unset(request.process_code):
            body['processCode'] = request.process_code
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
        return TeaCore.from_map(
            dingtalkworkflow__1__0_models.ProcessForecastResponse(),
            self.do_roarequest('ProcessForecast', 'workflow_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/workflow/processes/forecast', 'json', req, runtime)
        )

    async def process_forecast_with_options_async(
        self,
        request: dingtalkworkflow__1__0_models.ProcessForecastRequest,
        headers: dingtalkworkflow__1__0_models.ProcessForecastHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.ProcessForecastResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.form_component_values):
            body['formComponentValues'] = request.form_component_values
        if not UtilClient.is_unset(request.process_code):
            body['processCode'] = request.process_code
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
        return TeaCore.from_map(
            dingtalkworkflow__1__0_models.ProcessForecastResponse(),
            await self.do_roarequest_async('ProcessForecast', 'workflow_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/workflow/processes/forecast', 'json', req, runtime)
        )

    def query_all_form_instances(
        self,
        request: dingtalkworkflow__1__0_models.QueryAllFormInstancesRequest,
    ) -> dingtalkworkflow__1__0_models.QueryAllFormInstancesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.QueryAllFormInstancesHeaders()
        return self.query_all_form_instances_with_options(request, headers, runtime)

    async def query_all_form_instances_async(
        self,
        request: dingtalkworkflow__1__0_models.QueryAllFormInstancesRequest,
    ) -> dingtalkworkflow__1__0_models.QueryAllFormInstancesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.QueryAllFormInstancesHeaders()
        return await self.query_all_form_instances_with_options_async(request, headers, runtime)

    def query_all_form_instances_with_options(
        self,
        request: dingtalkworkflow__1__0_models.QueryAllFormInstancesRequest,
        headers: dingtalkworkflow__1__0_models.QueryAllFormInstancesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.QueryAllFormInstancesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_uuid):
            query['appUuid'] = request.app_uuid
        if not UtilClient.is_unset(request.form_code):
            query['formCode'] = request.form_code
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
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
            dingtalkworkflow__1__0_models.QueryAllFormInstancesResponse(),
            self.do_roarequest('QueryAllFormInstances', 'workflow_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/workflow/forms/pages/instances', 'json', req, runtime)
        )

    async def query_all_form_instances_with_options_async(
        self,
        request: dingtalkworkflow__1__0_models.QueryAllFormInstancesRequest,
        headers: dingtalkworkflow__1__0_models.QueryAllFormInstancesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.QueryAllFormInstancesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_uuid):
            query['appUuid'] = request.app_uuid
        if not UtilClient.is_unset(request.form_code):
            query['formCode'] = request.form_code
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
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
            dingtalkworkflow__1__0_models.QueryAllFormInstancesResponse(),
            await self.do_roarequest_async('QueryAllFormInstances', 'workflow_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/workflow/forms/pages/instances', 'json', req, runtime)
        )

    def query_all_process_instances(
        self,
        request: dingtalkworkflow__1__0_models.QueryAllProcessInstancesRequest,
    ) -> dingtalkworkflow__1__0_models.QueryAllProcessInstancesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.QueryAllProcessInstancesHeaders()
        return self.query_all_process_instances_with_options(request, headers, runtime)

    async def query_all_process_instances_async(
        self,
        request: dingtalkworkflow__1__0_models.QueryAllProcessInstancesRequest,
    ) -> dingtalkworkflow__1__0_models.QueryAllProcessInstancesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.QueryAllProcessInstancesHeaders()
        return await self.query_all_process_instances_with_options_async(request, headers, runtime)

    def query_all_process_instances_with_options(
        self,
        request: dingtalkworkflow__1__0_models.QueryAllProcessInstancesRequest,
        headers: dingtalkworkflow__1__0_models.QueryAllProcessInstancesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.QueryAllProcessInstancesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_uuid):
            query['appUuid'] = request.app_uuid
        if not UtilClient.is_unset(request.end_time_in_mills):
            query['endTimeInMills'] = request.end_time_in_mills
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.process_code):
            query['processCode'] = request.process_code
        if not UtilClient.is_unset(request.start_time_in_mills):
            query['startTimeInMills'] = request.start_time_in_mills
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
            dingtalkworkflow__1__0_models.QueryAllProcessInstancesResponse(),
            self.do_roarequest('QueryAllProcessInstances', 'workflow_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/workflow/processes/pages/instances', 'json', req, runtime)
        )

    async def query_all_process_instances_with_options_async(
        self,
        request: dingtalkworkflow__1__0_models.QueryAllProcessInstancesRequest,
        headers: dingtalkworkflow__1__0_models.QueryAllProcessInstancesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.QueryAllProcessInstancesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_uuid):
            query['appUuid'] = request.app_uuid
        if not UtilClient.is_unset(request.end_time_in_mills):
            query['endTimeInMills'] = request.end_time_in_mills
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.process_code):
            query['processCode'] = request.process_code
        if not UtilClient.is_unset(request.start_time_in_mills):
            query['startTimeInMills'] = request.start_time_in_mills
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
            dingtalkworkflow__1__0_models.QueryAllProcessInstancesResponse(),
            await self.do_roarequest_async('QueryAllProcessInstances', 'workflow_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/workflow/processes/pages/instances', 'json', req, runtime)
        )

    def query_form_by_biz_type(
        self,
        request: dingtalkworkflow__1__0_models.QueryFormByBizTypeRequest,
    ) -> dingtalkworkflow__1__0_models.QueryFormByBizTypeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.QueryFormByBizTypeHeaders()
        return self.query_form_by_biz_type_with_options(request, headers, runtime)

    async def query_form_by_biz_type_async(
        self,
        request: dingtalkworkflow__1__0_models.QueryFormByBizTypeRequest,
    ) -> dingtalkworkflow__1__0_models.QueryFormByBizTypeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.QueryFormByBizTypeHeaders()
        return await self.query_form_by_biz_type_with_options_async(request, headers, runtime)

    def query_form_by_biz_type_with_options(
        self,
        request: dingtalkworkflow__1__0_models.QueryFormByBizTypeRequest,
        headers: dingtalkworkflow__1__0_models.QueryFormByBizTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.QueryFormByBizTypeResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_uuid):
            body['appUuid'] = request.app_uuid
        if not UtilClient.is_unset(request.biz_types):
            body['bizTypes'] = request.biz_types
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
            dingtalkworkflow__1__0_models.QueryFormByBizTypeResponse(),
            self.do_roarequest('QueryFormByBizType', 'workflow_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/workflow/forms/forminfos/query', 'json', req, runtime)
        )

    async def query_form_by_biz_type_with_options_async(
        self,
        request: dingtalkworkflow__1__0_models.QueryFormByBizTypeRequest,
        headers: dingtalkworkflow__1__0_models.QueryFormByBizTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.QueryFormByBizTypeResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_uuid):
            body['appUuid'] = request.app_uuid
        if not UtilClient.is_unset(request.biz_types):
            body['bizTypes'] = request.biz_types
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
            dingtalkworkflow__1__0_models.QueryFormByBizTypeResponse(),
            await self.do_roarequest_async('QueryFormByBizType', 'workflow_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/workflow/forms/forminfos/query', 'json', req, runtime)
        )

    def query_form_instance(
        self,
        request: dingtalkworkflow__1__0_models.QueryFormInstanceRequest,
    ) -> dingtalkworkflow__1__0_models.QueryFormInstanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.QueryFormInstanceHeaders()
        return self.query_form_instance_with_options(request, headers, runtime)

    async def query_form_instance_async(
        self,
        request: dingtalkworkflow__1__0_models.QueryFormInstanceRequest,
    ) -> dingtalkworkflow__1__0_models.QueryFormInstanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.QueryFormInstanceHeaders()
        return await self.query_form_instance_with_options_async(request, headers, runtime)

    def query_form_instance_with_options(
        self,
        request: dingtalkworkflow__1__0_models.QueryFormInstanceRequest,
        headers: dingtalkworkflow__1__0_models.QueryFormInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.QueryFormInstanceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_uuid):
            query['appUuid'] = request.app_uuid
        if not UtilClient.is_unset(request.form_code):
            query['formCode'] = request.form_code
        if not UtilClient.is_unset(request.form_instance_id):
            query['formInstanceId'] = request.form_instance_id
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
            dingtalkworkflow__1__0_models.QueryFormInstanceResponse(),
            self.do_roarequest('QueryFormInstance', 'workflow_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/workflow/forms/instances', 'json', req, runtime)
        )

    async def query_form_instance_with_options_async(
        self,
        request: dingtalkworkflow__1__0_models.QueryFormInstanceRequest,
        headers: dingtalkworkflow__1__0_models.QueryFormInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.QueryFormInstanceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_uuid):
            query['appUuid'] = request.app_uuid
        if not UtilClient.is_unset(request.form_code):
            query['formCode'] = request.form_code
        if not UtilClient.is_unset(request.form_instance_id):
            query['formInstanceId'] = request.form_instance_id
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
            dingtalkworkflow__1__0_models.QueryFormInstanceResponse(),
            await self.do_roarequest_async('QueryFormInstance', 'workflow_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/workflow/forms/instances', 'json', req, runtime)
        )

    def query_integrated_todo_task(
        self,
        request: dingtalkworkflow__1__0_models.QueryIntegratedTodoTaskRequest,
    ) -> dingtalkworkflow__1__0_models.QueryIntegratedTodoTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.QueryIntegratedTodoTaskHeaders()
        return self.query_integrated_todo_task_with_options(request, headers, runtime)

    async def query_integrated_todo_task_async(
        self,
        request: dingtalkworkflow__1__0_models.QueryIntegratedTodoTaskRequest,
    ) -> dingtalkworkflow__1__0_models.QueryIntegratedTodoTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.QueryIntegratedTodoTaskHeaders()
        return await self.query_integrated_todo_task_with_options_async(request, headers, runtime)

    def query_integrated_todo_task_with_options(
        self,
        request: dingtalkworkflow__1__0_models.QueryIntegratedTodoTaskRequest,
        headers: dingtalkworkflow__1__0_models.QueryIntegratedTodoTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.QueryIntegratedTodoTaskResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.create_before):
            query['createBefore'] = request.create_before
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
        return TeaCore.from_map(
            dingtalkworkflow__1__0_models.QueryIntegratedTodoTaskResponse(),
            self.do_roarequest('QueryIntegratedTodoTask', 'workflow_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/workflow/processCentres/todoTasks', 'json', req, runtime)
        )

    async def query_integrated_todo_task_with_options_async(
        self,
        request: dingtalkworkflow__1__0_models.QueryIntegratedTodoTaskRequest,
        headers: dingtalkworkflow__1__0_models.QueryIntegratedTodoTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.QueryIntegratedTodoTaskResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.create_before):
            query['createBefore'] = request.create_before
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
        return TeaCore.from_map(
            dingtalkworkflow__1__0_models.QueryIntegratedTodoTaskResponse(),
            await self.do_roarequest_async('QueryIntegratedTodoTask', 'workflow_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/workflow/processCentres/todoTasks', 'json', req, runtime)
        )

    def query_process_by_biz_category_id(
        self,
        request: dingtalkworkflow__1__0_models.QueryProcessByBizCategoryIdRequest,
    ) -> dingtalkworkflow__1__0_models.QueryProcessByBizCategoryIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.QueryProcessByBizCategoryIdHeaders()
        return self.query_process_by_biz_category_id_with_options(request, headers, runtime)

    async def query_process_by_biz_category_id_async(
        self,
        request: dingtalkworkflow__1__0_models.QueryProcessByBizCategoryIdRequest,
    ) -> dingtalkworkflow__1__0_models.QueryProcessByBizCategoryIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.QueryProcessByBizCategoryIdHeaders()
        return await self.query_process_by_biz_category_id_with_options_async(request, headers, runtime)

    def query_process_by_biz_category_id_with_options(
        self,
        request: dingtalkworkflow__1__0_models.QueryProcessByBizCategoryIdRequest,
        headers: dingtalkworkflow__1__0_models.QueryProcessByBizCategoryIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.QueryProcessByBizCategoryIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_type):
            query['bizType'] = request.biz_type
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
        return TeaCore.from_map(
            dingtalkworkflow__1__0_models.QueryProcessByBizCategoryIdResponse(),
            self.do_roarequest('QueryProcessByBizCategoryId', 'workflow_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/workflow/processes/categories/templates', 'json', req, runtime)
        )

    async def query_process_by_biz_category_id_with_options_async(
        self,
        request: dingtalkworkflow__1__0_models.QueryProcessByBizCategoryIdRequest,
        headers: dingtalkworkflow__1__0_models.QueryProcessByBizCategoryIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.QueryProcessByBizCategoryIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_type):
            query['bizType'] = request.biz_type
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
        return TeaCore.from_map(
            dingtalkworkflow__1__0_models.QueryProcessByBizCategoryIdResponse(),
            await self.do_roarequest_async('QueryProcessByBizCategoryId', 'workflow_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/workflow/processes/categories/templates', 'json', req, runtime)
        )

    def query_schema_by_process_code(
        self,
        request: dingtalkworkflow__1__0_models.QuerySchemaByProcessCodeRequest,
    ) -> dingtalkworkflow__1__0_models.QuerySchemaByProcessCodeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.QuerySchemaByProcessCodeHeaders()
        return self.query_schema_by_process_code_with_options(request, headers, runtime)

    async def query_schema_by_process_code_async(
        self,
        request: dingtalkworkflow__1__0_models.QuerySchemaByProcessCodeRequest,
    ) -> dingtalkworkflow__1__0_models.QuerySchemaByProcessCodeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.QuerySchemaByProcessCodeHeaders()
        return await self.query_schema_by_process_code_with_options_async(request, headers, runtime)

    def query_schema_by_process_code_with_options(
        self,
        request: dingtalkworkflow__1__0_models.QuerySchemaByProcessCodeRequest,
        headers: dingtalkworkflow__1__0_models.QuerySchemaByProcessCodeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.QuerySchemaByProcessCodeResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_uuid):
            query['appUuid'] = request.app_uuid
        if not UtilClient.is_unset(request.process_code):
            query['processCode'] = request.process_code
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
            dingtalkworkflow__1__0_models.QuerySchemaByProcessCodeResponse(),
            self.do_roarequest('QuerySchemaByProcessCode', 'workflow_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/workflow/forms/schemas/processCodes', 'json', req, runtime)
        )

    async def query_schema_by_process_code_with_options_async(
        self,
        request: dingtalkworkflow__1__0_models.QuerySchemaByProcessCodeRequest,
        headers: dingtalkworkflow__1__0_models.QuerySchemaByProcessCodeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.QuerySchemaByProcessCodeResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_uuid):
            query['appUuid'] = request.app_uuid
        if not UtilClient.is_unset(request.process_code):
            query['processCode'] = request.process_code
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
            dingtalkworkflow__1__0_models.QuerySchemaByProcessCodeResponse(),
            await self.do_roarequest_async('QuerySchemaByProcessCode', 'workflow_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/workflow/forms/schemas/processCodes', 'json', req, runtime)
        )

    def save_integrated_instance(
        self,
        request: dingtalkworkflow__1__0_models.SaveIntegratedInstanceRequest,
    ) -> dingtalkworkflow__1__0_models.SaveIntegratedInstanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.SaveIntegratedInstanceHeaders()
        return self.save_integrated_instance_with_options(request, headers, runtime)

    async def save_integrated_instance_async(
        self,
        request: dingtalkworkflow__1__0_models.SaveIntegratedInstanceRequest,
    ) -> dingtalkworkflow__1__0_models.SaveIntegratedInstanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.SaveIntegratedInstanceHeaders()
        return await self.save_integrated_instance_with_options_async(request, headers, runtime)

    def save_integrated_instance_with_options(
        self,
        request: dingtalkworkflow__1__0_models.SaveIntegratedInstanceRequest,
        headers: dingtalkworkflow__1__0_models.SaveIntegratedInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.SaveIntegratedInstanceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.form_component_value_list):
            body['formComponentValueList'] = request.form_component_value_list
        if not UtilClient.is_unset(request.notifiers):
            body['notifiers'] = request.notifiers
        if not UtilClient.is_unset(request.originator_user_id):
            body['originatorUserId'] = request.originator_user_id
        if not UtilClient.is_unset(request.process_code):
            body['processCode'] = request.process_code
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.url):
            body['url'] = request.url
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
            dingtalkworkflow__1__0_models.SaveIntegratedInstanceResponse(),
            self.do_roarequest('SaveIntegratedInstance', 'workflow_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/workflow/processCentres/instances', 'json', req, runtime)
        )

    async def save_integrated_instance_with_options_async(
        self,
        request: dingtalkworkflow__1__0_models.SaveIntegratedInstanceRequest,
        headers: dingtalkworkflow__1__0_models.SaveIntegratedInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.SaveIntegratedInstanceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.form_component_value_list):
            body['formComponentValueList'] = request.form_component_value_list
        if not UtilClient.is_unset(request.notifiers):
            body['notifiers'] = request.notifiers
        if not UtilClient.is_unset(request.originator_user_id):
            body['originatorUserId'] = request.originator_user_id
        if not UtilClient.is_unset(request.process_code):
            body['processCode'] = request.process_code
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.url):
            body['url'] = request.url
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
            dingtalkworkflow__1__0_models.SaveIntegratedInstanceResponse(),
            await self.do_roarequest_async('SaveIntegratedInstance', 'workflow_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/workflow/processCentres/instances', 'json', req, runtime)
        )

    def save_process(
        self,
        request: dingtalkworkflow__1__0_models.SaveProcessRequest,
    ) -> dingtalkworkflow__1__0_models.SaveProcessResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.SaveProcessHeaders()
        return self.save_process_with_options(request, headers, runtime)

    async def save_process_async(
        self,
        request: dingtalkworkflow__1__0_models.SaveProcessRequest,
    ) -> dingtalkworkflow__1__0_models.SaveProcessResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.SaveProcessHeaders()
        return await self.save_process_with_options_async(request, headers, runtime)

    def save_process_with_options(
        self,
        request: dingtalkworkflow__1__0_models.SaveProcessRequest,
        headers: dingtalkworkflow__1__0_models.SaveProcessHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.SaveProcessResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.form_components):
            body['formComponents'] = request.form_components
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.process_code):
            body['processCode'] = request.process_code
        if not UtilClient.is_unset(request.process_feature_config):
            body['processFeatureConfig'] = request.process_feature_config
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
            dingtalkworkflow__1__0_models.SaveProcessResponse(),
            self.do_roarequest('SaveProcess', 'workflow_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/workflow/processCentres/schemas', 'json', req, runtime)
        )

    async def save_process_with_options_async(
        self,
        request: dingtalkworkflow__1__0_models.SaveProcessRequest,
        headers: dingtalkworkflow__1__0_models.SaveProcessHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.SaveProcessResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.form_components):
            body['formComponents'] = request.form_components
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.process_code):
            body['processCode'] = request.process_code
        if not UtilClient.is_unset(request.process_feature_config):
            body['processFeatureConfig'] = request.process_feature_config
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
            dingtalkworkflow__1__0_models.SaveProcessResponse(),
            await self.do_roarequest_async('SaveProcess', 'workflow_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/workflow/processCentres/schemas', 'json', req, runtime)
        )

    def start_process_instance(
        self,
        request: dingtalkworkflow__1__0_models.StartProcessInstanceRequest,
    ) -> dingtalkworkflow__1__0_models.StartProcessInstanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.StartProcessInstanceHeaders()
        return self.start_process_instance_with_options(request, headers, runtime)

    async def start_process_instance_async(
        self,
        request: dingtalkworkflow__1__0_models.StartProcessInstanceRequest,
    ) -> dingtalkworkflow__1__0_models.StartProcessInstanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.StartProcessInstanceHeaders()
        return await self.start_process_instance_with_options_async(request, headers, runtime)

    def start_process_instance_with_options(
        self,
        request: dingtalkworkflow__1__0_models.StartProcessInstanceRequest,
        headers: dingtalkworkflow__1__0_models.StartProcessInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.StartProcessInstanceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.approvers):
            body['approvers'] = request.approvers
        if not UtilClient.is_unset(request.cc_list):
            body['ccList'] = request.cc_list
        if not UtilClient.is_unset(request.cc_position):
            body['ccPosition'] = request.cc_position
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.form_component_values):
            body['formComponentValues'] = request.form_component_values
        if not UtilClient.is_unset(request.microapp_agent_id):
            body['microappAgentId'] = request.microapp_agent_id
        if not UtilClient.is_unset(request.originator_user_id):
            body['originatorUserId'] = request.originator_user_id
        if not UtilClient.is_unset(request.process_code):
            body['processCode'] = request.process_code
        if not UtilClient.is_unset(request.target_select_actioners):
            body['targetSelectActioners'] = request.target_select_actioners
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
            dingtalkworkflow__1__0_models.StartProcessInstanceResponse(),
            self.do_roarequest('StartProcessInstance', 'workflow_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/workflow/processInstances', 'json', req, runtime)
        )

    async def start_process_instance_with_options_async(
        self,
        request: dingtalkworkflow__1__0_models.StartProcessInstanceRequest,
        headers: dingtalkworkflow__1__0_models.StartProcessInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.StartProcessInstanceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.approvers):
            body['approvers'] = request.approvers
        if not UtilClient.is_unset(request.cc_list):
            body['ccList'] = request.cc_list
        if not UtilClient.is_unset(request.cc_position):
            body['ccPosition'] = request.cc_position
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.form_component_values):
            body['formComponentValues'] = request.form_component_values
        if not UtilClient.is_unset(request.microapp_agent_id):
            body['microappAgentId'] = request.microapp_agent_id
        if not UtilClient.is_unset(request.originator_user_id):
            body['originatorUserId'] = request.originator_user_id
        if not UtilClient.is_unset(request.process_code):
            body['processCode'] = request.process_code
        if not UtilClient.is_unset(request.target_select_actioners):
            body['targetSelectActioners'] = request.target_select_actioners
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
            dingtalkworkflow__1__0_models.StartProcessInstanceResponse(),
            await self.do_roarequest_async('StartProcessInstance', 'workflow_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/workflow/processInstances', 'json', req, runtime)
        )

    def update_integrated_task(
        self,
        request: dingtalkworkflow__1__0_models.UpdateIntegratedTaskRequest,
    ) -> dingtalkworkflow__1__0_models.UpdateIntegratedTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.UpdateIntegratedTaskHeaders()
        return self.update_integrated_task_with_options(request, headers, runtime)

    async def update_integrated_task_async(
        self,
        request: dingtalkworkflow__1__0_models.UpdateIntegratedTaskRequest,
    ) -> dingtalkworkflow__1__0_models.UpdateIntegratedTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.UpdateIntegratedTaskHeaders()
        return await self.update_integrated_task_with_options_async(request, headers, runtime)

    def update_integrated_task_with_options(
        self,
        request: dingtalkworkflow__1__0_models.UpdateIntegratedTaskRequest,
        headers: dingtalkworkflow__1__0_models.UpdateIntegratedTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.UpdateIntegratedTaskResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.process_instance_id):
            body['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.tasks):
            body['tasks'] = request.tasks
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
            dingtalkworkflow__1__0_models.UpdateIntegratedTaskResponse(),
            self.do_roarequest('UpdateIntegratedTask', 'workflow_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/workflow/processCentres/tasks', 'json', req, runtime)
        )

    async def update_integrated_task_with_options_async(
        self,
        request: dingtalkworkflow__1__0_models.UpdateIntegratedTaskRequest,
        headers: dingtalkworkflow__1__0_models.UpdateIntegratedTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.UpdateIntegratedTaskResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.process_instance_id):
            body['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.tasks):
            body['tasks'] = request.tasks
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
            dingtalkworkflow__1__0_models.UpdateIntegratedTaskResponse(),
            await self.do_roarequest_async('UpdateIntegratedTask', 'workflow_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/workflow/processCentres/tasks', 'json', req, runtime)
        )

    def update_process_instance(
        self,
        request: dingtalkworkflow__1__0_models.UpdateProcessInstanceRequest,
    ) -> dingtalkworkflow__1__0_models.UpdateProcessInstanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.UpdateProcessInstanceHeaders()
        return self.update_process_instance_with_options(request, headers, runtime)

    async def update_process_instance_async(
        self,
        request: dingtalkworkflow__1__0_models.UpdateProcessInstanceRequest,
    ) -> dingtalkworkflow__1__0_models.UpdateProcessInstanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkworkflow__1__0_models.UpdateProcessInstanceHeaders()
        return await self.update_process_instance_with_options_async(request, headers, runtime)

    def update_process_instance_with_options(
        self,
        request: dingtalkworkflow__1__0_models.UpdateProcessInstanceRequest,
        headers: dingtalkworkflow__1__0_models.UpdateProcessInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.UpdateProcessInstanceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.process_instance_id):
            body['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.result):
            body['result'] = request.result
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
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
            dingtalkworkflow__1__0_models.UpdateProcessInstanceResponse(),
            self.do_roarequest('UpdateProcessInstance', 'workflow_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/workflow/processCentres/instances', 'json', req, runtime)
        )

    async def update_process_instance_with_options_async(
        self,
        request: dingtalkworkflow__1__0_models.UpdateProcessInstanceRequest,
        headers: dingtalkworkflow__1__0_models.UpdateProcessInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkworkflow__1__0_models.UpdateProcessInstanceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.process_instance_id):
            body['processInstanceId'] = request.process_instance_id
        if not UtilClient.is_unset(request.result):
            body['result'] = request.result
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
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
            dingtalkworkflow__1__0_models.UpdateProcessInstanceResponse(),
            await self.do_roarequest_async('UpdateProcessInstance', 'workflow_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/workflow/processCentres/instances', 'json', req, runtime)
        )
