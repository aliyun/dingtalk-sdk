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
        if not UtilClient.is_unset(request.form_instance_id):
            query['formInstanceId'] = request.form_instance_id
        if not UtilClient.is_unset(request.form_code):
            query['formCode'] = request.form_code
        if not UtilClient.is_unset(request.app_uuid):
            query['appUuid'] = request.app_uuid
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
        if not UtilClient.is_unset(request.form_instance_id):
            query['formInstanceId'] = request.form_instance_id
        if not UtilClient.is_unset(request.form_code):
            query['formCode'] = request.form_code
        if not UtilClient.is_unset(request.app_uuid):
            query['appUuid'] = request.app_uuid
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
            dingtalkworkflow__1__0_models.QueryFormInstanceResponse(),
            await self.do_roarequest_async('QueryFormInstance', 'workflow_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/workflow/forms/instances', 'json', req, runtime)
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
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.request_id):
            body['RequestId'] = request.request_id
        if not UtilClient.is_unset(request.process_code):
            body['processCode'] = request.process_code
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.form_component_values):
            body['formComponentValues'] = request.form_component_values
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
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.request_id):
            body['RequestId'] = request.request_id
        if not UtilClient.is_unset(request.process_code):
            body['processCode'] = request.process_code
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.form_component_values):
            body['formComponentValues'] = request.form_component_values
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
            dingtalkworkflow__1__0_models.ProcessForecastResponse(),
            await self.do_roarequest_async('ProcessForecast', 'workflow_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/workflow/processes/forecast', 'json', req, runtime)
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
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.start_time_in_mills):
            query['startTimeInMills'] = request.start_time_in_mills
        if not UtilClient.is_unset(request.end_time_in_mills):
            query['endTimeInMills'] = request.end_time_in_mills
        if not UtilClient.is_unset(request.process_code):
            query['processCode'] = request.process_code
        if not UtilClient.is_unset(request.app_uuid):
            query['appUuid'] = request.app_uuid
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
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.start_time_in_mills):
            query['startTimeInMills'] = request.start_time_in_mills
        if not UtilClient.is_unset(request.end_time_in_mills):
            query['endTimeInMills'] = request.end_time_in_mills
        if not UtilClient.is_unset(request.process_code):
            query['processCode'] = request.process_code
        if not UtilClient.is_unset(request.app_uuid):
            query['appUuid'] = request.app_uuid
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
            dingtalkworkflow__1__0_models.QueryAllProcessInstancesResponse(),
            await self.do_roarequest_async('QueryAllProcessInstances', 'workflow_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/workflow/processes/pages/instances', 'json', req, runtime)
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
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.app_uuid):
            query['appUuid'] = request.app_uuid
        if not UtilClient.is_unset(request.form_code):
            query['formCode'] = request.form_code
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
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.app_uuid):
            query['appUuid'] = request.app_uuid
        if not UtilClient.is_unset(request.form_code):
            query['formCode'] = request.form_code
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
            dingtalkworkflow__1__0_models.QueryAllFormInstancesResponse(),
            await self.do_roarequest_async('QueryAllFormInstances', 'workflow_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/workflow/forms/pages/instances', 'json', req, runtime)
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkworkflow__1__0_models.QueryFormByBizTypeResponse(),
            await self.do_roarequest_async('QueryFormByBizType', 'workflow_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/workflow/forms/forminfos/query', 'json', req, runtime)
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
        if not UtilClient.is_unset(request.originator_user_id):
            body['originatorUserId'] = request.originator_user_id
        if not UtilClient.is_unset(request.process_code):
            body['processCode'] = request.process_code
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.microapp_agent_id):
            body['microappAgentId'] = request.microapp_agent_id
        if not UtilClient.is_unset(request.approvers):
            body['approvers'] = request.approvers
        if not UtilClient.is_unset(request.cc_list):
            body['ccList'] = request.cc_list
        if not UtilClient.is_unset(request.cc_position):
            body['ccPosition'] = request.cc_position
        if not UtilClient.is_unset(request.target_select_actioners):
            body['targetSelectActioners'] = request.target_select_actioners
        if not UtilClient.is_unset(request.form_component_values):
            body['formComponentValues'] = request.form_component_values
        if not UtilClient.is_unset(request.request_id):
            body['RequestId'] = request.request_id
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
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
        if not UtilClient.is_unset(request.originator_user_id):
            body['originatorUserId'] = request.originator_user_id
        if not UtilClient.is_unset(request.process_code):
            body['processCode'] = request.process_code
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.microapp_agent_id):
            body['microappAgentId'] = request.microapp_agent_id
        if not UtilClient.is_unset(request.approvers):
            body['approvers'] = request.approvers
        if not UtilClient.is_unset(request.cc_list):
            body['ccList'] = request.cc_list
        if not UtilClient.is_unset(request.cc_position):
            body['ccPosition'] = request.cc_position
        if not UtilClient.is_unset(request.target_select_actioners):
            body['targetSelectActioners'] = request.target_select_actioners
        if not UtilClient.is_unset(request.form_component_values):
            body['formComponentValues'] = request.form_component_values
        if not UtilClient.is_unset(request.request_id):
            body['RequestId'] = request.request_id
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
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
            dingtalkworkflow__1__0_models.StartProcessInstanceResponse(),
            await self.do_roarequest_async('StartProcessInstance', 'workflow_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/workflow/processInstances', 'json', req, runtime)
        )
