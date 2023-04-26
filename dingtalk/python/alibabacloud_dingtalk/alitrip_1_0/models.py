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
        finished_date: str = None,
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
    ):
        self.cause = cause
        self.city = city
        self.corp_id = corp_id
        self.date = date
        self.finished_date = finished_date
        self.project_code = project_code
        self.project_name = project_name
        self.status = status
        self.third_part_apply_id = third_part_apply_id
        self.third_part_cost_center_id = third_part_cost_center_id
        self.third_part_invoice_id = third_part_invoice_id
        self.times_total = times_total
        self.times_type = times_type
        self.times_used = times_used
        self.title = title
        self.user_id = user_id

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
        if self.finished_date is not None:
            result['finishedDate'] = self.finished_date
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
        if m.get('finishedDate') is not None:
            self.finished_date = m.get('finishedDate')
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
        return self


class AddCityCarApplyResponseBody(TeaModel):
    def __init__(
        self,
        apply_id: int = None,
    ):
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
        status_code: int = None,
        body: AddCityCarApplyResponseBody = None,
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
    ):
        self.corp_id = corp_id
        self.operate_time = operate_time
        self.remark = remark
        self.status = status
        self.third_part_apply_id = third_part_apply_id
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
        return self


class ApproveCityCarApplyResponseBody(TeaModel):
    def __init__(
        self,
        approve_result: bool = None,
    ):
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
        status_code: int = None,
        body: ApproveCityCarApplyResponseBody = None,
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
            temp_model = ApproveCityCarApplyResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BillSettementBtripTrainHeaders(TeaModel):
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


class BillSettementBtripTrainRequest(TeaModel):
    def __init__(
        self,
        category: int = None,
        corp_id: str = None,
        page_number: int = None,
        page_size: int = None,
        period_end: str = None,
        period_start: str = None,
    ):
        self.category = category
        self.corp_id = corp_id
        self.page_number = page_number
        self.page_size = page_size
        self.period_end = period_end
        self.period_start = period_start

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category is not None:
            result['category'] = self.category
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.period_end is not None:
            result['periodEnd'] = self.period_end
        if self.period_start is not None:
            result['periodStart'] = self.period_start
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('periodEnd') is not None:
            self.period_end = m.get('periodEnd')
        if m.get('periodStart') is not None:
            self.period_start = m.get('periodStart')
        return self


class BillSettementBtripTrainResponseBodyModuleDataList(TeaModel):
    def __init__(
        self,
        alipay_trade_no: str = None,
        apply_id: str = None,
        arr_date: str = None,
        arr_station: str = None,
        arr_time: str = None,
        bill_record_time: str = None,
        book_time: str = None,
        booker_id: str = None,
        booker_job_no: str = None,
        booker_name: str = None,
        capital_direction: str = None,
        cascade_department: str = None,
        change_fee: float = None,
        cost_center: str = None,
        cost_center_number: str = None,
        coupon: float = None,
        department: str = None,
        department_id: str = None,
        dept_date: str = None,
        dept_station: str = None,
        dept_time: str = None,
        fee_type: str = None,
        index: str = None,
        invoice_title: str = None,
        order_id: str = None,
        order_price: float = None,
        over_apply_id: str = None,
        primary_id: int = None,
        project_code: str = None,
        project_name: str = None,
        refund_fee: float = None,
        remark: str = None,
        run_time: str = None,
        seat_no: str = None,
        seat_type: str = None,
        service_fee: float = None,
        settlement_fee: float = None,
        settlement_grant_fee: float = None,
        settlement_time: str = None,
        settlement_type: str = None,
        status: int = None,
        ticket_no: str = None,
        ticket_price: float = None,
        train_no: str = None,
        train_type: str = None,
        traveler_id: str = None,
        traveler_job_no: str = None,
        traveler_name: str = None,
        voucher_type: int = None,
    ):
        self.alipay_trade_no = alipay_trade_no
        self.apply_id = apply_id
        self.arr_date = arr_date
        self.arr_station = arr_station
        self.arr_time = arr_time
        self.bill_record_time = bill_record_time
        self.book_time = book_time
        self.booker_id = booker_id
        self.booker_job_no = booker_job_no
        self.booker_name = booker_name
        self.capital_direction = capital_direction
        self.cascade_department = cascade_department
        self.change_fee = change_fee
        self.cost_center = cost_center
        self.cost_center_number = cost_center_number
        self.coupon = coupon
        self.department = department
        self.department_id = department_id
        self.dept_date = dept_date
        self.dept_station = dept_station
        self.dept_time = dept_time
        self.fee_type = fee_type
        self.index = index
        self.invoice_title = invoice_title
        self.order_id = order_id
        self.order_price = order_price
        self.over_apply_id = over_apply_id
        self.primary_id = primary_id
        self.project_code = project_code
        self.project_name = project_name
        self.refund_fee = refund_fee
        self.remark = remark
        self.run_time = run_time
        self.seat_no = seat_no
        self.seat_type = seat_type
        self.service_fee = service_fee
        self.settlement_fee = settlement_fee
        self.settlement_grant_fee = settlement_grant_fee
        self.settlement_time = settlement_time
        self.settlement_type = settlement_type
        self.status = status
        self.ticket_no = ticket_no
        self.ticket_price = ticket_price
        self.train_no = train_no
        self.train_type = train_type
        self.traveler_id = traveler_id
        self.traveler_job_no = traveler_job_no
        self.traveler_name = traveler_name
        self.voucher_type = voucher_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.alipay_trade_no is not None:
            result['alipayTradeNo'] = self.alipay_trade_no
        if self.apply_id is not None:
            result['applyId'] = self.apply_id
        if self.arr_date is not None:
            result['arrDate'] = self.arr_date
        if self.arr_station is not None:
            result['arrStation'] = self.arr_station
        if self.arr_time is not None:
            result['arrTime'] = self.arr_time
        if self.bill_record_time is not None:
            result['billRecordTime'] = self.bill_record_time
        if self.book_time is not None:
            result['bookTime'] = self.book_time
        if self.booker_id is not None:
            result['bookerId'] = self.booker_id
        if self.booker_job_no is not None:
            result['bookerJobNo'] = self.booker_job_no
        if self.booker_name is not None:
            result['bookerName'] = self.booker_name
        if self.capital_direction is not None:
            result['capitalDirection'] = self.capital_direction
        if self.cascade_department is not None:
            result['cascadeDepartment'] = self.cascade_department
        if self.change_fee is not None:
            result['changeFee'] = self.change_fee
        if self.cost_center is not None:
            result['costCenter'] = self.cost_center
        if self.cost_center_number is not None:
            result['costCenterNumber'] = self.cost_center_number
        if self.coupon is not None:
            result['coupon'] = self.coupon
        if self.department is not None:
            result['department'] = self.department
        if self.department_id is not None:
            result['departmentId'] = self.department_id
        if self.dept_date is not None:
            result['deptDate'] = self.dept_date
        if self.dept_station is not None:
            result['deptStation'] = self.dept_station
        if self.dept_time is not None:
            result['deptTime'] = self.dept_time
        if self.fee_type is not None:
            result['feeType'] = self.fee_type
        if self.index is not None:
            result['index'] = self.index
        if self.invoice_title is not None:
            result['invoiceTitle'] = self.invoice_title
        if self.order_id is not None:
            result['orderId'] = self.order_id
        if self.order_price is not None:
            result['orderPrice'] = self.order_price
        if self.over_apply_id is not None:
            result['overApplyId'] = self.over_apply_id
        if self.primary_id is not None:
            result['primaryId'] = self.primary_id
        if self.project_code is not None:
            result['projectCode'] = self.project_code
        if self.project_name is not None:
            result['projectName'] = self.project_name
        if self.refund_fee is not None:
            result['refundFee'] = self.refund_fee
        if self.remark is not None:
            result['remark'] = self.remark
        if self.run_time is not None:
            result['runTime'] = self.run_time
        if self.seat_no is not None:
            result['seatNo'] = self.seat_no
        if self.seat_type is not None:
            result['seatType'] = self.seat_type
        if self.service_fee is not None:
            result['serviceFee'] = self.service_fee
        if self.settlement_fee is not None:
            result['settlementFee'] = self.settlement_fee
        if self.settlement_grant_fee is not None:
            result['settlementGrantFee'] = self.settlement_grant_fee
        if self.settlement_time is not None:
            result['settlementTime'] = self.settlement_time
        if self.settlement_type is not None:
            result['settlementType'] = self.settlement_type
        if self.status is not None:
            result['status'] = self.status
        if self.ticket_no is not None:
            result['ticketNo'] = self.ticket_no
        if self.ticket_price is not None:
            result['ticketPrice'] = self.ticket_price
        if self.train_no is not None:
            result['trainNo'] = self.train_no
        if self.train_type is not None:
            result['trainType'] = self.train_type
        if self.traveler_id is not None:
            result['travelerId'] = self.traveler_id
        if self.traveler_job_no is not None:
            result['travelerJobNo'] = self.traveler_job_no
        if self.traveler_name is not None:
            result['travelerName'] = self.traveler_name
        if self.voucher_type is not None:
            result['voucherType'] = self.voucher_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('alipayTradeNo') is not None:
            self.alipay_trade_no = m.get('alipayTradeNo')
        if m.get('applyId') is not None:
            self.apply_id = m.get('applyId')
        if m.get('arrDate') is not None:
            self.arr_date = m.get('arrDate')
        if m.get('arrStation') is not None:
            self.arr_station = m.get('arrStation')
        if m.get('arrTime') is not None:
            self.arr_time = m.get('arrTime')
        if m.get('billRecordTime') is not None:
            self.bill_record_time = m.get('billRecordTime')
        if m.get('bookTime') is not None:
            self.book_time = m.get('bookTime')
        if m.get('bookerId') is not None:
            self.booker_id = m.get('bookerId')
        if m.get('bookerJobNo') is not None:
            self.booker_job_no = m.get('bookerJobNo')
        if m.get('bookerName') is not None:
            self.booker_name = m.get('bookerName')
        if m.get('capitalDirection') is not None:
            self.capital_direction = m.get('capitalDirection')
        if m.get('cascadeDepartment') is not None:
            self.cascade_department = m.get('cascadeDepartment')
        if m.get('changeFee') is not None:
            self.change_fee = m.get('changeFee')
        if m.get('costCenter') is not None:
            self.cost_center = m.get('costCenter')
        if m.get('costCenterNumber') is not None:
            self.cost_center_number = m.get('costCenterNumber')
        if m.get('coupon') is not None:
            self.coupon = m.get('coupon')
        if m.get('department') is not None:
            self.department = m.get('department')
        if m.get('departmentId') is not None:
            self.department_id = m.get('departmentId')
        if m.get('deptDate') is not None:
            self.dept_date = m.get('deptDate')
        if m.get('deptStation') is not None:
            self.dept_station = m.get('deptStation')
        if m.get('deptTime') is not None:
            self.dept_time = m.get('deptTime')
        if m.get('feeType') is not None:
            self.fee_type = m.get('feeType')
        if m.get('index') is not None:
            self.index = m.get('index')
        if m.get('invoiceTitle') is not None:
            self.invoice_title = m.get('invoiceTitle')
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        if m.get('orderPrice') is not None:
            self.order_price = m.get('orderPrice')
        if m.get('overApplyId') is not None:
            self.over_apply_id = m.get('overApplyId')
        if m.get('primaryId') is not None:
            self.primary_id = m.get('primaryId')
        if m.get('projectCode') is not None:
            self.project_code = m.get('projectCode')
        if m.get('projectName') is not None:
            self.project_name = m.get('projectName')
        if m.get('refundFee') is not None:
            self.refund_fee = m.get('refundFee')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('runTime') is not None:
            self.run_time = m.get('runTime')
        if m.get('seatNo') is not None:
            self.seat_no = m.get('seatNo')
        if m.get('seatType') is not None:
            self.seat_type = m.get('seatType')
        if m.get('serviceFee') is not None:
            self.service_fee = m.get('serviceFee')
        if m.get('settlementFee') is not None:
            self.settlement_fee = m.get('settlementFee')
        if m.get('settlementGrantFee') is not None:
            self.settlement_grant_fee = m.get('settlementGrantFee')
        if m.get('settlementTime') is not None:
            self.settlement_time = m.get('settlementTime')
        if m.get('settlementType') is not None:
            self.settlement_type = m.get('settlementType')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('ticketNo') is not None:
            self.ticket_no = m.get('ticketNo')
        if m.get('ticketPrice') is not None:
            self.ticket_price = m.get('ticketPrice')
        if m.get('trainNo') is not None:
            self.train_no = m.get('trainNo')
        if m.get('trainType') is not None:
            self.train_type = m.get('trainType')
        if m.get('travelerId') is not None:
            self.traveler_id = m.get('travelerId')
        if m.get('travelerJobNo') is not None:
            self.traveler_job_no = m.get('travelerJobNo')
        if m.get('travelerName') is not None:
            self.traveler_name = m.get('travelerName')
        if m.get('voucherType') is not None:
            self.voucher_type = m.get('voucherType')
        return self


