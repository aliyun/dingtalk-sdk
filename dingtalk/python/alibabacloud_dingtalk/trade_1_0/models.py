# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class CheckOpportunityResultHeaders(TeaModel):
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


class CheckOpportunityResultRequest(TeaModel):
    def __init__(
        self,
        belong_to_phone_num: str = None,
        contact_phone_num: str = None,
        corp_id: str = None,
        dept_id: int = None,
        market_code: str = None,
    ):
        # This parameter is required.
        self.belong_to_phone_num = belong_to_phone_num
        # This parameter is required.
        self.contact_phone_num = contact_phone_num
        # This parameter is required.
        self.corp_id = corp_id
        self.dept_id = dept_id
        # This parameter is required.
        self.market_code = market_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.belong_to_phone_num is not None:
            result['belongToPhoneNum'] = self.belong_to_phone_num
        if self.contact_phone_num is not None:
            result['contactPhoneNum'] = self.contact_phone_num
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.market_code is not None:
            result['marketCode'] = self.market_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('belongToPhoneNum') is not None:
            self.belong_to_phone_num = m.get('belongToPhoneNum')
        if m.get('contactPhoneNum') is not None:
            self.contact_phone_num = m.get('contactPhoneNum')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('marketCode') is not None:
            self.market_code = m.get('marketCode')
        return self


class CheckOpportunityResultResponseBody(TeaModel):
    def __init__(
        self,
        biz_success: bool = None,
    ):
        self.biz_success = biz_success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_success is not None:
            result['bizSuccess'] = self.biz_success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizSuccess') is not None:
            self.biz_success = m.get('bizSuccess')
        return self


class CheckOpportunityResultResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CheckOpportunityResultResponseBody = None,
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
            temp_model = CheckOpportunityResultResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateClueTempHeaders(TeaModel):
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


class CreateClueTempRequest(TeaModel):
    def __init__(
        self,
        address: str = None,
        contact_name: str = None,
        dept_id: int = None,
        ext: str = None,
        name: str = None,
        phone_num: str = None,
        position: str = None,
        product_code: str = None,
        sales_id: int = None,
        source: str = None,
    ):
        self.address = address
        # This parameter is required.
        self.contact_name = contact_name
        self.dept_id = dept_id
        self.ext = ext
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.phone_num = phone_num
        self.position = position
        self.product_code = product_code
        self.sales_id = sales_id
        # This parameter is required.
        self.source = source

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.address is not None:
            result['address'] = self.address
        if self.contact_name is not None:
            result['contactName'] = self.contact_name
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.ext is not None:
            result['ext'] = self.ext
        if self.name is not None:
            result['name'] = self.name
        if self.phone_num is not None:
            result['phoneNum'] = self.phone_num
        if self.position is not None:
            result['position'] = self.position
        if self.product_code is not None:
            result['productCode'] = self.product_code
        if self.sales_id is not None:
            result['salesId'] = self.sales_id
        if self.source is not None:
            result['source'] = self.source
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('address') is not None:
            self.address = m.get('address')
        if m.get('contactName') is not None:
            self.contact_name = m.get('contactName')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('phoneNum') is not None:
            self.phone_num = m.get('phoneNum')
        if m.get('position') is not None:
            self.position = m.get('position')
        if m.get('productCode') is not None:
            self.product_code = m.get('productCode')
        if m.get('salesId') is not None:
            self.sales_id = m.get('salesId')
        if m.get('source') is not None:
            self.source = m.get('source')
        return self


class CreateClueTempResponseBody(TeaModel):
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


class CreateClueTempResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateClueTempResponseBody = None,
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
            temp_model = CreateClueTempResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateNoteForIsvHeaders(TeaModel):
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


