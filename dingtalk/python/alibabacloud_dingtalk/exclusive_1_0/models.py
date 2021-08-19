# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class GetConferenceDetailHeaders(TeaModel):
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


class GetConferenceDetailResponseBodyMemberList(TeaModel):
    def __init__(
        self,
        union_id: str = None,
        name: str = None,
        attend_duration: float = None,
        staff_id: str = None,
    ):
        # 用户uid
        self.union_id = union_id
        # 用户昵称
        self.name = name
        # 参会时长
        self.attend_duration = attend_duration
        # 员工id
        self.staff_id = staff_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.name is not None:
            result['name'] = self.name
        if self.attend_duration is not None:
            result['attendDuration'] = self.attend_duration
        if self.staff_id is not None:
            result['staffId'] = self.staff_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('attendDuration') is not None:
            self.attend_duration = m.get('attendDuration')
        if m.get('staffId') is not None:
            self.staff_id = m.get('staffId')
        return self


class GetConferenceDetailResponseBody(TeaModel):
    def __init__(
        self,
        conference_id: str = None,
        title: str = None,
        conf_start_time: float = None,
        duration: float = None,
        total_num: int = None,
        attendee_num: int = None,
        attendee_percentage: str = None,
        caller_id: str = None,
        caller_name: str = None,
        member_list: List[GetConferenceDetailResponseBodyMemberList] = None,
    ):
        # 会议ID
        self.conference_id = conference_id
        # 会议标题
        self.title = title
        # 开始时间
        self.conf_start_time = conf_start_time
        # 持续时间
        self.duration = duration
        # 会议人数
        self.total_num = total_num
        # 出席会议人数
        self.attendee_num = attendee_num
        # 出席率
        self.attendee_percentage = attendee_percentage
        # 发起人uid
        self.caller_id = caller_id
        # 发起人昵称
        self.caller_name = caller_name
        # 参会人员列表
        self.member_list = member_list

    def validate(self):
        if self.member_list:
            for k in self.member_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        if self.title is not None:
            result['title'] = self.title
        if self.conf_start_time is not None:
            result['confStartTime'] = self.conf_start_time
        if self.duration is not None:
            result['duration'] = self.duration
        if self.total_num is not None:
            result['totalNum'] = self.total_num
        if self.attendee_num is not None:
            result['attendeeNum'] = self.attendee_num
        if self.attendee_percentage is not None:
            result['attendeePercentage'] = self.attendee_percentage
        if self.caller_id is not None:
            result['callerId'] = self.caller_id
        if self.caller_name is not None:
            result['callerName'] = self.caller_name
        result['memberList'] = []
        if self.member_list is not None:
            for k in self.member_list:
                result['memberList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('confStartTime') is not None:
            self.conf_start_time = m.get('confStartTime')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('totalNum') is not None:
            self.total_num = m.get('totalNum')
        if m.get('attendeeNum') is not None:
            self.attendee_num = m.get('attendeeNum')
        if m.get('attendeePercentage') is not None:
            self.attendee_percentage = m.get('attendeePercentage')
        if m.get('callerId') is not None:
            self.caller_id = m.get('callerId')
        if m.get('callerName') is not None:
            self.caller_name = m.get('callerName')
        self.member_list = []
        if m.get('memberList') is not None:
            for k in m.get('memberList'):
                temp_model = GetConferenceDetailResponseBodyMemberList()
                self.member_list.append(temp_model.from_map(k))
        return self


class GetConferenceDetailResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetConferenceDetailResponseBody = None,
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
            temp_model = GetConferenceDetailResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetOaOperatorLogListHeaders(TeaModel):
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


class GetOaOperatorLogListRequest(TeaModel):
    def __init__(
        self,
        op_user_id: str = None,
        start_time: int = None,
        end_time: int = None,
        page_number: int = None,
        page_size: int = None,
        category_list: List[str] = None,
    ):
        # 操作员userId
        self.op_user_id = op_user_id
        # 起始时间
        self.start_time = start_time
        # 结束时间
        self.end_time = end_time
        # 分页起始页
        self.page_number = page_number
        # 分页大小
        self.page_size = page_size
        # 操作分类（一级目录）
        self.category_list = category_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.category_list is not None:
            result['categoryList'] = self.category_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('categoryList') is not None:
            self.category_list = m.get('categoryList')
        return self


class GetOaOperatorLogListResponseBodyData(TeaModel):
    def __init__(
        self,
        op_user_id: str = None,
        op_name: str = None,
        op_time: int = None,
        category_1name: str = None,
        category_2name: str = None,
        content: str = None,
        extension: str = None,
    ):
        # 操作员userId
        self.op_user_id = op_user_id
        # 操作员名字
        self.op_name = op_name
        # 操作时间
        self.op_time = op_time
        # 操作分类（一级）
        self.category_1name = category_1name
        # 操作分类（二级）
        self.category_2name = category_2name
        # 操作详情
        self.content = content
        # 扩展字段
        self.extension = extension

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.op_name is not None:
            result['opName'] = self.op_name
        if self.op_time is not None:
            result['opTime'] = self.op_time
        if self.category_1name is not None:
            result['category1Name'] = self.category_1name
        if self.category_2name is not None:
            result['category2Name'] = self.category_2name
        if self.content is not None:
            result['content'] = self.content
        if self.extension is not None:
            result['extension'] = self.extension
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('opName') is not None:
            self.op_name = m.get('opName')
        if m.get('opTime') is not None:
            self.op_time = m.get('opTime')
        if m.get('category1Name') is not None:
            self.category_1name = m.get('category1Name')
        if m.get('category2Name') is not None:
            self.category_2name = m.get('category2Name')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        return self


class GetOaOperatorLogListResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetOaOperatorLogListResponseBodyData] = None,
        item_count: int = None,
    ):
        self.data = data
        # 当前获取记录数
        self.item_count = item_count

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
        if self.item_count is not None:
            result['itemCount'] = self.item_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetOaOperatorLogListResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('itemCount') is not None:
            self.item_count = m.get('itemCount')
        return self


class GetOaOperatorLogListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetOaOperatorLogListResponseBody = None,
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
            temp_model = GetOaOperatorLogListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteCommentHeaders(TeaModel):
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


class DeleteCommentResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: bool = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            self.body = m.get('body')
        return self


class GetAllLabelableDeptsHeaders(TeaModel):
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


class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1(TeaModel):
    def __init__(
        self,
        label_id: int = None,
        label_name: str = None,
        level_num: int = None,
    ):
        # 伙伴类型id
        self.label_id = label_id
        # 伙伴类型
        self.label_name = label_name
        # 伙伴类型层级
        self.level_num = level_num

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label_id is not None:
            result['labelId'] = self.label_id
        if self.label_name is not None:
            result['labelName'] = self.label_name
        if self.level_num is not None:
            result['levelNum'] = self.level_num
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('labelId') is not None:
            self.label_id = m.get('labelId')
        if m.get('labelName') is not None:
            self.label_name = m.get('labelName')
        if m.get('levelNum') is not None:
            self.level_num = m.get('levelNum')
        return self


class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2(TeaModel):
    def __init__(
        self,
        label_id: int = None,
        label_name: str = None,
        level_num: int = None,
    ):
        # 伙伴类型id
        self.label_id = label_id
        # 伙伴类型
        self.label_name = label_name
        # 伙伴类型层级
        self.level_num = level_num

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label_id is not None:
            result['labelId'] = self.label_id
        if self.label_name is not None:
            result['labelName'] = self.label_name
        if self.level_num is not None:
            result['levelNum'] = self.level_num
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('labelId') is not None:
            self.label_id = m.get('labelId')
        if m.get('labelName') is not None:
            self.label_name = m.get('labelName')
        if m.get('levelNum') is not None:
            self.level_num = m.get('levelNum')
        return self


