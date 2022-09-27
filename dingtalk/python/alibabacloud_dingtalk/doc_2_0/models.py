# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import List, Dict


class DentryModelCreator(TeaModel):
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


class DentryModelUpdater(TeaModel):
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


class DentryModelVisitorInfo(TeaModel):
    def __init__(
        self,
        dentry_actions: List[str] = None,
        role_code: str = None,
        space_actions: List[str] = None,
    ):
        # 节点的操作列表。
        self.dentry_actions = dentry_actions
        # 当前用户对这个空间的访问角色。
        self.role_code = role_code
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
        if self.role_code is not None:
            result['roleCode'] = self.role_code
        if self.space_actions is not None:
            result['spaceActions'] = self.space_actions
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentryActions') is not None:
            self.dentry_actions = m.get('dentryActions')
        if m.get('roleCode') is not None:
            self.role_code = m.get('roleCode')
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


class SpaceModelIconVO(TeaModel):
    def __init__(
        self,
        icon: str = None,
        type: str = None,
    ):
        # 图标
        self.icon = icon
        # 图标类型
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.icon is not None:
            result['icon'] = self.icon
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class SpaceModelOwner(TeaModel):
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


class SpaceModelVisitorInfo(TeaModel):
    def __init__(
        self,
        dentry_actions: List[str] = None,
        role_code: str = None,
        space_actions: List[str] = None,
    ):
        # 节点的操作列表。
        self.dentry_actions = dentry_actions
        # 权限
        self.role_code = role_code
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
        if self.role_code is not None:
            result['roleCode'] = self.role_code
        if self.space_actions is not None:
            result['spaceActions'] = self.space_actions
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentryActions') is not None:
            self.dentry_actions = m.get('dentryActions')
        if m.get('roleCode') is not None:
            self.role_code = m.get('roleCode')
        if m.get('spaceActions') is not None:
            self.space_actions = m.get('spaceActions')
        return self


class SpaceModel(TeaModel):
    def __init__(
        self,
        cover: str = None,
        description: str = None,
        icon_vo: SpaceModelIconVO = None,
        id: str = None,
        name: str = None,
        owner: SpaceModelOwner = None,
        recent_list: List[DentryModel] = None,
        type: int = None,
        url: str = None,
        visitor_info: SpaceModelVisitorInfo = None,
    ):
        # 封面
        self.cover = cover
        # 空间描述信息
        self.description = description
        # 知识库图标
        self.icon_vo = icon_vo
        # 知识库id。
        self.id = id
        # 知识库名称。
        self.name = name
        # 知识库所有者。
        self.owner = owner
        # 知识库中最近编辑的三篇文档。
        self.recent_list = recent_list
        # 知识库类型。
        self.type = type
        # 知识库访问url。
        self.url = url
        # 访问者对当前知识库的权限等信息。
        self.visitor_info = visitor_info

    def validate(self):
        if self.icon_vo:
            self.icon_vo.validate()
        if self.owner:
            self.owner.validate()
        if self.recent_list:
            for k in self.recent_list:
                if k:
                    k.validate()
        if self.visitor_info:
            self.visitor_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cover is not None:
            result['cover'] = self.cover
        if self.description is not None:
            result['description'] = self.description
        if self.icon_vo is not None:
            result['iconVO'] = self.icon_vo.to_map()
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.owner is not None:
            result['owner'] = self.owner.to_map()
        result['recentList'] = []
        if self.recent_list is not None:
            for k in self.recent_list:
                result['recentList'].append(k.to_map() if k else None)
        if self.type is not None:
            result['type'] = self.type
        if self.url is not None:
            result['url'] = self.url
        if self.visitor_info is not None:
            result['visitorInfo'] = self.visitor_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cover') is not None:
            self.cover = m.get('cover')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('iconVO') is not None:
            temp_model = SpaceModelIconVO()
            self.icon_vo = temp_model.from_map(m['iconVO'])
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('owner') is not None:
            temp_model = SpaceModelOwner()
            self.owner = temp_model.from_map(m['owner'])
        self.recent_list = []
        if m.get('recentList') is not None:
            for k in m.get('recentList'):
                temp_model = DentryModel()
                self.recent_list.append(temp_model.from_map(k))
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('visitorInfo') is not None:
            temp_model = SpaceModelVisitorInfo()
            self.visitor_info = temp_model.from_map(m['visitorInfo'])
        return self


class DentryModel(TeaModel):
    def __init__(
        self,
        content_type: str = None,
        created_time: int = None,
        creator: DentryModelCreator = None,
        dentry_id: str = None,
        dentry_type: str = None,
        dentry_uuid: str = None,
        doc_key: str = None,
        extension: str = None,
        has_children: bool = None,
        link_source_info: LinkSourceInfo = None,
        name: str = None,
        path: str = None,
        space: SpaceModel = None,
        space_id: str = None,
        updated_time: int = None,
        updater: DentryModelUpdater = None,
        url: str = None,
        visitor_info: DentryModelVisitorInfo = None,
    ):
        # 内容类型。alidoc-钉钉文档；link-快捷方式；archive-压缩包；document-文件。
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
        # 文档docKey，用于标识一篇钉钉文档的key。只有内容类型为alidoc的才会有值。
        self.doc_key = doc_key
        # 文件后缀名。
        self.extension = extension
        # 是否有子节点。
        self.has_children = has_children
        # 快捷方式类型的节点，其指向的原始数据信息。
        self.link_source_info = link_source_info
        # 节点名称。
        self.name = name
        # 节点的路径。
        self.path = path
        # 知识库信息。
        self.space = space
        # 知识库id。
        self.space_id = space_id
        # 更新时间。
        self.updated_time = updated_time
        # 更新人。
        self.updater = updater
        # 节点访问url。
        self.url = url
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
        if self.doc_key is not None:
            result['docKey'] = self.doc_key
        if self.extension is not None:
            result['extension'] = self.extension
        if self.has_children is not None:
            result['hasChildren'] = self.has_children
        if self.link_source_info is not None:
            result['linkSourceInfo'] = self.link_source_info.to_map()
        if self.name is not None:
            result['name'] = self.name
        if self.path is not None:
            result['path'] = self.path
        if self.space is not None:
            result['space'] = self.space.to_map()
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.updated_time is not None:
            result['updatedTime'] = self.updated_time
        if self.updater is not None:
            result['updater'] = self.updater.to_map()
        if self.url is not None:
            result['url'] = self.url
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
            temp_model = DentryModelCreator()
            self.creator = temp_model.from_map(m['creator'])
        if m.get('dentryId') is not None:
            self.dentry_id = m.get('dentryId')
        if m.get('dentryType') is not None:
            self.dentry_type = m.get('dentryType')
        if m.get('dentryUuid') is not None:
            self.dentry_uuid = m.get('dentryUuid')
        if m.get('docKey') is not None:
            self.doc_key = m.get('docKey')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('hasChildren') is not None:
            self.has_children = m.get('hasChildren')
        if m.get('linkSourceInfo') is not None:
            temp_model = LinkSourceInfo()
            self.link_source_info = temp_model.from_map(m['linkSourceInfo'])
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('path') is not None:
            self.path = m.get('path')
        if m.get('space') is not None:
            temp_model = SpaceModel()
            self.space = temp_model.from_map(m['space'])
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('updatedTime') is not None:
            self.updated_time = m.get('updatedTime')
        if m.get('updater') is not None:
            temp_model = DentryModelUpdater()
            self.updater = temp_model.from_map(m['updater'])
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('visitorInfo') is not None:
            temp_model = DentryModelVisitorInfo()
            self.visitor_info = temp_model.from_map(m['visitorInfo'])
        return self


class DentryVOCreator(TeaModel):
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


class DentryVOUpdater(TeaModel):
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


class DentryVOVisitorInfo(TeaModel):
    def __init__(
        self,
        dentry_actions: List[str] = None,
        role_code: str = None,
        space_actions: List[str] = None,
    ):
        # 节点的操作列表。
        self.dentry_actions = dentry_actions
        # 当前用户对这个空间的访问角色。
        self.role_code = role_code
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
        if self.role_code is not None:
            result['roleCode'] = self.role_code
        if self.space_actions is not None:
            result['spaceActions'] = self.space_actions
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentryActions') is not None:
            self.dentry_actions = m.get('dentryActions')
        if m.get('roleCode') is not None:
            self.role_code = m.get('roleCode')
        if m.get('spaceActions') is not None:
            self.space_actions = m.get('spaceActions')
        return self


