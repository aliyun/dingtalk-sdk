# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class BankGatewayInvokeHeaders(TeaModel):
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


class BankGatewayInvokeRequest(TeaModel):
    def __init__(
        self,
        action_type: str = None,
        input_data: str = None,
        url: str = None,
    ):
        self.action_type = action_type
        self.input_data = input_data
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_type is not None:
            result['actionType'] = self.action_type
        if self.input_data is not None:
            result['inputData'] = self.input_data
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionType') is not None:
            self.action_type = m.get('actionType')
        if m.get('inputData') is not None:
            self.input_data = m.get('inputData')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class BankGatewayInvokeResponseBody(TeaModel):
    def __init__(
        self,
        output_data: str = None,
    ):
        self.output_data = output_data

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.output_data is not None:
            result['outputData'] = self.output_data
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('outputData') is not None:
            self.output_data = m.get('outputData')
        return self


class BankGatewayInvokeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BankGatewayInvokeResponseBody = None,
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
            temp_model = BankGatewayInvokeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


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


class BatchSyncBankReceiptHeaders(TeaModel):
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


class BatchSyncBankReceiptRequestBody(TeaModel):
    def __init__(
        self,
        file_download_url: str = None,
        file_name: str = None,
        message_id: str = None,
        message_id_type: str = None,
    ):
        self.file_download_url = file_download_url
        self.file_name = file_name
        self.message_id = message_id
        self.message_id_type = message_id_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_download_url is not None:
            result['fileDownloadUrl'] = self.file_download_url
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.message_id is not None:
            result['messageId'] = self.message_id
        if self.message_id_type is not None:
            result['messageIdType'] = self.message_id_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileDownloadUrl') is not None:
            self.file_download_url = m.get('fileDownloadUrl')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('messageId') is not None:
            self.message_id = m.get('messageId')
        if m.get('messageIdType') is not None:
            self.message_id_type = m.get('messageIdType')
        return self


class BatchSyncBankReceiptRequest(TeaModel):
    def __init__(
        self,
        body: List[BatchSyncBankReceiptRequestBody] = None,
    ):
        self.body = body

    def validate(self):
        if self.body:
            for k in self.body:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['body'] = []
        if self.body is not None:
            for k in self.body:
                result['body'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.body = []
        if m.get('body') is not None:
            for k in m.get('body'):
                temp_model = BatchSyncBankReceiptRequestBody()
                self.body.append(temp_model.from_map(k))
        return self


class BatchSyncBankReceiptResponseBody(TeaModel):
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


class BatchSyncBankReceiptResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchSyncBankReceiptResponseBody = None,
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
            temp_model = BatchSyncBankReceiptResponseBody()
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
        # This parameter is required.
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
        remark: str = None,
        status: str = None,
        type: str = None,
    ):
        self.accountant_book_id_list = accountant_book_id_list
        # This parameter is required.
        self.code = code
        # This parameter is required.
        self.is_dir = is_dir
        # This parameter is required.
        self.name = name
        self.parent_code = parent_code
        self.remark = remark
        # This parameter is required.
        self.status = status
        # This parameter is required.
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
        if self.remark is not None:
            result['remark'] = self.remark
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
        if m.get('remark') is not None:
            self.remark = m.get('remark')
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
        # This parameter is required.
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
        # This parameter is required.
        self.account_code = account_code
        self.account_id = account_id
        # This parameter is required.
        self.account_name = account_name
        self.account_remark = account_remark
        # This parameter is required.
        self.account_type = account_type
        self.accountant_book_id_list = accountant_book_id_list
        self.amount = amount
        self.bank_code = bank_code
        self.bank_name = bank_name
        # This parameter is required.
        self.create_time = create_time
        # This parameter is required.
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
        # This parameter is required.
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
        # This parameter is required.
        self.create_time = create_time
        # This parameter is required.
        self.creator = creator
        # This parameter is required.
        self.description = description
        self.name = name
        # This parameter is required.
        self.project_code = project_code
        # This parameter is required.
        self.project_name = project_name
        # This parameter is required.
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


class GetReceiptHeaders(TeaModel):
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


class GetReceiptRequest(TeaModel):
    def __init__(
        self,
        code: str = None,
        model_id: str = None,
    ):
        # This parameter is required.
        self.code = code
        # This parameter is required.
        self.model_id = model_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.model_id is not None:
            result['modelId'] = self.model_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('modelId') is not None:
            self.model_id = m.get('modelId')
        return self


class GetReceiptResponseBody(TeaModel):
    def __init__(
        self,
        app_id: str = None,
        data: str = None,
        model_id: str = None,
        source: str = None,
    ):
        # This parameter is required.
        self.app_id = app_id
        # This parameter is required.
        self.data = data
        # This parameter is required.
        self.model_id = model_id
        # This parameter is required.
        self.source = source

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.data is not None:
            result['data'] = self.data
        if self.model_id is not None:
            result['modelId'] = self.model_id
        if self.source is not None:
            result['source'] = self.source
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('modelId') is not None:
            self.model_id = m.get('modelId')
        if m.get('source') is not None:
            self.source = m.get('source')
        return self


class GetReceiptResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetReceiptResponseBody = None,
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
            temp_model = GetReceiptResponseBody()
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
        # This parameter is required.
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
        # This parameter is required.
        self.code = code
        # This parameter is required.
        self.create_time = create_time
        # This parameter is required.
        self.description = description
        # This parameter is required.
        self.name = name
        # This parameter is required.
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


class IssueInvoiceWithOrderHeaders(TeaModel):
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


class IssueInvoiceWithOrderRequestContentAdditionInfo(TeaModel):
    def __init__(
        self,
        addition_content: str = None,
        addition_name: str = None,
        data_type: int = None,
    ):
        self.addition_content = addition_content
        self.addition_name = addition_name
        self.data_type = data_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.addition_content is not None:
            result['additionContent'] = self.addition_content
        if self.addition_name is not None:
            result['additionName'] = self.addition_name
        if self.data_type is not None:
            result['dataType'] = self.data_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('additionContent') is not None:
            self.addition_content = m.get('additionContent')
        if m.get('additionName') is not None:
            self.addition_name = m.get('additionName')
        if m.get('dataType') is not None:
            self.data_type = m.get('dataType')
        return self