class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3(TeaModel):
    def __init__(
        self,
        label_id: int = None,
        label_name: str = None,
        level_num: int = None,
    ):
        # 伙伴类型id
        self.label_id = label_id
        # 伙伴类型
        self.label_name = label_name
        # 伙伴类型层级
        self.level_num = level_num

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label_id is not None:
            result['labelId'] = self.label_id
        if self.label_name is not None:
            result['labelName'] = self.label_name
        if self.level_num is not None:
            result['levelNum'] = self.level_num
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('labelId') is not None:
            self.label_id = m.get('labelId')
        if m.get('labelName') is not None:
            self.label_name = m.get('labelName')
        if m.get('levelNum') is not None:
            self.level_num = m.get('levelNum')
        return self


class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4(TeaModel):
    def __init__(
        self,
        label_id: int = None,
        label_name: str = None,
        level_num: int = None,
    ):
        # 伙伴类型id
        self.label_id = label_id
        # 伙伴类型
        self.label_name = label_name
        # 伙伴类型层级
        self.level_num = level_num

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label_id is not None:
            result['labelId'] = self.label_id
        if self.label_name is not None:
            result['labelName'] = self.label_name
        if self.level_num is not None:
            result['levelNum'] = self.level_num
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('labelId') is not None:
            self.label_id = m.get('labelId')
        if m.get('labelName') is not None:
            self.label_name = m.get('labelName')
        if m.get('levelNum') is not None:
            self.level_num = m.get('levelNum')
        return self


class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5(TeaModel):
    def __init__(
        self,
        label_id: int = None,
        label_name: str = None,
        level_num: int = None,
    ):
        # 伙伴类型id
        self.label_id = label_id
        # 伙伴类型
        self.label_name = label_name
        # 伙伴类型层级
        self.level_num = level_num

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label_id is not None:
            result['labelId'] = self.label_id
        if self.label_name is not None:
            result['labelName'] = self.label_name
        if self.level_num is not None:
            result['levelNum'] = self.level_num
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('labelId') is not None:
            self.label_id = m.get('labelId')
        if m.get('labelName') is not None:
            self.label_name = m.get('labelName')
        if m.get('levelNum') is not None:
            self.level_num = m.get('levelNum')
        return self


