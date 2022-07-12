# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class SyncSecretKeyHeaders(TeaModel):
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


class SyncSecretKeyRequest(TeaModel):
    def __init__(
        self,
        action_type: str = None,
        secret_string: str = None,
        target_corp_id: str = None,
        trip_app_key: str = None,
        trip_app_security: str = None,
        trip_corp_id: str = None,
    ):
        # 操作类型，ADD/QUERY/MODIFY/DEL
        self.action_type = action_type
        # 验签加密串
        self.secret_string = secret_string
        # 钉钉侧对应的组织ID
        self.target_corp_id = target_corp_id
        # 商旅侧appkey
        self.trip_app_key = trip_app_key
        # 商旅对接密钥
        self.trip_app_security = trip_app_security
        # 商旅侧组织ID
        self.trip_corp_id = trip_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_type is not None:
            result['actionType'] = self.action_type
        if self.secret_string is not None:
            result['secretString'] = self.secret_string
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        if self.trip_app_key is not None:
            result['tripAppKey'] = self.trip_app_key
        if self.trip_app_security is not None:
            result['tripAppSecurity'] = self.trip_app_security
        if self.trip_corp_id is not None:
            result['tripCorpId'] = self.trip_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionType') is not None:
            self.action_type = m.get('actionType')
        if m.get('secretString') is not None:
            self.secret_string = m.get('secretString')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        if m.get('tripAppKey') is not None:
            self.trip_app_key = m.get('tripAppKey')
        if m.get('tripAppSecurity') is not None:
            self.trip_app_security = m.get('tripAppSecurity')
        if m.get('tripCorpId') is not None:
            self.trip_corp_id = m.get('tripCorpId')
        return self


class SyncSecretKeyResponseBodyResult(TeaModel):
    def __init__(
        self,
        secret_string: str = None,
        target_corp_id: str = None,
        trip_app_key: str = None,
        trip_app_security: str = None,
        trip_corp_id: str = None,
    ):
        # 验签加密串
        self.secret_string = secret_string
        # 钉钉侧对应的组织ID
        self.target_corp_id = target_corp_id
        # 商旅侧对接key
        self.trip_app_key = trip_app_key
        # 商旅侧对接密钥
        self.trip_app_security = trip_app_security
        # 商旅侧对应的组织ID
        self.trip_corp_id = trip_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.secret_string is not None:
            result['secretString'] = self.secret_string
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        if self.trip_app_key is not None:
            result['tripAppKey'] = self.trip_app_key
        if self.trip_app_security is not None:
            result['tripAppSecurity'] = self.trip_app_security
        if self.trip_corp_id is not None:
            result['tripCorpId'] = self.trip_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('secretString') is not None:
            self.secret_string = m.get('secretString')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        if m.get('tripAppKey') is not None:
            self.trip_app_key = m.get('tripAppKey')
        if m.get('tripAppSecurity') is not None:
            self.trip_app_security = m.get('tripAppSecurity')
        if m.get('tripCorpId') is not None:
            self.trip_corp_id = m.get('tripCorpId')
        return self


class SyncSecretKeyResponseBody(TeaModel):
    def __init__(
        self,
        result: SyncSecretKeyResponseBodyResult = None,
        success: str = None,
    ):
        self.result = result
        # 是否成功
        # 
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
            temp_model = SyncSecretKeyResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class SyncSecretKeyResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SyncSecretKeyResponseBody = None,
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
            temp_model = SyncSecretKeyResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SyncTripOrderHeaders(TeaModel):
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


class SyncTripOrderRequestEvent(TeaModel):
    def __init__(
        self,
        action: str = None,
        gmt_action: str = None,
    ):
        # 订单事件
        self.action = action
        # 事件时间
        self.gmt_action = gmt_action

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action is not None:
            result['action'] = self.action
        if self.gmt_action is not None:
            result['gmtAction'] = self.gmt_action
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('action') is not None:
            self.action = m.get('action')
        if m.get('gmtAction') is not None:
            self.gmt_action = m.get('gmtAction')
        return self