class BillSettementBtripTrainResponseBodyModule(TeaModel):
    def __init__(
        self,
        category: int = None,
        corp_id: str = None,
        data_list: List[BillSettementBtripTrainResponseBodyModuleDataList] = None,
        period_end: str = None,
        period_start: str = None,
        total_num: int = None,
    ):
        self.category = category
        self.corp_id = corp_id
        self.data_list = data_list
        self.period_end = period_end
        self.period_start = period_start
        self.total_num = total_num

    def validate(self):
        if self.data_list:
            for k in self.data_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category is not None:
            result['category'] = self.category
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        result['dataList'] = []
        if self.data_list is not None:
            for k in self.data_list:
                result['dataList'].append(k.to_map() if k else None)
        if self.period_end is not None:
            result['periodEnd'] = self.period_end
        if self.period_start is not None:
            result['periodStart'] = self.period_start
        if self.total_num is not None:
            result['totalNum'] = self.total_num
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        self.data_list = []
        if m.get('dataList') is not None:
            for k in m.get('dataList'):
                temp_model = BillSettementBtripTrainResponseBodyModuleDataList()
                self.data_list.append(temp_model.from_map(k))
        if m.get('periodEnd') is not None:
            self.period_end = m.get('periodEnd')
        if m.get('periodStart') is not None:
            self.period_start = m.get('periodStart')
        if m.get('totalNum') is not None:
            self.total_num = m.get('totalNum')
        return self


class BillSettementBtripTrainResponseBody(TeaModel):
    def __init__(
        self,
        module: BillSettementBtripTrainResponseBodyModule = None,
        result_code: int = None,
        result_msg: str = None,
        success: bool = None,
    ):
        self.module = module
        self.result_code = result_code
        self.result_msg = result_msg
        self.success = success

    def validate(self):
        if self.module:
            self.module.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.module is not None:
            result['module'] = self.module.to_map()
        if self.result_code is not None:
            result['resultCode'] = self.result_code
        if self.result_msg is not None:
            result['resultMsg'] = self.result_msg
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('module') is not None:
            temp_model = BillSettementBtripTrainResponseBodyModule()
            self.module = temp_model.from_map(m['module'])
        if m.get('resultCode') is not None:
            self.result_code = m.get('resultCode')
        if m.get('resultMsg') is not None:
            self.result_msg = m.get('resultMsg')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class BillSettementBtripTrainResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BillSettementBtripTrainResponseBody = None,
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
            temp_model = BillSettementBtripTrainResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BillSettementCarHeaders(TeaModel):
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


class BillSettementCarRequest(TeaModel):
    def __init__(
        self,
        category: int = None,
        corp_id: str = None,
        page_number: int = None,
        page_size: int = None,
        period_end: str = None,
        period_start: str = None,
    ):
        self.category = category
        self.corp_id = corp_id
        self.page_number = page_number
        self.page_size = page_size
        self.period_end = period_end
        self.period_start = period_start

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category is not None:
            result['category'] = self.category
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.period_end is not None:
            result['periodEnd'] = self.period_end
        if self.period_start is not None:
            result['periodStart'] = self.period_start
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('periodEnd') is not None:
            self.period_end = m.get('periodEnd')
        if m.get('periodStart') is not None:
            self.period_start = m.get('periodStart')
        return self


class BillSettementCarResponseBodyModuleDataList(TeaModel):
    def __init__(
        self,
        alipay_trade_no: str = None,
        apply_id: str = None,
        arr_city: str = None,
        arr_date: str = None,
        arr_location: str = None,
        arr_time: str = None,
        bill_record_time: str = None,
        book_time: str = None,
        booker_id: str = None,
        booker_job_no: str = None,
        booker_name: str = None,
        business_category: str = None,
        capital_direction: str = None,
        car_level: str = None,
        cascade_department: str = None,
        cost_center: str = None,
        cost_center_number: str = None,
        coupon: float = None,
        coupon_price: float = None,
        department: str = None,
        department_id: str = None,
        dept_city: str = None,
        dept_date: str = None,
        dept_location: str = None,
        dept_time: str = None,
        estimate_drive_distance: str = None,
        estimate_price: float = None,
        fee_type: str = None,
        index: str = None,
        invoice_title: str = None,
        memo: str = None,
        order_id: str = None,
        order_price: float = None,
        over_apply_id: str = None,
        person_settle_fee: float = None,
        primary_id: str = None,
        project_code: str = None,
        project_name: str = None,
        provider_name: str = None,
        real_drive_distance: str = None,
        real_from_addr: str = None,
        real_to_addr: str = None,
        remark: str = None,
        service_fee: str = None,
        settlement_fee: float = None,
        settlement_grant_fee: float = None,
        settlement_time: str = None,
        settlement_type: str = None,
        special_order: str = None,
        special_reason: str = None,
        status: int = None,
        sub_order_id: str = None,
        traveler_id: str = None,
        traveler_job_no: str = None,
        traveler_name: str = None,
        user_confirm_desc: str = None,
        voucher_type: int = None,
    ):
        self.alipay_trade_no = alipay_trade_no
        self.apply_id = apply_id
        self.arr_city = arr_city
        self.arr_date = arr_date
        self.arr_location = arr_location
        self.arr_time = arr_time
        self.bill_record_time = bill_record_time
        self.book_time = book_time
        self.booker_id = booker_id
        self.booker_job_no = booker_job_no
        self.booker_name = booker_name
        self.business_category = business_category
        self.capital_direction = capital_direction
        self.car_level = car_level
        self.cascade_department = cascade_department
        self.cost_center = cost_center
        self.cost_center_number = cost_center_number
        self.coupon = coupon
        self.coupon_price = coupon_price
        self.department = department
        self.department_id = department_id
        self.dept_city = dept_city
        self.dept_date = dept_date
        self.dept_location = dept_location
        self.dept_time = dept_time
        self.estimate_drive_distance = estimate_drive_distance
        self.estimate_price = estimate_price
        self.fee_type = fee_type
        self.index = index
        self.invoice_title = invoice_title
        self.memo = memo
        self.order_id = order_id
        self.order_price = order_price
        self.over_apply_id = over_apply_id
        self.person_settle_fee = person_settle_fee
        self.primary_id = primary_id
        self.project_code = project_code
        self.project_name = project_name
        self.provider_name = provider_name
        self.real_drive_distance = real_drive_distance
        self.real_from_addr = real_from_addr
        self.real_to_addr = real_to_addr
        self.remark = remark
        self.service_fee = service_fee
        self.settlement_fee = settlement_fee
        self.settlement_grant_fee = settlement_grant_fee
        self.settlement_time = settlement_time
        self.settlement_type = settlement_type
        self.special_order = special_order
        self.special_reason = special_reason
        self.status = status
        self.sub_order_id = sub_order_id
        self.traveler_id = traveler_id
        self.traveler_job_no = traveler_job_no
        self.traveler_name = traveler_name
        self.user_confirm_desc = user_confirm_desc
        self.voucher_type = voucher_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.alipay_trade_no is not None:
            result['alipayTradeNo'] = self.alipay_trade_no
        if self.apply_id is not None:
            result['applyId'] = self.apply_id
        if self.arr_city is not None:
            result['arrCity'] = self.arr_city
        if self.arr_date is not None:
            result['arrDate'] = self.arr_date
        if self.arr_location is not None:
            result['arrLocation'] = self.arr_location
        if self.arr_time is not None:
            result['arrTime'] = self.arr_time
        if self.bill_record_time is not None:
            result['billRecordTime'] = self.bill_record_time
        if self.book_time is not None:
            result['bookTime'] = self.book_time
        if self.booker_id is not None:
            result['bookerId'] = self.booker_id
        if self.booker_job_no is not None:
            result['bookerJobNo'] = self.booker_job_no
        if self.booker_name is not None:
            result['bookerName'] = self.booker_name
        if self.business_category is not None:
            result['businessCategory'] = self.business_category
        if self.capital_direction is not None:
            result['capitalDirection'] = self.capital_direction
        if self.car_level is not None:
            result['carLevel'] = self.car_level
        if self.cascade_department is not None:
            result['cascadeDepartment'] = self.cascade_department
        if self.cost_center is not None:
            result['costCenter'] = self.cost_center
        if self.cost_center_number is not None:
            result['costCenterNumber'] = self.cost_center_number
        if self.coupon is not None:
            result['coupon'] = self.coupon
        if self.coupon_price is not None:
            result['couponPrice'] = self.coupon_price
        if self.department is not None:
            result['department'] = self.department
        if self.department_id is not None:
            result['departmentId'] = self.department_id
        if self.dept_city is not None:
            result['deptCity'] = self.dept_city
        if self.dept_date is not None:
            result['deptDate'] = self.dept_date
        if self.dept_location is not None:
            result['deptLocation'] = self.dept_location
        if self.dept_time is not None:
            result['deptTime'] = self.dept_time
        if self.estimate_drive_distance is not None:
            result['estimateDriveDistance'] = self.estimate_drive_distance
        if self.estimate_price is not None:
            result['estimatePrice'] = self.estimate_price
        if self.fee_type is not None:
            result['feeType'] = self.fee_type
        if self.index is not None:
            result['index'] = self.index
        if self.invoice_title is not None:
            result['invoiceTitle'] = self.invoice_title
        if self.memo is not None:
            result['memo'] = self.memo
        if self.order_id is not None:
            result['orderId'] = self.order_id
        if self.order_price is not None:
            result['orderPrice'] = self.order_price
        if self.over_apply_id is not None:
            result['overApplyId'] = self.over_apply_id
        if self.person_settle_fee is not None:
            result['personSettleFee'] = self.person_settle_fee
        if self.primary_id is not None:
            result['primaryId'] = self.primary_id
        if self.project_code is not None:
            result['projectCode'] = self.project_code
        if self.project_name is not None:
            result['projectName'] = self.project_name
        if self.provider_name is not None:
            result['providerName'] = self.provider_name
        if self.real_drive_distance is not None:
            result['realDriveDistance'] = self.real_drive_distance
        if self.real_from_addr is not None:
            result['realFromAddr'] = self.real_from_addr
        if self.real_to_addr is not None:
            result['realToAddr'] = self.real_to_addr
        if self.remark is not None:
            result['remark'] = self.remark
        if self.service_fee is not None:
            result['serviceFee'] = self.service_fee
        if self.settlement_fee is not None:
            result['settlementFee'] = self.settlement_fee
        if self.settlement_grant_fee is not None:
            result['settlementGrantFee'] = self.settlement_grant_fee
        if self.settlement_time is not None:
            result['settlementTime'] = self.settlement_time
        if self.settlement_type is not None:
            result['settlementType'] = self.settlement_type
        if self.special_order is not None:
            result['specialOrder'] = self.special_order
        if self.special_reason is not None:
            result['specialReason'] = self.special_reason
        if self.status is not None:
            result['status'] = self.status
        if self.sub_order_id is not None:
            result['subOrderId'] = self.sub_order_id
        if self.traveler_id is not None:
            result['travelerId'] = self.traveler_id
        if self.traveler_job_no is not None:
            result['travelerJobNo'] = self.traveler_job_no
        if self.traveler_name is not None:
            result['travelerName'] = self.traveler_name
        if self.user_confirm_desc is not None:
            result['userConfirmDesc'] = self.user_confirm_desc
        if self.voucher_type is not None:
            result['voucherType'] = self.voucher_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('alipayTradeNo') is not None:
            self.alipay_trade_no = m.get('alipayTradeNo')
        if m.get('applyId') is not None:
            self.apply_id = m.get('applyId')
        if m.get('arrCity') is not None:
            self.arr_city = m.get('arrCity')
        if m.get('arrDate') is not None:
            self.arr_date = m.get('arrDate')
        if m.get('arrLocation') is not None:
            self.arr_location = m.get('arrLocation')
        if m.get('arrTime') is not None:
            self.arr_time = m.get('arrTime')
        if m.get('billRecordTime') is not None:
            self.bill_record_time = m.get('billRecordTime')
        if m.get('bookTime') is not None:
            self.book_time = m.get('bookTime')
        if m.get('bookerId') is not None:
            self.booker_id = m.get('bookerId')
        if m.get('bookerJobNo') is not None:
            self.booker_job_no = m.get('bookerJobNo')
        if m.get('bookerName') is not None:
            self.booker_name = m.get('bookerName')
        if m.get('businessCategory') is not None:
            self.business_category = m.get('businessCategory')
        if m.get('capitalDirection') is not None:
            self.capital_direction = m.get('capitalDirection')
        if m.get('carLevel') is not None:
            self.car_level = m.get('carLevel')
        if m.get('cascadeDepartment') is not None:
            self.cascade_department = m.get('cascadeDepartment')
        if m.get('costCenter') is not None:
            self.cost_center = m.get('costCenter')
        if m.get('costCenterNumber') is not None:
            self.cost_center_number = m.get('costCenterNumber')
        if m.get('coupon') is not None:
            self.coupon = m.get('coupon')
        if m.get('couponPrice') is not None:
            self.coupon_price = m.get('couponPrice')
        if m.get('department') is not None:
            self.department = m.get('department')
        if m.get('departmentId') is not None:
            self.department_id = m.get('departmentId')
        if m.get('deptCity') is not None:
            self.dept_city = m.get('deptCity')
        if m.get('deptDate') is not None:
            self.dept_date = m.get('deptDate')
        if m.get('deptLocation') is not None:
            self.dept_location = m.get('deptLocation')
        if m.get('deptTime') is not None:
            self.dept_time = m.get('deptTime')
        if m.get('estimateDriveDistance') is not None:
            self.estimate_drive_distance = m.get('estimateDriveDistance')
        if m.get('estimatePrice') is not None:
            self.estimate_price = m.get('estimatePrice')
        if m.get('feeType') is not None:
            self.fee_type = m.get('feeType')
        if m.get('index') is not None:
            self.index = m.get('index')
        if m.get('invoiceTitle') is not None:
            self.invoice_title = m.get('invoiceTitle')
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        if m.get('orderPrice') is not None:
            self.order_price = m.get('orderPrice')
        if m.get('overApplyId') is not None:
            self.over_apply_id = m.get('overApplyId')
        if m.get('personSettleFee') is not None:
            self.person_settle_fee = m.get('personSettleFee')
        if m.get('primaryId') is not None:
            self.primary_id = m.get('primaryId')
        if m.get('projectCode') is not None:
            self.project_code = m.get('projectCode')
        if m.get('projectName') is not None:
            self.project_name = m.get('projectName')
        if m.get('providerName') is not None:
            self.provider_name = m.get('providerName')
        if m.get('realDriveDistance') is not None:
            self.real_drive_distance = m.get('realDriveDistance')
        if m.get('realFromAddr') is not None:
            self.real_from_addr = m.get('realFromAddr')
        if m.get('realToAddr') is not None:
            self.real_to_addr = m.get('realToAddr')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('serviceFee') is not None:
            self.service_fee = m.get('serviceFee')
        if m.get('settlementFee') is not None:
            self.settlement_fee = m.get('settlementFee')
        if m.get('settlementGrantFee') is not None:
            self.settlement_grant_fee = m.get('settlementGrantFee')
        if m.get('settlementTime') is not None:
            self.settlement_time = m.get('settlementTime')
        if m.get('settlementType') is not None:
            self.settlement_type = m.get('settlementType')
        if m.get('specialOrder') is not None:
            self.special_order = m.get('specialOrder')
        if m.get('specialReason') is not None:
            self.special_reason = m.get('specialReason')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('subOrderId') is not None:
            self.sub_order_id = m.get('subOrderId')
        if m.get('travelerId') is not None:
            self.traveler_id = m.get('travelerId')
        if m.get('travelerJobNo') is not None:
            self.traveler_job_no = m.get('travelerJobNo')
        if m.get('travelerName') is not None:
            self.traveler_name = m.get('travelerName')
        if m.get('userConfirmDesc') is not None:
            self.user_confirm_desc = m.get('userConfirmDesc')
        if m.get('voucherType') is not None:
            self.voucher_type = m.get('voucherType')
        return self