class IssueInvoiceWithOrderRequestContentProducts(TeaModel):
    def __init__(
        self,
        amount_include_tax: str = None,
        product_name: str = None,
        quantity: str = None,
        revenue_code: str = None,
        specs: str = None,
        tax_sign: str = None,
        unit: str = None,
    ):
        self.amount_include_tax = amount_include_tax
        self.product_name = product_name
        self.quantity = quantity
        self.revenue_code = revenue_code
        self.specs = specs
        self.tax_sign = tax_sign
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount_include_tax is not None:
            result['amountIncludeTax'] = self.amount_include_tax
        if self.product_name is not None:
            result['productName'] = self.product_name
        if self.quantity is not None:
            result['quantity'] = self.quantity
        if self.revenue_code is not None:
            result['revenueCode'] = self.revenue_code
        if self.specs is not None:
            result['specs'] = self.specs
        if self.tax_sign is not None:
            result['taxSign'] = self.tax_sign
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amountIncludeTax') is not None:
            self.amount_include_tax = m.get('amountIncludeTax')
        if m.get('productName') is not None:
            self.product_name = m.get('productName')
        if m.get('quantity') is not None:
            self.quantity = m.get('quantity')
        if m.get('revenueCode') is not None:
            self.revenue_code = m.get('revenueCode')
        if m.get('specs') is not None:
            self.specs = m.get('specs')
        if m.get('taxSign') is not None:
            self.tax_sign = m.get('taxSign')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class IssueInvoiceWithOrderRequestContent(TeaModel):
    def __init__(
        self,
        addition_info: List[IssueInvoiceWithOrderRequestContentAdditionInfo] = None,
        apply_person: str = None,
        bank_account: str = None,
        bank_name: str = None,
        invoice_remark: str = None,
        invoice_type: int = None,
        natural_person: str = None,
        order_id: str = None,
        payee: str = None,
        phone: str = None,
        products: List[IssueInvoiceWithOrderRequestContentProducts] = None,
        purchaser: str = None,
        purchaser_address: str = None,
        purchaser_tel: str = None,
        remark: str = None,
        reviewer: str = None,
        taxnum: str = None,
    ):
        self.addition_info = addition_info
        self.apply_person = apply_person
        self.bank_account = bank_account
        self.bank_name = bank_name
        self.invoice_remark = invoice_remark
        self.invoice_type = invoice_type
        self.natural_person = natural_person
        self.order_id = order_id
        self.payee = payee
        self.phone = phone
        self.products = products
        self.purchaser = purchaser
        self.purchaser_address = purchaser_address
        self.purchaser_tel = purchaser_tel
        self.remark = remark
        self.reviewer = reviewer
        self.taxnum = taxnum

    def validate(self):
        if self.addition_info:
            for k in self.addition_info:
                if k:
                    k.validate()
        if self.products:
            for k in self.products:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['additionInfo'] = []
        if self.addition_info is not None:
            for k in self.addition_info:
                result['additionInfo'].append(k.to_map() if k else None)
        if self.apply_person is not None:
            result['applyPerson'] = self.apply_person
        if self.bank_account is not None:
            result['bankAccount'] = self.bank_account
        if self.bank_name is not None:
            result['bankName'] = self.bank_name
        if self.invoice_remark is not None:
            result['invoiceRemark'] = self.invoice_remark
        if self.invoice_type is not None:
            result['invoiceType'] = self.invoice_type
        if self.natural_person is not None:
            result['naturalPerson'] = self.natural_person
        if self.order_id is not None:
            result['orderId'] = self.order_id
        if self.payee is not None:
            result['payee'] = self.payee
        if self.phone is not None:
            result['phone'] = self.phone
        result['products'] = []
        if self.products is not None:
            for k in self.products:
                result['products'].append(k.to_map() if k else None)
        if self.purchaser is not None:
            result['purchaser'] = self.purchaser
        if self.purchaser_address is not None:
            result['purchaserAddress'] = self.purchaser_address
        if self.purchaser_tel is not None:
            result['purchaserTel'] = self.purchaser_tel
        if self.remark is not None:
            result['remark'] = self.remark
        if self.reviewer is not None:
            result['reviewer'] = self.reviewer
        if self.taxnum is not None:
            result['taxnum'] = self.taxnum
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.addition_info = []
        if m.get('additionInfo') is not None:
            for k in m.get('additionInfo'):
                temp_model = IssueInvoiceWithOrderRequestContentAdditionInfo()
                self.addition_info.append(temp_model.from_map(k))
        if m.get('applyPerson') is not None:
            self.apply_person = m.get('applyPerson')
        if m.get('bankAccount') is not None:
            self.bank_account = m.get('bankAccount')
        if m.get('bankName') is not None:
            self.bank_name = m.get('bankName')
        if m.get('invoiceRemark') is not None:
            self.invoice_remark = m.get('invoiceRemark')
        if m.get('invoiceType') is not None:
            self.invoice_type = m.get('invoiceType')
        if m.get('naturalPerson') is not None:
            self.natural_person = m.get('naturalPerson')
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        if m.get('payee') is not None:
            self.payee = m.get('payee')
        if m.get('phone') is not None:
            self.phone = m.get('phone')
        self.products = []
        if m.get('products') is not None:
            for k in m.get('products'):
                temp_model = IssueInvoiceWithOrderRequestContentProducts()
                self.products.append(temp_model.from_map(k))
        if m.get('purchaser') is not None:
            self.purchaser = m.get('purchaser')
        if m.get('purchaserAddress') is not None:
            self.purchaser_address = m.get('purchaserAddress')
        if m.get('purchaserTel') is not None:
            self.purchaser_tel = m.get('purchaserTel')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('reviewer') is not None:
            self.reviewer = m.get('reviewer')
        if m.get('taxnum') is not None:
            self.taxnum = m.get('taxnum')
        return self


class IssueInvoiceWithOrderRequest(TeaModel):
    def __init__(
        self,
        content: IssueInvoiceWithOrderRequestContent = None,
        finance_app_key: str = None,
        operator: str = None,
        signature: str = None,
    ):
        self.content = content
        self.finance_app_key = finance_app_key
        self.operator = operator
        self.signature = signature

    def validate(self):
        if self.content:
            self.content.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content.to_map()
        if self.finance_app_key is not None:
            result['financeAppKey'] = self.finance_app_key
        if self.operator is not None:
            result['operator'] = self.operator
        if self.signature is not None:
            result['signature'] = self.signature
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            temp_model = IssueInvoiceWithOrderRequestContent()
            self.content = temp_model.from_map(m['content'])
        if m.get('financeAppKey') is not None:
            self.finance_app_key = m.get('financeAppKey')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('signature') is not None:
            self.signature = m.get('signature')
        return self


class IssueInvoiceWithOrderResponseBody(TeaModel):
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


class IssueInvoiceWithOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: IssueInvoiceWithOrderResponseBody = None,
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
            temp_model = IssueInvoiceWithOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class LinkCommonInvokeHeaders(TeaModel):
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


