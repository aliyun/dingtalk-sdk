# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.report_1_0 import models as dingtalkreport__1__0_models
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

    def create_templates_with_options(
        self,
        request: dingtalkreport__1__0_models.CreateTemplatesRequest,
        headers: dingtalkreport__1__0_models.CreateTemplatesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkreport__1__0_models.CreateTemplatesResponse:
        """
        @summary 创建模板
        
        @param request: CreateTemplatesRequest
        @param headers: CreateTemplatesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTemplatesResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.allow_add_receivers):
            body['allowAddReceivers'] = request.allow_add_receivers
        if not UtilClient.is_unset(request.allow_edit):
            body['allowEdit'] = request.allow_edit
        if not UtilClient.is_unset(request.allow_get_location):
            body['allowGetLocation'] = request.allow_get_location
        if not UtilClient.is_unset(request.auth_dept_ids):
            body['authDeptIds'] = request.auth_dept_ids
        if not UtilClient.is_unset(request.auth_user_ids):
            body['authUserIds'] = request.auth_user_ids
        if not UtilClient.is_unset(request.creator):
            body['creator'] = request.creator
        if not UtilClient.is_unset(request.default_received_cids):
            body['defaultReceivedCids'] = request.default_received_cids
        if not UtilClient.is_unset(request.default_received_master_levels):
            body['defaultReceivedMasterLevels'] = request.default_received_master_levels
        if not UtilClient.is_unset(request.default_receivers):
            body['defaultReceivers'] = request.default_receivers
        if not UtilClient.is_unset(request.fields):
            body['fields'] = request.fields
        if not UtilClient.is_unset(request.logo):
            body['logo'] = request.logo
        if not UtilClient.is_unset(request.max_word_count):
            body['maxWordCount'] = request.max_word_count
        if not UtilClient.is_unset(request.min_word_count):
            body['minWordCount'] = request.min_word_count
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.template_managers):
            body['templateManagers'] = request.template_managers
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
            action='CreateTemplates',
            version='report_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/report/templates',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkreport__1__0_models.CreateTemplatesResponse(),
            self.execute(params, req, runtime)
        )

    async def create_templates_with_options_async(
        self,
        request: dingtalkreport__1__0_models.CreateTemplatesRequest,
        headers: dingtalkreport__1__0_models.CreateTemplatesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkreport__1__0_models.CreateTemplatesResponse:
        """
        @summary 创建模板
        
        @param request: CreateTemplatesRequest
        @param headers: CreateTemplatesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTemplatesResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.allow_add_receivers):
            body['allowAddReceivers'] = request.allow_add_receivers
        if not UtilClient.is_unset(request.allow_edit):
            body['allowEdit'] = request.allow_edit
        if not UtilClient.is_unset(request.allow_get_location):
            body['allowGetLocation'] = request.allow_get_location
        if not UtilClient.is_unset(request.auth_dept_ids):
            body['authDeptIds'] = request.auth_dept_ids
        if not UtilClient.is_unset(request.auth_user_ids):
            body['authUserIds'] = request.auth_user_ids
        if not UtilClient.is_unset(request.creator):
            body['creator'] = request.creator
        if not UtilClient.is_unset(request.default_received_cids):
            body['defaultReceivedCids'] = request.default_received_cids
        if not UtilClient.is_unset(request.default_received_master_levels):
            body['defaultReceivedMasterLevels'] = request.default_received_master_levels
        if not UtilClient.is_unset(request.default_receivers):
            body['defaultReceivers'] = request.default_receivers
        if not UtilClient.is_unset(request.fields):
            body['fields'] = request.fields
        if not UtilClient.is_unset(request.logo):
            body['logo'] = request.logo
        if not UtilClient.is_unset(request.max_word_count):
            body['maxWordCount'] = request.max_word_count
        if not UtilClient.is_unset(request.min_word_count):
            body['minWordCount'] = request.min_word_count
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.template_managers):
            body['templateManagers'] = request.template_managers
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
            action='CreateTemplates',
            version='report_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/report/templates',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkreport__1__0_models.CreateTemplatesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_templates(
        self,
        request: dingtalkreport__1__0_models.CreateTemplatesRequest,
    ) -> dingtalkreport__1__0_models.CreateTemplatesResponse:
        """
        @summary 创建模板
        
        @param request: CreateTemplatesRequest
        @return: CreateTemplatesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkreport__1__0_models.CreateTemplatesHeaders()
        return self.create_templates_with_options(request, headers, runtime)

    async def create_templates_async(
        self,
        request: dingtalkreport__1__0_models.CreateTemplatesRequest,
    ) -> dingtalkreport__1__0_models.CreateTemplatesResponse:
        """
        @summary 创建模板
        
        @param request: CreateTemplatesRequest
        @return: CreateTemplatesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkreport__1__0_models.CreateTemplatesHeaders()
        return await self.create_templates_with_options_async(request, headers, runtime)

    def get_send_and_receive_report_list_with_options(
        self,
        request: dingtalkreport__1__0_models.GetSendAndReceiveReportListRequest,
        headers: dingtalkreport__1__0_models.GetSendAndReceiveReportListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkreport__1__0_models.GetSendAndReceiveReportListResponse:
        """
        @summary 查询员工提交和收到的日志列表
        
        @param request: GetSendAndReceiveReportListRequest
        @param headers: GetSendAndReceiveReportListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSendAndReceiveReportListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operation_user_id):
            query['operationUserId'] = request.operation_user_id
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
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
            action='GetSendAndReceiveReportList',
            version='report_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/report/users/sendAndReceiveLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkreport__1__0_models.GetSendAndReceiveReportListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_send_and_receive_report_list_with_options_async(
        self,
        request: dingtalkreport__1__0_models.GetSendAndReceiveReportListRequest,
        headers: dingtalkreport__1__0_models.GetSendAndReceiveReportListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkreport__1__0_models.GetSendAndReceiveReportListResponse:
        """
        @summary 查询员工提交和收到的日志列表
        
        @param request: GetSendAndReceiveReportListRequest
        @param headers: GetSendAndReceiveReportListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSendAndReceiveReportListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operation_user_id):
            query['operationUserId'] = request.operation_user_id
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
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
            action='GetSendAndReceiveReportList',
            version='report_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/report/users/sendAndReceiveLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkreport__1__0_models.GetSendAndReceiveReportListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_send_and_receive_report_list(
        self,
        request: dingtalkreport__1__0_models.GetSendAndReceiveReportListRequest,
    ) -> dingtalkreport__1__0_models.GetSendAndReceiveReportListResponse:
        """
        @summary 查询员工提交和收到的日志列表
        
        @param request: GetSendAndReceiveReportListRequest
        @return: GetSendAndReceiveReportListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkreport__1__0_models.GetSendAndReceiveReportListHeaders()
        return self.get_send_and_receive_report_list_with_options(request, headers, runtime)

    async def get_send_and_receive_report_list_async(
        self,
        request: dingtalkreport__1__0_models.GetSendAndReceiveReportListRequest,
    ) -> dingtalkreport__1__0_models.GetSendAndReceiveReportListResponse:
        """
        @summary 查询员工提交和收到的日志列表
        
        @param request: GetSendAndReceiveReportListRequest
        @return: GetSendAndReceiveReportListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkreport__1__0_models.GetSendAndReceiveReportListHeaders()
        return await self.get_send_and_receive_report_list_with_options_async(request, headers, runtime)

    def get_submit_statistics_with_options(
        self,
        request: dingtalkreport__1__0_models.GetSubmitStatisticsRequest,
        headers: dingtalkreport__1__0_models.GetSubmitStatisticsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkreport__1__0_models.GetSubmitStatisticsResponse:
        """
        @summary 获取指定周期的提交统计结果
        
        @param request: GetSubmitStatisticsRequest
        @param headers: GetSubmitStatisticsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSubmitStatisticsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.operation_user_id):
            query['operationUserId'] = request.operation_user_id
        if not UtilClient.is_unset(request.remind_id):
            query['remindId'] = request.remind_id
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        if not UtilClient.is_unset(request.template_id):
            query['templateId'] = request.template_id
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
            action='GetSubmitStatistics',
            version='report_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/report/submitStatisticalResults',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkreport__1__0_models.GetSubmitStatisticsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_submit_statistics_with_options_async(
        self,
        request: dingtalkreport__1__0_models.GetSubmitStatisticsRequest,
        headers: dingtalkreport__1__0_models.GetSubmitStatisticsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkreport__1__0_models.GetSubmitStatisticsResponse:
        """
        @summary 获取指定周期的提交统计结果
        
        @param request: GetSubmitStatisticsRequest
        @param headers: GetSubmitStatisticsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSubmitStatisticsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.operation_user_id):
            query['operationUserId'] = request.operation_user_id
        if not UtilClient.is_unset(request.remind_id):
            query['remindId'] = request.remind_id
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        if not UtilClient.is_unset(request.template_id):
            query['templateId'] = request.template_id
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
            action='GetSubmitStatistics',
            version='report_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/report/submitStatisticalResults',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkreport__1__0_models.GetSubmitStatisticsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_submit_statistics(
        self,
        request: dingtalkreport__1__0_models.GetSubmitStatisticsRequest,
    ) -> dingtalkreport__1__0_models.GetSubmitStatisticsResponse:
        """
        @summary 获取指定周期的提交统计结果
        
        @param request: GetSubmitStatisticsRequest
        @return: GetSubmitStatisticsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkreport__1__0_models.GetSubmitStatisticsHeaders()
        return self.get_submit_statistics_with_options(request, headers, runtime)

    async def get_submit_statistics_async(
        self,
        request: dingtalkreport__1__0_models.GetSubmitStatisticsRequest,
    ) -> dingtalkreport__1__0_models.GetSubmitStatisticsResponse:
        """
        @summary 获取指定周期的提交统计结果
        
        @param request: GetSubmitStatisticsRequest
        @return: GetSubmitStatisticsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkreport__1__0_models.GetSubmitStatisticsHeaders()
        return await self.get_submit_statistics_with_options_async(request, headers, runtime)

    def query_remind_results_with_options(
        self,
        request: dingtalkreport__1__0_models.QueryRemindResultsRequest,
        headers: dingtalkreport__1__0_models.QueryRemindResultsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkreport__1__0_models.QueryRemindResultsResponse:
        """
        @summary 获取创建的统计规则信息
        
        @param request: QueryRemindResultsRequest
        @param headers: QueryRemindResultsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryRemindResultsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operation_user_id):
            query['operationUserId'] = request.operation_user_id
        if not UtilClient.is_unset(request.template_id):
            query['templateId'] = request.template_id
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
            action='QueryRemindResults',
            version='report_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/report/statisticalRules/results',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkreport__1__0_models.QueryRemindResultsResponse(),
            self.execute(params, req, runtime)
        )

    async def query_remind_results_with_options_async(
        self,
        request: dingtalkreport__1__0_models.QueryRemindResultsRequest,
        headers: dingtalkreport__1__0_models.QueryRemindResultsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkreport__1__0_models.QueryRemindResultsResponse:
        """
        @summary 获取创建的统计规则信息
        
        @param request: QueryRemindResultsRequest
        @param headers: QueryRemindResultsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryRemindResultsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operation_user_id):
            query['operationUserId'] = request.operation_user_id
        if not UtilClient.is_unset(request.template_id):
            query['templateId'] = request.template_id
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
            action='QueryRemindResults',
            version='report_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/report/statisticalRules/results',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkreport__1__0_models.QueryRemindResultsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_remind_results(
        self,
        request: dingtalkreport__1__0_models.QueryRemindResultsRequest,
    ) -> dingtalkreport__1__0_models.QueryRemindResultsResponse:
        """
        @summary 获取创建的统计规则信息
        
        @param request: QueryRemindResultsRequest
        @return: QueryRemindResultsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkreport__1__0_models.QueryRemindResultsHeaders()
        return self.query_remind_results_with_options(request, headers, runtime)

    async def query_remind_results_async(
        self,
        request: dingtalkreport__1__0_models.QueryRemindResultsRequest,
    ) -> dingtalkreport__1__0_models.QueryRemindResultsResponse:
        """
        @summary 获取创建的统计规则信息
        
        @param request: QueryRemindResultsRequest
        @return: QueryRemindResultsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkreport__1__0_models.QueryRemindResultsHeaders()
        return await self.query_remind_results_with_options_async(request, headers, runtime)

    def query_report_detail_with_options(
        self,
        request: dingtalkreport__1__0_models.QueryReportDetailRequest,
        headers: dingtalkreport__1__0_models.QueryReportDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkreport__1__0_models.QueryReportDetailResponse:
        """
        @summary 获取日志详情
        
        @param request: QueryReportDetailRequest
        @param headers: QueryReportDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryReportDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.format):
            query['format'] = request.format
        if not UtilClient.is_unset(request.report_id):
            query['reportId'] = request.report_id
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
            action='QueryReportDetail',
            version='report_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/report/details',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkreport__1__0_models.QueryReportDetailResponse(),
            self.execute(params, req, runtime)
        )

    async def query_report_detail_with_options_async(
        self,
        request: dingtalkreport__1__0_models.QueryReportDetailRequest,
        headers: dingtalkreport__1__0_models.QueryReportDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkreport__1__0_models.QueryReportDetailResponse:
        """
        @summary 获取日志详情
        
        @param request: QueryReportDetailRequest
        @param headers: QueryReportDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryReportDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.format):
            query['format'] = request.format
        if not UtilClient.is_unset(request.report_id):
            query['reportId'] = request.report_id
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
            action='QueryReportDetail',
            version='report_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/report/details',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkreport__1__0_models.QueryReportDetailResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_report_detail(
        self,
        request: dingtalkreport__1__0_models.QueryReportDetailRequest,
    ) -> dingtalkreport__1__0_models.QueryReportDetailResponse:
        """
        @summary 获取日志详情
        
        @param request: QueryReportDetailRequest
        @return: QueryReportDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkreport__1__0_models.QueryReportDetailHeaders()
        return self.query_report_detail_with_options(request, headers, runtime)

    async def query_report_detail_async(
        self,
        request: dingtalkreport__1__0_models.QueryReportDetailRequest,
    ) -> dingtalkreport__1__0_models.QueryReportDetailResponse:
        """
        @summary 获取日志详情
        
        @param request: QueryReportDetailRequest
        @return: QueryReportDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkreport__1__0_models.QueryReportDetailHeaders()
        return await self.query_report_detail_with_options_async(request, headers, runtime)
