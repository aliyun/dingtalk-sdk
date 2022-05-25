# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import List, Dict


class DentryOpenVOCreator(TeaModel):
    def __init__(
        self,
        name: str = None,
        union_id: str = None,
    ):
        # 用户名称。
        self.name = name
        # 用户unionId。
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class DentryOpenVOUpdater(TeaModel):
    def __init__(
        self,
        name: str = None,
        union_id: str = None,
    ):
        # 用户名称。
        self.name = name
        # 用户unionId。
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class DentryOpenVOVisitorInfo(TeaModel):
    def __init__(
        self,
        dentry_actions: List[str] = None,
        space_actions: List[str] = None,
    ):
        # 节点的操作列表。
        self.dentry_actions = dentry_actions
        # 空间的操作列表。
        self.space_actions = space_actions

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dentry_actions is not None:
            result['dentryActions'] = self.dentry_actions
        if self.space_actions is not None:
            result['spaceActions'] = self.space_actions
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentryActions') is not None:
            self.dentry_actions = m.get('dentryActions')
        if m.get('spaceActions') is not None:
            self.space_actions = m.get('spaceActions')
        return self


class LinkSourceInfoIconUrl(TeaModel):
    def __init__(
        self,
        line: str = None,
        small: str = None,
    ):
        # 默认的目录树图标。
        self.line = line
        # 被选中时的加深图标。
        self.small = small

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.line is not None:
            result['line'] = self.line
        if self.small is not None:
            result['small'] = self.small
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('line') is not None:
            self.line = m.get('line')
        if m.get('small') is not None:
            self.small = m.get('small')
        return self


class LinkSourceInfo(TeaModel):
    def __init__(
        self,
        extension: str = None,
        icon_url: LinkSourceInfoIconUrl = None,
        id: str = None,
        link_type: int = None,
        space_id: str = None,
    ):
        # 快捷方式关联的源文件后缀。
        self.extension = extension
        # 非通用快捷方式的图标信息。
        self.icon_url = icon_url
        # 快捷方式关联的源文件ID（空间内唯一）。
        self.id = id
        # 快捷方式类型。0-通用快捷方式；1-闪会快捷方式；2-日志快捷方式；3-闪会2.0快捷方式。
        self.link_type = link_type
        # 快捷方式关联的源文件所属空间id。
        self.space_id = space_id

    def validate(self):
        if self.icon_url:
            self.icon_url.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.extension is not None:
            result['extension'] = self.extension
        if self.icon_url is not None:
            result['iconUrl'] = self.icon_url.to_map()
        if self.id is not None:
            result['id'] = self.id
        if self.link_type is not None:
            result['linkType'] = self.link_type
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('iconUrl') is not None:
            temp_model = LinkSourceInfoIconUrl()
            self.icon_url = temp_model.from_map(m['iconUrl'])
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('linkType') is not None:
            self.link_type = m.get('linkType')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        return self


class SpaceOpenVOOwner(TeaModel):
    def __init__(
        self,
        name: str = None,
        union_id: str = None,
    ):
        # 用户名称。
        self.name = name
        # 用户unionId。
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class SpaceOpenVOVisitorInfo(TeaModel):
    def __init__(
        self,
        dentry_actions: List[str] = None,
        space_actions: List[str] = None,
    ):
        # 节点的操作列表。
        self.dentry_actions = dentry_actions
        # 空间的操作列表。
        self.space_actions = space_actions

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dentry_actions is not None:
            result['dentryActions'] = self.dentry_actions
        if self.space_actions is not None:
            result['spaceActions'] = self.space_actions
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentryActions') is not None:
            self.dentry_actions = m.get('dentryActions')
        if m.get('spaceActions') is not None:
            self.space_actions = m.get('spaceActions')
        return self


class SpaceOpenVO(TeaModel):
    def __init__(
        self,
        id: str = None,
        name: str = None,
        owner: SpaceOpenVOOwner = None,
        visitor_info: SpaceOpenVOVisitorInfo = None,
    ):
        # 知识库id。
        self.id = id
        # 知识库名称。
        self.name = name
        # 知识库所有者。
        self.owner = owner
        # 访问者对当前知识库的权限等信息。
        self.visitor_info = visitor_info

    def validate(self):
        if self.owner:
            self.owner.validate()
        if self.visitor_info:
            self.visitor_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.owner is not None:
            result['owner'] = self.owner.to_map()
        if self.visitor_info is not None:
            result['visitorInfo'] = self.visitor_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('owner') is not None:
            temp_model = SpaceOpenVOOwner()
            self.owner = temp_model.from_map(m['owner'])
        if m.get('visitorInfo') is not None:
            temp_model = SpaceOpenVOVisitorInfo()
            self.visitor_info = temp_model.from_map(m['visitorInfo'])
        return self