class GetAllLabelableDeptsResponseBodyData(TeaModel):
    def __init__(
        self,
        dept_id: str = None,
        super_dept_id: str = None,
        dept_name: str = None,
        member_count: int = None,
        partner_num: str = None,
        partner_label_volevel_1: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1 = None,
        partner_label_volevel_2: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2 = None,
        partner_label_volevel_3: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3 = None,
        partner_label_volevel_4: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4 = None,
        partner_label_volevel_5: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5 = None,
    ):
        # 部门id
        self.dept_id = dept_id
        # 父部门id
        self.super_dept_id = super_dept_id
        # 部门名称
        self.dept_name = dept_name
        # 部门人数
        self.member_count = member_count
        # 部门伙伴编码
        self.partner_num = partner_num
        # 部门一级伙伴类型
        self.partner_label_volevel_1 = partner_label_volevel_1
        # 部门二级伙伴类型
        self.partner_label_volevel_2 = partner_label_volevel_2
        # 部门三级伙伴类型
        self.partner_label_volevel_3 = partner_label_volevel_3
        # 部门四级伙伴类型
        self.partner_label_volevel_4 = partner_label_volevel_4
        # 部门五级伙伴类型
        self.partner_label_volevel_5 = partner_label_volevel_5

    def validate(self):
        if self.partner_label_volevel_1:
            self.partner_label_volevel_1.validate()
        if self.partner_label_volevel_2:
            self.partner_label_volevel_2.validate()
        if self.partner_label_volevel_3:
            self.partner_label_volevel_3.validate()
        if self.partner_label_volevel_4:
            self.partner_label_volevel_4.validate()
        if self.partner_label_volevel_5:
            self.partner_label_volevel_5.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.super_dept_id is not None:
            result['superDeptId'] = self.super_dept_id
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.member_count is not None:
            result['memberCount'] = self.member_count
        if self.partner_num is not None:
            result['partnerNum'] = self.partner_num
        if self.partner_label_volevel_1 is not None:
            result['partnerLabelVOLevel1'] = self.partner_label_volevel_1.to_map()
        if self.partner_label_volevel_2 is not None:
            result['partnerLabelVOLevel2'] = self.partner_label_volevel_2.to_map()
        if self.partner_label_volevel_3 is not None:
            result['partnerLabelVOLevel3'] = self.partner_label_volevel_3.to_map()
        if self.partner_label_volevel_4 is not None:
            result['partnerLabelVOLevel4'] = self.partner_label_volevel_4.to_map()
        if self.partner_label_volevel_5 is not None:
            result['partnerLabelVOLevel5'] = self.partner_label_volevel_5.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('superDeptId') is not None:
            self.super_dept_id = m.get('superDeptId')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('memberCount') is not None:
            self.member_count = m.get('memberCount')
        if m.get('partnerNum') is not None:
            self.partner_num = m.get('partnerNum')
        if m.get('partnerLabelVOLevel1') is not None:
            temp_model = GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1()
            self.partner_label_volevel_1 = temp_model.from_map(m['partnerLabelVOLevel1'])
        if m.get('partnerLabelVOLevel2') is not None:
            temp_model = GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2()
            self.partner_label_volevel_2 = temp_model.from_map(m['partnerLabelVOLevel2'])
        if m.get('partnerLabelVOLevel3') is not None:
            temp_model = GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3()
            self.partner_label_volevel_3 = temp_model.from_map(m['partnerLabelVOLevel3'])
        if m.get('partnerLabelVOLevel4') is not None:
            temp_model = GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4()
            self.partner_label_volevel_4 = temp_model.from_map(m['partnerLabelVOLevel4'])
        if m.get('partnerLabelVOLevel5') is not None:
            temp_model = GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5()
            self.partner_label_volevel_5 = temp_model.from_map(m['partnerLabelVOLevel5'])
        return self


class GetAllLabelableDeptsResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetAllLabelableDeptsResponseBodyData] = None,
    ):
        # 伙伴钉可打标部门列表
        self.data = data

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetAllLabelableDeptsResponseBodyData()
                self.data.append(temp_model.from_map(k))
        return self


class GetAllLabelableDeptsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetAllLabelableDeptsResponseBody = None,
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
            temp_model = GetAllLabelableDeptsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetTrustDeviceListHeaders(TeaModel):
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


class GetTrustDeviceListRequest(TeaModel):
    def __init__(
        self,
        user_ids: List[str] = None,
    ):
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class GetTrustDeviceListResponseBodyData(TeaModel):
    def __init__(
        self,
        user_id: str = None,
        platform: str = None,
        mac_address: str = None,
        status: int = None,
        create_time: int = None,
    ):
        # 员工Id
        self.user_id = user_id
        # 平台类型
        self.platform = platform
        # mac地址
        self.mac_address = mac_address
        # 设备状态
        self.status = status
        # 创建时间
        self.create_time = create_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.platform is not None:
            result['platform'] = self.platform
        if self.mac_address is not None:
            result['macAddress'] = self.mac_address
        if self.status is not None:
            result['status'] = self.status
        if self.create_time is not None:
            result['createTime'] = self.create_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('platform') is not None:
            self.platform = m.get('platform')
        if m.get('macAddress') is not None:
            self.mac_address = m.get('macAddress')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        return self


class GetTrustDeviceListResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetTrustDeviceListResponseBodyData] = None,
    ):
        self.data = data

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetTrustDeviceListResponseBodyData()
                self.data.append(temp_model.from_map(k))
        return self


class GetTrustDeviceListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetTrustDeviceListResponseBody = None,
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
            temp_model = GetTrustDeviceListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SearchOrgInnerGroupInfoHeaders(TeaModel):
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


