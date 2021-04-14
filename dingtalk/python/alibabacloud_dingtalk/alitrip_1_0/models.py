# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class AddCityCarApplyHeaders(TeaModel):
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


class AddCityCarApplyRequest(TeaModel):
    def __init__(
        self,
        cause: str = None,
        city: str = None,
        corp_id: str = None,
        date: str = None,
        project_code: str = None,
        project_name: str = None,
        status: int = None,
        third_part_apply_id: str = None,
        third_part_cost_center_id: str = None,
        third_part_invoice_id: str = None,
        times_total: int = None,
        times_type: int = None,
        times_used: int = None,
        title: str = None,
        user_id: str = None,
        ding_suite_key: str = None,
        ding_corp_id: str = None,
        ding_token_grant_type: int = None,
        finished_date: str = None,
    ):
        # 出差事由
        self.cause = cause
        # 用车城市
        self.city = city
        # 第三方企业ID
        self.corp_id = corp_id
        # 用车时间，按天管控，比如传值2021-03-18 20:26:56表示2021-03-18当天可用车，跨天情况配合finishedDate参数使用
        self.date = date
        # 审批单关联的项目code
        self.project_code = project_code
        # 审批单关联的项目名
        self.project_name = project_name
        # 审批单状态：0-申请，1-同意，2-拒绝
        self.status = status
        # 三方审批单ID
        self.third_part_apply_id = third_part_apply_id
        # 审批单关联的三方成本中心ID
        self.third_part_cost_center_id = third_part_cost_center_id
        # 审批单关联的三方发票抬头ID
        self.third_part_invoice_id = third_part_invoice_id
        # 审批单可用总次数
        self.times_total = times_total
        # 审批单可用次数类型：1-次数不限制，2-用户可指定次数，3-管理员限制次数；如果企业没有限制审批单使用次数的需求，这个参数传1(次数不限制)，同时times_total和times_used都传0即可
        self.times_type = times_type
        # 审批单已用次数
        self.times_used = times_used
        # 审批单标题
        self.title = title
        # 发起审批的第三方员工ID
        self.user_id = user_id
        # suiteKey
        self.ding_suite_key = ding_suite_key
        # account
        self.ding_corp_id = ding_corp_id
        # tokenGrantType
        self.ding_token_grant_type = ding_token_grant_type
        # 用车截止时间，按天管控，比如date传值2021-03-18 20:26:56、finished_date传值2021-03-30 20:26:56表示2021-03-18(含)到2021-03-30(含)之间可用车，该参数不传值情况使用date作为用车截止时间；
        self.finished_date = finished_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cause is not None:
            result['cause'] = self.cause
        if self.city is not None:
            result['city'] = self.city
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.date is not None:
            result['date'] = self.date
        if self.project_code is not None:
            result['projectCode'] = self.project_code
        if self.project_name is not None:
            result['projectName'] = self.project_name
        if self.status is not None:
            result['status'] = self.status
        if self.third_part_apply_id is not None:
            result['thirdPartApplyId'] = self.third_part_apply_id
        if self.third_part_cost_center_id is not None:
            result['thirdPartCostCenterId'] = self.third_part_cost_center_id
        if self.third_part_invoice_id is not None:
            result['thirdPartInvoiceId'] = self.third_part_invoice_id
        if self.times_total is not None:
            result['timesTotal'] = self.times_total
        if self.times_type is not None:
            result['timesType'] = self.times_type
        if self.times_used is not None:
            result['timesUsed'] = self.times_used
        if self.title is not None:
            result['title'] = self.title
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.finished_date is not None:
            result['finishedDate'] = self.finished_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cause') is not None:
            self.cause = m.get('cause')
        if m.get('city') is not None:
            self.city = m.get('city')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('projectCode') is not None:
            self.project_code = m.get('projectCode')
        if m.get('projectName') is not None:
            self.project_name = m.get('projectName')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('thirdPartApplyId') is not None:
            self.third_part_apply_id = m.get('thirdPartApplyId')
        if m.get('thirdPartCostCenterId') is not None:
            self.third_part_cost_center_id = m.get('thirdPartCostCenterId')
        if m.get('thirdPartInvoiceId') is not None:
            self.third_part_invoice_id = m.get('thirdPartInvoiceId')
        if m.get('timesTotal') is not None:
            self.times_total = m.get('timesTotal')
        if m.get('timesType') is not None:
            self.times_type = m.get('timesType')
        if m.get('timesUsed') is not None:
            self.times_used = m.get('timesUsed')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('finishedDate') is not None:
            self.finished_date = m.get('finishedDate')
        return self


