# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict


class SendByAppHeaders(TeaModel):
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


class SendByAppRequest(TeaModel):
    def __init__(
        self,
        dentry_id: str = None,
        space_id: str = None,
        target_union_id: str = None,
        union_id: str = None,
    ):
        # 文件id
        self.dentry_id = dentry_id
        # 文件所在空间id
        self.space_id = space_id
        # 目标用户id
        # 会通过应用发送消息给指定用户
        self.target_union_id = target_union_id
        # 用户id
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dentry_id is not None:
            result['dentryId'] = self.dentry_id
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.target_union_id is not None:
            result['targetUnionId'] = self.target_union_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentryId') is not None:
            self.dentry_id = m.get('dentryId')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('targetUnionId') is not None:
            self.target_union_id = m.get('targetUnionId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class SendByAppResponseBodyFile(TeaModel):
    def __init__(
        self,
        conversation_id: str = None,
        create_time: str = None,
        creator_id: str = None,
        extension: str = None,
        id: str = None,
        modified_time: str = None,
        modifier_id: str = None,
        name: str = None,
        parent_id: str = None,
        path: str = None,
        size: int = None,
        space_id: str = None,
        status: str = None,
        type: str = None,
        uuid: str = None,
        version: int = None,
    ):
        # 文件所在会话id
        self.conversation_id = conversation_id
        # 创建时间
        self.create_time = create_time
        # 创建者id
        self.creator_id = creator_id
        # 文件后缀
        self.extension = extension
        # 文件id
        self.id = id
        # 修改时间
        self.modified_time = modified_time
        # 修改者id
        self.modifier_id = modifier_id
        # 文件(夹)名称
        self.name = name
        # 文件所在的父目录id, 根目录id值为0
        self.parent_id = parent_id
        # 文件路径
        self.path = path
        # 文件大小, 单位:Byte
        self.size = size
        # 文件所在空间id
        self.space_id = space_id
        # 文件状态
        # 枚举值:
        # 	NORMAL: 正常
        # 	DELETED: 已删除
        # 	EXPIRED: 已过期
        self.status = status
        # 文件类型：文件、文件夹
        # 枚举值:
        # 	FILE: 文件
        # 	FOLDER: 文件夹
        self.type = type
        # uuid，如移动文件，此字段不变
        self.uuid = uuid
        # 文件版本
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conversation_id is not None:
            result['conversationId'] = self.conversation_id
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.extension is not None:
            result['extension'] = self.extension
        if self.id is not None:
            result['id'] = self.id
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.modifier_id is not None:
            result['modifierId'] = self.modifier_id
        if self.name is not None:
            result['name'] = self.name
        if self.parent_id is not None:
            result['parentId'] = self.parent_id
        if self.path is not None:
            result['path'] = self.path
        if self.size is not None:
            result['size'] = self.size
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.status is not None:
            result['status'] = self.status
        if self.type is not None:
            result['type'] = self.type
        if self.uuid is not None:
            result['uuid'] = self.uuid
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conversationId') is not None:
            self.conversation_id = m.get('conversationId')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('modifierId') is not None:
            self.modifier_id = m.get('modifierId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('parentId') is not None:
            self.parent_id = m.get('parentId')
        if m.get('path') is not None:
            self.path = m.get('path')
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class SendByAppResponseBody(TeaModel):
    def __init__(
        self,
        file: SendByAppResponseBodyFile = None,
    ):
        # 发送到目标会话的文件信息
        self.file = file

    def validate(self):
        if self.file:
            self.file.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file is not None:
            result['file'] = self.file.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('file') is not None:
            temp_model = SendByAppResponseBodyFile()
            self.file = temp_model.from_map(m['file'])
        return self


class SendByAppResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SendByAppResponseBody = None,
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
            temp_model = SendByAppResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