class DentryVO(TeaModel):
    def __init__(
        self,
        content_type: str = None,
        created_time: int = None,
        creator: DentryVOCreator = None,
        dentry_id: str = None,
        dentry_type: str = None,
        dentry_uuid: str = None,
        doc_key: str = None,
        extension: str = None,
        has_children: bool = None,
        link_source_info: LinkSourceInfo = None,
        name: str = None,
        path: str = None,
        space: SpaceModel = None,
        space_id: str = None,
        updated_time: int = None,
        updater: DentryVOUpdater = None,
        url: str = None,
        visitor_info: DentryVOVisitorInfo = None,
    ):
        # 内容类型。alidoc-钉钉文档；link-快捷方式；archive-压缩包；document-文件。
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
        # 文档docKey，用于标识一篇钉钉文档的key。只有内容类型为alidoc的才会有值。
        self.doc_key = doc_key
        # 文件后缀名。
        self.extension = extension
        # 是否有子节点。
        self.has_children = has_children
        # 快捷方式类型的节点，其指向的原始数据信息。
        self.link_source_info = link_source_info
        # 节点名称。
        self.name = name
        # 节点的路径。
        self.path = path
        # 知识库信息。
        self.space = space
        # 知识库id。
        self.space_id = space_id
        # 更新时间。
        self.updated_time = updated_time
        # 更新人。
        self.updater = updater
        # 节点访问url。
        self.url = url
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
        if self.doc_key is not None:
            result['docKey'] = self.doc_key
        if self.extension is not None:
            result['extension'] = self.extension
        if self.has_children is not None:
            result['hasChildren'] = self.has_children
        if self.link_source_info is not None:
            result['linkSourceInfo'] = self.link_source_info.to_map()
        if self.name is not None:
            result['name'] = self.name
        if self.path is not None:
            result['path'] = self.path
        if self.space is not None:
            result['space'] = self.space.to_map()
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.updated_time is not None:
            result['updatedTime'] = self.updated_time
        if self.updater is not None:
            result['updater'] = self.updater.to_map()
        if self.url is not None:
            result['url'] = self.url
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
            temp_model = DentryVOCreator()
            self.creator = temp_model.from_map(m['creator'])
        if m.get('dentryId') is not None:
            self.dentry_id = m.get('dentryId')
        if m.get('dentryType') is not None:
            self.dentry_type = m.get('dentryType')
        if m.get('dentryUuid') is not None:
            self.dentry_uuid = m.get('dentryUuid')
        if m.get('docKey') is not None:
            self.doc_key = m.get('docKey')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('hasChildren') is not None:
            self.has_children = m.get('hasChildren')
        if m.get('linkSourceInfo') is not None:
            temp_model = LinkSourceInfo()
            self.link_source_info = temp_model.from_map(m['linkSourceInfo'])
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('path') is not None:
            self.path = m.get('path')
        if m.get('space') is not None:
            temp_model = SpaceModel()
            self.space = temp_model.from_map(m['space'])
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('updatedTime') is not None:
            self.updated_time = m.get('updatedTime')
        if m.get('updater') is not None:
            temp_model = DentryVOUpdater()
            self.updater = temp_model.from_map(m['updater'])
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('visitorInfo') is not None:
            temp_model = DentryVOVisitorInfo()
            self.visitor_info = temp_model.from_map(m['visitorInfo'])
        return self


class OpenActionModel(TeaModel):
    def __init__(
        self,
        name: str = None,
        timestamp: int = None,
    ):
        # 操作人名称。
        self.name = name
        # 操作时间戳。
        self.timestamp = timestamp

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        return self


class SpaceVOIconVO(TeaModel):
    def __init__(
        self,
        icon: str = None,
        type: str = None,
    ):
        # 图标
        self.icon = icon
        # 图标类型
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.icon is not None:
            result['icon'] = self.icon
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class SpaceVOOwner(TeaModel):
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


class SpaceVOVisitorInfo(TeaModel):
    def __init__(
        self,
        dentry_actions: List[str] = None,
        role_code: str = None,
        space_actions: List[str] = None,
    ):
        # 节点的操作列表。
        self.dentry_actions = dentry_actions
        # 权限
        self.role_code = role_code
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
        if self.role_code is not None:
            result['roleCode'] = self.role_code
        if self.space_actions is not None:
            result['spaceActions'] = self.space_actions
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentryActions') is not None:
            self.dentry_actions = m.get('dentryActions')
        if m.get('roleCode') is not None:
            self.role_code = m.get('roleCode')
        if m.get('spaceActions') is not None:
            self.space_actions = m.get('spaceActions')
        return self


class SpaceVO(TeaModel):
    def __init__(
        self,
        cover: str = None,
        description: str = None,
        icon_vo: SpaceVOIconVO = None,
        id: str = None,
        name: str = None,
        owner: SpaceVOOwner = None,
        type: int = None,
        url: str = None,
        visitor_info: SpaceVOVisitorInfo = None,
    ):
        # 封面
        self.cover = cover
        # 访问者对当前知识库的权限等信息
        self.description = description
        # 知识库图标
        self.icon_vo = icon_vo
        # 知识库id。
        self.id = id
        # 知识库名称。
        self.name = name
        # 知识库所有者。
        self.owner = owner
        # 知识库类型。
        self.type = type
        # 知识库访问url。
        self.url = url
        # 访问者对当前知识库的权限等信息。
        self.visitor_info = visitor_info

    def validate(self):
        if self.icon_vo:
            self.icon_vo.validate()
        if self.owner:
            self.owner.validate()
        if self.visitor_info:
            self.visitor_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cover is not None:
            result['cover'] = self.cover
        if self.description is not None:
            result['description'] = self.description
        if self.icon_vo is not None:
            result['iconVO'] = self.icon_vo.to_map()
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.owner is not None:
            result['owner'] = self.owner.to_map()
        if self.type is not None:
            result['type'] = self.type
        if self.url is not None:
            result['url'] = self.url
        if self.visitor_info is not None:
            result['visitorInfo'] = self.visitor_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cover') is not None:
            self.cover = m.get('cover')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('iconVO') is not None:
            temp_model = SpaceVOIconVO()
            self.icon_vo = temp_model.from_map(m['iconVO'])
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('owner') is not None:
            temp_model = SpaceVOOwner()
            self.owner = temp_model.from_map(m['owner'])
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('visitorInfo') is not None:
            temp_model = SpaceVOVisitorInfo()
            self.visitor_info = temp_model.from_map(m['visitorInfo'])
        return self


class TeamModelCreator(TeaModel):
    def __init__(
        self,
        name: str = None,
        union_id: str = None,
    ):
        # 名字
        self.name = name
        # unionId
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


class TeamModelRelatedDeptInfo(TeaModel):
    def __init__(
        self,
        dept_id: str = None,
        dept_name: str = None,
    ):
        # 部门id
        self.dept_id = dept_id
        # 部门名称
        self.dept_name = dept_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        return self


class TeamModelUpdater(TeaModel):
    def __init__(
        self,
        name: str = None,
        union_id: str = None,
    ):
        # 名字
        self.name = name
        # unionId
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


class TeamModelVisitInfo(TeaModel):
    def __init__(
        self,
        role_code: str = None,
    ):
        # 用户对这个团队的访问情况
        self.role_code = role_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.role_code is not None:
            result['roleCode'] = self.role_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('roleCode') is not None:
            self.role_code = m.get('roleCode')
        return self


