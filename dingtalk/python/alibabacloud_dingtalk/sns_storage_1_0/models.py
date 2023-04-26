# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


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
    ):
        self.app_ids_for_app_properties = app_ids_for_app_properties

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_ids_for_app_properties is not None:
            result['appIdsForAppProperties'] = self.app_ids_for_app_properties
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appIdsForAppProperties') is not None:
            self.app_ids_for_app_properties = m.get('appIdsForAppProperties')
        return self


class GetDentriesRequest(TeaModel):
    def __init__(
        self,
        dentry_ids: List[str] = None,
        option: GetDentriesRequestOption = None,
        union_id: str = None,
    ):
        self.dentry_ids = dentry_ids
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
            temp_model = GetDentryResponseBody()
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
        self.dentry_ids = dentry_ids
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
            temp_model = GetFileDownloadInfoResponseBody()
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
        self.parent_id = parent_id
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
            temp_model = ListDentriesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListExpiredHeaders(TeaModel):
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


class ListExpiredRequestOption(TeaModel):
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


class ListExpiredRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        option: ListExpiredRequestOption = None,
        union_id: str = None,
    ):
        self.open_conversation_id = open_conversation_id
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
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.option is not None:
            result['option'] = self.option.to_map()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('option') is not None:
            temp_model = ListExpiredRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class ListExpiredResponseBodyFiles(TeaModel):
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


class ListExpiredResponseBody(TeaModel):
    def __init__(
        self,
        files: List[ListExpiredResponseBodyFiles] = None,
        next_token: str = None,
    ):
        self.files = files
        self.next_token = next_token

    def validate(self):
        if self.files:
            for k in self.files:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['files'] = []
        if self.files is not None:
            for k in self.files:
                result['files'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.files = []
        if m.get('files') is not None:
            for k in m.get('files'):
                temp_model = ListExpiredResponseBodyFiles()
                self.files.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class ListExpiredResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListExpiredResponseBody = None,
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
            temp_model = ListExpiredResponseBody()
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
        self.scope = scope
        self.scope_id = scope_id
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
        self.scope = scope
        self.scope_id = scope_id
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
            temp_model = UnsubscribeEventResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