class SyncTripOrderRequestOrderDetailsHotelLocation(TeaModel):
    def __init__(
        self,
        lat: str = None,
        lon: str = None,
        source: str = None,
        url: str = None,
    ):
        # 纬度
        self.lat = lat
        # 经度
        self.lon = lon
        # 坐标数据源
        # - BD09：来自百度地图的经纬坐标
        # - GCJ02: 来自高德地图，腾讯地图，Apple地图的坐标
        # - WGS84: 来自GPS的坐标
        self.source = source
        # 定位url
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.lat is not None:
            result['lat'] = self.lat
        if self.lon is not None:
            result['lon'] = self.lon
        if self.source is not None:
            result['source'] = self.source
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('lat') is not None:
            self.lat = m.get('lat')
        if m.get('lon') is not None:
            self.lon = m.get('lon')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class SyncTripOrderRequestOrderDetails(TeaModel):
    def __init__(
        self,
        arrival_time: str = None,
        car_number: str = None,
        catering_type: str = None,
        check_in_time: str = None,
        check_out_time: str = None,
        depart_time: str = None,
        destination_city_code: str = None,
        destination_station: str = None,
        hotel_address: str = None,
        hotel_location: SyncTripOrderRequestOrderDetailsHotelLocation = None,
        hotel_name: str = None,
        origin_city_code: str = None,
        origin_station: str = None,
        room_count: int = None,
        seat_info: str = None,
        sub_supply_logo: str = None,
        sub_supply_name: str = None,
        taxi_type: str = None,
        telephone: str = None,
        transport_number: str = None,
        type_description: str = None,
    ):
        # 到达时间
        self.arrival_time = arrival_time
        # 车牌号
        self.car_number = car_number
        # 餐食描述
        self.catering_type = catering_type
        # 入住时间
        self.check_in_time = check_in_time
        # 离店时间
        self.check_out_time = check_out_time
        # 出发时间
        self.depart_time = depart_time
        # 目的地城市码
        self.destination_city_code = destination_city_code
        # 目的站名称
        self.destination_station = destination_station
        # 酒店地址
        self.hotel_address = hotel_address
        # 酒店定位信息
        self.hotel_location = hotel_location
        # 酒店名称
        self.hotel_name = hotel_name
        # 出发地城市码
        self.origin_city_code = origin_city_code
        # 出发站名称
        self.origin_station = origin_station
        # 房间数
        self.room_count = room_count
        # 舱位
        self.seat_info = seat_info
        # 下游供应商logo
        self.sub_supply_logo = sub_supply_logo
        # 下游供应商名称
        self.sub_supply_name = sub_supply_name
        # 专车类型
        self.taxi_type = taxi_type
        # 联系方式
        self.telephone = telephone
        # 火车/航班班次
        self.transport_number = transport_number
        # 房型描述
        self.type_description = type_description

    def validate(self):
        if self.hotel_location:
            self.hotel_location.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.arrival_time is not None:
            result['arrivalTime'] = self.arrival_time
        if self.car_number is not None:
            result['carNumber'] = self.car_number
        if self.catering_type is not None:
            result['cateringType'] = self.catering_type
        if self.check_in_time is not None:
            result['checkInTime'] = self.check_in_time
        if self.check_out_time is not None:
            result['checkOutTime'] = self.check_out_time
        if self.depart_time is not None:
            result['departTime'] = self.depart_time
        if self.destination_city_code is not None:
            result['destinationCityCode'] = self.destination_city_code
        if self.destination_station is not None:
            result['destinationStation'] = self.destination_station
        if self.hotel_address is not None:
            result['hotelAddress'] = self.hotel_address
        if self.hotel_location is not None:
            result['hotelLocation'] = self.hotel_location.to_map()
        if self.hotel_name is not None:
            result['hotelName'] = self.hotel_name
        if self.origin_city_code is not None:
            result['originCityCode'] = self.origin_city_code
        if self.origin_station is not None:
            result['originStation'] = self.origin_station
        if self.room_count is not None:
            result['roomCount'] = self.room_count
        if self.seat_info is not None:
            result['seatInfo'] = self.seat_info
        if self.sub_supply_logo is not None:
            result['subSupplyLogo'] = self.sub_supply_logo
        if self.sub_supply_name is not None:
            result['subSupplyName'] = self.sub_supply_name
        if self.taxi_type is not None:
            result['taxiType'] = self.taxi_type
        if self.telephone is not None:
            result['telephone'] = self.telephone
        if self.transport_number is not None:
            result['transportNumber'] = self.transport_number
        if self.type_description is not None:
            result['typeDescription'] = self.type_description
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('arrivalTime') is not None:
            self.arrival_time = m.get('arrivalTime')
        if m.get('carNumber') is not None:
            self.car_number = m.get('carNumber')
        if m.get('cateringType') is not None:
            self.catering_type = m.get('cateringType')
        if m.get('checkInTime') is not None:
            self.check_in_time = m.get('checkInTime')
        if m.get('checkOutTime') is not None:
            self.check_out_time = m.get('checkOutTime')
        if m.get('departTime') is not None:
            self.depart_time = m.get('departTime')
        if m.get('destinationCityCode') is not None:
            self.destination_city_code = m.get('destinationCityCode')
        if m.get('destinationStation') is not None:
            self.destination_station = m.get('destinationStation')
        if m.get('hotelAddress') is not None:
            self.hotel_address = m.get('hotelAddress')
        if m.get('hotelLocation') is not None:
            temp_model = SyncTripOrderRequestOrderDetailsHotelLocation()
            self.hotel_location = temp_model.from_map(m['hotelLocation'])
        if m.get('hotelName') is not None:
            self.hotel_name = m.get('hotelName')
        if m.get('originCityCode') is not None:
            self.origin_city_code = m.get('originCityCode')
        if m.get('originStation') is not None:
            self.origin_station = m.get('originStation')
        if m.get('roomCount') is not None:
            self.room_count = m.get('roomCount')
        if m.get('seatInfo') is not None:
            self.seat_info = m.get('seatInfo')
        if m.get('subSupplyLogo') is not None:
            self.sub_supply_logo = m.get('subSupplyLogo')
        if m.get('subSupplyName') is not None:
            self.sub_supply_name = m.get('subSupplyName')
        if m.get('taxiType') is not None:
            self.taxi_type = m.get('taxiType')
        if m.get('telephone') is not None:
            self.telephone = m.get('telephone')
        if m.get('transportNumber') is not None:
            self.transport_number = m.get('transportNumber')
        if m.get('typeDescription') is not None:
            self.type_description = m.get('typeDescription')
        return self