class BillSettementCarResponseBodyModule(TeaModel):
    def __init__(
        self,
        category: int = None,
        corp_id: str = None,
        data_list: List[BillSettementCarResponseBodyModuleDataList] = None,
        period_end: str = None,
        period_start: str = None,
        total_num: int = None,
    ):
        self.category = category
        self.corp_id = corp_id
        self.data_list = data_list
        self.period_end = period_end
        self.period_start = period_start
        self.total_num = total_num

    def validate(self):
        if self.data_list:
            for k in self.data_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category is not None:
            result['category'] = self.category
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        result['dataList'] = []
        if self.data_list is not None:
            for k in self.data_list:
                result['dataList'].append(k.to_map() if k else None)
        if self.period_end is not None:
            result['periodEnd'] = self.period_end
        if self.period_start is not None:
            result['periodStart'] = self.period_start
        if self.total_num is not None:
            result['totalNum'] = self.total_num
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        self.data_list = []
        if m.get('dataList') is not None:
            for k in m.get('dataList'):
                temp_model = BillSettementCarResponseBodyModuleDataList()
                self.data_list.append(temp_model.from_map(k))
        if m.get('periodEnd') is not None:
            self.period_end = m.get('periodEnd')
        if m.get('periodStart') is not None:
            self.period_start = m.get('periodStart')
        if m.get('totalNum') is not None:
            self.total_num = m.get('totalNum')
        return self


class BillSettementCarResponseBody(TeaModel):
    def __init__(
        self,
        module: BillSettementCarResponseBodyModule = None,
        result_code: int = None,
        result_msg: str = None,
        success: bool = None,
    ):
        self.module = module
        self.result_code = result_code
        self.result_msg = result_msg
        self.success = success

    def validate(self):
        if self.module:
            self.module.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.module is not None:
            result['module'] = self.module.to_map()
        if self.result_code is not None:
            result['resultCode'] = self.result_code
        if self.result_msg is not None:
            result['resultMsg'] = self.result_msg
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('module') is not None:
            temp_model = BillSettementCarResponseBodyModule()
            self.module = temp_model.from_map(m['module'])
        if m.get('resultCode') is not None:
            self.result_code = m.get('resultCode')
        if m.get('resultMsg') is not None:
            self.result_msg = m.get('resultMsg')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class BillSettementCarResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BillSettementCarResponseBody = None,
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
            temp_model = BillSettementCarResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BillSettementFlightHeaders(TeaModel):
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


class BillSettementFlightRequest(TeaModel):
    def __init__(
        self,
        category: int = None,
        corp_id: str = None,
        page_number: int = None,
        page_size: int = None,
        period_end: str = None,
        period_start: str = None,
    ):
        self.category = category
        self.corp_id = corp_id
        self.page_number = page_number
        self.page_size = page_size
        self.period_end = period_end
        self.period_start = period_start

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category is not None:
            result['category'] = self.category
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.period_end is not None:
            result['periodEnd'] = self.period_end
        if self.period_start is not None:
            result['periodStart'] = self.period_start
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('periodEnd') is not None:
            self.period_end = m.get('periodEnd')
        if m.get('periodStart') is not None:
            self.period_start = m.get('periodStart')
        return self