class TeamModel(TeaModel):
    def __init__(
        self,
        cover: str = None,
        created_time: int = None,
        creator: TeamModelCreator = None,
        description: str = None,
        icon: str = None,
        id: str = None,
        name: str = None,
        related_dept_info: TeamModelRelatedDeptInfo = None,
        status: int = None,
        type: int = None,
        updated_time: int = None,
        updater: TeamModelUpdater = None,
        url: str = None,
        visit_info: TeamModelVisitInfo = None,
    ):
        # 封面
        self.cover = cover
        # 创建时间
        self.created_time = created_time
        # 创建人
        self.creator = creator
        # 团队描述
        self.description = description
        # 图标
        self.icon = icon
        # 团队ID
        self.id = id
        # 团队名称
        self.name = name
        # 关联部门信息
        self.related_dept_info = related_dept_info
        # 团队状态
        self.status = status
        # 团队类型
        self.type = type
        # 更新时间
        self.updated_time = updated_time
        # 更新人
        self.updater = updater
        # 团队链接
        self.url = url
        # 用户对这个团队的访问情况
        self.visit_info = visit_info

    def validate(self):
        if self.creator:
            self.creator.validate()
        if self.related_dept_info:
            self.related_dept_info.validate()
        if self.updater:
            self.updater.validate()
        if self.visit_info:
            self.visit_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cover is not None:
            result['cover'] = self.cover
        if self.created_time is not None:
            result['createdTime'] = self.created_time
        if self.creator is not None:
            result['creator'] = self.creator.to_map()
        if self.description is not None:
            result['description'] = self.description
        if self.icon is not None:
            result['icon'] = self.icon
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.related_dept_info is not None:
            result['relatedDeptInfo'] = self.related_dept_info.to_map()
        if self.status is not None:
            result['status'] = self.status
        if self.type is not None:
            result['type'] = self.type
        if self.updated_time is not None:
            result['updatedTime'] = self.updated_time
        if self.updater is not None:
            result['updater'] = self.updater.to_map()
        if self.url is not None:
            result['url'] = self.url
        if self.visit_info is not None:
            result['visitInfo'] = self.visit_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cover') is not None:
            self.cover = m.get('cover')
        if m.get('createdTime') is not None:
            self.created_time = m.get('createdTime')
        if m.get('creator') is not None:
            temp_model = TeamModelCreator()
            self.creator = temp_model.from_map(m['creator'])
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('relatedDeptInfo') is not None:
            temp_model = TeamModelRelatedDeptInfo()
            self.related_dept_info = temp_model.from_map(m['relatedDeptInfo'])
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('updatedTime') is not None:
            self.updated_time = m.get('updatedTime')
        if m.get('updater') is not None:
            temp_model = TeamModelUpdater()
            self.updater = temp_model.from_map(m['updater'])
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('visitInfo') is not None:
            temp_model = TeamModelVisitInfo()
            self.visit_info = temp_model.from_map(m['visitInfo'])
        return self


class TeamVOCreator(TeaModel):
    def __init__(
        self,
        name: str = None,
        union_id: str = None,
    ):
        # 名字
        self.name = name
        # unionId
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


class TeamVORelatedDeptInfo(TeaModel):
    def __init__(
        self,
        dept_id: str = None,
        dept_name: str = None,
    ):
        # 部门id
        self.dept_id = dept_id
        # 部门名称
        self.dept_name = dept_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        return self


class TeamVOUpdater(TeaModel):
    def __init__(
        self,
        name: str = None,
        union_id: str = None,
    ):
        # 名字
        self.name = name
        # unionId
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


class TeamVOVisitInfo(TeaModel):
    def __init__(
        self,
        role_code: str = None,
    ):
        # 用户对这个团队的访问情况
        self.role_code = role_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.role_code is not None:
            result['roleCode'] = self.role_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('roleCode') is not None:
            self.role_code = m.get('roleCode')
        return self


class TeamVO(TeaModel):
    def __init__(
        self,
        cover: str = None,
        created_time: int = None,
        creator: TeamVOCreator = None,
        description: str = None,
        icon: str = None,
        id: str = None,
        name: str = None,
        related_dept_info: TeamVORelatedDeptInfo = None,
        status: int = None,
        type: int = None,
        updated_time: int = None,
        updater: TeamVOUpdater = None,
        url: str = None,
        visit_info: TeamVOVisitInfo = None,
    ):
        # 封面
        self.cover = cover
        # 创建时间
        self.created_time = created_time
        # 创建人
        self.creator = creator
        # 团队描述
        self.description = description
        # 图标
        self.icon = icon
        # 团队ID
        self.id = id
        # 团队名称
        self.name = name
        # 关联部门信息
        self.related_dept_info = related_dept_info
        # 团队状态
        self.status = status
        # 团队类型
        self.type = type
        # 更新时间
        self.updated_time = updated_time
        # 更新人
        self.updater = updater
        # 团队链接
        self.url = url
        # 用户对这个团队的访问情况
        self.visit_info = visit_info

    def validate(self):
        if self.creator:
            self.creator.validate()
        if self.related_dept_info:
            self.related_dept_info.validate()
        if self.updater:
            self.updater.validate()
        if self.visit_info:
            self.visit_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cover is not None:
            result['cover'] = self.cover
        if self.created_time is not None:
            result['createdTime'] = self.created_time
        if self.creator is not None:
            result['creator'] = self.creator.to_map()
        if self.description is not None:
            result['description'] = self.description
        if self.icon is not None:
            result['icon'] = self.icon
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.related_dept_info is not None:
            result['relatedDeptInfo'] = self.related_dept_info.to_map()
        if self.status is not None:
            result['status'] = self.status
        if self.type is not None:
            result['type'] = self.type
        if self.updated_time is not None:
            result['updatedTime'] = self.updated_time
        if self.updater is not None:
            result['updater'] = self.updater.to_map()
        if self.url is not None:
            result['url'] = self.url
        if self.visit_info is not None:
            result['visitInfo'] = self.visit_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cover') is not None:
            self.cover = m.get('cover')
        if m.get('createdTime') is not None:
            self.created_time = m.get('createdTime')
        if m.get('creator') is not None:
            temp_model = TeamVOCreator()
            self.creator = temp_model.from_map(m['creator'])
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('relatedDeptInfo') is not None:
            temp_model = TeamVORelatedDeptInfo()
            self.related_dept_info = temp_model.from_map(m['relatedDeptInfo'])
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('updatedTime') is not None:
            self.updated_time = m.get('updatedTime')
        if m.get('updater') is not None:
            temp_model = TeamVOUpdater()
            self.updater = temp_model.from_map(m['updater'])
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('visitInfo') is not None:
            temp_model = TeamVOVisitInfo()
            self.visit_info = temp_model.from_map(m['visitInfo'])
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


class CopyDentryRequest(TeaModel):
    def __init__(
        self,
        name: str = None,
        operator_id: str = None,
        target_space_id: str = None,
        to_next_dentry_id: str = None,
        to_parent_dentry_id: str = None,
        to_prev_dentry_id: str = None,
    ):
        # 拷贝后的文档名称，长度不能超过50。
        self.name = name
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
        if self.name is not None:
            result['name'] = self.name
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
        if m.get('name') is not None:
            self.name = m.get('name')
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


class CopyDentryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DentryVO = None,
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
            temp_model = DentryVO()
            self.body = temp_model.from_map(m['body'])
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
        body: DentryVO = None,
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
            temp_model = DentryVO()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateSpaceHeaders(TeaModel):
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


class CreateSpaceRequestShareScope(TeaModel):
    def __init__(
        self,
        scope: int = None,
    ):
        # 公开范围。
        # 0-仅知识库成员可见；
        # 1-当前组织所有人可见。
        self.scope = scope

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.scope is not None:
            result['scope'] = self.scope
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('scope') is not None:
            self.scope = m.get('scope')
        return self


class CreateSpaceRequest(TeaModel):
    def __init__(
        self,
        description: str = None,
        icon: str = None,
        name: str = None,
        operator_id: str = None,
        section_id: str = None,
        share_scope: CreateSpaceRequestShareScope = None,
        team_id: str = None,
    ):
        # 知识库简介。
        # 最大长度50。
        self.description = description
        # 知识库图标。
        self.icon = icon
        # 知识库名称。
        # 最大长度50。
        self.name = name
        # 操作人unionId。
        self.operator_id = operator_id
        # 知识库分组id。只有选择了所属小组的情况下，才需要设置知识库分组。
        self.section_id = section_id
        # 公开范围。
        self.share_scope = share_scope
        # 所属小组id。
        self.team_id = team_id

    def validate(self):
        if self.share_scope:
            self.share_scope.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        if self.icon is not None:
            result['icon'] = self.icon
        if self.name is not None:
            result['name'] = self.name
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.section_id is not None:
            result['sectionId'] = self.section_id
        if self.share_scope is not None:
            result['shareScope'] = self.share_scope.to_map()
        if self.team_id is not None:
            result['teamId'] = self.team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('sectionId') is not None:
            self.section_id = m.get('sectionId')
        if m.get('shareScope') is not None:
            temp_model = CreateSpaceRequestShareScope()
            self.share_scope = temp_model.from_map(m['shareScope'])
        if m.get('teamId') is not None:
            self.team_id = m.get('teamId')
        return self


class CreateSpaceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SpaceVO = None,
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
            temp_model = SpaceVO()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateTeamHeaders(TeaModel):
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


class CreateTeamRequestMembers(TeaModel):
    def __init__(
        self,
        member_id: str = None,
        member_type: int = None,
        role_code: str = None,
    ):
        # 成员unionId。
        self.member_id = member_id
        # 成员类型。
        # 1-群；2-用户；3-组织；4-部门；5-虚拟组织；6-通讯录角色组。
        self.member_type = member_type
        # 成员角色。
        # 0-无权限；1-只读；2-只读/下载；3-编辑；4-管理员；5-所有者。
        self.role_code = role_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.member_id is not None:
            result['memberId'] = self.member_id
        if self.member_type is not None:
            result['memberType'] = self.member_type
        if self.role_code is not None:
            result['roleCode'] = self.role_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memberId') is not None:
            self.member_id = m.get('memberId')
        if m.get('memberType') is not None:
            self.member_type = m.get('memberType')
        if m.get('roleCode') is not None:
            self.role_code = m.get('roleCode')
        return self


class CreateTeamRequest(TeaModel):
    def __init__(
        self,
        cover: str = None,
        description: str = None,
        icon: str = None,
        members: List[CreateTeamRequestMembers] = None,
        name: str = None,
        operator_id: str = None,
        team_type: int = None,
    ):
        # 小组封面。
        self.cover = cover
        # 小组介绍。
        self.description = description
        # 小组图标。
        self.icon = icon
        # 小组成员列表。
        self.members = members
        # 小组名称。
        self.name = name
        # 操作人unionId。
        self.operator_id = operator_id
        # 小组类型。
        # 0-默认；
        # 1-部门；
        # 2-项目组；
        # 3-兴趣小组。
        self.team_type = team_type

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
        if self.cover is not None:
            result['cover'] = self.cover
        if self.description is not None:
            result['description'] = self.description
        if self.icon is not None:
            result['icon'] = self.icon
        result['members'] = []
        if self.members is not None:
            for k in self.members:
                result['members'].append(k.to_map() if k else None)
        if self.name is not None:
            result['name'] = self.name
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.team_type is not None:
            result['teamType'] = self.team_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cover') is not None:
            self.cover = m.get('cover')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        self.members = []
        if m.get('members') is not None:
            for k in m.get('members'):
                temp_model = CreateTeamRequestMembers()
                self.members.append(temp_model.from_map(k))
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('teamType') is not None:
            self.team_type = m.get('teamType')
        return self


class CreateTeamResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: TeamVO = None,
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
            temp_model = TeamVO()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteTeamHeaders(TeaModel):
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


class DeleteTeamRequest(TeaModel):
    def __init__(
        self,
        operator_id: str = None,
    ):
        # 操作人unionId。
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


class DeleteTeamResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: TeamVO = None,
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
            temp_model = TeamVO()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSchemaHeaders(TeaModel):
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


class GetSchemaRequest(TeaModel):
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


class GetSchemaResponseBody(TeaModel):
    def __init__(
        self,
        revision: int = None,
        value: str = None,
    ):
        # 当前版本。
        self.revision = revision
        # schema内容。
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.revision is not None:
            result['revision'] = self.revision
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('revision') is not None:
            self.revision = m.get('revision')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class GetSchemaResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetSchemaResponseBody = None,
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
            temp_model = GetSchemaResponseBody()
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
        children: List[DentryModel] = None,
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
                temp_model = DentryModel()
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


class GetTeamHeaders(TeaModel):
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


class GetTeamRequest(TeaModel):
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


class GetTeamResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: TeamVO = None,
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
            temp_model = TeamVO()
            self.body = temp_model.from_map(m['body'])
        return self


class GetTotalNumberOfDentriesHeaders(TeaModel):
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


class GetTotalNumberOfDentriesRequest(TeaModel):
    def __init__(
        self,
        include_folder: bool = None,
        operator_id: str = None,
        space_types: str = None,
    ):
        # 是否包含文件夹。默认包含。
        self.include_folder = include_folder
        # 操作用户unionId。
        self.operator_id = operator_id
        # 统计指定的知识库类型。0-我的文档；1-知识库。如果不传，则会统计全部数据。
        self.space_types = space_types

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.include_folder is not None:
            result['includeFolder'] = self.include_folder
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.space_types is not None:
            result['spaceTypes'] = self.space_types
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('includeFolder') is not None:
            self.include_folder = m.get('includeFolder')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('spaceTypes') is not None:
            self.space_types = m.get('spaceTypes')
        return self


class GetTotalNumberOfDentriesResponseBody(TeaModel):
    def __init__(
        self,
        dentries_count: str = None,
    ):
        self.dentries_count = dentries_count

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dentries_count is not None:
            result['dentriesCount'] = self.dentries_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentriesCount') is not None:
            self.dentries_count = m.get('dentriesCount')
        return self


class GetTotalNumberOfDentriesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetTotalNumberOfDentriesResponseBody = None,
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
            temp_model = GetTotalNumberOfDentriesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetTotalNumberOfSpacesHeaders(TeaModel):
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


class GetTotalNumberOfSpacesRequest(TeaModel):
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


class GetTotalNumberOfSpacesResponseBody(TeaModel):
    def __init__(
        self,
        spaces_count: str = None,
    ):
        self.spaces_count = spaces_count

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.spaces_count is not None:
            result['spacesCount'] = self.spaces_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('spacesCount') is not None:
            self.spaces_count = m.get('spacesCount')
        return self


class GetTotalNumberOfSpacesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetTotalNumberOfSpacesResponseBody = None,
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
            temp_model = GetTotalNumberOfSpacesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetUserInfoByOpenTokenHeaders(TeaModel):
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


class GetUserInfoByOpenTokenRequest(TeaModel):
    def __init__(
        self,
        doc_key: str = None,
        open_token: str = None,
    ):
        # 文档docKey，标识一篇文档的key。
        self.doc_key = doc_key
        # 文档颁发给三方应用的 OpenToken，用于三方应用在文档中的免登。
        self.open_token = open_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.doc_key is not None:
            result['docKey'] = self.doc_key
        if self.open_token is not None:
            result['openToken'] = self.open_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('docKey') is not None:
            self.doc_key = m.get('docKey')
        if m.get('openToken') is not None:
            self.open_token = m.get('openToken')
        return self


class GetUserInfoByOpenTokenResponseBody(TeaModel):
    def __init__(
        self,
        union_id: str = None,
        user_id: str = None,
    ):
        # 用户的 unionId。
        self.union_id = union_id
        # 用户的userId。
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetUserInfoByOpenTokenResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetUserInfoByOpenTokenResponseBody = None,
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
            temp_model = GetUserInfoByOpenTokenResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListFeedsHeaders(TeaModel):
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


class ListFeedsRequest(TeaModel):
    def __init__(
        self,
        exclude_file: bool = None,
        max_results: int = None,
        next_token: str = None,
        operator_id: str = None,
    ):
        # 是否排除文件。
        self.exclude_file = exclude_file
        # 每页最大条目数，最大值50。
        self.max_results = max_results
        # 分页游标，第一页可不传。
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
        if self.exclude_file is not None:
            result['excludeFile'] = self.exclude_file
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('excludeFile') is not None:
            self.exclude_file = m.get('excludeFile')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class ListFeedsResponseBodyItems(TeaModel):
    def __init__(
        self,
        content: str = None,
        time: int = None,
        type: int = None,
    ):
        # 动态内容。
        self.content = content
        # 动态时间。
        self.time = time
        # 动态类型。
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.time is not None:
            result['time'] = self.time
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('time') is not None:
            self.time = m.get('time')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class ListFeedsResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        items: List[ListFeedsResponseBodyItems] = None,
        next_token: str = None,
    ):
        # 是否还有更多数据。
        self.has_more = has_more
        # 动态列表。
        self.items = items
        # 分页游标。
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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.items = []
        if m.get('items') is not None:
            for k in m.get('items'):
                temp_model = ListFeedsResponseBodyItems()
                self.items.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class ListFeedsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListFeedsResponseBody = None,
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
            temp_model = ListFeedsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListHotDocsHeaders(TeaModel):
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


class ListHotDocsRequest(TeaModel):
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