class CreateNoteForIsvRequest(TeaModel):
    def __init__(
        self,
        contact_name: str = None,
        contact_phone_num: str = None,
        contact_title: str = None,
        content: str = None,
        corp_id: str = None,
        input_phone_num: str = None,
    ):
        self.contact_name = contact_name
        # This parameter is required.
        self.contact_phone_num = contact_phone_num
        self.contact_title = contact_title
        # This parameter is required.
        self.content = content
        # This parameter is required.
        self.corp_id = corp_id
        # This parameter is required.
        self.input_phone_num = input_phone_num

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.contact_name is not None:
            result['contactName'] = self.contact_name
        if self.contact_phone_num is not None:
            result['contactPhoneNum'] = self.contact_phone_num
        if self.contact_title is not None:
            result['contactTitle'] = self.contact_title
        if self.content is not None:
            result['content'] = self.content
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.input_phone_num is not None:
            result['inputPhoneNum'] = self.input_phone_num
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('contactName') is not None:
            self.contact_name = m.get('contactName')
        if m.get('contactPhoneNum') is not None:
            self.contact_phone_num = m.get('contactPhoneNum')
        if m.get('contactTitle') is not None:
            self.contact_title = m.get('contactTitle')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('inputPhoneNum') is not None:
            self.input_phone_num = m.get('inputPhoneNum')
        return self


class CreateNoteForIsvResponseBody(TeaModel):
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


class CreateNoteForIsvResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateNoteForIsvResponseBody = None,
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
            temp_model = CreateNoteForIsvResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateOpportunityHeaders(TeaModel):
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


class CreateOpportunityRequest(TeaModel):
    def __init__(
        self,
        belong_to_phone_num: str = None,
        contact_phone_num: str = None,
        corp_id: str = None,
        dept_id: int = None,
        market_code: str = None,
    ):
        # This parameter is required.
        self.belong_to_phone_num = belong_to_phone_num
        # This parameter is required.
        self.contact_phone_num = contact_phone_num
        # This parameter is required.
        self.corp_id = corp_id
        self.dept_id = dept_id
        # This parameter is required.
        self.market_code = market_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.belong_to_phone_num is not None:
            result['belongToPhoneNum'] = self.belong_to_phone_num
        if self.contact_phone_num is not None:
            result['contactPhoneNum'] = self.contact_phone_num
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.market_code is not None:
            result['marketCode'] = self.market_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('belongToPhoneNum') is not None:
            self.belong_to_phone_num = m.get('belongToPhoneNum')
        if m.get('contactPhoneNum') is not None:
            self.contact_phone_num = m.get('contactPhoneNum')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('marketCode') is not None:
            self.market_code = m.get('marketCode')
        return self


class CreateOpportunityResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class PurchaseMixViewHeaders(TeaModel):
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


class PurchaseMixViewRequestListItemComponentListItemPropertyList(TeaModel):
    def __init__(
        self,
        code: str = None,
        name: str = None,
        value: str = None,
    ):
        self.code = code
        self.name = name
        self.value = value

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
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class PurchaseMixViewRequestListItemComponentList(TeaModel):
    def __init__(
        self,
        component_code: str = None,
        component_name: str = None,
        item_property_list: List[PurchaseMixViewRequestListItemComponentListItemPropertyList] = None,
    ):
        self.component_code = component_code
        self.component_name = component_name
        self.item_property_list = item_property_list

    def validate(self):
        if self.item_property_list:
            for k in self.item_property_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.component_code is not None:
            result['componentCode'] = self.component_code
        if self.component_name is not None:
            result['componentName'] = self.component_name
        result['itemPropertyList'] = []
        if self.item_property_list is not None:
            for k in self.item_property_list:
                result['itemPropertyList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentCode') is not None:
            self.component_code = m.get('componentCode')
        if m.get('componentName') is not None:
            self.component_name = m.get('componentName')
        self.item_property_list = []
        if m.get('itemPropertyList') is not None:
            for k in m.get('itemPropertyList'):
                temp_model = PurchaseMixViewRequestListItemComponentListItemPropertyList()
                self.item_property_list.append(temp_model.from_map(k))
        return self


class PurchaseMixViewRequestListMinorItemParamList(TeaModel):
    def __init__(
        self,
        minor_item_code: str = None,
        minor_item_group_code: str = None,
    ):
        self.minor_item_code = minor_item_code
        self.minor_item_group_code = minor_item_group_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.minor_item_code is not None:
            result['minorItemCode'] = self.minor_item_code
        if self.minor_item_group_code is not None:
            result['minorItemGroupCode'] = self.minor_item_group_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('minorItemCode') is not None:
            self.minor_item_code = m.get('minorItemCode')
        if m.get('minorItemGroupCode') is not None:
            self.minor_item_group_code = m.get('minorItemGroupCode')
        return self