class BillSettementFlightResponseBodyModuleDataList(TeaModel):
    def __init__(
        self,
        advance_day: int = None,
        airline_corp_code: str = None,
        airline_corp_name: str = None,
        alipay_trade_no: str = None,
        apply_id: str = None,
        arr_airport_code: str = None,
        arr_city: str = None,
        arr_date: str = None,
        arr_station: str = None,
        arr_time: str = None,
        bill_record_time: str = None,
        book_time: str = None,
        booker_id: str = None,
        booker_job_no: str = None,
        booker_name: str = None,
        btrip_coupon_fee: float = None,
        build_fee: float = None,
        cabin: str = None,
        cabin_class: str = None,
        capital_direction: str = None,
        cascade_department: str = None,
        change_fee: float = None,
        corp_pay_order_fee: float = None,
        cost_center: str = None,
        cost_center_number: str = None,
        coupon: float = None,
        dep_airport_code: str = None,
        department: str = None,
        department_id: str = None,
        dept_city: str = None,
        dept_date: str = None,
        dept_station: str = None,
        dept_time: str = None,
        discount: str = None,
        fee_type: str = None,
        flight_no: str = None,
        index: str = None,
        insurance_fee: float = None,
        invoice_title: str = None,
        itinerary_num: str = None,
        itinerary_price: float = None,
        most_difference_dept_time: str = None,
        most_difference_discount: str = None,
        most_difference_flight_no: str = None,
        most_difference_price: float = None,
        most_difference_reason: str = None,
        most_price: float = None,
        negotiation_coupon_fee: float = None,
        oil_fee: float = None,
        order_id: str = None,
        over_apply_id: str = None,
        primary_id: int = None,
        project_code: str = None,
        project_name: str = None,
        refund_fee: float = None,
        refund_upgrade_cost: float = None,
        remark: str = None,
        repeat_refund: str = None,
        seal_price: float = None,
        service_fee: float = None,
        settlement_fee: float = None,
        settlement_grant_fee: float = None,
        settlement_time: str = None,
        settlement_type: str = None,
        status: int = None,
        ticket_id: str = None,
        traveler_id: str = None,
        traveler_job_no: str = None,
        traveler_name: str = None,
        upgrade_cost: float = None,
        voucher_type: int = None,
    ):
        self.advance_day = advance_day
        self.airline_corp_code = airline_corp_code
        self.airline_corp_name = airline_corp_name
        self.alipay_trade_no = alipay_trade_no
        self.apply_id = apply_id
        self.arr_airport_code = arr_airport_code
        self.arr_city = arr_city
        self.arr_date = arr_date
        self.arr_station = arr_station
        self.arr_time = arr_time
        self.bill_record_time = bill_record_time
        self.book_time = book_time
        self.booker_id = booker_id
        self.booker_job_no = booker_job_no
        self.booker_name = booker_name
        self.btrip_coupon_fee = btrip_coupon_fee
        self.build_fee = build_fee
        self.cabin = cabin
        self.cabin_class = cabin_class
        self.capital_direction = capital_direction
        self.cascade_department = cascade_department
        self.change_fee = change_fee
        self.corp_pay_order_fee = corp_pay_order_fee
        self.cost_center = cost_center
        self.cost_center_number = cost_center_number
        self.coupon = coupon
        self.dep_airport_code = dep_airport_code
        self.department = department
        self.department_id = department_id
        self.dept_city = dept_city
        self.dept_date = dept_date
        self.dept_station = dept_station
        self.dept_time = dept_time
        self.discount = discount
        self.fee_type = fee_type
        self.flight_no = flight_no
        self.index = index
        self.insurance_fee = insurance_fee
        self.invoice_title = invoice_title
        self.itinerary_num = itinerary_num
        self.itinerary_price = itinerary_price
        self.most_difference_dept_time = most_difference_dept_time
        self.most_difference_discount = most_difference_discount
        self.most_difference_flight_no = most_difference_flight_no
        self.most_difference_price = most_difference_price
        self.most_difference_reason = most_difference_reason
        self.most_price = most_price
        self.negotiation_coupon_fee = negotiation_coupon_fee
        self.oil_fee = oil_fee
        self.order_id = order_id
        self.over_apply_id = over_apply_id
        self.primary_id = primary_id
        self.project_code = project_code
        self.project_name = project_name
        self.refund_fee = refund_fee
        self.refund_upgrade_cost = refund_upgrade_cost
        self.remark = remark
        self.repeat_refund = repeat_refund
        self.seal_price = seal_price
        self.service_fee = service_fee
        self.settlement_fee = settlement_fee
        self.settlement_grant_fee = settlement_grant_fee
        self.settlement_time = settlement_time
        self.settlement_type = settlement_type
        self.status = status
        self.ticket_id = ticket_id
        self.traveler_id = traveler_id
        self.traveler_job_no = traveler_job_no
        self.traveler_name = traveler_name
        self.upgrade_cost = upgrade_cost
        self.voucher_type = voucher_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.advance_day is not None:
            result['advanceDay'] = self.advance_day
        if self.airline_corp_code is not None:
            result['airlineCorpCode'] = self.airline_corp_code
        if self.airline_corp_name is not None:
            result['airlineCorpName'] = self.airline_corp_name
        if self.alipay_trade_no is not None:
            result['alipayTradeNo'] = self.alipay_trade_no
        if self.apply_id is not None:
            result['applyId'] = self.apply_id
        if self.arr_airport_code is not None:
            result['arrAirportCode'] = self.arr_airport_code
        if self.arr_city is not None:
            result['arrCity'] = self.arr_city
        if self.arr_date is not None:
            result['arrDate'] = self.arr_date
        if self.arr_station is not None:
            result['arrStation'] = self.arr_station
        if self.arr_time is not None:
            result['arrTime'] = self.arr_time
        if self.bill_record_time is not None:
            result['billRecordTime'] = self.bill_record_time
        if self.book_time is not None:
            result['bookTime'] = self.book_time
        if self.booker_id is not None:
            result['bookerId'] = self.booker_id
        if self.booker_job_no is not None:
            result['bookerJobNo'] = self.booker_job_no
        if self.booker_name is not None:
            result['bookerName'] = self.booker_name
        if self.btrip_coupon_fee is not None:
            result['btripCouponFee'] = self.btrip_coupon_fee
        if self.build_fee is not None:
            result['buildFee'] = self.build_fee
        if self.cabin is not None:
            result['cabin'] = self.cabin
        if self.cabin_class is not None:
            result['cabinClass'] = self.cabin_class
        if self.capital_direction is not None:
            result['capitalDirection'] = self.capital_direction
        if self.cascade_department is not None:
            result['cascadeDepartment'] = self.cascade_department
        if self.change_fee is not None:
            result['changeFee'] = self.change_fee
        if self.corp_pay_order_fee is not None:
            result['corpPayOrderFee'] = self.corp_pay_order_fee
        if self.cost_center is not None:
            result['costCenter'] = self.cost_center
        if self.cost_center_number is not None:
            result['costCenterNumber'] = self.cost_center_number
        if self.coupon is not None:
            result['coupon'] = self.coupon
        if self.dep_airport_code is not None:
            result['depAirportCode'] = self.dep_airport_code
        if self.department is not None:
            result['department'] = self.department
        if self.department_id is not None:
            result['departmentId'] = self.department_id
        if self.dept_city is not None:
            result['deptCity'] = self.dept_city
        if self.dept_date is not None:
            result['deptDate'] = self.dept_date
        if self.dept_station is not None:
            result['deptStation'] = self.dept_station
        if self.dept_time is not None:
            result['deptTime'] = self.dept_time
        if self.discount is not None:
            result['discount'] = self.discount
        if self.fee_type is not None:
            result['feeType'] = self.fee_type
        if self.flight_no is not None:
            result['flightNo'] = self.flight_no
        if self.index is not None:
            result['index'] = self.index
        if self.insurance_fee is not None:
            result['insuranceFee'] = self.insurance_fee
        if self.invoice_title is not None:
            result['invoiceTitle'] = self.invoice_title
        if self.itinerary_num is not None:
            result['itineraryNum'] = self.itinerary_num
        if self.itinerary_price is not None:
            result['itineraryPrice'] = self.itinerary_price
        if self.most_difference_dept_time is not None:
            result['mostDifferenceDeptTime'] = self.most_difference_dept_time
        if self.most_difference_discount is not None:
            result['mostDifferenceDiscount'] = self.most_difference_discount
        if self.most_difference_flight_no is not None:
            result['mostDifferenceFlightNo'] = self.most_difference_flight_no
        if self.most_difference_price is not None:
            result['mostDifferencePrice'] = self.most_difference_price
        if self.most_difference_reason is not None:
            result['mostDifferenceReason'] = self.most_difference_reason
        if self.most_price is not None:
            result['mostPrice'] = self.most_price
        if self.negotiation_coupon_fee is not None:
            result['negotiationCouponFee'] = self.negotiation_coupon_fee
        if self.oil_fee is not None:
            result['oilFee'] = self.oil_fee
        if self.order_id is not None:
            result['orderId'] = self.order_id
        if self.over_apply_id is not None:
            result['overApplyId'] = self.over_apply_id
        if self.primary_id is not None:
            result['primaryId'] = self.primary_id
        if self.project_code is not None:
            result['projectCode'] = self.project_code
        if self.project_name is not None:
            result['projectName'] = self.project_name
        if self.refund_fee is not None:
            result['refundFee'] = self.refund_fee
        if self.refund_upgrade_cost is not None:
            result['refundUpgradeCost'] = self.refund_upgrade_cost
        if self.remark is not None:
            result['remark'] = self.remark
        if self.repeat_refund is not None:
            result['repeatRefund'] = self.repeat_refund
        if self.seal_price is not None:
            result['sealPrice'] = self.seal_price
        if self.service_fee is not None:
            result['serviceFee'] = self.service_fee
        if self.settlement_fee is not None:
            result['settlementFee'] = self.settlement_fee
        if self.settlement_grant_fee is not None:
            result['settlementGrantFee'] = self.settlement_grant_fee
        if self.settlement_time is not None:
            result['settlementTime'] = self.settlement_time
        if self.settlement_type is not None:
            result['settlementType'] = self.settlement_type
        if self.status is not None:
            result['status'] = self.status
        if self.ticket_id is not None:
            result['ticketId'] = self.ticket_id
        if self.traveler_id is not None:
            result['travelerId'] = self.traveler_id
        if self.traveler_job_no is not None:
            result['travelerJobNo'] = self.traveler_job_no
        if self.traveler_name is not None:
            result['travelerName'] = self.traveler_name
        if self.upgrade_cost is not None:
            result['upgradeCost'] = self.upgrade_cost
        if self.voucher_type is not None:
            result['voucherType'] = self.voucher_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('advanceDay') is not None:
            self.advance_day = m.get('advanceDay')
        if m.get('airlineCorpCode') is not None:
            self.airline_corp_code = m.get('airlineCorpCode')
        if m.get('airlineCorpName') is not None:
            self.airline_corp_name = m.get('airlineCorpName')
        if m.get('alipayTradeNo') is not None:
            self.alipay_trade_no = m.get('alipayTradeNo')
        if m.get('applyId') is not None:
            self.apply_id = m.get('applyId')
        if m.get('arrAirportCode') is not None:
            self.arr_airport_code = m.get('arrAirportCode')
        if m.get('arrCity') is not None:
            self.arr_city = m.get('arrCity')
        if m.get('arrDate') is not None:
            self.arr_date = m.get('arrDate')
        if m.get('arrStation') is not None:
            self.arr_station = m.get('arrStation')
        if m.get('arrTime') is not None:
            self.arr_time = m.get('arrTime')
        if m.get('billRecordTime') is not None:
            self.bill_record_time = m.get('billRecordTime')
        if m.get('bookTime') is not None:
            self.book_time = m.get('bookTime')
        if m.get('bookerId') is not None:
            self.booker_id = m.get('bookerId')
        if m.get('bookerJobNo') is not None:
            self.booker_job_no = m.get('bookerJobNo')
        if m.get('bookerName') is not None:
            self.booker_name = m.get('bookerName')
        if m.get('btripCouponFee') is not None:
            self.btrip_coupon_fee = m.get('btripCouponFee')
        if m.get('buildFee') is not None:
            self.build_fee = m.get('buildFee')
        if m.get('cabin') is not None:
            self.cabin = m.get('cabin')
        if m.get('cabinClass') is not None:
            self.cabin_class = m.get('cabinClass')
        if m.get('capitalDirection') is not None:
            self.capital_direction = m.get('capitalDirection')
        if m.get('cascadeDepartment') is not None:
            self.cascade_department = m.get('cascadeDepartment')
        if m.get('changeFee') is not None:
            self.change_fee = m.get('changeFee')
        if m.get('corpPayOrderFee') is not None:
            self.corp_pay_order_fee = m.get('corpPayOrderFee')
        if m.get('costCenter') is not None:
            self.cost_center = m.get('costCenter')
        if m.get('costCenterNumber') is not None:
            self.cost_center_number = m.get('costCenterNumber')
        if m.get('coupon') is not None:
            self.coupon = m.get('coupon')
        if m.get('depAirportCode') is not None:
            self.dep_airport_code = m.get('depAirportCode')
        if m.get('department') is not None:
            self.department = m.get('department')
        if m.get('departmentId') is not None:
            self.department_id = m.get('departmentId')
        if m.get('deptCity') is not None:
            self.dept_city = m.get('deptCity')
        if m.get('deptDate') is not None:
            self.dept_date = m.get('deptDate')
        if m.get('deptStation') is not None:
            self.dept_station = m.get('deptStation')
        if m.get('deptTime') is not None:
            self.dept_time = m.get('deptTime')
        if m.get('discount') is not None:
            self.discount = m.get('discount')
        if m.get('feeType') is not None:
            self.fee_type = m.get('feeType')
        if m.get('flightNo') is not None:
            self.flight_no = m.get('flightNo')
        if m.get('index') is not None:
            self.index = m.get('index')
        if m.get('insuranceFee') is not None:
            self.insurance_fee = m.get('insuranceFee')
        if m.get('invoiceTitle') is not None:
            self.invoice_title = m.get('invoiceTitle')
        if m.get('itineraryNum') is not None:
            self.itinerary_num = m.get('itineraryNum')
        if m.get('itineraryPrice') is not None:
            self.itinerary_price = m.get('itineraryPrice')
        if m.get('mostDifferenceDeptTime') is not None:
            self.most_difference_dept_time = m.get('mostDifferenceDeptTime')
        if m.get('mostDifferenceDiscount') is not None:
            self.most_difference_discount = m.get('mostDifferenceDiscount')
        if m.get('mostDifferenceFlightNo') is not None:
            self.most_difference_flight_no = m.get('mostDifferenceFlightNo')
        if m.get('mostDifferencePrice') is not None:
            self.most_difference_price = m.get('mostDifferencePrice')
        if m.get('mostDifferenceReason') is not None:
            self.most_difference_reason = m.get('mostDifferenceReason')
        if m.get('mostPrice') is not None:
            self.most_price = m.get('mostPrice')
        if m.get('negotiationCouponFee') is not None:
            self.negotiation_coupon_fee = m.get('negotiationCouponFee')
        if m.get('oilFee') is not None:
            self.oil_fee = m.get('oilFee')
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        if m.get('overApplyId') is not None:
            self.over_apply_id = m.get('overApplyId')
        if m.get('primaryId') is not None:
            self.primary_id = m.get('primaryId')
        if m.get('projectCode') is not None:
            self.project_code = m.get('projectCode')
        if m.get('projectName') is not None:
            self.project_name = m.get('projectName')
        if m.get('refundFee') is not None:
            self.refund_fee = m.get('refundFee')
        if m.get('refundUpgradeCost') is not None:
            self.refund_upgrade_cost = m.get('refundUpgradeCost')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('repeatRefund') is not None:
            self.repeat_refund = m.get('repeatRefund')
        if m.get('sealPrice') is not None:
            self.seal_price = m.get('sealPrice')
        if m.get('serviceFee') is not None:
            self.service_fee = m.get('serviceFee')
        if m.get('settlementFee') is not None:
            self.settlement_fee = m.get('settlementFee')
        if m.get('settlementGrantFee') is not None:
            self.settlement_grant_fee = m.get('settlementGrantFee')
        if m.get('settlementTime') is not None:
            self.settlement_time = m.get('settlementTime')
        if m.get('settlementType') is not None:
            self.settlement_type = m.get('settlementType')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('ticketId') is not None:
            self.ticket_id = m.get('ticketId')
        if m.get('travelerId') is not None:
            self.traveler_id = m.get('travelerId')
        if m.get('travelerJobNo') is not None:
            self.traveler_job_no = m.get('travelerJobNo')
        if m.get('travelerName') is not None:
            self.traveler_name = m.get('travelerName')
        if m.get('upgradeCost') is not None:
            self.upgrade_cost = m.get('upgradeCost')
        if m.get('voucherType') is not None:
            self.voucher_type = m.get('voucherType')
        return self


