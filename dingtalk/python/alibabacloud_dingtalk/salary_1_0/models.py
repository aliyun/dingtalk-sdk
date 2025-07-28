# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class GetSalaryCalculationHeaders(TeaModel):
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


class GetSalaryCalculationRequest(TeaModel):
    def __init__(
        self,
        date: str = None,
        salary_group_id: str = None,
    ):
        # This parameter is required.
        self.date = date
        # This parameter is required.
        self.salary_group_id = salary_group_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.salary_group_id is not None:
            result['salaryGroupId'] = self.salary_group_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('salaryGroupId') is not None:
            self.salary_group_id = m.get('salaryGroupId')
        return self


class GetSalaryCalculationResponseBodyResult(TeaModel):
    def __init__(
        self,
        cal_status: bool = None,
        end_date: str = None,
        start_date: str = None,
        status: str = None,
    ):
        self.cal_status = cal_status
        self.end_date = end_date
        self.start_date = start_date
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cal_status is not None:
            result['calStatus'] = self.cal_status
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('calStatus') is not None:
            self.cal_status = m.get('calStatus')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class GetSalaryCalculationResponseBody(TeaModel):
    def __init__(
        self,
        result: GetSalaryCalculationResponseBodyResult = None,
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
            temp_model = GetSalaryCalculationResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetSalaryCalculationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetSalaryCalculationResponseBody = None,
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
            temp_model = GetSalaryCalculationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSalaryGroupHeaders(TeaModel):
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


class GetSalaryGroupResponseBodyResult(TeaModel):
    def __init__(
        self,
        enable_flag: bool = None,
        salary_group_id: str = None,
        salary_group_name: str = None,
    ):
        self.enable_flag = enable_flag
        self.salary_group_id = salary_group_id
        self.salary_group_name = salary_group_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.enable_flag is not None:
            result['enableFlag'] = self.enable_flag
        if self.salary_group_id is not None:
            result['salaryGroupId'] = self.salary_group_id
        if self.salary_group_name is not None:
            result['salaryGroupName'] = self.salary_group_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('enableFlag') is not None:
            self.enable_flag = m.get('enableFlag')
        if m.get('salaryGroupId') is not None:
            self.salary_group_id = m.get('salaryGroupId')
        if m.get('salaryGroupName') is not None:
            self.salary_group_name = m.get('salaryGroupName')
        return self


class GetSalaryGroupResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetSalaryGroupResponseBodyResult] = None,
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
                temp_model = GetSalaryGroupResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetSalaryGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetSalaryGroupResponseBody = None,
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
            temp_model = GetSalaryGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSalaryItemHeaders(TeaModel):
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


class GetSalaryItemRequest(TeaModel):
    def __init__(
        self,
        salary_item_group_id: str = None,
    ):
        # This parameter is required.
        self.salary_item_group_id = salary_item_group_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.salary_item_group_id is not None:
            result['salaryItemGroupId'] = self.salary_item_group_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('salaryItemGroupId') is not None:
            self.salary_item_group_id = m.get('salaryItemGroupId')
        return self


class GetSalaryItemResponseBodyResult(TeaModel):
    def __init__(
        self,
        salary_item_id: str = None,
        salary_item_name: str = None,
    ):
        self.salary_item_id = salary_item_id
        self.salary_item_name = salary_item_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.salary_item_id is not None:
            result['salaryItemId'] = self.salary_item_id
        if self.salary_item_name is not None:
            result['salaryItemName'] = self.salary_item_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('salaryItemId') is not None:
            self.salary_item_id = m.get('salaryItemId')
        if m.get('salaryItemName') is not None:
            self.salary_item_name = m.get('salaryItemName')
        return self


class GetSalaryItemResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetSalaryItemResponseBodyResult] = None,
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
                temp_model = GetSalaryItemResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetSalaryItemResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetSalaryItemResponseBody = None,
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
            temp_model = GetSalaryItemResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSalaryItemGroupHeaders(TeaModel):
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


class GetSalaryItemGroupResponseBodyResult(TeaModel):
    def __init__(
        self,
        salary_item_group_id: str = None,
        salary_item_group_name: str = None,
    ):
        self.salary_item_group_id = salary_item_group_id
        self.salary_item_group_name = salary_item_group_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.salary_item_group_id is not None:
            result['salaryItemGroupId'] = self.salary_item_group_id
        if self.salary_item_group_name is not None:
            result['salaryItemGroupName'] = self.salary_item_group_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('salaryItemGroupId') is not None:
            self.salary_item_group_id = m.get('salaryItemGroupId')
        if m.get('salaryItemGroupName') is not None:
            self.salary_item_group_name = m.get('salaryItemGroupName')
        return self


class GetSalaryItemGroupResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetSalaryItemGroupResponseBodyResult] = None,
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
                temp_model = GetSalaryItemGroupResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetSalaryItemGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetSalaryItemGroupResponseBody = None,
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
            temp_model = GetSalaryItemGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListSalaryCalculationHeaders(TeaModel):
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