class SyncTripOrderRequest(TeaModel):
    def __init__(
        self,
        currency: str = None,
        ding_user_id: str = None,
        discount_amount: str = None,
        endorse_flag: bool = None,
        event: SyncTripOrderRequestEvent = None,
        gmt_order: str = None,
        gmt_pay: str = None,
        gmt_refund: str = None,
        invoice_apply_url: str = None,
        journey_biz_no: str = None,
        order_details: List[SyncTripOrderRequestOrderDetails] = None,
        order_no: str = None,
        order_url: str = None,
        real_amount: str = None,
        refund_amount: str = None,
        relative_order_no: str = None,
        target_corp_id: str = None,
        total_amount: str = None,
        type: str = None,
    ):
        # 币种
        self.currency = currency
        # 钉钉用户id
        self.ding_user_id = ding_user_id
        # 优惠金额
        self.discount_amount = discount_amount
        # 是否是改签单
        self.endorse_flag = endorse_flag
        self.event = event
        # 下单时间
        self.gmt_order = gmt_order
        # 付款时间
        self.gmt_pay = gmt_pay
        # 退款时间
        self.gmt_refund = gmt_refund
        # 发票申请链接
        self.invoice_apply_url = invoice_apply_url
        # 行程单号
        self.journey_biz_no = journey_biz_no
        # 订单详情列表
        self.order_details = order_details
        # 供应商订单号
        self.order_no = order_no
        # 订单详情链接
        self.order_url = order_url
        # 实付金额
        self.real_amount = real_amount
        # 退款金额
        self.refund_amount = refund_amount
        # 供应商关联订单号
        self.relative_order_no = relative_order_no
        # 用户组织id
        self.target_corp_id = target_corp_id
        # 总金额
        self.total_amount = total_amount
        # 订单类型
        self.type = type

    def validate(self):
        if self.event:
            self.event.validate()
        if self.order_details:
            for k in self.order_details:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.currency is not None:
            result['currency'] = self.currency
        if self.ding_user_id is not None:
            result['dingUserId'] = self.ding_user_id
        if self.discount_amount is not None:
            result['discountAmount'] = self.discount_amount
        if self.endorse_flag is not None:
            result['endorseFlag'] = self.endorse_flag
        if self.event is not None:
            result['event'] = self.event.to_map()
        if self.gmt_order is not None:
            result['gmtOrder'] = self.gmt_order
        if self.gmt_pay is not None:
            result['gmtPay'] = self.gmt_pay
        if self.gmt_refund is not None:
            result['gmtRefund'] = self.gmt_refund
        if self.invoice_apply_url is not None:
            result['invoiceApplyUrl'] = self.invoice_apply_url
        if self.journey_biz_no is not None:
            result['journeyBizNo'] = self.journey_biz_no
        result['orderDetails'] = []
        if self.order_details is not None:
            for k in self.order_details:
                result['orderDetails'].append(k.to_map() if k else None)
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.order_url is not None:
            result['orderUrl'] = self.order_url
        if self.real_amount is not None:
            result['realAmount'] = self.real_amount
        if self.refund_amount is not None:
            result['refundAmount'] = self.refund_amount
        if self.relative_order_no is not None:
            result['relativeOrderNo'] = self.relative_order_no
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        if self.total_amount is not None:
            result['totalAmount'] = self.total_amount
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('currency') is not None:
            self.currency = m.get('currency')
        if m.get('dingUserId') is not None:
            self.ding_user_id = m.get('dingUserId')
        if m.get('discountAmount') is not None:
            self.discount_amount = m.get('discountAmount')
        if m.get('endorseFlag') is not None:
            self.endorse_flag = m.get('endorseFlag')
        if m.get('event') is not None:
            temp_model = SyncTripOrderRequestEvent()
            self.event = temp_model.from_map(m['event'])
        if m.get('gmtOrder') is not None:
            self.gmt_order = m.get('gmtOrder')
        if m.get('gmtPay') is not None:
            self.gmt_pay = m.get('gmtPay')
        if m.get('gmtRefund') is not None:
            self.gmt_refund = m.get('gmtRefund')
        if m.get('invoiceApplyUrl') is not None:
            self.invoice_apply_url = m.get('invoiceApplyUrl')
        if m.get('journeyBizNo') is not None:
            self.journey_biz_no = m.get('journeyBizNo')
        self.order_details = []
        if m.get('orderDetails') is not None:
            for k in m.get('orderDetails'):
                temp_model = SyncTripOrderRequestOrderDetails()
                self.order_details.append(temp_model.from_map(k))
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('orderUrl') is not None:
            self.order_url = m.get('orderUrl')
        if m.get('realAmount') is not None:
            self.real_amount = m.get('realAmount')
        if m.get('refundAmount') is not None:
            self.refund_amount = m.get('refundAmount')
        if m.get('relativeOrderNo') is not None:
            self.relative_order_no = m.get('relativeOrderNo')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        if m.get('totalAmount') is not None:
            self.total_amount = m.get('totalAmount')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class SyncTripOrderResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        success: bool = None,
    ):
        # Id of the request
        self.request_id = request_id
        # 是否成功
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class SyncTripOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SyncTripOrderResponseBody = None,
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
            temp_model = SyncTripOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


