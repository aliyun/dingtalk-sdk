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
        self.name = name
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


class DentryModelStatisticalInfo(TeaModel):
    def __init__(
        self,
        word_count: int = None,
    ):
        self.word_count = word_count

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.word_count is not None:
            result['wordCount'] = self.word_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('wordCount') is not None:
            self.word_count = m.get('wordCount')
        return self


class DentryModelUpdater(TeaModel):
    def __init__(
        self,
        name: str = None,
        union_id: str = None,
    ):
        self.name = name
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
        self.dentry_actions = dentry_actions
        self.role_code = role_code
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
        self.line = line
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
        self.extension = extension
        self.icon_url = icon_url
        self.id = id
        self.link_type = link_type
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


class SpaceModelHdIconVO(TeaModel):
    def __init__(
        self,
        icon: str = None,
        type: str = None,
    ):
        self.icon = icon
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


class SpaceModelIconVO(TeaModel):
    def __init__(
        self,
        icon: str = None,
        type: str = None,
    ):
        self.icon = icon
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
        self.name = name
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
        self.dentry_actions = dentry_actions
        self.role_code = role_code
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
        hd_icon_vo: SpaceModelHdIconVO = None,
        icon_vo: SpaceModelIconVO = None,
        id: str = None,
        name: str = None,
        owner: SpaceModelOwner = None,
        recent_list: List[DentryModel] = None,
        type: int = None,
        url: str = None,
        visitor_info: SpaceModelVisitorInfo = None,
    ):
        self.cover = cover
        self.description = description
        self.hd_icon_vo = hd_icon_vo
        self.icon_vo = icon_vo
        self.id = id
        self.name = name
        self.owner = owner
        self.recent_list = recent_list
        self.type = type
        self.url = url
        self.visitor_info = visitor_info

    def validate(self):
        if self.hd_icon_vo:
            self.hd_icon_vo.validate()
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
        if self.hd_icon_vo is not None:
            result['hdIconVO'] = self.hd_icon_vo.to_map()
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
        if m.get('hdIconVO') is not None:
            temp_model = SpaceModelHdIconVO()
            self.hd_icon_vo = temp_model.from_map(m['hdIconVO'])
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
        statistical_info: DentryModelStatisticalInfo = None,
        updated_time: int = None,
        updater: DentryModelUpdater = None,
        url: str = None,
        visitor_info: DentryModelVisitorInfo = None,
    ):
        self.content_type = content_type
        self.created_time = created_time
        self.creator = creator
        self.dentry_id = dentry_id
        self.dentry_type = dentry_type
        self.dentry_uuid = dentry_uuid
        self.doc_key = doc_key
        self.extension = extension
        self.has_children = has_children
        self.link_source_info = link_source_info
        self.name = name
        self.path = path
        self.space = space
        self.space_id = space_id
        self.statistical_info = statistical_info
        self.updated_time = updated_time
        self.updater = updater
        self.url = url
        self.visitor_info = visitor_info

    def validate(self):
        if self.creator:
            self.creator.validate()
        if self.link_source_info:
            self.link_source_info.validate()
        if self.space:
            self.space.validate()
        if self.statistical_info:
            self.statistical_info.validate()
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
        if self.statistical_info is not None:
            result['statisticalInfo'] = self.statistical_info.to_map()
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
        if m.get('statisticalInfo') is not None:
            temp_model = DentryModelStatisticalInfo()
            self.statistical_info = temp_model.from_map(m['statisticalInfo'])
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
        self.name = name
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
        self.name = name
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
        self.dentry_actions = dentry_actions
        self.role_code = role_code
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
        self.content_type = content_type
        self.created_time = created_time
        self.creator = creator
        self.dentry_id = dentry_id
        self.dentry_type = dentry_type
        self.dentry_uuid = dentry_uuid
        self.doc_key = doc_key
        self.extension = extension
        self.has_children = has_children
        self.link_source_info = link_source_info
        self.name = name
        self.path = path
        self.space = space
        self.space_id = space_id
        self.updated_time = updated_time
        self.updater = updater
        self.url = url
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
        self.name = name
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
        self.icon = icon
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
        self.name = name
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
        self.dentry_actions = dentry_actions
        self.role_code = role_code
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
        self.cover = cover
        self.description = description
        self.icon_vo = icon_vo
        self.id = id
        self.name = name
        self.owner = owner
        self.type = type
        self.url = url
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
        self.name = name
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
        self.dept_id = dept_id
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
        self.name = name
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
        join_time: str = None,
        role_code: str = None,
    ):
        self.join_time = join_time
        self.role_code = role_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.join_time is not None:
            result['joinTime'] = self.join_time
        if self.role_code is not None:
            result['roleCode'] = self.role_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('joinTime') is not None:
            self.join_time = m.get('joinTime')
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
        self.cover = cover
        self.created_time = created_time
        self.creator = creator
        self.description = description
        self.icon = icon
        self.id = id
        self.name = name
        self.related_dept_info = related_dept_info
        self.status = status
        self.type = type
        self.updated_time = updated_time
        self.updater = updater
        self.url = url
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
        self.name = name
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
        self.dept_id = dept_id
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