class BillSettementFlightResponseBodyModule(TeaModel):
    def __init__(
        self,
        category: int = None,
        corp_id: str = None,
        data_list: List[BillSettementFlightResponseBodyModuleDataList] = None,
        period_end: str = None,
        period_start: str = None,
        total_num: int = None,
    ):
        self.category = category
        self.corp_id = corp_id
        self.data_list = data_list
        self.period_end = period_end
        self.period_start = period_start
        self.total_num = total_num

    def validate(self):
        if self.data_list:
            for k in self.data_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category is not None:
            result['category'] = self.category
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        result['dataList'] = []
        if self.data_list is not None:
            for k in self.data_list:
                result['dataList'].append(k.to_map() if k else None)
        if self.period_end is not None:
            result['periodEnd'] = self.period_end
        if self.period_start is not None:
            result['periodStart'] = self.period_start
        if self.total_num is not None:
            result['totalNum'] = self.total_num
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        self.data_list = []
        if m.get('dataList') is not None:
            for k in m.get('dataList'):
                temp_model = BillSettementFlightResponseBodyModuleDataList()
                self.data_list.append(temp_model.from_map(k))
        if m.get('periodEnd') is not None:
            self.period_end = m.get('periodEnd')
        if m.get('periodStart') is not None:
            self.period_start = m.get('periodStart')
        if m.get('totalNum') is not None:
            self.total_num = m.get('totalNum')
        return self


class BillSettementFlightResponseBody(TeaModel):
    def __init__(
        self,
        module: BillSettementFlightResponseBodyModule = None,
        result_code: int = None,
        result_msg: str = None,
        success: bool = None,
    ):
        self.module = module
        self.result_code = result_code
        self.result_msg = result_msg
        self.success = success

    def validate(self):
        if self.module:
            self.module.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.module is not None:
            result['module'] = self.module.to_map()
        if self.result_code is not None:
            result['resultCode'] = self.result_code
        if self.result_msg is not None:
            result['resultMsg'] = self.result_msg
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('module') is not None:
            temp_model = BillSettementFlightResponseBodyModule()
            self.module = temp_model.from_map(m['module'])
        if m.get('resultCode') is not None:
            self.result_code = m.get('resultCode')
        if m.get('resultMsg') is not None:
            self.result_msg = m.get('resultMsg')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class BillSettementFlightResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BillSettementFlightResponseBody = None,
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
            temp_model = BillSettementFlightResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BillSettementHotelHeaders(TeaModel):
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


class BillSettementHotelRequest(TeaModel):
    def __init__(
        self,
        category: int = None,
        corp_id: str = None,
        page_number: int = None,
        page_size: int = None,
        period_end: str = None,
        period_start: str = None,
    ):
        self.category = category
        self.corp_id = corp_id
        self.page_number = page_number
        self.page_size = page_size
        self.period_end = period_end
        self.period_start = period_start

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category is not None:
            result['category'] = self.category
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.period_end is not None:
            result['periodEnd'] = self.period_end
        if self.period_start is not None:
            result['periodStart'] = self.period_start
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('periodEnd') is not None:
            self.period_end = m.get('periodEnd')
        if m.get('periodStart') is not None:
            self.period_start = m.get('periodStart')
        return self


