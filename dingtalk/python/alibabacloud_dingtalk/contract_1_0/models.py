# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class ContractBenefitConsumeHeaders(TeaModel):
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


class ContractBenefitConsumeRequest(TeaModel):
    def __init__(
        self,
        benefit_point: str = None,
        biz_request_id: str = None,
        consume_quota: int = None,
        corp_id: str = None,
        ext_params: Dict[str, str] = None,
        isv_corp_id: str = None,
        opt_union_id: str = None,
    ):
        # This parameter is required.
        self.benefit_point = benefit_point
        # This parameter is required.
        self.biz_request_id = biz_request_id
        # This parameter is required.
        self.consume_quota = consume_quota
        # This parameter is required.
        self.corp_id = corp_id
        self.ext_params = ext_params
        # This parameter is required.
        self.isv_corp_id = isv_corp_id
        self.opt_union_id = opt_union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.benefit_point is not None:
            result['benefitPoint'] = self.benefit_point
        if self.biz_request_id is not None:
            result['bizRequestId'] = self.biz_request_id
        if self.consume_quota is not None:
            result['consumeQuota'] = self.consume_quota
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.ext_params is not None:
            result['extParams'] = self.ext_params
        if self.isv_corp_id is not None:
            result['isvCorpId'] = self.isv_corp_id
        if self.opt_union_id is not None:
            result['optUnionId'] = self.opt_union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('benefitPoint') is not None:
            self.benefit_point = m.get('benefitPoint')
        if m.get('bizRequestId') is not None:
            self.biz_request_id = m.get('bizRequestId')
        if m.get('consumeQuota') is not None:
            self.consume_quota = m.get('consumeQuota')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('extParams') is not None:
            self.ext_params = m.get('extParams')
        if m.get('isvCorpId') is not None:
            self.isv_corp_id = m.get('isvCorpId')
        if m.get('optUnionId') is not None:
            self.opt_union_id = m.get('optUnionId')
        return self


class ContractBenefitConsumeResponseBodyResult(TeaModel):
    def __init__(
        self,
        consume_result: bool = None,
    ):
        self.consume_result = consume_result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.consume_result is not None:
            result['consumeResult'] = self.consume_result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('consumeResult') is not None:
            self.consume_result = m.get('consumeResult')
        return self


class ContractBenefitConsumeResponseBody(TeaModel):
    def __init__(
        self,
        result: ContractBenefitConsumeResponseBodyResult = None,
        success: bool = None,
    ):
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
        if self.result is not None:
            result['result'] = self.result.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = ContractBenefitConsumeResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ContractBenefitConsumeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ContractBenefitConsumeResponseBody = None,
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
            temp_model = ContractBenefitConsumeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateContractCompareTaskHeaders(TeaModel):
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


class CreateContractCompareTaskRequestComparativeFile(TeaModel):
    def __init__(
        self,
        file_id: str = None,
        file_name: str = None,
        file_size: int = None,
        file_type: str = None,
        space_id: str = None,
    ):
        self.file_id = file_id
        self.file_name = file_name
        self.file_size = file_size
        self.file_type = file_type
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
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        return self


class CreateContractCompareTaskRequestStandardFile(TeaModel):
    def __init__(
        self,
        file_id: str = None,
        file_name: str = None,
        file_size: int = None,
        file_type: str = None,
        space_id: str = None,
    ):
        self.file_id = file_id
        self.file_name = file_name
        self.file_size = file_size
        self.file_type = file_type
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
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        return self


class CreateContractCompareTaskRequest(TeaModel):
    def __init__(
        self,
        comparative_file: CreateContractCompareTaskRequestComparativeFile = None,
        comparative_file_download_url: str = None,
        comparative_file_name: str = None,
        file_source: str = None,
        request_id: str = None,
        standard_file: CreateContractCompareTaskRequestStandardFile = None,
        standard_file_download_url: str = None,
        standard_file_name: str = None,
    ):
        self.comparative_file = comparative_file
        self.comparative_file_download_url = comparative_file_download_url
        # This parameter is required.
        self.comparative_file_name = comparative_file_name
        # This parameter is required.
        self.file_source = file_source
        # This parameter is required.
        self.request_id = request_id
        self.standard_file = standard_file
        self.standard_file_download_url = standard_file_download_url
        # This parameter is required.
        self.standard_file_name = standard_file_name

    def validate(self):
        if self.comparative_file:
            self.comparative_file.validate()
        if self.standard_file:
            self.standard_file.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.comparative_file is not None:
            result['comparativeFile'] = self.comparative_file.to_map()
        if self.comparative_file_download_url is not None:
            result['comparativeFileDownloadUrl'] = self.comparative_file_download_url
        if self.comparative_file_name is not None:
            result['comparativeFileName'] = self.comparative_file_name
        if self.file_source is not None:
            result['fileSource'] = self.file_source
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.standard_file is not None:
            result['standardFile'] = self.standard_file.to_map()
        if self.standard_file_download_url is not None:
            result['standardFileDownloadUrl'] = self.standard_file_download_url
        if self.standard_file_name is not None:
            result['standardFileName'] = self.standard_file_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('comparativeFile') is not None:
            temp_model = CreateContractCompareTaskRequestComparativeFile()
            self.comparative_file = temp_model.from_map(m['comparativeFile'])
        if m.get('comparativeFileDownloadUrl') is not None:
            self.comparative_file_download_url = m.get('comparativeFileDownloadUrl')
        if m.get('comparativeFileName') is not None:
            self.comparative_file_name = m.get('comparativeFileName')
        if m.get('fileSource') is not None:
            self.file_source = m.get('fileSource')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('standardFile') is not None:
            temp_model = CreateContractCompareTaskRequestStandardFile()
            self.standard_file = temp_model.from_map(m['standardFile'])
        if m.get('standardFileDownloadUrl') is not None:
            self.standard_file_download_url = m.get('standardFileDownloadUrl')
        if m.get('standardFileName') is not None:
            self.standard_file_name = m.get('standardFileName')
        return self