class SearchOrgInnerGroupInfoRequest(TeaModel):
    def __init__(
        self,
        group_members_count_end: int = None,
        sync_to_dingpan: int = None,
        group_owner: str = None,
        create_time_end: int = None,
        page_size: int = None,
        create_time_start: int = None,
        uuid: str = None,
        group_members_count_start: int = None,
        last_active_time_end: int = None,
        operator_user_id: str = None,
        group_name: str = None,
        page_start: int = None,
        last_active_time_start: int = None,
    ):
        # groupMembersCntEnd
        self.group_members_count_end = group_members_count_end
        # syncToDingpan
        self.sync_to_dingpan = sync_to_dingpan
        # groupOwner
        self.group_owner = group_owner
        # createTimeEnd
        self.create_time_end = create_time_end
        # pageSize
        self.page_size = page_size
        # createTimeStart
        self.create_time_start = create_time_start
        # uuid
        self.uuid = uuid
        # groupMembersCntStart
        self.group_members_count_start = group_members_count_start
        # lastActiveTimeEnd
        self.last_active_time_end = last_active_time_end
        # operatorUserId
        self.operator_user_id = operator_user_id
        # groupName
        self.group_name = group_name
        # pageStart
        self.page_start = page_start
        # lastActiveTimeStart
        self.last_active_time_start = last_active_time_start

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_members_count_end is not None:
            result['groupMembersCountEnd'] = self.group_members_count_end
        if self.sync_to_dingpan is not None:
            result['syncToDingpan'] = self.sync_to_dingpan
        if self.group_owner is not None:
            result['groupOwner'] = self.group_owner
        if self.create_time_end is not None:
            result['createTimeEnd'] = self.create_time_end
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.create_time_start is not None:
            result['createTimeStart'] = self.create_time_start
        if self.uuid is not None:
            result['uuid'] = self.uuid
        if self.group_members_count_start is not None:
            result['groupMembersCountStart'] = self.group_members_count_start
        if self.last_active_time_end is not None:
            result['lastActiveTimeEnd'] = self.last_active_time_end
        if self.operator_user_id is not None:
            result['operatorUserId'] = self.operator_user_id
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.page_start is not None:
            result['pageStart'] = self.page_start
        if self.last_active_time_start is not None:
            result['lastActiveTimeStart'] = self.last_active_time_start
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupMembersCountEnd') is not None:
            self.group_members_count_end = m.get('groupMembersCountEnd')
        if m.get('syncToDingpan') is not None:
            self.sync_to_dingpan = m.get('syncToDingpan')
        if m.get('groupOwner') is not None:
            self.group_owner = m.get('groupOwner')
        if m.get('createTimeEnd') is not None:
            self.create_time_end = m.get('createTimeEnd')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('createTimeStart') is not None:
            self.create_time_start = m.get('createTimeStart')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        if m.get('groupMembersCountStart') is not None:
            self.group_members_count_start = m.get('groupMembersCountStart')
        if m.get('lastActiveTimeEnd') is not None:
            self.last_active_time_end = m.get('lastActiveTimeEnd')
        if m.get('operatorUserId') is not None:
            self.operator_user_id = m.get('operatorUserId')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('pageStart') is not None:
            self.page_start = m.get('pageStart')
        if m.get('lastActiveTimeStart') is not None:
            self.last_active_time_start = m.get('lastActiveTimeStart')
        return self