class TeamVOShareScopeInfo(TeaModel):
    def __init__(
        self,
        role_id: str = None,
        scope: int = None,
    ):
        self.role_id = role_id
        self.scope = scope

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.role_id is not None:
            result['roleId'] = self.role_id
        if self.scope is not None:
            result['scope'] = self.scope
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('roleId') is not None:
            self.role_id = m.get('roleId')
        if m.get('scope') is not None:
            self.scope = m.get('scope')
        return self


class TeamVOUpdater(TeaModel):
    def __init__(
        self,
        name: str = None,
        union_id: str = None,
    ):
        self.name = name
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
        share_scope_info: TeamVOShareScopeInfo = None,
        status: int = None,
        type: int = None,
        updated_time: int = None,
        updater: TeamVOUpdater = None,
        url: str = None,
        visit_info: TeamVOVisitInfo = None,
    ):
        self.cover = cover
        self.created_time = created_time
        self.creator = creator
        self.description = description
        self.icon = icon
        self.id = id
        self.name = name
        self.related_dept_info = related_dept_info
        self.share_scope_info = share_scope_info
        self.status = status
        self.type = type
        self.updated_time = updated_time
        self.updater = updater
        self.url = url
        self.visit_info = visit_info

    def validate(self):
        if self.creator:
            self.creator.validate()
        if self.related_dept_info:
            self.related_dept_info.validate()
        if self.share_scope_info:
            self.share_scope_info.validate()
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
        if self.share_scope_info is not None:
            result['shareScopeInfo'] = self.share_scope_info.to_map()
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
        if m.get('shareScopeInfo') is not None:
            temp_model = TeamVOShareScopeInfo()
            self.share_scope_info = temp_model.from_map(m['shareScopeInfo'])
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


class BatchDeleteRecentsHeaders(TeaModel):
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


class BatchDeleteRecentsRequest(TeaModel):
    def __init__(
        self,
        dentry_uuids: List[str] = None,
        operator_id: str = None,
    ):
        self.dentry_uuids = dentry_uuids
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dentry_uuids is not None:
            result['dentryUuids'] = self.dentry_uuids
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentryUuids') is not None:
            self.dentry_uuids = m.get('dentryUuids')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class BatchDeleteRecentsResponseBody(TeaModel):
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


class BatchDeleteRecentsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchDeleteRecentsResponseBody = None,
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
            temp_model = BatchDeleteRecentsResponseBody()
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
        self.name = name
        self.operator_id = operator_id
        self.target_space_id = target_space_id
        self.to_next_dentry_id = to_next_dentry_id
        self.to_parent_dentry_id = to_parent_dentry_id
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
        status_code: int = None,
        body: DentryVO = None,
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
        self.dentry_type = dentry_type
        self.document_type = document_type
        self.name = name
        self.operator_id = operator_id
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
        status_code: int = None,
        body: DentryVO = None,
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
        self.description = description
        self.icon = icon
        self.name = name
        self.operator_id = operator_id
        self.section_id = section_id
        self.share_scope = share_scope
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
        status_code: int = None,
        body: SpaceVO = None,
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
        self.member_id = member_id
        self.member_type = member_type
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
        self.cover = cover
        self.description = description
        self.icon = icon
        self.members = members
        self.name = name
        self.operator_id = operator_id
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
        status_code: int = None,
        body: TeamVO = None,
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
        status_code: int = None,
        body: TeamVO = None,
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
        self.revision = revision
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
        status_code: int = None,
        body: GetSchemaResponseBody = None,
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
        self.dentry_id = dentry_id
        self.max_results = max_results
        self.next_token = next_token
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
        self.children = children
        self.has_more = has_more
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
        status_code: int = None,
        body: GetSpaceDirectoriesResponseBody = None,
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
            temp_model = GetSpaceDirectoriesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetStarInfoHeaders(TeaModel):
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


class GetStarInfoRequest(TeaModel):
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


class GetStarInfoResponseBody(TeaModel):
    def __init__(
        self,
        starred: bool = None,
    ):
        self.starred = starred

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.starred is not None:
            result['starred'] = self.starred
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('starred') is not None:
            self.starred = m.get('starred')
        return self


class GetStarInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetStarInfoResponseBody = None,
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
            temp_model = GetStarInfoResponseBody()
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
        status_code: int = None,
        body: TeamVO = None,
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
        self.include_folder = include_folder
        self.operator_id = operator_id
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
        status_code: int = None,
        body: GetTotalNumberOfDentriesResponseBody = None,
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
        status_code: int = None,
        body: GetTotalNumberOfSpacesResponseBody = None,
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
        self.doc_key = doc_key
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
        self.union_id = union_id
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
        status_code: int = None,
        body: GetUserInfoByOpenTokenResponseBody = None,
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
        self.exclude_file = exclude_file
        self.max_results = max_results
        self.next_token = next_token
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
        self.content = content
        self.time = time
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
        self.has_more = has_more
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
        status_code: int = None,
        body: ListFeedsResponseBody = None,
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
        status_code: int = None,
        body: ListHotDocsResponseBody = None,
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
            temp_model = ListHotDocsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListPinSpacesHeaders(TeaModel):
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


class ListPinSpacesRequestOption(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        with_space_creator_info: bool = None,
        with_space_modifier_info: bool = None,
        with_space_permission_role: bool = None,
        with_team_detail: bool = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        self.with_space_creator_info = with_space_creator_info
        self.with_space_modifier_info = with_space_modifier_info
        self.with_space_permission_role = with_space_permission_role
        self.with_team_detail = with_team_detail

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
        if self.with_space_creator_info is not None:
            result['withSpaceCreatorInfo'] = self.with_space_creator_info
        if self.with_space_modifier_info is not None:
            result['withSpaceModifierInfo'] = self.with_space_modifier_info
        if self.with_space_permission_role is not None:
            result['withSpacePermissionRole'] = self.with_space_permission_role
        if self.with_team_detail is not None:
            result['withTeamDetail'] = self.with_team_detail
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('withSpaceCreatorInfo') is not None:
            self.with_space_creator_info = m.get('withSpaceCreatorInfo')
        if m.get('withSpaceModifierInfo') is not None:
            self.with_space_modifier_info = m.get('withSpaceModifierInfo')
        if m.get('withSpacePermissionRole') is not None:
            self.with_space_permission_role = m.get('withSpacePermissionRole')
        if m.get('withTeamDetail') is not None:
            self.with_team_detail = m.get('withTeamDetail')
        return self


class ListPinSpacesRequest(TeaModel):
    def __init__(
        self,
        option: ListPinSpacesRequestOption = None,
        operator_id: str = None,
    ):
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
        if self.option is not None:
            result['option'] = self.option.to_map()
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('option') is not None:
            temp_model = ListPinSpacesRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class ListPinSpacesResponseBodyResultItemsSpaceInfoCreator(TeaModel):
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


class ListPinSpacesResponseBodyResultItemsSpaceInfoIconVO(TeaModel):
    def __init__(
        self,
        icon: str = None,
        type: str = None,
    ):
        self.icon = icon
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


class ListPinSpacesResponseBodyResultItemsSpaceInfoModifier(TeaModel):
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


class ListPinSpacesResponseBodyResultItemsSpaceInfo(TeaModel):
    def __init__(
        self,
        cover: str = None,
        create_time: str = None,
        creator: ListPinSpacesResponseBodyResultItemsSpaceInfoCreator = None,
        description: str = None,
        icon_vo: ListPinSpacesResponseBodyResultItemsSpaceInfoIconVO = None,
        id: str = None,
        mobile_url: str = None,
        modified_time: str = None,
        modifier: ListPinSpacesResponseBodyResultItemsSpaceInfoModifier = None,
        name: str = None,
        pc_url: str = None,
    ):
        self.cover = cover
        self.create_time = create_time
        self.creator = creator
        self.description = description
        self.icon_vo = icon_vo
        self.id = id
        self.mobile_url = mobile_url
        self.modified_time = modified_time
        self.modifier = modifier
        self.name = name
        self.pc_url = pc_url

    def validate(self):
        if self.creator:
            self.creator.validate()
        if self.icon_vo:
            self.icon_vo.validate()
        if self.modifier:
            self.modifier.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cover is not None:
            result['cover'] = self.cover
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator is not None:
            result['creator'] = self.creator.to_map()
        if self.description is not None:
            result['description'] = self.description
        if self.icon_vo is not None:
            result['iconVO'] = self.icon_vo.to_map()
        if self.id is not None:
            result['id'] = self.id
        if self.mobile_url is not None:
            result['mobileUrl'] = self.mobile_url
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.modifier is not None:
            result['modifier'] = self.modifier.to_map()
        if self.name is not None:
            result['name'] = self.name
        if self.pc_url is not None:
            result['pcUrl'] = self.pc_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cover') is not None:
            self.cover = m.get('cover')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creator') is not None:
            temp_model = ListPinSpacesResponseBodyResultItemsSpaceInfoCreator()
            self.creator = temp_model.from_map(m['creator'])
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('iconVO') is not None:
            temp_model = ListPinSpacesResponseBodyResultItemsSpaceInfoIconVO()
            self.icon_vo = temp_model.from_map(m['iconVO'])
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('mobileUrl') is not None:
            self.mobile_url = m.get('mobileUrl')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('modifier') is not None:
            temp_model = ListPinSpacesResponseBodyResultItemsSpaceInfoModifier()
            self.modifier = temp_model.from_map(m['modifier'])
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('pcUrl') is not None:
            self.pc_url = m.get('pcUrl')
        return self


class ListPinSpacesResponseBodyResultItemsTeamInfo(TeaModel):
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


class ListPinSpacesResponseBodyResultItems(TeaModel):
    def __init__(
        self,
        create_time: str = None,
        modified_time: str = None,
        space_info: ListPinSpacesResponseBodyResultItemsSpaceInfo = None,
        space_permission_role: str = None,
        team_info: ListPinSpacesResponseBodyResultItemsTeamInfo = None,
    ):
        self.create_time = create_time
        self.modified_time = modified_time
        self.space_info = space_info
        self.space_permission_role = space_permission_role
        self.team_info = team_info

    def validate(self):
        if self.space_info:
            self.space_info.validate()
        if self.team_info:
            self.team_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.space_info is not None:
            result['spaceInfo'] = self.space_info.to_map()
        if self.space_permission_role is not None:
            result['spacePermissionRole'] = self.space_permission_role
        if self.team_info is not None:
            result['teamInfo'] = self.team_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('spaceInfo') is not None:
            temp_model = ListPinSpacesResponseBodyResultItemsSpaceInfo()
            self.space_info = temp_model.from_map(m['spaceInfo'])
        if m.get('spacePermissionRole') is not None:
            self.space_permission_role = m.get('spacePermissionRole')
        if m.get('teamInfo') is not None:
            temp_model = ListPinSpacesResponseBodyResultItemsTeamInfo()
            self.team_info = temp_model.from_map(m['teamInfo'])
        return self


class ListPinSpacesResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        result_items: List[ListPinSpacesResponseBodyResultItems] = None,
    ):
        self.next_token = next_token
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
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['resultItems'] = []
        if self.result_items is not None:
            for k in self.result_items:
                result['resultItems'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.result_items = []
        if m.get('resultItems') is not None:
            for k in m.get('resultItems'):
                temp_model = ListPinSpacesResponseBodyResultItems()
                self.result_items.append(temp_model.from_map(k))
        return self


class ListPinSpacesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListPinSpacesResponseBody = None,
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
            temp_model = ListPinSpacesResponseBody()
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
        self.operator_id = operator_id
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
        status_code: int = None,
        body: ListRelatedSpaceTeamsResponseBody = None,
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
        self.max_results = max_results
        self.next_token = next_token
        self.operator_id = operator_id
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
        self.has_more = has_more
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
        status_code: int = None,
        body: ListRelatedTeamsResponseBody = None,
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
        self.display_type = display_type
        self.id = id
        self.name = name
        self.space_num = space_num
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
        status_code: int = None,
        body: ListSpaceSectionsResponseBody = None,
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
            temp_model = ListSpaceSectionsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListStarsHeaders(TeaModel):
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


class ListStarsRequestOption(TeaModel):
    def __init__(
        self,
        content_type_list: List[str] = None,
        filter_doc_types: List[str] = None,
        list_v2: bool = None,
        max_results: int = None,
        next_token: str = None,
        order: str = None,
        order_by: str = None,
        with_dentry_creator_info: bool = None,
        with_dentry_modifier_info: bool = None,
        with_dentry_permission_role: bool = None,
        with_space_detail: bool = None,
        with_space_permission_role: bool = None,
        with_team_detail: bool = None,
    ):
        self.content_type_list = content_type_list
        self.filter_doc_types = filter_doc_types
        self.list_v2 = list_v2
        self.max_results = max_results
        self.next_token = next_token
        self.order = order
        self.order_by = order_by
        self.with_dentry_creator_info = with_dentry_creator_info
        self.with_dentry_modifier_info = with_dentry_modifier_info
        self.with_dentry_permission_role = with_dentry_permission_role
        self.with_space_detail = with_space_detail
        self.with_space_permission_role = with_space_permission_role
        self.with_team_detail = with_team_detail

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content_type_list is not None:
            result['contentTypeList'] = self.content_type_list
        if self.filter_doc_types is not None:
            result['filterDocTypes'] = self.filter_doc_types
        if self.list_v2 is not None:
            result['listV2'] = self.list_v2
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.order is not None:
            result['order'] = self.order
        if self.order_by is not None:
            result['orderBy'] = self.order_by
        if self.with_dentry_creator_info is not None:
            result['withDentryCreatorInfo'] = self.with_dentry_creator_info
        if self.with_dentry_modifier_info is not None:
            result['withDentryModifierInfo'] = self.with_dentry_modifier_info
        if self.with_dentry_permission_role is not None:
            result['withDentryPermissionRole'] = self.with_dentry_permission_role
        if self.with_space_detail is not None:
            result['withSpaceDetail'] = self.with_space_detail
        if self.with_space_permission_role is not None:
            result['withSpacePermissionRole'] = self.with_space_permission_role
        if self.with_team_detail is not None:
            result['withTeamDetail'] = self.with_team_detail
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('contentTypeList') is not None:
            self.content_type_list = m.get('contentTypeList')
        if m.get('filterDocTypes') is not None:
            self.filter_doc_types = m.get('filterDocTypes')
        if m.get('listV2') is not None:
            self.list_v2 = m.get('listV2')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('order') is not None:
            self.order = m.get('order')
        if m.get('orderBy') is not None:
            self.order_by = m.get('orderBy')
        if m.get('withDentryCreatorInfo') is not None:
            self.with_dentry_creator_info = m.get('withDentryCreatorInfo')
        if m.get('withDentryModifierInfo') is not None:
            self.with_dentry_modifier_info = m.get('withDentryModifierInfo')
        if m.get('withDentryPermissionRole') is not None:
            self.with_dentry_permission_role = m.get('withDentryPermissionRole')
        if m.get('withSpaceDetail') is not None:
            self.with_space_detail = m.get('withSpaceDetail')
        if m.get('withSpacePermissionRole') is not None:
            self.with_space_permission_role = m.get('withSpacePermissionRole')
        if m.get('withTeamDetail') is not None:
            self.with_team_detail = m.get('withTeamDetail')
        return self


class ListStarsRequest(TeaModel):
    def __init__(
        self,
        option: ListStarsRequestOption = None,
        operator_id: str = None,
    ):
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
        if self.option is not None:
            result['option'] = self.option.to_map()
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('option') is not None:
            temp_model = ListStarsRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class ListStarsResponseBodyStarListDentryInfoCreator(TeaModel):
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


class ListStarsResponseBodyStarListDentryInfoModifier(TeaModel):
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


class ListStarsResponseBodyStarListDentryInfo(TeaModel):
    def __init__(
        self,
        create_time: str = None,
        creator: ListStarsResponseBodyStarListDentryInfoCreator = None,
        extension: str = None,
        id: str = None,
        mobile_url: str = None,
        modified_time: str = None,
        modifier: ListStarsResponseBodyStarListDentryInfoModifier = None,
        name: str = None,
        pc_url: str = None,
        space_id: str = None,
        status: str = None,
        type: str = None,
        uuid: str = None,
    ):
        self.create_time = create_time
        self.creator = creator
        self.extension = extension
        self.id = id
        self.mobile_url = mobile_url
        self.modified_time = modified_time
        self.modifier = modifier
        self.name = name
        self.pc_url = pc_url
        self.space_id = space_id
        self.status = status
        self.type = type
        self.uuid = uuid

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
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator is not None:
            result['creator'] = self.creator.to_map()
        if self.extension is not None:
            result['extension'] = self.extension
        if self.id is not None:
            result['id'] = self.id
        if self.mobile_url is not None:
            result['mobileUrl'] = self.mobile_url
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.modifier is not None:
            result['modifier'] = self.modifier.to_map()
        if self.name is not None:
            result['name'] = self.name
        if self.pc_url is not None:
            result['pcUrl'] = self.pc_url
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.status is not None:
            result['status'] = self.status
        if self.type is not None:
            result['type'] = self.type
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creator') is not None:
            temp_model = ListStarsResponseBodyStarListDentryInfoCreator()
            self.creator = temp_model.from_map(m['creator'])
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('mobileUrl') is not None:
            self.mobile_url = m.get('mobileUrl')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('modifier') is not None:
            temp_model = ListStarsResponseBodyStarListDentryInfoModifier()
            self.modifier = temp_model.from_map(m['modifier'])
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('pcUrl') is not None:
            self.pc_url = m.get('pcUrl')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class ListStarsResponseBodyStarListSpaceInfo(TeaModel):
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


class ListStarsResponseBodyStarListTeamInfo(TeaModel):
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


class ListStarsResponseBodyStarList(TeaModel):
    def __init__(
        self,
        create_time: str = None,
        dentry_info: ListStarsResponseBodyStarListDentryInfo = None,
        dentry_permission_role: str = None,
        id: str = None,
        is_deleted: bool = None,
        modified_time: str = None,
        space_info: ListStarsResponseBodyStarListSpaceInfo = None,
        space_permission_role: str = None,
        star_type: str = None,
        team_info: ListStarsResponseBodyStarListTeamInfo = None,
    ):
        self.create_time = create_time
        self.dentry_info = dentry_info
        self.dentry_permission_role = dentry_permission_role
        self.id = id
        self.is_deleted = is_deleted
        self.modified_time = modified_time
        self.space_info = space_info
        self.space_permission_role = space_permission_role
        self.star_type = star_type
        self.team_info = team_info

    def validate(self):
        if self.dentry_info:
            self.dentry_info.validate()
        if self.space_info:
            self.space_info.validate()
        if self.team_info:
            self.team_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.dentry_info is not None:
            result['dentryInfo'] = self.dentry_info.to_map()
        if self.dentry_permission_role is not None:
            result['dentryPermissionRole'] = self.dentry_permission_role
        if self.id is not None:
            result['id'] = self.id
        if self.is_deleted is not None:
            result['isDeleted'] = self.is_deleted
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.space_info is not None:
            result['spaceInfo'] = self.space_info.to_map()
        if self.space_permission_role is not None:
            result['spacePermissionRole'] = self.space_permission_role
        if self.star_type is not None:
            result['starType'] = self.star_type
        if self.team_info is not None:
            result['teamInfo'] = self.team_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('dentryInfo') is not None:
            temp_model = ListStarsResponseBodyStarListDentryInfo()
            self.dentry_info = temp_model.from_map(m['dentryInfo'])
        if m.get('dentryPermissionRole') is not None:
            self.dentry_permission_role = m.get('dentryPermissionRole')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isDeleted') is not None:
            self.is_deleted = m.get('isDeleted')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('spaceInfo') is not None:
            temp_model = ListStarsResponseBodyStarListSpaceInfo()
            self.space_info = temp_model.from_map(m['spaceInfo'])
        if m.get('spacePermissionRole') is not None:
            self.space_permission_role = m.get('spacePermissionRole')
        if m.get('starType') is not None:
            self.star_type = m.get('starType')
        if m.get('teamInfo') is not None:
            temp_model = ListStarsResponseBodyStarListTeamInfo()
            self.team_info = temp_model.from_map(m['teamInfo'])
        return self


class ListStarsResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        star_list: List[ListStarsResponseBodyStarList] = None,
    ):
        self.next_token = next_token
        self.star_list = star_list

    def validate(self):
        if self.star_list:
            for k in self.star_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['starList'] = []
        if self.star_list is not None:
            for k in self.star_list:
                result['starList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.star_list = []
        if m.get('starList') is not None:
            for k in m.get('starList'):
                temp_model = ListStarsResponseBodyStarList()
                self.star_list.append(temp_model.from_map(k))
        return self


class ListStarsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListStarsResponseBody = None,
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
            temp_model = ListStarsResponseBody()
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
        self.member_id = member_id
        self.member_type = member_type
        self.name = name
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
        self.members = members
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
        status_code: int = None,
        body: ListTeamMembersResponseBody = None,
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
            temp_model = ListTeamMembersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class MarkStarHeaders(TeaModel):
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


class MarkStarRequest(TeaModel):
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


class MarkStarResponseBody(TeaModel):
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


class MarkStarResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: MarkStarResponseBody = None,
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
            temp_model = MarkStarResponseBody()
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
        self.operator_id = operator_id
        self.target_space_id = target_space_id
        self.to_next_dentry_id = to_next_dentry_id
        self.to_parent_dentry_id = to_parent_dentry_id
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
        status_code: int = None,
        body: DentryVO = None,
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
            temp_model = DentryVO()
            self.body = temp_model.from_map(m['body'])
        return self


class PinSpaceHeaders(TeaModel):
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


class PinSpaceRequest(TeaModel):
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


class PinSpaceResponseBody(TeaModel):
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


class PinSpaceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PinSpaceResponseBody = None,
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
            temp_model = PinSpaceResponseBody()
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
        self.include_space = include_space
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
        status_code: int = None,
        body: DentryVO = None,
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
        with_statistical_info: bool = None,
    ):
        self.operator_id = operator_id
        self.url = url
        self.with_statistical_info = with_statistical_info

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
        if self.with_statistical_info is not None:
            result['withStatisticalInfo'] = self.with_statistical_info
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('withStatisticalInfo') is not None:
            self.with_statistical_info = m.get('withStatisticalInfo')
        return self


