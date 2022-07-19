# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


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
        # 属性名称 该属性名称在当前app下需要保证唯一，不同app间同名属性互不影响
        self.name = name
        # 属性值
        self.value = value
        # 属性可见范围
        # 枚举值:
        # 	PUBLIC: 该属性所有App可见
        # 	PRIVATE: 该属性仅其归属App可见
        # 默认值:
        # 	PRIVATE
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
        # 文件夹在应用上的属性, 一个应用最多只能设置3个属性
        self.app_properties = app_properties
        # 文件夹名称冲突策略
        # 枚举值:
        # 	AUTO_RENAME: 自动重命名
        # 	OVERWRITE: 覆盖
        # 	RETURN_DENTRY_IF_EXISTS: 返回已存在文件
        # 	RETURN_ERROR_IF_EXISTS: 文件已存在时报错
        # 默认值:
        # 	AUTO_RENAME
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
        # 名称, 规则：
        # 1. 头尾不能包含空格，否则会自动去除
        # 2. 不能包含特殊字符，包括：制表符、*、"、<、>、|
        # 3. 不能以"."结尾
        self.name = name
        # 可选参数
        self.option = option
        # 用户id
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
        # 文件是否只读
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


class DentryAppPropertiesValue(TeaModel):
    def __init__(
        self,
        name: str = None,
        value: str = None,
        visibility: str = None,
    ):
        # 属性名称 该属性名称在当前app下需要保证唯一，不同app间同名属性互不影响
        self.name = name
        # 属性值
        self.value = value
        # 属性可见范围
        # 枚举值:
        # 	PUBLIC: 该属性所有App可见
        # 	PRIVATE: 该属性仅其归属App可见
        # 默认值:
        # 	PRIVATE
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
        # 在特定应用上的属性。key是微应用Id, value是属性列表。
        # 可以通过修改DentryAppProperty里的scope来设置属性的可见性
        self.app_properties = app_properties
        # 创建时间
        self.create_time = create_time
        # 创建者id
        self.creator_id = creator_id
        # 后缀
        self.extension = extension
        # id
        self.id = id
        # 修改时间
        self.modified_time = modified_time
        # 修改者id
        self.modifier_id = modifier_id
        # 名称
        self.name = name
        # 父目录id, 根目录id值为0
        # 空值代表根目录的parentId不存在
        self.parent_id = parent_id
        # 存储分区，目前包括公有云OSS存储分区和专属Mini OSS存储分区
        # 枚举值:
        # 	PUBLIC_OSS_PARTITION: 公有云OSS存储分区
        # 	MINI_OSS_PARTITION: 专属Mini OSS存储分区
        self.partition_type = partition_type
        # 路径
        self.path = path
        # 属性
        self.properties = properties
        # 大小
        self.size = size
        # 所在空间id
        self.space_id = space_id
        # 状态
        # 枚举值:
        # 	NORMAL: 正常
        # 	DELETED: 已删除
        # 	EXPIRED: 已过期
        self.status = status
        # 驱动类型
        # 枚举值:
        # 	DINGTALK: 钉钉统一存储驱动
        # 	ALIDOC: 钉钉文档存储驱动
        # 	UNKNOWN: 未知驱动
        self.storage_driver = storage_driver
        # 类型，目录或文件
        # 枚举值:
        # 	FILE: 文件
        # 	FOLDER: 文件夹
        self.type = type
        # uuid，如移动文件，此字段不变
        self.uuid = uuid
        # 版本
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
        # 文件夹信息
        # dentry.type等于DentryTypeEnum.FOLDER表示是文件夹
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
        body: AddFolderResponseBody = None,
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
            temp_model = AddFolderResponseBody()
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
        # 是否进最近使用, 默认不支持
        # 默认值:
        # 	false
        self.can_record_recent_file = can_record_recent_file
        # 是否支持重命名空间名称, 默认不支持
        # 默认值:
        # 	false
        self.can_rename = can_rename
        # 是否支持搜索, 默认不支持
        # 默认值:
        # 	false
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
        # 空间能力项, 默认表示不设置拓展能力项
        self.capabilities = capabilities
        # 空间名称，默认无空间名称
        self.name = name
        # owner类型, 空间Owner可以是用户或应用, 详见 SpaceOwnerTypeEnum
        # 如果是应用类型，需要单独授权
        # 枚举值:
        # 	USER: 用户类型
        # 	APP: App类型
        # 默认值:
        # 	USER
        self.owner_type = owner_type
        # 空间能使用最大容量, 默认表示无最大容量
        self.quota = quota
        # 空间场景，详见 Space.scene 字段. 不指定默认值是default
        # 只能由数字和字母组成
        # 默认值:
        # 	default
        self.scene = scene
        # 空间场景Id，详见 Space.sceneId 字段. 不指定默认值是0
        # 只能由数字和字母组成
        # 默认值:
        # 	0
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


class AddSpaceRequestParam(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
    ):
        # 空间归属企业的Id
        self.corp_id = corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        return self