class AddCityCarApplyResponseBody(TeaModel):
    def __init__(
        self,
        apply_id: int = None,
    ):
        # 商旅内部审批单ID
        self.apply_id = apply_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.apply_id is not None:
            result['applyId'] = self.apply_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('applyId') is not None:
            self.apply_id = m.get('applyId')
        return self


class AddCityCarApplyResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: AddCityCarApplyResponseBody = None,
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
            temp_model = AddCityCarApplyResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ApproveCityCarApplyHeaders(TeaModel):
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


class ApproveCityCarApplyRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        operate_time: str = None,
        remark: str = None,
        status: int = None,
        third_part_apply_id: str = None,
        user_id: str = None,
        ding_suite_key: str = None,
        ding_corp_id: str = None,
        ding_token_grant_type: int = None,
    ):
        # 第三方企业ID
        self.corp_id = corp_id
        # 审批时间
        self.operate_time = operate_time
        # 审批备注
        self.remark = remark
        # 审批结果：1-同意，2-拒绝
        self.status = status
        # 第三方审批单ID
        self.third_part_apply_id = third_part_apply_id
        # 审批的第三方员工ID
        self.user_id = user_id
        # suiteKey
        self.ding_suite_key = ding_suite_key
        # account
        self.ding_corp_id = ding_corp_id
        # tokenGrantType
        self.ding_token_grant_type = ding_token_grant_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.operate_time is not None:
            result['operateTime'] = self.operate_time
        if self.remark is not None:
            result['remark'] = self.remark
        if self.status is not None:
            result['status'] = self.status
        if self.third_part_apply_id is not None:
            result['thirdPartApplyId'] = self.third_part_apply_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('operateTime') is not None:
            self.operate_time = m.get('operateTime')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('thirdPartApplyId') is not None:
            self.third_part_apply_id = m.get('thirdPartApplyId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        return self


class ApproveCityCarApplyResponseBody(TeaModel):
    def __init__(
        self,
        approve_result: bool = None,
    ):
        # 审批结果
        self.approve_result = approve_result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.approve_result is not None:
            result['approveResult'] = self.approve_result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('approveResult') is not None:
            self.approve_result = m.get('approveResult')
        return self


class ApproveCityCarApplyResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ApproveCityCarApplyResponseBody = None,
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
            temp_model = ApproveCityCarApplyResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryCityCarApplyHeaders(TeaModel):
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


class QueryCityCarApplyRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        created_end_at: str = None,
        created_start_at: str = None,
        page_number: int = None,
        page_size: int = None,
        third_part_apply_id: str = None,
        user_id: str = None,
    ):
        # 第三方企业ID
        self.corp_id = corp_id
        # 审批单创建时间小于值
        self.created_end_at = created_end_at
        # 审批单创建时间大于等于值
        self.created_start_at = created_start_at
        # 页码，要求大于等于1，默认1
        self.page_number = page_number
        # 每页数据量，要求大于等于1，默认20
        self.page_size = page_size
        # 三方审批单ID
        self.third_part_apply_id = third_part_apply_id
        # 第三方员工ID
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
        if self.created_end_at is not None:
            result['createdEndAt'] = self.created_end_at
        if self.created_start_at is not None:
            result['createdStartAt'] = self.created_start_at
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.third_part_apply_id is not None:
            result['thirdPartApplyId'] = self.third_part_apply_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('createdEndAt') is not None:
            self.created_end_at = m.get('createdEndAt')
        if m.get('createdStartAt') is not None:
            self.created_start_at = m.get('createdStartAt')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('thirdPartApplyId') is not None:
            self.third_part_apply_id = m.get('thirdPartApplyId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryCityCarApplyResponseBodyApplyListApproverList(TeaModel):
    def __init__(
        self,
        note: str = None,
        operate_time: str = None,
        order: int = None,
        status: int = None,
        status_desc: str = None,
        user_id: str = None,
        user_name: str = None,
    ):
        # 审批备注
        self.note = note
        # 审批时间
        self.operate_time = operate_time
        # 审批人排序值
        self.order = order
        # 审批状态枚举：审批状态：0-审批中，1-已同意，2-已拒绝
        self.status = status
        # 审批状态描述
        self.status_desc = status_desc
        # 审批员工ID
        self.user_id = user_id
        # 审批员工名
        self.user_name = user_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.note is not None:
            result['note'] = self.note
        if self.operate_time is not None:
            result['operateTime'] = self.operate_time
        if self.order is not None:
            result['order'] = self.order
        if self.status is not None:
            result['status'] = self.status
        if self.status_desc is not None:
            result['statusDesc'] = self.status_desc
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_name is not None:
            result['userName'] = self.user_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('note') is not None:
            self.note = m.get('note')
        if m.get('operateTime') is not None:
            self.operate_time = m.get('operateTime')
        if m.get('order') is not None:
            self.order = m.get('order')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('statusDesc') is not None:
            self.status_desc = m.get('statusDesc')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        return self


class QueryCityCarApplyResponseBodyApplyListItineraryList(TeaModel):
    def __init__(
        self,
        arr_city: str = None,
        arr_city_code: str = None,
        arr_date: str = None,
        cost_center_id: int = None,
        cost_center_name: str = None,
        dep_city: str = None,
        dep_city_code: str = None,
        dep_date: str = None,
        invoice_id: int = None,
        invoice_name: str = None,
        itinerary_id: str = None,
        project_code: str = None,
        project_title: str = None,
        traffic_type: int = None,
    ):
        # 目的地城市
        self.arr_city = arr_city
        # 目的地城市三字码
        self.arr_city_code = arr_city_code
        # 到达目的地城市时间
        self.arr_date = arr_date
        # 商旅内部成本中心ID
        self.cost_center_id = cost_center_id
        # 成本中心名称
        self.cost_center_name = cost_center_name
        # 出发城市
        self.dep_city = dep_city
        # 出发城市三字码
        self.dep_city_code = dep_city_code
        # 出发时间
        self.dep_date = dep_date
        # 商旅内部发票抬头ID
        self.invoice_id = invoice_id
        # 发票抬头名称
        self.invoice_name = invoice_name
        # 商旅内部行程单ID
        self.itinerary_id = itinerary_id
        # 项目code
        self.project_code = project_code
        # 项目名称
        self.project_title = project_title
        # 交通方式：4-市内交通
        self.traffic_type = traffic_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.arr_city is not None:
            result['arrCity'] = self.arr_city
        if self.arr_city_code is not None:
            result['arrCityCode'] = self.arr_city_code
        if self.arr_date is not None:
            result['arrDate'] = self.arr_date
        if self.cost_center_id is not None:
            result['costCenterId'] = self.cost_center_id
        if self.cost_center_name is not None:
            result['costCenterName'] = self.cost_center_name
        if self.dep_city is not None:
            result['depCity'] = self.dep_city
        if self.dep_city_code is not None:
            result['depCityCode'] = self.dep_city_code
        if self.dep_date is not None:
            result['depDate'] = self.dep_date
        if self.invoice_id is not None:
            result['invoiceId'] = self.invoice_id
        if self.invoice_name is not None:
            result['invoiceName'] = self.invoice_name
        if self.itinerary_id is not None:
            result['itineraryId'] = self.itinerary_id
        if self.project_code is not None:
            result['projectCode'] = self.project_code
        if self.project_title is not None:
            result['projectTitle'] = self.project_title
        if self.traffic_type is not None:
            result['trafficType'] = self.traffic_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('arrCity') is not None:
            self.arr_city = m.get('arrCity')
        if m.get('arrCityCode') is not None:
            self.arr_city_code = m.get('arrCityCode')
        if m.get('arrDate') is not None:
            self.arr_date = m.get('arrDate')
        if m.get('costCenterId') is not None:
            self.cost_center_id = m.get('costCenterId')
        if m.get('costCenterName') is not None:
            self.cost_center_name = m.get('costCenterName')
        if m.get('depCity') is not None:
            self.dep_city = m.get('depCity')
        if m.get('depCityCode') is not None:
            self.dep_city_code = m.get('depCityCode')
        if m.get('depDate') is not None:
            self.dep_date = m.get('depDate')
        if m.get('invoiceId') is not None:
            self.invoice_id = m.get('invoiceId')
        if m.get('invoiceName') is not None:
            self.invoice_name = m.get('invoiceName')
        if m.get('itineraryId') is not None:
            self.itinerary_id = m.get('itineraryId')
        if m.get('projectCode') is not None:
            self.project_code = m.get('projectCode')
        if m.get('projectTitle') is not None:
            self.project_title = m.get('projectTitle')
        if m.get('trafficType') is not None:
            self.traffic_type = m.get('trafficType')
        return self


class QueryCityCarApplyResponseBodyApplyList(TeaModel):
    def __init__(
        self,
        approver_list: List[QueryCityCarApplyResponseBodyApplyListApproverList] = None,
        depart_id: str = None,
        depart_name: str = None,
        gmt_create: str = None,
        gmt_modified: str = None,
        itinerary_list: List[QueryCityCarApplyResponseBodyApplyListItineraryList] = None,
        status: int = None,
        status_desc: str = None,
        third_part_apply_id: str = None,
        trip_cause: str = None,
        trip_title: str = None,
        user_id: str = None,
        user_name: str = None,
    ):
        # 审批单列表
        self.approver_list = approver_list
        # 员工所在部门ID
        self.depart_id = depart_id
        # 员工所在部门名
        self.depart_name = depart_name
        # 创建时间
        self.gmt_create = gmt_create
        # 最近修改时间
        self.gmt_modified = gmt_modified
        # 审批单关联的行程
        self.itinerary_list = itinerary_list
        # 审批单状态：0-申请，1-同意，2-拒绝
        self.status = status
        # 审批单状态：0-申请，1-同意，2-拒绝
        self.status_desc = status_desc
        # 三方审批单ID
        self.third_part_apply_id = third_part_apply_id
        # 申请事由
        self.trip_cause = trip_cause
        # 审批单标题
        self.trip_title = trip_title
        # 发起审批员工ID
        self.user_id = user_id
        # 发起审批员工名
        self.user_name = user_name

    def validate(self):
        if self.approver_list:
            for k in self.approver_list:
                if k:
                    k.validate()
        if self.itinerary_list:
            for k in self.itinerary_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['approverList'] = []
        if self.approver_list is not None:
            for k in self.approver_list:
                result['approverList'].append(k.to_map() if k else None)
        if self.depart_id is not None:
            result['departId'] = self.depart_id
        if self.depart_name is not None:
            result['departName'] = self.depart_name
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        result['itineraryList'] = []
        if self.itinerary_list is not None:
            for k in self.itinerary_list:
                result['itineraryList'].append(k.to_map() if k else None)
        if self.status is not None:
            result['status'] = self.status
        if self.status_desc is not None:
            result['statusDesc'] = self.status_desc
        if self.third_part_apply_id is not None:
            result['thirdPartApplyId'] = self.third_part_apply_id
        if self.trip_cause is not None:
            result['tripCause'] = self.trip_cause
        if self.trip_title is not None:
            result['tripTitle'] = self.trip_title
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_name is not None:
            result['userName'] = self.user_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.approver_list = []
        if m.get('approverList') is not None:
            for k in m.get('approverList'):
                temp_model = QueryCityCarApplyResponseBodyApplyListApproverList()
                self.approver_list.append(temp_model.from_map(k))
        if m.get('departId') is not None:
            self.depart_id = m.get('departId')
        if m.get('departName') is not None:
            self.depart_name = m.get('departName')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        self.itinerary_list = []
        if m.get('itineraryList') is not None:
            for k in m.get('itineraryList'):
                temp_model = QueryCityCarApplyResponseBodyApplyListItineraryList()
                self.itinerary_list.append(temp_model.from_map(k))
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('statusDesc') is not None:
            self.status_desc = m.get('statusDesc')
        if m.get('thirdPartApplyId') is not None:
            self.third_part_apply_id = m.get('thirdPartApplyId')
        if m.get('tripCause') is not None:
            self.trip_cause = m.get('tripCause')
        if m.get('tripTitle') is not None:
            self.trip_title = m.get('tripTitle')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        return self


class QueryCityCarApplyResponseBody(TeaModel):
    def __init__(
        self,
        apply_list: List[QueryCityCarApplyResponseBodyApplyList] = None,
        total: int = None,
    ):
        # 审批单列表
        self.apply_list = apply_list
        # 总数
        self.total = total

    def validate(self):
        if self.apply_list:
            for k in self.apply_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['applyList'] = []
        if self.apply_list is not None:
            for k in self.apply_list:
                result['applyList'].append(k.to_map() if k else None)
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.apply_list = []
        if m.get('applyList') is not None:
            for k in m.get('applyList'):
                temp_model = QueryCityCarApplyResponseBodyApplyList()
                self.apply_list.append(temp_model.from_map(k))
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class QueryCityCarApplyResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryCityCarApplyResponseBody = None,
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
            temp_model = QueryCityCarApplyResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