class SearchOrgInnerGroupInfoResponseBodyItems(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        group_owner: str = None,
        group_name: str = None,
        group_admins_count: int = None,
        group_members_count: int = None,
        group_create_time: int = None,
        group_last_active_time: int = None,
        group_last_active_time_show: str = None,
        sync_to_dingpan: int = None,
        used_quota: int = None,
        group_owner_user_id: str = None,
        status: int = None,
        template_id: str = None,
        template_name: str = None,
    ):
        self.open_conversation_id = open_conversation_id
        self.group_owner = group_owner
        self.group_name = group_name
        self.group_admins_count = group_admins_count
        self.group_members_count = group_members_count
        self.group_create_time = group_create_time
        self.group_last_active_time = group_last_active_time
        self.group_last_active_time_show = group_last_active_time_show
        self.sync_to_dingpan = sync_to_dingpan
        self.used_quota = used_quota
        self.group_owner_user_id = group_owner_user_id
        self.status = status
        self.template_id = template_id
        self.template_name = template_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.group_owner is not None:
            result['groupOwner'] = self.group_owner
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.group_admins_count is not None:
            result['groupAdminsCount'] = self.group_admins_count
        if self.group_members_count is not None:
            result['groupMembersCount'] = self.group_members_count
        if self.group_create_time is not None:
            result['groupCreateTime'] = self.group_create_time
        if self.group_last_active_time is not None:
            result['groupLastActiveTime'] = self.group_last_active_time
        if self.group_last_active_time_show is not None:
            result['groupLastActiveTimeShow'] = self.group_last_active_time_show
        if self.sync_to_dingpan is not None:
            result['syncToDingpan'] = self.sync_to_dingpan
        if self.used_quota is not None:
            result['usedQuota'] = self.used_quota
        if self.group_owner_user_id is not None:
            result['groupOwnerUserId'] = self.group_owner_user_id
        if self.status is not None:
            result['status'] = self.status
        if self.template_id is not None:
            result['templateId'] = self.template_id
        if self.template_name is not None:
            result['templateName'] = self.template_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('groupOwner') is not None:
            self.group_owner = m.get('groupOwner')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('groupAdminsCount') is not None:
            self.group_admins_count = m.get('groupAdminsCount')
        if m.get('groupMembersCount') is not None:
            self.group_members_count = m.get('groupMembersCount')
        if m.get('groupCreateTime') is not None:
            self.group_create_time = m.get('groupCreateTime')
        if m.get('groupLastActiveTime') is not None:
            self.group_last_active_time = m.get('groupLastActiveTime')
        if m.get('groupLastActiveTimeShow') is not None:
            self.group_last_active_time_show = m.get('groupLastActiveTimeShow')
        if m.get('syncToDingpan') is not None:
            self.sync_to_dingpan = m.get('syncToDingpan')
        if m.get('usedQuota') is not None:
            self.used_quota = m.get('usedQuota')
        if m.get('groupOwnerUserId') is not None:
            self.group_owner_user_id = m.get('groupOwnerUserId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        if m.get('templateName') is not None:
            self.template_name = m.get('templateName')
        return self


class SearchOrgInnerGroupInfoResponseBody(TeaModel):
    def __init__(
        self,
        total_count: int = None,
        item_count: int = None,
        items: List[SearchOrgInnerGroupInfoResponseBodyItems] = None,
    ):
        self.total_count = total_count
        self.item_count = item_count
        self.items = items

    def validate(self):
        if self.items:
            for k in self.items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        if self.item_count is not None:
            result['itemCount'] = self.item_count
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        if m.get('itemCount') is not None:
            self.item_count = m.get('itemCount')
        self.items = []
        if m.get('items') is not None:
            for k in m.get('items'):
                temp_model = SearchOrgInnerGroupInfoResponseBodyItems()
                self.items.append(temp_model.from_map(k))
        return self


class SearchOrgInnerGroupInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SearchOrgInnerGroupInfoResponseBody = None,
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
            temp_model = SearchOrgInnerGroupInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateTrustedDeviceHeaders(TeaModel):
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


class CreateTrustedDeviceRequest(TeaModel):
    def __init__(
        self,
        user_id: str = None,
        platform: str = None,
        mac_address: str = None,
        status: int = None,
    ):
        # 员工userId
        self.user_id = user_id
        # 平台类型
        self.platform = platform
        # mac地址
        self.mac_address = mac_address
        # 设备状态
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.platform is not None:
            result['platform'] = self.platform
        if self.mac_address is not None:
            result['macAddress'] = self.mac_address
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('platform') is not None:
            self.platform = m.get('platform')
        if m.get('macAddress') is not None:
            self.mac_address = m.get('macAddress')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class CreateTrustedDeviceResponseBody(TeaModel):
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


class CreateTrustedDeviceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateTrustedDeviceResponseBody = None,
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
            temp_model = CreateTrustedDeviceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetGroupActiveInfoHeaders(TeaModel):
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


class GetGroupActiveInfoRequest(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
        ding_group_id: str = None,
        page_number: int = None,
        page_size: int = None,
    ):
        # 统计日期
        self.stat_date = stat_date
        # 钉钉群组id
        self.ding_group_id = ding_group_id
        # 分页起始页
        self.page_number = page_number
        # 分页大小
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        if self.ding_group_id is not None:
            result['dingGroupId'] = self.ding_group_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        if m.get('dingGroupId') is not None:
            self.ding_group_id = m.get('dingGroupId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class GetGroupActiveInfoResponseBodyData(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
        ding_group_id: str = None,
        group_create_time: str = None,
        group_create_user_id: str = None,
        group_create_user_name: str = None,
        group_name: str = None,
        group_type: int = None,
        group_user_cnt_1d: int = None,
        send_message_user_cnt_1d: int = None,
        send_message_cnt_1d: int = None,
        open_conv_uv_1d: int = None,
    ):
        # 统计时间
        self.stat_date = stat_date
        # 群组id
        self.ding_group_id = ding_group_id
        # 群组创建时间
        self.group_create_time = group_create_time
        # 群组创建用户id
        self.group_create_user_id = group_create_user_id
        # 群组创建用户姓名
        self.group_create_user_name = group_create_user_name
        # 群名称
        self.group_name = group_name
        # 群类型：1-全员群，2-部门群，3-（其他）内部群，4-场景群
        self.group_type = group_type
        # 最近1天群人数
        self.group_user_cnt_1d = group_user_cnt_1d
        # 最近1天发消息人数
        self.send_message_user_cnt_1d = send_message_user_cnt_1d
        # 最近1天发消息次数
        self.send_message_cnt_1d = send_message_cnt_1d
        # 最近1天打开群人数
        self.open_conv_uv_1d = open_conv_uv_1d

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        if self.ding_group_id is not None:
            result['dingGroupId'] = self.ding_group_id
        if self.group_create_time is not None:
            result['groupCreateTime'] = self.group_create_time
        if self.group_create_user_id is not None:
            result['groupCreateUserId'] = self.group_create_user_id
        if self.group_create_user_name is not None:
            result['groupCreateUserName'] = self.group_create_user_name
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.group_type is not None:
            result['groupType'] = self.group_type
        if self.group_user_cnt_1d is not None:
            result['groupUserCnt1d'] = self.group_user_cnt_1d
        if self.send_message_user_cnt_1d is not None:
            result['sendMessageUserCnt1d'] = self.send_message_user_cnt_1d
        if self.send_message_cnt_1d is not None:
            result['sendMessageCnt1d'] = self.send_message_cnt_1d
        if self.open_conv_uv_1d is not None:
            result['openConvUv1d'] = self.open_conv_uv_1d
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        if m.get('dingGroupId') is not None:
            self.ding_group_id = m.get('dingGroupId')
        if m.get('groupCreateTime') is not None:
            self.group_create_time = m.get('groupCreateTime')
        if m.get('groupCreateUserId') is not None:
            self.group_create_user_id = m.get('groupCreateUserId')
        if m.get('groupCreateUserName') is not None:
            self.group_create_user_name = m.get('groupCreateUserName')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('groupType') is not None:
            self.group_type = m.get('groupType')
        if m.get('groupUserCnt1d') is not None:
            self.group_user_cnt_1d = m.get('groupUserCnt1d')
        if m.get('sendMessageUserCnt1d') is not None:
            self.send_message_user_cnt_1d = m.get('sendMessageUserCnt1d')
        if m.get('sendMessageCnt1d') is not None:
            self.send_message_cnt_1d = m.get('sendMessageCnt1d')
        if m.get('openConvUv1d') is not None:
            self.open_conv_uv_1d = m.get('openConvUv1d')
        return self


class GetGroupActiveInfoResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetGroupActiveInfoResponseBodyData] = None,
        total_count: int = None,
    ):
        self.data = data
        self.total_count = total_count

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
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetGroupActiveInfoResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetGroupActiveInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetGroupActiveInfoResponseBody = None,
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
            temp_model = GetGroupActiveInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetCommentListHeaders(TeaModel):
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


class GetCommentListRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
    ):
        # 分页起始页
        self.page_number = page_number
        # 分页大小
        self.page_size = page_size

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class GetCommentListResponseBodyData(TeaModel):
    def __init__(
        self,
        comment_user_name: str = None,
        content: str = None,
        comment_time: float = None,
        comment_id: str = None,
    ):
        # 评论者姓名
        self.comment_user_name = comment_user_name
        # 评论内容
        self.content = content
        # 评论时间
        self.comment_time = comment_time
        # 评论ID
        self.comment_id = comment_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.comment_user_name is not None:
            result['commentUserName'] = self.comment_user_name
        if self.content is not None:
            result['content'] = self.content
        if self.comment_time is not None:
            result['commentTime'] = self.comment_time
        if self.comment_id is not None:
            result['commentId'] = self.comment_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commentUserName') is not None:
            self.comment_user_name = m.get('commentUserName')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('commentTime') is not None:
            self.comment_time = m.get('commentTime')
        if m.get('commentId') is not None:
            self.comment_id = m.get('commentId')
        return self


class GetCommentListResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetCommentListResponseBodyData] = None,
        total_count: int = None,
    ):
        self.data = data
        self.total_count = total_count

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
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetCommentListResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetCommentListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetCommentListResponseBody = None,
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
            temp_model = GetCommentListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetPartnerTypeByParentIdHeaders(TeaModel):
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


