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
        process_corp_id: str = None,
        process_instance_id: str = None,
    ):
        self.process_corp_id = process_corp_id
        # This parameter is required.
        self.process_instance_id = process_instance_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_corp_id is not None:
            result['processCorpId'] = self.process_corp_id
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processCorpId') is not None:
            self.process_corp_id = m.get('processCorpId')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        return self


class GetTravelProcessDetailResponseBodyResultExtFormComponent(TeaModel):
    def __init__(
        self,
        biz_alias: str = None,
        component_type: str = None,
        ext_value: str = None,
        id: str = None,
        name: str = None,
        value: str = None,
    ):
        self.biz_alias = biz_alias
        self.component_type = component_type
        self.ext_value = ext_value
        self.id = id
        self.name = name
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.component_type is not None:
            result['componentType'] = self.component_type
        if self.ext_value is not None:
            result['extValue'] = self.ext_value
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('componentType') is not None:
            self.component_type = m.get('componentType')
        if m.get('extValue') is not None:
            self.ext_value = m.get('extValue')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class GetTravelProcessDetailResponseBodyResultJourneysArrival(TeaModel):
    def __init__(
        self,
        code: str = None,
        country_code: str = None,
        country_name: str = None,
        name: str = None,
        national_city_code: str = None,
    ):
        self.code = code
        self.country_code = country_code
        self.country_name = country_name
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
        if self.country_code is not None:
            result['countryCode'] = self.country_code
        if self.country_name is not None:
            result['countryName'] = self.country_name
        if self.name is not None:
            result['name'] = self.name
        if self.national_city_code is not None:
            result['nationalCityCode'] = self.national_city_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('countryCode') is not None:
            self.country_code = m.get('countryCode')
        if m.get('countryName') is not None:
            self.country_name = m.get('countryName')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('nationalCityCode') is not None:
            self.national_city_code = m.get('nationalCityCode')
        return self


class GetTravelProcessDetailResponseBodyResultJourneysDeparture(TeaModel):
    def __init__(
        self,
        code: str = None,
        country_code: str = None,
        country_name: str = None,
        name: str = None,
        national_city_code: str = None,
    ):
        self.code = code
        self.country_code = country_code
        self.country_name = country_name
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
        if self.country_code is not None:
            result['countryCode'] = self.country_code
        if self.country_name is not None:
            result['countryName'] = self.country_name
        if self.name is not None:
            result['name'] = self.name
        if self.national_city_code is not None:
            result['nationalCityCode'] = self.national_city_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('countryCode') is not None:
            self.country_code = m.get('countryCode')
        if m.get('countryName') is not None:
            self.country_name = m.get('countryName')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('nationalCityCode') is not None:
            self.national_city_code = m.get('nationalCityCode')
        return self


