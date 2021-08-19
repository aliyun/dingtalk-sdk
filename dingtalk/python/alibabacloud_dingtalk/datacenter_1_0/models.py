# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class QueryGroupMessageStatisticalDataHeaders(TeaModel):
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


class QueryGroupMessageStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # statDate
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryGroupMessageStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_id: str = None,
        kpi_name: str = None,
        unit: str = None,
        kpi_caliber: str = None,
        period: str = None,
    ):
        # 指标ID
        self.kpi_id = kpi_id
        # 指标名称
        self.kpi_name = kpi_name
        # 指标单位
        self.unit = unit
        # 指标口径
        self.kpi_caliber = kpi_caliber
        # 指标周期
        self.period = period

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.unit is not None:
            result['unit'] = self.unit
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.period is not None:
            result['period'] = self.period
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('period') is not None:
            self.period = m.get('period')
        return self


class QueryGroupMessageStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryGroupMessageStatisticalDataResponseBodyMetaList] = None,
    ):
        # 指标数据
        self.data_list = data_list
        # 指标元数据
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryGroupMessageStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryGroupMessageStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryGroupMessageStatisticalDataResponseBody = None,
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
            temp_model = QueryGroupMessageStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryVedioMeetingStatisticalDataHeaders(TeaModel):
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


class QueryVedioMeetingStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # statDate
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryVedioMeetingStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_id: str = None,
        kpi_name: str = None,
        unit: str = None,
        kpi_caliber: str = None,
        period: str = None,
    ):
        # 指标ID
        self.kpi_id = kpi_id
        # 指标名称
        self.kpi_name = kpi_name
        # 指标单位
        self.unit = unit
        # 指标口径
        self.kpi_caliber = kpi_caliber
        # 指标周期
        self.period = period

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.unit is not None:
            result['unit'] = self.unit
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.period is not None:
            result['period'] = self.period
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('period') is not None:
            self.period = m.get('period')
        return self


class QueryVedioMeetingStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryVedioMeetingStatisticalDataResponseBodyMetaList] = None,
    ):
        # 指标数据
        self.data_list = data_list
        # 指标元数据
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryVedioMeetingStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryVedioMeetingStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryVedioMeetingStatisticalDataResponseBody = None,
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
            temp_model = QueryVedioMeetingStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryHealthStatisticalDataHeaders(TeaModel):
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


class QueryHealthStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # statDate
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryHealthStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_id: str = None,
        kpi_name: str = None,
        unit: str = None,
        kpi_caliber: str = None,
        period: str = None,
    ):
        # 指标ID
        self.kpi_id = kpi_id
        # 指标名称
        self.kpi_name = kpi_name
        # 指标单位
        self.unit = unit
        # 指标口径
        self.kpi_caliber = kpi_caliber
        # 指标周期
        self.period = period

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.unit is not None:
            result['unit'] = self.unit
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.period is not None:
            result['period'] = self.period
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('period') is not None:
            self.period = m.get('period')
        return self


class QueryHealthStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryHealthStatisticalDataResponseBodyMetaList] = None,
    ):
        # 指标数据
        self.data_list = data_list
        # 指标元数据
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryHealthStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryHealthStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryHealthStatisticalDataResponseBody = None,
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
            temp_model = QueryHealthStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QuerySingleMessageStatisticalDataHeaders(TeaModel):
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


class QuerySingleMessageStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # statDate
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QuerySingleMessageStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_id: str = None,
        kpi_name: str = None,
        unit: str = None,
        kpi_caliber: str = None,
        period: str = None,
    ):
        # 指标ID
        self.kpi_id = kpi_id
        # 指标名称
        self.kpi_name = kpi_name
        # 指标单位
        self.unit = unit
        # 指标口径
        self.kpi_caliber = kpi_caliber
        # 指标周期
        self.period = period

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.unit is not None:
            result['unit'] = self.unit
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.period is not None:
            result['period'] = self.period
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('period') is not None:
            self.period = m.get('period')
        return self


class QuerySingleMessageStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QuerySingleMessageStatisticalDataResponseBodyMetaList] = None,
    ):
        # 指标数据
        self.data_list = data_list
        # 指标元数据
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QuerySingleMessageStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QuerySingleMessageStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QuerySingleMessageStatisticalDataResponseBody = None,
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
            temp_model = QuerySingleMessageStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryTodoStatisticalDataHeaders(TeaModel):
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


class QueryTodoStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # statDate
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryTodoStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_id: str = None,
        kpi_name: str = None,
        unit: str = None,
        kpi_caliber: str = None,
        period: str = None,
    ):
        # 指标ID
        self.kpi_id = kpi_id
        # 指标名称
        self.kpi_name = kpi_name
        # 指标单位
        self.unit = unit
        # 指标口径
        self.kpi_caliber = kpi_caliber
        # 指标周期
        self.period = period

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.unit is not None:
            result['unit'] = self.unit
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.period is not None:
            result['period'] = self.period
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('period') is not None:
            self.period = m.get('period')
        return self


class QueryTodoStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryTodoStatisticalDataResponseBodyMetaList] = None,
    ):
        # 指标数据
        self.data_list = data_list
        # 指标元数据
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryTodoStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryTodoStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryTodoStatisticalDataResponseBody = None,
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
            temp_model = QueryTodoStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryCheckinStatisticalDataHeaders(TeaModel):
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


class QueryCheckinStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # statDate
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryCheckinStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_id: str = None,
        kpi_name: str = None,
        unit: str = None,
        kpi_caliber: str = None,
        period: str = None,
    ):
        # 指标ID
        self.kpi_id = kpi_id
        # 指标名称
        self.kpi_name = kpi_name
        # 指标单位
        self.unit = unit
        # 指标口径
        self.kpi_caliber = kpi_caliber
        # 指标周期
        self.period = period

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.unit is not None:
            result['unit'] = self.unit
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.period is not None:
            result['period'] = self.period
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('period') is not None:
            self.period = m.get('period')
        return self


class QueryCheckinStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryCheckinStatisticalDataResponseBodyMetaList] = None,
    ):
        # 指标数据
        self.data_list = data_list
        # 指标元数据
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryCheckinStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryCheckinStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryCheckinStatisticalDataResponseBody = None,
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
            temp_model = QueryCheckinStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryEmployeeTypeStatisticalDataHeaders(TeaModel):
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


class QueryEmployeeTypeStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # statDate
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryEmployeeTypeStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_id: str = None,
        kpi_name: str = None,
        unit: str = None,
        kpi_caliber: str = None,
        period: str = None,
    ):
        # 指标ID
        self.kpi_id = kpi_id
        # 指标名称
        self.kpi_name = kpi_name
        # 指标单位
        self.unit = unit
        # 指标口径
        self.kpi_caliber = kpi_caliber
        # 指标周期
        self.period = period

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.unit is not None:
            result['unit'] = self.unit
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.period is not None:
            result['period'] = self.period
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('period') is not None:
            self.period = m.get('period')
        return self


class QueryEmployeeTypeStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryEmployeeTypeStatisticalDataResponseBodyMetaList] = None,
    ):
        # 指标数据
        self.data_list = data_list
        # 指标元数据
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryEmployeeTypeStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryEmployeeTypeStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryEmployeeTypeStatisticalDataResponseBody = None,
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
            temp_model = QueryEmployeeTypeStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryMailStatisticalDataHeaders(TeaModel):
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


class QueryMailStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # statDate
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryMailStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_id: str = None,
        kpi_name: str = None,
        unit: str = None,
        kpi_caliber: str = None,
        period: str = None,
    ):
        # 指标ID
        self.kpi_id = kpi_id
        # 指标名称
        self.kpi_name = kpi_name
        # 指标单位
        self.unit = unit
        # 指标口径
        self.kpi_caliber = kpi_caliber
        # 指标周期
        self.period = period

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.unit is not None:
            result['unit'] = self.unit
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.period is not None:
            result['period'] = self.period
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('period') is not None:
            self.period = m.get('period')
        return self


class QueryMailStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryMailStatisticalDataResponseBodyMetaList] = None,
    ):
        # 指标数据
        self.data_list = data_list
        # 指标元数据
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryMailStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryMailStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryMailStatisticalDataResponseBody = None,
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
            temp_model = QueryMailStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryCalendarStatisticalDataHeaders(TeaModel):
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


class QueryCalendarStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # statDate
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryCalendarStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_id: str = None,
        kpi_name: str = None,
        unit: str = None,
        kpi_caliber: str = None,
        period: str = None,
    ):
        # 指标ID
        self.kpi_id = kpi_id
        # 指标名称
        self.kpi_name = kpi_name
        # 指标单位
        self.unit = unit
        # 指标口径
        self.kpi_caliber = kpi_caliber
        # 指标周期
        self.period = period

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.unit is not None:
            result['unit'] = self.unit
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.period is not None:
            result['period'] = self.period
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('period') is not None:
            self.period = m.get('period')
        return self


class QueryCalendarStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryCalendarStatisticalDataResponseBodyMetaList] = None,
    ):
        # 指标数据
        self.data_list = data_list
        # 指标元数据
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryCalendarStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryCalendarStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryCalendarStatisticalDataResponseBody = None,
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
            temp_model = QueryCalendarStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryDocumentStatisticalDataHeaders(TeaModel):
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


class QueryDocumentStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # statDate
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryDocumentStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_id: str = None,
        kpi_name: str = None,
        unit: str = None,
        kpi_caliber: str = None,
        period: str = None,
    ):
        # 指标ID
        self.kpi_id = kpi_id
        # 指标名称
        self.kpi_name = kpi_name
        # 指标单位
        self.unit = unit
        # 指标口径
        self.kpi_caliber = kpi_caliber
        # 指标周期
        self.period = period

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.unit is not None:
            result['unit'] = self.unit
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.period is not None:
            result['period'] = self.period
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('period') is not None:
            self.period = m.get('period')
        return self


class QueryDocumentStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryDocumentStatisticalDataResponseBodyMetaList] = None,
    ):
        # 指标数据
        self.data_list = data_list
        # 指标元数据
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryDocumentStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryDocumentStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryDocumentStatisticalDataResponseBody = None,
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
            temp_model = QueryDocumentStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryReportStatisticalDataHeaders(TeaModel):
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


class QueryReportStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # statDate
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryReportStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_id: str = None,
        kpi_name: str = None,
        unit: str = None,
        kpi_caliber: str = None,
        period: str = None,
    ):
        # 指标ID
        self.kpi_id = kpi_id
        # 指标名称
        self.kpi_name = kpi_name
        # 指标单位
        self.unit = unit
        # 指标口径
        self.kpi_caliber = kpi_caliber
        # 指标周期
        self.period = period

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.unit is not None:
            result['unit'] = self.unit
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.period is not None:
            result['period'] = self.period
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('period') is not None:
            self.period = m.get('period')
        return self


class QueryReportStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryReportStatisticalDataResponseBodyMetaList] = None,
    ):
        # 指标数据
        self.data_list = data_list
        # 指标元数据
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryReportStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryReportStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryReportStatisticalDataResponseBody = None,
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
            temp_model = QueryReportStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryOnlineUserStatisticalDataHeaders(TeaModel):
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


class QueryOnlineUserStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # statDate
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryOnlineUserStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_id: str = None,
        kpi_name: str = None,
        unit: str = None,
        kpi_caliber: str = None,
        period: str = None,
    ):
        # 指标ID
        self.kpi_id = kpi_id
        # 指标名称
        self.kpi_name = kpi_name
        # 指标单位
        self.unit = unit
        # 指标口径
        self.kpi_caliber = kpi_caliber
        # 指标周期
        self.period = period

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.unit is not None:
            result['unit'] = self.unit
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.period is not None:
            result['period'] = self.period
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('period') is not None:
            self.period = m.get('period')
        return self


class QueryOnlineUserStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryOnlineUserStatisticalDataResponseBodyMetaList] = None,
    ):
        # 指标数据
        self.data_list = data_list
        # 指标元数据
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryOnlineUserStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryOnlineUserStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryOnlineUserStatisticalDataResponseBody = None,
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
            temp_model = QueryOnlineUserStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryApprovalStatisticalDataHeaders(TeaModel):
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


class QueryApprovalStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # statDate
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryApprovalStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_id: str = None,
        kpi_name: str = None,
        unit: str = None,
        kpi_caliber: str = None,
        period: str = None,
    ):
        # 指标ID
        self.kpi_id = kpi_id
        # 指标名称
        self.kpi_name = kpi_name
        # 指标单位
        self.unit = unit
        # 指标口径
        self.kpi_caliber = kpi_caliber
        # 指标周期
        self.period = period

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.unit is not None:
            result['unit'] = self.unit
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.period is not None:
            result['period'] = self.period
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('period') is not None:
            self.period = m.get('period')
        return self


class QueryApprovalStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryApprovalStatisticalDataResponseBodyMetaList] = None,
    ):
        # 指标数据
        self.data_list = data_list
        # 指标元数据
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryApprovalStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryApprovalStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryApprovalStatisticalDataResponseBody = None,
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
            temp_model = QueryApprovalStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryDriveStatisticalDataHeaders(TeaModel):
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


class QueryDriveStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # statDate
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryDriveStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_id: str = None,
        kpi_name: str = None,
        unit: str = None,
        kpi_caliber: str = None,
        period: str = None,
    ):
        # 指标ID
        self.kpi_id = kpi_id
        # 指标名称
        self.kpi_name = kpi_name
        # 指标单位
        self.unit = unit
        # 指标口径
        self.kpi_caliber = kpi_caliber
        # 指标周期
        self.period = period

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.unit is not None:
            result['unit'] = self.unit
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.period is not None:
            result['period'] = self.period
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('period') is not None:
            self.period = m.get('period')
        return self


class QueryDriveStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryDriveStatisticalDataResponseBodyMetaList] = None,
    ):
        # 指标数据
        self.data_list = data_list
        # 指标元数据
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryDriveStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryDriveStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryDriveStatisticalDataResponseBody = None,
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
            temp_model = QueryDriveStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryDingSendStatisticalDataHeaders(TeaModel):
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


class QueryDingSendStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # statDate
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryDingSendStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_id: str = None,
        kpi_name: str = None,
        unit: str = None,
        kpi_caliber: str = None,
        period: str = None,
    ):
        # 指标ID
        self.kpi_id = kpi_id
        # 指标名称
        self.kpi_name = kpi_name
        # 指标单位
        self.unit = unit
        # 指标口径
        self.kpi_caliber = kpi_caliber
        # 指标周期
        self.period = period

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.unit is not None:
            result['unit'] = self.unit
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.period is not None:
            result['period'] = self.period
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('period') is not None:
            self.period = m.get('period')
        return self


class QueryDingSendStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryDingSendStatisticalDataResponseBodyMetaList] = None,
    ):
        # 指标数据
        self.data_list = data_list
        # 指标元数据
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryDingSendStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryDingSendStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryDingSendStatisticalDataResponseBody = None,
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
            temp_model = QueryDingSendStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryActiveUserStatisticalDataHeaders(TeaModel):
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


class QueryActiveUserStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # statDate
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryActiveUserStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_id: str = None,
        kpi_name: str = None,
        unit: str = None,
        kpi_caliber: str = None,
        period: str = None,
    ):
        # 指标ID
        self.kpi_id = kpi_id
        # 指标名称
        self.kpi_name = kpi_name
        # 指标单位
        self.unit = unit
        # 指标口径
        self.kpi_caliber = kpi_caliber
        # 指标周期
        self.period = period

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.unit is not None:
            result['unit'] = self.unit
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.period is not None:
            result['period'] = self.period
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('period') is not None:
            self.period = m.get('period')
        return self


class QueryActiveUserStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryActiveUserStatisticalDataResponseBodyMetaList] = None,
    ):
        # 指标数据
        self.data_list = data_list
        # 指标元数据
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryActiveUserStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryActiveUserStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryActiveUserStatisticalDataResponseBody = None,
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
            temp_model = QueryActiveUserStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryGroupLiveStatisticalDataHeaders(TeaModel):
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


class QueryGroupLiveStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # statDate
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryGroupLiveStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_id: str = None,
        kpi_name: str = None,
        unit: str = None,
        kpi_caliber: str = None,
        period: str = None,
    ):
        # 指标ID
        self.kpi_id = kpi_id
        # 指标名称
        self.kpi_name = kpi_name
        # 指标单位
        self.unit = unit
        # 指标口径
        self.kpi_caliber = kpi_caliber
        # 指标周期
        self.period = period

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.unit is not None:
            result['unit'] = self.unit
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.period is not None:
            result['period'] = self.period
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('period') is not None:
            self.period = m.get('period')
        return self


class QueryGroupLiveStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryGroupLiveStatisticalDataResponseBodyMetaList] = None,
    ):
        # 指标数据
        self.data_list = data_list
        # 指标元数据
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryGroupLiveStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryGroupLiveStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryGroupLiveStatisticalDataResponseBody = None,
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
            temp_model = QueryGroupLiveStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryDigitalDistrictOrgInfoHeaders(TeaModel):
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


