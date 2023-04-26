# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict


class GetSpaceHeaders(TeaModel):
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


class GetSpaceRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        union_id: str = None,
    ):
        self.open_conversation_id = open_conversation_id
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetSpaceResponseBodySpace(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        create_time: str = None,
        modified_time: str = None,
        space_id: str = None,
    ):
        self.corp_id = corp_id
        self.create_time = create_time
        self.modified_time = modified_time
        self.space_id = space_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        return self


class GetSpaceResponseBody(TeaModel):
    def __init__(
        self,
        space: GetSpaceResponseBodySpace = None,
    ):
        self.space = space

    def validate(self):
        if self.space:
            self.space.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.space is not None:
            result['space'] = self.space.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('space') is not None:
            temp_model = GetSpaceResponseBodySpace()
            self.space = temp_model.from_map(m['space'])
        return self


class GetSpaceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetSpaceResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = GetSpaceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendHeaders(TeaModel):
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


class SendRequest(TeaModel):
    def __init__(
        self,
        dentry_id: str = None,
        open_conversation_id: str = None,
        space_id: str = None,
        union_id: str = None,
    ):
        self.dentry_id = dentry_id
        self.open_conversation_id = open_conversation_id
        self.space_id = space_id
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
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentryId') is not None:
            self.dentry_id = m.get('dentryId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class SendResponseBodyFile(TeaModel):
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
        self.conversation_id = conversation_id
        self.create_time = create_time
        self.creator_id = creator_id
        self.extension = extension
        self.id = id
        self.modified_time = modified_time
        self.modifier_id = modifier_id
        self.name = name
        self.parent_id = parent_id
        self.path = path
        self.size = size
        self.space_id = space_id
        self.status = status
        self.type = type
        self.uuid = uuid
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


class SendResponseBody(TeaModel):
    def __init__(
        self,
        file: SendResponseBodyFile = None,
    ):
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
            temp_model = SendResponseBodyFile()
            self.file = temp_model.from_map(m['file'])
        return self


class SendResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SendResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = SendResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


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
        union_id: str = None,
    ):
        self.dentry_id = dentry_id
        self.space_id = space_id
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
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentryId') is not None:
            self.dentry_id = m.get('dentryId')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
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
        self.conversation_id = conversation_id
        self.create_time = create_time
        self.creator_id = creator_id
        self.extension = extension
        self.id = id
        self.modified_time = modified_time
        self.modifier_id = modifier_id
        self.name = name
        self.parent_id = parent_id
        self.path = path
        self.size = size
        self.space_id = space_id
        self.status = status
        self.type = type
        self.uuid = uuid
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
        status_code: int = None,
        body: SendByAppResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = SendByAppResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendLinkHeaders(TeaModel):
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


class SendLinkRequest(TeaModel):
    def __init__(
        self,
        dentry_id: str = None,
        open_conversation_id: str = None,
        space_id: str = None,
        union_id: str = None,
    ):
        self.dentry_id = dentry_id
        self.open_conversation_id = open_conversation_id
        self.space_id = space_id
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
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentryId') is not None:
            self.dentry_id = m.get('dentryId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class SendLinkResponseBodyFile(TeaModel):
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
        self.conversation_id = conversation_id
        self.create_time = create_time
        self.creator_id = creator_id
        self.extension = extension
        self.id = id
        self.modified_time = modified_time
        self.modifier_id = modifier_id
        self.name = name
        self.parent_id = parent_id
        self.path = path
        self.size = size
        self.space_id = space_id
        self.status = status
        self.type = type
        self.uuid = uuid
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


class SendLinkResponseBody(TeaModel):
    def __init__(
        self,
        file: SendLinkResponseBodyFile = None,
    ):
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
            temp_model = SendLinkResponseBodyFile()
            self.file = temp_model.from_map(m['file'])
        return self


class SendLinkResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SendLinkResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = SendLinkResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