class DentryOpenVO(TeaModel):
    def __init__(
        self,
        content_type: str = None,
        created_time: int = None,
        creator: DentryOpenVOCreator = None,
        dentry_id: str = None,
        dentry_type: str = None,
        dentry_uuid: str = None,
        extension: str = None,
        has_children: bool = None,
        link_source_info: LinkSourceInfo = None,
        name: str = None,
        space: SpaceOpenVO = None,
        space_id: str = None,
        updated_time: int = None,
        updater: DentryOpenVOUpdater = None,
        visitor_info: DentryOpenVOVisitorInfo = None,
    ):
        # 内容类型。alidoc-钉钉文档；link-快捷方式；archive-压缩包。
        self.content_type = content_type
        # 创建时间。
        self.created_time = created_time
        # 创建者。
        self.creator = creator
        # 节点id。
        self.dentry_id = dentry_id
        # 节点类型。file-文件；folder-文件夹。
        self.dentry_type = dentry_type
        # 节点全局唯一标识id。
        self.dentry_uuid = dentry_uuid
        # 文件后缀名。
        self.extension = extension
        # 是否有子节点。
        self.has_children = has_children
        # 快捷方式类型的节点，其指向的原始数据信息。
        self.link_source_info = link_source_info
        # 节点名称。
        self.name = name
        # 知识库信息。
        self.space = space
        # 知识库id。
        self.space_id = space_id
        # 更新时间。
        self.updated_time = updated_time
        # 更新人。
        self.updater = updater
        # 访问者对当前节点的权限等信息。
        self.visitor_info = visitor_info

    def validate(self):
        if self.creator:
            self.creator.validate()
        if self.link_source_info:
            self.link_source_info.validate()
        if self.space:
            self.space.validate()
        if self.updater:
            self.updater.validate()
        if self.visitor_info:
            self.visitor_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content_type is not None:
            result['contentType'] = self.content_type
        if self.created_time is not None:
            result['createdTime'] = self.created_time
        if self.creator is not None:
            result['creator'] = self.creator.to_map()
        if self.dentry_id is not None:
            result['dentryId'] = self.dentry_id
        if self.dentry_type is not None:
            result['dentryType'] = self.dentry_type
        if self.dentry_uuid is not None:
            result['dentryUuid'] = self.dentry_uuid
        if self.extension is not None:
            result['extension'] = self.extension
        if self.has_children is not None:
            result['hasChildren'] = self.has_children
        if self.link_source_info is not None:
            result['linkSourceInfo'] = self.link_source_info.to_map()
        if self.name is not None:
            result['name'] = self.name
        if self.space is not None:
            result['space'] = self.space.to_map()
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.updated_time is not None:
            result['updatedTime'] = self.updated_time
        if self.updater is not None:
            result['updater'] = self.updater.to_map()
        if self.visitor_info is not None:
            result['visitorInfo'] = self.visitor_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('contentType') is not None:
            self.content_type = m.get('contentType')
        if m.get('createdTime') is not None:
            self.created_time = m.get('createdTime')
        if m.get('creator') is not None:
            temp_model = DentryOpenVOCreator()
            self.creator = temp_model.from_map(m['creator'])
        if m.get('dentryId') is not None:
            self.dentry_id = m.get('dentryId')
        if m.get('dentryType') is not None:
            self.dentry_type = m.get('dentryType')
        if m.get('dentryUuid') is not None:
            self.dentry_uuid = m.get('dentryUuid')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('hasChildren') is not None:
            self.has_children = m.get('hasChildren')
        if m.get('linkSourceInfo') is not None:
            temp_model = LinkSourceInfo()
            self.link_source_info = temp_model.from_map(m['linkSourceInfo'])
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('space') is not None:
            temp_model = SpaceOpenVO()
            self.space = temp_model.from_map(m['space'])
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('updatedTime') is not None:
            self.updated_time = m.get('updatedTime')
        if m.get('updater') is not None:
            temp_model = DentryOpenVOUpdater()
            self.updater = temp_model.from_map(m['updater'])
        if m.get('visitorInfo') is not None:
            temp_model = DentryOpenVOVisitorInfo()
            self.visitor_info = temp_model.from_map(m['visitorInfo'])
        return self


