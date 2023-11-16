# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class BatchDeleteReceiptHeaders(TeaModel):
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


class BatchDeleteReceiptRequest(TeaModel):
    def __init__(
        self,
        instance_id_list: List[str] = None,
        operator: str = None,
    ):
        self.instance_id_list = instance_id_list
        self.operator = operator

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.instance_id_list is not None:
            result['instanceIdList'] = self.instance_id_list
        if self.operator is not None:
            result['operator'] = self.operator
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instanceIdList') is not None:
            self.instance_id_list = m.get('instanceIdList')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        return self


class BatchDeleteReceiptResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
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


class BatchDeleteReceiptResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchDeleteReceiptResponseBody = None,
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
            temp_model = BatchDeleteReceiptResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetCategoryHeaders(TeaModel):
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


class GetCategoryRequest(TeaModel):
    def __init__(
        self,
        code: str = None,
    ):
        self.code = code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        return self


class GetCategoryResponseBody(TeaModel):
    def __init__(
        self,
        accountant_book_id_list: List[str] = None,
        code: str = None,
        is_dir: bool = None,
        name: str = None,
        parent_code: str = None,
        status: str = None,
        type: str = None,
    ):
        self.accountant_book_id_list = accountant_book_id_list
        self.code = code
        self.is_dir = is_dir
        self.name = name
        self.parent_code = parent_code
        self.status = status
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.accountant_book_id_list is not None:
            result['accountantBookIdList'] = self.accountant_book_id_list
        if self.code is not None:
            result['code'] = self.code
        if self.is_dir is not None:
            result['isDir'] = self.is_dir
        if self.name is not None:
            result['name'] = self.name
        if self.parent_code is not None:
            result['parentCode'] = self.parent_code
        if self.status is not None:
            result['status'] = self.status
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountantBookIdList') is not None:
            self.accountant_book_id_list = m.get('accountantBookIdList')
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('isDir') is not None:
            self.is_dir = m.get('isDir')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('parentCode') is not None:
            self.parent_code = m.get('parentCode')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GetCategoryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetCategoryResponseBody = None,
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
            temp_model = GetCategoryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetFinanceAccountHeaders(TeaModel):
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


class GetFinanceAccountRequest(TeaModel):
    def __init__(
        self,
        account_code: str = None,
    ):
        self.account_code = account_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_code is not None:
            result['accountCode'] = self.account_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountCode') is not None:
            self.account_code = m.get('accountCode')
        return self


class GetFinanceAccountResponseBody(TeaModel):
    def __init__(
        self,
        account_code: str = None,
        account_id: str = None,
        account_name: str = None,
        account_remark: str = None,
        account_type: str = None,
        accountant_book_id_list: List[str] = None,
        amount: str = None,
        bank_code: str = None,
        bank_name: str = None,
        create_time: int = None,
        creator: str = None,
    ):
        self.account_code = account_code
        self.account_id = account_id
        self.account_name = account_name
        self.account_remark = account_remark
        self.account_type = account_type
        self.accountant_book_id_list = accountant_book_id_list
        self.amount = amount
        self.bank_code = bank_code
        self.bank_name = bank_name
        self.create_time = create_time
        self.creator = creator

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_code is not None:
            result['accountCode'] = self.account_code
        if self.account_id is not None:
            result['accountId'] = self.account_id
        if self.account_name is not None:
            result['accountName'] = self.account_name
        if self.account_remark is not None:
            result['accountRemark'] = self.account_remark
        if self.account_type is not None:
            result['accountType'] = self.account_type
        if self.accountant_book_id_list is not None:
            result['accountantBookIdList'] = self.accountant_book_id_list
        if self.amount is not None:
            result['amount'] = self.amount
        if self.bank_code is not None:
            result['bankCode'] = self.bank_code
        if self.bank_name is not None:
            result['bankName'] = self.bank_name
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator is not None:
            result['creator'] = self.creator
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountCode') is not None:
            self.account_code = m.get('accountCode')
        if m.get('accountId') is not None:
            self.account_id = m.get('accountId')
        if m.get('accountName') is not None:
            self.account_name = m.get('accountName')
        if m.get('accountRemark') is not None:
            self.account_remark = m.get('accountRemark')
        if m.get('accountType') is not None:
            self.account_type = m.get('accountType')
        if m.get('accountantBookIdList') is not None:
            self.accountant_book_id_list = m.get('accountantBookIdList')
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('bankCode') is not None:
            self.bank_code = m.get('bankCode')
        if m.get('bankName') is not None:
            self.bank_name = m.get('bankName')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creator') is not None:
            self.creator = m.get('creator')
        return self


class GetFinanceAccountResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetFinanceAccountResponseBody = None,
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
            temp_model = GetFinanceAccountResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetProjectHeaders(TeaModel):
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


class GetProjectRequest(TeaModel):
    def __init__(
        self,
        code: str = None,
    ):
        self.code = code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        return self


class GetProjectResponseBody(TeaModel):
    def __init__(
        self,
        accountant_book_id_list: List[str] = None,
        code: str = None,
        create_time: int = None,
        creator: str = None,
        description: str = None,
        name: str = None,
        project_code: str = None,
        project_name: str = None,
        status: str = None,
        user_define_code: str = None,
    ):
        self.accountant_book_id_list = accountant_book_id_list
        self.code = code
        self.create_time = create_time
        self.creator = creator
        self.description = description
        self.name = name
        self.project_code = project_code
        self.project_name = project_name
        self.status = status
        self.user_define_code = user_define_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.accountant_book_id_list is not None:
            result['accountantBookIdList'] = self.accountant_book_id_list
        if self.code is not None:
            result['code'] = self.code
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator is not None:
            result['creator'] = self.creator
        if self.description is not None:
            result['description'] = self.description
        if self.name is not None:
            result['name'] = self.name
        if self.project_code is not None:
            result['projectCode'] = self.project_code
        if self.project_name is not None:
            result['projectName'] = self.project_name
        if self.status is not None:
            result['status'] = self.status
        if self.user_define_code is not None:
            result['userDefineCode'] = self.user_define_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountantBookIdList') is not None:
            self.accountant_book_id_list = m.get('accountantBookIdList')
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creator') is not None:
            self.creator = m.get('creator')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('projectCode') is not None:
            self.project_code = m.get('projectCode')
        if m.get('projectName') is not None:
            self.project_name = m.get('projectName')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userDefineCode') is not None:
            self.user_define_code = m.get('userDefineCode')
        return self


class GetProjectResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetProjectResponseBody = None,
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
            temp_model = GetProjectResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSupplierHeaders(TeaModel):
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


class GetSupplierRequest(TeaModel):
    def __init__(
        self,
        code: str = None,
    ):
        self.code = code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        return self


class GetSupplierResponseBody(TeaModel):
    def __init__(
        self,
        accountant_book_id_list: List[str] = None,
        code: str = None,
        create_time: int = None,
        description: str = None,
        name: str = None,
        status: str = None,
        user_define_code: str = None,
    ):
        self.accountant_book_id_list = accountant_book_id_list
        self.code = code
        self.create_time = create_time
        self.description = description
        self.name = name
        self.status = status
        self.user_define_code = user_define_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.accountant_book_id_list is not None:
            result['accountantBookIdList'] = self.accountant_book_id_list
        if self.code is not None:
            result['code'] = self.code
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.description is not None:
            result['description'] = self.description
        if self.name is not None:
            result['name'] = self.name
        if self.status is not None:
            result['status'] = self.status
        if self.user_define_code is not None:
            result['userDefineCode'] = self.user_define_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountantBookIdList') is not None:
            self.accountant_book_id_list = m.get('accountantBookIdList')
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userDefineCode') is not None:
            self.user_define_code = m.get('userDefineCode')
        return self


class GetSupplierResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetSupplierResponseBody = None,
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
            temp_model = GetSupplierResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryCategoryByPageHeaders(TeaModel):
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


class QueryCategoryByPageRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        type: str = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class QueryCategoryByPageResponseBodyList(TeaModel):
    def __init__(
        self,
        code: str = None,
        is_dir: bool = None,
        name: str = None,
        parent_code: str = None,
        status: str = None,
        type: str = None,
    ):
        self.code = code
        self.is_dir = is_dir
        self.name = name
        self.parent_code = parent_code
        self.status = status
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.is_dir is not None:
            result['isDir'] = self.is_dir
        if self.name is not None:
            result['name'] = self.name
        if self.parent_code is not None:
            result['parentCode'] = self.parent_code
        if self.status is not None:
            result['status'] = self.status
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('isDir') is not None:
            self.is_dir = m.get('isDir')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('parentCode') is not None:
            self.parent_code = m.get('parentCode')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class QueryCategoryByPageResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QueryCategoryByPageResponseBodyList] = None,
    ):
        self.has_more = has_more
        self.list = list

    def validate(self):
        if self.list:
            for k in self.list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryCategoryByPageResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class QueryCategoryByPageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryCategoryByPageResponseBody = None,
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
            temp_model = QueryCategoryByPageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryCustomerByPageHeaders(TeaModel):
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


class QueryCustomerByPageRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
    ):
        self.page_number = page_number
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class QueryCustomerByPageResponseBodyList(TeaModel):
    def __init__(
        self,
        code: str = None,
        create_time: int = None,
        description: str = None,
        name: str = None,
        status: str = None,
        user_define_code: str = None,
    ):
        self.code = code
        self.create_time = create_time
        self.description = description
        self.name = name
        self.status = status
        self.user_define_code = user_define_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.description is not None:
            result['description'] = self.description
        if self.name is not None:
            result['name'] = self.name
        if self.status is not None:
            result['status'] = self.status
        if self.user_define_code is not None:
            result['userDefineCode'] = self.user_define_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userDefineCode') is not None:
            self.user_define_code = m.get('userDefineCode')
        return self


class QueryCustomerByPageResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QueryCustomerByPageResponseBodyList] = None,
    ):
        self.has_more = has_more
        self.list = list

    def validate(self):
        if self.list:
            for k in self.list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryCustomerByPageResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class QueryCustomerByPageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryCustomerByPageResponseBody = None,
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
            temp_model = QueryCustomerByPageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryEnterpriseAccountByPageHeaders(TeaModel):
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


class QueryEnterpriseAccountByPageRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
    ):
        self.page_number = page_number
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class QueryEnterpriseAccountByPageResponseBodyList(TeaModel):
    def __init__(
        self,
        account_code: str = None,
        account_id: str = None,
        account_name: str = None,
        account_remark: str = None,
        account_type: str = None,
        amount: str = None,
        bank_code: str = None,
        bank_name: str = None,
        create_time: int = None,
        creator: str = None,
    ):
        self.account_code = account_code
        self.account_id = account_id
        self.account_name = account_name
        self.account_remark = account_remark
        self.account_type = account_type
        self.amount = amount
        self.bank_code = bank_code
        self.bank_name = bank_name
        self.create_time = create_time
        self.creator = creator

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_code is not None:
            result['accountCode'] = self.account_code
        if self.account_id is not None:
            result['accountId'] = self.account_id
        if self.account_name is not None:
            result['accountName'] = self.account_name
        if self.account_remark is not None:
            result['accountRemark'] = self.account_remark
        if self.account_type is not None:
            result['accountType'] = self.account_type
        if self.amount is not None:
            result['amount'] = self.amount
        if self.bank_code is not None:
            result['bankCode'] = self.bank_code
        if self.bank_name is not None:
            result['bankName'] = self.bank_name
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator is not None:
            result['creator'] = self.creator
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountCode') is not None:
            self.account_code = m.get('accountCode')
        if m.get('accountId') is not None:
            self.account_id = m.get('accountId')
        if m.get('accountName') is not None:
            self.account_name = m.get('accountName')
        if m.get('accountRemark') is not None:
            self.account_remark = m.get('accountRemark')
        if m.get('accountType') is not None:
            self.account_type = m.get('accountType')
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('bankCode') is not None:
            self.bank_code = m.get('bankCode')
        if m.get('bankName') is not None:
            self.bank_name = m.get('bankName')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creator') is not None:
            self.creator = m.get('creator')
        return self


class QueryEnterpriseAccountByPageResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QueryEnterpriseAccountByPageResponseBodyList] = None,
    ):
        self.has_more = has_more
        self.list = list

    def validate(self):
        if self.list:
            for k in self.list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryEnterpriseAccountByPageResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class QueryEnterpriseAccountByPageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryEnterpriseAccountByPageResponseBody = None,
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
            temp_model = QueryEnterpriseAccountByPageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryInstancePaymentOrderDetailHeaders(TeaModel):
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


class QueryInstancePaymentOrderDetailRequest(TeaModel):
    def __init__(
        self,
        order_no: str = None,
    ):
        self.order_no = order_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        return self


class QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTOBankOpenDTO(TeaModel):
    def __init__(
        self,
        account_name: str = None,
        bank_branch_code: str = None,
        bank_branch_name: str = None,
        bank_card_no: str = None,
        bank_code: str = None,
        bank_name: str = None,
        type: str = None,
    ):
        self.account_name = account_name
        self.bank_branch_code = bank_branch_code
        self.bank_branch_name = bank_branch_name
        self.bank_card_no = bank_card_no
        self.bank_code = bank_code
        self.bank_name = bank_name
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_name is not None:
            result['accountName'] = self.account_name
        if self.bank_branch_code is not None:
            result['bankBranchCode'] = self.bank_branch_code
        if self.bank_branch_name is not None:
            result['bankBranchName'] = self.bank_branch_name
        if self.bank_card_no is not None:
            result['bankCardNo'] = self.bank_card_no
        if self.bank_code is not None:
            result['bankCode'] = self.bank_code
        if self.bank_name is not None:
            result['bankName'] = self.bank_name
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountName') is not None:
            self.account_name = m.get('accountName')
        if m.get('bankBranchCode') is not None:
            self.bank_branch_code = m.get('bankBranchCode')
        if m.get('bankBranchName') is not None:
            self.bank_branch_name = m.get('bankBranchName')
        if m.get('bankCardNo') is not None:
            self.bank_card_no = m.get('bankCardNo')
        if m.get('bankCode') is not None:
            self.bank_code = m.get('bankCode')
        if m.get('bankName') is not None:
            self.bank_name = m.get('bankName')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTO(TeaModel):
    def __init__(
        self,
        bank_open_dto: QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTOBankOpenDTO = None,
    ):
        self.bank_open_dto = bank_open_dto

    def validate(self):
        if self.bank_open_dto:
            self.bank_open_dto.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.bank_open_dto is not None:
            result['bankOpenDTO'] = self.bank_open_dto.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bankOpenDTO') is not None:
            temp_model = QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTOBankOpenDTO()
            self.bank_open_dto = temp_model.from_map(m['bankOpenDTO'])
        return self


class QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTOBankOpenDTO(TeaModel):
    def __init__(
        self,
        account_name: str = None,
        bank_branch_code: str = None,
        bank_branch_name: str = None,
        bank_card_no: str = None,
        bank_code: str = None,
        bank_name: str = None,
        type: str = None,
    ):
        self.account_name = account_name
        self.bank_branch_code = bank_branch_code
        self.bank_branch_name = bank_branch_name
        self.bank_card_no = bank_card_no
        self.bank_code = bank_code
        self.bank_name = bank_name
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_name is not None:
            result['accountName'] = self.account_name
        if self.bank_branch_code is not None:
            result['bankBranchCode'] = self.bank_branch_code
        if self.bank_branch_name is not None:
            result['bankBranchName'] = self.bank_branch_name
        if self.bank_card_no is not None:
            result['bankCardNo'] = self.bank_card_no
        if self.bank_code is not None:
            result['bankCode'] = self.bank_code
        if self.bank_name is not None:
            result['bankName'] = self.bank_name
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountName') is not None:
            self.account_name = m.get('accountName')
        if m.get('bankBranchCode') is not None:
            self.bank_branch_code = m.get('bankBranchCode')
        if m.get('bankBranchName') is not None:
            self.bank_branch_name = m.get('bankBranchName')
        if m.get('bankCardNo') is not None:
            self.bank_card_no = m.get('bankCardNo')
        if m.get('bankCode') is not None:
            self.bank_code = m.get('bankCode')
        if m.get('bankName') is not None:
            self.bank_name = m.get('bankName')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTO(TeaModel):
    def __init__(
        self,
        bank_open_dto: QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTOBankOpenDTO = None,
        enterprise_account_code: str = None,
    ):
        self.bank_open_dto = bank_open_dto
        self.enterprise_account_code = enterprise_account_code

    def validate(self):
        if self.bank_open_dto:
            self.bank_open_dto.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.bank_open_dto is not None:
            result['bankOpenDTO'] = self.bank_open_dto.to_map()
        if self.enterprise_account_code is not None:
            result['enterpriseAccountCode'] = self.enterprise_account_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bankOpenDTO') is not None:
            temp_model = QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTOBankOpenDTO()
            self.bank_open_dto = temp_model.from_map(m['bankOpenDTO'])
        if m.get('enterpriseAccountCode') is not None:
            self.enterprise_account_code = m.get('enterpriseAccountCode')
        return self


