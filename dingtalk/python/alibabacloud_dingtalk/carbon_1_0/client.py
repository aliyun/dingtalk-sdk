# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
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
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def get_personal_carbon_info(
        self,
        request: dingtalkcarbon__1__0_models.GetPersonalCarbonInfoRequest,
    ) -> dingtalkcarbon__1__0_models.GetPersonalCarbonInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcarbon__1__0_models.GetPersonalCarbonInfoHeaders()
        return self.get_personal_carbon_info_with_options(request, headers, runtime)

    async def get_personal_carbon_info_async(
        self,
        request: dingtalkcarbon__1__0_models.GetPersonalCarbonInfoRequest,
    ) -> dingtalkcarbon__1__0_models.GetPersonalCarbonInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcarbon__1__0_models.GetPersonalCarbonInfoHeaders()
        return await self.get_personal_carbon_info_with_options_async(request, headers, runtime)

    def get_personal_carbon_info_with_options(
        self,
        request: dingtalkcarbon__1__0_models.GetPersonalCarbonInfoRequest,
        headers: dingtalkcarbon__1__0_models.GetPersonalCarbonInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcarbon__1__0_models.GetPersonalCarbonInfoResponse:
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
        return TeaCore.from_map(
            dingtalkcarbon__1__0_models.GetPersonalCarbonInfoResponse(),
            self.do_roarequest('GetPersonalCarbonInfo', 'carbon_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/carbon/personals/infos', 'json', req, runtime)
        )

    async def get_personal_carbon_info_with_options_async(
        self,
        request: dingtalkcarbon__1__0_models.GetPersonalCarbonInfoRequest,
        headers: dingtalkcarbon__1__0_models.GetPersonalCarbonInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcarbon__1__0_models.GetPersonalCarbonInfoResponse:
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
        return TeaCore.from_map(
            dingtalkcarbon__1__0_models.GetPersonalCarbonInfoResponse(),
            await self.do_roarequest_async('GetPersonalCarbonInfo', 'carbon_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/carbon/personals/infos', 'json', req, runtime)
        )

    def write_alibaba_org_carbon(
        self,
        request: dingtalkcarbon__1__0_models.WriteAlibabaOrgCarbonRequest,
    ) -> dingtalkcarbon__1__0_models.WriteAlibabaOrgCarbonResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcarbon__1__0_models.WriteAlibabaOrgCarbonHeaders()
        return self.write_alibaba_org_carbon_with_options(request, headers, runtime)

    async def write_alibaba_org_carbon_async(
        self,
        request: dingtalkcarbon__1__0_models.WriteAlibabaOrgCarbonRequest,
    ) -> dingtalkcarbon__1__0_models.WriteAlibabaOrgCarbonResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcarbon__1__0_models.WriteAlibabaOrgCarbonHeaders()
        return await self.write_alibaba_org_carbon_with_options_async(request, headers, runtime)

    def write_alibaba_org_carbon_with_options(
        self,
        request: dingtalkcarbon__1__0_models.WriteAlibabaOrgCarbonRequest,
        headers: dingtalkcarbon__1__0_models.WriteAlibabaOrgCarbonHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcarbon__1__0_models.WriteAlibabaOrgCarbonResponse:
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
        return TeaCore.from_map(
            dingtalkcarbon__1__0_models.WriteAlibabaOrgCarbonResponse(),
            self.do_roarequest('WriteAlibabaOrgCarbon', 'carbon_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/carbon/alibabaOrgDetails/write', 'json', req, runtime)
        )

    async def write_alibaba_org_carbon_with_options_async(
        self,
        request: dingtalkcarbon__1__0_models.WriteAlibabaOrgCarbonRequest,
        headers: dingtalkcarbon__1__0_models.WriteAlibabaOrgCarbonHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcarbon__1__0_models.WriteAlibabaOrgCarbonResponse:
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
        return TeaCore.from_map(
            dingtalkcarbon__1__0_models.WriteAlibabaOrgCarbonResponse(),
            await self.do_roarequest_async('WriteAlibabaOrgCarbon', 'carbon_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/carbon/alibabaOrgDetails/write', 'json', req, runtime)
        )

    def write_alibaba_user_carbon(
        self,
        request: dingtalkcarbon__1__0_models.WriteAlibabaUserCarbonRequest,
    ) -> dingtalkcarbon__1__0_models.WriteAlibabaUserCarbonResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcarbon__1__0_models.WriteAlibabaUserCarbonHeaders()
        return self.write_alibaba_user_carbon_with_options(request, headers, runtime)

    async def write_alibaba_user_carbon_async(
        self,
        request: dingtalkcarbon__1__0_models.WriteAlibabaUserCarbonRequest,
    ) -> dingtalkcarbon__1__0_models.WriteAlibabaUserCarbonResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcarbon__1__0_models.WriteAlibabaUserCarbonHeaders()
        return await self.write_alibaba_user_carbon_with_options_async(request, headers, runtime)

    def write_alibaba_user_carbon_with_options(
        self,
        request: dingtalkcarbon__1__0_models.WriteAlibabaUserCarbonRequest,
        headers: dingtalkcarbon__1__0_models.WriteAlibabaUserCarbonHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcarbon__1__0_models.WriteAlibabaUserCarbonResponse:
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
        return TeaCore.from_map(
            dingtalkcarbon__1__0_models.WriteAlibabaUserCarbonResponse(),
            self.do_roarequest('WriteAlibabaUserCarbon', 'carbon_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/carbon/alibabaUserDetails/write', 'json', req, runtime)
        )

    async def write_alibaba_user_carbon_with_options_async(
        self,
        request: dingtalkcarbon__1__0_models.WriteAlibabaUserCarbonRequest,
        headers: dingtalkcarbon__1__0_models.WriteAlibabaUserCarbonHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcarbon__1__0_models.WriteAlibabaUserCarbonResponse:
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
        return TeaCore.from_map(
            dingtalkcarbon__1__0_models.WriteAlibabaUserCarbonResponse(),
            await self.do_roarequest_async('WriteAlibabaUserCarbon', 'carbon_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/carbon/alibabaUserDetails/write', 'json', req, runtime)
        )

    def write_isv_state(
        self,
        request: dingtalkcarbon__1__0_models.WriteIsvStateRequest,
    ) -> dingtalkcarbon__1__0_models.WriteIsvStateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcarbon__1__0_models.WriteIsvStateHeaders()
        return self.write_isv_state_with_options(request, headers, runtime)

    async def write_isv_state_async(
        self,
        request: dingtalkcarbon__1__0_models.WriteIsvStateRequest,
    ) -> dingtalkcarbon__1__0_models.WriteIsvStateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcarbon__1__0_models.WriteIsvStateHeaders()
        return await self.write_isv_state_with_options_async(request, headers, runtime)

    def write_isv_state_with_options(
        self,
        request: dingtalkcarbon__1__0_models.WriteIsvStateRequest,
        headers: dingtalkcarbon__1__0_models.WriteIsvStateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcarbon__1__0_models.WriteIsvStateResponse:
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
        return TeaCore.from_map(
            dingtalkcarbon__1__0_models.WriteIsvStateResponse(),
            self.do_roarequest('WriteIsvState', 'carbon_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/carbon/datas/states/write', 'json', req, runtime)
        )

    async def write_isv_state_with_options_async(
        self,
        request: dingtalkcarbon__1__0_models.WriteIsvStateRequest,
        headers: dingtalkcarbon__1__0_models.WriteIsvStateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcarbon__1__0_models.WriteIsvStateResponse:
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
        return TeaCore.from_map(
            dingtalkcarbon__1__0_models.WriteIsvStateResponse(),
            await self.do_roarequest_async('WriteIsvState', 'carbon_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/carbon/datas/states/write', 'json', req, runtime)
        )

    def write_org_carbon(
        self,
        request: dingtalkcarbon__1__0_models.WriteOrgCarbonRequest,
    ) -> dingtalkcarbon__1__0_models.WriteOrgCarbonResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcarbon__1__0_models.WriteOrgCarbonHeaders()
        return self.write_org_carbon_with_options(request, headers, runtime)

    async def write_org_carbon_async(
        self,
        request: dingtalkcarbon__1__0_models.WriteOrgCarbonRequest,
    ) -> dingtalkcarbon__1__0_models.WriteOrgCarbonResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcarbon__1__0_models.WriteOrgCarbonHeaders()
        return await self.write_org_carbon_with_options_async(request, headers, runtime)

    def write_org_carbon_with_options(
        self,
        request: dingtalkcarbon__1__0_models.WriteOrgCarbonRequest,
        headers: dingtalkcarbon__1__0_models.WriteOrgCarbonHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcarbon__1__0_models.WriteOrgCarbonResponse:
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
        return TeaCore.from_map(
            dingtalkcarbon__1__0_models.WriteOrgCarbonResponse(),
            self.do_roarequest('WriteOrgCarbon', 'carbon_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/carbon/orgDetails/write', 'json', req, runtime)
        )

    async def write_org_carbon_with_options_async(
        self,
        request: dingtalkcarbon__1__0_models.WriteOrgCarbonRequest,
        headers: dingtalkcarbon__1__0_models.WriteOrgCarbonHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcarbon__1__0_models.WriteOrgCarbonResponse:
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
        return TeaCore.from_map(
            dingtalkcarbon__1__0_models.WriteOrgCarbonResponse(),
            await self.do_roarequest_async('WriteOrgCarbon', 'carbon_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/carbon/orgDetails/write', 'json', req, runtime)
        )

    def write_user_carbon(
        self,
        request: dingtalkcarbon__1__0_models.WriteUserCarbonRequest,
    ) -> dingtalkcarbon__1__0_models.WriteUserCarbonResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcarbon__1__0_models.WriteUserCarbonHeaders()
        return self.write_user_carbon_with_options(request, headers, runtime)

    async def write_user_carbon_async(
        self,
        request: dingtalkcarbon__1__0_models.WriteUserCarbonRequest,
    ) -> dingtalkcarbon__1__0_models.WriteUserCarbonResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcarbon__1__0_models.WriteUserCarbonHeaders()
        return await self.write_user_carbon_with_options_async(request, headers, runtime)

    def write_user_carbon_with_options(
        self,
        request: dingtalkcarbon__1__0_models.WriteUserCarbonRequest,
        headers: dingtalkcarbon__1__0_models.WriteUserCarbonHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcarbon__1__0_models.WriteUserCarbonResponse:
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
        return TeaCore.from_map(
            dingtalkcarbon__1__0_models.WriteUserCarbonResponse(),
            self.do_roarequest('WriteUserCarbon', 'carbon_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/carbon/userDetails/write', 'json', req, runtime)
        )

    async def write_user_carbon_with_options_async(
        self,
        request: dingtalkcarbon__1__0_models.WriteUserCarbonRequest,
        headers: dingtalkcarbon__1__0_models.WriteUserCarbonHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcarbon__1__0_models.WriteUserCarbonResponse:
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
        return TeaCore.from_map(
            dingtalkcarbon__1__0_models.WriteUserCarbonResponse(),
            await self.do_roarequest_async('WriteUserCarbon', 'carbon_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/carbon/userDetails/write', 'json', req, runtime)
        )

    def write_user_carbon_energy(
        self,
        request: dingtalkcarbon__1__0_models.WriteUserCarbonEnergyRequest,
    ) -> dingtalkcarbon__1__0_models.WriteUserCarbonEnergyResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcarbon__1__0_models.WriteUserCarbonEnergyHeaders()
        return self.write_user_carbon_energy_with_options(request, headers, runtime)

    async def write_user_carbon_energy_async(
        self,
        request: dingtalkcarbon__1__0_models.WriteUserCarbonEnergyRequest,
    ) -> dingtalkcarbon__1__0_models.WriteUserCarbonEnergyResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcarbon__1__0_models.WriteUserCarbonEnergyHeaders()
        return await self.write_user_carbon_energy_with_options_async(request, headers, runtime)

    def write_user_carbon_energy_with_options(
        self,
        request: dingtalkcarbon__1__0_models.WriteUserCarbonEnergyRequest,
        headers: dingtalkcarbon__1__0_models.WriteUserCarbonEnergyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcarbon__1__0_models.WriteUserCarbonEnergyResponse:
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
        return TeaCore.from_map(
            dingtalkcarbon__1__0_models.WriteUserCarbonEnergyResponse(),
            self.do_roarequest('WriteUserCarbonEnergy', 'carbon_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/carbon/userDetails/energies/write', 'json', req, runtime)
        )

    async def write_user_carbon_energy_with_options_async(
        self,
        request: dingtalkcarbon__1__0_models.WriteUserCarbonEnergyRequest,
        headers: dingtalkcarbon__1__0_models.WriteUserCarbonEnergyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcarbon__1__0_models.WriteUserCarbonEnergyResponse:
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
        return TeaCore.from_map(
            dingtalkcarbon__1__0_models.WriteUserCarbonEnergyResponse(),
            await self.do_roarequest_async('WriteUserCarbonEnergy', 'carbon_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/carbon/userDetails/energies/write', 'json', req, runtime)
        )