class DentryOpenVOResultCreator(TeaModel):
    def __init__(
        self,
        name: str = None,
        union_id: str = None,
    ):
        # 用户名称。
        self.name = name
        # 用户unionId。
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class DentryOpenVOResultUpdater(TeaModel):
    def __init__(
        self,
        name: str = None,
        union_id: str = None,
    ):
        # 用户名称。
        self.name = name
        # 用户unionId。
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class DentryOpenVOResultVisitorInfo(TeaModel):
    def __init__(
        self,
        dentry_actions: List[str] = None,
        space_actions: List[str] = None,
    ):
        # 节点的操作列表。
        self.dentry_actions = dentry_actions
        # 空间的操作列表。
        self.space_actions = space_actions

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dentry_actions is not None:
            result['dentryActions'] = self.dentry_actions
        if self.space_actions is not None:
            result['spaceActions'] = self.space_actions
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentryActions') is not None:
            self.dentry_actions = m.get('dentryActions')
        if m.get('spaceActions') is not None:
            self.space_actions = m.get('spaceActions')
        return self


class DentryOpenVOResult(TeaModel):
    def __init__(
        self,
        content_type: str = None,
        created_time: int = None,
        creator: DentryOpenVOResultCreator = None,
        dentry_id: str = None,
        dentry_type: str = None,
        dentry_uuid: str = None,
        extension: str = None,
        has_children: bool = None,
        link_source_info: LinkSourceInfo = None,
        name: str = None,
        space: SpaceOpenVO = None,
        space_id: str = None,
        updated_time: int = None,
        updater: DentryOpenVOResultUpdater = None,
        visitor_info: DentryOpenVOResultVisitorInfo = None,
    ):
        # 内容类型。alidoc-钉钉文档；link-快捷方式；archive-压缩包。
        self.content_type = content_type
        # 创建时间。
        self.created_time = created_time
        # 创建者。
        self.creator = creator
        # 节点id。
        self.dentry_id = dentry_id
        # 节点类型。file-文件；folder-文件夹。
        self.dentry_type = dentry_type
        # 节点全局唯一标识id。
        self.dentry_uuid = dentry_uuid
        # 文件后缀名。
        self.extension = extension
        # 是否有子节点。
        self.has_children = has_children
        # 快捷方式类型的节点，其指向的原始数据信息。
        self.link_source_info = link_source_info
        # 节点名称。
        self.name = name
        # 知识库信息。
        self.space = space
        # 知识库id。
        self.space_id = space_id
        # 更新时间。
        self.updated_time = updated_time
        # 更新人。
        self.updater = updater
        # 访问者对当前节点的权限等信息。
        self.visitor_info = visitor_info

    def validate(self):
        if self.creator:
            self.creator.validate()
        if self.link_source_info:
            self.link_source_info.validate()
        if self.space:
            self.space.validate()
        if self.updater:
            self.updater.validate()
        if self.visitor_info:
            self.visitor_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content_type is not None:
            result['contentType'] = self.content_type
        if self.created_time is not None:
            result['createdTime'] = self.created_time
        if self.creator is not None:
            result['creator'] = self.creator.to_map()
        if self.dentry_id is not None:
            result['dentryId'] = self.dentry_id
        if self.dentry_type is not None:
            result['dentryType'] = self.dentry_type
        if self.dentry_uuid is not None:
            result['dentryUuid'] = self.dentry_uuid
        if self.extension is not None:
            result['extension'] = self.extension
        if self.has_children is not None:
            result['hasChildren'] = self.has_children
        if self.link_source_info is not None:
            result['linkSourceInfo'] = self.link_source_info.to_map()
        if self.name is not None:
            result['name'] = self.name
        if self.space is not None:
            result['space'] = self.space.to_map()
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.updated_time is not None:
            result['updatedTime'] = self.updated_time
        if self.updater is not None:
            result['updater'] = self.updater.to_map()
        if self.visitor_info is not None:
            result['visitorInfo'] = self.visitor_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('contentType') is not None:
            self.content_type = m.get('contentType')
        if m.get('createdTime') is not None:
            self.created_time = m.get('createdTime')
        if m.get('creator') is not None:
            temp_model = DentryOpenVOResultCreator()
            self.creator = temp_model.from_map(m['creator'])
        if m.get('dentryId') is not None:
            self.dentry_id = m.get('dentryId')
        if m.get('dentryType') is not None:
            self.dentry_type = m.get('dentryType')
        if m.get('dentryUuid') is not None:
            self.dentry_uuid = m.get('dentryUuid')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('hasChildren') is not None:
            self.has_children = m.get('hasChildren')
        if m.get('linkSourceInfo') is not None:
            temp_model = LinkSourceInfo()
            self.link_source_info = temp_model.from_map(m['linkSourceInfo'])
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('space') is not None:
            temp_model = SpaceOpenVO()
            self.space = temp_model.from_map(m['space'])
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('updatedTime') is not None:
            self.updated_time = m.get('updatedTime')
        if m.get('updater') is not None:
            temp_model = DentryOpenVOResultUpdater()
            self.updater = temp_model.from_map(m['updater'])
        if m.get('visitorInfo') is not None:
            temp_model = DentryOpenVOResultVisitorInfo()
            self.visitor_info = temp_model.from_map(m['visitorInfo'])
        return self


