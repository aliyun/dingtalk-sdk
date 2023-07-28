# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.edu_1_0 import models as dingtalkedu__1__0_models
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

    def activate_device_with_options(
        self,
        request: dingtalkedu__1__0_models.ActivateDeviceRequest,
        headers: dingtalkedu__1__0_models.ActivateDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ActivateDeviceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.license_key):
            body['licenseKey'] = request.license_key
        if not UtilClient.is_unset(request.model):
            body['model'] = request.model
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='ActivateDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/devices/activate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ActivateDeviceResponse(),
            self.execute(params, req, runtime)
        )

    async def activate_device_with_options_async(
        self,
        request: dingtalkedu__1__0_models.ActivateDeviceRequest,
        headers: dingtalkedu__1__0_models.ActivateDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ActivateDeviceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.license_key):
            body['licenseKey'] = request.license_key
        if not UtilClient.is_unset(request.model):
            body['model'] = request.model
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='ActivateDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/devices/activate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ActivateDeviceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def activate_device(
        self,
        request: dingtalkedu__1__0_models.ActivateDeviceRequest,
    ) -> dingtalkedu__1__0_models.ActivateDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ActivateDeviceHeaders()
        return self.activate_device_with_options(request, headers, runtime)

    async def activate_device_async(
        self,
        request: dingtalkedu__1__0_models.ActivateDeviceRequest,
    ) -> dingtalkedu__1__0_models.ActivateDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ActivateDeviceHeaders()
        return await self.activate_device_with_options_async(request, headers, runtime)

    def add_device_with_options(
        self,
        request: dingtalkedu__1__0_models.AddDeviceRequest,
        headers: dingtalkedu__1__0_models.AddDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.AddDeviceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.model):
            body['model'] = request.model
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='AddDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/devices',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.AddDeviceResponse(),
            self.execute(params, req, runtime)
        )

    async def add_device_with_options_async(
        self,
        request: dingtalkedu__1__0_models.AddDeviceRequest,
        headers: dingtalkedu__1__0_models.AddDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.AddDeviceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.model):
            body['model'] = request.model
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='AddDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/devices',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.AddDeviceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_device(
        self,
        request: dingtalkedu__1__0_models.AddDeviceRequest,
    ) -> dingtalkedu__1__0_models.AddDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.AddDeviceHeaders()
        return self.add_device_with_options(request, headers, runtime)

    async def add_device_async(
        self,
        request: dingtalkedu__1__0_models.AddDeviceRequest,
    ) -> dingtalkedu__1__0_models.AddDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.AddDeviceHeaders()
        return await self.add_device_with_options_async(request, headers, runtime)

    def add_school_config_with_options(
        self,
        request: dingtalkedu__1__0_models.AddSchoolConfigRequest,
        headers: dingtalkedu__1__0_models.AddSchoolConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.AddSchoolConfigResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.operator_name):
            body['operatorName'] = request.operator_name
        if not UtilClient.is_unset(request.temperature_up_limit):
            body['temperatureUpLimit'] = request.temperature_up_limit
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
            action='AddSchoolConfig',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/schools/configurations',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.AddSchoolConfigResponse(),
            self.execute(params, req, runtime)
        )

    async def add_school_config_with_options_async(
        self,
        request: dingtalkedu__1__0_models.AddSchoolConfigRequest,
        headers: dingtalkedu__1__0_models.AddSchoolConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.AddSchoolConfigResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.operator_name):
            body['operatorName'] = request.operator_name
        if not UtilClient.is_unset(request.temperature_up_limit):
            body['temperatureUpLimit'] = request.temperature_up_limit
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
            action='AddSchoolConfig',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/schools/configurations',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.AddSchoolConfigResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_school_config(
        self,
        request: dingtalkedu__1__0_models.AddSchoolConfigRequest,
    ) -> dingtalkedu__1__0_models.AddSchoolConfigResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.AddSchoolConfigHeaders()
        return self.add_school_config_with_options(request, headers, runtime)

    async def add_school_config_async(
        self,
        request: dingtalkedu__1__0_models.AddSchoolConfigRequest,
    ) -> dingtalkedu__1__0_models.AddSchoolConfigResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.AddSchoolConfigHeaders()
        return await self.add_school_config_with_options_async(request, headers, runtime)

    def assign_class_with_options(
        self,
        request: dingtalkedu__1__0_models.AssignClassRequest,
        headers: dingtalkedu__1__0_models.AssignClassHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.AssignClassResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.is_finish):
            body['isFinish'] = request.is_finish
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.student_id):
            body['studentId'] = request.student_id
        if not UtilClient.is_unset(request.task_id):
            body['taskId'] = request.task_id
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
            action='AssignClass',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/newGrades/tasks/students/classes/assign',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.AssignClassResponse(),
            self.execute(params, req, runtime)
        )

    async def assign_class_with_options_async(
        self,
        request: dingtalkedu__1__0_models.AssignClassRequest,
        headers: dingtalkedu__1__0_models.AssignClassHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.AssignClassResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.is_finish):
            body['isFinish'] = request.is_finish
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.student_id):
            body['studentId'] = request.student_id
        if not UtilClient.is_unset(request.task_id):
            body['taskId'] = request.task_id
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
            action='AssignClass',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/newGrades/tasks/students/classes/assign',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.AssignClassResponse(),
            await self.execute_async(params, req, runtime)
        )

    def assign_class(
        self,
        request: dingtalkedu__1__0_models.AssignClassRequest,
    ) -> dingtalkedu__1__0_models.AssignClassResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.AssignClassHeaders()
        return self.assign_class_with_options(request, headers, runtime)

    async def assign_class_async(
        self,
        request: dingtalkedu__1__0_models.AssignClassRequest,
    ) -> dingtalkedu__1__0_models.AssignClassResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.AssignClassHeaders()
        return await self.assign_class_with_options_async(request, headers, runtime)

    def batch_create_with_options(
        self,
        request: dingtalkedu__1__0_models.BatchCreateRequest,
        headers: dingtalkedu__1__0_models.BatchCreateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.BatchCreateResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.card_biz_code):
            body['cardBizCode'] = request.card_biz_code
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.identifier):
            body['identifier'] = request.identifier
        if not UtilClient.is_unset(request.js_version):
            body['jsVersion'] = request.js_version
        if not UtilClient.is_unset(request.source_type):
            body['sourceType'] = request.source_type
        if not UtilClient.is_unset(request.userid):
            body['userid'] = request.userid
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
            action='BatchCreate',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/cards',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.BatchCreateResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_create_with_options_async(
        self,
        request: dingtalkedu__1__0_models.BatchCreateRequest,
        headers: dingtalkedu__1__0_models.BatchCreateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.BatchCreateResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.card_biz_code):
            body['cardBizCode'] = request.card_biz_code
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.identifier):
            body['identifier'] = request.identifier
        if not UtilClient.is_unset(request.js_version):
            body['jsVersion'] = request.js_version
        if not UtilClient.is_unset(request.source_type):
            body['sourceType'] = request.source_type
        if not UtilClient.is_unset(request.userid):
            body['userid'] = request.userid
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
            action='BatchCreate',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/cards',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.BatchCreateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_create(
        self,
        request: dingtalkedu__1__0_models.BatchCreateRequest,
    ) -> dingtalkedu__1__0_models.BatchCreateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.BatchCreateHeaders()
        return self.batch_create_with_options(request, headers, runtime)

    async def batch_create_async(
        self,
        request: dingtalkedu__1__0_models.BatchCreateRequest,
    ) -> dingtalkedu__1__0_models.BatchCreateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.BatchCreateHeaders()
        return await self.batch_create_with_options_async(request, headers, runtime)

    def batch_org_create_hwwith_options(
        self,
        request: dingtalkedu__1__0_models.BatchOrgCreateHWRequest,
        headers: dingtalkedu__1__0_models.BatchOrgCreateHWHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.BatchOrgCreateHWResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attributes):
            body['attributes'] = request.attributes
        if not UtilClient.is_unset(request.biz_code):
            body['bizCode'] = request.biz_code
        if not UtilClient.is_unset(request.course_name):
            body['courseName'] = request.course_name
        if not UtilClient.is_unset(request.hw_content):
            body['hwContent'] = request.hw_content
        if not UtilClient.is_unset(request.hw_deadline):
            body['hwDeadline'] = request.hw_deadline
        if not UtilClient.is_unset(request.hw_deadline_open):
            body['hwDeadlineOpen'] = request.hw_deadline_open
        if not UtilClient.is_unset(request.hw_media):
            body['hwMedia'] = request.hw_media
        if not UtilClient.is_unset(request.hw_photo):
            body['hwPhoto'] = request.hw_photo
        if not UtilClient.is_unset(request.hw_title):
            body['hwTitle'] = request.hw_title
        if not UtilClient.is_unset(request.hw_type):
            body['hwType'] = request.hw_type
        if not UtilClient.is_unset(request.hw_video):
            body['hwVideo'] = request.hw_video
        if not UtilClient.is_unset(request.identifier):
            body['identifier'] = request.identifier
        if not UtilClient.is_unset(request.open_select_item_list):
            body['openSelectItemList'] = request.open_select_item_list
        if not UtilClient.is_unset(request.scheduled_release):
            body['scheduledRelease'] = request.scheduled_release
        if not UtilClient.is_unset(request.scheduled_time):
            body['scheduledTime'] = request.scheduled_time
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.target_role):
            body['targetRole'] = request.target_role
        if not UtilClient.is_unset(request.teacher_name):
            body['teacherName'] = request.teacher_name
        if not UtilClient.is_unset(request.teacher_user_id):
            body['teacherUserId'] = request.teacher_user_id
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
            action='BatchOrgCreateHW',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/homeworks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.BatchOrgCreateHWResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_org_create_hwwith_options_async(
        self,
        request: dingtalkedu__1__0_models.BatchOrgCreateHWRequest,
        headers: dingtalkedu__1__0_models.BatchOrgCreateHWHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.BatchOrgCreateHWResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attributes):
            body['attributes'] = request.attributes
        if not UtilClient.is_unset(request.biz_code):
            body['bizCode'] = request.biz_code
        if not UtilClient.is_unset(request.course_name):
            body['courseName'] = request.course_name
        if not UtilClient.is_unset(request.hw_content):
            body['hwContent'] = request.hw_content
        if not UtilClient.is_unset(request.hw_deadline):
            body['hwDeadline'] = request.hw_deadline
        if not UtilClient.is_unset(request.hw_deadline_open):
            body['hwDeadlineOpen'] = request.hw_deadline_open
        if not UtilClient.is_unset(request.hw_media):
            body['hwMedia'] = request.hw_media
        if not UtilClient.is_unset(request.hw_photo):
            body['hwPhoto'] = request.hw_photo
        if not UtilClient.is_unset(request.hw_title):
            body['hwTitle'] = request.hw_title
        if not UtilClient.is_unset(request.hw_type):
            body['hwType'] = request.hw_type
        if not UtilClient.is_unset(request.hw_video):
            body['hwVideo'] = request.hw_video
        if not UtilClient.is_unset(request.identifier):
            body['identifier'] = request.identifier
        if not UtilClient.is_unset(request.open_select_item_list):
            body['openSelectItemList'] = request.open_select_item_list
        if not UtilClient.is_unset(request.scheduled_release):
            body['scheduledRelease'] = request.scheduled_release
        if not UtilClient.is_unset(request.scheduled_time):
            body['scheduledTime'] = request.scheduled_time
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.target_role):
            body['targetRole'] = request.target_role
        if not UtilClient.is_unset(request.teacher_name):
            body['teacherName'] = request.teacher_name
        if not UtilClient.is_unset(request.teacher_user_id):
            body['teacherUserId'] = request.teacher_user_id
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
            action='BatchOrgCreateHW',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/homeworks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.BatchOrgCreateHWResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_org_create_hw(
        self,
        request: dingtalkedu__1__0_models.BatchOrgCreateHWRequest,
    ) -> dingtalkedu__1__0_models.BatchOrgCreateHWResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.BatchOrgCreateHWHeaders()
        return self.batch_org_create_hwwith_options(request, headers, runtime)

    async def batch_org_create_hw_async(
        self,
        request: dingtalkedu__1__0_models.BatchOrgCreateHWRequest,
    ) -> dingtalkedu__1__0_models.BatchOrgCreateHWResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.BatchOrgCreateHWHeaders()
        return await self.batch_org_create_hwwith_options_async(request, headers, runtime)

    def cancel_order_with_options(
        self,
        request: dingtalkedu__1__0_models.CancelOrderRequest,
        headers: dingtalkedu__1__0_models.CancelOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CancelOrderResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
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
            action='CancelOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orders/cancel',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CancelOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def cancel_order_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CancelOrderRequest,
        headers: dingtalkedu__1__0_models.CancelOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CancelOrderResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
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
            action='CancelOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orders/cancel',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CancelOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def cancel_order(
        self,
        request: dingtalkedu__1__0_models.CancelOrderRequest,
    ) -> dingtalkedu__1__0_models.CancelOrderResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CancelOrderHeaders()
        return self.cancel_order_with_options(request, headers, runtime)

    async def cancel_order_async(
        self,
        request: dingtalkedu__1__0_models.CancelOrderRequest,
    ) -> dingtalkedu__1__0_models.CancelOrderResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CancelOrderHeaders()
        return await self.cancel_order_with_options_async(request, headers, runtime)

    def cancel_sns_order_with_options(
        self,
        request: dingtalkedu__1__0_models.CancelSnsOrderRequest,
        headers: dingtalkedu__1__0_models.CancelSnsOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CancelSnsOrderResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.alipay_app_id):
            body['alipayAppId'] = request.alipay_app_id
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
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
            action='CancelSnsOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/snsUserOrders/cancel',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CancelSnsOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def cancel_sns_order_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CancelSnsOrderRequest,
        headers: dingtalkedu__1__0_models.CancelSnsOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CancelSnsOrderResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.alipay_app_id):
            body['alipayAppId'] = request.alipay_app_id
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
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
            action='CancelSnsOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/snsUserOrders/cancel',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CancelSnsOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def cancel_sns_order(
        self,
        request: dingtalkedu__1__0_models.CancelSnsOrderRequest,
    ) -> dingtalkedu__1__0_models.CancelSnsOrderResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CancelSnsOrderHeaders()
        return self.cancel_sns_order_with_options(request, headers, runtime)

    async def cancel_sns_order_async(
        self,
        request: dingtalkedu__1__0_models.CancelSnsOrderRequest,
    ) -> dingtalkedu__1__0_models.CancelSnsOrderResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CancelSnsOrderHeaders()
        return await self.cancel_sns_order_with_options_async(request, headers, runtime)

    def cancel_user_order_with_options(
        self,
        request: dingtalkedu__1__0_models.CancelUserOrderRequest,
        headers: dingtalkedu__1__0_models.CancelUserOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CancelUserOrderResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.alipay_app_id):
            body['alipayAppId'] = request.alipay_app_id
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
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
            action='CancelUserOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/userOrders/cancel',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CancelUserOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def cancel_user_order_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CancelUserOrderRequest,
        headers: dingtalkedu__1__0_models.CancelUserOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CancelUserOrderResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.alipay_app_id):
            body['alipayAppId'] = request.alipay_app_id
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
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
            action='CancelUserOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/userOrders/cancel',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CancelUserOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def cancel_user_order(
        self,
        request: dingtalkedu__1__0_models.CancelUserOrderRequest,
    ) -> dingtalkedu__1__0_models.CancelUserOrderResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CancelUserOrderHeaders()
        return self.cancel_user_order_with_options(request, headers, runtime)

    async def cancel_user_order_async(
        self,
        request: dingtalkedu__1__0_models.CancelUserOrderRequest,
    ) -> dingtalkedu__1__0_models.CancelUserOrderResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CancelUserOrderHeaders()
        return await self.cancel_user_order_with_options_async(request, headers, runtime)

    def check_restriction_with_options(
        self,
        request: dingtalkedu__1__0_models.CheckRestrictionRequest,
        headers: dingtalkedu__1__0_models.CheckRestrictionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CheckRestrictionResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.actual_amount):
            body['actualAmount'] = request.actual_amount
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
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
            action='CheckRestriction',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/restrictions/check',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CheckRestrictionResponse(),
            self.execute(params, req, runtime)
        )

    async def check_restriction_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CheckRestrictionRequest,
        headers: dingtalkedu__1__0_models.CheckRestrictionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CheckRestrictionResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.actual_amount):
            body['actualAmount'] = request.actual_amount
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
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
            action='CheckRestriction',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/restrictions/check',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CheckRestrictionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def check_restriction(
        self,
        request: dingtalkedu__1__0_models.CheckRestrictionRequest,
    ) -> dingtalkedu__1__0_models.CheckRestrictionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CheckRestrictionHeaders()
        return self.check_restriction_with_options(request, headers, runtime)

    async def check_restriction_async(
        self,
        request: dingtalkedu__1__0_models.CheckRestrictionRequest,
    ) -> dingtalkedu__1__0_models.CheckRestrictionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CheckRestrictionHeaders()
        return await self.check_restriction_with_options_async(request, headers, runtime)

    def consume_point_with_options(
        self,
        request: dingtalkedu__1__0_models.ConsumePointRequest,
        headers: dingtalkedu__1__0_models.ConsumePointHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ConsumePointResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.amount):
            body['amount'] = request.amount
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.product_code):
            body['productCode'] = request.product_code
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
            action='ConsumePoint',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/poins/consume',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ConsumePointResponse(),
            self.execute(params, req, runtime)
        )

    async def consume_point_with_options_async(
        self,
        request: dingtalkedu__1__0_models.ConsumePointRequest,
        headers: dingtalkedu__1__0_models.ConsumePointHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ConsumePointResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.amount):
            body['amount'] = request.amount
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.product_code):
            body['productCode'] = request.product_code
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
            action='ConsumePoint',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/poins/consume',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ConsumePointResponse(),
            await self.execute_async(params, req, runtime)
        )

    def consume_point(
        self,
        request: dingtalkedu__1__0_models.ConsumePointRequest,
    ) -> dingtalkedu__1__0_models.ConsumePointResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ConsumePointHeaders()
        return self.consume_point_with_options(request, headers, runtime)

    async def consume_point_async(
        self,
        request: dingtalkedu__1__0_models.ConsumePointRequest,
    ) -> dingtalkedu__1__0_models.ConsumePointResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ConsumePointHeaders()
        return await self.consume_point_with_options_async(request, headers, runtime)

    def course_scheduling_compliment_notice_with_options(
        self,
        request: dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeRequest,
        headers: dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='CourseSchedulingComplimentNotice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/schedules/finishNotify',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeResponse(),
            self.execute(params, req, runtime)
        )

    async def course_scheduling_compliment_notice_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeRequest,
        headers: dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='CourseSchedulingComplimentNotice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/schedules/finishNotify',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def course_scheduling_compliment_notice(
        self,
        request: dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeRequest,
    ) -> dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeHeaders()
        return self.course_scheduling_compliment_notice_with_options(request, headers, runtime)

    async def course_scheduling_compliment_notice_async(
        self,
        request: dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeRequest,
    ) -> dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CourseSchedulingComplimentNoticeHeaders()
        return await self.course_scheduling_compliment_notice_with_options_async(request, headers, runtime)

    def create_app_order_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateAppOrderRequest,
        headers: dingtalkedu__1__0_models.CreateAppOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateAppOrderResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.actual_amount):
            body['actualAmount'] = request.actual_amount
        if not UtilClient.is_unset(request.alipay_app_id):
            body['alipayAppId'] = request.alipay_app_id
        if not UtilClient.is_unset(request.biz_code):
            body['bizCode'] = request.biz_code
        if not UtilClient.is_unset(request.detail_list):
            body['detailList'] = request.detail_list
        if not UtilClient.is_unset(request.label_amount):
            body['labelAmount'] = request.label_amount
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.merchant_order_no):
            body['merchantOrderNo'] = request.merchant_order_no
        if not UtilClient.is_unset(request.outer_user_id):
            body['outerUserId'] = request.outer_user_id
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.subject):
            body['subject'] = request.subject
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
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
            action='CreateAppOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/appOrders',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateAppOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def create_app_order_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateAppOrderRequest,
        headers: dingtalkedu__1__0_models.CreateAppOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateAppOrderResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.actual_amount):
            body['actualAmount'] = request.actual_amount
        if not UtilClient.is_unset(request.alipay_app_id):
            body['alipayAppId'] = request.alipay_app_id
        if not UtilClient.is_unset(request.biz_code):
            body['bizCode'] = request.biz_code
        if not UtilClient.is_unset(request.detail_list):
            body['detailList'] = request.detail_list
        if not UtilClient.is_unset(request.label_amount):
            body['labelAmount'] = request.label_amount
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.merchant_order_no):
            body['merchantOrderNo'] = request.merchant_order_no
        if not UtilClient.is_unset(request.outer_user_id):
            body['outerUserId'] = request.outer_user_id
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.subject):
            body['subject'] = request.subject
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
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
            action='CreateAppOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/appOrders',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateAppOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_app_order(
        self,
        request: dingtalkedu__1__0_models.CreateAppOrderRequest,
    ) -> dingtalkedu__1__0_models.CreateAppOrderResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateAppOrderHeaders()
        return self.create_app_order_with_options(request, headers, runtime)

    async def create_app_order_async(
        self,
        request: dingtalkedu__1__0_models.CreateAppOrderRequest,
    ) -> dingtalkedu__1__0_models.CreateAppOrderResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateAppOrderHeaders()
        return await self.create_app_order_with_options_async(request, headers, runtime)

    def create_custom_class_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateCustomClassRequest,
        headers: dingtalkedu__1__0_models.CreateCustomClassHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateCustomClassResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.custom_class):
            body['customClass'] = request.custom_class
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.super_id):
            body['superId'] = request.super_id
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
            action='CreateCustomClass',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/customClasses',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateCustomClassResponse(),
            self.execute(params, req, runtime)
        )

    async def create_custom_class_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateCustomClassRequest,
        headers: dingtalkedu__1__0_models.CreateCustomClassHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateCustomClassResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.custom_class):
            body['customClass'] = request.custom_class
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.super_id):
            body['superId'] = request.super_id
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
            action='CreateCustomClass',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/customClasses',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateCustomClassResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_custom_class(
        self,
        request: dingtalkedu__1__0_models.CreateCustomClassRequest,
    ) -> dingtalkedu__1__0_models.CreateCustomClassResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateCustomClassHeaders()
        return self.create_custom_class_with_options(request, headers, runtime)

    async def create_custom_class_async(
        self,
        request: dingtalkedu__1__0_models.CreateCustomClassRequest,
    ) -> dingtalkedu__1__0_models.CreateCustomClassResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateCustomClassHeaders()
        return await self.create_custom_class_with_options_async(request, headers, runtime)

    def create_custom_dept_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateCustomDeptRequest,
        headers: dingtalkedu__1__0_models.CreateCustomDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateCustomDeptResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.custom_dept):
            body['customDept'] = request.custom_dept
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.super_id):
            body['superId'] = request.super_id
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
            action='CreateCustomDept',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/customDepts',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateCustomDeptResponse(),
            self.execute(params, req, runtime)
        )

    async def create_custom_dept_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateCustomDeptRequest,
        headers: dingtalkedu__1__0_models.CreateCustomDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateCustomDeptResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.custom_dept):
            body['customDept'] = request.custom_dept
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.super_id):
            body['superId'] = request.super_id
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
            action='CreateCustomDept',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/customDepts',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateCustomDeptResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_custom_dept(
        self,
        request: dingtalkedu__1__0_models.CreateCustomDeptRequest,
    ) -> dingtalkedu__1__0_models.CreateCustomDeptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateCustomDeptHeaders()
        return self.create_custom_dept_with_options(request, headers, runtime)

    async def create_custom_dept_async(
        self,
        request: dingtalkedu__1__0_models.CreateCustomDeptRequest,
    ) -> dingtalkedu__1__0_models.CreateCustomDeptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateCustomDeptHeaders()
        return await self.create_custom_dept_with_options_async(request, headers, runtime)

    def create_edu_asset_space_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateEduAssetSpaceRequest,
        headers: dingtalkedu__1__0_models.CreateEduAssetSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateEduAssetSpaceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_code):
            body['bizCode'] = request.biz_code
        if not UtilClient.is_unset(request.space_desc):
            body['spaceDesc'] = request.space_desc
        if not UtilClient.is_unset(request.space_icon):
            body['spaceIcon'] = request.space_icon
        if not UtilClient.is_unset(request.space_name):
            body['spaceName'] = request.space_name
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
            action='CreateEduAssetSpace',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/assets/spaces',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateEduAssetSpaceResponse(),
            self.execute(params, req, runtime)
        )

    async def create_edu_asset_space_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateEduAssetSpaceRequest,
        headers: dingtalkedu__1__0_models.CreateEduAssetSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateEduAssetSpaceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_code):
            body['bizCode'] = request.biz_code
        if not UtilClient.is_unset(request.space_desc):
            body['spaceDesc'] = request.space_desc
        if not UtilClient.is_unset(request.space_icon):
            body['spaceIcon'] = request.space_icon
        if not UtilClient.is_unset(request.space_name):
            body['spaceName'] = request.space_name
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
            action='CreateEduAssetSpace',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/assets/spaces',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateEduAssetSpaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_edu_asset_space(
        self,
        request: dingtalkedu__1__0_models.CreateEduAssetSpaceRequest,
    ) -> dingtalkedu__1__0_models.CreateEduAssetSpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateEduAssetSpaceHeaders()
        return self.create_edu_asset_space_with_options(request, headers, runtime)

    async def create_edu_asset_space_async(
        self,
        request: dingtalkedu__1__0_models.CreateEduAssetSpaceRequest,
    ) -> dingtalkedu__1__0_models.CreateEduAssetSpaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateEduAssetSpaceHeaders()
        return await self.create_edu_asset_space_with_options_async(request, headers, runtime)

    def create_fulfil_record_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateFulfilRecordRequest,
        headers: dingtalkedu__1__0_models.CreateFulfilRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateFulfilRecordResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_time):
            body['bizTime'] = request.biz_time
        if not UtilClient.is_unset(request.ext_info):
            body['extInfo'] = request.ext_info
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
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
            action='CreateFulfilRecord',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/fulfilRecords',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateFulfilRecordResponse(),
            self.execute(params, req, runtime)
        )

    async def create_fulfil_record_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateFulfilRecordRequest,
        headers: dingtalkedu__1__0_models.CreateFulfilRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateFulfilRecordResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_time):
            body['bizTime'] = request.biz_time
        if not UtilClient.is_unset(request.ext_info):
            body['extInfo'] = request.ext_info
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
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
            action='CreateFulfilRecord',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/fulfilRecords',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateFulfilRecordResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_fulfil_record(
        self,
        request: dingtalkedu__1__0_models.CreateFulfilRecordRequest,
    ) -> dingtalkedu__1__0_models.CreateFulfilRecordResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateFulfilRecordHeaders()
        return self.create_fulfil_record_with_options(request, headers, runtime)

    async def create_fulfil_record_async(
        self,
        request: dingtalkedu__1__0_models.CreateFulfilRecordRequest,
    ) -> dingtalkedu__1__0_models.CreateFulfilRecordResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateFulfilRecordHeaders()
        return await self.create_fulfil_record_with_options_async(request, headers, runtime)

    def create_invite_url_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateInviteUrlRequest,
        headers: dingtalkedu__1__0_models.CreateInviteUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateInviteUrlResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.auth_code):
            body['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.target_corp_id):
            body['targetCorpId'] = request.target_corp_id
        if not UtilClient.is_unset(request.target_operator):
            body['targetOperator'] = request.target_operator
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
            action='CreateInviteUrl',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/orgRelations/inviteUrls',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateInviteUrlResponse(),
            self.execute(params, req, runtime)
        )

    async def create_invite_url_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateInviteUrlRequest,
        headers: dingtalkedu__1__0_models.CreateInviteUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateInviteUrlResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.auth_code):
            body['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.target_corp_id):
            body['targetCorpId'] = request.target_corp_id
        if not UtilClient.is_unset(request.target_operator):
            body['targetOperator'] = request.target_operator
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
            action='CreateInviteUrl',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/orgRelations/inviteUrls',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateInviteUrlResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_invite_url(
        self,
        request: dingtalkedu__1__0_models.CreateInviteUrlRequest,
    ) -> dingtalkedu__1__0_models.CreateInviteUrlResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateInviteUrlHeaders()
        return self.create_invite_url_with_options(request, headers, runtime)

    async def create_invite_url_async(
        self,
        request: dingtalkedu__1__0_models.CreateInviteUrlRequest,
    ) -> dingtalkedu__1__0_models.CreateInviteUrlResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateInviteUrlHeaders()
        return await self.create_invite_url_with_options_async(request, headers, runtime)

    def create_item_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateItemRequest,
        headers: dingtalkedu__1__0_models.CreateItemHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateItemResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.effect_type):
            body['effectType'] = request.effect_type
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.opt_user):
            body['optUser'] = request.opt_user
        if not UtilClient.is_unset(request.period_type):
            body['periodType'] = request.period_type
        if not UtilClient.is_unset(request.price):
            body['price'] = request.price
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='CreateItem',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/items',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateItemResponse(),
            self.execute(params, req, runtime)
        )

    async def create_item_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateItemRequest,
        headers: dingtalkedu__1__0_models.CreateItemHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateItemResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.effect_type):
            body['effectType'] = request.effect_type
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.opt_user):
            body['optUser'] = request.opt_user
        if not UtilClient.is_unset(request.period_type):
            body['periodType'] = request.period_type
        if not UtilClient.is_unset(request.price):
            body['price'] = request.price
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='CreateItem',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/items',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateItemResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_item(
        self,
        request: dingtalkedu__1__0_models.CreateItemRequest,
    ) -> dingtalkedu__1__0_models.CreateItemResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateItemHeaders()
        return self.create_item_with_options(request, headers, runtime)

    async def create_item_async(
        self,
        request: dingtalkedu__1__0_models.CreateItemRequest,
    ) -> dingtalkedu__1__0_models.CreateItemResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateItemHeaders()
        return await self.create_item_with_options_async(request, headers, runtime)

    def create_order_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateOrderRequest,
        headers: dingtalkedu__1__0_models.CreateOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateOrderResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.actual_amount):
            body['actualAmount'] = request.actual_amount
        if not UtilClient.is_unset(request.create_time):
            body['createTime'] = request.create_time
        if not UtilClient.is_unset(request.detail_list):
            body['detailList'] = request.detail_list
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.ftoken):
            body['ftoken'] = request.ftoken
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.terminal_params):
            body['terminalParams'] = request.terminal_params
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
        if not UtilClient.is_unset(request.total_amount):
            body['totalAmount'] = request.total_amount
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.version):
            body['version'] = request.version
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
            action='CreateOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orders',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def create_order_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateOrderRequest,
        headers: dingtalkedu__1__0_models.CreateOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateOrderResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.actual_amount):
            body['actualAmount'] = request.actual_amount
        if not UtilClient.is_unset(request.create_time):
            body['createTime'] = request.create_time
        if not UtilClient.is_unset(request.detail_list):
            body['detailList'] = request.detail_list
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.ftoken):
            body['ftoken'] = request.ftoken
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.terminal_params):
            body['terminalParams'] = request.terminal_params
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
        if not UtilClient.is_unset(request.total_amount):
            body['totalAmount'] = request.total_amount
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.version):
            body['version'] = request.version
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
            action='CreateOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orders',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_order(
        self,
        request: dingtalkedu__1__0_models.CreateOrderRequest,
    ) -> dingtalkedu__1__0_models.CreateOrderResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateOrderHeaders()
        return self.create_order_with_options(request, headers, runtime)

    async def create_order_async(
        self,
        request: dingtalkedu__1__0_models.CreateOrderRequest,
    ) -> dingtalkedu__1__0_models.CreateOrderResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateOrderHeaders()
        return await self.create_order_with_options_async(request, headers, runtime)

    def create_order_flow_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateOrderFlowRequest,
        headers: dingtalkedu__1__0_models.CreateOrderFlowHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateOrderFlowResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.actual_amount):
            body['actualAmount'] = request.actual_amount
        if not UtilClient.is_unset(request.alipay_uid):
            body['alipayUid'] = request.alipay_uid
        if not UtilClient.is_unset(request.create_time):
            body['createTime'] = request.create_time
        if not UtilClient.is_unset(request.detail_list):
            body['detailList'] = request.detail_list
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.guardian_user_id):
            body['guardianUserId'] = request.guardian_user_id
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
        if not UtilClient.is_unset(request.total_amount):
            body['totalAmount'] = request.total_amount
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
            action='CreateOrderFlow',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orders/flows',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateOrderFlowResponse(),
            self.execute(params, req, runtime)
        )

    async def create_order_flow_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateOrderFlowRequest,
        headers: dingtalkedu__1__0_models.CreateOrderFlowHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateOrderFlowResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.actual_amount):
            body['actualAmount'] = request.actual_amount
        if not UtilClient.is_unset(request.alipay_uid):
            body['alipayUid'] = request.alipay_uid
        if not UtilClient.is_unset(request.create_time):
            body['createTime'] = request.create_time
        if not UtilClient.is_unset(request.detail_list):
            body['detailList'] = request.detail_list
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.guardian_user_id):
            body['guardianUserId'] = request.guardian_user_id
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
        if not UtilClient.is_unset(request.total_amount):
            body['totalAmount'] = request.total_amount
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
            action='CreateOrderFlow',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orders/flows',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateOrderFlowResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_order_flow(
        self,
        request: dingtalkedu__1__0_models.CreateOrderFlowRequest,
    ) -> dingtalkedu__1__0_models.CreateOrderFlowResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateOrderFlowHeaders()
        return self.create_order_flow_with_options(request, headers, runtime)

    async def create_order_flow_async(
        self,
        request: dingtalkedu__1__0_models.CreateOrderFlowRequest,
    ) -> dingtalkedu__1__0_models.CreateOrderFlowResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateOrderFlowHeaders()
        return await self.create_order_flow_with_options_async(request, headers, runtime)

    def create_physical_classroom_with_options(
        self,
        request: dingtalkedu__1__0_models.CreatePhysicalClassroomRequest,
        headers: dingtalkedu__1__0_models.CreatePhysicalClassroomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreatePhysicalClassroomResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.classroom_building):
            body['classroomBuilding'] = request.classroom_building
        if not UtilClient.is_unset(request.classroom_campus):
            body['classroomCampus'] = request.classroom_campus
        if not UtilClient.is_unset(request.classroom_floor):
            body['classroomFloor'] = request.classroom_floor
        if not UtilClient.is_unset(request.classroom_name):
            body['classroomName'] = request.classroom_name
        if not UtilClient.is_unset(request.classroom_number):
            body['classroomNumber'] = request.classroom_number
        if not UtilClient.is_unset(request.direct_broadcast):
            body['directBroadcast'] = request.direct_broadcast
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
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
            action='CreatePhysicalClassroom',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/physicalClassrooms',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreatePhysicalClassroomResponse(),
            self.execute(params, req, runtime)
        )

    async def create_physical_classroom_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreatePhysicalClassroomRequest,
        headers: dingtalkedu__1__0_models.CreatePhysicalClassroomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreatePhysicalClassroomResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.classroom_building):
            body['classroomBuilding'] = request.classroom_building
        if not UtilClient.is_unset(request.classroom_campus):
            body['classroomCampus'] = request.classroom_campus
        if not UtilClient.is_unset(request.classroom_floor):
            body['classroomFloor'] = request.classroom_floor
        if not UtilClient.is_unset(request.classroom_name):
            body['classroomName'] = request.classroom_name
        if not UtilClient.is_unset(request.classroom_number):
            body['classroomNumber'] = request.classroom_number
        if not UtilClient.is_unset(request.direct_broadcast):
            body['directBroadcast'] = request.direct_broadcast
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
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
            action='CreatePhysicalClassroom',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/physicalClassrooms',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreatePhysicalClassroomResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_physical_classroom(
        self,
        request: dingtalkedu__1__0_models.CreatePhysicalClassroomRequest,
    ) -> dingtalkedu__1__0_models.CreatePhysicalClassroomResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreatePhysicalClassroomHeaders()
        return self.create_physical_classroom_with_options(request, headers, runtime)

    async def create_physical_classroom_async(
        self,
        request: dingtalkedu__1__0_models.CreatePhysicalClassroomRequest,
    ) -> dingtalkedu__1__0_models.CreatePhysicalClassroomResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreatePhysicalClassroomHeaders()
        return await self.create_physical_classroom_with_options_async(request, headers, runtime)

    def create_refund_flow_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateRefundFlowRequest,
        headers: dingtalkedu__1__0_models.CreateRefundFlowHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateRefundFlowResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.operator_name):
            body['operatorName'] = request.operator_name
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
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
            action='CreateRefundFlow',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/refunds/flows',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateRefundFlowResponse(),
            self.execute(params, req, runtime)
        )

    async def create_refund_flow_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateRefundFlowRequest,
        headers: dingtalkedu__1__0_models.CreateRefundFlowHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateRefundFlowResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.operator_name):
            body['operatorName'] = request.operator_name
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
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
            action='CreateRefundFlow',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/refunds/flows',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateRefundFlowResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_refund_flow(
        self,
        request: dingtalkedu__1__0_models.CreateRefundFlowRequest,
    ) -> dingtalkedu__1__0_models.CreateRefundFlowResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateRefundFlowHeaders()
        return self.create_refund_flow_with_options(request, headers, runtime)

    async def create_refund_flow_async(
        self,
        request: dingtalkedu__1__0_models.CreateRefundFlowRequest,
    ) -> dingtalkedu__1__0_models.CreateRefundFlowResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateRefundFlowHeaders()
        return await self.create_refund_flow_with_options_async(request, headers, runtime)

    def create_remote_class_course_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateRemoteClassCourseRequest,
        headers: dingtalkedu__1__0_models.CreateRemoteClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateRemoteClassCourseResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attend_participants):
            body['attendParticipants'] = request.attend_participants
        if not UtilClient.is_unset(request.auth_code):
            body['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.course_name):
            body['courseName'] = request.course_name
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.teaching_participant):
            body['teachingParticipant'] = request.teaching_participant
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
            action='CreateRemoteClassCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/courses',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateRemoteClassCourseResponse(),
            self.execute(params, req, runtime)
        )

    async def create_remote_class_course_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateRemoteClassCourseRequest,
        headers: dingtalkedu__1__0_models.CreateRemoteClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateRemoteClassCourseResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attend_participants):
            body['attendParticipants'] = request.attend_participants
        if not UtilClient.is_unset(request.auth_code):
            body['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.course_name):
            body['courseName'] = request.course_name
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.teaching_participant):
            body['teachingParticipant'] = request.teaching_participant
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
            action='CreateRemoteClassCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/courses',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateRemoteClassCourseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_remote_class_course(
        self,
        request: dingtalkedu__1__0_models.CreateRemoteClassCourseRequest,
    ) -> dingtalkedu__1__0_models.CreateRemoteClassCourseResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateRemoteClassCourseHeaders()
        return self.create_remote_class_course_with_options(request, headers, runtime)

    async def create_remote_class_course_async(
        self,
        request: dingtalkedu__1__0_models.CreateRemoteClassCourseRequest,
    ) -> dingtalkedu__1__0_models.CreateRemoteClassCourseResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateRemoteClassCourseHeaders()
        return await self.create_remote_class_course_with_options_async(request, headers, runtime)

    def create_section_config_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateSectionConfigRequest,
        headers: dingtalkedu__1__0_models.CreateSectionConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateSectionConfigResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.section_configs):
            body['sectionConfigs'] = request.section_configs
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
            action='CreateSectionConfig',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/sectionConfigs',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateSectionConfigResponse(),
            self.execute(params, req, runtime)
        )

    async def create_section_config_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateSectionConfigRequest,
        headers: dingtalkedu__1__0_models.CreateSectionConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateSectionConfigResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.section_configs):
            body['sectionConfigs'] = request.section_configs
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
            action='CreateSectionConfig',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/sectionConfigs',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateSectionConfigResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_section_config(
        self,
        request: dingtalkedu__1__0_models.CreateSectionConfigRequest,
    ) -> dingtalkedu__1__0_models.CreateSectionConfigResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateSectionConfigHeaders()
        return self.create_section_config_with_options(request, headers, runtime)

    async def create_section_config_async(
        self,
        request: dingtalkedu__1__0_models.CreateSectionConfigRequest,
    ) -> dingtalkedu__1__0_models.CreateSectionConfigResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateSectionConfigHeaders()
        return await self.create_section_config_with_options_async(request, headers, runtime)

    def create_sns_app_order_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateSnsAppOrderRequest,
        headers: dingtalkedu__1__0_models.CreateSnsAppOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateSnsAppOrderResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.actual_amount):
            body['actualAmount'] = request.actual_amount
        if not UtilClient.is_unset(request.alipay_app_id):
            body['alipayAppId'] = request.alipay_app_id
        if not UtilClient.is_unset(request.biz_code):
            body['bizCode'] = request.biz_code
        if not UtilClient.is_unset(request.detail_list):
            body['detailList'] = request.detail_list
        if not UtilClient.is_unset(request.label_amount):
            body['labelAmount'] = request.label_amount
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.merchant_order_no):
            body['merchantOrderNo'] = request.merchant_order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.subject):
            body['subject'] = request.subject
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
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
            action='CreateSnsAppOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/snsAppOrders',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateSnsAppOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def create_sns_app_order_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateSnsAppOrderRequest,
        headers: dingtalkedu__1__0_models.CreateSnsAppOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateSnsAppOrderResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.actual_amount):
            body['actualAmount'] = request.actual_amount
        if not UtilClient.is_unset(request.alipay_app_id):
            body['alipayAppId'] = request.alipay_app_id
        if not UtilClient.is_unset(request.biz_code):
            body['bizCode'] = request.biz_code
        if not UtilClient.is_unset(request.detail_list):
            body['detailList'] = request.detail_list
        if not UtilClient.is_unset(request.label_amount):
            body['labelAmount'] = request.label_amount
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.merchant_order_no):
            body['merchantOrderNo'] = request.merchant_order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.subject):
            body['subject'] = request.subject
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
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
            action='CreateSnsAppOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/snsAppOrders',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateSnsAppOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_sns_app_order(
        self,
        request: dingtalkedu__1__0_models.CreateSnsAppOrderRequest,
    ) -> dingtalkedu__1__0_models.CreateSnsAppOrderResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateSnsAppOrderHeaders()
        return self.create_sns_app_order_with_options(request, headers, runtime)

    async def create_sns_app_order_async(
        self,
        request: dingtalkedu__1__0_models.CreateSnsAppOrderRequest,
    ) -> dingtalkedu__1__0_models.CreateSnsAppOrderResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateSnsAppOrderHeaders()
        return await self.create_sns_app_order_with_options_async(request, headers, runtime)

    def create_sts_token_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateStsTokenRequest,
        headers: dingtalkedu__1__0_models.CreateStsTokenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateStsTokenResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_sn):
            body['deviceSn'] = request.device_sn
        if not UtilClient.is_unset(request.sts_type):
            body['stsType'] = request.sts_type
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
            action='CreateStsToken',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/ststoken',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateStsTokenResponse(),
            self.execute(params, req, runtime)
        )

    async def create_sts_token_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateStsTokenRequest,
        headers: dingtalkedu__1__0_models.CreateStsTokenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateStsTokenResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_sn):
            body['deviceSn'] = request.device_sn
        if not UtilClient.is_unset(request.sts_type):
            body['stsType'] = request.sts_type
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
            action='CreateStsToken',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/ststoken',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateStsTokenResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_sts_token(
        self,
        request: dingtalkedu__1__0_models.CreateStsTokenRequest,
    ) -> dingtalkedu__1__0_models.CreateStsTokenResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateStsTokenHeaders()
        return self.create_sts_token_with_options(request, headers, runtime)

    async def create_sts_token_async(
        self,
        request: dingtalkedu__1__0_models.CreateStsTokenRequest,
    ) -> dingtalkedu__1__0_models.CreateStsTokenResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateStsTokenHeaders()
        return await self.create_sts_token_with_options_async(request, headers, runtime)

    def create_token_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateTokenRequest,
        headers: dingtalkedu__1__0_models.CreateTokenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateTokenResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='CreateToken',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/tokens',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateTokenResponse(),
            self.execute(params, req, runtime)
        )

    async def create_token_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateTokenRequest,
        headers: dingtalkedu__1__0_models.CreateTokenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateTokenResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='CreateToken',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/tokens',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateTokenResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_token(
        self,
        request: dingtalkedu__1__0_models.CreateTokenRequest,
    ) -> dingtalkedu__1__0_models.CreateTokenResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateTokenHeaders()
        return self.create_token_with_options(request, headers, runtime)

    async def create_token_async(
        self,
        request: dingtalkedu__1__0_models.CreateTokenRequest,
    ) -> dingtalkedu__1__0_models.CreateTokenResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateTokenHeaders()
        return await self.create_token_with_options_async(request, headers, runtime)

    def create_university_course_group_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.CreateUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateUniversityCourseGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.course_group_introduce):
            body['courseGroupIntroduce'] = request.course_group_introduce
        if not UtilClient.is_unset(request.course_group_name):
            body['courseGroupName'] = request.course_group_name
        if not UtilClient.is_unset(request.courser_group_item_models):
            body['courserGroupItemModels'] = request.courser_group_item_models
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.isv_course_group_code):
            body['isvCourseGroupCode'] = request.isv_course_group_code
        if not UtilClient.is_unset(request.period_code):
            body['periodCode'] = request.period_code
        if not UtilClient.is_unset(request.school_year):
            body['schoolYear'] = request.school_year
        if not UtilClient.is_unset(request.semester):
            body['semester'] = request.semester
        if not UtilClient.is_unset(request.subject_name):
            body['subjectName'] = request.subject_name
        if not UtilClient.is_unset(request.teacher_infos):
            body['teacherInfos'] = request.teacher_infos
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
            action='CreateUniversityCourseGroup',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courseGroups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateUniversityCourseGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def create_university_course_group_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.CreateUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateUniversityCourseGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.course_group_introduce):
            body['courseGroupIntroduce'] = request.course_group_introduce
        if not UtilClient.is_unset(request.course_group_name):
            body['courseGroupName'] = request.course_group_name
        if not UtilClient.is_unset(request.courser_group_item_models):
            body['courserGroupItemModels'] = request.courser_group_item_models
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.isv_course_group_code):
            body['isvCourseGroupCode'] = request.isv_course_group_code
        if not UtilClient.is_unset(request.period_code):
            body['periodCode'] = request.period_code
        if not UtilClient.is_unset(request.school_year):
            body['schoolYear'] = request.school_year
        if not UtilClient.is_unset(request.semester):
            body['semester'] = request.semester
        if not UtilClient.is_unset(request.subject_name):
            body['subjectName'] = request.subject_name
        if not UtilClient.is_unset(request.teacher_infos):
            body['teacherInfos'] = request.teacher_infos
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
            action='CreateUniversityCourseGroup',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courseGroups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateUniversityCourseGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_university_course_group(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.CreateUniversityCourseGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateUniversityCourseGroupHeaders()
        return self.create_university_course_group_with_options(request, headers, runtime)

    async def create_university_course_group_async(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.CreateUniversityCourseGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateUniversityCourseGroupHeaders()
        return await self.create_university_course_group_with_options_async(request, headers, runtime)

    def create_university_student_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityStudentRequest,
        headers: dingtalkedu__1__0_models.CreateUniversityStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateUniversityStudentResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.gender):
            body['gender'] = request.gender
        if not UtilClient.is_unset(request.identity_number):
            body['identityNumber'] = request.identity_number
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.student_number):
            body['studentNumber'] = request.student_number
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
            action='CreateUniversityStudent',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/students',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateUniversityStudentResponse(),
            self.execute(params, req, runtime)
        )

    async def create_university_student_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityStudentRequest,
        headers: dingtalkedu__1__0_models.CreateUniversityStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateUniversityStudentResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.gender):
            body['gender'] = request.gender
        if not UtilClient.is_unset(request.identity_number):
            body['identityNumber'] = request.identity_number
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.student_number):
            body['studentNumber'] = request.student_number
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
            action='CreateUniversityStudent',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/students',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateUniversityStudentResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_university_student(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityStudentRequest,
    ) -> dingtalkedu__1__0_models.CreateUniversityStudentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateUniversityStudentHeaders()
        return self.create_university_student_with_options(request, headers, runtime)

    async def create_university_student_async(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityStudentRequest,
    ) -> dingtalkedu__1__0_models.CreateUniversityStudentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateUniversityStudentHeaders()
        return await self.create_university_student_with_options_async(request, headers, runtime)

    def create_university_teacher_with_options(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityTeacherRequest,
        headers: dingtalkedu__1__0_models.CreateUniversityTeacherHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateUniversityTeacherResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.role):
            body['role'] = request.role
        if not UtilClient.is_unset(request.teacher_user_id):
            body['teacherUserId'] = request.teacher_user_id
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
            action='CreateUniversityTeacher',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/teachers',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateUniversityTeacherResponse(),
            self.execute(params, req, runtime)
        )

    async def create_university_teacher_with_options_async(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityTeacherRequest,
        headers: dingtalkedu__1__0_models.CreateUniversityTeacherHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.CreateUniversityTeacherResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.class_id):
            body['classId'] = request.class_id
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.role):
            body['role'] = request.role
        if not UtilClient.is_unset(request.teacher_user_id):
            body['teacherUserId'] = request.teacher_user_id
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
            action='CreateUniversityTeacher',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/teachers',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.CreateUniversityTeacherResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_university_teacher(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityTeacherRequest,
    ) -> dingtalkedu__1__0_models.CreateUniversityTeacherResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateUniversityTeacherHeaders()
        return self.create_university_teacher_with_options(request, headers, runtime)

    async def create_university_teacher_async(
        self,
        request: dingtalkedu__1__0_models.CreateUniversityTeacherRequest,
    ) -> dingtalkedu__1__0_models.CreateUniversityTeacherResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.CreateUniversityTeacherHeaders()
        return await self.create_university_teacher_with_options_async(request, headers, runtime)

    def deactivate_device_with_options(
        self,
        request: dingtalkedu__1__0_models.DeactivateDeviceRequest,
        headers: dingtalkedu__1__0_models.DeactivateDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeactivateDeviceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.model):
            body['model'] = request.model
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='DeactivateDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/devices/deactivate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeactivateDeviceResponse(),
            self.execute(params, req, runtime)
        )

    async def deactivate_device_with_options_async(
        self,
        request: dingtalkedu__1__0_models.DeactivateDeviceRequest,
        headers: dingtalkedu__1__0_models.DeactivateDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeactivateDeviceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.model):
            body['model'] = request.model
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='DeactivateDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/devices/deactivate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeactivateDeviceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def deactivate_device(
        self,
        request: dingtalkedu__1__0_models.DeactivateDeviceRequest,
    ) -> dingtalkedu__1__0_models.DeactivateDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeactivateDeviceHeaders()
        return self.deactivate_device_with_options(request, headers, runtime)

    async def deactivate_device_async(
        self,
        request: dingtalkedu__1__0_models.DeactivateDeviceRequest,
    ) -> dingtalkedu__1__0_models.DeactivateDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeactivateDeviceHeaders()
        return await self.deactivate_device_with_options_async(request, headers, runtime)

    def deduct_point_with_options(
        self,
        request: dingtalkedu__1__0_models.DeductPointRequest,
        headers: dingtalkedu__1__0_models.DeductPointHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeductPointResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.deduct_desc):
            body['deductDesc'] = request.deduct_desc
        if not UtilClient.is_unset(request.deduct_detail_url):
            body['deductDetailUrl'] = request.deduct_detail_url
        if not UtilClient.is_unset(request.deduct_num):
            body['deductNum'] = request.deduct_num
        if not UtilClient.is_unset(request.point_type):
            body['pointType'] = request.point_type
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
            action='DeductPoint',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/points/deduct',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeductPointResponse(),
            self.execute(params, req, runtime)
        )

    async def deduct_point_with_options_async(
        self,
        request: dingtalkedu__1__0_models.DeductPointRequest,
        headers: dingtalkedu__1__0_models.DeductPointHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeductPointResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.deduct_desc):
            body['deductDesc'] = request.deduct_desc
        if not UtilClient.is_unset(request.deduct_detail_url):
            body['deductDetailUrl'] = request.deduct_detail_url
        if not UtilClient.is_unset(request.deduct_num):
            body['deductNum'] = request.deduct_num
        if not UtilClient.is_unset(request.point_type):
            body['pointType'] = request.point_type
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
            action='DeductPoint',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/points/deduct',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeductPointResponse(),
            await self.execute_async(params, req, runtime)
        )

    def deduct_point(
        self,
        request: dingtalkedu__1__0_models.DeductPointRequest,
    ) -> dingtalkedu__1__0_models.DeductPointResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeductPointHeaders()
        return self.deduct_point_with_options(request, headers, runtime)

    async def deduct_point_async(
        self,
        request: dingtalkedu__1__0_models.DeductPointRequest,
    ) -> dingtalkedu__1__0_models.DeductPointResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeductPointHeaders()
        return await self.deduct_point_with_options_async(request, headers, runtime)

    def delete_dept_with_options(
        self,
        dept_id: str,
        request: dingtalkedu__1__0_models.DeleteDeptRequest,
        headers: dingtalkedu__1__0_models.DeleteDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteDeptResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
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
            action='DeleteDept',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/depts/{dept_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteDeptResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_dept_with_options_async(
        self,
        dept_id: str,
        request: dingtalkedu__1__0_models.DeleteDeptRequest,
        headers: dingtalkedu__1__0_models.DeleteDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteDeptResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
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
            action='DeleteDept',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/depts/{dept_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteDeptResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_dept(
        self,
        dept_id: str,
        request: dingtalkedu__1__0_models.DeleteDeptRequest,
    ) -> dingtalkedu__1__0_models.DeleteDeptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteDeptHeaders()
        return self.delete_dept_with_options(dept_id, request, headers, runtime)

    async def delete_dept_async(
        self,
        dept_id: str,
        request: dingtalkedu__1__0_models.DeleteDeptRequest,
    ) -> dingtalkedu__1__0_models.DeleteDeptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteDeptHeaders()
        return await self.delete_dept_with_options_async(dept_id, request, headers, runtime)

    def delete_device_with_options(
        self,
        request: dingtalkedu__1__0_models.DeleteDeviceRequest,
        headers: dingtalkedu__1__0_models.DeleteDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteDeviceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='DeleteDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/devices',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteDeviceResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_device_with_options_async(
        self,
        request: dingtalkedu__1__0_models.DeleteDeviceRequest,
        headers: dingtalkedu__1__0_models.DeleteDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteDeviceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='DeleteDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/devices',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteDeviceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_device(
        self,
        request: dingtalkedu__1__0_models.DeleteDeviceRequest,
    ) -> dingtalkedu__1__0_models.DeleteDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteDeviceHeaders()
        return self.delete_device_with_options(request, headers, runtime)

    async def delete_device_async(
        self,
        request: dingtalkedu__1__0_models.DeleteDeviceRequest,
    ) -> dingtalkedu__1__0_models.DeleteDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteDeviceHeaders()
        return await self.delete_device_with_options_async(request, headers, runtime)

    def delete_device_org_with_options(
        self,
        request: dingtalkedu__1__0_models.DeleteDeviceOrgRequest,
        headers: dingtalkedu__1__0_models.DeleteDeviceOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteDeviceOrgResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.auth_code):
            query['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.device_code):
            query['deviceCode'] = request.device_code
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
            action='DeleteDeviceOrg',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/deviceOrgs',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteDeviceOrgResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_device_org_with_options_async(
        self,
        request: dingtalkedu__1__0_models.DeleteDeviceOrgRequest,
        headers: dingtalkedu__1__0_models.DeleteDeviceOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteDeviceOrgResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.auth_code):
            query['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.device_code):
            query['deviceCode'] = request.device_code
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
            action='DeleteDeviceOrg',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/deviceOrgs',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteDeviceOrgResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_device_org(
        self,
        request: dingtalkedu__1__0_models.DeleteDeviceOrgRequest,
    ) -> dingtalkedu__1__0_models.DeleteDeviceOrgResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteDeviceOrgHeaders()
        return self.delete_device_org_with_options(request, headers, runtime)

    async def delete_device_org_async(
        self,
        request: dingtalkedu__1__0_models.DeleteDeviceOrgRequest,
    ) -> dingtalkedu__1__0_models.DeleteDeviceOrgResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteDeviceOrgHeaders()
        return await self.delete_device_org_with_options_async(request, headers, runtime)

    def delete_guardian_with_options(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteGuardianRequest,
        headers: dingtalkedu__1__0_models.DeleteGuardianHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteGuardianResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        if not UtilClient.is_unset(request.stu_id):
            query['stuId'] = request.stu_id
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
            action='DeleteGuardian',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/classes/{class_id}/guardians/{user_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteGuardianResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_guardian_with_options_async(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteGuardianRequest,
        headers: dingtalkedu__1__0_models.DeleteGuardianHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteGuardianResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        if not UtilClient.is_unset(request.stu_id):
            query['stuId'] = request.stu_id
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
            action='DeleteGuardian',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/classes/{class_id}/guardians/{user_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteGuardianResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_guardian(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteGuardianRequest,
    ) -> dingtalkedu__1__0_models.DeleteGuardianResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteGuardianHeaders()
        return self.delete_guardian_with_options(class_id, user_id, request, headers, runtime)

    async def delete_guardian_async(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteGuardianRequest,
    ) -> dingtalkedu__1__0_models.DeleteGuardianResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteGuardianHeaders()
        return await self.delete_guardian_with_options_async(class_id, user_id, request, headers, runtime)

    def delete_org_relation_with_options(
        self,
        request: dingtalkedu__1__0_models.DeleteOrgRelationRequest,
        headers: dingtalkedu__1__0_models.DeleteOrgRelationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteOrgRelationResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.auth_code):
            query['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.target_corp_id):
            query['targetCorpId'] = request.target_corp_id
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
            action='DeleteOrgRelation',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/orgRelations',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteOrgRelationResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_org_relation_with_options_async(
        self,
        request: dingtalkedu__1__0_models.DeleteOrgRelationRequest,
        headers: dingtalkedu__1__0_models.DeleteOrgRelationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteOrgRelationResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.auth_code):
            query['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.target_corp_id):
            query['targetCorpId'] = request.target_corp_id
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
            action='DeleteOrgRelation',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/orgRelations',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteOrgRelationResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_org_relation(
        self,
        request: dingtalkedu__1__0_models.DeleteOrgRelationRequest,
    ) -> dingtalkedu__1__0_models.DeleteOrgRelationResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteOrgRelationHeaders()
        return self.delete_org_relation_with_options(request, headers, runtime)

    async def delete_org_relation_async(
        self,
        request: dingtalkedu__1__0_models.DeleteOrgRelationRequest,
    ) -> dingtalkedu__1__0_models.DeleteOrgRelationResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteOrgRelationHeaders()
        return await self.delete_org_relation_with_options_async(request, headers, runtime)

    def delete_physical_classroom_with_options(
        self,
        request: dingtalkedu__1__0_models.DeletePhysicalClassroomRequest,
        headers: dingtalkedu__1__0_models.DeletePhysicalClassroomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeletePhysicalClassroomResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.classroom_id):
            query['classroomId'] = request.classroom_id
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='DeletePhysicalClassroom',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/physicalClassrooms',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeletePhysicalClassroomResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_physical_classroom_with_options_async(
        self,
        request: dingtalkedu__1__0_models.DeletePhysicalClassroomRequest,
        headers: dingtalkedu__1__0_models.DeletePhysicalClassroomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeletePhysicalClassroomResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.classroom_id):
            query['classroomId'] = request.classroom_id
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='DeletePhysicalClassroom',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/physicalClassrooms',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeletePhysicalClassroomResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_physical_classroom(
        self,
        request: dingtalkedu__1__0_models.DeletePhysicalClassroomRequest,
    ) -> dingtalkedu__1__0_models.DeletePhysicalClassroomResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeletePhysicalClassroomHeaders()
        return self.delete_physical_classroom_with_options(request, headers, runtime)

    async def delete_physical_classroom_async(
        self,
        request: dingtalkedu__1__0_models.DeletePhysicalClassroomRequest,
    ) -> dingtalkedu__1__0_models.DeletePhysicalClassroomResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeletePhysicalClassroomHeaders()
        return await self.delete_physical_classroom_with_options_async(request, headers, runtime)

    def delete_remote_class_course_with_options(
        self,
        course_code: str,
        request: dingtalkedu__1__0_models.DeleteRemoteClassCourseRequest,
        headers: dingtalkedu__1__0_models.DeleteRemoteClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteRemoteClassCourseResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.auth_code):
            query['authCode'] = request.auth_code
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
            action='DeleteRemoteClassCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/courses/{course_code}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteRemoteClassCourseResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_remote_class_course_with_options_async(
        self,
        course_code: str,
        request: dingtalkedu__1__0_models.DeleteRemoteClassCourseRequest,
        headers: dingtalkedu__1__0_models.DeleteRemoteClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteRemoteClassCourseResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.auth_code):
            query['authCode'] = request.auth_code
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
            action='DeleteRemoteClassCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/courses/{course_code}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteRemoteClassCourseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_remote_class_course(
        self,
        course_code: str,
        request: dingtalkedu__1__0_models.DeleteRemoteClassCourseRequest,
    ) -> dingtalkedu__1__0_models.DeleteRemoteClassCourseResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteRemoteClassCourseHeaders()
        return self.delete_remote_class_course_with_options(course_code, request, headers, runtime)

    async def delete_remote_class_course_async(
        self,
        course_code: str,
        request: dingtalkedu__1__0_models.DeleteRemoteClassCourseRequest,
    ) -> dingtalkedu__1__0_models.DeleteRemoteClassCourseResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteRemoteClassCourseHeaders()
        return await self.delete_remote_class_course_with_options_async(course_code, request, headers, runtime)

    def delete_student_with_options(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteStudentRequest,
        headers: dingtalkedu__1__0_models.DeleteStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteStudentResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
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
            action='DeleteStudent',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/classes/{class_id}/students/{user_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteStudentResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_student_with_options_async(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteStudentRequest,
        headers: dingtalkedu__1__0_models.DeleteStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteStudentResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
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
            action='DeleteStudent',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/classes/{class_id}/students/{user_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteStudentResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_student(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteStudentRequest,
    ) -> dingtalkedu__1__0_models.DeleteStudentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteStudentHeaders()
        return self.delete_student_with_options(class_id, user_id, request, headers, runtime)

    async def delete_student_async(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteStudentRequest,
    ) -> dingtalkedu__1__0_models.DeleteStudentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteStudentHeaders()
        return await self.delete_student_with_options_async(class_id, user_id, request, headers, runtime)

    def delete_teacher_with_options(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteTeacherRequest,
        headers: dingtalkedu__1__0_models.DeleteTeacherHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteTeacherResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.adviser):
            query['adviser'] = request.adviser
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
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
            action='DeleteTeacher',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/classes/{class_id}/teachers/{user_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteTeacherResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_teacher_with_options_async(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteTeacherRequest,
        headers: dingtalkedu__1__0_models.DeleteTeacherHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteTeacherResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.adviser):
            query['adviser'] = request.adviser
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
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
            action='DeleteTeacher',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/classes/{class_id}/teachers/{user_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteTeacherResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_teacher(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteTeacherRequest,
    ) -> dingtalkedu__1__0_models.DeleteTeacherResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteTeacherHeaders()
        return self.delete_teacher_with_options(class_id, user_id, request, headers, runtime)

    async def delete_teacher_async(
        self,
        class_id: str,
        user_id: str,
        request: dingtalkedu__1__0_models.DeleteTeacherRequest,
    ) -> dingtalkedu__1__0_models.DeleteTeacherResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteTeacherHeaders()
        return await self.delete_teacher_with_options_async(class_id, user_id, request, headers, runtime)

    def delete_university_course_group_with_options(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.DeleteUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteUniversityCourseGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.course_group_code):
            query['courseGroupCode'] = request.course_group_code
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='DeleteUniversityCourseGroup',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courseGroups',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteUniversityCourseGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_university_course_group_with_options_async(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.DeleteUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteUniversityCourseGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.course_group_code):
            query['courseGroupCode'] = request.course_group_code
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='DeleteUniversityCourseGroup',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courseGroups',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteUniversityCourseGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_university_course_group(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.DeleteUniversityCourseGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteUniversityCourseGroupHeaders()
        return self.delete_university_course_group_with_options(request, headers, runtime)

    async def delete_university_course_group_async(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.DeleteUniversityCourseGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteUniversityCourseGroupHeaders()
        return await self.delete_university_course_group_with_options_async(request, headers, runtime)

    def delete_university_student_with_options(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityStudentRequest,
        headers: dingtalkedu__1__0_models.DeleteUniversityStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteUniversityStudentResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.class_id):
            query['classId'] = request.class_id
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.student_user_id):
            query['studentUserId'] = request.student_user_id
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
            action='DeleteUniversityStudent',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/students',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteUniversityStudentResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_university_student_with_options_async(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityStudentRequest,
        headers: dingtalkedu__1__0_models.DeleteUniversityStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteUniversityStudentResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.class_id):
            query['classId'] = request.class_id
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.student_user_id):
            query['studentUserId'] = request.student_user_id
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
            action='DeleteUniversityStudent',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/students',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteUniversityStudentResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_university_student(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityStudentRequest,
    ) -> dingtalkedu__1__0_models.DeleteUniversityStudentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteUniversityStudentHeaders()
        return self.delete_university_student_with_options(request, headers, runtime)

    async def delete_university_student_async(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityStudentRequest,
    ) -> dingtalkedu__1__0_models.DeleteUniversityStudentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteUniversityStudentHeaders()
        return await self.delete_university_student_with_options_async(request, headers, runtime)

    def delete_university_teacher_with_options(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityTeacherRequest,
        headers: dingtalkedu__1__0_models.DeleteUniversityTeacherHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteUniversityTeacherResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.class_id):
            query['classId'] = request.class_id
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.role):
            query['role'] = request.role
        if not UtilClient.is_unset(request.teacher_user_id):
            query['teacherUserId'] = request.teacher_user_id
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
            action='DeleteUniversityTeacher',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/teachers',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteUniversityTeacherResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_university_teacher_with_options_async(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityTeacherRequest,
        headers: dingtalkedu__1__0_models.DeleteUniversityTeacherHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeleteUniversityTeacherResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.class_id):
            query['classId'] = request.class_id
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.role):
            query['role'] = request.role
        if not UtilClient.is_unset(request.teacher_user_id):
            query['teacherUserId'] = request.teacher_user_id
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
            action='DeleteUniversityTeacher',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/teachers',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeleteUniversityTeacherResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_university_teacher(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityTeacherRequest,
    ) -> dingtalkedu__1__0_models.DeleteUniversityTeacherResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteUniversityTeacherHeaders()
        return self.delete_university_teacher_with_options(request, headers, runtime)

    async def delete_university_teacher_async(
        self,
        request: dingtalkedu__1__0_models.DeleteUniversityTeacherRequest,
    ) -> dingtalkedu__1__0_models.DeleteUniversityTeacherResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeleteUniversityTeacherHeaders()
        return await self.delete_university_teacher_with_options_async(request, headers, runtime)

    def device_heartbeat_with_options(
        self,
        request: dingtalkedu__1__0_models.DeviceHeartbeatRequest,
        headers: dingtalkedu__1__0_models.DeviceHeartbeatHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeviceHeartbeatResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='DeviceHeartbeat',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/heartbeats/report',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeviceHeartbeatResponse(),
            self.execute(params, req, runtime)
        )

    async def device_heartbeat_with_options_async(
        self,
        request: dingtalkedu__1__0_models.DeviceHeartbeatRequest,
        headers: dingtalkedu__1__0_models.DeviceHeartbeatHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.DeviceHeartbeatResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='DeviceHeartbeat',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/heartbeats/report',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.DeviceHeartbeatResponse(),
            await self.execute_async(params, req, runtime)
        )

    def device_heartbeat(
        self,
        request: dingtalkedu__1__0_models.DeviceHeartbeatRequest,
    ) -> dingtalkedu__1__0_models.DeviceHeartbeatResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeviceHeartbeatHeaders()
        return self.device_heartbeat_with_options(request, headers, runtime)

    async def device_heartbeat_async(
        self,
        request: dingtalkedu__1__0_models.DeviceHeartbeatRequest,
    ) -> dingtalkedu__1__0_models.DeviceHeartbeatResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.DeviceHeartbeatHeaders()
        return await self.device_heartbeat_with_options_async(request, headers, runtime)

    def edu_teacher_list_with_options(
        self,
        request: dingtalkedu__1__0_models.EduTeacherListRequest,
        headers: dingtalkedu__1__0_models.EduTeacherListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.EduTeacherListResponse:
        UtilClient.validate_model(request)
        query = {}
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
        params = open_api_models.Params(
            action='EduTeacherList',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/teachers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.EduTeacherListResponse(),
            self.execute(params, req, runtime)
        )

    async def edu_teacher_list_with_options_async(
        self,
        request: dingtalkedu__1__0_models.EduTeacherListRequest,
        headers: dingtalkedu__1__0_models.EduTeacherListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.EduTeacherListResponse:
        UtilClient.validate_model(request)
        query = {}
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
        params = open_api_models.Params(
            action='EduTeacherList',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/teachers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.EduTeacherListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def edu_teacher_list(
        self,
        request: dingtalkedu__1__0_models.EduTeacherListRequest,
    ) -> dingtalkedu__1__0_models.EduTeacherListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.EduTeacherListHeaders()
        return self.edu_teacher_list_with_options(request, headers, runtime)

    async def edu_teacher_list_async(
        self,
        request: dingtalkedu__1__0_models.EduTeacherListRequest,
    ) -> dingtalkedu__1__0_models.EduTeacherListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.EduTeacherListHeaders()
        return await self.edu_teacher_list_with_options_async(request, headers, runtime)

    def end_course_with_options(
        self,
        request: dingtalkedu__1__0_models.EndCourseRequest,
        headers: dingtalkedu__1__0_models.EndCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.EndCourseResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.course_code):
            body['courseCode'] = request.course_code
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.live_play_info_list):
            body['livePlayInfoList'] = request.live_play_info_list
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
            action='EndCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courses/end',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.EndCourseResponse(),
            self.execute(params, req, runtime)
        )

    async def end_course_with_options_async(
        self,
        request: dingtalkedu__1__0_models.EndCourseRequest,
        headers: dingtalkedu__1__0_models.EndCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.EndCourseResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.course_code):
            body['courseCode'] = request.course_code
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.live_play_info_list):
            body['livePlayInfoList'] = request.live_play_info_list
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
            action='EndCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courses/end',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.EndCourseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def end_course(
        self,
        request: dingtalkedu__1__0_models.EndCourseRequest,
    ) -> dingtalkedu__1__0_models.EndCourseResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.EndCourseHeaders()
        return self.end_course_with_options(request, headers, runtime)

    async def end_course_async(
        self,
        request: dingtalkedu__1__0_models.EndCourseRequest,
    ) -> dingtalkedu__1__0_models.EndCourseResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.EndCourseHeaders()
        return await self.end_course_with_options_async(request, headers, runtime)

    def get_bind_child_info_with_options(
        self,
        request: dingtalkedu__1__0_models.GetBindChildInfoRequest,
        headers: dingtalkedu__1__0_models.GetBindChildInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetBindChildInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.school_corp_id):
            query['schoolCorpId'] = request.school_corp_id
        if not UtilClient.is_unset(request.student_user_id):
            query['studentUserId'] = request.student_user_id
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
            action='GetBindChildInfo',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/families/childs/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetBindChildInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_bind_child_info_with_options_async(
        self,
        request: dingtalkedu__1__0_models.GetBindChildInfoRequest,
        headers: dingtalkedu__1__0_models.GetBindChildInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetBindChildInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.school_corp_id):
            query['schoolCorpId'] = request.school_corp_id
        if not UtilClient.is_unset(request.student_user_id):
            query['studentUserId'] = request.student_user_id
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
            action='GetBindChildInfo',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/families/childs/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetBindChildInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_bind_child_info(
        self,
        request: dingtalkedu__1__0_models.GetBindChildInfoRequest,
    ) -> dingtalkedu__1__0_models.GetBindChildInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetBindChildInfoHeaders()
        return self.get_bind_child_info_with_options(request, headers, runtime)

    async def get_bind_child_info_async(
        self,
        request: dingtalkedu__1__0_models.GetBindChildInfoRequest,
    ) -> dingtalkedu__1__0_models.GetBindChildInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetBindChildInfoHeaders()
        return await self.get_bind_child_info_with_options_async(request, headers, runtime)

    def get_default_child_with_options(
        self,
        headers: dingtalkedu__1__0_models.GetDefaultChildHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetDefaultChildResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetDefaultChild',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/defaultChildren',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetDefaultChildResponse(),
            self.execute(params, req, runtime)
        )

    async def get_default_child_with_options_async(
        self,
        headers: dingtalkedu__1__0_models.GetDefaultChildHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetDefaultChildResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetDefaultChild',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/defaultChildren',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetDefaultChildResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_default_child(self) -> dingtalkedu__1__0_models.GetDefaultChildResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetDefaultChildHeaders()
        return self.get_default_child_with_options(headers, runtime)

    async def get_default_child_async(self) -> dingtalkedu__1__0_models.GetDefaultChildResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetDefaultChildHeaders()
        return await self.get_default_child_with_options_async(headers, runtime)

    def get_edu_user_identity_with_options(
        self,
        request: dingtalkedu__1__0_models.GetEduUserIdentityRequest,
        headers: dingtalkedu__1__0_models.GetEduUserIdentityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetEduUserIdentityResponse:
        UtilClient.validate_model(request)
        query = {}
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
            action='GetEduUserIdentity',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/apollos/activities/userIdentities',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetEduUserIdentityResponse(),
            self.execute(params, req, runtime)
        )

    async def get_edu_user_identity_with_options_async(
        self,
        request: dingtalkedu__1__0_models.GetEduUserIdentityRequest,
        headers: dingtalkedu__1__0_models.GetEduUserIdentityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetEduUserIdentityResponse:
        UtilClient.validate_model(request)
        query = {}
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
            action='GetEduUserIdentity',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/apollos/activities/userIdentities',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetEduUserIdentityResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_edu_user_identity(
        self,
        request: dingtalkedu__1__0_models.GetEduUserIdentityRequest,
    ) -> dingtalkedu__1__0_models.GetEduUserIdentityResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetEduUserIdentityHeaders()
        return self.get_edu_user_identity_with_options(request, headers, runtime)

    async def get_edu_user_identity_async(
        self,
        request: dingtalkedu__1__0_models.GetEduUserIdentityRequest,
    ) -> dingtalkedu__1__0_models.GetEduUserIdentityResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetEduUserIdentityHeaders()
        return await self.get_edu_user_identity_with_options_async(request, headers, runtime)

    def get_open_course_detail_with_options(
        self,
        course_id: str,
        headers: dingtalkedu__1__0_models.GetOpenCourseDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetOpenCourseDetailResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetOpenCourseDetail',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/openCourse/{course_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetOpenCourseDetailResponse(),
            self.execute(params, req, runtime)
        )

    async def get_open_course_detail_with_options_async(
        self,
        course_id: str,
        headers: dingtalkedu__1__0_models.GetOpenCourseDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetOpenCourseDetailResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetOpenCourseDetail',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/openCourse/{course_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetOpenCourseDetailResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_open_course_detail(
        self,
        course_id: str,
    ) -> dingtalkedu__1__0_models.GetOpenCourseDetailResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetOpenCourseDetailHeaders()
        return self.get_open_course_detail_with_options(course_id, headers, runtime)

    async def get_open_course_detail_async(
        self,
        course_id: str,
    ) -> dingtalkedu__1__0_models.GetOpenCourseDetailResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetOpenCourseDetailHeaders()
        return await self.get_open_course_detail_with_options_async(course_id, headers, runtime)

    def get_open_courses_with_options(
        self,
        request: dingtalkedu__1__0_models.GetOpenCoursesRequest,
        headers: dingtalkedu__1__0_models.GetOpenCoursesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetOpenCoursesResponse:
        UtilClient.validate_model(request)
        query = {}
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
        params = open_api_models.Params(
            action='GetOpenCourses',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/openCourses',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetOpenCoursesResponse(),
            self.execute(params, req, runtime)
        )

    async def get_open_courses_with_options_async(
        self,
        request: dingtalkedu__1__0_models.GetOpenCoursesRequest,
        headers: dingtalkedu__1__0_models.GetOpenCoursesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetOpenCoursesResponse:
        UtilClient.validate_model(request)
        query = {}
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
        params = open_api_models.Params(
            action='GetOpenCourses',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/openCourses',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetOpenCoursesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_open_courses(
        self,
        request: dingtalkedu__1__0_models.GetOpenCoursesRequest,
    ) -> dingtalkedu__1__0_models.GetOpenCoursesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetOpenCoursesHeaders()
        return self.get_open_courses_with_options(request, headers, runtime)

    async def get_open_courses_async(
        self,
        request: dingtalkedu__1__0_models.GetOpenCoursesRequest,
    ) -> dingtalkedu__1__0_models.GetOpenCoursesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetOpenCoursesHeaders()
        return await self.get_open_courses_with_options_async(request, headers, runtime)

    def get_point_action_record_with_options(
        self,
        request: dingtalkedu__1__0_models.GetPointActionRecordRequest,
        headers: dingtalkedu__1__0_models.GetPointActionRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetPointActionRecordResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_id):
            query['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.point_type):
            query['pointType'] = request.point_type
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
            action='GetPointActionRecord',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/points/actionRecords',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetPointActionRecordResponse(),
            self.execute(params, req, runtime)
        )

    async def get_point_action_record_with_options_async(
        self,
        request: dingtalkedu__1__0_models.GetPointActionRecordRequest,
        headers: dingtalkedu__1__0_models.GetPointActionRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetPointActionRecordResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_id):
            query['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.point_type):
            query['pointType'] = request.point_type
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
            action='GetPointActionRecord',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/points/actionRecords',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetPointActionRecordResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_point_action_record(
        self,
        request: dingtalkedu__1__0_models.GetPointActionRecordRequest,
    ) -> dingtalkedu__1__0_models.GetPointActionRecordResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetPointActionRecordHeaders()
        return self.get_point_action_record_with_options(request, headers, runtime)

    async def get_point_action_record_async(
        self,
        request: dingtalkedu__1__0_models.GetPointActionRecordRequest,
    ) -> dingtalkedu__1__0_models.GetPointActionRecordResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetPointActionRecordHeaders()
        return await self.get_point_action_record_with_options_async(request, headers, runtime)

    def get_point_info_with_options(
        self,
        request: dingtalkedu__1__0_models.GetPointInfoRequest,
        headers: dingtalkedu__1__0_models.GetPointInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetPointInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.point_type):
            query['pointType'] = request.point_type
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
            action='GetPointInfo',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/points/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetPointInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_point_info_with_options_async(
        self,
        request: dingtalkedu__1__0_models.GetPointInfoRequest,
        headers: dingtalkedu__1__0_models.GetPointInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetPointInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.point_type):
            query['pointType'] = request.point_type
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
            action='GetPointInfo',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/points/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetPointInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_point_info(
        self,
        request: dingtalkedu__1__0_models.GetPointInfoRequest,
    ) -> dingtalkedu__1__0_models.GetPointInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetPointInfoHeaders()
        return self.get_point_info_with_options(request, headers, runtime)

    async def get_point_info_async(
        self,
        request: dingtalkedu__1__0_models.GetPointInfoRequest,
    ) -> dingtalkedu__1__0_models.GetPointInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetPointInfoHeaders()
        return await self.get_point_info_with_options_async(request, headers, runtime)

    def get_remote_class_course_with_options(
        self,
        course_code: str,
        request: dingtalkedu__1__0_models.GetRemoteClassCourseRequest,
        headers: dingtalkedu__1__0_models.GetRemoteClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetRemoteClassCourseResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
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
            action='GetRemoteClassCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/courses/{course_code}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetRemoteClassCourseResponse(),
            self.execute(params, req, runtime)
        )

    async def get_remote_class_course_with_options_async(
        self,
        course_code: str,
        request: dingtalkedu__1__0_models.GetRemoteClassCourseRequest,
        headers: dingtalkedu__1__0_models.GetRemoteClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetRemoteClassCourseResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
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
            action='GetRemoteClassCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/courses/{course_code}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetRemoteClassCourseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_remote_class_course(
        self,
        course_code: str,
        request: dingtalkedu__1__0_models.GetRemoteClassCourseRequest,
    ) -> dingtalkedu__1__0_models.GetRemoteClassCourseResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetRemoteClassCourseHeaders()
        return self.get_remote_class_course_with_options(course_code, request, headers, runtime)

    async def get_remote_class_course_async(
        self,
        course_code: str,
        request: dingtalkedu__1__0_models.GetRemoteClassCourseRequest,
    ) -> dingtalkedu__1__0_models.GetRemoteClassCourseResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetRemoteClassCourseHeaders()
        return await self.get_remote_class_course_with_options_async(course_code, request, headers, runtime)

    def get_share_role_members_with_options(
        self,
        share_role_code: str,
        headers: dingtalkedu__1__0_models.GetShareRoleMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetShareRoleMembersResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetShareRoleMembers',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/shareRoles/{share_role_code}/members',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetShareRoleMembersResponse(),
            self.execute(params, req, runtime)
        )

    async def get_share_role_members_with_options_async(
        self,
        share_role_code: str,
        headers: dingtalkedu__1__0_models.GetShareRoleMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetShareRoleMembersResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetShareRoleMembers',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/shareRoles/{share_role_code}/members',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetShareRoleMembersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_share_role_members(
        self,
        share_role_code: str,
    ) -> dingtalkedu__1__0_models.GetShareRoleMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetShareRoleMembersHeaders()
        return self.get_share_role_members_with_options(share_role_code, headers, runtime)

    async def get_share_role_members_async(
        self,
        share_role_code: str,
    ) -> dingtalkedu__1__0_models.GetShareRoleMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetShareRoleMembersHeaders()
        return await self.get_share_role_members_with_options_async(share_role_code, headers, runtime)

    def get_share_roles_with_options(
        self,
        headers: dingtalkedu__1__0_models.GetShareRolesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetShareRolesResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetShareRoles',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/shareRoles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetShareRolesResponse(),
            self.execute(params, req, runtime)
        )

    async def get_share_roles_with_options_async(
        self,
        headers: dingtalkedu__1__0_models.GetShareRolesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetShareRolesResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetShareRoles',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/shareRoles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetShareRolesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_share_roles(self) -> dingtalkedu__1__0_models.GetShareRolesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetShareRolesHeaders()
        return self.get_share_roles_with_options(headers, runtime)

    async def get_share_roles_async(self) -> dingtalkedu__1__0_models.GetShareRolesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetShareRolesHeaders()
        return await self.get_share_roles_with_options_async(headers, runtime)

    def get_task_list_with_options(
        self,
        request: dingtalkedu__1__0_models.GetTaskListRequest,
        headers: dingtalkedu__1__0_models.GetTaskListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetTaskListResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.task_year):
            query['taskYear'] = request.task_year
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
            action='GetTaskList',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/newGrades/tasks/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetTaskListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_task_list_with_options_async(
        self,
        request: dingtalkedu__1__0_models.GetTaskListRequest,
        headers: dingtalkedu__1__0_models.GetTaskListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetTaskListResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.task_year):
            query['taskYear'] = request.task_year
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
            action='GetTaskList',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/newGrades/tasks/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetTaskListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_task_list(
        self,
        request: dingtalkedu__1__0_models.GetTaskListRequest,
    ) -> dingtalkedu__1__0_models.GetTaskListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetTaskListHeaders()
        return self.get_task_list_with_options(request, headers, runtime)

    async def get_task_list_async(
        self,
        request: dingtalkedu__1__0_models.GetTaskListRequest,
    ) -> dingtalkedu__1__0_models.GetTaskListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetTaskListHeaders()
        return await self.get_task_list_with_options_async(request, headers, runtime)

    def get_task_student_list_with_options(
        self,
        request: dingtalkedu__1__0_models.GetTaskStudentListRequest,
        headers: dingtalkedu__1__0_models.GetTaskStudentListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetTaskStudentListResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.task_id):
            query['taskId'] = request.task_id
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
            action='GetTaskStudentList',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/newGrades/tasks/students/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetTaskStudentListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_task_student_list_with_options_async(
        self,
        request: dingtalkedu__1__0_models.GetTaskStudentListRequest,
        headers: dingtalkedu__1__0_models.GetTaskStudentListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.GetTaskStudentListResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.task_id):
            query['taskId'] = request.task_id
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
            action='GetTaskStudentList',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/newGrades/tasks/students/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.GetTaskStudentListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_task_student_list(
        self,
        request: dingtalkedu__1__0_models.GetTaskStudentListRequest,
    ) -> dingtalkedu__1__0_models.GetTaskStudentListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetTaskStudentListHeaders()
        return self.get_task_student_list_with_options(request, headers, runtime)

    async def get_task_student_list_async(
        self,
        request: dingtalkedu__1__0_models.GetTaskStudentListRequest,
    ) -> dingtalkedu__1__0_models.GetTaskStudentListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.GetTaskStudentListHeaders()
        return await self.get_task_student_list_with_options_async(request, headers, runtime)

    def init_courses_of_class_with_options(
        self,
        class_id: str,
        request: dingtalkedu__1__0_models.InitCoursesOfClassRequest,
        headers: dingtalkedu__1__0_models.InitCoursesOfClassHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.InitCoursesOfClassResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.courses):
            body['courses'] = request.courses
        if not UtilClient.is_unset(request.section_config):
            body['sectionConfig'] = request.section_config
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
            action='InitCoursesOfClass',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/classes/{class_id}/courses/init',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.InitCoursesOfClassResponse(),
            self.execute(params, req, runtime)
        )

    async def init_courses_of_class_with_options_async(
        self,
        class_id: str,
        request: dingtalkedu__1__0_models.InitCoursesOfClassRequest,
        headers: dingtalkedu__1__0_models.InitCoursesOfClassHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.InitCoursesOfClassResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.courses):
            body['courses'] = request.courses
        if not UtilClient.is_unset(request.section_config):
            body['sectionConfig'] = request.section_config
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
            action='InitCoursesOfClass',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/classes/{class_id}/courses/init',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.InitCoursesOfClassResponse(),
            await self.execute_async(params, req, runtime)
        )

    def init_courses_of_class(
        self,
        class_id: str,
        request: dingtalkedu__1__0_models.InitCoursesOfClassRequest,
    ) -> dingtalkedu__1__0_models.InitCoursesOfClassResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.InitCoursesOfClassHeaders()
        return self.init_courses_of_class_with_options(class_id, request, headers, runtime)

    async def init_courses_of_class_async(
        self,
        class_id: str,
        request: dingtalkedu__1__0_models.InitCoursesOfClassRequest,
    ) -> dingtalkedu__1__0_models.InitCoursesOfClassResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.InitCoursesOfClassHeaders()
        return await self.init_courses_of_class_with_options_async(class_id, request, headers, runtime)

    def init_device_with_options(
        self,
        request: dingtalkedu__1__0_models.InitDeviceRequest,
        headers: dingtalkedu__1__0_models.InitDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.InitDeviceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.encrypt_pub_key):
            body['encryptPubKey'] = request.encrypt_pub_key
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
        if not UtilClient.is_unset(request.version):
            body['version'] = request.version
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
            action='InitDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/devices/init',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.InitDeviceResponse(),
            self.execute(params, req, runtime)
        )

    async def init_device_with_options_async(
        self,
        request: dingtalkedu__1__0_models.InitDeviceRequest,
        headers: dingtalkedu__1__0_models.InitDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.InitDeviceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.encrypt_pub_key):
            body['encryptPubKey'] = request.encrypt_pub_key
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
        if not UtilClient.is_unset(request.version):
            body['version'] = request.version
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
            action='InitDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/devices/init',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.InitDeviceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def init_device(
        self,
        request: dingtalkedu__1__0_models.InitDeviceRequest,
    ) -> dingtalkedu__1__0_models.InitDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.InitDeviceHeaders()
        return self.init_device_with_options(request, headers, runtime)

    async def init_device_async(
        self,
        request: dingtalkedu__1__0_models.InitDeviceRequest,
    ) -> dingtalkedu__1__0_models.InitDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.InitDeviceHeaders()
        return await self.init_device_with_options_async(request, headers, runtime)

    def init_vpaas_device_with_options(
        self,
        request: dingtalkedu__1__0_models.InitVPaasDeviceRequest,
        headers: dingtalkedu__1__0_models.InitVPaasDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.InitVPaasDeviceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='InitVPaasDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/devices/init',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.InitVPaasDeviceResponse(),
            self.execute(params, req, runtime)
        )

    async def init_vpaas_device_with_options_async(
        self,
        request: dingtalkedu__1__0_models.InitVPaasDeviceRequest,
        headers: dingtalkedu__1__0_models.InitVPaasDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.InitVPaasDeviceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='InitVPaasDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/devices/init',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.InitVPaasDeviceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def init_vpaas_device(
        self,
        request: dingtalkedu__1__0_models.InitVPaasDeviceRequest,
    ) -> dingtalkedu__1__0_models.InitVPaasDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.InitVPaasDeviceHeaders()
        return self.init_vpaas_device_with_options(request, headers, runtime)

    async def init_vpaas_device_async(
        self,
        request: dingtalkedu__1__0_models.InitVPaasDeviceRequest,
    ) -> dingtalkedu__1__0_models.InitVPaasDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.InitVPaasDeviceHeaders()
        return await self.init_vpaas_device_with_options_async(request, headers, runtime)

    def insert_section_config_with_options(
        self,
        request: dingtalkedu__1__0_models.InsertSectionConfigRequest,
        headers: dingtalkedu__1__0_models.InsertSectionConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.InsertSectionConfigResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.end):
            body['end'] = request.end
        if not UtilClient.is_unset(request.schedule_name):
            body['scheduleName'] = request.schedule_name
        if not UtilClient.is_unset(request.section_models):
            body['sectionModels'] = request.section_models
        if not UtilClient.is_unset(request.start):
            body['start'] = request.start
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
            action='InsertSectionConfig',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/schedules/configs',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.InsertSectionConfigResponse(),
            self.execute(params, req, runtime)
        )

    async def insert_section_config_with_options_async(
        self,
        request: dingtalkedu__1__0_models.InsertSectionConfigRequest,
        headers: dingtalkedu__1__0_models.InsertSectionConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.InsertSectionConfigResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.end):
            body['end'] = request.end
        if not UtilClient.is_unset(request.schedule_name):
            body['scheduleName'] = request.schedule_name
        if not UtilClient.is_unset(request.section_models):
            body['sectionModels'] = request.section_models
        if not UtilClient.is_unset(request.start):
            body['start'] = request.start
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
            action='InsertSectionConfig',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/schedules/configs',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.InsertSectionConfigResponse(),
            await self.execute_async(params, req, runtime)
        )

    def insert_section_config(
        self,
        request: dingtalkedu__1__0_models.InsertSectionConfigRequest,
    ) -> dingtalkedu__1__0_models.InsertSectionConfigResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.InsertSectionConfigHeaders()
        return self.insert_section_config_with_options(request, headers, runtime)

    async def insert_section_config_async(
        self,
        request: dingtalkedu__1__0_models.InsertSectionConfigRequest,
    ) -> dingtalkedu__1__0_models.InsertSectionConfigResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.InsertSectionConfigHeaders()
        return await self.insert_section_config_with_options_async(request, headers, runtime)

    def list_order_with_options(
        self,
        request: dingtalkedu__1__0_models.ListOrderRequest,
        headers: dingtalkedu__1__0_models.ListOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ListOrderResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.create_time_end):
            body['createTimeEnd'] = request.create_time_end
        if not UtilClient.is_unset(request.create_time_start):
            body['createTimeStart'] = request.create_time_start
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.trade_no):
            body['tradeNo'] = request.trade_no
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
            action='ListOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orders/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ListOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def list_order_with_options_async(
        self,
        request: dingtalkedu__1__0_models.ListOrderRequest,
        headers: dingtalkedu__1__0_models.ListOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ListOrderResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.create_time_end):
            body['createTimeEnd'] = request.create_time_end
        if not UtilClient.is_unset(request.create_time_start):
            body['createTimeStart'] = request.create_time_start
        if not UtilClient.is_unset(request.merchant_id):
            body['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.trade_no):
            body['tradeNo'] = request.trade_no
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
            action='ListOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orders/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ListOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_order(
        self,
        request: dingtalkedu__1__0_models.ListOrderRequest,
    ) -> dingtalkedu__1__0_models.ListOrderResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ListOrderHeaders()
        return self.list_order_with_options(request, headers, runtime)

    async def list_order_async(
        self,
        request: dingtalkedu__1__0_models.ListOrderRequest,
    ) -> dingtalkedu__1__0_models.ListOrderResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ListOrderHeaders()
        return await self.list_order_with_options_async(request, headers, runtime)

    def move_student_with_options(
        self,
        request: dingtalkedu__1__0_models.MoveStudentRequest,
        headers: dingtalkedu__1__0_models.MoveStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.MoveStudentResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.origin_class_id):
            body['originClassId'] = request.origin_class_id
        if not UtilClient.is_unset(request.target_class_id):
            body['targetClassId'] = request.target_class_id
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
            action='MoveStudent',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/students/move',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.MoveStudentResponse(),
            self.execute(params, req, runtime)
        )

    async def move_student_with_options_async(
        self,
        request: dingtalkedu__1__0_models.MoveStudentRequest,
        headers: dingtalkedu__1__0_models.MoveStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.MoveStudentResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.origin_class_id):
            body['originClassId'] = request.origin_class_id
        if not UtilClient.is_unset(request.target_class_id):
            body['targetClassId'] = request.target_class_id
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
            action='MoveStudent',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/students/move',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.MoveStudentResponse(),
            await self.execute_async(params, req, runtime)
        )

    def move_student(
        self,
        request: dingtalkedu__1__0_models.MoveStudentRequest,
    ) -> dingtalkedu__1__0_models.MoveStudentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.MoveStudentHeaders()
        return self.move_student_with_options(request, headers, runtime)

    async def move_student_async(
        self,
        request: dingtalkedu__1__0_models.MoveStudentRequest,
    ) -> dingtalkedu__1__0_models.MoveStudentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.MoveStudentHeaders()
        return await self.move_student_with_options_async(request, headers, runtime)

    def page_query_devices_with_options(
        self,
        request: dingtalkedu__1__0_models.PageQueryDevicesRequest,
        headers: dingtalkedu__1__0_models.PageQueryDevicesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.PageQueryDevicesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.type):
            query['type'] = request.type
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
            action='PageQueryDevices',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/devices',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.PageQueryDevicesResponse(),
            self.execute(params, req, runtime)
        )

    async def page_query_devices_with_options_async(
        self,
        request: dingtalkedu__1__0_models.PageQueryDevicesRequest,
        headers: dingtalkedu__1__0_models.PageQueryDevicesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.PageQueryDevicesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.type):
            query['type'] = request.type
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
            action='PageQueryDevices',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/devices',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.PageQueryDevicesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def page_query_devices(
        self,
        request: dingtalkedu__1__0_models.PageQueryDevicesRequest,
    ) -> dingtalkedu__1__0_models.PageQueryDevicesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.PageQueryDevicesHeaders()
        return self.page_query_devices_with_options(request, headers, runtime)

    async def page_query_devices_async(
        self,
        request: dingtalkedu__1__0_models.PageQueryDevicesRequest,
    ) -> dingtalkedu__1__0_models.PageQueryDevicesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.PageQueryDevicesHeaders()
        return await self.page_query_devices_with_options_async(request, headers, runtime)

    def pay_order_with_options(
        self,
        request: dingtalkedu__1__0_models.PayOrderRequest,
        headers: dingtalkedu__1__0_models.PayOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.PayOrderResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.version):
            body['version'] = request.version
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
            action='PayOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orders/pay',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.PayOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def pay_order_with_options_async(
        self,
        request: dingtalkedu__1__0_models.PayOrderRequest,
        headers: dingtalkedu__1__0_models.PayOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.PayOrderResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.version):
            body['version'] = request.version
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
            action='PayOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orders/pay',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.PayOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def pay_order(
        self,
        request: dingtalkedu__1__0_models.PayOrderRequest,
    ) -> dingtalkedu__1__0_models.PayOrderResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.PayOrderHeaders()
        return self.pay_order_with_options(request, headers, runtime)

    async def pay_order_async(
        self,
        request: dingtalkedu__1__0_models.PayOrderRequest,
    ) -> dingtalkedu__1__0_models.PayOrderResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.PayOrderHeaders()
        return await self.pay_order_with_options_async(request, headers, runtime)

    def polling_confirm_status_with_options(
        self,
        request: dingtalkedu__1__0_models.PollingConfirmStatusRequest,
        headers: dingtalkedu__1__0_models.PollingConfirmStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.PollingConfirmStatusResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.course_code):
            query['courseCode'] = request.course_code
        if not UtilClient.is_unset(request.ext):
            query['ext'] = request.ext
        if not UtilClient.is_unset(request.isv_code):
            query['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='PollingConfirmStatus',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courses/pollingConfirmStatus',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.PollingConfirmStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def polling_confirm_status_with_options_async(
        self,
        request: dingtalkedu__1__0_models.PollingConfirmStatusRequest,
        headers: dingtalkedu__1__0_models.PollingConfirmStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.PollingConfirmStatusResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.course_code):
            query['courseCode'] = request.course_code
        if not UtilClient.is_unset(request.ext):
            query['ext'] = request.ext
        if not UtilClient.is_unset(request.isv_code):
            query['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='PollingConfirmStatus',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courses/pollingConfirmStatus',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.PollingConfirmStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def polling_confirm_status(
        self,
        request: dingtalkedu__1__0_models.PollingConfirmStatusRequest,
    ) -> dingtalkedu__1__0_models.PollingConfirmStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.PollingConfirmStatusHeaders()
        return self.polling_confirm_status_with_options(request, headers, runtime)

    async def polling_confirm_status_async(
        self,
        request: dingtalkedu__1__0_models.PollingConfirmStatusRequest,
    ) -> dingtalkedu__1__0_models.PollingConfirmStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.PollingConfirmStatusHeaders()
        return await self.polling_confirm_status_with_options_async(request, headers, runtime)

    def pre_dial_with_options(
        self,
        request: dingtalkedu__1__0_models.PreDialRequest,
        headers: dingtalkedu__1__0_models.PreDialHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.PreDialResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.caller_user_id):
            body['callerUserId'] = request.caller_user_id
        if not UtilClient.is_unset(request.receiver_user_id):
            body['receiverUserId'] = request.receiver_user_id
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='PreDial',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/devices/preDial',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.PreDialResponse(),
            self.execute(params, req, runtime)
        )

    async def pre_dial_with_options_async(
        self,
        request: dingtalkedu__1__0_models.PreDialRequest,
        headers: dingtalkedu__1__0_models.PreDialHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.PreDialResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.caller_user_id):
            body['callerUserId'] = request.caller_user_id
        if not UtilClient.is_unset(request.receiver_user_id):
            body['receiverUserId'] = request.receiver_user_id
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='PreDial',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/devices/preDial',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.PreDialResponse(),
            await self.execute_async(params, req, runtime)
        )

    def pre_dial(
        self,
        request: dingtalkedu__1__0_models.PreDialRequest,
    ) -> dingtalkedu__1__0_models.PreDialResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.PreDialHeaders()
        return self.pre_dial_with_options(request, headers, runtime)

    async def pre_dial_async(
        self,
        request: dingtalkedu__1__0_models.PreDialRequest,
    ) -> dingtalkedu__1__0_models.PreDialResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.PreDialHeaders()
        return await self.pre_dial_with_options_async(request, headers, runtime)

    def provide_point_with_options(
        self,
        request: dingtalkedu__1__0_models.ProvidePointRequest,
        headers: dingtalkedu__1__0_models.ProvidePointHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ProvidePointResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action_code):
            body['actionCode'] = request.action_code
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.point_type):
            body['pointType'] = request.point_type
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
            action='ProvidePoint',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/points/provide',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ProvidePointResponse(),
            self.execute(params, req, runtime)
        )

    async def provide_point_with_options_async(
        self,
        request: dingtalkedu__1__0_models.ProvidePointRequest,
        headers: dingtalkedu__1__0_models.ProvidePointHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ProvidePointResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action_code):
            body['actionCode'] = request.action_code
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.point_type):
            body['pointType'] = request.point_type
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
            action='ProvidePoint',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/points/provide',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ProvidePointResponse(),
            await self.execute_async(params, req, runtime)
        )

    def provide_point(
        self,
        request: dingtalkedu__1__0_models.ProvidePointRequest,
    ) -> dingtalkedu__1__0_models.ProvidePointResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ProvidePointHeaders()
        return self.provide_point_with_options(request, headers, runtime)

    async def provide_point_async(
        self,
        request: dingtalkedu__1__0_models.ProvidePointRequest,
    ) -> dingtalkedu__1__0_models.ProvidePointResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ProvidePointHeaders()
        return await self.provide_point_with_options_async(request, headers, runtime)

    def query_all_subjects_from_class_schedule_with_options(
        self,
        tmp_req: dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleRequest,
        headers: dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleResponse:
        UtilClient.validate_model(tmp_req)
        request = dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.class_ids):
            request.class_ids_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.class_ids, 'classIds', 'json')
        query = {}
        if not UtilClient.is_unset(request.class_ids_shrink):
            query['classIds'] = request.class_ids_shrink
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.period_code):
            query['periodCode'] = request.period_code
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
            action='QueryAllSubjectsFromClassSchedule',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/subjects/instances',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleResponse(),
            self.execute(params, req, runtime)
        )

    async def query_all_subjects_from_class_schedule_with_options_async(
        self,
        tmp_req: dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleRequest,
        headers: dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleResponse:
        UtilClient.validate_model(tmp_req)
        request = dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.class_ids):
            request.class_ids_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.class_ids, 'classIds', 'json')
        query = {}
        if not UtilClient.is_unset(request.class_ids_shrink):
            query['classIds'] = request.class_ids_shrink
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.period_code):
            query['periodCode'] = request.period_code
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
            action='QueryAllSubjectsFromClassSchedule',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/subjects/instances',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_all_subjects_from_class_schedule(
        self,
        request: dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleRequest,
    ) -> dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleHeaders()
        return self.query_all_subjects_from_class_schedule_with_options(request, headers, runtime)

    async def query_all_subjects_from_class_schedule_async(
        self,
        request: dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleRequest,
    ) -> dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryAllSubjectsFromClassScheduleHeaders()
        return await self.query_all_subjects_from_class_schedule_with_options_async(request, headers, runtime)

    def query_class_schedule_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryClassScheduleRequest,
        headers: dingtalkedu__1__0_models.QueryClassScheduleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        if not UtilClient.is_unset(request.subscriber_type):
            query['subscriberType'] = request.subscriber_type
        body = {}
        if not UtilClient.is_unset(request.section_index_list):
            body['sectionIndexList'] = request.section_index_list
        if not UtilClient.is_unset(request.subscriber_ids):
            body['subscriberIds'] = request.subscriber_ids
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
            action='QueryClassSchedule',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/classes/schedules/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryClassScheduleResponse(),
            self.execute(params, req, runtime)
        )

    async def query_class_schedule_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryClassScheduleRequest,
        headers: dingtalkedu__1__0_models.QueryClassScheduleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        if not UtilClient.is_unset(request.subscriber_type):
            query['subscriberType'] = request.subscriber_type
        body = {}
        if not UtilClient.is_unset(request.section_index_list):
            body['sectionIndexList'] = request.section_index_list
        if not UtilClient.is_unset(request.subscriber_ids):
            body['subscriberIds'] = request.subscriber_ids
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
            action='QueryClassSchedule',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/classes/schedules/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryClassScheduleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_class_schedule(
        self,
        request: dingtalkedu__1__0_models.QueryClassScheduleRequest,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryClassScheduleHeaders()
        return self.query_class_schedule_with_options(request, headers, runtime)

    async def query_class_schedule_async(
        self,
        request: dingtalkedu__1__0_models.QueryClassScheduleRequest,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryClassScheduleHeaders()
        return await self.query_class_schedule_with_options_async(request, headers, runtime)

    def query_class_schedule_by_time_school_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolRequest,
        headers: dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
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
            action='QueryClassScheduleByTimeSchool',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/schools/classes/courses ',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolResponse(),
            self.execute(params, req, runtime)
        )

    async def query_class_schedule_by_time_school_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolRequest,
        headers: dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
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
            action='QueryClassScheduleByTimeSchool',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/schools/classes/courses ',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_class_schedule_by_time_school(
        self,
        request: dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolRequest,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolHeaders()
        return self.query_class_schedule_by_time_school_with_options(request, headers, runtime)

    async def query_class_schedule_by_time_school_async(
        self,
        request: dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolRequest,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryClassScheduleByTimeSchoolHeaders()
        return await self.query_class_schedule_by_time_school_with_options_async(request, headers, runtime)

    def query_class_schedule_config_with_options(
        self,
        tmp_req: dingtalkedu__1__0_models.QueryClassScheduleConfigRequest,
        headers: dingtalkedu__1__0_models.QueryClassScheduleConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleConfigResponse:
        UtilClient.validate_model(tmp_req)
        request = dingtalkedu__1__0_models.QueryClassScheduleConfigShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.class_ids):
            request.class_ids_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.class_ids, 'classIds', 'json')
        query = {}
        if not UtilClient.is_unset(request.class_ids_shrink):
            query['classIds'] = request.class_ids_shrink
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='QueryClassScheduleConfig',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/schedules/configs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryClassScheduleConfigResponse(),
            self.execute(params, req, runtime)
        )

    async def query_class_schedule_config_with_options_async(
        self,
        tmp_req: dingtalkedu__1__0_models.QueryClassScheduleConfigRequest,
        headers: dingtalkedu__1__0_models.QueryClassScheduleConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleConfigResponse:
        UtilClient.validate_model(tmp_req)
        request = dingtalkedu__1__0_models.QueryClassScheduleConfigShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.class_ids):
            request.class_ids_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.class_ids, 'classIds', 'json')
        query = {}
        if not UtilClient.is_unset(request.class_ids_shrink):
            query['classIds'] = request.class_ids_shrink
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='QueryClassScheduleConfig',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/schedules/configs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryClassScheduleConfigResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_class_schedule_config(
        self,
        request: dingtalkedu__1__0_models.QueryClassScheduleConfigRequest,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleConfigResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryClassScheduleConfigHeaders()
        return self.query_class_schedule_config_with_options(request, headers, runtime)

    async def query_class_schedule_config_async(
        self,
        request: dingtalkedu__1__0_models.QueryClassScheduleConfigRequest,
    ) -> dingtalkedu__1__0_models.QueryClassScheduleConfigResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryClassScheduleConfigHeaders()
        return await self.query_class_schedule_config_with_options_async(request, headers, runtime)

    def query_device_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryDeviceRequest,
        headers: dingtalkedu__1__0_models.QueryDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryDeviceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='QueryDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpass/devices/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryDeviceResponse(),
            self.execute(params, req, runtime)
        )

    async def query_device_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryDeviceRequest,
        headers: dingtalkedu__1__0_models.QueryDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryDeviceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='QueryDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpass/devices/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryDeviceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_device(
        self,
        request: dingtalkedu__1__0_models.QueryDeviceRequest,
    ) -> dingtalkedu__1__0_models.QueryDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryDeviceHeaders()
        return self.query_device_with_options(request, headers, runtime)

    async def query_device_async(
        self,
        request: dingtalkedu__1__0_models.QueryDeviceRequest,
    ) -> dingtalkedu__1__0_models.QueryDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryDeviceHeaders()
        return await self.query_device_with_options_async(request, headers, runtime)

    def query_device_list_by_corp_id_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryDeviceListByCorpIdRequest,
        headers: dingtalkedu__1__0_models.QueryDeviceListByCorpIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryDeviceListByCorpIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
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
        params = open_api_models.Params(
            action='QueryDeviceListByCorpId',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/devices',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryDeviceListByCorpIdResponse(),
            self.execute(params, req, runtime)
        )

    async def query_device_list_by_corp_id_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryDeviceListByCorpIdRequest,
        headers: dingtalkedu__1__0_models.QueryDeviceListByCorpIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryDeviceListByCorpIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
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
        params = open_api_models.Params(
            action='QueryDeviceListByCorpId',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/devices',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryDeviceListByCorpIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_device_list_by_corp_id(
        self,
        request: dingtalkedu__1__0_models.QueryDeviceListByCorpIdRequest,
    ) -> dingtalkedu__1__0_models.QueryDeviceListByCorpIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryDeviceListByCorpIdHeaders()
        return self.query_device_list_by_corp_id_with_options(request, headers, runtime)

    async def query_device_list_by_corp_id_async(
        self,
        request: dingtalkedu__1__0_models.QueryDeviceListByCorpIdRequest,
    ) -> dingtalkedu__1__0_models.QueryDeviceListByCorpIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryDeviceListByCorpIdHeaders()
        return await self.query_device_list_by_corp_id_with_options_async(request, headers, runtime)

    def query_edu_asset_spaces_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryEduAssetSpacesRequest,
        headers: dingtalkedu__1__0_models.QueryEduAssetSpacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryEduAssetSpacesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_code):
            query['bizCode'] = request.biz_code
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
            action='QueryEduAssetSpaces',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/assets/spaces',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryEduAssetSpacesResponse(),
            self.execute(params, req, runtime)
        )

    async def query_edu_asset_spaces_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryEduAssetSpacesRequest,
        headers: dingtalkedu__1__0_models.QueryEduAssetSpacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryEduAssetSpacesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.biz_code):
            query['bizCode'] = request.biz_code
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
            action='QueryEduAssetSpaces',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/assets/spaces',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryEduAssetSpacesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_edu_asset_spaces(
        self,
        request: dingtalkedu__1__0_models.QueryEduAssetSpacesRequest,
    ) -> dingtalkedu__1__0_models.QueryEduAssetSpacesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryEduAssetSpacesHeaders()
        return self.query_edu_asset_spaces_with_options(request, headers, runtime)

    async def query_edu_asset_spaces_async(
        self,
        request: dingtalkedu__1__0_models.QueryEduAssetSpacesRequest,
    ) -> dingtalkedu__1__0_models.QueryEduAssetSpacesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryEduAssetSpacesHeaders()
        return await self.query_edu_asset_spaces_with_options_async(request, headers, runtime)

    def query_group_id_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryGroupIdRequest,
        headers: dingtalkedu__1__0_models.QueryGroupIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryGroupIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='QueryGroupId',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/faces/groups',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryGroupIdResponse(),
            self.execute(params, req, runtime)
        )

    async def query_group_id_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryGroupIdRequest,
        headers: dingtalkedu__1__0_models.QueryGroupIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryGroupIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='QueryGroupId',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/faces/groups',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryGroupIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_group_id(
        self,
        request: dingtalkedu__1__0_models.QueryGroupIdRequest,
    ) -> dingtalkedu__1__0_models.QueryGroupIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryGroupIdHeaders()
        return self.query_group_id_with_options(request, headers, runtime)

    async def query_group_id_async(
        self,
        request: dingtalkedu__1__0_models.QueryGroupIdRequest,
    ) -> dingtalkedu__1__0_models.QueryGroupIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryGroupIdHeaders()
        return await self.query_group_id_with_options_async(request, headers, runtime)

    def query_order_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryOrderRequest,
        headers: dingtalkedu__1__0_models.QueryOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryOrderResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.alipay_app_id):
            query['alipayAppId'] = request.alipay_app_id
        if not UtilClient.is_unset(request.merchant_id):
            query['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.order_no):
            query['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            query['signature'] = request.signature
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
            action='QueryOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orders',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def query_order_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryOrderRequest,
        headers: dingtalkedu__1__0_models.QueryOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryOrderResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.alipay_app_id):
            query['alipayAppId'] = request.alipay_app_id
        if not UtilClient.is_unset(request.merchant_id):
            query['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.order_no):
            query['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            query['signature'] = request.signature
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
            action='QueryOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orders',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_order(
        self,
        request: dingtalkedu__1__0_models.QueryOrderRequest,
    ) -> dingtalkedu__1__0_models.QueryOrderResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryOrderHeaders()
        return self.query_order_with_options(request, headers, runtime)

    async def query_order_async(
        self,
        request: dingtalkedu__1__0_models.QueryOrderRequest,
    ) -> dingtalkedu__1__0_models.QueryOrderResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryOrderHeaders()
        return await self.query_order_with_options_async(request, headers, runtime)

    def query_org_relation_list_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryOrgRelationListRequest,
        headers: dingtalkedu__1__0_models.QueryOrgRelationListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryOrgRelationListResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
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
            action='QueryOrgRelationList',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/orgRelations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryOrgRelationListResponse(),
            self.execute(params, req, runtime)
        )

    async def query_org_relation_list_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryOrgRelationListRequest,
        headers: dingtalkedu__1__0_models.QueryOrgRelationListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryOrgRelationListResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
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
            action='QueryOrgRelationList',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/orgRelations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryOrgRelationListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_org_relation_list(
        self,
        request: dingtalkedu__1__0_models.QueryOrgRelationListRequest,
    ) -> dingtalkedu__1__0_models.QueryOrgRelationListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryOrgRelationListHeaders()
        return self.query_org_relation_list_with_options(request, headers, runtime)

    async def query_org_relation_list_async(
        self,
        request: dingtalkedu__1__0_models.QueryOrgRelationListRequest,
    ) -> dingtalkedu__1__0_models.QueryOrgRelationListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryOrgRelationListHeaders()
        return await self.query_org_relation_list_with_options_async(request, headers, runtime)

    def query_org_secret_key_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryOrgSecretKeyRequest,
        headers: dingtalkedu__1__0_models.QueryOrgSecretKeyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryOrgSecretKeyResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.isv_code):
            query['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='QueryOrgSecretKey',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/secretKeys',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryOrgSecretKeyResponse(),
            self.execute(params, req, runtime)
        )

    async def query_org_secret_key_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryOrgSecretKeyRequest,
        headers: dingtalkedu__1__0_models.QueryOrgSecretKeyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryOrgSecretKeyResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.isv_code):
            query['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='QueryOrgSecretKey',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/secretKeys',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryOrgSecretKeyResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_org_secret_key(
        self,
        request: dingtalkedu__1__0_models.QueryOrgSecretKeyRequest,
    ) -> dingtalkedu__1__0_models.QueryOrgSecretKeyResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryOrgSecretKeyHeaders()
        return self.query_org_secret_key_with_options(request, headers, runtime)

    async def query_org_secret_key_async(
        self,
        request: dingtalkedu__1__0_models.QueryOrgSecretKeyRequest,
    ) -> dingtalkedu__1__0_models.QueryOrgSecretKeyResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryOrgSecretKeyHeaders()
        return await self.query_org_secret_key_with_options_async(request, headers, runtime)

    def query_org_type_with_options(
        self,
        headers: dingtalkedu__1__0_models.QueryOrgTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryOrgTypeResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='QueryOrgType',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orgTypes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryOrgTypeResponse(),
            self.execute(params, req, runtime)
        )

    async def query_org_type_with_options_async(
        self,
        headers: dingtalkedu__1__0_models.QueryOrgTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryOrgTypeResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='QueryOrgType',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orgTypes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryOrgTypeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_org_type(self) -> dingtalkedu__1__0_models.QueryOrgTypeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryOrgTypeHeaders()
        return self.query_org_type_with_options(headers, runtime)

    async def query_org_type_async(self) -> dingtalkedu__1__0_models.QueryOrgTypeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryOrgTypeHeaders()
        return await self.query_org_type_with_options_async(headers, runtime)

    def query_pay_result_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryPayResultRequest,
        headers: dingtalkedu__1__0_models.QueryPayResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryPayResultResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.version):
            body['version'] = request.version
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
            action='QueryPayResult',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/payResults/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryPayResultResponse(),
            self.execute(params, req, runtime)
        )

    async def query_pay_result_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryPayResultRequest,
        headers: dingtalkedu__1__0_models.QueryPayResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryPayResultResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.face_id):
            body['faceId'] = request.face_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.version):
            body['version'] = request.version
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
            action='QueryPayResult',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/payResults/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryPayResultResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_pay_result(
        self,
        request: dingtalkedu__1__0_models.QueryPayResultRequest,
    ) -> dingtalkedu__1__0_models.QueryPayResultResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryPayResultHeaders()
        return self.query_pay_result_with_options(request, headers, runtime)

    async def query_pay_result_async(
        self,
        request: dingtalkedu__1__0_models.QueryPayResultRequest,
    ) -> dingtalkedu__1__0_models.QueryPayResultResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryPayResultHeaders()
        return await self.query_pay_result_with_options_async(request, headers, runtime)

    def query_physical_classroom_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryPhysicalClassroomRequest,
        headers: dingtalkedu__1__0_models.QueryPhysicalClassroomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryPhysicalClassroomResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.classroom_id):
            query['classroomId'] = request.classroom_id
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='QueryPhysicalClassroom',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/physicalClassrooms',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryPhysicalClassroomResponse(),
            self.execute(params, req, runtime)
        )

    async def query_physical_classroom_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryPhysicalClassroomRequest,
        headers: dingtalkedu__1__0_models.QueryPhysicalClassroomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryPhysicalClassroomResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.classroom_id):
            query['classroomId'] = request.classroom_id
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='QueryPhysicalClassroom',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/physicalClassrooms',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryPhysicalClassroomResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_physical_classroom(
        self,
        request: dingtalkedu__1__0_models.QueryPhysicalClassroomRequest,
    ) -> dingtalkedu__1__0_models.QueryPhysicalClassroomResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryPhysicalClassroomHeaders()
        return self.query_physical_classroom_with_options(request, headers, runtime)

    async def query_physical_classroom_async(
        self,
        request: dingtalkedu__1__0_models.QueryPhysicalClassroomRequest,
    ) -> dingtalkedu__1__0_models.QueryPhysicalClassroomResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryPhysicalClassroomHeaders()
        return await self.query_physical_classroom_with_options_async(request, headers, runtime)

    def query_purchase_info_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryPurchaseInfoRequest,
        headers: dingtalkedu__1__0_models.QueryPurchaseInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryPurchaseInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.merchant_id):
            query['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.scene):
            query['scene'] = request.scene
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='QueryPurchaseInfo',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/users/purchases',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryPurchaseInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_purchase_info_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryPurchaseInfoRequest,
        headers: dingtalkedu__1__0_models.QueryPurchaseInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryPurchaseInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.merchant_id):
            query['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.scene):
            query['scene'] = request.scene
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='QueryPurchaseInfo',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/users/purchases',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryPurchaseInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_purchase_info(
        self,
        request: dingtalkedu__1__0_models.QueryPurchaseInfoRequest,
    ) -> dingtalkedu__1__0_models.QueryPurchaseInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryPurchaseInfoHeaders()
        return self.query_purchase_info_with_options(request, headers, runtime)

    async def query_purchase_info_async(
        self,
        request: dingtalkedu__1__0_models.QueryPurchaseInfoRequest,
    ) -> dingtalkedu__1__0_models.QueryPurchaseInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryPurchaseInfoHeaders()
        return await self.query_purchase_info_with_options_async(request, headers, runtime)

    def query_remote_class_course_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryRemoteClassCourseRequest,
        headers: dingtalkedu__1__0_models.QueryRemoteClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryRemoteClassCourseResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
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
            action='QueryRemoteClassCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/courses',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryRemoteClassCourseResponse(),
            self.execute(params, req, runtime)
        )

    async def query_remote_class_course_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryRemoteClassCourseRequest,
        headers: dingtalkedu__1__0_models.QueryRemoteClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryRemoteClassCourseResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
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
            action='QueryRemoteClassCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/courses',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryRemoteClassCourseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_remote_class_course(
        self,
        request: dingtalkedu__1__0_models.QueryRemoteClassCourseRequest,
    ) -> dingtalkedu__1__0_models.QueryRemoteClassCourseResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryRemoteClassCourseHeaders()
        return self.query_remote_class_course_with_options(request, headers, runtime)

    async def query_remote_class_course_async(
        self,
        request: dingtalkedu__1__0_models.QueryRemoteClassCourseRequest,
    ) -> dingtalkedu__1__0_models.QueryRemoteClassCourseResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryRemoteClassCourseHeaders()
        return await self.query_remote_class_course_with_options_async(request, headers, runtime)

    def query_school_user_face_with_options(
        self,
        request: dingtalkedu__1__0_models.QuerySchoolUserFaceRequest,
        headers: dingtalkedu__1__0_models.QuerySchoolUserFaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QuerySchoolUserFaceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
        if not UtilClient.is_unset(request.type):
            query['type'] = request.type
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
            action='QuerySchoolUserFace',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/schools/faces',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QuerySchoolUserFaceResponse(),
            self.execute(params, req, runtime)
        )

    async def query_school_user_face_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QuerySchoolUserFaceRequest,
        headers: dingtalkedu__1__0_models.QuerySchoolUserFaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QuerySchoolUserFaceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
        if not UtilClient.is_unset(request.type):
            query['type'] = request.type
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
            action='QuerySchoolUserFace',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/schools/faces',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QuerySchoolUserFaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_school_user_face(
        self,
        request: dingtalkedu__1__0_models.QuerySchoolUserFaceRequest,
    ) -> dingtalkedu__1__0_models.QuerySchoolUserFaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QuerySchoolUserFaceHeaders()
        return self.query_school_user_face_with_options(request, headers, runtime)

    async def query_school_user_face_async(
        self,
        request: dingtalkedu__1__0_models.QuerySchoolUserFaceRequest,
    ) -> dingtalkedu__1__0_models.QuerySchoolUserFaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QuerySchoolUserFaceHeaders()
        return await self.query_school_user_face_with_options_async(request, headers, runtime)

    def query_sns_order_with_options(
        self,
        request: dingtalkedu__1__0_models.QuerySnsOrderRequest,
        headers: dingtalkedu__1__0_models.QuerySnsOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QuerySnsOrderResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.alipay_app_id):
            query['alipayAppId'] = request.alipay_app_id
        if not UtilClient.is_unset(request.merchant_id):
            query['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.order_no):
            query['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            query['signature'] = request.signature
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
            action='QuerySnsOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/snsOrders',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QuerySnsOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def query_sns_order_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QuerySnsOrderRequest,
        headers: dingtalkedu__1__0_models.QuerySnsOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QuerySnsOrderResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.alipay_app_id):
            query['alipayAppId'] = request.alipay_app_id
        if not UtilClient.is_unset(request.merchant_id):
            query['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.order_no):
            query['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.signature):
            query['signature'] = request.signature
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
            action='QuerySnsOrder',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/snsOrders',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QuerySnsOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_sns_order(
        self,
        request: dingtalkedu__1__0_models.QuerySnsOrderRequest,
    ) -> dingtalkedu__1__0_models.QuerySnsOrderResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QuerySnsOrderHeaders()
        return self.query_sns_order_with_options(request, headers, runtime)

    async def query_sns_order_async(
        self,
        request: dingtalkedu__1__0_models.QuerySnsOrderRequest,
    ) -> dingtalkedu__1__0_models.QuerySnsOrderResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QuerySnsOrderHeaders()
        return await self.query_sns_order_with_options_async(request, headers, runtime)

    def query_statistics_data_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryStatisticsDataRequest,
        headers: dingtalkedu__1__0_models.QueryStatisticsDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryStatisticsDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        body = {}
        if not UtilClient.is_unset(request.section_index_list):
            body['sectionIndexList'] = request.section_index_list
        if not UtilClient.is_unset(request.teacher_user_ids):
            body['teacherUserIds'] = request.teacher_user_ids
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
            action='QueryStatisticsData',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/classes/schedules/statisticData/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryStatisticsDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_statistics_data_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryStatisticsDataRequest,
        headers: dingtalkedu__1__0_models.QueryStatisticsDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryStatisticsDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        body = {}
        if not UtilClient.is_unset(request.section_index_list):
            body['sectionIndexList'] = request.section_index_list
        if not UtilClient.is_unset(request.teacher_user_ids):
            body['teacherUserIds'] = request.teacher_user_ids
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
            action='QueryStatisticsData',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/classes/schedules/statisticData/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryStatisticsDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_statistics_data(
        self,
        request: dingtalkedu__1__0_models.QueryStatisticsDataRequest,
    ) -> dingtalkedu__1__0_models.QueryStatisticsDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryStatisticsDataHeaders()
        return self.query_statistics_data_with_options(request, headers, runtime)

    async def query_statistics_data_async(
        self,
        request: dingtalkedu__1__0_models.QueryStatisticsDataRequest,
    ) -> dingtalkedu__1__0_models.QueryStatisticsDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryStatisticsDataHeaders()
        return await self.query_statistics_data_with_options_async(request, headers, runtime)

    def query_subject_teachers_with_options(
        self,
        request: dingtalkedu__1__0_models.QuerySubjectTeachersRequest,
        headers: dingtalkedu__1__0_models.QuerySubjectTeachersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QuerySubjectTeachersResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.class_ids):
            query['classIds'] = request.class_ids
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.subject_code):
            query['subjectCode'] = request.subject_code
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
            action='QuerySubjectTeachers',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/subjects/teachers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QuerySubjectTeachersResponse(),
            self.execute(params, req, runtime)
        )

    async def query_subject_teachers_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QuerySubjectTeachersRequest,
        headers: dingtalkedu__1__0_models.QuerySubjectTeachersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QuerySubjectTeachersResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.class_ids):
            query['classIds'] = request.class_ids
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.subject_code):
            query['subjectCode'] = request.subject_code
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
            action='QuerySubjectTeachers',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/subjects/teachers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QuerySubjectTeachersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_subject_teachers(
        self,
        request: dingtalkedu__1__0_models.QuerySubjectTeachersRequest,
    ) -> dingtalkedu__1__0_models.QuerySubjectTeachersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QuerySubjectTeachersHeaders()
        return self.query_subject_teachers_with_options(request, headers, runtime)

    async def query_subject_teachers_async(
        self,
        request: dingtalkedu__1__0_models.QuerySubjectTeachersRequest,
    ) -> dingtalkedu__1__0_models.QuerySubjectTeachersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QuerySubjectTeachersHeaders()
        return await self.query_subject_teachers_with_options_async(request, headers, runtime)

    def query_teach_subjects_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryTeachSubjectsRequest,
        headers: dingtalkedu__1__0_models.QueryTeachSubjectsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryTeachSubjectsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.class_ids):
            query['classIds'] = request.class_ids
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='QueryTeachSubjects',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/teachers/subjects',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryTeachSubjectsResponse(),
            self.execute(params, req, runtime)
        )

    async def query_teach_subjects_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryTeachSubjectsRequest,
        headers: dingtalkedu__1__0_models.QueryTeachSubjectsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryTeachSubjectsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.class_ids):
            query['classIds'] = request.class_ids
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='QueryTeachSubjects',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/teachers/subjects',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryTeachSubjectsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_teach_subjects(
        self,
        request: dingtalkedu__1__0_models.QueryTeachSubjectsRequest,
    ) -> dingtalkedu__1__0_models.QueryTeachSubjectsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryTeachSubjectsHeaders()
        return self.query_teach_subjects_with_options(request, headers, runtime)

    async def query_teach_subjects_async(
        self,
        request: dingtalkedu__1__0_models.QueryTeachSubjectsRequest,
    ) -> dingtalkedu__1__0_models.QueryTeachSubjectsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryTeachSubjectsHeaders()
        return await self.query_teach_subjects_with_options_async(request, headers, runtime)

    def query_university_course_group_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.QueryUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryUniversityCourseGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.course_group_code):
            query['courseGroupCode'] = request.course_group_code
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='QueryUniversityCourseGroup',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courseGroups',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryUniversityCourseGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def query_university_course_group_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.QueryUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryUniversityCourseGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.course_group_code):
            query['courseGroupCode'] = request.course_group_code
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
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
            action='QueryUniversityCourseGroup',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courseGroups',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryUniversityCourseGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_university_course_group(
        self,
        request: dingtalkedu__1__0_models.QueryUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.QueryUniversityCourseGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryUniversityCourseGroupHeaders()
        return self.query_university_course_group_with_options(request, headers, runtime)

    async def query_university_course_group_async(
        self,
        request: dingtalkedu__1__0_models.QueryUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.QueryUniversityCourseGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryUniversityCourseGroupHeaders()
        return await self.query_university_course_group_with_options_async(request, headers, runtime)

    def query_user_face_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryUserFaceRequest,
        headers: dingtalkedu__1__0_models.QueryUserFaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryUserFaceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.face_id):
            query['faceId'] = request.face_id
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='QueryUserFace',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/users/faces',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryUserFaceResponse(),
            self.execute(params, req, runtime)
        )

    async def query_user_face_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryUserFaceRequest,
        headers: dingtalkedu__1__0_models.QueryUserFaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryUserFaceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.face_id):
            query['faceId'] = request.face_id
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='QueryUserFace',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/users/faces',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryUserFaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_user_face(
        self,
        request: dingtalkedu__1__0_models.QueryUserFaceRequest,
    ) -> dingtalkedu__1__0_models.QueryUserFaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryUserFaceHeaders()
        return self.query_user_face_with_options(request, headers, runtime)

    async def query_user_face_async(
        self,
        request: dingtalkedu__1__0_models.QueryUserFaceRequest,
    ) -> dingtalkedu__1__0_models.QueryUserFaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryUserFaceHeaders()
        return await self.query_user_face_with_options_async(request, headers, runtime)

    def query_user_pay_info_with_options(
        self,
        request: dingtalkedu__1__0_models.QueryUserPayInfoRequest,
        headers: dingtalkedu__1__0_models.QueryUserPayInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryUserPayInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.face_id):
            query['faceId'] = request.face_id
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='QueryUserPayInfo',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orders/payInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryUserPayInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_user_pay_info_with_options_async(
        self,
        request: dingtalkedu__1__0_models.QueryUserPayInfoRequest,
        headers: dingtalkedu__1__0_models.QueryUserPayInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.QueryUserPayInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.face_id):
            query['faceId'] = request.face_id
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='QueryUserPayInfo',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/orders/payInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.QueryUserPayInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_user_pay_info(
        self,
        request: dingtalkedu__1__0_models.QueryUserPayInfoRequest,
    ) -> dingtalkedu__1__0_models.QueryUserPayInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryUserPayInfoHeaders()
        return self.query_user_pay_info_with_options(request, headers, runtime)

    async def query_user_pay_info_async(
        self,
        request: dingtalkedu__1__0_models.QueryUserPayInfoRequest,
    ) -> dingtalkedu__1__0_models.QueryUserPayInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.QueryUserPayInfoHeaders()
        return await self.query_user_pay_info_with_options_async(request, headers, runtime)

    def remove_device_with_options(
        self,
        request: dingtalkedu__1__0_models.RemoveDeviceRequest,
        headers: dingtalkedu__1__0_models.RemoveDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.RemoveDeviceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.merchant_id):
            query['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='RemoveDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/devices',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.RemoveDeviceResponse(),
            self.execute(params, req, runtime)
        )

    async def remove_device_with_options_async(
        self,
        request: dingtalkedu__1__0_models.RemoveDeviceRequest,
        headers: dingtalkedu__1__0_models.RemoveDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.RemoveDeviceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.merchant_id):
            query['merchantId'] = request.merchant_id
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
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
            action='RemoveDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/devices',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.RemoveDeviceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def remove_device(
        self,
        request: dingtalkedu__1__0_models.RemoveDeviceRequest,
    ) -> dingtalkedu__1__0_models.RemoveDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.RemoveDeviceHeaders()
        return self.remove_device_with_options(request, headers, runtime)

    async def remove_device_async(
        self,
        request: dingtalkedu__1__0_models.RemoveDeviceRequest,
    ) -> dingtalkedu__1__0_models.RemoveDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.RemoveDeviceHeaders()
        return await self.remove_device_with_options_async(request, headers, runtime)

    def report_device_log_with_options(
        self,
        request: dingtalkedu__1__0_models.ReportDeviceLogRequest,
        headers: dingtalkedu__1__0_models.ReportDeviceLogHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ReportDeviceLogResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.media_id):
            query['mediaId'] = request.media_id
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
        if not UtilClient.is_unset(request.type):
            query['type'] = request.type
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
            action='ReportDeviceLog',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/deviceLogs/report',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ReportDeviceLogResponse(),
            self.execute(params, req, runtime)
        )

    async def report_device_log_with_options_async(
        self,
        request: dingtalkedu__1__0_models.ReportDeviceLogRequest,
        headers: dingtalkedu__1__0_models.ReportDeviceLogHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ReportDeviceLogResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.media_id):
            query['mediaId'] = request.media_id
        if not UtilClient.is_unset(request.sn):
            query['sn'] = request.sn
        if not UtilClient.is_unset(request.type):
            query['type'] = request.type
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
            action='ReportDeviceLog',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/deviceLogs/report',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ReportDeviceLogResponse(),
            await self.execute_async(params, req, runtime)
        )

    def report_device_log(
        self,
        request: dingtalkedu__1__0_models.ReportDeviceLogRequest,
    ) -> dingtalkedu__1__0_models.ReportDeviceLogResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ReportDeviceLogHeaders()
        return self.report_device_log_with_options(request, headers, runtime)

    async def report_device_log_async(
        self,
        request: dingtalkedu__1__0_models.ReportDeviceLogRequest,
    ) -> dingtalkedu__1__0_models.ReportDeviceLogResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ReportDeviceLogHeaders()
        return await self.report_device_log_with_options_async(request, headers, runtime)

    def report_device_use_log_with_options(
        self,
        request: dingtalkedu__1__0_models.ReportDeviceUseLogRequest,
        headers: dingtalkedu__1__0_models.ReportDeviceUseLogHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ReportDeviceUseLogResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
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
            action='ReportDeviceUseLog',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/deviceUseLogs/report',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ReportDeviceUseLogResponse(),
            self.execute(params, req, runtime)
        )

    async def report_device_use_log_with_options_async(
        self,
        request: dingtalkedu__1__0_models.ReportDeviceUseLogRequest,
        headers: dingtalkedu__1__0_models.ReportDeviceUseLogHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ReportDeviceUseLogResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
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
            action='ReportDeviceUseLog',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/deviceUseLogs/report',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ReportDeviceUseLogResponse(),
            await self.execute_async(params, req, runtime)
        )

    def report_device_use_log(
        self,
        request: dingtalkedu__1__0_models.ReportDeviceUseLogRequest,
    ) -> dingtalkedu__1__0_models.ReportDeviceUseLogResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ReportDeviceUseLogHeaders()
        return self.report_device_use_log_with_options(request, headers, runtime)

    async def report_device_use_log_async(
        self,
        request: dingtalkedu__1__0_models.ReportDeviceUseLogRequest,
    ) -> dingtalkedu__1__0_models.ReportDeviceUseLogResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ReportDeviceUseLogHeaders()
        return await self.report_device_use_log_with_options_async(request, headers, runtime)

    def rollback_deduct_point_with_options(
        self,
        request: dingtalkedu__1__0_models.RollbackDeductPointRequest,
        headers: dingtalkedu__1__0_models.RollbackDeductPointHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.RollbackDeductPointResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.point_type):
            body['pointType'] = request.point_type
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
            action='RollbackDeductPoint',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/deductPoints/rollback',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.RollbackDeductPointResponse(),
            self.execute(params, req, runtime)
        )

    async def rollback_deduct_point_with_options_async(
        self,
        request: dingtalkedu__1__0_models.RollbackDeductPointRequest,
        headers: dingtalkedu__1__0_models.RollbackDeductPointHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.RollbackDeductPointResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.point_type):
            body['pointType'] = request.point_type
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
            action='RollbackDeductPoint',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/deductPoints/rollback',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.RollbackDeductPointResponse(),
            await self.execute_async(params, req, runtime)
        )

    def rollback_deduct_point(
        self,
        request: dingtalkedu__1__0_models.RollbackDeductPointRequest,
    ) -> dingtalkedu__1__0_models.RollbackDeductPointResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.RollbackDeductPointHeaders()
        return self.rollback_deduct_point_with_options(request, headers, runtime)

    async def rollback_deduct_point_async(
        self,
        request: dingtalkedu__1__0_models.RollbackDeductPointRequest,
    ) -> dingtalkedu__1__0_models.RollbackDeductPointResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.RollbackDeductPointHeaders()
        return await self.rollback_deduct_point_with_options_async(request, headers, runtime)

    def search_teachers_with_options(
        self,
        request: dingtalkedu__1__0_models.SearchTeachersRequest,
        headers: dingtalkedu__1__0_models.SearchTeachersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.SearchTeachersResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.name_keyword):
            query['nameKeyword'] = request.name_keyword
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
            action='SearchTeachers',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/teachers/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.SearchTeachersResponse(),
            self.execute(params, req, runtime)
        )

    async def search_teachers_with_options_async(
        self,
        request: dingtalkedu__1__0_models.SearchTeachersRequest,
        headers: dingtalkedu__1__0_models.SearchTeachersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.SearchTeachersResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.name_keyword):
            query['nameKeyword'] = request.name_keyword
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
            action='SearchTeachers',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/teachers/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.SearchTeachersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_teachers(
        self,
        request: dingtalkedu__1__0_models.SearchTeachersRequest,
    ) -> dingtalkedu__1__0_models.SearchTeachersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.SearchTeachersHeaders()
        return self.search_teachers_with_options(request, headers, runtime)

    async def search_teachers_async(
        self,
        request: dingtalkedu__1__0_models.SearchTeachersRequest,
    ) -> dingtalkedu__1__0_models.SearchTeachersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.SearchTeachersHeaders()
        return await self.search_teachers_with_options_async(request, headers, runtime)

    def send_message_with_options(
        self,
        request: dingtalkedu__1__0_models.SendMessageRequest,
        headers: dingtalkedu__1__0_models.SendMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.SendMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.from_user_id):
            body['fromUserId'] = request.from_user_id
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.to_user_id_list):
            body['toUserIdList'] = request.to_user_id_list
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='SendMessage',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/messages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.SendMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def send_message_with_options_async(
        self,
        request: dingtalkedu__1__0_models.SendMessageRequest,
        headers: dingtalkedu__1__0_models.SendMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.SendMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.from_user_id):
            body['fromUserId'] = request.from_user_id
        if not UtilClient.is_unset(request.sn):
            body['sn'] = request.sn
        if not UtilClient.is_unset(request.to_user_id_list):
            body['toUserIdList'] = request.to_user_id_list
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='SendMessage',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/messages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.SendMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_message(
        self,
        request: dingtalkedu__1__0_models.SendMessageRequest,
    ) -> dingtalkedu__1__0_models.SendMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.SendMessageHeaders()
        return self.send_message_with_options(request, headers, runtime)

    async def send_message_async(
        self,
        request: dingtalkedu__1__0_models.SendMessageRequest,
    ) -> dingtalkedu__1__0_models.SendMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.SendMessageHeaders()
        return await self.send_message_with_options_async(request, headers, runtime)

    def start_course_with_options(
        self,
        request: dingtalkedu__1__0_models.StartCourseRequest,
        headers: dingtalkedu__1__0_models.StartCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.StartCourseResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.course_code):
            body['courseCode'] = request.course_code
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.live_play_info_list):
            body['livePlayInfoList'] = request.live_play_info_list
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
            action='StartCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courses/start',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.StartCourseResponse(),
            self.execute(params, req, runtime)
        )

    async def start_course_with_options_async(
        self,
        request: dingtalkedu__1__0_models.StartCourseRequest,
        headers: dingtalkedu__1__0_models.StartCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.StartCourseResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.course_code):
            body['courseCode'] = request.course_code
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.live_play_info_list):
            body['livePlayInfoList'] = request.live_play_info_list
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
            action='StartCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courses/start',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.StartCourseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def start_course(
        self,
        request: dingtalkedu__1__0_models.StartCourseRequest,
    ) -> dingtalkedu__1__0_models.StartCourseResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.StartCourseHeaders()
        return self.start_course_with_options(request, headers, runtime)

    async def start_course_async(
        self,
        request: dingtalkedu__1__0_models.StartCourseRequest,
    ) -> dingtalkedu__1__0_models.StartCourseResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.StartCourseHeaders()
        return await self.start_course_with_options_async(request, headers, runtime)

    def start_course_prepare_with_options(
        self,
        request: dingtalkedu__1__0_models.StartCoursePrepareRequest,
        headers: dingtalkedu__1__0_models.StartCoursePrepareHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.StartCoursePrepareResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.course_date):
            body['courseDate'] = request.course_date
        if not UtilClient.is_unset(request.course_group_code):
            body['courseGroupCode'] = request.course_group_code
        if not UtilClient.is_unset(request.device_id):
            body['deviceId'] = request.device_id
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.live_cover_image):
            body['liveCoverImage'] = request.live_cover_image
        if not UtilClient.is_unset(request.section_index):
            body['sectionIndex'] = request.section_index
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
            action='StartCoursePrepare',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courses/prepare',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.StartCoursePrepareResponse(),
            self.execute(params, req, runtime)
        )

    async def start_course_prepare_with_options_async(
        self,
        request: dingtalkedu__1__0_models.StartCoursePrepareRequest,
        headers: dingtalkedu__1__0_models.StartCoursePrepareHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.StartCoursePrepareResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.course_date):
            body['courseDate'] = request.course_date
        if not UtilClient.is_unset(request.course_group_code):
            body['courseGroupCode'] = request.course_group_code
        if not UtilClient.is_unset(request.device_id):
            body['deviceId'] = request.device_id
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
        if not UtilClient.is_unset(request.isv_code):
            body['isvCode'] = request.isv_code
        if not UtilClient.is_unset(request.live_cover_image):
            body['liveCoverImage'] = request.live_cover_image
        if not UtilClient.is_unset(request.section_index):
            body['sectionIndex'] = request.section_index
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
            action='StartCoursePrepare',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courses/prepare',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.StartCoursePrepareResponse(),
            await self.execute_async(params, req, runtime)
        )

    def start_course_prepare(
        self,
        request: dingtalkedu__1__0_models.StartCoursePrepareRequest,
    ) -> dingtalkedu__1__0_models.StartCoursePrepareResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.StartCoursePrepareHeaders()
        return self.start_course_prepare_with_options(request, headers, runtime)

    async def start_course_prepare_async(
        self,
        request: dingtalkedu__1__0_models.StartCoursePrepareRequest,
    ) -> dingtalkedu__1__0_models.StartCoursePrepareResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.StartCoursePrepareHeaders()
        return await self.start_course_prepare_with_options_async(request, headers, runtime)

    def subscribe_university_course_group_with_options(
        self,
        request: dingtalkedu__1__0_models.SubscribeUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.SubscribeUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.SubscribeUniversityCourseGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.course_group_code):
            body['courseGroupCode'] = request.course_group_code
        if not UtilClient.is_unset(request.student_user_ids):
            body['studentUserIds'] = request.student_user_ids
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
            action='SubscribeUniversityCourseGroup',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courseGroups/subscribe',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.SubscribeUniversityCourseGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def subscribe_university_course_group_with_options_async(
        self,
        request: dingtalkedu__1__0_models.SubscribeUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.SubscribeUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.SubscribeUniversityCourseGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.course_group_code):
            body['courseGroupCode'] = request.course_group_code
        if not UtilClient.is_unset(request.student_user_ids):
            body['studentUserIds'] = request.student_user_ids
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
            action='SubscribeUniversityCourseGroup',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courseGroups/subscribe',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.SubscribeUniversityCourseGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def subscribe_university_course_group(
        self,
        request: dingtalkedu__1__0_models.SubscribeUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.SubscribeUniversityCourseGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.SubscribeUniversityCourseGroupHeaders()
        return self.subscribe_university_course_group_with_options(request, headers, runtime)

    async def subscribe_university_course_group_async(
        self,
        request: dingtalkedu__1__0_models.SubscribeUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.SubscribeUniversityCourseGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.SubscribeUniversityCourseGroupHeaders()
        return await self.subscribe_university_course_group_with_options_async(request, headers, runtime)

    def unsubscribe_university_course_group_with_options(
        self,
        request: dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.course_group_code):
            body['courseGroupCode'] = request.course_group_code
        if not UtilClient.is_unset(request.student_user_ids):
            body['studentUserIds'] = request.student_user_ids
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
            action='UnsubscribeUniversityCourseGroup',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courseGroups/unsubscribe',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def unsubscribe_university_course_group_with_options_async(
        self,
        request: dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.course_group_code):
            body['courseGroupCode'] = request.course_group_code
        if not UtilClient.is_unset(request.student_user_ids):
            body['studentUserIds'] = request.student_user_ids
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
            action='UnsubscribeUniversityCourseGroup',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courseGroups/unsubscribe',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def unsubscribe_university_course_group(
        self,
        request: dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupHeaders()
        return self.unsubscribe_university_course_group_with_options(request, headers, runtime)

    async def unsubscribe_university_course_group_async(
        self,
        request: dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UnsubscribeUniversityCourseGroupHeaders()
        return await self.unsubscribe_university_course_group_with_options_async(request, headers, runtime)

    def update_courses_of_class_with_options(
        self,
        class_id: str,
        request: dingtalkedu__1__0_models.UpdateCoursesOfClassRequest,
        headers: dingtalkedu__1__0_models.UpdateCoursesOfClassHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateCoursesOfClassResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.courses):
            body['courses'] = request.courses
        if not UtilClient.is_unset(request.section_config):
            body['sectionConfig'] = request.section_config
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
            action='UpdateCoursesOfClass',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/classes/{class_id}/courses/schedules',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateCoursesOfClassResponse(),
            self.execute(params, req, runtime)
        )

    async def update_courses_of_class_with_options_async(
        self,
        class_id: str,
        request: dingtalkedu__1__0_models.UpdateCoursesOfClassRequest,
        headers: dingtalkedu__1__0_models.UpdateCoursesOfClassHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateCoursesOfClassResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.courses):
            body['courses'] = request.courses
        if not UtilClient.is_unset(request.section_config):
            body['sectionConfig'] = request.section_config
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
            action='UpdateCoursesOfClass',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/classes/{class_id}/courses/schedules',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateCoursesOfClassResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_courses_of_class(
        self,
        class_id: str,
        request: dingtalkedu__1__0_models.UpdateCoursesOfClassRequest,
    ) -> dingtalkedu__1__0_models.UpdateCoursesOfClassResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateCoursesOfClassHeaders()
        return self.update_courses_of_class_with_options(class_id, request, headers, runtime)

    async def update_courses_of_class_async(
        self,
        class_id: str,
        request: dingtalkedu__1__0_models.UpdateCoursesOfClassRequest,
    ) -> dingtalkedu__1__0_models.UpdateCoursesOfClassResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateCoursesOfClassHeaders()
        return await self.update_courses_of_class_with_options_async(class_id, request, headers, runtime)

    def update_physical_classroom_with_options(
        self,
        request: dingtalkedu__1__0_models.UpdatePhysicalClassroomRequest,
        headers: dingtalkedu__1__0_models.UpdatePhysicalClassroomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdatePhysicalClassroomResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.classroom_building):
            body['classroomBuilding'] = request.classroom_building
        if not UtilClient.is_unset(request.classroom_campus):
            body['classroomCampus'] = request.classroom_campus
        if not UtilClient.is_unset(request.classroom_floor):
            body['classroomFloor'] = request.classroom_floor
        if not UtilClient.is_unset(request.classroom_id):
            body['classroomId'] = request.classroom_id
        if not UtilClient.is_unset(request.classroom_name):
            body['classroomName'] = request.classroom_name
        if not UtilClient.is_unset(request.classroom_number):
            body['classroomNumber'] = request.classroom_number
        if not UtilClient.is_unset(request.direct_broadcast):
            body['directBroadcast'] = request.direct_broadcast
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
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
            action='UpdatePhysicalClassroom',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/physicalClassrooms',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdatePhysicalClassroomResponse(),
            self.execute(params, req, runtime)
        )

    async def update_physical_classroom_with_options_async(
        self,
        request: dingtalkedu__1__0_models.UpdatePhysicalClassroomRequest,
        headers: dingtalkedu__1__0_models.UpdatePhysicalClassroomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdatePhysicalClassroomResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.classroom_building):
            body['classroomBuilding'] = request.classroom_building
        if not UtilClient.is_unset(request.classroom_campus):
            body['classroomCampus'] = request.classroom_campus
        if not UtilClient.is_unset(request.classroom_floor):
            body['classroomFloor'] = request.classroom_floor
        if not UtilClient.is_unset(request.classroom_id):
            body['classroomId'] = request.classroom_id
        if not UtilClient.is_unset(request.classroom_name):
            body['classroomName'] = request.classroom_name
        if not UtilClient.is_unset(request.classroom_number):
            body['classroomNumber'] = request.classroom_number
        if not UtilClient.is_unset(request.direct_broadcast):
            body['directBroadcast'] = request.direct_broadcast
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
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
            action='UpdatePhysicalClassroom',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/physicalClassrooms',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdatePhysicalClassroomResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_physical_classroom(
        self,
        request: dingtalkedu__1__0_models.UpdatePhysicalClassroomRequest,
    ) -> dingtalkedu__1__0_models.UpdatePhysicalClassroomResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdatePhysicalClassroomHeaders()
        return self.update_physical_classroom_with_options(request, headers, runtime)

    async def update_physical_classroom_async(
        self,
        request: dingtalkedu__1__0_models.UpdatePhysicalClassroomRequest,
    ) -> dingtalkedu__1__0_models.UpdatePhysicalClassroomResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdatePhysicalClassroomHeaders()
        return await self.update_physical_classroom_with_options_async(request, headers, runtime)

    def update_remote_class_course_with_options(
        self,
        request: dingtalkedu__1__0_models.UpdateRemoteClassCourseRequest,
        headers: dingtalkedu__1__0_models.UpdateRemoteClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateRemoteClassCourseResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attend_participants):
            body['attendParticipants'] = request.attend_participants
        if not UtilClient.is_unset(request.auth_code):
            body['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.course_code):
            body['courseCode'] = request.course_code
        if not UtilClient.is_unset(request.course_name):
            body['courseName'] = request.course_name
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.teaching_participant):
            body['teachingParticipant'] = request.teaching_participant
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
            action='UpdateRemoteClassCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/courses',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateRemoteClassCourseResponse(),
            self.execute(params, req, runtime)
        )

    async def update_remote_class_course_with_options_async(
        self,
        request: dingtalkedu__1__0_models.UpdateRemoteClassCourseRequest,
        headers: dingtalkedu__1__0_models.UpdateRemoteClassCourseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateRemoteClassCourseResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attend_participants):
            body['attendParticipants'] = request.attend_participants
        if not UtilClient.is_unset(request.auth_code):
            body['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.course_code):
            body['courseCode'] = request.course_code
        if not UtilClient.is_unset(request.course_name):
            body['courseName'] = request.course_name
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.teaching_participant):
            body['teachingParticipant'] = request.teaching_participant
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
            action='UpdateRemoteClassCourse',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/courses',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateRemoteClassCourseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_remote_class_course(
        self,
        request: dingtalkedu__1__0_models.UpdateRemoteClassCourseRequest,
    ) -> dingtalkedu__1__0_models.UpdateRemoteClassCourseResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateRemoteClassCourseHeaders()
        return self.update_remote_class_course_with_options(request, headers, runtime)

    async def update_remote_class_course_async(
        self,
        request: dingtalkedu__1__0_models.UpdateRemoteClassCourseRequest,
    ) -> dingtalkedu__1__0_models.UpdateRemoteClassCourseResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateRemoteClassCourseHeaders()
        return await self.update_remote_class_course_with_options_async(request, headers, runtime)

    def update_remote_class_device_with_options(
        self,
        request: dingtalkedu__1__0_models.UpdateRemoteClassDeviceRequest,
        headers: dingtalkedu__1__0_models.UpdateRemoteClassDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateRemoteClassDeviceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.auth_code):
            query['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.device_code):
            query['deviceCode'] = request.device_code
        if not UtilClient.is_unset(request.device_name):
            query['deviceName'] = request.device_name
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
            action='UpdateRemoteClassDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/deviceNames',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateRemoteClassDeviceResponse(),
            self.execute(params, req, runtime)
        )

    async def update_remote_class_device_with_options_async(
        self,
        request: dingtalkedu__1__0_models.UpdateRemoteClassDeviceRequest,
        headers: dingtalkedu__1__0_models.UpdateRemoteClassDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateRemoteClassDeviceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.auth_code):
            query['authCode'] = request.auth_code
        if not UtilClient.is_unset(request.device_code):
            query['deviceCode'] = request.device_code
        if not UtilClient.is_unset(request.device_name):
            query['deviceName'] = request.device_name
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
            action='UpdateRemoteClassDevice',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/remoteClasses/deviceNames',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateRemoteClassDeviceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_remote_class_device(
        self,
        request: dingtalkedu__1__0_models.UpdateRemoteClassDeviceRequest,
    ) -> dingtalkedu__1__0_models.UpdateRemoteClassDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateRemoteClassDeviceHeaders()
        return self.update_remote_class_device_with_options(request, headers, runtime)

    async def update_remote_class_device_async(
        self,
        request: dingtalkedu__1__0_models.UpdateRemoteClassDeviceRequest,
    ) -> dingtalkedu__1__0_models.UpdateRemoteClassDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateRemoteClassDeviceHeaders()
        return await self.update_remote_class_device_with_options_async(request, headers, runtime)

    def update_university_course_group_with_options(
        self,
        request: dingtalkedu__1__0_models.UpdateUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.UpdateUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateUniversityCourseGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.course_group_code):
            body['courseGroupCode'] = request.course_group_code
        if not UtilClient.is_unset(request.course_group_introduce):
            body['courseGroupIntroduce'] = request.course_group_introduce
        if not UtilClient.is_unset(request.course_group_name):
            body['courseGroupName'] = request.course_group_name
        if not UtilClient.is_unset(request.courser_group_item_models):
            body['courserGroupItemModels'] = request.courser_group_item_models
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
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
            action='UpdateUniversityCourseGroup',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courseGroups',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateUniversityCourseGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def update_university_course_group_with_options_async(
        self,
        request: dingtalkedu__1__0_models.UpdateUniversityCourseGroupRequest,
        headers: dingtalkedu__1__0_models.UpdateUniversityCourseGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.UpdateUniversityCourseGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        body = {}
        if not UtilClient.is_unset(request.course_group_code):
            body['courseGroupCode'] = request.course_group_code
        if not UtilClient.is_unset(request.course_group_introduce):
            body['courseGroupIntroduce'] = request.course_group_introduce
        if not UtilClient.is_unset(request.course_group_name):
            body['courseGroupName'] = request.course_group_name
        if not UtilClient.is_unset(request.courser_group_item_models):
            body['courserGroupItemModels'] = request.courser_group_item_models
        if not UtilClient.is_unset(request.ext):
            body['ext'] = request.ext
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
            action='UpdateUniversityCourseGroup',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/universities/courseGroups',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.UpdateUniversityCourseGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_university_course_group(
        self,
        request: dingtalkedu__1__0_models.UpdateUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.UpdateUniversityCourseGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateUniversityCourseGroupHeaders()
        return self.update_university_course_group_with_options(request, headers, runtime)

    async def update_university_course_group_async(
        self,
        request: dingtalkedu__1__0_models.UpdateUniversityCourseGroupRequest,
    ) -> dingtalkedu__1__0_models.UpdateUniversityCourseGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.UpdateUniversityCourseGroupHeaders()
        return await self.update_university_course_group_with_options_async(request, headers, runtime)

    def v_paas_proxy_with_options(
        self,
        request: dingtalkedu__1__0_models.VPaasProxyRequest,
        headers: dingtalkedu__1__0_models.VPaasProxyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.VPaasProxyResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action_code):
            body['actionCode'] = request.action_code
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
        if not UtilClient.is_unset(request.public_key):
            body['publicKey'] = request.public_key
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
            action='VPaasProxy',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/proxy',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.VPaasProxyResponse(),
            self.execute(params, req, runtime)
        )

    async def v_paas_proxy_with_options_async(
        self,
        request: dingtalkedu__1__0_models.VPaasProxyRequest,
        headers: dingtalkedu__1__0_models.VPaasProxyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.VPaasProxyResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action_code):
            body['actionCode'] = request.action_code
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
        if not UtilClient.is_unset(request.public_key):
            body['publicKey'] = request.public_key
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
            action='VPaasProxy',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/vpaas/proxy',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.VPaasProxyResponse(),
            await self.execute_async(params, req, runtime)
        )

    def v_paas_proxy(
        self,
        request: dingtalkedu__1__0_models.VPaasProxyRequest,
    ) -> dingtalkedu__1__0_models.VPaasProxyResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.VPaasProxyHeaders()
        return self.v_paas_proxy_with_options(request, headers, runtime)

    async def v_paas_proxy_async(
        self,
        request: dingtalkedu__1__0_models.VPaasProxyRequest,
    ) -> dingtalkedu__1__0_models.VPaasProxyResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.VPaasProxyHeaders()
        return await self.v_paas_proxy_with_options_async(request, headers, runtime)

    def validate_user_role_with_options(
        self,
        request: dingtalkedu__1__0_models.ValidateUserRoleRequest,
        headers: dingtalkedu__1__0_models.ValidateUserRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ValidateUserRoleResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.time_threshold):
            body['timeThreshold'] = request.time_threshold
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
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
            action='ValidateUserRole',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/users/roles/validate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ValidateUserRoleResponse(),
            self.execute(params, req, runtime)
        )

    async def validate_user_role_with_options_async(
        self,
        request: dingtalkedu__1__0_models.ValidateUserRoleRequest,
        headers: dingtalkedu__1__0_models.ValidateUserRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkedu__1__0_models.ValidateUserRoleResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.time_threshold):
            body['timeThreshold'] = request.time_threshold
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
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
            action='ValidateUserRole',
            version='edu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/edu/users/roles/validate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkedu__1__0_models.ValidateUserRoleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def validate_user_role(
        self,
        request: dingtalkedu__1__0_models.ValidateUserRoleRequest,
    ) -> dingtalkedu__1__0_models.ValidateUserRoleResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ValidateUserRoleHeaders()
        return self.validate_user_role_with_options(request, headers, runtime)

    async def validate_user_role_async(
        self,
        request: dingtalkedu__1__0_models.ValidateUserRoleRequest,
    ) -> dingtalkedu__1__0_models.ValidateUserRoleResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkedu__1__0_models.ValidateUserRoleHeaders()
        return await self.validate_user_role_with_options_async(request, headers, runtime)