class LinkCommonInvokeRequest(TeaModel):
    def __init__(
        self,
        biz_type: str = None,
        data: str = None,
        invoke_id: str = None,
        user_id: str = None,
    ):
        self.biz_type = biz_type
        self.data = data
        self.invoke_id = invoke_id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.data is not None:
            result['data'] = self.data
        if self.invoke_id is not None:
            result['invokeId'] = self.invoke_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('invokeId') is not None:
            self.invoke_id = m.get('invokeId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class LinkCommonInvokeResponseBody(TeaModel):
    def __init__(
        self,
        biz_type: str = None,
        data: str = None,
        invoke_id: str = None,
    ):
        self.biz_type = biz_type
        self.data = data
        self.invoke_id = invoke_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.data is not None:
            result['data'] = self.data
        if self.invoke_id is not None:
            result['invokeId'] = self.invoke_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('invokeId') is not None:
            self.invoke_id = m.get('invokeId')
        return self


class LinkCommonInvokeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: LinkCommonInvokeResponseBody = None,
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
            temp_model = LinkCommonInvokeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class OrderBillingHeaders(TeaModel):
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


class OrderBillingRequestAdditionInfos(TeaModel):
    def __init__(
        self,
        addition_content: str = None,
        addition_name: str = None,
        data_type: int = None,
    ):
        self.addition_content = addition_content
        self.addition_name = addition_name
        self.data_type = data_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.addition_content is not None:
            result['additionContent'] = self.addition_content
        if self.addition_name is not None:
            result['additionName'] = self.addition_name
        if self.data_type is not None:
            result['dataType'] = self.data_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('additionContent') is not None:
            self.addition_content = m.get('additionContent')
        if m.get('additionName') is not None:
            self.addition_name = m.get('additionName')
        if m.get('dataType') is not None:
            self.data_type = m.get('dataType')
        return self


class OrderBillingRequestProducts(TeaModel):
    def __init__(
        self,
        amount_with_tax: str = None,
        product_name: str = None,
        quantity: str = None,
        revenue_code: str = None,
        specification: str = None,
        unit: str = None,
        unit_price: str = None,
    ):
        self.amount_with_tax = amount_with_tax
        self.product_name = product_name
        self.quantity = quantity
        self.revenue_code = revenue_code
        self.specification = specification
        self.unit = unit
        self.unit_price = unit_price

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount_with_tax is not None:
            result['amountWithTax'] = self.amount_with_tax
        if self.product_name is not None:
            result['productName'] = self.product_name
        if self.quantity is not None:
            result['quantity'] = self.quantity
        if self.revenue_code is not None:
            result['revenueCode'] = self.revenue_code
        if self.specification is not None:
            result['specification'] = self.specification
        if self.unit is not None:
            result['unit'] = self.unit
        if self.unit_price is not None:
            result['unitPrice'] = self.unit_price
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amountWithTax') is not None:
            self.amount_with_tax = m.get('amountWithTax')
        if m.get('productName') is not None:
            self.product_name = m.get('productName')
        if m.get('quantity') is not None:
            self.quantity = m.get('quantity')
        if m.get('revenueCode') is not None:
            self.revenue_code = m.get('revenueCode')
        if m.get('specification') is not None:
            self.specification = m.get('specification')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('unitPrice') is not None:
            self.unit_price = m.get('unitPrice')
        return self


class OrderBillingRequest(TeaModel):
    def __init__(
        self,
        addition_infos: List[OrderBillingRequestAdditionInfos] = None,
        app_key: str = None,
        apply_person: str = None,
        invoice_remark: str = None,
        invoice_type: str = None,
        is_natural_person: bool = None,
        operator: str = None,
        order_id: str = None,
        payee: str = None,
        phone: str = None,
        products: List[OrderBillingRequestProducts] = None,
        purchaser_address: str = None,
        purchaser_bank_account: str = None,
        purchaser_bank_name: str = None,
        purchaser_name: str = None,
        purchaser_tax_no: str = None,
        purchaser_tel: str = None,
        remark: str = None,
        reviewer: str = None,
        signature: str = None,
        tax_sign: int = None,
    ):
        self.addition_infos = addition_infos
        self.app_key = app_key
        self.apply_person = apply_person
        self.invoice_remark = invoice_remark
        self.invoice_type = invoice_type
        self.is_natural_person = is_natural_person
        self.operator = operator
        self.order_id = order_id
        self.payee = payee
        self.phone = phone
        self.products = products
        self.purchaser_address = purchaser_address
        self.purchaser_bank_account = purchaser_bank_account
        self.purchaser_bank_name = purchaser_bank_name
        self.purchaser_name = purchaser_name
        self.purchaser_tax_no = purchaser_tax_no
        self.purchaser_tel = purchaser_tel
        self.remark = remark
        self.reviewer = reviewer
        self.signature = signature
        self.tax_sign = tax_sign

    def validate(self):
        if self.addition_infos:
            for k in self.addition_infos:
                if k:
                    k.validate()
        if self.products:
            for k in self.products:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['additionInfos'] = []
        if self.addition_infos is not None:
            for k in self.addition_infos:
                result['additionInfos'].append(k.to_map() if k else None)
        if self.app_key is not None:
            result['appKey'] = self.app_key
        if self.apply_person is not None:
            result['applyPerson'] = self.apply_person
        if self.invoice_remark is not None:
            result['invoiceRemark'] = self.invoice_remark
        if self.invoice_type is not None:
            result['invoiceType'] = self.invoice_type
        if self.is_natural_person is not None:
            result['isNaturalPerson'] = self.is_natural_person
        if self.operator is not None:
            result['operator'] = self.operator
        if self.order_id is not None:
            result['orderId'] = self.order_id
        if self.payee is not None:
            result['payee'] = self.payee
        if self.phone is not None:
            result['phone'] = self.phone
        result['products'] = []
        if self.products is not None:
            for k in self.products:
                result['products'].append(k.to_map() if k else None)
        if self.purchaser_address is not None:
            result['purchaserAddress'] = self.purchaser_address
        if self.purchaser_bank_account is not None:
            result['purchaserBankAccount'] = self.purchaser_bank_account
        if self.purchaser_bank_name is not None:
            result['purchaserBankName'] = self.purchaser_bank_name
        if self.purchaser_name is not None:
            result['purchaserName'] = self.purchaser_name
        if self.purchaser_tax_no is not None:
            result['purchaserTaxNo'] = self.purchaser_tax_no
        if self.purchaser_tel is not None:
            result['purchaserTel'] = self.purchaser_tel
        if self.remark is not None:
            result['remark'] = self.remark
        if self.reviewer is not None:
            result['reviewer'] = self.reviewer
        if self.signature is not None:
            result['signature'] = self.signature
        if self.tax_sign is not None:
            result['taxSign'] = self.tax_sign
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.addition_infos = []
        if m.get('additionInfos') is not None:
            for k in m.get('additionInfos'):
                temp_model = OrderBillingRequestAdditionInfos()
                self.addition_infos.append(temp_model.from_map(k))
        if m.get('appKey') is not None:
            self.app_key = m.get('appKey')
        if m.get('applyPerson') is not None:
            self.apply_person = m.get('applyPerson')
        if m.get('invoiceRemark') is not None:
            self.invoice_remark = m.get('invoiceRemark')
        if m.get('invoiceType') is not None:
            self.invoice_type = m.get('invoiceType')
        if m.get('isNaturalPerson') is not None:
            self.is_natural_person = m.get('isNaturalPerson')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        if m.get('payee') is not None:
            self.payee = m.get('payee')
        if m.get('phone') is not None:
            self.phone = m.get('phone')
        self.products = []
        if m.get('products') is not None:
            for k in m.get('products'):
                temp_model = OrderBillingRequestProducts()
                self.products.append(temp_model.from_map(k))
        if m.get('purchaserAddress') is not None:
            self.purchaser_address = m.get('purchaserAddress')
        if m.get('purchaserBankAccount') is not None:
            self.purchaser_bank_account = m.get('purchaserBankAccount')
        if m.get('purchaserBankName') is not None:
            self.purchaser_bank_name = m.get('purchaserBankName')
        if m.get('purchaserName') is not None:
            self.purchaser_name = m.get('purchaserName')
        if m.get('purchaserTaxNo') is not None:
            self.purchaser_tax_no = m.get('purchaserTaxNo')
        if m.get('purchaserTel') is not None:
            self.purchaser_tel = m.get('purchaserTel')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('reviewer') is not None:
            self.reviewer = m.get('reviewer')
        if m.get('signature') is not None:
            self.signature = m.get('signature')
        if m.get('taxSign') is not None:
            self.tax_sign = m.get('taxSign')
        return self


class OrderBillingResponseBody(TeaModel):
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


class OrderBillingResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: OrderBillingResponseBody = None,
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
            temp_model = OrderBillingResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryAccountTradeByPageHeaders(TeaModel):
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


class QueryAccountTradeByPageRequestFilter(TeaModel):
    def __init__(
        self,
        end_amount: str = None,
        other_account_name: str = None,
        start_amount: str = None,
        trade_type: str = None,
    ):
        self.end_amount = end_amount
        self.other_account_name = other_account_name
        self.start_amount = start_amount
        self.trade_type = trade_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_amount is not None:
            result['endAmount'] = self.end_amount
        if self.other_account_name is not None:
            result['otherAccountName'] = self.other_account_name
        if self.start_amount is not None:
            result['startAmount'] = self.start_amount
        if self.trade_type is not None:
            result['tradeType'] = self.trade_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endAmount') is not None:
            self.end_amount = m.get('endAmount')
        if m.get('otherAccountName') is not None:
            self.other_account_name = m.get('otherAccountName')
        if m.get('startAmount') is not None:
            self.start_amount = m.get('startAmount')
        if m.get('tradeType') is not None:
            self.trade_type = m.get('tradeType')
        return self


class QueryAccountTradeByPageRequest(TeaModel):
    def __init__(
        self,
        account_id: str = None,
        end_date: int = None,
        filter: QueryAccountTradeByPageRequestFilter = None,
        page_number: int = None,
        page_size: int = None,
        start_date: int = None,
        user_id: str = None,
    ):
        self.account_id = account_id
        self.end_date = end_date
        self.filter = filter
        self.page_number = page_number
        self.page_size = page_size
        self.start_date = start_date
        self.user_id = user_id

    def validate(self):
        if self.filter:
            self.filter.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_id is not None:
            result['accountId'] = self.account_id
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.filter is not None:
            result['filter'] = self.filter.to_map()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountId') is not None:
            self.account_id = m.get('accountId')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('filter') is not None:
            temp_model = QueryAccountTradeByPageRequestFilter()
            self.filter = temp_model.from_map(m['filter'])
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryAccountTradeByPageResponseBodyResultReceiptFile(TeaModel):
    def __init__(
        self,
        file_id: str = None,
        file_name: str = None,
        file_size: int = None,
        file_type: str = None,
        preview_url: str = None,
        space_id: str = None,
    ):
        self.file_id = file_id
        self.file_name = file_name
        self.file_size = file_size
        self.file_type = file_type
        self.preview_url = preview_url
        self.space_id = space_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.file_size is not None:
            result['fileSize'] = self.file_size
        if self.file_type is not None:
            result['fileType'] = self.file_type
        if self.preview_url is not None:
            result['previewUrl'] = self.preview_url
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('fileSize') is not None:
            self.file_size = m.get('fileSize')
        if m.get('fileType') is not None:
            self.file_type = m.get('fileType')
        if m.get('previewUrl') is not None:
            self.preview_url = m.get('previewUrl')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        return self


class QueryAccountTradeByPageResponseBodyResult(TeaModel):
    def __init__(
        self,
        balance: str = None,
        instance_id: str = None,
        instance_title: str = None,
        instance_url: str = None,
        other_account_name: str = None,
        other_account_no: str = None,
        receipt_file: QueryAccountTradeByPageResponseBodyResultReceiptFile = None,
        remark: str = None,
        trade_amount: str = None,
        trade_no: str = None,
        trade_time: int = None,
        trade_type: str = None,
    ):
        self.balance = balance
        self.instance_id = instance_id
        self.instance_title = instance_title
        self.instance_url = instance_url
        self.other_account_name = other_account_name
        self.other_account_no = other_account_no
        self.receipt_file = receipt_file
        self.remark = remark
        self.trade_amount = trade_amount
        self.trade_no = trade_no
        self.trade_time = trade_time
        self.trade_type = trade_type

    def validate(self):
        if self.receipt_file:
            self.receipt_file.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.balance is not None:
            result['balance'] = self.balance
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.instance_title is not None:
            result['instanceTitle'] = self.instance_title
        if self.instance_url is not None:
            result['instanceUrl'] = self.instance_url
        if self.other_account_name is not None:
            result['otherAccountName'] = self.other_account_name
        if self.other_account_no is not None:
            result['otherAccountNo'] = self.other_account_no
        if self.receipt_file is not None:
            result['receiptFile'] = self.receipt_file.to_map()
        if self.remark is not None:
            result['remark'] = self.remark
        if self.trade_amount is not None:
            result['tradeAmount'] = self.trade_amount
        if self.trade_no is not None:
            result['tradeNo'] = self.trade_no
        if self.trade_time is not None:
            result['tradeTime'] = self.trade_time
        if self.trade_type is not None:
            result['tradeType'] = self.trade_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('balance') is not None:
            self.balance = m.get('balance')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('instanceTitle') is not None:
            self.instance_title = m.get('instanceTitle')
        if m.get('instanceUrl') is not None:
            self.instance_url = m.get('instanceUrl')
        if m.get('otherAccountName') is not None:
            self.other_account_name = m.get('otherAccountName')
        if m.get('otherAccountNo') is not None:
            self.other_account_no = m.get('otherAccountNo')
        if m.get('receiptFile') is not None:
            temp_model = QueryAccountTradeByPageResponseBodyResultReceiptFile()
            self.receipt_file = temp_model.from_map(m['receiptFile'])
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('tradeAmount') is not None:
            self.trade_amount = m.get('tradeAmount')
        if m.get('tradeNo') is not None:
            self.trade_no = m.get('tradeNo')
        if m.get('tradeTime') is not None:
            self.trade_time = m.get('tradeTime')
        if m.get('tradeType') is not None:
            self.trade_type = m.get('tradeType')
        return self


class QueryAccountTradeByPageResponseBody(TeaModel):
    def __init__(
        self,
        result: List[QueryAccountTradeByPageResponseBodyResult] = None,
        total_count: int = None,
    ):
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
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = QueryAccountTradeByPageResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class QueryAccountTradeByPageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryAccountTradeByPageResponseBody = None,
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
            temp_model = QueryAccountTradeByPageResponseBody()
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
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
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
        remark: str = None,
        status: str = None,
        type: str = None,
    ):
        # This parameter is required.
        self.code = code
        # This parameter is required.
        self.is_dir = is_dir
        # This parameter is required.
        self.name = name
        self.parent_code = parent_code
        self.remark = remark
        # This parameter is required.
        self.status = status
        # This parameter is required.
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
        if self.remark is not None:
            result['remark'] = self.remark
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
        if m.get('remark') is not None:
            self.remark = m.get('remark')
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
        # This parameter is required.
        self.has_more = has_more
        # This parameter is required.
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
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
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
        # This parameter is required.
        self.code = code
        # This parameter is required.
        self.create_time = create_time
        # This parameter is required.
        self.description = description
        # This parameter is required.
        self.name = name
        # This parameter is required.
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
        # This parameter is required.
        self.has_more = has_more
        # This parameter is required.
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
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
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
        # This parameter is required.
        self.account_code = account_code
        self.account_id = account_id
        # This parameter is required.
        self.account_name = account_name
        self.account_remark = account_remark
        # This parameter is required.
        self.account_type = account_type
        self.amount = amount
        self.bank_code = bank_code
        self.bank_name = bank_name
        # This parameter is required.
        self.create_time = create_time
        # This parameter is required.
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
        # This parameter is required.
        self.has_more = has_more
        # This parameter is required.
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


