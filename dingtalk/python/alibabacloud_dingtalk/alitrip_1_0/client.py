# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalkalitrip_1_0 import models as dingtalkalitrip__1__0_models
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

    def add_city_car_apply(
        self,
        request: dingtalkalitrip__1__0_models.AddCityCarApplyRequest,
    ) -> dingtalkalitrip__1__0_models.AddCityCarApplyResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkalitrip__1__0_models.AddCityCarApplyHeaders()
        return self.add_city_car_apply_with_options(request, headers, runtime)

    async def add_city_car_apply_async(
        self,
        request: dingtalkalitrip__1__0_models.AddCityCarApplyRequest,
    ) -> dingtalkalitrip__1__0_models.AddCityCarApplyResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkalitrip__1__0_models.AddCityCarApplyHeaders()
        return await self.add_city_car_apply_with_options_async(request, headers, runtime)

    def add_city_car_apply_with_options(
        self,
        request: dingtalkalitrip__1__0_models.AddCityCarApplyRequest,
        headers: dingtalkalitrip__1__0_models.AddCityCarApplyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkalitrip__1__0_models.AddCityCarApplyResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.cause):
            body['cause'] = request.cause
        if not UtilClient.is_unset(request.city):
            body['city'] = request.city
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.date):
            body['date'] = request.date
        if not UtilClient.is_unset(request.project_code):
            body['projectCode'] = request.project_code
        if not UtilClient.is_unset(request.project_name):
            body['projectName'] = request.project_name
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.third_part_apply_id):
            body['thirdPartApplyId'] = request.third_part_apply_id
        if not UtilClient.is_unset(request.third_part_cost_center_id):
            body['thirdPartCostCenterId'] = request.third_part_cost_center_id
        if not UtilClient.is_unset(request.third_part_invoice_id):
            body['thirdPartInvoiceId'] = request.third_part_invoice_id
        if not UtilClient.is_unset(request.times_total):
            body['timesTotal'] = request.times_total
        if not UtilClient.is_unset(request.times_type):
            body['timesType'] = request.times_type
        if not UtilClient.is_unset(request.times_used):
            body['timesUsed'] = request.times_used
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.finished_date):
            body['finishedDate'] = request.finished_date
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
            dingtalkalitrip__1__0_models.AddCityCarApplyResponse(),
            self.do_roarequest('AddCityCarApply', 'alitrip_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/alitrip/cityCarApprovals', 'json', req, runtime)
        )

    async def add_city_car_apply_with_options_async(
        self,
        request: dingtalkalitrip__1__0_models.AddCityCarApplyRequest,
        headers: dingtalkalitrip__1__0_models.AddCityCarApplyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkalitrip__1__0_models.AddCityCarApplyResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.cause):
            body['cause'] = request.cause
        if not UtilClient.is_unset(request.city):
            body['city'] = request.city
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.date):
            body['date'] = request.date
        if not UtilClient.is_unset(request.project_code):
            body['projectCode'] = request.project_code
        if not UtilClient.is_unset(request.project_name):
            body['projectName'] = request.project_name
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.third_part_apply_id):
            body['thirdPartApplyId'] = request.third_part_apply_id
        if not UtilClient.is_unset(request.third_part_cost_center_id):
            body['thirdPartCostCenterId'] = request.third_part_cost_center_id
        if not UtilClient.is_unset(request.third_part_invoice_id):
            body['thirdPartInvoiceId'] = request.third_part_invoice_id
        if not UtilClient.is_unset(request.times_total):
            body['timesTotal'] = request.times_total
        if not UtilClient.is_unset(request.times_type):
            body['timesType'] = request.times_type
        if not UtilClient.is_unset(request.times_used):
            body['timesUsed'] = request.times_used
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.finished_date):
            body['finishedDate'] = request.finished_date
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
            dingtalkalitrip__1__0_models.AddCityCarApplyResponse(),
            await self.do_roarequest_async('AddCityCarApply', 'alitrip_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/alitrip/cityCarApprovals', 'json', req, runtime)
        )

    def approve_city_car_apply(
        self,
        request: dingtalkalitrip__1__0_models.ApproveCityCarApplyRequest,
    ) -> dingtalkalitrip__1__0_models.ApproveCityCarApplyResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkalitrip__1__0_models.ApproveCityCarApplyHeaders()
        return self.approve_city_car_apply_with_options(request, headers, runtime)

    async def approve_city_car_apply_async(
        self,
        request: dingtalkalitrip__1__0_models.ApproveCityCarApplyRequest,
    ) -> dingtalkalitrip__1__0_models.ApproveCityCarApplyResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkalitrip__1__0_models.ApproveCityCarApplyHeaders()
        return await self.approve_city_car_apply_with_options_async(request, headers, runtime)

    def approve_city_car_apply_with_options(
        self,
        request: dingtalkalitrip__1__0_models.ApproveCityCarApplyRequest,
        headers: dingtalkalitrip__1__0_models.ApproveCityCarApplyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkalitrip__1__0_models.ApproveCityCarApplyResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.operate_time):
            body['operateTime'] = request.operate_time
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.third_part_apply_id):
            body['thirdPartApplyId'] = request.third_part_apply_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
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
            dingtalkalitrip__1__0_models.ApproveCityCarApplyResponse(),
            self.do_roarequest('ApproveCityCarApply', 'alitrip_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/alitrip/cityCarApprovals', 'json', req, runtime)
        )

    async def approve_city_car_apply_with_options_async(
        self,
        request: dingtalkalitrip__1__0_models.ApproveCityCarApplyRequest,
        headers: dingtalkalitrip__1__0_models.ApproveCityCarApplyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkalitrip__1__0_models.ApproveCityCarApplyResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.operate_time):
            body['operateTime'] = request.operate_time
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.third_part_apply_id):
            body['thirdPartApplyId'] = request.third_part_apply_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_corp_id):
            body['dingCorpId'] = request.ding_corp_id
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
            dingtalkalitrip__1__0_models.ApproveCityCarApplyResponse(),
            await self.do_roarequest_async('ApproveCityCarApply', 'alitrip_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/alitrip/cityCarApprovals', 'json', req, runtime)
        )

    def query_city_car_apply(
        self,
        request: dingtalkalitrip__1__0_models.QueryCityCarApplyRequest,
    ) -> dingtalkalitrip__1__0_models.QueryCityCarApplyResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkalitrip__1__0_models.QueryCityCarApplyHeaders()
        return self.query_city_car_apply_with_options(request, headers, runtime)

    async def query_city_car_apply_async(
        self,
        request: dingtalkalitrip__1__0_models.QueryCityCarApplyRequest,
    ) -> dingtalkalitrip__1__0_models.QueryCityCarApplyResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkalitrip__1__0_models.QueryCityCarApplyHeaders()
        return await self.query_city_car_apply_with_options_async(request, headers, runtime)

    def query_city_car_apply_with_options(
        self,
        request: dingtalkalitrip__1__0_models.QueryCityCarApplyRequest,
        headers: dingtalkalitrip__1__0_models.QueryCityCarApplyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkalitrip__1__0_models.QueryCityCarApplyResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.created_end_at):
            query['createdEndAt'] = request.created_end_at
        if not UtilClient.is_unset(request.created_start_at):
            query['createdStartAt'] = request.created_start_at
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.third_part_apply_id):
            query['thirdPartApplyId'] = request.third_part_apply_id
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
            dingtalkalitrip__1__0_models.QueryCityCarApplyResponse(),
            self.do_roarequest('QueryCityCarApply', 'alitrip_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/alitrip/cityCarApprovals', 'json', req, runtime)
        )

    async def query_city_car_apply_with_options_async(
        self,
        request: dingtalkalitrip__1__0_models.QueryCityCarApplyRequest,
        headers: dingtalkalitrip__1__0_models.QueryCityCarApplyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkalitrip__1__0_models.QueryCityCarApplyResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.created_end_at):
            query['createdEndAt'] = request.created_end_at
        if not UtilClient.is_unset(request.created_start_at):
            query['createdStartAt'] = request.created_start_at
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.third_part_apply_id):
            query['thirdPartApplyId'] = request.third_part_apply_id
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
            dingtalkalitrip__1__0_models.QueryCityCarApplyResponse(),
            await self.do_roarequest_async('QueryCityCarApply', 'alitrip_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/alitrip/cityCarApprovals', 'json', req, runtime)
        )