class CreateContractCompareTaskResponseBodyResultData(TeaModel):
    def __init__(
        self,
        compare_task_id: str = None,
    ):
        self.compare_task_id = compare_task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.compare_task_id is not None:
            result['compareTaskId'] = self.compare_task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('compareTaskId') is not None:
            self.compare_task_id = m.get('compareTaskId')
        return self


class CreateContractCompareTaskResponseBodyResult(TeaModel):
    def __init__(
        self,
        data: CreateContractCompareTaskResponseBodyResultData = None,
        request_id: str = None,
    ):
        self.data = data
        self.request_id = request_id

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = CreateContractCompareTaskResponseBodyResultData()
            self.data = temp_model.from_map(m['data'])
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class CreateContractCompareTaskResponseBody(TeaModel):
    def __init__(
        self,
        result: CreateContractCompareTaskResponseBodyResult = None,
        success: bool = None,
    ):
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
        if self.result is not None:
            result['result'] = self.result.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = CreateContractCompareTaskResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CreateContractCompareTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateContractCompareTaskResponseBody = None,
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
            temp_model = CreateContractCompareTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateContractExtractTaskHeaders(TeaModel):
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


class CreateContractExtractTaskRequestContractFile(TeaModel):
    def __init__(
        self,
        file_id: str = None,
        file_name: str = None,
        file_size: int = None,
        file_type: str = None,
        space_id: str = None,
    ):
        self.file_id = file_id
        self.file_name = file_name
        self.file_size = file_size
        self.file_type = file_type
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
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        return self


class CreateContractExtractTaskRequest(TeaModel):
    def __init__(
        self,
        contract_file: CreateContractExtractTaskRequestContractFile = None,
        contract_file_download_url: str = None,
        contract_file_name: str = None,
        extract_keys: List[str] = None,
        file_source: str = None,
        request_id: str = None,
    ):
        self.contract_file = contract_file
        self.contract_file_download_url = contract_file_download_url
        # This parameter is required.
        self.contract_file_name = contract_file_name
        # This parameter is required.
        self.extract_keys = extract_keys
        # This parameter is required.
        self.file_source = file_source
        # This parameter is required.
        self.request_id = request_id

    def validate(self):
        if self.contract_file:
            self.contract_file.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.contract_file is not None:
            result['contractFile'] = self.contract_file.to_map()
        if self.contract_file_download_url is not None:
            result['contractFileDownloadUrl'] = self.contract_file_download_url
        if self.contract_file_name is not None:
            result['contractFileName'] = self.contract_file_name
        if self.extract_keys is not None:
            result['extractKeys'] = self.extract_keys
        if self.file_source is not None:
            result['fileSource'] = self.file_source
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('contractFile') is not None:
            temp_model = CreateContractExtractTaskRequestContractFile()
            self.contract_file = temp_model.from_map(m['contractFile'])
        if m.get('contractFileDownloadUrl') is not None:
            self.contract_file_download_url = m.get('contractFileDownloadUrl')
        if m.get('contractFileName') is not None:
            self.contract_file_name = m.get('contractFileName')
        if m.get('extractKeys') is not None:
            self.extract_keys = m.get('extractKeys')
        if m.get('fileSource') is not None:
            self.file_source = m.get('fileSource')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class CreateContractExtractTaskResponseBodyResultData(TeaModel):
    def __init__(
        self,
        extract_task_id: str = None,
    ):
        self.extract_task_id = extract_task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.extract_task_id is not None:
            result['extractTaskId'] = self.extract_task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('extractTaskId') is not None:
            self.extract_task_id = m.get('extractTaskId')
        return self


class CreateContractExtractTaskResponseBodyResult(TeaModel):
    def __init__(
        self,
        data: CreateContractExtractTaskResponseBodyResultData = None,
        request_id: str = None,
    ):
        self.data = data
        self.request_id = request_id

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = CreateContractExtractTaskResponseBodyResultData()
            self.data = temp_model.from_map(m['data'])
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class CreateContractExtractTaskResponseBody(TeaModel):
    def __init__(
        self,
        result: CreateContractExtractTaskResponseBodyResult = None,
        success: bool = None,
    ):
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
        if self.result is not None:
            result['result'] = self.result.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = CreateContractExtractTaskResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CreateContractExtractTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateContractExtractTaskResponseBody = None,
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
            temp_model = CreateContractExtractTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateContractReviewTaskHeaders(TeaModel):
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


class CreateContractReviewTaskRequestContractFile(TeaModel):
    def __init__(
        self,
        file_id: str = None,
        file_name: str = None,
        file_size: int = None,
        file_type: str = None,
        space_id: str = None,
    ):
        self.file_id = file_id
        self.file_name = file_name
        self.file_size = file_size
        self.file_type = file_type
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
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        return self


class CreateContractReviewTaskRequestReviewCustomRules(TeaModel):
    def __init__(
        self,
        risk_level: str = None,
        rule_desc: str = None,
        rule_sequence: str = None,
        rule_tag: str = None,
        rule_title: str = None,
    ):
        self.risk_level = risk_level
        self.rule_desc = rule_desc
        self.rule_sequence = rule_sequence
        self.rule_tag = rule_tag
        self.rule_title = rule_title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.risk_level is not None:
            result['riskLevel'] = self.risk_level
        if self.rule_desc is not None:
            result['ruleDesc'] = self.rule_desc
        if self.rule_sequence is not None:
            result['ruleSequence'] = self.rule_sequence
        if self.rule_tag is not None:
            result['ruleTag'] = self.rule_tag
        if self.rule_title is not None:
            result['ruleTitle'] = self.rule_title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('riskLevel') is not None:
            self.risk_level = m.get('riskLevel')
        if m.get('ruleDesc') is not None:
            self.rule_desc = m.get('ruleDesc')
        if m.get('ruleSequence') is not None:
            self.rule_sequence = m.get('ruleSequence')
        if m.get('ruleTag') is not None:
            self.rule_tag = m.get('ruleTag')
        if m.get('ruleTitle') is not None:
            self.rule_title = m.get('ruleTitle')
        return self


