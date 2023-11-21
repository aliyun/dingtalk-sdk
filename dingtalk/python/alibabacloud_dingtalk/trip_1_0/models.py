# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class GetTravelProcessDetailHeaders(TeaModel):
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


class GetTravelProcessDetailRequest(TeaModel):
    def __init__(
        self,
        process_instance_id: str = None,
    ):
        self.process_instance_id = process_instance_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        return self


class GetTravelProcessDetailResponseBodyResultJourneysArrival(TeaModel):
    def __init__(
        self,
        code: str = None,
        name: str = None,
        national_city_code: str = None,
    ):
        self.code = code
        self.name = name
        self.national_city_code = national_city_code

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
        if self.national_city_code is not None:
            result['nationalCityCode'] = self.national_city_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('nationalCityCode') is not None:
            self.national_city_code = m.get('nationalCityCode')
        return self


class GetTravelProcessDetailResponseBodyResultJourneysDeparture(TeaModel):
    def __init__(
        self,
        code: str = None,
        name: str = None,
        national_city_code: str = None,
    ):
        self.code = code
        self.name = name
        self.national_city_code = national_city_code

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
        if self.national_city_code is not None:
            result['nationalCityCode'] = self.national_city_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('nationalCityCode') is not None:
            self.national_city_code = m.get('nationalCityCode')
        return self


class GetTravelProcessDetailResponseBodyResultJourneys(TeaModel):
    def __init__(
        self,
        arrival: GetTravelProcessDetailResponseBodyResultJourneysArrival = None,
        departure: GetTravelProcessDetailResponseBodyResultJourneysDeparture = None,
        end_time: str = None,
        journey_biz_no: str = None,
        start_time: str = None,
        travel_type: str = None,
        trip_way: str = None,
    ):
        self.arrival = arrival
        self.departure = departure
        self.end_time = end_time
        self.journey_biz_no = journey_biz_no
        self.start_time = start_time
        self.travel_type = travel_type
        self.trip_way = trip_way

    def validate(self):
        if self.arrival:
            self.arrival.validate()
        if self.departure:
            self.departure.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.arrival is not None:
            result['arrival'] = self.arrival.to_map()
        if self.departure is not None:
            result['departure'] = self.departure.to_map()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.journey_biz_no is not None:
            result['journeyBizNo'] = self.journey_biz_no
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.travel_type is not None:
            result['travelType'] = self.travel_type
        if self.trip_way is not None:
            result['tripWay'] = self.trip_way
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('arrival') is not None:
            temp_model = GetTravelProcessDetailResponseBodyResultJourneysArrival()
            self.arrival = temp_model.from_map(m['arrival'])
        if m.get('departure') is not None:
            temp_model = GetTravelProcessDetailResponseBodyResultJourneysDeparture()
            self.departure = temp_model.from_map(m['departure'])
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('journeyBizNo') is not None:
            self.journey_biz_no = m.get('journeyBizNo')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('travelType') is not None:
            self.travel_type = m.get('travelType')
        if m.get('tripWay') is not None:
            self.trip_way = m.get('tripWay')
        return self