class PurchaseMixViewRequestList(TeaModel):
    def __init__(
        self,
        activity_id: int = None,
        article_code: str = None,
        article_item_code: str = None,
        article_item_id: int = None,
        article_item_name: str = None,
        biz_type: int = None,
        coupon_id: int = None,
        cyc_num: int = None,
        cyc_type: int = None,
        cyc_unit: int = None,
        extend_1: int = None,
        instance_num: int = None,
        is_credit: bool = None,
        item_component_list: List[PurchaseMixViewRequestListItemComponentList] = None,
        minor_item_param_list: List[PurchaseMixViewRequestListMinorItemParamList] = None,
        order_param_map: Dict[str, Any] = None,
        order_type: str = None,
        sale_market_type: str = None,
        sale_org_id: int = None,
        sub_quantity: int = None,
        trade_model_type: str = None,
    ):
        self.activity_id = activity_id
        self.article_code = article_code
        self.article_item_code = article_item_code
        self.article_item_id = article_item_id
        self.article_item_name = article_item_name
        self.biz_type = biz_type
        self.coupon_id = coupon_id
        self.cyc_num = cyc_num
        self.cyc_type = cyc_type
        self.cyc_unit = cyc_unit
        self.extend_1 = extend_1
        self.instance_num = instance_num
        self.is_credit = is_credit
        self.item_component_list = item_component_list
        self.minor_item_param_list = minor_item_param_list
        self.order_param_map = order_param_map
        self.order_type = order_type
        self.sale_market_type = sale_market_type
        self.sale_org_id = sale_org_id
        self.sub_quantity = sub_quantity
        self.trade_model_type = trade_model_type

    def validate(self):
        if self.item_component_list:
            for k in self.item_component_list:
                if k:
                    k.validate()
        if self.minor_item_param_list:
            for k in self.minor_item_param_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        if self.article_code is not None:
            result['articleCode'] = self.article_code
        if self.article_item_code is not None:
            result['articleItemCode'] = self.article_item_code
        if self.article_item_id is not None:
            result['articleItemId'] = self.article_item_id
        if self.article_item_name is not None:
            result['articleItemName'] = self.article_item_name
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.coupon_id is not None:
            result['couponId'] = self.coupon_id
        if self.cyc_num is not None:
            result['cycNum'] = self.cyc_num
        if self.cyc_type is not None:
            result['cycType'] = self.cyc_type
        if self.cyc_unit is not None:
            result['cycUnit'] = self.cyc_unit
        if self.extend_1 is not None:
            result['extend1'] = self.extend_1
        if self.instance_num is not None:
            result['instanceNum'] = self.instance_num
        if self.is_credit is not None:
            result['isCredit'] = self.is_credit
        result['itemComponentList'] = []
        if self.item_component_list is not None:
            for k in self.item_component_list:
                result['itemComponentList'].append(k.to_map() if k else None)
        result['minorItemParamList'] = []
        if self.minor_item_param_list is not None:
            for k in self.minor_item_param_list:
                result['minorItemParamList'].append(k.to_map() if k else None)
        if self.order_param_map is not None:
            result['orderParamMap'] = self.order_param_map
        if self.order_type is not None:
            result['orderType'] = self.order_type
        if self.sale_market_type is not None:
            result['saleMarketType'] = self.sale_market_type
        if self.sale_org_id is not None:
            result['saleOrgId'] = self.sale_org_id
        if self.sub_quantity is not None:
            result['subQuantity'] = self.sub_quantity
        if self.trade_model_type is not None:
            result['tradeModelType'] = self.trade_model_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('articleCode') is not None:
            self.article_code = m.get('articleCode')
        if m.get('articleItemCode') is not None:
            self.article_item_code = m.get('articleItemCode')
        if m.get('articleItemId') is not None:
            self.article_item_id = m.get('articleItemId')
        if m.get('articleItemName') is not None:
            self.article_item_name = m.get('articleItemName')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('couponId') is not None:
            self.coupon_id = m.get('couponId')
        if m.get('cycNum') is not None:
            self.cyc_num = m.get('cycNum')
        if m.get('cycType') is not None:
            self.cyc_type = m.get('cycType')
        if m.get('cycUnit') is not None:
            self.cyc_unit = m.get('cycUnit')
        if m.get('extend1') is not None:
            self.extend_1 = m.get('extend1')
        if m.get('instanceNum') is not None:
            self.instance_num = m.get('instanceNum')
        if m.get('isCredit') is not None:
            self.is_credit = m.get('isCredit')
        self.item_component_list = []
        if m.get('itemComponentList') is not None:
            for k in m.get('itemComponentList'):
                temp_model = PurchaseMixViewRequestListItemComponentList()
                self.item_component_list.append(temp_model.from_map(k))
        self.minor_item_param_list = []
        if m.get('minorItemParamList') is not None:
            for k in m.get('minorItemParamList'):
                temp_model = PurchaseMixViewRequestListMinorItemParamList()
                self.minor_item_param_list.append(temp_model.from_map(k))
        if m.get('orderParamMap') is not None:
            self.order_param_map = m.get('orderParamMap')
        if m.get('orderType') is not None:
            self.order_type = m.get('orderType')
        if m.get('saleMarketType') is not None:
            self.sale_market_type = m.get('saleMarketType')
        if m.get('saleOrgId') is not None:
            self.sale_org_id = m.get('saleOrgId')
        if m.get('subQuantity') is not None:
            self.sub_quantity = m.get('subQuantity')
        if m.get('tradeModelType') is not None:
            self.trade_model_type = m.get('tradeModelType')
        return self