class CreateContractReviewTaskRequest(TeaModel):
    def __init__(
        self,
        contract_file: CreateContractReviewTaskRequestContractFile = None,
        contract_file_download_url: str = None,
        contract_file_name: str = None,
        file_source: str = None,
        request_id: str = None,
        review_custom_rules: List[CreateContractReviewTaskRequestReviewCustomRules] = None,
        rule_type: str = None,
        standpoint: str = None,
    ):
        self.contract_file = contract_file
        self.contract_file_download_url = contract_file_download_url
        # This parameter is required.
        self.contract_file_name = contract_file_name
        # This parameter is required.
        self.file_source = file_source
        # This parameter is required.
        self.request_id = request_id
        self.review_custom_rules = review_custom_rules
        self.rule_type = rule_type
        self.standpoint = standpoint

    def validate(self):
        if self.contract_file:
            self.contract_file.validate()
        if self.review_custom_rules:
            for k in self.review_custom_rules:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.contract_file is not None:
            result['contractFile'] = self.contract_file.to_map()
        if self.contract_file_download_url is not None:
            result['contractFileDownloadUrl'] = self.contract_file_download_url
        if self.contract_file_name is not None:
            result['contractFileName'] = self.contract_file_name
        if self.file_source is not None:
            result['fileSource'] = self.file_source
        if self.request_id is not None:
            result['requestId'] = self.request_id
        result['reviewCustomRules'] = []
        if self.review_custom_rules is not None:
            for k in self.review_custom_rules:
                result['reviewCustomRules'].append(k.to_map() if k else None)
        if self.rule_type is not None:
            result['ruleType'] = self.rule_type
        if self.standpoint is not None:
            result['standpoint'] = self.standpoint
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('contractFile') is not None:
            temp_model = CreateContractReviewTaskRequestContractFile()
            self.contract_file = temp_model.from_map(m['contractFile'])
        if m.get('contractFileDownloadUrl') is not None:
            self.contract_file_download_url = m.get('contractFileDownloadUrl')
        if m.get('contractFileName') is not None:
            self.contract_file_name = m.get('contractFileName')
        if m.get('fileSource') is not None:
            self.file_source = m.get('fileSource')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        self.review_custom_rules = []
        if m.get('reviewCustomRules') is not None:
            for k in m.get('reviewCustomRules'):
                temp_model = CreateContractReviewTaskRequestReviewCustomRules()
                self.review_custom_rules.append(temp_model.from_map(k))
        if m.get('ruleType') is not None:
            self.rule_type = m.get('ruleType')
        if m.get('standpoint') is not None:
            self.standpoint = m.get('standpoint')
        return self


class CreateContractReviewTaskResponseBodyResultData(TeaModel):
    def __init__(
        self,
        review_task_id: str = None,
    ):
        self.review_task_id = review_task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.review_task_id is not None:
            result['reviewTaskId'] = self.review_task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('reviewTaskId') is not None:
            self.review_task_id = m.get('reviewTaskId')
        return self


class CreateContractReviewTaskResponseBodyResult(TeaModel):
    def __init__(
        self,
        data: CreateContractReviewTaskResponseBodyResultData = None,
        request_id: str = None,
    ):
        self.data = data
        self.request_id = request_id

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = CreateContractReviewTaskResponseBodyResultData()
            self.data = temp_model.from_map(m['data'])
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class CreateContractReviewTaskResponseBody(TeaModel):
    def __init__(
        self,
        result: CreateContractReviewTaskResponseBodyResult = None,
        success: bool = None,
    ):
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
        if self.result is not None:
            result['result'] = self.result.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = CreateContractReviewTaskResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CreateContractReviewTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateContractReviewTaskResponseBody = None,
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
            temp_model = CreateContractReviewTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class EsignQueryApprovalInfoHeaders(TeaModel):
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


class EsignQueryApprovalInfoRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        esign_flow_id: str = None,
        union_id: str = None,
    ):
        self.corp_id = corp_id
        self.esign_flow_id = esign_flow_id
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
        if self.esign_flow_id is not None:
            result['esignFlowId'] = self.esign_flow_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('esignFlowId') is not None:
            self.esign_flow_id = m.get('esignFlowId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class EsignQueryApprovalInfoResponseBodyResult(TeaModel):
    def __init__(
        self,
        bpms_process_business_id: str = None,
        bpms_process_instance_id: str = None,
        bpms_process_instance_url: str = None,
    ):
        self.bpms_process_business_id = bpms_process_business_id
        self.bpms_process_instance_id = bpms_process_instance_id
        self.bpms_process_instance_url = bpms_process_instance_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.bpms_process_business_id is not None:
            result['bpmsProcessBusinessId'] = self.bpms_process_business_id
        if self.bpms_process_instance_id is not None:
            result['bpmsProcessInstanceId'] = self.bpms_process_instance_id
        if self.bpms_process_instance_url is not None:
            result['bpmsProcessInstanceUrl'] = self.bpms_process_instance_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bpmsProcessBusinessId') is not None:
            self.bpms_process_business_id = m.get('bpmsProcessBusinessId')
        if m.get('bpmsProcessInstanceId') is not None:
            self.bpms_process_instance_id = m.get('bpmsProcessInstanceId')
        if m.get('bpmsProcessInstanceUrl') is not None:
            self.bpms_process_instance_url = m.get('bpmsProcessInstanceUrl')
        return self


class EsignQueryApprovalInfoResponseBody(TeaModel):
    def __init__(
        self,
        result: EsignQueryApprovalInfoResponseBodyResult = None,
        success: bool = None,
    ):
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
        if self.result is not None:
            result['result'] = self.result.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = EsignQueryApprovalInfoResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class EsignQueryApprovalInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: EsignQueryApprovalInfoResponseBody = None,
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
            temp_model = EsignQueryApprovalInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class EsignQueryGrantInfoHeaders(TeaModel):
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


class EsignQueryGrantInfoRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        extension: Dict[str, str] = None,
        union_id: str = None,
    ):
        self.corp_id = corp_id
        self.extension = extension
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
        if self.extension is not None:
            result['extension'] = self.extension
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class EsignQueryGrantInfoResponseBodyResult(TeaModel):
    def __init__(
        self,
        legal_person: str = None,
        mobile_phone_number: str = None,
        org_name: str = None,
        state_code: str = None,
        unified_social_credit: str = None,
        user_name: str = None,
    ):
        self.legal_person = legal_person
        self.mobile_phone_number = mobile_phone_number
        self.org_name = org_name
        self.state_code = state_code
        self.unified_social_credit = unified_social_credit
        self.user_name = user_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.legal_person is not None:
            result['legalPerson'] = self.legal_person
        if self.mobile_phone_number is not None:
            result['mobilePhoneNumber'] = self.mobile_phone_number
        if self.org_name is not None:
            result['orgName'] = self.org_name
        if self.state_code is not None:
            result['stateCode'] = self.state_code
        if self.unified_social_credit is not None:
            result['unifiedSocialCredit'] = self.unified_social_credit
        if self.user_name is not None:
            result['userName'] = self.user_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('legalPerson') is not None:
            self.legal_person = m.get('legalPerson')
        if m.get('mobilePhoneNumber') is not None:
            self.mobile_phone_number = m.get('mobilePhoneNumber')
        if m.get('orgName') is not None:
            self.org_name = m.get('orgName')
        if m.get('stateCode') is not None:
            self.state_code = m.get('stateCode')
        if m.get('unifiedSocialCredit') is not None:
            self.unified_social_credit = m.get('unifiedSocialCredit')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        return self


class EsignQueryGrantInfoResponseBody(TeaModel):
    def __init__(
        self,
        result: EsignQueryGrantInfoResponseBodyResult = None,
        success: bool = None,
    ):
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
        if self.result is not None:
            result['result'] = self.result.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = EsignQueryGrantInfoResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class EsignQueryGrantInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: EsignQueryGrantInfoResponseBody = None,
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
            temp_model = EsignQueryGrantInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class EsignQueryIdentityByTicketHeaders(TeaModel):
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


class EsignQueryIdentityByTicketRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        extension: Dict[str, str] = None,
        ticket: str = None,
    ):
        # This parameter is required.
        self.corp_id = corp_id
        self.extension = extension
        # This parameter is required.
        self.ticket = ticket

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.extension is not None:
            result['extension'] = self.extension
        if self.ticket is not None:
            result['ticket'] = self.ticket
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('ticket') is not None:
            self.ticket = m.get('ticket')
        return self