class ListSalaryCalculationRequest(TeaModel):
    def __init__(
        self,
        date: str = None,
        page_index: int = None,
        page_size: int = None,
        salary_group_id: str = None,
    ):
        # This parameter is required.
        self.date = date
        # This parameter is required.
        self.page_index = page_index
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
        self.salary_group_id = salary_group_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.page_index is not None:
            result['pageIndex'] = self.page_index
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.salary_group_id is not None:
            result['salaryGroupId'] = self.salary_group_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('pageIndex') is not None:
            self.page_index = m.get('pageIndex')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('salaryGroupId') is not None:
            self.salary_group_id = m.get('salaryGroupId')
        return self


class ListSalaryCalculationResponseBodyResultDataDataList(TeaModel):
    def __init__(
        self,
        salary_item_id: str = None,
        salary_item_name: str = None,
        salary_item_value: str = None,
    ):
        self.salary_item_id = salary_item_id
        self.salary_item_name = salary_item_name
        self.salary_item_value = salary_item_value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.salary_item_id is not None:
            result['salaryItemId'] = self.salary_item_id
        if self.salary_item_name is not None:
            result['salaryItemName'] = self.salary_item_name
        if self.salary_item_value is not None:
            result['salaryItemValue'] = self.salary_item_value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('salaryItemId') is not None:
            self.salary_item_id = m.get('salaryItemId')
        if m.get('salaryItemName') is not None:
            self.salary_item_name = m.get('salaryItemName')
        if m.get('salaryItemValue') is not None:
            self.salary_item_value = m.get('salaryItemValue')
        return self


class ListSalaryCalculationResponseBodyResultData(TeaModel):
    def __init__(
        self,
        data_list: List[ListSalaryCalculationResponseBodyResultDataDataList] = None,
        user_id: str = None,
    ):
        self.data_list = data_list
        self.user_id = user_id

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
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data_list = []
        if m.get('dataList') is not None:
            for k in m.get('dataList'):
                temp_model = ListSalaryCalculationResponseBodyResultDataDataList()
                self.data_list.append(temp_model.from_map(k))
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ListSalaryCalculationResponseBodyResult(TeaModel):
    def __init__(
        self,
        data: List[ListSalaryCalculationResponseBodyResultData] = None,
        has_more: bool = None,
    ):
        self.data = data
        self.has_more = has_more

    def validate(self):
        if self.data:
            for k in self.data:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['data'] = []
        if self.data is not None:
            for k in self.data:
                result['data'].append(k.to_map() if k else None)
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = ListSalaryCalculationResponseBodyResultData()
                self.data.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        return self


class ListSalaryCalculationResponseBody(TeaModel):
    def __init__(
        self,
        result: ListSalaryCalculationResponseBodyResult = None,
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
            temp_model = ListSalaryCalculationResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class ListSalaryCalculationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListSalaryCalculationResponseBody = None,
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
            temp_model = ListSalaryCalculationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class WriteSalaryCalculationHeaders(TeaModel):
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


class WriteSalaryCalculationRequestItemsContents(TeaModel):
    def __init__(
        self,
        salary_item_id: str = None,
        salary_item_value: str = None,
    ):
        # This parameter is required.
        self.salary_item_id = salary_item_id
        self.salary_item_value = salary_item_value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.salary_item_id is not None:
            result['salaryItemId'] = self.salary_item_id
        if self.salary_item_value is not None:
            result['salaryItemValue'] = self.salary_item_value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('salaryItemId') is not None:
            self.salary_item_id = m.get('salaryItemId')
        if m.get('salaryItemValue') is not None:
            self.salary_item_value = m.get('salaryItemValue')
        return self


class WriteSalaryCalculationRequestItems(TeaModel):
    def __init__(
        self,
        contents: List[WriteSalaryCalculationRequestItemsContents] = None,
        user_id: str = None,
    ):
        self.contents = contents
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        if self.contents:
            for k in self.contents:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['contents'] = []
        if self.contents is not None:
            for k in self.contents:
                result['contents'].append(k.to_map() if k else None)
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.contents = []
        if m.get('contents') is not None:
            for k in m.get('contents'):
                temp_model = WriteSalaryCalculationRequestItemsContents()
                self.contents.append(temp_model.from_map(k))
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class WriteSalaryCalculationRequest(TeaModel):
    def __init__(
        self,
        date: str = None,
        items: List[WriteSalaryCalculationRequestItems] = None,
    ):
        # This parameter is required.
        self.date = date
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
        if self.date is not None:
            result['date'] = self.date
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        self.items = []
        if m.get('items') is not None:
            for k in m.get('items'):
                temp_model = WriteSalaryCalculationRequestItems()
                self.items.append(temp_model.from_map(k))
        return self


class WriteSalaryCalculationResponseBody(TeaModel):
    def __init__(
        self,
        result: Dict[str, Any] = None,
    ):
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class WriteSalaryCalculationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: WriteSalaryCalculationResponseBody = None,
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
            temp_model = WriteSalaryCalculationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


