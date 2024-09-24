# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class ResultValue(TeaModel):
    def __init__(
        self,
        status: str = None,
    ):
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class AddHrmLegalEntityHeaders(TeaModel):
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


class AddHrmLegalEntityRequestExtManageAddress(TeaModel):
    def __init__(
        self,
        area_code: str = None,
        area_name: str = None,
        city_code: str = None,
        city_name: str = None,
        country_code: str = None,
        country_name: str = None,
        detail_address: str = None,
        global_area_type: str = None,
        province_code: str = None,
        province_name: str = None,
    ):
        self.area_code = area_code
        self.area_name = area_name
        self.city_code = city_code
        self.city_name = city_name
        self.country_code = country_code
        self.country_name = country_name
        self.detail_address = detail_address
        self.global_area_type = global_area_type
        self.province_code = province_code
        self.province_name = province_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.area_code is not None:
            result['areaCode'] = self.area_code
        if self.area_name is not None:
            result['areaName'] = self.area_name
        if self.city_code is not None:
            result['cityCode'] = self.city_code
        if self.city_name is not None:
            result['cityName'] = self.city_name
        if self.country_code is not None:
            result['countryCode'] = self.country_code
        if self.country_name is not None:
            result['countryName'] = self.country_name
        if self.detail_address is not None:
            result['detailAddress'] = self.detail_address
        if self.global_area_type is not None:
            result['globalAreaType'] = self.global_area_type
        if self.province_code is not None:
            result['provinceCode'] = self.province_code
        if self.province_name is not None:
            result['provinceName'] = self.province_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('areaCode') is not None:
            self.area_code = m.get('areaCode')
        if m.get('areaName') is not None:
            self.area_name = m.get('areaName')
        if m.get('cityCode') is not None:
            self.city_code = m.get('cityCode')
        if m.get('cityName') is not None:
            self.city_name = m.get('cityName')
        if m.get('countryCode') is not None:
            self.country_code = m.get('countryCode')
        if m.get('countryName') is not None:
            self.country_name = m.get('countryName')
        if m.get('detailAddress') is not None:
            self.detail_address = m.get('detailAddress')
        if m.get('globalAreaType') is not None:
            self.global_area_type = m.get('globalAreaType')
        if m.get('provinceCode') is not None:
            self.province_code = m.get('provinceCode')
        if m.get('provinceName') is not None:
            self.province_name = m.get('provinceName')
        return self


class AddHrmLegalEntityRequestExtRegistrationAddress(TeaModel):
    def __init__(
        self,
        area_code: str = None,
        area_name: str = None,
        city_code: str = None,
        city_name: str = None,
        country_code: str = None,
        country_name: str = None,
        detail_address: str = None,
        global_area_type: str = None,
        province_code: str = None,
        province_name: str = None,
    ):
        self.area_code = area_code
        self.area_name = area_name
        self.city_code = city_code
        self.city_name = city_name
        self.country_code = country_code
        self.country_name = country_name
        self.detail_address = detail_address
        self.global_area_type = global_area_type
        self.province_code = province_code
        self.province_name = province_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.area_code is not None:
            result['areaCode'] = self.area_code
        if self.area_name is not None:
            result['areaName'] = self.area_name
        if self.city_code is not None:
            result['cityCode'] = self.city_code
        if self.city_name is not None:
            result['cityName'] = self.city_name
        if self.country_code is not None:
            result['countryCode'] = self.country_code
        if self.country_name is not None:
            result['countryName'] = self.country_name
        if self.detail_address is not None:
            result['detailAddress'] = self.detail_address
        if self.global_area_type is not None:
            result['globalAreaType'] = self.global_area_type
        if self.province_code is not None:
            result['provinceCode'] = self.province_code
        if self.province_name is not None:
            result['provinceName'] = self.province_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('areaCode') is not None:
            self.area_code = m.get('areaCode')
        if m.get('areaName') is not None:
            self.area_name = m.get('areaName')
        if m.get('cityCode') is not None:
            self.city_code = m.get('cityCode')
        if m.get('cityName') is not None:
            self.city_name = m.get('cityName')
        if m.get('countryCode') is not None:
            self.country_code = m.get('countryCode')
        if m.get('countryName') is not None:
            self.country_name = m.get('countryName')
        if m.get('detailAddress') is not None:
            self.detail_address = m.get('detailAddress')
        if m.get('globalAreaType') is not None:
            self.global_area_type = m.get('globalAreaType')
        if m.get('provinceCode') is not None:
            self.province_code = m.get('provinceCode')
        if m.get('provinceName') is not None:
            self.province_name = m.get('provinceName')
        return self


class AddHrmLegalEntityRequestExt(TeaModel):
    def __init__(
        self,
        legal_entity_en_name: str = None,
        legal_entity_en_short_name: str = None,
        legal_entity_type: str = None,
        manage_address: AddHrmLegalEntityRequestExtManageAddress = None,
        registration_address: AddHrmLegalEntityRequestExtRegistrationAddress = None,
        registration_date: int = None,
        unified_social_credit_code: str = None,
        zip_code: str = None,
    ):
        self.legal_entity_en_name = legal_entity_en_name
        self.legal_entity_en_short_name = legal_entity_en_short_name
        self.legal_entity_type = legal_entity_type
        self.manage_address = manage_address
        self.registration_address = registration_address
        self.registration_date = registration_date
        self.unified_social_credit_code = unified_social_credit_code
        self.zip_code = zip_code

    def validate(self):
        if self.manage_address:
            self.manage_address.validate()
        if self.registration_address:
            self.registration_address.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.legal_entity_en_name is not None:
            result['legalEntityEnName'] = self.legal_entity_en_name
        if self.legal_entity_en_short_name is not None:
            result['legalEntityEnShortName'] = self.legal_entity_en_short_name
        if self.legal_entity_type is not None:
            result['legalEntityType'] = self.legal_entity_type
        if self.manage_address is not None:
            result['manageAddress'] = self.manage_address.to_map()
        if self.registration_address is not None:
            result['registrationAddress'] = self.registration_address.to_map()
        if self.registration_date is not None:
            result['registrationDate'] = self.registration_date
        if self.unified_social_credit_code is not None:
            result['unifiedSocialCreditCode'] = self.unified_social_credit_code
        if self.zip_code is not None:
            result['zipCode'] = self.zip_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('legalEntityEnName') is not None:
            self.legal_entity_en_name = m.get('legalEntityEnName')
        if m.get('legalEntityEnShortName') is not None:
            self.legal_entity_en_short_name = m.get('legalEntityEnShortName')
        if m.get('legalEntityType') is not None:
            self.legal_entity_type = m.get('legalEntityType')
        if m.get('manageAddress') is not None:
            temp_model = AddHrmLegalEntityRequestExtManageAddress()
            self.manage_address = temp_model.from_map(m['manageAddress'])
        if m.get('registrationAddress') is not None:
            temp_model = AddHrmLegalEntityRequestExtRegistrationAddress()
            self.registration_address = temp_model.from_map(m['registrationAddress'])
        if m.get('registrationDate') is not None:
            self.registration_date = m.get('registrationDate')
        if m.get('unifiedSocialCreditCode') is not None:
            self.unified_social_credit_code = m.get('unifiedSocialCreditCode')
        if m.get('zipCode') is not None:
            self.zip_code = m.get('zipCode')
        return self


class AddHrmLegalEntityRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        create_user_id: str = None,
        ext: AddHrmLegalEntityRequestExt = None,
        legal_entity_name: str = None,
        legal_entity_short_name: str = None,
        legal_entity_status: int = None,
        legal_person_name: str = None,
        ding_tenant_id: int = None,
    ):
        # This parameter is required.
        self.corp_id = corp_id
        self.create_user_id = create_user_id
        self.ext = ext
        # This parameter is required.
        self.legal_entity_name = legal_entity_name
        self.legal_entity_short_name = legal_entity_short_name
        # This parameter is required.
        self.legal_entity_status = legal_entity_status
        self.legal_person_name = legal_person_name
        self.ding_tenant_id = ding_tenant_id

    def validate(self):
        if self.ext:
            self.ext.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.create_user_id is not None:
            result['createUserId'] = self.create_user_id
        if self.ext is not None:
            result['ext'] = self.ext.to_map()
        if self.legal_entity_name is not None:
            result['legalEntityName'] = self.legal_entity_name
        if self.legal_entity_short_name is not None:
            result['legalEntityShortName'] = self.legal_entity_short_name
        if self.legal_entity_status is not None:
            result['legalEntityStatus'] = self.legal_entity_status
        if self.legal_person_name is not None:
            result['legalPersonName'] = self.legal_person_name
        if self.ding_tenant_id is not None:
            result['dingTenantId'] = self.ding_tenant_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('createUserId') is not None:
            self.create_user_id = m.get('createUserId')
        if m.get('ext') is not None:
            temp_model = AddHrmLegalEntityRequestExt()
            self.ext = temp_model.from_map(m['ext'])
        if m.get('legalEntityName') is not None:
            self.legal_entity_name = m.get('legalEntityName')
        if m.get('legalEntityShortName') is not None:
            self.legal_entity_short_name = m.get('legalEntityShortName')
        if m.get('legalEntityStatus') is not None:
            self.legal_entity_status = m.get('legalEntityStatus')
        if m.get('legalPersonName') is not None:
            self.legal_person_name = m.get('legalPersonName')
        if m.get('dingTenantId') is not None:
            self.ding_tenant_id = m.get('dingTenantId')
        return self


class AddHrmLegalEntityResponseBodyResult(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        gmt_create: int = None,
        gmt_modified: int = None,
        legal_entity_id: str = None,
        legal_entity_name: str = None,
        legal_entity_short_name: str = None,
        legal_entity_status: int = None,
        legal_person_name: str = None,
    ):
        self.corp_id = corp_id
        self.gmt_create = gmt_create
        self.gmt_modified = gmt_modified
        self.legal_entity_id = legal_entity_id
        self.legal_entity_name = legal_entity_name
        self.legal_entity_short_name = legal_entity_short_name
        self.legal_entity_status = legal_entity_status
        self.legal_person_name = legal_person_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.legal_entity_id is not None:
            result['legalEntityId'] = self.legal_entity_id
        if self.legal_entity_name is not None:
            result['legalEntityName'] = self.legal_entity_name
        if self.legal_entity_short_name is not None:
            result['legalEntityShortName'] = self.legal_entity_short_name
        if self.legal_entity_status is not None:
            result['legalEntityStatus'] = self.legal_entity_status
        if self.legal_person_name is not None:
            result['legalPersonName'] = self.legal_person_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('legalEntityId') is not None:
            self.legal_entity_id = m.get('legalEntityId')
        if m.get('legalEntityName') is not None:
            self.legal_entity_name = m.get('legalEntityName')
        if m.get('legalEntityShortName') is not None:
            self.legal_entity_short_name = m.get('legalEntityShortName')
        if m.get('legalEntityStatus') is not None:
            self.legal_entity_status = m.get('legalEntityStatus')
        if m.get('legalPersonName') is not None:
            self.legal_person_name = m.get('legalPersonName')
        return self


