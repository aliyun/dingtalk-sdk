# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class GetCheckinRecordByUserHeaders(TeaModel):
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


class GetCheckinRecordByUserRequest(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        max_results: int = None,
        next_token: int = None,
        operator_user_id: str = None,
        start_time: int = None,
        user_id_list: List[str] = None,
    ):
        # This parameter is required.
        self.end_time = end_time
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token
        # This parameter is required.
        self.operator_user_id = operator_user_id
        # This parameter is required.
        self.start_time = start_time
        # This parameter is required.
        self.user_id_list = user_id_list

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
        if self.operator_user_id is not None:
            result['operatorUserId'] = self.operator_user_id
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('operatorUserId') is not None:
            self.operator_user_id = m.get('operatorUserId')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        return self


class GetCheckinRecordByUserResponseBodyResultPageListCustomDataList(TeaModel):
    def __init__(
        self,
        key: str = None,
        label: str = None,
        value: str = None,
    ):
        self.key = key
        self.label = label
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.key is not None:
            result['key'] = self.key
        if self.label is not None:
            result['label'] = self.label
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('key') is not None:
            self.key = m.get('key')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class GetCheckinRecordByUserResponseBodyResultPageList(TeaModel):
    def __init__(
        self,
        checkin_time: int = None,
        custom_data_list: List[GetCheckinRecordByUserResponseBodyResultPageListCustomDataList] = None,
        detail_place: str = None,
        image_list: List[str] = None,
        place: str = None,
        remark: str = None,
        user_id: str = None,
        visit_user: str = None,
    ):
        self.checkin_time = checkin_time
        self.custom_data_list = custom_data_list
        self.detail_place = detail_place
        self.image_list = image_list
        self.place = place
        self.remark = remark
        self.user_id = user_id
        self.visit_user = visit_user

    def validate(self):
        if self.custom_data_list:
            for k in self.custom_data_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.checkin_time is not None:
            result['checkinTime'] = self.checkin_time
        result['customDataList'] = []
        if self.custom_data_list is not None:
            for k in self.custom_data_list:
                result['customDataList'].append(k.to_map() if k else None)
        if self.detail_place is not None:
            result['detailPlace'] = self.detail_place
        if self.image_list is not None:
            result['imageList'] = self.image_list
        if self.place is not None:
            result['place'] = self.place
        if self.remark is not None:
            result['remark'] = self.remark
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.visit_user is not None:
            result['visitUser'] = self.visit_user
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('checkinTime') is not None:
            self.checkin_time = m.get('checkinTime')
        self.custom_data_list = []
        if m.get('customDataList') is not None:
            for k in m.get('customDataList'):
                temp_model = GetCheckinRecordByUserResponseBodyResultPageListCustomDataList()
                self.custom_data_list.append(temp_model.from_map(k))
        if m.get('detailPlace') is not None:
            self.detail_place = m.get('detailPlace')
        if m.get('imageList') is not None:
            self.image_list = m.get('imageList')
        if m.get('place') is not None:
            self.place = m.get('place')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('visitUser') is not None:
            self.visit_user = m.get('visitUser')
        return self


class GetCheckinRecordByUserResponseBodyResult(TeaModel):
    def __init__(
        self,
        next_token: int = None,
        page_list: List[GetCheckinRecordByUserResponseBodyResultPageList] = None,
    ):
        self.next_token = next_token
        self.page_list = page_list

    def validate(self):
        if self.page_list:
            for k in self.page_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['pageList'] = []
        if self.page_list is not None:
            for k in self.page_list:
                result['pageList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.page_list = []
        if m.get('pageList') is not None:
            for k in m.get('pageList'):
                temp_model = GetCheckinRecordByUserResponseBodyResultPageList()
                self.page_list.append(temp_model.from_map(k))
        return self


class GetCheckinRecordByUserResponseBody(TeaModel):
    def __init__(
        self,
        result: GetCheckinRecordByUserResponseBodyResult = None,
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
            temp_model = GetCheckinRecordByUserResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetCheckinRecordByUserResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetCheckinRecordByUserResponseBody = None,
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
            temp_model = GetCheckinRecordByUserResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


