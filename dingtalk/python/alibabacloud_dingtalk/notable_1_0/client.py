# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.notable_1_0 import models as dingtalknotable__1__0_models
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

    def create_field_with_options(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.CreateFieldRequest,
        headers: dingtalknotable__1__0_models.CreateFieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.CreateFieldResponse:
        """
        @summary 新增数据表字段
        
        @param request: CreateFieldRequest
        @param headers: CreateFieldHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateFieldResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.property):
            body['property'] = request.property
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateField',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/fields',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.CreateFieldResponse(),
            self.execute(params, req, runtime)
        )

    async def create_field_with_options_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.CreateFieldRequest,
        headers: dingtalknotable__1__0_models.CreateFieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.CreateFieldResponse:
        """
        @summary 新增数据表字段
        
        @param request: CreateFieldRequest
        @param headers: CreateFieldHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateFieldResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.property):
            body['property'] = request.property
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateField',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/fields',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.CreateFieldResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_field(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.CreateFieldRequest,
    ) -> dingtalknotable__1__0_models.CreateFieldResponse:
        """
        @summary 新增数据表字段
        
        @param request: CreateFieldRequest
        @return: CreateFieldResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.CreateFieldHeaders()
        return self.create_field_with_options(base_id, sheet_id_or_name, request, headers, runtime)

    async def create_field_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.CreateFieldRequest,
    ) -> dingtalknotable__1__0_models.CreateFieldResponse:
        """
        @summary 新增数据表字段
        
        @param request: CreateFieldRequest
        @return: CreateFieldResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.CreateFieldHeaders()
        return await self.create_field_with_options_async(base_id, sheet_id_or_name, request, headers, runtime)

    def create_sheet_with_options(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.CreateSheetRequest,
        headers: dingtalknotable__1__0_models.CreateSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.CreateSheetResponse:
        """
        @summary 创建数据表
        
        @param request: CreateSheetRequest
        @param headers: CreateSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateSheetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.fields):
            body['fields'] = request.fields
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateSheet',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.CreateSheetResponse(),
            self.execute(params, req, runtime)
        )

    async def create_sheet_with_options_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.CreateSheetRequest,
        headers: dingtalknotable__1__0_models.CreateSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.CreateSheetResponse:
        """
        @summary 创建数据表
        
        @param request: CreateSheetRequest
        @param headers: CreateSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateSheetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.fields):
            body['fields'] = request.fields
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateSheet',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.CreateSheetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_sheet(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.CreateSheetRequest,
    ) -> dingtalknotable__1__0_models.CreateSheetResponse:
        """
        @summary 创建数据表
        
        @param request: CreateSheetRequest
        @return: CreateSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.CreateSheetHeaders()
        return self.create_sheet_with_options(base_id, request, headers, runtime)

    async def create_sheet_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.CreateSheetRequest,
    ) -> dingtalknotable__1__0_models.CreateSheetResponse:
        """
        @summary 创建数据表
        
        @param request: CreateSheetRequest
        @return: CreateSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.CreateSheetHeaders()
        return await self.create_sheet_with_options_async(base_id, request, headers, runtime)

    def delete_field_with_options(
        self,
        base_id: str,
        sheet_id_or_name: str,
        field_id_or_name: str,
        request: dingtalknotable__1__0_models.DeleteFieldRequest,
        headers: dingtalknotable__1__0_models.DeleteFieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.DeleteFieldResponse:
        """
        @summary 删除数据表字段
        
        @param request: DeleteFieldRequest
        @param headers: DeleteFieldHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteFieldResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='DeleteField',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/fields/{field_id_or_name}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.DeleteFieldResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_field_with_options_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        field_id_or_name: str,
        request: dingtalknotable__1__0_models.DeleteFieldRequest,
        headers: dingtalknotable__1__0_models.DeleteFieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.DeleteFieldResponse:
        """
        @summary 删除数据表字段
        
        @param request: DeleteFieldRequest
        @param headers: DeleteFieldHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteFieldResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='DeleteField',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/fields/{field_id_or_name}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.DeleteFieldResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_field(
        self,
        base_id: str,
        sheet_id_or_name: str,
        field_id_or_name: str,
        request: dingtalknotable__1__0_models.DeleteFieldRequest,
    ) -> dingtalknotable__1__0_models.DeleteFieldResponse:
        """
        @summary 删除数据表字段
        
        @param request: DeleteFieldRequest
        @return: DeleteFieldResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.DeleteFieldHeaders()
        return self.delete_field_with_options(base_id, sheet_id_or_name, field_id_or_name, request, headers, runtime)

    async def delete_field_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        field_id_or_name: str,
        request: dingtalknotable__1__0_models.DeleteFieldRequest,
    ) -> dingtalknotable__1__0_models.DeleteFieldResponse:
        """
        @summary 删除数据表字段
        
        @param request: DeleteFieldRequest
        @return: DeleteFieldResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.DeleteFieldHeaders()
        return await self.delete_field_with_options_async(base_id, sheet_id_or_name, field_id_or_name, request, headers, runtime)

    def delete_records_with_options(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.DeleteRecordsRequest,
        headers: dingtalknotable__1__0_models.DeleteRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.DeleteRecordsResponse:
        """
        @summary 删除数据表多行记录
        
        @param request: DeleteRecordsRequest
        @param headers: DeleteRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteRecordsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.record_ids):
            body['recordIds'] = request.record_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DeleteRecords',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/records/delete',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.DeleteRecordsResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_records_with_options_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.DeleteRecordsRequest,
        headers: dingtalknotable__1__0_models.DeleteRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.DeleteRecordsResponse:
        """
        @summary 删除数据表多行记录
        
        @param request: DeleteRecordsRequest
        @param headers: DeleteRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteRecordsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.record_ids):
            body['recordIds'] = request.record_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DeleteRecords',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/records/delete',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.DeleteRecordsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_records(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.DeleteRecordsRequest,
    ) -> dingtalknotable__1__0_models.DeleteRecordsResponse:
        """
        @summary 删除数据表多行记录
        
        @param request: DeleteRecordsRequest
        @return: DeleteRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.DeleteRecordsHeaders()
        return self.delete_records_with_options(base_id, sheet_id_or_name, request, headers, runtime)

    async def delete_records_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.DeleteRecordsRequest,
    ) -> dingtalknotable__1__0_models.DeleteRecordsResponse:
        """
        @summary 删除数据表多行记录
        
        @param request: DeleteRecordsRequest
        @return: DeleteRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.DeleteRecordsHeaders()
        return await self.delete_records_with_options_async(base_id, sheet_id_or_name, request, headers, runtime)

    def delete_sheet_with_options(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.DeleteSheetRequest,
        headers: dingtalknotable__1__0_models.DeleteSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.DeleteSheetResponse:
        """
        @summary 删除数据表
        
        @param request: DeleteSheetRequest
        @param headers: DeleteSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteSheetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='DeleteSheet',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.DeleteSheetResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_sheet_with_options_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.DeleteSheetRequest,
        headers: dingtalknotable__1__0_models.DeleteSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.DeleteSheetResponse:
        """
        @summary 删除数据表
        
        @param request: DeleteSheetRequest
        @param headers: DeleteSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteSheetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='DeleteSheet',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.DeleteSheetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_sheet(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.DeleteSheetRequest,
    ) -> dingtalknotable__1__0_models.DeleteSheetResponse:
        """
        @summary 删除数据表
        
        @param request: DeleteSheetRequest
        @return: DeleteSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.DeleteSheetHeaders()
        return self.delete_sheet_with_options(base_id, sheet_id_or_name, request, headers, runtime)

    async def delete_sheet_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.DeleteSheetRequest,
    ) -> dingtalknotable__1__0_models.DeleteSheetResponse:
        """
        @summary 删除数据表
        
        @param request: DeleteSheetRequest
        @return: DeleteSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.DeleteSheetHeaders()
        return await self.delete_sheet_with_options_async(base_id, sheet_id_or_name, request, headers, runtime)

    def get_all_fields_with_options(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.GetAllFieldsRequest,
        headers: dingtalknotable__1__0_models.GetAllFieldsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.GetAllFieldsResponse:
        """
        @summary 获取所有字段
        
        @param request: GetAllFieldsRequest
        @param headers: GetAllFieldsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAllFieldsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='GetAllFields',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/fields',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.GetAllFieldsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_all_fields_with_options_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.GetAllFieldsRequest,
        headers: dingtalknotable__1__0_models.GetAllFieldsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.GetAllFieldsResponse:
        """
        @summary 获取所有字段
        
        @param request: GetAllFieldsRequest
        @param headers: GetAllFieldsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAllFieldsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='GetAllFields',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/fields',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.GetAllFieldsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_all_fields(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.GetAllFieldsRequest,
    ) -> dingtalknotable__1__0_models.GetAllFieldsResponse:
        """
        @summary 获取所有字段
        
        @param request: GetAllFieldsRequest
        @return: GetAllFieldsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.GetAllFieldsHeaders()
        return self.get_all_fields_with_options(base_id, sheet_id_or_name, request, headers, runtime)

    async def get_all_fields_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.GetAllFieldsRequest,
    ) -> dingtalknotable__1__0_models.GetAllFieldsResponse:
        """
        @summary 获取所有字段
        
        @param request: GetAllFieldsRequest
        @return: GetAllFieldsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.GetAllFieldsHeaders()
        return await self.get_all_fields_with_options_async(base_id, sheet_id_or_name, request, headers, runtime)

    def get_all_sheets_with_options(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.GetAllSheetsRequest,
        headers: dingtalknotable__1__0_models.GetAllSheetsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.GetAllSheetsResponse:
        """
        @summary 获取所有数据表
        
        @param request: GetAllSheetsRequest
        @param headers: GetAllSheetsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAllSheetsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='GetAllSheets',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.GetAllSheetsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_all_sheets_with_options_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.GetAllSheetsRequest,
        headers: dingtalknotable__1__0_models.GetAllSheetsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.GetAllSheetsResponse:
        """
        @summary 获取所有数据表
        
        @param request: GetAllSheetsRequest
        @param headers: GetAllSheetsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAllSheetsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='GetAllSheets',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.GetAllSheetsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_all_sheets(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.GetAllSheetsRequest,
    ) -> dingtalknotable__1__0_models.GetAllSheetsResponse:
        """
        @summary 获取所有数据表
        
        @param request: GetAllSheetsRequest
        @return: GetAllSheetsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.GetAllSheetsHeaders()
        return self.get_all_sheets_with_options(base_id, request, headers, runtime)

    async def get_all_sheets_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.GetAllSheetsRequest,
    ) -> dingtalknotable__1__0_models.GetAllSheetsResponse:
        """
        @summary 获取所有数据表
        
        @param request: GetAllSheetsRequest
        @return: GetAllSheetsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.GetAllSheetsHeaders()
        return await self.get_all_sheets_with_options_async(base_id, request, headers, runtime)

    def get_record_with_options(
        self,
        base_id: str,
        sheet_id_or_name: str,
        record_id: str,
        request: dingtalknotable__1__0_models.GetRecordRequest,
        headers: dingtalknotable__1__0_models.GetRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.GetRecordResponse:
        """
        @summary 获取记录
        
        @param request: GetRecordRequest
        @param headers: GetRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRecordResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='GetRecord',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/records/{record_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.GetRecordResponse(),
            self.execute(params, req, runtime)
        )

    async def get_record_with_options_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        record_id: str,
        request: dingtalknotable__1__0_models.GetRecordRequest,
        headers: dingtalknotable__1__0_models.GetRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.GetRecordResponse:
        """
        @summary 获取记录
        
        @param request: GetRecordRequest
        @param headers: GetRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRecordResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='GetRecord',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/records/{record_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.GetRecordResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_record(
        self,
        base_id: str,
        sheet_id_or_name: str,
        record_id: str,
        request: dingtalknotable__1__0_models.GetRecordRequest,
    ) -> dingtalknotable__1__0_models.GetRecordResponse:
        """
        @summary 获取记录
        
        @param request: GetRecordRequest
        @return: GetRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.GetRecordHeaders()
        return self.get_record_with_options(base_id, sheet_id_or_name, record_id, request, headers, runtime)

    async def get_record_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        record_id: str,
        request: dingtalknotable__1__0_models.GetRecordRequest,
    ) -> dingtalknotable__1__0_models.GetRecordResponse:
        """
        @summary 获取记录
        
        @param request: GetRecordRequest
        @return: GetRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.GetRecordHeaders()
        return await self.get_record_with_options_async(base_id, sheet_id_or_name, record_id, request, headers, runtime)

    def get_records_with_options(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.GetRecordsRequest,
        headers: dingtalknotable__1__0_models.GetRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.GetRecordsResponse:
        """
        @summary 获取多行记录
        
        @param request: GetRecordsRequest
        @param headers: GetRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRecordsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='GetRecords',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/records',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.GetRecordsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_records_with_options_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.GetRecordsRequest,
        headers: dingtalknotable__1__0_models.GetRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.GetRecordsResponse:
        """
        @summary 获取多行记录
        
        @param request: GetRecordsRequest
        @param headers: GetRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRecordsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='GetRecords',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/records',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.GetRecordsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_records(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.GetRecordsRequest,
    ) -> dingtalknotable__1__0_models.GetRecordsResponse:
        """
        @summary 获取多行记录
        
        @param request: GetRecordsRequest
        @return: GetRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.GetRecordsHeaders()
        return self.get_records_with_options(base_id, sheet_id_or_name, request, headers, runtime)

    async def get_records_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.GetRecordsRequest,
    ) -> dingtalknotable__1__0_models.GetRecordsResponse:
        """
        @summary 获取多行记录
        
        @param request: GetRecordsRequest
        @return: GetRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.GetRecordsHeaders()
        return await self.get_records_with_options_async(base_id, sheet_id_or_name, request, headers, runtime)

    def get_sheet_with_options(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.GetSheetRequest,
        headers: dingtalknotable__1__0_models.GetSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.GetSheetResponse:
        """
        @summary 获取数据表
        
        @param request: GetSheetRequest
        @param headers: GetSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSheetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='GetSheet',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.GetSheetResponse(),
            self.execute(params, req, runtime)
        )

    async def get_sheet_with_options_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.GetSheetRequest,
        headers: dingtalknotable__1__0_models.GetSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.GetSheetResponse:
        """
        @summary 获取数据表
        
        @param request: GetSheetRequest
        @param headers: GetSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSheetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='GetSheet',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.GetSheetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_sheet(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.GetSheetRequest,
    ) -> dingtalknotable__1__0_models.GetSheetResponse:
        """
        @summary 获取数据表
        
        @param request: GetSheetRequest
        @return: GetSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.GetSheetHeaders()
        return self.get_sheet_with_options(base_id, sheet_id_or_name, request, headers, runtime)

    async def get_sheet_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.GetSheetRequest,
    ) -> dingtalknotable__1__0_models.GetSheetResponse:
        """
        @summary 获取数据表
        
        @param request: GetSheetRequest
        @return: GetSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.GetSheetHeaders()
        return await self.get_sheet_with_options_async(base_id, sheet_id_or_name, request, headers, runtime)

    def insert_records_with_options(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.InsertRecordsRequest,
        headers: dingtalknotable__1__0_models.InsertRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.InsertRecordsResponse:
        """
        @summary 新增记录
        
        @param request: InsertRecordsRequest
        @param headers: InsertRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InsertRecordsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.records):
            body['records'] = request.records
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='InsertRecords',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/records',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.InsertRecordsResponse(),
            self.execute(params, req, runtime)
        )

    async def insert_records_with_options_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.InsertRecordsRequest,
        headers: dingtalknotable__1__0_models.InsertRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.InsertRecordsResponse:
        """
        @summary 新增记录
        
        @param request: InsertRecordsRequest
        @param headers: InsertRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InsertRecordsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.records):
            body['records'] = request.records
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='InsertRecords',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/records',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.InsertRecordsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def insert_records(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.InsertRecordsRequest,
    ) -> dingtalknotable__1__0_models.InsertRecordsResponse:
        """
        @summary 新增记录
        
        @param request: InsertRecordsRequest
        @return: InsertRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.InsertRecordsHeaders()
        return self.insert_records_with_options(base_id, sheet_id_or_name, request, headers, runtime)

    async def insert_records_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.InsertRecordsRequest,
    ) -> dingtalknotable__1__0_models.InsertRecordsResponse:
        """
        @summary 新增记录
        
        @param request: InsertRecordsRequest
        @return: InsertRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.InsertRecordsHeaders()
        return await self.insert_records_with_options_async(base_id, sheet_id_or_name, request, headers, runtime)

    def list_records_with_options(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.ListRecordsRequest,
        headers: dingtalknotable__1__0_models.ListRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.ListRecordsResponse:
        """
        @summary 列出多行记录
        
        @param request: ListRecordsRequest
        @param headers: ListRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListRecordsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.filter):
            body['filter'] = request.filter
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ListRecords',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/records/list',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.ListRecordsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_records_with_options_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.ListRecordsRequest,
        headers: dingtalknotable__1__0_models.ListRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.ListRecordsResponse:
        """
        @summary 列出多行记录
        
        @param request: ListRecordsRequest
        @param headers: ListRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListRecordsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.filter):
            body['filter'] = request.filter
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ListRecords',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/records/list',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.ListRecordsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_records(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.ListRecordsRequest,
    ) -> dingtalknotable__1__0_models.ListRecordsResponse:
        """
        @summary 列出多行记录
        
        @param request: ListRecordsRequest
        @return: ListRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.ListRecordsHeaders()
        return self.list_records_with_options(base_id, sheet_id_or_name, request, headers, runtime)

    async def list_records_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.ListRecordsRequest,
    ) -> dingtalknotable__1__0_models.ListRecordsResponse:
        """
        @summary 列出多行记录
        
        @param request: ListRecordsRequest
        @return: ListRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.ListRecordsHeaders()
        return await self.list_records_with_options_async(base_id, sheet_id_or_name, request, headers, runtime)

    def prepare_set_rich_text_with_options(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.PrepareSetRichTextRequest,
        headers: dingtalknotable__1__0_models.PrepareSetRichTextHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.PrepareSetRichTextResponse:
        """
        @summary 富文本值预处理
        
        @param request: PrepareSetRichTextRequest
        @param headers: PrepareSetRichTextHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PrepareSetRichTextResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.markdown):
            body['markdown'] = request.markdown
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='PrepareSetRichText',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/prepareSetRichText',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.PrepareSetRichTextResponse(),
            self.execute(params, req, runtime)
        )

    async def prepare_set_rich_text_with_options_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.PrepareSetRichTextRequest,
        headers: dingtalknotable__1__0_models.PrepareSetRichTextHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.PrepareSetRichTextResponse:
        """
        @summary 富文本值预处理
        
        @param request: PrepareSetRichTextRequest
        @param headers: PrepareSetRichTextHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PrepareSetRichTextResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.markdown):
            body['markdown'] = request.markdown
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='PrepareSetRichText',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/prepareSetRichText',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.PrepareSetRichTextResponse(),
            await self.execute_async(params, req, runtime)
        )

    def prepare_set_rich_text(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.PrepareSetRichTextRequest,
    ) -> dingtalknotable__1__0_models.PrepareSetRichTextResponse:
        """
        @summary 富文本值预处理
        
        @param request: PrepareSetRichTextRequest
        @return: PrepareSetRichTextResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.PrepareSetRichTextHeaders()
        return self.prepare_set_rich_text_with_options(base_id, request, headers, runtime)

    async def prepare_set_rich_text_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.PrepareSetRichTextRequest,
    ) -> dingtalknotable__1__0_models.PrepareSetRichTextResponse:
        """
        @summary 富文本值预处理
        
        @param request: PrepareSetRichTextRequest
        @return: PrepareSetRichTextResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.PrepareSetRichTextHeaders()
        return await self.prepare_set_rich_text_with_options_async(base_id, request, headers, runtime)

    def update_field_with_options(
        self,
        base_id: str,
        sheet_id_or_name: str,
        field_id_or_name: str,
        request: dingtalknotable__1__0_models.UpdateFieldRequest,
        headers: dingtalknotable__1__0_models.UpdateFieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.UpdateFieldResponse:
        """
        @summary 更新数据表字段
        
        @param request: UpdateFieldRequest
        @param headers: UpdateFieldHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateFieldResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.property):
            body['property'] = request.property
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateField',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/fields/{field_id_or_name}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.UpdateFieldResponse(),
            self.execute(params, req, runtime)
        )

    async def update_field_with_options_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        field_id_or_name: str,
        request: dingtalknotable__1__0_models.UpdateFieldRequest,
        headers: dingtalknotable__1__0_models.UpdateFieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.UpdateFieldResponse:
        """
        @summary 更新数据表字段
        
        @param request: UpdateFieldRequest
        @param headers: UpdateFieldHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateFieldResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.property):
            body['property'] = request.property
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateField',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/fields/{field_id_or_name}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.UpdateFieldResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_field(
        self,
        base_id: str,
        sheet_id_or_name: str,
        field_id_or_name: str,
        request: dingtalknotable__1__0_models.UpdateFieldRequest,
    ) -> dingtalknotable__1__0_models.UpdateFieldResponse:
        """
        @summary 更新数据表字段
        
        @param request: UpdateFieldRequest
        @return: UpdateFieldResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.UpdateFieldHeaders()
        return self.update_field_with_options(base_id, sheet_id_or_name, field_id_or_name, request, headers, runtime)

    async def update_field_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        field_id_or_name: str,
        request: dingtalknotable__1__0_models.UpdateFieldRequest,
    ) -> dingtalknotable__1__0_models.UpdateFieldResponse:
        """
        @summary 更新数据表字段
        
        @param request: UpdateFieldRequest
        @return: UpdateFieldResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.UpdateFieldHeaders()
        return await self.update_field_with_options_async(base_id, sheet_id_or_name, field_id_or_name, request, headers, runtime)

    def update_records_with_options(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.UpdateRecordsRequest,
        headers: dingtalknotable__1__0_models.UpdateRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.UpdateRecordsResponse:
        """
        @summary 更新数据表多行记录
        
        @param request: UpdateRecordsRequest
        @param headers: UpdateRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateRecordsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.records):
            body['records'] = request.records
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateRecords',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/records',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.UpdateRecordsResponse(),
            self.execute(params, req, runtime)
        )

    async def update_records_with_options_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.UpdateRecordsRequest,
        headers: dingtalknotable__1__0_models.UpdateRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.UpdateRecordsResponse:
        """
        @summary 更新数据表多行记录
        
        @param request: UpdateRecordsRequest
        @param headers: UpdateRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateRecordsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.records):
            body['records'] = request.records
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateRecords',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/records',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.UpdateRecordsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_records(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.UpdateRecordsRequest,
    ) -> dingtalknotable__1__0_models.UpdateRecordsResponse:
        """
        @summary 更新数据表多行记录
        
        @param request: UpdateRecordsRequest
        @return: UpdateRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.UpdateRecordsHeaders()
        return self.update_records_with_options(base_id, sheet_id_or_name, request, headers, runtime)

    async def update_records_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.UpdateRecordsRequest,
    ) -> dingtalknotable__1__0_models.UpdateRecordsResponse:
        """
        @summary 更新数据表多行记录
        
        @param request: UpdateRecordsRequest
        @return: UpdateRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.UpdateRecordsHeaders()
        return await self.update_records_with_options_async(base_id, sheet_id_or_name, request, headers, runtime)

    def update_sheet_with_options(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.UpdateSheetRequest,
        headers: dingtalknotable__1__0_models.UpdateSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.UpdateSheetResponse:
        """
        @summary 更新数据表
        
        @param request: UpdateSheetRequest
        @param headers: UpdateSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateSheetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateSheet',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.UpdateSheetResponse(),
            self.execute(params, req, runtime)
        )

    async def update_sheet_with_options_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.UpdateSheetRequest,
        headers: dingtalknotable__1__0_models.UpdateSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.UpdateSheetResponse:
        """
        @summary 更新数据表
        
        @param request: UpdateSheetRequest
        @param headers: UpdateSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateSheetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateSheet',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.UpdateSheetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_sheet(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.UpdateSheetRequest,
    ) -> dingtalknotable__1__0_models.UpdateSheetResponse:
        """
        @summary 更新数据表
        
        @param request: UpdateSheetRequest
        @return: UpdateSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.UpdateSheetHeaders()
        return self.update_sheet_with_options(base_id, sheet_id_or_name, request, headers, runtime)

    async def update_sheet_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.UpdateSheetRequest,
    ) -> dingtalknotable__1__0_models.UpdateSheetResponse:
        """
        @summary 更新数据表
        
        @param request: UpdateSheetRequest
        @return: UpdateSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.UpdateSheetHeaders()
        return await self.update_sheet_with_options_async(base_id, sheet_id_or_name, request, headers, runtime)