class EsignQueryIdentityByTicketResponseBodyResult(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
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


class EsignQueryIdentityByTicketResponseBody(TeaModel):
    def __init__(
        self,
        result: EsignQueryIdentityByTicketResponseBodyResult = None,
        success: bool = None,
    ):
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
        if self.result is not None:
            result['result'] = self.result.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = EsignQueryIdentityByTicketResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class EsignQueryIdentityByTicketResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: EsignQueryIdentityByTicketResponseBody = None,
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
            temp_model = EsignQueryIdentityByTicketResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class EsignSyncEventHeaders(TeaModel):
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


class EsignSyncEventRequest(TeaModel):
    def __init__(
        self,
        action: str = None,
        corp_id: str = None,
        esign_data: str = None,
        extension: Dict[str, str] = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.action = action
        self.corp_id = corp_id
        self.esign_data = esign_data
        self.extension = extension
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action is not None:
            result['action'] = self.action
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.esign_data is not None:
            result['esignData'] = self.esign_data
        if self.extension is not None:
            result['extension'] = self.extension
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('action') is not None:
            self.action = m.get('action')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('esignData') is not None:
            self.esign_data = m.get('esignData')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class EsignSyncEventResponseBodyResult(TeaModel):
    def __init__(
        self,
        message: str = None,
    ):
        self.message = message

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.message is not None:
            result['message'] = self.message
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('message') is not None:
            self.message = m.get('message')
        return self


class EsignSyncEventResponseBody(TeaModel):
    def __init__(
        self,
        result: EsignSyncEventResponseBodyResult = None,
        success: bool = None,
    ):
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
        if self.result is not None:
            result['result'] = self.result.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = EsignSyncEventResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class EsignSyncEventResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: EsignSyncEventResponseBody = None,
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
            temp_model = EsignSyncEventResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class EsignUserVerifyHeaders(TeaModel):
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


class EsignUserVerifyRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.corp_id = corp_id
        # This parameter is required.
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


class EsignUserVerifyResponseBodyResult(TeaModel):
    def __init__(
        self,
        can_access: bool = None,
    ):
        self.can_access = can_access

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.can_access is not None:
            result['canAccess'] = self.can_access
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('canAccess') is not None:
            self.can_access = m.get('canAccess')
        return self


class EsignUserVerifyResponseBody(TeaModel):
    def __init__(
        self,
        result: EsignUserVerifyResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        # This parameter is required.
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = EsignUserVerifyResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class EsignUserVerifyResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: EsignUserVerifyResponseBody = None,
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
            temp_model = EsignUserVerifyResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class FinishReviewOrderHeaders(TeaModel):
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


class FinishReviewOrderRequestEndFiles(TeaModel):
    def __init__(
        self,
        file_name: str = None,
        file_size: str = None,
        file_type: str = None,
        file_version: int = None,
        url: str = None,
    ):
        self.file_name = file_name
        self.file_size = file_size
        self.file_type = file_type
        self.file_version = file_version
        self.url = url

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
        if self.file_type is not None:
            result['fileType'] = self.file_type
        if self.file_version is not None:
            result['fileVersion'] = self.file_version
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('fileSize') is not None:
            self.file_size = m.get('fileSize')
        if m.get('fileType') is not None:
            self.file_type = m.get('fileType')
        if m.get('fileVersion') is not None:
            self.file_version = m.get('fileVersion')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class FinishReviewOrderRequest(TeaModel):
    def __init__(
        self,
        end_files: List[FinishReviewOrderRequestEndFiles] = None,
        extension: str = None,
        order_id: str = None,
    ):
        self.end_files = end_files
        self.extension = extension
        self.order_id = order_id

    def validate(self):
        if self.end_files:
            for k in self.end_files:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['endFiles'] = []
        if self.end_files is not None:
            for k in self.end_files:
                result['endFiles'].append(k.to_map() if k else None)
        if self.extension is not None:
            result['extension'] = self.extension
        if self.order_id is not None:
            result['orderId'] = self.order_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.end_files = []
        if m.get('endFiles') is not None:
            for k in m.get('endFiles'):
                temp_model = FinishReviewOrderRequestEndFiles()
                self.end_files.append(temp_model.from_map(k))
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        return self


class FinishReviewOrderResponseBody(TeaModel):
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


class FinishReviewOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: FinishReviewOrderResponseBody = None,
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
            temp_model = FinishReviewOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryAdvancedContractVersionHeaders(TeaModel):
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


class QueryAdvancedContractVersionRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        extension: Dict[str, str] = None,
    ):
        self.corp_id = corp_id
        self.extension = extension

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.extension is not None:
            result['extension'] = self.extension
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        return self


class QueryAdvancedContractVersionResponseBodyResult(TeaModel):
    def __init__(
        self,
        enable_esign_attachment_sign: bool = None,
        extension: Dict[str, str] = None,
        version: str = None,
    ):
        self.enable_esign_attachment_sign = enable_esign_attachment_sign
        self.extension = extension
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.enable_esign_attachment_sign is not None:
            result['enableEsignAttachmentSign'] = self.enable_esign_attachment_sign
        if self.extension is not None:
            result['extension'] = self.extension
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('enableEsignAttachmentSign') is not None:
            self.enable_esign_attachment_sign = m.get('enableEsignAttachmentSign')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class QueryAdvancedContractVersionResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryAdvancedContractVersionResponseBodyResult = None,
        success: bool = None,
    ):
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
        if self.result is not None:
            result['result'] = self.result.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = QueryAdvancedContractVersionResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryAdvancedContractVersionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryAdvancedContractVersionResponseBody = None,
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
            temp_model = QueryAdvancedContractVersionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryContractCompareResultHeaders(TeaModel):
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


class QueryContractCompareResultRequest(TeaModel):
    def __init__(
        self,
        compare_task_id: str = None,
        request_id: str = None,
    ):
        # This parameter is required.
        self.compare_task_id = compare_task_id
        # This parameter is required.
        self.request_id = request_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.compare_task_id is not None:
            result['compareTaskId'] = self.compare_task_id
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('compareTaskId') is not None:
            self.compare_task_id = m.get('compareTaskId')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class QueryContractCompareResultResponseBodyResultDataCompareDetailDetails(TeaModel):
    def __init__(
        self,
        compare_words: str = None,
        original_words: str = None,
        type: int = None,
    ):
        self.compare_words = compare_words
        self.original_words = original_words
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.compare_words is not None:
            result['compareWords'] = self.compare_words
        if self.original_words is not None:
            result['originalWords'] = self.original_words
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('compareWords') is not None:
            self.compare_words = m.get('compareWords')
        if m.get('originalWords') is not None:
            self.original_words = m.get('originalWords')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class QueryContractCompareResultResponseBodyResultDataCompareDetailDifferenceCount(TeaModel):
    def __init__(
        self,
        add: int = None,
        delete: int = None,
        replace: int = None,
        total: int = None,
    ):
        self.add = add
        self.delete = delete
        self.replace = replace
        self.total = total

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.add is not None:
            result['add'] = self.add
        if self.delete is not None:
            result['delete'] = self.delete
        if self.replace is not None:
            result['replace'] = self.replace
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('add') is not None:
            self.add = m.get('add')
        if m.get('delete') is not None:
            self.delete = m.get('delete')
        if m.get('replace') is not None:
            self.replace = m.get('replace')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class QueryContractCompareResultResponseBodyResultDataCompareDetail(TeaModel):
    def __init__(
        self,
        details: List[QueryContractCompareResultResponseBodyResultDataCompareDetailDetails] = None,
        difference_count: QueryContractCompareResultResponseBodyResultDataCompareDetailDifferenceCount = None,
    ):
        self.details = details
        self.difference_count = difference_count

    def validate(self):
        if self.details:
            for k in self.details:
                if k:
                    k.validate()
        if self.difference_count:
            self.difference_count.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['details'] = []
        if self.details is not None:
            for k in self.details:
                result['details'].append(k.to_map() if k else None)
        if self.difference_count is not None:
            result['differenceCount'] = self.difference_count.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.details = []
        if m.get('details') is not None:
            for k in m.get('details'):
                temp_model = QueryContractCompareResultResponseBodyResultDataCompareDetailDetails()
                self.details.append(temp_model.from_map(k))
        if m.get('differenceCount') is not None:
            temp_model = QueryContractCompareResultResponseBodyResultDataCompareDetailDifferenceCount()
            self.difference_count = temp_model.from_map(m['differenceCount'])
        return self


class QueryContractCompareResultResponseBodyResultData(TeaModel):
    def __init__(
        self,
        compare_detail: QueryContractCompareResultResponseBodyResultDataCompareDetail = None,
        compare_detail_url: str = None,
        compare_status: str = None,
    ):
        self.compare_detail = compare_detail
        self.compare_detail_url = compare_detail_url
        self.compare_status = compare_status

    def validate(self):
        if self.compare_detail:
            self.compare_detail.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.compare_detail is not None:
            result['compareDetail'] = self.compare_detail.to_map()
        if self.compare_detail_url is not None:
            result['compareDetailUrl'] = self.compare_detail_url
        if self.compare_status is not None:
            result['compareStatus'] = self.compare_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('compareDetail') is not None:
            temp_model = QueryContractCompareResultResponseBodyResultDataCompareDetail()
            self.compare_detail = temp_model.from_map(m['compareDetail'])
        if m.get('compareDetailUrl') is not None:
            self.compare_detail_url = m.get('compareDetailUrl')
        if m.get('compareStatus') is not None:
            self.compare_status = m.get('compareStatus')
        return self


class QueryContractCompareResultResponseBodyResult(TeaModel):
    def __init__(
        self,
        data: QueryContractCompareResultResponseBodyResultData = None,
        request_id: str = None,
    ):
        self.data = data
        self.request_id = request_id

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = QueryContractCompareResultResponseBodyResultData()
            self.data = temp_model.from_map(m['data'])
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class QueryContractCompareResultResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryContractCompareResultResponseBodyResult = None,
        success: bool = None,
    ):
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
        if self.result is not None:
            result['result'] = self.result.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = QueryContractCompareResultResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryContractCompareResultResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryContractCompareResultResponseBody = None,
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
            temp_model = QueryContractCompareResultResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryContractExtractResultHeaders(TeaModel):
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


