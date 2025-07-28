# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.amdp_1_0 import models as dingtalkamdp__1__0_models
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

    def amdp_emp_role_data_push_with_options(
        self,
        request: dingtalkamdp__1__0_models.AmdpEmpRoleDataPushRequest,
        headers: dingtalkamdp__1__0_models.AmdpEmpRoleDataPushHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkamdp__1__0_models.AmdpEmpRoleDataPushResponse:
        """
        @summary 人员角色数据推送
        
        @param request: AmdpEmpRoleDataPushRequest
        @param headers: AmdpEmpRoleDataPushHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AmdpEmpRoleDataPushResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
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
            action='AmdpEmpRoleDataPush',
            version='amdp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/amdp/employeeRoles/datas/push',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkamdp__1__0_models.AmdpEmpRoleDataPushResponse(),
            self.execute(params, req, runtime)
        )

    async def amdp_emp_role_data_push_with_options_async(
        self,
        request: dingtalkamdp__1__0_models.AmdpEmpRoleDataPushRequest,
        headers: dingtalkamdp__1__0_models.AmdpEmpRoleDataPushHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkamdp__1__0_models.AmdpEmpRoleDataPushResponse:
        """
        @summary 人员角色数据推送
        
        @param request: AmdpEmpRoleDataPushRequest
        @param headers: AmdpEmpRoleDataPushHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AmdpEmpRoleDataPushResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
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
            action='AmdpEmpRoleDataPush',
            version='amdp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/amdp/employeeRoles/datas/push',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkamdp__1__0_models.AmdpEmpRoleDataPushResponse(),
            await self.execute_async(params, req, runtime)
        )

    def amdp_emp_role_data_push(
        self,
        request: dingtalkamdp__1__0_models.AmdpEmpRoleDataPushRequest,
    ) -> dingtalkamdp__1__0_models.AmdpEmpRoleDataPushResponse:
        """
        @summary 人员角色数据推送
        
        @param request: AmdpEmpRoleDataPushRequest
        @return: AmdpEmpRoleDataPushResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkamdp__1__0_models.AmdpEmpRoleDataPushHeaders()
        return self.amdp_emp_role_data_push_with_options(request, headers, runtime)

    async def amdp_emp_role_data_push_async(
        self,
        request: dingtalkamdp__1__0_models.AmdpEmpRoleDataPushRequest,
    ) -> dingtalkamdp__1__0_models.AmdpEmpRoleDataPushResponse:
        """
        @summary 人员角色数据推送
        
        @param request: AmdpEmpRoleDataPushRequest
        @return: AmdpEmpRoleDataPushResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkamdp__1__0_models.AmdpEmpRoleDataPushHeaders()
        return await self.amdp_emp_role_data_push_with_options_async(request, headers, runtime)

    def amdp_employee_data_push_with_options(
        self,
        request: dingtalkamdp__1__0_models.AmdpEmployeeDataPushRequest,
        headers: dingtalkamdp__1__0_models.AmdpEmployeeDataPushHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkamdp__1__0_models.AmdpEmployeeDataPushResponse:
        """
        @summary 人员数据推送
        
        @param request: AmdpEmployeeDataPushRequest
        @param headers: AmdpEmployeeDataPushHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AmdpEmployeeDataPushResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
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
            action='AmdpEmployeeDataPush',
            version='amdp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/amdp/employees/datas/push',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkamdp__1__0_models.AmdpEmployeeDataPushResponse(),
            self.execute(params, req, runtime)
        )

    async def amdp_employee_data_push_with_options_async(
        self,
        request: dingtalkamdp__1__0_models.AmdpEmployeeDataPushRequest,
        headers: dingtalkamdp__1__0_models.AmdpEmployeeDataPushHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkamdp__1__0_models.AmdpEmployeeDataPushResponse:
        """
        @summary 人员数据推送
        
        @param request: AmdpEmployeeDataPushRequest
        @param headers: AmdpEmployeeDataPushHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AmdpEmployeeDataPushResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
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
            action='AmdpEmployeeDataPush',
            version='amdp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/amdp/employees/datas/push',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkamdp__1__0_models.AmdpEmployeeDataPushResponse(),
            await self.execute_async(params, req, runtime)
        )

    def amdp_employee_data_push(
        self,
        request: dingtalkamdp__1__0_models.AmdpEmployeeDataPushRequest,
    ) -> dingtalkamdp__1__0_models.AmdpEmployeeDataPushResponse:
        """
        @summary 人员数据推送
        
        @param request: AmdpEmployeeDataPushRequest
        @return: AmdpEmployeeDataPushResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkamdp__1__0_models.AmdpEmployeeDataPushHeaders()
        return self.amdp_employee_data_push_with_options(request, headers, runtime)

    async def amdp_employee_data_push_async(
        self,
        request: dingtalkamdp__1__0_models.AmdpEmployeeDataPushRequest,
    ) -> dingtalkamdp__1__0_models.AmdpEmployeeDataPushResponse:
        """
        @summary 人员数据推送
        
        @param request: AmdpEmployeeDataPushRequest
        @return: AmdpEmployeeDataPushResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkamdp__1__0_models.AmdpEmployeeDataPushHeaders()
        return await self.amdp_employee_data_push_with_options_async(request, headers, runtime)

    def amdp_job_position_data_push_with_options(
        self,
        request: dingtalkamdp__1__0_models.AmdpJobPositionDataPushRequest,
        headers: dingtalkamdp__1__0_models.AmdpJobPositionDataPushHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkamdp__1__0_models.AmdpJobPositionDataPushResponse:
        """
        @summary 任职数据推送
        
        @param request: AmdpJobPositionDataPushRequest
        @param headers: AmdpJobPositionDataPushHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AmdpJobPositionDataPushResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
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
            action='AmdpJobPositionDataPush',
            version='amdp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/amdp/empJobs/datas/push',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkamdp__1__0_models.AmdpJobPositionDataPushResponse(),
            self.execute(params, req, runtime)
        )

    async def amdp_job_position_data_push_with_options_async(
        self,
        request: dingtalkamdp__1__0_models.AmdpJobPositionDataPushRequest,
        headers: dingtalkamdp__1__0_models.AmdpJobPositionDataPushHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkamdp__1__0_models.AmdpJobPositionDataPushResponse:
        """
        @summary 任职数据推送
        
        @param request: AmdpJobPositionDataPushRequest
        @param headers: AmdpJobPositionDataPushHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AmdpJobPositionDataPushResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
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
            action='AmdpJobPositionDataPush',
            version='amdp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/amdp/empJobs/datas/push',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkamdp__1__0_models.AmdpJobPositionDataPushResponse(),
            await self.execute_async(params, req, runtime)
        )

    def amdp_job_position_data_push(
        self,
        request: dingtalkamdp__1__0_models.AmdpJobPositionDataPushRequest,
    ) -> dingtalkamdp__1__0_models.AmdpJobPositionDataPushResponse:
        """
        @summary 任职数据推送
        
        @param request: AmdpJobPositionDataPushRequest
        @return: AmdpJobPositionDataPushResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkamdp__1__0_models.AmdpJobPositionDataPushHeaders()
        return self.amdp_job_position_data_push_with_options(request, headers, runtime)

    async def amdp_job_position_data_push_async(
        self,
        request: dingtalkamdp__1__0_models.AmdpJobPositionDataPushRequest,
    ) -> dingtalkamdp__1__0_models.AmdpJobPositionDataPushResponse:
        """
        @summary 任职数据推送
        
        @param request: AmdpJobPositionDataPushRequest
        @return: AmdpJobPositionDataPushResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkamdp__1__0_models.AmdpJobPositionDataPushHeaders()
        return await self.amdp_job_position_data_push_with_options_async(request, headers, runtime)

    def amdp_organization_data_push_with_options(
        self,
        request: dingtalkamdp__1__0_models.AmdpOrganizationDataPushRequest,
        headers: dingtalkamdp__1__0_models.AmdpOrganizationDataPushHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkamdp__1__0_models.AmdpOrganizationDataPushResponse:
        """
        @summary 组织部门数据推送
        
        @param request: AmdpOrganizationDataPushRequest
        @param headers: AmdpOrganizationDataPushHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AmdpOrganizationDataPushResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
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
            action='AmdpOrganizationDataPush',
            version='amdp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/amdp/organizations/departments/datas/push',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkamdp__1__0_models.AmdpOrganizationDataPushResponse(),
            self.execute(params, req, runtime)
        )

    async def amdp_organization_data_push_with_options_async(
        self,
        request: dingtalkamdp__1__0_models.AmdpOrganizationDataPushRequest,
        headers: dingtalkamdp__1__0_models.AmdpOrganizationDataPushHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkamdp__1__0_models.AmdpOrganizationDataPushResponse:
        """
        @summary 组织部门数据推送
        
        @param request: AmdpOrganizationDataPushRequest
        @param headers: AmdpOrganizationDataPushHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AmdpOrganizationDataPushResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
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
            action='AmdpOrganizationDataPush',
            version='amdp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/amdp/organizations/departments/datas/push',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkamdp__1__0_models.AmdpOrganizationDataPushResponse(),
            await self.execute_async(params, req, runtime)
        )

    def amdp_organization_data_push(
        self,
        request: dingtalkamdp__1__0_models.AmdpOrganizationDataPushRequest,
    ) -> dingtalkamdp__1__0_models.AmdpOrganizationDataPushResponse:
        """
        @summary 组织部门数据推送
        
        @param request: AmdpOrganizationDataPushRequest
        @return: AmdpOrganizationDataPushResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkamdp__1__0_models.AmdpOrganizationDataPushHeaders()
        return self.amdp_organization_data_push_with_options(request, headers, runtime)

    async def amdp_organization_data_push_async(
        self,
        request: dingtalkamdp__1__0_models.AmdpOrganizationDataPushRequest,
    ) -> dingtalkamdp__1__0_models.AmdpOrganizationDataPushResponse:
        """
        @summary 组织部门数据推送
        
        @param request: AmdpOrganizationDataPushRequest
        @return: AmdpOrganizationDataPushResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkamdp__1__0_models.AmdpOrganizationDataPushHeaders()
        return await self.amdp_organization_data_push_with_options_async(request, headers, runtime)