class PurchaseMixViewRequest(TeaModel):
    def __init__(
        self,
        channel_code: str = None,
        combine_activity_id: int = None,
        create_order: bool = None,
        list: List[PurchaseMixViewRequestList] = None,
        memo: str = None,
        merge_order_name: str = None,
        need_model_type_list: List[str] = None,
        obj_id: int = None,
        obj_type: int = None,
        order_param_map: Dict[str, Any] = None,
        outer_trade_code: str = None,
        outer_trade_type: str = None,
        plan_id: int = None,
        request_id: str = None,
        uid: int = None,
        un_pay: bool = None,
    ):
        self.channel_code = channel_code
        self.combine_activity_id = combine_activity_id
        self.create_order = create_order
        self.list = list
        self.memo = memo
        self.merge_order_name = merge_order_name
        self.need_model_type_list = need_model_type_list
        self.obj_id = obj_id
        self.obj_type = obj_type
        self.order_param_map = order_param_map
        self.outer_trade_code = outer_trade_code
        self.outer_trade_type = outer_trade_type
        self.plan_id = plan_id
        self.request_id = request_id
        self.uid = uid
        self.un_pay = un_pay

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
        if self.channel_code is not None:
            result['channelCode'] = self.channel_code
        if self.combine_activity_id is not None:
            result['combineActivityId'] = self.combine_activity_id
        if self.create_order is not None:
            result['createOrder'] = self.create_order
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.memo is not None:
            result['memo'] = self.memo
        if self.merge_order_name is not None:
            result['mergeOrderName'] = self.merge_order_name
        if self.need_model_type_list is not None:
            result['needModelTypeList'] = self.need_model_type_list
        if self.obj_id is not None:
            result['objId'] = self.obj_id
        if self.obj_type is not None:
            result['objType'] = self.obj_type
        if self.order_param_map is not None:
            result['orderParamMap'] = self.order_param_map
        if self.outer_trade_code is not None:
            result['outerTradeCode'] = self.outer_trade_code
        if self.outer_trade_type is not None:
            result['outerTradeType'] = self.outer_trade_type
        if self.plan_id is not None:
            result['planId'] = self.plan_id
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.uid is not None:
            result['uid'] = self.uid
        if self.un_pay is not None:
            result['unPay'] = self.un_pay
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('channelCode') is not None:
            self.channel_code = m.get('channelCode')
        if m.get('combineActivityId') is not None:
            self.combine_activity_id = m.get('combineActivityId')
        if m.get('createOrder') is not None:
            self.create_order = m.get('createOrder')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = PurchaseMixViewRequestList()
                self.list.append(temp_model.from_map(k))
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        if m.get('mergeOrderName') is not None:
            self.merge_order_name = m.get('mergeOrderName')
        if m.get('needModelTypeList') is not None:
            self.need_model_type_list = m.get('needModelTypeList')
        if m.get('objId') is not None:
            self.obj_id = m.get('objId')
        if m.get('objType') is not None:
            self.obj_type = m.get('objType')
        if m.get('orderParamMap') is not None:
            self.order_param_map = m.get('orderParamMap')
        if m.get('outerTradeCode') is not None:
            self.outer_trade_code = m.get('outerTradeCode')
        if m.get('outerTradeType') is not None:
            self.outer_trade_type = m.get('outerTradeType')
        if m.get('planId') is not None:
            self.plan_id = m.get('planId')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('uid') is not None:
            self.uid = m.get('uid')
        if m.get('unPay') is not None:
            self.un_pay = m.get('unPay')
        return self