class AddSpaceRequest(TeaModel):
    def __init__(
        self,
        option: AddSpaceRequestOption = None,
        param: AddSpaceRequestParam = None,
        union_id: str = None,
    ):
        # 可选参数
        self.option = option
        # 必选参数
        self.param = param
        # 用户id
        self.union_id = union_id

    def validate(self):
        if self.option:
            self.option.validate()
        if self.param:
            self.param.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.option is not None:
            result['option'] = self.option.to_map()
        if self.param is not None:
            result['param'] = self.param.to_map()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('option') is not None:
            temp_model = AddSpaceRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('param') is not None:
            temp_model = AddSpaceRequestParam()
            self.param = temp_model.from_map(m['param'])
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
        # 是否进最近使用, 默认不支持
        # 默认值:
        # 	false
        self.can_record_recent_file = can_record_recent_file
        # 是否支持重命名空间名称, 默认不支持
        # 默认值:
        # 	false
        self.can_rename = can_rename
        # 是否支持搜索, 默认不支持
        # 默认值:
        # 	false
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
        quota: int = None,
        scene: str = None,
        scene_id: str = None,
        status: str = None,
        used_quota: int = None,
    ):
        # 开放平台应用appId
        self.app_id = app_id
        # 空间能力项. key详见 SpaceCapabilityEnum
        self.capabilities = capabilities
        # 空间归属企业的id
        self.corp_id = corp_id
        # 创建时间
        self.create_time = create_time
        # 创建者id
        self.creator_id = creator_id
        # 空间id
        self.id = id
        # 修改时间
        self.modified_time = modified_time
        # 修改者id
        self.modifier_id = modifier_id
        # 空间名称
        self.name = name
        # 所有者id, 根据ownerType定义, 确定值的所属类型
        self.owner_id = owner_id
        # owner类型, 详见SpaceOwnerTypeEnum
        # 枚举值:
        # 	USER: 用户类型
        # 	APP: App类型
        # 默认值:
        # 	USER
        self.owner_type = owner_type
        # 总容量
        self.quota = quota
        # 业务场景，可以自定义，表示多个不同空间的聚合，可以提供对特定场景做能力设计、容量管理，如根据场景来做搜索或查询。创建空间时，不指定scene, 默认值是default
        # 默认值:
        # 	default
        self.scene = scene
        # 关联业务id, 配合scene一起使用。创建空间时，不指定sceneId， 默认值是0
        # 默认值:
        # 	0
        self.scene_id = scene_id
        # 空间状态
        # 枚举值:
        # 	NORMAL: 正常
        # 	DELETE: 已删除
        self.status = status
        # 已使用容量
        self.used_quota = used_quota

    def validate(self):
        if self.capabilities:
            self.capabilities.validate()

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
        # 空间详情
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
        body: AddSpaceResponseBody = None,
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
        # 用户id
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
        # 本次操作是否成功
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
        body: ClearRecycleBinResponseBody = None,
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
        # 属性名称 该属性名称在当前app下需要保证唯一，不同app间同名属性互不影响
        self.name = name
        # 属性值
        self.value = value
        # 属性可见范围
        # 枚举值:
        # 	PUBLIC: 该属性所有App可见
        # 	PRIVATE: 该属性仅其归属App可见
        # 默认值:
        # 	PRIVATE
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
    ):
        # 文件在应用上的属性, 一个应用最多只能设置3个属性
        self.app_properties = app_properties
        # 文件名称冲突策略
        # 枚举值:
        # 	AUTO_RENAME: 自动重命名
        # 	OVERWRITE: 覆盖
        # 	RETURN_DENTRY_IF_EXISTS: 返回已存在文件
        # 	RETURN_ERROR_IF_EXISTS: 文件已存在时报错
        # 默认值:
        # 	AUTO_RENAME
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
                temp_model = CommitFileRequestOptionAppProperties()
                self.app_properties.append(temp_model.from_map(k))
        if m.get('conflictStrategy') is not None:
            self.conflict_strategy = m.get('conflictStrategy')
        return self


class CommitFileRequest(TeaModel):
    def __init__(
        self,
        name: str = None,
        option: CommitFileRequestOption = None,
        parent_id: str = None,
        size: int = None,
        upload_key: str = None,
        union_id: str = None,
    ):
        # 名称, 规则：
        # 1. 头尾不能包含空格，否则会自动去除
        # 2. 不能包含特殊字符，包括：制表符、*、"、<、>、|
        # 3. 不能以"."结尾
        self.name = name
        # 可选参数
        self.option = option
        # 父目录id, 根目录id值为0
        self.parent_id = parent_id
        # 大小
        self.size = size
        # 添加文件唯一标识，可通过DentryService.getUploadInfo来生成
        self.upload_key = upload_key
        # 用户id
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
        if self.parent_id is not None:
            result['parentId'] = self.parent_id
        if self.size is not None:
            result['size'] = self.size
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
        if m.get('parentId') is not None:
            self.parent_id = m.get('parentId')
        if m.get('size') is not None:
            self.size = m.get('size')
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
        # 文件是否只读
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


