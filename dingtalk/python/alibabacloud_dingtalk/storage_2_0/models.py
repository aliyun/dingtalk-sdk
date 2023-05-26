# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class DentryAppPropertiesValue(TeaModel):
    def __init__(
        self,
        name: str = None,
        value: str = None,
        visibility: str = None,
    ):
        self.name = name
        self.value = value
        self.visibility = visibility

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        if self.visibility is not None:
            result['visibility'] = self.visibility
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        if m.get('visibility') is not None:
            self.visibility = m.get('visibility')
        return self


class AddPermissionHeaders(TeaModel):
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


class AddPermissionRequestMembers(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        id: str = None,
        type: str = None,
    ):
        self.corp_id = corp_id
        self.id = id
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.id is not None:
            result['id'] = self.id
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class AddPermissionRequestOption(TeaModel):
    def __init__(
        self,
        duration: int = None,
    ):
        self.duration = duration

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.duration is not None:
            result['duration'] = self.duration
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        return self


class AddPermissionRequest(TeaModel):
    def __init__(
        self,
        members: List[AddPermissionRequestMembers] = None,
        option: AddPermissionRequestOption = None,
        role_id: str = None,
        union_id: str = None,
    ):
        self.members = members
        self.option = option
        self.role_id = role_id
        self.union_id = union_id

    def validate(self):
        if self.members:
            for k in self.members:
                if k:
                    k.validate()
        if self.option:
            self.option.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['members'] = []
        if self.members is not None:
            for k in self.members:
                result['members'].append(k.to_map() if k else None)
        if self.option is not None:
            result['option'] = self.option.to_map()
        if self.role_id is not None:
            result['roleId'] = self.role_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.members = []
        if m.get('members') is not None:
            for k in m.get('members'):
                temp_model = AddPermissionRequestMembers()
                self.members.append(temp_model.from_map(k))
        if m.get('option') is not None:
            temp_model = AddPermissionRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('roleId') is not None:
            self.role_id = m.get('roleId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class AddPermissionResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
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


class AddPermissionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddPermissionResponseBody = None,
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
            temp_model = AddPermissionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CommitFileHeaders(TeaModel):
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


class CommitFileRequestOptionAppProperties(TeaModel):
    def __init__(
        self,
        name: str = None,
        value: str = None,
        visibility: str = None,
    ):
        self.name = name
        self.value = value
        self.visibility = visibility

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        if self.visibility is not None:
            result['visibility'] = self.visibility
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        if m.get('visibility') is not None:
            self.visibility = m.get('visibility')
        return self


class CommitFileRequestOption(TeaModel):
    def __init__(
        self,
        app_properties: List[CommitFileRequestOptionAppProperties] = None,
        conflict_strategy: str = None,
        convert_to_online_doc: bool = None,
        convert_to_online_doc_target_document_type: str = None,
        size: int = None,
    ):
        self.app_properties = app_properties
        self.conflict_strategy = conflict_strategy
        self.convert_to_online_doc = convert_to_online_doc
        self.convert_to_online_doc_target_document_type = convert_to_online_doc_target_document_type
        self.size = size

    def validate(self):
        if self.app_properties:
            for k in self.app_properties:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['appProperties'] = []
        if self.app_properties is not None:
            for k in self.app_properties:
                result['appProperties'].append(k.to_map() if k else None)
        if self.conflict_strategy is not None:
            result['conflictStrategy'] = self.conflict_strategy
        if self.convert_to_online_doc is not None:
            result['convertToOnlineDoc'] = self.convert_to_online_doc
        if self.convert_to_online_doc_target_document_type is not None:
            result['convertToOnlineDocTargetDocumentType'] = self.convert_to_online_doc_target_document_type
        if self.size is not None:
            result['size'] = self.size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.app_properties = []
        if m.get('appProperties') is not None:
            for k in m.get('appProperties'):
                temp_model = CommitFileRequestOptionAppProperties()
                self.app_properties.append(temp_model.from_map(k))
        if m.get('conflictStrategy') is not None:
            self.conflict_strategy = m.get('conflictStrategy')
        if m.get('convertToOnlineDoc') is not None:
            self.convert_to_online_doc = m.get('convertToOnlineDoc')
        if m.get('convertToOnlineDocTargetDocumentType') is not None:
            self.convert_to_online_doc_target_document_type = m.get('convertToOnlineDocTargetDocumentType')
        if m.get('size') is not None:
            self.size = m.get('size')
        return self


class CommitFileRequest(TeaModel):
    def __init__(
        self,
        name: str = None,
        option: CommitFileRequestOption = None,
        upload_key: str = None,
        union_id: str = None,
    ):
        self.name = name
        self.option = option
        self.upload_key = upload_key
        self.union_id = union_id

    def validate(self):
        if self.option:
            self.option.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.option is not None:
            result['option'] = self.option.to_map()
        if self.upload_key is not None:
            result['uploadKey'] = self.upload_key
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('option') is not None:
            temp_model = CommitFileRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('uploadKey') is not None:
            self.upload_key = m.get('uploadKey')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class CommitFileResponseBodyDentryProperties(TeaModel):
    def __init__(
        self,
        read_only: bool = None,
    ):
        self.read_only = read_only

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.read_only is not None:
            result['readOnly'] = self.read_only
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('readOnly') is not None:
            self.read_only = m.get('readOnly')
        return self


class CommitFileResponseBodyDentryThumbnail(TeaModel):
    def __init__(
        self,
        height: int = None,
        url: str = None,
        width: int = None,
    ):
        self.height = height
        self.url = url
        self.width = width

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.height is not None:
            result['height'] = self.height
        if self.url is not None:
            result['url'] = self.url
        if self.width is not None:
            result['width'] = self.width
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('height') is not None:
            self.height = m.get('height')
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('width') is not None:
            self.width = m.get('width')
        return self


class CommitFileResponseBodyDentry(TeaModel):
    def __init__(
        self,
        app_properties: Dict[str, List[DentryAppPropertiesValue]] = None,
        category: str = None,
        create_time: str = None,
        creator_id: str = None,
        extension: str = None,
        id: str = None,
        modified_time: str = None,
        modifier_id: str = None,
        name: str = None,
        parent_id: str = None,
        partition_type: str = None,
        path: str = None,
        properties: CommitFileResponseBodyDentryProperties = None,
        size: int = None,
        space_id: str = None,
        status: str = None,
        storage_driver: str = None,
        thumbnail: CommitFileResponseBodyDentryThumbnail = None,
        type: str = None,
        uuid: str = None,
        version: int = None,
    ):
        self.app_properties = app_properties
        self.category = category
        self.create_time = create_time
        self.creator_id = creator_id
        self.extension = extension
        self.id = id
        self.modified_time = modified_time
        self.modifier_id = modifier_id
        self.name = name
        self.parent_id = parent_id
        self.partition_type = partition_type
        self.path = path
        self.properties = properties
        self.size = size
        self.space_id = space_id
        self.status = status
        self.storage_driver = storage_driver
        self.thumbnail = thumbnail
        self.type = type
        self.uuid = uuid
        self.version = version

    def validate(self):
        if self.app_properties:
            for v in self.app_properties.values():
                for k1 in v:
                    if k1:
                        k1.validate()
        if self.properties:
            self.properties.validate()
        if self.thumbnail:
            self.thumbnail.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['appProperties'] = {}
        if self.app_properties is not None:
            for k, v in self.app_properties.items():
                l1 = []
                for k1 in v:
                    l1.append(k1.to_map() if k1 else None)
                result['appProperties'][k] = l1
        if self.category is not None:
            result['category'] = self.category
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
        if self.partition_type is not None:
            result['partitionType'] = self.partition_type
        if self.path is not None:
            result['path'] = self.path
        if self.properties is not None:
            result['properties'] = self.properties.to_map()
        if self.size is not None:
            result['size'] = self.size
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.status is not None:
            result['status'] = self.status
        if self.storage_driver is not None:
            result['storageDriver'] = self.storage_driver
        if self.thumbnail is not None:
            result['thumbnail'] = self.thumbnail.to_map()
        if self.type is not None:
            result['type'] = self.type
        if self.uuid is not None:
            result['uuid'] = self.uuid
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.app_properties = {}
        if m.get('appProperties') is not None:
            for k, v in m.get('appProperties').items():
                l1 = []
                for k1 in v:
                    temp_model = DentryAppPropertiesValue()
                    l1.append(temp_model.from_map(k1))
                self.app_properties['k'] = l1
        if m.get('category') is not None:
            self.category = m.get('category')
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
        if m.get('partitionType') is not None:
            self.partition_type = m.get('partitionType')
        if m.get('path') is not None:
            self.path = m.get('path')
        if m.get('properties') is not None:
            temp_model = CommitFileResponseBodyDentryProperties()
            self.properties = temp_model.from_map(m['properties'])
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('storageDriver') is not None:
            self.storage_driver = m.get('storageDriver')
        if m.get('thumbnail') is not None:
            temp_model = CommitFileResponseBodyDentryThumbnail()
            self.thumbnail = temp_model.from_map(m['thumbnail'])
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class CommitFileResponseBody(TeaModel):
    def __init__(
        self,
        dentry: CommitFileResponseBodyDentry = None,
    ):
        self.dentry = dentry

    def validate(self):
        if self.dentry:
            self.dentry.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dentry is not None:
            result['dentry'] = self.dentry.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentry') is not None:
            temp_model = CommitFileResponseBodyDentry()
            self.dentry = temp_model.from_map(m['dentry'])
        return self


class CommitFileResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CommitFileResponseBody = None,
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
            temp_model = CommitFileResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeletePermissionHeaders(TeaModel):
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


class DeletePermissionRequestMembers(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        id: str = None,
        type: str = None,
    ):
        self.corp_id = corp_id
        self.id = id
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.id is not None:
            result['id'] = self.id
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class DeletePermissionRequest(TeaModel):
    def __init__(
        self,
        members: List[DeletePermissionRequestMembers] = None,
        role_id: str = None,
        union_id: str = None,
    ):
        self.members = members
        self.role_id = role_id
        self.union_id = union_id

    def validate(self):
        if self.members:
            for k in self.members:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['members'] = []
        if self.members is not None:
            for k in self.members:
                result['members'].append(k.to_map() if k else None)
        if self.role_id is not None:
            result['roleId'] = self.role_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.members = []
        if m.get('members') is not None:
            for k in m.get('members'):
                temp_model = DeletePermissionRequestMembers()
                self.members.append(temp_model.from_map(k))
        if m.get('roleId') is not None:
            self.role_id = m.get('roleId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class DeletePermissionResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
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


class DeletePermissionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeletePermissionResponseBody = None,
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
            temp_model = DeletePermissionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetFileUploadInfoHeaders(TeaModel):
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


class GetFileUploadInfoRequestOptionPreCheckParam(TeaModel):
    def __init__(
        self,
        name: str = None,
        size: int = None,
    ):
        self.name = name
        self.size = size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.size is not None:
            result['size'] = self.size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('size') is not None:
            self.size = m.get('size')
        return self


class GetFileUploadInfoRequestOption(TeaModel):
    def __init__(
        self,
        pre_check_param: GetFileUploadInfoRequestOptionPreCheckParam = None,
        prefer_intranet: bool = None,
        prefer_region: str = None,
        storage_driver: str = None,
    ):
        self.pre_check_param = pre_check_param
        self.prefer_intranet = prefer_intranet
        self.prefer_region = prefer_region
        self.storage_driver = storage_driver

    def validate(self):
        if self.pre_check_param:
            self.pre_check_param.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pre_check_param is not None:
            result['preCheckParam'] = self.pre_check_param.to_map()
        if self.prefer_intranet is not None:
            result['preferIntranet'] = self.prefer_intranet
        if self.prefer_region is not None:
            result['preferRegion'] = self.prefer_region
        if self.storage_driver is not None:
            result['storageDriver'] = self.storage_driver
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('preCheckParam') is not None:
            temp_model = GetFileUploadInfoRequestOptionPreCheckParam()
            self.pre_check_param = temp_model.from_map(m['preCheckParam'])
        if m.get('preferIntranet') is not None:
            self.prefer_intranet = m.get('preferIntranet')
        if m.get('preferRegion') is not None:
            self.prefer_region = m.get('preferRegion')
        if m.get('storageDriver') is not None:
            self.storage_driver = m.get('storageDriver')
        return self


class GetFileUploadInfoRequest(TeaModel):
    def __init__(
        self,
        option: GetFileUploadInfoRequestOption = None,
        protocol: str = None,
        union_id: str = None,
    ):
        self.option = option
        self.protocol = protocol
        self.union_id = union_id

    def validate(self):
        if self.option:
            self.option.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.option is not None:
            result['option'] = self.option.to_map()
        if self.protocol is not None:
            result['protocol'] = self.protocol
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('option') is not None:
            temp_model = GetFileUploadInfoRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('protocol') is not None:
            self.protocol = m.get('protocol')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetFileUploadInfoResponseBodyHeaderSignatureInfo(TeaModel):
    def __init__(
        self,
        expiration_seconds: int = None,
        headers: Dict[str, str] = None,
        internal_resource_urls: List[str] = None,
        region: str = None,
        resource_urls: List[str] = None,
    ):
        self.expiration_seconds = expiration_seconds
        self.headers = headers
        self.internal_resource_urls = internal_resource_urls
        self.region = region
        self.resource_urls = resource_urls

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.expiration_seconds is not None:
            result['expirationSeconds'] = self.expiration_seconds
        if self.headers is not None:
            result['headers'] = self.headers
        if self.internal_resource_urls is not None:
            result['internalResourceUrls'] = self.internal_resource_urls
        if self.region is not None:
            result['region'] = self.region
        if self.resource_urls is not None:
            result['resourceUrls'] = self.resource_urls
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('expirationSeconds') is not None:
            self.expiration_seconds = m.get('expirationSeconds')
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('internalResourceUrls') is not None:
            self.internal_resource_urls = m.get('internalResourceUrls')
        if m.get('region') is not None:
            self.region = m.get('region')
        if m.get('resourceUrls') is not None:
            self.resource_urls = m.get('resourceUrls')
        return self


class GetFileUploadInfoResponseBody(TeaModel):
    def __init__(
        self,
        header_signature_info: GetFileUploadInfoResponseBodyHeaderSignatureInfo = None,
        protocol: str = None,
        storage_driver: str = None,
        upload_key: str = None,
    ):
        self.header_signature_info = header_signature_info
        self.protocol = protocol
        self.storage_driver = storage_driver
        self.upload_key = upload_key

    def validate(self):
        if self.header_signature_info:
            self.header_signature_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.header_signature_info is not None:
            result['headerSignatureInfo'] = self.header_signature_info.to_map()
        if self.protocol is not None:
            result['protocol'] = self.protocol
        if self.storage_driver is not None:
            result['storageDriver'] = self.storage_driver
        if self.upload_key is not None:
            result['uploadKey'] = self.upload_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headerSignatureInfo') is not None:
            temp_model = GetFileUploadInfoResponseBodyHeaderSignatureInfo()
            self.header_signature_info = temp_model.from_map(m['headerSignatureInfo'])
        if m.get('protocol') is not None:
            self.protocol = m.get('protocol')
        if m.get('storageDriver') is not None:
            self.storage_driver = m.get('storageDriver')
        if m.get('uploadKey') is not None:
            self.upload_key = m.get('uploadKey')
        return self


class GetFileUploadInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetFileUploadInfoResponseBody = None,
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
            temp_model = GetFileUploadInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetPermissionInheritanceHeaders(TeaModel):
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


class GetPermissionInheritanceRequest(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetPermissionInheritanceResponseBody(TeaModel):
    def __init__(
        self,
        inheritance: str = None,
    ):
        self.inheritance = inheritance

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.inheritance is not None:
            result['inheritance'] = self.inheritance
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('inheritance') is not None:
            self.inheritance = m.get('inheritance')
        return self


class GetPermissionInheritanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetPermissionInheritanceResponseBody = None,
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
            temp_model = GetPermissionInheritanceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListPermissionsHeaders(TeaModel):
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


class ListPermissionsRequestOption(TeaModel):
    def __init__(
        self,
        filter_role_ids: List[str] = None,
        max_results: int = None,
        next_token: str = None,
    ):
        self.filter_role_ids = filter_role_ids
        self.max_results = max_results
        self.next_token = next_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.filter_role_ids is not None:
            result['filterRoleIds'] = self.filter_role_ids
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('filterRoleIds') is not None:
            self.filter_role_ids = m.get('filterRoleIds')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class ListPermissionsRequest(TeaModel):
    def __init__(
        self,
        option: ListPermissionsRequestOption = None,
        union_id: str = None,
    ):
        self.option = option
        self.union_id = union_id

    def validate(self):
        if self.option:
            self.option.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.option is not None:
            result['option'] = self.option.to_map()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('option') is not None:
            temp_model = ListPermissionsRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class ListPermissionsResponseBodyPermissionsMember(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        id: str = None,
        type: str = None,
    ):
        self.corp_id = corp_id
        self.id = id
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.id is not None:
            result['id'] = self.id
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class ListPermissionsResponseBodyPermissionsRole(TeaModel):
    def __init__(
        self,
        id: str = None,
        name: str = None,
    ):
        self.id = id
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class ListPermissionsResponseBodyPermissions(TeaModel):
    def __init__(
        self,
        dentry_uuid: str = None,
        duration: int = None,
        member: ListPermissionsResponseBodyPermissionsMember = None,
        role: ListPermissionsResponseBodyPermissionsRole = None,
    ):
        self.dentry_uuid = dentry_uuid
        self.duration = duration
        self.member = member
        self.role = role

    def validate(self):
        if self.member:
            self.member.validate()
        if self.role:
            self.role.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dentry_uuid is not None:
            result['dentryUuid'] = self.dentry_uuid
        if self.duration is not None:
            result['duration'] = self.duration
        if self.member is not None:
            result['member'] = self.member.to_map()
        if self.role is not None:
            result['role'] = self.role.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentryUuid') is not None:
            self.dentry_uuid = m.get('dentryUuid')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('member') is not None:
            temp_model = ListPermissionsResponseBodyPermissionsMember()
            self.member = temp_model.from_map(m['member'])
        if m.get('role') is not None:
            temp_model = ListPermissionsResponseBodyPermissionsRole()
            self.role = temp_model.from_map(m['role'])
        return self


class ListPermissionsResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        permissions: List[ListPermissionsResponseBodyPermissions] = None,
    ):
        self.next_token = next_token
        self.permissions = permissions

    def validate(self):
        if self.permissions:
            for k in self.permissions:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['permissions'] = []
        if self.permissions is not None:
            for k in self.permissions:
                result['permissions'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.permissions = []
        if m.get('permissions') is not None:
            for k in m.get('permissions'):
                temp_model = ListPermissionsResponseBodyPermissions()
                self.permissions.append(temp_model.from_map(k))
        return self


class ListPermissionsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListPermissionsResponseBody = None,
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
            temp_model = ListPermissionsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ManagerGetDefaultHandOverUserHeaders(TeaModel):
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


class ManagerGetDefaultHandOverUserRequest(TeaModel):
    def __init__(
        self,
        operator_id: str = None,
    ):
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class ManagerGetDefaultHandOverUserResponseBody(TeaModel):
    def __init__(
        self,
        default_handover_user_id: str = None,
    ):
        self.default_handover_user_id = default_handover_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.default_handover_user_id is not None:
            result['defaultHandoverUserId'] = self.default_handover_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('defaultHandoverUserId') is not None:
            self.default_handover_user_id = m.get('defaultHandoverUserId')
        return self


class ManagerGetDefaultHandOverUserResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ManagerGetDefaultHandOverUserResponseBody = None,
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
            temp_model = ManagerGetDefaultHandOverUserResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ManagerSetDefaultHandOverUserHeaders(TeaModel):
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


class ManagerSetDefaultHandOverUserRequest(TeaModel):
    def __init__(
        self,
        default_handover_user_id: str = None,
        operator_id: str = None,
    ):
        self.default_handover_user_id = default_handover_user_id
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.default_handover_user_id is not None:
            result['defaultHandoverUserId'] = self.default_handover_user_id
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('defaultHandoverUserId') is not None:
            self.default_handover_user_id = m.get('defaultHandoverUserId')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class ManagerSetDefaultHandOverUserResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
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


class ManagerSetDefaultHandOverUserResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ManagerSetDefaultHandOverUserResponseBody = None,
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
            temp_model = ManagerSetDefaultHandOverUserResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SearchDentriesHeaders(TeaModel):
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


class SearchDentriesRequestOptionCreateTimeRange(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        start_time: int = None,
    ):
        self.end_time = end_time
        self.start_time = start_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.start_time is not None:
            result['startTime'] = self.start_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        return self


class SearchDentriesRequestOptionVisitTimeRange(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        start_time: int = None,
    ):
        self.end_time = end_time
        self.start_time = start_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.start_time is not None:
            result['startTime'] = self.start_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        return self


class SearchDentriesRequestOption(TeaModel):
    def __init__(
        self,
        create_time_range: SearchDentriesRequestOptionCreateTimeRange = None,
        creator_ids: List[str] = None,
        dentry_categories: List[str] = None,
        max_results: int = None,
        modifier_ids: List[str] = None,
        next_token: str = None,
        visit_time_range: SearchDentriesRequestOptionVisitTimeRange = None,
    ):
        self.create_time_range = create_time_range
        self.creator_ids = creator_ids
        self.dentry_categories = dentry_categories
        self.max_results = max_results
        self.modifier_ids = modifier_ids
        self.next_token = next_token
        self.visit_time_range = visit_time_range

    def validate(self):
        if self.create_time_range:
            self.create_time_range.validate()
        if self.visit_time_range:
            self.visit_time_range.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_time_range is not None:
            result['createTimeRange'] = self.create_time_range.to_map()
        if self.creator_ids is not None:
            result['creatorIds'] = self.creator_ids
        if self.dentry_categories is not None:
            result['dentryCategories'] = self.dentry_categories
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.modifier_ids is not None:
            result['modifierIds'] = self.modifier_ids
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.visit_time_range is not None:
            result['visitTimeRange'] = self.visit_time_range.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTimeRange') is not None:
            temp_model = SearchDentriesRequestOptionCreateTimeRange()
            self.create_time_range = temp_model.from_map(m['createTimeRange'])
        if m.get('creatorIds') is not None:
            self.creator_ids = m.get('creatorIds')
        if m.get('dentryCategories') is not None:
            self.dentry_categories = m.get('dentryCategories')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('modifierIds') is not None:
            self.modifier_ids = m.get('modifierIds')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('visitTimeRange') is not None:
            temp_model = SearchDentriesRequestOptionVisitTimeRange()
            self.visit_time_range = temp_model.from_map(m['visitTimeRange'])
        return self


class SearchDentriesRequest(TeaModel):
    def __init__(
        self,
        keyword: str = None,
        option: SearchDentriesRequestOption = None,
        operator_id: str = None,
    ):
        self.keyword = keyword
        self.option = option
        self.operator_id = operator_id

    def validate(self):
        if self.option:
            self.option.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.keyword is not None:
            result['keyword'] = self.keyword
        if self.option is not None:
            result['option'] = self.option.to_map()
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('keyword') is not None:
            self.keyword = m.get('keyword')
        if m.get('option') is not None:
            temp_model = SearchDentriesRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class SearchDentriesResponseBodyItemsCreator(TeaModel):
    def __init__(
        self,
        name: str = None,
        user_id: str = None,
    ):
        self.name = name
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SearchDentriesResponseBodyItemsModifier(TeaModel):
    def __init__(
        self,
        name: str = None,
        user_id: str = None,
    ):
        self.name = name
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SearchDentriesResponseBodyItems(TeaModel):
    def __init__(
        self,
        creator: SearchDentriesResponseBodyItemsCreator = None,
        dentry_uuid: str = None,
        modifier: SearchDentriesResponseBodyItemsModifier = None,
        name: str = None,
    ):
        self.creator = creator
        self.dentry_uuid = dentry_uuid
        self.modifier = modifier
        self.name = name

    def validate(self):
        if self.creator:
            self.creator.validate()
        if self.modifier:
            self.modifier.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.creator is not None:
            result['creator'] = self.creator.to_map()
        if self.dentry_uuid is not None:
            result['dentryUuid'] = self.dentry_uuid
        if self.modifier is not None:
            result['modifier'] = self.modifier.to_map()
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('creator') is not None:
            temp_model = SearchDentriesResponseBodyItemsCreator()
            self.creator = temp_model.from_map(m['creator'])
        if m.get('dentryUuid') is not None:
            self.dentry_uuid = m.get('dentryUuid')
        if m.get('modifier') is not None:
            temp_model = SearchDentriesResponseBodyItemsModifier()
            self.modifier = temp_model.from_map(m['modifier'])
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class SearchDentriesResponseBody(TeaModel):
    def __init__(
        self,
        items: List[SearchDentriesResponseBodyItems] = None,
        next_token: str = None,
    ):
        self.items = items
        self.next_token = next_token

    def validate(self):
        if self.items:
            for k in self.items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.items = []
        if m.get('items') is not None:
            for k in m.get('items'):
                temp_model = SearchDentriesResponseBodyItems()
                self.items.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class SearchDentriesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SearchDentriesResponseBody = None,
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
            temp_model = SearchDentriesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SearchWorkspacesHeaders(TeaModel):
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


class SearchWorkspacesRequestOption(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
    ):
        self.max_results = max_results
        self.next_token = next_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class SearchWorkspacesRequest(TeaModel):
    def __init__(
        self,
        keyword: str = None,
        option: SearchWorkspacesRequestOption = None,
        operator_id: str = None,
    ):
        self.keyword = keyword
        self.option = option
        self.operator_id = operator_id

    def validate(self):
        if self.option:
            self.option.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.keyword is not None:
            result['keyword'] = self.keyword
        if self.option is not None:
            result['option'] = self.option.to_map()
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('keyword') is not None:
            self.keyword = m.get('keyword')
        if m.get('option') is not None:
            temp_model = SearchWorkspacesRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class SearchWorkspacesResponseBodyItems(TeaModel):
    def __init__(
        self,
        name: str = None,
        url: str = None,
        workspace_id: str = None,
    ):
        self.name = name
        self.url = url
        self.workspace_id = workspace_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.url is not None:
            result['url'] = self.url
        if self.workspace_id is not None:
            result['workspaceId'] = self.workspace_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('workspaceId') is not None:
            self.workspace_id = m.get('workspaceId')
        return self


class SearchWorkspacesResponseBody(TeaModel):
    def __init__(
        self,
        items: List[SearchWorkspacesResponseBodyItems] = None,
        next_token: str = None,
    ):
        self.items = items
        self.next_token = next_token

    def validate(self):
        if self.items:
            for k in self.items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.items = []
        if m.get('items') is not None:
            for k in m.get('items'):
                temp_model = SearchWorkspacesResponseBodyItems()
                self.items.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class SearchWorkspacesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SearchWorkspacesResponseBody = None,
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
            temp_model = SearchWorkspacesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SetPermissionInheritanceHeaders(TeaModel):
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


class SetPermissionInheritanceRequest(TeaModel):
    def __init__(
        self,
        inheritance: str = None,
        union_id: str = None,
    ):
        self.inheritance = inheritance
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.inheritance is not None:
            result['inheritance'] = self.inheritance
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('inheritance') is not None:
            self.inheritance = m.get('inheritance')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class SetPermissionInheritanceResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
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


class SetPermissionInheritanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SetPermissionInheritanceResponseBody = None,
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
            temp_model = SetPermissionInheritanceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdatePermissionHeaders(TeaModel):
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


class UpdatePermissionRequestMembers(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        id: str = None,
        type: str = None,
    ):
        self.corp_id = corp_id
        self.id = id
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.id is not None:
            result['id'] = self.id
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class UpdatePermissionRequestOption(TeaModel):
    def __init__(
        self,
        duration: int = None,
    ):
        self.duration = duration

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.duration is not None:
            result['duration'] = self.duration
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        return self


class UpdatePermissionRequest(TeaModel):
    def __init__(
        self,
        members: List[UpdatePermissionRequestMembers] = None,
        option: UpdatePermissionRequestOption = None,
        role_id: str = None,
        union_id: str = None,
    ):
        self.members = members
        self.option = option
        self.role_id = role_id
        self.union_id = union_id

    def validate(self):
        if self.members:
            for k in self.members:
                if k:
                    k.validate()
        if self.option:
            self.option.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['members'] = []
        if self.members is not None:
            for k in self.members:
                result['members'].append(k.to_map() if k else None)
        if self.option is not None:
            result['option'] = self.option.to_map()
        if self.role_id is not None:
            result['roleId'] = self.role_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.members = []
        if m.get('members') is not None:
            for k in m.get('members'):
                temp_model = UpdatePermissionRequestMembers()
                self.members.append(temp_model.from_map(k))
        if m.get('option') is not None:
            temp_model = UpdatePermissionRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('roleId') is not None:
            self.role_id = m.get('roleId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class UpdatePermissionResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
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


class UpdatePermissionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdatePermissionResponseBody = None,
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
            temp_model = UpdatePermissionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