class BillSettementHotelResponseBodyModuleDataList(TeaModel):
    def __init__(
        self,
        alipay_trade_no: str = None,
        apply_id: str = None,
        bill_record_time: str = None,
        book_time: str = None,
        booker_id: str = None,
        booker_job_no: str = None,
        booker_name: str = None,
        capital_direction: str = None,
        cascade_department: str = None,
        check_in_date: str = None,
        checkout_date: str = None,
        city: str = None,
        city_code: str = None,
        corp_refund_fee: float = None,
        corp_total_fee: float = None,
        cost_center: str = None,
        cost_center_number: str = None,
        department: str = None,
        department_id: str = None,
        fee_type: str = None,
        fees: float = None,
        fu_point_fee: float = None,
        hotel_name: str = None,
        index: str = None,
        invoice_title: str = None,
        is_negotiation: bool = None,
        is_share_str: str = None,
        nights: int = None,
        order_id: str = None,
        order_price: float = None,
        order_type: str = None,
        over_apply_id: str = None,
        person_refund_fee: float = None,
        person_settle_price: float = None,
        primary_id: int = None,
        project_code: str = None,
        project_name: str = None,
        promotion_fee: float = None,
        remark: str = None,
        room_number: int = None,
        room_price: float = None,
        room_type: str = None,
        service_fee: float = None,
        settlement_fee: float = None,
        settlement_grant_fee: float = None,
        settlement_time: str = None,
        settlement_type: str = None,
        status: int = None,
        total_nights: int = None,
        traveler_id: str = None,
        traveler_job_no: str = None,
        traveler_name: str = None,
        voucher_type: int = None,
    ):
        self.alipay_trade_no = alipay_trade_no
        self.apply_id = apply_id
        self.bill_record_time = bill_record_time
        self.book_time = book_time
        self.booker_id = booker_id
        self.booker_job_no = booker_job_no
        self.booker_name = booker_name
        self.capital_direction = capital_direction
        self.cascade_department = cascade_department
        self.check_in_date = check_in_date
        self.checkout_date = checkout_date
        self.city = city
        self.city_code = city_code
        self.corp_refund_fee = corp_refund_fee
        self.corp_total_fee = corp_total_fee
        self.cost_center = cost_center
        self.cost_center_number = cost_center_number
        self.department = department
        self.department_id = department_id
        self.fee_type = fee_type
        self.fees = fees
        self.fu_point_fee = fu_point_fee
        self.hotel_name = hotel_name
        self.index = index
        self.invoice_title = invoice_title
        self.is_negotiation = is_negotiation
        self.is_share_str = is_share_str
        self.nights = nights
        self.order_id = order_id
        self.order_price = order_price
        self.order_type = order_type
        self.over_apply_id = over_apply_id
        self.person_refund_fee = person_refund_fee
        self.person_settle_price = person_settle_price
        self.primary_id = primary_id
        self.project_code = project_code
        self.project_name = project_name
        self.promotion_fee = promotion_fee
        self.remark = remark
        self.room_number = room_number
        self.room_price = room_price
        self.room_type = room_type
        self.service_fee = service_fee
        self.settlement_fee = settlement_fee
        self.settlement_grant_fee = settlement_grant_fee
        self.settlement_time = settlement_time
        self.settlement_type = settlement_type
        self.status = status
        self.total_nights = total_nights
        self.traveler_id = traveler_id
        self.traveler_job_no = traveler_job_no
        self.traveler_name = traveler_name
        self.voucher_type = voucher_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.alipay_trade_no is not None:
            result['alipayTradeNo'] = self.alipay_trade_no
        if self.apply_id is not None:
            result['applyId'] = self.apply_id
        if self.bill_record_time is not None:
            result['billRecordTime'] = self.bill_record_time
        if self.book_time is not None:
            result['bookTime'] = self.book_time
        if self.booker_id is not None:
            result['bookerId'] = self.booker_id
        if self.booker_job_no is not None:
            result['bookerJobNo'] = self.booker_job_no
        if self.booker_name is not None:
            result['bookerName'] = self.booker_name
        if self.capital_direction is not None:
            result['capitalDirection'] = self.capital_direction
        if self.cascade_department is not None:
            result['cascadeDepartment'] = self.cascade_department
        if self.check_in_date is not None:
            result['checkInDate'] = self.check_in_date
        if self.checkout_date is not None:
            result['checkoutDate'] = self.checkout_date
        if self.city is not None:
            result['city'] = self.city
        if self.city_code is not None:
            result['cityCode'] = self.city_code
        if self.corp_refund_fee is not None:
            result['corpRefundFee'] = self.corp_refund_fee
        if self.corp_total_fee is not None:
            result['corpTotalFee'] = self.corp_total_fee
        if self.cost_center is not None:
            result['costCenter'] = self.cost_center
        if self.cost_center_number is not None:
            result['costCenterNumber'] = self.cost_center_number
        if self.department is not None:
            result['department'] = self.department
        if self.department_id is not None:
            result['departmentId'] = self.department_id
        if self.fee_type is not None:
            result['feeType'] = self.fee_type
        if self.fees is not None:
            result['fees'] = self.fees
        if self.fu_point_fee is not None:
            result['fuPointFee'] = self.fu_point_fee
        if self.hotel_name is not None:
            result['hotelName'] = self.hotel_name
        if self.index is not None:
            result['index'] = self.index
        if self.invoice_title is not None:
            result['invoiceTitle'] = self.invoice_title
        if self.is_negotiation is not None:
            result['isNegotiation'] = self.is_negotiation
        if self.is_share_str is not None:
            result['isShareStr'] = self.is_share_str
        if self.nights is not None:
            result['nights'] = self.nights
        if self.order_id is not None:
            result['orderId'] = self.order_id
        if self.order_price is not None:
            result['orderPrice'] = self.order_price
        if self.order_type is not None:
            result['orderType'] = self.order_type
        if self.over_apply_id is not None:
            result['overApplyId'] = self.over_apply_id
        if self.person_refund_fee is not None:
            result['personRefundFee'] = self.person_refund_fee
        if self.person_settle_price is not None:
            result['personSettlePrice'] = self.person_settle_price
        if self.primary_id is not None:
            result['primaryId'] = self.primary_id
        if self.project_code is not None:
            result['projectCode'] = self.project_code
        if self.project_name is not None:
            result['projectName'] = self.project_name
        if self.promotion_fee is not None:
            result['promotionFee'] = self.promotion_fee
        if self.remark is not None:
            result['remark'] = self.remark
        if self.room_number is not None:
            result['roomNumber'] = self.room_number
        if self.room_price is not None:
            result['roomPrice'] = self.room_price
        if self.room_type is not None:
            result['roomType'] = self.room_type
        if self.service_fee is not None:
            result['serviceFee'] = self.service_fee
        if self.settlement_fee is not None:
            result['settlementFee'] = self.settlement_fee
        if self.settlement_grant_fee is not None:
            result['settlementGrantFee'] = self.settlement_grant_fee
        if self.settlement_time is not None:
            result['settlementTime'] = self.settlement_time
        if self.settlement_type is not None:
            result['settlementType'] = self.settlement_type
        if self.status is not None:
            result['status'] = self.status
        if self.total_nights is not None:
            result['totalNights'] = self.total_nights
        if self.traveler_id is not None:
            result['travelerId'] = self.traveler_id
        if self.traveler_job_no is not None:
            result['travelerJobNo'] = self.traveler_job_no
        if self.traveler_name is not None:
            result['travelerName'] = self.traveler_name
        if self.voucher_type is not None:
            result['voucherType'] = self.voucher_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('alipayTradeNo') is not None:
            self.alipay_trade_no = m.get('alipayTradeNo')
        if m.get('applyId') is not None:
            self.apply_id = m.get('applyId')
        if m.get('billRecordTime') is not None:
            self.bill_record_time = m.get('billRecordTime')
        if m.get('bookTime') is not None:
            self.book_time = m.get('bookTime')
        if m.get('bookerId') is not None:
            self.booker_id = m.get('bookerId')
        if m.get('bookerJobNo') is not None:
            self.booker_job_no = m.get('bookerJobNo')
        if m.get('bookerName') is not None:
            self.booker_name = m.get('bookerName')
        if m.get('capitalDirection') is not None:
            self.capital_direction = m.get('capitalDirection')
        if m.get('cascadeDepartment') is not None:
            self.cascade_department = m.get('cascadeDepartment')
        if m.get('checkInDate') is not None:
            self.check_in_date = m.get('checkInDate')
        if m.get('checkoutDate') is not None:
            self.checkout_date = m.get('checkoutDate')
        if m.get('city') is not None:
            self.city = m.get('city')
        if m.get('cityCode') is not None:
            self.city_code = m.get('cityCode')
        if m.get('corpRefundFee') is not None:
            self.corp_refund_fee = m.get('corpRefundFee')
        if m.get('corpTotalFee') is not None:
            self.corp_total_fee = m.get('corpTotalFee')
        if m.get('costCenter') is not None:
            self.cost_center = m.get('costCenter')
        if m.get('costCenterNumber') is not None:
            self.cost_center_number = m.get('costCenterNumber')
        if m.get('department') is not None:
            self.department = m.get('department')
        if m.get('departmentId') is not None:
            self.department_id = m.get('departmentId')
        if m.get('feeType') is not None:
            self.fee_type = m.get('feeType')
        if m.get('fees') is not None:
            self.fees = m.get('fees')
        if m.get('fuPointFee') is not None:
            self.fu_point_fee = m.get('fuPointFee')
        if m.get('hotelName') is not None:
            self.hotel_name = m.get('hotelName')
        if m.get('index') is not None:
            self.index = m.get('index')
        if m.get('invoiceTitle') is not None:
            self.invoice_title = m.get('invoiceTitle')
        if m.get('isNegotiation') is not None:
            self.is_negotiation = m.get('isNegotiation')
        if m.get('isShareStr') is not None:
            self.is_share_str = m.get('isShareStr')
        if m.get('nights') is not None:
            self.nights = m.get('nights')
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        if m.get('orderPrice') is not None:
            self.order_price = m.get('orderPrice')
        if m.get('orderType') is not None:
            self.order_type = m.get('orderType')
        if m.get('overApplyId') is not None:
            self.over_apply_id = m.get('overApplyId')
        if m.get('personRefundFee') is not None:
            self.person_refund_fee = m.get('personRefundFee')
        if m.get('personSettlePrice') is not None:
            self.person_settle_price = m.get('personSettlePrice')
        if m.get('primaryId') is not None:
            self.primary_id = m.get('primaryId')
        if m.get('projectCode') is not None:
            self.project_code = m.get('projectCode')
        if m.get('projectName') is not None:
            self.project_name = m.get('projectName')
        if m.get('promotionFee') is not None:
            self.promotion_fee = m.get('promotionFee')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('roomNumber') is not None:
            self.room_number = m.get('roomNumber')
        if m.get('roomPrice') is not None:
            self.room_price = m.get('roomPrice')
        if m.get('roomType') is not None:
            self.room_type = m.get('roomType')
        if m.get('serviceFee') is not None:
            self.service_fee = m.get('serviceFee')
        if m.get('settlementFee') is not None:
            self.settlement_fee = m.get('settlementFee')
        if m.get('settlementGrantFee') is not None:
            self.settlement_grant_fee = m.get('settlementGrantFee')
        if m.get('settlementTime') is not None:
            self.settlement_time = m.get('settlementTime')
        if m.get('settlementType') is not None:
            self.settlement_type = m.get('settlementType')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('totalNights') is not None:
            self.total_nights = m.get('totalNights')
        if m.get('travelerId') is not None:
            self.traveler_id = m.get('travelerId')
        if m.get('travelerJobNo') is not None:
            self.traveler_job_no = m.get('travelerJobNo')
        if m.get('travelerName') is not None:
            self.traveler_name = m.get('travelerName')
        if m.get('voucherType') is not None:
            self.voucher_type = m.get('voucherType')
        return self


class BillSettementHotelResponseBodyModule(TeaModel):
    def __init__(
        self,
        category: int = None,
        corp_id: str = None,
        data_list: List[BillSettementHotelResponseBodyModuleDataList] = None,
        period_end: str = None,
        period_start: str = None,
        total_num: int = None,
    ):
        self.category = category
        self.corp_id = corp_id
        self.data_list = data_list
        self.period_end = period_end
        self.period_start = period_start
        self.total_num = total_num

    def validate(self):
        if self.data_list:
            for k in self.data_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category is not None:
            result['category'] = self.category
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        result['dataList'] = []
        if self.data_list is not None:
            for k in self.data_list:
                result['dataList'].append(k.to_map() if k else None)
        if self.period_end is not None:
            result['periodEnd'] = self.period_end
        if self.period_start is not None:
            result['periodStart'] = self.period_start
        if self.total_num is not None:
            result['totalNum'] = self.total_num
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        self.data_list = []
        if m.get('dataList') is not None:
            for k in m.get('dataList'):
                temp_model = BillSettementHotelResponseBodyModuleDataList()
                self.data_list.append(temp_model.from_map(k))
        if m.get('periodEnd') is not None:
            self.period_end = m.get('periodEnd')
        if m.get('periodStart') is not None:
            self.period_start = m.get('periodStart')
        if m.get('totalNum') is not None:
            self.total_num = m.get('totalNum')
        return self


class BillSettementHotelResponseBody(TeaModel):
    def __init__(
        self,
        module: BillSettementHotelResponseBodyModule = None,
        result_code: int = None,
        result_msg: str = None,
        success: bool = None,
    ):
        self.module = module
        self.result_code = result_code
        self.result_msg = result_msg
        self.success = success

    def validate(self):
        if self.module:
            self.module.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.module is not None:
            result['module'] = self.module.to_map()
        if self.result_code is not None:
            result['resultCode'] = self.result_code
        if self.result_msg is not None:
            result['resultMsg'] = self.result_msg
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('module') is not None:
            temp_model = BillSettementHotelResponseBodyModule()
            self.module = temp_model.from_map(m['module'])
        if m.get('resultCode') is not None:
            self.result_code = m.get('resultCode')
        if m.get('resultMsg') is not None:
            self.result_msg = m.get('resultMsg')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class BillSettementHotelResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BillSettementHotelResponseBody = None,
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
            temp_model = BillSettementHotelResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetFlightExceedApplyHeaders(TeaModel):
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