class QueryItemByUrlResponseBodySpaceOwner(TeaModel):
    def __init__(
        self,
        name: str = None,
        union_id: str = None,
    ):
        self.name = name
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
        self.description = description
        self.id = id
        self.name = name
        self.owner = owner
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
        self.biz_type = biz_type
        self.dentry = dentry
        self.resource_type = resource_type
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
        status_code: int = None,
        body: QueryItemByUrlResponseBody = None,
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
        status_code: int = None,
        body: SpaceVO = None,
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
        self.creator_type = creator_type
        self.file_type = file_type
        self.max_results = max_results
        self.next_token = next_token
        self.operator_id = operator_id
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


class QueryRecentListResponseBodyRecentListTeam(TeaModel):
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


class QueryRecentListResponseBodyRecentList(TeaModel):
    def __init__(
        self,
        deleted: bool = None,
        dentry: DentryModel = None,
        recent_time: int = None,
        team: QueryRecentListResponseBodyRecentListTeam = None,
    ):
        self.deleted = deleted
        self.dentry = dentry
        self.recent_time = recent_time
        self.team = team

    def validate(self):
        if self.dentry:
            self.dentry.validate()
        if self.team:
            self.team.validate()

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
        if self.team is not None:
            result['team'] = self.team.to_map()
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
        if m.get('team') is not None:
            temp_model = QueryRecentListResponseBodyRecentListTeam()
            self.team = temp_model.from_map(m['team'])
        return self


class QueryRecentListResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        next_token: str = None,
        recent_list: List[QueryRecentListResponseBodyRecentList] = None,
    ):
        self.has_more = has_more
        self.next_token = next_token
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
        status_code: int = None,
        body: QueryRecentListResponseBody = None,
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
        status_code: int = None,
        body: SpaceVO = None,
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
        self.max_results = max_results
        self.next_token = next_token
        self.operator_id = operator_id
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


class RelatedSpacesResponseBodyItemsHdIconVO(TeaModel):
    def __init__(
        self,
        icon: str = None,
        type: str = None,
    ):
        self.icon = icon
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


class RelatedSpacesResponseBodyItemsIconVO(TeaModel):
    def __init__(
        self,
        icon: str = None,
        type: str = None,
    ):
        self.icon = icon
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


class RelatedSpacesResponseBodyItemsOwner(TeaModel):
    def __init__(
        self,
        name: str = None,
        union_id: str = None,
    ):
        self.name = name
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


class RelatedSpacesResponseBodyItemsVisitorInfo(TeaModel):
    def __init__(
        self,
        dentry_actions: List[str] = None,
        pinned: bool = None,
        role_code: str = None,
        space_actions: List[str] = None,
    ):
        self.dentry_actions = dentry_actions
        self.pinned = pinned
        self.role_code = role_code
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
        if self.pinned is not None:
            result['pinned'] = self.pinned
        if self.role_code is not None:
            result['roleCode'] = self.role_code
        if self.space_actions is not None:
            result['spaceActions'] = self.space_actions
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentryActions') is not None:
            self.dentry_actions = m.get('dentryActions')
        if m.get('pinned') is not None:
            self.pinned = m.get('pinned')
        if m.get('roleCode') is not None:
            self.role_code = m.get('roleCode')
        if m.get('spaceActions') is not None:
            self.space_actions = m.get('spaceActions')
        return self