class QueryContractExtractResultRequest(TeaModel):
    def __init__(
        self,
        extract_task_id: str = None,
        request_id: str = None,
    ):
        # This parameter is required.
        self.extract_task_id = extract_task_id
        # This parameter is required.
        self.request_id = request_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.extract_task_id is not None:
            result['extractTaskId'] = self.extract_task_id
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('extractTaskId') is not None:
            self.extract_task_id = m.get('extractTaskId')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class QueryContractExtractResultResponseBodyResultDataExtractEntities(TeaModel):
    def __init__(
        self,
        key: str = None,
        value: str = None,
    ):
        self.key = key
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
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('key') is not None:
            self.key = m.get('key')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class QueryContractExtractResultResponseBodyResultData(TeaModel):
    def __init__(
        self,
        extract_entities: List[QueryContractExtractResultResponseBodyResultDataExtractEntities] = None,
        extract_status: str = None,
    ):
        self.extract_entities = extract_entities
        self.extract_status = extract_status

    def validate(self):
        if self.extract_entities:
            for k in self.extract_entities:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['extractEntities'] = []
        if self.extract_entities is not None:
            for k in self.extract_entities:
                result['extractEntities'].append(k.to_map() if k else None)
        if self.extract_status is not None:
            result['extractStatus'] = self.extract_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.extract_entities = []
        if m.get('extractEntities') is not None:
            for k in m.get('extractEntities'):
                temp_model = QueryContractExtractResultResponseBodyResultDataExtractEntities()
                self.extract_entities.append(temp_model.from_map(k))
        if m.get('extractStatus') is not None:
            self.extract_status = m.get('extractStatus')
        return self


class QueryContractExtractResultResponseBodyResult(TeaModel):
    def __init__(
        self,
        data: QueryContractExtractResultResponseBodyResultData = None,
        request_id: str = None,
    ):
        self.data = data
        self.request_id = request_id

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = QueryContractExtractResultResponseBodyResultData()
            self.data = temp_model.from_map(m['data'])
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class QueryContractExtractResultResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryContractExtractResultResponseBodyResult = None,
        success: bool = None,
    ):
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
        if self.result is not None:
            result['result'] = self.result.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = QueryContractExtractResultResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryContractExtractResultResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryContractExtractResultResponseBody = None,
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
            temp_model = QueryContractExtractResultResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryContractReviewResultHeaders(TeaModel):
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


class QueryContractReviewResultRequest(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        review_task_id: str = None,
    ):
        # This parameter is required.
        self.request_id = request_id
        # This parameter is required.
        self.review_task_id = review_task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.review_task_id is not None:
            result['reviewTaskId'] = self.review_task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('reviewTaskId') is not None:
            self.review_task_id = m.get('reviewTaskId')
        return self