class ListHotDocsResponseBody(TeaModel):
    def __init__(
        self,
        items: List[DentryModel] = None,
    ):
        # 热门文档列表。
        self.items = items

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.items = []
        if m.get('items') is not None:
            for k in m.get('items'):
                temp_model = DentryModel()
                self.items.append(temp_model.from_map(k))
        return self


class ListHotDocsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListHotDocsResponseBody = None,
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
            temp_model = ListHotDocsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListRelatedSpaceTeamsHeaders(TeaModel):
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


class ListRelatedSpaceTeamsRequest(TeaModel):
    def __init__(
        self,
        operator_id: str = None,
        type: int = None,
    ):
        # 操作用户unionId。
        self.operator_id = operator_id
        # 团队类型。
        # 0-空白团队；1-部门；2-项目组；3-兴趣小组。
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class ListRelatedSpaceTeamsResponseBody(TeaModel):
    def __init__(
        self,
        items: List[TeamModel] = None,
    ):
        self.items = items

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.items = []
        if m.get('items') is not None:
            for k in m.get('items'):
                temp_model = TeamModel()
                self.items.append(temp_model.from_map(k))
        return self


class ListRelatedSpaceTeamsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListRelatedSpaceTeamsResponseBody = None,
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
            temp_model = ListRelatedSpaceTeamsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListRelatedTeamsHeaders(TeaModel):
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


class ListRelatedTeamsRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        operator_id: str = None,
        type: int = None,
    ):
        # 每页最大条目数，最大值50。
        self.max_results = max_results
        # 分页游标，第一页可不传。
        self.next_token = next_token
        # 操作用户unionId。
        self.operator_id = operator_id
        # 小组类型。
        # 0-默认；1-部门；2-项目组；3-兴趣小组。
        self.type = type

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
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class ListRelatedTeamsResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        items: List[TeamModel] = None,
        next_token: str = None,
    ):
        # 是否还有更多数据。
        self.has_more = has_more
        # 小组列表。
        self.items = items
        # 分页游标。
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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.items = []
        if m.get('items') is not None:
            for k in m.get('items'):
                temp_model = TeamModel()
                self.items.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class ListRelatedTeamsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListRelatedTeamsResponseBody = None,
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
            temp_model = ListRelatedTeamsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListSpaceSectionsHeaders(TeaModel):
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


class ListSpaceSectionsRequest(TeaModel):
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


class ListSpaceSectionsResponseBodyItems(TeaModel):
    def __init__(
        self,
        display_type: str = None,
        id: str = None,
        name: str = None,
        space_num: int = None,
        spaces: List[SpaceModel] = None,
    ):
        # 展示类型。
        self.display_type = display_type
        # 分组id。
        self.id = id
        # 分组名称。
        self.name = name
        # 知识库数量。
        self.space_num = space_num
        # 知识库列表
        self.spaces = spaces

    def validate(self):
        if self.spaces:
            for k in self.spaces:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_type is not None:
            result['displayType'] = self.display_type
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.space_num is not None:
            result['spaceNum'] = self.space_num
        result['spaces'] = []
        if self.spaces is not None:
            for k in self.spaces:
                result['spaces'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayType') is not None:
            self.display_type = m.get('displayType')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('spaceNum') is not None:
            self.space_num = m.get('spaceNum')
        self.spaces = []
        if m.get('spaces') is not None:
            for k in m.get('spaces'):
                temp_model = SpaceModel()
                self.spaces.append(temp_model.from_map(k))
        return self


class ListSpaceSectionsResponseBody(TeaModel):
    def __init__(
        self,
        items: List[ListSpaceSectionsResponseBodyItems] = None,
    ):
        # 空间分组列表。
        self.items = items

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.items = []
        if m.get('items') is not None:
            for k in m.get('items'):
                temp_model = ListSpaceSectionsResponseBodyItems()
                self.items.append(temp_model.from_map(k))
        return self


class ListSpaceSectionsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListSpaceSectionsResponseBody = None,
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
            temp_model = ListSpaceSectionsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListTeamMembersHeaders(TeaModel):
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


class ListTeamMembersRequest(TeaModel):
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


class ListTeamMembersResponseBodyMembers(TeaModel):
    def __init__(
        self,
        member_id: str = None,
        member_type: int = None,
        name: str = None,
        role_code: str = None,
    ):
        # 成员id。
        self.member_id = member_id
        # 成员类型。
        # 1-群；2-用户；3-组织；4-部门；5-虚拟组。
        self.member_type = member_type
        # 成员名称。
        self.name = name
        # 成员角色。
        # 0-无权限；1-只读；2-只读/下载；3-编辑；4-管理员；5-所有者。
        self.role_code = role_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.member_id is not None:
            result['memberId'] = self.member_id
        if self.member_type is not None:
            result['memberType'] = self.member_type
        if self.name is not None:
            result['name'] = self.name
        if self.role_code is not None:
            result['roleCode'] = self.role_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memberId') is not None:
            self.member_id = m.get('memberId')
        if m.get('memberType') is not None:
            self.member_type = m.get('memberType')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('roleCode') is not None:
            self.role_code = m.get('roleCode')
        return self


class ListTeamMembersResponseBody(TeaModel):
    def __init__(
        self,
        members: List[ListTeamMembersResponseBodyMembers] = None,
        team_name: str = None,
    ):
        # 小组成员列表。
        self.members = members
        # 小组名称。
        self.team_name = team_name

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
        if self.team_name is not None:
            result['teamName'] = self.team_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.members = []
        if m.get('members') is not None:
            for k in m.get('members'):
                temp_model = ListTeamMembersResponseBodyMembers()
                self.members.append(temp_model.from_map(k))
        if m.get('teamName') is not None:
            self.team_name = m.get('teamName')
        return self


class ListTeamMembersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListTeamMembersResponseBody = None,
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
            temp_model = ListTeamMembersResponseBody()
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
        body: DentryVO = None,
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
            temp_model = DentryVO()
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
        body: DentryVO = None,
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
            temp_model = DentryVO()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryItemByUrlHeaders(TeaModel):
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


class QueryItemByUrlRequest(TeaModel):
    def __init__(
        self,
        operator_id: str = None,
        url: str = None,
    ):
        # 操作用户unionId。
        self.operator_id = operator_id
        # 链接url。
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class QueryItemByUrlResponseBodySpaceOwner(TeaModel):
    def __init__(
        self,
        name: str = None,
        union_id: str = None,
    ):
        # 知识库所有者名称。
        self.name = name
        # 知识库所有者的unionId。
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


class QueryItemByUrlResponseBodySpace(TeaModel):
    def __init__(
        self,
        description: str = None,
        id: str = None,
        name: str = None,
        owner: QueryItemByUrlResponseBodySpaceOwner = None,
        type: int = None,
    ):
        # 知识库简介。
        self.description = description
        # 知识库id。
        self.id = id
        # 知识库名称。
        self.name = name
        # 如果type=2，会返回其所有者。
        self.owner = owner
        # 知识库类型。1-知识库；2-我的文档。
        self.type = type

    def validate(self):
        if self.owner:
            self.owner.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.owner is not None:
            result['owner'] = self.owner.to_map()
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('owner') is not None:
            temp_model = QueryItemByUrlResponseBodySpaceOwner()
            self.owner = temp_model.from_map(m['owner'])
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class QueryItemByUrlResponseBody(TeaModel):
    def __init__(
        self,
        biz_type: str = None,
        dentry: DentryModel = None,
        resource_type: str = None,
        space: QueryItemByUrlResponseBodySpace = None,
    ):
        # 业务类型。可选值：dingpan-云盘中的文档；mainsite-知识库中的文档。
        self.biz_type = biz_type
        self.dentry = dentry
        # 资源类型。可选值有：space-知识库；file-文档；folder-文件夹。
        self.resource_type = resource_type
        # 当resourceType为space时，这里会返回知识库信息。
        self.space = space

    def validate(self):
        if self.dentry:
            self.dentry.validate()
        if self.space:
            self.space.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.dentry is not None:
            result['dentry'] = self.dentry.to_map()
        if self.resource_type is not None:
            result['resourceType'] = self.resource_type
        if self.space is not None:
            result['space'] = self.space.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('dentry') is not None:
            temp_model = DentryModel()
            self.dentry = temp_model.from_map(m['dentry'])
        if m.get('resourceType') is not None:
            self.resource_type = m.get('resourceType')
        if m.get('space') is not None:
            temp_model = QueryItemByUrlResponseBodySpace()
            self.space = temp_model.from_map(m['space'])
        return self


class QueryItemByUrlResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryItemByUrlResponseBody = None,
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
            temp_model = QueryItemByUrlResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryMineSpaceHeaders(TeaModel):
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


class QueryMineSpaceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SpaceVO = None,
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
            temp_model = SpaceVO()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryRecentListHeaders(TeaModel):
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


class QueryRecentListRequest(TeaModel):
    def __init__(
        self,
        creator_type: int = None,
        file_type: int = None,
        max_results: int = None,
        next_token: str = None,
        operator_id: str = None,
        recent_type: int = None,
    ):
        # 创建人类型。0-全部；1-我创建的；2-他人创建；不填也是查全部。
        self.creator_type = creator_type
        # 访问文档类型：0-文字；1-表格；2-PPT；3-白板；6-脑图；7-多维表；不填的话，则默认是所有。
        self.file_type = file_type
        # 每页最大条目数，最大值50。
        self.max_results = max_results
        # 分页游标，第一页可不传。
        self.next_token = next_token
        # 操作用户unionId。
        self.operator_id = operator_id
        # 最近列表的类型：0-最近访问；1-最近编辑。
        self.recent_type = recent_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.creator_type is not None:
            result['creatorType'] = self.creator_type
        if self.file_type is not None:
            result['fileType'] = self.file_type
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.recent_type is not None:
            result['recentType'] = self.recent_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('creatorType') is not None:
            self.creator_type = m.get('creatorType')
        if m.get('fileType') is not None:
            self.file_type = m.get('fileType')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('recentType') is not None:
            self.recent_type = m.get('recentType')
        return self


class QueryRecentListResponseBodyRecentList(TeaModel):
    def __init__(
        self,
        deleted: bool = None,
        dentry: DentryModel = None,
        recent_time: int = None,
    ):
        # 是否被删除。
        self.deleted = deleted
        # 节点信息。
        self.dentry = dentry
        # 如果查询的是访问，那么这里是访问时间；否则就是编辑时间。
        self.recent_time = recent_time

    def validate(self):
        if self.dentry:
            self.dentry.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.deleted is not None:
            result['deleted'] = self.deleted
        if self.dentry is not None:
            result['dentry'] = self.dentry.to_map()
        if self.recent_time is not None:
            result['recentTime'] = self.recent_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deleted') is not None:
            self.deleted = m.get('deleted')
        if m.get('dentry') is not None:
            temp_model = DentryModel()
            self.dentry = temp_model.from_map(m['dentry'])
        if m.get('recentTime') is not None:
            self.recent_time = m.get('recentTime')
        return self


class QueryRecentListResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        next_token: str = None,
        recent_list: List[QueryRecentListResponseBodyRecentList] = None,
    ):
        # 是否还有更多数据。
        self.has_more = has_more
        # 分页游标。
        self.next_token = next_token
        # 子节点列表。
        self.recent_list = recent_list

    def validate(self):
        if self.recent_list:
            for k in self.recent_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['recentList'] = []
        if self.recent_list is not None:
            for k in self.recent_list:
                result['recentList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.recent_list = []
        if m.get('recentList') is not None:
            for k in m.get('recentList'):
                temp_model = QueryRecentListResponseBodyRecentList()
                self.recent_list.append(temp_model.from_map(k))
        return self


class QueryRecentListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryRecentListResponseBody = None,
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
            temp_model = QueryRecentListResponseBody()
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
        body: SpaceVO = None,
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
            temp_model = SpaceVO()
            self.body = temp_model.from_map(m['body'])
        return self


class RelatedSpacesHeaders(TeaModel):
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


class RelatedSpacesRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        operator_id: str = None,
        team_id: str = None,
    ):
        # 每页最大条目数，最大值100。
        self.max_results = max_results
        # 分页游标，第一页可不传。
        self.next_token = next_token
        # 操作用户unionId。
        self.operator_id = operator_id
        # 小组id。
        self.team_id = team_id

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
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.team_id is not None:
            result['teamId'] = self.team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('teamId') is not None:
            self.team_id = m.get('teamId')
        return self


class RelatedSpacesResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        items: List[SpaceModel] = None,
        next_token: str = None,
    ):
        # 是否还有更多数据。
        self.has_more = has_more
        self.items = items
        # 分页游标。
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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.items = []
        if m.get('items') is not None:
            for k in m.get('items'):
                temp_model = SpaceModel()
                self.items.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class RelatedSpacesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: RelatedSpacesResponseBody = None,
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
            temp_model = RelatedSpacesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RemoveTeamMembersHeaders(TeaModel):
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


class RemoveTeamMembersRequestMembers(TeaModel):
    def __init__(
        self,
        member_id: str = None,
        member_type: int = None,
        role_code: str = None,
    ):
        # 成员id。
        self.member_id = member_id
        # 成员类型。
        # 1-群；2-用户；3-组织；4-部门；5-虚拟组织；6-通讯录角色组。
        self.member_type = member_type
        # 成员角色。
        # 0-无权限；1-只读；2-只读/下载；3-编辑；4-管理员；5-所有者。
        self.role_code = role_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.member_id is not None:
            result['memberId'] = self.member_id
        if self.member_type is not None:
            result['memberType'] = self.member_type
        if self.role_code is not None:
            result['roleCode'] = self.role_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memberId') is not None:
            self.member_id = m.get('memberId')
        if m.get('memberType') is not None:
            self.member_type = m.get('memberType')
        if m.get('roleCode') is not None:
            self.role_code = m.get('roleCode')
        return self


class RemoveTeamMembersRequest(TeaModel):
    def __init__(
        self,
        members: List[RemoveTeamMembersRequestMembers] = None,
        notify: bool = None,
        operator_id: str = None,
    ):
        # 待移除的成员列表。
        self.members = members
        # 是否通知被移除的成员，默认否。
        self.notify = notify
        # 操作人unionId。
        self.operator_id = operator_id

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
        if self.notify is not None:
            result['notify'] = self.notify
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.members = []
        if m.get('members') is not None:
            for k in m.get('members'):
                temp_model = RemoveTeamMembersRequestMembers()
                self.members.append(temp_model.from_map(k))
        if m.get('notify') is not None:
            self.notify = m.get('notify')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class RemoveTeamMembersResponseBodyNotInOrgMembers(TeaModel):
    def __init__(
        self,
        member_id: str = None,
        member_type: int = None,
        name: str = None,
        role_code: str = None,
    ):
        # 成员id。
        self.member_id = member_id
        # 成员类型。
        # 1-群；2-用户；3-组织；4-部门；5-虚拟组织；6-通讯录角色组。
        self.member_type = member_type
        # 成员名称。
        self.name = name
        # 成员角色。
        # 0-无权限；1-只读；2-只读/下载；3-编辑、4-管理员；5-所有者。
        self.role_code = role_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.member_id is not None:
            result['memberId'] = self.member_id
        if self.member_type is not None:
            result['memberType'] = self.member_type
        if self.name is not None:
            result['name'] = self.name
        if self.role_code is not None:
            result['roleCode'] = self.role_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memberId') is not None:
            self.member_id = m.get('memberId')
        if m.get('memberType') is not None:
            self.member_type = m.get('memberType')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('roleCode') is not None:
            self.role_code = m.get('roleCode')
        return self


class RemoveTeamMembersResponseBody(TeaModel):
    def __init__(
        self,
        not_in_org_members: List[RemoveTeamMembersResponseBodyNotInOrgMembers] = None,
        save_success: bool = None,
    ):
        # 企业外的成员列表。
        # 保存失败的时候会返回此列表。
        self.not_in_org_members = not_in_org_members
        # 是否保存成功。
        self.save_success = save_success

    def validate(self):
        if self.not_in_org_members:
            for k in self.not_in_org_members:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['notInOrgMembers'] = []
        if self.not_in_org_members is not None:
            for k in self.not_in_org_members:
                result['notInOrgMembers'].append(k.to_map() if k else None)
        if self.save_success is not None:
            result['saveSuccess'] = self.save_success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.not_in_org_members = []
        if m.get('notInOrgMembers') is not None:
            for k in m.get('notInOrgMembers'):
                temp_model = RemoveTeamMembersResponseBodyNotInOrgMembers()
                self.not_in_org_members.append(temp_model.from_map(k))
        if m.get('saveSuccess') is not None:
            self.save_success = m.get('saveSuccess')
        return self


class RemoveTeamMembersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: RemoveTeamMembersResponseBody = None,
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
            temp_model = RemoveTeamMembersResponseBody()
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
        name: str = None,
        operator_id: str = None,
    ):
        # 重命名之后的节点名称，长度不能超过50。
        self.name = name
        # 操作人unionId。
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class RenameDentryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DentryVO = None,
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
            temp_model = DentryVO()
            self.body = temp_model.from_map(m['body'])
        return self


class SaveTeamMembersHeaders(TeaModel):
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


class SaveTeamMembersRequestMembers(TeaModel):
    def __init__(
        self,
        member_id: str = None,
        member_type: int = None,
        role_code: str = None,
    ):
        # 成员id。
        self.member_id = member_id
        # 成员类型。
        # 1-群；2-用户；3-组织；4-部门；5-虚拟组织；6-通讯录角色组。
        self.member_type = member_type
        # 成员角色。
        # 0-无权限；1-只读；2-只读/下载；3-编辑；4-管理员；5-所有者。
        self.role_code = role_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.member_id is not None:
            result['memberId'] = self.member_id
        if self.member_type is not None:
            result['memberType'] = self.member_type
        if self.role_code is not None:
            result['roleCode'] = self.role_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memberId') is not None:
            self.member_id = m.get('memberId')
        if m.get('memberType') is not None:
            self.member_type = m.get('memberType')
        if m.get('roleCode') is not None:
            self.role_code = m.get('roleCode')
        return self


class SaveTeamMembersRequest(TeaModel):
    def __init__(
        self,
        members: List[SaveTeamMembersRequestMembers] = None,
        notify: bool = None,
        operator_id: str = None,
    ):
        # 待添加/修改的成员列表。
        self.members = members
        # 是否通知被授权成员，默认否。
        self.notify = notify
        # 操作人unionId。
        self.operator_id = operator_id

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
        if self.notify is not None:
            result['notify'] = self.notify
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.members = []
        if m.get('members') is not None:
            for k in m.get('members'):
                temp_model = SaveTeamMembersRequestMembers()
                self.members.append(temp_model.from_map(k))
        if m.get('notify') is not None:
            self.notify = m.get('notify')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class SaveTeamMembersResponseBodyNotInOrgMembers(TeaModel):
    def __init__(
        self,
        member_id: str = None,
        member_type: int = None,
        name: str = None,
        role_code: str = None,
    ):
        # 成员id。
        self.member_id = member_id
        # 成员类型。
        # 1-群；2-用户；3-组织；4-部门；5-虚拟组织；6-通讯录角色组。
        self.member_type = member_type
        # 成员名称。
        self.name = name
        # 成员角色。
        # 0-无权限；1-只读；2-只读/下载；3-编辑、4-管理员；5-所有者。
        self.role_code = role_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.member_id is not None:
            result['memberId'] = self.member_id
        if self.member_type is not None:
            result['memberType'] = self.member_type
        if self.name is not None:
            result['name'] = self.name
        if self.role_code is not None:
            result['roleCode'] = self.role_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memberId') is not None:
            self.member_id = m.get('memberId')
        if m.get('memberType') is not None:
            self.member_type = m.get('memberType')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('roleCode') is not None:
            self.role_code = m.get('roleCode')
        return self


class SaveTeamMembersResponseBody(TeaModel):
    def __init__(
        self,
        not_in_org_members: List[SaveTeamMembersResponseBodyNotInOrgMembers] = None,
        save_success: bool = None,
    ):
        # 企业外的成员列表。
        # 保存失败的时候会返回此列表。
        self.not_in_org_members = not_in_org_members
        # 是否保存成功。
        self.save_success = save_success

    def validate(self):
        if self.not_in_org_members:
            for k in self.not_in_org_members:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['notInOrgMembers'] = []
        if self.not_in_org_members is not None:
            for k in self.not_in_org_members:
                result['notInOrgMembers'].append(k.to_map() if k else None)
        if self.save_success is not None:
            result['saveSuccess'] = self.save_success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.not_in_org_members = []
        if m.get('notInOrgMembers') is not None:
            for k in m.get('notInOrgMembers'):
                temp_model = SaveTeamMembersResponseBodyNotInOrgMembers()
                self.not_in_org_members.append(temp_model.from_map(k))
        if m.get('saveSuccess') is not None:
            self.save_success = m.get('saveSuccess')
        return self


class SaveTeamMembersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SaveTeamMembersResponseBody = None,
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
            temp_model = SaveTeamMembersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SearchHeaders(TeaModel):
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


class SearchRequestDentryRequestVisitTimeRange(TeaModel):
    def __init__(
        self,
        end: int = None,
        start: int = None,
    ):
        # 结束时间戳（ms）。
        self.end = end
        # 起始时间戳（ms）。
        self.start = start

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end is not None:
            result['end'] = self.end
        if self.start is not None:
            result['start'] = self.start
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('end') is not None:
            self.end = m.get('end')
        if m.get('start') is not None:
            self.start = m.get('start')
        return self


class SearchRequestDentryRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        search_field: int = None,
        search_file_type: int = None,
        space_id: str = None,
        summary_length: int = None,
        visit_time_range: SearchRequestDentryRequestVisitTimeRange = None,
    ):
        # 每页最大条目数，最大值50。
        self.max_results = max_results
        # 分页游标。如果是首次调用，可不传；如果非首次调用，该参数传上次调用时返回的nextToken。
        self.next_token = next_token
        # 搜索的字段。支持的有：1-标题和内容；2-标题、内容和评论；3-标题和评论；4-标题；5-内容；6-评论。
        self.search_field = search_field
        # 搜索指定的文件类型。支持的类型有：1-文档；2-表格；3-脑图；4-演示；5-白板。
        self.search_file_type = search_file_type
        # 知识库id，在指定的知识库中搜索。
        self.space_id = space_id
        # 文档内容命中了搜索关键词的时候，需要返回的文档摘要长度。
        self.summary_length = summary_length
        # 文档访问时间的范围。
        self.visit_time_range = visit_time_range

    def validate(self):
        if self.visit_time_range:
            self.visit_time_range.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.search_field is not None:
            result['searchField'] = self.search_field
        if self.search_file_type is not None:
            result['searchFileType'] = self.search_file_type
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.summary_length is not None:
            result['summaryLength'] = self.summary_length
        if self.visit_time_range is not None:
            result['visitTimeRange'] = self.visit_time_range.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('searchField') is not None:
            self.search_field = m.get('searchField')
        if m.get('searchFileType') is not None:
            self.search_file_type = m.get('searchFileType')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('summaryLength') is not None:
            self.summary_length = m.get('summaryLength')
        if m.get('visitTimeRange') is not None:
            temp_model = SearchRequestDentryRequestVisitTimeRange()
            self.visit_time_range = temp_model.from_map(m['visitTimeRange'])
        return self


class SearchRequestSpaceRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
    ):
        # 每页最大条目数，最大值50。
        self.max_results = max_results
        # 分页游标。如果是首次调用，可不传；如果非首次调用，该参数传上次调用时返回的nextToken。
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


class SearchRequest(TeaModel):
    def __init__(
        self,
        dentry_request: SearchRequestDentryRequest = None,
        keyword: str = None,
        operator_id: str = None,
        space_request: SearchRequestSpaceRequest = None,
    ):
        # 节点搜索请求，和空间搜索请求二选一必填。
        self.dentry_request = dentry_request
        #  搜索关键词。
        self.keyword = keyword
        # 操作人unionId。
        self.operator_id = operator_id
        # 空间搜索请求，和节点搜索请求二选一必填。
        self.space_request = space_request

    def validate(self):
        if self.dentry_request:
            self.dentry_request.validate()
        if self.space_request:
            self.space_request.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dentry_request is not None:
            result['dentryRequest'] = self.dentry_request.to_map()
        if self.keyword is not None:
            result['keyword'] = self.keyword
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.space_request is not None:
            result['spaceRequest'] = self.space_request.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentryRequest') is not None:
            temp_model = SearchRequestDentryRequest()
            self.dentry_request = temp_model.from_map(m['dentryRequest'])
        if m.get('keyword') is not None:
            self.keyword = m.get('keyword')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('spaceRequest') is not None:
            temp_model = SearchRequestSpaceRequest()
            self.space_request = temp_model.from_map(m['spaceRequest'])
        return self