class RelatedSpacesResponseBodyItems(TeaModel):
    def __init__(
        self,
        cover: str = None,
        description: str = None,
        hd_icon_vo: RelatedSpacesResponseBodyItemsHdIconVO = None,
        icon_vo: RelatedSpacesResponseBodyItemsIconVO = None,
        id: str = None,
        name: str = None,
        owner: RelatedSpacesResponseBodyItemsOwner = None,
        recent_list: List[DentryModel] = None,
        type: int = None,
        url: str = None,
        visitor_info: RelatedSpacesResponseBodyItemsVisitorInfo = None,
    ):
        self.cover = cover
        self.description = description
        self.hd_icon_vo = hd_icon_vo
        self.icon_vo = icon_vo
        self.id = id
        self.name = name
        self.owner = owner
        self.recent_list = recent_list
        self.type = type
        self.url = url
        self.visitor_info = visitor_info

    def validate(self):
        if self.hd_icon_vo:
            self.hd_icon_vo.validate()
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
        if self.hd_icon_vo is not None:
            result['hdIconVO'] = self.hd_icon_vo.to_map()
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
        if m.get('hdIconVO') is not None:
            temp_model = RelatedSpacesResponseBodyItemsHdIconVO()
            self.hd_icon_vo = temp_model.from_map(m['hdIconVO'])
        if m.get('iconVO') is not None:
            temp_model = RelatedSpacesResponseBodyItemsIconVO()
            self.icon_vo = temp_model.from_map(m['iconVO'])
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('owner') is not None:
            temp_model = RelatedSpacesResponseBodyItemsOwner()
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
            temp_model = RelatedSpacesResponseBodyItemsVisitorInfo()
            self.visitor_info = temp_model.from_map(m['visitorInfo'])
        return self


class RelatedSpacesResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        items: List[RelatedSpacesResponseBodyItems] = None,
        next_token: str = None,
    ):
        self.has_more = has_more
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
                temp_model = RelatedSpacesResponseBodyItems()
                self.items.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class RelatedSpacesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RelatedSpacesResponseBody = None,
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
        self.member_id = member_id
        self.member_type = member_type
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
        self.members = members
        self.notify = notify
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
        self.member_id = member_id
        self.member_type = member_type
        self.name = name
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
        self.not_in_org_members = not_in_org_members
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
        status_code: int = None,
        body: RemoveTeamMembersResponseBody = None,
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
        self.name = name
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
        status_code: int = None,
        body: DentryVO = None,
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
        self.member_id = member_id
        self.member_type = member_type
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
        self.members = members
        self.notify = notify
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
        self.member_id = member_id
        self.member_type = member_type
        self.name = name
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
        self.not_in_org_members = not_in_org_members
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
        status_code: int = None,
        body: SaveTeamMembersResponseBody = None,
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
        self.end = end
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
        space_ids: List[str] = None,
        summary_length: int = None,
        visit_time_range: SearchRequestDentryRequestVisitTimeRange = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        self.search_field = search_field
        self.search_file_type = search_file_type
        self.space_id = space_id
        self.space_ids = space_ids
        self.summary_length = summary_length
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
        if self.space_ids is not None:
            result['spaceIds'] = self.space_ids
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
        if m.get('spaceIds') is not None:
            self.space_ids = m.get('spaceIds')
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
        with_team_info: bool = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        self.with_team_info = with_team_info

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
        if self.with_team_info is not None:
            result['withTeamInfo'] = self.with_team_info
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('withTeamInfo') is not None:
            self.with_team_info = m.get('withTeamInfo')
        return self