class PurchaseMixViewResponseBodyResultAliyunArticleItemViewUnitList(TeaModel):
    def __init__(
        self,
        actual_pay_fee: float = None,
        article_code: str = None,
        article_item_code: str = None,
        biz_tag_list: List[str] = None,
        end_date: int = None,
        order_type: str = None,
        pay_fee: float = None,
        start_date: int = None,
    ):
        self.actual_pay_fee = actual_pay_fee
        self.article_code = article_code
        self.article_item_code = article_item_code
        self.biz_tag_list = biz_tag_list
        self.end_date = end_date
        self.order_type = order_type
        self.pay_fee = pay_fee
        self.start_date = start_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.actual_pay_fee is not None:
            result['actualPayFee'] = self.actual_pay_fee
        if self.article_code is not None:
            result['articleCode'] = self.article_code
        if self.article_item_code is not None:
            result['articleItemCode'] = self.article_item_code
        if self.biz_tag_list is not None:
            result['bizTagList'] = self.biz_tag_list
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.order_type is not None:
            result['orderType'] = self.order_type
        if self.pay_fee is not None:
            result['payFee'] = self.pay_fee
        if self.start_date is not None:
            result['startDate'] = self.start_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actualPayFee') is not None:
            self.actual_pay_fee = m.get('actualPayFee')
        if m.get('articleCode') is not None:
            self.article_code = m.get('articleCode')
        if m.get('articleItemCode') is not None:
            self.article_item_code = m.get('articleItemCode')
        if m.get('bizTagList') is not None:
            self.biz_tag_list = m.get('bizTagList')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('orderType') is not None:
            self.order_type = m.get('orderType')
        if m.get('payFee') is not None:
            self.pay_fee = m.get('payFee')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        return self