class SpaceOpenVOResultOwner(TeaModel):
    def __init__(
        self,
        name: str = None,
        union_id: str = None,
    ):
        # 用户名称。
        self.name = name
        # 用户unionId。
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class SpaceOpenVOResultVisitorInfo(TeaModel):
    def __init__(
        self,
        dentry_actions: List[str] = None,
        space_actions: List[str] = None,
    ):
        # 节点的操作列表。
        self.dentry_actions = dentry_actions
        # 空间的操作列表。
        self.space_actions = space_actions

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dentry_actions is not None:
            result['dentryActions'] = self.dentry_actions
        if self.space_actions is not None:
            result['spaceActions'] = self.space_actions
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentryActions') is not None:
            self.dentry_actions = m.get('dentryActions')
        if m.get('spaceActions') is not None:
            self.space_actions = m.get('spaceActions')
        return self


class SpaceOpenVOResult(TeaModel):
    def __init__(
        self,
        id: str = None,
        name: str = None,
        owner: SpaceOpenVOResultOwner = None,
        visitor_info: SpaceOpenVOResultVisitorInfo = None,
    ):
        # 知识库id。
        self.id = id
        # 知识库名称。
        self.name = name
        # 知识库所有者。
        self.owner = owner
        # 访问者对当前知识库的权限等信息。
        self.visitor_info = visitor_info

    def validate(self):
        if self.owner:
            self.owner.validate()
        if self.visitor_info:
            self.visitor_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.owner is not None:
            result['owner'] = self.owner.to_map()
        if self.visitor_info is not None:
            result['visitorInfo'] = self.visitor_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('owner') is not None:
            temp_model = SpaceOpenVOResultOwner()
            self.owner = temp_model.from_map(m['owner'])
        if m.get('visitorInfo') is not None:
            temp_model = SpaceOpenVOResultVisitorInfo()
            self.visitor_info = temp_model.from_map(m['visitorInfo'])
        return self


class CreateDentryHeaders(TeaModel):
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


class CreateDentryRequest(TeaModel):
    def __init__(
        self,
        dentry_type: str = None,
        document_type: int = None,
        name: str = None,
        operator_id: str = None,
        parent_dentry_id: str = None,
    ):
        # 节点类型，file-文档，folder-文件夹。
        self.dentry_type = dentry_type
        # 节点类型为文档才有，0-文字，1-表格，2-PPT，3-白板，6-脑图，7-多维表。
        self.document_type = document_type
        # 节点名称。
        self.name = name
        # 操作人unionId。
        self.operator_id = operator_id
        # 父节点id，可为空。
        self.parent_dentry_id = parent_dentry_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dentry_type is not None:
            result['dentryType'] = self.dentry_type
        if self.document_type is not None:
            result['documentType'] = self.document_type
        if self.name is not None:
            result['name'] = self.name
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.parent_dentry_id is not None:
            result['parentDentryId'] = self.parent_dentry_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentryType') is not None:
            self.dentry_type = m.get('dentryType')
        if m.get('documentType') is not None:
            self.document_type = m.get('documentType')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('parentDentryId') is not None:
            self.parent_dentry_id = m.get('parentDentryId')
        return self


class CreateDentryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DentryOpenVOResult = None,
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
            temp_model = DentryOpenVOResult()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSpaceDirectoriesHeaders(TeaModel):
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


class GetSpaceDirectoriesRequest(TeaModel):
    def __init__(
        self,
        dentry_id: str = None,
        max_results: int = None,
        next_token: str = None,
        operator_id: str = None,
    ):
        # 知识库节点id。
        self.dentry_id = dentry_id
        # 查询数量，最大500。
        self.max_results = max_results
        # 分页token，第一页可不传。
        self.next_token = next_token
        # 操作用户unionId。
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dentry_id is not None:
            result['dentryId'] = self.dentry_id
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentryId') is not None:
            self.dentry_id = m.get('dentryId')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class GetSpaceDirectoriesResponseBody(TeaModel):
    def __init__(
        self,
        children: List[DentryOpenVO] = None,
        has_more: bool = None,
        next_token: str = None,
    ):
        # 子节点列表。
        self.children = children
        # 是否还有后续可查询子节点。
        self.has_more = has_more
        # 分页token。
        self.next_token = next_token

    def validate(self):
        if self.children:
            for k in self.children:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['children'] = []
        if self.children is not None:
            for k in self.children:
                result['children'].append(k.to_map() if k else None)
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.children = []
        if m.get('children') is not None:
            for k in m.get('children'):
                temp_model = DentryOpenVO()
                self.children.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetSpaceDirectoriesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetSpaceDirectoriesResponseBody = None,
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
            temp_model = GetSpaceDirectoriesResponseBody()
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


class MoveDentryRequest(TeaModel):
    def __init__(
        self,
        operator_id: str = None,
        target_space_id: str = None,
        to_next_dentry_id: str = None,
        to_parent_dentry_id: str = None,
        to_prev_dentry_id: str = None,
    ):
        # 操作人unionId。
        self.operator_id = operator_id
        # 需要移动到的知识库id。
        self.target_space_id = target_space_id
        # 移动到目标位置的后置节点id。不为空时，需要是归属于 toParentDentryId 的子节点。
        self.to_next_dentry_id = to_next_dentry_id
        # 需要移动到目标位置的父节点id。如果为根目录，则不传；如果为非根目录，则需要传对应的id。
        self.to_parent_dentry_id = to_parent_dentry_id
        # 移动到目标位置的前置节点id。不为空时，需要是归属于 toParentDentryId 的子节点。
        self.to_prev_dentry_id = to_prev_dentry_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.target_space_id is not None:
            result['targetSpaceId'] = self.target_space_id
        if self.to_next_dentry_id is not None:
            result['toNextDentryId'] = self.to_next_dentry_id
        if self.to_parent_dentry_id is not None:
            result['toParentDentryId'] = self.to_parent_dentry_id
        if self.to_prev_dentry_id is not None:
            result['toPrevDentryId'] = self.to_prev_dentry_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('targetSpaceId') is not None:
            self.target_space_id = m.get('targetSpaceId')
        if m.get('toNextDentryId') is not None:
            self.to_next_dentry_id = m.get('toNextDentryId')
        if m.get('toParentDentryId') is not None:
            self.to_parent_dentry_id = m.get('toParentDentryId')
        if m.get('toPrevDentryId') is not None:
            self.to_prev_dentry_id = m.get('toPrevDentryId')
        return self


class MoveDentryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DentryOpenVOResult = None,
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
            temp_model = DentryOpenVOResult()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryDentryHeaders(TeaModel):
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


class QueryDentryRequest(TeaModel):
    def __init__(
        self,
        include_space: bool = None,
        operator_id: str = None,
    ):
        # 是否查询知识库信息。
        self.include_space = include_space
        # 操作用户unionId。
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.include_space is not None:
            result['includeSpace'] = self.include_space
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('includeSpace') is not None:
            self.include_space = m.get('includeSpace')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class QueryDentryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DentryOpenVOResult = None,
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
            temp_model = DentryOpenVOResult()
            self.body = temp_model.from_map(m['body'])
        return self


class QuerySpaceHeaders(TeaModel):
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


class QuerySpaceRequest(TeaModel):
    def __init__(
        self,
        operator_id: str = None,
    ):
        # 操作用户unionId。
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


class QuerySpaceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SpaceOpenVOResult = None,
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
            temp_model = SpaceOpenVOResult()
            self.body = temp_model.from_map(m['body'])
        return self