class GetTravelProcessDetailResponseBodyResultJourneys(TeaModel):
    def __init__(
        self,
        arrival: GetTravelProcessDetailResponseBodyResultJourneysArrival = None,
        cost_center: str = None,
        cost_center_id: str = None,
        cost_center_third_party_id: str = None,
        departure: GetTravelProcessDetailResponseBodyResultJourneysDeparture = None,
        end_time: str = None,
        end_time_acc: str = None,
        invoice_title: str = None,
        invoice_title_id: str = None,
        invoice_title_third_party_id: str = None,
        itinerary_project: str = None,
        itinerary_project_id: str = None,
        itinerary_project_third_party_id: str = None,
        journey_biz_no: str = None,
        start_time: str = None,
        start_time_acc: str = None,
        time_unit: str = None,
        travel_type: str = None,
        trip_way: str = None,
    ):
        self.arrival = arrival
        self.cost_center = cost_center
        self.cost_center_id = cost_center_id
        self.cost_center_third_party_id = cost_center_third_party_id
        self.departure = departure
        self.end_time = end_time
        self.end_time_acc = end_time_acc
        self.invoice_title = invoice_title
        self.invoice_title_id = invoice_title_id
        self.invoice_title_third_party_id = invoice_title_third_party_id
        self.itinerary_project = itinerary_project
        self.itinerary_project_id = itinerary_project_id
        self.itinerary_project_third_party_id = itinerary_project_third_party_id
        self.journey_biz_no = journey_biz_no
        self.start_time = start_time
        self.start_time_acc = start_time_acc
        self.time_unit = time_unit
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
        if self.cost_center is not None:
            result['costCenter'] = self.cost_center
        if self.cost_center_id is not None:
            result['costCenterId'] = self.cost_center_id
        if self.cost_center_third_party_id is not None:
            result['costCenterThirdPartyId'] = self.cost_center_third_party_id
        if self.departure is not None:
            result['departure'] = self.departure.to_map()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.end_time_acc is not None:
            result['endTimeAcc'] = self.end_time_acc
        if self.invoice_title is not None:
            result['invoiceTitle'] = self.invoice_title
        if self.invoice_title_id is not None:
            result['invoiceTitleId'] = self.invoice_title_id
        if self.invoice_title_third_party_id is not None:
            result['invoiceTitleThirdPartyId'] = self.invoice_title_third_party_id
        if self.itinerary_project is not None:
            result['itineraryProject'] = self.itinerary_project
        if self.itinerary_project_id is not None:
            result['itineraryProjectId'] = self.itinerary_project_id
        if self.itinerary_project_third_party_id is not None:
            result['itineraryProjectThirdPartyId'] = self.itinerary_project_third_party_id
        if self.journey_biz_no is not None:
            result['journeyBizNo'] = self.journey_biz_no
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.start_time_acc is not None:
            result['startTimeAcc'] = self.start_time_acc
        if self.time_unit is not None:
            result['timeUnit'] = self.time_unit
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
        if m.get('costCenter') is not None:
            self.cost_center = m.get('costCenter')
        if m.get('costCenterId') is not None:
            self.cost_center_id = m.get('costCenterId')
        if m.get('costCenterThirdPartyId') is not None:
            self.cost_center_third_party_id = m.get('costCenterThirdPartyId')
        if m.get('departure') is not None:
            temp_model = GetTravelProcessDetailResponseBodyResultJourneysDeparture()
            self.departure = temp_model.from_map(m['departure'])
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('endTimeAcc') is not None:
            self.end_time_acc = m.get('endTimeAcc')
        if m.get('invoiceTitle') is not None:
            self.invoice_title = m.get('invoiceTitle')
        if m.get('invoiceTitleId') is not None:
            self.invoice_title_id = m.get('invoiceTitleId')
        if m.get('invoiceTitleThirdPartyId') is not None:
            self.invoice_title_third_party_id = m.get('invoiceTitleThirdPartyId')
        if m.get('itineraryProject') is not None:
            self.itinerary_project = m.get('itineraryProject')
        if m.get('itineraryProjectId') is not None:
            self.itinerary_project_id = m.get('itineraryProjectId')
        if m.get('itineraryProjectThirdPartyId') is not None:
            self.itinerary_project_third_party_id = m.get('itineraryProjectThirdPartyId')
        if m.get('journeyBizNo') is not None:
            self.journey_biz_no = m.get('journeyBizNo')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('startTimeAcc') is not None:
            self.start_time_acc = m.get('startTimeAcc')
        if m.get('timeUnit') is not None:
            self.time_unit = m.get('timeUnit')
        if m.get('travelType') is not None:
            self.travel_type = m.get('travelType')
        if m.get('tripWay') is not None:
            self.trip_way = m.get('tripWay')
        return self


