# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict


class CreatePackageHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CreatePackageRequest(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        app_id: int = None,
        oss_object_key: str = None,
    ):
        # 企业内部微应用agentId
        self.agent_id = agent_id
        # 第三方企业应用appId
        self.app_id = app_id
        # 通过获取上传凭据接口返回的name值
        self.oss_object_key = oss_object_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.oss_object_key is not None:
            result['ossObjectKey'] = self.oss_object_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('ossObjectKey') is not None:
            self.oss_object_key = m.get('ossObjectKey')
        return self


class CreatePackageResponseBody(TeaModel):
    def __init__(
        self,
        task_id: str = None,
    ):
        # 创建任务ID
        self.task_id = task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class CreatePackageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreatePackageResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = CreatePackageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetAccessTokenHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetAccessTokenRequest(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        app_id: int = None,
    ):
        # 企业内部微应用agentId。
        self.agent_id = agent_id
        # 第三方企业应用appId。
        self.app_id = app_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.app_id is not None:
            result['appId'] = self.app_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        return self


class GetAccessTokenResponseBody(TeaModel):
    def __init__(
        self,
        access_key_id: str = None,
        access_key_secret: str = None,
        bucket: str = None,
        endpoint: str = None,
        expiration: str = None,
        name: str = None,
        region: str = None,
        sts_token: str = None,
    ):
        # 阿里云OSS SDK初始化配置项
        self.access_key_id = access_key_id
        # 阿里云OSS SDK初始化配置项
        self.access_key_secret = access_key_secret
        # 阿里云OSS SDK初始化配置项
        self.bucket = bucket
        # 阿里云OSS SDK初始化配置项
        self.endpoint = endpoint
        # 阿里云OSS SDK初始化配置项
        self.expiration = expiration
        # 可上传的阿里云OSS文件地址
        self.name = name
        # 阿里云OSS SDK初始化配置项
        self.region = region
        # 阿里云OSS SDK初始化配置项
        self.sts_token = sts_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key_id is not None:
            result['accessKeyId'] = self.access_key_id
        if self.access_key_secret is not None:
            result['accessKeySecret'] = self.access_key_secret
        if self.bucket is not None:
            result['bucket'] = self.bucket
        if self.endpoint is not None:
            result['endpoint'] = self.endpoint
        if self.expiration is not None:
            result['expiration'] = self.expiration
        if self.name is not None:
            result['name'] = self.name
        if self.region is not None:
            result['region'] = self.region
        if self.sts_token is not None:
            result['stsToken'] = self.sts_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKeyId') is not None:
            self.access_key_id = m.get('accessKeyId')
        if m.get('accessKeySecret') is not None:
            self.access_key_secret = m.get('accessKeySecret')
        if m.get('bucket') is not None:
            self.bucket = m.get('bucket')
        if m.get('endpoint') is not None:
            self.endpoint = m.get('endpoint')
        if m.get('expiration') is not None:
            self.expiration = m.get('expiration')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('region') is not None:
            self.region = m.get('region')
        if m.get('stsToken') is not None:
            self.sts_token = m.get('stsToken')
        return self


class GetAccessTokenResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetAccessTokenResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = GetAccessTokenResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetCreateStatusHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetCreateStatusRequest(TeaModel):
    def __init__(
        self,
        task_id: str = None,
    ):
        # 创建离线包接口返回的taskId
        self.task_id = task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class GetCreateStatusResponseBody(TeaModel):
    def __init__(
        self,
        build_time: int = None,
        finished: bool = None,
        package_size: int = None,
        status: str = None,
        task_id: str = None,
        version: str = None,
    ):
        # 创建时间
        self.build_time = build_time
        # 任务是否已结束
        self.finished = finished
        # H5离线包体积，单位Byte
        self.package_size = package_size
        # 任务状态。1：构建中；2：成功；3：失败；5：超时。
        self.status = status
        # 创建离线包接口返回的taskId
        self.task_id = task_id
        # H5离线包版本号
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.build_time is not None:
            result['buildTime'] = self.build_time
        if self.finished is not None:
            result['finished'] = self.finished
        if self.package_size is not None:
            result['packageSize'] = self.package_size
        if self.status is not None:
            result['status'] = self.status
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('buildTime') is not None:
            self.build_time = m.get('buildTime')
        if m.get('finished') is not None:
            self.finished = m.get('finished')
        if m.get('packageSize') is not None:
            self.package_size = m.get('packageSize')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class GetCreateStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetCreateStatusResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = GetCreateStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PublishPackageHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class PublishPackageRequest(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        app_id: int = None,
        version: str = None,
    ):
        # 企业内部微应用agentId
        self.agent_id = agent_id
        # 第三方企业应用appId
        self.app_id = app_id
        # H5离线包版本号
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class PublishPackageResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        # 成功标记
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class PublishPackageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: PublishPackageResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = PublishPackageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