class PurchaseMixViewResponseBodyResultMixPromotionVO(TeaModel):
    def __init__(
        self,
        activity_id: int = None,
        activity_name: str = None,
        activity_url: str = None,
        end_time: int = None,
        extend_param: Dict[str, Any] = None,
        forbidden_coupon: bool = None,
        is_selected: bool = None,
        market_activity_id: int = None,
        promotion_id: int = None,
        promotion_name: str = None,
        promotion_type: str = None,
        source: str = None,
        start_time: int = None,
        type: str = None,
    ):
        self.activity_id = activity_id
        self.activity_name = activity_name
        self.activity_url = activity_url
        self.end_time = end_time
        self.extend_param = extend_param
        self.forbidden_coupon = forbidden_coupon
        self.is_selected = is_selected
        self.market_activity_id = market_activity_id
        self.promotion_id = promotion_id
        self.promotion_name = promotion_name
        self.promotion_type = promotion_type
        self.source = source
        self.start_time = start_time
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        if self.activity_name is not None:
            result['activityName'] = self.activity_name
        if self.activity_url is not None:
            result['activityUrl'] = self.activity_url
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.extend_param is not None:
            result['extendParam'] = self.extend_param
        if self.forbidden_coupon is not None:
            result['forbiddenCoupon'] = self.forbidden_coupon
        if self.is_selected is not None:
            result['isSelected'] = self.is_selected
        if self.market_activity_id is not None:
            result['marketActivityId'] = self.market_activity_id
        if self.promotion_id is not None:
            result['promotionId'] = self.promotion_id
        if self.promotion_name is not None:
            result['promotionName'] = self.promotion_name
        if self.promotion_type is not None:
            result['promotionType'] = self.promotion_type
        if self.source is not None:
            result['source'] = self.source
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('activityName') is not None:
            self.activity_name = m.get('activityName')
        if m.get('activityUrl') is not None:
            self.activity_url = m.get('activityUrl')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('extendParam') is not None:
            self.extend_param = m.get('extendParam')
        if m.get('forbiddenCoupon') is not None:
            self.forbidden_coupon = m.get('forbiddenCoupon')
        if m.get('isSelected') is not None:
            self.is_selected = m.get('isSelected')
        if m.get('marketActivityId') is not None:
            self.market_activity_id = m.get('marketActivityId')
        if m.get('promotionId') is not None:
            self.promotion_id = m.get('promotionId')
        if m.get('promotionName') is not None:
            self.promotion_name = m.get('promotionName')
        if m.get('promotionType') is not None:
            self.promotion_type = m.get('promotionType')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class PurchaseMixViewResponseBodyResultRecommendedMarketingCollocationDTO(TeaModel):
    def __init__(
        self,
        activity_id: int = None,
        coupon_id: int = None,
    ):
        self.activity_id = activity_id
        self.coupon_id = coupon_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        if self.coupon_id is not None:
            result['couponId'] = self.coupon_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('couponId') is not None:
            self.coupon_id = m.get('couponId')
        return self


class PurchaseMixViewResponseBodyResult(TeaModel):
    def __init__(
        self,
        aliyun_article_item_view_unit_list: List[PurchaseMixViewResponseBodyResultAliyunArticleItemViewUnitList] = None,
        mix_promotion_vo: PurchaseMixViewResponseBodyResultMixPromotionVO = None,
        recommended_marketing_collocation_dto: PurchaseMixViewResponseBodyResultRecommendedMarketingCollocationDTO = None,
    ):
        self.aliyun_article_item_view_unit_list = aliyun_article_item_view_unit_list
        self.mix_promotion_vo = mix_promotion_vo
        self.recommended_marketing_collocation_dto = recommended_marketing_collocation_dto

    def validate(self):
        if self.aliyun_article_item_view_unit_list:
            for k in self.aliyun_article_item_view_unit_list:
                if k:
                    k.validate()
        if self.mix_promotion_vo:
            self.mix_promotion_vo.validate()
        if self.recommended_marketing_collocation_dto:
            self.recommended_marketing_collocation_dto.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['aliyunArticleItemViewUnitList'] = []
        if self.aliyun_article_item_view_unit_list is not None:
            for k in self.aliyun_article_item_view_unit_list:
                result['aliyunArticleItemViewUnitList'].append(k.to_map() if k else None)
        if self.mix_promotion_vo is not None:
            result['mixPromotionVO'] = self.mix_promotion_vo.to_map()
        if self.recommended_marketing_collocation_dto is not None:
            result['recommendedMarketingCollocationDTO'] = self.recommended_marketing_collocation_dto.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.aliyun_article_item_view_unit_list = []
        if m.get('aliyunArticleItemViewUnitList') is not None:
            for k in m.get('aliyunArticleItemViewUnitList'):
                temp_model = PurchaseMixViewResponseBodyResultAliyunArticleItemViewUnitList()
                self.aliyun_article_item_view_unit_list.append(temp_model.from_map(k))
        if m.get('mixPromotionVO') is not None:
            temp_model = PurchaseMixViewResponseBodyResultMixPromotionVO()
            self.mix_promotion_vo = temp_model.from_map(m['mixPromotionVO'])
        if m.get('recommendedMarketingCollocationDTO') is not None:
            temp_model = PurchaseMixViewResponseBodyResultRecommendedMarketingCollocationDTO()
            self.recommended_marketing_collocation_dto = temp_model.from_map(m['recommendedMarketingCollocationDTO'])
        return self