class GetTravelProcessDetailResponseBodyResultTasks(TeaModel):
    def __init__(
        self,
        activity_id: str = None,
        create_time: str = None,
        finish_time: str = None,
        origin_user_id: str = None,
        process_instance_id: str = None,
        result: str = None,
        status: str = None,
        task_id: int = None,
        url: str = None,
        user_id: str = None,
    ):
        self.activity_id = activity_id
        self.create_time = create_time
        self.finish_time = finish_time
        self.origin_user_id = origin_user_id
        self.process_instance_id = process_instance_id
        self.result = result
        self.status = status
        self.task_id = task_id
        self.url = url
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.finish_time is not None:
            result['finishTime'] = self.finish_time
        if self.origin_user_id is not None:
            result['originUserId'] = self.origin_user_id
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.result is not None:
            result['result'] = self.result
        if self.status is not None:
            result['status'] = self.status
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.url is not None:
            result['url'] = self.url
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('finishTime') is not None:
            self.finish_time = m.get('finishTime')
        if m.get('originUserId') is not None:
            self.origin_user_id = m.get('originUserId')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetTravelProcessDetailResponseBodyResult(TeaModel):
    def __init__(
        self,
        archive_time: str = None,
        biz_category_id: str = None,
        business_id: str = None,
        corp_id: str = None,
        cost_center: str = None,
        cost_center_id: str = None,
        cost_center_third_party_id: str = None,
        create_time: str = None,
        ext_form_component: List[GetTravelProcessDetailResponseBodyResultExtFormComponent] = None,
        fee_type: str = None,
        invoice_title: str = None,
        invoice_title_id: str = None,
        invoice_title_third_party_id: str = None,
        itinerary_project: str = None,
        itinerary_project_third_party_id: str = None,
        journeys: List[GetTravelProcessDetailResponseBodyResultJourneys] = None,
        main_process_instance_id: str = None,
        memo: str = None,
        originator_id: str = None,
        originator_id_on_behalf: str = None,
        process_instance_id: str = None,
        process_result: str = None,
        process_status: str = None,
        remark: str = None,
        tasks: List[GetTravelProcessDetailResponseBodyResultTasks] = None,
        travel_category: str = None,
        travelers: List[str] = None,
        trip_days: str = None,
    ):
        self.archive_time = archive_time
        self.biz_category_id = biz_category_id
        self.business_id = business_id
        self.corp_id = corp_id
        self.cost_center = cost_center
        self.cost_center_id = cost_center_id
        self.cost_center_third_party_id = cost_center_third_party_id
        self.create_time = create_time
        self.ext_form_component = ext_form_component
        self.fee_type = fee_type
        self.invoice_title = invoice_title
        self.invoice_title_id = invoice_title_id
        self.invoice_title_third_party_id = invoice_title_third_party_id
        self.itinerary_project = itinerary_project
        self.itinerary_project_third_party_id = itinerary_project_third_party_id
        self.journeys = journeys
        self.main_process_instance_id = main_process_instance_id
        self.memo = memo
        self.originator_id = originator_id
        self.originator_id_on_behalf = originator_id_on_behalf
        self.process_instance_id = process_instance_id
        self.process_result = process_result
        self.process_status = process_status
        self.remark = remark
        self.tasks = tasks
        self.travel_category = travel_category
        self.travelers = travelers
        self.trip_days = trip_days

    def validate(self):
        if self.ext_form_component:
            for k in self.ext_form_component:
                if k:
                    k.validate()
        if self.journeys:
            for k in self.journeys:
                if k:
                    k.validate()
        if self.tasks:
            for k in self.tasks:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.archive_time is not None:
            result['archiveTime'] = self.archive_time
        if self.biz_category_id is not None:
            result['bizCategoryId'] = self.biz_category_id
        if self.business_id is not None:
            result['businessId'] = self.business_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.cost_center is not None:
            result['costCenter'] = self.cost_center
        if self.cost_center_id is not None:
            result['costCenterId'] = self.cost_center_id
        if self.cost_center_third_party_id is not None:
            result['costCenterThirdPartyId'] = self.cost_center_third_party_id
        if self.create_time is not None:
            result['createTime'] = self.create_time
        result['extFormComponent'] = []
        if self.ext_form_component is not None:
            for k in self.ext_form_component:
                result['extFormComponent'].append(k.to_map() if k else None)
        if self.fee_type is not None:
            result['feeType'] = self.fee_type
        if self.invoice_title is not None:
            result['invoiceTitle'] = self.invoice_title
        if self.invoice_title_id is not None:
            result['invoiceTitleId'] = self.invoice_title_id
        if self.invoice_title_third_party_id is not None:
            result['invoiceTitleThirdPartyId'] = self.invoice_title_third_party_id
        if self.itinerary_project is not None:
            result['itineraryProject'] = self.itinerary_project
        if self.itinerary_project_third_party_id is not None:
            result['itineraryProjectThirdPartyId'] = self.itinerary_project_third_party_id
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
        if self.originator_id_on_behalf is not None:
            result['originatorIdOnBehalf'] = self.originator_id_on_behalf
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.process_result is not None:
            result['processResult'] = self.process_result
        if self.process_status is not None:
            result['processStatus'] = self.process_status
        if self.remark is not None:
            result['remark'] = self.remark
        result['tasks'] = []
        if self.tasks is not None:
            for k in self.tasks:
                result['tasks'].append(k.to_map() if k else None)
        if self.travel_category is not None:
            result['travelCategory'] = self.travel_category
        if self.travelers is not None:
            result['travelers'] = self.travelers
        if self.trip_days is not None:
            result['tripDays'] = self.trip_days
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('archiveTime') is not None:
            self.archive_time = m.get('archiveTime')
        if m.get('bizCategoryId') is not None:
            self.biz_category_id = m.get('bizCategoryId')
        if m.get('businessId') is not None:
            self.business_id = m.get('businessId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('costCenter') is not None:
            self.cost_center = m.get('costCenter')
        if m.get('costCenterId') is not None:
            self.cost_center_id = m.get('costCenterId')
        if m.get('costCenterThirdPartyId') is not None:
            self.cost_center_third_party_id = m.get('costCenterThirdPartyId')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        self.ext_form_component = []
        if m.get('extFormComponent') is not None:
            for k in m.get('extFormComponent'):
                temp_model = GetTravelProcessDetailResponseBodyResultExtFormComponent()
                self.ext_form_component.append(temp_model.from_map(k))
        if m.get('feeType') is not None:
            self.fee_type = m.get('feeType')
        if m.get('invoiceTitle') is not None:
            self.invoice_title = m.get('invoiceTitle')
        if m.get('invoiceTitleId') is not None:
            self.invoice_title_id = m.get('invoiceTitleId')
        if m.get('invoiceTitleThirdPartyId') is not None:
            self.invoice_title_third_party_id = m.get('invoiceTitleThirdPartyId')
        if m.get('itineraryProject') is not None:
            self.itinerary_project = m.get('itineraryProject')
        if m.get('itineraryProjectThirdPartyId') is not None:
            self.itinerary_project_third_party_id = m.get('itineraryProjectThirdPartyId')
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
        if m.get('originatorIdOnBehalf') is not None:
            self.originator_id_on_behalf = m.get('originatorIdOnBehalf')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('processResult') is not None:
            self.process_result = m.get('processResult')
        if m.get('processStatus') is not None:
            self.process_status = m.get('processStatus')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        self.tasks = []
        if m.get('tasks') is not None:
            for k in m.get('tasks'):
                temp_model = GetTravelProcessDetailResponseBodyResultTasks()
                self.tasks.append(temp_model.from_map(k))
        if m.get('travelCategory') is not None:
            self.travel_category = m.get('travelCategory')
        if m.get('travelers') is not None:
            self.travelers = m.get('travelers')
        if m.get('tripDays') is not None:
            self.trip_days = m.get('tripDays')
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
        # This parameter is required.
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
        # This parameter is required.
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
        # This parameter is required.
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
        # This parameter is required.
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
        # This parameter is required.
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
        # This parameter is required.
        self.org_pay_status = org_pay_status
        # This parameter is required.
        self.sign_status = sign_status
        # This parameter is required.
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


class SyncCostCenterHeaders(TeaModel):
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


class SyncCostCenterRequest(TeaModel):
    def __init__(
        self,
        channel_corp_id: str = None,
        cost_center_id: str = None,
        delete_flag: bool = None,
        extension: str = None,
        gmt_action: str = None,
        number: str = None,
        scope: int = None,
        source: str = None,
        third_part_id: str = None,
        title: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.channel_corp_id = channel_corp_id
        # This parameter is required.
        self.cost_center_id = cost_center_id
        self.delete_flag = delete_flag
        self.extension = extension
        # This parameter is required.
        self.gmt_action = gmt_action
        self.number = number
        self.scope = scope
        self.source = source
        self.third_part_id = third_part_id
        # This parameter is required.
        self.title = title
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.channel_corp_id is not None:
            result['channelCorpId'] = self.channel_corp_id
        if self.cost_center_id is not None:
            result['costCenterId'] = self.cost_center_id
        if self.delete_flag is not None:
            result['deleteFlag'] = self.delete_flag
        if self.extension is not None:
            result['extension'] = self.extension
        if self.gmt_action is not None:
            result['gmtAction'] = self.gmt_action
        if self.number is not None:
            result['number'] = self.number
        if self.scope is not None:
            result['scope'] = self.scope
        if self.source is not None:
            result['source'] = self.source
        if self.third_part_id is not None:
            result['thirdPartId'] = self.third_part_id
        if self.title is not None:
            result['title'] = self.title
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('channelCorpId') is not None:
            self.channel_corp_id = m.get('channelCorpId')
        if m.get('costCenterId') is not None:
            self.cost_center_id = m.get('costCenterId')
        if m.get('deleteFlag') is not None:
            self.delete_flag = m.get('deleteFlag')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('gmtAction') is not None:
            self.gmt_action = m.get('gmtAction')
        if m.get('number') is not None:
            self.number = m.get('number')
        if m.get('scope') is not None:
            self.scope = m.get('scope')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('thirdPartId') is not None:
            self.third_part_id = m.get('thirdPartId')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SyncCostCenterResponseBody(TeaModel):
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


class SyncCostCenterResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SyncCostCenterResponseBody = None,
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
            temp_model = SyncCostCenterResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SyncCostCenterEntityHeaders(TeaModel):
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


class SyncCostCenterEntityRequestEntityList(TeaModel):
    def __init__(
        self,
        entity_id: str = None,
        entity_type: str = None,
    ):
        # This parameter is required.
        self.entity_id = entity_id
        # This parameter is required.
        self.entity_type = entity_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.entity_id is not None:
            result['entityId'] = self.entity_id
        if self.entity_type is not None:
            result['entityType'] = self.entity_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('entityId') is not None:
            self.entity_id = m.get('entityId')
        if m.get('entityType') is not None:
            self.entity_type = m.get('entityType')
        return self


class SyncCostCenterEntityRequest(TeaModel):
    def __init__(
        self,
        channel_corp_id: str = None,
        cost_center_id: str = None,
        del_all: bool = None,
        entity_list: List[SyncCostCenterEntityRequestEntityList] = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.channel_corp_id = channel_corp_id
        # This parameter is required.
        self.cost_center_id = cost_center_id
        self.del_all = del_all
        self.entity_list = entity_list
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        if self.entity_list:
            for k in self.entity_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.channel_corp_id is not None:
            result['channelCorpId'] = self.channel_corp_id
        if self.cost_center_id is not None:
            result['costCenterId'] = self.cost_center_id
        if self.del_all is not None:
            result['delAll'] = self.del_all
        result['entityList'] = []
        if self.entity_list is not None:
            for k in self.entity_list:
                result['entityList'].append(k.to_map() if k else None)
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('channelCorpId') is not None:
            self.channel_corp_id = m.get('channelCorpId')
        if m.get('costCenterId') is not None:
            self.cost_center_id = m.get('costCenterId')
        if m.get('delAll') is not None:
            self.del_all = m.get('delAll')
        self.entity_list = []
        if m.get('entityList') is not None:
            for k in m.get('entityList'):
                temp_model = SyncCostCenterEntityRequestEntityList()
                self.entity_list.append(temp_model.from_map(k))
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SyncCostCenterEntityResponseBody(TeaModel):
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


class SyncCostCenterEntityResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SyncCostCenterEntityResponseBody = None,
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
            temp_model = SyncCostCenterEntityResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SyncInvoiceHeaders(TeaModel):
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


class SyncInvoiceRequest(TeaModel):
    def __init__(
        self,
        address: str = None,
        bank_name: str = None,
        bank_no: str = None,
        channel_corp_id: str = None,
        delete_flag: bool = None,
        gmt_action: str = None,
        invoice_id: str = None,
        project_ids: List[str] = None,
        scope: int = None,
        source: str = None,
        tax_no: str = None,
        tel: str = None,
        third_part_id: str = None,
        title: str = None,
        type: int = None,
        unit_type: int = None,
        user_id: str = None,
    ):
        self.address = address
        self.bank_name = bank_name
        self.bank_no = bank_no
        # This parameter is required.
        self.channel_corp_id = channel_corp_id
        self.delete_flag = delete_flag
        # This parameter is required.
        self.gmt_action = gmt_action
        # This parameter is required.
        self.invoice_id = invoice_id
        self.project_ids = project_ids
        self.scope = scope
        self.source = source
        self.tax_no = tax_no
        self.tel = tel
        self.third_part_id = third_part_id
        # This parameter is required.
        self.title = title
        self.type = type
        self.unit_type = unit_type
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.address is not None:
            result['address'] = self.address
        if self.bank_name is not None:
            result['bankName'] = self.bank_name
        if self.bank_no is not None:
            result['bankNo'] = self.bank_no
        if self.channel_corp_id is not None:
            result['channelCorpId'] = self.channel_corp_id
        if self.delete_flag is not None:
            result['deleteFlag'] = self.delete_flag
        if self.gmt_action is not None:
            result['gmtAction'] = self.gmt_action
        if self.invoice_id is not None:
            result['invoiceId'] = self.invoice_id
        if self.project_ids is not None:
            result['projectIds'] = self.project_ids
        if self.scope is not None:
            result['scope'] = self.scope
        if self.source is not None:
            result['source'] = self.source
        if self.tax_no is not None:
            result['taxNo'] = self.tax_no
        if self.tel is not None:
            result['tel'] = self.tel
        if self.third_part_id is not None:
            result['thirdPartId'] = self.third_part_id
        if self.title is not None:
            result['title'] = self.title
        if self.type is not None:
            result['type'] = self.type
        if self.unit_type is not None:
            result['unitType'] = self.unit_type
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('address') is not None:
            self.address = m.get('address')
        if m.get('bankName') is not None:
            self.bank_name = m.get('bankName')
        if m.get('bankNo') is not None:
            self.bank_no = m.get('bankNo')
        if m.get('channelCorpId') is not None:
            self.channel_corp_id = m.get('channelCorpId')
        if m.get('deleteFlag') is not None:
            self.delete_flag = m.get('deleteFlag')
        if m.get('gmtAction') is not None:
            self.gmt_action = m.get('gmtAction')
        if m.get('invoiceId') is not None:
            self.invoice_id = m.get('invoiceId')
        if m.get('projectIds') is not None:
            self.project_ids = m.get('projectIds')
        if m.get('scope') is not None:
            self.scope = m.get('scope')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('taxNo') is not None:
            self.tax_no = m.get('taxNo')
        if m.get('tel') is not None:
            self.tel = m.get('tel')
        if m.get('thirdPartId') is not None:
            self.third_part_id = m.get('thirdPartId')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('unitType') is not None:
            self.unit_type = m.get('unitType')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SyncInvoiceResponseBody(TeaModel):
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


class SyncInvoiceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SyncInvoiceResponseBody = None,
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
            temp_model = SyncInvoiceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SyncInvoiceEntityHeaders(TeaModel):
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


class SyncInvoiceEntityRequestEntityList(TeaModel):
    def __init__(
        self,
        entity_id: str = None,
        entity_type: str = None,
    ):
        # This parameter is required.
        self.entity_id = entity_id
        # This parameter is required.
        self.entity_type = entity_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.entity_id is not None:
            result['entityId'] = self.entity_id
        if self.entity_type is not None:
            result['entityType'] = self.entity_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('entityId') is not None:
            self.entity_id = m.get('entityId')
        if m.get('entityType') is not None:
            self.entity_type = m.get('entityType')
        return self


class SyncInvoiceEntityRequest(TeaModel):
    def __init__(
        self,
        channel_corp_id: str = None,
        del_all: bool = None,
        entity_list: List[SyncInvoiceEntityRequestEntityList] = None,
        invoice_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.channel_corp_id = channel_corp_id
        self.del_all = del_all
        self.entity_list = entity_list
        # This parameter is required.
        self.invoice_id = invoice_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        if self.entity_list:
            for k in self.entity_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.channel_corp_id is not None:
            result['channelCorpId'] = self.channel_corp_id
        if self.del_all is not None:
            result['delAll'] = self.del_all
        result['entityList'] = []
        if self.entity_list is not None:
            for k in self.entity_list:
                result['entityList'].append(k.to_map() if k else None)
        if self.invoice_id is not None:
            result['invoiceId'] = self.invoice_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('channelCorpId') is not None:
            self.channel_corp_id = m.get('channelCorpId')
        if m.get('delAll') is not None:
            self.del_all = m.get('delAll')
        self.entity_list = []
        if m.get('entityList') is not None:
            for k in m.get('entityList'):
                temp_model = SyncInvoiceEntityRequestEntityList()
                self.entity_list.append(temp_model.from_map(k))
        if m.get('invoiceId') is not None:
            self.invoice_id = m.get('invoiceId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SyncInvoiceEntityResponseBody(TeaModel):
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


class SyncInvoiceEntityResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SyncInvoiceEntityResponseBody = None,
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
            temp_model = SyncInvoiceEntityResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SyncProjectHeaders(TeaModel):
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


class SyncProjectRequest(TeaModel):
    def __init__(
        self,
        channel_corp_id: str = None,
        code: str = None,
        cost_center_id: str = None,
        delete_flag: bool = None,
        extension: str = None,
        gmt_action: str = None,
        invoice_id: str = None,
        manager_ids: List[str] = None,
        project_id: str = None,
        project_name: str = None,
        scope: int = None,
        source: str = None,
        third_part_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.channel_corp_id = channel_corp_id
        self.code = code
        self.cost_center_id = cost_center_id
        self.delete_flag = delete_flag
        self.extension = extension
        # This parameter is required.
        self.gmt_action = gmt_action
        self.invoice_id = invoice_id
        self.manager_ids = manager_ids
        # This parameter is required.
        self.project_id = project_id
        # This parameter is required.
        self.project_name = project_name
        self.scope = scope
        self.source = source
        self.third_part_id = third_part_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.channel_corp_id is not None:
            result['channelCorpId'] = self.channel_corp_id
        if self.code is not None:
            result['code'] = self.code
        if self.cost_center_id is not None:
            result['costCenterId'] = self.cost_center_id
        if self.delete_flag is not None:
            result['deleteFlag'] = self.delete_flag
        if self.extension is not None:
            result['extension'] = self.extension
        if self.gmt_action is not None:
            result['gmtAction'] = self.gmt_action
        if self.invoice_id is not None:
            result['invoiceId'] = self.invoice_id
        if self.manager_ids is not None:
            result['managerIds'] = self.manager_ids
        if self.project_id is not None:
            result['projectId'] = self.project_id
        if self.project_name is not None:
            result['projectName'] = self.project_name
        if self.scope is not None:
            result['scope'] = self.scope
        if self.source is not None:
            result['source'] = self.source
        if self.third_part_id is not None:
            result['thirdPartId'] = self.third_part_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('channelCorpId') is not None:
            self.channel_corp_id = m.get('channelCorpId')
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('costCenterId') is not None:
            self.cost_center_id = m.get('costCenterId')
        if m.get('deleteFlag') is not None:
            self.delete_flag = m.get('deleteFlag')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('gmtAction') is not None:
            self.gmt_action = m.get('gmtAction')
        if m.get('invoiceId') is not None:
            self.invoice_id = m.get('invoiceId')
        if m.get('managerIds') is not None:
            self.manager_ids = m.get('managerIds')
        if m.get('projectId') is not None:
            self.project_id = m.get('projectId')
        if m.get('projectName') is not None:
            self.project_name = m.get('projectName')
        if m.get('scope') is not None:
            self.scope = m.get('scope')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('thirdPartId') is not None:
            self.third_part_id = m.get('thirdPartId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SyncProjectResponseBody(TeaModel):
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


class SyncProjectResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SyncProjectResponseBody = None,
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
            temp_model = SyncProjectResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SyncProjectEntityHeaders(TeaModel):
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


class SyncProjectEntityRequestEntityList(TeaModel):
    def __init__(
        self,
        entity_id: str = None,
        entity_type: str = None,
    ):
        # This parameter is required.
        self.entity_id = entity_id
        # This parameter is required.
        self.entity_type = entity_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.entity_id is not None:
            result['entityId'] = self.entity_id
        if self.entity_type is not None:
            result['entityType'] = self.entity_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('entityId') is not None:
            self.entity_id = m.get('entityId')
        if m.get('entityType') is not None:
            self.entity_type = m.get('entityType')
        return self


class SyncProjectEntityRequest(TeaModel):
    def __init__(
        self,
        channel_corp_id: str = None,
        del_all: bool = None,
        entity_list: List[SyncProjectEntityRequestEntityList] = None,
        project_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.channel_corp_id = channel_corp_id
        self.del_all = del_all
        self.entity_list = entity_list
        # This parameter is required.
        self.project_id = project_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        if self.entity_list:
            for k in self.entity_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.channel_corp_id is not None:
            result['channelCorpId'] = self.channel_corp_id
        if self.del_all is not None:
            result['delAll'] = self.del_all
        result['entityList'] = []
        if self.entity_list is not None:
            for k in self.entity_list:
                result['entityList'].append(k.to_map() if k else None)
        if self.project_id is not None:
            result['projectId'] = self.project_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('channelCorpId') is not None:
            self.channel_corp_id = m.get('channelCorpId')
        if m.get('delAll') is not None:
            self.del_all = m.get('delAll')
        self.entity_list = []
        if m.get('entityList') is not None:
            for k in m.get('entityList'):
                temp_model = SyncProjectEntityRequestEntityList()
                self.entity_list.append(temp_model.from_map(k))
        if m.get('projectId') is not None:
            self.project_id = m.get('projectId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SyncProjectEntityResponseBody(TeaModel):
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


class SyncProjectEntityResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SyncProjectEntityResponseBody = None,
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
            temp_model = SyncProjectEntityResponseBody()
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
        # This parameter is required.
        self.action_type = action_type
        self.secret_string = secret_string
        # This parameter is required.
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
        # This parameter is required.
        self.action = action
        # This parameter is required.
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
        destination_terminal_building: str = None,
        detail_amount: str = None,
        hotel_address: str = None,
        hotel_city: str = None,
        hotel_location: SyncTripOrderRequestOrderDetailsHotelLocation = None,
        hotel_name: str = None,
        open_consumer_info: List[SyncTripOrderRequestOrderDetailsOpenConsumerInfo] = None,
        origin_city: str = None,
        origin_city_code: str = None,
        origin_station: str = None,
        origin_terminal_building: str = None,
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
        self.destination_terminal_building = destination_terminal_building
        self.detail_amount = detail_amount
        self.hotel_address = hotel_address
        self.hotel_city = hotel_city
        self.hotel_location = hotel_location
        self.hotel_name = hotel_name
        self.open_consumer_info = open_consumer_info
        self.origin_city = origin_city
        self.origin_city_code = origin_city_code
        self.origin_station = origin_station
        self.origin_terminal_building = origin_terminal_building
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
        if self.destination_terminal_building is not None:
            result['destinationTerminalBuilding'] = self.destination_terminal_building
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
        if self.origin_terminal_building is not None:
            result['originTerminalBuilding'] = self.origin_terminal_building
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
        if m.get('destinationTerminalBuilding') is not None:
            self.destination_terminal_building = m.get('destinationTerminalBuilding')
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
        if m.get('originTerminalBuilding') is not None:
            self.origin_terminal_building = m.get('originTerminalBuilding')
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
        biz_extension: str = None,
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
        self.biz_extension = biz_extension
        self.channel_type = channel_type
        # This parameter is required.
        self.currency = currency
        # This parameter is required.
        self.ding_user_id = ding_user_id
        self.discount_amount = discount_amount
        self.endorse_flag = endorse_flag
        # This parameter is required.
        self.event = event
        # This parameter is required.
        self.gmt_order = gmt_order
        self.gmt_pay = gmt_pay
        self.gmt_refund = gmt_refund
        self.invoice_apply_url = invoice_apply_url
        self.journey_biz_no = journey_biz_no
        self.order_details = order_details
        # This parameter is required.
        self.order_no = order_no
        # This parameter is required.
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
        # This parameter is required.
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
        if self.biz_extension is not None:
            result['bizExtension'] = self.biz_extension
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
        if m.get('bizExtension') is not None:
            self.biz_extension = m.get('bizExtension')
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


class SyncTripProductConfigHeaders(TeaModel):
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


class SyncTripProductConfigRequestTripProductConfigListTmcInfos(TeaModel):
    def __init__(
        self,
        category_type: str = None,
        gmt_org_pay: str = None,
        pay_type: str = None,
        tmc_corp_id: str = None,
    ):
        self.category_type = category_type
        self.gmt_org_pay = gmt_org_pay
        self.pay_type = pay_type
        self.tmc_corp_id = tmc_corp_id

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
        if self.pay_type is not None:
            result['payType'] = self.pay_type
        if self.tmc_corp_id is not None:
            result['tmcCorpId'] = self.tmc_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('categoryType') is not None:
            self.category_type = m.get('categoryType')
        if m.get('gmtOrgPay') is not None:
            self.gmt_org_pay = m.get('gmtOrgPay')
        if m.get('payType') is not None:
            self.pay_type = m.get('payType')
        if m.get('tmcCorpId') is not None:
            self.tmc_corp_id = m.get('tmcCorpId')
        return self


class SyncTripProductConfigRequestTripProductConfigList(TeaModel):
    def __init__(
        self,
        all_visible: bool = None,
        dept_visible_scopes: List[str] = None,
        open_status: bool = None,
        product_type: str = None,
        role_visible_scopes: List[str] = None,
        staff_visible_scopes: List[str] = None,
        tmc_infos: List[SyncTripProductConfigRequestTripProductConfigListTmcInfos] = None,
    ):
        self.all_visible = all_visible
        self.dept_visible_scopes = dept_visible_scopes
        self.open_status = open_status
        self.product_type = product_type
        self.role_visible_scopes = role_visible_scopes
        self.staff_visible_scopes = staff_visible_scopes
        self.tmc_infos = tmc_infos

    def validate(self):
        if self.tmc_infos:
            for k in self.tmc_infos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.all_visible is not None:
            result['allVisible'] = self.all_visible
        if self.dept_visible_scopes is not None:
            result['deptVisibleScopes'] = self.dept_visible_scopes
        if self.open_status is not None:
            result['openStatus'] = self.open_status
        if self.product_type is not None:
            result['productType'] = self.product_type
        if self.role_visible_scopes is not None:
            result['roleVisibleScopes'] = self.role_visible_scopes
        if self.staff_visible_scopes is not None:
            result['staffVisibleScopes'] = self.staff_visible_scopes
        result['tmcInfos'] = []
        if self.tmc_infos is not None:
            for k in self.tmc_infos:
                result['tmcInfos'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('allVisible') is not None:
            self.all_visible = m.get('allVisible')
        if m.get('deptVisibleScopes') is not None:
            self.dept_visible_scopes = m.get('deptVisibleScopes')
        if m.get('openStatus') is not None:
            self.open_status = m.get('openStatus')
        if m.get('productType') is not None:
            self.product_type = m.get('productType')
        if m.get('roleVisibleScopes') is not None:
            self.role_visible_scopes = m.get('roleVisibleScopes')
        if m.get('staffVisibleScopes') is not None:
            self.staff_visible_scopes = m.get('staffVisibleScopes')
        self.tmc_infos = []
        if m.get('tmcInfos') is not None:
            for k in m.get('tmcInfos'):
                temp_model = SyncTripProductConfigRequestTripProductConfigListTmcInfos()
                self.tmc_infos.append(temp_model.from_map(k))
        return self


class SyncTripProductConfigRequest(TeaModel):
    def __init__(
        self,
        target_corp_id: str = None,
        trip_product_config_list: List[SyncTripProductConfigRequestTripProductConfigList] = None,
    ):
        self.target_corp_id = target_corp_id
        self.trip_product_config_list = trip_product_config_list

    def validate(self):
        if self.trip_product_config_list:
            for k in self.trip_product_config_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        result['tripProductConfigList'] = []
        if self.trip_product_config_list is not None:
            for k in self.trip_product_config_list:
                result['tripProductConfigList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        self.trip_product_config_list = []
        if m.get('tripProductConfigList') is not None:
            for k in m.get('tripProductConfigList'):
                temp_model = SyncTripProductConfigRequestTripProductConfigList()
                self.trip_product_config_list.append(temp_model.from_map(k))
        return self


class SyncTripProductConfigResponseBody(TeaModel):
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


class SyncTripProductConfigResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SyncTripProductConfigResponseBody = None,
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
            temp_model = SyncTripProductConfigResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class TripPlatformUnifiedEntryHeaders(TeaModel):
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


class TripPlatformUnifiedEntryRequest(TeaModel):
    def __init__(
        self,
        messages: str = None,
        method: str = None,
    ):
        self.messages = messages
        # This parameter is required.
        self.method = method

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.messages is not None:
            result['messages'] = self.messages
        if self.method is not None:
            result['method'] = self.method
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('messages') is not None:
            self.messages = m.get('messages')
        if m.get('method') is not None:
            self.method = m.get('method')
        return self


class TripPlatformUnifiedEntryResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: str = None,
        success: bool = None,
    ):
        self.request_id = request_id
        self.result = result
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
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class TripPlatformUnifiedEntryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: TripPlatformUnifiedEntryResponseBody = None,
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
            temp_model = TripPlatformUnifiedEntryResponseBody()
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
        # This parameter is required.
        self.channel_corp_id = channel_corp_id
        self.force_upgrade = force_upgrade
        # This parameter is required.
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


