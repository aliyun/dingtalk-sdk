# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class ConnectionOmniChannelTiktokMessageHeaders(TeaModel):
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


class ConnectionOmniChannelTiktokMessageRequest(TeaModel):
    def __init__(
        self,
        tiktok_content_json_string: str = None,
    ):
        self.tiktok_content_json_string = tiktok_content_json_string

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.tiktok_content_json_string is not None:
            result['tiktokContentJsonString'] = self.tiktok_content_json_string
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('tiktokContentJsonString') is not None:
            self.tiktok_content_json_string = m.get('tiktokContentJsonString')
        return self


class ConnectionOmniChannelTiktokMessageResponseBodyOmniChannelTiktokRsp(TeaModel):
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


class ConnectionOmniChannelTiktokMessageResponseBody(TeaModel):
    def __init__(
        self,
        error_code: str = None,
        error_msg: str = None,
        omni_channel_tiktok_rsp: ConnectionOmniChannelTiktokMessageResponseBodyOmniChannelTiktokRsp = None,
        success: str = None,
    ):
        self.error_code = error_code
        self.error_msg = error_msg
        self.omni_channel_tiktok_rsp = omni_channel_tiktok_rsp
        self.success = success

    def validate(self):
        if self.omni_channel_tiktok_rsp:
            self.omni_channel_tiktok_rsp.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.omni_channel_tiktok_rsp is not None:
            result['omniChannelTiktokRsp'] = self.omni_channel_tiktok_rsp.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('omniChannelTiktokRsp') is not None:
            temp_model = ConnectionOmniChannelTiktokMessageResponseBodyOmniChannelTiktokRsp()
            self.omni_channel_tiktok_rsp = temp_model.from_map(m['omniChannelTiktokRsp'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ConnectionOmniChannelTiktokMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ConnectionOmniChannelTiktokMessageResponseBody = None,
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
            temp_model = ConnectionOmniChannelTiktokMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetLoginUserHeaders(TeaModel):
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


class GetLoginUserRequest(TeaModel):
    def __init__(
        self,
        auth_code: str = None,
    ):
        self.auth_code = auth_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auth_code is not None:
            result['authCode'] = self.auth_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authCode') is not None:
            self.auth_code = m.get('authCode')
        return self


class GetLoginUserResponseBodyCommodityInfo(TeaModel):
    def __init__(
        self,
        version: str = None,
    ):
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class GetLoginUserResponseBody(TeaModel):
    def __init__(
        self,
        commodity_info: GetLoginUserResponseBodyCommodityInfo = None,
        corp_id: str = None,
        open_id: str = None,
        union_id: str = None,
    ):
        self.commodity_info = commodity_info
        self.corp_id = corp_id
        self.open_id = open_id
        self.union_id = union_id

    def validate(self):
        if self.commodity_info:
            self.commodity_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.commodity_info is not None:
            result['commodityInfo'] = self.commodity_info.to_map()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.open_id is not None:
            result['openId'] = self.open_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commodityInfo') is not None:
            temp_model = GetLoginUserResponseBodyCommodityInfo()
            self.commodity_info = temp_model.from_map(m['commodityInfo'])
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('openId') is not None:
            self.open_id = m.get('openId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetLoginUserResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetLoginUserResponseBody = None,
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
            temp_model = GetLoginUserResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class LaunchHeaders(TeaModel):
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


class LaunchRequestVariantsOptionValues(TeaModel):
    def __init__(
        self,
        name: str = None,
        value: str = None,
    ):
        self.name = name
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class LaunchRequestVariants(TeaModel):
    def __init__(
        self,
        images: List[str] = None,
        option_values: List[LaunchRequestVariantsOptionValues] = None,
        price: str = None,
        sku: str = None,
    ):
        self.images = images
        self.option_values = option_values
        self.price = price
        self.sku = sku

    def validate(self):
        if self.option_values:
            for k in self.option_values:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.images is not None:
            result['images'] = self.images
        result['optionValues'] = []
        if self.option_values is not None:
            for k in self.option_values:
                result['optionValues'].append(k.to_map() if k else None)
        if self.price is not None:
            result['price'] = self.price
        if self.sku is not None:
            result['sku'] = self.sku
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('images') is not None:
            self.images = m.get('images')
        self.option_values = []
        if m.get('optionValues') is not None:
            for k in m.get('optionValues'):
                temp_model = LaunchRequestVariantsOptionValues()
                self.option_values.append(temp_model.from_map(k))
        if m.get('price') is not None:
            self.price = m.get('price')
        if m.get('sku') is not None:
            self.sku = m.get('sku')
        return self


class LaunchRequest(TeaModel):
    def __init__(
        self,
        description: str = None,
        image_urls: List[str] = None,
        platform: List[str] = None,
        product_name: str = None,
        selling_points: List[str] = None,
        source_data: str = None,
        variants: List[LaunchRequestVariants] = None,
        video_urls: List[str] = None,
        ding_agent_id: int = None,
        ding_client_id: str = None,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
        ding_uid: int = None,
    ):
        self.description = description
        self.image_urls = image_urls
        self.platform = platform
        self.product_name = product_name
        self.selling_points = selling_points
        self.source_data = source_data
        self.variants = variants
        self.video_urls = video_urls
        self.ding_agent_id = ding_agent_id
        self.ding_client_id = ding_client_id
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type
        self.ding_uid = ding_uid

    def validate(self):
        if self.variants:
            for k in self.variants:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        if self.image_urls is not None:
            result['imageUrls'] = self.image_urls
        if self.platform is not None:
            result['platform'] = self.platform
        if self.product_name is not None:
            result['productName'] = self.product_name
        if self.selling_points is not None:
            result['sellingPoints'] = self.selling_points
        if self.source_data is not None:
            result['sourceData'] = self.source_data
        result['variants'] = []
        if self.variants is not None:
            for k in self.variants:
                result['variants'].append(k.to_map() if k else None)
        if self.video_urls is not None:
            result['videoUrls'] = self.video_urls
        if self.ding_agent_id is not None:
            result['dingAgentId'] = self.ding_agent_id
        if self.ding_client_id is not None:
            result['dingClientId'] = self.ding_client_id
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.ding_uid is not None:
            result['dingUid'] = self.ding_uid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('imageUrls') is not None:
            self.image_urls = m.get('imageUrls')
        if m.get('platform') is not None:
            self.platform = m.get('platform')
        if m.get('productName') is not None:
            self.product_name = m.get('productName')
        if m.get('sellingPoints') is not None:
            self.selling_points = m.get('sellingPoints')
        if m.get('sourceData') is not None:
            self.source_data = m.get('sourceData')
        self.variants = []
        if m.get('variants') is not None:
            for k in m.get('variants'):
                temp_model = LaunchRequestVariants()
                self.variants.append(temp_model.from_map(k))
        if m.get('videoUrls') is not None:
            self.video_urls = m.get('videoUrls')
        if m.get('dingAgentId') is not None:
            self.ding_agent_id = m.get('dingAgentId')
        if m.get('dingClientId') is not None:
            self.ding_client_id = m.get('dingClientId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('dingUid') is not None:
            self.ding_uid = m.get('dingUid')
        return self


class LaunchResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        # This parameter is required.
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


class LaunchResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: LaunchResponseBody = None,
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
            temp_model = LaunchResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryNotableInfoHeaders(TeaModel):
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


class QueryNotableInfoRequest(TeaModel):
    def __init__(
        self,
        scene_code: str = None,
    ):
        self.scene_code = scene_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.scene_code is not None:
            result['sceneCode'] = self.scene_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sceneCode') is not None:
            self.scene_code = m.get('sceneCode')
        return self


class QueryNotableInfoResponseBody(TeaModel):
    def __init__(
        self,
        admin_union_ids: List[str] = None,
        base_id: str = None,
    ):
        self.admin_union_ids = admin_union_ids
        self.base_id = base_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.admin_union_ids is not None:
            result['adminUnionIds'] = self.admin_union_ids
        if self.base_id is not None:
            result['baseId'] = self.base_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('adminUnionIds') is not None:
            self.admin_union_ids = m.get('adminUnionIds')
        if m.get('baseId') is not None:
            self.base_id = m.get('baseId')
        return self


class QueryNotableInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryNotableInfoResponseBody = None,
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
            temp_model = QueryNotableInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class TiktokShopAuthCallbackHeaders(TeaModel):
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


class TiktokShopAuthCallbackRequest(TeaModel):
    def __init__(
        self,
        seller_type: str = None,
        shop_id: str = None,
        shop_name: str = None,
        shop_region: str = None,
    ):
        self.seller_type = seller_type
        self.shop_id = shop_id
        self.shop_name = shop_name
        self.shop_region = shop_region

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.seller_type is not None:
            result['sellerType'] = self.seller_type
        if self.shop_id is not None:
            result['shopId'] = self.shop_id
        if self.shop_name is not None:
            result['shopName'] = self.shop_name
        if self.shop_region is not None:
            result['shopRegion'] = self.shop_region
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sellerType') is not None:
            self.seller_type = m.get('sellerType')
        if m.get('shopId') is not None:
            self.shop_id = m.get('shopId')
        if m.get('shopName') is not None:
            self.shop_name = m.get('shopName')
        if m.get('shopRegion') is not None:
            self.shop_region = m.get('shopRegion')
        return self


class TiktokShopAuthCallbackResponseBody(TeaModel):
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


class TiktokShopAuthCallbackResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: TiktokShopAuthCallbackResponseBody = None,
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
            temp_model = TiktokShopAuthCallbackResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


