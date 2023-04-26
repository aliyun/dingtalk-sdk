# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.swform_1_0 import models as dingtalkswform__1__0_models
from alibabacloud_tea_util import models as util_models
from alibabacloud_openapi_util.client import Client as OpenApiUtilClient


class Client(OpenApiClient):
    """
    *\
    """
    _client: SPIClient = None

    def __init__(
        self, 
        config: open_api_models.Config,
    ):
        super().__init__(config)
        self._client = GatewayClientClient()
        self._spi = self._client
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def get_form_instance_with_options(
        self,
        form_instance_id: str,
        request: dingtalkswform__1__0_models.GetFormInstanceRequest,
        headers: dingtalkswform__1__0_models.GetFormInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkswform__1__0_models.GetFormInstanceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_type):
            query['bizType'] = request.biz_type
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
            action='GetFormInstance',
            version='swform_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/swform/instances/{form_instance_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkswform__1__0_models.GetFormInstanceResponse(),
            self.execute(params, req, runtime)
        )

    async def get_form_instance_with_options_async(
        self,
        form_instance_id: str,
        request: dingtalkswform__1__0_models.GetFormInstanceRequest,
        headers: dingtalkswform__1__0_models.GetFormInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkswform__1__0_models.GetFormInstanceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_type):
            query['bizType'] = request.biz_type
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
            action='GetFormInstance',
            version='swform_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/swform/instances/{form_instance_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkswform__1__0_models.GetFormInstanceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_form_instance(
        self,
        form_instance_id: str,
        request: dingtalkswform__1__0_models.GetFormInstanceRequest,
    ) -> dingtalkswform__1__0_models.GetFormInstanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkswform__1__0_models.GetFormInstanceHeaders()
        return self.get_form_instance_with_options(form_instance_id, request, headers, runtime)

    async def get_form_instance_async(
        self,
        form_instance_id: str,
        request: dingtalkswform__1__0_models.GetFormInstanceRequest,
    ) -> dingtalkswform__1__0_models.GetFormInstanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkswform__1__0_models.GetFormInstanceHeaders()
        return await self.get_form_instance_with_options_async(form_instance_id, request, headers, runtime)

    def list_form_instances_with_options(
        self,
        form_code: str,
        request: dingtalkswform__1__0_models.ListFormInstancesRequest,
        headers: dingtalkswform__1__0_models.ListFormInstancesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkswform__1__0_models.ListFormInstancesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.action_date):
            query['actionDate'] = request.action_date
        if not UtilClient.is_unset(request.biz_type):
            query['bizType'] = request.biz_type
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
        params = open_api_models.Params(
            action='ListFormInstances',
            version='swform_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/swform/forms/{form_code}/instances',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkswform__1__0_models.ListFormInstancesResponse(),
            self.execute(params, req, runtime)
        )

    async def list_form_instances_with_options_async(
        self,
        form_code: str,
        request: dingtalkswform__1__0_models.ListFormInstancesRequest,
        headers: dingtalkswform__1__0_models.ListFormInstancesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkswform__1__0_models.ListFormInstancesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.action_date):
            query['actionDate'] = request.action_date
        if not UtilClient.is_unset(request.biz_type):
            query['bizType'] = request.biz_type
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
        params = open_api_models.Params(
            action='ListFormInstances',
            version='swform_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/swform/forms/{form_code}/instances',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkswform__1__0_models.ListFormInstancesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_form_instances(
        self,
        form_code: str,
        request: dingtalkswform__1__0_models.ListFormInstancesRequest,
    ) -> dingtalkswform__1__0_models.ListFormInstancesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkswform__1__0_models.ListFormInstancesHeaders()
        return self.list_form_instances_with_options(form_code, request, headers, runtime)

    async def list_form_instances_async(
        self,
        form_code: str,
        request: dingtalkswform__1__0_models.ListFormInstancesRequest,
    ) -> dingtalkswform__1__0_models.ListFormInstancesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkswform__1__0_models.ListFormInstancesHeaders()
        return await self.list_form_instances_with_options_async(form_code, request, headers, runtime)

    def list_form_schemas_by_creator_with_options(
        self,
        request: dingtalkswform__1__0_models.ListFormSchemasByCreatorRequest,
        headers: dingtalkswform__1__0_models.ListFormSchemasByCreatorHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkswform__1__0_models.ListFormSchemasByCreatorResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_type):
            query['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.creator):
            query['creator'] = request.creator
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
        params = open_api_models.Params(
            action='ListFormSchemasByCreator',
            version='swform_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/swform/users/forms',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkswform__1__0_models.ListFormSchemasByCreatorResponse(),
            self.execute(params, req, runtime)
        )

    async def list_form_schemas_by_creator_with_options_async(
        self,
        request: dingtalkswform__1__0_models.ListFormSchemasByCreatorRequest,
        headers: dingtalkswform__1__0_models.ListFormSchemasByCreatorHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkswform__1__0_models.ListFormSchemasByCreatorResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_type):
            query['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.creator):
            query['creator'] = request.creator
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
        params = open_api_models.Params(
            action='ListFormSchemasByCreator',
            version='swform_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/swform/users/forms',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkswform__1__0_models.ListFormSchemasByCreatorResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_form_schemas_by_creator(
        self,
        request: dingtalkswform__1__0_models.ListFormSchemasByCreatorRequest,
    ) -> dingtalkswform__1__0_models.ListFormSchemasByCreatorResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkswform__1__0_models.ListFormSchemasByCreatorHeaders()
        return self.list_form_schemas_by_creator_with_options(request, headers, runtime)

    async def list_form_schemas_by_creator_async(
        self,
        request: dingtalkswform__1__0_models.ListFormSchemasByCreatorRequest,
    ) -> dingtalkswform__1__0_models.ListFormSchemasByCreatorResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkswform__1__0_models.ListFormSchemasByCreatorHeaders()
        return await self.list_form_schemas_by_creator_with_options_async(request, headers, runtime)