class GetTravelProcessDetailResponseBodyResult(TeaModel):
    def __init__(
        self,
        business_id: str = None,
        corp_id: str = None,
        cost_center: str = None,
        itinerary_project: str = None,
        journeys: List[GetTravelProcessDetailResponseBodyResultJourneys] = None,
        main_process_instance_id: str = None,
        memo: str = None,
        originator_id: str = None,
        process_instance_id: str = None,
        process_result: str = None,
        process_status: str = None,
        remark: str = None,
        travel_category: str = None,
        travelers: List[str] = None,
    ):
        self.business_id = business_id
        self.corp_id = corp_id
        self.cost_center = cost_center
        self.itinerary_project = itinerary_project
        self.journeys = journeys
        self.main_process_instance_id = main_process_instance_id
        self.memo = memo
        self.originator_id = originator_id
        self.process_instance_id = process_instance_id
        self.process_result = process_result
        self.process_status = process_status
        self.remark = remark
        self.travel_category = travel_category
        self.travelers = travelers

    def validate(self):
        if self.journeys:
            for k in self.journeys:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.business_id is not None:
            result['businessId'] = self.business_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.cost_center is not None:
            result['costCenter'] = self.cost_center
        if self.itinerary_project is not None:
            result['itineraryProject'] = self.itinerary_project
        result['journeys'] = []
        if self.journeys is not None:
            for k in self.journeys:
                result['journeys'].append(k.to_map() if k else None)
        if self.main_process_instance_id is not None:
            result['mainProcessInstanceId'] = self.main_process_instance_id
        if self.memo is not None:
            result['memo'] = self.memo
        if self.originator_id is not None:
            result['originatorId'] = self.originator_id
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.process_result is not None:
            result['processResult'] = self.process_result
        if self.process_status is not None:
            result['processStatus'] = self.process_status
        if self.remark is not None:
            result['remark'] = self.remark
        if self.travel_category is not None:
            result['travelCategory'] = self.travel_category
        if self.travelers is not None:
            result['travelers'] = self.travelers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('businessId') is not None:
            self.business_id = m.get('businessId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('costCenter') is not None:
            self.cost_center = m.get('costCenter')
        if m.get('itineraryProject') is not None:
            self.itinerary_project = m.get('itineraryProject')
        self.journeys = []
        if m.get('journeys') is not None:
            for k in m.get('journeys'):
                temp_model = GetTravelProcessDetailResponseBodyResultJourneys()
                self.journeys.append(temp_model.from_map(k))
        if m.get('mainProcessInstanceId') is not None:
            self.main_process_instance_id = m.get('mainProcessInstanceId')
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        if m.get('originatorId') is not None:
            self.originator_id = m.get('originatorId')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('processResult') is not None:
            self.process_result = m.get('processResult')
        if m.get('processStatus') is not None:
            self.process_status = m.get('processStatus')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('travelCategory') is not None:
            self.travel_category = m.get('travelCategory')
        if m.get('travelers') is not None:
            self.travelers = m.get('travelers')
        return self


class GetTravelProcessDetailResponseBody(TeaModel):
    def __init__(
        self,
        result: GetTravelProcessDetailResponseBodyResult = None,
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
            temp_model = GetTravelProcessDetailResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetTravelProcessDetailResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetTravelProcessDetailResponseBody = None,
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
            temp_model = GetTravelProcessDetailResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PreCheckTemplateHeaders(TeaModel):
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


class PreCheckTemplateRequest(TeaModel):
    def __init__(
        self,
        customer_corp_id: str = None,
    ):
        self.customer_corp_id = customer_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.customer_corp_id is not None:
            result['customerCorpId'] = self.customer_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customerCorpId') is not None:
            self.customer_corp_id = m.get('customerCorpId')
        return self


class PreCheckTemplateResponseBodyResultBlockRecords(TeaModel):
    def __init__(
        self,
        block_type: str = None,
        reason: str = None,
    ):
        self.block_type = block_type
        self.reason = reason

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.block_type is not None:
            result['blockType'] = self.block_type
        if self.reason is not None:
            result['reason'] = self.reason
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('blockType') is not None:
            self.block_type = m.get('blockType')
        if m.get('reason') is not None:
            self.reason = m.get('reason')
        return self


class PreCheckTemplateResponseBodyResult(TeaModel):
    def __init__(
        self,
        block_records: List[PreCheckTemplateResponseBodyResultBlockRecords] = None,
        pass_: bool = None,
    ):
        self.block_records = block_records
        self.pass_ = pass_

    def validate(self):
        if self.block_records:
            for k in self.block_records:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['blockRecords'] = []
        if self.block_records is not None:
            for k in self.block_records:
                result['blockRecords'].append(k.to_map() if k else None)
        if self.pass_ is not None:
            result['pass'] = self.pass_
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.block_records = []
        if m.get('blockRecords') is not None:
            for k in m.get('blockRecords'):
                temp_model = PreCheckTemplateResponseBodyResultBlockRecords()
                self.block_records.append(temp_model.from_map(k))
        if m.get('pass') is not None:
            self.pass_ = m.get('pass')
        return self


class PreCheckTemplateResponseBody(TeaModel):
    def __init__(
        self,
        result: PreCheckTemplateResponseBodyResult = None,
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
            temp_model = PreCheckTemplateResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class PreCheckTemplateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PreCheckTemplateResponseBody = None,
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
            temp_model = PreCheckTemplateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryTripProcessTemplatesHeaders(TeaModel):
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


class QueryTripProcessTemplatesRequest(TeaModel):
    def __init__(
        self,
        customer_corp_id: str = None,
    ):
        self.customer_corp_id = customer_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.customer_corp_id is not None:
            result['customerCorpId'] = self.customer_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customerCorpId') is not None:
            self.customer_corp_id = m.get('customerCorpId')
        return self


class QueryTripProcessTemplatesResponseBodyResultSchemas(TeaModel):
    def __init__(
        self,
        process_code: str = None,
        process_name: str = None,
        type: str = None,
    ):
        self.process_code = process_code
        self.process_name = process_name
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.process_name is not None:
            result['processName'] = self.process_name
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('processName') is not None:
            self.process_name = m.get('processName')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class QueryTripProcessTemplatesResponseBodyResult(TeaModel):
    def __init__(
        self,
        schemas: List[QueryTripProcessTemplatesResponseBodyResultSchemas] = None,
    ):
        self.schemas = schemas

    def validate(self):
        if self.schemas:
            for k in self.schemas:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['schemas'] = []
        if self.schemas is not None:
            for k in self.schemas:
                result['schemas'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.schemas = []
        if m.get('schemas') is not None:
            for k in m.get('schemas'):
                temp_model = QueryTripProcessTemplatesResponseBodyResultSchemas()
                self.schemas.append(temp_model.from_map(k))
        return self


class QueryTripProcessTemplatesResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryTripProcessTemplatesResponseBodyResult = None,
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
            temp_model = QueryTripProcessTemplatesResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryTripProcessTemplatesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryTripProcessTemplatesResponseBody = None,
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
            temp_model = QueryTripProcessTemplatesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SyncBusinessSignInfoHeaders(TeaModel):
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


class SyncBusinessSignInfoRequestTmcProductDetailList(TeaModel):
    def __init__(
        self,
        gmt_org_pay: str = None,
        pay_type: str = None,
        product: str = None,
    ):
        self.gmt_org_pay = gmt_org_pay
        self.pay_type = pay_type
        self.product = product

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.gmt_org_pay is not None:
            result['gmtOrgPay'] = self.gmt_org_pay
        if self.pay_type is not None:
            result['payType'] = self.pay_type
        if self.product is not None:
            result['product'] = self.product
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('gmtOrgPay') is not None:
            self.gmt_org_pay = m.get('gmtOrgPay')
        if m.get('payType') is not None:
            self.pay_type = m.get('payType')
        if m.get('product') is not None:
            self.product = m.get('product')
        return self


class SyncBusinessSignInfoRequestTmcProductListProductDetailList(TeaModel):
    def __init__(
        self,
        category_type: str = None,
        gmt_org_pay: str = None,
        open_status: bool = None,
        pay_type: str = None,
        product: str = None,
    ):
        self.category_type = category_type
        self.gmt_org_pay = gmt_org_pay
        self.open_status = open_status
        self.pay_type = pay_type
        self.product = product

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category_type is not None:
            result['categoryType'] = self.category_type
        if self.gmt_org_pay is not None:
            result['gmtOrgPay'] = self.gmt_org_pay
        if self.open_status is not None:
            result['openStatus'] = self.open_status
        if self.pay_type is not None:
            result['payType'] = self.pay_type
        if self.product is not None:
            result['product'] = self.product
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('categoryType') is not None:
            self.category_type = m.get('categoryType')
        if m.get('gmtOrgPay') is not None:
            self.gmt_org_pay = m.get('gmtOrgPay')
        if m.get('openStatus') is not None:
            self.open_status = m.get('openStatus')
        if m.get('payType') is not None:
            self.pay_type = m.get('payType')
        if m.get('product') is not None:
            self.product = m.get('product')
        return self


class SyncBusinessSignInfoRequestTmcProductList(TeaModel):
    def __init__(
        self,
        product_detail_list: List[SyncBusinessSignInfoRequestTmcProductListProductDetailList] = None,
        tmc_corp_id: str = None,
    ):
        self.product_detail_list = product_detail_list
        self.tmc_corp_id = tmc_corp_id

    def validate(self):
        if self.product_detail_list:
            for k in self.product_detail_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['productDetailList'] = []
        if self.product_detail_list is not None:
            for k in self.product_detail_list:
                result['productDetailList'].append(k.to_map() if k else None)
        if self.tmc_corp_id is not None:
            result['tmcCorpId'] = self.tmc_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.product_detail_list = []
        if m.get('productDetailList') is not None:
            for k in m.get('productDetailList'):
                temp_model = SyncBusinessSignInfoRequestTmcProductListProductDetailList()
                self.product_detail_list.append(temp_model.from_map(k))
        if m.get('tmcCorpId') is not None:
            self.tmc_corp_id = m.get('tmcCorpId')
        return self


class SyncBusinessSignInfoRequest(TeaModel):
    def __init__(
        self,
        biz_type_list: List[str] = None,
        gmt_org_pay: str = None,
        gmt_sign: str = None,
        org_pay_status: str = None,
        sign_status: str = None,
        target_corp_id: str = None,
        tmc_product_detail_list: List[SyncBusinessSignInfoRequestTmcProductDetailList] = None,
        tmc_product_list: List[SyncBusinessSignInfoRequestTmcProductList] = None,
    ):
        self.biz_type_list = biz_type_list
        self.gmt_org_pay = gmt_org_pay
        self.gmt_sign = gmt_sign
        self.org_pay_status = org_pay_status
        self.sign_status = sign_status
        self.target_corp_id = target_corp_id
        self.tmc_product_detail_list = tmc_product_detail_list
        self.tmc_product_list = tmc_product_list

    def validate(self):
        if self.tmc_product_detail_list:
            for k in self.tmc_product_detail_list:
                if k:
                    k.validate()
        if self.tmc_product_list:
            for k in self.tmc_product_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type_list is not None:
            result['bizTypeList'] = self.biz_type_list
        if self.gmt_org_pay is not None:
            result['gmtOrgPay'] = self.gmt_org_pay
        if self.gmt_sign is not None:
            result['gmtSign'] = self.gmt_sign
        if self.org_pay_status is not None:
            result['orgPayStatus'] = self.org_pay_status
        if self.sign_status is not None:
            result['signStatus'] = self.sign_status
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        result['tmcProductDetailList'] = []
        if self.tmc_product_detail_list is not None:
            for k in self.tmc_product_detail_list:
                result['tmcProductDetailList'].append(k.to_map() if k else None)
        result['tmcProductList'] = []
        if self.tmc_product_list is not None:
            for k in self.tmc_product_list:
                result['tmcProductList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizTypeList') is not None:
            self.biz_type_list = m.get('bizTypeList')
        if m.get('gmtOrgPay') is not None:
            self.gmt_org_pay = m.get('gmtOrgPay')
        if m.get('gmtSign') is not None:
            self.gmt_sign = m.get('gmtSign')
        if m.get('orgPayStatus') is not None:
            self.org_pay_status = m.get('orgPayStatus')
        if m.get('signStatus') is not None:
            self.sign_status = m.get('signStatus')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        self.tmc_product_detail_list = []
        if m.get('tmcProductDetailList') is not None:
            for k in m.get('tmcProductDetailList'):
                temp_model = SyncBusinessSignInfoRequestTmcProductDetailList()
                self.tmc_product_detail_list.append(temp_model.from_map(k))
        self.tmc_product_list = []
        if m.get('tmcProductList') is not None:
            for k in m.get('tmcProductList'):
                temp_model = SyncBusinessSignInfoRequestTmcProductList()
                self.tmc_product_list.append(temp_model.from_map(k))
        return self


class SyncBusinessSignInfoResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        success: bool = None,
    ):
        self.request_id = request_id
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


class SyncBusinessSignInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SyncBusinessSignInfoResponseBody = None,
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
            temp_model = SyncBusinessSignInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


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
        self.action_type = action_type
        self.secret_string = secret_string
        self.target_corp_id = target_corp_id
        self.trip_app_key = trip_app_key
        self.trip_app_security = trip_app_security
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
        self.secret_string = secret_string
        self.target_corp_id = target_corp_id
        self.trip_app_key = trip_app_key
        self.trip_app_security = trip_app_security
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
        status_code: int = None,
        body: SyncSecretKeyResponseBody = None,
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
        self.action = action
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
        self.lat = lat
        self.lon = lon
        self.source = source
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


class SyncTripOrderRequestOrderDetailsOpenConsumerInfo(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        name: str = None,
        staff_flag: bool = None,
        status: str = None,
        ticket_amount: str = None,
        ticket_no: str = None,
        user_id: str = None,
    ):
        self.corp_id = corp_id
        self.name = name
        self.staff_flag = staff_flag
        self.status = status
        self.ticket_amount = ticket_amount
        self.ticket_no = ticket_no
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.name is not None:
            result['name'] = self.name
        if self.staff_flag is not None:
            result['staffFlag'] = self.staff_flag
        if self.status is not None:
            result['status'] = self.status
        if self.ticket_amount is not None:
            result['ticketAmount'] = self.ticket_amount
        if self.ticket_no is not None:
            result['ticketNo'] = self.ticket_no
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('staffFlag') is not None:
            self.staff_flag = m.get('staffFlag')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('ticketAmount') is not None:
            self.ticket_amount = m.get('ticketAmount')
        if m.get('ticketNo') is not None:
            self.ticket_no = m.get('ticketNo')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SyncTripOrderRequestOrderDetails(TeaModel):
    def __init__(
        self,
        arrival_time: str = None,
        car_color: str = None,
        car_model: str = None,
        car_number: str = None,
        catering_type: str = None,
        check_in_time: str = None,
        check_out_time: str = None,
        depart_time: str = None,
        destination_city: str = None,
        destination_city_code: str = None,
        destination_station: str = None,
        detail_amount: str = None,
        hotel_address: str = None,
        hotel_city: str = None,
        hotel_location: SyncTripOrderRequestOrderDetailsHotelLocation = None,
        hotel_name: str = None,
        open_consumer_info: List[SyncTripOrderRequestOrderDetailsOpenConsumerInfo] = None,
        origin_city: str = None,
        origin_city_code: str = None,
        origin_station: str = None,
        room_count: int = None,
        seat_info: str = None,
        service_type: str = None,
        sub_supply_logo: str = None,
        sub_supply_name: str = None,
        taxi_type: str = None,
        telephone: str = None,
        transport_number: str = None,
        type_description: str = None,
    ):
        self.arrival_time = arrival_time
        self.car_color = car_color
        self.car_model = car_model
        self.car_number = car_number
        self.catering_type = catering_type
        self.check_in_time = check_in_time
        self.check_out_time = check_out_time
        self.depart_time = depart_time
        self.destination_city = destination_city
        self.destination_city_code = destination_city_code
        self.destination_station = destination_station
        self.detail_amount = detail_amount
        self.hotel_address = hotel_address
        self.hotel_city = hotel_city
        self.hotel_location = hotel_location
        self.hotel_name = hotel_name
        self.open_consumer_info = open_consumer_info
        self.origin_city = origin_city
        self.origin_city_code = origin_city_code
        self.origin_station = origin_station
        self.room_count = room_count
        self.seat_info = seat_info
        self.service_type = service_type
        self.sub_supply_logo = sub_supply_logo
        self.sub_supply_name = sub_supply_name
        self.taxi_type = taxi_type
        self.telephone = telephone
        self.transport_number = transport_number
        self.type_description = type_description

    def validate(self):
        if self.hotel_location:
            self.hotel_location.validate()
        if self.open_consumer_info:
            for k in self.open_consumer_info:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.arrival_time is not None:
            result['arrivalTime'] = self.arrival_time
        if self.car_color is not None:
            result['carColor'] = self.car_color
        if self.car_model is not None:
            result['carModel'] = self.car_model
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
        if self.destination_city is not None:
            result['destinationCity'] = self.destination_city
        if self.destination_city_code is not None:
            result['destinationCityCode'] = self.destination_city_code
        if self.destination_station is not None:
            result['destinationStation'] = self.destination_station
        if self.detail_amount is not None:
            result['detailAmount'] = self.detail_amount
        if self.hotel_address is not None:
            result['hotelAddress'] = self.hotel_address
        if self.hotel_city is not None:
            result['hotelCity'] = self.hotel_city
        if self.hotel_location is not None:
            result['hotelLocation'] = self.hotel_location.to_map()
        if self.hotel_name is not None:
            result['hotelName'] = self.hotel_name
        result['openConsumerInfo'] = []
        if self.open_consumer_info is not None:
            for k in self.open_consumer_info:
                result['openConsumerInfo'].append(k.to_map() if k else None)
        if self.origin_city is not None:
            result['originCity'] = self.origin_city
        if self.origin_city_code is not None:
            result['originCityCode'] = self.origin_city_code
        if self.origin_station is not None:
            result['originStation'] = self.origin_station
        if self.room_count is not None:
            result['roomCount'] = self.room_count
        if self.seat_info is not None:
            result['seatInfo'] = self.seat_info
        if self.service_type is not None:
            result['serviceType'] = self.service_type
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
        if m.get('carColor') is not None:
            self.car_color = m.get('carColor')
        if m.get('carModel') is not None:
            self.car_model = m.get('carModel')
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
        if m.get('destinationCity') is not None:
            self.destination_city = m.get('destinationCity')
        if m.get('destinationCityCode') is not None:
            self.destination_city_code = m.get('destinationCityCode')
        if m.get('destinationStation') is not None:
            self.destination_station = m.get('destinationStation')
        if m.get('detailAmount') is not None:
            self.detail_amount = m.get('detailAmount')
        if m.get('hotelAddress') is not None:
            self.hotel_address = m.get('hotelAddress')
        if m.get('hotelCity') is not None:
            self.hotel_city = m.get('hotelCity')
        if m.get('hotelLocation') is not None:
            temp_model = SyncTripOrderRequestOrderDetailsHotelLocation()
            self.hotel_location = temp_model.from_map(m['hotelLocation'])
        if m.get('hotelName') is not None:
            self.hotel_name = m.get('hotelName')
        self.open_consumer_info = []
        if m.get('openConsumerInfo') is not None:
            for k in m.get('openConsumerInfo'):
                temp_model = SyncTripOrderRequestOrderDetailsOpenConsumerInfo()
                self.open_consumer_info.append(temp_model.from_map(k))
        if m.get('originCity') is not None:
            self.origin_city = m.get('originCity')
        if m.get('originCityCode') is not None:
            self.origin_city_code = m.get('originCityCode')
        if m.get('originStation') is not None:
            self.origin_station = m.get('originStation')
        if m.get('roomCount') is not None:
            self.room_count = m.get('roomCount')
        if m.get('seatInfo') is not None:
            self.seat_info = m.get('seatInfo')
        if m.get('serviceType') is not None:
            self.service_type = m.get('serviceType')
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
        channel_type: str = None,
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
        process_id: str = None,
        real_amount: str = None,
        refund_amount: str = None,
        relative_order_no: str = None,
        source: str = None,
        supply_logo: str = None,
        supply_name: str = None,
        target_corp_id: str = None,
        tmc_corp_id: str = None,
        total_amount: str = None,
        type: str = None,
    ):
        self.channel_type = channel_type
        self.currency = currency
        self.ding_user_id = ding_user_id
        self.discount_amount = discount_amount
        self.endorse_flag = endorse_flag
        self.event = event
        self.gmt_order = gmt_order
        self.gmt_pay = gmt_pay
        self.gmt_refund = gmt_refund
        self.invoice_apply_url = invoice_apply_url
        self.journey_biz_no = journey_biz_no
        self.order_details = order_details
        self.order_no = order_no
        self.order_url = order_url
        self.process_id = process_id
        self.real_amount = real_amount
        self.refund_amount = refund_amount
        self.relative_order_no = relative_order_no
        self.source = source
        self.supply_logo = supply_logo
        self.supply_name = supply_name
        self.target_corp_id = target_corp_id
        self.tmc_corp_id = tmc_corp_id
        self.total_amount = total_amount
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
        if self.channel_type is not None:
            result['channelType'] = self.channel_type
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
        if self.process_id is not None:
            result['processId'] = self.process_id
        if self.real_amount is not None:
            result['realAmount'] = self.real_amount
        if self.refund_amount is not None:
            result['refundAmount'] = self.refund_amount
        if self.relative_order_no is not None:
            result['relativeOrderNo'] = self.relative_order_no
        if self.source is not None:
            result['source'] = self.source
        if self.supply_logo is not None:
            result['supplyLogo'] = self.supply_logo
        if self.supply_name is not None:
            result['supplyName'] = self.supply_name
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        if self.tmc_corp_id is not None:
            result['tmcCorpId'] = self.tmc_corp_id
        if self.total_amount is not None:
            result['totalAmount'] = self.total_amount
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('channelType') is not None:
            self.channel_type = m.get('channelType')
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
        if m.get('processId') is not None:
            self.process_id = m.get('processId')
        if m.get('realAmount') is not None:
            self.real_amount = m.get('realAmount')
        if m.get('refundAmount') is not None:
            self.refund_amount = m.get('refundAmount')
        if m.get('relativeOrderNo') is not None:
            self.relative_order_no = m.get('relativeOrderNo')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('supplyLogo') is not None:
            self.supply_logo = m.get('supplyLogo')
        if m.get('supplyName') is not None:
            self.supply_name = m.get('supplyName')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        if m.get('tmcCorpId') is not None:
            self.tmc_corp_id = m.get('tmcCorpId')
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
        self.request_id = request_id
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
        status_code: int = None,
        body: SyncTripOrderResponseBody = None,
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
            temp_model = SyncTripOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpgradeTemplateHeaders(TeaModel):
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


class UpgradeTemplateRequest(TeaModel):
    def __init__(
        self,
        channel_corp_id: str = None,
        force_upgrade: bool = None,
        tmc_corp_id: str = None,
    ):
        self.channel_corp_id = channel_corp_id
        self.force_upgrade = force_upgrade
        self.tmc_corp_id = tmc_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.channel_corp_id is not None:
            result['channelCorpId'] = self.channel_corp_id
        if self.force_upgrade is not None:
            result['forceUpgrade'] = self.force_upgrade
        if self.tmc_corp_id is not None:
            result['tmcCorpId'] = self.tmc_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('channelCorpId') is not None:
            self.channel_corp_id = m.get('channelCorpId')
        if m.get('forceUpgrade') is not None:
            self.force_upgrade = m.get('forceUpgrade')
        if m.get('tmcCorpId') is not None:
            self.tmc_corp_id = m.get('tmcCorpId')
        return self


class UpgradeTemplateResponseBodyResult(TeaModel):
    def __init__(
        self,
        upgrade_result: bool = None,
    ):
        self.upgrade_result = upgrade_result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.upgrade_result is not None:
            result['upgradeResult'] = self.upgrade_result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('upgradeResult') is not None:
            self.upgrade_result = m.get('upgradeResult')
        return self


class UpgradeTemplateResponseBody(TeaModel):
    def __init__(
        self,
        result: UpgradeTemplateResponseBodyResult = None,
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
            temp_model = UpgradeTemplateResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UpgradeTemplateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpgradeTemplateResponseBody = None,
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
            temp_model = UpgradeTemplateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