class SearchRequest(TeaModel):
    def __init__(
        self,
        dentry_request: SearchRequestDentryRequest = None,
        keyword: str = None,
        operator_id: str = None,
        space_request: SearchRequestSpaceRequest = None,
    ):
        self.dentry_request = dentry_request
        self.keyword = keyword
        self.operator_id = operator_id
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
        self.content = content
        self.creation = creation
        self.dentry_id = dentry_id
        self.dentry_uuid = dentry_uuid
        self.extension = extension
        self.icon_url = icon_url
        self.last_edition = last_edition
        self.name = name
        self.origin_name = origin_name
        self.path = path
        self.scene_type = scene_type
        self.search_file_type = search_file_type
        self.space_id = space_id
        self.thumbnail_url = thumbnail_url
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
        self.has_more = has_more
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
        self.icon = icon
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


class SearchResponseBodySpaceResultItemsTeamVO(TeaModel):
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


class SearchResponseBodySpaceResultItemsUserLastOperation(TeaModel):
    def __init__(
        self,
        name: str = None,
        time: int = None,
    ):
        self.name = name
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
        team_vo: SearchResponseBodySpaceResultItemsTeamVO = None,
        url: str = None,
        user_last_operation: SearchResponseBodySpaceResultItemsUserLastOperation = None,
    ):
        self.icon_vo = icon_vo
        self.name = name
        self.origin_name = origin_name
        self.space_id = space_id
        self.team_vo = team_vo
        self.url = url
        self.user_last_operation = user_last_operation

    def validate(self):
        if self.icon_vo:
            self.icon_vo.validate()
        if self.team_vo:
            self.team_vo.validate()
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
        if self.team_vo is not None:
            result['teamVO'] = self.team_vo.to_map()
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
        if m.get('teamVO') is not None:
            temp_model = SearchResponseBodySpaceResultItemsTeamVO()
            self.team_vo = temp_model.from_map(m['teamVO'])
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
        self.has_more = has_more
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
        self.dentry_result = dentry_result
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
        status_code: int = None,
        body: SearchResponseBody = None,
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
            temp_model = SearchResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UnmarkStarHeaders(TeaModel):
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


class UnmarkStarRequest(TeaModel):
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


class UnmarkStarResponseBody(TeaModel):
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


class UnmarkStarResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UnmarkStarResponseBody = None,
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
            temp_model = UnmarkStarResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UnpinSpaceHeaders(TeaModel):
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


class UnpinSpaceRequest(TeaModel):
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


class UnpinSpaceResponseBody(TeaModel):
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


class UnpinSpaceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UnpinSpaceResponseBody = None,
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
            temp_model = UnpinSpaceResponseBody()
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
        self.description = description
        self.name = name
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
        status_code: int = None,
        body: TeamVO = None,
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
            temp_model = TeamVO()
            self.body = temp_model.from_map(m['body'])
        return self