class CommitFileResponseBodyDentry(TeaModel):
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
        properties: CommitFileResponseBodyDentryProperties = None,
        size: int = None,
        space_id: str = None,
        status: str = None,
        storage_driver: str = None,
        type: str = None,
        uuid: str = None,
        version: int = None,
    ):
        # 在特定应用上的属性。key是微应用Id, value是属性列表。
        # 可以通过修改DentryAppProperty里的scope来设置属性的可见性
        self.app_properties = app_properties
        # 创建时间
        self.create_time = create_time
        # 创建者id
        self.creator_id = creator_id
        # 后缀
        self.extension = extension
        # id
        self.id = id
        # 修改时间
        self.modified_time = modified_time
        # 修改者id
        self.modifier_id = modifier_id
        # 名称
        self.name = name
        # 父目录id, 根目录id值为0
        # 空值代表根目录的parentId不存在
        self.parent_id = parent_id
        # 存储分区，目前包括公有云OSS存储分区和专属Mini OSS存储分区
        # 枚举值:
        # 	PUBLIC_OSS_PARTITION: 公有云OSS存储分区
        # 	MINI_OSS_PARTITION: 专属Mini OSS存储分区
        self.partition_type = partition_type
        # 路径
        self.path = path
        # 属性
        self.properties = properties
        # 大小
        self.size = size
        # 所在空间id
        self.space_id = space_id
        # 状态
        # 枚举值:
        # 	NORMAL: 正常
        # 	DELETED: 已删除
        # 	EXPIRED: 已过期
        self.status = status
        # 驱动类型
        # 枚举值:
        # 	DINGTALK: 钉钉统一存储驱动
        # 	ALIDOC: 钉钉文档存储驱动
        # 	UNKNOWN: 未知驱动
        self.storage_driver = storage_driver
        # 类型，目录或文件
        # 枚举值:
        # 	FILE: 文件
        # 	FOLDER: 文件夹
        self.type = type
        # uuid，如移动文件，此字段不变
        self.uuid = uuid
        # 版本
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
        # 文件信息
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
        body: CommitFileResponseBody = None,
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
            temp_model = CommitFileResponseBody()
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
        # 文件(夹)名称冲突策略
        # 枚举值:
        # 	AUTO_RENAME: 自动重命名
        # 	OVERWRITE: 覆盖
        # 	RETURN_DENTRY_IF_EXISTS: 返回已存在文件
        # 	RETURN_ERROR_IF_EXISTS: 文件已存在时报错
        # 默认值:
        # 	AUTO_RENAME
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
        # 可选参数
        self.option = option
        # 目标文件夹id, 根目录id值为0
        self.target_folder_id = target_folder_id
        # 目标文件夹空间id
        self.target_space_id = target_space_id
        # 用户id
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
        # 文件是否只读
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
        # 在特定应用上的属性。key是微应用Id, value是属性列表。
        # 可以通过修改DentryAppProperty里的scope来设置属性的可见性
        self.app_properties = app_properties
        # 创建时间
        self.create_time = create_time
        # 创建者id
        self.creator_id = creator_id
        # 后缀
        self.extension = extension
        # id
        self.id = id
        # 修改时间
        self.modified_time = modified_time
        # 修改者id
        self.modifier_id = modifier_id
        # 名称
        self.name = name
        # 父目录id, 根目录id值为0
        # 空值代表根目录的parentId不存在
        self.parent_id = parent_id
        # 存储分区，目前包括公有云OSS存储分区和专属Mini OSS存储分区
        # 枚举值:
        # 	PUBLIC_OSS_PARTITION: 公有云OSS存储分区
        # 	MINI_OSS_PARTITION: 专属Mini OSS存储分区
        self.partition_type = partition_type
        # 路径
        self.path = path
        # 属性
        self.properties = properties
        # 大小
        self.size = size
        # 所在空间id
        self.space_id = space_id
        # 状态
        # 枚举值:
        # 	NORMAL: 正常
        # 	DELETED: 已删除
        # 	EXPIRED: 已过期
        self.status = status
        # 驱动类型
        # 枚举值:
        # 	DINGTALK: 钉钉统一存储驱动
        # 	ALIDOC: 钉钉文档存储驱动
        # 	UNKNOWN: 未知驱动
        self.storage_driver = storage_driver
        # 类型，目录或文件
        # 枚举值:
        # 	FILE: 文件
        # 	FOLDER: 文件夹
        self.type = type
        # uuid，如移动文件，此字段不变
        self.uuid = uuid
        # 版本
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
        # 是否是异步任务
        # 如果操作对象有子节点，则会异步处理
        self.async_ = async_
        # 文件信息
        self.dentry = dentry
        # 任务id，用于查询任务执行状态; 查询接口开发中
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
        body: CopyDentryResponseBody = None,
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
            temp_model = CopyDentryResponseBody()
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
        # 是否删除到回收站，默认不删除到回收站，直接删除
        # 默认值:
        # 	false
        self.to_recycle_bin = to_recycle_bin
        # 用户id
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
        # 是否是异步任务
        # 如果操作对象有子节点，则会异步处理
        self.async_ = async_
        # 任务Id，用于查询任务执行状态; 查询接口开发中
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
        body: DeleteDentryResponseBody = None,
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
        # 文件上App属性名称
        self.property_names = property_names
        # 用户id
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
        # 本次操作是否成功
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
        body: DeleteDentryAppPropertiesResponseBody = None,
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
            temp_model = DeleteDentryAppPropertiesResponseBody()
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
        # 用户id
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
        # 本次操作是否成功
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
        body: DeleteRecycleItemResponseBody = None,
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
        # 回收项id列表
        self.recycle_item_ids = recycle_item_ids
        # 用户id
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
        # 本次操作是否成功
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
        body: DeleteRecycleItemsResponseBody = None,
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
        corp_id: str = None,
        union_id: str = None,
    ):
        # 应用归属企业的Id
        self.corp_id = corp_id
        # 用户id
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetCurrentAppResponseBodyAppPartitionsQuota(TeaModel):
    def __init__(
        self,
        max: int = None,
        type: str = None,
        used: int = None,
    ):
        # 最大容量, 单位: Byte
        # 当前应用容量被设置为max时，代表当前应用容量设置了上限，used<=max
        # 当前应用容量未设置max时，返回空，此时应用共享该企业剩余可用容量
        self.max = max
        # 容量类型
        # 枚举值:
        # 	SHARE: 共享容量
        # 此模式下，Quota.max为空，表示共享企业容量
        # 	PRIVATE: 专享容量
        # 当Quota.max设置值后，表示容量独占
        # 使用场景：当需要保证单个应用的可用容量不受其他应用影响时, 可使用共享容量
        self.type = type
        # 已使用容量, 单位: Byte
        # 表示该应用下所用文件占用容量的总和，文件的上传、复制、删除相关操作会对used的值做相应变更
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
        if self.type is not None:
            result['type'] = self.type
        if self.used is not None:
            result['used'] = self.used
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('max') is not None:
            self.max = m.get('max')
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
        # 分区类型
        # 枚举值:
        # 	PUBLIC_OSS_PARTITION: 公有云OSS存储分区
        # 	MINI_OSS_PARTITION: 专属Mini OSS存储分区
        self.partition_type = partition_type
        # 容量信息
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
        # 开放平台应用appId
        self.app_id = app_id
        # 应用归属企业的id
        self.corp_id = corp_id
        # 应用创建时间
        self.create_time = create_time
        # 应用修改时间
        self.modified_time = modified_time
        # 应用名称，对应开放平台应用名称
        self.name = name
        # 分区容量信息
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
        # 企业存储应用信息
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
        body: GetCurrentAppResponseBody = None,
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
            temp_model = GetCurrentAppResponseBody()
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
    ):
        # 通过指定应用id, 返回对应的可见属性，即dentry.appProperties，
        # 默认都会返回当前应用的属性，
        # 如不指定appIds, 则默认返回当前应用的appProperties
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


