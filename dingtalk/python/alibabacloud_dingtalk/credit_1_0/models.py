# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict


class QueryScoreHeaders(TeaModel):
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


class QueryScoreRequest(TeaModel):
    def __init__(
        self,
        encryption: str = None,
        full_name: str = None,
        id_card_code: str = None,
        mobile: str = None,
        org_name: str = None,
        uni_sc_code: str = None,
    ):
        self.encryption = encryption
        self.full_name = full_name
        self.id_card_code = id_card_code
        self.mobile = mobile
        self.org_name = org_name
        self.uni_sc_code = uni_sc_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.encryption is not None:
            result['encryption'] = self.encryption
        if self.full_name is not None:
            result['fullName'] = self.full_name
        if self.id_card_code is not None:
            result['idCardCode'] = self.id_card_code
        if self.mobile is not None:
            result['mobile'] = self.mobile
        if self.org_name is not None:
            result['orgName'] = self.org_name
        if self.uni_sc_code is not None:
            result['uniScCode'] = self.uni_sc_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('encryption') is not None:
            self.encryption = m.get('encryption')
        if m.get('fullName') is not None:
            self.full_name = m.get('fullName')
        if m.get('idCardCode') is not None:
            self.id_card_code = m.get('idCardCode')
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        if m.get('orgName') is not None:
            self.org_name = m.get('orgName')
        if m.get('uniScCode') is not None:
            self.uni_sc_code = m.get('uniScCode')
        return self


class QueryScoreResponseBodyResult(TeaModel):
    def __init__(
        self,
        ccoc_score: float = None,
        city_change_cnt_3y: int = None,
        city_change_trend_2y: float = None,
        classification_of_org: str = None,
        growth_rate_login_days_180d: float = None,
        ind_change_cnt_3y: int = None,
        ind_change_trend_2y: float = None,
        job_change_cnt_3y: int = None,
        job_title: str = None,
        join_days: int = None,
        login_days_14d_pct: float = None,
        login_days_365d_pct: float = None,
        org_cnt: int = None,
        org_industry_sub_name_new: str = None,
        org_industry_up_name_new: str = None,
    ):
        self.ccoc_score = ccoc_score
        self.city_change_cnt_3y = city_change_cnt_3y
        self.city_change_trend_2y = city_change_trend_2y
        self.classification_of_org = classification_of_org
        self.growth_rate_login_days_180d = growth_rate_login_days_180d
        self.ind_change_cnt_3y = ind_change_cnt_3y
        self.ind_change_trend_2y = ind_change_trend_2y
        self.job_change_cnt_3y = job_change_cnt_3y
        self.job_title = job_title
        self.join_days = join_days
        self.login_days_14d_pct = login_days_14d_pct
        self.login_days_365d_pct = login_days_365d_pct
        self.org_cnt = org_cnt
        self.org_industry_sub_name_new = org_industry_sub_name_new
        self.org_industry_up_name_new = org_industry_up_name_new

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ccoc_score is not None:
            result['ccocScore'] = self.ccoc_score
        if self.city_change_cnt_3y is not None:
            result['cityChangeCnt3y'] = self.city_change_cnt_3y
        if self.city_change_trend_2y is not None:
            result['cityChangeTrend2y'] = self.city_change_trend_2y
        if self.classification_of_org is not None:
            result['classificationOfOrg'] = self.classification_of_org
        if self.growth_rate_login_days_180d is not None:
            result['growthRateLoginDays180d'] = self.growth_rate_login_days_180d
        if self.ind_change_cnt_3y is not None:
            result['indChangeCnt3y'] = self.ind_change_cnt_3y
        if self.ind_change_trend_2y is not None:
            result['indChangeTrend2y'] = self.ind_change_trend_2y
        if self.job_change_cnt_3y is not None:
            result['jobChangeCnt3y'] = self.job_change_cnt_3y
        if self.job_title is not None:
            result['jobTitle'] = self.job_title
        if self.join_days is not None:
            result['joinDays'] = self.join_days
        if self.login_days_14d_pct is not None:
            result['loginDays14dPct'] = self.login_days_14d_pct
        if self.login_days_365d_pct is not None:
            result['loginDays365dPct'] = self.login_days_365d_pct
        if self.org_cnt is not None:
            result['orgCnt'] = self.org_cnt
        if self.org_industry_sub_name_new is not None:
            result['orgIndustrySubNameNew'] = self.org_industry_sub_name_new
        if self.org_industry_up_name_new is not None:
            result['orgIndustryUpNameNew'] = self.org_industry_up_name_new
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ccocScore') is not None:
            self.ccoc_score = m.get('ccocScore')
        if m.get('cityChangeCnt3y') is not None:
            self.city_change_cnt_3y = m.get('cityChangeCnt3y')
        if m.get('cityChangeTrend2y') is not None:
            self.city_change_trend_2y = m.get('cityChangeTrend2y')
        if m.get('classificationOfOrg') is not None:
            self.classification_of_org = m.get('classificationOfOrg')
        if m.get('growthRateLoginDays180d') is not None:
            self.growth_rate_login_days_180d = m.get('growthRateLoginDays180d')
        if m.get('indChangeCnt3y') is not None:
            self.ind_change_cnt_3y = m.get('indChangeCnt3y')
        if m.get('indChangeTrend2y') is not None:
            self.ind_change_trend_2y = m.get('indChangeTrend2y')
        if m.get('jobChangeCnt3y') is not None:
            self.job_change_cnt_3y = m.get('jobChangeCnt3y')
        if m.get('jobTitle') is not None:
            self.job_title = m.get('jobTitle')
        if m.get('joinDays') is not None:
            self.join_days = m.get('joinDays')
        if m.get('loginDays14dPct') is not None:
            self.login_days_14d_pct = m.get('loginDays14dPct')
        if m.get('loginDays365dPct') is not None:
            self.login_days_365d_pct = m.get('loginDays365dPct')
        if m.get('orgCnt') is not None:
            self.org_cnt = m.get('orgCnt')
        if m.get('orgIndustrySubNameNew') is not None:
            self.org_industry_sub_name_new = m.get('orgIndustrySubNameNew')
        if m.get('orgIndustryUpNameNew') is not None:
            self.org_industry_up_name_new = m.get('orgIndustryUpNameNew')
        return self


class QueryScoreResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryScoreResponseBodyResult = None,
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
            temp_model = QueryScoreResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryScoreResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryScoreResponseBody = None,
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
            temp_model = QueryScoreResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


