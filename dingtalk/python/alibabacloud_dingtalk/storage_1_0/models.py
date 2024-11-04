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


class ResultItemsDentryAppPropertiesValue(TeaModel):
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


class DentriesAppPropertiesValue(TeaModel):
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


class AddFolderHeaders(TeaModel):
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


class AddFolderRequestOptionAppProperties(TeaModel):
    def __init__(
        self,
        name: str = None,
        value: str = None,
        visibility: str = None,
    ):
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.value = value
        # This parameter is required.
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


class AddFolderRequestOption(TeaModel):
    def __init__(
        self,
        app_properties: List[AddFolderRequestOptionAppProperties] = None,
        conflict_strategy: str = None,
    ):
        self.app_properties = app_properties
        self.conflict_strategy = conflict_strategy

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.app_properties = []
        if m.get('appProperties') is not None:
            for k in m.get('appProperties'):
                temp_model = AddFolderRequestOptionAppProperties()
                self.app_properties.append(temp_model.from_map(k))
        if m.get('conflictStrategy') is not None:
            self.conflict_strategy = m.get('conflictStrategy')
        return self


class AddFolderRequest(TeaModel):
    def __init__(
        self,
        name: str = None,
        option: AddFolderRequestOption = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.name = name
        self.option = option
        # This parameter is required.
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
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('option') is not None:
            temp_model = AddFolderRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class AddFolderResponseBodyDentryProperties(TeaModel):
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


class AddFolderResponseBodyDentry(TeaModel):
    def __init__(
        self,
        app_properties: Dict[str, List[DentryAppPropertiesValue]] = None,
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
        properties: AddFolderResponseBodyDentryProperties = None,
        size: int = None,
        space_id: str = None,
        status: str = None,
        storage_driver: str = None,
        type: str = None,
        uuid: str = None,
        version: int = None,
    ):
        self.app_properties = app_properties
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
            temp_model = AddFolderResponseBodyDentryProperties()
            self.properties = temp_model.from_map(m['properties'])
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('storageDriver') is not None:
            self.storage_driver = m.get('storageDriver')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class AddFolderResponseBody(TeaModel):
    def __init__(
        self,
        dentry: AddFolderResponseBodyDentry = None,
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
            temp_model = AddFolderResponseBodyDentry()
            self.dentry = temp_model.from_map(m['dentry'])
        return self


class AddFolderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddFolderResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = AddFolderResponseBody()
            self.body = temp_model.from_map(m['body'])
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
        # This parameter is required.
        self.id = id
        # This parameter is required.
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
        # This parameter is required.
        self.members = members
        self.option = option
        # This parameter is required.
        self.role_id = role_id
        # This parameter is required.
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


class AddSpaceHeaders(TeaModel):
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


class AddSpaceRequestOptionCapabilities(TeaModel):
    def __init__(
        self,
        can_record_recent_file: bool = None,
        can_rename: bool = None,
        can_search: bool = None,
    ):
        self.can_record_recent_file = can_record_recent_file
        self.can_rename = can_rename
        self.can_search = can_search

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.can_record_recent_file is not None:
            result['canRecordRecentFile'] = self.can_record_recent_file
        if self.can_rename is not None:
            result['canRename'] = self.can_rename
        if self.can_search is not None:
            result['canSearch'] = self.can_search
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('canRecordRecentFile') is not None:
            self.can_record_recent_file = m.get('canRecordRecentFile')
        if m.get('canRename') is not None:
            self.can_rename = m.get('canRename')
        if m.get('canSearch') is not None:
            self.can_search = m.get('canSearch')
        return self


class AddSpaceRequestOption(TeaModel):
    def __init__(
        self,
        capabilities: AddSpaceRequestOptionCapabilities = None,
        name: str = None,
        owner_type: str = None,
        quota: int = None,
        scene: str = None,
        scene_id: str = None,
    ):
        self.capabilities = capabilities
        self.name = name
        self.owner_type = owner_type
        self.quota = quota
        self.scene = scene
        self.scene_id = scene_id

    def validate(self):
        if self.capabilities:
            self.capabilities.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.capabilities is not None:
            result['capabilities'] = self.capabilities.to_map()
        if self.name is not None:
            result['name'] = self.name
        if self.owner_type is not None:
            result['ownerType'] = self.owner_type
        if self.quota is not None:
            result['quota'] = self.quota
        if self.scene is not None:
            result['scene'] = self.scene
        if self.scene_id is not None:
            result['sceneId'] = self.scene_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('capabilities') is not None:
            temp_model = AddSpaceRequestOptionCapabilities()
            self.capabilities = temp_model.from_map(m['capabilities'])
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('ownerType') is not None:
            self.owner_type = m.get('ownerType')
        if m.get('quota') is not None:
            self.quota = m.get('quota')
        if m.get('scene') is not None:
            self.scene = m.get('scene')
        if m.get('sceneId') is not None:
            self.scene_id = m.get('sceneId')
        return self


class AddSpaceRequest(TeaModel):
    def __init__(
        self,
        option: AddSpaceRequestOption = None,
        union_id: str = None,
    ):
        self.option = option
        # This parameter is required.
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
            temp_model = AddSpaceRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class AddSpaceResponseBodySpaceCapabilities(TeaModel):
    def __init__(
        self,
        can_record_recent_file: bool = None,
        can_rename: bool = None,
        can_search: bool = None,
    ):
        self.can_record_recent_file = can_record_recent_file
        self.can_rename = can_rename
        self.can_search = can_search

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.can_record_recent_file is not None:
            result['canRecordRecentFile'] = self.can_record_recent_file
        if self.can_rename is not None:
            result['canRename'] = self.can_rename
        if self.can_search is not None:
            result['canSearch'] = self.can_search
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('canRecordRecentFile') is not None:
            self.can_record_recent_file = m.get('canRecordRecentFile')
        if m.get('canRename') is not None:
            self.can_rename = m.get('canRename')
        if m.get('canSearch') is not None:
            self.can_search = m.get('canSearch')
        return self


class AddSpaceResponseBodySpacePartitionsQuota(TeaModel):
    def __init__(
        self,
        max: int = None,
        reserved: int = None,
        type: str = None,
        used: int = None,
    ):
        self.max = max
        self.reserved = reserved
        self.type = type
        self.used = used

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max is not None:
            result['max'] = self.max
        if self.reserved is not None:
            result['reserved'] = self.reserved
        if self.type is not None:
            result['type'] = self.type
        if self.used is not None:
            result['used'] = self.used
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('max') is not None:
            self.max = m.get('max')
        if m.get('reserved') is not None:
            self.reserved = m.get('reserved')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('used') is not None:
            self.used = m.get('used')
        return self


class AddSpaceResponseBodySpacePartitions(TeaModel):
    def __init__(
        self,
        partition_type: str = None,
        quota: AddSpaceResponseBodySpacePartitionsQuota = None,
    ):
        self.partition_type = partition_type
        self.quota = quota

    def validate(self):
        if self.quota:
            self.quota.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.partition_type is not None:
            result['partitionType'] = self.partition_type
        if self.quota is not None:
            result['quota'] = self.quota.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('partitionType') is not None:
            self.partition_type = m.get('partitionType')
        if m.get('quota') is not None:
            temp_model = AddSpaceResponseBodySpacePartitionsQuota()
            self.quota = temp_model.from_map(m['quota'])
        return self


class AddSpaceResponseBodySpace(TeaModel):
    def __init__(
        self,
        app_id: str = None,
        capabilities: AddSpaceResponseBodySpaceCapabilities = None,
        corp_id: str = None,
        create_time: str = None,
        creator_id: str = None,
        id: str = None,
        modified_time: str = None,
        modifier_id: str = None,
        name: str = None,
        owner_id: str = None,
        owner_type: str = None,
        partitions: List[AddSpaceResponseBodySpacePartitions] = None,
        quota: int = None,
        scene: str = None,
        scene_id: str = None,
        status: str = None,
        used_quota: int = None,
    ):
        self.app_id = app_id
        self.capabilities = capabilities
        self.corp_id = corp_id
        self.create_time = create_time
        self.creator_id = creator_id
        self.id = id
        self.modified_time = modified_time
        self.modifier_id = modifier_id
        self.name = name
        self.owner_id = owner_id
        self.owner_type = owner_type
        self.partitions = partitions
        self.quota = quota
        self.scene = scene
        self.scene_id = scene_id
        self.status = status
        self.used_quota = used_quota

    def validate(self):
        if self.capabilities:
            self.capabilities.validate()
        if self.partitions:
            for k in self.partitions:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.capabilities is not None:
            result['capabilities'] = self.capabilities.to_map()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.id is not None:
            result['id'] = self.id
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.modifier_id is not None:
            result['modifierId'] = self.modifier_id
        if self.name is not None:
            result['name'] = self.name
        if self.owner_id is not None:
            result['ownerId'] = self.owner_id
        if self.owner_type is not None:
            result['ownerType'] = self.owner_type
        result['partitions'] = []
        if self.partitions is not None:
            for k in self.partitions:
                result['partitions'].append(k.to_map() if k else None)
        if self.quota is not None:
            result['quota'] = self.quota
        if self.scene is not None:
            result['scene'] = self.scene
        if self.scene_id is not None:
            result['sceneId'] = self.scene_id
        if self.status is not None:
            result['status'] = self.status
        if self.used_quota is not None:
            result['usedQuota'] = self.used_quota
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('capabilities') is not None:
            temp_model = AddSpaceResponseBodySpaceCapabilities()
            self.capabilities = temp_model.from_map(m['capabilities'])
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('modifierId') is not None:
            self.modifier_id = m.get('modifierId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('ownerId') is not None:
            self.owner_id = m.get('ownerId')
        if m.get('ownerType') is not None:
            self.owner_type = m.get('ownerType')
        self.partitions = []
        if m.get('partitions') is not None:
            for k in m.get('partitions'):
                temp_model = AddSpaceResponseBodySpacePartitions()
                self.partitions.append(temp_model.from_map(k))
        if m.get('quota') is not None:
            self.quota = m.get('quota')
        if m.get('scene') is not None:
            self.scene = m.get('scene')
        if m.get('sceneId') is not None:
            self.scene_id = m.get('sceneId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('usedQuota') is not None:
            self.used_quota = m.get('usedQuota')
        return self


class AddSpaceResponseBody(TeaModel):
    def __init__(
        self,
        space: AddSpaceResponseBodySpace = None,
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
            temp_model = AddSpaceResponseBodySpace()
            self.space = temp_model.from_map(m['space'])
        return self


class AddSpaceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddSpaceResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = AddSpaceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ClearRecycleBinHeaders(TeaModel):
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


class ClearRecycleBinRequest(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        # This parameter is required.
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


class ClearRecycleBinResponseBody(TeaModel):
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


class ClearRecycleBinResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ClearRecycleBinResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = ClearRecycleBinResponseBody()
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
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.value = value
        # This parameter is required.
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
        size: int = None,
    ):
        self.app_properties = app_properties
        self.conflict_strategy = conflict_strategy
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
        if m.get('size') is not None:
            self.size = m.get('size')
        return self


class CommitFileRequest(TeaModel):
    def __init__(
        self,
        name: str = None,
        option: CommitFileRequestOption = None,
        overwrite_dentry_id: str = None,
        parent_id: str = None,
        upload_key: str = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.name = name
        self.option = option
        self.overwrite_dentry_id = overwrite_dentry_id
        # This parameter is required.
        self.parent_id = parent_id
        # This parameter is required.
        self.upload_key = upload_key
        # This parameter is required.
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
        if self.overwrite_dentry_id is not None:
            result['overwriteDentryId'] = self.overwrite_dentry_id
        if self.parent_id is not None:
            result['parentId'] = self.parent_id
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
        if m.get('overwriteDentryId') is not None:
            self.overwrite_dentry_id = m.get('overwriteDentryId')
        if m.get('parentId') is not None:
            self.parent_id = m.get('parentId')
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


class CopyDentriesHeaders(TeaModel):
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


class CopyDentriesRequestOption(TeaModel):
    def __init__(
        self,
        conflict_strategy: str = None,
    ):
        self.conflict_strategy = conflict_strategy

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conflict_strategy is not None:
            result['conflictStrategy'] = self.conflict_strategy
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conflictStrategy') is not None:
            self.conflict_strategy = m.get('conflictStrategy')
        return self


class CopyDentriesRequest(TeaModel):
    def __init__(
        self,
        dentry_ids: List[str] = None,
        option: CopyDentriesRequestOption = None,
        target_folder_id: str = None,
        target_space_id: str = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.dentry_ids = dentry_ids
        self.option = option
        # This parameter is required.
        self.target_folder_id = target_folder_id
        # This parameter is required.
        self.target_space_id = target_space_id
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        if self.option:
            self.option.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dentry_ids is not None:
            result['dentryIds'] = self.dentry_ids
        if self.option is not None:
            result['option'] = self.option.to_map()
        if self.target_folder_id is not None:
            result['targetFolderId'] = self.target_folder_id
        if self.target_space_id is not None:
            result['targetSpaceId'] = self.target_space_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentryIds') is not None:
            self.dentry_ids = m.get('dentryIds')
        if m.get('option') is not None:
            temp_model = CopyDentriesRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('targetFolderId') is not None:
            self.target_folder_id = m.get('targetFolderId')
        if m.get('targetSpaceId') is not None:
            self.target_space_id = m.get('targetSpaceId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class CopyDentriesResponseBodyResultItems(TeaModel):
    def __init__(
        self,
        async_: bool = None,
        dentry_id: str = None,
        error_code: str = None,
        space_id: str = None,
        success: bool = None,
        target_dentry_id: str = None,
        target_space_id: str = None,
        task_id: str = None,
    ):
        self.async_ = async_
        self.dentry_id = dentry_id
        self.error_code = error_code
        self.space_id = space_id
        self.success = success
        self.target_dentry_id = target_dentry_id
        self.target_space_id = target_space_id
        self.task_id = task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.async_ is not None:
            result['async'] = self.async_
        if self.dentry_id is not None:
            result['dentryId'] = self.dentry_id
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.success is not None:
            result['success'] = self.success
        if self.target_dentry_id is not None:
            result['targetDentryId'] = self.target_dentry_id
        if self.target_space_id is not None:
            result['targetSpaceId'] = self.target_space_id
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('async') is not None:
            self.async_ = m.get('async')
        if m.get('dentryId') is not None:
            self.dentry_id = m.get('dentryId')
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('targetDentryId') is not None:
            self.target_dentry_id = m.get('targetDentryId')
        if m.get('targetSpaceId') is not None:
            self.target_space_id = m.get('targetSpaceId')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class CopyDentriesResponseBody(TeaModel):
    def __init__(
        self,
        result_items: List[CopyDentriesResponseBodyResultItems] = None,
    ):
        self.result_items = result_items

    def validate(self):
        if self.result_items:
            for k in self.result_items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['resultItems'] = []
        if self.result_items is not None:
            for k in self.result_items:
                result['resultItems'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result_items = []
        if m.get('resultItems') is not None:
            for k in m.get('resultItems'):
                temp_model = CopyDentriesResponseBodyResultItems()
                self.result_items.append(temp_model.from_map(k))
        return self


class CopyDentriesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CopyDentriesResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = CopyDentriesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CopyDentryHeaders(TeaModel):
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


class CopyDentryRequestOption(TeaModel):
    def __init__(
        self,
        conflict_strategy: str = None,
    ):
        self.conflict_strategy = conflict_strategy

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conflict_strategy is not None:
            result['conflictStrategy'] = self.conflict_strategy
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conflictStrategy') is not None:
            self.conflict_strategy = m.get('conflictStrategy')
        return self


class CopyDentryRequest(TeaModel):
    def __init__(
        self,
        option: CopyDentryRequestOption = None,
        target_folder_id: str = None,
        target_space_id: str = None,
        union_id: str = None,
    ):
        self.option = option
        # This parameter is required.
        self.target_folder_id = target_folder_id
        # This parameter is required.
        self.target_space_id = target_space_id
        # This parameter is required.
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
        if self.target_folder_id is not None:
            result['targetFolderId'] = self.target_folder_id
        if self.target_space_id is not None:
            result['targetSpaceId'] = self.target_space_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('option') is not None:
            temp_model = CopyDentryRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('targetFolderId') is not None:
            self.target_folder_id = m.get('targetFolderId')
        if m.get('targetSpaceId') is not None:
            self.target_space_id = m.get('targetSpaceId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class CopyDentryResponseBodyDentryProperties(TeaModel):
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


class CopyDentryResponseBodyDentry(TeaModel):
    def __init__(
        self,
        app_properties: Dict[str, List[DentryAppPropertiesValue]] = None,
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
        properties: CopyDentryResponseBodyDentryProperties = None,
        size: int = None,
        space_id: str = None,
        status: str = None,
        storage_driver: str = None,
        type: str = None,
        uuid: str = None,
        version: int = None,
    ):
        self.app_properties = app_properties
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
            temp_model = CopyDentryResponseBodyDentryProperties()
            self.properties = temp_model.from_map(m['properties'])
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('storageDriver') is not None:
            self.storage_driver = m.get('storageDriver')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class CopyDentryResponseBody(TeaModel):
    def __init__(
        self,
        async_: bool = None,
        dentry: CopyDentryResponseBodyDentry = None,
        task_id: str = None,
    ):
        self.async_ = async_
        self.dentry = dentry
        self.task_id = task_id

    def validate(self):
        if self.dentry:
            self.dentry.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.async_ is not None:
            result['async'] = self.async_
        if self.dentry is not None:
            result['dentry'] = self.dentry.to_map()
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('async') is not None:
            self.async_ = m.get('async')
        if m.get('dentry') is not None:
            temp_model = CopyDentryResponseBodyDentry()
            self.dentry = temp_model.from_map(m['dentry'])
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class CopyDentryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CopyDentryResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = CopyDentryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteDentriesHeaders(TeaModel):
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


class DeleteDentriesRequestOption(TeaModel):
    def __init__(
        self,
        to_recycle_bin: bool = None,
    ):
        self.to_recycle_bin = to_recycle_bin

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.to_recycle_bin is not None:
            result['toRecycleBin'] = self.to_recycle_bin
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('toRecycleBin') is not None:
            self.to_recycle_bin = m.get('toRecycleBin')
        return self


class DeleteDentriesRequest(TeaModel):
    def __init__(
        self,
        dentry_ids: List[str] = None,
        option: DeleteDentriesRequestOption = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.dentry_ids = dentry_ids
        self.option = option
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        if self.option:
            self.option.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dentry_ids is not None:
            result['dentryIds'] = self.dentry_ids
        if self.option is not None:
            result['option'] = self.option.to_map()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentryIds') is not None:
            self.dentry_ids = m.get('dentryIds')
        if m.get('option') is not None:
            temp_model = DeleteDentriesRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class DeleteDentriesResponseBodyResultItems(TeaModel):
    def __init__(
        self,
        async_: bool = None,
        dentry_id: str = None,
        error_code: str = None,
        space_id: str = None,
        success: bool = None,
        task_id: str = None,
    ):
        self.async_ = async_
        self.dentry_id = dentry_id
        self.error_code = error_code
        self.space_id = space_id
        self.success = success
        self.task_id = task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.async_ is not None:
            result['async'] = self.async_
        if self.dentry_id is not None:
            result['dentryId'] = self.dentry_id
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.success is not None:
            result['success'] = self.success
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('async') is not None:
            self.async_ = m.get('async')
        if m.get('dentryId') is not None:
            self.dentry_id = m.get('dentryId')
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class DeleteDentriesResponseBody(TeaModel):
    def __init__(
        self,
        result_items: List[DeleteDentriesResponseBodyResultItems] = None,
    ):
        self.result_items = result_items

    def validate(self):
        if self.result_items:
            for k in self.result_items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['resultItems'] = []
        if self.result_items is not None:
            for k in self.result_items:
                result['resultItems'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result_items = []
        if m.get('resultItems') is not None:
            for k in m.get('resultItems'):
                temp_model = DeleteDentriesResponseBodyResultItems()
                self.result_items.append(temp_model.from_map(k))
        return self


class DeleteDentriesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteDentriesResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = DeleteDentriesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteDentryHeaders(TeaModel):
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


class DeleteDentryRequest(TeaModel):
    def __init__(
        self,
        to_recycle_bin: bool = None,
        union_id: str = None,
    ):
        self.to_recycle_bin = to_recycle_bin
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.to_recycle_bin is not None:
            result['toRecycleBin'] = self.to_recycle_bin
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('toRecycleBin') is not None:
            self.to_recycle_bin = m.get('toRecycleBin')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class DeleteDentryResponseBody(TeaModel):
    def __init__(
        self,
        async_: bool = None,
        task_id: str = None,
    ):
        self.async_ = async_
        self.task_id = task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.async_ is not None:
            result['async'] = self.async_
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('async') is not None:
            self.async_ = m.get('async')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class DeleteDentryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteDentryResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = DeleteDentryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteDentryAppPropertiesHeaders(TeaModel):
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


class DeleteDentryAppPropertiesRequest(TeaModel):
    def __init__(
        self,
        property_names: List[str] = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.property_names = property_names
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.property_names is not None:
            result['propertyNames'] = self.property_names
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('propertyNames') is not None:
            self.property_names = m.get('propertyNames')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class DeleteDentryAppPropertiesResponseBody(TeaModel):
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


class DeleteDentryAppPropertiesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteDentryAppPropertiesResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = DeleteDentryAppPropertiesResponseBody()
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
        # This parameter is required.
        self.id = id
        # This parameter is required.
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
        # This parameter is required.
        self.members = members
        # This parameter is required.
        self.role_id = role_id
        # This parameter is required.
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


class DeleteRecycleItemHeaders(TeaModel):
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


class DeleteRecycleItemRequest(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        # This parameter is required.
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


class DeleteRecycleItemResponseBody(TeaModel):
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


class DeleteRecycleItemResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteRecycleItemResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = DeleteRecycleItemResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteRecycleItemsHeaders(TeaModel):
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


class DeleteRecycleItemsRequest(TeaModel):
    def __init__(
        self,
        recycle_item_ids: List[str] = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.recycle_item_ids = recycle_item_ids
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.recycle_item_ids is not None:
            result['recycleItemIds'] = self.recycle_item_ids
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('recycleItemIds') is not None:
            self.recycle_item_ids = m.get('recycleItemIds')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class DeleteRecycleItemsResponseBody(TeaModel):
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


class DeleteRecycleItemsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteRecycleItemsResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = DeleteRecycleItemsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetCurrentAppHeaders(TeaModel):
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


class GetCurrentAppRequest(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        # This parameter is required.
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


class GetCurrentAppResponseBodyAppPartitionsQuota(TeaModel):
    def __init__(
        self,
        max: int = None,
        reserved: int = None,
        type: str = None,
        used: int = None,
    ):
        self.max = max
        self.reserved = reserved
        self.type = type
        self.used = used

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max is not None:
            result['max'] = self.max
        if self.reserved is not None:
            result['reserved'] = self.reserved
        if self.type is not None:
            result['type'] = self.type
        if self.used is not None:
            result['used'] = self.used
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('max') is not None:
            self.max = m.get('max')
        if m.get('reserved') is not None:
            self.reserved = m.get('reserved')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('used') is not None:
            self.used = m.get('used')
        return self


class GetCurrentAppResponseBodyAppPartitions(TeaModel):
    def __init__(
        self,
        partition_type: str = None,
        quota: GetCurrentAppResponseBodyAppPartitionsQuota = None,
    ):
        self.partition_type = partition_type
        self.quota = quota

    def validate(self):
        if self.quota:
            self.quota.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.partition_type is not None:
            result['partitionType'] = self.partition_type
        if self.quota is not None:
            result['quota'] = self.quota.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('partitionType') is not None:
            self.partition_type = m.get('partitionType')
        if m.get('quota') is not None:
            temp_model = GetCurrentAppResponseBodyAppPartitionsQuota()
            self.quota = temp_model.from_map(m['quota'])
        return self


class GetCurrentAppResponseBodyApp(TeaModel):
    def __init__(
        self,
        app_id: str = None,
        corp_id: str = None,
        create_time: str = None,
        modified_time: str = None,
        name: str = None,
        partitions: List[GetCurrentAppResponseBodyAppPartitions] = None,
    ):
        self.app_id = app_id
        self.corp_id = corp_id
        self.create_time = create_time
        self.modified_time = modified_time
        self.name = name
        self.partitions = partitions

    def validate(self):
        if self.partitions:
            for k in self.partitions:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.name is not None:
            result['name'] = self.name
        result['partitions'] = []
        if self.partitions is not None:
            for k in self.partitions:
                result['partitions'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('name') is not None:
            self.name = m.get('name')
        self.partitions = []
        if m.get('partitions') is not None:
            for k in m.get('partitions'):
                temp_model = GetCurrentAppResponseBodyAppPartitions()
                self.partitions.append(temp_model.from_map(k))
        return self


class GetCurrentAppResponseBody(TeaModel):
    def __init__(
        self,
        app: GetCurrentAppResponseBodyApp = None,
    ):
        self.app = app

    def validate(self):
        if self.app:
            self.app.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app is not None:
            result['app'] = self.app.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('app') is not None:
            temp_model = GetCurrentAppResponseBodyApp()
            self.app = temp_model.from_map(m['app'])
        return self


class GetCurrentAppResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetCurrentAppResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = GetCurrentAppResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetDentriesHeaders(TeaModel):
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


class GetDentriesRequestOption(TeaModel):
    def __init__(
        self,
        app_ids_for_app_properties: List[str] = None,
        with_thumbnail: bool = None,
    ):
        self.app_ids_for_app_properties = app_ids_for_app_properties
        self.with_thumbnail = with_thumbnail

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_ids_for_app_properties is not None:
            result['appIdsForAppProperties'] = self.app_ids_for_app_properties
        if self.with_thumbnail is not None:
            result['withThumbnail'] = self.with_thumbnail
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appIdsForAppProperties') is not None:
            self.app_ids_for_app_properties = m.get('appIdsForAppProperties')
        if m.get('withThumbnail') is not None:
            self.with_thumbnail = m.get('withThumbnail')
        return self


class GetDentriesRequest(TeaModel):
    def __init__(
        self,
        dentry_ids: List[str] = None,
        option: GetDentriesRequestOption = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.dentry_ids = dentry_ids
        self.option = option
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        if self.option:
            self.option.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dentry_ids is not None:
            result['dentryIds'] = self.dentry_ids
        if self.option is not None:
            result['option'] = self.option.to_map()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentryIds') is not None:
            self.dentry_ids = m.get('dentryIds')
        if m.get('option') is not None:
            temp_model = GetDentriesRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetDentriesResponseBodyResultItemsDentryProperties(TeaModel):
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


class GetDentriesResponseBodyResultItemsDentryThumbnail(TeaModel):
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


class GetDentriesResponseBodyResultItemsDentry(TeaModel):
    def __init__(
        self,
        app_properties: Dict[str, List[ResultItemsDentryAppPropertiesValue]] = None,
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
        properties: GetDentriesResponseBodyResultItemsDentryProperties = None,
        size: int = None,
        space_id: str = None,
        status: str = None,
        storage_driver: str = None,
        thumbnail: GetDentriesResponseBodyResultItemsDentryThumbnail = None,
        type: str = None,
        uuid: str = None,
        version: int = None,
    ):
        self.app_properties = app_properties
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
                    temp_model = ResultItemsDentryAppPropertiesValue()
                    l1.append(temp_model.from_map(k1))
                self.app_properties['k'] = l1
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
            temp_model = GetDentriesResponseBodyResultItemsDentryProperties()
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
            temp_model = GetDentriesResponseBodyResultItemsDentryThumbnail()
            self.thumbnail = temp_model.from_map(m['thumbnail'])
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class GetDentriesResponseBodyResultItems(TeaModel):
    def __init__(
        self,
        dentry: GetDentriesResponseBodyResultItemsDentry = None,
        dentry_id: str = None,
        error_code: str = None,
        space_id: str = None,
        success: bool = None,
    ):
        self.dentry = dentry
        self.dentry_id = dentry_id
        self.error_code = error_code
        self.space_id = space_id
        self.success = success

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
        if self.dentry_id is not None:
            result['dentryId'] = self.dentry_id
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentry') is not None:
            temp_model = GetDentriesResponseBodyResultItemsDentry()
            self.dentry = temp_model.from_map(m['dentry'])
        if m.get('dentryId') is not None:
            self.dentry_id = m.get('dentryId')
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetDentriesResponseBody(TeaModel):
    def __init__(
        self,
        result_items: List[GetDentriesResponseBodyResultItems] = None,
    ):
        self.result_items = result_items

    def validate(self):
        if self.result_items:
            for k in self.result_items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['resultItems'] = []
        if self.result_items is not None:
            for k in self.result_items:
                result['resultItems'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result_items = []
        if m.get('resultItems') is not None:
            for k in m.get('resultItems'):
                temp_model = GetDentriesResponseBodyResultItems()
                self.result_items.append(temp_model.from_map(k))
        return self


class GetDentriesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetDentriesResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = GetDentriesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetDentryHeaders(TeaModel):
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


class GetDentryRequestOption(TeaModel):
    def __init__(
        self,
        app_ids_for_app_properties: List[str] = None,
        with_thumbnail: bool = None,
    ):
        self.app_ids_for_app_properties = app_ids_for_app_properties
        self.with_thumbnail = with_thumbnail

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_ids_for_app_properties is not None:
            result['appIdsForAppProperties'] = self.app_ids_for_app_properties
        if self.with_thumbnail is not None:
            result['withThumbnail'] = self.with_thumbnail
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appIdsForAppProperties') is not None:
            self.app_ids_for_app_properties = m.get('appIdsForAppProperties')
        if m.get('withThumbnail') is not None:
            self.with_thumbnail = m.get('withThumbnail')
        return self


class GetDentryRequest(TeaModel):
    def __init__(
        self,
        option: GetDentryRequestOption = None,
        union_id: str = None,
    ):
        self.option = option
        # This parameter is required.
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
            temp_model = GetDentryRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetDentryResponseBodyDentryProperties(TeaModel):
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


class GetDentryResponseBodyDentryThumbnail(TeaModel):
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


class GetDentryResponseBodyDentry(TeaModel):
    def __init__(
        self,
        app_properties: Dict[str, List[DentryAppPropertiesValue]] = None,
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
        properties: GetDentryResponseBodyDentryProperties = None,
        size: int = None,
        space_id: str = None,
        status: str = None,
        storage_driver: str = None,
        thumbnail: GetDentryResponseBodyDentryThumbnail = None,
        type: str = None,
        uuid: str = None,
        version: int = None,
    ):
        self.app_properties = app_properties
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
            temp_model = GetDentryResponseBodyDentryProperties()
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
            temp_model = GetDentryResponseBodyDentryThumbnail()
            self.thumbnail = temp_model.from_map(m['thumbnail'])
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class GetDentryResponseBody(TeaModel):
    def __init__(
        self,
        dentry: GetDentryResponseBodyDentry = None,
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
            temp_model = GetDentryResponseBodyDentry()
            self.dentry = temp_model.from_map(m['dentry'])
        return self


class GetDentryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetDentryResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = GetDentryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetDentryOpenInfoHeaders(TeaModel):
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


class GetDentryOpenInfoRequestOption(TeaModel):
    def __init__(
        self,
        check_login: bool = None,
        type: str = None,
        version: int = None,
        water_mark: bool = None,
    ):
        self.check_login = check_login
        self.type = type
        self.version = version
        self.water_mark = water_mark

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.check_login is not None:
            result['checkLogin'] = self.check_login
        if self.type is not None:
            result['type'] = self.type
        if self.version is not None:
            result['version'] = self.version
        if self.water_mark is not None:
            result['waterMark'] = self.water_mark
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('checkLogin') is not None:
            self.check_login = m.get('checkLogin')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('version') is not None:
            self.version = m.get('version')
        if m.get('waterMark') is not None:
            self.water_mark = m.get('waterMark')
        return self


class GetDentryOpenInfoRequest(TeaModel):
    def __init__(
        self,
        option: GetDentryOpenInfoRequestOption = None,
        union_id: str = None,
    ):
        self.option = option
        # This parameter is required.
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
            temp_model = GetDentryOpenInfoRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetDentryOpenInfoResponseBody(TeaModel):
    def __init__(
        self,
        has_water_mark: bool = None,
        url: str = None,
    ):
        self.has_water_mark = has_water_mark
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_water_mark is not None:
            result['hasWaterMark'] = self.has_water_mark
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasWaterMark') is not None:
            self.has_water_mark = m.get('hasWaterMark')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class GetDentryOpenInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetDentryOpenInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = GetDentryOpenInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetDentryThumbnailsHeaders(TeaModel):
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


class GetDentryThumbnailsRequest(TeaModel):
    def __init__(
        self,
        dentry_ids: List[str] = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.dentry_ids = dentry_ids
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dentry_ids is not None:
            result['dentryIds'] = self.dentry_ids
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentryIds') is not None:
            self.dentry_ids = m.get('dentryIds')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetDentryThumbnailsResponseBodyResultItemsThumbnail(TeaModel):
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


class GetDentryThumbnailsResponseBodyResultItems(TeaModel):
    def __init__(
        self,
        dentry_id: str = None,
        error_code: str = None,
        space_id: str = None,
        success: bool = None,
        thumbnail: GetDentryThumbnailsResponseBodyResultItemsThumbnail = None,
    ):
        self.dentry_id = dentry_id
        self.error_code = error_code
        self.space_id = space_id
        self.success = success
        self.thumbnail = thumbnail

    def validate(self):
        if self.thumbnail:
            self.thumbnail.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dentry_id is not None:
            result['dentryId'] = self.dentry_id
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.success is not None:
            result['success'] = self.success
        if self.thumbnail is not None:
            result['thumbnail'] = self.thumbnail.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentryId') is not None:
            self.dentry_id = m.get('dentryId')
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('thumbnail') is not None:
            temp_model = GetDentryThumbnailsResponseBodyResultItemsThumbnail()
            self.thumbnail = temp_model.from_map(m['thumbnail'])
        return self


class GetDentryThumbnailsResponseBody(TeaModel):
    def __init__(
        self,
        result_items: List[GetDentryThumbnailsResponseBodyResultItems] = None,
    ):
        self.result_items = result_items

    def validate(self):
        if self.result_items:
            for k in self.result_items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['resultItems'] = []
        if self.result_items is not None:
            for k in self.result_items:
                result['resultItems'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result_items = []
        if m.get('resultItems') is not None:
            for k in m.get('resultItems'):
                temp_model = GetDentryThumbnailsResponseBodyResultItems()
                self.result_items.append(temp_model.from_map(k))
        return self


class GetDentryThumbnailsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetDentryThumbnailsResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = GetDentryThumbnailsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetFileDownloadInfoHeaders(TeaModel):
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


class GetFileDownloadInfoRequestOption(TeaModel):
    def __init__(
        self,
        prefer_intranet: bool = None,
        version: int = None,
    ):
        self.prefer_intranet = prefer_intranet
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.prefer_intranet is not None:
            result['preferIntranet'] = self.prefer_intranet
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('preferIntranet') is not None:
            self.prefer_intranet = m.get('preferIntranet')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class GetFileDownloadInfoRequest(TeaModel):
    def __init__(
        self,
        option: GetFileDownloadInfoRequestOption = None,
        union_id: str = None,
    ):
        self.option = option
        # This parameter is required.
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
            temp_model = GetFileDownloadInfoRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetFileDownloadInfoResponseBodyHeaderSignatureInfo(TeaModel):
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


class GetFileDownloadInfoResponseBody(TeaModel):
    def __init__(
        self,
        header_signature_info: GetFileDownloadInfoResponseBodyHeaderSignatureInfo = None,
        protocol: str = None,
    ):
        self.header_signature_info = header_signature_info
        self.protocol = protocol

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headerSignatureInfo') is not None:
            temp_model = GetFileDownloadInfoResponseBodyHeaderSignatureInfo()
            self.header_signature_info = temp_model.from_map(m['headerSignatureInfo'])
        if m.get('protocol') is not None:
            self.protocol = m.get('protocol')
        return self


class GetFileDownloadInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetFileDownloadInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = GetFileDownloadInfoResponseBody()
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
        md_5: str = None,
        name: str = None,
        parent_id: str = None,
        size: int = None,
    ):
        self.md_5 = md_5
        self.name = name
        self.parent_id = parent_id
        self.size = size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.md_5 is not None:
            result['md5'] = self.md_5
        if self.name is not None:
            result['name'] = self.name
        if self.parent_id is not None:
            result['parentId'] = self.parent_id
        if self.size is not None:
            result['size'] = self.size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('md5') is not None:
            self.md_5 = m.get('md5')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('parentId') is not None:
            self.parent_id = m.get('parentId')
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
        multipart: bool = None,
        option: GetFileUploadInfoRequestOption = None,
        protocol: str = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.multipart = multipart
        self.option = option
        # This parameter is required.
        self.protocol = protocol
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        if self.option:
            self.option.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.multipart is not None:
            result['multipart'] = self.multipart
        if self.option is not None:
            result['option'] = self.option.to_map()
        if self.protocol is not None:
            result['protocol'] = self.protocol
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('multipart') is not None:
            self.multipart = m.get('multipart')
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


class GetMultipartFileUploadInfosHeaders(TeaModel):
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


class GetMultipartFileUploadInfosRequestOption(TeaModel):
    def __init__(
        self,
        prefer_intranet: bool = None,
    ):
        self.prefer_intranet = prefer_intranet

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.prefer_intranet is not None:
            result['preferIntranet'] = self.prefer_intranet
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('preferIntranet') is not None:
            self.prefer_intranet = m.get('preferIntranet')
        return self


class GetMultipartFileUploadInfosRequest(TeaModel):
    def __init__(
        self,
        option: GetMultipartFileUploadInfosRequestOption = None,
        part_numbers: List[int] = None,
        upload_key: str = None,
        union_id: str = None,
    ):
        self.option = option
        # This parameter is required.
        self.part_numbers = part_numbers
        # This parameter is required.
        self.upload_key = upload_key
        # This parameter is required.
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
        if self.part_numbers is not None:
            result['partNumbers'] = self.part_numbers
        if self.upload_key is not None:
            result['uploadKey'] = self.upload_key
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('option') is not None:
            temp_model = GetMultipartFileUploadInfosRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('partNumbers') is not None:
            self.part_numbers = m.get('partNumbers')
        if m.get('uploadKey') is not None:
            self.upload_key = m.get('uploadKey')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfosHeaderSignatureInfo(TeaModel):
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


class GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfos(TeaModel):
    def __init__(
        self,
        header_signature_info: GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfosHeaderSignatureInfo = None,
        part_number: int = None,
    ):
        self.header_signature_info = header_signature_info
        self.part_number = part_number

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
        if self.part_number is not None:
            result['partNumber'] = self.part_number
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headerSignatureInfo') is not None:
            temp_model = GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfosHeaderSignatureInfo()
            self.header_signature_info = temp_model.from_map(m['headerSignatureInfo'])
        if m.get('partNumber') is not None:
            self.part_number = m.get('partNumber')
        return self


class GetMultipartFileUploadInfosResponseBody(TeaModel):
    def __init__(
        self,
        multipart_header_signature_infos: List[GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfos] = None,
    ):
        self.multipart_header_signature_infos = multipart_header_signature_infos

    def validate(self):
        if self.multipart_header_signature_infos:
            for k in self.multipart_header_signature_infos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['multipartHeaderSignatureInfos'] = []
        if self.multipart_header_signature_infos is not None:
            for k in self.multipart_header_signature_infos:
                result['multipartHeaderSignatureInfos'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.multipart_header_signature_infos = []
        if m.get('multipartHeaderSignatureInfos') is not None:
            for k in m.get('multipartHeaderSignatureInfos'):
                temp_model = GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfos()
                self.multipart_header_signature_infos.append(temp_model.from_map(k))
        return self


class GetMultipartFileUploadInfosResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetMultipartFileUploadInfosResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = GetMultipartFileUploadInfosResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetOrgHeaders(TeaModel):
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


class GetOrgRequest(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        # This parameter is required.
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


class GetOrgResponseBodyOrgPartitionsQuota(TeaModel):
    def __init__(
        self,
        max: int = None,
        reserved: int = None,
        type: str = None,
        used: int = None,
    ):
        self.max = max
        self.reserved = reserved
        self.type = type
        self.used = used

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max is not None:
            result['max'] = self.max
        if self.reserved is not None:
            result['reserved'] = self.reserved
        if self.type is not None:
            result['type'] = self.type
        if self.used is not None:
            result['used'] = self.used
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('max') is not None:
            self.max = m.get('max')
        if m.get('reserved') is not None:
            self.reserved = m.get('reserved')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('used') is not None:
            self.used = m.get('used')
        return self


class GetOrgResponseBodyOrgPartitions(TeaModel):
    def __init__(
        self,
        partition_type: str = None,
        quota: GetOrgResponseBodyOrgPartitionsQuota = None,
    ):
        self.partition_type = partition_type
        self.quota = quota

    def validate(self):
        if self.quota:
            self.quota.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.partition_type is not None:
            result['partitionType'] = self.partition_type
        if self.quota is not None:
            result['quota'] = self.quota.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('partitionType') is not None:
            self.partition_type = m.get('partitionType')
        if m.get('quota') is not None:
            temp_model = GetOrgResponseBodyOrgPartitionsQuota()
            self.quota = temp_model.from_map(m['quota'])
        return self


class GetOrgResponseBodyOrg(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        partitions: List[GetOrgResponseBodyOrgPartitions] = None,
    ):
        self.corp_id = corp_id
        self.partitions = partitions

    def validate(self):
        if self.partitions:
            for k in self.partitions:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        result['partitions'] = []
        if self.partitions is not None:
            for k in self.partitions:
                result['partitions'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        self.partitions = []
        if m.get('partitions') is not None:
            for k in m.get('partitions'):
                temp_model = GetOrgResponseBodyOrgPartitions()
                self.partitions.append(temp_model.from_map(k))
        return self


class GetOrgResponseBody(TeaModel):
    def __init__(
        self,
        org: GetOrgResponseBodyOrg = None,
    ):
        self.org = org

    def validate(self):
        if self.org:
            self.org.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.org is not None:
            result['org'] = self.org.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('org') is not None:
            temp_model = GetOrgResponseBodyOrg()
            self.org = temp_model.from_map(m['org'])
        return self


class GetOrgResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetOrgResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = GetOrgResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetRecycleBinHeaders(TeaModel):
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


class GetRecycleBinRequest(TeaModel):
    def __init__(
        self,
        recycle_bin_scope: str = None,
        scope_id: str = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.recycle_bin_scope = recycle_bin_scope
        # This parameter is required.
        self.scope_id = scope_id
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.recycle_bin_scope is not None:
            result['recycleBinScope'] = self.recycle_bin_scope
        if self.scope_id is not None:
            result['scopeId'] = self.scope_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('recycleBinScope') is not None:
            self.recycle_bin_scope = m.get('recycleBinScope')
        if m.get('scopeId') is not None:
            self.scope_id = m.get('scopeId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetRecycleBinResponseBodyRecycleBin(TeaModel):
    def __init__(
        self,
        id: str = None,
        scope: str = None,
        scope_id: str = None,
    ):
        self.id = id
        self.scope = scope
        self.scope_id = scope_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.scope is not None:
            result['scope'] = self.scope
        if self.scope_id is not None:
            result['scopeId'] = self.scope_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('scope') is not None:
            self.scope = m.get('scope')
        if m.get('scopeId') is not None:
            self.scope_id = m.get('scopeId')
        return self


class GetRecycleBinResponseBody(TeaModel):
    def __init__(
        self,
        recycle_bin: GetRecycleBinResponseBodyRecycleBin = None,
    ):
        self.recycle_bin = recycle_bin

    def validate(self):
        if self.recycle_bin:
            self.recycle_bin.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.recycle_bin is not None:
            result['recycleBin'] = self.recycle_bin.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('recycleBin') is not None:
            temp_model = GetRecycleBinResponseBodyRecycleBin()
            self.recycle_bin = temp_model.from_map(m['recycleBin'])
        return self


class GetRecycleBinResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetRecycleBinResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = GetRecycleBinResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetRecycleItemHeaders(TeaModel):
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


class GetRecycleItemRequest(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        # This parameter is required.
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


class GetRecycleItemResponseBodyItem(TeaModel):
    def __init__(
        self,
        dentry_id: str = None,
        id: str = None,
        operator_id: str = None,
        operator_time: str = None,
        original_name: str = None,
        original_path: str = None,
        size: int = None,
        space_id: str = None,
        type: str = None,
    ):
        self.dentry_id = dentry_id
        self.id = id
        self.operator_id = operator_id
        self.operator_time = operator_time
        self.original_name = original_name
        self.original_path = original_path
        self.size = size
        self.space_id = space_id
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dentry_id is not None:
            result['dentryId'] = self.dentry_id
        if self.id is not None:
            result['id'] = self.id
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.operator_time is not None:
            result['operatorTime'] = self.operator_time
        if self.original_name is not None:
            result['originalName'] = self.original_name
        if self.original_path is not None:
            result['originalPath'] = self.original_path
        if self.size is not None:
            result['size'] = self.size
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentryId') is not None:
            self.dentry_id = m.get('dentryId')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('operatorTime') is not None:
            self.operator_time = m.get('operatorTime')
        if m.get('originalName') is not None:
            self.original_name = m.get('originalName')
        if m.get('originalPath') is not None:
            self.original_path = m.get('originalPath')
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GetRecycleItemResponseBody(TeaModel):
    def __init__(
        self,
        item: GetRecycleItemResponseBodyItem = None,
    ):
        self.item = item

    def validate(self):
        if self.item:
            self.item.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.item is not None:
            result['item'] = self.item.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('item') is not None:
            temp_model = GetRecycleItemResponseBodyItem()
            self.item = temp_model.from_map(m['item'])
        return self


class GetRecycleItemResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetRecycleItemResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = GetRecycleItemResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


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
        union_id: str = None,
    ):
        # This parameter is required.
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


class GetSpaceResponseBodySpaceCapabilities(TeaModel):
    def __init__(
        self,
        can_record_recent_file: bool = None,
        can_rename: bool = None,
        can_search: bool = None,
    ):
        self.can_record_recent_file = can_record_recent_file
        self.can_rename = can_rename
        self.can_search = can_search

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.can_record_recent_file is not None:
            result['canRecordRecentFile'] = self.can_record_recent_file
        if self.can_rename is not None:
            result['canRename'] = self.can_rename
        if self.can_search is not None:
            result['canSearch'] = self.can_search
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('canRecordRecentFile') is not None:
            self.can_record_recent_file = m.get('canRecordRecentFile')
        if m.get('canRename') is not None:
            self.can_rename = m.get('canRename')
        if m.get('canSearch') is not None:
            self.can_search = m.get('canSearch')
        return self


class GetSpaceResponseBodySpacePartitionsQuota(TeaModel):
    def __init__(
        self,
        max: int = None,
        reserved: int = None,
        type: str = None,
        used: int = None,
    ):
        self.max = max
        self.reserved = reserved
        self.type = type
        self.used = used

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max is not None:
            result['max'] = self.max
        if self.reserved is not None:
            result['reserved'] = self.reserved
        if self.type is not None:
            result['type'] = self.type
        if self.used is not None:
            result['used'] = self.used
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('max') is not None:
            self.max = m.get('max')
        if m.get('reserved') is not None:
            self.reserved = m.get('reserved')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('used') is not None:
            self.used = m.get('used')
        return self


class GetSpaceResponseBodySpacePartitions(TeaModel):
    def __init__(
        self,
        partition_type: str = None,
        quota: GetSpaceResponseBodySpacePartitionsQuota = None,
    ):
        self.partition_type = partition_type
        self.quota = quota

    def validate(self):
        if self.quota:
            self.quota.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.partition_type is not None:
            result['partitionType'] = self.partition_type
        if self.quota is not None:
            result['quota'] = self.quota.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('partitionType') is not None:
            self.partition_type = m.get('partitionType')
        if m.get('quota') is not None:
            temp_model = GetSpaceResponseBodySpacePartitionsQuota()
            self.quota = temp_model.from_map(m['quota'])
        return self


class GetSpaceResponseBodySpace(TeaModel):
    def __init__(
        self,
        app_id: str = None,
        capabilities: GetSpaceResponseBodySpaceCapabilities = None,
        corp_id: str = None,
        create_time: str = None,
        creator_id: str = None,
        id: str = None,
        modified_time: str = None,
        modifier_id: str = None,
        name: str = None,
        owner_id: str = None,
        owner_type: str = None,
        partitions: List[GetSpaceResponseBodySpacePartitions] = None,
        quota: int = None,
        scene: str = None,
        scene_id: str = None,
        status: str = None,
        used_quota: int = None,
    ):
        self.app_id = app_id
        self.capabilities = capabilities
        self.corp_id = corp_id
        self.create_time = create_time
        self.creator_id = creator_id
        self.id = id
        self.modified_time = modified_time
        self.modifier_id = modifier_id
        self.name = name
        self.owner_id = owner_id
        self.owner_type = owner_type
        self.partitions = partitions
        self.quota = quota
        self.scene = scene
        self.scene_id = scene_id
        self.status = status
        self.used_quota = used_quota

    def validate(self):
        if self.capabilities:
            self.capabilities.validate()
        if self.partitions:
            for k in self.partitions:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.capabilities is not None:
            result['capabilities'] = self.capabilities.to_map()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.id is not None:
            result['id'] = self.id
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.modifier_id is not None:
            result['modifierId'] = self.modifier_id
        if self.name is not None:
            result['name'] = self.name
        if self.owner_id is not None:
            result['ownerId'] = self.owner_id
        if self.owner_type is not None:
            result['ownerType'] = self.owner_type
        result['partitions'] = []
        if self.partitions is not None:
            for k in self.partitions:
                result['partitions'].append(k.to_map() if k else None)
        if self.quota is not None:
            result['quota'] = self.quota
        if self.scene is not None:
            result['scene'] = self.scene
        if self.scene_id is not None:
            result['sceneId'] = self.scene_id
        if self.status is not None:
            result['status'] = self.status
        if self.used_quota is not None:
            result['usedQuota'] = self.used_quota
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('capabilities') is not None:
            temp_model = GetSpaceResponseBodySpaceCapabilities()
            self.capabilities = temp_model.from_map(m['capabilities'])
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('modifierId') is not None:
            self.modifier_id = m.get('modifierId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('ownerId') is not None:
            self.owner_id = m.get('ownerId')
        if m.get('ownerType') is not None:
            self.owner_type = m.get('ownerType')
        self.partitions = []
        if m.get('partitions') is not None:
            for k in m.get('partitions'):
                temp_model = GetSpaceResponseBodySpacePartitions()
                self.partitions.append(temp_model.from_map(k))
        if m.get('quota') is not None:
            self.quota = m.get('quota')
        if m.get('scene') is not None:
            self.scene = m.get('scene')
        if m.get('sceneId') is not None:
            self.scene_id = m.get('sceneId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('usedQuota') is not None:
            self.used_quota = m.get('usedQuota')
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


class GetTaskHeaders(TeaModel):
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


class GetTaskRequest(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        # This parameter is required.
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


class GetTaskResponseBodyTask(TeaModel):
    def __init__(
        self,
        begin_time: str = None,
        end_time: str = None,
        fail_count: int = None,
        fail_message: str = None,
        id: str = None,
        status: str = None,
        success_count: int = None,
        total_count: int = None,
    ):
        self.begin_time = begin_time
        self.end_time = end_time
        self.fail_count = fail_count
        self.fail_message = fail_message
        self.id = id
        self.status = status
        self.success_count = success_count
        self.total_count = total_count

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.begin_time is not None:
            result['beginTime'] = self.begin_time
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.fail_count is not None:
            result['failCount'] = self.fail_count
        if self.fail_message is not None:
            result['failMessage'] = self.fail_message
        if self.id is not None:
            result['id'] = self.id
        if self.status is not None:
            result['status'] = self.status
        if self.success_count is not None:
            result['successCount'] = self.success_count
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('beginTime') is not None:
            self.begin_time = m.get('beginTime')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('failCount') is not None:
            self.fail_count = m.get('failCount')
        if m.get('failMessage') is not None:
            self.fail_message = m.get('failMessage')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('successCount') is not None:
            self.success_count = m.get('successCount')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetTaskResponseBody(TeaModel):
    def __init__(
        self,
        task: GetTaskResponseBodyTask = None,
    ):
        self.task = task

    def validate(self):
        if self.task:
            self.task.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.task is not None:
            result['task'] = self.task.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('task') is not None:
            temp_model = GetTaskResponseBodyTask()
            self.task = temp_model.from_map(m['task'])
        return self


class GetTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetTaskResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = GetTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetWebOfficeUrlHeaders(TeaModel):
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


class GetWebOfficeUrlRequest(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        # This parameter is required.
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


class GetWebOfficeUrlResponseBody(TeaModel):
    def __init__(
        self,
        web_office_access_token: str = None,
        web_office_refresh_token: str = None,
        web_office_url: str = None,
    ):
        self.web_office_access_token = web_office_access_token
        self.web_office_refresh_token = web_office_refresh_token
        self.web_office_url = web_office_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.web_office_access_token is not None:
            result['webOfficeAccessToken'] = self.web_office_access_token
        if self.web_office_refresh_token is not None:
            result['webOfficeRefreshToken'] = self.web_office_refresh_token
        if self.web_office_url is not None:
            result['webOfficeUrl'] = self.web_office_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('webOfficeAccessToken') is not None:
            self.web_office_access_token = m.get('webOfficeAccessToken')
        if m.get('webOfficeRefreshToken') is not None:
            self.web_office_refresh_token = m.get('webOfficeRefreshToken')
        if m.get('webOfficeUrl') is not None:
            self.web_office_url = m.get('webOfficeUrl')
        return self


class GetWebOfficeUrlResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetWebOfficeUrlResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = GetWebOfficeUrlResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class InitMultipartFileUploadHeaders(TeaModel):
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


class InitMultipartFileUploadRequestOptionPreCheckParam(TeaModel):
    def __init__(
        self,
        md_5: str = None,
        name: str = None,
        parent_id: str = None,
        size: int = None,
    ):
        self.md_5 = md_5
        self.name = name
        self.parent_id = parent_id
        self.size = size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.md_5 is not None:
            result['md5'] = self.md_5
        if self.name is not None:
            result['name'] = self.name
        if self.parent_id is not None:
            result['parentId'] = self.parent_id
        if self.size is not None:
            result['size'] = self.size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('md5') is not None:
            self.md_5 = m.get('md5')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('parentId') is not None:
            self.parent_id = m.get('parentId')
        if m.get('size') is not None:
            self.size = m.get('size')
        return self


class InitMultipartFileUploadRequestOption(TeaModel):
    def __init__(
        self,
        pre_check_param: InitMultipartFileUploadRequestOptionPreCheckParam = None,
        prefer_region: str = None,
        storage_driver: str = None,
    ):
        self.pre_check_param = pre_check_param
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
        if self.prefer_region is not None:
            result['preferRegion'] = self.prefer_region
        if self.storage_driver is not None:
            result['storageDriver'] = self.storage_driver
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('preCheckParam') is not None:
            temp_model = InitMultipartFileUploadRequestOptionPreCheckParam()
            self.pre_check_param = temp_model.from_map(m['preCheckParam'])
        if m.get('preferRegion') is not None:
            self.prefer_region = m.get('preferRegion')
        if m.get('storageDriver') is not None:
            self.storage_driver = m.get('storageDriver')
        return self


class InitMultipartFileUploadRequest(TeaModel):
    def __init__(
        self,
        option: InitMultipartFileUploadRequestOption = None,
        union_id: str = None,
    ):
        self.option = option
        # This parameter is required.
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
            temp_model = InitMultipartFileUploadRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class InitMultipartFileUploadResponseBody(TeaModel):
    def __init__(
        self,
        storage_driver: str = None,
        upload_key: str = None,
    ):
        self.storage_driver = storage_driver
        self.upload_key = upload_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.storage_driver is not None:
            result['storageDriver'] = self.storage_driver
        if self.upload_key is not None:
            result['uploadKey'] = self.upload_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('storageDriver') is not None:
            self.storage_driver = m.get('storageDriver')
        if m.get('uploadKey') is not None:
            self.upload_key = m.get('uploadKey')
        return self


class InitMultipartFileUploadResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: InitMultipartFileUploadResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = InitMultipartFileUploadResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListAllDentriesHeaders(TeaModel):
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


class ListAllDentriesRequestOption(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        order: str = None,
        with_thumbnail: bool = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        self.order = order
        self.with_thumbnail = with_thumbnail

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
        if self.order is not None:
            result['order'] = self.order
        if self.with_thumbnail is not None:
            result['withThumbnail'] = self.with_thumbnail
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('order') is not None:
            self.order = m.get('order')
        if m.get('withThumbnail') is not None:
            self.with_thumbnail = m.get('withThumbnail')
        return self


class ListAllDentriesRequest(TeaModel):
    def __init__(
        self,
        option: ListAllDentriesRequestOption = None,
        union_id: str = None,
    ):
        self.option = option
        # This parameter is required.
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
            temp_model = ListAllDentriesRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class ListAllDentriesResponseBodyDentriesProperties(TeaModel):
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


class ListAllDentriesResponseBodyDentriesThumbnail(TeaModel):
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


class ListAllDentriesResponseBodyDentries(TeaModel):
    def __init__(
        self,
        app_properties: Dict[str, List[DentriesAppPropertiesValue]] = None,
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
        properties: ListAllDentriesResponseBodyDentriesProperties = None,
        size: int = None,
        space_id: str = None,
        status: str = None,
        storage_driver: str = None,
        thumbnail: ListAllDentriesResponseBodyDentriesThumbnail = None,
        type: str = None,
        uuid: str = None,
        version: int = None,
    ):
        self.app_properties = app_properties
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
                    temp_model = DentriesAppPropertiesValue()
                    l1.append(temp_model.from_map(k1))
                self.app_properties['k'] = l1
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
            temp_model = ListAllDentriesResponseBodyDentriesProperties()
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
            temp_model = ListAllDentriesResponseBodyDentriesThumbnail()
            self.thumbnail = temp_model.from_map(m['thumbnail'])
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class ListAllDentriesResponseBody(TeaModel):
    def __init__(
        self,
        dentries: List[ListAllDentriesResponseBodyDentries] = None,
        next_token: str = None,
    ):
        self.dentries = dentries
        self.next_token = next_token

    def validate(self):
        if self.dentries:
            for k in self.dentries:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['dentries'] = []
        if self.dentries is not None:
            for k in self.dentries:
                result['dentries'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.dentries = []
        if m.get('dentries') is not None:
            for k in m.get('dentries'):
                temp_model = ListAllDentriesResponseBodyDentries()
                self.dentries.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class ListAllDentriesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListAllDentriesResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = ListAllDentriesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListDentriesHeaders(TeaModel):
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


class ListDentriesRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        order: str = None,
        order_by: str = None,
        parent_id: str = None,
        union_id: str = None,
        with_thumbnail: bool = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        self.order = order
        self.order_by = order_by
        # This parameter is required.
        self.parent_id = parent_id
        # This parameter is required.
        self.union_id = union_id
        self.with_thumbnail = with_thumbnail

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
        if self.order is not None:
            result['order'] = self.order
        if self.order_by is not None:
            result['orderBy'] = self.order_by
        if self.parent_id is not None:
            result['parentId'] = self.parent_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.with_thumbnail is not None:
            result['withThumbnail'] = self.with_thumbnail
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('order') is not None:
            self.order = m.get('order')
        if m.get('orderBy') is not None:
            self.order_by = m.get('orderBy')
        if m.get('parentId') is not None:
            self.parent_id = m.get('parentId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('withThumbnail') is not None:
            self.with_thumbnail = m.get('withThumbnail')
        return self


class ListDentriesResponseBodyDentriesProperties(TeaModel):
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


class ListDentriesResponseBodyDentriesThumbnail(TeaModel):
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


class ListDentriesResponseBodyDentries(TeaModel):
    def __init__(
        self,
        app_properties: Dict[str, List[DentriesAppPropertiesValue]] = None,
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
        properties: ListDentriesResponseBodyDentriesProperties = None,
        size: int = None,
        space_id: str = None,
        status: str = None,
        storage_driver: str = None,
        thumbnail: ListDentriesResponseBodyDentriesThumbnail = None,
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
                    temp_model = DentriesAppPropertiesValue()
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
            temp_model = ListDentriesResponseBodyDentriesProperties()
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
            temp_model = ListDentriesResponseBodyDentriesThumbnail()
            self.thumbnail = temp_model.from_map(m['thumbnail'])
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class ListDentriesResponseBody(TeaModel):
    def __init__(
        self,
        dentries: List[ListDentriesResponseBodyDentries] = None,
        next_token: str = None,
    ):
        self.dentries = dentries
        self.next_token = next_token

    def validate(self):
        if self.dentries:
            for k in self.dentries:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['dentries'] = []
        if self.dentries is not None:
            for k in self.dentries:
                result['dentries'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.dentries = []
        if m.get('dentries') is not None:
            for k in m.get('dentries'):
                temp_model = ListDentriesResponseBodyDentries()
                self.dentries.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class ListDentriesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListDentriesResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = ListDentriesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListDentryVersionsHeaders(TeaModel):
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


class ListDentryVersionsRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        union_id: str = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        # This parameter is required.
        self.union_id = union_id

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
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class ListDentryVersionsResponseBodyDentriesProperties(TeaModel):
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


class ListDentryVersionsResponseBodyDentries(TeaModel):
    def __init__(
        self,
        app_properties: Dict[str, List[DentriesAppPropertiesValue]] = None,
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
        properties: ListDentryVersionsResponseBodyDentriesProperties = None,
        size: int = None,
        space_id: str = None,
        status: str = None,
        storage_driver: str = None,
        type: str = None,
        uuid: str = None,
        version: int = None,
    ):
        self.app_properties = app_properties
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
                    temp_model = DentriesAppPropertiesValue()
                    l1.append(temp_model.from_map(k1))
                self.app_properties['k'] = l1
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
            temp_model = ListDentryVersionsResponseBodyDentriesProperties()
            self.properties = temp_model.from_map(m['properties'])
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('storageDriver') is not None:
            self.storage_driver = m.get('storageDriver')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class ListDentryVersionsResponseBody(TeaModel):
    def __init__(
        self,
        dentries: List[ListDentryVersionsResponseBodyDentries] = None,
        next_token: str = None,
    ):
        self.dentries = dentries
        self.next_token = next_token

    def validate(self):
        if self.dentries:
            for k in self.dentries:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['dentries'] = []
        if self.dentries is not None:
            for k in self.dentries:
                result['dentries'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.dentries = []
        if m.get('dentries') is not None:
            for k in m.get('dentries'):
                temp_model = ListDentryVersionsResponseBodyDentries()
                self.dentries.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class ListDentryVersionsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListDentryVersionsResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = ListDentryVersionsResponseBody()
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
        # This parameter is required.
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
        create_time: str = None,
        dentry_id: str = None,
        duration: int = None,
        member: ListPermissionsResponseBodyPermissionsMember = None,
        modified_time: str = None,
        operator_id: str = None,
        role: ListPermissionsResponseBodyPermissionsRole = None,
        space_id: str = None,
    ):
        self.create_time = create_time
        self.dentry_id = dentry_id
        self.duration = duration
        self.member = member
        self.modified_time = modified_time
        self.operator_id = operator_id
        self.role = role
        self.space_id = space_id

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
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.dentry_id is not None:
            result['dentryId'] = self.dentry_id
        if self.duration is not None:
            result['duration'] = self.duration
        if self.member is not None:
            result['member'] = self.member.to_map()
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.role is not None:
            result['role'] = self.role.to_map()
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('dentryId') is not None:
            self.dentry_id = m.get('dentryId')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('member') is not None:
            temp_model = ListPermissionsResponseBodyPermissionsMember()
            self.member = temp_model.from_map(m['member'])
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('role') is not None:
            temp_model = ListPermissionsResponseBodyPermissionsRole()
            self.role = temp_model.from_map(m['role'])
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
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


class ListRecycleItemsHeaders(TeaModel):
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


class ListRecycleItemsRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        union_id: str = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        # This parameter is required.
        self.union_id = union_id

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
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class ListRecycleItemsResponseBodyRecycleItems(TeaModel):
    def __init__(
        self,
        dentry_id: str = None,
        id: str = None,
        operator_id: str = None,
        operator_time: str = None,
        original_name: str = None,
        original_path: str = None,
        size: int = None,
        space_id: str = None,
        type: str = None,
    ):
        self.dentry_id = dentry_id
        self.id = id
        self.operator_id = operator_id
        self.operator_time = operator_time
        self.original_name = original_name
        self.original_path = original_path
        self.size = size
        self.space_id = space_id
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dentry_id is not None:
            result['dentryId'] = self.dentry_id
        if self.id is not None:
            result['id'] = self.id
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.operator_time is not None:
            result['operatorTime'] = self.operator_time
        if self.original_name is not None:
            result['originalName'] = self.original_name
        if self.original_path is not None:
            result['originalPath'] = self.original_path
        if self.size is not None:
            result['size'] = self.size
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentryId') is not None:
            self.dentry_id = m.get('dentryId')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('operatorTime') is not None:
            self.operator_time = m.get('operatorTime')
        if m.get('originalName') is not None:
            self.original_name = m.get('originalName')
        if m.get('originalPath') is not None:
            self.original_path = m.get('originalPath')
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class ListRecycleItemsResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        recycle_items: List[ListRecycleItemsResponseBodyRecycleItems] = None,
    ):
        self.next_token = next_token
        self.recycle_items = recycle_items

    def validate(self):
        if self.recycle_items:
            for k in self.recycle_items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['recycleItems'] = []
        if self.recycle_items is not None:
            for k in self.recycle_items:
                result['recycleItems'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.recycle_items = []
        if m.get('recycleItems') is not None:
            for k in m.get('recycleItems'):
                temp_model = ListRecycleItemsResponseBodyRecycleItems()
                self.recycle_items.append(temp_model.from_map(k))
        return self


class ListRecycleItemsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListRecycleItemsResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = ListRecycleItemsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class MoveDentriesHeaders(TeaModel):
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


class MoveDentriesRequestOption(TeaModel):
    def __init__(
        self,
        conflict_strategy: str = None,
        preserve_permissions: bool = None,
    ):
        self.conflict_strategy = conflict_strategy
        self.preserve_permissions = preserve_permissions

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conflict_strategy is not None:
            result['conflictStrategy'] = self.conflict_strategy
        if self.preserve_permissions is not None:
            result['preservePermissions'] = self.preserve_permissions
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conflictStrategy') is not None:
            self.conflict_strategy = m.get('conflictStrategy')
        if m.get('preservePermissions') is not None:
            self.preserve_permissions = m.get('preservePermissions')
        return self


class MoveDentriesRequest(TeaModel):
    def __init__(
        self,
        dentry_ids: List[str] = None,
        option: MoveDentriesRequestOption = None,
        target_folder_id: str = None,
        target_space_id: str = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.dentry_ids = dentry_ids
        self.option = option
        # This parameter is required.
        self.target_folder_id = target_folder_id
        # This parameter is required.
        self.target_space_id = target_space_id
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        if self.option:
            self.option.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dentry_ids is not None:
            result['dentryIds'] = self.dentry_ids
        if self.option is not None:
            result['option'] = self.option.to_map()
        if self.target_folder_id is not None:
            result['targetFolderId'] = self.target_folder_id
        if self.target_space_id is not None:
            result['targetSpaceId'] = self.target_space_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentryIds') is not None:
            self.dentry_ids = m.get('dentryIds')
        if m.get('option') is not None:
            temp_model = MoveDentriesRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('targetFolderId') is not None:
            self.target_folder_id = m.get('targetFolderId')
        if m.get('targetSpaceId') is not None:
            self.target_space_id = m.get('targetSpaceId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class MoveDentriesResponseBodyResultItems(TeaModel):
    def __init__(
        self,
        async_: bool = None,
        dentry_id: str = None,
        error_code: str = None,
        space_id: str = None,
        success: bool = None,
        target_dentry_id: str = None,
        target_space_id: str = None,
        task_id: str = None,
    ):
        self.async_ = async_
        self.dentry_id = dentry_id
        self.error_code = error_code
        self.space_id = space_id
        self.success = success
        self.target_dentry_id = target_dentry_id
        self.target_space_id = target_space_id
        self.task_id = task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.async_ is not None:
            result['async'] = self.async_
        if self.dentry_id is not None:
            result['dentryId'] = self.dentry_id
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.success is not None:
            result['success'] = self.success
        if self.target_dentry_id is not None:
            result['targetDentryId'] = self.target_dentry_id
        if self.target_space_id is not None:
            result['targetSpaceId'] = self.target_space_id
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('async') is not None:
            self.async_ = m.get('async')
        if m.get('dentryId') is not None:
            self.dentry_id = m.get('dentryId')
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('targetDentryId') is not None:
            self.target_dentry_id = m.get('targetDentryId')
        if m.get('targetSpaceId') is not None:
            self.target_space_id = m.get('targetSpaceId')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class MoveDentriesResponseBody(TeaModel):
    def __init__(
        self,
        result_items: List[MoveDentriesResponseBodyResultItems] = None,
    ):
        self.result_items = result_items

    def validate(self):
        if self.result_items:
            for k in self.result_items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['resultItems'] = []
        if self.result_items is not None:
            for k in self.result_items:
                result['resultItems'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result_items = []
        if m.get('resultItems') is not None:
            for k in m.get('resultItems'):
                temp_model = MoveDentriesResponseBodyResultItems()
                self.result_items.append(temp_model.from_map(k))
        return self


class MoveDentriesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: MoveDentriesResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = MoveDentriesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class MoveDentryHeaders(TeaModel):
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


class MoveDentryRequestOption(TeaModel):
    def __init__(
        self,
        conflict_strategy: str = None,
        preseve_permissions: bool = None,
    ):
        self.conflict_strategy = conflict_strategy
        self.preseve_permissions = preseve_permissions

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conflict_strategy is not None:
            result['conflictStrategy'] = self.conflict_strategy
        if self.preseve_permissions is not None:
            result['presevePermissions'] = self.preseve_permissions
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conflictStrategy') is not None:
            self.conflict_strategy = m.get('conflictStrategy')
        if m.get('presevePermissions') is not None:
            self.preseve_permissions = m.get('presevePermissions')
        return self


class MoveDentryRequest(TeaModel):
    def __init__(
        self,
        option: MoveDentryRequestOption = None,
        target_folder_id: str = None,
        target_space_id: str = None,
        union_id: str = None,
    ):
        self.option = option
        # This parameter is required.
        self.target_folder_id = target_folder_id
        # This parameter is required.
        self.target_space_id = target_space_id
        # This parameter is required.
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
        if self.target_folder_id is not None:
            result['targetFolderId'] = self.target_folder_id
        if self.target_space_id is not None:
            result['targetSpaceId'] = self.target_space_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('option') is not None:
            temp_model = MoveDentryRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('targetFolderId') is not None:
            self.target_folder_id = m.get('targetFolderId')
        if m.get('targetSpaceId') is not None:
            self.target_space_id = m.get('targetSpaceId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class MoveDentryResponseBodyDentryProperties(TeaModel):
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


class MoveDentryResponseBodyDentry(TeaModel):
    def __init__(
        self,
        app_properties: Dict[str, List[DentryAppPropertiesValue]] = None,
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
        properties: MoveDentryResponseBodyDentryProperties = None,
        size: int = None,
        space_id: str = None,
        status: str = None,
        storage_driver: str = None,
        type: str = None,
        uuid: str = None,
        version: int = None,
    ):
        self.app_properties = app_properties
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
            temp_model = MoveDentryResponseBodyDentryProperties()
            self.properties = temp_model.from_map(m['properties'])
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('storageDriver') is not None:
            self.storage_driver = m.get('storageDriver')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class MoveDentryResponseBody(TeaModel):
    def __init__(
        self,
        async_: bool = None,
        dentry: MoveDentryResponseBodyDentry = None,
        task_id: str = None,
    ):
        self.async_ = async_
        self.dentry = dentry
        self.task_id = task_id

    def validate(self):
        if self.dentry:
            self.dentry.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.async_ is not None:
            result['async'] = self.async_
        if self.dentry is not None:
            result['dentry'] = self.dentry.to_map()
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('async') is not None:
            self.async_ = m.get('async')
        if m.get('dentry') is not None:
            temp_model = MoveDentryResponseBodyDentry()
            self.dentry = temp_model.from_map(m['dentry'])
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class MoveDentryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: MoveDentryResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = MoveDentryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RefreshWebOfficeTokenHeaders(TeaModel):
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


class RefreshWebOfficeTokenRequest(TeaModel):
    def __init__(
        self,
        union_id: str = None,
        web_office_access_token: str = None,
        web_office_refresh_token: str = None,
    ):
        # This parameter is required.
        self.union_id = union_id
        # This parameter is required.
        self.web_office_access_token = web_office_access_token
        # This parameter is required.
        self.web_office_refresh_token = web_office_refresh_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.web_office_access_token is not None:
            result['webOfficeAccessToken'] = self.web_office_access_token
        if self.web_office_refresh_token is not None:
            result['webOfficeRefreshToken'] = self.web_office_refresh_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('webOfficeAccessToken') is not None:
            self.web_office_access_token = m.get('webOfficeAccessToken')
        if m.get('webOfficeRefreshToken') is not None:
            self.web_office_refresh_token = m.get('webOfficeRefreshToken')
        return self


class RefreshWebOfficeTokenResponseBody(TeaModel):
    def __init__(
        self,
        web_office_access_token: str = None,
        web_office_refresh_token: str = None,
    ):
        self.web_office_access_token = web_office_access_token
        self.web_office_refresh_token = web_office_refresh_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.web_office_access_token is not None:
            result['webOfficeAccessToken'] = self.web_office_access_token
        if self.web_office_refresh_token is not None:
            result['webOfficeRefreshToken'] = self.web_office_refresh_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('webOfficeAccessToken') is not None:
            self.web_office_access_token = m.get('webOfficeAccessToken')
        if m.get('webOfficeRefreshToken') is not None:
            self.web_office_refresh_token = m.get('webOfficeRefreshToken')
        return self


class RefreshWebOfficeTokenResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RefreshWebOfficeTokenResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = RefreshWebOfficeTokenResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RegisterOpenInfoHeaders(TeaModel):
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


class RegisterOpenInfoRequestOpenInfos(TeaModel):
    def __init__(
        self,
        open_type: str = None,
        url: str = None,
    ):
        # This parameter is required.
        self.open_type = open_type
        # This parameter is required.
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_type is not None:
            result['openType'] = self.open_type
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openType') is not None:
            self.open_type = m.get('openType')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class RegisterOpenInfoRequest(TeaModel):
    def __init__(
        self,
        open_infos: List[RegisterOpenInfoRequestOpenInfos] = None,
        provider: str = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.open_infos = open_infos
        # This parameter is required.
        self.provider = provider
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        if self.open_infos:
            for k in self.open_infos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['openInfos'] = []
        if self.open_infos is not None:
            for k in self.open_infos:
                result['openInfos'].append(k.to_map() if k else None)
        if self.provider is not None:
            result['provider'] = self.provider
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.open_infos = []
        if m.get('openInfos') is not None:
            for k in m.get('openInfos'):
                temp_model = RegisterOpenInfoRequestOpenInfos()
                self.open_infos.append(temp_model.from_map(k))
        if m.get('provider') is not None:
            self.provider = m.get('provider')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class RegisterOpenInfoResponseBody(TeaModel):
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


class RegisterOpenInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RegisterOpenInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = RegisterOpenInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RenameDentryHeaders(TeaModel):
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


class RenameDentryRequest(TeaModel):
    def __init__(
        self,
        new_name: str = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.new_name = new_name
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.new_name is not None:
            result['newName'] = self.new_name
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('newName') is not None:
            self.new_name = m.get('newName')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class RenameDentryResponseBodyDentryProperties(TeaModel):
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


class RenameDentryResponseBodyDentry(TeaModel):
    def __init__(
        self,
        app_properties: Dict[str, List[DentryAppPropertiesValue]] = None,
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
        properties: RenameDentryResponseBodyDentryProperties = None,
        size: int = None,
        space_id: str = None,
        status: str = None,
        storage_driver: str = None,
        type: str = None,
        uuid: str = None,
        version: int = None,
    ):
        self.app_properties = app_properties
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
            temp_model = RenameDentryResponseBodyDentryProperties()
            self.properties = temp_model.from_map(m['properties'])
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('storageDriver') is not None:
            self.storage_driver = m.get('storageDriver')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class RenameDentryResponseBody(TeaModel):
    def __init__(
        self,
        dentry: RenameDentryResponseBodyDentry = None,
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
            temp_model = RenameDentryResponseBodyDentry()
            self.dentry = temp_model.from_map(m['dentry'])
        return self


class RenameDentryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RenameDentryResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = RenameDentryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RestoreRecycleItemHeaders(TeaModel):
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


class RestoreRecycleItemRequestOption(TeaModel):
    def __init__(
        self,
        conflict_strategy: str = None,
    ):
        self.conflict_strategy = conflict_strategy

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conflict_strategy is not None:
            result['conflictStrategy'] = self.conflict_strategy
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conflictStrategy') is not None:
            self.conflict_strategy = m.get('conflictStrategy')
        return self


class RestoreRecycleItemRequest(TeaModel):
    def __init__(
        self,
        option: RestoreRecycleItemRequestOption = None,
        union_id: str = None,
    ):
        self.option = option
        # This parameter is required.
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
            temp_model = RestoreRecycleItemRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class RestoreRecycleItemResponseBody(TeaModel):
    def __init__(
        self,
        async_: bool = None,
        dentry_id: str = None,
        space_id: str = None,
        task_id: str = None,
    ):
        self.async_ = async_
        self.dentry_id = dentry_id
        self.space_id = space_id
        self.task_id = task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.async_ is not None:
            result['async'] = self.async_
        if self.dentry_id is not None:
            result['dentryId'] = self.dentry_id
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('async') is not None:
            self.async_ = m.get('async')
        if m.get('dentryId') is not None:
            self.dentry_id = m.get('dentryId')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class RestoreRecycleItemResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RestoreRecycleItemResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = RestoreRecycleItemResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RestoreRecycleItemsHeaders(TeaModel):
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


class RestoreRecycleItemsRequestOption(TeaModel):
    def __init__(
        self,
        conflict_strategy: str = None,
    ):
        self.conflict_strategy = conflict_strategy

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conflict_strategy is not None:
            result['conflictStrategy'] = self.conflict_strategy
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conflictStrategy') is not None:
            self.conflict_strategy = m.get('conflictStrategy')
        return self


class RestoreRecycleItemsRequest(TeaModel):
    def __init__(
        self,
        option: RestoreRecycleItemsRequestOption = None,
        recycle_item_ids: List[str] = None,
        union_id: str = None,
    ):
        self.option = option
        # This parameter is required.
        self.recycle_item_ids = recycle_item_ids
        # This parameter is required.
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
        if self.recycle_item_ids is not None:
            result['recycleItemIds'] = self.recycle_item_ids
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('option') is not None:
            temp_model = RestoreRecycleItemsRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('recycleItemIds') is not None:
            self.recycle_item_ids = m.get('recycleItemIds')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class RestoreRecycleItemsResponseBodyResultItems(TeaModel):
    def __init__(
        self,
        async_: bool = None,
        dentry_id: str = None,
        error_code: str = None,
        recycle_bin_id: str = None,
        recycle_item_id: str = None,
        space_id: str = None,
        success: bool = None,
        task_id: str = None,
    ):
        self.async_ = async_
        self.dentry_id = dentry_id
        self.error_code = error_code
        self.recycle_bin_id = recycle_bin_id
        self.recycle_item_id = recycle_item_id
        self.space_id = space_id
        self.success = success
        self.task_id = task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.async_ is not None:
            result['async'] = self.async_
        if self.dentry_id is not None:
            result['dentryId'] = self.dentry_id
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.recycle_bin_id is not None:
            result['recycleBinId'] = self.recycle_bin_id
        if self.recycle_item_id is not None:
            result['recycleItemId'] = self.recycle_item_id
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.success is not None:
            result['success'] = self.success
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('async') is not None:
            self.async_ = m.get('async')
        if m.get('dentryId') is not None:
            self.dentry_id = m.get('dentryId')
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('recycleBinId') is not None:
            self.recycle_bin_id = m.get('recycleBinId')
        if m.get('recycleItemId') is not None:
            self.recycle_item_id = m.get('recycleItemId')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class RestoreRecycleItemsResponseBody(TeaModel):
    def __init__(
        self,
        result_items: List[RestoreRecycleItemsResponseBodyResultItems] = None,
    ):
        self.result_items = result_items

    def validate(self):
        if self.result_items:
            for k in self.result_items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['resultItems'] = []
        if self.result_items is not None:
            for k in self.result_items:
                result['resultItems'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result_items = []
        if m.get('resultItems') is not None:
            for k in m.get('resultItems'):
                temp_model = RestoreRecycleItemsResponseBodyResultItems()
                self.result_items.append(temp_model.from_map(k))
        return self


class RestoreRecycleItemsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RestoreRecycleItemsResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = RestoreRecycleItemsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RevertDentryVersionHeaders(TeaModel):
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


class RevertDentryVersionRequest(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        # This parameter is required.
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


class RevertDentryVersionResponseBody(TeaModel):
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


class RevertDentryVersionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RevertDentryVersionResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = RevertDentryVersionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SubscribeEventHeaders(TeaModel):
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


class SubscribeEventRequest(TeaModel):
    def __init__(
        self,
        scope: str = None,
        scope_id: str = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.scope = scope
        # This parameter is required.
        self.scope_id = scope_id
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.scope is not None:
            result['scope'] = self.scope
        if self.scope_id is not None:
            result['scopeId'] = self.scope_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('scope') is not None:
            self.scope = m.get('scope')
        if m.get('scopeId') is not None:
            self.scope_id = m.get('scopeId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class SubscribeEventResponseBody(TeaModel):
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


class SubscribeEventResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SubscribeEventResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = SubscribeEventResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UnsubscribeEventHeaders(TeaModel):
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


class UnsubscribeEventRequest(TeaModel):
    def __init__(
        self,
        scope: str = None,
        scope_id: str = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.scope = scope
        # This parameter is required.
        self.scope_id = scope_id
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.scope is not None:
            result['scope'] = self.scope
        if self.scope_id is not None:
            result['scopeId'] = self.scope_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('scope') is not None:
            self.scope = m.get('scope')
        if m.get('scopeId') is not None:
            self.scope_id = m.get('scopeId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class UnsubscribeEventResponseBody(TeaModel):
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


class UnsubscribeEventResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UnsubscribeEventResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = UnsubscribeEventResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateDentryAppPropertiesHeaders(TeaModel):
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


class UpdateDentryAppPropertiesRequestAppProperties(TeaModel):
    def __init__(
        self,
        name: str = None,
        value: str = None,
        visibility: str = None,
    ):
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.value = value
        # This parameter is required.
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


class UpdateDentryAppPropertiesRequest(TeaModel):
    def __init__(
        self,
        app_properties: List[UpdateDentryAppPropertiesRequestAppProperties] = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.app_properties = app_properties
        # This parameter is required.
        self.union_id = union_id

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
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.app_properties = []
        if m.get('appProperties') is not None:
            for k in m.get('appProperties'):
                temp_model = UpdateDentryAppPropertiesRequestAppProperties()
                self.app_properties.append(temp_model.from_map(k))
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class UpdateDentryAppPropertiesResponseBody(TeaModel):
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


class UpdateDentryAppPropertiesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateDentryAppPropertiesResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = UpdateDentryAppPropertiesResponseBody()
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
        # This parameter is required.
        self.id = id
        # This parameter is required.
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
        # This parameter is required.
        self.members = members
        self.option = option
        # This parameter is required.
        self.role_id = role_id
        # This parameter is required.
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


