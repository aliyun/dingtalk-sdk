# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.carbon_1_0 import models as dingtalkcarbon__1__0_models
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

    def get_personal_carbon_info_with_options(
        self,
        request: dingtalkcarbon__1__0_models.GetPersonalCarbonInfoRequest,
        headers: dingtalkcarbon__1__0_models.GetPersonalCarbonInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcarbon__1__0_models.GetPersonalCarbonInfoResponse:
        """
        @summary 获取用户的减碳明细
        
        @param request: GetPersonalCarbonInfoRequest
        @param headers: GetPersonalCarbonInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPersonalCarbonInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.action_type):
            query['actionType'] = request.action_type
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='GetPersonalCarbonInfo',
            version='carbon_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/carbon/personals/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcarbon__1__0_models.GetPersonalCarbonInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_personal_carbon_info_with_options_async(
        self,
        request: dingtalkcarbon__1__0_models.GetPersonalCarbonInfoRequest,
        headers: dingtalkcarbon__1__0_models.GetPersonalCarbonInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcarbon__1__0_models.GetPersonalCarbonInfoResponse:
        """
        @summary 获取用户的减碳明细
        
        @param request: GetPersonalCarbonInfoRequest
        @param headers: GetPersonalCarbonInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPersonalCarbonInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.action_type):
            query['actionType'] = request.action_type
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='GetPersonalCarbonInfo',
            version='carbon_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/carbon/personals/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcarbon__1__0_models.GetPersonalCarbonInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_personal_carbon_info(
        self,
        request: dingtalkcarbon__1__0_models.GetPersonalCarbonInfoRequest,
    ) -> dingtalkcarbon__1__0_models.GetPersonalCarbonInfoResponse:
        """
        @summary 获取用户的减碳明细
        
        @param request: GetPersonalCarbonInfoRequest
        @return: GetPersonalCarbonInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcarbon__1__0_models.GetPersonalCarbonInfoHeaders()
        return self.get_personal_carbon_info_with_options(request, headers, runtime)

    async def get_personal_carbon_info_async(
        self,
        request: dingtalkcarbon__1__0_models.GetPersonalCarbonInfoRequest,
    ) -> dingtalkcarbon__1__0_models.GetPersonalCarbonInfoResponse:
        """
        @summary 获取用户的减碳明细
        
        @param request: GetPersonalCarbonInfoRequest
        @return: GetPersonalCarbonInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcarbon__1__0_models.GetPersonalCarbonInfoHeaders()
        return await self.get_personal_carbon_info_with_options_async(request, headers, runtime)

    def write_alibaba_org_carbon_with_options(
        self,
        request: dingtalkcarbon__1__0_models.WriteAlibabaOrgCarbonRequest,
        headers: dingtalkcarbon__1__0_models.WriteAlibabaOrgCarbonHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcarbon__1__0_models.WriteAlibabaOrgCarbonResponse:
        """
        @summary 写入阿里巴巴每日组织明细碳能量数据
        
        @param request: WriteAlibabaOrgCarbonRequest
        @param headers: WriteAlibabaOrgCarbonHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: WriteAlibabaOrgCarbonResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.org_details_list):
            body['orgDetailsList'] = request.org_details_list
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
            action='WriteAlibabaOrgCarbon',
            version='carbon_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/carbon/alibabaOrgDetails/write',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcarbon__1__0_models.WriteAlibabaOrgCarbonResponse(),
            self.execute(params, req, runtime)
        )

    async def write_alibaba_org_carbon_with_options_async(
        self,
        request: dingtalkcarbon__1__0_models.WriteAlibabaOrgCarbonRequest,
        headers: dingtalkcarbon__1__0_models.WriteAlibabaOrgCarbonHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcarbon__1__0_models.WriteAlibabaOrgCarbonResponse:
        """
        @summary 写入阿里巴巴每日组织明细碳能量数据
        
        @param request: WriteAlibabaOrgCarbonRequest
        @param headers: WriteAlibabaOrgCarbonHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: WriteAlibabaOrgCarbonResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.org_details_list):
            body['orgDetailsList'] = request.org_details_list
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
            action='WriteAlibabaOrgCarbon',
            version='carbon_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/carbon/alibabaOrgDetails/write',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcarbon__1__0_models.WriteAlibabaOrgCarbonResponse(),
            await self.execute_async(params, req, runtime)
        )

    def write_alibaba_org_carbon(
        self,
        request: dingtalkcarbon__1__0_models.WriteAlibabaOrgCarbonRequest,
    ) -> dingtalkcarbon__1__0_models.WriteAlibabaOrgCarbonResponse:
        """
        @summary 写入阿里巴巴每日组织明细碳能量数据
        
        @param request: WriteAlibabaOrgCarbonRequest
        @return: WriteAlibabaOrgCarbonResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcarbon__1__0_models.WriteAlibabaOrgCarbonHeaders()
        return self.write_alibaba_org_carbon_with_options(request, headers, runtime)

    async def write_alibaba_org_carbon_async(
        self,
        request: dingtalkcarbon__1__0_models.WriteAlibabaOrgCarbonRequest,
    ) -> dingtalkcarbon__1__0_models.WriteAlibabaOrgCarbonResponse:
        """
        @summary 写入阿里巴巴每日组织明细碳能量数据
        
        @param request: WriteAlibabaOrgCarbonRequest
        @return: WriteAlibabaOrgCarbonResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcarbon__1__0_models.WriteAlibabaOrgCarbonHeaders()
        return await self.write_alibaba_org_carbon_with_options_async(request, headers, runtime)

    def write_alibaba_user_carbon_with_options(
        self,
        request: dingtalkcarbon__1__0_models.WriteAlibabaUserCarbonRequest,
        headers: dingtalkcarbon__1__0_models.WriteAlibabaUserCarbonHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcarbon__1__0_models.WriteAlibabaUserCarbonResponse:
        """
        @summary 写入阿里巴巴每日用户碳能量数据
        
        @param request: WriteAlibabaUserCarbonRequest
        @param headers: WriteAlibabaUserCarbonHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: WriteAlibabaUserCarbonResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.user_details_list):
            body['userDetailsList'] = request.user_details_list
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
            action='WriteAlibabaUserCarbon',
            version='carbon_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/carbon/alibabaUserDetails/write',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcarbon__1__0_models.WriteAlibabaUserCarbonResponse(),
            self.execute(params, req, runtime)
        )

    async def write_alibaba_user_carbon_with_options_async(
        self,
        request: dingtalkcarbon__1__0_models.WriteAlibabaUserCarbonRequest,
        headers: dingtalkcarbon__1__0_models.WriteAlibabaUserCarbonHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcarbon__1__0_models.WriteAlibabaUserCarbonResponse:
        """
        @summary 写入阿里巴巴每日用户碳能量数据
        
        @param request: WriteAlibabaUserCarbonRequest
        @param headers: WriteAlibabaUserCarbonHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: WriteAlibabaUserCarbonResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.user_details_list):
            body['userDetailsList'] = request.user_details_list
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
            action='WriteAlibabaUserCarbon',
            version='carbon_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/carbon/alibabaUserDetails/write',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcarbon__1__0_models.WriteAlibabaUserCarbonResponse(),
            await self.execute_async(params, req, runtime)
        )

    def write_alibaba_user_carbon(
        self,
        request: dingtalkcarbon__1__0_models.WriteAlibabaUserCarbonRequest,
    ) -> dingtalkcarbon__1__0_models.WriteAlibabaUserCarbonResponse:
        """
        @summary 写入阿里巴巴每日用户碳能量数据
        
        @param request: WriteAlibabaUserCarbonRequest
        @return: WriteAlibabaUserCarbonResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcarbon__1__0_models.WriteAlibabaUserCarbonHeaders()
        return self.write_alibaba_user_carbon_with_options(request, headers, runtime)

    async def write_alibaba_user_carbon_async(
        self,
        request: dingtalkcarbon__1__0_models.WriteAlibabaUserCarbonRequest,
    ) -> dingtalkcarbon__1__0_models.WriteAlibabaUserCarbonResponse:
        """
        @summary 写入阿里巴巴每日用户碳能量数据
        
        @param request: WriteAlibabaUserCarbonRequest
        @return: WriteAlibabaUserCarbonResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcarbon__1__0_models.WriteAlibabaUserCarbonHeaders()
        return await self.write_alibaba_user_carbon_with_options_async(request, headers, runtime)

    def write_isv_state_with_options(
        self,
        request: dingtalkcarbon__1__0_models.WriteIsvStateRequest,
        headers: dingtalkcarbon__1__0_models.WriteIsvStateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcarbon__1__0_models.WriteIsvStateResponse:
        """
        @summary ISV记录数据传输当前状态
        
        @param request: WriteIsvStateRequest
        @param headers: WriteIsvStateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: WriteIsvStateResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.isv_name):
            query['isvName'] = request.isv_name
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
        params = open_api_models.Params(
            action='WriteIsvState',
            version='carbon_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/carbon/datas/states/write',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcarbon__1__0_models.WriteIsvStateResponse(),
            self.execute(params, req, runtime)
        )

    async def write_isv_state_with_options_async(
        self,
        request: dingtalkcarbon__1__0_models.WriteIsvStateRequest,
        headers: dingtalkcarbon__1__0_models.WriteIsvStateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcarbon__1__0_models.WriteIsvStateResponse:
        """
        @summary ISV记录数据传输当前状态
        
        @param request: WriteIsvStateRequest
        @param headers: WriteIsvStateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: WriteIsvStateResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.isv_name):
            query['isvName'] = request.isv_name
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
        params = open_api_models.Params(
            action='WriteIsvState',
            version='carbon_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/carbon/datas/states/write',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcarbon__1__0_models.WriteIsvStateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def write_isv_state(
        self,
        request: dingtalkcarbon__1__0_models.WriteIsvStateRequest,
    ) -> dingtalkcarbon__1__0_models.WriteIsvStateResponse:
        """
        @summary ISV记录数据传输当前状态
        
        @param request: WriteIsvStateRequest
        @return: WriteIsvStateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcarbon__1__0_models.WriteIsvStateHeaders()
        return self.write_isv_state_with_options(request, headers, runtime)

    async def write_isv_state_async(
        self,
        request: dingtalkcarbon__1__0_models.WriteIsvStateRequest,
    ) -> dingtalkcarbon__1__0_models.WriteIsvStateResponse:
        """
        @summary ISV记录数据传输当前状态
        
        @param request: WriteIsvStateRequest
        @return: WriteIsvStateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcarbon__1__0_models.WriteIsvStateHeaders()
        return await self.write_isv_state_with_options_async(request, headers, runtime)

    def write_org_carbon_with_options(
        self,
        request: dingtalkcarbon__1__0_models.WriteOrgCarbonRequest,
        headers: dingtalkcarbon__1__0_models.WriteOrgCarbonHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcarbon__1__0_models.WriteOrgCarbonResponse:
        """
        @summary 写入isv每日组织明细碳能量数据
        
        @param request: WriteOrgCarbonRequest
        @param headers: WriteOrgCarbonHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: WriteOrgCarbonResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.org_details_list):
            body['orgDetailsList'] = request.org_details_list
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
            action='WriteOrgCarbon',
            version='carbon_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/carbon/orgDetails/write',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcarbon__1__0_models.WriteOrgCarbonResponse(),
            self.execute(params, req, runtime)
        )

    async def write_org_carbon_with_options_async(
        self,
        request: dingtalkcarbon__1__0_models.WriteOrgCarbonRequest,
        headers: dingtalkcarbon__1__0_models.WriteOrgCarbonHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcarbon__1__0_models.WriteOrgCarbonResponse:
        """
        @summary 写入isv每日组织明细碳能量数据
        
        @param request: WriteOrgCarbonRequest
        @param headers: WriteOrgCarbonHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: WriteOrgCarbonResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.org_details_list):
            body['orgDetailsList'] = request.org_details_list
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
            action='WriteOrgCarbon',
            version='carbon_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/carbon/orgDetails/write',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcarbon__1__0_models.WriteOrgCarbonResponse(),
            await self.execute_async(params, req, runtime)
        )

    def write_org_carbon(
        self,
        request: dingtalkcarbon__1__0_models.WriteOrgCarbonRequest,
    ) -> dingtalkcarbon__1__0_models.WriteOrgCarbonResponse:
        """
        @summary 写入isv每日组织明细碳能量数据
        
        @param request: WriteOrgCarbonRequest
        @return: WriteOrgCarbonResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcarbon__1__0_models.WriteOrgCarbonHeaders()
        return self.write_org_carbon_with_options(request, headers, runtime)

    async def write_org_carbon_async(
        self,
        request: dingtalkcarbon__1__0_models.WriteOrgCarbonRequest,
    ) -> dingtalkcarbon__1__0_models.WriteOrgCarbonResponse:
        """
        @summary 写入isv每日组织明细碳能量数据
        
        @param request: WriteOrgCarbonRequest
        @return: WriteOrgCarbonResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcarbon__1__0_models.WriteOrgCarbonHeaders()
        return await self.write_org_carbon_with_options_async(request, headers, runtime)

    def write_user_carbon_with_options(
        self,
        request: dingtalkcarbon__1__0_models.WriteUserCarbonRequest,
        headers: dingtalkcarbon__1__0_models.WriteUserCarbonHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcarbon__1__0_models.WriteUserCarbonResponse:
        """
        @summary 写入isv每日用户明细碳能量数据
        
        @param request: WriteUserCarbonRequest
        @param headers: WriteUserCarbonHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: WriteUserCarbonResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.user_details_list):
            body['userDetailsList'] = request.user_details_list
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
            action='WriteUserCarbon',
            version='carbon_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/carbon/userDetails/write',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcarbon__1__0_models.WriteUserCarbonResponse(),
            self.execute(params, req, runtime)
        )

    async def write_user_carbon_with_options_async(
        self,
        request: dingtalkcarbon__1__0_models.WriteUserCarbonRequest,
        headers: dingtalkcarbon__1__0_models.WriteUserCarbonHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcarbon__1__0_models.WriteUserCarbonResponse:
        """
        @summary 写入isv每日用户明细碳能量数据
        
        @param request: WriteUserCarbonRequest
        @param headers: WriteUserCarbonHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: WriteUserCarbonResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.user_details_list):
            body['userDetailsList'] = request.user_details_list
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
            action='WriteUserCarbon',
            version='carbon_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/carbon/userDetails/write',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcarbon__1__0_models.WriteUserCarbonResponse(),
            await self.execute_async(params, req, runtime)
        )

    def write_user_carbon(
        self,
        request: dingtalkcarbon__1__0_models.WriteUserCarbonRequest,
    ) -> dingtalkcarbon__1__0_models.WriteUserCarbonResponse:
        """
        @summary 写入isv每日用户明细碳能量数据
        
        @param request: WriteUserCarbonRequest
        @return: WriteUserCarbonResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcarbon__1__0_models.WriteUserCarbonHeaders()
        return self.write_user_carbon_with_options(request, headers, runtime)

    async def write_user_carbon_async(
        self,
        request: dingtalkcarbon__1__0_models.WriteUserCarbonRequest,
    ) -> dingtalkcarbon__1__0_models.WriteUserCarbonResponse:
        """
        @summary 写入isv每日用户明细碳能量数据
        
        @param request: WriteUserCarbonRequest
        @return: WriteUserCarbonResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcarbon__1__0_models.WriteUserCarbonHeaders()
        return await self.write_user_carbon_with_options_async(request, headers, runtime)

    def write_user_carbon_energy_with_options(
        self,
        request: dingtalkcarbon__1__0_models.WriteUserCarbonEnergyRequest,
        headers: dingtalkcarbon__1__0_models.WriteUserCarbonEnergyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcarbon__1__0_models.WriteUserCarbonEnergyResponse:
        """
        @summary 写入isv能耗每日用户明细碳能量数据
        
        @param request: WriteUserCarbonEnergyRequest
        @param headers: WriteUserCarbonEnergyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: WriteUserCarbonEnergyResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.user_details_list):
            body['userDetailsList'] = request.user_details_list
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
            action='WriteUserCarbonEnergy',
            version='carbon_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/carbon/userDetails/energies/write',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcarbon__1__0_models.WriteUserCarbonEnergyResponse(),
            self.execute(params, req, runtime)
        )

    async def write_user_carbon_energy_with_options_async(
        self,
        request: dingtalkcarbon__1__0_models.WriteUserCarbonEnergyRequest,
        headers: dingtalkcarbon__1__0_models.WriteUserCarbonEnergyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcarbon__1__0_models.WriteUserCarbonEnergyResponse:
        """
        @summary 写入isv能耗每日用户明细碳能量数据
        
        @param request: WriteUserCarbonEnergyRequest
        @param headers: WriteUserCarbonEnergyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: WriteUserCarbonEnergyResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.user_details_list):
            body['userDetailsList'] = request.user_details_list
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
            action='WriteUserCarbonEnergy',
            version='carbon_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/carbon/userDetails/energies/write',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcarbon__1__0_models.WriteUserCarbonEnergyResponse(),
            await self.execute_async(params, req, runtime)
        )

    def write_user_carbon_energy(
        self,
        request: dingtalkcarbon__1__0_models.WriteUserCarbonEnergyRequest,
    ) -> dingtalkcarbon__1__0_models.WriteUserCarbonEnergyResponse:
        """
        @summary 写入isv能耗每日用户明细碳能量数据
        
        @param request: WriteUserCarbonEnergyRequest
        @return: WriteUserCarbonEnergyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcarbon__1__0_models.WriteUserCarbonEnergyHeaders()
        return self.write_user_carbon_energy_with_options(request, headers, runtime)

    async def write_user_carbon_energy_async(
        self,
        request: dingtalkcarbon__1__0_models.WriteUserCarbonEnergyRequest,
    ) -> dingtalkcarbon__1__0_models.WriteUserCarbonEnergyResponse:
        """
        @summary 写入isv能耗每日用户明细碳能量数据
        
        @param request: WriteUserCarbonEnergyRequest
        @return: WriteUserCarbonEnergyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcarbon__1__0_models.WriteUserCarbonEnergyHeaders()
        return await self.write_user_carbon_energy_with_options_async(request, headers, runtime)