class QueryInvoiceTransferDataHeaders(TeaModel):
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


class QueryInvoiceTransferDataRequestBody(TeaModel):
    def __init__(
        self,
        keys: List[str] = None,
    ):
        self.keys = keys

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.keys is not None:
            result['keys'] = self.keys
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('keys') is not None:
            self.keys = m.get('keys')
        return self


class QueryInvoiceTransferDataRequest(TeaModel):
    def __init__(
        self,
        body: QueryInvoiceTransferDataRequestBody = None,
    ):
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('body') is not None:
            temp_model = QueryInvoiceTransferDataRequestBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryInvoiceTransferDataShrinkRequest(TeaModel):
    def __init__(
        self,
        body_shrink: str = None,
    ):
        self.body_shrink = body_shrink

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.body_shrink is not None:
            result['body'] = self.body_shrink
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('body') is not None:
            self.body_shrink = m.get('body')
        return self


class QueryInvoiceTransferDataResponseBody(TeaModel):
    def __init__(
        self,
        key_to_data: Dict[str, str] = None,
    ):
        self.key_to_data = key_to_data

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.key_to_data is not None:
            result['keyToData'] = self.key_to_data
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('keyToData') is not None:
            self.key_to_data = m.get('keyToData')
        return self


class QueryInvoiceTransferDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryInvoiceTransferDataResponseBody = None,
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
            temp_model = QueryInvoiceTransferDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryPaymentRecallFileHeaders(TeaModel):
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