class GetDentryRequest(TeaModel):
    def __init__(
        self,
        option: GetDentryRequestOption = None,
        union_id: str = None,
    ):
        # 可选参数
        self.option = option
        # 用户id
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
        # 文件是否只读
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
        type: str = None,
        uuid: str = None,
        version: int = None,
    ):
        # 在特定应用上的属性。key是微应用Id, value是属性列表。
        # 可以通过修改DentryAppProperty里的scope来设置属性的可见性
        self.app_properties = app_properties
        # 创建时间
        self.create_time = create_time
        # 创建者id
        self.creator_id = creator_id
        # 后缀
        self.extension = extension
        # id
        self.id = id
        # 修改时间
        self.modified_time = modified_time
        # 修改者id
        self.modifier_id = modifier_id
        # 名称
        self.name = name
        # 父目录id, 根目录id值为0
        # 空值代表根目录的parentId不存在
        self.parent_id = parent_id
        # 存储分区，目前包括公有云OSS存储分区和专属Mini OSS存储分区
        # 枚举值:
        # 	PUBLIC_OSS_PARTITION: 公有云OSS存储分区
        # 	MINI_OSS_PARTITION: 专属Mini OSS存储分区
        self.partition_type = partition_type
        # 路径
        self.path = path
        # 属性
        self.properties = properties
        # 大小
        self.size = size
        # 所在空间id
        self.space_id = space_id
        # 状态
        # 枚举值:
        # 	NORMAL: 正常
        # 	DELETED: 已删除
        # 	EXPIRED: 已过期
        self.status = status
        # 驱动类型
        # 枚举值:
        # 	DINGTALK: 钉钉统一存储驱动
        # 	ALIDOC: 钉钉文档存储驱动
        # 	UNKNOWN: 未知驱动
        self.storage_driver = storage_driver
        # 类型，目录或文件
        # 枚举值:
        # 	FILE: 文件
        # 	FOLDER: 文件夹
        self.type = type
        # uuid，如移动文件，此字段不变
        self.uuid = uuid
        # 版本
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
        # 文件(夹)信息
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
        body: GetDentryResponseBody = None,
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
            temp_model = GetDentryResponseBody()
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
        version: int = None,
    ):
        # 历史版本号
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class GetFileDownloadInfoRequest(TeaModel):
    def __init__(
        self,
        option: GetFileDownloadInfoRequestOption = None,
        union_id: str = None,
    ):
        # 可选参数
        self.option = option
        # 用户id
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
        # 过期时间，单位秒
        self.expiration_seconds = expiration_seconds
        # 请求头
        self.headers = headers
        # 内网URL, 在网络连通的情况下，使用内网URL可加速服务器间上传
        self.internal_resource_urls = internal_resource_urls
        # 地域
        # 枚举值:
        # 	ZHANGJIAKOU: 张家口
        # 	SHENZHEN: 深圳
        # 	SHANGHAI: 上海
        # 	SINGAPORE: 新加坡
        # 	UNKNOWN: 未知
        self.region = region
        # 多个上传下载URL, 前面url优先
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
        # Header加签信息, 当protocol等于HEADER_SIGNATURE时，此字段生效
        self.header_signature_info = header_signature_info
        # 文件下载协议
        # 枚举值:
        # 	HEADER_SIGNATURE: Header加签
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
        body: GetFileDownloadInfoResponseBody = None,
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
        # 文件md5值, 做文件完整性校验。不传则不做校验。
        self.md_5 = md_5
        # 文件名称, 文件名称合法性和文件名称冲突校验
        # 规则：
        # 1. 头尾不能包含空格，否则会自动去除
        # 2. 不能包含特殊字符，包括：制表符、*、"、<、>、|
        # 3. 不能以"."结尾
        self.name = name
        # 父目录id
        # 根目录id值为0
        # 用于同目录文件名冲突校验
        self.parent_id = parent_id
        # 文件大小, 做容量相关校验。不传则不做校验。
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
        prefer_region: str = None,
        storage_driver: str = None,
    ):
        # 预检查的字段。可实现对文件名称，文件完整性，容量的校验
        self.pre_check_param = pre_check_param
        # 优先地域, 倾向于将资源存到哪个地域，可实现就近上传等功能
        # 枚举值:
        # 	ZHANGJIAKOU: 张家口
        # 	SHENZHEN: 深圳
        # 	SHANGHAI: 上海
        # 	SINGAPORE: 新加坡
        # 	UNKNOWN: 未知
        self.prefer_region = prefer_region
        # 文件存储驱动类型
        # 枚举值:
        # 	DINGTALK: 钉钉统一存储驱动
        # 	ALIDOC: 钉钉文档存储驱动
        # 	UNKNOWN: 未知驱动
        # 默认值:
        # 	DINGTALK
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
            temp_model = GetFileUploadInfoRequestOptionPreCheckParam()
            self.pre_check_param = temp_model.from_map(m['preCheckParam'])
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
        # 是否需要分片上传
        # 5G以下文件，建议设为false，简化上传步骤
        # 5G以上文件，必须设为true, 否则上传会失败
        # 具体参考文档: https://help.aliyun.com/document_detail/84778.html
        self.multipart = multipart
        # 可选参数
        self.option = option
        # 通过指定上传协议返回不同协议上传所需要的信息
        # 对于部分企业开启了专属存储，必须实现HEADER加签，否则无法支持专属存储组织文件上传。
        # 如果指定上传协议不支持，则会返回错误Errors.DENTRY_UPLOAD_PROTOCOL_NOTSUPPORT, 请尝试用其它协议上传。
        # 枚举值:
        # 	HEADER_SIGNATURE: Header加签
        self.protocol = protocol
        # 用户id
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
        # 过期时间，单位秒
        self.expiration_seconds = expiration_seconds
        # 请求头
        self.headers = headers
        # 内网URL, 在网络连通的情况下，使用内网URL可加速服务器间上传
        self.internal_resource_urls = internal_resource_urls
        # 地域
        # 枚举值:
        # 	ZHANGJIAKOU: 张家口
        # 	SHENZHEN: 深圳
        # 	SHANGHAI: 上海
        # 	SINGAPORE: 新加坡
        # 	UNKNOWN: 未知
        self.region = region
        # 多个上传下载URL, 前面url优先
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
        # Header加签上传信息, 当protocol等于HEADER_SIGNATURE时，此字段生效
        self.header_signature_info = header_signature_info
        # 上传协议，根据不同上传类型返回对应的信息.
        # 枚举值:
        # 	HEADER_SIGNATURE: Header加签
        self.protocol = protocol
        # 文件存储类型
        # 枚举值:
        # 	DINGTALK: 钉钉统一存储驱动
        # 	ALIDOC: 钉钉文档存储驱动
        # 	UNKNOWN: 未知驱动
        self.storage_driver = storage_driver
        # 上传唯一标识
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
        body: GetFileUploadInfoResponseBody = None,
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
            temp_model = GetFileUploadInfoResponseBody()
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
        # 回收站范围类型
        # 枚举值:
        # 	ORG: 企业
        # 	APP: 应用
        # 	SPACE: 空间
        self.recycle_bin_scope = recycle_bin_scope
        # 回收站范围id
        # 根据recycleBinScope传入对应的企业、应用、空间ID
        self.scope_id = scope_id
        # 用户id
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
        # 回收站id
        self.id = id
        # 回收站范围类型
        # 枚举值:
        # 	ORG: 企业
        # 	APP: 应用
        # 	SPACE: 空间
        self.scope = scope
        # 回收站范围id
        # 根据recycleBinScope传入对应的企业、应用、空间ID
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
        # 回收站信息
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
        body: GetRecycleBinResponseBody = None,
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
        # 用户id
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
        app_id: str = None,
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
        # 原文件(夹)所在应用id
        self.app_id = app_id
        # 原文件(夹)id
        self.dentry_id = dentry_id
        # 回收项id
        self.id = id
        # 操作人id
        self.operator_id = operator_id
        # 删除时间
        self.operator_time = operator_time
        # 原文件(夹)名称
        self.original_name = original_name
        # 原文件(夹)路径
        self.original_path = original_path
        # 原文件(夹)大小
        self.size = size
        # 原文件(夹)所在空间id
        self.space_id = space_id
        # 类型，目录或文件
        # 枚举值:
        # 	FILE: 文件
        # 	FOLDER: 文件夹
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_id is not None:
            result['appId'] = self.app_id
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
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
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
        # 回收项信息
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
        body: GetRecycleItemResponseBody = None,
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
        # 用户id
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
        # 是否进最近使用, 默认不支持
        # 默认值:
        # 	false
        self.can_record_recent_file = can_record_recent_file
        # 是否支持重命名空间名称, 默认不支持
        # 默认值:
        # 	false
        self.can_rename = can_rename
        # 是否支持搜索, 默认不支持
        # 默认值:
        # 	false
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
        quota: int = None,
        scene: str = None,
        scene_id: str = None,
        status: str = None,
        used_quota: int = None,
    ):
        # 开放平台应用appId
        self.app_id = app_id
        # 空间能力项. key详见 SpaceCapabilityEnum
        self.capabilities = capabilities
        # 空间归属企业的id
        self.corp_id = corp_id
        # 创建时间
        self.create_time = create_time
        # 创建者id
        self.creator_id = creator_id
        # 空间id
        self.id = id
        # 修改时间
        self.modified_time = modified_time
        # 修改者id
        self.modifier_id = modifier_id
        # 空间名称
        self.name = name
        # 所有者id, 根据ownerType定义, 确定值的所属类型
        self.owner_id = owner_id
        # owner类型, 详见SpaceOwnerTypeEnum
        # 枚举值:
        # 	USER: 用户类型
        # 	APP: App类型
        # 默认值:
        # 	USER
        self.owner_type = owner_type
        # 总容量
        self.quota = quota
        # 业务场景，可以自定义，表示多个不同空间的聚合，可以提供对特定场景做能力设计、容量管理，如根据场景来做搜索或查询。创建空间时，不指定scene, 默认值是default
        # 默认值:
        # 	default
        self.scene = scene
        # 关联业务id, 配合scene一起使用。创建空间时，不指定sceneId， 默认值是0
        # 默认值:
        # 	0
        self.scene_id = scene_id
        # 空间状态
        # 枚举值:
        # 	NORMAL: 正常
        # 	DELETE: 已删除
        self.status = status
        # 已使用容量
        self.used_quota = used_quota

    def validate(self):
        if self.capabilities:
            self.capabilities.validate()

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
        # 空间详情
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
        body: GetSpaceResponseBody = None,
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
            temp_model = GetSpaceResponseBody()
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
    ):
        # 分页大小
        # 默认值:
        # 	50
        self.max_results = max_results
        # 分页游标, 首次拉取不用传
        self.next_token = next_token
        # 排序规则, 升降或降序
        # 枚举值:
        # 	ASC: 升序
        # 	DESC: 降序
        # 默认值:
        # 	DESC
        self.order = order
        # 排序字段
        # 枚举值:
        # 	NAME: 名称
        # 	SIZE: 大小
        # 	MODIFIED_TIME: 最后修改时间
        # 	CREATE_TIME: 创建时间
        # 默认值:
        # 	MODIFIED_TIME
        self.order_by = order_by
        # 父目录id, 根目录id值为0
        self.parent_id = parent_id
        # 用户id
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
        if self.order is not None:
            result['order'] = self.order
        if self.order_by is not None:
            result['orderBy'] = self.order_by
        if self.parent_id is not None:
            result['parentId'] = self.parent_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
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
        return self