class PurchaseMixViewResponseBody(TeaModel):
    def __init__(
        self,
        error_code: str = None,
        error_msg: str = None,
        result: PurchaseMixViewResponseBodyResult = None,
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
            temp_model = PurchaseMixViewResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class PurchaseMixViewResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PurchaseMixViewResponseBody = None,
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
            temp_model = PurchaseMixViewResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryTradeOrderHeaders(TeaModel):
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


class QueryTradeOrderRequest(TeaModel):
    def __init__(
        self,
        order_id: int = None,
        outer_order_id: str = None,
    ):
        self.order_id = order_id
        self.outer_order_id = outer_order_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.order_id is not None:
            result['orderId'] = self.order_id
        if self.outer_order_id is not None:
            result['outerOrderId'] = self.outer_order_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        if m.get('outerOrderId') is not None:
            self.outer_order_id = m.get('outerOrderId')
        return self


class QueryTradeOrderResponseBody(TeaModel):
    def __init__(
        self,
        article_code: str = None,
        article_item_code: str = None,
        article_item_name: str = None,
        article_name: str = None,
        close_time: int = None,
        create_time: int = None,
        fee: int = None,
        isv_crop_id: str = None,
        order_id: int = None,
        outer_order_id: str = None,
        pay_fee: int = None,
        pay_time: int = None,
        quantity: int = None,
        refund_time: int = None,
        status: int = None,
    ):
        # This parameter is required.
        self.article_code = article_code
        # This parameter is required.
        self.article_item_code = article_item_code
        # This parameter is required.
        self.article_item_name = article_item_name
        # This parameter is required.
        self.article_name = article_name
        self.close_time = close_time
        # This parameter is required.
        self.create_time = create_time
        # This parameter is required.
        self.fee = fee
        # This parameter is required.
        self.isv_crop_id = isv_crop_id
        # This parameter is required.
        self.order_id = order_id
        self.outer_order_id = outer_order_id
        # This parameter is required.
        self.pay_fee = pay_fee
        self.pay_time = pay_time
        # This parameter is required.
        self.quantity = quantity
        self.refund_time = refund_time
        # This parameter is required.
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.article_code is not None:
            result['articleCode'] = self.article_code
        if self.article_item_code is not None:
            result['articleItemCode'] = self.article_item_code
        if self.article_item_name is not None:
            result['articleItemName'] = self.article_item_name
        if self.article_name is not None:
            result['articleName'] = self.article_name
        if self.close_time is not None:
            result['closeTime'] = self.close_time
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.fee is not None:
            result['fee'] = self.fee
        if self.isv_crop_id is not None:
            result['isvCropId'] = self.isv_crop_id
        if self.order_id is not None:
            result['orderId'] = self.order_id
        if self.outer_order_id is not None:
            result['outerOrderId'] = self.outer_order_id
        if self.pay_fee is not None:
            result['payFee'] = self.pay_fee
        if self.pay_time is not None:
            result['payTime'] = self.pay_time
        if self.quantity is not None:
            result['quantity'] = self.quantity
        if self.refund_time is not None:
            result['refundTime'] = self.refund_time
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('articleCode') is not None:
            self.article_code = m.get('articleCode')
        if m.get('articleItemCode') is not None:
            self.article_item_code = m.get('articleItemCode')
        if m.get('articleItemName') is not None:
            self.article_item_name = m.get('articleItemName')
        if m.get('articleName') is not None:
            self.article_name = m.get('articleName')
        if m.get('closeTime') is not None:
            self.close_time = m.get('closeTime')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('fee') is not None:
            self.fee = m.get('fee')
        if m.get('isvCropId') is not None:
            self.isv_crop_id = m.get('isvCropId')
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        if m.get('outerOrderId') is not None:
            self.outer_order_id = m.get('outerOrderId')
        if m.get('payFee') is not None:
            self.pay_fee = m.get('payFee')
        if m.get('payTime') is not None:
            self.pay_time = m.get('payTime')
        if m.get('quantity') is not None:
            self.quantity = m.get('quantity')
        if m.get('refundTime') is not None:
            self.refund_time = m.get('refundTime')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class QueryTradeOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryTradeOrderResponseBody = None,
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
            temp_model = QueryTradeOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