class QueryInstancePaymentOrderDetailResponseBody(TeaModel):
    def __init__(
        self,
        amount: str = None,
        instance_id: str = None,
        payee_account_dto: QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTO = None,
        payer_account_dto: QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTO = None,
        remark: str = None,
        usage: str = None,
        user_id: str = None,
    ):
        self.amount = amount
        self.instance_id = instance_id
        self.payee_account_dto = payee_account_dto
        self.payer_account_dto = payer_account_dto
        self.remark = remark
        self.usage = usage
        self.user_id = user_id

    def validate(self):
        if self.payee_account_dto:
            self.payee_account_dto.validate()
        if self.payer_account_dto:
            self.payer_account_dto.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.payee_account_dto is not None:
            result['payeeAccountDTO'] = self.payee_account_dto.to_map()
        if self.payer_account_dto is not None:
            result['payerAccountDTO'] = self.payer_account_dto.to_map()
        if self.remark is not None:
            result['remark'] = self.remark
        if self.usage is not None:
            result['usage'] = self.usage
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('payeeAccountDTO') is not None:
            temp_model = QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTO()
            self.payee_account_dto = temp_model.from_map(m['payeeAccountDTO'])
        if m.get('payerAccountDTO') is not None:
            temp_model = QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTO()
            self.payer_account_dto = temp_model.from_map(m['payerAccountDTO'])
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('usage') is not None:
            self.usage = m.get('usage')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryInstancePaymentOrderDetailResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryInstancePaymentOrderDetailResponseBody = None,
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
            temp_model = QueryInstancePaymentOrderDetailResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryProjectByPageHeaders(TeaModel):
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


class QueryProjectByPageRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
    ):
        self.page_number = page_number
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class QueryProjectByPageResponseBodyList(TeaModel):
    def __init__(
        self,
        caode: str = None,
        code: str = None,
        create_time: int = None,
        creator: str = None,
        description: str = None,
        name: str = None,
        project_code: str = None,
        project_name: str = None,
        status: str = None,
        user_define_code: str = None,
    ):
        self.caode = caode
        self.code = code
        self.create_time = create_time
        self.creator = creator
        self.description = description
        self.name = name
        self.project_code = project_code
        self.project_name = project_name
        self.status = status
        self.user_define_code = user_define_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.caode is not None:
            result['caode'] = self.caode
        if self.code is not None:
            result['code'] = self.code
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator is not None:
            result['creator'] = self.creator
        if self.description is not None:
            result['description'] = self.description
        if self.name is not None:
            result['name'] = self.name
        if self.project_code is not None:
            result['projectCode'] = self.project_code
        if self.project_name is not None:
            result['projectName'] = self.project_name
        if self.status is not None:
            result['status'] = self.status
        if self.user_define_code is not None:
            result['userDefineCode'] = self.user_define_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('caode') is not None:
            self.caode = m.get('caode')
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creator') is not None:
            self.creator = m.get('creator')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('projectCode') is not None:
            self.project_code = m.get('projectCode')
        if m.get('projectName') is not None:
            self.project_name = m.get('projectName')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userDefineCode') is not None:
            self.user_define_code = m.get('userDefineCode')
        return self


class QueryProjectByPageResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QueryProjectByPageResponseBodyList] = None,
    ):
        self.has_more = has_more
        self.list = list

    def validate(self):
        if self.list:
            for k in self.list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryProjectByPageResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class QueryProjectByPageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryProjectByPageResponseBody = None,
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
            temp_model = QueryProjectByPageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QuerySupplierByPageHeaders(TeaModel):
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


class QuerySupplierByPageRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
    ):
        self.page_number = page_number
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class QuerySupplierByPageResponseBodyList(TeaModel):
    def __init__(
        self,
        code: str = None,
        create_time: int = None,
        description: str = None,
        name: str = None,
        status: str = None,
        user_define_code: str = None,
    ):
        self.code = code
        self.create_time = create_time
        self.description = description
        self.name = name
        self.status = status
        self.user_define_code = user_define_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.description is not None:
            result['description'] = self.description
        if self.name is not None:
            result['name'] = self.name
        if self.status is not None:
            result['status'] = self.status
        if self.user_define_code is not None:
            result['userDefineCode'] = self.user_define_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userDefineCode') is not None:
            self.user_define_code = m.get('userDefineCode')
        return self


class QuerySupplierByPageResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QuerySupplierByPageResponseBodyList] = None,
    ):
        self.has_more = has_more
        self.list = list

    def validate(self):
        if self.list:
            for k in self.list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QuerySupplierByPageResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class QuerySupplierByPageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QuerySupplierByPageResponseBody = None,
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
            temp_model = QuerySupplierByPageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SignEnterpriseAccountHeaders(TeaModel):
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


class SignEnterpriseAccountRequest(TeaModel):
    def __init__(
        self,
        bank_card_no: str = None,
        operator: str = None,
        sign_operate_type: str = None,
    ):
        self.bank_card_no = bank_card_no
        self.operator = operator
        self.sign_operate_type = sign_operate_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.bank_card_no is not None:
            result['bankCardNo'] = self.bank_card_no
        if self.operator is not None:
            result['operator'] = self.operator
        if self.sign_operate_type is not None:
            result['signOperateType'] = self.sign_operate_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bankCardNo') is not None:
            self.bank_card_no = m.get('bankCardNo')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('signOperateType') is not None:
            self.sign_operate_type = m.get('signOperateType')
        return self


class SignEnterpriseAccountResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
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


class SignEnterpriseAccountResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SignEnterpriseAccountResponseBody = None,
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
            temp_model = SignEnterpriseAccountResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateInstanceOrderInfoHeaders(TeaModel):
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


class UpdateInstanceOrderInfoRequestPayerBank(TeaModel):
    def __init__(
        self,
        card_no: str = None,
        name: str = None,
    ):
        self.card_no = card_no
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_no is not None:
            result['cardNo'] = self.card_no
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardNo') is not None:
            self.card_no = m.get('cardNo')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class UpdateInstanceOrderInfoRequest(TeaModel):
    def __init__(
        self,
        fail_reason: str = None,
        order_no: str = None,
        out_order_no: str = None,
        payer_bank: UpdateInstanceOrderInfoRequestPayerBank = None,
        status: str = None,
        user_id: str = None,
    ):
        self.fail_reason = fail_reason
        self.order_no = order_no
        self.out_order_no = out_order_no
        self.payer_bank = payer_bank
        self.status = status
        self.user_id = user_id

    def validate(self):
        if self.payer_bank:
            self.payer_bank.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.fail_reason is not None:
            result['failReason'] = self.fail_reason
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.out_order_no is not None:
            result['outOrderNo'] = self.out_order_no
        if self.payer_bank is not None:
            result['payerBank'] = self.payer_bank.to_map()
        if self.status is not None:
            result['status'] = self.status
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('failReason') is not None:
            self.fail_reason = m.get('failReason')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('outOrderNo') is not None:
            self.out_order_no = m.get('outOrderNo')
        if m.get('payerBank') is not None:
            temp_model = UpdateInstanceOrderInfoRequestPayerBank()
            self.payer_bank = temp_model.from_map(m['payerBank'])
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UpdateInstanceOrderInfoShrinkRequest(TeaModel):
    def __init__(
        self,
        fail_reason: str = None,
        order_no: str = None,
        out_order_no: str = None,
        payer_bank_shrink: str = None,
        status: str = None,
        user_id: str = None,
    ):
        self.fail_reason = fail_reason
        self.order_no = order_no
        self.out_order_no = out_order_no
        self.payer_bank_shrink = payer_bank_shrink
        self.status = status
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.fail_reason is not None:
            result['failReason'] = self.fail_reason
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.out_order_no is not None:
            result['outOrderNo'] = self.out_order_no
        if self.payer_bank_shrink is not None:
            result['payerBank'] = self.payer_bank_shrink
        if self.status is not None:
            result['status'] = self.status
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('failReason') is not None:
            self.fail_reason = m.get('failReason')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('outOrderNo') is not None:
            self.out_order_no = m.get('outOrderNo')
        if m.get('payerBank') is not None:
            self.payer_bank_shrink = m.get('payerBank')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UpdateInstanceOrderInfoResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
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


class UpdateInstanceOrderInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateInstanceOrderInfoResponseBody = None,
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
            temp_model = UpdateInstanceOrderInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


