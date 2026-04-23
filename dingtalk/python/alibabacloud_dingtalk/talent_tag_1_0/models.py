# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class TalentV2AddCustomTagHeaders(TeaModel):
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


class TalentV2AddCustomTagRequest(TeaModel):
    def __init__(
        self,
        sort_order: int = None,
        tag_code: str = None,
        tag_name: str = None,
        user_id: str = None,
    ):
        self.sort_order = sort_order
        self.tag_code = tag_code
        # This parameter is required.
        self.tag_name = tag_name
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sort_order is not None:
            result['sortOrder'] = self.sort_order
        if self.tag_code is not None:
            result['tagCode'] = self.tag_code
        if self.tag_name is not None:
            result['tagName'] = self.tag_name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sortOrder') is not None:
            self.sort_order = m.get('sortOrder')
        if m.get('tagCode') is not None:
            self.tag_code = m.get('tagCode')
        if m.get('tagName') is not None:
            self.tag_name = m.get('tagName')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class TalentV2AddCustomTagResponseBodyResult(TeaModel):
    def __init__(
        self,
        tag_code: str = None,
        tag_name: str = None,
    ):
        self.tag_code = tag_code
        self.tag_name = tag_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.tag_code is not None:
            result['tagCode'] = self.tag_code
        if self.tag_name is not None:
            result['tagName'] = self.tag_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('tagCode') is not None:
            self.tag_code = m.get('tagCode')
        if m.get('tagName') is not None:
            self.tag_name = m.get('tagName')
        return self