class ListDentriesResponseBodyDentriesProperties(TeaModel):
    def __init__(
        self,
        read_only: bool = None,
    ):
        # 文件是否只读
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


class DentriesAppPropertiesValue(TeaModel):
    def __init__(
        self,
        name: str = None,
        value: str = None,
        visibility: str = None,
    ):
        # 属性名称 该属性名称在当前app下需要保证唯一，不同app间同名属性互不影响
        self.name = name
        # 属性值
        self.value = value
        # 属性可见范围
        # 枚举值:
        # 	PUBLIC: 该属性所有App可见
        # 	PRIVATE: 该属性仅其归属App可见
        # 默认值:
        # 	PRIVATE
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
        type: str = None,
        uuid: str = None,
        version: int = None,
    ):
        # 在特定应用上的属性。key是微应用Id, value是属性列表。
        # 可以通过修改DentryAppProperty里的scope来设置属性的可见性
        self.app_properties = app_properties
        # 创建时间
        self.create_time = create_time
        # 创建者id
        self.creator_id = creator_id
        # 后缀
        self.extension = extension
        # id
        self.id = id
        # 修改时间
        self.modified_time = modified_time
        # 修改者id
        self.modifier_id = modifier_id
        # 名称
        self.name = name
        # 父目录id, 根目录id值为0
        # 空值代表根目录的parentId不存在
        self.parent_id = parent_id
        # 存储分区，目前包括公有云OSS存储分区和专属Mini OSS存储分区
        # 枚举值:
        # 	PUBLIC_OSS_PARTITION: 公有云OSS存储分区
        # 	MINI_OSS_PARTITION: 专属Mini OSS存储分区
        self.partition_type = partition_type
        # 路径
        self.path = path
        # 属性
        self.properties = properties
        # 大小
        self.size = size
        # 所在空间id
        self.space_id = space_id
        # 状态
        # 枚举值:
        # 	NORMAL: 正常
        # 	DELETED: 已删除
        # 	EXPIRED: 已过期
        self.status = status
        # 驱动类型
        # 枚举值:
        # 	DINGTALK: 钉钉统一存储驱动
        # 	ALIDOC: 钉钉文档存储驱动
        # 	UNKNOWN: 未知驱动
        self.storage_driver = storage_driver
        # 类型，目录或文件
        # 枚举值:
        # 	FILE: 文件
        # 	FOLDER: 文件夹
        self.type = type
        # uuid，如移动文件，此字段不变
        self.uuid = uuid
        # 版本
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
        # 文件列表
        self.dentries = dentries
        # 分页游标
        # 不为空表示有更多数据
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
        body: ListDentriesResponseBody = None,
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
        # 历史版本分页大小，默认100
        # 默认值:
        # 	100
        self.max_results = max_results
        # 下一页的游标位置
        self.next_token = next_token
        # 用户id
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
        # 文件是否只读
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
        # 在特定应用上的属性。key是微应用Id, value是属性列表。
        # 可以通过修改DentryAppProperty里的scope来设置属性的可见性
        self.app_properties = app_properties
        # 创建时间
        self.create_time = create_time
        # 创建者id
        self.creator_id = creator_id
        # 后缀
        self.extension = extension
        # id
        self.id = id
        # 修改时间
        self.modified_time = modified_time
        # 修改者id
        self.modifier_id = modifier_id
        # 名称
        self.name = name
        # 父目录id, 根目录id值为0
        # 空值代表根目录的parentId不存在
        self.parent_id = parent_id
        # 存储分区，目前包括公有云OSS存储分区和专属Mini OSS存储分区
        # 枚举值:
        # 	PUBLIC_OSS_PARTITION: 公有云OSS存储分区
        # 	MINI_OSS_PARTITION: 专属Mini OSS存储分区
        self.partition_type = partition_type
        # 路径
        self.path = path
        # 属性
        self.properties = properties
        # 大小
        self.size = size
        # 所在空间id
        self.space_id = space_id
        # 状态
        # 枚举值:
        # 	NORMAL: 正常
        # 	DELETED: 已删除
        # 	EXPIRED: 已过期
        self.status = status
        # 驱动类型
        # 枚举值:
        # 	DINGTALK: 钉钉统一存储驱动
        # 	ALIDOC: 钉钉文档存储驱动
        # 	UNKNOWN: 未知驱动
        self.storage_driver = storage_driver
        # 类型，目录或文件
        # 枚举值:
        # 	FILE: 文件
        # 	FOLDER: 文件夹
        self.type = type
        # uuid，如移动文件，此字段不变
        self.uuid = uuid
        # 版本
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
        # 文件版本列表
        self.dentries = dentries
        # 分页游标
        # 不为空表示有更多数据
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
        body: ListDentryVersionsResponseBody = None,
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
            temp_model = ListDentryVersionsResponseBody()
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
        # 分页大小, 不保证全量返回
        # 默认值:
        # 	50
        self.max_results = max_results
        # 分页游标，首次拉取nextToken传null
        self.next_token = next_token
        # 用户id
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
        app_id: str = None,
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
        # 原文件(夹)所在应用id
        self.app_id = app_id
        # 原文件(夹)id
        self.dentry_id = dentry_id
        # 回收项id
        self.id = id
        # 操作人id
        self.operator_id = operator_id
        # 删除时间
        self.operator_time = operator_time
        # 原文件(夹)名称
        self.original_name = original_name
        # 原文件(夹)路径
        self.original_path = original_path
        # 原文件(夹)大小
        self.size = size
        # 原文件(夹)所在空间id
        self.space_id = space_id
        # 类型，目录或文件
        # 枚举值:
        # 	FILE: 文件
        # 	FOLDER: 文件夹
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_id is not None:
            result['appId'] = self.app_id
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
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
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
        # 分页游标
        # 不为空表示有更多数据
        self.next_token = next_token
        # 回收项列表
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
        body: ListRecycleItemsResponseBody = None,
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
            temp_model = ListRecycleItemsResponseBody()
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
        # 文件(夹)名称冲突策略
        # 枚举值:
        # 	AUTO_RENAME: 自动重命名
        # 	OVERWRITE: 覆盖
        # 	RETURN_DENTRY_IF_EXISTS: 返回已存在文件
        # 	RETURN_ERROR_IF_EXISTS: 文件已存在时报错
        # 默认值:
        # 	AUTO_RENAME
        self.conflict_strategy = conflict_strategy
        # 移动后，是否保留权限
        # 默认值:
        # 	false
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
        # 可选参数
        self.option = option
        # 目标文件夹ID
        self.target_folder_id = target_folder_id
        # 目标文件(夹)空间id
        self.target_space_id = target_space_id
        # 用户id
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
        # 文件是否只读
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
        # 在特定应用上的属性。key是微应用Id, value是属性列表。
        # 可以通过修改DentryAppProperty里的scope来设置属性的可见性
        self.app_properties = app_properties
        # 创建时间
        self.create_time = create_time
        # 创建者id
        self.creator_id = creator_id
        # 后缀
        self.extension = extension
        # id
        self.id = id
        # 修改时间
        self.modified_time = modified_time
        # 修改者id
        self.modifier_id = modifier_id
        # 名称
        self.name = name
        # 父目录id, 根目录id值为0
        # 空值代表根目录的parentId不存在
        self.parent_id = parent_id
        # 存储分区，目前包括公有云OSS存储分区和专属Mini OSS存储分区
        # 枚举值:
        # 	PUBLIC_OSS_PARTITION: 公有云OSS存储分区
        # 	MINI_OSS_PARTITION: 专属Mini OSS存储分区
        self.partition_type = partition_type
        # 路径
        self.path = path
        # 属性
        self.properties = properties
        # 大小
        self.size = size
        # 所在空间id
        self.space_id = space_id
        # 状态
        # 枚举值:
        # 	NORMAL: 正常
        # 	DELETED: 已删除
        # 	EXPIRED: 已过期
        self.status = status
        # 驱动类型
        # 枚举值:
        # 	DINGTALK: 钉钉统一存储驱动
        # 	ALIDOC: 钉钉文档存储驱动
        # 	UNKNOWN: 未知驱动
        self.storage_driver = storage_driver
        # 类型，目录或文件
        # 枚举值:
        # 	FILE: 文件
        # 	FOLDER: 文件夹
        self.type = type
        # uuid，如移动文件，此字段不变
        self.uuid = uuid
        # 版本
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
        # 是否是异步任务
        # 如果操作对象有子节点，则会异步处理
        self.async_ = async_
        # 文件信息
        self.dentry = dentry
        # 任务Id，用于查询任务执行状态; 查询接口开发中
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
        body: MoveDentryResponseBody = None,
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
            temp_model = MoveDentryResponseBody()
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
        # 名称, 规则：
        # 1. 头尾不能包含空格，否则会自动去除
        # 2. 不能包含特殊字符，包括：制表符、*、"、<、>、|
        # 3. 不能以"."结尾
        self.new_name = new_name
        # 用户id
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
        # 文件是否只读
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
        # 在特定应用上的属性。key是微应用Id, value是属性列表。
        # 可以通过修改DentryAppProperty里的scope来设置属性的可见性
        self.app_properties = app_properties
        # 创建时间
        self.create_time = create_time
        # 创建者id
        self.creator_id = creator_id
        # 后缀
        self.extension = extension
        # id
        self.id = id
        # 修改时间
        self.modified_time = modified_time
        # 修改者id
        self.modifier_id = modifier_id
        # 名称
        self.name = name
        # 父目录id, 根目录id值为0
        # 空值代表根目录的parentId不存在
        self.parent_id = parent_id
        # 存储分区，目前包括公有云OSS存储分区和专属Mini OSS存储分区
        # 枚举值:
        # 	PUBLIC_OSS_PARTITION: 公有云OSS存储分区
        # 	MINI_OSS_PARTITION: 专属Mini OSS存储分区
        self.partition_type = partition_type
        # 路径
        self.path = path
        # 属性
        self.properties = properties
        # 大小
        self.size = size
        # 所在空间id
        self.space_id = space_id
        # 状态
        # 枚举值:
        # 	NORMAL: 正常
        # 	DELETED: 已删除
        # 	EXPIRED: 已过期
        self.status = status
        # 驱动类型
        # 枚举值:
        # 	DINGTALK: 钉钉统一存储驱动
        # 	ALIDOC: 钉钉文档存储驱动
        # 	UNKNOWN: 未知驱动
        self.storage_driver = storage_driver
        # 类型，目录或文件
        # 枚举值:
        # 	FILE: 文件
        # 	FOLDER: 文件夹
        self.type = type
        # uuid，如移动文件，此字段不变
        self.uuid = uuid
        # 版本
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
        # 文件信息
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
        body: RenameDentryResponseBody = None,
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
        # 文件名称冲突策略
        # 还原时原路径可能已经存在同名的文件
        # 枚举值:
        # 	AUTO_RENAME: 自动重命名
        # 	OVERWRITE: 覆盖
        # 	RETURN_DENTRY_IF_EXISTS: 返回已存在文件
        # 	RETURN_ERROR_IF_EXISTS: 文件已存在时报错
        # 默认值:
        # 	AUTO_RENAME
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
        # 可选参数
        self.option = option
        # 用户id
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
        success: bool = None,
    ):
        # 本次操作是否成功
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


class RestoreRecycleItemResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: RestoreRecycleItemResponseBody = None,
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
            temp_model = RestoreRecycleItemResponseBody()
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
        # 用户id
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
        # 本次操作是否成功
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
        body: RevertDentryVersionResponseBody = None,
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
            temp_model = RevertDentryVersionResponseBody()
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
        # 属性名称 该属性名称在当前app下需要保证唯一，不同app间同名属性互不影响
        self.name = name
        # 属性值
        self.value = value
        # 属性可见范围
        # 枚举值:
        # 	PUBLIC: 该属性所有App可见
        # 	PRIVATE: 该属性仅其归属App可见
        # 默认值:
        # 	PRIVATE
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
        # App属性列表 属性不存在时则新增，存在则覆盖原值
        self.app_properties = app_properties
        # 用户id
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
        # 本次操作是否成功
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
        body: UpdateDentryAppPropertiesResponseBody = None,
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
            temp_model = UpdateDentryAppPropertiesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