class QueryPaymentRecallFileRequest(TeaModel):
    def __init__(
        self,
        user_id: str = None,
    ):
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryPaymentRecallFileResponseBodyPaymentRecallFileList(TeaModel):
    def __init__(
        self,
        file_id: str = None,
        file_name: str = None,
        file_size: str = None,
        file_type: str = None,
        instance_id: str = None,
        order_no: str = None,
        preview_url: str = None,
        space_id: str = None,
    ):
        self.file_id = file_id
        self.file_name = file_name
        self.file_size = file_size
        self.file_type = file_type
        self.instance_id = instance_id
        self.order_no = order_no
        self.preview_url = preview_url
        self.space_id = space_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.file_size is not None:
            result['fileSize'] = self.file_size
        if self.file_type is not None:
            result['fileType'] = self.file_type
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.preview_url is not None:
            result['previewUrl'] = self.preview_url
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('fileSize') is not None:
            self.file_size = m.get('fileSize')
        if m.get('fileType') is not None:
            self.file_type = m.get('fileType')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('previewUrl') is not None:
            self.preview_url = m.get('previewUrl')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        return self


class QueryPaymentRecallFileResponseBody(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        payment_recall_file_list: List[QueryPaymentRecallFileResponseBodyPaymentRecallFileList] = None,
    ):
        self.corp_id = corp_id
        self.payment_recall_file_list = payment_recall_file_list

    def validate(self):
        if self.payment_recall_file_list:
            for k in self.payment_recall_file_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        result['paymentRecallFileList'] = []
        if self.payment_recall_file_list is not None:
            for k in self.payment_recall_file_list:
                result['paymentRecallFileList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        self.payment_recall_file_list = []
        if m.get('paymentRecallFileList') is not None:
            for k in m.get('paymentRecallFileList'):
                temp_model = QueryPaymentRecallFileResponseBodyPaymentRecallFileList()
                self.payment_recall_file_list.append(temp_model.from_map(k))
        return self


class QueryPaymentRecallFileResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryPaymentRecallFileResponseBody = None,
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
            temp_model = QueryPaymentRecallFileResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryPaymentStatusHeaders(TeaModel):
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


class QueryPaymentStatusRequest(TeaModel):
    def __init__(
        self,
        instance_id: str = None,
        order_no: str = None,
        user_id: str = None,
    ):
        self.instance_id = instance_id
        self.order_no = order_no
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryPaymentStatusResponseBodyPayeeAccountInfoBankOpenDTO(TeaModel):
    def __init__(
        self,
        bank_branch_name: str = None,
        bank_card_no: str = None,
        bank_name: str = None,
    ):
        self.bank_branch_name = bank_branch_name
        self.bank_card_no = bank_card_no
        self.bank_name = bank_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.bank_branch_name is not None:
            result['bankBranchName'] = self.bank_branch_name
        if self.bank_card_no is not None:
            result['bankCardNo'] = self.bank_card_no
        if self.bank_name is not None:
            result['bankName'] = self.bank_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bankBranchName') is not None:
            self.bank_branch_name = m.get('bankBranchName')
        if m.get('bankCardNo') is not None:
            self.bank_card_no = m.get('bankCardNo')
        if m.get('bankName') is not None:
            self.bank_name = m.get('bankName')
        return self


class QueryPaymentStatusResponseBodyPayeeAccountInfo(TeaModel):
    def __init__(
        self,
        bank_open_dto: QueryPaymentStatusResponseBodyPayeeAccountInfoBankOpenDTO = None,
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
            temp_model = QueryPaymentStatusResponseBodyPayeeAccountInfoBankOpenDTO()
            self.bank_open_dto = temp_model.from_map(m['bankOpenDTO'])
        return self


class QueryPaymentStatusResponseBodyPayerAccountInfoBankOpenDTO(TeaModel):
    def __init__(
        self,
        bank_branch_name: str = None,
        bank_card_no: str = None,
        bank_name: str = None,
    ):
        self.bank_branch_name = bank_branch_name
        self.bank_card_no = bank_card_no
        self.bank_name = bank_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.bank_branch_name is not None:
            result['bankBranchName'] = self.bank_branch_name
        if self.bank_card_no is not None:
            result['bankCardNo'] = self.bank_card_no
        if self.bank_name is not None:
            result['bankName'] = self.bank_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bankBranchName') is not None:
            self.bank_branch_name = m.get('bankBranchName')
        if m.get('bankCardNo') is not None:
            self.bank_card_no = m.get('bankCardNo')
        if m.get('bankName') is not None:
            self.bank_name = m.get('bankName')
        return self


class QueryPaymentStatusResponseBodyPayerAccountInfo(TeaModel):
    def __init__(
        self,
        account_type: str = None,
        bank_open_dto: QueryPaymentStatusResponseBodyPayerAccountInfoBankOpenDTO = None,
        enterprise_account_code: str = None,
    ):
        self.account_type = account_type
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
        if self.account_type is not None:
            result['accountType'] = self.account_type
        if self.bank_open_dto is not None:
            result['bankOpenDTO'] = self.bank_open_dto.to_map()
        if self.enterprise_account_code is not None:
            result['enterpriseAccountCode'] = self.enterprise_account_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountType') is not None:
            self.account_type = m.get('accountType')
        if m.get('bankOpenDTO') is not None:
            temp_model = QueryPaymentStatusResponseBodyPayerAccountInfoBankOpenDTO()
            self.bank_open_dto = temp_model.from_map(m['bankOpenDTO'])
        if m.get('enterpriseAccountCode') is not None:
            self.enterprise_account_code = m.get('enterpriseAccountCode')
        return self


class QueryPaymentStatusResponseBody(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        fail_reason: str = None,
        instance_id: str = None,
        order_no: str = None,
        payee_account_info: QueryPaymentStatusResponseBodyPayeeAccountInfo = None,
        payer_account_info: QueryPaymentStatusResponseBodyPayerAccountInfo = None,
        payment_status: str = None,
        payment_time: str = None,
        remark: str = None,
        usage: str = None,
        user_id: str = None,
    ):
        self.corp_id = corp_id
        self.fail_reason = fail_reason
        self.instance_id = instance_id
        self.order_no = order_no
        self.payee_account_info = payee_account_info
        self.payer_account_info = payer_account_info
        self.payment_status = payment_status
        self.payment_time = payment_time
        self.remark = remark
        self.usage = usage
        self.user_id = user_id

    def validate(self):
        if self.payee_account_info:
            self.payee_account_info.validate()
        if self.payer_account_info:
            self.payer_account_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.fail_reason is not None:
            result['failReason'] = self.fail_reason
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.payee_account_info is not None:
            result['payeeAccountInfo'] = self.payee_account_info.to_map()
        if self.payer_account_info is not None:
            result['payerAccountInfo'] = self.payer_account_info.to_map()
        if self.payment_status is not None:
            result['paymentStatus'] = self.payment_status
        if self.payment_time is not None:
            result['paymentTime'] = self.payment_time
        if self.remark is not None:
            result['remark'] = self.remark
        if self.usage is not None:
            result['usage'] = self.usage
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('failReason') is not None:
            self.fail_reason = m.get('failReason')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('payeeAccountInfo') is not None:
            temp_model = QueryPaymentStatusResponseBodyPayeeAccountInfo()
            self.payee_account_info = temp_model.from_map(m['payeeAccountInfo'])
        if m.get('payerAccountInfo') is not None:
            temp_model = QueryPaymentStatusResponseBodyPayerAccountInfo()
            self.payer_account_info = temp_model.from_map(m['payerAccountInfo'])
        if m.get('paymentStatus') is not None:
            self.payment_status = m.get('paymentStatus')
        if m.get('paymentTime') is not None:
            self.payment_time = m.get('paymentTime')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('usage') is not None:
            self.usage = m.get('usage')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryPaymentStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryPaymentStatusResponseBody = None,
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
            temp_model = QueryPaymentStatusResponseBody()
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
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
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
        # This parameter is required.
        self.create_time = create_time
        # This parameter is required.
        self.creator = creator
        self.description = description
        self.name = name
        # This parameter is required.
        self.project_code = project_code
        # This parameter is required.
        self.project_name = project_name
        # This parameter is required.
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
        # This parameter is required.
        self.has_more = has_more
        # This parameter is required.
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


class QueryReceiptForInvoiceHeaders(TeaModel):
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


class QueryReceiptForInvoiceRequest(TeaModel):
    def __init__(
        self,
        accountant_book_id: str = None,
        apply_status_list: List[str] = None,
        biz_status_list: List[str] = None,
        company_code: str = None,
        end_time: int = None,
        page_number: int = None,
        page_size: int = None,
        receipt_status_list: List[str] = None,
        search_params: Dict[str, str] = None,
        start_time: int = None,
        title: str = None,
    ):
        self.accountant_book_id = accountant_book_id
        self.apply_status_list = apply_status_list
        self.biz_status_list = biz_status_list
        self.company_code = company_code
        self.end_time = end_time
        self.page_number = page_number
        self.page_size = page_size
        self.receipt_status_list = receipt_status_list
        self.search_params = search_params
        self.start_time = start_time
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.accountant_book_id is not None:
            result['accountantBookId'] = self.accountant_book_id
        if self.apply_status_list is not None:
            result['applyStatusList'] = self.apply_status_list
        if self.biz_status_list is not None:
            result['bizStatusList'] = self.biz_status_list
        if self.company_code is not None:
            result['companyCode'] = self.company_code
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.receipt_status_list is not None:
            result['receiptStatusList'] = self.receipt_status_list
        if self.search_params is not None:
            result['searchParams'] = self.search_params
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountantBookId') is not None:
            self.accountant_book_id = m.get('accountantBookId')
        if m.get('applyStatusList') is not None:
            self.apply_status_list = m.get('applyStatusList')
        if m.get('bizStatusList') is not None:
            self.biz_status_list = m.get('bizStatusList')
        if m.get('companyCode') is not None:
            self.company_code = m.get('companyCode')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('receiptStatusList') is not None:
            self.receipt_status_list = m.get('receiptStatusList')
        if m.get('searchParams') is not None:
            self.search_params = m.get('searchParams')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class QueryReceiptForInvoiceResponseBodyListCreator(TeaModel):
    def __init__(
        self,
        avatar_url: str = None,
        nick: str = None,
        user_id: str = None,
    ):
        self.avatar_url = avatar_url
        self.nick = nick
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avatar_url is not None:
            result['avatarUrl'] = self.avatar_url
        if self.nick is not None:
            result['nick'] = self.nick
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avatarUrl') is not None:
            self.avatar_url = m.get('avatarUrl')
        if m.get('nick') is not None:
            self.nick = m.get('nick')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryReceiptForInvoiceResponseBodyListCustomer(TeaModel):
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


class QueryReceiptForInvoiceResponseBodyListProductInfoList(TeaModel):
    def __init__(
        self,
        amount_with_tax: str = None,
        amount_without_tax: str = None,
        discount_amount: str = None,
        name: str = None,
        quantity: str = None,
        specification: str = None,
        tax_classification_code: str = None,
        tax_rate: str = None,
        unit: str = None,
        unit_price_with_tax: str = None,
        unit_price_without_tax: str = None,
        with_tax: bool = None,
    ):
        self.amount_with_tax = amount_with_tax
        self.amount_without_tax = amount_without_tax
        self.discount_amount = discount_amount
        self.name = name
        self.quantity = quantity
        self.specification = specification
        self.tax_classification_code = tax_classification_code
        self.tax_rate = tax_rate
        self.unit = unit
        self.unit_price_with_tax = unit_price_with_tax
        self.unit_price_without_tax = unit_price_without_tax
        self.with_tax = with_tax

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount_with_tax is not None:
            result['amountWithTax'] = self.amount_with_tax
        if self.amount_without_tax is not None:
            result['amountWithoutTax'] = self.amount_without_tax
        if self.discount_amount is not None:
            result['discountAmount'] = self.discount_amount
        if self.name is not None:
            result['name'] = self.name
        if self.quantity is not None:
            result['quantity'] = self.quantity
        if self.specification is not None:
            result['specification'] = self.specification
        if self.tax_classification_code is not None:
            result['taxClassificationCode'] = self.tax_classification_code
        if self.tax_rate is not None:
            result['taxRate'] = self.tax_rate
        if self.unit is not None:
            result['unit'] = self.unit
        if self.unit_price_with_tax is not None:
            result['unitPriceWithTax'] = self.unit_price_with_tax
        if self.unit_price_without_tax is not None:
            result['unitPriceWithoutTax'] = self.unit_price_without_tax
        if self.with_tax is not None:
            result['withTax'] = self.with_tax
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amountWithTax') is not None:
            self.amount_with_tax = m.get('amountWithTax')
        if m.get('amountWithoutTax') is not None:
            self.amount_without_tax = m.get('amountWithoutTax')
        if m.get('discountAmount') is not None:
            self.discount_amount = m.get('discountAmount')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('quantity') is not None:
            self.quantity = m.get('quantity')
        if m.get('specification') is not None:
            self.specification = m.get('specification')
        if m.get('taxClassificationCode') is not None:
            self.tax_classification_code = m.get('taxClassificationCode')
        if m.get('taxRate') is not None:
            self.tax_rate = m.get('taxRate')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('unitPriceWithTax') is not None:
            self.unit_price_with_tax = m.get('unitPriceWithTax')
        if m.get('unitPriceWithoutTax') is not None:
            self.unit_price_without_tax = m.get('unitPriceWithoutTax')
        if m.get('withTax') is not None:
            self.with_tax = m.get('withTax')
        return self


class QueryReceiptForInvoiceResponseBodyList(TeaModel):
    def __init__(
        self,
        accountant_book_id: str = None,
        amount: str = None,
        apply_status: str = None,
        biz_status: str = None,
        business_id: str = None,
        company_code: str = None,
        create_time: str = None,
        creator: QueryReceiptForInvoiceResponseBodyListCreator = None,
        customer: QueryReceiptForInvoiceResponseBodyListCustomer = None,
        drawer_email: str = None,
        drawer_telephone: str = None,
        invoice_type: str = None,
        model_id: str = None,
        product_info_list: List[QueryReceiptForInvoiceResponseBodyListProductInfoList] = None,
        purchaser_account: str = None,
        purchaser_address: str = None,
        purchaser_bank_name: str = None,
        purchaser_name: str = None,
        purchaser_tax_no: str = None,
        purchaser_tel: str = None,
        receipt_id: str = None,
        record_time: str = None,
        remark: str = None,
        source: str = None,
        status: str = None,
        title: str = None,
    ):
        self.accountant_book_id = accountant_book_id
        self.amount = amount
        self.apply_status = apply_status
        self.biz_status = biz_status
        self.business_id = business_id
        self.company_code = company_code
        self.create_time = create_time
        self.creator = creator
        self.customer = customer
        self.drawer_email = drawer_email
        self.drawer_telephone = drawer_telephone
        self.invoice_type = invoice_type
        self.model_id = model_id
        self.product_info_list = product_info_list
        self.purchaser_account = purchaser_account
        self.purchaser_address = purchaser_address
        self.purchaser_bank_name = purchaser_bank_name
        self.purchaser_name = purchaser_name
        self.purchaser_tax_no = purchaser_tax_no
        self.purchaser_tel = purchaser_tel
        self.receipt_id = receipt_id
        self.record_time = record_time
        self.remark = remark
        self.source = source
        self.status = status
        self.title = title

    def validate(self):
        if self.creator:
            self.creator.validate()
        if self.customer:
            self.customer.validate()
        if self.product_info_list:
            for k in self.product_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.accountant_book_id is not None:
            result['accountantBookId'] = self.accountant_book_id
        if self.amount is not None:
            result['amount'] = self.amount
        if self.apply_status is not None:
            result['applyStatus'] = self.apply_status
        if self.biz_status is not None:
            result['bizStatus'] = self.biz_status
        if self.business_id is not None:
            result['businessId'] = self.business_id
        if self.company_code is not None:
            result['companyCode'] = self.company_code
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator is not None:
            result['creator'] = self.creator.to_map()
        if self.customer is not None:
            result['customer'] = self.customer.to_map()
        if self.drawer_email is not None:
            result['drawerEmail'] = self.drawer_email
        if self.drawer_telephone is not None:
            result['drawerTelephone'] = self.drawer_telephone
        if self.invoice_type is not None:
            result['invoiceType'] = self.invoice_type
        if self.model_id is not None:
            result['modelId'] = self.model_id
        result['productInfoList'] = []
        if self.product_info_list is not None:
            for k in self.product_info_list:
                result['productInfoList'].append(k.to_map() if k else None)
        if self.purchaser_account is not None:
            result['purchaserAccount'] = self.purchaser_account
        if self.purchaser_address is not None:
            result['purchaserAddress'] = self.purchaser_address
        if self.purchaser_bank_name is not None:
            result['purchaserBankName'] = self.purchaser_bank_name
        if self.purchaser_name is not None:
            result['purchaserName'] = self.purchaser_name
        if self.purchaser_tax_no is not None:
            result['purchaserTaxNo'] = self.purchaser_tax_no
        if self.purchaser_tel is not None:
            result['purchaserTel'] = self.purchaser_tel
        if self.receipt_id is not None:
            result['receiptId'] = self.receipt_id
        if self.record_time is not None:
            result['recordTime'] = self.record_time
        if self.remark is not None:
            result['remark'] = self.remark
        if self.source is not None:
            result['source'] = self.source
        if self.status is not None:
            result['status'] = self.status
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountantBookId') is not None:
            self.accountant_book_id = m.get('accountantBookId')
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('applyStatus') is not None:
            self.apply_status = m.get('applyStatus')
        if m.get('bizStatus') is not None:
            self.biz_status = m.get('bizStatus')
        if m.get('businessId') is not None:
            self.business_id = m.get('businessId')
        if m.get('companyCode') is not None:
            self.company_code = m.get('companyCode')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creator') is not None:
            temp_model = QueryReceiptForInvoiceResponseBodyListCreator()
            self.creator = temp_model.from_map(m['creator'])
        if m.get('customer') is not None:
            temp_model = QueryReceiptForInvoiceResponseBodyListCustomer()
            self.customer = temp_model.from_map(m['customer'])
        if m.get('drawerEmail') is not None:
            self.drawer_email = m.get('drawerEmail')
        if m.get('drawerTelephone') is not None:
            self.drawer_telephone = m.get('drawerTelephone')
        if m.get('invoiceType') is not None:
            self.invoice_type = m.get('invoiceType')
        if m.get('modelId') is not None:
            self.model_id = m.get('modelId')
        self.product_info_list = []
        if m.get('productInfoList') is not None:
            for k in m.get('productInfoList'):
                temp_model = QueryReceiptForInvoiceResponseBodyListProductInfoList()
                self.product_info_list.append(temp_model.from_map(k))
        if m.get('purchaserAccount') is not None:
            self.purchaser_account = m.get('purchaserAccount')
        if m.get('purchaserAddress') is not None:
            self.purchaser_address = m.get('purchaserAddress')
        if m.get('purchaserBankName') is not None:
            self.purchaser_bank_name = m.get('purchaserBankName')
        if m.get('purchaserName') is not None:
            self.purchaser_name = m.get('purchaserName')
        if m.get('purchaserTaxNo') is not None:
            self.purchaser_tax_no = m.get('purchaserTaxNo')
        if m.get('purchaserTel') is not None:
            self.purchaser_tel = m.get('purchaserTel')
        if m.get('receiptId') is not None:
            self.receipt_id = m.get('receiptId')
        if m.get('recordTime') is not None:
            self.record_time = m.get('recordTime')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class QueryReceiptForInvoiceResponseBody(TeaModel):
    def __init__(
        self,
        has_more: str = None,
        list: List[QueryReceiptForInvoiceResponseBodyList] = None,
        total_count: int = None,
    ):
        self.has_more = has_more
        self.list = list
        self.total_count = total_count

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
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryReceiptForInvoiceResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class QueryReceiptForInvoiceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryReceiptForInvoiceResponseBody = None,
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
            temp_model = QueryReceiptForInvoiceResponseBody()
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
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
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
        # This parameter is required.
        self.code = code
        # This parameter is required.
        self.create_time = create_time
        # This parameter is required.
        self.description = description
        # This parameter is required.
        self.name = name
        # This parameter is required.
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
        # This parameter is required.
        self.has_more = has_more
        # This parameter is required.
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


class QueryUseNewInvoiceAppHeaders(TeaModel):
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


class QueryUseNewInvoiceAppResponseBody(TeaModel):
    def __init__(
        self,
        use_new: bool = None,
    ):
        # This parameter is required.
        self.use_new = use_new

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.use_new is not None:
            result['useNew'] = self.use_new
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('useNew') is not None:
            self.use_new = m.get('useNew')
        return self


class QueryUseNewInvoiceAppResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryUseNewInvoiceAppResponseBody = None,
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
            temp_model = QueryUseNewInvoiceAppResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryUserRoleListHeaders(TeaModel):
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


class QueryUserRoleListRequest(TeaModel):
    def __init__(
        self,
        company_code: str = None,
        user_id: str = None,
    ):
        self.company_code = company_code
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.company_code is not None:
            result['companyCode'] = self.company_code
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('companyCode') is not None:
            self.company_code = m.get('companyCode')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryUserRoleListResponseBodyFinanceEmpDeptOpenList(TeaModel):
    def __init__(
        self,
        cascade_dept_id: str = None,
        dept_id: int = None,
        name: str = None,
        super_dept_id: int = None,
    ):
        self.cascade_dept_id = cascade_dept_id
        self.dept_id = dept_id
        self.name = name
        self.super_dept_id = super_dept_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cascade_dept_id is not None:
            result['cascadeDeptId'] = self.cascade_dept_id
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.name is not None:
            result['name'] = self.name
        if self.super_dept_id is not None:
            result['superDeptId'] = self.super_dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cascadeDeptId') is not None:
            self.cascade_dept_id = m.get('cascadeDeptId')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('superDeptId') is not None:
            self.super_dept_id = m.get('superDeptId')
        return self


class QueryUserRoleListResponseBodyRoleVOList(TeaModel):
    def __init__(
        self,
        role_code: str = None,
        role_name: str = None,
    ):
        self.role_code = role_code
        self.role_name = role_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.role_code is not None:
            result['roleCode'] = self.role_code
        if self.role_name is not None:
            result['roleName'] = self.role_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('roleCode') is not None:
            self.role_code = m.get('roleCode')
        if m.get('roleName') is not None:
            self.role_name = m.get('roleName')
        return self


class QueryUserRoleListResponseBody(TeaModel):
    def __init__(
        self,
        company_code: str = None,
        finance_emp_dept_open_list: List[QueryUserRoleListResponseBodyFinanceEmpDeptOpenList] = None,
        role_volist: List[QueryUserRoleListResponseBodyRoleVOList] = None,
    ):
        self.company_code = company_code
        self.finance_emp_dept_open_list = finance_emp_dept_open_list
        self.role_volist = role_volist

    def validate(self):
        if self.finance_emp_dept_open_list:
            for k in self.finance_emp_dept_open_list:
                if k:
                    k.validate()
        if self.role_volist:
            for k in self.role_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.company_code is not None:
            result['companyCode'] = self.company_code
        result['financeEmpDeptOpenList'] = []
        if self.finance_emp_dept_open_list is not None:
            for k in self.finance_emp_dept_open_list:
                result['financeEmpDeptOpenList'].append(k.to_map() if k else None)
        result['roleVOList'] = []
        if self.role_volist is not None:
            for k in self.role_volist:
                result['roleVOList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('companyCode') is not None:
            self.company_code = m.get('companyCode')
        self.finance_emp_dept_open_list = []
        if m.get('financeEmpDeptOpenList') is not None:
            for k in m.get('financeEmpDeptOpenList'):
                temp_model = QueryUserRoleListResponseBodyFinanceEmpDeptOpenList()
                self.finance_emp_dept_open_list.append(temp_model.from_map(k))
        self.role_volist = []
        if m.get('roleVOList') is not None:
            for k in m.get('roleVOList'):
                temp_model = QueryUserRoleListResponseBodyRoleVOList()
                self.role_volist.append(temp_model.from_map(k))
        return self


class QueryUserRoleListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryUserRoleListResponseBody = None,
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
            temp_model = QueryUserRoleListResponseBody()
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
        bank_open_id: str = None,
        channel_type: str = None,
        operator: str = None,
        sign_operate_type: str = None,
    ):
        self.bank_card_no = bank_card_no
        self.bank_open_id = bank_open_id
        self.channel_type = channel_type
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
        if self.bank_open_id is not None:
            result['bankOpenId'] = self.bank_open_id
        if self.channel_type is not None:
            result['channelType'] = self.channel_type
        if self.operator is not None:
            result['operator'] = self.operator
        if self.sign_operate_type is not None:
            result['signOperateType'] = self.sign_operate_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bankCardNo') is not None:
            self.bank_card_no = m.get('bankCardNo')
        if m.get('bankOpenId') is not None:
            self.bank_open_id = m.get('bankOpenId')
        if m.get('channelType') is not None:
            self.channel_type = m.get('channelType')
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


class SyncReceiptRecallHeaders(TeaModel):
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


class SyncReceiptRecallRequest(TeaModel):
    def __init__(
        self,
        file_download_url: str = None,
        file_name: str = None,
        order_no: str = None,
    ):
        self.file_download_url = file_download_url
        self.file_name = file_name
        self.order_no = order_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_download_url is not None:
            result['fileDownloadUrl'] = self.file_download_url
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileDownloadUrl') is not None:
            self.file_download_url = m.get('fileDownloadUrl')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        return self


class SyncReceiptRecallResponseBody(TeaModel):
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


class SyncReceiptRecallResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SyncReceiptRecallResponseBody = None,
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
            temp_model = SyncReceiptRecallResponseBody()
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
        payment_time: int = None,
        status: str = None,
        user_id: str = None,
    ):
        self.fail_reason = fail_reason
        self.order_no = order_no
        self.out_order_no = out_order_no
        self.payer_bank = payer_bank
        self.payment_time = payment_time
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
        if self.payment_time is not None:
            result['paymentTime'] = self.payment_time
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
        if m.get('paymentTime') is not None:
            self.payment_time = m.get('paymentTime')
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
        payment_time: int = None,
        status: str = None,
        user_id: str = None,
    ):
        self.fail_reason = fail_reason
        self.order_no = order_no
        self.out_order_no = out_order_no
        self.payer_bank_shrink = payer_bank_shrink
        self.payment_time = payment_time
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
        if self.payment_time is not None:
            result['paymentTime'] = self.payment_time
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
        if m.get('paymentTime') is not None:
            self.payment_time = m.get('paymentTime')
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


class UpdateInvoiceDataTransferDoneHeaders(TeaModel):
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


class UpdateInvoiceDataTransferDoneResponseBody(TeaModel):
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


class UpdateInvoiceDataTransferDoneResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateInvoiceDataTransferDoneResponseBody = None,
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
            temp_model = UpdateInvoiceDataTransferDoneResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


