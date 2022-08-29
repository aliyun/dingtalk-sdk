# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.datacenter_1_0 import models as dingtalkdatacenter__1__0_models
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

    def get_abnormal_operation(
        self,
        request: dingtalkdatacenter__1__0_models.GetAbnormalOperationRequest,
    ) -> dingtalkdatacenter__1__0_models.GetAbnormalOperationResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetAbnormalOperationHeaders()
        return self.get_abnormal_operation_with_options(request, headers, runtime)

    async def get_abnormal_operation_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetAbnormalOperationRequest,
    ) -> dingtalkdatacenter__1__0_models.GetAbnormalOperationResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetAbnormalOperationHeaders()
        return await self.get_abnormal_operation_with_options_async(request, headers, runtime)

    def get_abnormal_operation_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.GetAbnormalOperationRequest,
        headers: dingtalkdatacenter__1__0_models.GetAbnormalOperationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetAbnormalOperationResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            dingtalkdatacenter__1__0_models.GetAbnormalOperationResponse(),
            self.do_roarequest('GetAbnormalOperation', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/companies/abnormalOperations', 'json', req, runtime)
        )

    async def get_abnormal_operation_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetAbnormalOperationRequest,
        headers: dingtalkdatacenter__1__0_models.GetAbnormalOperationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetAbnormalOperationResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            dingtalkdatacenter__1__0_models.GetAbnormalOperationResponse(),
            await self.do_roarequest_async('GetAbnormalOperation', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/companies/abnormalOperations', 'json', req, runtime)
        )

    def get_administrative_penalties(
        self,
        request: dingtalkdatacenter__1__0_models.GetAdministrativePenaltiesRequest,
    ) -> dingtalkdatacenter__1__0_models.GetAdministrativePenaltiesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetAdministrativePenaltiesHeaders()
        return self.get_administrative_penalties_with_options(request, headers, runtime)

    async def get_administrative_penalties_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetAdministrativePenaltiesRequest,
    ) -> dingtalkdatacenter__1__0_models.GetAdministrativePenaltiesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetAdministrativePenaltiesHeaders()
        return await self.get_administrative_penalties_with_options_async(request, headers, runtime)

    def get_administrative_penalties_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.GetAdministrativePenaltiesRequest,
        headers: dingtalkdatacenter__1__0_models.GetAdministrativePenaltiesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetAdministrativePenaltiesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            dingtalkdatacenter__1__0_models.GetAdministrativePenaltiesResponse(),
            self.do_roarequest('GetAdministrativePenalties', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/companies/administrativePenalties', 'json', req, runtime)
        )

    async def get_administrative_penalties_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetAdministrativePenaltiesRequest,
        headers: dingtalkdatacenter__1__0_models.GetAdministrativePenaltiesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetAdministrativePenaltiesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            dingtalkdatacenter__1__0_models.GetAdministrativePenaltiesResponse(),
            await self.do_roarequest_async('GetAdministrativePenalties', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/companies/administrativePenalties', 'json', req, runtime)
        )

    def get_basic_info(
        self,
        request: dingtalkdatacenter__1__0_models.GetBasicInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.GetBasicInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetBasicInfoHeaders()
        return self.get_basic_info_with_options(request, headers, runtime)

    async def get_basic_info_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetBasicInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.GetBasicInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetBasicInfoHeaders()
        return await self.get_basic_info_with_options_async(request, headers, runtime)

    def get_basic_info_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.GetBasicInfoRequest,
        headers: dingtalkdatacenter__1__0_models.GetBasicInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetBasicInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            dingtalkdatacenter__1__0_models.GetBasicInfoResponse(),
            self.do_roarequest('GetBasicInfo', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/companies/businessBasicInfos', 'json', req, runtime)
        )

    async def get_basic_info_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetBasicInfoRequest,
        headers: dingtalkdatacenter__1__0_models.GetBasicInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetBasicInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            dingtalkdatacenter__1__0_models.GetBasicInfoResponse(),
            await self.do_roarequest_async('GetBasicInfo', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/companies/businessBasicInfos', 'json', req, runtime)
        )

    def get_environmental_penalties(
        self,
        request: dingtalkdatacenter__1__0_models.GetEnvironmentalPenaltiesRequest,
    ) -> dingtalkdatacenter__1__0_models.GetEnvironmentalPenaltiesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetEnvironmentalPenaltiesHeaders()
        return self.get_environmental_penalties_with_options(request, headers, runtime)

    async def get_environmental_penalties_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetEnvironmentalPenaltiesRequest,
    ) -> dingtalkdatacenter__1__0_models.GetEnvironmentalPenaltiesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetEnvironmentalPenaltiesHeaders()
        return await self.get_environmental_penalties_with_options_async(request, headers, runtime)

    def get_environmental_penalties_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.GetEnvironmentalPenaltiesRequest,
        headers: dingtalkdatacenter__1__0_models.GetEnvironmentalPenaltiesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetEnvironmentalPenaltiesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            dingtalkdatacenter__1__0_models.GetEnvironmentalPenaltiesResponse(),
            self.do_roarequest('GetEnvironmentalPenalties', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/companies/environmentalPenalties', 'json', req, runtime)
        )

    async def get_environmental_penalties_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetEnvironmentalPenaltiesRequest,
        headers: dingtalkdatacenter__1__0_models.GetEnvironmentalPenaltiesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetEnvironmentalPenaltiesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            dingtalkdatacenter__1__0_models.GetEnvironmentalPenaltiesResponse(),
            await self.do_roarequest_async('GetEnvironmentalPenalties', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/companies/environmentalPenalties', 'json', req, runtime)
        )

    def get_holder_info(
        self,
        request: dingtalkdatacenter__1__0_models.GetHolderInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.GetHolderInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetHolderInfoHeaders()
        return self.get_holder_info_with_options(request, headers, runtime)

    async def get_holder_info_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetHolderInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.GetHolderInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetHolderInfoHeaders()
        return await self.get_holder_info_with_options_async(request, headers, runtime)

    def get_holder_info_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.GetHolderInfoRequest,
        headers: dingtalkdatacenter__1__0_models.GetHolderInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetHolderInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            dingtalkdatacenter__1__0_models.GetHolderInfoResponse(),
            self.do_roarequest('GetHolderInfo', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/companies/shareholderInfos', 'json', req, runtime)
        )

    async def get_holder_info_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetHolderInfoRequest,
        headers: dingtalkdatacenter__1__0_models.GetHolderInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetHolderInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            dingtalkdatacenter__1__0_models.GetHolderInfoResponse(),
            await self.do_roarequest_async('GetHolderInfo', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/companies/shareholderInfos', 'json', req, runtime)
        )

    def get_qeneral_taxpayer_info(
        self,
        request: dingtalkdatacenter__1__0_models.GetQeneralTaxpayerInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.GetQeneralTaxpayerInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetQeneralTaxpayerInfoHeaders()
        return self.get_qeneral_taxpayer_info_with_options(request, headers, runtime)

    async def get_qeneral_taxpayer_info_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetQeneralTaxpayerInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.GetQeneralTaxpayerInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetQeneralTaxpayerInfoHeaders()
        return await self.get_qeneral_taxpayer_info_with_options_async(request, headers, runtime)

    def get_qeneral_taxpayer_info_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.GetQeneralTaxpayerInfoRequest,
        headers: dingtalkdatacenter__1__0_models.GetQeneralTaxpayerInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetQeneralTaxpayerInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            dingtalkdatacenter__1__0_models.GetQeneralTaxpayerInfoResponse(),
            self.do_roarequest('GetQeneralTaxpayerInfo', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/companies/generalTaxpayerInfos', 'json', req, runtime)
        )

    async def get_qeneral_taxpayer_info_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetQeneralTaxpayerInfoRequest,
        headers: dingtalkdatacenter__1__0_models.GetQeneralTaxpayerInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetQeneralTaxpayerInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            dingtalkdatacenter__1__0_models.GetQeneralTaxpayerInfoResponse(),
            await self.do_roarequest_async('GetQeneralTaxpayerInfo', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/companies/generalTaxpayerInfos', 'json', req, runtime)
        )

    def get_serious_violation(
        self,
        request: dingtalkdatacenter__1__0_models.GetSeriousViolationRequest,
    ) -> dingtalkdatacenter__1__0_models.GetSeriousViolationResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetSeriousViolationHeaders()
        return self.get_serious_violation_with_options(request, headers, runtime)

    async def get_serious_violation_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetSeriousViolationRequest,
    ) -> dingtalkdatacenter__1__0_models.GetSeriousViolationResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetSeriousViolationHeaders()
        return await self.get_serious_violation_with_options_async(request, headers, runtime)

    def get_serious_violation_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.GetSeriousViolationRequest,
        headers: dingtalkdatacenter__1__0_models.GetSeriousViolationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetSeriousViolationResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            dingtalkdatacenter__1__0_models.GetSeriousViolationResponse(),
            self.do_roarequest('GetSeriousViolation', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/companies/seriousViolations', 'json', req, runtime)
        )

    async def get_serious_violation_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetSeriousViolationRequest,
        headers: dingtalkdatacenter__1__0_models.GetSeriousViolationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetSeriousViolationResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            dingtalkdatacenter__1__0_models.GetSeriousViolationResponse(),
            await self.do_roarequest_async('GetSeriousViolation', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/companies/seriousViolations', 'json', req, runtime)
        )

    def post_corp_auth_info(self) -> dingtalkdatacenter__1__0_models.PostCorpAuthInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.PostCorpAuthInfoHeaders()
        return self.post_corp_auth_info_with_options(headers, runtime)

    async def post_corp_auth_info_async(self) -> dingtalkdatacenter__1__0_models.PostCorpAuthInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.PostCorpAuthInfoHeaders()
        return await self.post_corp_auth_info_with_options_async(headers, runtime)

    def post_corp_auth_info_with_options(
        self,
        headers: dingtalkdatacenter__1__0_models.PostCorpAuthInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.PostCorpAuthInfoResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.PostCorpAuthInfoResponse(),
            self.do_roarequest('PostCorpAuthInfo', 'datacenter_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/datacenter/corporations/authorize', 'json', req, runtime)
        )

    async def post_corp_auth_info_with_options_async(
        self,
        headers: dingtalkdatacenter__1__0_models.PostCorpAuthInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.PostCorpAuthInfoResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.PostCorpAuthInfoResponse(),
            await self.do_roarequest_async('PostCorpAuthInfo', 'datacenter_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/datacenter/corporations/authorize', 'json', req, runtime)
        )

    def query_active_user_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataHeaders()
        return self.query_active_user_statistical_data_with_options(request, headers, runtime)

    async def query_active_user_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataHeaders()
        return await self.query_active_user_statistical_data_with_options_async(request, headers, runtime)

    def query_active_user_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataResponse(),
            self.do_roarequest('QueryActiveUserStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/activeUserData', 'json', req, runtime)
        )

    async def query_active_user_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataResponse(),
            await self.do_roarequest_async('QueryActiveUserStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/activeUserData', 'json', req, runtime)
        )

    def query_anhmd_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryAnhmdStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryAnhmdStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryAnhmdStatisticalDataHeaders()
        return self.query_anhmd_statistical_data_with_options(request, headers, runtime)

    async def query_anhmd_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryAnhmdStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryAnhmdStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryAnhmdStatisticalDataHeaders()
        return await self.query_anhmd_statistical_data_with_options_async(request, headers, runtime)

    def query_anhmd_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryAnhmdStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryAnhmdStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryAnhmdStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryAnhmdStatisticalDataResponse(),
            self.do_roarequest('QueryAnhmdStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/statisticDatas/anHmd', 'json', req, runtime)
        )

    async def query_anhmd_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryAnhmdStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryAnhmdStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryAnhmdStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryAnhmdStatisticalDataResponse(),
            await self.do_roarequest_async('QueryAnhmdStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/statisticDatas/anHmd', 'json', req, runtime)
        )

    def query_approval_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataHeaders()
        return self.query_approval_statistical_data_with_options(request, headers, runtime)

    async def query_approval_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataHeaders()
        return await self.query_approval_statistical_data_with_options_async(request, headers, runtime)

    def query_approval_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataResponse(),
            self.do_roarequest('QueryApprovalStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/approvalData', 'json', req, runtime)
        )

    async def query_approval_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataResponse(),
            await self.do_roarequest_async('QueryApprovalStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/approvalData', 'json', req, runtime)
        )

    def query_attendance_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataHeaders()
        return self.query_attendance_statistical_data_with_options(request, headers, runtime)

    async def query_attendance_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataHeaders()
        return await self.query_attendance_statistical_data_with_options_async(request, headers, runtime)

    def query_attendance_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataResponse(),
            self.do_roarequest('QueryAttendanceStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/attendanceData', 'json', req, runtime)
        )

    async def query_attendance_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataResponse(),
            await self.do_roarequest_async('QueryAttendanceStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/attendanceData', 'json', req, runtime)
        )

    def query_blackboard_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataHeaders()
        return self.query_blackboard_statistical_data_with_options(request, headers, runtime)

    async def query_blackboard_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataHeaders()
        return await self.query_blackboard_statistical_data_with_options_async(request, headers, runtime)

    def query_blackboard_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataResponse(),
            self.do_roarequest('QueryBlackboardStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/blackboardData', 'json', req, runtime)
        )

    async def query_blackboard_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataResponse(),
            await self.do_roarequest_async('QueryBlackboardStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/blackboardData', 'json', req, runtime)
        )

    def query_calendar_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataHeaders()
        return self.query_calendar_statistical_data_with_options(request, headers, runtime)

    async def query_calendar_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataHeaders()
        return await self.query_calendar_statistical_data_with_options_async(request, headers, runtime)

    def query_calendar_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataResponse(),
            self.do_roarequest('QueryCalendarStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/calendarData', 'json', req, runtime)
        )

    async def query_calendar_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataResponse(),
            await self.do_roarequest_async('QueryCalendarStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/calendarData', 'json', req, runtime)
        )

    def query_checkin_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataHeaders()
        return self.query_checkin_statistical_data_with_options(request, headers, runtime)

    async def query_checkin_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataHeaders()
        return await self.query_checkin_statistical_data_with_options_async(request, headers, runtime)

    def query_checkin_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataResponse(),
            self.do_roarequest('QueryCheckinStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/checkinData', 'json', req, runtime)
        )

    async def query_checkin_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataResponse(),
            await self.do_roarequest_async('QueryCheckinStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/checkinData', 'json', req, runtime)
        )

    def query_circle_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataHeaders()
        return self.query_circle_statistical_data_with_options(request, headers, runtime)

    async def query_circle_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataHeaders()
        return await self.query_circle_statistical_data_with_options_async(request, headers, runtime)

    def query_circle_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataResponse(),
            self.do_roarequest('QueryCircleStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/circleData', 'json', req, runtime)
        )

    async def query_circle_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataResponse(),
            await self.do_roarequest_async('QueryCircleStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/circleData', 'json', req, runtime)
        )

    def query_company_basic_info(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoHeaders()
        return self.query_company_basic_info_with_options(request, headers, runtime)

    async def query_company_basic_info_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoHeaders()
        return await self.query_company_basic_info_with_options_async(request, headers, runtime)

    def query_company_basic_info_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoRequest,
        headers: dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.keyword):
            query['keyword'] = request.keyword
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
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoResponse(),
            self.do_roarequest('QueryCompanyBasicInfo', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/companies/basicInfo', 'json', req, runtime)
        )

    async def query_company_basic_info_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoRequest,
        headers: dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.keyword):
            query['keyword'] = request.keyword
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
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoResponse(),
            await self.do_roarequest_async('QueryCompanyBasicInfo', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/companies/basicInfo', 'json', req, runtime)
        )

    def query_digital_district_org_info(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoHeaders()
        return self.query_digital_district_org_info_with_options(request, headers, runtime)

    async def query_digital_district_org_info_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoHeaders()
        return await self.query_digital_district_org_info_with_options_async(request, headers, runtime)

    def query_digital_district_org_info_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoRequest,
        headers: dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_ids):
            body['corpIds'] = request.corp_ids
        if not UtilClient.is_unset(request.stat_dates):
            body['statDates'] = request.stat_dates
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
            dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoResponse(),
            self.do_roarequest('QueryDigitalDistrictOrgInfo', 'datacenter_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/datacenter/digitalCounty/orgInfos/query', 'json', req, runtime)
        )

    async def query_digital_district_org_info_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoRequest,
        headers: dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_ids):
            body['corpIds'] = request.corp_ids
        if not UtilClient.is_unset(request.stat_dates):
            body['statDates'] = request.stat_dates
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
            dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoResponse(),
            await self.do_roarequest_async('QueryDigitalDistrictOrgInfo', 'datacenter_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/datacenter/digitalCounty/orgInfos/query', 'json', req, runtime)
        )

    def query_ding_recive_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataHeaders()
        return self.query_ding_recive_statistical_data_with_options(request, headers, runtime)

    async def query_ding_recive_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataHeaders()
        return await self.query_ding_recive_statistical_data_with_options_async(request, headers, runtime)

    def query_ding_recive_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataResponse(),
            self.do_roarequest('QueryDingReciveStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/dingReciveData', 'json', req, runtime)
        )

    async def query_ding_recive_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataResponse(),
            await self.do_roarequest_async('QueryDingReciveStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/dingReciveData', 'json', req, runtime)
        )

    def query_ding_send_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataHeaders()
        return self.query_ding_send_statistical_data_with_options(request, headers, runtime)

    async def query_ding_send_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataHeaders()
        return await self.query_ding_send_statistical_data_with_options_async(request, headers, runtime)

    def query_ding_send_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataResponse(),
            self.do_roarequest('QueryDingSendStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/dingSendData', 'json', req, runtime)
        )

    async def query_ding_send_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataResponse(),
            await self.do_roarequest_async('QueryDingSendStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/dingSendData', 'json', req, runtime)
        )

    def query_document_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataHeaders()
        return self.query_document_statistical_data_with_options(request, headers, runtime)

    async def query_document_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataHeaders()
        return await self.query_document_statistical_data_with_options_async(request, headers, runtime)

    def query_document_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataResponse(),
            self.do_roarequest('QueryDocumentStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/documentData', 'json', req, runtime)
        )

    async def query_document_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataResponse(),
            await self.do_roarequest_async('QueryDocumentStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/documentData', 'json', req, runtime)
        )

    def query_drive_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataHeaders()
        return self.query_drive_statistical_data_with_options(request, headers, runtime)

    async def query_drive_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataHeaders()
        return await self.query_drive_statistical_data_with_options_async(request, headers, runtime)

    def query_drive_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataResponse(),
            self.do_roarequest('QueryDriveStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/driveData', 'json', req, runtime)
        )

    async def query_drive_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataResponse(),
            await self.do_roarequest_async('QueryDriveStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/driveData', 'json', req, runtime)
        )

    def query_employee_type_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataHeaders()
        return self.query_employee_type_statistical_data_with_options(request, headers, runtime)

    async def query_employee_type_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataHeaders()
        return await self.query_employee_type_statistical_data_with_options_async(request, headers, runtime)

    def query_employee_type_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataResponse(),
            self.do_roarequest('QueryEmployeeTypeStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/employeeTypeData', 'json', req, runtime)
        )

    async def query_employee_type_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataResponse(),
            await self.do_roarequest_async('QueryEmployeeTypeStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/employeeTypeData', 'json', req, runtime)
        )

    def query_general_data_service(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGeneralDataServiceRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryGeneralDataServiceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryGeneralDataServiceHeaders()
        return self.query_general_data_service_with_options(request, headers, runtime)

    async def query_general_data_service_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGeneralDataServiceRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryGeneralDataServiceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryGeneralDataServiceHeaders()
        return await self.query_general_data_service_with_options_async(request, headers, runtime)

    def query_general_data_service_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGeneralDataServiceRequest,
        headers: dingtalkdatacenter__1__0_models.QueryGeneralDataServiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryGeneralDataServiceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.end_date):
            query['endDate'] = request.end_date
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.service_id):
            query['serviceId'] = request.service_id
        if not UtilClient.is_unset(request.start_date):
            query['startDate'] = request.start_date
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
            dingtalkdatacenter__1__0_models.QueryGeneralDataServiceResponse(),
            self.do_roarequest('QueryGeneralDataService', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/generalDataServices', 'json', req, runtime)
        )

    async def query_general_data_service_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGeneralDataServiceRequest,
        headers: dingtalkdatacenter__1__0_models.QueryGeneralDataServiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryGeneralDataServiceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.end_date):
            query['endDate'] = request.end_date
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.service_id):
            query['serviceId'] = request.service_id
        if not UtilClient.is_unset(request.start_date):
            query['startDate'] = request.start_date
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
            dingtalkdatacenter__1__0_models.QueryGeneralDataServiceResponse(),
            await self.do_roarequest_async('QueryGeneralDataService', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/generalDataServices', 'json', req, runtime)
        )

    def query_group_live_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataHeaders()
        return self.query_group_live_statistical_data_with_options(request, headers, runtime)

    async def query_group_live_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataHeaders()
        return await self.query_group_live_statistical_data_with_options_async(request, headers, runtime)

    def query_group_live_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataResponse(),
            self.do_roarequest('QueryGroupLiveStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/groupLiveData', 'json', req, runtime)
        )

    async def query_group_live_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataResponse(),
            await self.do_roarequest_async('QueryGroupLiveStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/groupLiveData', 'json', req, runtime)
        )

    def query_group_message_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataHeaders()
        return self.query_group_message_statistical_data_with_options(request, headers, runtime)

    async def query_group_message_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataHeaders()
        return await self.query_group_message_statistical_data_with_options_async(request, headers, runtime)

    def query_group_message_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataResponse(),
            self.do_roarequest('QueryGroupMessageStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/groupMessageData', 'json', req, runtime)
        )

    async def query_group_message_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataResponse(),
            await self.do_roarequest_async('QueryGroupMessageStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/groupMessageData', 'json', req, runtime)
        )

    def query_health_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataHeaders()
        return self.query_health_statistical_data_with_options(request, headers, runtime)

    async def query_health_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataHeaders()
        return await self.query_health_statistical_data_with_options_async(request, headers, runtime)

    def query_health_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataResponse(),
            self.do_roarequest('QueryHealthStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/healtheUserData', 'json', req, runtime)
        )

    async def query_health_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataResponse(),
            await self.do_roarequest_async('QueryHealthStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/healtheUserData', 'json', req, runtime)
        )

    def query_mail_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryMailStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryMailStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryMailStatisticalDataHeaders()
        return self.query_mail_statistical_data_with_options(request, headers, runtime)

    async def query_mail_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryMailStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryMailStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryMailStatisticalDataHeaders()
        return await self.query_mail_statistical_data_with_options_async(request, headers, runtime)

    def query_mail_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryMailStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryMailStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryMailStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryMailStatisticalDataResponse(),
            self.do_roarequest('QueryMailStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/mailData', 'json', req, runtime)
        )

    async def query_mail_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryMailStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryMailStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryMailStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryMailStatisticalDataResponse(),
            await self.do_roarequest_async('QueryMailStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/mailData', 'json', req, runtime)
        )

    def query_official_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryOfficialDataHeaders()
        return self.query_official_data_with_options(request, headers, runtime)

    async def query_official_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryOfficialDataHeaders()
        return await self.query_official_data_with_options_async(request, headers, runtime)

    def query_official_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryOfficialDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.param):
            query['param'] = request.param
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
            dingtalkdatacenter__1__0_models.QueryOfficialDataResponse(),
            self.do_roarequest('QueryOfficialData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/datas', 'json', req, runtime)
        )

    async def query_official_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryOfficialDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.param):
            query['param'] = request.param
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
            dingtalkdatacenter__1__0_models.QueryOfficialDataResponse(),
            await self.do_roarequest_async('QueryOfficialData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/datas', 'json', req, runtime)
        )

    def query_official_dataset_fields(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialDatasetFieldsRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialDatasetFieldsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryOfficialDatasetFieldsHeaders()
        return self.query_official_dataset_fields_with_options(request, headers, runtime)

    async def query_official_dataset_fields_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialDatasetFieldsRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialDatasetFieldsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryOfficialDatasetFieldsHeaders()
        return await self.query_official_dataset_fields_with_options_async(request, headers, runtime)

    def query_official_dataset_fields_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialDatasetFieldsRequest,
        headers: dingtalkdatacenter__1__0_models.QueryOfficialDatasetFieldsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialDatasetFieldsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ds_id):
            query['dsId'] = request.ds_id
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
            dingtalkdatacenter__1__0_models.QueryOfficialDatasetFieldsResponse(),
            self.do_roarequest('QueryOfficialDatasetFields', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/datasetFields', 'json', req, runtime)
        )

    async def query_official_dataset_fields_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialDatasetFieldsRequest,
        headers: dingtalkdatacenter__1__0_models.QueryOfficialDatasetFieldsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialDatasetFieldsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ds_id):
            query['dsId'] = request.ds_id
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
            dingtalkdatacenter__1__0_models.QueryOfficialDatasetFieldsResponse(),
            await self.do_roarequest_async('QueryOfficialDatasetFields', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/datasetFields', 'json', req, runtime)
        )

    def query_official_dataset_list(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialDatasetListRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialDatasetListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryOfficialDatasetListHeaders()
        return self.query_official_dataset_list_with_options(request, headers, runtime)

    async def query_official_dataset_list_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialDatasetListRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialDatasetListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryOfficialDatasetListHeaders()
        return await self.query_official_dataset_list_with_options_async(request, headers, runtime)

    def query_official_dataset_list_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialDatasetListRequest,
        headers: dingtalkdatacenter__1__0_models.QueryOfficialDatasetListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialDatasetListResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.keyword):
            query['keyword'] = request.keyword
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
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryOfficialDatasetListResponse(),
            self.do_roarequest('QueryOfficialDatasetList', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/datasetLists', 'json', req, runtime)
        )

    async def query_official_dataset_list_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialDatasetListRequest,
        headers: dingtalkdatacenter__1__0_models.QueryOfficialDatasetListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialDatasetListResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.keyword):
            query['keyword'] = request.keyword
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
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryOfficialDatasetListResponse(),
            await self.do_roarequest_async('QueryOfficialDatasetList', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/datasetLists', 'json', req, runtime)
        )

    def query_online_user_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataHeaders()
        return self.query_online_user_statistical_data_with_options(request, headers, runtime)

    async def query_online_user_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataHeaders()
        return await self.query_online_user_statistical_data_with_options_async(request, headers, runtime)

    def query_online_user_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataResponse(),
            self.do_roarequest('QueryOnlineUserStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/onlineUserData', 'json', req, runtime)
        )

    async def query_online_user_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataResponse(),
            await self.do_roarequest_async('QueryOnlineUserStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/onlineUserData', 'json', req, runtime)
        )

    def query_red_envelope_recive_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataHeaders()
        return self.query_red_envelope_recive_statistical_data_with_options(request, headers, runtime)

    async def query_red_envelope_recive_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataHeaders()
        return await self.query_red_envelope_recive_statistical_data_with_options_async(request, headers, runtime)

    def query_red_envelope_recive_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataResponse(),
            self.do_roarequest('QueryRedEnvelopeReciveStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/redEnvelopeReciveData', 'json', req, runtime)
        )

    async def query_red_envelope_recive_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataResponse(),
            await self.do_roarequest_async('QueryRedEnvelopeReciveStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/redEnvelopeReciveData', 'json', req, runtime)
        )

    def query_red_envelope_send_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataHeaders()
        return self.query_red_envelope_send_statistical_data_with_options(request, headers, runtime)

    async def query_red_envelope_send_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataHeaders()
        return await self.query_red_envelope_send_statistical_data_with_options_async(request, headers, runtime)

    def query_red_envelope_send_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataResponse(),
            self.do_roarequest('QueryRedEnvelopeSendStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/redEnvelopeSendData', 'json', req, runtime)
        )

    async def query_red_envelope_send_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataResponse(),
            await self.do_roarequest_async('QueryRedEnvelopeSendStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/redEnvelopeSendData', 'json', req, runtime)
        )

    def query_report_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryReportStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryReportStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryReportStatisticalDataHeaders()
        return self.query_report_statistical_data_with_options(request, headers, runtime)

    async def query_report_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryReportStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryReportStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryReportStatisticalDataHeaders()
        return await self.query_report_statistical_data_with_options_async(request, headers, runtime)

    def query_report_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryReportStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryReportStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryReportStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryReportStatisticalDataResponse(),
            self.do_roarequest('QueryReportStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/reportData', 'json', req, runtime)
        )

    async def query_report_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryReportStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryReportStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryReportStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryReportStatisticalDataResponse(),
            await self.do_roarequest_async('QueryReportStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/reportData', 'json', req, runtime)
        )

    def query_single_message_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataHeaders()
        return self.query_single_message_statistical_data_with_options(request, headers, runtime)

    async def query_single_message_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataHeaders()
        return await self.query_single_message_statistical_data_with_options_async(request, headers, runtime)

    def query_single_message_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataResponse(),
            self.do_roarequest('QuerySingleMessageStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/singleMessagerData', 'json', req, runtime)
        )

    async def query_single_message_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataResponse(),
            await self.do_roarequest_async('QuerySingleMessageStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/singleMessagerData', 'json', req, runtime)
        )

    def query_tel_meeting_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataHeaders()
        return self.query_tel_meeting_statistical_data_with_options(request, headers, runtime)

    async def query_tel_meeting_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataHeaders()
        return await self.query_tel_meeting_statistical_data_with_options_async(request, headers, runtime)

    def query_tel_meeting_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataResponse(),
            self.do_roarequest('QueryTelMeetingStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/telMeetingData', 'json', req, runtime)
        )

    async def query_tel_meeting_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataResponse(),
            await self.do_roarequest_async('QueryTelMeetingStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/telMeetingData', 'json', req, runtime)
        )

    def query_todo_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataHeaders()
        return self.query_todo_statistical_data_with_options(request, headers, runtime)

    async def query_todo_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataHeaders()
        return await self.query_todo_statistical_data_with_options_async(request, headers, runtime)

    def query_todo_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataResponse(),
            self.do_roarequest('QueryTodoStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/todoUserData', 'json', req, runtime)
        )

    async def query_todo_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataResponse(),
            await self.do_roarequest_async('QueryTodoStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/todoUserData', 'json', req, runtime)
        )

    def query_vedio_meeting_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataHeaders()
        return self.query_vedio_meeting_statistical_data_with_options(request, headers, runtime)

    async def query_vedio_meeting_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataHeaders()
        return await self.query_vedio_meeting_statistical_data_with_options_async(request, headers, runtime)

    def query_vedio_meeting_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataResponse(),
            self.do_roarequest('QueryVedioMeetingStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/vedioMeetingData', 'json', req, runtime)
        )

    async def query_vedio_meeting_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataResponse(),
            await self.do_roarequest_async('QueryVedioMeetingStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/vedioMeetingData', 'json', req, runtime)
        )

    def query_yyd_active_day_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydActiveDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydActiveDayStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydActiveDayStatisticalDataHeaders()
        return self.query_yyd_active_day_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_active_day_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydActiveDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydActiveDayStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydActiveDayStatisticalDataHeaders()
        return await self.query_yyd_active_day_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_active_day_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydActiveDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydActiveDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydActiveDayStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydActiveDayStatisticalDataResponse(),
            self.do_roarequest('QueryYydActiveDayStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydActiveDayDatas', 'json', req, runtime)
        )

    async def query_yyd_active_day_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydActiveDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydActiveDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydActiveDayStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydActiveDayStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydActiveDayStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydActiveDayDatas', 'json', req, runtime)
        )

    def query_yyd_active_month_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydActiveMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydActiveMonthStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydActiveMonthStatisticalDataHeaders()
        return self.query_yyd_active_month_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_active_month_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydActiveMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydActiveMonthStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydActiveMonthStatisticalDataHeaders()
        return await self.query_yyd_active_month_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_active_month_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydActiveMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydActiveMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydActiveMonthStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydActiveMonthStatisticalDataResponse(),
            self.do_roarequest('QueryYydActiveMonthStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydActiveMonthDatas', 'json', req, runtime)
        )

    async def query_yyd_active_month_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydActiveMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydActiveMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydActiveMonthStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydActiveMonthStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydActiveMonthStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydActiveMonthDatas', 'json', req, runtime)
        )

    def query_yyd_active_week_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydActiveWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydActiveWeekStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydActiveWeekStatisticalDataHeaders()
        return self.query_yyd_active_week_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_active_week_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydActiveWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydActiveWeekStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydActiveWeekStatisticalDataHeaders()
        return await self.query_yyd_active_week_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_active_week_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydActiveWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydActiveWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydActiveWeekStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydActiveWeekStatisticalDataResponse(),
            self.do_roarequest('QueryYydActiveWeekStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydActiveWeekDatas', 'json', req, runtime)
        )

    async def query_yyd_active_week_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydActiveWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydActiveWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydActiveWeekStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydActiveWeekStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydActiveWeekStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydActiveWeekDatas', 'json', req, runtime)
        )

    def query_yyd_app_day_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppDayStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydAppDayStatisticalDataHeaders()
        return self.query_yyd_app_day_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_app_day_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppDayStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydAppDayStatisticalDataHeaders()
        return await self.query_yyd_app_day_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_app_day_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydAppDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppDayStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydAppDayStatisticalDataResponse(),
            self.do_roarequest('QueryYydAppDayStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydAppDayDatas', 'json', req, runtime)
        )

    async def query_yyd_app_day_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydAppDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppDayStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydAppDayStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydAppDayStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydAppDayDatas', 'json', req, runtime)
        )

    def query_yyd_app_month_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppMonthStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydAppMonthStatisticalDataHeaders()
        return self.query_yyd_app_month_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_app_month_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppMonthStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydAppMonthStatisticalDataHeaders()
        return await self.query_yyd_app_month_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_app_month_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydAppMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppMonthStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydAppMonthStatisticalDataResponse(),
            self.do_roarequest('QueryYydAppMonthStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydAppMonthDatas', 'json', req, runtime)
        )

    async def query_yyd_app_month_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydAppMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppMonthStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydAppMonthStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydAppMonthStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydAppMonthDatas', 'json', req, runtime)
        )

    def query_yyd_app_std_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppStdStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppStdStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydAppStdStatisticalDataHeaders()
        return self.query_yyd_app_std_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_app_std_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppStdStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppStdStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydAppStdStatisticalDataHeaders()
        return await self.query_yyd_app_std_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_app_std_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppStdStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydAppStdStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppStdStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydAppStdStatisticalDataResponse(),
            self.do_roarequest('QueryYydAppStdStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydAppStdDatas', 'json', req, runtime)
        )

    async def query_yyd_app_std_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppStdStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydAppStdStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppStdStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydAppStdStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydAppStdStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydAppStdDatas', 'json', req, runtime)
        )

    def query_yyd_app_week_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppWeekStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydAppWeekStatisticalDataHeaders()
        return self.query_yyd_app_week_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_app_week_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppWeekStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydAppWeekStatisticalDataHeaders()
        return await self.query_yyd_app_week_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_app_week_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydAppWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppWeekStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydAppWeekStatisticalDataResponse(),
            self.do_roarequest('QueryYydAppWeekStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydAppWeekDatas', 'json', req, runtime)
        )

    async def query_yyd_app_week_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydAppWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppWeekStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydAppWeekStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydAppWeekStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydAppWeekDatas', 'json', req, runtime)
        )

    def query_yyd_calendar_day_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydCalendarDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydCalendarDayStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydCalendarDayStatisticalDataHeaders()
        return self.query_yyd_calendar_day_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_calendar_day_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydCalendarDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydCalendarDayStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydCalendarDayStatisticalDataHeaders()
        return await self.query_yyd_calendar_day_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_calendar_day_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydCalendarDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydCalendarDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydCalendarDayStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydCalendarDayStatisticalDataResponse(),
            self.do_roarequest('QueryYydCalendarDayStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydCalendarDayDatas', 'json', req, runtime)
        )

    async def query_yyd_calendar_day_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydCalendarDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydCalendarDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydCalendarDayStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydCalendarDayStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydCalendarDayStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydCalendarDayDatas', 'json', req, runtime)
        )

    def query_yyd_calendar_month_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydCalendarMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydCalendarMonthStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydCalendarMonthStatisticalDataHeaders()
        return self.query_yyd_calendar_month_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_calendar_month_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydCalendarMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydCalendarMonthStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydCalendarMonthStatisticalDataHeaders()
        return await self.query_yyd_calendar_month_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_calendar_month_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydCalendarMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydCalendarMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydCalendarMonthStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydCalendarMonthStatisticalDataResponse(),
            self.do_roarequest('QueryYydCalendarMonthStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydCalendarMonthDatas', 'json', req, runtime)
        )

    async def query_yyd_calendar_month_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydCalendarMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydCalendarMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydCalendarMonthStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydCalendarMonthStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydCalendarMonthStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydCalendarMonthDatas', 'json', req, runtime)
        )

    def query_yyd_calendar_week_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydCalendarWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydCalendarWeekStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydCalendarWeekStatisticalDataHeaders()
        return self.query_yyd_calendar_week_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_calendar_week_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydCalendarWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydCalendarWeekStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydCalendarWeekStatisticalDataHeaders()
        return await self.query_yyd_calendar_week_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_calendar_week_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydCalendarWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydCalendarWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydCalendarWeekStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydCalendarWeekStatisticalDataResponse(),
            self.do_roarequest('QueryYydCalendarWeekStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydCalendarWeekDatas', 'json', req, runtime)
        )

    async def query_yyd_calendar_week_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydCalendarWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydCalendarWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydCalendarWeekStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydCalendarWeekStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydCalendarWeekStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydCalendarWeekDatas', 'json', req, runtime)
        )

    def query_yyd_ding_msg_day_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydDingMsgDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydDingMsgDayStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydDingMsgDayStatisticalDataHeaders()
        return self.query_yyd_ding_msg_day_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_ding_msg_day_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydDingMsgDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydDingMsgDayStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydDingMsgDayStatisticalDataHeaders()
        return await self.query_yyd_ding_msg_day_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_ding_msg_day_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydDingMsgDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydDingMsgDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydDingMsgDayStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydDingMsgDayStatisticalDataResponse(),
            self.do_roarequest('QueryYydDingMsgDayStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydDingMsgDayDatas', 'json', req, runtime)
        )

    async def query_yyd_ding_msg_day_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydDingMsgDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydDingMsgDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydDingMsgDayStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydDingMsgDayStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydDingMsgDayStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydDingMsgDayDatas', 'json', req, runtime)
        )

    def query_yyd_ding_msg_month_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydDingMsgMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydDingMsgMonthStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydDingMsgMonthStatisticalDataHeaders()
        return self.query_yyd_ding_msg_month_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_ding_msg_month_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydDingMsgMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydDingMsgMonthStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydDingMsgMonthStatisticalDataHeaders()
        return await self.query_yyd_ding_msg_month_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_ding_msg_month_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydDingMsgMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydDingMsgMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydDingMsgMonthStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydDingMsgMonthStatisticalDataResponse(),
            self.do_roarequest('QueryYydDingMsgMonthStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydDingMsgMonthDatas', 'json', req, runtime)
        )

    async def query_yyd_ding_msg_month_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydDingMsgMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydDingMsgMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydDingMsgMonthStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydDingMsgMonthStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydDingMsgMonthStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydDingMsgMonthDatas', 'json', req, runtime)
        )

    def query_yyd_ding_msg_week_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydDingMsgWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydDingMsgWeekStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydDingMsgWeekStatisticalDataHeaders()
        return self.query_yyd_ding_msg_week_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_ding_msg_week_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydDingMsgWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydDingMsgWeekStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydDingMsgWeekStatisticalDataHeaders()
        return await self.query_yyd_ding_msg_week_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_ding_msg_week_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydDingMsgWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydDingMsgWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydDingMsgWeekStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydDingMsgWeekStatisticalDataResponse(),
            self.do_roarequest('QueryYydDingMsgWeekStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydDingMsgWeekDatas', 'json', req, runtime)
        )

    async def query_yyd_ding_msg_week_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydDingMsgWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydDingMsgWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydDingMsgWeekStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydDingMsgWeekStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydDingMsgWeekStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydDingMsgWeekDatas', 'json', req, runtime)
        )

    def query_yyd_group_msg_day_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydGroupMsgDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydGroupMsgDayStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydGroupMsgDayStatisticalDataHeaders()
        return self.query_yyd_group_msg_day_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_group_msg_day_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydGroupMsgDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydGroupMsgDayStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydGroupMsgDayStatisticalDataHeaders()
        return await self.query_yyd_group_msg_day_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_group_msg_day_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydGroupMsgDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydGroupMsgDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydGroupMsgDayStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydGroupMsgDayStatisticalDataResponse(),
            self.do_roarequest('QueryYydGroupMsgDayStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydGroupMsgDayDatas', 'json', req, runtime)
        )

    async def query_yyd_group_msg_day_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydGroupMsgDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydGroupMsgDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydGroupMsgDayStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydGroupMsgDayStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydGroupMsgDayStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydGroupMsgDayDatas', 'json', req, runtime)
        )

    def query_yyd_group_msg_month_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydGroupMsgMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydGroupMsgMonthStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydGroupMsgMonthStatisticalDataHeaders()
        return self.query_yyd_group_msg_month_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_group_msg_month_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydGroupMsgMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydGroupMsgMonthStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydGroupMsgMonthStatisticalDataHeaders()
        return await self.query_yyd_group_msg_month_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_group_msg_month_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydGroupMsgMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydGroupMsgMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydGroupMsgMonthStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydGroupMsgMonthStatisticalDataResponse(),
            self.do_roarequest('QueryYydGroupMsgMonthStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydGroupMsgMonthDatas', 'json', req, runtime)
        )

    async def query_yyd_group_msg_month_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydGroupMsgMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydGroupMsgMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydGroupMsgMonthStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydGroupMsgMonthStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydGroupMsgMonthStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydGroupMsgMonthDatas', 'json', req, runtime)
        )

    def query_yyd_group_msg_week_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydGroupMsgWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydGroupMsgWeekStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydGroupMsgWeekStatisticalDataHeaders()
        return self.query_yyd_group_msg_week_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_group_msg_week_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydGroupMsgWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydGroupMsgWeekStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydGroupMsgWeekStatisticalDataHeaders()
        return await self.query_yyd_group_msg_week_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_group_msg_week_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydGroupMsgWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydGroupMsgWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydGroupMsgWeekStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydGroupMsgWeekStatisticalDataResponse(),
            self.do_roarequest('QueryYydGroupMsgWeekStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydGroupMsgWeekDatas', 'json', req, runtime)
        )

    async def query_yyd_group_msg_week_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydGroupMsgWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydGroupMsgWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydGroupMsgWeekStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydGroupMsgWeekStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydGroupMsgWeekStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydGroupMsgWeekDatas', 'json', req, runtime)
        )

    def query_yyd_log_day_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydLogDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydLogDayStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydLogDayStatisticalDataHeaders()
        return self.query_yyd_log_day_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_log_day_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydLogDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydLogDayStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydLogDayStatisticalDataHeaders()
        return await self.query_yyd_log_day_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_log_day_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydLogDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydLogDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydLogDayStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydLogDayStatisticalDataResponse(),
            self.do_roarequest('QueryYydLogDayStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydLogDayDatas', 'json', req, runtime)
        )

    async def query_yyd_log_day_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydLogDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydLogDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydLogDayStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydLogDayStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydLogDayStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydLogDayDatas', 'json', req, runtime)
        )

    def query_yyd_log_month_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydLogMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydLogMonthStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydLogMonthStatisticalDataHeaders()
        return self.query_yyd_log_month_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_log_month_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydLogMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydLogMonthStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydLogMonthStatisticalDataHeaders()
        return await self.query_yyd_log_month_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_log_month_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydLogMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydLogMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydLogMonthStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydLogMonthStatisticalDataResponse(),
            self.do_roarequest('QueryYydLogMonthStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydLogMonthDatas', 'json', req, runtime)
        )

    async def query_yyd_log_month_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydLogMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydLogMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydLogMonthStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydLogMonthStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydLogMonthStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydLogMonthDatas', 'json', req, runtime)
        )

    def query_yyd_log_week_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydLogWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydLogWeekStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydLogWeekStatisticalDataHeaders()
        return self.query_yyd_log_week_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_log_week_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydLogWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydLogWeekStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydLogWeekStatisticalDataHeaders()
        return await self.query_yyd_log_week_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_log_week_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydLogWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydLogWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydLogWeekStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydLogWeekStatisticalDataResponse(),
            self.do_roarequest('QueryYydLogWeekStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydLogWeekDatas', 'json', req, runtime)
        )

    async def query_yyd_log_week_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydLogWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydLogWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydLogWeekStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydLogWeekStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydLogWeekStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydLogWeekDatas', 'json', req, runtime)
        )

    def query_yyd_meeting_day_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydMeetingDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydMeetingDayStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydMeetingDayStatisticalDataHeaders()
        return self.query_yyd_meeting_day_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_meeting_day_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydMeetingDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydMeetingDayStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydMeetingDayStatisticalDataHeaders()
        return await self.query_yyd_meeting_day_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_meeting_day_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydMeetingDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydMeetingDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydMeetingDayStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydMeetingDayStatisticalDataResponse(),
            self.do_roarequest('QueryYydMeetingDayStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydMeetingDayDatas', 'json', req, runtime)
        )

    async def query_yyd_meeting_day_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydMeetingDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydMeetingDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydMeetingDayStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydMeetingDayStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydMeetingDayStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydMeetingDayDatas', 'json', req, runtime)
        )

    def query_yyd_meeting_month_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydMeetingMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydMeetingMonthStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydMeetingMonthStatisticalDataHeaders()
        return self.query_yyd_meeting_month_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_meeting_month_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydMeetingMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydMeetingMonthStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydMeetingMonthStatisticalDataHeaders()
        return await self.query_yyd_meeting_month_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_meeting_month_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydMeetingMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydMeetingMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydMeetingMonthStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydMeetingMonthStatisticalDataResponse(),
            self.do_roarequest('QueryYydMeetingMonthStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydMeetingMonthDatas', 'json', req, runtime)
        )

    async def query_yyd_meeting_month_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydMeetingMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydMeetingMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydMeetingMonthStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydMeetingMonthStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydMeetingMonthStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydMeetingMonthDatas', 'json', req, runtime)
        )

    def query_yyd_meeting_week_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydMeetingWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydMeetingWeekStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydMeetingWeekStatisticalDataHeaders()
        return self.query_yyd_meeting_week_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_meeting_week_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydMeetingWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydMeetingWeekStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydMeetingWeekStatisticalDataHeaders()
        return await self.query_yyd_meeting_week_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_meeting_week_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydMeetingWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydMeetingWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydMeetingWeekStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydMeetingWeekStatisticalDataResponse(),
            self.do_roarequest('QueryYydMeetingWeekStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydMeetingWeekDatas', 'json', req, runtime)
        )

    async def query_yyd_meeting_week_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydMeetingWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydMeetingWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydMeetingWeekStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydMeetingWeekStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydMeetingWeekStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydMeetingWeekDatas', 'json', req, runtime)
        )

    def query_yyd_notice_day_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydNoticeDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydNoticeDayStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydNoticeDayStatisticalDataHeaders()
        return self.query_yyd_notice_day_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_notice_day_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydNoticeDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydNoticeDayStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydNoticeDayStatisticalDataHeaders()
        return await self.query_yyd_notice_day_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_notice_day_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydNoticeDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydNoticeDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydNoticeDayStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydNoticeDayStatisticalDataResponse(),
            self.do_roarequest('QueryYydNoticeDayStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydNoticeDayDatas', 'json', req, runtime)
        )

    async def query_yyd_notice_day_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydNoticeDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydNoticeDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydNoticeDayStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydNoticeDayStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydNoticeDayStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydNoticeDayDatas', 'json', req, runtime)
        )

    def query_yyd_notice_month_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydNoticeMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydNoticeMonthStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydNoticeMonthStatisticalDataHeaders()
        return self.query_yyd_notice_month_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_notice_month_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydNoticeMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydNoticeMonthStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydNoticeMonthStatisticalDataHeaders()
        return await self.query_yyd_notice_month_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_notice_month_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydNoticeMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydNoticeMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydNoticeMonthStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydNoticeMonthStatisticalDataResponse(),
            self.do_roarequest('QueryYydNoticeMonthStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydNoticeMonthDatas', 'json', req, runtime)
        )

    async def query_yyd_notice_month_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydNoticeMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydNoticeMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydNoticeMonthStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydNoticeMonthStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydNoticeMonthStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydNoticeMonthDatas', 'json', req, runtime)
        )

    def query_yyd_notice_week_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydNoticeWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydNoticeWeekStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydNoticeWeekStatisticalDataHeaders()
        return self.query_yyd_notice_week_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_notice_week_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydNoticeWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydNoticeWeekStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydNoticeWeekStatisticalDataHeaders()
        return await self.query_yyd_notice_week_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_notice_week_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydNoticeWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydNoticeWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydNoticeWeekStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydNoticeWeekStatisticalDataResponse(),
            self.do_roarequest('QueryYydNoticeWeekStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydNoticeWeekDatas', 'json', req, runtime)
        )

    async def query_yyd_notice_week_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydNoticeWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydNoticeWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydNoticeWeekStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydNoticeWeekStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydNoticeWeekStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydNoticeWeekDatas', 'json', req, runtime)
        )

    def query_yyd_single_msg_day_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydSingleMsgDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydSingleMsgDayStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydSingleMsgDayStatisticalDataHeaders()
        return self.query_yyd_single_msg_day_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_single_msg_day_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydSingleMsgDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydSingleMsgDayStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydSingleMsgDayStatisticalDataHeaders()
        return await self.query_yyd_single_msg_day_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_single_msg_day_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydSingleMsgDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydSingleMsgDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydSingleMsgDayStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydSingleMsgDayStatisticalDataResponse(),
            self.do_roarequest('QueryYydSingleMsgDayStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydSingleMsgDayDatas', 'json', req, runtime)
        )

    async def query_yyd_single_msg_day_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydSingleMsgDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydSingleMsgDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydSingleMsgDayStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydSingleMsgDayStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydSingleMsgDayStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydSingleMsgDayDatas', 'json', req, runtime)
        )

    def query_yyd_single_msg_month_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydSingleMsgMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydSingleMsgMonthStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydSingleMsgMonthStatisticalDataHeaders()
        return self.query_yyd_single_msg_month_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_single_msg_month_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydSingleMsgMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydSingleMsgMonthStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydSingleMsgMonthStatisticalDataHeaders()
        return await self.query_yyd_single_msg_month_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_single_msg_month_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydSingleMsgMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydSingleMsgMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydSingleMsgMonthStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydSingleMsgMonthStatisticalDataResponse(),
            self.do_roarequest('QueryYydSingleMsgMonthStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydSingleMsgMonthDatas', 'json', req, runtime)
        )

    async def query_yyd_single_msg_month_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydSingleMsgMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydSingleMsgMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydSingleMsgMonthStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydSingleMsgMonthStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydSingleMsgMonthStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydSingleMsgMonthDatas', 'json', req, runtime)
        )

    def query_yyd_single_msg_week_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydSingleMsgWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydSingleMsgWeekStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydSingleMsgWeekStatisticalDataHeaders()
        return self.query_yyd_single_msg_week_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_single_msg_week_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydSingleMsgWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydSingleMsgWeekStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydSingleMsgWeekStatisticalDataHeaders()
        return await self.query_yyd_single_msg_week_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_single_msg_week_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydSingleMsgWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydSingleMsgWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydSingleMsgWeekStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydSingleMsgWeekStatisticalDataResponse(),
            self.do_roarequest('QueryYydSingleMsgWeekStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydSingleMsgWeekDatas', 'json', req, runtime)
        )

    async def query_yyd_single_msg_week_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydSingleMsgWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydSingleMsgWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydSingleMsgWeekStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydSingleMsgWeekStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydSingleMsgWeekStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydSingleMsgWeekDatas', 'json', req, runtime)
        )

    def query_yyd_toatl_msg_day_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydToatlMsgDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydToatlMsgDayStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydToatlMsgDayStatisticalDataHeaders()
        return self.query_yyd_toatl_msg_day_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_toatl_msg_day_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydToatlMsgDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydToatlMsgDayStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydToatlMsgDayStatisticalDataHeaders()
        return await self.query_yyd_toatl_msg_day_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_toatl_msg_day_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydToatlMsgDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydToatlMsgDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydToatlMsgDayStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydToatlMsgDayStatisticalDataResponse(),
            self.do_roarequest('QueryYydToatlMsgDayStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydToatlMsgDayDatas', 'json', req, runtime)
        )

    async def query_yyd_toatl_msg_day_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydToatlMsgDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydToatlMsgDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydToatlMsgDayStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydToatlMsgDayStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydToatlMsgDayStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydToatlMsgDayDatas', 'json', req, runtime)
        )

    def query_yyd_toatl_msg_month_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydToatlMsgMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydToatlMsgMonthStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydToatlMsgMonthStatisticalDataHeaders()
        return self.query_yyd_toatl_msg_month_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_toatl_msg_month_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydToatlMsgMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydToatlMsgMonthStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydToatlMsgMonthStatisticalDataHeaders()
        return await self.query_yyd_toatl_msg_month_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_toatl_msg_month_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydToatlMsgMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydToatlMsgMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydToatlMsgMonthStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydToatlMsgMonthStatisticalDataResponse(),
            self.do_roarequest('QueryYydToatlMsgMonthStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydToatlMsgMonthDatas', 'json', req, runtime)
        )

    async def query_yyd_toatl_msg_month_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydToatlMsgMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydToatlMsgMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydToatlMsgMonthStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydToatlMsgMonthStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydToatlMsgMonthStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydToatlMsgMonthDatas', 'json', req, runtime)
        )

    def query_yyd_toatl_msg_week_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydToatlMsgWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydToatlMsgWeekStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydToatlMsgWeekStatisticalDataHeaders()
        return self.query_yyd_toatl_msg_week_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_toatl_msg_week_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydToatlMsgWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydToatlMsgWeekStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydToatlMsgWeekStatisticalDataHeaders()
        return await self.query_yyd_toatl_msg_week_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_toatl_msg_week_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydToatlMsgWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydToatlMsgWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydToatlMsgWeekStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydToatlMsgWeekStatisticalDataResponse(),
            self.do_roarequest('QueryYydToatlMsgWeekStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydToatlMsgWeekDatas', 'json', req, runtime)
        )

    async def query_yyd_toatl_msg_week_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydToatlMsgWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydToatlMsgWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydToatlMsgWeekStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydToatlMsgWeekStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydToatlMsgWeekStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydToatlMsgWeekDatas', 'json', req, runtime)
        )

    def query_yyd_todo_day_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTodoDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTodoDayStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydTodoDayStatisticalDataHeaders()
        return self.query_yyd_todo_day_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_todo_day_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTodoDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTodoDayStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydTodoDayStatisticalDataHeaders()
        return await self.query_yyd_todo_day_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_todo_day_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTodoDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydTodoDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTodoDayStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydTodoDayStatisticalDataResponse(),
            self.do_roarequest('QueryYydTodoDayStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydTodoDayDatas', 'json', req, runtime)
        )

    async def query_yyd_todo_day_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTodoDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydTodoDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTodoDayStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydTodoDayStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydTodoDayStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydTodoDayDatas', 'json', req, runtime)
        )

    def query_yyd_todo_month_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTodoMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTodoMonthStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydTodoMonthStatisticalDataHeaders()
        return self.query_yyd_todo_month_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_todo_month_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTodoMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTodoMonthStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydTodoMonthStatisticalDataHeaders()
        return await self.query_yyd_todo_month_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_todo_month_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTodoMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydTodoMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTodoMonthStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydTodoMonthStatisticalDataResponse(),
            self.do_roarequest('QueryYydTodoMonthStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydTodoMonthDatas', 'json', req, runtime)
        )

    async def query_yyd_todo_month_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTodoMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydTodoMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTodoMonthStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydTodoMonthStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydTodoMonthStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydTodoMonthDatas', 'json', req, runtime)
        )

    def query_yyd_todo_week_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTodoWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTodoWeekStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydTodoWeekStatisticalDataHeaders()
        return self.query_yyd_todo_week_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_todo_week_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTodoWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTodoWeekStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydTodoWeekStatisticalDataHeaders()
        return await self.query_yyd_todo_week_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_todo_week_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTodoWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydTodoWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTodoWeekStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydTodoWeekStatisticalDataResponse(),
            self.do_roarequest('QueryYydTodoWeekStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydTodoWeekDatas', 'json', req, runtime)
        )

    async def query_yyd_todo_week_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTodoWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydTodoWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTodoWeekStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydTodoWeekStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydTodoWeekStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydTodoWeekDatas', 'json', req, runtime)
        )

    def query_yyd_total_day_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalDayStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydTotalDayStatisticalDataHeaders()
        return self.query_yyd_total_day_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_total_day_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalDayStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydTotalDayStatisticalDataHeaders()
        return await self.query_yyd_total_day_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_total_day_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydTotalDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalDayStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydTotalDayStatisticalDataResponse(),
            self.do_roarequest('QueryYydTotalDayStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydTotalDayDatas', 'json', req, runtime)
        )

    async def query_yyd_total_day_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydTotalDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalDayStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydTotalDayStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydTotalDayStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydTotalDayDatas', 'json', req, runtime)
        )

    def query_yyd_total_month_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalMonthStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydTotalMonthStatisticalDataHeaders()
        return self.query_yyd_total_month_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_total_month_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalMonthStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydTotalMonthStatisticalDataHeaders()
        return await self.query_yyd_total_month_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_total_month_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydTotalMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalMonthStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydTotalMonthStatisticalDataResponse(),
            self.do_roarequest('QueryYydTotalMonthStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydTotalMonthDatas', 'json', req, runtime)
        )

    async def query_yyd_total_month_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydTotalMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalMonthStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydTotalMonthStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydTotalMonthStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydTotalMonthDatas', 'json', req, runtime)
        )

    def query_yyd_total_std_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalStdStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalStdStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydTotalStdStatisticalDataHeaders()
        return self.query_yyd_total_std_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_total_std_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalStdStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalStdStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydTotalStdStatisticalDataHeaders()
        return await self.query_yyd_total_std_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_total_std_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalStdStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydTotalStdStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalStdStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydTotalStdStatisticalDataResponse(),
            self.do_roarequest('QueryYydTotalStdStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydTotalStdDatas', 'json', req, runtime)
        )

    async def query_yyd_total_std_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalStdStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydTotalStdStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalStdStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydTotalStdStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydTotalStdStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydTotalStdDatas', 'json', req, runtime)
        )

    def query_yyd_total_week_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalWeekStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydTotalWeekStatisticalDataHeaders()
        return self.query_yyd_total_week_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_total_week_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalWeekStatisticalDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydTotalWeekStatisticalDataHeaders()
        return await self.query_yyd_total_week_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_total_week_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydTotalWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalWeekStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydTotalWeekStatisticalDataResponse(),
            self.do_roarequest('QueryYydTotalWeekStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydTotalWeekDatas', 'json', req, runtime)
        )

    async def query_yyd_total_week_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydTotalWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalWeekStatisticalDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            dingtalkdatacenter__1__0_models.QueryYydTotalWeekStatisticalDataResponse(),
            await self.do_roarequest_async('QueryYydTotalWeekStatisticalData', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/yydTotalWeekDatas', 'json', req, runtime)
        )

    def search_company(
        self,
        request: dingtalkdatacenter__1__0_models.SearchCompanyRequest,
    ) -> dingtalkdatacenter__1__0_models.SearchCompanyResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.SearchCompanyHeaders()
        return self.search_company_with_options(request, headers, runtime)

    async def search_company_async(
        self,
        request: dingtalkdatacenter__1__0_models.SearchCompanyRequest,
    ) -> dingtalkdatacenter__1__0_models.SearchCompanyResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.SearchCompanyHeaders()
        return await self.search_company_with_options_async(request, headers, runtime)

    def search_company_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.SearchCompanyRequest,
        headers: dingtalkdatacenter__1__0_models.SearchCompanyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.SearchCompanyResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            dingtalkdatacenter__1__0_models.SearchCompanyResponse(),
            self.do_roarequest('SearchCompany', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/keywords/companies', 'json', req, runtime)
        )

    async def search_company_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.SearchCompanyRequest,
        headers: dingtalkdatacenter__1__0_models.SearchCompanyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.SearchCompanyResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            dingtalkdatacenter__1__0_models.SearchCompanyResponse(),
            await self.do_roarequest_async('SearchCompany', 'datacenter_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/datacenter/keywords/companies', 'json', req, runtime)
        )