class GetPartnerTypeByParentIdResponseBodyData(TeaModel):
    def __init__(
        self,
        type_id: float = None,
        type_name: str = None,
    ):
        # 自标签id
        self.type_id = type_id
        # 子标签名
        self.type_name = type_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type_id is not None:
            result['typeId'] = self.type_id
        if self.type_name is not None:
            result['typeName'] = self.type_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('typeId') is not None:
            self.type_id = m.get('typeId')
        if m.get('typeName') is not None:
            self.type_name = m.get('typeName')
        return self


class GetPartnerTypeByParentIdResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetPartnerTypeByParentIdResponseBodyData] = None,
    ):
        # 子标签列表
        self.data = data

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetPartnerTypeByParentIdResponseBodyData()
                self.data.append(temp_model.from_map(k))
        return self


class GetPartnerTypeByParentIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetPartnerTypeByParentIdResponseBody = None,
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
            temp_model = GetPartnerTypeByParentIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SetDeptPartnerTypeAndNumHeaders(TeaModel):
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


class SetDeptPartnerTypeAndNumRequest(TeaModel):
    def __init__(
        self,
        dept_id: str = None,
        partner_num: str = None,
        label_ids: List[str] = None,
    ):
        # 部门id
        self.dept_id = dept_id
        # 伙伴编码
        self.partner_num = partner_num
        # 伙伴类型id列表
        self.label_ids = label_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.partner_num is not None:
            result['partnerNum'] = self.partner_num
        if self.label_ids is not None:
            result['labelIds'] = self.label_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('partnerNum') is not None:
            self.partner_num = m.get('partnerNum')
        if m.get('labelIds') is not None:
            self.label_ids = m.get('labelIds')
        return self


class SetDeptPartnerTypeAndNumResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        return self


