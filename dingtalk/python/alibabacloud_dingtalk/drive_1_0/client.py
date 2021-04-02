# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalkdrive_1_0 import models as dingtalkdrive__1__0_models
from alibabacloud_tea_util import models as util_models


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

    def get_download_info(
        self,
        user_id: str,
        space_id: str,
        file_id: str,
    ) -> dingtalkdrive__1__0_models.GetDownloadInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.GetDownloadInfoHeaders()
        return self.get_download_info_with_options(user_id, space_id, file_id, headers, runtime)

    async def get_download_info_async(
        self,
        user_id: str,
        space_id: str,
        file_id: str,
    ) -> dingtalkdrive__1__0_models.GetDownloadInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdrive__1__0_models.GetDownloadInfoHeaders()
        return await self.get_download_info_with_options_async(user_id, space_id, file_id, headers, runtime)

    def get_download_info_with_options(
        self,
        user_id: str,
        space_id: str,
        file_id: str,
        headers: dingtalkdrive__1__0_models.GetDownloadInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.GetDownloadInfoResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.GetDownloadInfoResponse(),
            self.do_roarequest('GetDownloadInfo', 'drive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/drive/users/{user_id}/spaces/{space_id}/files/{file_id}/downloadInfo', 'json', req, runtime)
        )

    async def get_download_info_with_options_async(
        self,
        user_id: str,
        space_id: str,
        file_id: str,
        headers: dingtalkdrive__1__0_models.GetDownloadInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdrive__1__0_models.GetDownloadInfoResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkdrive__1__0_models.GetDownloadInfoResponse(),
            await self.do_roarequest_async('GetDownloadInfo', 'drive_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/drive/users/{user_id}/spaces/{space_id}/files/{file_id}/downloadInfo', 'json', req, runtime)
        )
