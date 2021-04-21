# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class AddFileHeaders(TeaModel):
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


class AddFileRequest(TeaModel):
    def __init__(
        self,
        parent_id: str = None,
        file_type: str = None,
        file_name: str = None,
        media_id: str = None,
        add_conflict_policy: str = None,
    ):
        # 父目录id
        self.parent_id = parent_id
        # 文件类型
        self.file_type = file_type
        # 文件名
        self.file_name = file_name
        # mediaId
        self.media_id = media_id
        # 文件名冲突策略
        self.add_conflict_policy = add_conflict_policy

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.parent_id is not None:
            result['parentId'] = self.parent_id
        if self.file_type is not None:
            result['fileType'] = self.file_type
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.media_id is not None:
            result['mediaId'] = self.media_id
        if self.add_conflict_policy is not None:
            result['addConflictPolicy'] = self.add_conflict_policy
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('parentId') is not None:
            self.parent_id = m.get('parentId')
        if m.get('fileType') is not None:
            self.file_type = m.get('fileType')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('mediaId') is not None:
            self.media_id = m.get('mediaId')
        if m.get('addConflictPolicy') is not None:
            self.add_conflict_policy = m.get('addConflictPolicy')
        return self


class AddFileResponseBody(TeaModel):
    def __init__(
        self,
        space_id: str = None,
        file_id: str = None,
        file_name: str = None,
        file_path: str = None,
        file_type: str = None,
        file_extension: str = None,
    ):
        # 空间id
        self.space_id = space_id
        # 文件id
        self.file_id = file_id
        # 文件名称
        self.file_name = file_name
        # 文件路径
        self.file_path = file_path
        # 文件类型
        self.file_type = file_type
        # 文件后缀
        self.file_extension = file_extension

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.file_path is not None:
            result['filePath'] = self.file_path
        if self.file_type is not None:
            result['fileType'] = self.file_type
        if self.file_extension is not None:
            result['fileExtension'] = self.file_extension
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('filePath') is not None:
            self.file_path = m.get('filePath')
        if m.get('fileType') is not None:
            self.file_type = m.get('fileType')
        if m.get('fileExtension') is not None:
            self.file_extension = m.get('fileExtension')
        return self


class AddFileResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: AddFileResponseBody = None,
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
            temp_model = AddFileResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RecoverRecycleFilesHeaders(TeaModel):
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


class RecoverRecycleFilesRequest(TeaModel):
    def __init__(
        self,
        recycle_item_id_list: List[int] = None,
        recycle_type: str = None,
    ):
        # 回收站item id列表
        self.recycle_item_id_list = recycle_item_id_list
        # 回收站类型
        self.recycle_type = recycle_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.recycle_item_id_list is not None:
            result['recycleItemIdList'] = self.recycle_item_id_list
        if self.recycle_type is not None:
            result['recycleType'] = self.recycle_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('recycleItemIdList') is not None:
            self.recycle_item_id_list = m.get('recycleItemIdList')
        if m.get('recycleType') is not None:
            self.recycle_type = m.get('recycleType')
        return self


class RecoverRecycleFilesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        return self


class DeleteRecycleFilesHeaders(TeaModel):
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


class DeleteRecycleFilesRequest(TeaModel):
    def __init__(
        self,
        recycle_item_id_list: List[int] = None,
        recycle_type: str = None,
    ):
        # 回收站item id列表
        self.recycle_item_id_list = recycle_item_id_list
        # 回收站类型
        self.recycle_type = recycle_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.recycle_item_id_list is not None:
            result['recycleItemIdList'] = self.recycle_item_id_list
        if self.recycle_type is not None:
            result['recycleType'] = self.recycle_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('recycleItemIdList') is not None:
            self.recycle_item_id_list = m.get('recycleItemIdList')
        if m.get('recycleType') is not None:
            self.recycle_type = m.get('recycleType')
        return self


class DeleteRecycleFilesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        return self


class GetFileInfoHeaders(TeaModel):
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


class GetFileInfoResponseBody(TeaModel):
    def __init__(
        self,
        space_id: str = None,
        file_id: str = None,
        file_name: str = None,
        file_path: str = None,
        file_type: str = None,
        file_extension: str = None,
    ):
        # 空间id
        self.space_id = space_id
        # 文件id
        self.file_id = file_id
        # 文件名称
        self.file_name = file_name
        # 文件路径
        self.file_path = file_path
        # 文件类型
        self.file_type = file_type
        # 文件后缀
        self.file_extension = file_extension

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.file_path is not None:
            result['filePath'] = self.file_path
        if self.file_type is not None:
            result['fileType'] = self.file_type
        if self.file_extension is not None:
            result['fileExtension'] = self.file_extension
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('filePath') is not None:
            self.file_path = m.get('filePath')
        if m.get('fileType') is not None:
            self.file_type = m.get('fileType')
        if m.get('fileExtension') is not None:
            self.file_extension = m.get('fileExtension')
        return self


class GetFileInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetFileInfoResponseBody = None,
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
            temp_model = GetFileInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListRecycleFilesHeaders(TeaModel):
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


class ListRecycleFilesRequest(TeaModel):
    def __init__(
        self,
        recycle_type: str = None,
        next_token: str = None,
        max_results: int = None,
        order_type: str = None,
    ):
        # 回收站类型
        self.recycle_type = recycle_type
        # 分页加载更多锚点
        self.next_token = next_token
        # 分页长度
        self.max_results = max_results
        # 文件排序类型
        self.order_type = order_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.recycle_type is not None:
            result['recycleType'] = self.recycle_type
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.order_type is not None:
            result['orderType'] = self.order_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('recycleType') is not None:
            self.recycle_type = m.get('recycleType')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('orderType') is not None:
            self.order_type = m.get('orderType')
        return self


class ListRecycleFilesResponseBodyRecycleItems(TeaModel):
    def __init__(
        self,
        recycle_item_id: str = None,
        delete_uid: int = None,
        delete_time: str = None,
        file_size: int = None,
        file_type: str = None,
        content_type: str = None,
        file_name: str = None,
        file_path: str = None,
    ):
        # 回收站item id
        self.recycle_item_id = recycle_item_id
        # 删除者id
        self.delete_uid = delete_uid
        # 删除时间
        self.delete_time = delete_time
        # 文件大小
        self.file_size = file_size
        # 文件类型
        self.file_type = file_type
        # 文件内容类型
        self.content_type = content_type
        # 文件名称
        self.file_name = file_name
        # 文件路径
        self.file_path = file_path

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.recycle_item_id is not None:
            result['recycleItemId'] = self.recycle_item_id
        if self.delete_uid is not None:
            result['deleteUid'] = self.delete_uid
        if self.delete_time is not None:
            result['deleteTime'] = self.delete_time
        if self.file_size is not None:
            result['fileSize'] = self.file_size
        if self.file_type is not None:
            result['fileType'] = self.file_type
        if self.content_type is not None:
            result['contentType'] = self.content_type
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.file_path is not None:
            result['filePath'] = self.file_path
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('recycleItemId') is not None:
            self.recycle_item_id = m.get('recycleItemId')
        if m.get('deleteUid') is not None:
            self.delete_uid = m.get('deleteUid')
        if m.get('deleteTime') is not None:
            self.delete_time = m.get('deleteTime')
        if m.get('fileSize') is not None:
            self.file_size = m.get('fileSize')
        if m.get('fileType') is not None:
            self.file_type = m.get('fileType')
        if m.get('contentType') is not None:
            self.content_type = m.get('contentType')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('filePath') is not None:
            self.file_path = m.get('filePath')
        return self