class QueryContractReviewResultResponseBodyResultDataReviewRiskDetailSubRisks(TeaModel):
    def __init__(
        self,
        original_content: str = None,
        result_content: str = None,
        result_type: str = None,
        risk_brief: str = None,
        risk_clause: str = None,
        risk_explain: str = None,
    ):
        self.original_content = original_content
        self.result_content = result_content
        self.result_type = result_type
        self.risk_brief = risk_brief
        self.risk_clause = risk_clause
        self.risk_explain = risk_explain

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.original_content is not None:
            result['originalContent'] = self.original_content
        if self.result_content is not None:
            result['resultContent'] = self.result_content
        if self.result_type is not None:
            result['resultType'] = self.result_type
        if self.risk_brief is not None:
            result['riskBrief'] = self.risk_brief
        if self.risk_clause is not None:
            result['riskClause'] = self.risk_clause
        if self.risk_explain is not None:
            result['riskExplain'] = self.risk_explain
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('originalContent') is not None:
            self.original_content = m.get('originalContent')
        if m.get('resultContent') is not None:
            self.result_content = m.get('resultContent')
        if m.get('resultType') is not None:
            self.result_type = m.get('resultType')
        if m.get('riskBrief') is not None:
            self.risk_brief = m.get('riskBrief')
        if m.get('riskClause') is not None:
            self.risk_clause = m.get('riskClause')
        if m.get('riskExplain') is not None:
            self.risk_explain = m.get('riskExplain')
        return self


class QueryContractReviewResultResponseBodyResultDataReviewRiskDetail(TeaModel):
    def __init__(
        self,
        examine_brief: str = None,
        examine_result: str = None,
        examine_status: str = None,
        risk_level: str = None,
        rule_sequence: str = None,
        rule_tag: str = None,
        rule_title: str = None,
        sub_risks: List[QueryContractReviewResultResponseBodyResultDataReviewRiskDetailSubRisks] = None,
    ):
        self.examine_brief = examine_brief
        self.examine_result = examine_result
        self.examine_status = examine_status
        self.risk_level = risk_level
        self.rule_sequence = rule_sequence
        self.rule_tag = rule_tag
        self.rule_title = rule_title
        self.sub_risks = sub_risks

    def validate(self):
        if self.sub_risks:
            for k in self.sub_risks:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.examine_brief is not None:
            result['examineBrief'] = self.examine_brief
        if self.examine_result is not None:
            result['examineResult'] = self.examine_result
        if self.examine_status is not None:
            result['examineStatus'] = self.examine_status
        if self.risk_level is not None:
            result['riskLevel'] = self.risk_level
        if self.rule_sequence is not None:
            result['ruleSequence'] = self.rule_sequence
        if self.rule_tag is not None:
            result['ruleTag'] = self.rule_tag
        if self.rule_title is not None:
            result['ruleTitle'] = self.rule_title
        result['subRisks'] = []
        if self.sub_risks is not None:
            for k in self.sub_risks:
                result['subRisks'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('examineBrief') is not None:
            self.examine_brief = m.get('examineBrief')
        if m.get('examineResult') is not None:
            self.examine_result = m.get('examineResult')
        if m.get('examineStatus') is not None:
            self.examine_status = m.get('examineStatus')
        if m.get('riskLevel') is not None:
            self.risk_level = m.get('riskLevel')
        if m.get('ruleSequence') is not None:
            self.rule_sequence = m.get('ruleSequence')
        if m.get('ruleTag') is not None:
            self.rule_tag = m.get('ruleTag')
        if m.get('ruleTitle') is not None:
            self.rule_title = m.get('ruleTitle')
        self.sub_risks = []
        if m.get('subRisks') is not None:
            for k in m.get('subRisks'):
                temp_model = QueryContractReviewResultResponseBodyResultDataReviewRiskDetailSubRisks()
                self.sub_risks.append(temp_model.from_map(k))
        return self


class QueryContractReviewResultResponseBodyResultDataReviewRiskOverview(TeaModel):
    def __init__(
        self,
        has_risk: bool = None,
        high_risk: int = None,
        low_risk: int = None,
        medium_risk: int = None,
    ):
        self.has_risk = has_risk
        self.high_risk = high_risk
        self.low_risk = low_risk
        self.medium_risk = medium_risk

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_risk is not None:
            result['hasRisk'] = self.has_risk
        if self.high_risk is not None:
            result['highRisk'] = self.high_risk
        if self.low_risk is not None:
            result['lowRisk'] = self.low_risk
        if self.medium_risk is not None:
            result['mediumRisk'] = self.medium_risk
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasRisk') is not None:
            self.has_risk = m.get('hasRisk')
        if m.get('highRisk') is not None:
            self.high_risk = m.get('highRisk')
        if m.get('lowRisk') is not None:
            self.low_risk = m.get('lowRisk')
        if m.get('mediumRisk') is not None:
            self.medium_risk = m.get('mediumRisk')
        return self


class QueryContractReviewResultResponseBodyResultDataReviewStatus(TeaModel):
    def __init__(
        self,
        overview: str = None,
        result: str = None,
        rule: str = None,
        stage: str = None,
    ):
        self.overview = overview
        self.result = result
        self.rule = rule
        self.stage = stage

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.overview is not None:
            result['overview'] = self.overview
        if self.result is not None:
            result['result'] = self.result
        if self.rule is not None:
            result['rule'] = self.rule
        if self.stage is not None:
            result['stage'] = self.stage
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('overview') is not None:
            self.overview = m.get('overview')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('rule') is not None:
            self.rule = m.get('rule')
        if m.get('stage') is not None:
            self.stage = m.get('stage')
        return self


class QueryContractReviewResultResponseBodyResultData(TeaModel):
    def __init__(
        self,
        review_risk_detail: List[QueryContractReviewResultResponseBodyResultDataReviewRiskDetail] = None,
        review_risk_overview: QueryContractReviewResultResponseBodyResultDataReviewRiskOverview = None,
        review_status: QueryContractReviewResultResponseBodyResultDataReviewStatus = None,
    ):
        self.review_risk_detail = review_risk_detail
        self.review_risk_overview = review_risk_overview
        self.review_status = review_status

    def validate(self):
        if self.review_risk_detail:
            for k in self.review_risk_detail:
                if k:
                    k.validate()
        if self.review_risk_overview:
            self.review_risk_overview.validate()
        if self.review_status:
            self.review_status.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['reviewRiskDetail'] = []
        if self.review_risk_detail is not None:
            for k in self.review_risk_detail:
                result['reviewRiskDetail'].append(k.to_map() if k else None)
        if self.review_risk_overview is not None:
            result['reviewRiskOverview'] = self.review_risk_overview.to_map()
        if self.review_status is not None:
            result['reviewStatus'] = self.review_status.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.review_risk_detail = []
        if m.get('reviewRiskDetail') is not None:
            for k in m.get('reviewRiskDetail'):
                temp_model = QueryContractReviewResultResponseBodyResultDataReviewRiskDetail()
                self.review_risk_detail.append(temp_model.from_map(k))
        if m.get('reviewRiskOverview') is not None:
            temp_model = QueryContractReviewResultResponseBodyResultDataReviewRiskOverview()
            self.review_risk_overview = temp_model.from_map(m['reviewRiskOverview'])
        if m.get('reviewStatus') is not None:
            temp_model = QueryContractReviewResultResponseBodyResultDataReviewStatus()
            self.review_status = temp_model.from_map(m['reviewStatus'])
        return self


class QueryContractReviewResultResponseBodyResult(TeaModel):
    def __init__(
        self,
        data: QueryContractReviewResultResponseBodyResultData = None,
        request_id: str = None,
    ):
        self.data = data
        self.request_id = request_id

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = QueryContractReviewResultResponseBodyResultData()
            self.data = temp_model.from_map(m['data'])
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class QueryContractReviewResultResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryContractReviewResultResponseBodyResult = None,
        success: bool = None,
    ):
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
        if self.result is not None:
            result['result'] = self.result.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = QueryContractReviewResultResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryContractReviewResultResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryContractReviewResultResponseBody = None,
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
            temp_model = QueryContractReviewResultResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendContractCardHeaders(TeaModel):
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


