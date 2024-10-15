# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.alitrip_1_0 import models as dingtalkalitrip__1__0_models
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

    def add_city_car_apply_with_options(
        self,
        request: dingtalkalitrip__1__0_models.AddCityCarApplyRequest,
        headers: dingtalkalitrip__1__0_models.AddCityCarApplyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkalitrip__1__0_models.AddCityCarApplyResponse:
        """
        @summary 同步第三方市内用车申请单
        
        @param request: AddCityCarApplyRequest
        @param headers: AddCityCarApplyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddCityCarApplyResponse
        """
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
        if not UtilClient.is_unset(request.finished_date):
            body['finishedDate'] = request.finished_date
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
            action='AddCityCarApply',
            version='alitrip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/alitrip/cityCarApprovals',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkalitrip__1__0_models.AddCityCarApplyResponse(),
            self.execute(params, req, runtime)
        )

    async def add_city_car_apply_with_options_async(
        self,
        request: dingtalkalitrip__1__0_models.AddCityCarApplyRequest,
        headers: dingtalkalitrip__1__0_models.AddCityCarApplyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkalitrip__1__0_models.AddCityCarApplyResponse:
        """
        @summary 同步第三方市内用车申请单
        
        @param request: AddCityCarApplyRequest
        @param headers: AddCityCarApplyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddCityCarApplyResponse
        """
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
        if not UtilClient.is_unset(request.finished_date):
            body['finishedDate'] = request.finished_date
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
            action='AddCityCarApply',
            version='alitrip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/alitrip/cityCarApprovals',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkalitrip__1__0_models.AddCityCarApplyResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_city_car_apply(
        self,
        request: dingtalkalitrip__1__0_models.AddCityCarApplyRequest,
    ) -> dingtalkalitrip__1__0_models.AddCityCarApplyResponse:
        """
        @summary 同步第三方市内用车申请单
        
        @param request: AddCityCarApplyRequest
        @return: AddCityCarApplyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkalitrip__1__0_models.AddCityCarApplyHeaders()
        return self.add_city_car_apply_with_options(request, headers, runtime)

    async def add_city_car_apply_async(
        self,
        request: dingtalkalitrip__1__0_models.AddCityCarApplyRequest,
    ) -> dingtalkalitrip__1__0_models.AddCityCarApplyResponse:
        """
        @summary 同步第三方市内用车申请单
        
        @param request: AddCityCarApplyRequest
        @return: AddCityCarApplyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkalitrip__1__0_models.AddCityCarApplyHeaders()
        return await self.add_city_car_apply_with_options_async(request, headers, runtime)

    def approve_city_car_apply_with_options(
        self,
        request: dingtalkalitrip__1__0_models.ApproveCityCarApplyRequest,
        headers: dingtalkalitrip__1__0_models.ApproveCityCarApplyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkalitrip__1__0_models.ApproveCityCarApplyResponse:
        """
        @summary 三方市内用车申请单审批
        
        @param request: ApproveCityCarApplyRequest
        @param headers: ApproveCityCarApplyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ApproveCityCarApplyResponse
        """
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
            action='ApproveCityCarApply',
            version='alitrip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/alitrip/cityCarApprovals',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkalitrip__1__0_models.ApproveCityCarApplyResponse(),
            self.execute(params, req, runtime)
        )

    async def approve_city_car_apply_with_options_async(
        self,
        request: dingtalkalitrip__1__0_models.ApproveCityCarApplyRequest,
        headers: dingtalkalitrip__1__0_models.ApproveCityCarApplyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkalitrip__1__0_models.ApproveCityCarApplyResponse:
        """
        @summary 三方市内用车申请单审批
        
        @param request: ApproveCityCarApplyRequest
        @param headers: ApproveCityCarApplyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ApproveCityCarApplyResponse
        """
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
            action='ApproveCityCarApply',
            version='alitrip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/alitrip/cityCarApprovals',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkalitrip__1__0_models.ApproveCityCarApplyResponse(),
            await self.execute_async(params, req, runtime)
        )

    def approve_city_car_apply(
        self,
        request: dingtalkalitrip__1__0_models.ApproveCityCarApplyRequest,
    ) -> dingtalkalitrip__1__0_models.ApproveCityCarApplyResponse:
        """
        @summary 三方市内用车申请单审批
        
        @param request: ApproveCityCarApplyRequest
        @return: ApproveCityCarApplyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkalitrip__1__0_models.ApproveCityCarApplyHeaders()
        return self.approve_city_car_apply_with_options(request, headers, runtime)

    async def approve_city_car_apply_async(
        self,
        request: dingtalkalitrip__1__0_models.ApproveCityCarApplyRequest,
    ) -> dingtalkalitrip__1__0_models.ApproveCityCarApplyResponse:
        """
        @summary 三方市内用车申请单审批
        
        @param request: ApproveCityCarApplyRequest
        @return: ApproveCityCarApplyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkalitrip__1__0_models.ApproveCityCarApplyHeaders()
        return await self.approve_city_car_apply_with_options_async(request, headers, runtime)

    def bill_settement_btrip_train_with_options(
        self,
        request: dingtalkalitrip__1__0_models.BillSettementBtripTrainRequest,
        headers: dingtalkalitrip__1__0_models.BillSettementBtripTrainHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkalitrip__1__0_models.BillSettementBtripTrainResponse:
        """
        @summary 商旅火车票结算记账查询接口
        
        @param request: BillSettementBtripTrainRequest
        @param headers: BillSettementBtripTrainHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BillSettementBtripTrainResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.category):
            query['category'] = request.category
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.period_end):
            query['periodEnd'] = request.period_end
        if not UtilClient.is_unset(request.period_start):
            query['periodStart'] = request.period_start
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
            action='BillSettementBtripTrain',
            version='alitrip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/alitrip/billSettlements/btripTrains',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkalitrip__1__0_models.BillSettementBtripTrainResponse(),
            self.execute(params, req, runtime)
        )

    async def bill_settement_btrip_train_with_options_async(
        self,
        request: dingtalkalitrip__1__0_models.BillSettementBtripTrainRequest,
        headers: dingtalkalitrip__1__0_models.BillSettementBtripTrainHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkalitrip__1__0_models.BillSettementBtripTrainResponse:
        """
        @summary 商旅火车票结算记账查询接口
        
        @param request: BillSettementBtripTrainRequest
        @param headers: BillSettementBtripTrainHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BillSettementBtripTrainResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.category):
            query['category'] = request.category
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.period_end):
            query['periodEnd'] = request.period_end
        if not UtilClient.is_unset(request.period_start):
            query['periodStart'] = request.period_start
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
            action='BillSettementBtripTrain',
            version='alitrip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/alitrip/billSettlements/btripTrains',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkalitrip__1__0_models.BillSettementBtripTrainResponse(),
            await self.execute_async(params, req, runtime)
        )

    def bill_settement_btrip_train(
        self,
        request: dingtalkalitrip__1__0_models.BillSettementBtripTrainRequest,
    ) -> dingtalkalitrip__1__0_models.BillSettementBtripTrainResponse:
        """
        @summary 商旅火车票结算记账查询接口
        
        @param request: BillSettementBtripTrainRequest
        @return: BillSettementBtripTrainResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkalitrip__1__0_models.BillSettementBtripTrainHeaders()
        return self.bill_settement_btrip_train_with_options(request, headers, runtime)

    async def bill_settement_btrip_train_async(
        self,
        request: dingtalkalitrip__1__0_models.BillSettementBtripTrainRequest,
    ) -> dingtalkalitrip__1__0_models.BillSettementBtripTrainResponse:
        """
        @summary 商旅火车票结算记账查询接口
        
        @param request: BillSettementBtripTrainRequest
        @return: BillSettementBtripTrainResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkalitrip__1__0_models.BillSettementBtripTrainHeaders()
        return await self.bill_settement_btrip_train_with_options_async(request, headers, runtime)

    def bill_settement_car_with_options(
        self,
        request: dingtalkalitrip__1__0_models.BillSettementCarRequest,
        headers: dingtalkalitrip__1__0_models.BillSettementCarHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkalitrip__1__0_models.BillSettementCarResponse:
        """
        @summary 用车结算记账查询接口
        
        @param request: BillSettementCarRequest
        @param headers: BillSettementCarHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BillSettementCarResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.category):
            query['category'] = request.category
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.period_end):
            query['periodEnd'] = request.period_end
        if not UtilClient.is_unset(request.period_start):
            query['periodStart'] = request.period_start
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
            action='BillSettementCar',
            version='alitrip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/alitrip/billSettlements/cars',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkalitrip__1__0_models.BillSettementCarResponse(),
            self.execute(params, req, runtime)
        )

    async def bill_settement_car_with_options_async(
        self,
        request: dingtalkalitrip__1__0_models.BillSettementCarRequest,
        headers: dingtalkalitrip__1__0_models.BillSettementCarHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkalitrip__1__0_models.BillSettementCarResponse:
        """
        @summary 用车结算记账查询接口
        
        @param request: BillSettementCarRequest
        @param headers: BillSettementCarHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BillSettementCarResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.category):
            query['category'] = request.category
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.period_end):
            query['periodEnd'] = request.period_end
        if not UtilClient.is_unset(request.period_start):
            query['periodStart'] = request.period_start
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
            action='BillSettementCar',
            version='alitrip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/alitrip/billSettlements/cars',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkalitrip__1__0_models.BillSettementCarResponse(),
            await self.execute_async(params, req, runtime)
        )

    def bill_settement_car(
        self,
        request: dingtalkalitrip__1__0_models.BillSettementCarRequest,
    ) -> dingtalkalitrip__1__0_models.BillSettementCarResponse:
        """
        @summary 用车结算记账查询接口
        
        @param request: BillSettementCarRequest
        @return: BillSettementCarResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkalitrip__1__0_models.BillSettementCarHeaders()
        return self.bill_settement_car_with_options(request, headers, runtime)

    async def bill_settement_car_async(
        self,
        request: dingtalkalitrip__1__0_models.BillSettementCarRequest,
    ) -> dingtalkalitrip__1__0_models.BillSettementCarResponse:
        """
        @summary 用车结算记账查询接口
        
        @param request: BillSettementCarRequest
        @return: BillSettementCarResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkalitrip__1__0_models.BillSettementCarHeaders()
        return await self.bill_settement_car_with_options_async(request, headers, runtime)

    def bill_settement_flight_with_options(
        self,
        request: dingtalkalitrip__1__0_models.BillSettementFlightRequest,
        headers: dingtalkalitrip__1__0_models.BillSettementFlightHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkalitrip__1__0_models.BillSettementFlightResponse:
        """
        @summary 机票结算记账查询接口
        
        @param request: BillSettementFlightRequest
        @param headers: BillSettementFlightHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BillSettementFlightResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.category):
            query['category'] = request.category
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.period_end):
            query['periodEnd'] = request.period_end
        if not UtilClient.is_unset(request.period_start):
            query['periodStart'] = request.period_start
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
            action='BillSettementFlight',
            version='alitrip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/alitrip/billSettlements/flights',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkalitrip__1__0_models.BillSettementFlightResponse(),
            self.execute(params, req, runtime)
        )

    async def bill_settement_flight_with_options_async(
        self,
        request: dingtalkalitrip__1__0_models.BillSettementFlightRequest,
        headers: dingtalkalitrip__1__0_models.BillSettementFlightHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkalitrip__1__0_models.BillSettementFlightResponse:
        """
        @summary 机票结算记账查询接口
        
        @param request: BillSettementFlightRequest
        @param headers: BillSettementFlightHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BillSettementFlightResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.category):
            query['category'] = request.category
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.period_end):
            query['periodEnd'] = request.period_end
        if not UtilClient.is_unset(request.period_start):
            query['periodStart'] = request.period_start
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
            action='BillSettementFlight',
            version='alitrip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/alitrip/billSettlements/flights',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkalitrip__1__0_models.BillSettementFlightResponse(),
            await self.execute_async(params, req, runtime)
        )

    def bill_settement_flight(
        self,
        request: dingtalkalitrip__1__0_models.BillSettementFlightRequest,
    ) -> dingtalkalitrip__1__0_models.BillSettementFlightResponse:
        """
        @summary 机票结算记账查询接口
        
        @param request: BillSettementFlightRequest
        @return: BillSettementFlightResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkalitrip__1__0_models.BillSettementFlightHeaders()
        return self.bill_settement_flight_with_options(request, headers, runtime)

    async def bill_settement_flight_async(
        self,
        request: dingtalkalitrip__1__0_models.BillSettementFlightRequest,
    ) -> dingtalkalitrip__1__0_models.BillSettementFlightResponse:
        """
        @summary 机票结算记账查询接口
        
        @param request: BillSettementFlightRequest
        @return: BillSettementFlightResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkalitrip__1__0_models.BillSettementFlightHeaders()
        return await self.bill_settement_flight_with_options_async(request, headers, runtime)

    def bill_settement_hotel_with_options(
        self,
        request: dingtalkalitrip__1__0_models.BillSettementHotelRequest,
        headers: dingtalkalitrip__1__0_models.BillSettementHotelHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkalitrip__1__0_models.BillSettementHotelResponse:
        """
        @summary 酒店结算记账查询接口
        
        @param request: BillSettementHotelRequest
        @param headers: BillSettementHotelHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BillSettementHotelResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.category):
            query['category'] = request.category
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.period_end):
            query['periodEnd'] = request.period_end
        if not UtilClient.is_unset(request.period_start):
            query['periodStart'] = request.period_start
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
            action='BillSettementHotel',
            version='alitrip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/alitrip/billSettlements/hotels',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkalitrip__1__0_models.BillSettementHotelResponse(),
            self.execute(params, req, runtime)
        )

    async def bill_settement_hotel_with_options_async(
        self,
        request: dingtalkalitrip__1__0_models.BillSettementHotelRequest,
        headers: dingtalkalitrip__1__0_models.BillSettementHotelHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkalitrip__1__0_models.BillSettementHotelResponse:
        """
        @summary 酒店结算记账查询接口
        
        @param request: BillSettementHotelRequest
        @param headers: BillSettementHotelHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BillSettementHotelResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.category):
            query['category'] = request.category
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.period_end):
            query['periodEnd'] = request.period_end
        if not UtilClient.is_unset(request.period_start):
            query['periodStart'] = request.period_start
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
            action='BillSettementHotel',
            version='alitrip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/alitrip/billSettlements/hotels',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkalitrip__1__0_models.BillSettementHotelResponse(),
            await self.execute_async(params, req, runtime)
        )

    def bill_settement_hotel(
        self,
        request: dingtalkalitrip__1__0_models.BillSettementHotelRequest,
    ) -> dingtalkalitrip__1__0_models.BillSettementHotelResponse:
        """
        @summary 酒店结算记账查询接口
        
        @param request: BillSettementHotelRequest
        @return: BillSettementHotelResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkalitrip__1__0_models.BillSettementHotelHeaders()
        return self.bill_settement_hotel_with_options(request, headers, runtime)

    async def bill_settement_hotel_async(
        self,
        request: dingtalkalitrip__1__0_models.BillSettementHotelRequest,
    ) -> dingtalkalitrip__1__0_models.BillSettementHotelResponse:
        """
        @summary 酒店结算记账查询接口
        
        @param request: BillSettementHotelRequest
        @return: BillSettementHotelResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkalitrip__1__0_models.BillSettementHotelHeaders()
        return await self.bill_settement_hotel_with_options_async(request, headers, runtime)

    def get_flight_exceed_apply_with_options(
        self,
        request: dingtalkalitrip__1__0_models.GetFlightExceedApplyRequest,
        headers: dingtalkalitrip__1__0_models.GetFlightExceedApplyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkalitrip__1__0_models.GetFlightExceedApplyResponse:
        """
        @summary 商旅机票第三方超标审批单搜索接口
        
        @param request: GetFlightExceedApplyRequest
        @param headers: GetFlightExceedApplyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFlightExceedApplyResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.apply_id):
            query['applyId'] = request.apply_id
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
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
            action='GetFlightExceedApply',
            version='alitrip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/alitrip/exceedapply/getFlight',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkalitrip__1__0_models.GetFlightExceedApplyResponse(),
            self.execute(params, req, runtime)
        )

    async def get_flight_exceed_apply_with_options_async(
        self,
        request: dingtalkalitrip__1__0_models.GetFlightExceedApplyRequest,
        headers: dingtalkalitrip__1__0_models.GetFlightExceedApplyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkalitrip__1__0_models.GetFlightExceedApplyResponse:
        """
        @summary 商旅机票第三方超标审批单搜索接口
        
        @param request: GetFlightExceedApplyRequest
        @param headers: GetFlightExceedApplyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFlightExceedApplyResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.apply_id):
            query['applyId'] = request.apply_id
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
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
            action='GetFlightExceedApply',
            version='alitrip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/alitrip/exceedapply/getFlight',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkalitrip__1__0_models.GetFlightExceedApplyResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_flight_exceed_apply(
        self,
        request: dingtalkalitrip__1__0_models.GetFlightExceedApplyRequest,
    ) -> dingtalkalitrip__1__0_models.GetFlightExceedApplyResponse:
        """
        @summary 商旅机票第三方超标审批单搜索接口
        
        @param request: GetFlightExceedApplyRequest
        @return: GetFlightExceedApplyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkalitrip__1__0_models.GetFlightExceedApplyHeaders()
        return self.get_flight_exceed_apply_with_options(request, headers, runtime)

    async def get_flight_exceed_apply_async(
        self,
        request: dingtalkalitrip__1__0_models.GetFlightExceedApplyRequest,
    ) -> dingtalkalitrip__1__0_models.GetFlightExceedApplyResponse:
        """
        @summary 商旅机票第三方超标审批单搜索接口
        
        @param request: GetFlightExceedApplyRequest
        @return: GetFlightExceedApplyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkalitrip__1__0_models.GetFlightExceedApplyHeaders()
        return await self.get_flight_exceed_apply_with_options_async(request, headers, runtime)

    def get_hotel_exceed_apply_with_options(
        self,
        request: dingtalkalitrip__1__0_models.GetHotelExceedApplyRequest,
        headers: dingtalkalitrip__1__0_models.GetHotelExceedApplyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkalitrip__1__0_models.GetHotelExceedApplyResponse:
        """
        @summary 搜索酒店超标审批单
        
        @param request: GetHotelExceedApplyRequest
        @param headers: GetHotelExceedApplyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetHotelExceedApplyResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.apply_id):
            query['applyId'] = request.apply_id
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
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
            action='GetHotelExceedApply',
            version='alitrip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/alitrip/exceedapply/getHotel',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkalitrip__1__0_models.GetHotelExceedApplyResponse(),
            self.execute(params, req, runtime)
        )

    async def get_hotel_exceed_apply_with_options_async(
        self,
        request: dingtalkalitrip__1__0_models.GetHotelExceedApplyRequest,
        headers: dingtalkalitrip__1__0_models.GetHotelExceedApplyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkalitrip__1__0_models.GetHotelExceedApplyResponse:
        """
        @summary 搜索酒店超标审批单
        
        @param request: GetHotelExceedApplyRequest
        @param headers: GetHotelExceedApplyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetHotelExceedApplyResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.apply_id):
            query['applyId'] = request.apply_id
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
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
            action='GetHotelExceedApply',
            version='alitrip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/alitrip/exceedapply/getHotel',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkalitrip__1__0_models.GetHotelExceedApplyResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_hotel_exceed_apply(
        self,
        request: dingtalkalitrip__1__0_models.GetHotelExceedApplyRequest,
    ) -> dingtalkalitrip__1__0_models.GetHotelExceedApplyResponse:
        """
        @summary 搜索酒店超标审批单
        
        @param request: GetHotelExceedApplyRequest
        @return: GetHotelExceedApplyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkalitrip__1__0_models.GetHotelExceedApplyHeaders()
        return self.get_hotel_exceed_apply_with_options(request, headers, runtime)

    async def get_hotel_exceed_apply_async(
        self,
        request: dingtalkalitrip__1__0_models.GetHotelExceedApplyRequest,
    ) -> dingtalkalitrip__1__0_models.GetHotelExceedApplyResponse:
        """
        @summary 搜索酒店超标审批单
        
        @param request: GetHotelExceedApplyRequest
        @return: GetHotelExceedApplyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkalitrip__1__0_models.GetHotelExceedApplyHeaders()
        return await self.get_hotel_exceed_apply_with_options_async(request, headers, runtime)

    def get_train_exceed_apply_with_options(
        self,
        request: dingtalkalitrip__1__0_models.GetTrainExceedApplyRequest,
        headers: dingtalkalitrip__1__0_models.GetTrainExceedApplyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkalitrip__1__0_models.GetTrainExceedApplyResponse:
        """
        @summary 商旅火车票第三方超标审批单搜索接口
        
        @param request: GetTrainExceedApplyRequest
        @param headers: GetTrainExceedApplyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTrainExceedApplyResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.apply_id):
            query['applyId'] = request.apply_id
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
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
            action='GetTrainExceedApply',
            version='alitrip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/alitrip/exceedapply/getTrain',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkalitrip__1__0_models.GetTrainExceedApplyResponse(),
            self.execute(params, req, runtime)
        )

    async def get_train_exceed_apply_with_options_async(
        self,
        request: dingtalkalitrip__1__0_models.GetTrainExceedApplyRequest,
        headers: dingtalkalitrip__1__0_models.GetTrainExceedApplyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkalitrip__1__0_models.GetTrainExceedApplyResponse:
        """
        @summary 商旅火车票第三方超标审批单搜索接口
        
        @param request: GetTrainExceedApplyRequest
        @param headers: GetTrainExceedApplyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTrainExceedApplyResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.apply_id):
            query['applyId'] = request.apply_id
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
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
            action='GetTrainExceedApply',
            version='alitrip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/alitrip/exceedapply/getTrain',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkalitrip__1__0_models.GetTrainExceedApplyResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_train_exceed_apply(
        self,
        request: dingtalkalitrip__1__0_models.GetTrainExceedApplyRequest,
    ) -> dingtalkalitrip__1__0_models.GetTrainExceedApplyResponse:
        """
        @summary 商旅火车票第三方超标审批单搜索接口
        
        @param request: GetTrainExceedApplyRequest
        @return: GetTrainExceedApplyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkalitrip__1__0_models.GetTrainExceedApplyHeaders()
        return self.get_train_exceed_apply_with_options(request, headers, runtime)

    async def get_train_exceed_apply_async(
        self,
        request: dingtalkalitrip__1__0_models.GetTrainExceedApplyRequest,
    ) -> dingtalkalitrip__1__0_models.GetTrainExceedApplyResponse:
        """
        @summary 商旅火车票第三方超标审批单搜索接口
        
        @param request: GetTrainExceedApplyRequest
        @return: GetTrainExceedApplyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkalitrip__1__0_models.GetTrainExceedApplyHeaders()
        return await self.get_train_exceed_apply_with_options_async(request, headers, runtime)

    def query_city_car_apply_with_options(
        self,
        request: dingtalkalitrip__1__0_models.QueryCityCarApplyRequest,
        headers: dingtalkalitrip__1__0_models.QueryCityCarApplyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkalitrip__1__0_models.QueryCityCarApplyResponse:
        """
        @summary 三方市内用车申请单查询
        
        @param request: QueryCityCarApplyRequest
        @param headers: QueryCityCarApplyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCityCarApplyResponse
        """
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryCityCarApply',
            version='alitrip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/alitrip/cityCarApprovals',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkalitrip__1__0_models.QueryCityCarApplyResponse(),
            self.execute(params, req, runtime)
        )

    async def query_city_car_apply_with_options_async(
        self,
        request: dingtalkalitrip__1__0_models.QueryCityCarApplyRequest,
        headers: dingtalkalitrip__1__0_models.QueryCityCarApplyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkalitrip__1__0_models.QueryCityCarApplyResponse:
        """
        @summary 三方市内用车申请单查询
        
        @param request: QueryCityCarApplyRequest
        @param headers: QueryCityCarApplyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCityCarApplyResponse
        """
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
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryCityCarApply',
            version='alitrip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/alitrip/cityCarApprovals',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkalitrip__1__0_models.QueryCityCarApplyResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_city_car_apply(
        self,
        request: dingtalkalitrip__1__0_models.QueryCityCarApplyRequest,
    ) -> dingtalkalitrip__1__0_models.QueryCityCarApplyResponse:
        """
        @summary 三方市内用车申请单查询
        
        @param request: QueryCityCarApplyRequest
        @return: QueryCityCarApplyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkalitrip__1__0_models.QueryCityCarApplyHeaders()
        return self.query_city_car_apply_with_options(request, headers, runtime)

    async def query_city_car_apply_async(
        self,
        request: dingtalkalitrip__1__0_models.QueryCityCarApplyRequest,
    ) -> dingtalkalitrip__1__0_models.QueryCityCarApplyResponse:
        """
        @summary 三方市内用车申请单查询
        
        @param request: QueryCityCarApplyRequest
        @return: QueryCityCarApplyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkalitrip__1__0_models.QueryCityCarApplyHeaders()
        return await self.query_city_car_apply_with_options_async(request, headers, runtime)

    def query_union_order_with_options(
        self,
        request: dingtalkalitrip__1__0_models.QueryUnionOrderRequest,
        headers: dingtalkalitrip__1__0_models.QueryUnionOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkalitrip__1__0_models.QueryUnionOrderResponse:
        """
        @summary 申请单关联单号查询相关订单信息
        
        @param request: QueryUnionOrderRequest
        @param headers: QueryUnionOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUnionOrderResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.third_part_apply_id):
            query['thirdPartApplyId'] = request.third_part_apply_id
        if not UtilClient.is_unset(request.union_no):
            query['unionNo'] = request.union_no
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
            action='QueryUnionOrder',
            version='alitrip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/alitrip/unionOrders',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkalitrip__1__0_models.QueryUnionOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def query_union_order_with_options_async(
        self,
        request: dingtalkalitrip__1__0_models.QueryUnionOrderRequest,
        headers: dingtalkalitrip__1__0_models.QueryUnionOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkalitrip__1__0_models.QueryUnionOrderResponse:
        """
        @summary 申请单关联单号查询相关订单信息
        
        @param request: QueryUnionOrderRequest
        @param headers: QueryUnionOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUnionOrderResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.third_part_apply_id):
            query['thirdPartApplyId'] = request.third_part_apply_id
        if not UtilClient.is_unset(request.union_no):
            query['unionNo'] = request.union_no
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
            action='QueryUnionOrder',
            version='alitrip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/alitrip/unionOrders',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkalitrip__1__0_models.QueryUnionOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_union_order(
        self,
        request: dingtalkalitrip__1__0_models.QueryUnionOrderRequest,
    ) -> dingtalkalitrip__1__0_models.QueryUnionOrderResponse:
        """
        @summary 申请单关联单号查询相关订单信息
        
        @param request: QueryUnionOrderRequest
        @return: QueryUnionOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkalitrip__1__0_models.QueryUnionOrderHeaders()
        return self.query_union_order_with_options(request, headers, runtime)

    async def query_union_order_async(
        self,
        request: dingtalkalitrip__1__0_models.QueryUnionOrderRequest,
    ) -> dingtalkalitrip__1__0_models.QueryUnionOrderResponse:
        """
        @summary 申请单关联单号查询相关订单信息
        
        @param request: QueryUnionOrderRequest
        @return: QueryUnionOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkalitrip__1__0_models.QueryUnionOrderHeaders()
        return await self.query_union_order_with_options_async(request, headers, runtime)

    def sync_exceed_apply_with_options(
        self,
        request: dingtalkalitrip__1__0_models.SyncExceedApplyRequest,
        headers: dingtalkalitrip__1__0_models.SyncExceedApplyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkalitrip__1__0_models.SyncExceedApplyResponse:
        """
        @summary 同步超标审批结果
        
        @param request: SyncExceedApplyRequest
        @param headers: SyncExceedApplyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncExceedApplyResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.apply_id):
            query['applyId'] = request.apply_id
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.remark):
            query['remark'] = request.remark
        if not UtilClient.is_unset(request.status):
            query['status'] = request.status
        if not UtilClient.is_unset(request.thirdparty_flow_id):
            query['thirdpartyFlowId'] = request.thirdparty_flow_id
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
            action='SyncExceedApply',
            version='alitrip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/alitrip/exceedapply/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkalitrip__1__0_models.SyncExceedApplyResponse(),
            self.execute(params, req, runtime)
        )

    async def sync_exceed_apply_with_options_async(
        self,
        request: dingtalkalitrip__1__0_models.SyncExceedApplyRequest,
        headers: dingtalkalitrip__1__0_models.SyncExceedApplyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkalitrip__1__0_models.SyncExceedApplyResponse:
        """
        @summary 同步超标审批结果
        
        @param request: SyncExceedApplyRequest
        @param headers: SyncExceedApplyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncExceedApplyResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.apply_id):
            query['applyId'] = request.apply_id
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.remark):
            query['remark'] = request.remark
        if not UtilClient.is_unset(request.status):
            query['status'] = request.status
        if not UtilClient.is_unset(request.thirdparty_flow_id):
            query['thirdpartyFlowId'] = request.thirdparty_flow_id
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
            action='SyncExceedApply',
            version='alitrip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/alitrip/exceedapply/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkalitrip__1__0_models.SyncExceedApplyResponse(),
            await self.execute_async(params, req, runtime)
        )

    def sync_exceed_apply(
        self,
        request: dingtalkalitrip__1__0_models.SyncExceedApplyRequest,
    ) -> dingtalkalitrip__1__0_models.SyncExceedApplyResponse:
        """
        @summary 同步超标审批结果
        
        @param request: SyncExceedApplyRequest
        @return: SyncExceedApplyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkalitrip__1__0_models.SyncExceedApplyHeaders()
        return self.sync_exceed_apply_with_options(request, headers, runtime)

    async def sync_exceed_apply_async(
        self,
        request: dingtalkalitrip__1__0_models.SyncExceedApplyRequest,
    ) -> dingtalkalitrip__1__0_models.SyncExceedApplyResponse:
        """
        @summary 同步超标审批结果
        
        @param request: SyncExceedApplyRequest
        @return: SyncExceedApplyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkalitrip__1__0_models.SyncExceedApplyHeaders()
        return await self.sync_exceed_apply_with_options_async(request, headers, runtime)