class TalentV2AddCustomTagResponseBody(TeaModel):
    def __init__(
        self,
        result: TalentV2AddCustomTagResponseBodyResult = None,
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
            temp_model = TalentV2AddCustomTagResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class TalentV2AddCustomTagResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: TalentV2AddCustomTagResponseBody = None,
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
            temp_model = TalentV2AddCustomTagResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class TalentV2AddObjectiveTagHeaders(TeaModel):
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


class TalentV2AddObjectiveTagRequest(TeaModel):
    def __init__(
        self,
        sort_order: int = None,
        tag_code: str = None,
        tag_name: str = None,
        user_id: str = None,
    ):
        self.sort_order = sort_order
        self.tag_code = tag_code
        # This parameter is required.
        self.tag_name = tag_name
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sort_order is not None:
            result['sortOrder'] = self.sort_order
        if self.tag_code is not None:
            result['tagCode'] = self.tag_code
        if self.tag_name is not None:
            result['tagName'] = self.tag_name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sortOrder') is not None:
            self.sort_order = m.get('sortOrder')
        if m.get('tagCode') is not None:
            self.tag_code = m.get('tagCode')
        if m.get('tagName') is not None:
            self.tag_name = m.get('tagName')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class TalentV2AddObjectiveTagResponseBodyResult(TeaModel):
    def __init__(
        self,
        tag_code: str = None,
        tag_name: str = None,
    ):
        self.tag_code = tag_code
        self.tag_name = tag_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.tag_code is not None:
            result['tagCode'] = self.tag_code
        if self.tag_name is not None:
            result['tagName'] = self.tag_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('tagCode') is not None:
            self.tag_code = m.get('tagCode')
        if m.get('tagName') is not None:
            self.tag_name = m.get('tagName')
        return self


class TalentV2AddObjectiveTagResponseBody(TeaModel):
    def __init__(
        self,
        result: TalentV2AddObjectiveTagResponseBodyResult = None,
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
            temp_model = TalentV2AddObjectiveTagResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class TalentV2AddObjectiveTagResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: TalentV2AddObjectiveTagResponseBody = None,
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
            temp_model = TalentV2AddObjectiveTagResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class TalentV2AddPersonalityTagHeaders(TeaModel):
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


class TalentV2AddPersonalityTagRequest(TeaModel):
    def __init__(
        self,
        category_code: str = None,
        category_name: str = None,
        category_sort_order: int = None,
        sort_order: int = None,
        tag_code: str = None,
        tag_name: str = None,
    ):
        self.category_code = category_code
        # This parameter is required.
        self.category_name = category_name
        self.category_sort_order = category_sort_order
        self.sort_order = sort_order
        self.tag_code = tag_code
        # This parameter is required.
        self.tag_name = tag_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category_code is not None:
            result['categoryCode'] = self.category_code
        if self.category_name is not None:
            result['categoryName'] = self.category_name
        if self.category_sort_order is not None:
            result['categorySortOrder'] = self.category_sort_order
        if self.sort_order is not None:
            result['sortOrder'] = self.sort_order
        if self.tag_code is not None:
            result['tagCode'] = self.tag_code
        if self.tag_name is not None:
            result['tagName'] = self.tag_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('categoryCode') is not None:
            self.category_code = m.get('categoryCode')
        if m.get('categoryName') is not None:
            self.category_name = m.get('categoryName')
        if m.get('categorySortOrder') is not None:
            self.category_sort_order = m.get('categorySortOrder')
        if m.get('sortOrder') is not None:
            self.sort_order = m.get('sortOrder')
        if m.get('tagCode') is not None:
            self.tag_code = m.get('tagCode')
        if m.get('tagName') is not None:
            self.tag_name = m.get('tagName')
        return self


class TalentV2AddPersonalityTagResponseBodyResult(TeaModel):
    def __init__(
        self,
        category_code: str = None,
        category_name: str = None,
        tag_code: str = None,
        tag_name: str = None,
    ):
        self.category_code = category_code
        self.category_name = category_name
        self.tag_code = tag_code
        self.tag_name = tag_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category_code is not None:
            result['categoryCode'] = self.category_code
        if self.category_name is not None:
            result['categoryName'] = self.category_name
        if self.tag_code is not None:
            result['tagCode'] = self.tag_code
        if self.tag_name is not None:
            result['tagName'] = self.tag_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('categoryCode') is not None:
            self.category_code = m.get('categoryCode')
        if m.get('categoryName') is not None:
            self.category_name = m.get('categoryName')
        if m.get('tagCode') is not None:
            self.tag_code = m.get('tagCode')
        if m.get('tagName') is not None:
            self.tag_name = m.get('tagName')
        return self


class TalentV2AddPersonalityTagResponseBody(TeaModel):
    def __init__(
        self,
        result: TalentV2AddPersonalityTagResponseBodyResult = None,
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
            temp_model = TalentV2AddPersonalityTagResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class TalentV2AddPersonalityTagResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: TalentV2AddPersonalityTagResponseBody = None,
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
            temp_model = TalentV2AddPersonalityTagResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class TalentV2DeleteCustomTagHeaders(TeaModel):
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


class TalentV2DeleteCustomTagRequest(TeaModel):
    def __init__(
        self,
        tag_code: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.tag_code = tag_code
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.tag_code is not None:
            result['tagCode'] = self.tag_code
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('tagCode') is not None:
            self.tag_code = m.get('tagCode')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class TalentV2DeleteCustomTagResponseBodyResult(TeaModel):
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


class TalentV2DeleteCustomTagResponseBody(TeaModel):
    def __init__(
        self,
        result: TalentV2DeleteCustomTagResponseBodyResult = None,
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
            temp_model = TalentV2DeleteCustomTagResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class TalentV2DeleteCustomTagResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: TalentV2DeleteCustomTagResponseBody = None,
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
            temp_model = TalentV2DeleteCustomTagResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class TalentV2DeleteObjectiveTagHeaders(TeaModel):
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


class TalentV2DeleteObjectiveTagRequest(TeaModel):
    def __init__(
        self,
        tag_code: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.tag_code = tag_code
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.tag_code is not None:
            result['tagCode'] = self.tag_code
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('tagCode') is not None:
            self.tag_code = m.get('tagCode')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class TalentV2DeleteObjectiveTagResponseBodyResult(TeaModel):
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


class TalentV2DeleteObjectiveTagResponseBody(TeaModel):
    def __init__(
        self,
        result: TalentV2DeleteObjectiveTagResponseBodyResult = None,
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
            temp_model = TalentV2DeleteObjectiveTagResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class TalentV2DeleteObjectiveTagResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: TalentV2DeleteObjectiveTagResponseBody = None,
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
            temp_model = TalentV2DeleteObjectiveTagResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class TalentV2DeletePersonalityTagHeaders(TeaModel):
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


class TalentV2DeletePersonalityTagRequest(TeaModel):
    def __init__(
        self,
        tag_code: str = None,
    ):
        # This parameter is required.
        self.tag_code = tag_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.tag_code is not None:
            result['tagCode'] = self.tag_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('tagCode') is not None:
            self.tag_code = m.get('tagCode')
        return self


class TalentV2DeletePersonalityTagResponseBodyResult(TeaModel):
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


class TalentV2DeletePersonalityTagResponseBody(TeaModel):
    def __init__(
        self,
        result: TalentV2DeletePersonalityTagResponseBodyResult = None,
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
            temp_model = TalentV2DeletePersonalityTagResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class TalentV2DeletePersonalityTagResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: TalentV2DeletePersonalityTagResponseBody = None,
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
            temp_model = TalentV2DeletePersonalityTagResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class TalentV2LikeTagHeaders(TeaModel):
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


class TalentV2LikeTagRequest(TeaModel):
    def __init__(
        self,
        action_type: str = None,
        operator_user_id: str = None,
        tag_code: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.action_type = action_type
        # This parameter is required.
        self.operator_user_id = operator_user_id
        # This parameter is required.
        self.tag_code = tag_code
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_type is not None:
            result['actionType'] = self.action_type
        if self.operator_user_id is not None:
            result['operatorUserId'] = self.operator_user_id
        if self.tag_code is not None:
            result['tagCode'] = self.tag_code
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionType') is not None:
            self.action_type = m.get('actionType')
        if m.get('operatorUserId') is not None:
            self.operator_user_id = m.get('operatorUserId')
        if m.get('tagCode') is not None:
            self.tag_code = m.get('tagCode')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class TalentV2LikeTagResponseBodyResult(TeaModel):
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


class TalentV2LikeTagResponseBody(TeaModel):
    def __init__(
        self,
        result: TalentV2LikeTagResponseBodyResult = None,
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
            temp_model = TalentV2LikeTagResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class TalentV2LikeTagResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: TalentV2LikeTagResponseBody = None,
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
            temp_model = TalentV2LikeTagResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class TalentV2QueryCustomTagHeaders(TeaModel):
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


class TalentV2QueryCustomTagRequest(TeaModel):
    def __init__(
        self,
        user_id: str = None,
    ):
        # This parameter is required.
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


class TalentV2QueryCustomTagResponseBodyResultTags(TeaModel):
    def __init__(
        self,
        sort_order: int = None,
        tag_code: str = None,
        tag_name: str = None,
    ):
        self.sort_order = sort_order
        self.tag_code = tag_code
        self.tag_name = tag_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sort_order is not None:
            result['sortOrder'] = self.sort_order
        if self.tag_code is not None:
            result['tagCode'] = self.tag_code
        if self.tag_name is not None:
            result['tagName'] = self.tag_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sortOrder') is not None:
            self.sort_order = m.get('sortOrder')
        if m.get('tagCode') is not None:
            self.tag_code = m.get('tagCode')
        if m.get('tagName') is not None:
            self.tag_name = m.get('tagName')
        return self


class TalentV2QueryCustomTagResponseBodyResult(TeaModel):
    def __init__(
        self,
        tags: List[TalentV2QueryCustomTagResponseBodyResultTags] = None,
    ):
        self.tags = tags

    def validate(self):
        if self.tags:
            for k in self.tags:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['tags'] = []
        if self.tags is not None:
            for k in self.tags:
                result['tags'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.tags = []
        if m.get('tags') is not None:
            for k in m.get('tags'):
                temp_model = TalentV2QueryCustomTagResponseBodyResultTags()
                self.tags.append(temp_model.from_map(k))
        return self


class TalentV2QueryCustomTagResponseBody(TeaModel):
    def __init__(
        self,
        result: TalentV2QueryCustomTagResponseBodyResult = None,
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
            temp_model = TalentV2QueryCustomTagResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class TalentV2QueryCustomTagResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: TalentV2QueryCustomTagResponseBody = None,
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
            temp_model = TalentV2QueryCustomTagResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class TalentV2QueryObjectiveTagHeaders(TeaModel):
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


class TalentV2QueryObjectiveTagRequest(TeaModel):
    def __init__(
        self,
        user_id: str = None,
    ):
        # This parameter is required.
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


class TalentV2QueryObjectiveTagResponseBodyResultTags(TeaModel):
    def __init__(
        self,
        sort_order: int = None,
        tag_code: str = None,
        tag_name: str = None,
    ):
        self.sort_order = sort_order
        self.tag_code = tag_code
        self.tag_name = tag_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sort_order is not None:
            result['sortOrder'] = self.sort_order
        if self.tag_code is not None:
            result['tagCode'] = self.tag_code
        if self.tag_name is not None:
            result['tagName'] = self.tag_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sortOrder') is not None:
            self.sort_order = m.get('sortOrder')
        if m.get('tagCode') is not None:
            self.tag_code = m.get('tagCode')
        if m.get('tagName') is not None:
            self.tag_name = m.get('tagName')
        return self


class TalentV2QueryObjectiveTagResponseBodyResult(TeaModel):
    def __init__(
        self,
        tags: List[TalentV2QueryObjectiveTagResponseBodyResultTags] = None,
    ):
        self.tags = tags

    def validate(self):
        if self.tags:
            for k in self.tags:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['tags'] = []
        if self.tags is not None:
            for k in self.tags:
                result['tags'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.tags = []
        if m.get('tags') is not None:
            for k in m.get('tags'):
                temp_model = TalentV2QueryObjectiveTagResponseBodyResultTags()
                self.tags.append(temp_model.from_map(k))
        return self


class TalentV2QueryObjectiveTagResponseBody(TeaModel):
    def __init__(
        self,
        result: TalentV2QueryObjectiveTagResponseBodyResult = None,
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
            temp_model = TalentV2QueryObjectiveTagResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class TalentV2QueryObjectiveTagResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: TalentV2QueryObjectiveTagResponseBody = None,
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
            temp_model = TalentV2QueryObjectiveTagResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class TalentV2QueryPersonalityTagHeaders(TeaModel):
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


class TalentV2QueryPersonalityTagResponseBodyResultTags(TeaModel):
    def __init__(
        self,
        category_code: str = None,
        category_name: str = None,
        category_sort_order: int = None,
        sort_order: int = None,
        tag_code: str = None,
        tag_name: str = None,
    ):
        self.category_code = category_code
        self.category_name = category_name
        self.category_sort_order = category_sort_order
        self.sort_order = sort_order
        self.tag_code = tag_code
        self.tag_name = tag_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category_code is not None:
            result['categoryCode'] = self.category_code
        if self.category_name is not None:
            result['categoryName'] = self.category_name
        if self.category_sort_order is not None:
            result['categorySortOrder'] = self.category_sort_order
        if self.sort_order is not None:
            result['sortOrder'] = self.sort_order
        if self.tag_code is not None:
            result['tagCode'] = self.tag_code
        if self.tag_name is not None:
            result['tagName'] = self.tag_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('categoryCode') is not None:
            self.category_code = m.get('categoryCode')
        if m.get('categoryName') is not None:
            self.category_name = m.get('categoryName')
        if m.get('categorySortOrder') is not None:
            self.category_sort_order = m.get('categorySortOrder')
        if m.get('sortOrder') is not None:
            self.sort_order = m.get('sortOrder')
        if m.get('tagCode') is not None:
            self.tag_code = m.get('tagCode')
        if m.get('tagName') is not None:
            self.tag_name = m.get('tagName')
        return self


class TalentV2QueryPersonalityTagResponseBodyResult(TeaModel):
    def __init__(
        self,
        tags: List[TalentV2QueryPersonalityTagResponseBodyResultTags] = None,
    ):
        self.tags = tags

    def validate(self):
        if self.tags:
            for k in self.tags:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['tags'] = []
        if self.tags is not None:
            for k in self.tags:
                result['tags'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.tags = []
        if m.get('tags') is not None:
            for k in m.get('tags'):
                temp_model = TalentV2QueryPersonalityTagResponseBodyResultTags()
                self.tags.append(temp_model.from_map(k))
        return self


class TalentV2QueryPersonalityTagResponseBody(TeaModel):
    def __init__(
        self,
        result: TalentV2QueryPersonalityTagResponseBodyResult = None,
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
            temp_model = TalentV2QueryPersonalityTagResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class TalentV2QueryPersonalityTagResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: TalentV2QueryPersonalityTagResponseBody = None,
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
            temp_model = TalentV2QueryPersonalityTagResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class TalentV2QueryTagLikeDetailListHeaders(TeaModel):
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


class TalentV2QueryTagLikeDetailListRequest(TeaModel):
    def __init__(
        self,
        cursor: int = None,
        size: int = None,
        tag_code: str = None,
        user_id: str = None,
    ):
        self.cursor = cursor
        self.size = size
        # This parameter is required.
        self.tag_code = tag_code
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cursor is not None:
            result['cursor'] = self.cursor
        if self.size is not None:
            result['size'] = self.size
        if self.tag_code is not None:
            result['tagCode'] = self.tag_code
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cursor') is not None:
            self.cursor = m.get('cursor')
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('tagCode') is not None:
            self.tag_code = m.get('tagCode')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class TalentV2QueryTagLikeDetailListResponseBodyResultLikeDetails(TeaModel):
    def __init__(
        self,
        like_timestamp: int = None,
        operator_user_id: str = None,
    ):
        self.like_timestamp = like_timestamp
        self.operator_user_id = operator_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.like_timestamp is not None:
            result['likeTimestamp'] = self.like_timestamp
        if self.operator_user_id is not None:
            result['operatorUserId'] = self.operator_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('likeTimestamp') is not None:
            self.like_timestamp = m.get('likeTimestamp')
        if m.get('operatorUserId') is not None:
            self.operator_user_id = m.get('operatorUserId')
        return self


class TalentV2QueryTagLikeDetailListResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        like_details: List[TalentV2QueryTagLikeDetailListResponseBodyResultLikeDetails] = None,
        next_cursor: int = None,
    ):
        self.has_more = has_more
        self.like_details = like_details
        self.next_cursor = next_cursor

    def validate(self):
        if self.like_details:
            for k in self.like_details:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['likeDetails'] = []
        if self.like_details is not None:
            for k in self.like_details:
                result['likeDetails'].append(k.to_map() if k else None)
        if self.next_cursor is not None:
            result['nextCursor'] = self.next_cursor
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.like_details = []
        if m.get('likeDetails') is not None:
            for k in m.get('likeDetails'):
                temp_model = TalentV2QueryTagLikeDetailListResponseBodyResultLikeDetails()
                self.like_details.append(temp_model.from_map(k))
        if m.get('nextCursor') is not None:
            self.next_cursor = m.get('nextCursor')
        return self


class TalentV2QueryTagLikeDetailListResponseBody(TeaModel):
    def __init__(
        self,
        result: TalentV2QueryTagLikeDetailListResponseBodyResult = None,
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
            temp_model = TalentV2QueryTagLikeDetailListResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class TalentV2QueryTagLikeDetailListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: TalentV2QueryTagLikeDetailListResponseBody = None,
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
            temp_model = TalentV2QueryTagLikeDetailListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class TalentV2QueryTagLikeListHeaders(TeaModel):
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


class TalentV2QueryTagLikeListRequest(TeaModel):
    def __init__(
        self,
        operator_user_id: str = None,
        user_id: str = None,
    ):
        self.operator_user_id = operator_user_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator_user_id is not None:
            result['operatorUserId'] = self.operator_user_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operatorUserId') is not None:
            self.operator_user_id = m.get('operatorUserId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class TalentV2QueryTagLikeListResponseBodyResultTagLikes(TeaModel):
    def __init__(
        self,
        has_liked: bool = None,
        like_count: int = None,
        tag_code: str = None,
        tag_name: str = None,
    ):
        self.has_liked = has_liked
        self.like_count = like_count
        self.tag_code = tag_code
        self.tag_name = tag_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_liked is not None:
            result['hasLiked'] = self.has_liked
        if self.like_count is not None:
            result['likeCount'] = self.like_count
        if self.tag_code is not None:
            result['tagCode'] = self.tag_code
        if self.tag_name is not None:
            result['tagName'] = self.tag_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasLiked') is not None:
            self.has_liked = m.get('hasLiked')
        if m.get('likeCount') is not None:
            self.like_count = m.get('likeCount')
        if m.get('tagCode') is not None:
            self.tag_code = m.get('tagCode')
        if m.get('tagName') is not None:
            self.tag_name = m.get('tagName')
        return self


class TalentV2QueryTagLikeListResponseBodyResult(TeaModel):
    def __init__(
        self,
        tag_likes: List[TalentV2QueryTagLikeListResponseBodyResultTagLikes] = None,
    ):
        self.tag_likes = tag_likes

    def validate(self):
        if self.tag_likes:
            for k in self.tag_likes:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['tagLikes'] = []
        if self.tag_likes is not None:
            for k in self.tag_likes:
                result['tagLikes'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.tag_likes = []
        if m.get('tagLikes') is not None:
            for k in m.get('tagLikes'):
                temp_model = TalentV2QueryTagLikeListResponseBodyResultTagLikes()
                self.tag_likes.append(temp_model.from_map(k))
        return self


class TalentV2QueryTagLikeListResponseBody(TeaModel):
    def __init__(
        self,
        result: TalentV2QueryTagLikeListResponseBodyResult = None,
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
            temp_model = TalentV2QueryTagLikeListResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class TalentV2QueryTagLikeListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: TalentV2QueryTagLikeListResponseBody = None,
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
            temp_model = TalentV2QueryTagLikeListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


