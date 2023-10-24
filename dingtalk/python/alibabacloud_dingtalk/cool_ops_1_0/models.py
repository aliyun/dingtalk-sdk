# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class UpdateIsvOppStatusHeaders(TeaModel):
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


class UpdateIsvOppStatusRequestIsvOpportunityStatusList(TeaModel):
    def __init__(
        self,
        isv_corp_id: str = None,
        micro_app_id: str = None,
        name: str = None,
        note: str = None,
        oper_name: str = None,
        oper_time: str = None,
        oper_user_id: str = None,
        opp_source_corp_id: str = None,
        opportunity_status: str = None,
        user_id: str = None,
    ):
        self.isv_corp_id = isv_corp_id
        self.micro_app_id = micro_app_id
        self.name = name
        self.note = note
        self.oper_name = oper_name
        self.oper_time = oper_time
        self.oper_user_id = oper_user_id
        self.opp_source_corp_id = opp_source_corp_id
        self.opportunity_status = opportunity_status
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.isv_corp_id is not None:
            result['isvCorpId'] = self.isv_corp_id
        if self.micro_app_id is not None:
            result['microAppId'] = self.micro_app_id
        if self.name is not None:
            result['name'] = self.name
        if self.note is not None:
            result['note'] = self.note
        if self.oper_name is not None:
            result['operName'] = self.oper_name
        if self.oper_time is not None:
            result['operTime'] = self.oper_time
        if self.oper_user_id is not None:
            result['operUserId'] = self.oper_user_id
        if self.opp_source_corp_id is not None:
            result['oppSourceCorpId'] = self.opp_source_corp_id
        if self.opportunity_status is not None:
            result['opportunityStatus'] = self.opportunity_status
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isvCorpId') is not None:
            self.isv_corp_id = m.get('isvCorpId')
        if m.get('microAppId') is not None:
            self.micro_app_id = m.get('microAppId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('note') is not None:
            self.note = m.get('note')
        if m.get('operName') is not None:
            self.oper_name = m.get('operName')
        if m.get('operTime') is not None:
            self.oper_time = m.get('operTime')
        if m.get('operUserId') is not None:
            self.oper_user_id = m.get('operUserId')
        if m.get('oppSourceCorpId') is not None:
            self.opp_source_corp_id = m.get('oppSourceCorpId')
        if m.get('opportunityStatus') is not None:
            self.opportunity_status = m.get('opportunityStatus')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UpdateIsvOppStatusRequest(TeaModel):
    def __init__(
        self,
        isv_opportunity_status_list: List[UpdateIsvOppStatusRequestIsvOpportunityStatusList] = None,
    ):
        self.isv_opportunity_status_list = isv_opportunity_status_list

    def validate(self):
        if self.isv_opportunity_status_list:
            for k in self.isv_opportunity_status_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['isvOpportunityStatusList'] = []
        if self.isv_opportunity_status_list is not None:
            for k in self.isv_opportunity_status_list:
                result['isvOpportunityStatusList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.isv_opportunity_status_list = []
        if m.get('isvOpportunityStatusList') is not None:
            for k in m.get('isvOpportunityStatusList'):
                temp_model = UpdateIsvOppStatusRequestIsvOpportunityStatusList()
                self.isv_opportunity_status_list.append(temp_model.from_map(k))
        return self


class UpdateIsvOppStatusResponseBody(TeaModel):
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


class UpdateIsvOppStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateIsvOppStatusResponseBody = None,
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
            temp_model = UpdateIsvOppStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


