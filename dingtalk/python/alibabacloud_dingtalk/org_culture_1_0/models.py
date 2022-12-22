# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class AssignOrgHoldingToEmpHoldingBatchHeaders(TeaModel):
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


class AssignOrgHoldingToEmpHoldingBatchRequestTargetUserList(TeaModel):
    def __init__(
        self,
        out_id: str = None,
        target_user_id: str = None,
    ):
        # 积分交易单号，长度1-32。
        # 
        self.out_id = out_id
        # 操作目标对象userId
        self.target_user_id = target_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.out_id is not None:
            result['outId'] = self.out_id
        if self.target_user_id is not None:
            result['targetUserId'] = self.target_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('outId') is not None:
            self.out_id = m.get('outId')
        if m.get('targetUserId') is not None:
            self.target_user_id = m.get('targetUserId')
        return self


class AssignOrgHoldingToEmpHoldingBatchRequest(TeaModel):
    def __init__(
        self,
        remark: str = None,
        send_org_culture_inform: bool = None,
        single_amount: int = None,
        source_usage: str = None,
        target_usage: str = None,
        target_user_list: List[AssignOrgHoldingToEmpHoldingBatchRequestTargetUserList] = None,
    ):
        # 备注信息 长度小于40
        self.remark = remark
        # 是否发送组织文化通知
        self.send_org_culture_inform = send_org_culture_inform
        # 发放积分或额度数量 1～100000
        self.single_amount = single_amount
        # 发放人sourceUsage  发放人与接受人usage应一一对应
        # 发放积分sourceUsage：OPEN_ORG_POINT_PERSONAL_ASSIGN 对应的targetUsage为OPEN_EMP_POINT_PERSONAL_RECEIVE；
        # 发额度sourceUsage：OPEN_ORG_POINT_HOLDING_ASSIGN 对应的 targetUsage为OPEN_EMP_POINT_HOLDING_RECEIVE；
        # 行为规则发积分 sourceUsage：OPEN_ACTION_RULE_PERSONAL_ASSIGN 对应的 targetUsage为OPEN_ACTION_RULE_PERSONAL_RECEIVE
        self.source_usage = source_usage
        # 接受人targetUsage  发放人与接受人usage应一一对应
        self.target_usage = target_usage
        # 发放目标用户
        self.target_user_list = target_user_list

    def validate(self):
        if self.target_user_list:
            for k in self.target_user_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.remark is not None:
            result['remark'] = self.remark
        if self.send_org_culture_inform is not None:
            result['sendOrgCultureInform'] = self.send_org_culture_inform
        if self.single_amount is not None:
            result['singleAmount'] = self.single_amount
        if self.source_usage is not None:
            result['sourceUsage'] = self.source_usage
        if self.target_usage is not None:
            result['targetUsage'] = self.target_usage
        result['targetUserList'] = []
        if self.target_user_list is not None:
            for k in self.target_user_list:
                result['targetUserList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('sendOrgCultureInform') is not None:
            self.send_org_culture_inform = m.get('sendOrgCultureInform')
        if m.get('singleAmount') is not None:
            self.single_amount = m.get('singleAmount')
        if m.get('sourceUsage') is not None:
            self.source_usage = m.get('sourceUsage')
        if m.get('targetUsage') is not None:
            self.target_usage = m.get('targetUsage')
        self.target_user_list = []
        if m.get('targetUserList') is not None:
            for k in m.get('targetUserList'):
                temp_model = AssignOrgHoldingToEmpHoldingBatchRequestTargetUserList()
                self.target_user_list.append(temp_model.from_map(k))
        return self


class AssignOrgHoldingToEmpHoldingBatchResponseBodyResultOpenPointInvokeResultDTOS(TeaModel):
    def __init__(
        self,
        code: str = None,
        invoke_status: str = None,
        msg: str = None,
        out_id: str = None,
        user_id: str = None,
    ):
        # 错误码
        self.code = code
        # 状态SUCCESS：成功。 FAIL：失败 UNKNOWN:结果未知
        self.invoke_status = invoke_status
        # 错误信息
        self.msg = msg
        # 积分交易单号
        # 
        self.out_id = out_id
        # 发放用户userId
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.invoke_status is not None:
            result['invokeStatus'] = self.invoke_status
        if self.msg is not None:
            result['msg'] = self.msg
        if self.out_id is not None:
            result['outId'] = self.out_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('invokeStatus') is not None:
            self.invoke_status = m.get('invokeStatus')
        if m.get('msg') is not None:
            self.msg = m.get('msg')
        if m.get('outId') is not None:
            self.out_id = m.get('outId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class AssignOrgHoldingToEmpHoldingBatchResponseBodyResult(TeaModel):
    def __init__(
        self,
        open_point_invoke_result_dtos: List[AssignOrgHoldingToEmpHoldingBatchResponseBodyResultOpenPointInvokeResultDTOS] = None,
    ):
        # 每个人发放的结果
        self.open_point_invoke_result_dtos = open_point_invoke_result_dtos

    def validate(self):
        if self.open_point_invoke_result_dtos:
            for k in self.open_point_invoke_result_dtos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['openPointInvokeResultDTOS'] = []
        if self.open_point_invoke_result_dtos is not None:
            for k in self.open_point_invoke_result_dtos:
                result['openPointInvokeResultDTOS'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.open_point_invoke_result_dtos = []
        if m.get('openPointInvokeResultDTOS') is not None:
            for k in m.get('openPointInvokeResultDTOS'):
                temp_model = AssignOrgHoldingToEmpHoldingBatchResponseBodyResultOpenPointInvokeResultDTOS()
                self.open_point_invoke_result_dtos.append(temp_model.from_map(k))
        return self


class AssignOrgHoldingToEmpHoldingBatchResponseBody(TeaModel):
    def __init__(
        self,
        result: AssignOrgHoldingToEmpHoldingBatchResponseBodyResult = None,
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
            temp_model = AssignOrgHoldingToEmpHoldingBatchResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class AssignOrgHoldingToEmpHoldingBatchResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: AssignOrgHoldingToEmpHoldingBatchResponseBody = None,
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
            temp_model = AssignOrgHoldingToEmpHoldingBatchResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ConsumeUserPointsHeaders(TeaModel):
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


class ConsumeUserPointsRequest(TeaModel):
    def __init__(
        self,
        amount: int = None,
        out_id: str = None,
        remark: str = None,
        usage: str = None,
    ):
        # 扣减积分数量，1～1000000
        self.amount = amount
        # 幂等外部ID，最大长度32个字符
        self.out_id = out_id
        # 备注，最长32个字符
        self.remark = remark
        # 用途，可用值：OPEN_EMP_POINT_CONSUME_DEFAULT-默认扣减，OPEN_EMP_POINT_PUNISH_CONSUME-惩罚扣减；默认为: OPEN_EMP_POINT_CONSUME_DEFAULT
        self.usage = usage

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.out_id is not None:
            result['outId'] = self.out_id
        if self.remark is not None:
            result['remark'] = self.remark
        if self.usage is not None:
            result['usage'] = self.usage
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('outId') is not None:
            self.out_id = m.get('outId')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('usage') is not None:
            self.usage = m.get('usage')
        return self


class ConsumeUserPointsResponseBodyResult(TeaModel):
    def __init__(
        self,
        amount: int = None,
    ):
        # 扣减后剩余积分数量
        self.amount = amount

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        return self


class ConsumeUserPointsResponseBody(TeaModel):
    def __init__(
        self,
        result: ConsumeUserPointsResponseBodyResult = None,
        success: bool = None,
    ):
        # 响应数据
        self.result = result
        # 请求响应状态
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
            temp_model = ConsumeUserPointsResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ConsumeUserPointsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ConsumeUserPointsResponseBody = None,
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
            temp_model = ConsumeUserPointsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeductionPointBatchHeaders(TeaModel):
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


class DeductionPointBatchRequestTargetUserList(TeaModel):
    def __init__(
        self,
        out_id: str = None,
        target_user_id: str = None,
    ):
        # 积分交易单号
        self.out_id = out_id
        # 扣减目标用户userId
        self.target_user_id = target_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.out_id is not None:
            result['outId'] = self.out_id
        if self.target_user_id is not None:
            result['targetUserId'] = self.target_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('outId') is not None:
            self.out_id = m.get('outId')
        if m.get('targetUserId') is not None:
            self.target_user_id = m.get('targetUserId')
        return self


class DeductionPointBatchRequest(TeaModel):
    def __init__(
        self,
        deduction_amount: int = None,
        remark: str = None,
        send_org_culture_inform: bool = None,
        target_user_list: List[DeductionPointBatchRequestTargetUserList] = None,
        user_id: str = None,
    ):
        # 扣减数量 范围：1—100000
        self.deduction_amount = deduction_amount
        # 扣减积分原因
        self.remark = remark
        # 是否发送组织文化通知
        self.send_org_culture_inform = send_org_culture_inform
        # 批量扣减积分用户
        self.target_user_list = target_user_list
        # 操作人userId
        self.user_id = user_id

    def validate(self):
        if self.target_user_list:
            for k in self.target_user_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.deduction_amount is not None:
            result['deductionAmount'] = self.deduction_amount
        if self.remark is not None:
            result['remark'] = self.remark
        if self.send_org_culture_inform is not None:
            result['sendOrgCultureInform'] = self.send_org_culture_inform
        result['targetUserList'] = []
        if self.target_user_list is not None:
            for k in self.target_user_list:
                result['targetUserList'].append(k.to_map() if k else None)
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deductionAmount') is not None:
            self.deduction_amount = m.get('deductionAmount')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('sendOrgCultureInform') is not None:
            self.send_org_culture_inform = m.get('sendOrgCultureInform')
        self.target_user_list = []
        if m.get('targetUserList') is not None:
            for k in m.get('targetUserList'):
                temp_model = DeductionPointBatchRequestTargetUserList()
                self.target_user_list.append(temp_model.from_map(k))
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class DeductionPointBatchResponseBodyResultOpenPointInvokeResultDTOS(TeaModel):
    def __init__(
        self,
        code: str = None,
        invoke_status: str = None,
        msg: str = None,
        out_id: str = None,
        user_id: str = None,
    ):
        # 错误码
        self.code = code
        # 状态 success：成功。 Fail：失败 UNKNOWN:结果未知
        self.invoke_status = invoke_status
        # 错误信息
        self.msg = msg
        # 积分交易单号
        self.out_id = out_id
        # 扣减用户userId
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.invoke_status is not None:
            result['invokeStatus'] = self.invoke_status
        if self.msg is not None:
            result['msg'] = self.msg
        if self.out_id is not None:
            result['outId'] = self.out_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('invokeStatus') is not None:
            self.invoke_status = m.get('invokeStatus')
        if m.get('msg') is not None:
            self.msg = m.get('msg')
        if m.get('outId') is not None:
            self.out_id = m.get('outId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class DeductionPointBatchResponseBodyResult(TeaModel):
    def __init__(
        self,
        open_point_invoke_result_dtos: List[DeductionPointBatchResponseBodyResultOpenPointInvokeResultDTOS] = None,
    ):
        # 每个人发放的结果
        self.open_point_invoke_result_dtos = open_point_invoke_result_dtos

    def validate(self):
        if self.open_point_invoke_result_dtos:
            for k in self.open_point_invoke_result_dtos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['openPointInvokeResultDTOS'] = []
        if self.open_point_invoke_result_dtos is not None:
            for k in self.open_point_invoke_result_dtos:
                result['openPointInvokeResultDTOS'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.open_point_invoke_result_dtos = []
        if m.get('openPointInvokeResultDTOS') is not None:
            for k in m.get('openPointInvokeResultDTOS'):
                temp_model = DeductionPointBatchResponseBodyResultOpenPointInvokeResultDTOS()
                self.open_point_invoke_result_dtos.append(temp_model.from_map(k))
        return self


class DeductionPointBatchResponseBody(TeaModel):
    def __init__(
        self,
        result: DeductionPointBatchResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        # 调用是否成功
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
            temp_model = DeductionPointBatchResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class DeductionPointBatchResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DeductionPointBatchResponseBody = None,
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
            temp_model = DeductionPointBatchResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ExportPointOpenHeaders(TeaModel):
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


class ExportPointOpenRequest(TeaModel):
    def __init__(
        self,
        export_date: str = None,
        export_type: int = None,
        user_id: str = None,
    ):
        # exportType为1时不需要传此参数，目前仅exportType=3时必须传入此参数,必须为七日内某一天且不能选择当日，格式yyyyMmdd。
        self.export_date = export_date
        # 导出类型 1为七日内明细，3为七日内某一天榜单，且都不包含当日
        self.export_type = export_type
        # 操作人userId 必须为管理员
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.export_date is not None:
            result['exportDate'] = self.export_date
        if self.export_type is not None:
            result['exportType'] = self.export_type
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('exportDate') is not None:
            self.export_date = m.get('exportDate')
        if m.get('exportType') is not None:
            self.export_type = m.get('exportType')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ExportPointOpenResponseBody(TeaModel):
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


class ExportPointOpenResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ExportPointOpenResponseBody = None,
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
            temp_model = ExportPointOpenResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GrantHonorHeaders(TeaModel):
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


class GrantHonorRequest(TeaModel):
    def __init__(
        self,
        expiration_time: int = None,
        grant_reason: str = None,
        granter_name: str = None,
        notice_announcer: bool = None,
        notice_single: bool = None,
        open_conversation_ids: List[str] = None,
        receiver_user_ids: List[str] = None,
        sender_user_id: str = None,
    ):
        # 有效期到期时间 时间戳. 会处理成到期那天的23:59:59秒的时间戳
        self.expiration_time = expiration_time
        # 颁奖词，最多可以填50字
        self.grant_reason = grant_reason
        # 颁奖人名字，最多15个字
        self.granter_name = granter_name
        # 是否使用官宣号发送内网动态
        self.notice_announcer = notice_announcer
        # 是否触达单聊会话通知
        self.notice_single = notice_single
        self.open_conversation_ids = open_conversation_ids
        # 接受人userId
        self.receiver_user_ids = receiver_user_ids
        # 发送人userId
        self.sender_user_id = sender_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.expiration_time is not None:
            result['expirationTime'] = self.expiration_time
        if self.grant_reason is not None:
            result['grantReason'] = self.grant_reason
        if self.granter_name is not None:
            result['granterName'] = self.granter_name
        if self.notice_announcer is not None:
            result['noticeAnnouncer'] = self.notice_announcer
        if self.notice_single is not None:
            result['noticeSingle'] = self.notice_single
        if self.open_conversation_ids is not None:
            result['openConversationIds'] = self.open_conversation_ids
        if self.receiver_user_ids is not None:
            result['receiverUserIds'] = self.receiver_user_ids
        if self.sender_user_id is not None:
            result['senderUserId'] = self.sender_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('expirationTime') is not None:
            self.expiration_time = m.get('expirationTime')
        if m.get('grantReason') is not None:
            self.grant_reason = m.get('grantReason')
        if m.get('granterName') is not None:
            self.granter_name = m.get('granterName')
        if m.get('noticeAnnouncer') is not None:
            self.notice_announcer = m.get('noticeAnnouncer')
        if m.get('noticeSingle') is not None:
            self.notice_single = m.get('noticeSingle')
        if m.get('openConversationIds') is not None:
            self.open_conversation_ids = m.get('openConversationIds')
        if m.get('receiverUserIds') is not None:
            self.receiver_user_ids = m.get('receiverUserIds')
        if m.get('senderUserId') is not None:
            self.sender_user_id = m.get('senderUserId')
        return self


class GrantHonorResponseBodyResult(TeaModel):
    def __init__(
        self,
        failed_user_ids: List[str] = None,
        success_user_ids: List[str] = None,
    ):
        # 失败的userId
        self.failed_user_ids = failed_user_ids
        # 成功的userId
        self.success_user_ids = success_user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.failed_user_ids is not None:
            result['failedUserIds'] = self.failed_user_ids
        if self.success_user_ids is not None:
            result['successUserIds'] = self.success_user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('failedUserIds') is not None:
            self.failed_user_ids = m.get('failedUserIds')
        if m.get('successUserIds') is not None:
            self.success_user_ids = m.get('successUserIds')
        return self


class GrantHonorResponseBody(TeaModel):
    def __init__(
        self,
        result: GrantHonorResponseBodyResult = None,
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
            temp_model = GrantHonorResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GrantHonorResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GrantHonorResponseBody = None,
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
            temp_model = GrantHonorResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryCorpPointsHeaders(TeaModel):
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


class QueryCorpPointsRequest(TeaModel):
    def __init__(
        self,
        opt_user_id: str = None,
    ):
        # 操作用户ID
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


class QueryCorpPointsResponseBodyResult(TeaModel):
    def __init__(
        self,
        amount: int = None,
    ):
        # 企业员工可用于兑换积分总额
        self.amount = amount

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        return self


class QueryCorpPointsResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryCorpPointsResponseBodyResult = None,
        success: bool = None,
    ):
        # 响应数据
        self.result = result
        # 请求响应状态
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
            temp_model = QueryCorpPointsResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryCorpPointsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryCorpPointsResponseBody = None,
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
            temp_model = QueryCorpPointsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryEmpPointDetailsHeaders(TeaModel):
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


class QueryEmpPointDetailsRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        user_id: str = None,
    ):
        # 第几页 第一页是1
        self.page_number = page_number
        # 每页大小最多50 默认值10
        self.page_size = page_size
        # 查询目标对象userId
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource(TeaModel):
    def __init__(
        self,
        account_type: str = None,
        emp_name: str = None,
        user_id: str = None,
    ):
        # 积分账号的类型
        # 企业账号：ORG, 员工账号：EMP
        self.account_type = account_type
        # 企业内名字
        self.emp_name = emp_name
        # 用户userId
        # 
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_type is not None:
            result['accountType'] = self.account_type
        if self.emp_name is not None:
            result['empName'] = self.emp_name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountType') is not None:
            self.account_type = m.get('accountType')
        if m.get('empName') is not None:
            self.emp_name = m.get('empName')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget(TeaModel):
    def __init__(
        self,
        account_type: str = None,
        emp_name: str = None,
        user_id: str = None,
    ):
        # 积分账号的类型
        # 企业账号：ORG, 员工账号：EMP
        self.account_type = account_type
        # 企业内名字
        self.emp_name = emp_name
        # 用户useId
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_type is not None:
            result['accountType'] = self.account_type
        if self.emp_name is not None:
            result['empName'] = self.emp_name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountType') is not None:
            self.account_type = m.get('accountType')
        if m.get('empName') is not None:
            self.emp_name = m.get('empName')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO(TeaModel):
    def __init__(
        self,
        account_source: QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource = None,
        account_target: QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget = None,
        remark: str = None,
        usage: str = None,
    ):
        # 来源账户
        self.account_source = account_source
        # 目标账户
        # 
        self.account_target = account_target
        # 备注信息，在明细中展示
        self.remark = remark
        # 来源/用途，一般是系统固定的场景
        self.usage = usage

    def validate(self):
        if self.account_source:
            self.account_source.validate()
        if self.account_target:
            self.account_target.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_source is not None:
            result['accountSource'] = self.account_source.to_map()
        if self.account_target is not None:
            result['accountTarget'] = self.account_target.to_map()
        if self.remark is not None:
            result['remark'] = self.remark
        if self.usage is not None:
            result['usage'] = self.usage
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountSource') is not None:
            temp_model = QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource()
            self.account_source = temp_model.from_map(m['accountSource'])
        if m.get('accountTarget') is not None:
            temp_model = QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget()
            self.account_target = temp_model.from_map(m['accountTarget'])
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('usage') is not None:
            self.usage = m.get('usage')
        return self


class QueryEmpPointDetailsResponseBodyResultDetails(TeaModel):
    def __init__(
        self,
        amount: int = None,
        gmt_create: int = None,
        out_id: str = None,
        point_operate_feature_response_dto: QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO = None,
        source_biz_code: str = None,
    ):
        # 积分数量 发放时为负。 扣减时为正
        self.amount = amount
        # 创建时间
        self.gmt_create = gmt_create
        # 积分交易单号
        # 
        self.out_id = out_id
        self.point_operate_feature_response_dto = point_operate_feature_response_dto
        # 源账户积分bizCode.
        # 个人可用积分:personal
        # 额度:credit
        self.source_biz_code = source_biz_code

    def validate(self):
        if self.point_operate_feature_response_dto:
            self.point_operate_feature_response_dto.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.out_id is not None:
            result['outId'] = self.out_id
        if self.point_operate_feature_response_dto is not None:
            result['pointOperateFeatureResponseDTO'] = self.point_operate_feature_response_dto.to_map()
        if self.source_biz_code is not None:
            result['sourceBizCode'] = self.source_biz_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('outId') is not None:
            self.out_id = m.get('outId')
        if m.get('pointOperateFeatureResponseDTO') is not None:
            temp_model = QueryEmpPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO()
            self.point_operate_feature_response_dto = temp_model.from_map(m['pointOperateFeatureResponseDTO'])
        if m.get('sourceBizCode') is not None:
            self.source_biz_code = m.get('sourceBizCode')
        return self


class QueryEmpPointDetailsResponseBodyResult(TeaModel):
    def __init__(
        self,
        details: List[QueryEmpPointDetailsResponseBodyResultDetails] = None,
        has_more: bool = None,
    ):
        # 个人积分明细列表
        self.details = details
        # 是否有下一页
        self.has_more = has_more

    def validate(self):
        if self.details:
            for k in self.details:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['details'] = []
        if self.details is not None:
            for k in self.details:
                result['details'].append(k.to_map() if k else None)
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.details = []
        if m.get('details') is not None:
            for k in m.get('details'):
                temp_model = QueryEmpPointDetailsResponseBodyResultDetails()
                self.details.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        return self


class QueryEmpPointDetailsResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryEmpPointDetailsResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        # 调用是否成功
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
            temp_model = QueryEmpPointDetailsResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryEmpPointDetailsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryEmpPointDetailsResponseBody = None,
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
            temp_model = QueryEmpPointDetailsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryOrgHonorsHeaders(TeaModel):
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


class QueryOrgHonorsRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
    ):
        # 分页获取数据时，数据的数量，默认为20，最大可传入100
        self.max_results = max_results
        # 分页获取数据的标记，第一页调用时传0，非第一页传入上次调用本接口返回值中的nextToken
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


class QueryOrgHonorsResponseBodyResultOpenHonors(TeaModel):
    def __init__(
        self,
        honor_desc: str = None,
        honor_id: int = None,
        honor_img_url: str = None,
        honor_name: str = None,
        honor_pendant_img_url: str = None,
    ):
        # 荣誉含义
        self.honor_desc = honor_desc
        # 荣誉id
        self.honor_id = honor_id
        # 荣誉图片url
        self.honor_img_url = honor_img_url
        # 荣誉名字
        self.honor_name = honor_name
        # 荣誉附赠的挂件图url
        self.honor_pendant_img_url = honor_pendant_img_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.honor_desc is not None:
            result['honorDesc'] = self.honor_desc
        if self.honor_id is not None:
            result['honorId'] = self.honor_id
        if self.honor_img_url is not None:
            result['honorImgUrl'] = self.honor_img_url
        if self.honor_name is not None:
            result['honorName'] = self.honor_name
        if self.honor_pendant_img_url is not None:
            result['honorPendantImgUrl'] = self.honor_pendant_img_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('honorDesc') is not None:
            self.honor_desc = m.get('honorDesc')
        if m.get('honorId') is not None:
            self.honor_id = m.get('honorId')
        if m.get('honorImgUrl') is not None:
            self.honor_img_url = m.get('honorImgUrl')
        if m.get('honorName') is not None:
            self.honor_name = m.get('honorName')
        if m.get('honorPendantImgUrl') is not None:
            self.honor_pendant_img_url = m.get('honorPendantImgUrl')
        return self


class QueryOrgHonorsResponseBodyResult(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        open_honors: List[QueryOrgHonorsResponseBodyResultOpenHonors] = None,
    ):
        # 下次获取数据的游标
        self.next_token = next_token
        self.open_honors = open_honors

    def validate(self):
        if self.open_honors:
            for k in self.open_honors:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['openHonors'] = []
        if self.open_honors is not None:
            for k in self.open_honors:
                result['openHonors'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.open_honors = []
        if m.get('openHonors') is not None:
            for k in m.get('openHonors'):
                temp_model = QueryOrgHonorsResponseBodyResultOpenHonors()
                self.open_honors.append(temp_model.from_map(k))
        return self


class QueryOrgHonorsResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryOrgHonorsResponseBodyResult = None,
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
            temp_model = QueryOrgHonorsResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryOrgHonorsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryOrgHonorsResponseBody = None,
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
            temp_model = QueryOrgHonorsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryOrgPointDetailsHeaders(TeaModel):
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


class QueryOrgPointDetailsRequest(TeaModel):
    def __init__(
        self,
        account_type: str = None,
        page_number: int = None,
        page_size: int = None,
        user_id: str = None,
    ):
        # 查询企业账号明细，ORG,ORG_DEDUCTIONS两种。     ORG:企业账户明细 查询的是企业积分发放明细       ORG_DEDUCTIONS:扣除账户明细，查询的是企业扣减积分明细
        self.account_type = account_type
        # 查询页数 第一页是1 非空必传
        self.page_number = page_number
        # 每页大小最多50，默认10
        self.page_size = page_size
        # 操作人userId 必须是管理员
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_type is not None:
            result['accountType'] = self.account_type
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountType') is not None:
            self.account_type = m.get('accountType')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource(TeaModel):
    def __init__(
        self,
        account_type: str = None,
        emp_name: str = None,
        user_id: str = None,
    ):
        # 积分账号的类型
        # 企业账号：ORG, 员工账号：EMP
        self.account_type = account_type
        # 企业内名字
        self.emp_name = emp_name
        # 用户id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_type is not None:
            result['accountType'] = self.account_type
        if self.emp_name is not None:
            result['empName'] = self.emp_name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountType') is not None:
            self.account_type = m.get('accountType')
        if m.get('empName') is not None:
            self.emp_name = m.get('empName')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget(TeaModel):
    def __init__(
        self,
        account_type: str = None,
        emp_name: str = None,
        user_id: str = None,
    ):
        # 积分账号的类型
        # 企业账号：ORG, 员工账号：EMP
        self.account_type = account_type
        # 企业内名字
        self.emp_name = emp_name
        # 用户id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_type is not None:
            result['accountType'] = self.account_type
        if self.emp_name is not None:
            result['empName'] = self.emp_name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountType') is not None:
            self.account_type = m.get('accountType')
        if m.get('empName') is not None:
            self.emp_name = m.get('empName')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO(TeaModel):
    def __init__(
        self,
        account_source: QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource = None,
        account_target: QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget = None,
        remark: str = None,
        usage: str = None,
    ):
        # 如果是扣减操作明细，为被扣减账户
        # 如果是发放操作明细，为操作发放账户
        # 如果是个人积分明细，为来源账户
        self.account_source = account_source
        # 如果是扣减操作明细，为操作扣减账户
        # 如果是发放操作明细，为被发放账户
        # 如果是个人积分明细，为目标账户
        self.account_target = account_target
        # 备注信息，在明细中展示
        self.remark = remark
        # 来源/用途 一般是系统固定的场景
        self.usage = usage

    def validate(self):
        if self.account_source:
            self.account_source.validate()
        if self.account_target:
            self.account_target.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_source is not None:
            result['accountSource'] = self.account_source.to_map()
        if self.account_target is not None:
            result['accountTarget'] = self.account_target.to_map()
        if self.remark is not None:
            result['remark'] = self.remark
        if self.usage is not None:
            result['usage'] = self.usage
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountSource') is not None:
            temp_model = QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountSource()
            self.account_source = temp_model.from_map(m['accountSource'])
        if m.get('accountTarget') is not None:
            temp_model = QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTOAccountTarget()
            self.account_target = temp_model.from_map(m['accountTarget'])
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('usage') is not None:
            self.usage = m.get('usage')
        return self


class QueryOrgPointDetailsResponseBodyResultDetails(TeaModel):
    def __init__(
        self,
        amount: int = None,
        gmt_create: int = None,
        out_id: str = None,
        point_operate_feature_response_dto: QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO = None,
        source_biz_code: str = None,
    ):
        # 积分数量 发放时为负。 扣减时为正
        self.amount = amount
        # 创建时间
        self.gmt_create = gmt_create
        # 积分交易单号
        self.out_id = out_id
        # 账户信息
        self.point_operate_feature_response_dto = point_operate_feature_response_dto
        # 源账户积分bizCode。
        # 个人可用积分:personal
        # 额度:credit
        self.source_biz_code = source_biz_code

    def validate(self):
        if self.point_operate_feature_response_dto:
            self.point_operate_feature_response_dto.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.out_id is not None:
            result['outId'] = self.out_id
        if self.point_operate_feature_response_dto is not None:
            result['pointOperateFeatureResponseDTO'] = self.point_operate_feature_response_dto.to_map()
        if self.source_biz_code is not None:
            result['sourceBizCode'] = self.source_biz_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('outId') is not None:
            self.out_id = m.get('outId')
        if m.get('pointOperateFeatureResponseDTO') is not None:
            temp_model = QueryOrgPointDetailsResponseBodyResultDetailsPointOperateFeatureResponseDTO()
            self.point_operate_feature_response_dto = temp_model.from_map(m['pointOperateFeatureResponseDTO'])
        if m.get('sourceBizCode') is not None:
            self.source_biz_code = m.get('sourceBizCode')
        return self


class QueryOrgPointDetailsResponseBodyResult(TeaModel):
    def __init__(
        self,
        details: List[QueryOrgPointDetailsResponseBodyResultDetails] = None,
        has_more: bool = None,
        success: bool = None,
    ):
        # 积分明细列表
        self.details = details
        # 分页使用，表示是否还有下一页
        self.has_more = has_more
        # 调用是否成功
        self.success = success

    def validate(self):
        if self.details:
            for k in self.details:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['details'] = []
        if self.details is not None:
            for k in self.details:
                result['details'].append(k.to_map() if k else None)
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.details = []
        if m.get('details') is not None:
            for k in m.get('details'):
                temp_model = QueryOrgPointDetailsResponseBodyResultDetails()
                self.details.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryOrgPointDetailsResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryOrgPointDetailsResponseBodyResult = None,
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
            temp_model = QueryOrgPointDetailsResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class QueryOrgPointDetailsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryOrgPointDetailsResponseBody = None,
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
            temp_model = QueryOrgPointDetailsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryPointActionAutoAssignRuleHeaders(TeaModel):
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


class QueryPointActionAutoAssignRuleResponseBodyResultQueryPointRuleResponseDTOS(TeaModel):
    def __init__(
        self,
        award_score: int = None,
        code: str = None,
        day_limit_times: int = None,
        description: str = None,
        status: int = None,
    ):
        # 奖励积分
        self.award_score = award_score
        # 行为名称
        self.code = code
        # 单日计次上限
        self.day_limit_times = day_limit_times
        # 行为描述
        self.description = description
        # 生效状态：0无效，1有效
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.award_score is not None:
            result['awardScore'] = self.award_score
        if self.code is not None:
            result['code'] = self.code
        if self.day_limit_times is not None:
            result['dayLimitTimes'] = self.day_limit_times
        if self.description is not None:
            result['description'] = self.description
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('awardScore') is not None:
            self.award_score = m.get('awardScore')
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('dayLimitTimes') is not None:
            self.day_limit_times = m.get('dayLimitTimes')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class QueryPointActionAutoAssignRuleResponseBodyResult(TeaModel):
    def __init__(
        self,
        query_point_rule_response_dtos: List[QueryPointActionAutoAssignRuleResponseBodyResultQueryPointRuleResponseDTOS] = None,
    ):
        # 行为规则列表
        self.query_point_rule_response_dtos = query_point_rule_response_dtos

    def validate(self):
        if self.query_point_rule_response_dtos:
            for k in self.query_point_rule_response_dtos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['queryPointRuleResponseDTOS'] = []
        if self.query_point_rule_response_dtos is not None:
            for k in self.query_point_rule_response_dtos:
                result['queryPointRuleResponseDTOS'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.query_point_rule_response_dtos = []
        if m.get('queryPointRuleResponseDTOS') is not None:
            for k in m.get('queryPointRuleResponseDTOS'):
                temp_model = QueryPointActionAutoAssignRuleResponseBodyResultQueryPointRuleResponseDTOS()
                self.query_point_rule_response_dtos.append(temp_model.from_map(k))
        return self


class QueryPointActionAutoAssignRuleResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryPointActionAutoAssignRuleResponseBodyResult = None,
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
            temp_model = QueryPointActionAutoAssignRuleResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryPointActionAutoAssignRuleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryPointActionAutoAssignRuleResponseBody = None,
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
            temp_model = QueryPointActionAutoAssignRuleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryPointAutoIssueSettingHeaders(TeaModel):
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


class QueryPointAutoIssueSettingResponseBodyResult(TeaModel):
    def __init__(
        self,
        point_auto_num: int = None,
        point_auto_state: bool = None,
        point_auto_time: int = None,
    ):
        # 企业每月额度自动发放给每个人的数量
        self.point_auto_num = point_auto_num
        # 企业积分自动发放状态
        self.point_auto_state = point_auto_state
        # 企业积分自动发放时间 指定的是每月1号或15号
        self.point_auto_time = point_auto_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.point_auto_num is not None:
            result['pointAutoNum'] = self.point_auto_num
        if self.point_auto_state is not None:
            result['pointAutoState'] = self.point_auto_state
        if self.point_auto_time is not None:
            result['pointAutoTime'] = self.point_auto_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pointAutoNum') is not None:
            self.point_auto_num = m.get('pointAutoNum')
        if m.get('pointAutoState') is not None:
            self.point_auto_state = m.get('pointAutoState')
        if m.get('pointAutoTime') is not None:
            self.point_auto_time = m.get('pointAutoTime')
        return self


class QueryPointAutoIssueSettingResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryPointAutoIssueSettingResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        # 调用是否成功
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
            temp_model = QueryPointAutoIssueSettingResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryPointAutoIssueSettingResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryPointAutoIssueSettingResponseBody = None,
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
            temp_model = QueryPointAutoIssueSettingResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryUserHonorsHeaders(TeaModel):
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


class QueryUserHonorsRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
    ):
        # 查询数据的条数，默认查询20条，最大可传100
        self.max_results = max_results
        # 分页查询的标记，查询第一页时传0，非第一页时传入上次调用本接口返回值中的nextToken
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


class QueryUserHonorsResponseBodyResultHonorsGrantHistory(TeaModel):
    def __init__(
        self,
        grant_time: int = None,
        sender_userid: str = None,
    ):
        # 授予时间 时间戳
        self.grant_time = grant_time
        # 必须。荣誉发放人userid
        self.sender_userid = sender_userid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.grant_time is not None:
            result['grantTime'] = self.grant_time
        if self.sender_userid is not None:
            result['senderUserid'] = self.sender_userid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('grantTime') is not None:
            self.grant_time = m.get('grantTime')
        if m.get('senderUserid') is not None:
            self.sender_userid = m.get('senderUserid')
        return self


class QueryUserHonorsResponseBodyResultHonors(TeaModel):
    def __init__(
        self,
        expiration_time: int = None,
        grant_history: List[QueryUserHonorsResponseBodyResultHonorsGrantHistory] = None,
        honor_desc: str = None,
        honor_id: str = None,
        honor_name: str = None,
    ):
        # 有效期截止时间点，没有该属性则为永久生效
        self.expiration_time = expiration_time
        # 授予历史记录 包含用户及授予时间
        self.grant_history = grant_history
        # 荣誉含义
        self.honor_desc = honor_desc
        # 必须。荣誉id
        self.honor_id = honor_id
        # 必须。荣誉名字
        self.honor_name = honor_name

    def validate(self):
        if self.grant_history:
            for k in self.grant_history:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.expiration_time is not None:
            result['expirationTime'] = self.expiration_time
        result['grantHistory'] = []
        if self.grant_history is not None:
            for k in self.grant_history:
                result['grantHistory'].append(k.to_map() if k else None)
        if self.honor_desc is not None:
            result['honorDesc'] = self.honor_desc
        if self.honor_id is not None:
            result['honorId'] = self.honor_id
        if self.honor_name is not None:
            result['honorName'] = self.honor_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('expirationTime') is not None:
            self.expiration_time = m.get('expirationTime')
        self.grant_history = []
        if m.get('grantHistory') is not None:
            for k in m.get('grantHistory'):
                temp_model = QueryUserHonorsResponseBodyResultHonorsGrantHistory()
                self.grant_history.append(temp_model.from_map(k))
        if m.get('honorDesc') is not None:
            self.honor_desc = m.get('honorDesc')
        if m.get('honorId') is not None:
            self.honor_id = m.get('honorId')
        if m.get('honorName') is not None:
            self.honor_name = m.get('honorName')
        return self


class QueryUserHonorsResponseBodyResult(TeaModel):
    def __init__(
        self,
        honors: List[QueryUserHonorsResponseBodyResultHonors] = None,
        next_token: str = None,
    ):
        self.honors = honors
        self.next_token = next_token

    def validate(self):
        if self.honors:
            for k in self.honors:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['honors'] = []
        if self.honors is not None:
            for k in self.honors:
                result['honors'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.honors = []
        if m.get('honors') is not None:
            for k in m.get('honors'):
                temp_model = QueryUserHonorsResponseBodyResultHonors()
                self.honors.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class QueryUserHonorsResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryUserHonorsResponseBodyResult = None,
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
            temp_model = QueryUserHonorsResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryUserHonorsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryUserHonorsResponseBody = None,
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
            temp_model = QueryUserHonorsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryUserPointsHeaders(TeaModel):
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


class QueryUserPointsResponseBodyResult(TeaModel):
    def __init__(
        self,
        amount: int = None,
    ):
        # 员工积分数量
        self.amount = amount

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        return self


class QueryUserPointsResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryUserPointsResponseBodyResult = None,
        success: bool = None,
    ):
        # 响应数据
        self.result = result
        # 请求响应状态
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
            temp_model = QueryUserPointsResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryUserPointsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryUserPointsResponseBody = None,
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
            temp_model = QueryUserPointsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateAutoIssuePointHeaders(TeaModel):
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


class UpdateAutoIssuePointRequest(TeaModel):
    def __init__(
        self,
        point_auto_num: int = None,
        point_auto_state: bool = None,
        point_auto_time: int = None,
        user_id: str = None,
    ):
        # 企业积分自动发放数量1-10000
        self.point_auto_num = point_auto_num
        # 企业积分自动发放状态
        self.point_auto_state = point_auto_state
        # 企业积分自动发放时间 必须为每月的1号或15号，传入1时为1号，传入15时为15号。
        self.point_auto_time = point_auto_time
        # 操作人userId
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.point_auto_num is not None:
            result['pointAutoNum'] = self.point_auto_num
        if self.point_auto_state is not None:
            result['pointAutoState'] = self.point_auto_state
        if self.point_auto_time is not None:
            result['pointAutoTime'] = self.point_auto_time
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pointAutoNum') is not None:
            self.point_auto_num = m.get('pointAutoNum')
        if m.get('pointAutoState') is not None:
            self.point_auto_state = m.get('pointAutoState')
        if m.get('pointAutoTime') is not None:
            self.point_auto_time = m.get('pointAutoTime')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UpdateAutoIssuePointResponseBodyResult(TeaModel):
    def __init__(
        self,
        next_auto_issue_point_time: int = None,
    ):
        # 下次自动发放时间
        self.next_auto_issue_point_time = next_auto_issue_point_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_auto_issue_point_time is not None:
            result['nextAutoIssuePointTime'] = self.next_auto_issue_point_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextAutoIssuePointTime') is not None:
            self.next_auto_issue_point_time = m.get('nextAutoIssuePointTime')
        return self


class UpdateAutoIssuePointResponseBody(TeaModel):
    def __init__(
        self,
        result: UpdateAutoIssuePointResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        # 调用是否成功
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
            temp_model = UpdateAutoIssuePointResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UpdateAutoIssuePointResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateAutoIssuePointResponseBody = None,
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
            temp_model = UpdateAutoIssuePointResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdatePointActionAutoAssignRuleHeaders(TeaModel):
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


class UpdatePointActionAutoAssignRuleRequestUpdatePointRuleRequestDTOList(TeaModel):
    def __init__(
        self,
        award_score: int = None,
        code: str = None,
        day_limit_times: int = None,
        status: int = None,
    ):
        # 奖励积分1～100
        self.award_score = award_score
        # 行为名称 不支持修改 
        self.code = code
        # 单日计次上限 1～10
        self.day_limit_times = day_limit_times
        # 生效状态：0无效，1有效
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.award_score is not None:
            result['awardScore'] = self.award_score
        if self.code is not None:
            result['code'] = self.code
        if self.day_limit_times is not None:
            result['dayLimitTimes'] = self.day_limit_times
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('awardScore') is not None:
            self.award_score = m.get('awardScore')
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('dayLimitTimes') is not None:
            self.day_limit_times = m.get('dayLimitTimes')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class UpdatePointActionAutoAssignRuleRequest(TeaModel):
    def __init__(
        self,
        update_point_rule_request_dtolist: List[UpdatePointActionAutoAssignRuleRequestUpdatePointRuleRequestDTOList] = None,
        user_id: str = None,
    ):
        # 行为规则列表
        self.update_point_rule_request_dtolist = update_point_rule_request_dtolist
        # 操作人userId
        self.user_id = user_id

    def validate(self):
        if self.update_point_rule_request_dtolist:
            for k in self.update_point_rule_request_dtolist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['updatePointRuleRequestDTOList'] = []
        if self.update_point_rule_request_dtolist is not None:
            for k in self.update_point_rule_request_dtolist:
                result['updatePointRuleRequestDTOList'].append(k.to_map() if k else None)
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.update_point_rule_request_dtolist = []
        if m.get('updatePointRuleRequestDTOList') is not None:
            for k in m.get('updatePointRuleRequestDTOList'):
                temp_model = UpdatePointActionAutoAssignRuleRequestUpdatePointRuleRequestDTOList()
                self.update_point_rule_request_dtolist.append(temp_model.from_map(k))
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UpdatePointActionAutoAssignRuleResponseBody(TeaModel):
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


class UpdatePointActionAutoAssignRuleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdatePointActionAutoAssignRuleResponseBody = None,
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
            temp_model = UpdatePointActionAutoAssignRuleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