class AddHrmLegalEntityResponseBody(TeaModel):
    def __init__(
        self,
        result: AddHrmLegalEntityResponseBodyResult = None,
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
            temp_model = AddHrmLegalEntityResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class AddHrmLegalEntityResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddHrmLegalEntityResponseBody = None,
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
            temp_model = AddHrmLegalEntityResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AddHrmPreentryHeaders(TeaModel):
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


class AddHrmPreentryRequestGroupsSectionsEmpFieldVOList(TeaModel):
    def __init__(
        self,
        field_code: str = None,
        value: str = None,
    ):
        self.field_code = field_code
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_code is not None:
            result['fieldCode'] = self.field_code
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldCode') is not None:
            self.field_code = m.get('fieldCode')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class AddHrmPreentryRequestGroupsSections(TeaModel):
    def __init__(
        self,
        emp_field_volist: List[AddHrmPreentryRequestGroupsSectionsEmpFieldVOList] = None,
        old_index: int = None,
    ):
        self.emp_field_volist = emp_field_volist
        self.old_index = old_index

    def validate(self):
        if self.emp_field_volist:
            for k in self.emp_field_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['empFieldVOList'] = []
        if self.emp_field_volist is not None:
            for k in self.emp_field_volist:
                result['empFieldVOList'].append(k.to_map() if k else None)
        if self.old_index is not None:
            result['oldIndex'] = self.old_index
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.emp_field_volist = []
        if m.get('empFieldVOList') is not None:
            for k in m.get('empFieldVOList'):
                temp_model = AddHrmPreentryRequestGroupsSectionsEmpFieldVOList()
                self.emp_field_volist.append(temp_model.from_map(k))
        if m.get('oldIndex') is not None:
            self.old_index = m.get('oldIndex')
        return self


class AddHrmPreentryRequestGroups(TeaModel):
    def __init__(
        self,
        group_id: str = None,
        sections: List[AddHrmPreentryRequestGroupsSections] = None,
    ):
        self.group_id = group_id
        self.sections = sections

    def validate(self):
        if self.sections:
            for k in self.sections:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_id is not None:
            result['groupId'] = self.group_id
        result['sections'] = []
        if self.sections is not None:
            for k in self.sections:
                result['sections'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        self.sections = []
        if m.get('sections') is not None:
            for k in m.get('sections'):
                temp_model = AddHrmPreentryRequestGroupsSections()
                self.sections.append(temp_model.from_map(k))
        return self


class AddHrmPreentryRequest(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        groups: List[AddHrmPreentryRequestGroups] = None,
        mobile: str = None,
        name: str = None,
        need_send_pre_entry_msg: bool = None,
        pre_entry_time: int = None,
    ):
        self.agent_id = agent_id
        self.groups = groups
        # This parameter is required.
        self.mobile = mobile
        # This parameter is required.
        self.name = name
        self.need_send_pre_entry_msg = need_send_pre_entry_msg
        self.pre_entry_time = pre_entry_time

    def validate(self):
        if self.groups:
            for k in self.groups:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        result['groups'] = []
        if self.groups is not None:
            for k in self.groups:
                result['groups'].append(k.to_map() if k else None)
        if self.mobile is not None:
            result['mobile'] = self.mobile
        if self.name is not None:
            result['name'] = self.name
        if self.need_send_pre_entry_msg is not None:
            result['needSendPreEntryMsg'] = self.need_send_pre_entry_msg
        if self.pre_entry_time is not None:
            result['preEntryTime'] = self.pre_entry_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        self.groups = []
        if m.get('groups') is not None:
            for k in m.get('groups'):
                temp_model = AddHrmPreentryRequestGroups()
                self.groups.append(temp_model.from_map(k))
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('needSendPreEntryMsg') is not None:
            self.need_send_pre_entry_msg = m.get('needSendPreEntryMsg')
        if m.get('preEntryTime') is not None:
            self.pre_entry_time = m.get('preEntryTime')
        return self


class AddHrmPreentryResponseBody(TeaModel):
    def __init__(
        self,
        tmp_user_id: str = None,
    ):
        self.tmp_user_id = tmp_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.tmp_user_id is not None:
            result['tmpUserId'] = self.tmp_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('tmpUserId') is not None:
            self.tmp_user_id = m.get('tmpUserId')
        return self


class AddHrmPreentryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddHrmPreentryResponseBody = None,
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
            temp_model = AddHrmPreentryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateRecordHeaders(TeaModel):
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


class CreateRecordRequestAttachmentList(TeaModel):
    def __init__(
        self,
        field_code: str = None,
        field_name: str = None,
        field_type: str = None,
        field_value: str = None,
        group_id: str = None,
    ):
        self.field_code = field_code
        self.field_name = field_name
        self.field_type = field_type
        self.field_value = field_value
        self.group_id = group_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_code is not None:
            result['fieldCode'] = self.field_code
        if self.field_name is not None:
            result['fieldName'] = self.field_name
        if self.field_type is not None:
            result['fieldType'] = self.field_type
        if self.field_value is not None:
            result['fieldValue'] = self.field_value
        if self.group_id is not None:
            result['groupId'] = self.group_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldCode') is not None:
            self.field_code = m.get('fieldCode')
        if m.get('fieldName') is not None:
            self.field_name = m.get('fieldName')
        if m.get('fieldType') is not None:
            self.field_type = m.get('fieldType')
        if m.get('fieldValue') is not None:
            self.field_value = m.get('fieldValue')
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        return self


class CreateRecordRequestFieldList(TeaModel):
    def __init__(
        self,
        field_code: str = None,
        field_name: str = None,
        field_type: str = None,
        field_value: str = None,
        group_id: str = None,
        option_id: str = None,
        options: str = None,
        sign_required: bool = None,
        user_custom_field: bool = None,
    ):
        self.field_code = field_code
        self.field_name = field_name
        self.field_type = field_type
        self.field_value = field_value
        self.group_id = group_id
        self.option_id = option_id
        self.options = options
        self.sign_required = sign_required
        self.user_custom_field = user_custom_field

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_code is not None:
            result['fieldCode'] = self.field_code
        if self.field_name is not None:
            result['fieldName'] = self.field_name
        if self.field_type is not None:
            result['fieldType'] = self.field_type
        if self.field_value is not None:
            result['fieldValue'] = self.field_value
        if self.group_id is not None:
            result['groupId'] = self.group_id
        if self.option_id is not None:
            result['optionId'] = self.option_id
        if self.options is not None:
            result['options'] = self.options
        if self.sign_required is not None:
            result['signRequired'] = self.sign_required
        if self.user_custom_field is not None:
            result['userCustomField'] = self.user_custom_field
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldCode') is not None:
            self.field_code = m.get('fieldCode')
        if m.get('fieldName') is not None:
            self.field_name = m.get('fieldName')
        if m.get('fieldType') is not None:
            self.field_type = m.get('fieldType')
        if m.get('fieldValue') is not None:
            self.field_value = m.get('fieldValue')
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        if m.get('optionId') is not None:
            self.option_id = m.get('optionId')
        if m.get('options') is not None:
            self.options = m.get('options')
        if m.get('signRequired') is not None:
            self.sign_required = m.get('signRequired')
        if m.get('userCustomField') is not None:
            self.user_custom_field = m.get('userCustomField')
        return self


class CreateRecordRequestGroupListFieldList(TeaModel):
    def __init__(
        self,
        field_code: str = None,
        field_name: str = None,
        field_type: str = None,
        field_value: str = None,
        options: str = None,
        option_id: str = None,
        group_id: str = None,
    ):
        self.field_code = field_code
        self.field_name = field_name
        self.field_type = field_type
        self.field_value = field_value
        self.options = options
        self.option_id = option_id
        self.group_id = group_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_code is not None:
            result['fieldCode'] = self.field_code
        if self.field_name is not None:
            result['fieldName'] = self.field_name
        if self.field_type is not None:
            result['fieldType'] = self.field_type
        if self.field_value is not None:
            result['fieldValue'] = self.field_value
        if self.options is not None:
            result['options'] = self.options
        if self.option_id is not None:
            result['optionId'] = self.option_id
        if self.group_id is not None:
            result['groupId'] = self.group_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldCode') is not None:
            self.field_code = m.get('fieldCode')
        if m.get('fieldName') is not None:
            self.field_name = m.get('fieldName')
        if m.get('fieldType') is not None:
            self.field_type = m.get('fieldType')
        if m.get('fieldValue') is not None:
            self.field_value = m.get('fieldValue')
        if m.get('options') is not None:
            self.options = m.get('options')
        if m.get('optionId') is not None:
            self.option_id = m.get('optionId')
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        return self


class CreateRecordRequestGroupList(TeaModel):
    def __init__(
        self,
        detail_flag: bool = None,
        field_list: List[List[CreateRecordRequestGroupListFieldList]] = None,
        group_id: str = None,
        group_name: str = None,
    ):
        self.detail_flag = detail_flag
        self.field_list = field_list
        self.group_id = group_id
        self.group_name = group_name

    def validate(self):
        if self.field_list:
            for k in self.field_list:
                for k1 in k:
                    if k1:
                        k1.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.detail_flag is not None:
            result['detailFlag'] = self.detail_flag
        result['fieldList'] = []
        if self.field_list is not None:
            for k in self.field_list:
                l1 = []
                for k1 in k:
                    l1.append(k1.to_map() if k1 else None)
                result['fieldList'].append(l1)
        if self.group_id is not None:
            result['groupId'] = self.group_id
        if self.group_name is not None:
            result['groupName'] = self.group_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('detailFlag') is not None:
            self.detail_flag = m.get('detailFlag')
        self.field_list = []
        if m.get('fieldList') is not None:
            for k in m.get('fieldList'):
                l1 = []
                for k1 in k:
                    temp_model = CreateRecordRequestGroupListFieldList()
                    l1.append(temp_model.from_map(k1))
                self.field_list.append(l1)
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        return self


class CreateRecordRequest(TeaModel):
    def __init__(
        self,
        attachment_list: List[CreateRecordRequestAttachmentList] = None,
        dept_id: int = None,
        field_list: List[CreateRecordRequestFieldList] = None,
        group_list: List[CreateRecordRequestGroupList] = None,
        remark: str = None,
        sign_last_legal_entity_name: str = None,
        sign_legal_entity_name: str = None,
        sign_source: str = None,
        sign_start_user_id: str = None,
        sign_user_id: str = None,
        template_id: str = None,
    ):
        self.attachment_list = attachment_list
        self.dept_id = dept_id
        self.field_list = field_list
        self.group_list = group_list
        self.remark = remark
        self.sign_last_legal_entity_name = sign_last_legal_entity_name
        self.sign_legal_entity_name = sign_legal_entity_name
        # This parameter is required.
        self.sign_source = sign_source
        # This parameter is required.
        self.sign_start_user_id = sign_start_user_id
        # This parameter is required.
        self.sign_user_id = sign_user_id
        # This parameter is required.
        self.template_id = template_id

    def validate(self):
        if self.attachment_list:
            for k in self.attachment_list:
                if k:
                    k.validate()
        if self.field_list:
            for k in self.field_list:
                if k:
                    k.validate()
        if self.group_list:
            for k in self.group_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attachmentList'] = []
        if self.attachment_list is not None:
            for k in self.attachment_list:
                result['attachmentList'].append(k.to_map() if k else None)
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        result['fieldList'] = []
        if self.field_list is not None:
            for k in self.field_list:
                result['fieldList'].append(k.to_map() if k else None)
        result['groupList'] = []
        if self.group_list is not None:
            for k in self.group_list:
                result['groupList'].append(k.to_map() if k else None)
        if self.remark is not None:
            result['remark'] = self.remark
        if self.sign_last_legal_entity_name is not None:
            result['signLastLegalEntityName'] = self.sign_last_legal_entity_name
        if self.sign_legal_entity_name is not None:
            result['signLegalEntityName'] = self.sign_legal_entity_name
        if self.sign_source is not None:
            result['signSource'] = self.sign_source
        if self.sign_start_user_id is not None:
            result['signStartUserId'] = self.sign_start_user_id
        if self.sign_user_id is not None:
            result['signUserId'] = self.sign_user_id
        if self.template_id is not None:
            result['templateId'] = self.template_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attachment_list = []
        if m.get('attachmentList') is not None:
            for k in m.get('attachmentList'):
                temp_model = CreateRecordRequestAttachmentList()
                self.attachment_list.append(temp_model.from_map(k))
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        self.field_list = []
        if m.get('fieldList') is not None:
            for k in m.get('fieldList'):
                temp_model = CreateRecordRequestFieldList()
                self.field_list.append(temp_model.from_map(k))
        self.group_list = []
        if m.get('groupList') is not None:
            for k in m.get('groupList'):
                temp_model = CreateRecordRequestGroupList()
                self.group_list.append(temp_model.from_map(k))
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('signLastLegalEntityName') is not None:
            self.sign_last_legal_entity_name = m.get('signLastLegalEntityName')
        if m.get('signLegalEntityName') is not None:
            self.sign_legal_entity_name = m.get('signLegalEntityName')
        if m.get('signSource') is not None:
            self.sign_source = m.get('signSource')
        if m.get('signStartUserId') is not None:
            self.sign_start_user_id = m.get('signStartUserId')
        if m.get('signUserId') is not None:
            self.sign_user_id = m.get('signUserId')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        return self


class CreateRecordResponseBodyResult(TeaModel):
    def __init__(
        self,
        details: str = None,
        item_id: str = None,
        type: str = None,
    ):
        self.details = details
        self.item_id = item_id
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.details is not None:
            result['details'] = self.details
        if self.item_id is not None:
            result['itemId'] = self.item_id
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('details') is not None:
            self.details = m.get('details')
        if m.get('itemId') is not None:
            self.item_id = m.get('itemId')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class CreateRecordResponseBody(TeaModel):
    def __init__(
        self,
        result: CreateRecordResponseBodyResult = None,
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
            temp_model = CreateRecordResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CreateRecordResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateRecordResponseBody = None,
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
            temp_model = CreateRecordResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeviceMarketManagerResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        self.request_id = request_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class DeviceMarketManagerResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeviceMarketManagerResponseBody = None,
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
            temp_model = DeviceMarketManagerResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeviceMarketOrderManagerResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        self.request_id = request_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class DeviceMarketOrderManagerResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeviceMarketOrderManagerResponseBody = None,
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
            temp_model = DeviceMarketOrderManagerResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ECertQueryHeaders(TeaModel):
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


class ECertQueryRequest(TeaModel):
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


class ECertQueryResponseBody(TeaModel):
    def __init__(
        self,
        cert_no: str = None,
        employ_job_id: str = None,
        employ_job_id_label: str = None,
        employ_position_id: str = None,
        employ_position_id_label: str = None,
        employ_position_rank_id: str = None,
        employ_position_rank_id_label: str = None,
        hired_date: str = None,
        last_work_day: str = None,
        main_dept_id: int = None,
        main_dept_name: str = None,
        name: str = None,
        real_name: str = None,
        termination_reason_passive: List[str] = None,
        termination_reason_voluntary: List[str] = None,
    ):
        self.cert_no = cert_no
        self.employ_job_id = employ_job_id
        self.employ_job_id_label = employ_job_id_label
        self.employ_position_id = employ_position_id
        self.employ_position_id_label = employ_position_id_label
        self.employ_position_rank_id = employ_position_rank_id
        self.employ_position_rank_id_label = employ_position_rank_id_label
        self.hired_date = hired_date
        self.last_work_day = last_work_day
        self.main_dept_id = main_dept_id
        self.main_dept_name = main_dept_name
        # This parameter is required.
        self.name = name
        self.real_name = real_name
        self.termination_reason_passive = termination_reason_passive
        self.termination_reason_voluntary = termination_reason_voluntary

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cert_no is not None:
            result['certNO'] = self.cert_no
        if self.employ_job_id is not None:
            result['employJobId'] = self.employ_job_id
        if self.employ_job_id_label is not None:
            result['employJobIdLabel'] = self.employ_job_id_label
        if self.employ_position_id is not None:
            result['employPositionId'] = self.employ_position_id
        if self.employ_position_id_label is not None:
            result['employPositionIdLabel'] = self.employ_position_id_label
        if self.employ_position_rank_id is not None:
            result['employPositionRankId'] = self.employ_position_rank_id
        if self.employ_position_rank_id_label is not None:
            result['employPositionRankIdLabel'] = self.employ_position_rank_id_label
        if self.hired_date is not None:
            result['hiredDate'] = self.hired_date
        if self.last_work_day is not None:
            result['lastWorkDay'] = self.last_work_day
        if self.main_dept_id is not None:
            result['mainDeptId'] = self.main_dept_id
        if self.main_dept_name is not None:
            result['mainDeptName'] = self.main_dept_name
        if self.name is not None:
            result['name'] = self.name
        if self.real_name is not None:
            result['realName'] = self.real_name
        if self.termination_reason_passive is not None:
            result['terminationReasonPassive'] = self.termination_reason_passive
        if self.termination_reason_voluntary is not None:
            result['terminationReasonVoluntary'] = self.termination_reason_voluntary
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('certNO') is not None:
            self.cert_no = m.get('certNO')
        if m.get('employJobId') is not None:
            self.employ_job_id = m.get('employJobId')
        if m.get('employJobIdLabel') is not None:
            self.employ_job_id_label = m.get('employJobIdLabel')
        if m.get('employPositionId') is not None:
            self.employ_position_id = m.get('employPositionId')
        if m.get('employPositionIdLabel') is not None:
            self.employ_position_id_label = m.get('employPositionIdLabel')
        if m.get('employPositionRankId') is not None:
            self.employ_position_rank_id = m.get('employPositionRankId')
        if m.get('employPositionRankIdLabel') is not None:
            self.employ_position_rank_id_label = m.get('employPositionRankIdLabel')
        if m.get('hiredDate') is not None:
            self.hired_date = m.get('hiredDate')
        if m.get('lastWorkDay') is not None:
            self.last_work_day = m.get('lastWorkDay')
        if m.get('mainDeptId') is not None:
            self.main_dept_id = m.get('mainDeptId')
        if m.get('mainDeptName') is not None:
            self.main_dept_name = m.get('mainDeptName')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('realName') is not None:
            self.real_name = m.get('realName')
        if m.get('terminationReasonPassive') is not None:
            self.termination_reason_passive = m.get('terminationReasonPassive')
        if m.get('terminationReasonVoluntary') is not None:
            self.termination_reason_voluntary = m.get('terminationReasonVoluntary')
        return self


class ECertQueryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ECertQueryResponseBody = None,
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
            temp_model = ECertQueryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class EmployeeAttachmentUpdateHeaders(TeaModel):
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


class EmployeeAttachmentUpdateRequest(TeaModel):
    def __init__(
        self,
        app_agent_id: int = None,
        field_code: str = None,
        file_suffix: str = None,
        media_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_agent_id = app_agent_id
        # This parameter is required.
        self.field_code = field_code
        self.file_suffix = file_suffix
        # This parameter is required.
        self.media_id = media_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_agent_id is not None:
            result['appAgentId'] = self.app_agent_id
        if self.field_code is not None:
            result['fieldCode'] = self.field_code
        if self.file_suffix is not None:
            result['fileSuffix'] = self.file_suffix
        if self.media_id is not None:
            result['mediaId'] = self.media_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appAgentId') is not None:
            self.app_agent_id = m.get('appAgentId')
        if m.get('fieldCode') is not None:
            self.field_code = m.get('fieldCode')
        if m.get('fileSuffix') is not None:
            self.file_suffix = m.get('fileSuffix')
        if m.get('mediaId') is not None:
            self.media_id = m.get('mediaId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class EmployeeAttachmentUpdateResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class EmployeeAttachmentUpdateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: EmployeeAttachmentUpdateResponseBody = None,
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
            temp_model = EmployeeAttachmentUpdateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class EsignRollbackHeaders(TeaModel):
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


class EsignRollbackRequest(TeaModel):
    def __init__(
        self,
        opt_user_id: str = None,
    ):
        # This parameter is required.
        self.opt_user_id = opt_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.opt_user_id is not None:
            result['optUserId'] = self.opt_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('optUserId') is not None:
            self.opt_user_id = m.get('optUserId')
        return self


class EsignRollbackResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # This parameter is required.
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


class EsignRollbackResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: EsignRollbackResponseBody = None,
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
            temp_model = EsignRollbackResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetEmployeeRosterByFieldHeaders(TeaModel):
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


class GetEmployeeRosterByFieldRequest(TeaModel):
    def __init__(
        self,
        app_agent_id: int = None,
        field_filter_list: List[str] = None,
        text_2select_convert: bool = None,
        user_id_list: List[str] = None,
    ):
        # This parameter is required.
        self.app_agent_id = app_agent_id
        self.field_filter_list = field_filter_list
        self.text_2select_convert = text_2select_convert
        # This parameter is required.
        self.user_id_list = user_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_agent_id is not None:
            result['appAgentId'] = self.app_agent_id
        if self.field_filter_list is not None:
            result['fieldFilterList'] = self.field_filter_list
        if self.text_2select_convert is not None:
            result['text2SelectConvert'] = self.text_2select_convert
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appAgentId') is not None:
            self.app_agent_id = m.get('appAgentId')
        if m.get('fieldFilterList') is not None:
            self.field_filter_list = m.get('fieldFilterList')
        if m.get('text2SelectConvert') is not None:
            self.text_2select_convert = m.get('text2SelectConvert')
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        return self


class GetEmployeeRosterByFieldResponseBodyResultFieldDataListFieldValueList(TeaModel):
    def __init__(
        self,
        item_index: int = None,
        label: str = None,
        value: str = None,
    ):
        self.item_index = item_index
        self.label = label
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.item_index is not None:
            result['itemIndex'] = self.item_index
        if self.label is not None:
            result['label'] = self.label
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('itemIndex') is not None:
            self.item_index = m.get('itemIndex')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class GetEmployeeRosterByFieldResponseBodyResultFieldDataList(TeaModel):
    def __init__(
        self,
        field_code: str = None,
        field_name: str = None,
        field_value_list: List[GetEmployeeRosterByFieldResponseBodyResultFieldDataListFieldValueList] = None,
        group_id: str = None,
    ):
        self.field_code = field_code
        self.field_name = field_name
        self.field_value_list = field_value_list
        self.group_id = group_id

    def validate(self):
        if self.field_value_list:
            for k in self.field_value_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_code is not None:
            result['fieldCode'] = self.field_code
        if self.field_name is not None:
            result['fieldName'] = self.field_name
        result['fieldValueList'] = []
        if self.field_value_list is not None:
            for k in self.field_value_list:
                result['fieldValueList'].append(k.to_map() if k else None)
        if self.group_id is not None:
            result['groupId'] = self.group_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldCode') is not None:
            self.field_code = m.get('fieldCode')
        if m.get('fieldName') is not None:
            self.field_name = m.get('fieldName')
        self.field_value_list = []
        if m.get('fieldValueList') is not None:
            for k in m.get('fieldValueList'):
                temp_model = GetEmployeeRosterByFieldResponseBodyResultFieldDataListFieldValueList()
                self.field_value_list.append(temp_model.from_map(k))
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        return self


class GetEmployeeRosterByFieldResponseBodyResult(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        field_data_list: List[GetEmployeeRosterByFieldResponseBodyResultFieldDataList] = None,
        union_id: str = None,
        user_id: str = None,
    ):
        self.corp_id = corp_id
        self.field_data_list = field_data_list
        self.union_id = union_id
        self.user_id = user_id

    def validate(self):
        if self.field_data_list:
            for k in self.field_data_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        result['fieldDataList'] = []
        if self.field_data_list is not None:
            for k in self.field_data_list:
                result['fieldDataList'].append(k.to_map() if k else None)
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        self.field_data_list = []
        if m.get('fieldDataList') is not None:
            for k in m.get('fieldDataList'):
                temp_model = GetEmployeeRosterByFieldResponseBodyResultFieldDataList()
                self.field_data_list.append(temp_model.from_map(k))
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetEmployeeRosterByFieldResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetEmployeeRosterByFieldResponseBodyResult] = None,
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
                temp_model = GetEmployeeRosterByFieldResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetEmployeeRosterByFieldResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetEmployeeRosterByFieldResponseBody = None,
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
            temp_model = GetEmployeeRosterByFieldResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetFileTemplateListHeaders(TeaModel):
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


class GetFileTemplateListRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: int = None,
        sign_source: str = None,
        template_status: int = None,
        template_type_list: List[str] = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        # This parameter is required.
        self.sign_source = sign_source
        self.template_status = template_status
        self.template_type_list = template_type_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.sign_source is not None:
            result['signSource'] = self.sign_source
        if self.template_status is not None:
            result['templateStatus'] = self.template_status
        if self.template_type_list is not None:
            result['templateTypeList'] = self.template_type_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('signSource') is not None:
            self.sign_source = m.get('signSource')
        if m.get('templateStatus') is not None:
            self.template_status = m.get('templateStatus')
        if m.get('templateTypeList') is not None:
            self.template_type_list = m.get('templateTypeList')
        return self


class GetFileTemplateListResponseBodyResultDataAttachmentList(TeaModel):
    def __init__(
        self,
        desc: str = None,
        field_code: str = None,
        field_name: str = None,
        field_type: str = None,
        group_id: str = None,
        sign_required: bool = None,
        user_custom_field: bool = None,
    ):
        self.desc = desc
        self.field_code = field_code
        self.field_name = field_name
        self.field_type = field_type
        self.group_id = group_id
        self.sign_required = sign_required
        self.user_custom_field = user_custom_field

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.desc is not None:
            result['desc'] = self.desc
        if self.field_code is not None:
            result['fieldCode'] = self.field_code
        if self.field_name is not None:
            result['fieldName'] = self.field_name
        if self.field_type is not None:
            result['fieldType'] = self.field_type
        if self.group_id is not None:
            result['groupId'] = self.group_id
        if self.sign_required is not None:
            result['signRequired'] = self.sign_required
        if self.user_custom_field is not None:
            result['userCustomField'] = self.user_custom_field
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('desc') is not None:
            self.desc = m.get('desc')
        if m.get('fieldCode') is not None:
            self.field_code = m.get('fieldCode')
        if m.get('fieldName') is not None:
            self.field_name = m.get('fieldName')
        if m.get('fieldType') is not None:
            self.field_type = m.get('fieldType')
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        if m.get('signRequired') is not None:
            self.sign_required = m.get('signRequired')
        if m.get('userCustomField') is not None:
            self.user_custom_field = m.get('userCustomField')
        return self


class GetFileTemplateListResponseBodyResultDataFieldList(TeaModel):
    def __init__(
        self,
        desc: str = None,
        field_code: str = None,
        field_name: str = None,
        field_type: str = None,
        group_id: str = None,
        sign_required: bool = None,
        user_custom_field: bool = None,
    ):
        self.desc = desc
        self.field_code = field_code
        self.field_name = field_name
        self.field_type = field_type
        self.group_id = group_id
        self.sign_required = sign_required
        self.user_custom_field = user_custom_field

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.desc is not None:
            result['desc'] = self.desc
        if self.field_code is not None:
            result['fieldCode'] = self.field_code
        if self.field_name is not None:
            result['fieldName'] = self.field_name
        if self.field_type is not None:
            result['fieldType'] = self.field_type
        if self.group_id is not None:
            result['groupId'] = self.group_id
        if self.sign_required is not None:
            result['signRequired'] = self.sign_required
        if self.user_custom_field is not None:
            result['userCustomField'] = self.user_custom_field
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('desc') is not None:
            self.desc = m.get('desc')
        if m.get('fieldCode') is not None:
            self.field_code = m.get('fieldCode')
        if m.get('fieldName') is not None:
            self.field_name = m.get('fieldName')
        if m.get('fieldType') is not None:
            self.field_type = m.get('fieldType')
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        if m.get('signRequired') is not None:
            self.sign_required = m.get('signRequired')
        if m.get('userCustomField') is not None:
            self.user_custom_field = m.get('userCustomField')
        return self


class GetFileTemplateListResponseBodyResultDataGroupListFieldList(TeaModel):
    def __init__(
        self,
        desc: str = None,
        field_code: str = None,
        field_name: str = None,
        field_type: str = None,
        group_id: str = None,
        sign_required: bool = None,
        user_custom_field: bool = None,
    ):
        self.desc = desc
        self.field_code = field_code
        self.field_name = field_name
        self.field_type = field_type
        self.group_id = group_id
        self.sign_required = sign_required
        self.user_custom_field = user_custom_field

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.desc is not None:
            result['desc'] = self.desc
        if self.field_code is not None:
            result['fieldCode'] = self.field_code
        if self.field_name is not None:
            result['fieldName'] = self.field_name
        if self.field_type is not None:
            result['fieldType'] = self.field_type
        if self.group_id is not None:
            result['groupId'] = self.group_id
        if self.sign_required is not None:
            result['signRequired'] = self.sign_required
        if self.user_custom_field is not None:
            result['userCustomField'] = self.user_custom_field
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('desc') is not None:
            self.desc = m.get('desc')
        if m.get('fieldCode') is not None:
            self.field_code = m.get('fieldCode')
        if m.get('fieldName') is not None:
            self.field_name = m.get('fieldName')
        if m.get('fieldType') is not None:
            self.field_type = m.get('fieldType')
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        if m.get('signRequired') is not None:
            self.sign_required = m.get('signRequired')
        if m.get('userCustomField') is not None:
            self.user_custom_field = m.get('userCustomField')
        return self


class GetFileTemplateListResponseBodyResultDataGroupList(TeaModel):
    def __init__(
        self,
        detail_flag: bool = None,
        field_list: List[GetFileTemplateListResponseBodyResultDataGroupListFieldList] = None,
        group_id: str = None,
        group_name: str = None,
    ):
        self.detail_flag = detail_flag
        self.field_list = field_list
        self.group_id = group_id
        self.group_name = group_name

    def validate(self):
        if self.field_list:
            for k in self.field_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.detail_flag is not None:
            result['detailFlag'] = self.detail_flag
        result['fieldList'] = []
        if self.field_list is not None:
            for k in self.field_list:
                result['fieldList'].append(k.to_map() if k else None)
        if self.group_id is not None:
            result['groupId'] = self.group_id
        if self.group_name is not None:
            result['groupName'] = self.group_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('detailFlag') is not None:
            self.detail_flag = m.get('detailFlag')
        self.field_list = []
        if m.get('fieldList') is not None:
            for k in m.get('fieldList'):
                temp_model = GetFileTemplateListResponseBodyResultDataGroupListFieldList()
                self.field_list.append(temp_model.from_map(k))
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        return self


class GetFileTemplateListResponseBodyResultData(TeaModel):
    def __init__(
        self,
        attachment_list: List[GetFileTemplateListResponseBodyResultDataAttachmentList] = None,
        corp_id: str = None,
        field_list: List[GetFileTemplateListResponseBodyResultDataFieldList] = None,
        group_list: List[GetFileTemplateListResponseBodyResultDataGroupList] = None,
        template_id: str = None,
        template_inst_name: str = None,
        template_name: str = None,
        template_sign_status: int = None,
        template_status: int = None,
        template_type: str = None,
        template_type_name: str = None,
        tenant_id: int = None,
    ):
        self.attachment_list = attachment_list
        self.corp_id = corp_id
        self.field_list = field_list
        self.group_list = group_list
        self.template_id = template_id
        self.template_inst_name = template_inst_name
        self.template_name = template_name
        self.template_sign_status = template_sign_status
        self.template_status = template_status
        self.template_type = template_type
        self.template_type_name = template_type_name
        self.tenant_id = tenant_id

    def validate(self):
        if self.attachment_list:
            for k in self.attachment_list:
                if k:
                    k.validate()
        if self.field_list:
            for k in self.field_list:
                if k:
                    k.validate()
        if self.group_list:
            for k in self.group_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attachmentList'] = []
        if self.attachment_list is not None:
            for k in self.attachment_list:
                result['attachmentList'].append(k.to_map() if k else None)
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        result['fieldList'] = []
        if self.field_list is not None:
            for k in self.field_list:
                result['fieldList'].append(k.to_map() if k else None)
        result['groupList'] = []
        if self.group_list is not None:
            for k in self.group_list:
                result['groupList'].append(k.to_map() if k else None)
        if self.template_id is not None:
            result['templateId'] = self.template_id
        if self.template_inst_name is not None:
            result['templateInstName'] = self.template_inst_name
        if self.template_name is not None:
            result['templateName'] = self.template_name
        if self.template_sign_status is not None:
            result['templateSignStatus'] = self.template_sign_status
        if self.template_status is not None:
            result['templateStatus'] = self.template_status
        if self.template_type is not None:
            result['templateType'] = self.template_type
        if self.template_type_name is not None:
            result['templateTypeName'] = self.template_type_name
        if self.tenant_id is not None:
            result['tenantId'] = self.tenant_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attachment_list = []
        if m.get('attachmentList') is not None:
            for k in m.get('attachmentList'):
                temp_model = GetFileTemplateListResponseBodyResultDataAttachmentList()
                self.attachment_list.append(temp_model.from_map(k))
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        self.field_list = []
        if m.get('fieldList') is not None:
            for k in m.get('fieldList'):
                temp_model = GetFileTemplateListResponseBodyResultDataFieldList()
                self.field_list.append(temp_model.from_map(k))
        self.group_list = []
        if m.get('groupList') is not None:
            for k in m.get('groupList'):
                temp_model = GetFileTemplateListResponseBodyResultDataGroupList()
                self.group_list.append(temp_model.from_map(k))
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        if m.get('templateInstName') is not None:
            self.template_inst_name = m.get('templateInstName')
        if m.get('templateName') is not None:
            self.template_name = m.get('templateName')
        if m.get('templateSignStatus') is not None:
            self.template_sign_status = m.get('templateSignStatus')
        if m.get('templateStatus') is not None:
            self.template_status = m.get('templateStatus')
        if m.get('templateType') is not None:
            self.template_type = m.get('templateType')
        if m.get('templateTypeName') is not None:
            self.template_type_name = m.get('templateTypeName')
        if m.get('tenantId') is not None:
            self.tenant_id = m.get('tenantId')
        return self


class GetFileTemplateListResponseBodyResult(TeaModel):
    def __init__(
        self,
        data: List[GetFileTemplateListResponseBodyResultData] = None,
        has_more: bool = None,
        next_token: int = None,
    ):
        self.data = data
        # This parameter is required.
        self.has_more = has_more
        self.next_token = next_token

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
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetFileTemplateListResponseBodyResultData()
                self.data.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetFileTemplateListResponseBody(TeaModel):
    def __init__(
        self,
        result: GetFileTemplateListResponseBodyResult = None,
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
            temp_model = GetFileTemplateListResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetFileTemplateListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetFileTemplateListResponseBody = None,
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
            temp_model = GetFileTemplateListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSignRecordByIdHeaders(TeaModel):
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


class GetSignRecordByIdRequest(TeaModel):
    def __init__(
        self,
        body: List[str] = None,
    ):
        # This parameter is required.
        self.body = body

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.body is not None:
            result['body'] = self.body
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('body') is not None:
            self.body = m.get('body')
        return self


class GetSignRecordByIdResponseBodyResult(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        remark: str = None,
        sign_expire_time: int = None,
        sign_file_name: str = None,
        sign_finish_time: int = None,
        sign_legal_entity_name: str = None,
        sign_record_id: str = None,
        sign_start_time: int = None,
        sign_status: str = None,
        sign_status_remarks: str = None,
        sign_template_type: str = None,
        sign_user_id: str = None,
        sign_user_name: str = None,
        sign_way: str = None,
    ):
        self.corp_id = corp_id
        self.remark = remark
        self.sign_expire_time = sign_expire_time
        self.sign_file_name = sign_file_name
        self.sign_finish_time = sign_finish_time
        self.sign_legal_entity_name = sign_legal_entity_name
        self.sign_record_id = sign_record_id
        self.sign_start_time = sign_start_time
        self.sign_status = sign_status
        self.sign_status_remarks = sign_status_remarks
        self.sign_template_type = sign_template_type
        self.sign_user_id = sign_user_id
        self.sign_user_name = sign_user_name
        self.sign_way = sign_way

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.remark is not None:
            result['remark'] = self.remark
        if self.sign_expire_time is not None:
            result['signExpireTime'] = self.sign_expire_time
        if self.sign_file_name is not None:
            result['signFileName'] = self.sign_file_name
        if self.sign_finish_time is not None:
            result['signFinishTime'] = self.sign_finish_time
        if self.sign_legal_entity_name is not None:
            result['signLegalEntityName'] = self.sign_legal_entity_name
        if self.sign_record_id is not None:
            result['signRecordId'] = self.sign_record_id
        if self.sign_start_time is not None:
            result['signStartTime'] = self.sign_start_time
        if self.sign_status is not None:
            result['signStatus'] = self.sign_status
        if self.sign_status_remarks is not None:
            result['signStatusRemarks'] = self.sign_status_remarks
        if self.sign_template_type is not None:
            result['signTemplateType'] = self.sign_template_type
        if self.sign_user_id is not None:
            result['signUserId'] = self.sign_user_id
        if self.sign_user_name is not None:
            result['signUserName'] = self.sign_user_name
        if self.sign_way is not None:
            result['signWay'] = self.sign_way
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('signExpireTime') is not None:
            self.sign_expire_time = m.get('signExpireTime')
        if m.get('signFileName') is not None:
            self.sign_file_name = m.get('signFileName')
        if m.get('signFinishTime') is not None:
            self.sign_finish_time = m.get('signFinishTime')
        if m.get('signLegalEntityName') is not None:
            self.sign_legal_entity_name = m.get('signLegalEntityName')
        if m.get('signRecordId') is not None:
            self.sign_record_id = m.get('signRecordId')
        if m.get('signStartTime') is not None:
            self.sign_start_time = m.get('signStartTime')
        if m.get('signStatus') is not None:
            self.sign_status = m.get('signStatus')
        if m.get('signStatusRemarks') is not None:
            self.sign_status_remarks = m.get('signStatusRemarks')
        if m.get('signTemplateType') is not None:
            self.sign_template_type = m.get('signTemplateType')
        if m.get('signUserId') is not None:
            self.sign_user_id = m.get('signUserId')
        if m.get('signUserName') is not None:
            self.sign_user_name = m.get('signUserName')
        if m.get('signWay') is not None:
            self.sign_way = m.get('signWay')
        return self


class GetSignRecordByIdResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetSignRecordByIdResponseBodyResult] = None,
        success: bool = None,
    ):
        self.result = result
        # This parameter is required.
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = GetSignRecordByIdResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetSignRecordByIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetSignRecordByIdResponseBody = None,
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
            temp_model = GetSignRecordByIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSignRecordByUserIdHeaders(TeaModel):
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


class GetSignRecordByUserIdRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: int = None,
        sign_status: List[str] = None,
        sign_user_id: str = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        self.sign_status = sign_status
        # This parameter is required.
        self.sign_user_id = sign_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.sign_status is not None:
            result['signStatus'] = self.sign_status
        if self.sign_user_id is not None:
            result['signUserId'] = self.sign_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('signStatus') is not None:
            self.sign_status = m.get('signStatus')
        if m.get('signUserId') is not None:
            self.sign_user_id = m.get('signUserId')
        return self


class GetSignRecordByUserIdResponseBodyResultData(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        remark: str = None,
        sign_expire_time: int = None,
        sign_file_name: str = None,
        sign_file_url: str = None,
        sign_finish_time: int = None,
        sign_legal_entity_name: str = None,
        sign_record_id: str = None,
        sign_start_time: int = None,
        sign_status: str = None,
        sign_status_remarks: str = None,
        sign_template_type: str = None,
        sign_user_id: str = None,
        sign_user_name: str = None,
        sign_way: str = None,
    ):
        self.corp_id = corp_id
        self.remark = remark
        self.sign_expire_time = sign_expire_time
        self.sign_file_name = sign_file_name
        self.sign_file_url = sign_file_url
        self.sign_finish_time = sign_finish_time
        self.sign_legal_entity_name = sign_legal_entity_name
        self.sign_record_id = sign_record_id
        self.sign_start_time = sign_start_time
        self.sign_status = sign_status
        self.sign_status_remarks = sign_status_remarks
        self.sign_template_type = sign_template_type
        self.sign_user_id = sign_user_id
        self.sign_user_name = sign_user_name
        self.sign_way = sign_way

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.remark is not None:
            result['remark'] = self.remark
        if self.sign_expire_time is not None:
            result['signExpireTime'] = self.sign_expire_time
        if self.sign_file_name is not None:
            result['signFileName'] = self.sign_file_name
        if self.sign_file_url is not None:
            result['signFileUrl'] = self.sign_file_url
        if self.sign_finish_time is not None:
            result['signFinishTime'] = self.sign_finish_time
        if self.sign_legal_entity_name is not None:
            result['signLegalEntityName'] = self.sign_legal_entity_name
        if self.sign_record_id is not None:
            result['signRecordId'] = self.sign_record_id
        if self.sign_start_time is not None:
            result['signStartTime'] = self.sign_start_time
        if self.sign_status is not None:
            result['signStatus'] = self.sign_status
        if self.sign_status_remarks is not None:
            result['signStatusRemarks'] = self.sign_status_remarks
        if self.sign_template_type is not None:
            result['signTemplateType'] = self.sign_template_type
        if self.sign_user_id is not None:
            result['signUserId'] = self.sign_user_id
        if self.sign_user_name is not None:
            result['signUserName'] = self.sign_user_name
        if self.sign_way is not None:
            result['signWay'] = self.sign_way
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('signExpireTime') is not None:
            self.sign_expire_time = m.get('signExpireTime')
        if m.get('signFileName') is not None:
            self.sign_file_name = m.get('signFileName')
        if m.get('signFileUrl') is not None:
            self.sign_file_url = m.get('signFileUrl')
        if m.get('signFinishTime') is not None:
            self.sign_finish_time = m.get('signFinishTime')
        if m.get('signLegalEntityName') is not None:
            self.sign_legal_entity_name = m.get('signLegalEntityName')
        if m.get('signRecordId') is not None:
            self.sign_record_id = m.get('signRecordId')
        if m.get('signStartTime') is not None:
            self.sign_start_time = m.get('signStartTime')
        if m.get('signStatus') is not None:
            self.sign_status = m.get('signStatus')
        if m.get('signStatusRemarks') is not None:
            self.sign_status_remarks = m.get('signStatusRemarks')
        if m.get('signTemplateType') is not None:
            self.sign_template_type = m.get('signTemplateType')
        if m.get('signUserId') is not None:
            self.sign_user_id = m.get('signUserId')
        if m.get('signUserName') is not None:
            self.sign_user_name = m.get('signUserName')
        if m.get('signWay') is not None:
            self.sign_way = m.get('signWay')
        return self


class GetSignRecordByUserIdResponseBodyResult(TeaModel):
    def __init__(
        self,
        data: List[GetSignRecordByUserIdResponseBodyResultData] = None,
        has_more: bool = None,
        next_token: int = None,
    ):
        self.data = data
        self.has_more = has_more
        self.next_token = next_token

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
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetSignRecordByUserIdResponseBodyResultData()
                self.data.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetSignRecordByUserIdResponseBody(TeaModel):
    def __init__(
        self,
        result: GetSignRecordByUserIdResponseBodyResult = None,
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
            temp_model = GetSignRecordByUserIdResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetSignRecordByUserIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetSignRecordByUserIdResponseBody = None,
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
            temp_model = GetSignRecordByUserIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class HrmAuthResourcesQueryHeaders(TeaModel):
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


class HrmAuthResourcesQueryRequest(TeaModel):
    def __init__(
        self,
        auth_resource_ids: List[str] = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.auth_resource_ids = auth_resource_ids
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auth_resource_ids is not None:
            result['authResourceIds'] = self.auth_resource_ids
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authResourceIds') is not None:
            self.auth_resource_ids = m.get('authResourceIds')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class HrmAuthResourcesQueryResponseBodyResult(TeaModel):
    def __init__(
        self,
        authorized: bool = None,
        resource_id: str = None,
    ):
        self.authorized = authorized
        self.resource_id = resource_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.authorized is not None:
            result['authorized'] = self.authorized
        if self.resource_id is not None:
            result['resourceId'] = self.resource_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authorized') is not None:
            self.authorized = m.get('authorized')
        if m.get('resourceId') is not None:
            self.resource_id = m.get('resourceId')
        return self


class HrmAuthResourcesQueryResponseBody(TeaModel):
    def __init__(
        self,
        result: List[HrmAuthResourcesQueryResponseBodyResult] = None,
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
                temp_model = HrmAuthResourcesQueryResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class HrmAuthResourcesQueryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: HrmAuthResourcesQueryResponseBody = None,
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
            temp_model = HrmAuthResourcesQueryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class HrmBenefitQueryHeaders(TeaModel):
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


class HrmBenefitQueryRequest(TeaModel):
    def __init__(
        self,
        benefit_codes: List[str] = None,
    ):
        # This parameter is required.
        self.benefit_codes = benefit_codes

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.benefit_codes is not None:
            result['benefitCodes'] = self.benefit_codes
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('benefitCodes') is not None:
            self.benefit_codes = m.get('benefitCodes')
        return self


class HrmBenefitQueryResponseBody(TeaModel):
    def __init__(
        self,
        result: Any = None,
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


class HrmBenefitQueryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: HrmBenefitQueryResponseBody = None,
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
            temp_model = HrmBenefitQueryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class HrmCorpConfigQueryHeaders(TeaModel):
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


class HrmCorpConfigQueryRequest(TeaModel):
    def __init__(
        self,
        sub_type: str = None,
        type: str = None,
    ):
        # This parameter is required.
        self.sub_type = sub_type
        # This parameter is required.
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sub_type is not None:
            result['subType'] = self.sub_type
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('subType') is not None:
            self.sub_type = m.get('subType')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class HrmCorpConfigQueryResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
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


class HrmCorpConfigQueryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: HrmCorpConfigQueryResponseBody = None,
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
            temp_model = HrmCorpConfigQueryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class HrmMailSendHeaders(TeaModel):
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


class HrmMailSendRequestMailAttachments(TeaModel):
    def __init__(
        self,
        name: str = None,
        path: str = None,
        type: str = None,
    ):
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.path = path
        # This parameter is required.
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.path is not None:
            result['path'] = self.path
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('path') is not None:
            self.path = m.get('path')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class HrmMailSendRequestMailMeetingAlarm(TeaModel):
    def __init__(
        self,
        alarm_desc: str = None,
        alarm_minutes: int = None,
        alarm_summary: str = None,
    ):
        # This parameter is required.
        self.alarm_desc = alarm_desc
        # This parameter is required.
        self.alarm_minutes = alarm_minutes
        # This parameter is required.
        self.alarm_summary = alarm_summary

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.alarm_desc is not None:
            result['alarmDesc'] = self.alarm_desc
        if self.alarm_minutes is not None:
            result['alarmMinutes'] = self.alarm_minutes
        if self.alarm_summary is not None:
            result['alarmSummary'] = self.alarm_summary
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('alarmDesc') is not None:
            self.alarm_desc = m.get('alarmDesc')
        if m.get('alarmMinutes') is not None:
            self.alarm_minutes = m.get('alarmMinutes')
        if m.get('alarmSummary') is not None:
            self.alarm_summary = m.get('alarmSummary')
        return self


class HrmMailSendRequestMailMeetingAttendees(TeaModel):
    def __init__(
        self,
        address: str = None,
        name: str = None,
    ):
        # This parameter is required.
        self.address = address
        # This parameter is required.
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.address is not None:
            result['address'] = self.address
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('address') is not None:
            self.address = m.get('address')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class HrmMailSendRequestMailMeetingOrganizer(TeaModel):
    def __init__(
        self,
        address: str = None,
        name: str = None,
    ):
        # This parameter is required.
        self.address = address
        # This parameter is required.
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.address is not None:
            result['address'] = self.address
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('address') is not None:
            self.address = m.get('address')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class HrmMailSendRequestMailMeeting(TeaModel):
    def __init__(
        self,
        alarm: HrmMailSendRequestMailMeetingAlarm = None,
        attendees: List[HrmMailSendRequestMailMeetingAttendees] = None,
        description: str = None,
        end_time: int = None,
        location: str = None,
        method: str = None,
        organizer: HrmMailSendRequestMailMeetingOrganizer = None,
        sequence: int = None,
        start_time: int = None,
        summary: str = None,
        uuid: str = None,
    ):
        self.alarm = alarm
        self.attendees = attendees
        self.description = description
        # This parameter is required.
        self.end_time = end_time
        self.location = location
        # This parameter is required.
        self.method = method
        self.organizer = organizer
        self.sequence = sequence
        # This parameter is required.
        self.start_time = start_time
        # This parameter is required.
        self.summary = summary
        # This parameter is required.
        self.uuid = uuid

    def validate(self):
        if self.alarm:
            self.alarm.validate()
        if self.attendees:
            for k in self.attendees:
                if k:
                    k.validate()
        if self.organizer:
            self.organizer.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.alarm is not None:
            result['alarm'] = self.alarm.to_map()
        result['attendees'] = []
        if self.attendees is not None:
            for k in self.attendees:
                result['attendees'].append(k.to_map() if k else None)
        if self.description is not None:
            result['description'] = self.description
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.location is not None:
            result['location'] = self.location
        if self.method is not None:
            result['method'] = self.method
        if self.organizer is not None:
            result['organizer'] = self.organizer.to_map()
        if self.sequence is not None:
            result['sequence'] = self.sequence
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.summary is not None:
            result['summary'] = self.summary
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('alarm') is not None:
            temp_model = HrmMailSendRequestMailMeetingAlarm()
            self.alarm = temp_model.from_map(m['alarm'])
        self.attendees = []
        if m.get('attendees') is not None:
            for k in m.get('attendees'):
                temp_model = HrmMailSendRequestMailMeetingAttendees()
                self.attendees.append(temp_model.from_map(k))
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('location') is not None:
            self.location = m.get('location')
        if m.get('method') is not None:
            self.method = m.get('method')
        if m.get('organizer') is not None:
            temp_model = HrmMailSendRequestMailMeetingOrganizer()
            self.organizer = temp_model.from_map(m['organizer'])
        if m.get('sequence') is not None:
            self.sequence = m.get('sequence')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('summary') is not None:
            self.summary = m.get('summary')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class HrmMailSendRequestMail(TeaModel):
    def __init__(
        self,
        attachments: List[HrmMailSendRequestMailAttachments] = None,
        bcc_address: str = None,
        cc_address: str = None,
        content: str = None,
        meeting: HrmMailSendRequestMailMeeting = None,
        receiver_address: str = None,
        sender_alias: str = None,
        subject: str = None,
    ):
        self.attachments = attachments
        self.bcc_address = bcc_address
        self.cc_address = cc_address
        # This parameter is required.
        self.content = content
        self.meeting = meeting
        # This parameter is required.
        self.receiver_address = receiver_address
        # This parameter is required.
        self.sender_alias = sender_alias
        # This parameter is required.
        self.subject = subject

    def validate(self):
        if self.attachments:
            for k in self.attachments:
                if k:
                    k.validate()
        if self.meeting:
            self.meeting.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attachments'] = []
        if self.attachments is not None:
            for k in self.attachments:
                result['attachments'].append(k.to_map() if k else None)
        if self.bcc_address is not None:
            result['bccAddress'] = self.bcc_address
        if self.cc_address is not None:
            result['ccAddress'] = self.cc_address
        if self.content is not None:
            result['content'] = self.content
        if self.meeting is not None:
            result['meeting'] = self.meeting.to_map()
        if self.receiver_address is not None:
            result['receiverAddress'] = self.receiver_address
        if self.sender_alias is not None:
            result['senderAlias'] = self.sender_alias
        if self.subject is not None:
            result['subject'] = self.subject
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attachments = []
        if m.get('attachments') is not None:
            for k in m.get('attachments'):
                temp_model = HrmMailSendRequestMailAttachments()
                self.attachments.append(temp_model.from_map(k))
        if m.get('bccAddress') is not None:
            self.bcc_address = m.get('bccAddress')
        if m.get('ccAddress') is not None:
            self.cc_address = m.get('ccAddress')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('meeting') is not None:
            temp_model = HrmMailSendRequestMailMeeting()
            self.meeting = temp_model.from_map(m['meeting'])
        if m.get('receiverAddress') is not None:
            self.receiver_address = m.get('receiverAddress')
        if m.get('senderAlias') is not None:
            self.sender_alias = m.get('senderAlias')
        if m.get('subject') is not None:
            self.subject = m.get('subject')
        return self


class HrmMailSendRequestOperator(TeaModel):
    def __init__(
        self,
        biz_id: str = None,
        mail_account_type: str = None,
        token: str = None,
    ):
        # This parameter is required.
        self.biz_id = biz_id
        # This parameter is required.
        self.mail_account_type = mail_account_type
        # This parameter is required.
        self.token = token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.mail_account_type is not None:
            result['mailAccountType'] = self.mail_account_type
        if self.token is not None:
            result['token'] = self.token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('mailAccountType') is not None:
            self.mail_account_type = m.get('mailAccountType')
        if m.get('token') is not None:
            self.token = m.get('token')
        return self


class HrmMailSendRequest(TeaModel):
    def __init__(
        self,
        mail: HrmMailSendRequestMail = None,
        operator: HrmMailSendRequestOperator = None,
    ):
        # This parameter is required.
        self.mail = mail
        # This parameter is required.
        self.operator = operator

    def validate(self):
        if self.mail:
            self.mail.validate()
        if self.operator:
            self.operator.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mail is not None:
            result['mail'] = self.mail.to_map()
        if self.operator is not None:
            result['operator'] = self.operator.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mail') is not None:
            temp_model = HrmMailSendRequestMail()
            self.mail = temp_model.from_map(m['mail'])
        if m.get('operator') is not None:
            temp_model = HrmMailSendRequestOperator()
            self.operator = temp_model.from_map(m['operator'])
        return self


class HrmMailSendResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
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


class HrmMailSendResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: HrmMailSendResponseBody = None,
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
            temp_model = HrmMailSendResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class HrmMokaEventHeaders(TeaModel):
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


class HrmMokaEventRequest(TeaModel):
    def __init__(
        self,
        biz_id: str = None,
        content: str = None,
    ):
        # This parameter is required.
        self.biz_id = biz_id
        # This parameter is required.
        self.content = content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.content is not None:
            result['content'] = self.content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('content') is not None:
            self.content = m.get('content')
        return self


class HrmMokaEventResponseBody(TeaModel):
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


class HrmMokaEventResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: HrmMokaEventResponseBody = None,
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
            temp_model = HrmMokaEventResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class HrmMokaOapiHeaders(TeaModel):
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


class HrmMokaOapiRequest(TeaModel):
    def __init__(
        self,
        api_code: str = None,
        params: Any = None,
    ):
        # This parameter is required.
        self.api_code = api_code
        self.params = params

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.api_code is not None:
            result['apiCode'] = self.api_code
        if self.params is not None:
            result['params'] = self.params
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('apiCode') is not None:
            self.api_code = m.get('apiCode')
        if m.get('params') is not None:
            self.params = m.get('params')
        return self


class HrmMokaOapiResponseBody(TeaModel):
    def __init__(
        self,
        biz_success: bool = None,
        error_code: str = None,
        error_msg: str = None,
        result: Dict[str, Any] = None,
    ):
        self.biz_success = biz_success
        self.error_code = error_code
        self.error_msg = error_msg
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_success is not None:
            result['bizSuccess'] = self.biz_success
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizSuccess') is not None:
            self.biz_success = m.get('bizSuccess')
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class HrmMokaOapiResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: HrmMokaOapiResponseBody = None,
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
            temp_model = HrmMokaOapiResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class HrmProcessRegularHeaders(TeaModel):
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


class HrmProcessRegularRequest(TeaModel):
    def __init__(
        self,
        operation_id: str = None,
        regular_date: int = None,
        remark: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.operation_id = operation_id
        # This parameter is required.
        self.regular_date = regular_date
        self.remark = remark
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operation_id is not None:
            result['operationId'] = self.operation_id
        if self.regular_date is not None:
            result['regularDate'] = self.regular_date
        if self.remark is not None:
            result['remark'] = self.remark
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operationId') is not None:
            self.operation_id = m.get('operationId')
        if m.get('regularDate') is not None:
            self.regular_date = m.get('regularDate')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class HrmProcessRegularResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # This parameter is required.
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


class HrmProcessRegularResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: HrmProcessRegularResponseBody = None,
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
            temp_model = HrmProcessRegularResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class HrmProcessTerminationAndHandoverHeaders(TeaModel):
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


class HrmProcessTerminationAndHandoverRequest(TeaModel):
    def __init__(
        self,
        aflow_hand_over_user_id: str = None,
        ding_pan_handover_user_id: str = None,
        direct_subordinates_handover_user_id: str = None,
        dismission_memo: str = None,
        dismission_reason: int = None,
        doc_note_handover_user_id: str = None,
        last_work_date: int = None,
        opt_user_id: str = None,
        permission_handover_user_id: str = None,
        user_id: str = None,
    ):
        self.aflow_hand_over_user_id = aflow_hand_over_user_id
        self.ding_pan_handover_user_id = ding_pan_handover_user_id
        self.direct_subordinates_handover_user_id = direct_subordinates_handover_user_id
        # This parameter is required.
        self.dismission_memo = dismission_memo
        # This parameter is required.
        self.dismission_reason = dismission_reason
        self.doc_note_handover_user_id = doc_note_handover_user_id
        # This parameter is required.
        self.last_work_date = last_work_date
        # This parameter is required.
        self.opt_user_id = opt_user_id
        self.permission_handover_user_id = permission_handover_user_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.aflow_hand_over_user_id is not None:
            result['aflowHandOverUserId'] = self.aflow_hand_over_user_id
        if self.ding_pan_handover_user_id is not None:
            result['dingPanHandoverUserId'] = self.ding_pan_handover_user_id
        if self.direct_subordinates_handover_user_id is not None:
            result['directSubordinatesHandoverUserId'] = self.direct_subordinates_handover_user_id
        if self.dismission_memo is not None:
            result['dismissionMemo'] = self.dismission_memo
        if self.dismission_reason is not None:
            result['dismissionReason'] = self.dismission_reason
        if self.doc_note_handover_user_id is not None:
            result['docNoteHandoverUserId'] = self.doc_note_handover_user_id
        if self.last_work_date is not None:
            result['lastWorkDate'] = self.last_work_date
        if self.opt_user_id is not None:
            result['optUserId'] = self.opt_user_id
        if self.permission_handover_user_id is not None:
            result['permissionHandoverUserId'] = self.permission_handover_user_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('aflowHandOverUserId') is not None:
            self.aflow_hand_over_user_id = m.get('aflowHandOverUserId')
        if m.get('dingPanHandoverUserId') is not None:
            self.ding_pan_handover_user_id = m.get('dingPanHandoverUserId')
        if m.get('directSubordinatesHandoverUserId') is not None:
            self.direct_subordinates_handover_user_id = m.get('directSubordinatesHandoverUserId')
        if m.get('dismissionMemo') is not None:
            self.dismission_memo = m.get('dismissionMemo')
        if m.get('dismissionReason') is not None:
            self.dismission_reason = m.get('dismissionReason')
        if m.get('docNoteHandoverUserId') is not None:
            self.doc_note_handover_user_id = m.get('docNoteHandoverUserId')
        if m.get('lastWorkDate') is not None:
            self.last_work_date = m.get('lastWorkDate')
        if m.get('optUserId') is not None:
            self.opt_user_id = m.get('optUserId')
        if m.get('permissionHandoverUserId') is not None:
            self.permission_handover_user_id = m.get('permissionHandoverUserId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class HrmProcessTerminationAndHandoverResponseBody(TeaModel):
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


class HrmProcessTerminationAndHandoverResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: HrmProcessTerminationAndHandoverResponseBody = None,
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
            temp_model = HrmProcessTerminationAndHandoverResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class HrmProcessTransferHeaders(TeaModel):
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


class HrmProcessTransferRequest(TeaModel):
    def __init__(
        self,
        dept_ids_after_transfer: List[int] = None,
        job_id_after_transfer: str = None,
        main_dept_id_after_transfer: int = None,
        operate_user_id: str = None,
        position_id_after_transfer: str = None,
        position_level_after_transfer: str = None,
        position_name_after_transfer: str = None,
        rank_id_after_transfer: str = None,
        user_id: str = None,
    ):
        self.dept_ids_after_transfer = dept_ids_after_transfer
        self.job_id_after_transfer = job_id_after_transfer
        self.main_dept_id_after_transfer = main_dept_id_after_transfer
        self.operate_user_id = operate_user_id
        self.position_id_after_transfer = position_id_after_transfer
        self.position_level_after_transfer = position_level_after_transfer
        self.position_name_after_transfer = position_name_after_transfer
        self.rank_id_after_transfer = rank_id_after_transfer
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_ids_after_transfer is not None:
            result['deptIdsAfterTransfer'] = self.dept_ids_after_transfer
        if self.job_id_after_transfer is not None:
            result['jobIdAfterTransfer'] = self.job_id_after_transfer
        if self.main_dept_id_after_transfer is not None:
            result['mainDeptIdAfterTransfer'] = self.main_dept_id_after_transfer
        if self.operate_user_id is not None:
            result['operateUserId'] = self.operate_user_id
        if self.position_id_after_transfer is not None:
            result['positionIdAfterTransfer'] = self.position_id_after_transfer
        if self.position_level_after_transfer is not None:
            result['positionLevelAfterTransfer'] = self.position_level_after_transfer
        if self.position_name_after_transfer is not None:
            result['positionNameAfterTransfer'] = self.position_name_after_transfer
        if self.rank_id_after_transfer is not None:
            result['rankIdAfterTransfer'] = self.rank_id_after_transfer
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptIdsAfterTransfer') is not None:
            self.dept_ids_after_transfer = m.get('deptIdsAfterTransfer')
        if m.get('jobIdAfterTransfer') is not None:
            self.job_id_after_transfer = m.get('jobIdAfterTransfer')
        if m.get('mainDeptIdAfterTransfer') is not None:
            self.main_dept_id_after_transfer = m.get('mainDeptIdAfterTransfer')
        if m.get('operateUserId') is not None:
            self.operate_user_id = m.get('operateUserId')
        if m.get('positionIdAfterTransfer') is not None:
            self.position_id_after_transfer = m.get('positionIdAfterTransfer')
        if m.get('positionLevelAfterTransfer') is not None:
            self.position_level_after_transfer = m.get('positionLevelAfterTransfer')
        if m.get('positionNameAfterTransfer') is not None:
            self.position_name_after_transfer = m.get('positionNameAfterTransfer')
        if m.get('rankIdAfterTransfer') is not None:
            self.rank_id_after_transfer = m.get('rankIdAfterTransfer')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class HrmProcessTransferResponseBody(TeaModel):
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


class HrmProcessTransferResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: HrmProcessTransferResponseBody = None,
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
            temp_model = HrmProcessTransferResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class HrmProcessUpdateTerminationInfoHeaders(TeaModel):
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


class HrmProcessUpdateTerminationInfoRequest(TeaModel):
    def __init__(
        self,
        dismission_memo: str = None,
        last_work_date: int = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.dismission_memo = dismission_memo
        # This parameter is required.
        self.last_work_date = last_work_date
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dismission_memo is not None:
            result['dismissionMemo'] = self.dismission_memo
        if self.last_work_date is not None:
            result['lastWorkDate'] = self.last_work_date
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dismissionMemo') is not None:
            self.dismission_memo = m.get('dismissionMemo')
        if m.get('lastWorkDate') is not None:
            self.last_work_date = m.get('lastWorkDate')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class HrmProcessUpdateTerminationInfoResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # This parameter is required.
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


class HrmProcessUpdateTerminationInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: HrmProcessUpdateTerminationInfoResponseBody = None,
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
            temp_model = HrmProcessUpdateTerminationInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class HrmPtsServiceHeaders(TeaModel):
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


class HrmPtsServiceRequest(TeaModel):
    def __init__(
        self,
        env: str = None,
        method: str = None,
        outer_id: str = None,
        params: Any = None,
        path: str = None,
    ):
        # This parameter is required.
        self.env = env
        self.method = method
        # This parameter is required.
        self.outer_id = outer_id
        self.params = params
        # This parameter is required.
        self.path = path

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.env is not None:
            result['env'] = self.env
        if self.method is not None:
            result['method'] = self.method
        if self.outer_id is not None:
            result['outerId'] = self.outer_id
        if self.params is not None:
            result['params'] = self.params
        if self.path is not None:
            result['path'] = self.path
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('env') is not None:
            self.env = m.get('env')
        if m.get('method') is not None:
            self.method = m.get('method')
        if m.get('outerId') is not None:
            self.outer_id = m.get('outerId')
        if m.get('params') is not None:
            self.params = m.get('params')
        if m.get('path') is not None:
            self.path = m.get('path')
        return self


class HrmPtsServiceResponseBody(TeaModel):
    def __init__(
        self,
        biz_success: bool = None,
        error_code: str = None,
        error_msg: str = None,
        result: Dict[str, Any] = None,
    ):
        self.biz_success = biz_success
        self.error_code = error_code
        self.error_msg = error_msg
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_success is not None:
            result['bizSuccess'] = self.biz_success
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizSuccess') is not None:
            self.biz_success = m.get('bizSuccess')
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class HrmPtsServiceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: HrmPtsServiceResponseBody = None,
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
            temp_model = HrmPtsServiceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class InvalidSignRecordsHeaders(TeaModel):
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


class InvalidSignRecordsRequest(TeaModel):
    def __init__(
        self,
        invalid_user_id: str = None,
        sign_record_ids: List[str] = None,
        status_remark: str = None,
    ):
        # This parameter is required.
        self.invalid_user_id = invalid_user_id
        # This parameter is required.
        self.sign_record_ids = sign_record_ids
        # This parameter is required.
        self.status_remark = status_remark

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.invalid_user_id is not None:
            result['invalidUserId'] = self.invalid_user_id
        if self.sign_record_ids is not None:
            result['signRecordIds'] = self.sign_record_ids
        if self.status_remark is not None:
            result['statusRemark'] = self.status_remark
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('invalidUserId') is not None:
            self.invalid_user_id = m.get('invalidUserId')
        if m.get('signRecordIds') is not None:
            self.sign_record_ids = m.get('signRecordIds')
        if m.get('statusRemark') is not None:
            self.status_remark = m.get('statusRemark')
        return self


class InvalidSignRecordsResponseBodyResultFailItems(TeaModel):
    def __init__(
        self,
        item_id: str = None,
        type: str = None,
    ):
        self.item_id = item_id
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.item_id is not None:
            result['itemId'] = self.item_id
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('itemId') is not None:
            self.item_id = m.get('itemId')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class InvalidSignRecordsResponseBodyResultSuccessItems(TeaModel):
    def __init__(
        self,
        item_id: str = None,
    ):
        self.item_id = item_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.item_id is not None:
            result['itemId'] = self.item_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('itemId') is not None:
            self.item_id = m.get('itemId')
        return self


class InvalidSignRecordsResponseBodyResult(TeaModel):
    def __init__(
        self,
        fail_items: List[InvalidSignRecordsResponseBodyResultFailItems] = None,
        success_items: List[InvalidSignRecordsResponseBodyResultSuccessItems] = None,
    ):
        self.fail_items = fail_items
        self.success_items = success_items

    def validate(self):
        if self.fail_items:
            for k in self.fail_items:
                if k:
                    k.validate()
        if self.success_items:
            for k in self.success_items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['failItems'] = []
        if self.fail_items is not None:
            for k in self.fail_items:
                result['failItems'].append(k.to_map() if k else None)
        result['successItems'] = []
        if self.success_items is not None:
            for k in self.success_items:
                result['successItems'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.fail_items = []
        if m.get('failItems') is not None:
            for k in m.get('failItems'):
                temp_model = InvalidSignRecordsResponseBodyResultFailItems()
                self.fail_items.append(temp_model.from_map(k))
        self.success_items = []
        if m.get('successItems') is not None:
            for k in m.get('successItems'):
                temp_model = InvalidSignRecordsResponseBodyResultSuccessItems()
                self.success_items.append(temp_model.from_map(k))
        return self


class InvalidSignRecordsResponseBody(TeaModel):
    def __init__(
        self,
        result: InvalidSignRecordsResponseBodyResult = None,
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
            temp_model = InvalidSignRecordsResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class InvalidSignRecordsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: InvalidSignRecordsResponseBody = None,
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
            temp_model = InvalidSignRecordsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class MasterDataDeleteHeaders(TeaModel):
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


class MasterDataDeleteRequestBodyFieldList(TeaModel):
    def __init__(
        self,
        name: str = None,
        value_str: str = None,
    ):
        self.name = name
        self.value_str = value_str

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.value_str is not None:
            result['valueStr'] = self.value_str
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('valueStr') is not None:
            self.value_str = m.get('valueStr')
        return self


class MasterDataDeleteRequestBodyScope(TeaModel):
    def __init__(
        self,
        scope_code: str = None,
        version: int = None,
    ):
        # This parameter is required.
        self.scope_code = scope_code
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.scope_code is not None:
            result['scopeCode'] = self.scope_code
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('scopeCode') is not None:
            self.scope_code = m.get('scopeCode')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class MasterDataDeleteRequestBody(TeaModel):
    def __init__(
        self,
        biz_time: int = None,
        biz_uk: str = None,
        entity_code: str = None,
        field_list: List[MasterDataDeleteRequestBodyFieldList] = None,
        scope: MasterDataDeleteRequestBodyScope = None,
    ):
        # This parameter is required.
        self.biz_time = biz_time
        # This parameter is required.
        self.biz_uk = biz_uk
        self.entity_code = entity_code
        self.field_list = field_list
        # This parameter is required.
        self.scope = scope

    def validate(self):
        if self.field_list:
            for k in self.field_list:
                if k:
                    k.validate()
        if self.scope:
            self.scope.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_time is not None:
            result['bizTime'] = self.biz_time
        if self.biz_uk is not None:
            result['bizUk'] = self.biz_uk
        if self.entity_code is not None:
            result['entityCode'] = self.entity_code
        result['fieldList'] = []
        if self.field_list is not None:
            for k in self.field_list:
                result['fieldList'].append(k.to_map() if k else None)
        if self.scope is not None:
            result['scope'] = self.scope.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizTime') is not None:
            self.biz_time = m.get('bizTime')
        if m.get('bizUk') is not None:
            self.biz_uk = m.get('bizUk')
        if m.get('entityCode') is not None:
            self.entity_code = m.get('entityCode')
        self.field_list = []
        if m.get('fieldList') is not None:
            for k in m.get('fieldList'):
                temp_model = MasterDataDeleteRequestBodyFieldList()
                self.field_list.append(temp_model.from_map(k))
        if m.get('scope') is not None:
            temp_model = MasterDataDeleteRequestBodyScope()
            self.scope = temp_model.from_map(m['scope'])
        return self


class MasterDataDeleteRequest(TeaModel):
    def __init__(
        self,
        body: List[MasterDataDeleteRequestBody] = None,
        tenant_id: int = None,
    ):
        # This parameter is required.
        self.body = body
        # This parameter is required.
        self.tenant_id = tenant_id

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
        if self.tenant_id is not None:
            result['tenantId'] = self.tenant_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.body = []
        if m.get('body') is not None:
            for k in m.get('body'):
                temp_model = MasterDataDeleteRequestBody()
                self.body.append(temp_model.from_map(k))
        if m.get('tenantId') is not None:
            self.tenant_id = m.get('tenantId')
        return self


class MasterDataDeleteResponseBodyFailResult(TeaModel):
    def __init__(
        self,
        biz_uk: str = None,
        error_code: str = None,
        error_msg: str = None,
        success: bool = None,
    ):
        self.biz_uk = biz_uk
        self.error_code = error_code
        self.error_msg = error_msg
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_uk is not None:
            result['bizUK'] = self.biz_uk
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizUK') is not None:
            self.biz_uk = m.get('bizUK')
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class MasterDataDeleteResponseBody(TeaModel):
    def __init__(
        self,
        all_success: bool = None,
        fail_result: List[MasterDataDeleteResponseBodyFailResult] = None,
    ):
        # This parameter is required.
        self.all_success = all_success
        self.fail_result = fail_result

    def validate(self):
        if self.fail_result:
            for k in self.fail_result:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.all_success is not None:
            result['allSuccess'] = self.all_success
        result['failResult'] = []
        if self.fail_result is not None:
            for k in self.fail_result:
                result['failResult'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('allSuccess') is not None:
            self.all_success = m.get('allSuccess')
        self.fail_result = []
        if m.get('failResult') is not None:
            for k in m.get('failResult'):
                temp_model = MasterDataDeleteResponseBodyFailResult()
                self.fail_result.append(temp_model.from_map(k))
        return self


class MasterDataDeleteResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: MasterDataDeleteResponseBody = None,
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
            temp_model = MasterDataDeleteResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class MasterDataQueryHeaders(TeaModel):
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


class MasterDataQueryRequestQueryParamsConditionList(TeaModel):
    def __init__(
        self,
        operate: str = None,
        value: str = None,
    ):
        self.operate = operate
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operate is not None:
            result['operate'] = self.operate
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operate') is not None:
            self.operate = m.get('operate')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class MasterDataQueryRequestQueryParams(TeaModel):
    def __init__(
        self,
        condition_list: List[MasterDataQueryRequestQueryParamsConditionList] = None,
        field_code: str = None,
        join_type: str = None,
    ):
        self.condition_list = condition_list
        self.field_code = field_code
        self.join_type = join_type

    def validate(self):
        if self.condition_list:
            for k in self.condition_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['conditionList'] = []
        if self.condition_list is not None:
            for k in self.condition_list:
                result['conditionList'].append(k.to_map() if k else None)
        if self.field_code is not None:
            result['fieldCode'] = self.field_code
        if self.join_type is not None:
            result['joinType'] = self.join_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.condition_list = []
        if m.get('conditionList') is not None:
            for k in m.get('conditionList'):
                temp_model = MasterDataQueryRequestQueryParamsConditionList()
                self.condition_list.append(temp_model.from_map(k))
        if m.get('fieldCode') is not None:
            self.field_code = m.get('fieldCode')
        if m.get('joinType') is not None:
            self.join_type = m.get('joinType')
        return self


class MasterDataQueryRequest(TeaModel):
    def __init__(
        self,
        biz_uk: str = None,
        max_results: int = None,
        next_token: int = None,
        opt_user_id: str = None,
        query_params: List[MasterDataQueryRequestQueryParams] = None,
        relation_ids: List[str] = None,
        scope_code: str = None,
        tenant_id: int = None,
        view_entity_code: str = None,
    ):
        self.biz_uk = biz_uk
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token
        self.opt_user_id = opt_user_id
        self.query_params = query_params
        # This parameter is required.
        self.relation_ids = relation_ids
        # This parameter is required.
        self.scope_code = scope_code
        # This parameter is required.
        self.tenant_id = tenant_id
        # This parameter is required.
        self.view_entity_code = view_entity_code

    def validate(self):
        if self.query_params:
            for k in self.query_params:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_uk is not None:
            result['bizUK'] = self.biz_uk
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.opt_user_id is not None:
            result['optUserId'] = self.opt_user_id
        result['queryParams'] = []
        if self.query_params is not None:
            for k in self.query_params:
                result['queryParams'].append(k.to_map() if k else None)
        if self.relation_ids is not None:
            result['relationIds'] = self.relation_ids
        if self.scope_code is not None:
            result['scopeCode'] = self.scope_code
        if self.tenant_id is not None:
            result['tenantId'] = self.tenant_id
        if self.view_entity_code is not None:
            result['viewEntityCode'] = self.view_entity_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizUK') is not None:
            self.biz_uk = m.get('bizUK')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('optUserId') is not None:
            self.opt_user_id = m.get('optUserId')
        self.query_params = []
        if m.get('queryParams') is not None:
            for k in m.get('queryParams'):
                temp_model = MasterDataQueryRequestQueryParams()
                self.query_params.append(temp_model.from_map(k))
        if m.get('relationIds') is not None:
            self.relation_ids = m.get('relationIds')
        if m.get('scopeCode') is not None:
            self.scope_code = m.get('scopeCode')
        if m.get('tenantId') is not None:
            self.tenant_id = m.get('tenantId')
        if m.get('viewEntityCode') is not None:
            self.view_entity_code = m.get('viewEntityCode')
        return self


class MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO(TeaModel):
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


class MasterDataQueryResponseBodyResultViewEntityFieldVOList(TeaModel):
    def __init__(
        self,
        field_code: str = None,
        field_data_vo: MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO = None,
        field_name: str = None,
        field_type: str = None,
    ):
        self.field_code = field_code
        self.field_data_vo = field_data_vo
        self.field_name = field_name
        self.field_type = field_type

    def validate(self):
        if self.field_data_vo:
            self.field_data_vo.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_code is not None:
            result['fieldCode'] = self.field_code
        if self.field_data_vo is not None:
            result['fieldDataVO'] = self.field_data_vo.to_map()
        if self.field_name is not None:
            result['fieldName'] = self.field_name
        if self.field_type is not None:
            result['fieldType'] = self.field_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldCode') is not None:
            self.field_code = m.get('fieldCode')
        if m.get('fieldDataVO') is not None:
            temp_model = MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO()
            self.field_data_vo = temp_model.from_map(m['fieldDataVO'])
        if m.get('fieldName') is not None:
            self.field_name = m.get('fieldName')
        if m.get('fieldType') is not None:
            self.field_type = m.get('fieldType')
        return self


class MasterDataQueryResponseBodyResult(TeaModel):
    def __init__(
        self,
        outer_id: str = None,
        relation_id: str = None,
        scope_code: str = None,
        view_entity_code: str = None,
        view_entity_field_volist: List[MasterDataQueryResponseBodyResultViewEntityFieldVOList] = None,
    ):
        self.outer_id = outer_id
        # This parameter is required.
        self.relation_id = relation_id
        # This parameter is required.
        self.scope_code = scope_code
        # This parameter is required.
        self.view_entity_code = view_entity_code
        self.view_entity_field_volist = view_entity_field_volist

    def validate(self):
        if self.view_entity_field_volist:
            for k in self.view_entity_field_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.outer_id is not None:
            result['outerId'] = self.outer_id
        if self.relation_id is not None:
            result['relationId'] = self.relation_id
        if self.scope_code is not None:
            result['scopeCode'] = self.scope_code
        if self.view_entity_code is not None:
            result['viewEntityCode'] = self.view_entity_code
        result['viewEntityFieldVOList'] = []
        if self.view_entity_field_volist is not None:
            for k in self.view_entity_field_volist:
                result['viewEntityFieldVOList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('outerId') is not None:
            self.outer_id = m.get('outerId')
        if m.get('relationId') is not None:
            self.relation_id = m.get('relationId')
        if m.get('scopeCode') is not None:
            self.scope_code = m.get('scopeCode')
        if m.get('viewEntityCode') is not None:
            self.view_entity_code = m.get('viewEntityCode')
        self.view_entity_field_volist = []
        if m.get('viewEntityFieldVOList') is not None:
            for k in m.get('viewEntityFieldVOList'):
                temp_model = MasterDataQueryResponseBodyResultViewEntityFieldVOList()
                self.view_entity_field_volist.append(temp_model.from_map(k))
        return self


class MasterDataQueryResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        next_token: int = None,
        result: List[MasterDataQueryResponseBodyResult] = None,
        success: bool = None,
        total: int = None,
    ):
        self.has_more = has_more
        self.next_token = next_token
        # This parameter is required.
        self.result = result
        # This parameter is required.
        self.success = success
        self.total = total

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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        if self.success is not None:
            result['success'] = self.success
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = MasterDataQueryResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class MasterDataQueryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: MasterDataQueryResponseBody = None,
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
            temp_model = MasterDataQueryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class MasterDataSaveHeaders(TeaModel):
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


class MasterDataSaveRequestBodyFieldList(TeaModel):
    def __init__(
        self,
        name: str = None,
        value_str: str = None,
    ):
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.value_str = value_str

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.value_str is not None:
            result['valueStr'] = self.value_str
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('valueStr') is not None:
            self.value_str = m.get('valueStr')
        return self


class MasterDataSaveRequestBodyScope(TeaModel):
    def __init__(
        self,
        scope_code: str = None,
        version: int = None,
    ):
        # This parameter is required.
        self.scope_code = scope_code
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.scope_code is not None:
            result['scopeCode'] = self.scope_code
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('scopeCode') is not None:
            self.scope_code = m.get('scopeCode')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class MasterDataSaveRequestBody(TeaModel):
    def __init__(
        self,
        biz_time: int = None,
        biz_uk: str = None,
        entity_code: str = None,
        field_list: List[MasterDataSaveRequestBodyFieldList] = None,
        scope: MasterDataSaveRequestBodyScope = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.biz_time = biz_time
        # This parameter is required.
        self.biz_uk = biz_uk
        self.entity_code = entity_code
        # This parameter is required.
        self.field_list = field_list
        # This parameter is required.
        self.scope = scope
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        if self.field_list:
            for k in self.field_list:
                if k:
                    k.validate()
        if self.scope:
            self.scope.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_time is not None:
            result['bizTime'] = self.biz_time
        if self.biz_uk is not None:
            result['bizUk'] = self.biz_uk
        if self.entity_code is not None:
            result['entityCode'] = self.entity_code
        result['fieldList'] = []
        if self.field_list is not None:
            for k in self.field_list:
                result['fieldList'].append(k.to_map() if k else None)
        if self.scope is not None:
            result['scope'] = self.scope.to_map()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizTime') is not None:
            self.biz_time = m.get('bizTime')
        if m.get('bizUk') is not None:
            self.biz_uk = m.get('bizUk')
        if m.get('entityCode') is not None:
            self.entity_code = m.get('entityCode')
        self.field_list = []
        if m.get('fieldList') is not None:
            for k in m.get('fieldList'):
                temp_model = MasterDataSaveRequestBodyFieldList()
                self.field_list.append(temp_model.from_map(k))
        if m.get('scope') is not None:
            temp_model = MasterDataSaveRequestBodyScope()
            self.scope = temp_model.from_map(m['scope'])
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class MasterDataSaveRequest(TeaModel):
    def __init__(
        self,
        body: List[MasterDataSaveRequestBody] = None,
        tenant_id: int = None,
    ):
        # This parameter is required.
        self.body = body
        # This parameter is required.
        self.tenant_id = tenant_id

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
        if self.tenant_id is not None:
            result['tenantId'] = self.tenant_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.body = []
        if m.get('body') is not None:
            for k in m.get('body'):
                temp_model = MasterDataSaveRequestBody()
                self.body.append(temp_model.from_map(k))
        if m.get('tenantId') is not None:
            self.tenant_id = m.get('tenantId')
        return self


class MasterDataSaveResponseBodyFailResult(TeaModel):
    def __init__(
        self,
        biz_uk: str = None,
        error_code: str = None,
        error_msg: str = None,
        success: bool = None,
    ):
        self.biz_uk = biz_uk
        self.error_code = error_code
        self.error_msg = error_msg
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_uk is not None:
            result['bizUk'] = self.biz_uk
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizUk') is not None:
            self.biz_uk = m.get('bizUk')
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class MasterDataSaveResponseBody(TeaModel):
    def __init__(
        self,
        all_success: bool = None,
        fail_result: List[MasterDataSaveResponseBodyFailResult] = None,
    ):
        # This parameter is required.
        self.all_success = all_success
        self.fail_result = fail_result

    def validate(self):
        if self.fail_result:
            for k in self.fail_result:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.all_success is not None:
            result['allSuccess'] = self.all_success
        result['failResult'] = []
        if self.fail_result is not None:
            for k in self.fail_result:
                result['failResult'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('allSuccess') is not None:
            self.all_success = m.get('allSuccess')
        self.fail_result = []
        if m.get('failResult') is not None:
            for k in m.get('failResult'):
                temp_model = MasterDataSaveResponseBodyFailResult()
                self.fail_result.append(temp_model.from_map(k))
        return self


class MasterDataSaveResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: MasterDataSaveResponseBody = None,
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
            temp_model = MasterDataSaveResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class MasterDataTenantQueyHeaders(TeaModel):
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


class MasterDataTenantQueyRequest(TeaModel):
    def __init__(
        self,
        entity_code: str = None,
        scope_code: str = None,
    ):
        # This parameter is required.
        self.entity_code = entity_code
        # This parameter is required.
        self.scope_code = scope_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.entity_code is not None:
            result['entityCode'] = self.entity_code
        if self.scope_code is not None:
            result['scopeCode'] = self.scope_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('entityCode') is not None:
            self.entity_code = m.get('entityCode')
        if m.get('scopeCode') is not None:
            self.scope_code = m.get('scopeCode')
        return self


class MasterDataTenantQueyResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_data: bool = None,
        integrate_data_auth: bool = None,
        name: str = None,
        read_auth: bool = None,
        tenant_id: int = None,
        type: int = None,
    ):
        self.has_data = has_data
        self.integrate_data_auth = integrate_data_auth
        # This parameter is required.
        self.name = name
        self.read_auth = read_auth
        # This parameter is required.
        self.tenant_id = tenant_id
        # This parameter is required.
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_data is not None:
            result['hasData'] = self.has_data
        if self.integrate_data_auth is not None:
            result['integrateDataAuth'] = self.integrate_data_auth
        if self.name is not None:
            result['name'] = self.name
        if self.read_auth is not None:
            result['readAuth'] = self.read_auth
        if self.tenant_id is not None:
            result['tenantId'] = self.tenant_id
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasData') is not None:
            self.has_data = m.get('hasData')
        if m.get('integrateDataAuth') is not None:
            self.integrate_data_auth = m.get('integrateDataAuth')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('readAuth') is not None:
            self.read_auth = m.get('readAuth')
        if m.get('tenantId') is not None:
            self.tenant_id = m.get('tenantId')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class MasterDataTenantQueyResponseBody(TeaModel):
    def __init__(
        self,
        result: List[MasterDataTenantQueyResponseBodyResult] = None,
    ):
        # This parameter is required.
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
                temp_model = MasterDataTenantQueyResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class MasterDataTenantQueyResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: MasterDataTenantQueyResponseBody = None,
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
            temp_model = MasterDataTenantQueyResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class MasterDatasGetHeaders(TeaModel):
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


class MasterDatasGetRequest(TeaModel):
    def __init__(
        self,
        obj_id: str = None,
        scope_code: str = None,
        tenant_id: int = None,
        view_entity_code: str = None,
    ):
        # This parameter is required.
        self.obj_id = obj_id
        # This parameter is required.
        self.scope_code = scope_code
        # This parameter is required.
        self.tenant_id = tenant_id
        # This parameter is required.
        self.view_entity_code = view_entity_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.obj_id is not None:
            result['objId'] = self.obj_id
        if self.scope_code is not None:
            result['scopeCode'] = self.scope_code
        if self.tenant_id is not None:
            result['tenantId'] = self.tenant_id
        if self.view_entity_code is not None:
            result['viewEntityCode'] = self.view_entity_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('objId') is not None:
            self.obj_id = m.get('objId')
        if m.get('scopeCode') is not None:
            self.scope_code = m.get('scopeCode')
        if m.get('tenantId') is not None:
            self.tenant_id = m.get('tenantId')
        if m.get('viewEntityCode') is not None:
            self.view_entity_code = m.get('viewEntityCode')
        return self


class MasterDatasGetResponseBodyResultViewEntityFieldVOListFieldDataVO(TeaModel):
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


class MasterDatasGetResponseBodyResultViewEntityFieldVOList(TeaModel):
    def __init__(
        self,
        field_code: str = None,
        field_data_vo: MasterDatasGetResponseBodyResultViewEntityFieldVOListFieldDataVO = None,
        field_name: str = None,
        field_type: str = None,
    ):
        self.field_code = field_code
        self.field_data_vo = field_data_vo
        self.field_name = field_name
        self.field_type = field_type

    def validate(self):
        if self.field_data_vo:
            self.field_data_vo.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_code is not None:
            result['fieldCode'] = self.field_code
        if self.field_data_vo is not None:
            result['fieldDataVO'] = self.field_data_vo.to_map()
        if self.field_name is not None:
            result['fieldName'] = self.field_name
        if self.field_type is not None:
            result['fieldType'] = self.field_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldCode') is not None:
            self.field_code = m.get('fieldCode')
        if m.get('fieldDataVO') is not None:
            temp_model = MasterDatasGetResponseBodyResultViewEntityFieldVOListFieldDataVO()
            self.field_data_vo = temp_model.from_map(m['fieldDataVO'])
        if m.get('fieldName') is not None:
            self.field_name = m.get('fieldName')
        if m.get('fieldType') is not None:
            self.field_type = m.get('fieldType')
        return self


class MasterDatasGetResponseBodyResult(TeaModel):
    def __init__(
        self,
        obj_id: str = None,
        relation_id: str = None,
        scope_code: str = None,
        view_entity_code: str = None,
        view_entity_field_volist: List[MasterDatasGetResponseBodyResultViewEntityFieldVOList] = None,
    ):
        self.obj_id = obj_id
        # This parameter is required.
        self.relation_id = relation_id
        self.scope_code = scope_code
        self.view_entity_code = view_entity_code
        self.view_entity_field_volist = view_entity_field_volist

    def validate(self):
        if self.view_entity_field_volist:
            for k in self.view_entity_field_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.obj_id is not None:
            result['objId'] = self.obj_id
        if self.relation_id is not None:
            result['relationId'] = self.relation_id
        if self.scope_code is not None:
            result['scopeCode'] = self.scope_code
        if self.view_entity_code is not None:
            result['viewEntityCode'] = self.view_entity_code
        result['viewEntityFieldVOList'] = []
        if self.view_entity_field_volist is not None:
            for k in self.view_entity_field_volist:
                result['viewEntityFieldVOList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('objId') is not None:
            self.obj_id = m.get('objId')
        if m.get('relationId') is not None:
            self.relation_id = m.get('relationId')
        if m.get('scopeCode') is not None:
            self.scope_code = m.get('scopeCode')
        if m.get('viewEntityCode') is not None:
            self.view_entity_code = m.get('viewEntityCode')
        self.view_entity_field_volist = []
        if m.get('viewEntityFieldVOList') is not None:
            for k in m.get('viewEntityFieldVOList'):
                temp_model = MasterDatasGetResponseBodyResultViewEntityFieldVOList()
                self.view_entity_field_volist.append(temp_model.from_map(k))
        return self


class MasterDatasGetResponseBody(TeaModel):
    def __init__(
        self,
        result: MasterDatasGetResponseBodyResult = None,
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
            temp_model = MasterDatasGetResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class MasterDatasGetResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: MasterDatasGetResponseBody = None,
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
            temp_model = MasterDatasGetResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class MasterDatasQueryHeaders(TeaModel):
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


class MasterDatasQueryRequestQueryParamsConditionList(TeaModel):
    def __init__(
        self,
        operate: str = None,
        value: str = None,
    ):
        self.operate = operate
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operate is not None:
            result['operate'] = self.operate
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operate') is not None:
            self.operate = m.get('operate')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class MasterDatasQueryRequestQueryParams(TeaModel):
    def __init__(
        self,
        condition_list: List[MasterDatasQueryRequestQueryParamsConditionList] = None,
        field_code: str = None,
        join_type: str = None,
    ):
        self.condition_list = condition_list
        self.field_code = field_code
        self.join_type = join_type

    def validate(self):
        if self.condition_list:
            for k in self.condition_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['conditionList'] = []
        if self.condition_list is not None:
            for k in self.condition_list:
                result['conditionList'].append(k.to_map() if k else None)
        if self.field_code is not None:
            result['fieldCode'] = self.field_code
        if self.join_type is not None:
            result['joinType'] = self.join_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.condition_list = []
        if m.get('conditionList') is not None:
            for k in m.get('conditionList'):
                temp_model = MasterDatasQueryRequestQueryParamsConditionList()
                self.condition_list.append(temp_model.from_map(k))
        if m.get('fieldCode') is not None:
            self.field_code = m.get('fieldCode')
        if m.get('joinType') is not None:
            self.join_type = m.get('joinType')
        return self


class MasterDatasQueryRequest(TeaModel):
    def __init__(
        self,
        biz_uk: str = None,
        max_results: int = None,
        next_token: int = None,
        query_params: List[MasterDatasQueryRequestQueryParams] = None,
        relation_ids: List[str] = None,
        scope_code: str = None,
        tenant_id: int = None,
        view_entity_code: str = None,
    ):
        self.biz_uk = biz_uk
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token
        self.query_params = query_params
        # This parameter is required.
        self.relation_ids = relation_ids
        # This parameter is required.
        self.scope_code = scope_code
        # This parameter is required.
        self.tenant_id = tenant_id
        # This parameter is required.
        self.view_entity_code = view_entity_code

    def validate(self):
        if self.query_params:
            for k in self.query_params:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_uk is not None:
            result['bizUK'] = self.biz_uk
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['queryParams'] = []
        if self.query_params is not None:
            for k in self.query_params:
                result['queryParams'].append(k.to_map() if k else None)
        if self.relation_ids is not None:
            result['relationIds'] = self.relation_ids
        if self.scope_code is not None:
            result['scopeCode'] = self.scope_code
        if self.tenant_id is not None:
            result['tenantId'] = self.tenant_id
        if self.view_entity_code is not None:
            result['viewEntityCode'] = self.view_entity_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizUK') is not None:
            self.biz_uk = m.get('bizUK')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.query_params = []
        if m.get('queryParams') is not None:
            for k in m.get('queryParams'):
                temp_model = MasterDatasQueryRequestQueryParams()
                self.query_params.append(temp_model.from_map(k))
        if m.get('relationIds') is not None:
            self.relation_ids = m.get('relationIds')
        if m.get('scopeCode') is not None:
            self.scope_code = m.get('scopeCode')
        if m.get('tenantId') is not None:
            self.tenant_id = m.get('tenantId')
        if m.get('viewEntityCode') is not None:
            self.view_entity_code = m.get('viewEntityCode')
        return self


class MasterDatasQueryResponseBodyResultViewEntityFieldVOListFieldDataVO(TeaModel):
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


class MasterDatasQueryResponseBodyResultViewEntityFieldVOList(TeaModel):
    def __init__(
        self,
        field_code: str = None,
        field_data_vo: MasterDatasQueryResponseBodyResultViewEntityFieldVOListFieldDataVO = None,
        field_name: str = None,
        field_type: str = None,
    ):
        self.field_code = field_code
        self.field_data_vo = field_data_vo
        self.field_name = field_name
        self.field_type = field_type

    def validate(self):
        if self.field_data_vo:
            self.field_data_vo.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_code is not None:
            result['fieldCode'] = self.field_code
        if self.field_data_vo is not None:
            result['fieldDataVO'] = self.field_data_vo.to_map()
        if self.field_name is not None:
            result['fieldName'] = self.field_name
        if self.field_type is not None:
            result['fieldType'] = self.field_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldCode') is not None:
            self.field_code = m.get('fieldCode')
        if m.get('fieldDataVO') is not None:
            temp_model = MasterDatasQueryResponseBodyResultViewEntityFieldVOListFieldDataVO()
            self.field_data_vo = temp_model.from_map(m['fieldDataVO'])
        if m.get('fieldName') is not None:
            self.field_name = m.get('fieldName')
        if m.get('fieldType') is not None:
            self.field_type = m.get('fieldType')
        return self


class MasterDatasQueryResponseBodyResult(TeaModel):
    def __init__(
        self,
        obj_id: str = None,
        relation_id: str = None,
        scope_code: str = None,
        view_entity_code: str = None,
        view_entity_field_volist: List[MasterDatasQueryResponseBodyResultViewEntityFieldVOList] = None,
    ):
        self.obj_id = obj_id
        # This parameter is required.
        self.relation_id = relation_id
        self.scope_code = scope_code
        self.view_entity_code = view_entity_code
        self.view_entity_field_volist = view_entity_field_volist

    def validate(self):
        if self.view_entity_field_volist:
            for k in self.view_entity_field_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.obj_id is not None:
            result['objId'] = self.obj_id
        if self.relation_id is not None:
            result['relationId'] = self.relation_id
        if self.scope_code is not None:
            result['scopeCode'] = self.scope_code
        if self.view_entity_code is not None:
            result['viewEntityCode'] = self.view_entity_code
        result['viewEntityFieldVOList'] = []
        if self.view_entity_field_volist is not None:
            for k in self.view_entity_field_volist:
                result['viewEntityFieldVOList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('objId') is not None:
            self.obj_id = m.get('objId')
        if m.get('relationId') is not None:
            self.relation_id = m.get('relationId')
        if m.get('scopeCode') is not None:
            self.scope_code = m.get('scopeCode')
        if m.get('viewEntityCode') is not None:
            self.view_entity_code = m.get('viewEntityCode')
        self.view_entity_field_volist = []
        if m.get('viewEntityFieldVOList') is not None:
            for k in m.get('viewEntityFieldVOList'):
                temp_model = MasterDatasQueryResponseBodyResultViewEntityFieldVOList()
                self.view_entity_field_volist.append(temp_model.from_map(k))
        return self


class MasterDatasQueryResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        next_token: int = None,
        result: List[MasterDatasQueryResponseBodyResult] = None,
        success: bool = None,
        total: int = None,
    ):
        self.has_more = has_more
        self.next_token = next_token
        self.result = result
        # This parameter is required.
        self.success = success
        self.total = total

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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        if self.success is not None:
            result['success'] = self.success
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = MasterDatasQueryResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class MasterDatasQueryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: MasterDatasQueryResponseBody = None,
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
            temp_model = MasterDatasQueryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class OpenOemMicroAppHeaders(TeaModel):
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


class OpenOemMicroAppRequest(TeaModel):
    def __init__(
        self,
        tenant_id: int = None,
    ):
        self.tenant_id = tenant_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.tenant_id is not None:
            result['tenantId'] = self.tenant_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('tenantId') is not None:
            self.tenant_id = m.get('tenantId')
        return self


class OpenOemMicroAppResponseBody(TeaModel):
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


class OpenOemMicroAppResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: OpenOemMicroAppResponseBody = None,
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
            temp_model = OpenOemMicroAppResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryCustomEntryProcessesHeaders(TeaModel):
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


class QueryCustomEntryProcessesRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: int = None,
        operate_user_id: str = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        self.operate_user_id = operate_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.operate_user_id is not None:
            result['operateUserId'] = self.operate_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('operateUserId') is not None:
            self.operate_user_id = m.get('operateUserId')
        return self


class QueryCustomEntryProcessesResponseBodyList(TeaModel):
    def __init__(
        self,
        form_desc: str = None,
        form_id: str = None,
        form_name: str = None,
        short_url: str = None,
    ):
        self.form_desc = form_desc
        self.form_id = form_id
        self.form_name = form_name
        self.short_url = short_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.form_desc is not None:
            result['formDesc'] = self.form_desc
        if self.form_id is not None:
            result['formId'] = self.form_id
        if self.form_name is not None:
            result['formName'] = self.form_name
        if self.short_url is not None:
            result['shortUrl'] = self.short_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('formDesc') is not None:
            self.form_desc = m.get('formDesc')
        if m.get('formId') is not None:
            self.form_id = m.get('formId')
        if m.get('formName') is not None:
            self.form_name = m.get('formName')
        if m.get('shortUrl') is not None:
            self.short_url = m.get('shortUrl')
        return self


class QueryCustomEntryProcessesResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QueryCustomEntryProcessesResponseBodyList] = None,
        next_token: int = None,
    ):
        self.has_more = has_more
        self.list = list
        self.next_token = next_token

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
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryCustomEntryProcessesResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class QueryCustomEntryProcessesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryCustomEntryProcessesResponseBody = None,
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
            temp_model = QueryCustomEntryProcessesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryDismissionStaffIdListHeaders(TeaModel):
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


class QueryDismissionStaffIdListRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: int = None,
    ):
        self.max_results = max_results
        self.next_token = next_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class QueryDismissionStaffIdListResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        next_token: int = None,
        user_id_list: List[str] = None,
    ):
        self.has_more = has_more
        self.next_token = next_token
        self.user_id_list = user_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        return self


class QueryDismissionStaffIdListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryDismissionStaffIdListResponseBody = None,
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
            temp_model = QueryDismissionStaffIdListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryHrmEmployeeDismissionInfoHeaders(TeaModel):
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


class QueryHrmEmployeeDismissionInfoRequest(TeaModel):
    def __init__(
        self,
        user_id_list: List[str] = None,
    ):
        # This parameter is required.
        self.user_id_list = user_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        return self


class QueryHrmEmployeeDismissionInfoShrinkRequest(TeaModel):
    def __init__(
        self,
        user_id_list_shrink: str = None,
    ):
        # This parameter is required.
        self.user_id_list_shrink = user_id_list_shrink

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id_list_shrink is not None:
            result['userIdList'] = self.user_id_list_shrink
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userIdList') is not None:
            self.user_id_list_shrink = m.get('userIdList')
        return self


class QueryHrmEmployeeDismissionInfoResponseBodyResultDeptList(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        dept_path: str = None,
    ):
        self.dept_id = dept_id
        self.dept_path = dept_path

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['dept_id'] = self.dept_id
        if self.dept_path is not None:
            result['dept_path'] = self.dept_path
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dept_id') is not None:
            self.dept_id = m.get('dept_id')
        if m.get('dept_path') is not None:
            self.dept_path = m.get('dept_path')
        return self


class QueryHrmEmployeeDismissionInfoResponseBodyResult(TeaModel):
    def __init__(
        self,
        dept_list: List[QueryHrmEmployeeDismissionInfoResponseBodyResultDeptList] = None,
        handover_user_id: str = None,
        last_work_day: int = None,
        main_dept_id: int = None,
        main_dept_name: str = None,
        name: str = None,
        passive_reason: List[str] = None,
        pre_status: int = None,
        reason_memo: str = None,
        status: int = None,
        user_id: str = None,
        voluntary_reason: List[str] = None,
    ):
        self.dept_list = dept_list
        self.handover_user_id = handover_user_id
        self.last_work_day = last_work_day
        self.main_dept_id = main_dept_id
        self.main_dept_name = main_dept_name
        self.name = name
        self.passive_reason = passive_reason
        self.pre_status = pre_status
        self.reason_memo = reason_memo
        self.status = status
        self.user_id = user_id
        self.voluntary_reason = voluntary_reason

    def validate(self):
        if self.dept_list:
            for k in self.dept_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['deptList'] = []
        if self.dept_list is not None:
            for k in self.dept_list:
                result['deptList'].append(k.to_map() if k else None)
        if self.handover_user_id is not None:
            result['handoverUserId'] = self.handover_user_id
        if self.last_work_day is not None:
            result['lastWorkDay'] = self.last_work_day
        if self.main_dept_id is not None:
            result['mainDeptId'] = self.main_dept_id
        if self.main_dept_name is not None:
            result['mainDeptName'] = self.main_dept_name
        if self.name is not None:
            result['name'] = self.name
        if self.passive_reason is not None:
            result['passiveReason'] = self.passive_reason
        if self.pre_status is not None:
            result['preStatus'] = self.pre_status
        if self.reason_memo is not None:
            result['reasonMemo'] = self.reason_memo
        if self.status is not None:
            result['status'] = self.status
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.voluntary_reason is not None:
            result['voluntaryReason'] = self.voluntary_reason
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.dept_list = []
        if m.get('deptList') is not None:
            for k in m.get('deptList'):
                temp_model = QueryHrmEmployeeDismissionInfoResponseBodyResultDeptList()
                self.dept_list.append(temp_model.from_map(k))
        if m.get('handoverUserId') is not None:
            self.handover_user_id = m.get('handoverUserId')
        if m.get('lastWorkDay') is not None:
            self.last_work_day = m.get('lastWorkDay')
        if m.get('mainDeptId') is not None:
            self.main_dept_id = m.get('mainDeptId')
        if m.get('mainDeptName') is not None:
            self.main_dept_name = m.get('mainDeptName')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('passiveReason') is not None:
            self.passive_reason = m.get('passiveReason')
        if m.get('preStatus') is not None:
            self.pre_status = m.get('preStatus')
        if m.get('reasonMemo') is not None:
            self.reason_memo = m.get('reasonMemo')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('voluntaryReason') is not None:
            self.voluntary_reason = m.get('voluntaryReason')
        return self


class QueryHrmEmployeeDismissionInfoResponseBody(TeaModel):
    def __init__(
        self,
        result: List[QueryHrmEmployeeDismissionInfoResponseBodyResult] = None,
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
                temp_model = QueryHrmEmployeeDismissionInfoResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class QueryHrmEmployeeDismissionInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryHrmEmployeeDismissionInfoResponseBody = None,
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
            temp_model = QueryHrmEmployeeDismissionInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryJobRanksHeaders(TeaModel):
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


class QueryJobRanksRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: int = None,
        rank_category_id: str = None,
        rank_code: str = None,
        rank_name: str = None,
    ):
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token
        self.rank_category_id = rank_category_id
        self.rank_code = rank_code
        self.rank_name = rank_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.rank_category_id is not None:
            result['rankCategoryId'] = self.rank_category_id
        if self.rank_code is not None:
            result['rankCode'] = self.rank_code
        if self.rank_name is not None:
            result['rankName'] = self.rank_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('rankCategoryId') is not None:
            self.rank_category_id = m.get('rankCategoryId')
        if m.get('rankCode') is not None:
            self.rank_code = m.get('rankCode')
        if m.get('rankName') is not None:
            self.rank_name = m.get('rankName')
        return self


class QueryJobRanksResponseBodyList(TeaModel):
    def __init__(
        self,
        max_job_grade: int = None,
        min_job_grade: int = None,
        rank_category_id: str = None,
        rank_code: str = None,
        rank_description: str = None,
        rank_id: str = None,
        rank_name: str = None,
    ):
        self.max_job_grade = max_job_grade
        self.min_job_grade = min_job_grade
        self.rank_category_id = rank_category_id
        self.rank_code = rank_code
        self.rank_description = rank_description
        self.rank_id = rank_id
        self.rank_name = rank_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max_job_grade is not None:
            result['maxJobGrade'] = self.max_job_grade
        if self.min_job_grade is not None:
            result['minJobGrade'] = self.min_job_grade
        if self.rank_category_id is not None:
            result['rankCategoryId'] = self.rank_category_id
        if self.rank_code is not None:
            result['rankCode'] = self.rank_code
        if self.rank_description is not None:
            result['rankDescription'] = self.rank_description
        if self.rank_id is not None:
            result['rankId'] = self.rank_id
        if self.rank_name is not None:
            result['rankName'] = self.rank_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxJobGrade') is not None:
            self.max_job_grade = m.get('maxJobGrade')
        if m.get('minJobGrade') is not None:
            self.min_job_grade = m.get('minJobGrade')
        if m.get('rankCategoryId') is not None:
            self.rank_category_id = m.get('rankCategoryId')
        if m.get('rankCode') is not None:
            self.rank_code = m.get('rankCode')
        if m.get('rankDescription') is not None:
            self.rank_description = m.get('rankDescription')
        if m.get('rankId') is not None:
            self.rank_id = m.get('rankId')
        if m.get('rankName') is not None:
            self.rank_name = m.get('rankName')
        return self


class QueryJobRanksResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QueryJobRanksResponseBodyList] = None,
        next_token: int = None,
    ):
        self.has_more = has_more
        self.list = list
        self.next_token = next_token

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
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryJobRanksResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class QueryJobRanksResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryJobRanksResponseBody = None,
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
            temp_model = QueryJobRanksResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryJobsHeaders(TeaModel):
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


class QueryJobsRequest(TeaModel):
    def __init__(
        self,
        job_name: str = None,
        max_results: int = None,
        next_token: int = None,
    ):
        self.job_name = job_name
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.job_name is not None:
            result['jobName'] = self.job_name
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('jobName') is not None:
            self.job_name = m.get('jobName')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class QueryJobsResponseBodyList(TeaModel):
    def __init__(
        self,
        job_description: str = None,
        job_id: str = None,
        job_name: str = None,
    ):
        self.job_description = job_description
        self.job_id = job_id
        self.job_name = job_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.job_description is not None:
            result['jobDescription'] = self.job_description
        if self.job_id is not None:
            result['jobId'] = self.job_id
        if self.job_name is not None:
            result['jobName'] = self.job_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('jobDescription') is not None:
            self.job_description = m.get('jobDescription')
        if m.get('jobId') is not None:
            self.job_id = m.get('jobId')
        if m.get('jobName') is not None:
            self.job_name = m.get('jobName')
        return self


class QueryJobsResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QueryJobsResponseBodyList] = None,
        next_token: int = None,
    ):
        self.has_more = has_more
        self.list = list
        self.next_token = next_token

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
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryJobsResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class QueryJobsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryJobsResponseBody = None,
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
            temp_model = QueryJobsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryMicroAppStatusHeaders(TeaModel):
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


class QueryMicroAppStatusRequest(TeaModel):
    def __init__(
        self,
        tenant_id_list: List[int] = None,
    ):
        self.tenant_id_list = tenant_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.tenant_id_list is not None:
            result['tenantIdList'] = self.tenant_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('tenantIdList') is not None:
            self.tenant_id_list = m.get('tenantIdList')
        return self


class QueryMicroAppStatusResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: Dict[str, ResultValue] = None,
        success: bool = None,
    ):
        self.request_id = request_id
        self.result = result
        self.success = success

    def validate(self):
        if self.result:
            for v in self.result.values():
                if v:
                    v.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        result['result'] = {}
        if self.result is not None:
            for k, v in self.result.items():
                result['result'][k] = v.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        self.result = {}
        if m.get('result') is not None:
            for k, v in m.get('result').items():
                temp_model = ResultValue()
                self.result[k] = temp_model.from_map(v)
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryMicroAppStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryMicroAppStatusResponseBody = None,
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
            temp_model = QueryMicroAppStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryMicroAppViewHeaders(TeaModel):
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


class QueryMicroAppViewRequest(TeaModel):
    def __init__(
        self,
        tenant_id_list: List[int] = None,
        view_user_id: str = None,
    ):
        self.tenant_id_list = tenant_id_list
        self.view_user_id = view_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.tenant_id_list is not None:
            result['tenantIdList'] = self.tenant_id_list
        if self.view_user_id is not None:
            result['viewUserId'] = self.view_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('tenantIdList') is not None:
            self.tenant_id_list = m.get('tenantIdList')
        if m.get('viewUserId') is not None:
            self.view_user_id = m.get('viewUserId')
        return self


class QueryMicroAppViewResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: Dict[str, bool] = None,
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


class QueryMicroAppViewResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryMicroAppViewResponseBody = None,
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
            temp_model = QueryMicroAppViewResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryPositionsHeaders(TeaModel):
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


class QueryPositionsRequest(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        in_category_ids: List[str] = None,
        in_position_ids: List[str] = None,
        position_name: str = None,
        max_results: int = None,
        next_token: int = None,
    ):
        self.dept_id = dept_id
        self.in_category_ids = in_category_ids
        self.in_position_ids = in_position_ids
        self.position_name = position_name
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.in_category_ids is not None:
            result['inCategoryIds'] = self.in_category_ids
        if self.in_position_ids is not None:
            result['inPositionIds'] = self.in_position_ids
        if self.position_name is not None:
            result['positionName'] = self.position_name
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('inCategoryIds') is not None:
            self.in_category_ids = m.get('inCategoryIds')
        if m.get('inPositionIds') is not None:
            self.in_position_ids = m.get('inPositionIds')
        if m.get('positionName') is not None:
            self.position_name = m.get('positionName')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class QueryPositionsResponseBodyList(TeaModel):
    def __init__(
        self,
        job_id: str = None,
        position_category_id: str = None,
        position_des: str = None,
        position_id: str = None,
        position_name: str = None,
        rank_id_list: List[str] = None,
        status: int = None,
    ):
        self.job_id = job_id
        self.position_category_id = position_category_id
        self.position_des = position_des
        self.position_id = position_id
        self.position_name = position_name
        self.rank_id_list = rank_id_list
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.job_id is not None:
            result['jobId'] = self.job_id
        if self.position_category_id is not None:
            result['positionCategoryId'] = self.position_category_id
        if self.position_des is not None:
            result['positionDes'] = self.position_des
        if self.position_id is not None:
            result['positionId'] = self.position_id
        if self.position_name is not None:
            result['positionName'] = self.position_name
        if self.rank_id_list is not None:
            result['rankIdList'] = self.rank_id_list
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('jobId') is not None:
            self.job_id = m.get('jobId')
        if m.get('positionCategoryId') is not None:
            self.position_category_id = m.get('positionCategoryId')
        if m.get('positionDes') is not None:
            self.position_des = m.get('positionDes')
        if m.get('positionId') is not None:
            self.position_id = m.get('positionId')
        if m.get('positionName') is not None:
            self.position_name = m.get('positionName')
        if m.get('rankIdList') is not None:
            self.rank_id_list = m.get('rankIdList')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class QueryPositionsResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QueryPositionsResponseBodyList] = None,
        next_token: int = None,
    ):
        self.has_more = has_more
        self.list = list
        self.next_token = next_token

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
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryPositionsResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class QueryPositionsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryPositionsResponseBody = None,
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
            temp_model = QueryPositionsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RevokeSignRecordsHeaders(TeaModel):
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


class RevokeSignRecordsRequest(TeaModel):
    def __init__(
        self,
        revoke_user_id: str = None,
        sign_record_ids: List[str] = None,
        status_remark: str = None,
    ):
        # This parameter is required.
        self.revoke_user_id = revoke_user_id
        # This parameter is required.
        self.sign_record_ids = sign_record_ids
        # This parameter is required.
        self.status_remark = status_remark

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.revoke_user_id is not None:
            result['revokeUserId'] = self.revoke_user_id
        if self.sign_record_ids is not None:
            result['signRecordIds'] = self.sign_record_ids
        if self.status_remark is not None:
            result['statusRemark'] = self.status_remark
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('revokeUserId') is not None:
            self.revoke_user_id = m.get('revokeUserId')
        if m.get('signRecordIds') is not None:
            self.sign_record_ids = m.get('signRecordIds')
        if m.get('statusRemark') is not None:
            self.status_remark = m.get('statusRemark')
        return self


class RevokeSignRecordsResponseBodyResultFailItems(TeaModel):
    def __init__(
        self,
        item_id: str = None,
        type: str = None,
    ):
        self.item_id = item_id
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.item_id is not None:
            result['itemId'] = self.item_id
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('itemId') is not None:
            self.item_id = m.get('itemId')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class RevokeSignRecordsResponseBodyResultSuccessItems(TeaModel):
    def __init__(
        self,
        item_id: str = None,
    ):
        self.item_id = item_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.item_id is not None:
            result['itemId'] = self.item_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('itemId') is not None:
            self.item_id = m.get('itemId')
        return self


class RevokeSignRecordsResponseBodyResult(TeaModel):
    def __init__(
        self,
        fail_items: List[RevokeSignRecordsResponseBodyResultFailItems] = None,
        success_items: List[RevokeSignRecordsResponseBodyResultSuccessItems] = None,
    ):
        self.fail_items = fail_items
        self.success_items = success_items

    def validate(self):
        if self.fail_items:
            for k in self.fail_items:
                if k:
                    k.validate()
        if self.success_items:
            for k in self.success_items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['failItems'] = []
        if self.fail_items is not None:
            for k in self.fail_items:
                result['failItems'].append(k.to_map() if k else None)
        result['successItems'] = []
        if self.success_items is not None:
            for k in self.success_items:
                result['successItems'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.fail_items = []
        if m.get('failItems') is not None:
            for k in m.get('failItems'):
                temp_model = RevokeSignRecordsResponseBodyResultFailItems()
                self.fail_items.append(temp_model.from_map(k))
        self.success_items = []
        if m.get('successItems') is not None:
            for k in m.get('successItems'):
                temp_model = RevokeSignRecordsResponseBodyResultSuccessItems()
                self.success_items.append(temp_model.from_map(k))
        return self


class RevokeSignRecordsResponseBody(TeaModel):
    def __init__(
        self,
        result: RevokeSignRecordsResponseBodyResult = None,
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
            temp_model = RevokeSignRecordsResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class RevokeSignRecordsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RevokeSignRecordsResponseBody = None,
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
            temp_model = RevokeSignRecordsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RosterMetaAvailableFieldListHeaders(TeaModel):
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


class RosterMetaAvailableFieldListRequest(TeaModel):
    def __init__(
        self,
        app_agent_id: int = None,
    ):
        # This parameter is required.
        self.app_agent_id = app_agent_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_agent_id is not None:
            result['appAgentId'] = self.app_agent_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appAgentId') is not None:
            self.app_agent_id = m.get('appAgentId')
        return self


class RosterMetaAvailableFieldListResponseBodyResult(TeaModel):
    def __init__(
        self,
        field_code: str = None,
        field_name: str = None,
        field_type: str = None,
        option_text: str = None,
    ):
        self.field_code = field_code
        self.field_name = field_name
        self.field_type = field_type
        self.option_text = option_text

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_code is not None:
            result['fieldCode'] = self.field_code
        if self.field_name is not None:
            result['fieldName'] = self.field_name
        if self.field_type is not None:
            result['fieldType'] = self.field_type
        if self.option_text is not None:
            result['optionText'] = self.option_text
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldCode') is not None:
            self.field_code = m.get('fieldCode')
        if m.get('fieldName') is not None:
            self.field_name = m.get('fieldName')
        if m.get('fieldType') is not None:
            self.field_type = m.get('fieldType')
        if m.get('optionText') is not None:
            self.option_text = m.get('optionText')
        return self


class RosterMetaAvailableFieldListResponseBody(TeaModel):
    def __init__(
        self,
        result: List[RosterMetaAvailableFieldListResponseBodyResult] = None,
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
                temp_model = RosterMetaAvailableFieldListResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class RosterMetaAvailableFieldListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RosterMetaAvailableFieldListResponseBody = None,
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
            temp_model = RosterMetaAvailableFieldListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RosterMetaFieldOptionsUpdateHeaders(TeaModel):
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


class RosterMetaFieldOptionsUpdateRequest(TeaModel):
    def __init__(
        self,
        app_agent_id: int = None,
        field_code: str = None,
        group_id: str = None,
        labels: List[str] = None,
        modify_type: str = None,
    ):
        self.app_agent_id = app_agent_id
        # This parameter is required.
        self.field_code = field_code
        # This parameter is required.
        self.group_id = group_id
        # This parameter is required.
        self.labels = labels
        # This parameter is required.
        self.modify_type = modify_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_agent_id is not None:
            result['appAgentId'] = self.app_agent_id
        if self.field_code is not None:
            result['fieldCode'] = self.field_code
        if self.group_id is not None:
            result['groupId'] = self.group_id
        if self.labels is not None:
            result['labels'] = self.labels
        if self.modify_type is not None:
            result['modifyType'] = self.modify_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appAgentId') is not None:
            self.app_agent_id = m.get('appAgentId')
        if m.get('fieldCode') is not None:
            self.field_code = m.get('fieldCode')
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        if m.get('labels') is not None:
            self.labels = m.get('labels')
        if m.get('modifyType') is not None:
            self.modify_type = m.get('modifyType')
        return self


class RosterMetaFieldOptionsUpdateResponseBody(TeaModel):
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


class RosterMetaFieldOptionsUpdateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RosterMetaFieldOptionsUpdateResponseBody = None,
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
            temp_model = RosterMetaFieldOptionsUpdateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendIsvCardMessageHeaders(TeaModel):
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


class SendIsvCardMessageRequest(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        biz_id: str = None,
        message_type: str = None,
        receiver_user_ids: List[str] = None,
        scene_type: str = None,
        scope: str = None,
        sender_user_id: str = None,
        value_map: Dict[str, str] = None,
    ):
        # This parameter is required.
        self.agent_id = agent_id
        # This parameter is required.
        self.biz_id = biz_id
        # This parameter is required.
        self.message_type = message_type
        # This parameter is required.
        self.receiver_user_ids = receiver_user_ids
        # This parameter is required.
        self.scene_type = scene_type
        # This parameter is required.
        self.scope = scope
        # This parameter is required.
        self.sender_user_id = sender_user_id
        self.value_map = value_map

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.message_type is not None:
            result['messageType'] = self.message_type
        if self.receiver_user_ids is not None:
            result['receiverUserIds'] = self.receiver_user_ids
        if self.scene_type is not None:
            result['sceneType'] = self.scene_type
        if self.scope is not None:
            result['scope'] = self.scope
        if self.sender_user_id is not None:
            result['senderUserId'] = self.sender_user_id
        if self.value_map is not None:
            result['valueMap'] = self.value_map
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('messageType') is not None:
            self.message_type = m.get('messageType')
        if m.get('receiverUserIds') is not None:
            self.receiver_user_ids = m.get('receiverUserIds')
        if m.get('sceneType') is not None:
            self.scene_type = m.get('sceneType')
        if m.get('scope') is not None:
            self.scope = m.get('scope')
        if m.get('senderUserId') is not None:
            self.sender_user_id = m.get('senderUserId')
        if m.get('valueMap') is not None:
            self.value_map = m.get('valueMap')
        return self


class SendIsvCardMessageResponseBodyHrmInteractiveCardSendResult(TeaModel):
    def __init__(
        self,
        biz_id: str = None,
        error_code: str = None,
        error_msg: str = None,
    ):
        self.biz_id = biz_id
        self.error_code = error_code
        self.error_msg = error_msg

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        return self


class SendIsvCardMessageResponseBody(TeaModel):
    def __init__(
        self,
        error_code: str = None,
        error_msg: str = None,
        hrm_interactive_card_send_result: SendIsvCardMessageResponseBodyHrmInteractiveCardSendResult = None,
        request_id: str = None,
        success: bool = None,
    ):
        self.error_code = error_code
        self.error_msg = error_msg
        self.hrm_interactive_card_send_result = hrm_interactive_card_send_result
        self.request_id = request_id
        self.success = success

    def validate(self):
        if self.hrm_interactive_card_send_result:
            self.hrm_interactive_card_send_result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.hrm_interactive_card_send_result is not None:
            result['hrmInteractiveCardSendResult'] = self.hrm_interactive_card_send_result.to_map()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('hrmInteractiveCardSendResult') is not None:
            temp_model = SendIsvCardMessageResponseBodyHrmInteractiveCardSendResult()
            self.hrm_interactive_card_send_result = temp_model.from_map(m['hrmInteractiveCardSendResult'])
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class SendIsvCardMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SendIsvCardMessageResponseBody = None,
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
            temp_model = SendIsvCardMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SolutionTaskInitHeaders(TeaModel):
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


class SolutionTaskInitRequest(TeaModel):
    def __init__(
        self,
        category: str = None,
        claim_time: int = None,
        description: str = None,
        finish_time: int = None,
        outer_id: str = None,
        status: str = None,
        title: str = None,
        user_id: str = None,
        solution_type: str = None,
    ):
        # This parameter is required.
        self.category = category
        self.claim_time = claim_time
        self.description = description
        self.finish_time = finish_time
        # This parameter is required.
        self.outer_id = outer_id
        # This parameter is required.
        self.status = status
        # This parameter is required.
        self.title = title
        # This parameter is required.
        self.user_id = user_id
        # This parameter is required.
        self.solution_type = solution_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category is not None:
            result['category'] = self.category
        if self.claim_time is not None:
            result['claimTime'] = self.claim_time
        if self.description is not None:
            result['description'] = self.description
        if self.finish_time is not None:
            result['finishTime'] = self.finish_time
        if self.outer_id is not None:
            result['outerId'] = self.outer_id
        if self.status is not None:
            result['status'] = self.status
        if self.title is not None:
            result['title'] = self.title
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.solution_type is not None:
            result['solutionType'] = self.solution_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('claimTime') is not None:
            self.claim_time = m.get('claimTime')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('finishTime') is not None:
            self.finish_time = m.get('finishTime')
        if m.get('outerId') is not None:
            self.outer_id = m.get('outerId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('solutionType') is not None:
            self.solution_type = m.get('solutionType')
        return self


class SolutionTaskInitResponseBody(TeaModel):
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


class SolutionTaskInitResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SolutionTaskInitResponseBody = None,
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
            temp_model = SolutionTaskInitResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SolutionTaskSaveHeaders(TeaModel):
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


class SolutionTaskSaveRequest(TeaModel):
    def __init__(
        self,
        claim_time: int = None,
        description: str = None,
        finish_time: int = None,
        outer_id: str = None,
        solution_instance_id: str = None,
        start_time: int = None,
        status: str = None,
        task_type: str = None,
        template_outer_id: str = None,
        title: str = None,
        user_id: str = None,
        solution_type: str = None,
    ):
        self.claim_time = claim_time
        self.description = description
        self.finish_time = finish_time
        # This parameter is required.
        self.outer_id = outer_id
        # This parameter is required.
        self.solution_instance_id = solution_instance_id
        self.start_time = start_time
        # This parameter is required.
        self.status = status
        # This parameter is required.
        self.task_type = task_type
        self.template_outer_id = template_outer_id
        # This parameter is required.
        self.title = title
        # This parameter is required.
        self.user_id = user_id
        # This parameter is required.
        self.solution_type = solution_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.claim_time is not None:
            result['claimTime'] = self.claim_time
        if self.description is not None:
            result['description'] = self.description
        if self.finish_time is not None:
            result['finishTime'] = self.finish_time
        if self.outer_id is not None:
            result['outerId'] = self.outer_id
        if self.solution_instance_id is not None:
            result['solutionInstanceId'] = self.solution_instance_id
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.status is not None:
            result['status'] = self.status
        if self.task_type is not None:
            result['taskType'] = self.task_type
        if self.template_outer_id is not None:
            result['templateOuterId'] = self.template_outer_id
        if self.title is not None:
            result['title'] = self.title
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.solution_type is not None:
            result['solutionType'] = self.solution_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('claimTime') is not None:
            self.claim_time = m.get('claimTime')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('finishTime') is not None:
            self.finish_time = m.get('finishTime')
        if m.get('outerId') is not None:
            self.outer_id = m.get('outerId')
        if m.get('solutionInstanceId') is not None:
            self.solution_instance_id = m.get('solutionInstanceId')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('taskType') is not None:
            self.task_type = m.get('taskType')
        if m.get('templateOuterId') is not None:
            self.template_outer_id = m.get('templateOuterId')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('solutionType') is not None:
            self.solution_type = m.get('solutionType')
        return self


class SolutionTaskSaveResponseBody(TeaModel):
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


class SolutionTaskSaveResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SolutionTaskSaveResponseBody = None,
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
            temp_model = SolutionTaskSaveResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SyncSolutionStatusHeaders(TeaModel):
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


class SyncSolutionStatusRequest(TeaModel):
    def __init__(
        self,
        biz_id: str = None,
        solution_status: str = None,
        solution_type: str = None,
        tenant_id: int = None,
        user_ids: List[str] = None,
    ):
        # This parameter is required.
        self.biz_id = biz_id
        # This parameter is required.
        self.solution_status = solution_status
        # This parameter is required.
        self.solution_type = solution_type
        # This parameter is required.
        self.tenant_id = tenant_id
        # This parameter is required.
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.solution_status is not None:
            result['solutionStatus'] = self.solution_status
        if self.solution_type is not None:
            result['solutionType'] = self.solution_type
        if self.tenant_id is not None:
            result['tenantId'] = self.tenant_id
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('solutionStatus') is not None:
            self.solution_status = m.get('solutionStatus')
        if m.get('solutionType') is not None:
            self.solution_type = m.get('solutionType')
        if m.get('tenantId') is not None:
            self.tenant_id = m.get('tenantId')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class SyncSolutionStatusResponseBody(TeaModel):
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


class SyncSolutionStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SyncSolutionStatusResponseBody = None,
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
            temp_model = SyncSolutionStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SyncTaskTemplateHeaders(TeaModel):
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


class SyncTaskTemplateRequestTaskScopeVO(TeaModel):
    def __init__(
        self,
        dept_ids: List[int] = None,
        position_ids: List[str] = None,
        role_ids: List[str] = None,
        user_ids: List[str] = None,
    ):
        self.dept_ids = dept_ids
        self.position_ids = position_ids
        self.role_ids = role_ids
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_ids is not None:
            result['deptIds'] = self.dept_ids
        if self.position_ids is not None:
            result['positionIds'] = self.position_ids
        if self.role_ids is not None:
            result['roleIds'] = self.role_ids
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptIds') is not None:
            self.dept_ids = m.get('deptIds')
        if m.get('positionIds') is not None:
            self.position_ids = m.get('positionIds')
        if m.get('roleIds') is not None:
            self.role_ids = m.get('roleIds')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class SyncTaskTemplateRequest(TeaModel):
    def __init__(
        self,
        delete: bool = None,
        des: str = None,
        ext: str = None,
        name: str = None,
        opt_user_id: str = None,
        outer_id: str = None,
        task_scope_vo: SyncTaskTemplateRequestTaskScopeVO = None,
        task_type: str = None,
        solution_type: str = None,
    ):
        self.delete = delete
        self.des = des
        self.ext = ext
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.opt_user_id = opt_user_id
        # This parameter is required.
        self.outer_id = outer_id
        self.task_scope_vo = task_scope_vo
        # This parameter is required.
        self.task_type = task_type
        # This parameter is required.
        self.solution_type = solution_type

    def validate(self):
        if self.task_scope_vo:
            self.task_scope_vo.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.delete is not None:
            result['delete'] = self.delete
        if self.des is not None:
            result['des'] = self.des
        if self.ext is not None:
            result['ext'] = self.ext
        if self.name is not None:
            result['name'] = self.name
        if self.opt_user_id is not None:
            result['optUserId'] = self.opt_user_id
        if self.outer_id is not None:
            result['outerId'] = self.outer_id
        if self.task_scope_vo is not None:
            result['taskScopeVO'] = self.task_scope_vo.to_map()
        if self.task_type is not None:
            result['taskType'] = self.task_type
        if self.solution_type is not None:
            result['solutionType'] = self.solution_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('delete') is not None:
            self.delete = m.get('delete')
        if m.get('des') is not None:
            self.des = m.get('des')
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('optUserId') is not None:
            self.opt_user_id = m.get('optUserId')
        if m.get('outerId') is not None:
            self.outer_id = m.get('outerId')
        if m.get('taskScopeVO') is not None:
            temp_model = SyncTaskTemplateRequestTaskScopeVO()
            self.task_scope_vo = temp_model.from_map(m['taskScopeVO'])
        if m.get('taskType') is not None:
            self.task_type = m.get('taskType')
        if m.get('solutionType') is not None:
            self.solution_type = m.get('solutionType')
        return self


class SyncTaskTemplateResponseBody(TeaModel):
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


class SyncTaskTemplateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SyncTaskTemplateResponseBody = None,
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
            temp_model = SyncTaskTemplateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateHrmLegalEntityNameHeaders(TeaModel):
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


class UpdateHrmLegalEntityNameRequest(TeaModel):
    def __init__(
        self,
        ding_tenant_id: int = None,
        legal_entity_name: str = None,
        origin_legal_entity_name: str = None,
    ):
        self.ding_tenant_id = ding_tenant_id
        # This parameter is required.
        self.legal_entity_name = legal_entity_name
        # This parameter is required.
        self.origin_legal_entity_name = origin_legal_entity_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_tenant_id is not None:
            result['dingTenantId'] = self.ding_tenant_id
        if self.legal_entity_name is not None:
            result['legalEntityName'] = self.legal_entity_name
        if self.origin_legal_entity_name is not None:
            result['originLegalEntityName'] = self.origin_legal_entity_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingTenantId') is not None:
            self.ding_tenant_id = m.get('dingTenantId')
        if m.get('legalEntityName') is not None:
            self.legal_entity_name = m.get('legalEntityName')
        if m.get('originLegalEntityName') is not None:
            self.origin_legal_entity_name = m.get('originLegalEntityName')
        return self


class UpdateHrmLegalEntityNameResponseBodyResult(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        gmt_create: int = None,
        gmt_modified: int = None,
        legal_entity_id: str = None,
        legal_entity_name: str = None,
        legal_entity_short_name: str = None,
        legal_entity_status: int = None,
        legal_person_name: str = None,
    ):
        self.corp_id = corp_id
        self.gmt_create = gmt_create
        self.gmt_modified = gmt_modified
        self.legal_entity_id = legal_entity_id
        self.legal_entity_name = legal_entity_name
        self.legal_entity_short_name = legal_entity_short_name
        self.legal_entity_status = legal_entity_status
        self.legal_person_name = legal_person_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.legal_entity_id is not None:
            result['legalEntityId'] = self.legal_entity_id
        if self.legal_entity_name is not None:
            result['legalEntityName'] = self.legal_entity_name
        if self.legal_entity_short_name is not None:
            result['legalEntityShortName'] = self.legal_entity_short_name
        if self.legal_entity_status is not None:
            result['legalEntityStatus'] = self.legal_entity_status
        if self.legal_person_name is not None:
            result['legalPersonName'] = self.legal_person_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('legalEntityId') is not None:
            self.legal_entity_id = m.get('legalEntityId')
        if m.get('legalEntityName') is not None:
            self.legal_entity_name = m.get('legalEntityName')
        if m.get('legalEntityShortName') is not None:
            self.legal_entity_short_name = m.get('legalEntityShortName')
        if m.get('legalEntityStatus') is not None:
            self.legal_entity_status = m.get('legalEntityStatus')
        if m.get('legalPersonName') is not None:
            self.legal_person_name = m.get('legalPersonName')
        return self


class UpdateHrmLegalEntityNameResponseBody(TeaModel):
    def __init__(
        self,
        result: UpdateHrmLegalEntityNameResponseBodyResult = None,
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
            temp_model = UpdateHrmLegalEntityNameResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UpdateHrmLegalEntityNameResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateHrmLegalEntityNameResponseBody = None,
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
            temp_model = UpdateHrmLegalEntityNameResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateHrmLegalEntityWithoutNameHeaders(TeaModel):
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


class UpdateHrmLegalEntityWithoutNameRequestExtManageAddress(TeaModel):
    def __init__(
        self,
        area_code: str = None,
        area_name: str = None,
        city_code: str = None,
        city_name: str = None,
        country_code: str = None,
        country_name: str = None,
        detail_address: str = None,
        global_area_type: str = None,
        province_code: str = None,
        province_name: str = None,
    ):
        self.area_code = area_code
        self.area_name = area_name
        self.city_code = city_code
        self.city_name = city_name
        self.country_code = country_code
        self.country_name = country_name
        self.detail_address = detail_address
        self.global_area_type = global_area_type
        self.province_code = province_code
        self.province_name = province_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.area_code is not None:
            result['areaCode'] = self.area_code
        if self.area_name is not None:
            result['areaName'] = self.area_name
        if self.city_code is not None:
            result['cityCode'] = self.city_code
        if self.city_name is not None:
            result['cityName'] = self.city_name
        if self.country_code is not None:
            result['countryCode'] = self.country_code
        if self.country_name is not None:
            result['countryName'] = self.country_name
        if self.detail_address is not None:
            result['detailAddress'] = self.detail_address
        if self.global_area_type is not None:
            result['globalAreaType'] = self.global_area_type
        if self.province_code is not None:
            result['provinceCode'] = self.province_code
        if self.province_name is not None:
            result['provinceName'] = self.province_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('areaCode') is not None:
            self.area_code = m.get('areaCode')
        if m.get('areaName') is not None:
            self.area_name = m.get('areaName')
        if m.get('cityCode') is not None:
            self.city_code = m.get('cityCode')
        if m.get('cityName') is not None:
            self.city_name = m.get('cityName')
        if m.get('countryCode') is not None:
            self.country_code = m.get('countryCode')
        if m.get('countryName') is not None:
            self.country_name = m.get('countryName')
        if m.get('detailAddress') is not None:
            self.detail_address = m.get('detailAddress')
        if m.get('globalAreaType') is not None:
            self.global_area_type = m.get('globalAreaType')
        if m.get('provinceCode') is not None:
            self.province_code = m.get('provinceCode')
        if m.get('provinceName') is not None:
            self.province_name = m.get('provinceName')
        return self


class UpdateHrmLegalEntityWithoutNameRequestExtRegistrationAddress(TeaModel):
    def __init__(
        self,
        area_code: str = None,
        area_name: str = None,
        city_code: str = None,
        city_name: str = None,
        country_code: str = None,
        country_name: str = None,
        detail_address: str = None,
        global_area_type: str = None,
        province_code: str = None,
        province_name: str = None,
    ):
        self.area_code = area_code
        self.area_name = area_name
        self.city_code = city_code
        self.city_name = city_name
        self.country_code = country_code
        self.country_name = country_name
        self.detail_address = detail_address
        self.global_area_type = global_area_type
        self.province_code = province_code
        self.province_name = province_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.area_code is not None:
            result['areaCode'] = self.area_code
        if self.area_name is not None:
            result['areaName'] = self.area_name
        if self.city_code is not None:
            result['cityCode'] = self.city_code
        if self.city_name is not None:
            result['cityName'] = self.city_name
        if self.country_code is not None:
            result['countryCode'] = self.country_code
        if self.country_name is not None:
            result['countryName'] = self.country_name
        if self.detail_address is not None:
            result['detailAddress'] = self.detail_address
        if self.global_area_type is not None:
            result['globalAreaType'] = self.global_area_type
        if self.province_code is not None:
            result['provinceCode'] = self.province_code
        if self.province_name is not None:
            result['provinceName'] = self.province_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('areaCode') is not None:
            self.area_code = m.get('areaCode')
        if m.get('areaName') is not None:
            self.area_name = m.get('areaName')
        if m.get('cityCode') is not None:
            self.city_code = m.get('cityCode')
        if m.get('cityName') is not None:
            self.city_name = m.get('cityName')
        if m.get('countryCode') is not None:
            self.country_code = m.get('countryCode')
        if m.get('countryName') is not None:
            self.country_name = m.get('countryName')
        if m.get('detailAddress') is not None:
            self.detail_address = m.get('detailAddress')
        if m.get('globalAreaType') is not None:
            self.global_area_type = m.get('globalAreaType')
        if m.get('provinceCode') is not None:
            self.province_code = m.get('provinceCode')
        if m.get('provinceName') is not None:
            self.province_name = m.get('provinceName')
        return self


class UpdateHrmLegalEntityWithoutNameRequestExt(TeaModel):
    def __init__(
        self,
        legal_entity_en_name: str = None,
        legal_entity_en_short_name: str = None,
        legal_entity_type: str = None,
        manage_address: UpdateHrmLegalEntityWithoutNameRequestExtManageAddress = None,
        registration_address: UpdateHrmLegalEntityWithoutNameRequestExtRegistrationAddress = None,
        registration_date: int = None,
        unified_social_credit_code: str = None,
        zip_code: str = None,
    ):
        self.legal_entity_en_name = legal_entity_en_name
        self.legal_entity_en_short_name = legal_entity_en_short_name
        self.legal_entity_type = legal_entity_type
        self.manage_address = manage_address
        self.registration_address = registration_address
        self.registration_date = registration_date
        self.unified_social_credit_code = unified_social_credit_code
        self.zip_code = zip_code

    def validate(self):
        if self.manage_address:
            self.manage_address.validate()
        if self.registration_address:
            self.registration_address.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.legal_entity_en_name is not None:
            result['legalEntityEnName'] = self.legal_entity_en_name
        if self.legal_entity_en_short_name is not None:
            result['legalEntityEnShortName'] = self.legal_entity_en_short_name
        if self.legal_entity_type is not None:
            result['legalEntityType'] = self.legal_entity_type
        if self.manage_address is not None:
            result['manageAddress'] = self.manage_address.to_map()
        if self.registration_address is not None:
            result['registrationAddress'] = self.registration_address.to_map()
        if self.registration_date is not None:
            result['registrationDate'] = self.registration_date
        if self.unified_social_credit_code is not None:
            result['unifiedSocialCreditCode'] = self.unified_social_credit_code
        if self.zip_code is not None:
            result['zipCode'] = self.zip_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('legalEntityEnName') is not None:
            self.legal_entity_en_name = m.get('legalEntityEnName')
        if m.get('legalEntityEnShortName') is not None:
            self.legal_entity_en_short_name = m.get('legalEntityEnShortName')
        if m.get('legalEntityType') is not None:
            self.legal_entity_type = m.get('legalEntityType')
        if m.get('manageAddress') is not None:
            temp_model = UpdateHrmLegalEntityWithoutNameRequestExtManageAddress()
            self.manage_address = temp_model.from_map(m['manageAddress'])
        if m.get('registrationAddress') is not None:
            temp_model = UpdateHrmLegalEntityWithoutNameRequestExtRegistrationAddress()
            self.registration_address = temp_model.from_map(m['registrationAddress'])
        if m.get('registrationDate') is not None:
            self.registration_date = m.get('registrationDate')
        if m.get('unifiedSocialCreditCode') is not None:
            self.unified_social_credit_code = m.get('unifiedSocialCreditCode')
        if m.get('zipCode') is not None:
            self.zip_code = m.get('zipCode')
        return self


class UpdateHrmLegalEntityWithoutNameRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        create_user_id: str = None,
        ext: UpdateHrmLegalEntityWithoutNameRequestExt = None,
        legal_entity_name: str = None,
        legal_entity_short_name: str = None,
        legal_entity_status: int = None,
        legal_person_name: str = None,
        ding_tenant_id: int = None,
    ):
        # This parameter is required.
        self.corp_id = corp_id
        self.create_user_id = create_user_id
        self.ext = ext
        # This parameter is required.
        self.legal_entity_name = legal_entity_name
        self.legal_entity_short_name = legal_entity_short_name
        # This parameter is required.
        self.legal_entity_status = legal_entity_status
        self.legal_person_name = legal_person_name
        self.ding_tenant_id = ding_tenant_id

    def validate(self):
        if self.ext:
            self.ext.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.create_user_id is not None:
            result['createUserId'] = self.create_user_id
        if self.ext is not None:
            result['ext'] = self.ext.to_map()
        if self.legal_entity_name is not None:
            result['legalEntityName'] = self.legal_entity_name
        if self.legal_entity_short_name is not None:
            result['legalEntityShortName'] = self.legal_entity_short_name
        if self.legal_entity_status is not None:
            result['legalEntityStatus'] = self.legal_entity_status
        if self.legal_person_name is not None:
            result['legalPersonName'] = self.legal_person_name
        if self.ding_tenant_id is not None:
            result['dingTenantId'] = self.ding_tenant_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('createUserId') is not None:
            self.create_user_id = m.get('createUserId')
        if m.get('ext') is not None:
            temp_model = UpdateHrmLegalEntityWithoutNameRequestExt()
            self.ext = temp_model.from_map(m['ext'])
        if m.get('legalEntityName') is not None:
            self.legal_entity_name = m.get('legalEntityName')
        if m.get('legalEntityShortName') is not None:
            self.legal_entity_short_name = m.get('legalEntityShortName')
        if m.get('legalEntityStatus') is not None:
            self.legal_entity_status = m.get('legalEntityStatus')
        if m.get('legalPersonName') is not None:
            self.legal_person_name = m.get('legalPersonName')
        if m.get('dingTenantId') is not None:
            self.ding_tenant_id = m.get('dingTenantId')
        return self


class UpdateHrmLegalEntityWithoutNameResponseBodyResult(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        gmt_create: int = None,
        gmt_modified: int = None,
        legal_entity_id: str = None,
        legal_entity_name: str = None,
        legal_entity_short_name: str = None,
        legal_entity_status: int = None,
        legal_person_name: str = None,
    ):
        self.corp_id = corp_id
        self.gmt_create = gmt_create
        self.gmt_modified = gmt_modified
        self.legal_entity_id = legal_entity_id
        self.legal_entity_name = legal_entity_name
        self.legal_entity_short_name = legal_entity_short_name
        self.legal_entity_status = legal_entity_status
        self.legal_person_name = legal_person_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.legal_entity_id is not None:
            result['legalEntityId'] = self.legal_entity_id
        if self.legal_entity_name is not None:
            result['legalEntityName'] = self.legal_entity_name
        if self.legal_entity_short_name is not None:
            result['legalEntityShortName'] = self.legal_entity_short_name
        if self.legal_entity_status is not None:
            result['legalEntityStatus'] = self.legal_entity_status
        if self.legal_person_name is not None:
            result['legalPersonName'] = self.legal_person_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('legalEntityId') is not None:
            self.legal_entity_id = m.get('legalEntityId')
        if m.get('legalEntityName') is not None:
            self.legal_entity_name = m.get('legalEntityName')
        if m.get('legalEntityShortName') is not None:
            self.legal_entity_short_name = m.get('legalEntityShortName')
        if m.get('legalEntityStatus') is not None:
            self.legal_entity_status = m.get('legalEntityStatus')
        if m.get('legalPersonName') is not None:
            self.legal_person_name = m.get('legalPersonName')
        return self


class UpdateHrmLegalEntityWithoutNameResponseBody(TeaModel):
    def __init__(
        self,
        result: UpdateHrmLegalEntityWithoutNameResponseBodyResult = None,
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
            temp_model = UpdateHrmLegalEntityWithoutNameResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UpdateHrmLegalEntityWithoutNameResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateHrmLegalEntityWithoutNameResponseBody = None,
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
            temp_model = UpdateHrmLegalEntityWithoutNameResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateHrmVersionRollBackStatusHeaders(TeaModel):
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


class UpdateHrmVersionRollBackStatusRequest(TeaModel):
    def __init__(
        self,
        config_value: str = None,
        opt_user_id: str = None,
    ):
        self.config_value = config_value
        self.opt_user_id = opt_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.config_value is not None:
            result['configValue'] = self.config_value
        if self.opt_user_id is not None:
            result['optUserId'] = self.opt_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('configValue') is not None:
            self.config_value = m.get('configValue')
        if m.get('optUserId') is not None:
            self.opt_user_id = m.get('optUserId')
        return self


class UpdateHrmVersionRollBackStatusResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: bool = None,
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


class UpdateHrmVersionRollBackStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateHrmVersionRollBackStatusResponseBody = None,
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
            temp_model = UpdateHrmVersionRollBackStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateIsvCardMessageHeaders(TeaModel):
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


class UpdateIsvCardMessageRequest(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        biz_id: str = None,
        message_type: str = None,
        scene_type: str = None,
        scope: str = None,
        value_map: Dict[str, str] = None,
    ):
        self.agent_id = agent_id
        # This parameter is required.
        self.biz_id = biz_id
        # This parameter is required.
        self.message_type = message_type
        # This parameter is required.
        self.scene_type = scene_type
        # This parameter is required.
        self.scope = scope
        # This parameter is required.
        self.value_map = value_map

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.message_type is not None:
            result['messageType'] = self.message_type
        if self.scene_type is not None:
            result['sceneType'] = self.scene_type
        if self.scope is not None:
            result['scope'] = self.scope
        if self.value_map is not None:
            result['valueMap'] = self.value_map
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('messageType') is not None:
            self.message_type = m.get('messageType')
        if m.get('sceneType') is not None:
            self.scene_type = m.get('sceneType')
        if m.get('scope') is not None:
            self.scope = m.get('scope')
        if m.get('valueMap') is not None:
            self.value_map = m.get('valueMap')
        return self


class UpdateIsvCardMessageResponseBody(TeaModel):
    def __init__(
        self,
        error_code: str = None,
        error_msg: str = None,
        request_id: str = None,
        success: bool = None,
    ):
        self.error_code = error_code
        self.error_msg = error_msg
        self.request_id = request_id
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UpdateIsvCardMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateIsvCardMessageResponseBody = None,
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
            temp_model = UpdateIsvCardMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UploadAttachmentHeaders(TeaModel):
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


class UploadAttachmentRequest(TeaModel):
    def __init__(
        self,
        media_id: str = None,
        user_id: str = None,
    ):
        self.media_id = media_id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.media_id is not None:
            result['mediaId'] = self.media_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mediaId') is not None:
            self.media_id = m.get('mediaId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UploadAttachmentResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UploadAttachmentResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UploadAttachmentResponseBody = None,
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
            temp_model = UploadAttachmentResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


