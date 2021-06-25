# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalkconnector_1_0 import models as dingtalkconnector__1__0_models
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

    def pull_data_by_page(
        self,
        request: dingtalkconnector__1__0_models.PullDataByPageRequest,
    ) -> dingtalkconnector__1__0_models.PullDataByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.PullDataByPageHeaders()
        return self.pull_data_by_page_with_options(request, headers, runtime)

    async def pull_data_by_page_async(
        self,
        request: dingtalkconnector__1__0_models.PullDataByPageRequest,
    ) -> dingtalkconnector__1__0_models.PullDataByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.PullDataByPageHeaders()
        return await self.pull_data_by_page_with_options_async(request, headers, runtime)

    def pull_data_by_page_with_options(
        self,
        request: dingtalkconnector__1__0_models.PullDataByPageRequest,
        headers: dingtalkconnector__1__0_models.PullDataByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.PullDataByPageResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.data_model_id):
            query['dataModelId'] = request.data_model_id
        if not UtilClient.is_unset(request.datetime_filter_field):
            query['datetimeFilterField'] = request.datetime_filter_field
        if not UtilClient.is_unset(request.min_datetime):
            query['minDatetime'] = request.min_datetime
        if not UtilClient.is_unset(request.max_datetime):
            query['maxDatetime'] = request.max_datetime
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.app_id):
            query['appId'] = request.app_id
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
            dingtalkconnector__1__0_models.PullDataByPageResponse(),
            self.do_roarequest('PullDataByPage', 'connector_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/connector/data', 'json', req, runtime)
        )

    async def pull_data_by_page_with_options_async(
        self,
        request: dingtalkconnector__1__0_models.PullDataByPageRequest,
        headers: dingtalkconnector__1__0_models.PullDataByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.PullDataByPageResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.data_model_id):
            query['dataModelId'] = request.data_model_id
        if not UtilClient.is_unset(request.datetime_filter_field):
            query['datetimeFilterField'] = request.datetime_filter_field
        if not UtilClient.is_unset(request.min_datetime):
            query['minDatetime'] = request.min_datetime
        if not UtilClient.is_unset(request.max_datetime):
            query['maxDatetime'] = request.max_datetime
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.app_id):
            query['appId'] = request.app_id
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
            dingtalkconnector__1__0_models.PullDataByPageResponse(),
            await self.do_roarequest_async('PullDataByPage', 'connector_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/connector/data', 'json', req, runtime)
        )

    def pull_data_by_pk(
        self,
        data_model_id: str,
        request: dingtalkconnector__1__0_models.PullDataByPkRequest,
    ) -> dingtalkconnector__1__0_models.PullDataByPkResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.PullDataByPkHeaders()
        return self.pull_data_by_pk_with_options(data_model_id, request, headers, runtime)

    async def pull_data_by_pk_async(
        self,
        data_model_id: str,
        request: dingtalkconnector__1__0_models.PullDataByPkRequest,
    ) -> dingtalkconnector__1__0_models.PullDataByPkResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.PullDataByPkHeaders()
        return await self.pull_data_by_pk_with_options_async(data_model_id, request, headers, runtime)

    def pull_data_by_pk_with_options(
        self,
        data_model_id: str,
        request: dingtalkconnector__1__0_models.PullDataByPkRequest,
        headers: dingtalkconnector__1__0_models.PullDataByPkHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.PullDataByPkResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.primary_key):
            query['primaryKey'] = request.primary_key
        if not UtilClient.is_unset(request.app_id):
            query['appId'] = request.app_id
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
            dingtalkconnector__1__0_models.PullDataByPkResponse(),
            self.do_roarequest('PullDataByPk', 'connector_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/connector/data/{data_model_id}', 'json', req, runtime)
        )

    async def pull_data_by_pk_with_options_async(
        self,
        data_model_id: str,
        request: dingtalkconnector__1__0_models.PullDataByPkRequest,
        headers: dingtalkconnector__1__0_models.PullDataByPkHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.PullDataByPkResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.primary_key):
            query['primaryKey'] = request.primary_key
        if not UtilClient.is_unset(request.app_id):
            query['appId'] = request.app_id
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
            dingtalkconnector__1__0_models.PullDataByPkResponse(),
            await self.do_roarequest_async('PullDataByPk', 'connector_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/connector/data/{data_model_id}', 'json', req, runtime)
        )

    def sync_data(
        self,
        request: dingtalkconnector__1__0_models.SyncDataRequest,
    ) -> dingtalkconnector__1__0_models.SyncDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.SyncDataHeaders()
        return self.sync_data_with_options(request, headers, runtime)

    async def sync_data_async(
        self,
        request: dingtalkconnector__1__0_models.SyncDataRequest,
    ) -> dingtalkconnector__1__0_models.SyncDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.SyncDataHeaders()
        return await self.sync_data_with_options_async(request, headers, runtime)

    def sync_data_with_options(
        self,
        request: dingtalkconnector__1__0_models.SyncDataRequest,
        headers: dingtalkconnector__1__0_models.SyncDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.SyncDataResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.trigger_data_list):
            body['triggerDataList'] = request.trigger_data_list
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
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
            dingtalkconnector__1__0_models.SyncDataResponse(),
            self.do_roarequest('SyncData', 'connector_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/connector/triggers/data/sync', 'json', req, runtime)
        )

    async def sync_data_with_options_async(
        self,
        request: dingtalkconnector__1__0_models.SyncDataRequest,
        headers: dingtalkconnector__1__0_models.SyncDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.SyncDataResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.trigger_data_list):
            body['triggerDataList'] = request.trigger_data_list
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
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
            dingtalkconnector__1__0_models.SyncDataResponse(),
            await self.do_roarequest_async('SyncData', 'connector_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/connector/triggers/data/sync', 'json', req, runtime)
        )