class ListRecycleFilesResponseBody(TeaModel):
    def __init__(
        self,
        recycle_items: List[ListRecycleFilesResponseBodyRecycleItems] = None,
        next_token: str = None,
    ):
        # 回收站文件列表
        self.recycle_items = recycle_items
        # 加载更多锚点, nextToken不为空表示有更多数据
        self.next_token = next_token

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
        result['recycleItems'] = []
        if self.recycle_items is not None:
            for k in self.recycle_items:
                result['recycleItems'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.recycle_items = []
        if m.get('recycleItems') is not None:
            for k in m.get('recycleItems'):
                temp_model = ListRecycleFilesResponseBodyRecycleItems()
                self.recycle_items.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class ListRecycleFilesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListRecycleFilesResponseBody = None,
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
            temp_model = ListRecycleFilesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RenameFileHeaders(TeaModel):
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


class RenameFileRequest(TeaModel):
    def __init__(
        self,
        new_file_name: str = None,
    ):
        # 新文件名称
        self.new_file_name = new_file_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.new_file_name is not None:
            result['newFileName'] = self.new_file_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('newFileName') is not None:
            self.new_file_name = m.get('newFileName')
        return self


class RenameFileResponseBody(TeaModel):
    def __init__(
        self,
        space_id: str = None,
        file_id: str = None,
        file_name: str = None,
        file_path: str = None,
        file_type: str = None,
        file_extension: str = None,
    ):
        # 空间id
        self.space_id = space_id
        # 文件id
        self.file_id = file_id
        # 文件名称
        self.file_name = file_name
        # 文件路径
        self.file_path = file_path
        # 文件类型
        self.file_type = file_type
        # 文件后缀
        self.file_extension = file_extension

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.file_path is not None:
            result['filePath'] = self.file_path
        if self.file_type is not None:
            result['fileType'] = self.file_type
        if self.file_extension is not None:
            result['fileExtension'] = self.file_extension
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('filePath') is not None:
            self.file_path = m.get('filePath')
        if m.get('fileType') is not None:
            self.file_type = m.get('fileType')
        if m.get('fileExtension') is not None:
            self.file_extension = m.get('fileExtension')
        return self


class RenameFileResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: RenameFileResponseBody = None,
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
            temp_model = RenameFileResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListFilesHeaders(TeaModel):
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


class ListFilesRequest(TeaModel):
    def __init__(
        self,
        parent_id: str = None,
        next_token: str = None,
        max_results: int = None,
    ):
        # 父目录id
        self.parent_id = parent_id
        # 分页查询锚点
        self.next_token = next_token
        # 分页长度
        self.max_results = max_results

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.parent_id is not None:
            result['parentId'] = self.parent_id
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('parentId') is not None:
            self.parent_id = m.get('parentId')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        return self


class ListFilesResponseBodyFiles(TeaModel):
    def __init__(
        self,
        space_id: str = None,
        file_id: str = None,
        file_name: str = None,
        file_path: str = None,
        file_type: str = None,
        file_extension: str = None,
    ):
        # 空间id
        self.space_id = space_id
        # 文件id
        self.file_id = file_id
        # 文件名称
        self.file_name = file_name
        # 文件路径
        self.file_path = file_path
        # 文件类型
        self.file_type = file_type
        # 文件后缀
        self.file_extension = file_extension

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.file_path is not None:
            result['filePath'] = self.file_path
        if self.file_type is not None:
            result['fileType'] = self.file_type
        if self.file_extension is not None:
            result['fileExtension'] = self.file_extension
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('filePath') is not None:
            self.file_path = m.get('filePath')
        if m.get('fileType') is not None:
            self.file_type = m.get('fileType')
        if m.get('fileExtension') is not None:
            self.file_extension = m.get('fileExtension')
        return self


class ListFilesResponseBody(TeaModel):
    def __init__(
        self,
        files: List[ListFilesResponseBodyFiles] = None,
        next_token: str = None,
    ):
        # 文件列表
        self.files = files
        # 分页加载锚点, nextToken不为空表示有更多数据
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
                temp_model = ListFilesResponseBodyFiles()
                self.files.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class ListFilesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListFilesResponseBody = None,
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
            temp_model = ListFilesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class MoveFileHeaders(TeaModel):
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


class MoveFileRequest(TeaModel):
    def __init__(
        self,
        target_space_id: str = None,
        target_parent_id: str = None,
        add_conflict_policy: str = None,
    ):
        # 目标空间id
        self.target_space_id = target_space_id
        # 目标父目录id
        self.target_parent_id = target_parent_id
        # 文件名冲突策略
        self.add_conflict_policy = add_conflict_policy

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.target_space_id is not None:
            result['targetSpaceId'] = self.target_space_id
        if self.target_parent_id is not None:
            result['targetParentId'] = self.target_parent_id
        if self.add_conflict_policy is not None:
            result['addConflictPolicy'] = self.add_conflict_policy
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('targetSpaceId') is not None:
            self.target_space_id = m.get('targetSpaceId')
        if m.get('targetParentId') is not None:
            self.target_parent_id = m.get('targetParentId')
        if m.get('addConflictPolicy') is not None:
            self.add_conflict_policy = m.get('addConflictPolicy')
        return self


class MoveFileResponseBody(TeaModel):
    def __init__(
        self,
        space_id: str = None,
        file_id: str = None,
        file_name: str = None,
        file_path: str = None,
        file_type: str = None,
        file_extension: str = None,
    ):
        # 空间id
        self.space_id = space_id
        # 文件id
        self.file_id = file_id
        # 文件名称
        self.file_name = file_name
        # 文件路径
        self.file_path = file_path
        # 文件类型
        self.file_type = file_type
        # 文件后缀
        self.file_extension = file_extension

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.file_path is not None:
            result['filePath'] = self.file_path
        if self.file_type is not None:
            result['fileType'] = self.file_type
        if self.file_extension is not None:
            result['fileExtension'] = self.file_extension
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('filePath') is not None:
            self.file_path = m.get('filePath')
        if m.get('fileType') is not None:
            self.file_type = m.get('fileType')
        if m.get('fileExtension') is not None:
            self.file_extension = m.get('fileExtension')
        return self


class MoveFileResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: MoveFileResponseBody = None,
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
            temp_model = MoveFileResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetDownloadInfoHeaders(TeaModel):
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


class GetDownloadInfoResponseBodyDownloadInfo(TeaModel):
    def __init__(
        self,
        resource_url: str = None,
        expiration_seconds: int = None,
        headers: Dict[str, Any] = None,
    ):
        # 加签url
        self.resource_url = resource_url
        # 加签url过期时间
        self.expiration_seconds = expiration_seconds
        # headers
        self.headers = headers

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.resource_url is not None:
            result['resourceUrl'] = self.resource_url
        if self.expiration_seconds is not None:
            result['expirationSeconds'] = self.expiration_seconds
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('resourceUrl') is not None:
            self.resource_url = m.get('resourceUrl')
        if m.get('expirationSeconds') is not None:
            self.expiration_seconds = m.get('expirationSeconds')
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        return self


class GetDownloadInfoResponseBody(TeaModel):
    def __init__(
        self,
        download_info: GetDownloadInfoResponseBodyDownloadInfo = None,
    ):
        # 下载加签url信息
        self.download_info = download_info

    def validate(self):
        if self.download_info:
            self.download_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.download_info is not None:
            result['downloadInfo'] = self.download_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('downloadInfo') is not None:
            temp_model = GetDownloadInfoResponseBodyDownloadInfo()
            self.download_info = temp_model.from_map(m['downloadInfo'])
        return self


class GetDownloadInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetDownloadInfoResponseBody = None,
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
            temp_model = GetDownloadInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetUploadInfoHeaders(TeaModel):
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


class GetUploadInfoRequest(TeaModel):
    def __init__(
        self,
        file_name: str = None,
        file_size: int = None,
        md_5: str = None,
        add_conflict_policy: str = None,
        media_id: str = None,
    ):
        # 文件名
        self.file_name = file_name
        # 文件大小
        self.file_size = file_size
        # 文件md5
        self.md_5 = md_5
        # 文件名称冲突策略
        self.add_conflict_policy = add_conflict_policy
        # mediaId
        self.media_id = media_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.file_size is not None:
            result['fileSize'] = self.file_size
        if self.md_5 is not None:
            result['md5'] = self.md_5
        if self.add_conflict_policy is not None:
            result['addConflictPolicy'] = self.add_conflict_policy
        if self.media_id is not None:
            result['mediaId'] = self.media_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('fileSize') is not None:
            self.file_size = m.get('fileSize')
        if m.get('md5') is not None:
            self.md_5 = m.get('md5')
        if m.get('addConflictPolicy') is not None:
            self.add_conflict_policy = m.get('addConflictPolicy')
        if m.get('mediaId') is not None:
            self.media_id = m.get('mediaId')
        return self


class GetUploadInfoResponseBodyStsUploadInfo(TeaModel):
    def __init__(
        self,
        bucket: str = None,
        end_point: str = None,
        access_key_id: str = None,
        access_key_secret: str = None,
        access_token: str = None,
        access_token_expiration_millis: int = None,
        media_id: str = None,
    ):
        # bucket
        self.bucket = bucket
        # endPoint
        self.end_point = end_point
        # accessKeyId
        self.access_key_id = access_key_id
        # accessKeySecret
        self.access_key_secret = access_key_secret
        # accessToken
        self.access_token = access_token
        # accessTokenExpiration
        self.access_token_expiration_millis = access_token_expiration_millis
        # mediaId
        self.media_id = media_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.bucket is not None:
            result['bucket'] = self.bucket
        if self.end_point is not None:
            result['endPoint'] = self.end_point
        if self.access_key_id is not None:
            result['accessKeyId'] = self.access_key_id
        if self.access_key_secret is not None:
            result['accessKeySecret'] = self.access_key_secret
        if self.access_token is not None:
            result['accessToken'] = self.access_token
        if self.access_token_expiration_millis is not None:
            result['accessTokenExpirationMillis'] = self.access_token_expiration_millis
        if self.media_id is not None:
            result['mediaId'] = self.media_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bucket') is not None:
            self.bucket = m.get('bucket')
        if m.get('endPoint') is not None:
            self.end_point = m.get('endPoint')
        if m.get('accessKeyId') is not None:
            self.access_key_id = m.get('accessKeyId')
        if m.get('accessKeySecret') is not None:
            self.access_key_secret = m.get('accessKeySecret')
        if m.get('accessToken') is not None:
            self.access_token = m.get('accessToken')
        if m.get('accessTokenExpirationMillis') is not None:
            self.access_token_expiration_millis = m.get('accessTokenExpirationMillis')
        if m.get('mediaId') is not None:
            self.media_id = m.get('mediaId')
        return self


class GetUploadInfoResponseBody(TeaModel):
    def __init__(
        self,
        sts_upload_info: GetUploadInfoResponseBodyStsUploadInfo = None,
    ):
        self.sts_upload_info = sts_upload_info

    def validate(self):
        if self.sts_upload_info:
            self.sts_upload_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sts_upload_info is not None:
            result['stsUploadInfo'] = self.sts_upload_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('stsUploadInfo') is not None:
            temp_model = GetUploadInfoResponseBodyStsUploadInfo()
            self.sts_upload_info = temp_model.from_map(m['stsUploadInfo'])
        return self


class GetUploadInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetUploadInfoResponseBody = None,
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
            temp_model = GetUploadInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListSpacesHeaders(TeaModel):
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


class ListSpacesRequest(TeaModel):
    def __init__(
        self,
        space_type: str = None,
        next_token: str = None,
        max_results: int = None,
    ):
        # 空间类型
        self.space_type = space_type
        # 分页加载锚点
        self.next_token = next_token
        # 分页大小
        self.max_results = max_results

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.space_type is not None:
            result['spaceType'] = self.space_type
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('spaceType') is not None:
            self.space_type = m.get('spaceType')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        return self


class ListSpacesResponseBodySpaces(TeaModel):
    def __init__(
        self,
        space_id: str = None,
        space_name: str = None,
        space_type: str = None,
        quota: int = None,
        used_quota: int = None,
        create_time: str = None,
        modify_time: str = None,
    ):
        # 空间id
        self.space_id = space_id
        # 空间名称
        self.space_name = space_name
        # 空间类型
        self.space_type = space_type
        # 空间总额度
        self.quota = quota
        # 空间已使用额度
        self.used_quota = used_quota
        # 创建时间
        self.create_time = create_time
        # 修改时间
        self.modify_time = modify_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.space_name is not None:
            result['spaceName'] = self.space_name
        if self.space_type is not None:
            result['spaceType'] = self.space_type
        if self.quota is not None:
            result['quota'] = self.quota
        if self.used_quota is not None:
            result['usedQuota'] = self.used_quota
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.modify_time is not None:
            result['modifyTime'] = self.modify_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('spaceName') is not None:
            self.space_name = m.get('spaceName')
        if m.get('spaceType') is not None:
            self.space_type = m.get('spaceType')
        if m.get('quota') is not None:
            self.quota = m.get('quota')
        if m.get('usedQuota') is not None:
            self.used_quota = m.get('usedQuota')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('modifyTime') is not None:
            self.modify_time = m.get('modifyTime')
        return self


class ListSpacesResponseBody(TeaModel):
    def __init__(
        self,
        spaces: List[ListSpacesResponseBodySpaces] = None,
        next_token: str = None,
    ):
        self.spaces = spaces
        # 分页加载更多锚点, nextToken不为空表示有更多数据
        self.next_token = next_token

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
        result['spaces'] = []
        if self.spaces is not None:
            for k in self.spaces:
                result['spaces'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.spaces = []
        if m.get('spaces') is not None:
            for k in m.get('spaces'):
                temp_model = ListSpacesResponseBodySpaces()
                self.spaces.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class ListSpacesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListSpacesResponseBody = None,
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
            temp_model = ListSpacesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ClearRecycleFilesHeaders(TeaModel):
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


class ClearRecycleFilesRequest(TeaModel):
    def __init__(
        self,
        recycle_type: str = None,
    ):
        # 回收站类型
        self.recycle_type = recycle_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.recycle_type is not None:
            result['recycleType'] = self.recycle_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('recycleType') is not None:
            self.recycle_type = m.get('recycleType')
        return self


class ClearRecycleFilesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        return self


class DeleteFileHeaders(TeaModel):
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


class DeleteFileRequest(TeaModel):
    def __init__(
        self,
        delete_policy: str = None,
    ):
        # 删除策略
        self.delete_policy = delete_policy

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.delete_policy is not None:
            result['deletePolicy'] = self.delete_policy
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deletePolicy') is not None:
            self.delete_policy = m.get('deletePolicy')
        return self


class DeleteFileResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        # 是否成功
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


class DeleteFileResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DeleteFileResponseBody = None,
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
            temp_model = DeleteFileResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


