# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.org_culture_1_0 import models as dingtalkorg_culture__1__0_models
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

    def assign_org_holding_to_emp_holding_batch(
        self,
        request: dingtalkorg_culture__1__0_models.AssignOrgHoldingToEmpHoldingBatchRequest,
    ) -> dingtalkorg_culture__1__0_models.AssignOrgHoldingToEmpHoldingBatchResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.AssignOrgHoldingToEmpHoldingBatchHeaders()
        return self.assign_org_holding_to_emp_holding_batch_with_options(request, headers, runtime)

    async def assign_org_holding_to_emp_holding_batch_async(
        self,
        request: dingtalkorg_culture__1__0_models.AssignOrgHoldingToEmpHoldingBatchRequest,
    ) -> dingtalkorg_culture__1__0_models.AssignOrgHoldingToEmpHoldingBatchResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.AssignOrgHoldingToEmpHoldingBatchHeaders()
        return await self.assign_org_holding_to_emp_holding_batch_with_options_async(request, headers, runtime)

    def assign_org_holding_to_emp_holding_batch_with_options(
        self,
        request: dingtalkorg_culture__1__0_models.AssignOrgHoldingToEmpHoldingBatchRequest,
        headers: dingtalkorg_culture__1__0_models.AssignOrgHoldingToEmpHoldingBatchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.AssignOrgHoldingToEmpHoldingBatchResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.send_org_culture_inform):
            body['sendOrgCultureInform'] = request.send_org_culture_inform
        if not UtilClient.is_unset(request.single_amount):
            body['singleAmount'] = request.single_amount
        if not UtilClient.is_unset(request.source_usage):
            body['sourceUsage'] = request.source_usage
        if not UtilClient.is_unset(request.target_usage):
            body['targetUsage'] = request.target_usage
        if not UtilClient.is_unset(request.target_user_list):
            body['targetUserList'] = request.target_user_list
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
            dingtalkorg_culture__1__0_models.AssignOrgHoldingToEmpHoldingBatchResponse(),
            self.do_roarequest('AssignOrgHoldingToEmpHoldingBatch', 'orgCulture_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/orgCulture/organizations/points/assign', 'json', req, runtime)
        )

    async def assign_org_holding_to_emp_holding_batch_with_options_async(
        self,
        request: dingtalkorg_culture__1__0_models.AssignOrgHoldingToEmpHoldingBatchRequest,
        headers: dingtalkorg_culture__1__0_models.AssignOrgHoldingToEmpHoldingBatchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.AssignOrgHoldingToEmpHoldingBatchResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.send_org_culture_inform):
            body['sendOrgCultureInform'] = request.send_org_culture_inform
        if not UtilClient.is_unset(request.single_amount):
            body['singleAmount'] = request.single_amount
        if not UtilClient.is_unset(request.source_usage):
            body['sourceUsage'] = request.source_usage
        if not UtilClient.is_unset(request.target_usage):
            body['targetUsage'] = request.target_usage
        if not UtilClient.is_unset(request.target_user_list):
            body['targetUserList'] = request.target_user_list
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
            dingtalkorg_culture__1__0_models.AssignOrgHoldingToEmpHoldingBatchResponse(),
            await self.do_roarequest_async('AssignOrgHoldingToEmpHoldingBatch', 'orgCulture_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/orgCulture/organizations/points/assign', 'json', req, runtime)
        )

    def consume_user_points(
        self,
        user_id: str,
        request: dingtalkorg_culture__1__0_models.ConsumeUserPointsRequest,
    ) -> dingtalkorg_culture__1__0_models.ConsumeUserPointsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.ConsumeUserPointsHeaders()
        return self.consume_user_points_with_options(user_id, request, headers, runtime)

    async def consume_user_points_async(
        self,
        user_id: str,
        request: dingtalkorg_culture__1__0_models.ConsumeUserPointsRequest,
    ) -> dingtalkorg_culture__1__0_models.ConsumeUserPointsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.ConsumeUserPointsHeaders()
        return await self.consume_user_points_with_options_async(user_id, request, headers, runtime)

    def consume_user_points_with_options(
        self,
        user_id: str,
        request: dingtalkorg_culture__1__0_models.ConsumeUserPointsRequest,
        headers: dingtalkorg_culture__1__0_models.ConsumeUserPointsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.ConsumeUserPointsResponse:
        UtilClient.validate_model(request)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
        body = {}
        if not UtilClient.is_unset(request.amount):
            body['amount'] = request.amount
        if not UtilClient.is_unset(request.out_id):
            body['outId'] = request.out_id
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.usage):
            body['usage'] = request.usage
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
            dingtalkorg_culture__1__0_models.ConsumeUserPointsResponse(),
            self.do_roarequest('ConsumeUserPoints', 'orgCulture_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/orgCulture/users/{user_id}/points/deduct', 'json', req, runtime)
        )

    async def consume_user_points_with_options_async(
        self,
        user_id: str,
        request: dingtalkorg_culture__1__0_models.ConsumeUserPointsRequest,
        headers: dingtalkorg_culture__1__0_models.ConsumeUserPointsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.ConsumeUserPointsResponse:
        UtilClient.validate_model(request)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
        body = {}
        if not UtilClient.is_unset(request.amount):
            body['amount'] = request.amount
        if not UtilClient.is_unset(request.out_id):
            body['outId'] = request.out_id
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.usage):
            body['usage'] = request.usage
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
            dingtalkorg_culture__1__0_models.ConsumeUserPointsResponse(),
            await self.do_roarequest_async('ConsumeUserPoints', 'orgCulture_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/orgCulture/users/{user_id}/points/deduct', 'json', req, runtime)
        )

    def create_org_honor(
        self,
        request: dingtalkorg_culture__1__0_models.CreateOrgHonorRequest,
    ) -> dingtalkorg_culture__1__0_models.CreateOrgHonorResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.CreateOrgHonorHeaders()
        return self.create_org_honor_with_options(request, headers, runtime)

    async def create_org_honor_async(
        self,
        request: dingtalkorg_culture__1__0_models.CreateOrgHonorRequest,
    ) -> dingtalkorg_culture__1__0_models.CreateOrgHonorResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.CreateOrgHonorHeaders()
        return await self.create_org_honor_with_options_async(request, headers, runtime)

    def create_org_honor_with_options(
        self,
        request: dingtalkorg_culture__1__0_models.CreateOrgHonorRequest,
        headers: dingtalkorg_culture__1__0_models.CreateOrgHonorHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.CreateOrgHonorResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.avatar_frame_media_id):
            body['avatarFrameMediaId'] = request.avatar_frame_media_id
        if not UtilClient.is_unset(request.default_bg_color):
            body['defaultBgColor'] = request.default_bg_color
        if not UtilClient.is_unset(request.medal_desc):
            body['medalDesc'] = request.medal_desc
        if not UtilClient.is_unset(request.medal_media_id):
            body['medalMediaId'] = request.medal_media_id
        if not UtilClient.is_unset(request.medal_name):
            body['medalName'] = request.medal_name
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
        return TeaCore.from_map(
            dingtalkorg_culture__1__0_models.CreateOrgHonorResponse(),
            self.do_roarequest('CreateOrgHonor', 'orgCulture_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/orgCulture/honors/templates', 'json', req, runtime)
        )

    async def create_org_honor_with_options_async(
        self,
        request: dingtalkorg_culture__1__0_models.CreateOrgHonorRequest,
        headers: dingtalkorg_culture__1__0_models.CreateOrgHonorHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.CreateOrgHonorResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.avatar_frame_media_id):
            body['avatarFrameMediaId'] = request.avatar_frame_media_id
        if not UtilClient.is_unset(request.default_bg_color):
            body['defaultBgColor'] = request.default_bg_color
        if not UtilClient.is_unset(request.medal_desc):
            body['medalDesc'] = request.medal_desc
        if not UtilClient.is_unset(request.medal_media_id):
            body['medalMediaId'] = request.medal_media_id
        if not UtilClient.is_unset(request.medal_name):
            body['medalName'] = request.medal_name
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
        return TeaCore.from_map(
            dingtalkorg_culture__1__0_models.CreateOrgHonorResponse(),
            await self.do_roarequest_async('CreateOrgHonor', 'orgCulture_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/orgCulture/honors/templates', 'json', req, runtime)
        )

    def deduction_point_batch(
        self,
        request: dingtalkorg_culture__1__0_models.DeductionPointBatchRequest,
    ) -> dingtalkorg_culture__1__0_models.DeductionPointBatchResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.DeductionPointBatchHeaders()
        return self.deduction_point_batch_with_options(request, headers, runtime)

    async def deduction_point_batch_async(
        self,
        request: dingtalkorg_culture__1__0_models.DeductionPointBatchRequest,
    ) -> dingtalkorg_culture__1__0_models.DeductionPointBatchResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.DeductionPointBatchHeaders()
        return await self.deduction_point_batch_with_options_async(request, headers, runtime)

    def deduction_point_batch_with_options(
        self,
        request: dingtalkorg_culture__1__0_models.DeductionPointBatchRequest,
        headers: dingtalkorg_culture__1__0_models.DeductionPointBatchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.DeductionPointBatchResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.deduction_amount):
            body['deductionAmount'] = request.deduction_amount
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.send_org_culture_inform):
            body['sendOrgCultureInform'] = request.send_org_culture_inform
        if not UtilClient.is_unset(request.target_user_list):
            body['targetUserList'] = request.target_user_list
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
        return TeaCore.from_map(
            dingtalkorg_culture__1__0_models.DeductionPointBatchResponse(),
            self.do_roarequest('DeductionPointBatch', 'orgCulture_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/orgCulture/users/points/deduct', 'json', req, runtime)
        )

    async def deduction_point_batch_with_options_async(
        self,
        request: dingtalkorg_culture__1__0_models.DeductionPointBatchRequest,
        headers: dingtalkorg_culture__1__0_models.DeductionPointBatchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.DeductionPointBatchResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.deduction_amount):
            body['deductionAmount'] = request.deduction_amount
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.send_org_culture_inform):
            body['sendOrgCultureInform'] = request.send_org_culture_inform
        if not UtilClient.is_unset(request.target_user_list):
            body['targetUserList'] = request.target_user_list
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
        return TeaCore.from_map(
            dingtalkorg_culture__1__0_models.DeductionPointBatchResponse(),
            await self.do_roarequest_async('DeductionPointBatch', 'orgCulture_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/orgCulture/users/points/deduct', 'json', req, runtime)
        )

    def export_point_open(
        self,
        request: dingtalkorg_culture__1__0_models.ExportPointOpenRequest,
    ) -> dingtalkorg_culture__1__0_models.ExportPointOpenResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.ExportPointOpenHeaders()
        return self.export_point_open_with_options(request, headers, runtime)

    async def export_point_open_async(
        self,
        request: dingtalkorg_culture__1__0_models.ExportPointOpenRequest,
    ) -> dingtalkorg_culture__1__0_models.ExportPointOpenResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.ExportPointOpenHeaders()
        return await self.export_point_open_with_options_async(request, headers, runtime)

    def export_point_open_with_options(
        self,
        request: dingtalkorg_culture__1__0_models.ExportPointOpenRequest,
        headers: dingtalkorg_culture__1__0_models.ExportPointOpenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.ExportPointOpenResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.export_date):
            body['exportDate'] = request.export_date
        if not UtilClient.is_unset(request.export_type):
            body['exportType'] = request.export_type
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
        return TeaCore.from_map(
            dingtalkorg_culture__1__0_models.ExportPointOpenResponse(),
            self.do_roarequest('ExportPointOpen', 'orgCulture_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/orgCulture/users/points/export', 'json', req, runtime)
        )

    async def export_point_open_with_options_async(
        self,
        request: dingtalkorg_culture__1__0_models.ExportPointOpenRequest,
        headers: dingtalkorg_culture__1__0_models.ExportPointOpenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.ExportPointOpenResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.export_date):
            body['exportDate'] = request.export_date
        if not UtilClient.is_unset(request.export_type):
            body['exportType'] = request.export_type
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
        return TeaCore.from_map(
            dingtalkorg_culture__1__0_models.ExportPointOpenResponse(),
            await self.do_roarequest_async('ExportPointOpen', 'orgCulture_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/orgCulture/users/points/export', 'json', req, runtime)
        )

    def grant_honor(
        self,
        honor_id: str,
        request: dingtalkorg_culture__1__0_models.GrantHonorRequest,
    ) -> dingtalkorg_culture__1__0_models.GrantHonorResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.GrantHonorHeaders()
        return self.grant_honor_with_options(honor_id, request, headers, runtime)

    async def grant_honor_async(
        self,
        honor_id: str,
        request: dingtalkorg_culture__1__0_models.GrantHonorRequest,
    ) -> dingtalkorg_culture__1__0_models.GrantHonorResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.GrantHonorHeaders()
        return await self.grant_honor_with_options_async(honor_id, request, headers, runtime)

    def grant_honor_with_options(
        self,
        honor_id: str,
        request: dingtalkorg_culture__1__0_models.GrantHonorRequest,
        headers: dingtalkorg_culture__1__0_models.GrantHonorHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.GrantHonorResponse:
        UtilClient.validate_model(request)
        honor_id = OpenApiUtilClient.get_encode_param(honor_id)
        body = {}
        if not UtilClient.is_unset(request.expiration_time):
            body['expirationTime'] = request.expiration_time
        if not UtilClient.is_unset(request.grant_reason):
            body['grantReason'] = request.grant_reason
        if not UtilClient.is_unset(request.granter_name):
            body['granterName'] = request.granter_name
        if not UtilClient.is_unset(request.notice_announcer):
            body['noticeAnnouncer'] = request.notice_announcer
        if not UtilClient.is_unset(request.notice_single):
            body['noticeSingle'] = request.notice_single
        if not UtilClient.is_unset(request.open_conversation_ids):
            body['openConversationIds'] = request.open_conversation_ids
        if not UtilClient.is_unset(request.receiver_user_ids):
            body['receiverUserIds'] = request.receiver_user_ids
        if not UtilClient.is_unset(request.sender_user_id):
            body['senderUserId'] = request.sender_user_id
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
            dingtalkorg_culture__1__0_models.GrantHonorResponse(),
            self.do_roarequest('GrantHonor', 'orgCulture_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/orgCulture/honors/{honor_id}/grant', 'json', req, runtime)
        )

    async def grant_honor_with_options_async(
        self,
        honor_id: str,
        request: dingtalkorg_culture__1__0_models.GrantHonorRequest,
        headers: dingtalkorg_culture__1__0_models.GrantHonorHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.GrantHonorResponse:
        UtilClient.validate_model(request)
        honor_id = OpenApiUtilClient.get_encode_param(honor_id)
        body = {}
        if not UtilClient.is_unset(request.expiration_time):
            body['expirationTime'] = request.expiration_time
        if not UtilClient.is_unset(request.grant_reason):
            body['grantReason'] = request.grant_reason
        if not UtilClient.is_unset(request.granter_name):
            body['granterName'] = request.granter_name
        if not UtilClient.is_unset(request.notice_announcer):
            body['noticeAnnouncer'] = request.notice_announcer
        if not UtilClient.is_unset(request.notice_single):
            body['noticeSingle'] = request.notice_single
        if not UtilClient.is_unset(request.open_conversation_ids):
            body['openConversationIds'] = request.open_conversation_ids
        if not UtilClient.is_unset(request.receiver_user_ids):
            body['receiverUserIds'] = request.receiver_user_ids
        if not UtilClient.is_unset(request.sender_user_id):
            body['senderUserId'] = request.sender_user_id
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
            dingtalkorg_culture__1__0_models.GrantHonorResponse(),
            await self.do_roarequest_async('GrantHonor', 'orgCulture_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/orgCulture/honors/{honor_id}/grant', 'json', req, runtime)
        )

    def query_corp_points(
        self,
        request: dingtalkorg_culture__1__0_models.QueryCorpPointsRequest,
    ) -> dingtalkorg_culture__1__0_models.QueryCorpPointsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.QueryCorpPointsHeaders()
        return self.query_corp_points_with_options(request, headers, runtime)

    async def query_corp_points_async(
        self,
        request: dingtalkorg_culture__1__0_models.QueryCorpPointsRequest,
    ) -> dingtalkorg_culture__1__0_models.QueryCorpPointsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.QueryCorpPointsHeaders()
        return await self.query_corp_points_with_options_async(request, headers, runtime)

    def query_corp_points_with_options(
        self,
        request: dingtalkorg_culture__1__0_models.QueryCorpPointsRequest,
        headers: dingtalkorg_culture__1__0_models.QueryCorpPointsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.QueryCorpPointsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.opt_user_id):
            query['optUserId'] = request.opt_user_id
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
            dingtalkorg_culture__1__0_models.QueryCorpPointsResponse(),
            self.do_roarequest('QueryCorpPoints', 'orgCulture_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/orgCulture/organizations/points', 'json', req, runtime)
        )

    async def query_corp_points_with_options_async(
        self,
        request: dingtalkorg_culture__1__0_models.QueryCorpPointsRequest,
        headers: dingtalkorg_culture__1__0_models.QueryCorpPointsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.QueryCorpPointsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.opt_user_id):
            query['optUserId'] = request.opt_user_id
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
            dingtalkorg_culture__1__0_models.QueryCorpPointsResponse(),
            await self.do_roarequest_async('QueryCorpPoints', 'orgCulture_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/orgCulture/organizations/points', 'json', req, runtime)
        )

    def query_emp_point_details(
        self,
        request: dingtalkorg_culture__1__0_models.QueryEmpPointDetailsRequest,
    ) -> dingtalkorg_culture__1__0_models.QueryEmpPointDetailsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.QueryEmpPointDetailsHeaders()
        return self.query_emp_point_details_with_options(request, headers, runtime)

    async def query_emp_point_details_async(
        self,
        request: dingtalkorg_culture__1__0_models.QueryEmpPointDetailsRequest,
    ) -> dingtalkorg_culture__1__0_models.QueryEmpPointDetailsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.QueryEmpPointDetailsHeaders()
        return await self.query_emp_point_details_with_options_async(request, headers, runtime)

    def query_emp_point_details_with_options(
        self,
        request: dingtalkorg_culture__1__0_models.QueryEmpPointDetailsRequest,
        headers: dingtalkorg_culture__1__0_models.QueryEmpPointDetailsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.QueryEmpPointDetailsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
            dingtalkorg_culture__1__0_models.QueryEmpPointDetailsResponse(),
            self.do_roarequest('QueryEmpPointDetails', 'orgCulture_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/orgCulture/points/empDetails', 'json', req, runtime)
        )

    async def query_emp_point_details_with_options_async(
        self,
        request: dingtalkorg_culture__1__0_models.QueryEmpPointDetailsRequest,
        headers: dingtalkorg_culture__1__0_models.QueryEmpPointDetailsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.QueryEmpPointDetailsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
            dingtalkorg_culture__1__0_models.QueryEmpPointDetailsResponse(),
            await self.do_roarequest_async('QueryEmpPointDetails', 'orgCulture_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/orgCulture/points/empDetails', 'json', req, runtime)
        )

    def query_org_honors(
        self,
        request: dingtalkorg_culture__1__0_models.QueryOrgHonorsRequest,
    ) -> dingtalkorg_culture__1__0_models.QueryOrgHonorsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.QueryOrgHonorsHeaders()
        return self.query_org_honors_with_options(request, headers, runtime)

    async def query_org_honors_async(
        self,
        request: dingtalkorg_culture__1__0_models.QueryOrgHonorsRequest,
    ) -> dingtalkorg_culture__1__0_models.QueryOrgHonorsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.QueryOrgHonorsHeaders()
        return await self.query_org_honors_with_options_async(request, headers, runtime)

    def query_org_honors_with_options(
        self,
        request: dingtalkorg_culture__1__0_models.QueryOrgHonorsRequest,
        headers: dingtalkorg_culture__1__0_models.QueryOrgHonorsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.QueryOrgHonorsResponse:
        UtilClient.validate_model(request)
        query = {}
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
        return TeaCore.from_map(
            dingtalkorg_culture__1__0_models.QueryOrgHonorsResponse(),
            self.do_roarequest('QueryOrgHonors', 'orgCulture_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/orgCulture/organizations/honors', 'json', req, runtime)
        )

    async def query_org_honors_with_options_async(
        self,
        request: dingtalkorg_culture__1__0_models.QueryOrgHonorsRequest,
        headers: dingtalkorg_culture__1__0_models.QueryOrgHonorsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.QueryOrgHonorsResponse:
        UtilClient.validate_model(request)
        query = {}
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
        return TeaCore.from_map(
            dingtalkorg_culture__1__0_models.QueryOrgHonorsResponse(),
            await self.do_roarequest_async('QueryOrgHonors', 'orgCulture_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/orgCulture/organizations/honors', 'json', req, runtime)
        )

    def query_org_point_details(
        self,
        request: dingtalkorg_culture__1__0_models.QueryOrgPointDetailsRequest,
    ) -> dingtalkorg_culture__1__0_models.QueryOrgPointDetailsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.QueryOrgPointDetailsHeaders()
        return self.query_org_point_details_with_options(request, headers, runtime)

    async def query_org_point_details_async(
        self,
        request: dingtalkorg_culture__1__0_models.QueryOrgPointDetailsRequest,
    ) -> dingtalkorg_culture__1__0_models.QueryOrgPointDetailsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.QueryOrgPointDetailsHeaders()
        return await self.query_org_point_details_with_options_async(request, headers, runtime)

    def query_org_point_details_with_options(
        self,
        request: dingtalkorg_culture__1__0_models.QueryOrgPointDetailsRequest,
        headers: dingtalkorg_culture__1__0_models.QueryOrgPointDetailsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.QueryOrgPointDetailsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.account_type):
            query['accountType'] = request.account_type
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
            dingtalkorg_culture__1__0_models.QueryOrgPointDetailsResponse(),
            self.do_roarequest('QueryOrgPointDetails', 'orgCulture_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/orgCulture/points/orgDetails', 'json', req, runtime)
        )

    async def query_org_point_details_with_options_async(
        self,
        request: dingtalkorg_culture__1__0_models.QueryOrgPointDetailsRequest,
        headers: dingtalkorg_culture__1__0_models.QueryOrgPointDetailsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.QueryOrgPointDetailsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.account_type):
            query['accountType'] = request.account_type
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
            dingtalkorg_culture__1__0_models.QueryOrgPointDetailsResponse(),
            await self.do_roarequest_async('QueryOrgPointDetails', 'orgCulture_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/orgCulture/points/orgDetails', 'json', req, runtime)
        )

    def query_point_action_auto_assign_rule(self) -> dingtalkorg_culture__1__0_models.QueryPointActionAutoAssignRuleResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.QueryPointActionAutoAssignRuleHeaders()
        return self.query_point_action_auto_assign_rule_with_options(headers, runtime)

    async def query_point_action_auto_assign_rule_async(self) -> dingtalkorg_culture__1__0_models.QueryPointActionAutoAssignRuleResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.QueryPointActionAutoAssignRuleHeaders()
        return await self.query_point_action_auto_assign_rule_with_options_async(headers, runtime)

    def query_point_action_auto_assign_rule_with_options(
        self,
        headers: dingtalkorg_culture__1__0_models.QueryPointActionAutoAssignRuleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.QueryPointActionAutoAssignRuleResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkorg_culture__1__0_models.QueryPointActionAutoAssignRuleResponse(),
            self.do_roarequest('QueryPointActionAutoAssignRule', 'orgCulture_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/orgCulture/users/points/actionRules', 'json', req, runtime)
        )

    async def query_point_action_auto_assign_rule_with_options_async(
        self,
        headers: dingtalkorg_culture__1__0_models.QueryPointActionAutoAssignRuleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.QueryPointActionAutoAssignRuleResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkorg_culture__1__0_models.QueryPointActionAutoAssignRuleResponse(),
            await self.do_roarequest_async('QueryPointActionAutoAssignRule', 'orgCulture_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/orgCulture/users/points/actionRules', 'json', req, runtime)
        )

    def query_point_auto_issue_setting(self) -> dingtalkorg_culture__1__0_models.QueryPointAutoIssueSettingResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.QueryPointAutoIssueSettingHeaders()
        return self.query_point_auto_issue_setting_with_options(headers, runtime)

    async def query_point_auto_issue_setting_async(self) -> dingtalkorg_culture__1__0_models.QueryPointAutoIssueSettingResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.QueryPointAutoIssueSettingHeaders()
        return await self.query_point_auto_issue_setting_with_options_async(headers, runtime)

    def query_point_auto_issue_setting_with_options(
        self,
        headers: dingtalkorg_culture__1__0_models.QueryPointAutoIssueSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.QueryPointAutoIssueSettingResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkorg_culture__1__0_models.QueryPointAutoIssueSettingResponse(),
            self.do_roarequest('QueryPointAutoIssueSetting', 'orgCulture_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/orgCulture/users/points', 'json', req, runtime)
        )

    async def query_point_auto_issue_setting_with_options_async(
        self,
        headers: dingtalkorg_culture__1__0_models.QueryPointAutoIssueSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.QueryPointAutoIssueSettingResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkorg_culture__1__0_models.QueryPointAutoIssueSettingResponse(),
            await self.do_roarequest_async('QueryPointAutoIssueSetting', 'orgCulture_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/orgCulture/users/points', 'json', req, runtime)
        )

    def query_user_honors(
        self,
        user_id: str,
        request: dingtalkorg_culture__1__0_models.QueryUserHonorsRequest,
    ) -> dingtalkorg_culture__1__0_models.QueryUserHonorsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.QueryUserHonorsHeaders()
        return self.query_user_honors_with_options(user_id, request, headers, runtime)

    async def query_user_honors_async(
        self,
        user_id: str,
        request: dingtalkorg_culture__1__0_models.QueryUserHonorsRequest,
    ) -> dingtalkorg_culture__1__0_models.QueryUserHonorsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.QueryUserHonorsHeaders()
        return await self.query_user_honors_with_options_async(user_id, request, headers, runtime)

    def query_user_honors_with_options(
        self,
        user_id: str,
        request: dingtalkorg_culture__1__0_models.QueryUserHonorsRequest,
        headers: dingtalkorg_culture__1__0_models.QueryUserHonorsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.QueryUserHonorsResponse:
        UtilClient.validate_model(request)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
        query = {}
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
        return TeaCore.from_map(
            dingtalkorg_culture__1__0_models.QueryUserHonorsResponse(),
            self.do_roarequest('QueryUserHonors', 'orgCulture_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/orgCulture/honors/users/{user_id}', 'json', req, runtime)
        )

    async def query_user_honors_with_options_async(
        self,
        user_id: str,
        request: dingtalkorg_culture__1__0_models.QueryUserHonorsRequest,
        headers: dingtalkorg_culture__1__0_models.QueryUserHonorsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.QueryUserHonorsResponse:
        UtilClient.validate_model(request)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
        query = {}
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
        return TeaCore.from_map(
            dingtalkorg_culture__1__0_models.QueryUserHonorsResponse(),
            await self.do_roarequest_async('QueryUserHonors', 'orgCulture_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/orgCulture/honors/users/{user_id}', 'json', req, runtime)
        )

    def query_user_points(
        self,
        user_id: str,
    ) -> dingtalkorg_culture__1__0_models.QueryUserPointsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.QueryUserPointsHeaders()
        return self.query_user_points_with_options(user_id, headers, runtime)

    async def query_user_points_async(
        self,
        user_id: str,
    ) -> dingtalkorg_culture__1__0_models.QueryUserPointsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.QueryUserPointsHeaders()
        return await self.query_user_points_with_options_async(user_id, headers, runtime)

    def query_user_points_with_options(
        self,
        user_id: str,
        headers: dingtalkorg_culture__1__0_models.QueryUserPointsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.QueryUserPointsResponse:
        user_id = OpenApiUtilClient.get_encode_param(user_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkorg_culture__1__0_models.QueryUserPointsResponse(),
            self.do_roarequest('QueryUserPoints', 'orgCulture_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/orgCulture/users/{user_id}/points', 'json', req, runtime)
        )

    async def query_user_points_with_options_async(
        self,
        user_id: str,
        headers: dingtalkorg_culture__1__0_models.QueryUserPointsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.QueryUserPointsResponse:
        user_id = OpenApiUtilClient.get_encode_param(user_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkorg_culture__1__0_models.QueryUserPointsResponse(),
            await self.do_roarequest_async('QueryUserPoints', 'orgCulture_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/orgCulture/users/{user_id}/points', 'json', req, runtime)
        )

    def recall_honor(
        self,
        honor_id: str,
        request: dingtalkorg_culture__1__0_models.RecallHonorRequest,
    ) -> dingtalkorg_culture__1__0_models.RecallHonorResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.RecallHonorHeaders()
        return self.recall_honor_with_options(honor_id, request, headers, runtime)

    async def recall_honor_async(
        self,
        honor_id: str,
        request: dingtalkorg_culture__1__0_models.RecallHonorRequest,
    ) -> dingtalkorg_culture__1__0_models.RecallHonorResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.RecallHonorHeaders()
        return await self.recall_honor_with_options_async(honor_id, request, headers, runtime)

    def recall_honor_with_options(
        self,
        honor_id: str,
        request: dingtalkorg_culture__1__0_models.RecallHonorRequest,
        headers: dingtalkorg_culture__1__0_models.RecallHonorHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.RecallHonorResponse:
        UtilClient.validate_model(request)
        honor_id = OpenApiUtilClient.get_encode_param(honor_id)
        body = {}
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
        return TeaCore.from_map(
            dingtalkorg_culture__1__0_models.RecallHonorResponse(),
            self.do_roarequest('RecallHonor', 'orgCulture_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/orgCulture/honors/{honor_id}/recall', 'json', req, runtime)
        )

    async def recall_honor_with_options_async(
        self,
        honor_id: str,
        request: dingtalkorg_culture__1__0_models.RecallHonorRequest,
        headers: dingtalkorg_culture__1__0_models.RecallHonorHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.RecallHonorResponse:
        UtilClient.validate_model(request)
        honor_id = OpenApiUtilClient.get_encode_param(honor_id)
        body = {}
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
        return TeaCore.from_map(
            dingtalkorg_culture__1__0_models.RecallHonorResponse(),
            await self.do_roarequest_async('RecallHonor', 'orgCulture_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/orgCulture/honors/{honor_id}/recall', 'json', req, runtime)
        )

    def update_auto_issue_point(
        self,
        request: dingtalkorg_culture__1__0_models.UpdateAutoIssuePointRequest,
    ) -> dingtalkorg_culture__1__0_models.UpdateAutoIssuePointResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.UpdateAutoIssuePointHeaders()
        return self.update_auto_issue_point_with_options(request, headers, runtime)

    async def update_auto_issue_point_async(
        self,
        request: dingtalkorg_culture__1__0_models.UpdateAutoIssuePointRequest,
    ) -> dingtalkorg_culture__1__0_models.UpdateAutoIssuePointResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.UpdateAutoIssuePointHeaders()
        return await self.update_auto_issue_point_with_options_async(request, headers, runtime)

    def update_auto_issue_point_with_options(
        self,
        request: dingtalkorg_culture__1__0_models.UpdateAutoIssuePointRequest,
        headers: dingtalkorg_culture__1__0_models.UpdateAutoIssuePointHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.UpdateAutoIssuePointResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.point_auto_num):
            body['pointAutoNum'] = request.point_auto_num
        if not UtilClient.is_unset(request.point_auto_state):
            body['pointAutoState'] = request.point_auto_state
        if not UtilClient.is_unset(request.point_auto_time):
            body['pointAutoTime'] = request.point_auto_time
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
        return TeaCore.from_map(
            dingtalkorg_culture__1__0_models.UpdateAutoIssuePointResponse(),
            self.do_roarequest('UpdateAutoIssuePoint', 'orgCulture_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/orgCulture/users/points/set', 'json', req, runtime)
        )

    async def update_auto_issue_point_with_options_async(
        self,
        request: dingtalkorg_culture__1__0_models.UpdateAutoIssuePointRequest,
        headers: dingtalkorg_culture__1__0_models.UpdateAutoIssuePointHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.UpdateAutoIssuePointResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.point_auto_num):
            body['pointAutoNum'] = request.point_auto_num
        if not UtilClient.is_unset(request.point_auto_state):
            body['pointAutoState'] = request.point_auto_state
        if not UtilClient.is_unset(request.point_auto_time):
            body['pointAutoTime'] = request.point_auto_time
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
        return TeaCore.from_map(
            dingtalkorg_culture__1__0_models.UpdateAutoIssuePointResponse(),
            await self.do_roarequest_async('UpdateAutoIssuePoint', 'orgCulture_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/orgCulture/users/points/set', 'json', req, runtime)
        )

    def update_point_action_auto_assign_rule(
        self,
        request: dingtalkorg_culture__1__0_models.UpdatePointActionAutoAssignRuleRequest,
    ) -> dingtalkorg_culture__1__0_models.UpdatePointActionAutoAssignRuleResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.UpdatePointActionAutoAssignRuleHeaders()
        return self.update_point_action_auto_assign_rule_with_options(request, headers, runtime)

    async def update_point_action_auto_assign_rule_async(
        self,
        request: dingtalkorg_culture__1__0_models.UpdatePointActionAutoAssignRuleRequest,
    ) -> dingtalkorg_culture__1__0_models.UpdatePointActionAutoAssignRuleResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.UpdatePointActionAutoAssignRuleHeaders()
        return await self.update_point_action_auto_assign_rule_with_options_async(request, headers, runtime)

    def update_point_action_auto_assign_rule_with_options(
        self,
        request: dingtalkorg_culture__1__0_models.UpdatePointActionAutoAssignRuleRequest,
        headers: dingtalkorg_culture__1__0_models.UpdatePointActionAutoAssignRuleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.UpdatePointActionAutoAssignRuleResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.update_point_rule_request_dtolist):
            body['updatePointRuleRequestDTOList'] = request.update_point_rule_request_dtolist
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
        return TeaCore.from_map(
            dingtalkorg_culture__1__0_models.UpdatePointActionAutoAssignRuleResponse(),
            self.do_roarequest('UpdatePointActionAutoAssignRule', 'orgCulture_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/orgCulture/users/points/actionRules', 'json', req, runtime)
        )

    async def update_point_action_auto_assign_rule_with_options_async(
        self,
        request: dingtalkorg_culture__1__0_models.UpdatePointActionAutoAssignRuleRequest,
        headers: dingtalkorg_culture__1__0_models.UpdatePointActionAutoAssignRuleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.UpdatePointActionAutoAssignRuleResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.update_point_rule_request_dtolist):
            body['updatePointRuleRequestDTOList'] = request.update_point_rule_request_dtolist
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
        return TeaCore.from_map(
            dingtalkorg_culture__1__0_models.UpdatePointActionAutoAssignRuleResponse(),
            await self.do_roarequest_async('UpdatePointActionAutoAssignRule', 'orgCulture_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/orgCulture/users/points/actionRules', 'json', req, runtime)
        )

    def wear_org_honor(
        self,
        honor_id: str,
        request: dingtalkorg_culture__1__0_models.WearOrgHonorRequest,
    ) -> dingtalkorg_culture__1__0_models.WearOrgHonorResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.WearOrgHonorHeaders()
        return self.wear_org_honor_with_options(honor_id, request, headers, runtime)

    async def wear_org_honor_async(
        self,
        honor_id: str,
        request: dingtalkorg_culture__1__0_models.WearOrgHonorRequest,
    ) -> dingtalkorg_culture__1__0_models.WearOrgHonorResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkorg_culture__1__0_models.WearOrgHonorHeaders()
        return await self.wear_org_honor_with_options_async(honor_id, request, headers, runtime)

    def wear_org_honor_with_options(
        self,
        honor_id: str,
        request: dingtalkorg_culture__1__0_models.WearOrgHonorRequest,
        headers: dingtalkorg_culture__1__0_models.WearOrgHonorHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.WearOrgHonorResponse:
        UtilClient.validate_model(request)
        honor_id = OpenApiUtilClient.get_encode_param(honor_id)
        body = {}
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.wear):
            body['wear'] = request.wear
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
            dingtalkorg_culture__1__0_models.WearOrgHonorResponse(),
            self.do_roarequest('WearOrgHonor', 'orgCulture_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/orgCulture/honors/{honor_id}/wear', 'json', req, runtime)
        )

    async def wear_org_honor_with_options_async(
        self,
        honor_id: str,
        request: dingtalkorg_culture__1__0_models.WearOrgHonorRequest,
        headers: dingtalkorg_culture__1__0_models.WearOrgHonorHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkorg_culture__1__0_models.WearOrgHonorResponse:
        UtilClient.validate_model(request)
        honor_id = OpenApiUtilClient.get_encode_param(honor_id)
        body = {}
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.wear):
            body['wear'] = request.wear
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
            dingtalkorg_culture__1__0_models.WearOrgHonorResponse(),
            await self.do_roarequest_async('WearOrgHonor', 'orgCulture_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/orgCulture/honors/{honor_id}/wear', 'json', req, runtime)
        )