class SendContractCardRequestContractInfo(TeaModel):
    def __init__(
        self,
        contract_code: str = None,
        contract_name: str = None,
        create_time: int = None,
        sign_user_name: str = None,
    ):
        self.contract_code = contract_code
        self.contract_name = contract_name
        self.create_time = create_time
        self.sign_user_name = sign_user_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.contract_code is not None:
            result['contractCode'] = self.contract_code
        if self.contract_name is not None:
            result['contractName'] = self.contract_name
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.sign_user_name is not None:
            result['signUserName'] = self.sign_user_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('contractCode') is not None:
            self.contract_code = m.get('contractCode')
        if m.get('contractName') is not None:
            self.contract_name = m.get('contractName')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('signUserName') is not None:
            self.sign_user_name = m.get('signUserName')
        return self


class SendContractCardRequestReceivers(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        user_id: str = None,
        user_type: str = None,
    ):
        self.corp_id = corp_id
        self.user_id = user_id
        self.user_type = user_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_type is not None:
            result['userType'] = self.user_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userType') is not None:
            self.user_type = m.get('userType')
        return self


class SendContractCardRequestSender(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        user_id: str = None,
        user_type: str = None,
    ):
        self.corp_id = corp_id
        self.user_id = user_id
        self.user_type = user_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_type is not None:
            result['userType'] = self.user_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userType') is not None:
            self.user_type = m.get('userType')
        return self


class SendContractCardRequest(TeaModel):
    def __init__(
        self,
        card_type: str = None,
        contract_info: SendContractCardRequestContractInfo = None,
        corp_id: str = None,
        extension: Dict[str, str] = None,
        process_instance_id: str = None,
        receive_groups: List[str] = None,
        receivers: List[SendContractCardRequestReceivers] = None,
        sender: SendContractCardRequestSender = None,
        sync_single_chat: bool = None,
    ):
        # This parameter is required.
        self.card_type = card_type
        self.contract_info = contract_info
        # This parameter is required.
        self.corp_id = corp_id
        self.extension = extension
        self.process_instance_id = process_instance_id
        self.receive_groups = receive_groups
        # This parameter is required.
        self.receivers = receivers
        # This parameter is required.
        self.sender = sender
        # This parameter is required.
        self.sync_single_chat = sync_single_chat

    def validate(self):
        if self.contract_info:
            self.contract_info.validate()
        if self.receivers:
            for k in self.receivers:
                if k:
                    k.validate()
        if self.sender:
            self.sender.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_type is not None:
            result['cardType'] = self.card_type
        if self.contract_info is not None:
            result['contractInfo'] = self.contract_info.to_map()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.extension is not None:
            result['extension'] = self.extension
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.receive_groups is not None:
            result['receiveGroups'] = self.receive_groups
        result['receivers'] = []
        if self.receivers is not None:
            for k in self.receivers:
                result['receivers'].append(k.to_map() if k else None)
        if self.sender is not None:
            result['sender'] = self.sender.to_map()
        if self.sync_single_chat is not None:
            result['syncSingleChat'] = self.sync_single_chat
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardType') is not None:
            self.card_type = m.get('cardType')
        if m.get('contractInfo') is not None:
            temp_model = SendContractCardRequestContractInfo()
            self.contract_info = temp_model.from_map(m['contractInfo'])
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('receiveGroups') is not None:
            self.receive_groups = m.get('receiveGroups')
        self.receivers = []
        if m.get('receivers') is not None:
            for k in m.get('receivers'):
                temp_model = SendContractCardRequestReceivers()
                self.receivers.append(temp_model.from_map(k))
        if m.get('sender') is not None:
            temp_model = SendContractCardRequestSender()
            self.sender = temp_model.from_map(m['sender'])
        if m.get('syncSingleChat') is not None:
            self.sync_single_chat = m.get('syncSingleChat')
        return self


class SendContractCardResponseBody(TeaModel):
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


class SendContractCardResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SendContractCardResponseBody = None,
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
            temp_model = SendContractCardResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


