# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class SyncDataHeaders(TeaModel):
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


class SyncDataRequestTriggerDataList(TeaModel):
    def __init__(
        self,
        trigger_id: str = None,
        custom_trigger_id: str = None,
        json_data: str = None,
        data_gmt_create: int = None,
        data_gmt_modified: int = None,
        action: str = None,
    ):
        self.trigger_id = trigger_id
        self.custom_trigger_id = custom_trigger_id
        self.json_data = json_data
        self.data_gmt_create = data_gmt_create
        self.data_gmt_modified = data_gmt_modified
        self.action = action

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.trigger_id is not None:
            result['triggerId'] = self.trigger_id
        if self.custom_trigger_id is not None:
            result['customTriggerId'] = self.custom_trigger_id
        if self.json_data is not None:
            result['jsonData'] = self.json_data
        if self.data_gmt_create is not None:
            result['dataGmtCreate'] = self.data_gmt_create
        if self.data_gmt_modified is not None:
            result['dataGmtModified'] = self.data_gmt_modified
        if self.action is not None:
            result['action'] = self.action
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('triggerId') is not None:
            self.trigger_id = m.get('triggerId')
        if m.get('customTriggerId') is not None:
            self.custom_trigger_id = m.get('customTriggerId')
        if m.get('jsonData') is not None:
            self.json_data = m.get('jsonData')
        if m.get('dataGmtCreate') is not None:
            self.data_gmt_create = m.get('dataGmtCreate')
        if m.get('dataGmtModified') is not None:
            self.data_gmt_modified = m.get('dataGmtModified')
        if m.get('action') is not None:
            self.action = m.get('action')
        return self


class SyncDataRequest(TeaModel):
    def __init__(
        self,
        trigger_data_list: List[SyncDataRequestTriggerDataList] = None,
    ):
        self.trigger_data_list = trigger_data_list

    def validate(self):
        if self.trigger_data_list:
            for k in self.trigger_data_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['triggerDataList'] = []
        if self.trigger_data_list is not None:
            for k in self.trigger_data_list:
                result['triggerDataList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.trigger_data_list = []
        if m.get('triggerDataList') is not None:
            for k in m.get('triggerDataList'):
                temp_model = SyncDataRequestTriggerDataList()
                self.trigger_data_list.append(temp_model.from_map(k))
        return self


class SyncDataResponseBodyList(TeaModel):
    def __init__(
        self,
        trigger_id: str = None,
        biz_primary_key: str = None,
        success: bool = None,
        sub_err_code: str = None,
        sub_err_msg: str = None,
    ):
        self.trigger_id = trigger_id
        self.biz_primary_key = biz_primary_key
        self.success = success
        self.sub_err_code = sub_err_code
        self.sub_err_msg = sub_err_msg

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.trigger_id is not None:
            result['triggerId'] = self.trigger_id
        if self.biz_primary_key is not None:
            result['bizPrimaryKey'] = self.biz_primary_key
        if self.success is not None:
            result['success'] = self.success
        if self.sub_err_code is not None:
            result['subErrCode'] = self.sub_err_code
        if self.sub_err_msg is not None:
            result['subErrMsg'] = self.sub_err_msg
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('triggerId') is not None:
            self.trigger_id = m.get('triggerId')
        if m.get('bizPrimaryKey') is not None:
            self.biz_primary_key = m.get('bizPrimaryKey')
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('subErrCode') is not None:
            self.sub_err_code = m.get('subErrCode')
        if m.get('subErrMsg') is not None:
            self.sub_err_msg = m.get('subErrMsg')
        return self


class SyncDataResponseBody(TeaModel):
    def __init__(
        self,
        list: List[SyncDataResponseBodyList] = None,
    ):
        # resultList
        self.list = list

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
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = SyncDataResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class SyncDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SyncDataResponseBody = None,
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
            temp_model = SyncDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