class SearchResponseBodyDentryResultItems(TeaModel):
    def __init__(
        self,
        content: str = None,
        creation: OpenActionModel = None,
        dentry_id: str = None,
        dentry_uuid: str = None,
        extension: str = None,
        icon_url: str = None,
        last_edition: OpenActionModel = None,
        name: str = None,
        origin_name: str = None,
        path: str = None,
        scene_type: int = None,
        search_file_type: int = None,
        space_id: str = None,
        thumbnail_url: str = None,
        url: str = None,
    ):
        # 如果内容命中了关键词，会返回该部分内容，带高亮。
        self.content = content
        # 创建信息。
        self.creation = creation
        # 节点id。
        self.dentry_id = dentry_id
        # 节点唯一标识。
        self.dentry_uuid = dentry_uuid
        # 文件名扩展。
        self.extension = extension
        # 节点图标url。
        self.icon_url = icon_url
        # 最后修改信息。
        self.last_edition = last_edition
        # 节点名称，如果命中了关键词，会带有高亮。
        self.name = name
        # 节点原始名称，不带高亮。
        self.origin_name = origin_name
        # 节点的路径。
        self.path = path
        # 节点所属的业务场景。可选值有：1-知识库；2-我的文档；5-群聊。
        self.scene_type = scene_type
        # 文件类型。1-文档；2-表格；3-脑图；4-演示；5-白板；6-office文字；7-office表格；8-office ppt；10-多维表格；11-文本；12-图片；13-视频；14-音频；15-压缩文件；16-其他。
        self.search_file_type = search_file_type
        # 节点所属的知识库id。
        self.space_id = space_id
        # 文档缩略图url。
        self.thumbnail_url = thumbnail_url
        # 节点访问url。
        self.url = url

    def validate(self):
        if self.creation:
            self.creation.validate()
        if self.last_edition:
            self.last_edition.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.creation is not None:
            result['creation'] = self.creation.to_map()
        if self.dentry_id is not None:
            result['dentryId'] = self.dentry_id
        if self.dentry_uuid is not None:
            result['dentryUuid'] = self.dentry_uuid
        if self.extension is not None:
            result['extension'] = self.extension
        if self.icon_url is not None:
            result['iconUrl'] = self.icon_url
        if self.last_edition is not None:
            result['lastEdition'] = self.last_edition.to_map()
        if self.name is not None:
            result['name'] = self.name
        if self.origin_name is not None:
            result['originName'] = self.origin_name
        if self.path is not None:
            result['path'] = self.path
        if self.scene_type is not None:
            result['sceneType'] = self.scene_type
        if self.search_file_type is not None:
            result['searchFileType'] = self.search_file_type
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.thumbnail_url is not None:
            result['thumbnailUrl'] = self.thumbnail_url
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('creation') is not None:
            temp_model = OpenActionModel()
            self.creation = temp_model.from_map(m['creation'])
        if m.get('dentryId') is not None:
            self.dentry_id = m.get('dentryId')
        if m.get('dentryUuid') is not None:
            self.dentry_uuid = m.get('dentryUuid')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('iconUrl') is not None:
            self.icon_url = m.get('iconUrl')
        if m.get('lastEdition') is not None:
            temp_model = OpenActionModel()
            self.last_edition = temp_model.from_map(m['lastEdition'])
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('originName') is not None:
            self.origin_name = m.get('originName')
        if m.get('path') is not None:
            self.path = m.get('path')
        if m.get('sceneType') is not None:
            self.scene_type = m.get('sceneType')
        if m.get('searchFileType') is not None:
            self.search_file_type = m.get('searchFileType')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('thumbnailUrl') is not None:
            self.thumbnail_url = m.get('thumbnailUrl')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class SearchResponseBodyDentryResult(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        items: List[SearchResponseBodyDentryResultItems] = None,
        next_token: str = None,
    ):
        # 是否还有更多数据。
        self.has_more = has_more
        # 搜索命中的节点列表。
        self.items = items
        # 分页游标。
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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.items = []
        if m.get('items') is not None:
            for k in m.get('items'):
                temp_model = SearchResponseBodyDentryResultItems()
                self.items.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class SearchResponseBodySpaceResultItemsIconVO(TeaModel):
    def __init__(
        self,
        icon: str = None,
        type: str = None,
    ):
        # 图标信息。
        self.icon = icon
        # 知识库图标的类型。
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.icon is not None:
            result['icon'] = self.icon
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class SearchResponseBodySpaceResultItemsUserLastOperation(TeaModel):
    def __init__(
        self,
        name: str = None,
        time: int = None,
    ):
        # 操作人名称。
        self.name = name
        # 操作的时间戳（ms）。
        self.time = time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.time is not None:
            result['time'] = self.time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('time') is not None:
            self.time = m.get('time')
        return self


class SearchResponseBodySpaceResultItems(TeaModel):
    def __init__(
        self,
        icon_vo: SearchResponseBodySpaceResultItemsIconVO = None,
        name: str = None,
        origin_name: str = None,
        space_id: str = None,
        url: str = None,
        user_last_operation: SearchResponseBodySpaceResultItemsUserLastOperation = None,
    ):
        # 知识库图标。
        self.icon_vo = icon_vo
        # 知识库名称，如果命中了关键词，会带有高亮。
        self.name = name
        # 知识库原始名称，不带高亮。
        self.origin_name = origin_name
        # 知识库id。
        self.space_id = space_id
        # 知识库访问url。
        self.url = url
        # 用户最后一次操作信息。
        self.user_last_operation = user_last_operation

    def validate(self):
        if self.icon_vo:
            self.icon_vo.validate()
        if self.user_last_operation:
            self.user_last_operation.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.icon_vo is not None:
            result['iconVO'] = self.icon_vo.to_map()
        if self.name is not None:
            result['name'] = self.name
        if self.origin_name is not None:
            result['originName'] = self.origin_name
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.url is not None:
            result['url'] = self.url
        if self.user_last_operation is not None:
            result['userLastOperation'] = self.user_last_operation.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('iconVO') is not None:
            temp_model = SearchResponseBodySpaceResultItemsIconVO()
            self.icon_vo = temp_model.from_map(m['iconVO'])
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('originName') is not None:
            self.origin_name = m.get('originName')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('userLastOperation') is not None:
            temp_model = SearchResponseBodySpaceResultItemsUserLastOperation()
            self.user_last_operation = temp_model.from_map(m['userLastOperation'])
        return self


class SearchResponseBodySpaceResult(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        items: List[SearchResponseBodySpaceResultItems] = None,
        next_token: str = None,
    ):
        # 是否还有更多数据。
        self.has_more = has_more
        # 搜索命中的知识库列表。
        self.items = items
        # 分页游标。
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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.items = []
        if m.get('items') is not None:
            for k in m.get('items'):
                temp_model = SearchResponseBodySpaceResultItems()
                self.items.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class SearchResponseBody(TeaModel):
    def __init__(
        self,
        dentry_result: SearchResponseBodyDentryResult = None,
        space_result: SearchResponseBodySpaceResult = None,
    ):
        # 节点搜索结果。
        self.dentry_result = dentry_result
        # 知识库搜索结果。
        self.space_result = space_result

    def validate(self):
        if self.dentry_result:
            self.dentry_result.validate()
        if self.space_result:
            self.space_result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dentry_result is not None:
            result['dentryResult'] = self.dentry_result.to_map()
        if self.space_result is not None:
            result['spaceResult'] = self.space_result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentryResult') is not None:
            temp_model = SearchResponseBodyDentryResult()
            self.dentry_result = temp_model.from_map(m['dentryResult'])
        if m.get('spaceResult') is not None:
            temp_model = SearchResponseBodySpaceResult()
            self.space_result = temp_model.from_map(m['spaceResult'])
        return self


class SearchResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SearchResponseBody = None,
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
            temp_model = SearchResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateTeamHeaders(TeaModel):
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


class UpdateTeamRequest(TeaModel):
    def __init__(
        self,
        description: str = None,
        name: str = None,
        operator_id: str = None,
    ):
        # 小组介绍。和小组名称至少有一个必填。
        self.description = description
        # 小组名称。和小组介绍至少有一个必填。
        self.name = name
        # 操作人unionId。
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        if self.name is not None:
            result['name'] = self.name
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class UpdateTeamResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: TeamVO = None,
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
            temp_model = TeamVO()
            self.body = temp_model.from_map(m['body'])
        return self


