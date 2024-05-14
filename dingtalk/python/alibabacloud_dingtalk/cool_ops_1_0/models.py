# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class BatchQueryOpportunityTagHeaders(TeaModel):
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


class BatchQueryOpportunityTagRequest(TeaModel):
    def __init__(
        self,
        corp_id_list: List[str] = None,
    ):
        self.corp_id_list = corp_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id_list is not None:
            result['corpIdList'] = self.corp_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpIdList') is not None:
            self.corp_id_list = m.get('corpIdList')
        return self


class BatchQueryOpportunityTagResponseBodyResultOpportunityList(TeaModel):
    def __init__(
        self,
        active_user_cnt_7d: int = None,
        app_active_state: str = None,
        corp_id: str = None,
        fst_funnelsource_name_lv_1: str = None,
        funnelsource_name_lv_1: str = None,
    ):
        self.active_user_cnt_7d = active_user_cnt_7d
        self.app_active_state = app_active_state
        self.corp_id = corp_id
        self.fst_funnelsource_name_lv_1 = fst_funnelsource_name_lv_1
        self.funnelsource_name_lv_1 = funnelsource_name_lv_1

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.active_user_cnt_7d is not None:
            result['activeUserCnt7d'] = self.active_user_cnt_7d
        if self.app_active_state is not None:
            result['appActiveState'] = self.app_active_state
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.fst_funnelsource_name_lv_1 is not None:
            result['fstFunnelsourceNameLv1'] = self.fst_funnelsource_name_lv_1
        if self.funnelsource_name_lv_1 is not None:
            result['funnelsourceNameLv1'] = self.funnelsource_name_lv_1
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activeUserCnt7d') is not None:
            self.active_user_cnt_7d = m.get('activeUserCnt7d')
        if m.get('appActiveState') is not None:
            self.app_active_state = m.get('appActiveState')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('fstFunnelsourceNameLv1') is not None:
            self.fst_funnelsource_name_lv_1 = m.get('fstFunnelsourceNameLv1')
        if m.get('funnelsourceNameLv1') is not None:
            self.funnelsource_name_lv_1 = m.get('funnelsourceNameLv1')
        return self


class BatchQueryOpportunityTagResponseBodyResult(TeaModel):
    def __init__(
        self,
        opportunity_list: List[BatchQueryOpportunityTagResponseBodyResultOpportunityList] = None,
    ):
        self.opportunity_list = opportunity_list

    def validate(self):
        if self.opportunity_list:
            for k in self.opportunity_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['opportunityList'] = []
        if self.opportunity_list is not None:
            for k in self.opportunity_list:
                result['opportunityList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.opportunity_list = []
        if m.get('opportunityList') is not None:
            for k in m.get('opportunityList'):
                temp_model = BatchQueryOpportunityTagResponseBodyResultOpportunityList()
                self.opportunity_list.append(temp_model.from_map(k))
        return self


class BatchQueryOpportunityTagResponseBody(TeaModel):
    def __init__(
        self,
        result: BatchQueryOpportunityTagResponseBodyResult = None,
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
            temp_model = BatchQueryOpportunityTagResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class BatchQueryOpportunityTagResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchQueryOpportunityTagResponseBody = None,
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
            temp_model = BatchQueryOpportunityTagResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


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
        oper_corp_id: str = None,
        oper_name: str = None,
        oper_time: str = None,
        oper_user_id: str = None,
        opp_source_corp_id: str = None,
        opportunity_status: str = None,
        user_id: str = None,
    ):
        self.isv_corp_id = isv_corp_id
        # This parameter is required.
        self.micro_app_id = micro_app_id
        # This parameter is required.
        self.name = name
        self.note = note
        self.oper_corp_id = oper_corp_id
        # This parameter is required.
        self.oper_name = oper_name
        # This parameter is required.
        self.oper_time = oper_time
        # This parameter is required.
        self.oper_user_id = oper_user_id
        # This parameter is required.
        self.opp_source_corp_id = opp_source_corp_id
        # This parameter is required.
        self.opportunity_status = opportunity_status
        # This parameter is required.
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
        if self.oper_corp_id is not None:
            result['operCorpId'] = self.oper_corp_id
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
        if m.get('operCorpId') is not None:
            self.oper_corp_id = m.get('operCorpId')
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