class QueryDigitalDistrictOrgInfoRequest(TeaModel):
    def __init__(
        self,
        kpi_group_id: str = None,
        stat_dates: List[str] = None,
        corp_ids: List[str] = None,
    ):
        self.kpi_group_id = kpi_group_id
        self.stat_dates = stat_dates
        self.corp_ids = corp_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_group_id is not None:
            result['kpiGroupId'] = self.kpi_group_id
        if self.stat_dates is not None:
            result['statDates'] = self.stat_dates
        if self.corp_ids is not None:
            result['corpIds'] = self.corp_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiGroupId') is not None:
            self.kpi_group_id = m.get('kpiGroupId')
        if m.get('statDates') is not None:
            self.stat_dates = m.get('statDates')
        if m.get('corpIds') is not None:
            self.corp_ids = m.get('corpIds')
        return self


class QueryDigitalDistrictOrgInfoResponseBody(TeaModel):
    def __init__(
        self,
        arguments: List[str] = None,
        result: str = None,
    ):
        # arguments
        self.arguments = arguments
        # result
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.arguments is not None:
            result['arguments'] = self.arguments
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('arguments') is not None:
            self.arguments = m.get('arguments')
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class QueryDigitalDistrictOrgInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryDigitalDistrictOrgInfoResponseBody = None,
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
            temp_model = QueryDigitalDistrictOrgInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryAttendanceStatisticalDataHeaders(TeaModel):
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


class QueryAttendanceStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # statDate
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryAttendanceStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_id: str = None,
        kpi_name: str = None,
        unit: str = None,
        kpi_caliber: str = None,
        period: str = None,
    ):
        # 指标ID
        self.kpi_id = kpi_id
        # 指标名称
        self.kpi_name = kpi_name
        # 指标单位
        self.unit = unit
        # 指标口径
        self.kpi_caliber = kpi_caliber
        # 指标周期
        self.period = period

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.unit is not None:
            result['unit'] = self.unit
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.period is not None:
            result['period'] = self.period
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('period') is not None:
            self.period = m.get('period')
        return self


class QueryAttendanceStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryAttendanceStatisticalDataResponseBodyMetaList] = None,
    ):
        # 指标数据
        self.data_list = data_list
        # 指标元数据
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryAttendanceStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryAttendanceStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryAttendanceStatisticalDataResponseBody = None,
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
            temp_model = QueryAttendanceStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryDingReciveStatisticalDataHeaders(TeaModel):
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


class QueryDingReciveStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # statDate
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryDingReciveStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_id: str = None,
        kpi_name: str = None,
        unit: str = None,
        kpi_caliber: str = None,
        period: str = None,
    ):
        # 指标ID
        self.kpi_id = kpi_id
        # 指标名称
        self.kpi_name = kpi_name
        # 指标单位
        self.unit = unit
        # 指标口径
        self.kpi_caliber = kpi_caliber
        # 指标周期
        self.period = period

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.unit is not None:
            result['unit'] = self.unit
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.period is not None:
            result['period'] = self.period
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('period') is not None:
            self.period = m.get('period')
        return self


class QueryDingReciveStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryDingReciveStatisticalDataResponseBodyMetaList] = None,
    ):
        # 指标数据
        self.data_list = data_list
        # 指标元数据
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryDingReciveStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryDingReciveStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryDingReciveStatisticalDataResponseBody = None,
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
            temp_model = QueryDingReciveStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryRedEnvelopeReciveStatisticalDataHeaders(TeaModel):
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


class QueryRedEnvelopeReciveStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # statDate
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryRedEnvelopeReciveStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_id: str = None,
        kpi_name: str = None,
        unit: str = None,
        kpi_caliber: str = None,
        period: str = None,
    ):
        # 指标ID
        self.kpi_id = kpi_id
        # 指标名称
        self.kpi_name = kpi_name
        # 指标单位
        self.unit = unit
        # 指标口径
        self.kpi_caliber = kpi_caliber
        # 指标周期
        self.period = period

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.unit is not None:
            result['unit'] = self.unit
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.period is not None:
            result['period'] = self.period
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('period') is not None:
            self.period = m.get('period')
        return self


class QueryRedEnvelopeReciveStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryRedEnvelopeReciveStatisticalDataResponseBodyMetaList] = None,
    ):
        # 指标数据
        self.data_list = data_list
        # 指标元数据
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryRedEnvelopeReciveStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryRedEnvelopeReciveStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryRedEnvelopeReciveStatisticalDataResponseBody = None,
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
            temp_model = QueryRedEnvelopeReciveStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryCircleStatisticalDataHeaders(TeaModel):
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


class QueryCircleStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # statDate
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryCircleStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_id: str = None,
        kpi_name: str = None,
        unit: str = None,
        kpi_caliber: str = None,
        period: str = None,
    ):
        # 指标ID
        self.kpi_id = kpi_id
        # 指标名称
        self.kpi_name = kpi_name
        # 指标单位
        self.unit = unit
        # 指标口径
        self.kpi_caliber = kpi_caliber
        # 指标周期
        self.period = period

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.unit is not None:
            result['unit'] = self.unit
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.period is not None:
            result['period'] = self.period
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('period') is not None:
            self.period = m.get('period')
        return self


class QueryCircleStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryCircleStatisticalDataResponseBodyMetaList] = None,
    ):
        # 指标数据
        self.data_list = data_list
        # 指标元数据
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryCircleStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryCircleStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryCircleStatisticalDataResponseBody = None,
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
            temp_model = QueryCircleStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryRedEnvelopeSendStatisticalDataHeaders(TeaModel):
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


class QueryRedEnvelopeSendStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # statDate
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryRedEnvelopeSendStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_id: str = None,
        kpi_name: str = None,
        unit: str = None,
        kpi_caliber: str = None,
        period: str = None,
    ):
        # 指标ID
        self.kpi_id = kpi_id
        # 指标名称
        self.kpi_name = kpi_name
        # 指标单位
        self.unit = unit
        # 指标口径
        self.kpi_caliber = kpi_caliber
        # 指标周期
        self.period = period

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.unit is not None:
            result['unit'] = self.unit
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.period is not None:
            result['period'] = self.period
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('period') is not None:
            self.period = m.get('period')
        return self


class QueryRedEnvelopeSendStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryRedEnvelopeSendStatisticalDataResponseBodyMetaList] = None,
    ):
        # 指标数据
        self.data_list = data_list
        # 指标元数据
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryRedEnvelopeSendStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryRedEnvelopeSendStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryRedEnvelopeSendStatisticalDataResponseBody = None,
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
            temp_model = QueryRedEnvelopeSendStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryTelMeetingStatisticalDataHeaders(TeaModel):
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


class QueryTelMeetingStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # statDate
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryTelMeetingStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_id: str = None,
        kpi_name: str = None,
        unit: str = None,
        kpi_caliber: str = None,
        period: str = None,
    ):
        # 指标ID
        self.kpi_id = kpi_id
        # 指标名称
        self.kpi_name = kpi_name
        # 指标单位
        self.unit = unit
        # 指标口径
        self.kpi_caliber = kpi_caliber
        # 指标周期
        self.period = period

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.unit is not None:
            result['unit'] = self.unit
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.period is not None:
            result['period'] = self.period
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('period') is not None:
            self.period = m.get('period')
        return self


class QueryTelMeetingStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryTelMeetingStatisticalDataResponseBodyMetaList] = None,
    ):
        # 指标数据
        self.data_list = data_list
        # 指标元数据
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryTelMeetingStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryTelMeetingStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryTelMeetingStatisticalDataResponseBody = None,
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
            temp_model = QueryTelMeetingStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryBlackboardStatisticalDataHeaders(TeaModel):
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


class QueryBlackboardStatisticalDataRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
    ):
        # statDate
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class QueryBlackboardStatisticalDataResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_id: str = None,
        kpi_name: str = None,
        unit: str = None,
        kpi_caliber: str = None,
        period: str = None,
    ):
        # 指标ID
        self.kpi_id = kpi_id
        # 指标名称
        self.kpi_name = kpi_name
        # 指标单位
        self.unit = unit
        # 指标口径
        self.kpi_caliber = kpi_caliber
        # 指标周期
        self.period = period

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.unit is not None:
            result['unit'] = self.unit
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.period is not None:
            result['period'] = self.period
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('period') is not None:
            self.period = m.get('period')
        return self


class QueryBlackboardStatisticalDataResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[QueryBlackboardStatisticalDataResponseBodyMetaList] = None,
    ):
        # 指标数据
        self.data_list = data_list
        # 指标元数据
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = QueryBlackboardStatisticalDataResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class QueryBlackboardStatisticalDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryBlackboardStatisticalDataResponseBody = None,
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
            temp_model = QueryBlackboardStatisticalDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


