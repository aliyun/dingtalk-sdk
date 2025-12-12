# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class GetAudioFileDownloadInfoHeaders(TeaModel):
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


class GetAudioFileDownloadInfoRequest(TeaModel):
    def __init__(
        self,
        device_type: str = None,
        file_id: str = None,
    ):
        # This parameter is required.
        self.device_type = device_type
        # This parameter is required.
        self.file_id = file_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_type is not None:
            result['deviceType'] = self.device_type
        if self.file_id is not None:
            result['fileId'] = self.file_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceType') is not None:
            self.device_type = m.get('deviceType')
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        return self


class GetAudioFileDownloadInfoResponseBodyResult(TeaModel):
    def __init__(
        self,
        url: str = None,
    ):
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class GetAudioFileDownloadInfoResponseBody(TeaModel):
    def __init__(
        self,
        result: GetAudioFileDownloadInfoResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = GetAudioFileDownloadInfoResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetAudioFileDownloadInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetAudioFileDownloadInfoResponseBody = None,
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
            temp_model = GetAudioFileDownloadInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetAudioFileInfoHeaders(TeaModel):
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


class GetAudioFileInfoRequest(TeaModel):
    def __init__(
        self,
        device_type: str = None,
        file_id: str = None,
    ):
        # This parameter is required.
        self.device_type = device_type
        # This parameter is required.
        self.file_id = file_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_type is not None:
            result['deviceType'] = self.device_type
        if self.file_id is not None:
            result['fileId'] = self.file_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceType') is not None:
            self.device_type = m.get('deviceType')
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        return self


class GetAudioFileInfoResponseBodyResult(TeaModel):
    def __init__(
        self,
        create_time: int = None,
        creator_user_id: str = None,
        duration: int = None,
        file_id: str = None,
        file_name: str = None,
        file_size: int = None,
    ):
        self.create_time = create_time
        self.creator_user_id = creator_user_id
        self.duration = duration
        self.file_id = file_id
        self.file_name = file_name
        self.file_size = file_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator_user_id is not None:
            result['creatorUserId'] = self.creator_user_id
        if self.duration is not None:
            result['duration'] = self.duration
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.file_size is not None:
            result['fileSize'] = self.file_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creatorUserId') is not None:
            self.creator_user_id = m.get('creatorUserId')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('fileSize') is not None:
            self.file_size = m.get('fileSize')
        return self


class GetAudioFileInfoResponseBody(TeaModel):
    def __init__(
        self,
        result: GetAudioFileInfoResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = GetAudioFileInfoResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetAudioFileInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetAudioFileInfoResponseBody = None,
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
            temp_model = GetAudioFileInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetCustomerInfoHeaders(TeaModel):
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


class GetCustomerInfoRequest(TeaModel):
    def __init__(
        self,
        customer_id: str = None,
    ):
        # This parameter is required.
        self.customer_id = customer_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.customer_id is not None:
            result['customerId'] = self.customer_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customerId') is not None:
            self.customer_id = m.get('customerId')
        return self


class GetCustomerInfoResponseBodyResult(TeaModel):
    def __init__(
        self,
        create_at: str = None,
        id: str = None,
        name: str = None,
        owner_user_id: str = None,
        team_code: str = None,
    ):
        self.create_at = create_at
        self.id = id
        self.name = name
        self.owner_user_id = owner_user_id
        self.team_code = team_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_at is not None:
            result['createAt'] = self.create_at
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.owner_user_id is not None:
            result['ownerUserId'] = self.owner_user_id
        if self.team_code is not None:
            result['teamCode'] = self.team_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createAt') is not None:
            self.create_at = m.get('createAt')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('ownerUserId') is not None:
            self.owner_user_id = m.get('ownerUserId')
        if m.get('teamCode') is not None:
            self.team_code = m.get('teamCode')
        return self


class GetCustomerInfoResponseBody(TeaModel):
    def __init__(
        self,
        result: GetCustomerInfoResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = GetCustomerInfoResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetCustomerInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetCustomerInfoResponseBody = None,
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
            temp_model = GetCustomerInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetServiceChapterSummaryHeaders(TeaModel):
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


class GetServiceChapterSummaryRequest(TeaModel):
    def __init__(
        self,
        record_id: str = None,
    ):
        # This parameter is required.
        self.record_id = record_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.record_id is not None:
            result['recordId'] = self.record_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('recordId') is not None:
            self.record_id = m.get('recordId')
        return self


class GetServiceChapterSummaryResponseBodyResult(TeaModel):
    def __init__(
        self,
        content: str = None,
        name: str = None,
    ):
        self.content = content
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class GetServiceChapterSummaryResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        result: List[GetServiceChapterSummaryResponseBodyResult] = None,
        total_count: int = None,
    ):
        self.next_token = next_token
        self.result = result
        self.total_count = total_count

    def validate(self):
        if self.result:
            for k in self.result:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = GetServiceChapterSummaryResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetServiceChapterSummaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetServiceChapterSummaryResponseBody = None,
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
            temp_model = GetServiceChapterSummaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetServiceChatSummaryHeaders(TeaModel):
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


class GetServiceChatSummaryRequest(TeaModel):
    def __init__(
        self,
        record_id: str = None,
    ):
        # This parameter is required.
        self.record_id = record_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.record_id is not None:
            result['recordId'] = self.record_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('recordId') is not None:
            self.record_id = m.get('recordId')
        return self


class GetServiceChatSummaryResponseBodyResultBasic(TeaModel):
    def __init__(
        self,
        content: str = None,
        name: str = None,
    ):
        self.content = content
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class GetServiceChatSummaryResponseBodyResultProductItemList(TeaModel):
    def __init__(
        self,
        content: str = None,
        name: str = None,
    ):
        self.content = content
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class GetServiceChatSummaryResponseBodyResultProduct(TeaModel):
    def __init__(
        self,
        item_list: List[GetServiceChatSummaryResponseBodyResultProductItemList] = None,
        product: str = None,
    ):
        self.item_list = item_list
        self.product = product

    def validate(self):
        if self.item_list:
            for k in self.item_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['itemList'] = []
        if self.item_list is not None:
            for k in self.item_list:
                result['itemList'].append(k.to_map() if k else None)
        if self.product is not None:
            result['product'] = self.product
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.item_list = []
        if m.get('itemList') is not None:
            for k in m.get('itemList'):
                temp_model = GetServiceChatSummaryResponseBodyResultProductItemList()
                self.item_list.append(temp_model.from_map(k))
        if m.get('product') is not None:
            self.product = m.get('product')
        return self


class GetServiceChatSummaryResponseBodyResult(TeaModel):
    def __init__(
        self,
        basic: List[GetServiceChatSummaryResponseBodyResultBasic] = None,
        product: List[GetServiceChatSummaryResponseBodyResultProduct] = None,
    ):
        self.basic = basic
        self.product = product

    def validate(self):
        if self.basic:
            for k in self.basic:
                if k:
                    k.validate()
        if self.product:
            for k in self.product:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['basic'] = []
        if self.basic is not None:
            for k in self.basic:
                result['basic'].append(k.to_map() if k else None)
        result['product'] = []
        if self.product is not None:
            for k in self.product:
                result['product'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.basic = []
        if m.get('basic') is not None:
            for k in m.get('basic'):
                temp_model = GetServiceChatSummaryResponseBodyResultBasic()
                self.basic.append(temp_model.from_map(k))
        self.product = []
        if m.get('product') is not None:
            for k in m.get('product'):
                temp_model = GetServiceChatSummaryResponseBodyResultProduct()
                self.product.append(temp_model.from_map(k))
        return self


class GetServiceChatSummaryResponseBody(TeaModel):
    def __init__(
        self,
        result: GetServiceChatSummaryResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = GetServiceChatSummaryResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetServiceChatSummaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetServiceChatSummaryResponseBody = None,
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
            temp_model = GetServiceChatSummaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetServiceQualityInspectionHeaders(TeaModel):
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


class GetServiceQualityInspectionRequest(TeaModel):
    def __init__(
        self,
        record_id: str = None,
    ):
        # This parameter is required.
        self.record_id = record_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.record_id is not None:
            result['recordId'] = self.record_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('recordId') is not None:
            self.record_id = m.get('recordId')
        return self


class GetServiceQualityInspectionResponseBodyResultGroupListItemList(TeaModel):
    def __init__(
        self,
        flow_name: str = None,
        is_hit: str = None,
        reason: str = None,
        score: int = None,
        script: str = None,
    ):
        self.flow_name = flow_name
        self.is_hit = is_hit
        self.reason = reason
        self.score = score
        self.script = script

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.flow_name is not None:
            result['flowName'] = self.flow_name
        if self.is_hit is not None:
            result['isHit'] = self.is_hit
        if self.reason is not None:
            result['reason'] = self.reason
        if self.score is not None:
            result['score'] = self.score
        if self.script is not None:
            result['script'] = self.script
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('flowName') is not None:
            self.flow_name = m.get('flowName')
        if m.get('isHit') is not None:
            self.is_hit = m.get('isHit')
        if m.get('reason') is not None:
            self.reason = m.get('reason')
        if m.get('score') is not None:
            self.score = m.get('score')
        if m.get('script') is not None:
            self.script = m.get('script')
        return self


class GetServiceQualityInspectionResponseBodyResultGroupList(TeaModel):
    def __init__(
        self,
        item_list: List[GetServiceQualityInspectionResponseBodyResultGroupListItemList] = None,
        name: str = None,
    ):
        self.item_list = item_list
        self.name = name

    def validate(self):
        if self.item_list:
            for k in self.item_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['itemList'] = []
        if self.item_list is not None:
            for k in self.item_list:
                result['itemList'].append(k.to_map() if k else None)
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.item_list = []
        if m.get('itemList') is not None:
            for k in m.get('itemList'):
                temp_model = GetServiceQualityInspectionResponseBodyResultGroupListItemList()
                self.item_list.append(temp_model.from_map(k))
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class GetServiceQualityInspectionResponseBodyResult(TeaModel):
    def __init__(
        self,
        group_list: List[GetServiceQualityInspectionResponseBodyResultGroupList] = None,
        score: int = None,
        summary: str = None,
    ):
        self.group_list = group_list
        self.score = score
        self.summary = summary

    def validate(self):
        if self.group_list:
            for k in self.group_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['groupList'] = []
        if self.group_list is not None:
            for k in self.group_list:
                result['groupList'].append(k.to_map() if k else None)
        if self.score is not None:
            result['score'] = self.score
        if self.summary is not None:
            result['summary'] = self.summary
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.group_list = []
        if m.get('groupList') is not None:
            for k in m.get('groupList'):
                temp_model = GetServiceQualityInspectionResponseBodyResultGroupList()
                self.group_list.append(temp_model.from_map(k))
        if m.get('score') is not None:
            self.score = m.get('score')
        if m.get('summary') is not None:
            self.summary = m.get('summary')
        return self


class GetServiceQualityInspectionResponseBody(TeaModel):
    def __init__(
        self,
        result: GetServiceQualityInspectionResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = GetServiceQualityInspectionResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetServiceQualityInspectionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetServiceQualityInspectionResponseBody = None,
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
            temp_model = GetServiceQualityInspectionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetServiceRecordTranscriptHeaders(TeaModel):
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


class GetServiceRecordTranscriptRequest(TeaModel):
    def __init__(
        self,
        id: str = None,
    ):
        # This parameter is required.
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class GetServiceRecordTranscriptResponseBodyResultAudionTextDataList(TeaModel):
    def __init__(
        self,
        channel: str = None,
        end_time: str = None,
        start_time: str = None,
        text: str = None,
    ):
        self.channel = channel
        self.end_time = end_time
        self.start_time = start_time
        self.text = text

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.channel is not None:
            result['channel'] = self.channel
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.text is not None:
            result['text'] = self.text
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('channel') is not None:
            self.channel = m.get('channel')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('text') is not None:
            self.text = m.get('text')
        return self


class GetServiceRecordTranscriptResponseBodyResultAudionText(TeaModel):
    def __init__(
        self,
        data_list: List[GetServiceRecordTranscriptResponseBodyResultAudionTextDataList] = None,
        status: str = None,
    ):
        self.data_list = data_list
        self.status = status

    def validate(self):
        if self.data_list:
            for k in self.data_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['dataList'] = []
        if self.data_list is not None:
            for k in self.data_list:
                result['dataList'].append(k.to_map() if k else None)
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data_list = []
        if m.get('dataList') is not None:
            for k in m.get('dataList'):
                temp_model = GetServiceRecordTranscriptResponseBodyResultAudionTextDataList()
                self.data_list.append(temp_model.from_map(k))
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class GetServiceRecordTranscriptResponseBodyResultSpeakerDataList(TeaModel):
    def __init__(
        self,
        channel: str = None,
        role: str = None,
    ):
        self.channel = channel
        self.role = role

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.channel is not None:
            result['channel'] = self.channel
        if self.role is not None:
            result['role'] = self.role
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('channel') is not None:
            self.channel = m.get('channel')
        if m.get('role') is not None:
            self.role = m.get('role')
        return self


class GetServiceRecordTranscriptResponseBodyResultSpeaker(TeaModel):
    def __init__(
        self,
        data_list: List[GetServiceRecordTranscriptResponseBodyResultSpeakerDataList] = None,
        status: str = None,
    ):
        self.data_list = data_list
        self.status = status

    def validate(self):
        if self.data_list:
            for k in self.data_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['dataList'] = []
        if self.data_list is not None:
            for k in self.data_list:
                result['dataList'].append(k.to_map() if k else None)
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data_list = []
        if m.get('dataList') is not None:
            for k in m.get('dataList'):
                temp_model = GetServiceRecordTranscriptResponseBodyResultSpeakerDataList()
                self.data_list.append(temp_model.from_map(k))
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class GetServiceRecordTranscriptResponseBodyResult(TeaModel):
    def __init__(
        self,
        audion_text: GetServiceRecordTranscriptResponseBodyResultAudionText = None,
        speaker: GetServiceRecordTranscriptResponseBodyResultSpeaker = None,
    ):
        self.audion_text = audion_text
        self.speaker = speaker

    def validate(self):
        if self.audion_text:
            self.audion_text.validate()
        if self.speaker:
            self.speaker.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.audion_text is not None:
            result['audionText'] = self.audion_text.to_map()
        if self.speaker is not None:
            result['speaker'] = self.speaker.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('audionText') is not None:
            temp_model = GetServiceRecordTranscriptResponseBodyResultAudionText()
            self.audion_text = temp_model.from_map(m['audionText'])
        if m.get('speaker') is not None:
            temp_model = GetServiceRecordTranscriptResponseBodyResultSpeaker()
            self.speaker = temp_model.from_map(m['speaker'])
        return self


class GetServiceRecordTranscriptResponseBody(TeaModel):
    def __init__(
        self,
        result: GetServiceRecordTranscriptResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = GetServiceRecordTranscriptResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetServiceRecordTranscriptResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetServiceRecordTranscriptResponseBody = None,
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
            temp_model = GetServiceRecordTranscriptResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetTranscriptSummaryHeaders(TeaModel):
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


class GetTranscriptSummaryRequest(TeaModel):
    def __init__(
        self,
        device_type: str = None,
        file_id: str = None,
    ):
        # This parameter is required.
        self.device_type = device_type
        # This parameter is required.
        self.file_id = file_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_type is not None:
            result['deviceType'] = self.device_type
        if self.file_id is not None:
            result['fileId'] = self.file_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceType') is not None:
            self.device_type = m.get('deviceType')
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        return self


class GetTranscriptSummaryResponseBodyResult(TeaModel):
    def __init__(
        self,
        content: str = None,
    ):
        self.content = content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        return self


class GetTranscriptSummaryResponseBody(TeaModel):
    def __init__(
        self,
        result: GetTranscriptSummaryResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = GetTranscriptSummaryResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetTranscriptSummaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetTranscriptSummaryResponseBody = None,
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
            temp_model = GetTranscriptSummaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListCustomerHeaders(TeaModel):
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


class ListCustomerRequest(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        max_results: int = None,
        next_token: str = None,
        owner_user_id: str = None,
        start_time: int = None,
        team_code: str = None,
    ):
        self.end_time = end_time
        self.max_results = max_results
        self.next_token = next_token
        self.owner_user_id = owner_user_id
        self.start_time = start_time
        # This parameter is required.
        self.team_code = team_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.owner_user_id is not None:
            result['ownerUserId'] = self.owner_user_id
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.team_code is not None:
            result['teamCode'] = self.team_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('ownerUserId') is not None:
            self.owner_user_id = m.get('ownerUserId')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('teamCode') is not None:
            self.team_code = m.get('teamCode')
        return self


class ListCustomerResponseBodyResult(TeaModel):
    def __init__(
        self,
        create_at: str = None,
        id: str = None,
        name: str = None,
        owner_user_id: str = None,
        team_code: str = None,
    ):
        self.create_at = create_at
        self.id = id
        self.name = name
        self.owner_user_id = owner_user_id
        self.team_code = team_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_at is not None:
            result['createAt'] = self.create_at
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.owner_user_id is not None:
            result['ownerUserId'] = self.owner_user_id
        if self.team_code is not None:
            result['teamCode'] = self.team_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createAt') is not None:
            self.create_at = m.get('createAt')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('ownerUserId') is not None:
            self.owner_user_id = m.get('ownerUserId')
        if m.get('teamCode') is not None:
            self.team_code = m.get('teamCode')
        return self


class ListCustomerResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        result: List[ListCustomerResponseBodyResult] = None,
        total_count: int = None,
    ):
        self.next_token = next_token
        self.result = result
        self.total_count = total_count

    def validate(self):
        if self.result:
            for k in self.result:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = ListCustomerResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class ListCustomerResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListCustomerResponseBody = None,
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
            temp_model = ListCustomerResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListServiceRecordHeaders(TeaModel):
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


class ListServiceRecordRequest(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        max_results: int = None,
        next_token: str = None,
        start_time: int = None,
        team_code: str = None,
        user_id: str = None,
    ):
        self.end_time = end_time
        self.max_results = max_results
        self.next_token = next_token
        self.start_time = start_time
        self.team_code = team_code
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.team_code is not None:
            result['teamCode'] = self.team_code
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('teamCode') is not None:
            self.team_code = m.get('teamCode')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ListServiceRecordResponseBodyResultTeam(TeaModel):
    def __init__(
        self,
        code: str = None,
        name: str = None,
    ):
        self.code = code
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class ListServiceRecordResponseBodyResultUser(TeaModel):
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


class ListServiceRecordResponseBodyResult(TeaModel):
    def __init__(
        self,
        customer_id: str = None,
        device_sn: str = None,
        duration: str = None,
        end_timestamp: int = None,
        record_id: str = None,
        start_timestamp: int = None,
        team: ListServiceRecordResponseBodyResultTeam = None,
        user: ListServiceRecordResponseBodyResultUser = None,
    ):
        self.customer_id = customer_id
        self.device_sn = device_sn
        self.duration = duration
        self.end_timestamp = end_timestamp
        self.record_id = record_id
        self.start_timestamp = start_timestamp
        self.team = team
        self.user = user

    def validate(self):
        if self.team:
            self.team.validate()
        if self.user:
            self.user.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.customer_id is not None:
            result['customerId'] = self.customer_id
        if self.device_sn is not None:
            result['deviceSn'] = self.device_sn
        if self.duration is not None:
            result['duration'] = self.duration
        if self.end_timestamp is not None:
            result['endTimestamp'] = self.end_timestamp
        if self.record_id is not None:
            result['recordId'] = self.record_id
        if self.start_timestamp is not None:
            result['startTimestamp'] = self.start_timestamp
        if self.team is not None:
            result['team'] = self.team.to_map()
        if self.user is not None:
            result['user'] = self.user.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customerId') is not None:
            self.customer_id = m.get('customerId')
        if m.get('deviceSn') is not None:
            self.device_sn = m.get('deviceSn')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('endTimestamp') is not None:
            self.end_timestamp = m.get('endTimestamp')
        if m.get('recordId') is not None:
            self.record_id = m.get('recordId')
        if m.get('startTimestamp') is not None:
            self.start_timestamp = m.get('startTimestamp')
        if m.get('team') is not None:
            temp_model = ListServiceRecordResponseBodyResultTeam()
            self.team = temp_model.from_map(m['team'])
        if m.get('user') is not None:
            temp_model = ListServiceRecordResponseBodyResultUser()
            self.user = temp_model.from_map(m['user'])
        return self


class ListServiceRecordResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        result: List[ListServiceRecordResponseBodyResult] = None,
        total_count: int = None,
    ):
        self.next_token = next_token
        self.result = result
        self.total_count = total_count

    def validate(self):
        if self.result:
            for k in self.result:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = ListServiceRecordResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class ListServiceRecordResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListServiceRecordResponseBody = None,
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
            temp_model = ListServiceRecordResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListServiceTodoHeaders(TeaModel):
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


class ListServiceTodoRequest(TeaModel):
    def __init__(
        self,
        record_id: str = None,
    ):
        # This parameter is required.
        self.record_id = record_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.record_id is not None:
            result['recordId'] = self.record_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('recordId') is not None:
            self.record_id = m.get('recordId')
        return self


class ListServiceTodoResponseBodyResultExecutors(TeaModel):
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


class ListServiceTodoResponseBodyResult(TeaModel):
    def __init__(
        self,
        creator: str = None,
        ding_todo_id: str = None,
        executors: List[ListServiceTodoResponseBodyResultExecutors] = None,
        finished: bool = None,
        plan_finish_date: int = None,
        todo_content: str = None,
        uuid: str = None,
    ):
        self.creator = creator
        self.ding_todo_id = ding_todo_id
        self.executors = executors
        self.finished = finished
        self.plan_finish_date = plan_finish_date
        self.todo_content = todo_content
        self.uuid = uuid

    def validate(self):
        if self.executors:
            for k in self.executors:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.creator is not None:
            result['creator'] = self.creator
        if self.ding_todo_id is not None:
            result['dingTodoId'] = self.ding_todo_id
        result['executors'] = []
        if self.executors is not None:
            for k in self.executors:
                result['executors'].append(k.to_map() if k else None)
        if self.finished is not None:
            result['finished'] = self.finished
        if self.plan_finish_date is not None:
            result['planFinishDate'] = self.plan_finish_date
        if self.todo_content is not None:
            result['todoContent'] = self.todo_content
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('creator') is not None:
            self.creator = m.get('creator')
        if m.get('dingTodoId') is not None:
            self.ding_todo_id = m.get('dingTodoId')
        self.executors = []
        if m.get('executors') is not None:
            for k in m.get('executors'):
                temp_model = ListServiceTodoResponseBodyResultExecutors()
                self.executors.append(temp_model.from_map(k))
        if m.get('finished') is not None:
            self.finished = m.get('finished')
        if m.get('planFinishDate') is not None:
            self.plan_finish_date = m.get('planFinishDate')
        if m.get('todoContent') is not None:
            self.todo_content = m.get('todoContent')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class ListServiceTodoResponseBody(TeaModel):
    def __init__(
        self,
        result: List[ListServiceTodoResponseBodyResult] = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            for k in self.result:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = ListServiceTodoResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class ListServiceTodoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListServiceTodoResponseBody = None,
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
            temp_model = ListServiceTodoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListTeamHeaders(TeaModel):
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


class ListTeamRequest(TeaModel):
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


class ListTeamResponseBodyResult(TeaModel):
    def __init__(
        self,
        code: str = None,
        name: str = None,
    ):
        self.code = code
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class ListTeamResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        result: List[ListTeamResponseBodyResult] = None,
        total_count: int = None,
    ):
        self.next_token = next_token
        self.result = result
        self.total_count = total_count

    def validate(self):
        if self.result:
            for k in self.result:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = ListTeamResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class ListTeamResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListTeamResponseBody = None,
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
            temp_model = ListTeamResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryAsrTaskHeaders(TeaModel):
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


class QueryAsrTaskRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        task_id: str = None,
        union_id: str = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        # This parameter is required.
        self.task_id = task_id
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
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryAsrTaskResponseBodyResultResultInfoParagraphListSentenceListWordList(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        start_time: int = None,
        text: str = None,
    ):
        self.end_time = end_time
        self.start_time = start_time
        self.text = text

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
        if self.text is not None:
            result['text'] = self.text
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('text') is not None:
            self.text = m.get('text')
        return self


class QueryAsrTaskResponseBodyResultResultInfoParagraphListSentenceList(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        sentence: str = None,
        start_time: int = None,
        word_list: List[QueryAsrTaskResponseBodyResultResultInfoParagraphListSentenceListWordList] = None,
    ):
        self.end_time = end_time
        self.sentence = sentence
        self.start_time = start_time
        self.word_list = word_list

    def validate(self):
        if self.word_list:
            for k in self.word_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.sentence is not None:
            result['sentence'] = self.sentence
        if self.start_time is not None:
            result['startTime'] = self.start_time
        result['wordList'] = []
        if self.word_list is not None:
            for k in self.word_list:
                result['wordList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('sentence') is not None:
            self.sentence = m.get('sentence')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        self.word_list = []
        if m.get('wordList') is not None:
            for k in m.get('wordList'):
                temp_model = QueryAsrTaskResponseBodyResultResultInfoParagraphListSentenceListWordList()
                self.word_list.append(temp_model.from_map(k))
        return self


class QueryAsrTaskResponseBodyResultResultInfoParagraphList(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        paragraph: str = None,
        sentence_list: List[QueryAsrTaskResponseBodyResultResultInfoParagraphListSentenceList] = None,
        speaker_id: str = None,
        start_time: int = None,
    ):
        self.end_time = end_time
        self.paragraph = paragraph
        self.sentence_list = sentence_list
        self.speaker_id = speaker_id
        self.start_time = start_time

    def validate(self):
        if self.sentence_list:
            for k in self.sentence_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.paragraph is not None:
            result['paragraph'] = self.paragraph
        result['sentenceList'] = []
        if self.sentence_list is not None:
            for k in self.sentence_list:
                result['sentenceList'].append(k.to_map() if k else None)
        if self.speaker_id is not None:
            result['speakerId'] = self.speaker_id
        if self.start_time is not None:
            result['startTime'] = self.start_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('paragraph') is not None:
            self.paragraph = m.get('paragraph')
        self.sentence_list = []
        if m.get('sentenceList') is not None:
            for k in m.get('sentenceList'):
                temp_model = QueryAsrTaskResponseBodyResultResultInfoParagraphListSentenceList()
                self.sentence_list.append(temp_model.from_map(k))
        if m.get('speakerId') is not None:
            self.speaker_id = m.get('speakerId')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        return self


class QueryAsrTaskResponseBodyResultResultInfo(TeaModel):
    def __init__(
        self,
        paragraph_list: List[QueryAsrTaskResponseBodyResultResultInfoParagraphList] = None,
    ):
        self.paragraph_list = paragraph_list

    def validate(self):
        if self.paragraph_list:
            for k in self.paragraph_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['paragraphList'] = []
        if self.paragraph_list is not None:
            for k in self.paragraph_list:
                result['paragraphList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.paragraph_list = []
        if m.get('paragraphList') is not None:
            for k in m.get('paragraphList'):
                temp_model = QueryAsrTaskResponseBodyResultResultInfoParagraphList()
                self.paragraph_list.append(temp_model.from_map(k))
        return self


class QueryAsrTaskResponseBodyResult(TeaModel):
    def __init__(
        self,
        biz_key: str = None,
        next_token: str = None,
        result_info: QueryAsrTaskResponseBodyResultResultInfo = None,
        task_id: str = None,
        task_status: str = None,
    ):
        self.biz_key = biz_key
        self.next_token = next_token
        self.result_info = result_info
        self.task_id = task_id
        self.task_status = task_status

    def validate(self):
        if self.result_info:
            self.result_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_key is not None:
            result['bizKey'] = self.biz_key
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.result_info is not None:
            result['resultInfo'] = self.result_info.to_map()
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.task_status is not None:
            result['taskStatus'] = self.task_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizKey') is not None:
            self.biz_key = m.get('bizKey')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('resultInfo') is not None:
            temp_model = QueryAsrTaskResponseBodyResultResultInfo()
            self.result_info = temp_model.from_map(m['resultInfo'])
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('taskStatus') is not None:
            self.task_status = m.get('taskStatus')
        return self


class QueryAsrTaskResponseBody(TeaModel):
    def __init__(
        self,
        error_code: str = None,
        error_msg: str = None,
        result: QueryAsrTaskResponseBodyResult = None,
        success: bool = None,
    ):
        self.error_code = error_code
        self.error_msg = error_msg
        self.result = result
        self.success = success

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.result is not None:
            result['result'] = self.result.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('result') is not None:
            temp_model = QueryAsrTaskResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryAsrTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryAsrTaskResponseBody = None,
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
            temp_model = QueryAsrTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryAudioFileHeaders(TeaModel):
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


class QueryAudioFileRequest(TeaModel):
    def __init__(
        self,
        device_type: str = None,
        end_timestamp: int = None,
        max_results: int = None,
        next_token: str = None,
        sn: str = None,
        start_timestamp: int = None,
    ):
        # This parameter is required.
        self.device_type = device_type
        self.end_timestamp = end_timestamp
        self.max_results = max_results
        self.next_token = next_token
        # This parameter is required.
        self.sn = sn
        self.start_timestamp = start_timestamp

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_type is not None:
            result['deviceType'] = self.device_type
        if self.end_timestamp is not None:
            result['endTimestamp'] = self.end_timestamp
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.sn is not None:
            result['sn'] = self.sn
        if self.start_timestamp is not None:
            result['startTimestamp'] = self.start_timestamp
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceType') is not None:
            self.device_type = m.get('deviceType')
        if m.get('endTimestamp') is not None:
            self.end_timestamp = m.get('endTimestamp')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        if m.get('startTimestamp') is not None:
            self.start_timestamp = m.get('startTimestamp')
        return self


class QueryAudioFileResponseBodyResult(TeaModel):
    def __init__(
        self,
        create_time: int = None,
        creator_user_id: str = None,
        duration: int = None,
        file_id: str = None,
        file_name: str = None,
        file_size: int = None,
    ):
        self.create_time = create_time
        self.creator_user_id = creator_user_id
        self.duration = duration
        self.file_id = file_id
        self.file_name = file_name
        self.file_size = file_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator_user_id is not None:
            result['creatorUserId'] = self.creator_user_id
        if self.duration is not None:
            result['duration'] = self.duration
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.file_size is not None:
            result['fileSize'] = self.file_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creatorUserId') is not None:
            self.creator_user_id = m.get('creatorUserId')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('fileSize') is not None:
            self.file_size = m.get('fileSize')
        return self


class QueryAudioFileResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        result: List[QueryAudioFileResponseBodyResult] = None,
        total_count: int = None,
    ):
        self.next_token = next_token
        self.result = result
        self.total_count = total_count

    def validate(self):
        if self.result:
            for k in self.result:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = QueryAudioFileResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class QueryAudioFileResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryAudioFileResponseBody = None,
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
            temp_model = QueryAudioFileResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryDeviceDetailHeaders(TeaModel):
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


class QueryDeviceDetailRequest(TeaModel):
    def __init__(
        self,
        device_type: str = None,
        sn_list: List[str] = None,
    ):
        # This parameter is required.
        self.device_type = device_type
        # This parameter is required.
        self.sn_list = sn_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_type is not None:
            result['deviceType'] = self.device_type
        if self.sn_list is not None:
            result['snList'] = self.sn_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceType') is not None:
            self.device_type = m.get('deviceType')
        if m.get('snList') is not None:
            self.sn_list = m.get('snList')
        return self


class QueryDeviceDetailResponseBodyResult(TeaModel):
    def __init__(
        self,
        bind_timestamp: int = None,
        device_name: str = None,
        sn: str = None,
        user_id: str = None,
    ):
        self.bind_timestamp = bind_timestamp
        self.device_name = device_name
        self.sn = sn
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.bind_timestamp is not None:
            result['bindTimestamp'] = self.bind_timestamp
        if self.device_name is not None:
            result['deviceName'] = self.device_name
        if self.sn is not None:
            result['sn'] = self.sn
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bindTimestamp') is not None:
            self.bind_timestamp = m.get('bindTimestamp')
        if m.get('deviceName') is not None:
            self.device_name = m.get('deviceName')
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryDeviceDetailResponseBody(TeaModel):
    def __init__(
        self,
        result: List[QueryDeviceDetailResponseBodyResult] = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            for k in self.result:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = QueryDeviceDetailResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class QueryDeviceDetailResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryDeviceDetailResponseBody = None,
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
            temp_model = QueryDeviceDetailResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryDeviceStatusHeaders(TeaModel):
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


class QueryDeviceStatusRequest(TeaModel):
    def __init__(
        self,
        device_type: str = None,
        sn_list: List[str] = None,
    ):
        # This parameter is required.
        self.device_type = device_type
        # This parameter is required.
        self.sn_list = sn_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_type is not None:
            result['deviceType'] = self.device_type
        if self.sn_list is not None:
            result['snList'] = self.sn_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceType') is not None:
            self.device_type = m.get('deviceType')
        if m.get('snList') is not None:
            self.sn_list = m.get('snList')
        return self


class QueryDeviceStatusResponseBodyResultBattery(TeaModel):
    def __init__(
        self,
        timestamp: int = None,
        value: int = None,
    ):
        self.timestamp = timestamp
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class QueryDeviceStatusResponseBodyResultFirmware(TeaModel):
    def __init__(
        self,
        timestamp: int = None,
        value: str = None,
    ):
        self.timestamp = timestamp
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class QueryDeviceStatusResponseBodyResultRecordingStartTime(TeaModel):
    def __init__(
        self,
        timestamp: int = None,
        value: int = None,
    ):
        self.timestamp = timestamp
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class QueryDeviceStatusResponseBodyResultStatus(TeaModel):
    def __init__(
        self,
        timestamp: int = None,
        value: str = None,
    ):
        self.timestamp = timestamp
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class QueryDeviceStatusResponseBodyResult(TeaModel):
    def __init__(
        self,
        battery: QueryDeviceStatusResponseBodyResultBattery = None,
        firmware: QueryDeviceStatusResponseBodyResultFirmware = None,
        recording_start_time: QueryDeviceStatusResponseBodyResultRecordingStartTime = None,
        sn: str = None,
        status: QueryDeviceStatusResponseBodyResultStatus = None,
    ):
        self.battery = battery
        self.firmware = firmware
        self.recording_start_time = recording_start_time
        self.sn = sn
        self.status = status

    def validate(self):
        if self.battery:
            self.battery.validate()
        if self.firmware:
            self.firmware.validate()
        if self.recording_start_time:
            self.recording_start_time.validate()
        if self.status:
            self.status.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.battery is not None:
            result['battery'] = self.battery.to_map()
        if self.firmware is not None:
            result['firmware'] = self.firmware.to_map()
        if self.recording_start_time is not None:
            result['recordingStartTime'] = self.recording_start_time.to_map()
        if self.sn is not None:
            result['sn'] = self.sn
        if self.status is not None:
            result['status'] = self.status.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('battery') is not None:
            temp_model = QueryDeviceStatusResponseBodyResultBattery()
            self.battery = temp_model.from_map(m['battery'])
        if m.get('firmware') is not None:
            temp_model = QueryDeviceStatusResponseBodyResultFirmware()
            self.firmware = temp_model.from_map(m['firmware'])
        if m.get('recordingStartTime') is not None:
            temp_model = QueryDeviceStatusResponseBodyResultRecordingStartTime()
            self.recording_start_time = temp_model.from_map(m['recordingStartTime'])
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        if m.get('status') is not None:
            temp_model = QueryDeviceStatusResponseBodyResultStatus()
            self.status = temp_model.from_map(m['status'])
        return self


class QueryDeviceStatusResponseBody(TeaModel):
    def __init__(
        self,
        result: List[QueryDeviceStatusResponseBodyResult] = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            for k in self.result:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = QueryDeviceStatusResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class QueryDeviceStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryDeviceStatusResponseBody = None,
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
            temp_model = QueryDeviceStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SubmitAsrTaskHeaders(TeaModel):
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


class SubmitAsrTaskRequestTranscriptionDiarization(TeaModel):
    def __init__(
        self,
        speaker_count: int = None,
    ):
        self.speaker_count = speaker_count

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.speaker_count is not None:
            result['speakerCount'] = self.speaker_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('speakerCount') is not None:
            self.speaker_count = m.get('speakerCount')
        return self


class SubmitAsrTaskRequestTranscription(TeaModel):
    def __init__(
        self,
        diarization: SubmitAsrTaskRequestTranscriptionDiarization = None,
        diarization_enabled: bool = None,
    ):
        self.diarization = diarization
        self.diarization_enabled = diarization_enabled

    def validate(self):
        if self.diarization:
            self.diarization.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.diarization is not None:
            result['diarization'] = self.diarization.to_map()
        if self.diarization_enabled is not None:
            result['diarizationEnabled'] = self.diarization_enabled
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('diarization') is not None:
            temp_model = SubmitAsrTaskRequestTranscriptionDiarization()
            self.diarization = temp_model.from_map(m['diarization'])
        if m.get('diarizationEnabled') is not None:
            self.diarization_enabled = m.get('diarizationEnabled')
        return self


class SubmitAsrTaskRequest(TeaModel):
    def __init__(
        self,
        biz_key: str = None,
        dentry_id: str = None,
        phrases: List[str] = None,
        source_language: str = None,
        space_id: str = None,
        transcription: SubmitAsrTaskRequestTranscription = None,
        union_id: str = None,
    ):
        self.biz_key = biz_key
        # This parameter is required.
        self.dentry_id = dentry_id
        self.phrases = phrases
        # This parameter is required.
        self.source_language = source_language
        # This parameter is required.
        self.space_id = space_id
        self.transcription = transcription
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        if self.transcription:
            self.transcription.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_key is not None:
            result['bizKey'] = self.biz_key
        if self.dentry_id is not None:
            result['dentryId'] = self.dentry_id
        if self.phrases is not None:
            result['phrases'] = self.phrases
        if self.source_language is not None:
            result['sourceLanguage'] = self.source_language
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.transcription is not None:
            result['transcription'] = self.transcription.to_map()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizKey') is not None:
            self.biz_key = m.get('bizKey')
        if m.get('dentryId') is not None:
            self.dentry_id = m.get('dentryId')
        if m.get('phrases') is not None:
            self.phrases = m.get('phrases')
        if m.get('sourceLanguage') is not None:
            self.source_language = m.get('sourceLanguage')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('transcription') is not None:
            temp_model = SubmitAsrTaskRequestTranscription()
            self.transcription = temp_model.from_map(m['transcription'])
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class SubmitAsrTaskResponseBodyResult(TeaModel):
    def __init__(
        self,
        task_id: str = None,
    ):
        self.task_id = task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class SubmitAsrTaskResponseBody(TeaModel):
    def __init__(
        self,
        error_code: str = None,
        error_msg: str = None,
        result: SubmitAsrTaskResponseBodyResult = None,
        success: str = None,
    ):
        self.error_code = error_code
        self.error_msg = error_msg
        self.result = result
        self.success = success

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.result is not None:
            result['result'] = self.result.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('result') is not None:
            temp_model = SubmitAsrTaskResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class SubmitAsrTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SubmitAsrTaskResponseBody = None,
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
            temp_model = SubmitAsrTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