class GetFlightExceedApplyRequest(TeaModel):
    def __init__(
        self,
        apply_id: str = None,
        corp_id: str = None,
    ):
        self.apply_id = apply_id
        self.corp_id = corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.apply_id is not None:
            result['applyId'] = self.apply_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('applyId') is not None:
            self.apply_id = m.get('applyId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        return self


class GetFlightExceedApplyResponseBodyApplyIntentionInfoDO(TeaModel):
    def __init__(
        self,
        arr_city: str = None,
        arr_city_name: str = None,
        arr_time: str = None,
        cabin: str = None,
        cabin_class: int = None,
        cabin_class_str: str = None,
        dep_city: str = None,
        dep_city_name: str = None,
        dep_time: str = None,
        discount: float = None,
        flight_no: str = None,
        price: int = None,
        type: int = None,
    ):
        self.arr_city = arr_city
        self.arr_city_name = arr_city_name
        self.arr_time = arr_time
        self.cabin = cabin
        self.cabin_class = cabin_class
        self.cabin_class_str = cabin_class_str
        self.dep_city = dep_city
        self.dep_city_name = dep_city_name
        self.dep_time = dep_time
        self.discount = discount
        self.flight_no = flight_no
        self.price = price
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.arr_city is not None:
            result['arrCity'] = self.arr_city
        if self.arr_city_name is not None:
            result['arrCityName'] = self.arr_city_name
        if self.arr_time is not None:
            result['arrTime'] = self.arr_time
        if self.cabin is not None:
            result['cabin'] = self.cabin
        if self.cabin_class is not None:
            result['cabinClass'] = self.cabin_class
        if self.cabin_class_str is not None:
            result['cabinClassStr'] = self.cabin_class_str
        if self.dep_city is not None:
            result['depCity'] = self.dep_city
        if self.dep_city_name is not None:
            result['depCityName'] = self.dep_city_name
        if self.dep_time is not None:
            result['depTime'] = self.dep_time
        if self.discount is not None:
            result['discount'] = self.discount
        if self.flight_no is not None:
            result['flightNo'] = self.flight_no
        if self.price is not None:
            result['price'] = self.price
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('arrCity') is not None:
            self.arr_city = m.get('arrCity')
        if m.get('arrCityName') is not None:
            self.arr_city_name = m.get('arrCityName')
        if m.get('arrTime') is not None:
            self.arr_time = m.get('arrTime')
        if m.get('cabin') is not None:
            self.cabin = m.get('cabin')
        if m.get('cabinClass') is not None:
            self.cabin_class = m.get('cabinClass')
        if m.get('cabinClassStr') is not None:
            self.cabin_class_str = m.get('cabinClassStr')
        if m.get('depCity') is not None:
            self.dep_city = m.get('depCity')
        if m.get('depCityName') is not None:
            self.dep_city_name = m.get('depCityName')
        if m.get('depTime') is not None:
            self.dep_time = m.get('depTime')
        if m.get('discount') is not None:
            self.discount = m.get('discount')
        if m.get('flightNo') is not None:
            self.flight_no = m.get('flightNo')
        if m.get('price') is not None:
            self.price = m.get('price')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GetFlightExceedApplyResponseBody(TeaModel):
    def __init__(
        self,
        apply_id: int = None,
        apply_intention_info_do: GetFlightExceedApplyResponseBodyApplyIntentionInfoDO = None,
        btrip_cause: str = None,
        corp_id: str = None,
        exceed_reason: str = None,
        exceed_type: int = None,
        origin_standard: str = None,
        status: int = None,
        submit_time: str = None,
        thirdpart_apply_id: str = None,
        user_id: str = None,
    ):
        self.apply_id = apply_id
        self.apply_intention_info_do = apply_intention_info_do
        self.btrip_cause = btrip_cause
        self.corp_id = corp_id
        self.exceed_reason = exceed_reason
        self.exceed_type = exceed_type
        self.origin_standard = origin_standard
        self.status = status
        self.submit_time = submit_time
        self.thirdpart_apply_id = thirdpart_apply_id
        self.user_id = user_id

    def validate(self):
        if self.apply_intention_info_do:
            self.apply_intention_info_do.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.apply_id is not None:
            result['applyId'] = self.apply_id
        if self.apply_intention_info_do is not None:
            result['applyIntentionInfoDO'] = self.apply_intention_info_do.to_map()
        if self.btrip_cause is not None:
            result['btripCause'] = self.btrip_cause
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.exceed_reason is not None:
            result['exceedReason'] = self.exceed_reason
        if self.exceed_type is not None:
            result['exceedType'] = self.exceed_type
        if self.origin_standard is not None:
            result['originStandard'] = self.origin_standard
        if self.status is not None:
            result['status'] = self.status
        if self.submit_time is not None:
            result['submitTime'] = self.submit_time
        if self.thirdpart_apply_id is not None:
            result['thirdpartApplyId'] = self.thirdpart_apply_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('applyId') is not None:
            self.apply_id = m.get('applyId')
        if m.get('applyIntentionInfoDO') is not None:
            temp_model = GetFlightExceedApplyResponseBodyApplyIntentionInfoDO()
            self.apply_intention_info_do = temp_model.from_map(m['applyIntentionInfoDO'])
        if m.get('btripCause') is not None:
            self.btrip_cause = m.get('btripCause')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('exceedReason') is not None:
            self.exceed_reason = m.get('exceedReason')
        if m.get('exceedType') is not None:
            self.exceed_type = m.get('exceedType')
        if m.get('originStandard') is not None:
            self.origin_standard = m.get('originStandard')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('submitTime') is not None:
            self.submit_time = m.get('submitTime')
        if m.get('thirdpartApplyId') is not None:
            self.thirdpart_apply_id = m.get('thirdpartApplyId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetFlightExceedApplyResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetFlightExceedApplyResponseBody = None,
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
            temp_model = GetFlightExceedApplyResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetHotelExceedApplyHeaders(TeaModel):
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


class GetHotelExceedApplyRequest(TeaModel):
    def __init__(
        self,
        apply_id: str = None,
        corp_id: str = None,
    ):
        self.apply_id = apply_id
        self.corp_id = corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.apply_id is not None:
            result['applyId'] = self.apply_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('applyId') is not None:
            self.apply_id = m.get('applyId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        return self


class GetHotelExceedApplyResponseBodyApplyIntentionInfoDO(TeaModel):
    def __init__(
        self,
        check_in: str = None,
        check_out: str = None,
        city_code: str = None,
        city_name: str = None,
        price: int = None,
        together: bool = None,
        type: int = None,
    ):
        self.check_in = check_in
        self.check_out = check_out
        self.city_code = city_code
        self.city_name = city_name
        self.price = price
        self.together = together
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.check_in is not None:
            result['checkIn'] = self.check_in
        if self.check_out is not None:
            result['checkOut'] = self.check_out
        if self.city_code is not None:
            result['cityCode'] = self.city_code
        if self.city_name is not None:
            result['cityName'] = self.city_name
        if self.price is not None:
            result['price'] = self.price
        if self.together is not None:
            result['together'] = self.together
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('checkIn') is not None:
            self.check_in = m.get('checkIn')
        if m.get('checkOut') is not None:
            self.check_out = m.get('checkOut')
        if m.get('cityCode') is not None:
            self.city_code = m.get('cityCode')
        if m.get('cityName') is not None:
            self.city_name = m.get('cityName')
        if m.get('price') is not None:
            self.price = m.get('price')
        if m.get('together') is not None:
            self.together = m.get('together')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GetHotelExceedApplyResponseBody(TeaModel):
    def __init__(
        self,
        apply_id: int = None,
        apply_intention_info_do: GetHotelExceedApplyResponseBodyApplyIntentionInfoDO = None,
        btrip_cause: str = None,
        corp_id: str = None,
        exceed_reason: str = None,
        exceed_type: int = None,
        origin_standard: str = None,
        status: int = None,
        submit_time: str = None,
        thirdpart_apply_id: str = None,
        user_id: str = None,
    ):
        self.apply_id = apply_id
        self.apply_intention_info_do = apply_intention_info_do
        self.btrip_cause = btrip_cause
        self.corp_id = corp_id
        self.exceed_reason = exceed_reason
        self.exceed_type = exceed_type
        self.origin_standard = origin_standard
        self.status = status
        self.submit_time = submit_time
        self.thirdpart_apply_id = thirdpart_apply_id
        self.user_id = user_id

    def validate(self):
        if self.apply_intention_info_do:
            self.apply_intention_info_do.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.apply_id is not None:
            result['applyId'] = self.apply_id
        if self.apply_intention_info_do is not None:
            result['applyIntentionInfoDO'] = self.apply_intention_info_do.to_map()
        if self.btrip_cause is not None:
            result['btripCause'] = self.btrip_cause
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.exceed_reason is not None:
            result['exceedReason'] = self.exceed_reason
        if self.exceed_type is not None:
            result['exceedType'] = self.exceed_type
        if self.origin_standard is not None:
            result['originStandard'] = self.origin_standard
        if self.status is not None:
            result['status'] = self.status
        if self.submit_time is not None:
            result['submitTime'] = self.submit_time
        if self.thirdpart_apply_id is not None:
            result['thirdpartApplyId'] = self.thirdpart_apply_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('applyId') is not None:
            self.apply_id = m.get('applyId')
        if m.get('applyIntentionInfoDO') is not None:
            temp_model = GetHotelExceedApplyResponseBodyApplyIntentionInfoDO()
            self.apply_intention_info_do = temp_model.from_map(m['applyIntentionInfoDO'])
        if m.get('btripCause') is not None:
            self.btrip_cause = m.get('btripCause')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('exceedReason') is not None:
            self.exceed_reason = m.get('exceedReason')
        if m.get('exceedType') is not None:
            self.exceed_type = m.get('exceedType')
        if m.get('originStandard') is not None:
            self.origin_standard = m.get('originStandard')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('submitTime') is not None:
            self.submit_time = m.get('submitTime')
        if m.get('thirdpartApplyId') is not None:
            self.thirdpart_apply_id = m.get('thirdpartApplyId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetHotelExceedApplyResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetHotelExceedApplyResponseBody = None,
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
            temp_model = GetHotelExceedApplyResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetTrainExceedApplyHeaders(TeaModel):
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


class GetTrainExceedApplyRequest(TeaModel):
    def __init__(
        self,
        apply_id: str = None,
        corp_id: str = None,
    ):
        self.apply_id = apply_id
        self.corp_id = corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.apply_id is not None:
            result['applyId'] = self.apply_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('applyId') is not None:
            self.apply_id = m.get('applyId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        return self


class GetTrainExceedApplyResponseBodyApplyIntentionInfoDO(TeaModel):
    def __init__(
        self,
        arr_city: str = None,
        arr_city_name: str = None,
        arr_station: str = None,
        arr_time: str = None,
        dep_city: str = None,
        dep_city_name: str = None,
        dep_station: str = None,
        dep_time: str = None,
        price: int = None,
        seat_name: str = None,
        train_no: str = None,
        train_type_desc: str = None,
    ):
        self.arr_city = arr_city
        self.arr_city_name = arr_city_name
        self.arr_station = arr_station
        self.arr_time = arr_time
        self.dep_city = dep_city
        self.dep_city_name = dep_city_name
        self.dep_station = dep_station
        self.dep_time = dep_time
        self.price = price
        self.seat_name = seat_name
        self.train_no = train_no
        self.train_type_desc = train_type_desc

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.arr_city is not None:
            result['arrCity'] = self.arr_city
        if self.arr_city_name is not None:
            result['arrCityName'] = self.arr_city_name
        if self.arr_station is not None:
            result['arrStation'] = self.arr_station
        if self.arr_time is not None:
            result['arrTime'] = self.arr_time
        if self.dep_city is not None:
            result['depCity'] = self.dep_city
        if self.dep_city_name is not None:
            result['depCityName'] = self.dep_city_name
        if self.dep_station is not None:
            result['depStation'] = self.dep_station
        if self.dep_time is not None:
            result['depTime'] = self.dep_time
        if self.price is not None:
            result['price'] = self.price
        if self.seat_name is not None:
            result['seatName'] = self.seat_name
        if self.train_no is not None:
            result['trainNo'] = self.train_no
        if self.train_type_desc is not None:
            result['trainTypeDesc'] = self.train_type_desc
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('arrCity') is not None:
            self.arr_city = m.get('arrCity')
        if m.get('arrCityName') is not None:
            self.arr_city_name = m.get('arrCityName')
        if m.get('arrStation') is not None:
            self.arr_station = m.get('arrStation')
        if m.get('arrTime') is not None:
            self.arr_time = m.get('arrTime')
        if m.get('depCity') is not None:
            self.dep_city = m.get('depCity')
        if m.get('depCityName') is not None:
            self.dep_city_name = m.get('depCityName')
        if m.get('depStation') is not None:
            self.dep_station = m.get('depStation')
        if m.get('depTime') is not None:
            self.dep_time = m.get('depTime')
        if m.get('price') is not None:
            self.price = m.get('price')
        if m.get('seatName') is not None:
            self.seat_name = m.get('seatName')
        if m.get('trainNo') is not None:
            self.train_no = m.get('trainNo')
        if m.get('trainTypeDesc') is not None:
            self.train_type_desc = m.get('trainTypeDesc')
        return self


class GetTrainExceedApplyResponseBody(TeaModel):
    def __init__(
        self,
        apply_id: int = None,
        apply_intention_info_do: GetTrainExceedApplyResponseBodyApplyIntentionInfoDO = None,
        btrip_cause: str = None,
        corp_id: str = None,
        exceed_reason: str = None,
        exceed_type: int = None,
        origin_standard: str = None,
        status: int = None,
        submit_time: str = None,
        thirdpart_apply_id: str = None,
        user_id: str = None,
    ):
        self.apply_id = apply_id
        self.apply_intention_info_do = apply_intention_info_do
        self.btrip_cause = btrip_cause
        self.corp_id = corp_id
        self.exceed_reason = exceed_reason
        self.exceed_type = exceed_type
        self.origin_standard = origin_standard
        self.status = status
        self.submit_time = submit_time
        self.thirdpart_apply_id = thirdpart_apply_id
        self.user_id = user_id

    def validate(self):
        if self.apply_intention_info_do:
            self.apply_intention_info_do.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.apply_id is not None:
            result['applyId'] = self.apply_id
        if self.apply_intention_info_do is not None:
            result['applyIntentionInfoDO'] = self.apply_intention_info_do.to_map()
        if self.btrip_cause is not None:
            result['btripCause'] = self.btrip_cause
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.exceed_reason is not None:
            result['exceedReason'] = self.exceed_reason
        if self.exceed_type is not None:
            result['exceedType'] = self.exceed_type
        if self.origin_standard is not None:
            result['originStandard'] = self.origin_standard
        if self.status is not None:
            result['status'] = self.status
        if self.submit_time is not None:
            result['submitTime'] = self.submit_time
        if self.thirdpart_apply_id is not None:
            result['thirdpartApplyId'] = self.thirdpart_apply_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('applyId') is not None:
            self.apply_id = m.get('applyId')
        if m.get('applyIntentionInfoDO') is not None:
            temp_model = GetTrainExceedApplyResponseBodyApplyIntentionInfoDO()
            self.apply_intention_info_do = temp_model.from_map(m['applyIntentionInfoDO'])
        if m.get('btripCause') is not None:
            self.btrip_cause = m.get('btripCause')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('exceedReason') is not None:
            self.exceed_reason = m.get('exceedReason')
        if m.get('exceedType') is not None:
            self.exceed_type = m.get('exceedType')
        if m.get('originStandard') is not None:
            self.origin_standard = m.get('originStandard')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('submitTime') is not None:
            self.submit_time = m.get('submitTime')
        if m.get('thirdpartApplyId') is not None:
            self.thirdpart_apply_id = m.get('thirdpartApplyId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetTrainExceedApplyResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetTrainExceedApplyResponseBody = None,
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
            temp_model = GetTrainExceedApplyResponseBody()
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
        self.corp_id = corp_id
        self.created_end_at = created_end_at
        self.created_start_at = created_start_at
        self.page_number = page_number
        self.page_size = page_size
        self.third_part_apply_id = third_part_apply_id
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
        self.note = note
        self.operate_time = operate_time
        self.order = order
        self.status = status
        self.status_desc = status_desc
        self.user_id = user_id
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
        self.arr_city = arr_city
        self.arr_city_code = arr_city_code
        self.arr_date = arr_date
        self.cost_center_id = cost_center_id
        self.cost_center_name = cost_center_name
        self.dep_city = dep_city
        self.dep_city_code = dep_city_code
        self.dep_date = dep_date
        self.invoice_id = invoice_id
        self.invoice_name = invoice_name
        self.itinerary_id = itinerary_id
        self.project_code = project_code
        self.project_title = project_title
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
        self.approver_list = approver_list
        self.depart_id = depart_id
        self.depart_name = depart_name
        self.gmt_create = gmt_create
        self.gmt_modified = gmt_modified
        self.itinerary_list = itinerary_list
        self.status = status
        self.status_desc = status_desc
        self.third_part_apply_id = third_part_apply_id
        self.trip_cause = trip_cause
        self.trip_title = trip_title
        self.user_id = user_id
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
        self.apply_list = apply_list
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
        status_code: int = None,
        body: QueryCityCarApplyResponseBody = None,
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
            temp_model = QueryCityCarApplyResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryUnionOrderHeaders(TeaModel):
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


class QueryUnionOrderRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        third_part_apply_id: str = None,
        union_no: str = None,
    ):
        self.corp_id = corp_id
        self.third_part_apply_id = third_part_apply_id
        self.union_no = union_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.third_part_apply_id is not None:
            result['thirdPartApplyId'] = self.third_part_apply_id
        if self.union_no is not None:
            result['unionNo'] = self.union_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('thirdPartApplyId') is not None:
            self.third_part_apply_id = m.get('thirdPartApplyId')
        if m.get('unionNo') is not None:
            self.union_no = m.get('unionNo')
        return self


class QueryUnionOrderResponseBodyFlightList(TeaModel):
    def __init__(
        self,
        flight_order_id: int = None,
        flight_order_status: int = None,
    ):
        self.flight_order_id = flight_order_id
        self.flight_order_status = flight_order_status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.flight_order_id is not None:
            result['flightOrderId'] = self.flight_order_id
        if self.flight_order_status is not None:
            result['flightOrderStatus'] = self.flight_order_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('flightOrderId') is not None:
            self.flight_order_id = m.get('flightOrderId')
        if m.get('flightOrderStatus') is not None:
            self.flight_order_status = m.get('flightOrderStatus')
        return self


class QueryUnionOrderResponseBodyHotelList(TeaModel):
    def __init__(
        self,
        hotel_order_id: int = None,
        hotel_order_status: int = None,
    ):
        self.hotel_order_id = hotel_order_id
        self.hotel_order_status = hotel_order_status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.hotel_order_id is not None:
            result['hotelOrderId'] = self.hotel_order_id
        if self.hotel_order_status is not None:
            result['hotelOrderStatus'] = self.hotel_order_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hotelOrderId') is not None:
            self.hotel_order_id = m.get('hotelOrderId')
        if m.get('hotelOrderStatus') is not None:
            self.hotel_order_status = m.get('hotelOrderStatus')
        return self


class QueryUnionOrderResponseBodyTrainList(TeaModel):
    def __init__(
        self,
        train_order_id: int = None,
        train_orderstatus: int = None,
    ):
        self.train_order_id = train_order_id
        self.train_orderstatus = train_orderstatus

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.train_order_id is not None:
            result['trainOrderId'] = self.train_order_id
        if self.train_orderstatus is not None:
            result['trainOrderstatus'] = self.train_orderstatus
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('trainOrderId') is not None:
            self.train_order_id = m.get('trainOrderId')
        if m.get('trainOrderstatus') is not None:
            self.train_orderstatus = m.get('trainOrderstatus')
        return self


class QueryUnionOrderResponseBodyVehicleList(TeaModel):
    def __init__(
        self,
        vehicle_order_id: int = None,
        vehicle_order_status: int = None,
    ):
        self.vehicle_order_id = vehicle_order_id
        self.vehicle_order_status = vehicle_order_status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.vehicle_order_id is not None:
            result['vehicleOrderId'] = self.vehicle_order_id
        if self.vehicle_order_status is not None:
            result['vehicleOrderStatus'] = self.vehicle_order_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('vehicleOrderId') is not None:
            self.vehicle_order_id = m.get('vehicleOrderId')
        if m.get('vehicleOrderStatus') is not None:
            self.vehicle_order_status = m.get('vehicleOrderStatus')
        return self


class QueryUnionOrderResponseBody(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        flight_list: List[QueryUnionOrderResponseBodyFlightList] = None,
        hotel_list: List[QueryUnionOrderResponseBodyHotelList] = None,
        train_list: List[QueryUnionOrderResponseBodyTrainList] = None,
        vehicle_list: List[QueryUnionOrderResponseBodyVehicleList] = None,
    ):
        self.corp_id = corp_id
        self.flight_list = flight_list
        self.hotel_list = hotel_list
        self.train_list = train_list
        self.vehicle_list = vehicle_list

    def validate(self):
        if self.flight_list:
            for k in self.flight_list:
                if k:
                    k.validate()
        if self.hotel_list:
            for k in self.hotel_list:
                if k:
                    k.validate()
        if self.train_list:
            for k in self.train_list:
                if k:
                    k.validate()
        if self.vehicle_list:
            for k in self.vehicle_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        result['flightList'] = []
        if self.flight_list is not None:
            for k in self.flight_list:
                result['flightList'].append(k.to_map() if k else None)
        result['hotelList'] = []
        if self.hotel_list is not None:
            for k in self.hotel_list:
                result['hotelList'].append(k.to_map() if k else None)
        result['trainList'] = []
        if self.train_list is not None:
            for k in self.train_list:
                result['trainList'].append(k.to_map() if k else None)
        result['vehicleList'] = []
        if self.vehicle_list is not None:
            for k in self.vehicle_list:
                result['vehicleList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        self.flight_list = []
        if m.get('flightList') is not None:
            for k in m.get('flightList'):
                temp_model = QueryUnionOrderResponseBodyFlightList()
                self.flight_list.append(temp_model.from_map(k))
        self.hotel_list = []
        if m.get('hotelList') is not None:
            for k in m.get('hotelList'):
                temp_model = QueryUnionOrderResponseBodyHotelList()
                self.hotel_list.append(temp_model.from_map(k))
        self.train_list = []
        if m.get('trainList') is not None:
            for k in m.get('trainList'):
                temp_model = QueryUnionOrderResponseBodyTrainList()
                self.train_list.append(temp_model.from_map(k))
        self.vehicle_list = []
        if m.get('vehicleList') is not None:
            for k in m.get('vehicleList'):
                temp_model = QueryUnionOrderResponseBodyVehicleList()
                self.vehicle_list.append(temp_model.from_map(k))
        return self


class QueryUnionOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryUnionOrderResponseBody = None,
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
            temp_model = QueryUnionOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SyncExceedApplyHeaders(TeaModel):
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


class SyncExceedApplyRequest(TeaModel):
    def __init__(
        self,
        apply_id: str = None,
        corp_id: str = None,
        remark: str = None,
        status: int = None,
        thirdparty_flow_id: str = None,
        user_id: str = None,
    ):
        self.apply_id = apply_id
        self.corp_id = corp_id
        self.remark = remark
        self.status = status
        self.thirdparty_flow_id = thirdparty_flow_id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.apply_id is not None:
            result['applyId'] = self.apply_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.remark is not None:
            result['remark'] = self.remark
        if self.status is not None:
            result['status'] = self.status
        if self.thirdparty_flow_id is not None:
            result['thirdpartyFlowId'] = self.thirdparty_flow_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('applyId') is not None:
            self.apply_id = m.get('applyId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('thirdpartyFlowId') is not None:
            self.thirdparty_flow_id = m.get('thirdpartyFlowId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SyncExceedApplyResponseBody(TeaModel):
    def __init__(
        self,
        module: bool = None,
    ):
        self.module = module

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.module is not None:
            result['module'] = self.module
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('module') is not None:
            self.module = m.get('module')
        return self


class SyncExceedApplyResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SyncExceedApplyResponseBody = None,
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
            temp_model = SyncExceedApplyResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


