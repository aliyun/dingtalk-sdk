# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class QueryStatisticsDataHeaders(TeaModel):
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


class QueryStatisticsDataRequest(TeaModel):
    def __init__(
        self,
        start_time: int = None,
        end_time: int = None,
        op_user_id: str = None,
        section_index_list: List[int] = None,
        teacher_user_ids: List[str] = None,
    ):
        # startTime
        self.start_time = start_time
        # endTime
        self.end_time = end_time
        # opUserId
        self.op_user_id = op_user_id
        # 课程节次列表
        self.section_index_list = section_index_list
        # 老师UserIds
        self.teacher_user_ids = teacher_user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.section_index_list is not None:
            result['sectionIndexList'] = self.section_index_list
        if self.teacher_user_ids is not None:
            result['teacherUserIds'] = self.teacher_user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('sectionIndexList') is not None:
            self.section_index_list = m.get('sectionIndexList')
        if m.get('teacherUserIds') is not None:
            self.teacher_user_ids = m.get('teacherUserIds')
        return self


class QueryStatisticsDataResponseBodyResult(TeaModel):
    def __init__(
        self,
        user_id: str = None,
        user_name: str = None,
        class_id: int = None,
        subject_name: int = None,
        course_hours: float = None,
        course_count: int = None,
    ):
        # 用户id
        self.user_id = user_id
        # 用户名称
        self.user_name = user_name
        # 班级id
        self.class_id = class_id
        # 学科名称
        self.subject_name = subject_name
        # 总学时
        self.course_hours = course_hours
        # 总课程数
        self.course_count = course_count

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_name is not None:
            result['userName'] = self.user_name
        if self.class_id is not None:
            result['classId'] = self.class_id
        if self.subject_name is not None:
            result['subjectName'] = self.subject_name
        if self.course_hours is not None:
            result['courseHours'] = self.course_hours
        if self.course_count is not None:
            result['courseCount'] = self.course_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        if m.get('subjectName') is not None:
            self.subject_name = m.get('subjectName')
        if m.get('courseHours') is not None:
            self.course_hours = m.get('courseHours')
        if m.get('courseCount') is not None:
            self.course_count = m.get('courseCount')
        return self


class QueryStatisticsDataResponseBody(TeaModel):
    def __init__(
        self,
        result: List[QueryStatisticsDataResponseBodyResult] = None,
    ):
        # result
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
                temp_model = QueryStatisticsDataResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class QueryStatisticsDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryStatisticsDataResponseBody = None,
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
            temp_model = QueryStatisticsDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryAllSubjectsFromClassScheduleHeaders(TeaModel):
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


class QueryAllSubjectsFromClassScheduleRequest(TeaModel):
    def __init__(
        self,
        class_ids: List[int] = None,
        op_user_id: str = None,
        period_code: str = None,
    ):
        # 班级ID。
        self.class_ids = class_ids
        # 操作者的userid。
        self.op_user_id = op_user_id
        # 学段编码：KINDERGARTEN：小学 PRIMARY_SCHOOL：小学 MODDLE_SCHOOL： 初中 HIGH_SCHOOL： 高中 UNIVERSITY：大学 NOT_SCHOOL：无学段
        self.period_code = period_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_ids is not None:
            result['classIds'] = self.class_ids
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.period_code is not None:
            result['periodCode'] = self.period_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classIds') is not None:
            self.class_ids = m.get('classIds')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('periodCode') is not None:
            self.period_code = m.get('periodCode')
        return self


class QueryAllSubjectsFromClassScheduleShrinkRequest(TeaModel):
    def __init__(
        self,
        class_ids_shrink: str = None,
        op_user_id: str = None,
        period_code: str = None,
    ):
        # 班级ID。
        self.class_ids_shrink = class_ids_shrink
        # 操作者的userid。
        self.op_user_id = op_user_id
        # 学段编码：KINDERGARTEN：小学 PRIMARY_SCHOOL：小学 MODDLE_SCHOOL： 初中 HIGH_SCHOOL： 高中 UNIVERSITY：大学 NOT_SCHOOL：无学段
        self.period_code = period_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_ids_shrink is not None:
            result['classIds'] = self.class_ids_shrink
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.period_code is not None:
            result['periodCode'] = self.period_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classIds') is not None:
            self.class_ids_shrink = m.get('classIds')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('periodCode') is not None:
            self.period_code = m.get('periodCode')
        return self


class QueryAllSubjectsFromClassScheduleResponseBodyResultExtTeacherList(TeaModel):
    def __init__(
        self,
        user_id: str = None,
        name: str = None,
        avator: str = None,
        uid: int = None,
    ):
        # 老师的userid。
        self.user_id = user_id
        # 老师名称。
        self.name = name
        # 老师的头像url
        self.avator = avator
        # 老师的uid。
        self.uid = uid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.name is not None:
            result['name'] = self.name
        if self.avator is not None:
            result['avator'] = self.avator
        if self.uid is not None:
            result['uid'] = self.uid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('avator') is not None:
            self.avator = m.get('avator')
        if m.get('uid') is not None:
            self.uid = m.get('uid')
        return self


class QueryAllSubjectsFromClassScheduleResponseBodyResultExt(TeaModel):
    def __init__(
        self,
        font_color: str = None,
        background_color: str = None,
        class_id: int = None,
        teacher_list: List[QueryAllSubjectsFromClassScheduleResponseBodyResultExtTeacherList] = None,
    ):
        # 学科字体颜色
        self.font_color = font_color
        # 学科背景颜色
        self.background_color = background_color
        # 班级id。
        self.class_id = class_id
        # 老师列表
        self.teacher_list = teacher_list

    def validate(self):
        if self.teacher_list:
            for k in self.teacher_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.font_color is not None:
            result['fontColor'] = self.font_color
        if self.background_color is not None:
            result['backgroundColor'] = self.background_color
        if self.class_id is not None:
            result['classId'] = self.class_id
        result['teacherList'] = []
        if self.teacher_list is not None:
            for k in self.teacher_list:
                result['teacherList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fontColor') is not None:
            self.font_color = m.get('fontColor')
        if m.get('backgroundColor') is not None:
            self.background_color = m.get('backgroundColor')
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        self.teacher_list = []
        if m.get('teacherList') is not None:
            for k in m.get('teacherList'):
                temp_model = QueryAllSubjectsFromClassScheduleResponseBodyResultExtTeacherList()
                self.teacher_list.append(temp_model.from_map(k))
        return self


class QueryAllSubjectsFromClassScheduleResponseBodyResult(TeaModel):
    def __init__(
        self,
        subject_name: str = None,
        subject_code: str = None,
        period_code: str = None,
        creator_org_id: int = None,
        ext: QueryAllSubjectsFromClassScheduleResponseBodyResultExt = None,
    ):
        # 学科名称。
        self.subject_name = subject_name
        # 学科code。
        self.subject_code = subject_code
        # 学段编码：  KINDERGARTEN：小学 PRIMARY_SCHOOL：小学 MODDLE_SCHOOL： 初中 HIGH_SCHOOL： 高中 UNIVERSITY：大学 NOT_SCHOOL：无学段
        self.period_code = period_code
        # creatorOrgId
        self.creator_org_id = creator_org_id
        # 拓展信息
        self.ext = ext

    def validate(self):
        if self.ext:
            self.ext.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.subject_name is not None:
            result['subjectName'] = self.subject_name
        if self.subject_code is not None:
            result['subjectCode'] = self.subject_code
        if self.period_code is not None:
            result['periodCode'] = self.period_code
        if self.creator_org_id is not None:
            result['creatorOrgId'] = self.creator_org_id
        if self.ext is not None:
            result['ext'] = self.ext.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('subjectName') is not None:
            self.subject_name = m.get('subjectName')
        if m.get('subjectCode') is not None:
            self.subject_code = m.get('subjectCode')
        if m.get('periodCode') is not None:
            self.period_code = m.get('periodCode')
        if m.get('creatorOrgId') is not None:
            self.creator_org_id = m.get('creatorOrgId')
        if m.get('ext') is not None:
            temp_model = QueryAllSubjectsFromClassScheduleResponseBodyResultExt()
            self.ext = temp_model.from_map(m['ext'])
        return self


class QueryAllSubjectsFromClassScheduleResponseBody(TeaModel):
    def __init__(
        self,
        result: List[QueryAllSubjectsFromClassScheduleResponseBodyResult] = None,
    ):
        # 查询结果。
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
                temp_model = QueryAllSubjectsFromClassScheduleResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class QueryAllSubjectsFromClassScheduleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryAllSubjectsFromClassScheduleResponseBody = None,
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
            temp_model = QueryAllSubjectsFromClassScheduleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryClassScheduleConfigHeaders(TeaModel):
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


class QueryClassScheduleConfigRequest(TeaModel):
    def __init__(
        self,
        class_ids: List[int] = None,
        op_user_id: str = None,
    ):
        # 课程id列表
        self.class_ids = class_ids
        # 操作者的UserID
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_ids is not None:
            result['classIds'] = self.class_ids
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classIds') is not None:
            self.class_ids = m.get('classIds')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class QueryClassScheduleConfigShrinkRequest(TeaModel):
    def __init__(
        self,
        class_ids_shrink: str = None,
        op_user_id: str = None,
    ):
        # 课程id列表
        self.class_ids_shrink = class_ids_shrink
        # 操作者的UserID
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_ids_shrink is not None:
            result['classIds'] = self.class_ids_shrink
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classIds') is not None:
            self.class_ids_shrink = m.get('classIds')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class QueryClassScheduleConfigResponseBodyResultStart(TeaModel):
    def __init__(
        self,
        year: int = None,
        month: int = None,
        day_of_month: int = None,
    ):
        # 年份
        self.year = year
        # 月份
        self.month = month
        # 一个月中的第几天
        self.day_of_month = day_of_month

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.year is not None:
            result['year'] = self.year
        if self.month is not None:
            result['month'] = self.month
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('year') is not None:
            self.year = m.get('year')
        if m.get('month') is not None:
            self.month = m.get('month')
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        return self


class QueryClassScheduleConfigResponseBodyResultEnd(TeaModel):
    def __init__(
        self,
        year: int = None,
        month: int = None,
        day_of_month: int = None,
    ):
        # 年份
        self.year = year
        # 月份
        self.month = month
        # 一个月中第几天
        self.day_of_month = day_of_month

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.year is not None:
            result['year'] = self.year
        if self.month is not None:
            result['month'] = self.month
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('year') is not None:
            self.year = m.get('year')
        if m.get('month') is not None:
            self.month = m.get('month')
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        return self


class QueryClassScheduleConfigResponseBodyResultSectionModelsStart(TeaModel):
    def __init__(
        self,
        min: int = None,
        hour: int = None,
    ):
        # 分钟
        self.min = min
        # 小时
        self.hour = hour

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.min is not None:
            result['min'] = self.min
        if self.hour is not None:
            result['hour'] = self.hour
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('min') is not None:
            self.min = m.get('min')
        if m.get('hour') is not None:
            self.hour = m.get('hour')
        return self


class QueryClassScheduleConfigResponseBodyResultSectionModelsEnd(TeaModel):
    def __init__(
        self,
        min: int = None,
        hour: int = None,
    ):
        # 分钟
        self.min = min
        # 小时
        self.hour = hour

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.min is not None:
            result['min'] = self.min
        if self.hour is not None:
            result['hour'] = self.hour
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('min') is not None:
            self.min = m.get('min')
        if m.get('hour') is not None:
            self.hour = m.get('hour')
        return self


class QueryClassScheduleConfigResponseBodyResultSectionModels(TeaModel):
    def __init__(
        self,
        section_type: str = None,
        start: QueryClassScheduleConfigResponseBodyResultSectionModelsStart = None,
        section_index: int = None,
        end: QueryClassScheduleConfigResponseBodyResultSectionModelsEnd = None,
        section_name: str = None,
    ):
        # 节次类型：COURSE/REST
        self.section_type = section_type
        # 开始时间（时分）
        self.start = start
        # 节次设置
        self.section_index = section_index
        # 结束时间
        self.end = end
        # 节次名称
        self.section_name = section_name

    def validate(self):
        if self.start:
            self.start.validate()
        if self.end:
            self.end.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.section_type is not None:
            result['sectionType'] = self.section_type
        if self.start is not None:
            result['start'] = self.start.to_map()
        if self.section_index is not None:
            result['sectionIndex'] = self.section_index
        if self.end is not None:
            result['end'] = self.end.to_map()
        if self.section_name is not None:
            result['sectionName'] = self.section_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sectionType') is not None:
            self.section_type = m.get('sectionType')
        if m.get('start') is not None:
            temp_model = QueryClassScheduleConfigResponseBodyResultSectionModelsStart()
            self.start = temp_model.from_map(m['start'])
        if m.get('sectionIndex') is not None:
            self.section_index = m.get('sectionIndex')
        if m.get('end') is not None:
            temp_model = QueryClassScheduleConfigResponseBodyResultSectionModelsEnd()
            self.end = temp_model.from_map(m['end'])
        if m.get('sectionName') is not None:
            self.section_name = m.get('sectionName')
        return self


class QueryClassScheduleConfigResponseBodyResult(TeaModel):
    def __init__(
        self,
        class_id: int = None,
        start: QueryClassScheduleConfigResponseBodyResultStart = None,
        end: QueryClassScheduleConfigResponseBodyResultEnd = None,
        section_models: List[QueryClassScheduleConfigResponseBodyResultSectionModels] = None,
    ):
        # 班级的Id.
        self.class_id = class_id
        # 开始时间
        self.start = start
        self.end = end
        # 节次模型。
        self.section_models = section_models

    def validate(self):
        if self.start:
            self.start.validate()
        if self.end:
            self.end.validate()
        if self.section_models:
            for k in self.section_models:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_id is not None:
            result['classId'] = self.class_id
        if self.start is not None:
            result['start'] = self.start.to_map()
        if self.end is not None:
            result['end'] = self.end.to_map()
        result['sectionModels'] = []
        if self.section_models is not None:
            for k in self.section_models:
                result['sectionModels'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        if m.get('start') is not None:
            temp_model = QueryClassScheduleConfigResponseBodyResultStart()
            self.start = temp_model.from_map(m['start'])
        if m.get('end') is not None:
            temp_model = QueryClassScheduleConfigResponseBodyResultEnd()
            self.end = temp_model.from_map(m['end'])
        self.section_models = []
        if m.get('sectionModels') is not None:
            for k in m.get('sectionModels'):
                temp_model = QueryClassScheduleConfigResponseBodyResultSectionModels()
                self.section_models.append(temp_model.from_map(k))
        return self


class QueryClassScheduleConfigResponseBody(TeaModel):
    def __init__(
        self,
        result: List[QueryClassScheduleConfigResponseBodyResult] = None,
    ):
        # 查询结果
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
                temp_model = QueryClassScheduleConfigResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class QueryClassScheduleConfigResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryClassScheduleConfigResponseBody = None,
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
            temp_model = QueryClassScheduleConfigResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetDefaultChildHeaders(TeaModel):
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


class GetDefaultChildResponseBodyBindStudents(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        staff_id: str = None,
        class_id: int = None,
        period: str = None,
    ):
        self.corp_id = corp_id
        self.staff_id = staff_id
        self.class_id = class_id
        self.period = period

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.staff_id is not None:
            result['staffId'] = self.staff_id
        if self.class_id is not None:
            result['classId'] = self.class_id
        if self.period is not None:
            result['period'] = self.period
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('staffId') is not None:
            self.staff_id = m.get('staffId')
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        if m.get('period') is not None:
            self.period = m.get('period')
        return self


class GetDefaultChildResponseBody(TeaModel):
    def __init__(
        self,
        name: str = None,
        nick: str = None,
        avatar: str = None,
        union_id: str = None,
        period: str = None,
        grade: int = None,
        bind_students: List[GetDefaultChildResponseBodyBindStudents] = None,
    ):
        self.name = name
        self.nick = nick
        self.avatar = avatar
        self.union_id = union_id
        self.period = period
        self.grade = grade
        self.bind_students = bind_students

    def validate(self):
        if self.bind_students:
            for k in self.bind_students:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.nick is not None:
            result['nick'] = self.nick
        if self.avatar is not None:
            result['avatar'] = self.avatar
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.period is not None:
            result['period'] = self.period
        if self.grade is not None:
            result['grade'] = self.grade
        result['bindStudents'] = []
        if self.bind_students is not None:
            for k in self.bind_students:
                result['bindStudents'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('nick') is not None:
            self.nick = m.get('nick')
        if m.get('avatar') is not None:
            self.avatar = m.get('avatar')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('grade') is not None:
            self.grade = m.get('grade')
        self.bind_students = []
        if m.get('bindStudents') is not None:
            for k in m.get('bindStudents'):
                temp_model = GetDefaultChildResponseBodyBindStudents()
                self.bind_students.append(temp_model.from_map(k))
        return self


class GetDefaultChildResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetDefaultChildResponseBody = None,
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
            temp_model = GetDefaultChildResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetOpenCoursesHeaders(TeaModel):
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


class GetOpenCoursesRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
    ):
        # 分页起始, 起始值为0
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


class GetOpenCoursesResponseBodyCourseList(TeaModel):
    def __init__(
        self,
        course_id: str = None,
        title: str = None,
        feed_type: int = None,
        teacher_name: str = None,
        cover_url: str = None,
        start_time: int = None,
        jump_url: str = None,
        teacher_id: str = None,
    ):
        # 课程id
        self.course_id = course_id
        # 课程标题
        self.title = title
        # 课程类型: 0-直播 2-视频内容
        self.feed_type = feed_type
        # 老师名称
        self.teacher_name = teacher_name
        # 封面图片地址
        self.cover_url = cover_url
        # 课程开始时间
        self.start_time = start_time
        # 课程观看地址
        self.jump_url = jump_url
        # 老师的userId
        self.teacher_id = teacher_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_id is not None:
            result['courseId'] = self.course_id
        if self.title is not None:
            result['title'] = self.title
        if self.feed_type is not None:
            result['feedType'] = self.feed_type
        if self.teacher_name is not None:
            result['teacherName'] = self.teacher_name
        if self.cover_url is not None:
            result['coverUrl'] = self.cover_url
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.jump_url is not None:
            result['jumpUrl'] = self.jump_url
        if self.teacher_id is not None:
            result['teacherId'] = self.teacher_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseId') is not None:
            self.course_id = m.get('courseId')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('feedType') is not None:
            self.feed_type = m.get('feedType')
        if m.get('teacherName') is not None:
            self.teacher_name = m.get('teacherName')
        if m.get('coverUrl') is not None:
            self.cover_url = m.get('coverUrl')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('jumpUrl') is not None:
            self.jump_url = m.get('jumpUrl')
        if m.get('teacherId') is not None:
            self.teacher_id = m.get('teacherId')
        return self


class GetOpenCoursesResponseBody(TeaModel):
    def __init__(
        self,
        total_count: int = None,
        course_list: List[GetOpenCoursesResponseBodyCourseList] = None,
    ):
        # 总记录数
        self.total_count = total_count
        self.course_list = course_list

    def validate(self):
        if self.course_list:
            for k in self.course_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        result['courseList'] = []
        if self.course_list is not None:
            for k in self.course_list:
                result['courseList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        self.course_list = []
        if m.get('courseList') is not None:
            for k in m.get('courseList'):
                temp_model = GetOpenCoursesResponseBodyCourseList()
                self.course_list.append(temp_model.from_map(k))
        return self


class GetOpenCoursesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetOpenCoursesResponseBody = None,
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
            temp_model = GetOpenCoursesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CourseSchedulingComplimentNoticeHeaders(TeaModel):
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


class CourseSchedulingComplimentNoticeRequest(TeaModel):
    def __init__(
        self,
        op_user_id: str = None,
    ):
        # opUserId
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class CourseSchedulingComplimentNoticeResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 通知课程导入完成是否成功。
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


class CourseSchedulingComplimentNoticeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CourseSchedulingComplimentNoticeResponseBody = None,
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
            temp_model = CourseSchedulingComplimentNoticeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchCreateHeaders(TeaModel):
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


class BatchCreateRequestDataCardRuleItemParamList(TeaModel):
    def __init__(
        self,
        card_task_code: str = None,
        relation_id: str = None,
        card_rule_attr: str = None,
        daily_dubbing: int = None,
        relation_title: str = None,
        relation_url: str = None,
    ):
        # 卡片taskCode
        self.card_task_code = card_task_code
        # 关联的外部Id
        self.relation_id = relation_id
        # 扩展属性，存放配音难度、每日配音视频的url等
        self.card_rule_attr = card_rule_attr
        # 每日配音数
        self.daily_dubbing = daily_dubbing
        # 关联内容标题（会在打卡详页页展示）
        self.relation_title = relation_title
        # relationUrl（点击打卡内容后跳转的链接）（点击卡片内容后跳转的链接）
        self.relation_url = relation_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_task_code is not None:
            result['cardTaskCode'] = self.card_task_code
        if self.relation_id is not None:
            result['relationId'] = self.relation_id
        if self.card_rule_attr is not None:
            result['cardRuleAttr'] = self.card_rule_attr
        if self.daily_dubbing is not None:
            result['dailyDubbing'] = self.daily_dubbing
        if self.relation_title is not None:
            result['relationTitle'] = self.relation_title
        if self.relation_url is not None:
            result['relationUrl'] = self.relation_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardTaskCode') is not None:
            self.card_task_code = m.get('cardTaskCode')
        if m.get('relationId') is not None:
            self.relation_id = m.get('relationId')
        if m.get('cardRuleAttr') is not None:
            self.card_rule_attr = m.get('cardRuleAttr')
        if m.get('dailyDubbing') is not None:
            self.daily_dubbing = m.get('dailyDubbing')
        if m.get('relationTitle') is not None:
            self.relation_title = m.get('relationTitle')
        if m.get('relationUrl') is not None:
            self.relation_url = m.get('relationUrl')
        return self


class BatchCreateRequestDataOrgClassStudentGroupListClassListStudents(TeaModel):
    def __init__(
        self,
        name: str = None,
        staff_id: str = None,
    ):
        # 学生名称
        self.name = name
        # 学生id
        self.staff_id = staff_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.staff_id is not None:
            result['staffId'] = self.staff_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('staffId') is not None:
            self.staff_id = m.get('staffId')
        return self


class BatchCreateRequestDataOrgClassStudentGroupListClassList(TeaModel):
    def __init__(
        self,
        class_id: int = None,
        class_name: str = None,
        students: List[BatchCreateRequestDataOrgClassStudentGroupListClassListStudents] = None,
    ):
        # 班级id
        self.class_id = class_id
        # 班级名称
        self.class_name = class_name
        # 班级学生
        self.students = students

    def validate(self):
        if self.students:
            for k in self.students:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_id is not None:
            result['classId'] = self.class_id
        if self.class_name is not None:
            result['className'] = self.class_name
        result['students'] = []
        if self.students is not None:
            for k in self.students:
                result['students'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        if m.get('className') is not None:
            self.class_name = m.get('className')
        self.students = []
        if m.get('students') is not None:
            for k in m.get('students'):
                temp_model = BatchCreateRequestDataOrgClassStudentGroupListClassListStudents()
                self.students.append(temp_model.from_map(k))
        return self


class BatchCreateRequestDataOrgClassStudentGroupList(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        class_list: List[BatchCreateRequestDataOrgClassStudentGroupListClassList] = None,
    ):
        # 组织id
        self.corp_id = corp_id
        # 班级列表
        self.class_list = class_list

    def validate(self):
        if self.class_list:
            for k in self.class_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        result['classList'] = []
        if self.class_list is not None:
            for k in self.class_list:
                result['classList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        self.class_list = []
        if m.get('classList') is not None:
            for k in m.get('classList'):
                temp_model = BatchCreateRequestDataOrgClassStudentGroupListClassList()
                self.class_list.append(temp_model.from_map(k))
        return self


class BatchCreateRequestData(TeaModel):
    def __init__(
        self,
        can_reissue_card: bool = None,
        card_cycle: int = None,
        card_frequency: List[int] = None,
        card_rule_item_param_list: List[BatchCreateRequestDataCardRuleItemParamList] = None,
        class_ids: List[str] = None,
        class_names: List[str] = None,
        content: str = None,
        effect_date: int = None,
        medias: str = None,
        need_metering: str = None,
        org_class_student_group_list: List[BatchCreateRequestDataOrgClassStudentGroupList] = None,
        remind_hour: int = None,
        remind_minute: int = None,
        target_role: str = None,
        template_id: int = None,
        title: str = None,
        unit_of_measurement: str = None,
    ):
        # 是否可以补卡
        self.can_reissue_card = can_reissue_card
        # 打卡周期,单位为天
        self.card_cycle = card_cycle
        # 打卡的频次设置："cardFrequency":[             1,//周天             2,//周一             3,//周二             4,//周三             5,//周四             6,//周五             7//周六         ]
        self.card_frequency = card_frequency
        self.card_rule_item_param_list = card_rule_item_param_list
        # 班级列表
        self.class_ids = class_ids
        # 班级名称列表
        self.class_names = class_names
        # 打卡的内容
        self.content = content
        # 卡片生效时间
        self.effect_date = effect_date
        # 上传相册，图片，录音，盯盘的信息
        self.medias = medias
        # 计量开启
        self.need_metering = need_metering
        self.org_class_student_group_list = org_class_student_group_list
        # 提醒时间（小时）
        self.remind_hour = remind_hour
        # 提醒时间（分钟）
        self.remind_minute = remind_minute
        # 默认：student_guardian
        self.target_role = target_role
        # 打卡模板id
        self.template_id = template_id
        # 卡片标题
        self.title = title
        # 计量单位
        self.unit_of_measurement = unit_of_measurement

    def validate(self):
        if self.card_rule_item_param_list:
            for k in self.card_rule_item_param_list:
                if k:
                    k.validate()
        if self.org_class_student_group_list:
            for k in self.org_class_student_group_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.can_reissue_card is not None:
            result['canReissueCard'] = self.can_reissue_card
        if self.card_cycle is not None:
            result['cardCycle'] = self.card_cycle
        if self.card_frequency is not None:
            result['cardFrequency'] = self.card_frequency
        result['cardRuleItemParamList'] = []
        if self.card_rule_item_param_list is not None:
            for k in self.card_rule_item_param_list:
                result['cardRuleItemParamList'].append(k.to_map() if k else None)
        if self.class_ids is not None:
            result['classIds'] = self.class_ids
        if self.class_names is not None:
            result['classNames'] = self.class_names
        if self.content is not None:
            result['content'] = self.content
        if self.effect_date is not None:
            result['effectDate'] = self.effect_date
        if self.medias is not None:
            result['medias'] = self.medias
        if self.need_metering is not None:
            result['needMetering'] = self.need_metering
        result['orgClassStudentGroupList'] = []
        if self.org_class_student_group_list is not None:
            for k in self.org_class_student_group_list:
                result['orgClassStudentGroupList'].append(k.to_map() if k else None)
        if self.remind_hour is not None:
            result['remindHour'] = self.remind_hour
        if self.remind_minute is not None:
            result['remindMinute'] = self.remind_minute
        if self.target_role is not None:
            result['targetRole'] = self.target_role
        if self.template_id is not None:
            result['templateId'] = self.template_id
        if self.title is not None:
            result['title'] = self.title
        if self.unit_of_measurement is not None:
            result['unitOfMeasurement'] = self.unit_of_measurement
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('canReissueCard') is not None:
            self.can_reissue_card = m.get('canReissueCard')
        if m.get('cardCycle') is not None:
            self.card_cycle = m.get('cardCycle')
        if m.get('cardFrequency') is not None:
            self.card_frequency = m.get('cardFrequency')
        self.card_rule_item_param_list = []
        if m.get('cardRuleItemParamList') is not None:
            for k in m.get('cardRuleItemParamList'):
                temp_model = BatchCreateRequestDataCardRuleItemParamList()
                self.card_rule_item_param_list.append(temp_model.from_map(k))
        if m.get('classIds') is not None:
            self.class_ids = m.get('classIds')
        if m.get('classNames') is not None:
            self.class_names = m.get('classNames')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('effectDate') is not None:
            self.effect_date = m.get('effectDate')
        if m.get('medias') is not None:
            self.medias = m.get('medias')
        if m.get('needMetering') is not None:
            self.need_metering = m.get('needMetering')
        self.org_class_student_group_list = []
        if m.get('orgClassStudentGroupList') is not None:
            for k in m.get('orgClassStudentGroupList'):
                temp_model = BatchCreateRequestDataOrgClassStudentGroupList()
                self.org_class_student_group_list.append(temp_model.from_map(k))
        if m.get('remindHour') is not None:
            self.remind_hour = m.get('remindHour')
        if m.get('remindMinute') is not None:
            self.remind_minute = m.get('remindMinute')
        if m.get('targetRole') is not None:
            self.target_role = m.get('targetRole')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('unitOfMeasurement') is not None:
            self.unit_of_measurement = m.get('unitOfMeasurement')
        return self


class BatchCreateRequest(TeaModel):
    def __init__(
        self,
        card_biz_code: str = None,
        data: BatchCreateRequestData = None,
        identifier: str = None,
        source_type: str = None,
        userid: str = None,
        ding_corp_id: str = None,
        js_version: int = None,
    ):
        # 卡片业务类型，打卡写死：industry_center
        self.card_biz_code = card_biz_code
        # 卡片详细数据
        self.data = data
        # 卡片幂等唯一键
        self.identifier = identifier
        # isv业务类型
        self.source_type = source_type
        # 老师用户id
        self.userid = userid
        # 老师corpId
        self.ding_corp_id = ding_corp_id
        # 小程序版本号
        self.js_version = js_version

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_biz_code is not None:
            result['cardBizCode'] = self.card_biz_code
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.identifier is not None:
            result['identifier'] = self.identifier
        if self.source_type is not None:
            result['sourceType'] = self.source_type
        if self.userid is not None:
            result['userid'] = self.userid
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.js_version is not None:
            result['jsVersion'] = self.js_version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardBizCode') is not None:
            self.card_biz_code = m.get('cardBizCode')
        if m.get('data') is not None:
            temp_model = BatchCreateRequestData()
            self.data = temp_model.from_map(m['data'])
        if m.get('identifier') is not None:
            self.identifier = m.get('identifier')
        if m.get('sourceType') is not None:
            self.source_type = m.get('sourceType')
        if m.get('userid') is not None:
            self.userid = m.get('userid')
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('jsVersion') is not None:
            self.js_version = m.get('jsVersion')
        return self


class BatchCreateResponseBodyResult(TeaModel):
    def __init__(
        self,
        corp_id_card_id_map: Dict[str, str] = None,
    ):
        self.corp_id_card_id_map = corp_id_card_id_map

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id_card_id_map is not None:
            result['corpIdCardIdMap'] = self.corp_id_card_id_map
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpIdCardIdMap') is not None:
            self.corp_id_card_id_map = m.get('corpIdCardIdMap')
        return self


class BatchCreateResponseBody(TeaModel):
    def __init__(
        self,
        result: BatchCreateResponseBodyResult = None,
    ):
        # result
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
            temp_model = BatchCreateResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class BatchCreateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: BatchCreateResponseBody = None,
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
            temp_model = BatchCreateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class InitCoursesOfClassHeaders(TeaModel):
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


class InitCoursesOfClassRequestCoursesDateModel(TeaModel):
    def __init__(
        self,
        month: int = None,
        year: int = None,
        day_of_month: int = None,
    ):
        # 月份。
        self.month = month
        # 年份。
        self.year = year
        # 每个月的第几天。
        self.day_of_month = day_of_month

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.month is not None:
            result['month'] = self.month
        if self.year is not None:
            result['year'] = self.year
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('month') is not None:
            self.month = m.get('month')
        if m.get('year') is not None:
            self.year = m.get('year')
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        return self


class InitCoursesOfClassRequestCoursesSectionModel(TeaModel):
    def __init__(
        self,
        section_index: int = None,
        section_name: str = None,
    ):
        # 节次序列号。
        self.section_index = section_index
        # 节次名称。
        self.section_name = section_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.section_index is not None:
            result['sectionIndex'] = self.section_index
        if self.section_name is not None:
            result['sectionName'] = self.section_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sectionIndex') is not None:
            self.section_index = m.get('sectionIndex')
        if m.get('sectionName') is not None:
            self.section_name = m.get('sectionName')
        return self


class InitCoursesOfClassRequestCourses(TeaModel):
    def __init__(
        self,
        teacher_staff_ids: List[str] = None,
        course_name: str = None,
        date_model: InitCoursesOfClassRequestCoursesDateModel = None,
        section_model: InitCoursesOfClassRequestCoursesSectionModel = None,
        creator_name: str = None,
        location: str = None,
    ):
        # 老师的staffId。
        self.teacher_staff_ids = teacher_staff_ids
        # 课程名称。
        self.course_name = course_name
        # 上课时间。
        self.date_model = date_model
        # 课程节次。
        self.section_model = section_model
        # 创建者名称。
        self.creator_name = creator_name
        # 上课地点
        self.location = location

    def validate(self):
        if self.date_model:
            self.date_model.validate()
        if self.section_model:
            self.section_model.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.teacher_staff_ids is not None:
            result['teacherStaffIds'] = self.teacher_staff_ids
        if self.course_name is not None:
            result['courseName'] = self.course_name
        if self.date_model is not None:
            result['dateModel'] = self.date_model.to_map()
        if self.section_model is not None:
            result['sectionModel'] = self.section_model.to_map()
        if self.creator_name is not None:
            result['creatorName'] = self.creator_name
        if self.location is not None:
            result['location'] = self.location
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('teacherStaffIds') is not None:
            self.teacher_staff_ids = m.get('teacherStaffIds')
        if m.get('courseName') is not None:
            self.course_name = m.get('courseName')
        if m.get('dateModel') is not None:
            temp_model = InitCoursesOfClassRequestCoursesDateModel()
            self.date_model = temp_model.from_map(m['dateModel'])
        if m.get('sectionModel') is not None:
            temp_model = InitCoursesOfClassRequestCoursesSectionModel()
            self.section_model = temp_model.from_map(m['sectionModel'])
        if m.get('creatorName') is not None:
            self.creator_name = m.get('creatorName')
        if m.get('location') is not None:
            self.location = m.get('location')
        return self


class InitCoursesOfClassRequestSectionConfigSectionModelsStart(TeaModel):
    def __init__(
        self,
        min: int = None,
        hour: int = None,
    ):
        # 分钟
        self.min = min
        # 小时
        self.hour = hour

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.min is not None:
            result['min'] = self.min
        if self.hour is not None:
            result['hour'] = self.hour
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('min') is not None:
            self.min = m.get('min')
        if m.get('hour') is not None:
            self.hour = m.get('hour')
        return self


class InitCoursesOfClassRequestSectionConfigSectionModelsEnd(TeaModel):
    def __init__(
        self,
        min: int = None,
        hour: int = None,
    ):
        # 分钟
        self.min = min
        # 小时
        self.hour = hour

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.min is not None:
            result['min'] = self.min
        if self.hour is not None:
            result['hour'] = self.hour
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('min') is not None:
            self.min = m.get('min')
        if m.get('hour') is not None:
            self.hour = m.get('hour')
        return self


class InitCoursesOfClassRequestSectionConfigSectionModels(TeaModel):
    def __init__(
        self,
        section_type: str = None,
        start: InitCoursesOfClassRequestSectionConfigSectionModelsStart = None,
        section_index: int = None,
        end: InitCoursesOfClassRequestSectionConfigSectionModelsEnd = None,
    ):
        # 节次类型枚举：COURSE/REST
        self.section_type = section_type
        # 开始时间
        self.start = start
        # 第几节。
        self.section_index = section_index
        # 结束时间
        self.end = end

    def validate(self):
        if self.start:
            self.start.validate()
        if self.end:
            self.end.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.section_type is not None:
            result['sectionType'] = self.section_type
        if self.start is not None:
            result['start'] = self.start.to_map()
        if self.section_index is not None:
            result['sectionIndex'] = self.section_index
        if self.end is not None:
            result['end'] = self.end.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sectionType') is not None:
            self.section_type = m.get('sectionType')
        if m.get('start') is not None:
            temp_model = InitCoursesOfClassRequestSectionConfigSectionModelsStart()
            self.start = temp_model.from_map(m['start'])
        if m.get('sectionIndex') is not None:
            self.section_index = m.get('sectionIndex')
        if m.get('end') is not None:
            temp_model = InitCoursesOfClassRequestSectionConfigSectionModelsEnd()
            self.end = temp_model.from_map(m['end'])
        return self


class InitCoursesOfClassRequestSectionConfigStart(TeaModel):
    def __init__(
        self,
        month: int = None,
        year: int = None,
        day_of_month: int = None,
    ):
        # 月份。
        self.month = month
        # 年份。
        self.year = year
        # 每个月的第几天。
        self.day_of_month = day_of_month

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.month is not None:
            result['month'] = self.month
        if self.year is not None:
            result['year'] = self.year
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('month') is not None:
            self.month = m.get('month')
        if m.get('year') is not None:
            self.year = m.get('year')
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        return self


class InitCoursesOfClassRequestSectionConfigEnd(TeaModel):
    def __init__(
        self,
        month: int = None,
        year: int = None,
        day_of_month: int = None,
    ):
        # 月份。
        self.month = month
        # 年份。
        self.year = year
        # 每个月的第几天。
        self.day_of_month = day_of_month

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.month is not None:
            result['month'] = self.month
        if self.year is not None:
            result['year'] = self.year
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('month') is not None:
            self.month = m.get('month')
        if m.get('year') is not None:
            self.year = m.get('year')
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        return self


class InitCoursesOfClassRequestSectionConfig(TeaModel):
    def __init__(
        self,
        section_models: List[InitCoursesOfClassRequestSectionConfigSectionModels] = None,
        start: InitCoursesOfClassRequestSectionConfigStart = None,
        end: InitCoursesOfClassRequestSectionConfigEnd = None,
    ):
        # 节次模型
        self.section_models = section_models
        # 课程表开始时间（精确到日）
        self.start = start
        # 课程表结束开始时间（精确到日）
        self.end = end

    def validate(self):
        if self.section_models:
            for k in self.section_models:
                if k:
                    k.validate()
        if self.start:
            self.start.validate()
        if self.end:
            self.end.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['sectionModels'] = []
        if self.section_models is not None:
            for k in self.section_models:
                result['sectionModels'].append(k.to_map() if k else None)
        if self.start is not None:
            result['start'] = self.start.to_map()
        if self.end is not None:
            result['end'] = self.end.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.section_models = []
        if m.get('sectionModels') is not None:
            for k in m.get('sectionModels'):
                temp_model = InitCoursesOfClassRequestSectionConfigSectionModels()
                self.section_models.append(temp_model.from_map(k))
        if m.get('start') is not None:
            temp_model = InitCoursesOfClassRequestSectionConfigStart()
            self.start = temp_model.from_map(m['start'])
        if m.get('end') is not None:
            temp_model = InitCoursesOfClassRequestSectionConfigEnd()
            self.end = temp_model.from_map(m['end'])
        return self


class InitCoursesOfClassRequest(TeaModel):
    def __init__(
        self,
        courses: List[InitCoursesOfClassRequestCourses] = None,
        section_config: InitCoursesOfClassRequestSectionConfig = None,
        op_user_id: str = None,
    ):
        # 课程设置。
        self.courses = courses
        # 节次设置
        self.section_config = section_config
        # 操作人的userid。
        self.op_user_id = op_user_id

    def validate(self):
        if self.courses:
            for k in self.courses:
                if k:
                    k.validate()
        if self.section_config:
            self.section_config.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['courses'] = []
        if self.courses is not None:
            for k in self.courses:
                result['courses'].append(k.to_map() if k else None)
        if self.section_config is not None:
            result['sectionConfig'] = self.section_config.to_map()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.courses = []
        if m.get('courses') is not None:
            for k in m.get('courses'):
                temp_model = InitCoursesOfClassRequestCourses()
                self.courses.append(temp_model.from_map(k))
        if m.get('sectionConfig') is not None:
            temp_model = InitCoursesOfClassRequestSectionConfig()
            self.section_config = temp_model.from_map(m['sectionConfig'])
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class InitCoursesOfClassResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 初始化是否成功。
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


class InitCoursesOfClassResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: InitCoursesOfClassResponseBody = None,
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
            temp_model = InitCoursesOfClassResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteDeptHeaders(TeaModel):
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


class DeleteDeptRequest(TeaModel):
    def __init__(
        self,
        operator: str = None,
    ):
        # 钉钉企业管理员员工ID
        self.operator = operator

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator is not None:
            result['operator'] = self.operator
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        return self


class DeleteDeptResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        # success
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


class DeleteDeptResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DeleteDeptResponseBody = None,
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
            temp_model = DeleteDeptResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteGuardianHeaders(TeaModel):
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


class DeleteGuardianRequest(TeaModel):
    def __init__(
        self,
        stu_id: str = None,
        operator: str = None,
    ):
        # 学生ID
        self.stu_id = stu_id
        # 钉钉企业管理员员工ID
        self.operator = operator

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stu_id is not None:
            result['stuId'] = self.stu_id
        if self.operator is not None:
            result['operator'] = self.operator
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('stuId') is not None:
            self.stu_id = m.get('stuId')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        return self


class DeleteGuardianResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        # success
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


class DeleteGuardianResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DeleteGuardianResponseBody = None,
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
            temp_model = DeleteGuardianResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class InsertSectionConfigHeaders(TeaModel):
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


class InsertSectionConfigRequestSectionModelsStart(TeaModel):
    def __init__(
        self,
        min: int = None,
        hour: int = None,
    ):
        # 分钟
        self.min = min
        # 小时
        self.hour = hour

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.min is not None:
            result['min'] = self.min
        if self.hour is not None:
            result['hour'] = self.hour
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('min') is not None:
            self.min = m.get('min')
        if m.get('hour') is not None:
            self.hour = m.get('hour')
        return self


class InsertSectionConfigRequestSectionModelsEnd(TeaModel):
    def __init__(
        self,
        min: int = None,
        hour: int = None,
    ):
        # 分钟
        self.min = min
        # 小时
        self.hour = hour

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.min is not None:
            result['min'] = self.min
        if self.hour is not None:
            result['hour'] = self.hour
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('min') is not None:
            self.min = m.get('min')
        if m.get('hour') is not None:
            self.hour = m.get('hour')
        return self


class InsertSectionConfigRequestSectionModels(TeaModel):
    def __init__(
        self,
        section_type: str = None,
        start: InsertSectionConfigRequestSectionModelsStart = None,
        section_index: int = None,
        end: InsertSectionConfigRequestSectionModelsEnd = None,
        section_name: str = None,
    ):
        # 节次类型
        self.section_type = section_type
        # 开始时间
        self.start = start
        # 节次序号
        self.section_index = section_index
        # 结束时间
        self.end = end
        # 节次名称
        self.section_name = section_name

    def validate(self):
        if self.start:
            self.start.validate()
        if self.end:
            self.end.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.section_type is not None:
            result['sectionType'] = self.section_type
        if self.start is not None:
            result['start'] = self.start.to_map()
        if self.section_index is not None:
            result['sectionIndex'] = self.section_index
        if self.end is not None:
            result['end'] = self.end.to_map()
        if self.section_name is not None:
            result['sectionName'] = self.section_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sectionType') is not None:
            self.section_type = m.get('sectionType')
        if m.get('start') is not None:
            temp_model = InsertSectionConfigRequestSectionModelsStart()
            self.start = temp_model.from_map(m['start'])
        if m.get('sectionIndex') is not None:
            self.section_index = m.get('sectionIndex')
        if m.get('end') is not None:
            temp_model = InsertSectionConfigRequestSectionModelsEnd()
            self.end = temp_model.from_map(m['end'])
        if m.get('sectionName') is not None:
            self.section_name = m.get('sectionName')
        return self


class InsertSectionConfigRequestStart(TeaModel):
    def __init__(
        self,
        month: int = None,
        year: int = None,
        day_of_month: int = None,
    ):
        # 月份
        self.month = month
        # 年份
        self.year = year
        # 一月中的第几天
        self.day_of_month = day_of_month

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.month is not None:
            result['month'] = self.month
        if self.year is not None:
            result['year'] = self.year
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('month') is not None:
            self.month = m.get('month')
        if m.get('year') is not None:
            self.year = m.get('year')
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        return self


class InsertSectionConfigRequestEnd(TeaModel):
    def __init__(
        self,
        month: int = None,
        year: int = None,
        day_of_month: int = None,
    ):
        # 月份
        self.month = month
        # 年份
        self.year = year
        # 一月中的第几天
        self.day_of_month = day_of_month

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.month is not None:
            result['month'] = self.month
        if self.year is not None:
            result['year'] = self.year
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('month') is not None:
            self.month = m.get('month')
        if m.get('year') is not None:
            self.year = m.get('year')
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        return self


class InsertSectionConfigRequest(TeaModel):
    def __init__(
        self,
        section_models: List[InsertSectionConfigRequestSectionModels] = None,
        start: InsertSectionConfigRequestStart = None,
        end: InsertSectionConfigRequestEnd = None,
        schedule_name: str = None,
        op_user_id: str = None,
    ):
        # 节次模型
        self.section_models = section_models
        # 开始日期
        self.start = start
        # 结束日期
        self.end = end
        # 课程表名称
        self.schedule_name = schedule_name
        # 操作人的userid。
        self.op_user_id = op_user_id

    def validate(self):
        if self.section_models:
            for k in self.section_models:
                if k:
                    k.validate()
        if self.start:
            self.start.validate()
        if self.end:
            self.end.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['sectionModels'] = []
        if self.section_models is not None:
            for k in self.section_models:
                result['sectionModels'].append(k.to_map() if k else None)
        if self.start is not None:
            result['start'] = self.start.to_map()
        if self.end is not None:
            result['end'] = self.end.to_map()
        if self.schedule_name is not None:
            result['scheduleName'] = self.schedule_name
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.section_models = []
        if m.get('sectionModels') is not None:
            for k in m.get('sectionModels'):
                temp_model = InsertSectionConfigRequestSectionModels()
                self.section_models.append(temp_model.from_map(k))
        if m.get('start') is not None:
            temp_model = InsertSectionConfigRequestStart()
            self.start = temp_model.from_map(m['start'])
        if m.get('end') is not None:
            temp_model = InsertSectionConfigRequestEnd()
            self.end = temp_model.from_map(m['end'])
        if m.get('scheduleName') is not None:
            self.schedule_name = m.get('scheduleName')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class InsertSectionConfigResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 初始化是否成功。
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


class InsertSectionConfigResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: InsertSectionConfigResponseBody = None,
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
            temp_model = InsertSectionConfigResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteTeacherHeaders(TeaModel):
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


class DeleteTeacherRequest(TeaModel):
    def __init__(
        self,
        adviser: int = None,
        operator: str = None,
    ):
        # 是否班主任；1:班主任；0:非班主任
        self.adviser = adviser
        # 钉钉企业管理员员工ID
        self.operator = operator

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.adviser is not None:
            result['adviser'] = self.adviser
        if self.operator is not None:
            result['operator'] = self.operator
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('adviser') is not None:
            self.adviser = m.get('adviser')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        return self


class DeleteTeacherResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        # success
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


class DeleteTeacherResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DeleteTeacherResponseBody = None,
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
            temp_model = DeleteTeacherResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchOrgCreateHWHeaders(TeaModel):
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


class BatchOrgCreateHWRequestOpenSelectItemListClassListStudents(TeaModel):
    def __init__(
        self,
        name: str = None,
        staff_id: str = None,
        avatar: str = None,
    ):
        # 学生姓名
        self.name = name
        # 学生userid
        self.staff_id = staff_id
        # 学生头像
        self.avatar = avatar

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.staff_id is not None:
            result['staffId'] = self.staff_id
        if self.avatar is not None:
            result['avatar'] = self.avatar
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('staffId') is not None:
            self.staff_id = m.get('staffId')
        if m.get('avatar') is not None:
            self.avatar = m.get('avatar')
        return self


class BatchOrgCreateHWRequestOpenSelectItemListClassList(TeaModel):
    def __init__(
        self,
        class_id: str = None,
        class_name: str = None,
        all: bool = None,
        students: List[BatchOrgCreateHWRequestOpenSelectItemListClassListStudents] = None,
    ):
        # 班级id
        self.class_id = class_id
        # 班级名称
        self.class_name = class_name
        # 是否全选
        self.all = all
        # 学生列表
        self.students = students

    def validate(self):
        if self.students:
            for k in self.students:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_id is not None:
            result['classId'] = self.class_id
        if self.class_name is not None:
            result['className'] = self.class_name
        if self.all is not None:
            result['all'] = self.all
        result['students'] = []
        if self.students is not None:
            for k in self.students:
                result['students'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        if m.get('className') is not None:
            self.class_name = m.get('className')
        if m.get('all') is not None:
            self.all = m.get('all')
        self.students = []
        if m.get('students') is not None:
            for k in m.get('students'):
                temp_model = BatchOrgCreateHWRequestOpenSelectItemListClassListStudents()
                self.students.append(temp_model.from_map(k))
        return self


class BatchOrgCreateHWRequestOpenSelectItemList(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        selected_classes_desc: str = None,
        class_list: List[BatchOrgCreateHWRequestOpenSelectItemListClassList] = None,
    ):
        # 组织corpId
        self.corp_id = corp_id
        # 选择内容
        self.selected_classes_desc = selected_classes_desc
        # 班级列表
        self.class_list = class_list

    def validate(self):
        if self.class_list:
            for k in self.class_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.selected_classes_desc is not None:
            result['selectedClassesDesc'] = self.selected_classes_desc
        result['classList'] = []
        if self.class_list is not None:
            for k in self.class_list:
                result['classList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('selectedClassesDesc') is not None:
            self.selected_classes_desc = m.get('selectedClassesDesc')
        self.class_list = []
        if m.get('classList') is not None:
            for k in m.get('classList'):
                temp_model = BatchOrgCreateHWRequestOpenSelectItemListClassList()
                self.class_list.append(temp_model.from_map(k))
        return self


class BatchOrgCreateHWRequest(TeaModel):
    def __init__(
        self,
        hw_media: str = None,
        hw_content: str = None,
        hw_title: str = None,
        course_name: str = None,
        hw_photo: str = None,
        hw_video: str = None,
        teacher_name: str = None,
        teacher_user_id: str = None,
        identifier: str = None,
        attributes: str = None,
        target_role: str = None,
        biz_code: str = None,
        status: str = None,
        scheduled_release: str = None,
        scheduled_time: str = None,
        hw_deadline_open: str = None,
        hw_deadline: int = None,
        hw_type: str = None,
        open_select_item_list: List[BatchOrgCreateHWRequestOpenSelectItemList] = None,
        ding_org_id: int = None,
    ):
        # 作业视频
        self.hw_media = hw_media
        # 作业内容
        self.hw_content = hw_content
        # 作业标题
        self.hw_title = hw_title
        # 作业课程名称
        self.course_name = course_name
        # 作业图片
        self.hw_photo = hw_photo
        # 作业音视频
        self.hw_video = hw_video
        # 老师名称
        self.teacher_name = teacher_name
        # 老师userid
        self.teacher_user_id = teacher_user_id
        # 幂等ID字段
        self.identifier = identifier
        # 扩展属性
        self.attributes = attributes
        # 发送对象
        self.target_role = target_role
        # 业务编码
        self.biz_code = biz_code
        # 状态
        self.status = status
        # 定时调度
        self.scheduled_release = scheduled_release
        # 定时调度时间
        self.scheduled_time = scheduled_time
        # 截止时间开启
        self.hw_deadline_open = hw_deadline_open
        # 截止时间
        self.hw_deadline = hw_deadline
        # 作业类型
        self.hw_type = hw_type
        # 选择跨组织班级
        self.open_select_item_list = open_select_item_list
        # 组织ID
        self.ding_org_id = ding_org_id

    def validate(self):
        if self.open_select_item_list:
            for k in self.open_select_item_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.hw_media is not None:
            result['hwMedia'] = self.hw_media
        if self.hw_content is not None:
            result['hwContent'] = self.hw_content
        if self.hw_title is not None:
            result['hwTitle'] = self.hw_title
        if self.course_name is not None:
            result['courseName'] = self.course_name
        if self.hw_photo is not None:
            result['hwPhoto'] = self.hw_photo
        if self.hw_video is not None:
            result['hwVideo'] = self.hw_video
        if self.teacher_name is not None:
            result['teacherName'] = self.teacher_name
        if self.teacher_user_id is not None:
            result['teacherUserId'] = self.teacher_user_id
        if self.identifier is not None:
            result['identifier'] = self.identifier
        if self.attributes is not None:
            result['attributes'] = self.attributes
        if self.target_role is not None:
            result['targetRole'] = self.target_role
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        if self.status is not None:
            result['status'] = self.status
        if self.scheduled_release is not None:
            result['scheduledRelease'] = self.scheduled_release
        if self.scheduled_time is not None:
            result['scheduledTime'] = self.scheduled_time
        if self.hw_deadline_open is not None:
            result['hwDeadlineOpen'] = self.hw_deadline_open
        if self.hw_deadline is not None:
            result['hwDeadline'] = self.hw_deadline
        if self.hw_type is not None:
            result['hwType'] = self.hw_type
        result['openSelectItemList'] = []
        if self.open_select_item_list is not None:
            for k in self.open_select_item_list:
                result['openSelectItemList'].append(k.to_map() if k else None)
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hwMedia') is not None:
            self.hw_media = m.get('hwMedia')
        if m.get('hwContent') is not None:
            self.hw_content = m.get('hwContent')
        if m.get('hwTitle') is not None:
            self.hw_title = m.get('hwTitle')
        if m.get('courseName') is not None:
            self.course_name = m.get('courseName')
        if m.get('hwPhoto') is not None:
            self.hw_photo = m.get('hwPhoto')
        if m.get('hwVideo') is not None:
            self.hw_video = m.get('hwVideo')
        if m.get('teacherName') is not None:
            self.teacher_name = m.get('teacherName')
        if m.get('teacherUserId') is not None:
            self.teacher_user_id = m.get('teacherUserId')
        if m.get('identifier') is not None:
            self.identifier = m.get('identifier')
        if m.get('attributes') is not None:
            self.attributes = m.get('attributes')
        if m.get('targetRole') is not None:
            self.target_role = m.get('targetRole')
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('scheduledRelease') is not None:
            self.scheduled_release = m.get('scheduledRelease')
        if m.get('scheduledTime') is not None:
            self.scheduled_time = m.get('scheduledTime')
        if m.get('hwDeadlineOpen') is not None:
            self.hw_deadline_open = m.get('hwDeadlineOpen')
        if m.get('hwDeadline') is not None:
            self.hw_deadline = m.get('hwDeadline')
        if m.get('hwType') is not None:
            self.hw_type = m.get('hwType')
        self.open_select_item_list = []
        if m.get('openSelectItemList') is not None:
            for k in m.get('openSelectItemList'):
                temp_model = BatchOrgCreateHWRequestOpenSelectItemList()
                self.open_select_item_list.append(temp_model.from_map(k))
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        return self


class BatchOrgCreateHWResponseBodyResultPublishList(TeaModel):
    def __init__(
        self,
        corpid: str = None,
        hwid: int = None,
    ):
        self.corpid = corpid
        self.hwid = hwid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corpid is not None:
            result['corpid'] = self.corpid
        if self.hwid is not None:
            result['hwid'] = self.hwid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpid') is not None:
            self.corpid = m.get('corpid')
        if m.get('hwid') is not None:
            self.hwid = m.get('hwid')
        return self


class BatchOrgCreateHWResponseBodyResult(TeaModel):
    def __init__(
        self,
        publish_list: List[BatchOrgCreateHWResponseBodyResultPublishList] = None,
    ):
        self.publish_list = publish_list

    def validate(self):
        if self.publish_list:
            for k in self.publish_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['publishList'] = []
        if self.publish_list is not None:
            for k in self.publish_list:
                result['publishList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.publish_list = []
        if m.get('publishList') is not None:
            for k in m.get('publishList'):
                temp_model = BatchOrgCreateHWResponseBodyResultPublishList()
                self.publish_list.append(temp_model.from_map(k))
        return self


class BatchOrgCreateHWResponseBody(TeaModel):
    def __init__(
        self,
        result: BatchOrgCreateHWResponseBodyResult = None,
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
            temp_model = BatchOrgCreateHWResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class BatchOrgCreateHWResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: BatchOrgCreateHWResponseBody = None,
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
            temp_model = BatchOrgCreateHWResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateCustomDeptHeaders(TeaModel):
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


class CreateCustomDeptRequestCustomDept(TeaModel):
    def __init__(
        self,
        type: str = None,
        name: str = None,
    ):
        # 部门类型：custom_campus: 自定义校区；custom_dept: 自定义部门
        self.type = type
        # 自定义校区或部门名称
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class CreateCustomDeptRequest(TeaModel):
    def __init__(
        self,
        custom_dept: CreateCustomDeptRequestCustomDept = None,
        super_id: int = None,
        operator: str = None,
        ding_org_id: int = None,
        ding_token_grant_type: int = None,
        ding_suite_key: str = None,
        ding_oauth_app_id: int = None,
        ding_corp_id: str = None,
        ding_isv_org_id: int = None,
    ):
        self.custom_dept = custom_dept
        # 上级部门ID（type为custom_campus时，必须为-7）
        self.super_id = super_id
        # 钉钉管理员员工ID
        self.operator = operator
        self.ding_org_id = ding_org_id
        self.ding_token_grant_type = ding_token_grant_type
        self.ding_suite_key = ding_suite_key
        self.ding_oauth_app_id = ding_oauth_app_id
        self.ding_corp_id = ding_corp_id
        self.ding_isv_org_id = ding_isv_org_id

    def validate(self):
        if self.custom_dept:
            self.custom_dept.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.custom_dept is not None:
            result['customDept'] = self.custom_dept.to_map()
        if self.super_id is not None:
            result['superId'] = self.super_id
        if self.operator is not None:
            result['operator'] = self.operator
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_oauth_app_id is not None:
            result['dingOauthAppId'] = self.ding_oauth_app_id
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customDept') is not None:
            temp_model = CreateCustomDeptRequestCustomDept()
            self.custom_dept = temp_model.from_map(m['customDept'])
        if m.get('superId') is not None:
            self.super_id = m.get('superId')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingOauthAppId') is not None:
            self.ding_oauth_app_id = m.get('dingOauthAppId')
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        return self


class CreateCustomDeptResponseBodyResult(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
    ):
        # 部门ID
        self.dept_id = dept_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        return self


class CreateCustomDeptResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
        result: CreateCustomDeptResponseBodyResult = None,
    ):
        # success
        self.success = success
        # result
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('result') is not None:
            temp_model = CreateCustomDeptResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class CreateCustomDeptResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateCustomDeptResponseBody = None,
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
            temp_model = CreateCustomDeptResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetOpenCourseDetailHeaders(TeaModel):
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


class GetOpenCourseDetailResponseBodyPushModel(TeaModel):
    def __init__(
        self,
        push_org_name_list: List[str] = None,
        push_role_name_list: List[str] = None,
    ):
        # 参与学校的名称列表
        self.push_org_name_list = push_org_name_list
        # 参与角色的名称列表
        self.push_role_name_list = push_role_name_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.push_org_name_list is not None:
            result['pushOrgNameList'] = self.push_org_name_list
        if self.push_role_name_list is not None:
            result['pushRoleNameList'] = self.push_role_name_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pushOrgNameList') is not None:
            self.push_org_name_list = m.get('pushOrgNameList')
        if m.get('pushRoleNameList') is not None:
            self.push_role_name_list = m.get('pushRoleNameList')
        return self


class GetOpenCourseDetailResponseBody(TeaModel):
    def __init__(
        self,
        course_id: str = None,
        title: str = None,
        course_type: int = None,
        teacher_name: str = None,
        cover_url: str = None,
        start_time: int = None,
        teacher_id: str = None,
        introduction: str = None,
        push_model: GetOpenCourseDetailResponseBodyPushModel = None,
    ):
        # 课程id
        self.course_id = course_id
        # 课程标题
        self.title = title
        # 课程类型: 0-直播 2-视频内容
        self.course_type = course_type
        # 老师名称
        self.teacher_name = teacher_name
        # 封面图片地址
        self.cover_url = cover_url
        # 课程开始时间
        self.start_time = start_time
        # 老师的userId
        self.teacher_id = teacher_id
        # 课程介绍
        self.introduction = introduction
        # 发布详情model
        self.push_model = push_model

    def validate(self):
        if self.push_model:
            self.push_model.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_id is not None:
            result['courseId'] = self.course_id
        if self.title is not None:
            result['title'] = self.title
        if self.course_type is not None:
            result['courseType'] = self.course_type
        if self.teacher_name is not None:
            result['teacherName'] = self.teacher_name
        if self.cover_url is not None:
            result['coverUrl'] = self.cover_url
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.teacher_id is not None:
            result['teacherId'] = self.teacher_id
        if self.introduction is not None:
            result['introduction'] = self.introduction
        if self.push_model is not None:
            result['pushModel'] = self.push_model.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseId') is not None:
            self.course_id = m.get('courseId')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('courseType') is not None:
            self.course_type = m.get('courseType')
        if m.get('teacherName') is not None:
            self.teacher_name = m.get('teacherName')
        if m.get('coverUrl') is not None:
            self.cover_url = m.get('coverUrl')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('teacherId') is not None:
            self.teacher_id = m.get('teacherId')
        if m.get('introduction') is not None:
            self.introduction = m.get('introduction')
        if m.get('pushModel') is not None:
            temp_model = GetOpenCourseDetailResponseBodyPushModel()
            self.push_model = temp_model.from_map(m['pushModel'])
        return self


class GetOpenCourseDetailResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetOpenCourseDetailResponseBody = None,
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
            temp_model = GetOpenCourseDetailResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteStudentHeaders(TeaModel):
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


class DeleteStudentRequest(TeaModel):
    def __init__(
        self,
        operator: str = None,
    ):
        # 钉钉管理员员工ID
        self.operator = operator

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator is not None:
            result['operator'] = self.operator
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        return self


class DeleteStudentResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        # success
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


class DeleteStudentResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DeleteStudentResponseBody = None,
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
            temp_model = DeleteStudentResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryClassScheduleByTimeSchoolHeaders(TeaModel):
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


class QueryClassScheduleByTimeSchoolRequest(TeaModel):
    def __init__(
        self,
        start_time: int = None,
        end_time: int = None,
        op_user_id: str = None,
    ):
        # 开始时间
        self.start_time = start_time
        # 1621676000000
        self.end_time = end_time
        # 1621566000000
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms(TeaModel):
    def __init__(
        self,
        target_id: str = None,
        interact_info: str = None,
    ):
        # 课堂唯一标识
        self.target_id = target_id
        # 交互信息
        self.interact_info = interact_info

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.target_id is not None:
            result['targetId'] = self.target_id
        if self.interact_info is not None:
            result['interactInfo'] = self.interact_info
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('targetId') is not None:
            self.target_id = m.get('targetId')
        if m.get('interactInfo') is not None:
            self.interact_info = m.get('interactInfo')
        return self


class QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels(TeaModel):
    def __init__(
        self,
        user_id: str = None,
        uid: int = None,
        name: str = None,
    ):
        # 用户userid
        self.user_id = user_id
        # 用户uid
        self.uid = uid
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.uid is not None:
            result['uid'] = self.uid
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('uid') is not None:
            self.uid = m.get('uid')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class QueryClassScheduleByTimeSchoolResponseBodyResult(TeaModel):
    def __init__(
        self,
        code: str = None,
        name: str = None,
        introduce: str = None,
        cover_url: str = None,
        start_time: int = None,
        end_time: int = None,
        creator_corp_id: str = None,
        creator_user_id: str = None,
        creator_user_name: str = None,
        teacher_corp_id: str = None,
        teacher_user_id: str = None,
        teacher_user_name: str = None,
        biz_key: str = None,
        subject_code: str = None,
        course_group_code: str = None,
        status: int = None,
        classrooms: List[QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms] = None,
        edu_user_models: List[QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels] = None,
        section_name: str = None,
        section_index: int = None,
        class_id: int = None,
        ext_info: str = None,
    ):
        # 课程编码
        self.code = code
        # 课程名称
        self.name = name
        # 课程介绍
        self.introduce = introduce
        # 课程封面地址
        self.cover_url = cover_url
        # 开始时间
        self.start_time = start_time
        # 结束时间
        self.end_time = end_time
        # 创建者组织id
        self.creator_corp_id = creator_corp_id
        # 创建者UserId
        self.creator_user_id = creator_user_id
        # 创建者UserName
        self.creator_user_name = creator_user_name
        # 老师CorpId
        self.teacher_corp_id = teacher_corp_id
        # 老师UserId
        self.teacher_user_id = teacher_user_id
        # 老师UserName
        self.teacher_user_name = teacher_user_name
        # 业务唯一键
        self.biz_key = biz_key
        # 学科编码
        self.subject_code = subject_code
        # 课程组编码
        self.course_group_code = course_group_code
        # 课程状态
        self.status = status
        # 课堂列表
        self.classrooms = classrooms
        # 课程参与人列表
        self.edu_user_models = edu_user_models
        # 课程编码
        self.section_name = section_name
        # 课程所在节次序列号
        self.section_index = section_index
        # 课程所在班级id
        self.class_id = class_id
        # 课程扩展信息
        self.ext_info = ext_info

    def validate(self):
        if self.classrooms:
            for k in self.classrooms:
                if k:
                    k.validate()
        if self.edu_user_models:
            for k in self.edu_user_models:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.name is not None:
            result['name'] = self.name
        if self.introduce is not None:
            result['introduce'] = self.introduce
        if self.cover_url is not None:
            result['coverUrl'] = self.cover_url
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.creator_corp_id is not None:
            result['creatorCorpId'] = self.creator_corp_id
        if self.creator_user_id is not None:
            result['creatorUserId'] = self.creator_user_id
        if self.creator_user_name is not None:
            result['creatorUserName'] = self.creator_user_name
        if self.teacher_corp_id is not None:
            result['teacherCorpId'] = self.teacher_corp_id
        if self.teacher_user_id is not None:
            result['teacherUserId'] = self.teacher_user_id
        if self.teacher_user_name is not None:
            result['teacherUserName'] = self.teacher_user_name
        if self.biz_key is not None:
            result['bizKey'] = self.biz_key
        if self.subject_code is not None:
            result['subjectCode'] = self.subject_code
        if self.course_group_code is not None:
            result['courseGroupCode'] = self.course_group_code
        if self.status is not None:
            result['status'] = self.status
        result['classrooms'] = []
        if self.classrooms is not None:
            for k in self.classrooms:
                result['classrooms'].append(k.to_map() if k else None)
        result['eduUserModels'] = []
        if self.edu_user_models is not None:
            for k in self.edu_user_models:
                result['eduUserModels'].append(k.to_map() if k else None)
        if self.section_name is not None:
            result['sectionName'] = self.section_name
        if self.section_index is not None:
            result['sectionIndex'] = self.section_index
        if self.class_id is not None:
            result['classId'] = self.class_id
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('introduce') is not None:
            self.introduce = m.get('introduce')
        if m.get('coverUrl') is not None:
            self.cover_url = m.get('coverUrl')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('creatorCorpId') is not None:
            self.creator_corp_id = m.get('creatorCorpId')
        if m.get('creatorUserId') is not None:
            self.creator_user_id = m.get('creatorUserId')
        if m.get('creatorUserName') is not None:
            self.creator_user_name = m.get('creatorUserName')
        if m.get('teacherCorpId') is not None:
            self.teacher_corp_id = m.get('teacherCorpId')
        if m.get('teacherUserId') is not None:
            self.teacher_user_id = m.get('teacherUserId')
        if m.get('teacherUserName') is not None:
            self.teacher_user_name = m.get('teacherUserName')
        if m.get('bizKey') is not None:
            self.biz_key = m.get('bizKey')
        if m.get('subjectCode') is not None:
            self.subject_code = m.get('subjectCode')
        if m.get('courseGroupCode') is not None:
            self.course_group_code = m.get('courseGroupCode')
        if m.get('status') is not None:
            self.status = m.get('status')
        self.classrooms = []
        if m.get('classrooms') is not None:
            for k in m.get('classrooms'):
                temp_model = QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms()
                self.classrooms.append(temp_model.from_map(k))
        self.edu_user_models = []
        if m.get('eduUserModels') is not None:
            for k in m.get('eduUserModels'):
                temp_model = QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels()
                self.edu_user_models.append(temp_model.from_map(k))
        if m.get('sectionName') is not None:
            self.section_name = m.get('sectionName')
        if m.get('sectionIndex') is not None:
            self.section_index = m.get('sectionIndex')
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        return self


class QueryClassScheduleByTimeSchoolResponseBody(TeaModel):
    def __init__(
        self,
        result: List[QueryClassScheduleByTimeSchoolResponseBodyResult] = None,
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
                temp_model = QueryClassScheduleByTimeSchoolResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class QueryClassScheduleByTimeSchoolResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryClassScheduleByTimeSchoolResponseBody = None,
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
            temp_model = QueryClassScheduleByTimeSchoolResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateCoursesOfClassHeaders(TeaModel):
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


class UpdateCoursesOfClassRequestCoursesDateModel(TeaModel):
    def __init__(
        self,
        month: int = None,
        year: int = None,
        day_of_month: int = None,
    ):
        # month
        self.month = month
        # year
        self.year = year
        # dayOfMonth
        self.day_of_month = day_of_month

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.month is not None:
            result['month'] = self.month
        if self.year is not None:
            result['year'] = self.year
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('month') is not None:
            self.month = m.get('month')
        if m.get('year') is not None:
            self.year = m.get('year')
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        return self


class UpdateCoursesOfClassRequestCoursesSectionModel(TeaModel):
    def __init__(
        self,
        section_type: str = None,
        section_index: int = None,
        section_name: str = None,
    ):
        # sectionType
        self.section_type = section_type
        # 节次index
        self.section_index = section_index
        # 节次名称
        self.section_name = section_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.section_type is not None:
            result['sectionType'] = self.section_type
        if self.section_index is not None:
            result['sectionIndex'] = self.section_index
        if self.section_name is not None:
            result['sectionName'] = self.section_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sectionType') is not None:
            self.section_type = m.get('sectionType')
        if m.get('sectionIndex') is not None:
            self.section_index = m.get('sectionIndex')
        if m.get('sectionName') is not None:
            self.section_name = m.get('sectionName')
        return self


class UpdateCoursesOfClassRequestCourses(TeaModel):
    def __init__(
        self,
        teacher_staff_ids: List[str] = None,
        course_name: str = None,
        date_model: UpdateCoursesOfClassRequestCoursesDateModel = None,
        section_model: UpdateCoursesOfClassRequestCoursesSectionModel = None,
        creator_name: str = None,
        location: str = None,
        delete_tag: bool = None,
        course_code: str = None,
        course_group_code: str = None,
    ):
        # 老师Staffid
        self.teacher_staff_ids = teacher_staff_ids
        # 课程名称
        self.course_name = course_name
        # 上课日期
        self.date_model = date_model
        # 节次模型
        self.section_model = section_model
        # 创建者名字
        self.creator_name = creator_name
        # 上课地点
        self.location = location
        # 删除标记：要删除为ture
        self.delete_tag = delete_tag
        # 课程code：删除/更新必填
        self.course_code = course_code
        # 课组code
        self.course_group_code = course_group_code

    def validate(self):
        if self.date_model:
            self.date_model.validate()
        if self.section_model:
            self.section_model.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.teacher_staff_ids is not None:
            result['teacherStaffIds'] = self.teacher_staff_ids
        if self.course_name is not None:
            result['courseName'] = self.course_name
        if self.date_model is not None:
            result['dateModel'] = self.date_model.to_map()
        if self.section_model is not None:
            result['sectionModel'] = self.section_model.to_map()
        if self.creator_name is not None:
            result['creatorName'] = self.creator_name
        if self.location is not None:
            result['location'] = self.location
        if self.delete_tag is not None:
            result['deleteTag'] = self.delete_tag
        if self.course_code is not None:
            result['courseCode'] = self.course_code
        if self.course_group_code is not None:
            result['courseGroupCode'] = self.course_group_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('teacherStaffIds') is not None:
            self.teacher_staff_ids = m.get('teacherStaffIds')
        if m.get('courseName') is not None:
            self.course_name = m.get('courseName')
        if m.get('dateModel') is not None:
            temp_model = UpdateCoursesOfClassRequestCoursesDateModel()
            self.date_model = temp_model.from_map(m['dateModel'])
        if m.get('sectionModel') is not None:
            temp_model = UpdateCoursesOfClassRequestCoursesSectionModel()
            self.section_model = temp_model.from_map(m['sectionModel'])
        if m.get('creatorName') is not None:
            self.creator_name = m.get('creatorName')
        if m.get('location') is not None:
            self.location = m.get('location')
        if m.get('deleteTag') is not None:
            self.delete_tag = m.get('deleteTag')
        if m.get('courseCode') is not None:
            self.course_code = m.get('courseCode')
        if m.get('courseGroupCode') is not None:
            self.course_group_code = m.get('courseGroupCode')
        return self


class UpdateCoursesOfClassRequestSectionConfigSectionModelsStart(TeaModel):
    def __init__(
        self,
        min: int = None,
        hour: int = None,
    ):
        # 分钟
        self.min = min
        # 小时
        self.hour = hour

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.min is not None:
            result['min'] = self.min
        if self.hour is not None:
            result['hour'] = self.hour
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('min') is not None:
            self.min = m.get('min')
        if m.get('hour') is not None:
            self.hour = m.get('hour')
        return self


class UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd(TeaModel):
    def __init__(
        self,
        min: int = None,
        hour: int = None,
    ):
        # 分钟
        self.min = min
        # 小时
        self.hour = hour

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.min is not None:
            result['min'] = self.min
        if self.hour is not None:
            result['hour'] = self.hour
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('min') is not None:
            self.min = m.get('min')
        if m.get('hour') is not None:
            self.hour = m.get('hour')
        return self


class UpdateCoursesOfClassRequestSectionConfigSectionModels(TeaModel):
    def __init__(
        self,
        section_type: str = None,
        start: UpdateCoursesOfClassRequestSectionConfigSectionModelsStart = None,
        section_index: int = None,
        end: UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd = None,
    ):
        # 节次类型枚举：COURSE/REST
        self.section_type = section_type
        # 开始时间
        self.start = start
        # 第几节。
        self.section_index = section_index
        # 结束时间
        self.end = end

    def validate(self):
        if self.start:
            self.start.validate()
        if self.end:
            self.end.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.section_type is not None:
            result['sectionType'] = self.section_type
        if self.start is not None:
            result['start'] = self.start.to_map()
        if self.section_index is not None:
            result['sectionIndex'] = self.section_index
        if self.end is not None:
            result['end'] = self.end.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sectionType') is not None:
            self.section_type = m.get('sectionType')
        if m.get('start') is not None:
            temp_model = UpdateCoursesOfClassRequestSectionConfigSectionModelsStart()
            self.start = temp_model.from_map(m['start'])
        if m.get('sectionIndex') is not None:
            self.section_index = m.get('sectionIndex')
        if m.get('end') is not None:
            temp_model = UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd()
            self.end = temp_model.from_map(m['end'])
        return self


class UpdateCoursesOfClassRequestSectionConfig(TeaModel):
    def __init__(
        self,
        section_models: List[UpdateCoursesOfClassRequestSectionConfigSectionModels] = None,
    ):
        # 节次模型
        self.section_models = section_models

    def validate(self):
        if self.section_models:
            for k in self.section_models:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['sectionModels'] = []
        if self.section_models is not None:
            for k in self.section_models:
                result['sectionModels'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.section_models = []
        if m.get('sectionModels') is not None:
            for k in m.get('sectionModels'):
                temp_model = UpdateCoursesOfClassRequestSectionConfigSectionModels()
                self.section_models.append(temp_model.from_map(k))
        return self


class UpdateCoursesOfClassRequest(TeaModel):
    def __init__(
        self,
        courses: List[UpdateCoursesOfClassRequestCourses] = None,
        section_config: UpdateCoursesOfClassRequestSectionConfig = None,
        op_user_id: str = None,
    ):
        self.courses = courses
        # 节次设置
        self.section_config = section_config
        # 操作者id
        self.op_user_id = op_user_id

    def validate(self):
        if self.courses:
            for k in self.courses:
                if k:
                    k.validate()
        if self.section_config:
            self.section_config.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['courses'] = []
        if self.courses is not None:
            for k in self.courses:
                result['courses'].append(k.to_map() if k else None)
        if self.section_config is not None:
            result['sectionConfig'] = self.section_config.to_map()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.courses = []
        if m.get('courses') is not None:
            for k in m.get('courses'):
                temp_model = UpdateCoursesOfClassRequestCourses()
                self.courses.append(temp_model.from_map(k))
        if m.get('sectionConfig') is not None:
            temp_model = UpdateCoursesOfClassRequestSectionConfig()
            self.section_config = temp_model.from_map(m['sectionConfig'])
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class UpdateCoursesOfClassResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 结果
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


class UpdateCoursesOfClassResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateCoursesOfClassResponseBody = None,
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
            temp_model = UpdateCoursesOfClassResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryTeachSubjectsHeaders(TeaModel):
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


class QueryTeachSubjectsRequest(TeaModel):
    def __init__(
        self,
        class_ids: List[int] = None,
        op_user_id: str = None,
    ):
        # 班级ids
        self.class_ids = class_ids
        # 操作者UserId
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_ids is not None:
            result['classIds'] = self.class_ids
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classIds') is not None:
            self.class_ids = m.get('classIds')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class QueryTeachSubjectsResponseBodyResult(TeaModel):
    def __init__(
        self,
        teacher_name: str = None,
        subject_name: str = None,
        subject_code: str = None,
        period_code: str = None,
        corp_id: str = None,
        teacher_user_id: str = None,
        class_id: int = None,
    ):
        # 老师名称
        self.teacher_name = teacher_name
        # 学科名称
        self.subject_name = subject_name
        # 学科code
        self.subject_code = subject_code
        # 学段code
        self.period_code = period_code
        # 学校corpId
        self.corp_id = corp_id
        # 老师Userid
        self.teacher_user_id = teacher_user_id
        # 班级id
        self.class_id = class_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.teacher_name is not None:
            result['teacherName'] = self.teacher_name
        if self.subject_name is not None:
            result['subjectName'] = self.subject_name
        if self.subject_code is not None:
            result['subjectCode'] = self.subject_code
        if self.period_code is not None:
            result['periodCode'] = self.period_code
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.teacher_user_id is not None:
            result['teacherUserId'] = self.teacher_user_id
        if self.class_id is not None:
            result['classId'] = self.class_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('teacherName') is not None:
            self.teacher_name = m.get('teacherName')
        if m.get('subjectName') is not None:
            self.subject_name = m.get('subjectName')
        if m.get('subjectCode') is not None:
            self.subject_code = m.get('subjectCode')
        if m.get('periodCode') is not None:
            self.period_code = m.get('periodCode')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('teacherUserId') is not None:
            self.teacher_user_id = m.get('teacherUserId')
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        return self


class QueryTeachSubjectsResponseBody(TeaModel):
    def __init__(
        self,
        result: List[QueryTeachSubjectsResponseBodyResult] = None,
    ):
        # 结果
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
                temp_model = QueryTeachSubjectsResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class QueryTeachSubjectsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryTeachSubjectsResponseBody = None,
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
            temp_model = QueryTeachSubjectsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetShareRolesHeaders(TeaModel):
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


class GetShareRolesResponseBodyResult(TeaModel):
    def __init__(
        self,
        share_role_code: str = None,
        share_role_name: str = None,
    ):
        # 角色code
        self.share_role_code = share_role_code
        # 角色名称
        self.share_role_name = share_role_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.share_role_code is not None:
            result['shareRoleCode'] = self.share_role_code
        if self.share_role_name is not None:
            result['shareRoleName'] = self.share_role_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('shareRoleCode') is not None:
            self.share_role_code = m.get('shareRoleCode')
        if m.get('shareRoleName') is not None:
            self.share_role_name = m.get('shareRoleName')
        return self


class GetShareRolesResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetShareRolesResponseBodyResult] = None,
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
                temp_model = GetShareRolesResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetShareRolesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetShareRolesResponseBody = None,
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
            temp_model = GetShareRolesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QuerySubjectTeachersHeaders(TeaModel):
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


class QuerySubjectTeachersRequest(TeaModel):
    def __init__(
        self,
        class_ids: List[int] = None,
        op_user_id: str = None,
        subject_code: str = None,
    ):
        # 班级ids
        self.class_ids = class_ids
        # 操作人id
        self.op_user_id = op_user_id
        # 学科code
        self.subject_code = subject_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_ids is not None:
            result['classIds'] = self.class_ids
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.subject_code is not None:
            result['subjectCode'] = self.subject_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classIds') is not None:
            self.class_ids = m.get('classIds')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('subjectCode') is not None:
            self.subject_code = m.get('subjectCode')
        return self


class QuerySubjectTeachersResponseBodyResult(TeaModel):
    def __init__(
        self,
        teacher_name: str = None,
        subject_name: str = None,
        subject_code: str = None,
        period_code: str = None,
        corp_id: str = None,
        teacher_user_id: str = None,
        class_id: int = None,
    ):
        # 老师名称
        self.teacher_name = teacher_name
        # 学科名称
        self.subject_name = subject_name
        # 学科code
        self.subject_code = subject_code
        # 学段code
        self.period_code = period_code
        # 学校corpId
        self.corp_id = corp_id
        # 老师Userid
        self.teacher_user_id = teacher_user_id
        # 班级id
        self.class_id = class_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.teacher_name is not None:
            result['teacherName'] = self.teacher_name
        if self.subject_name is not None:
            result['subjectName'] = self.subject_name
        if self.subject_code is not None:
            result['subjectCode'] = self.subject_code
        if self.period_code is not None:
            result['periodCode'] = self.period_code
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.teacher_user_id is not None:
            result['teacherUserId'] = self.teacher_user_id
        if self.class_id is not None:
            result['classId'] = self.class_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('teacherName') is not None:
            self.teacher_name = m.get('teacherName')
        if m.get('subjectName') is not None:
            self.subject_name = m.get('subjectName')
        if m.get('subjectCode') is not None:
            self.subject_code = m.get('subjectCode')
        if m.get('periodCode') is not None:
            self.period_code = m.get('periodCode')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('teacherUserId') is not None:
            self.teacher_user_id = m.get('teacherUserId')
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        return self


class QuerySubjectTeachersResponseBody(TeaModel):
    def __init__(
        self,
        result: List[QuerySubjectTeachersResponseBodyResult] = None,
    ):
        # 结果
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
                temp_model = QuerySubjectTeachersResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class QuerySubjectTeachersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QuerySubjectTeachersResponseBody = None,
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
            temp_model = QuerySubjectTeachersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryClassScheduleHeaders(TeaModel):
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


class QueryClassScheduleRequest(TeaModel):
    def __init__(
        self,
        subscriber_type: str = None,
        start_time: int = None,
        end_time: int = None,
        op_user_id: str = None,
        subscriber_ids: List[str] = None,
        section_index_list: List[int] = None,
    ):
        # 订阅者类型：  DEPARTMENT：班级订阅 USER：老师订阅
        self.subscriber_type = subscriber_type
        # 开始时间（unix时间戳）
        self.start_time = start_time
        # 结束时间（unix时间戳）
        self.end_time = end_time
        # 操作者UserId
        self.op_user_id = op_user_id
        # 订阅者的Id。
        self.subscriber_ids = subscriber_ids
        # 查询课程的节次。
        self.section_index_list = section_index_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.subscriber_type is not None:
            result['subscriberType'] = self.subscriber_type
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.subscriber_ids is not None:
            result['subscriberIds'] = self.subscriber_ids
        if self.section_index_list is not None:
            result['sectionIndexList'] = self.section_index_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('subscriberType') is not None:
            self.subscriber_type = m.get('subscriberType')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('subscriberIds') is not None:
            self.subscriber_ids = m.get('subscriberIds')
        if m.get('sectionIndexList') is not None:
            self.section_index_list = m.get('sectionIndexList')
        return self


class QueryClassScheduleResponseBodyConfigStart(TeaModel):
    def __init__(
        self,
        year: int = None,
        month: int = None,
        day_of_month: int = None,
    ):
        # 年份。
        self.year = year
        # 月份。
        self.month = month
        # 一个月中第几天
        self.day_of_month = day_of_month

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.year is not None:
            result['year'] = self.year
        if self.month is not None:
            result['month'] = self.month
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('year') is not None:
            self.year = m.get('year')
        if m.get('month') is not None:
            self.month = m.get('month')
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        return self


class QueryClassScheduleResponseBodyConfigSectionModelsStart(TeaModel):
    def __init__(
        self,
        hour: int = None,
        min: int = None,
    ):
        # 小时。
        self.hour = hour
        # 分钟
        self.min = min

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.hour is not None:
            result['hour'] = self.hour
        if self.min is not None:
            result['min'] = self.min
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hour') is not None:
            self.hour = m.get('hour')
        if m.get('min') is not None:
            self.min = m.get('min')
        return self


class QueryClassScheduleResponseBodyConfigSectionModelsEnd(TeaModel):
    def __init__(
        self,
        hour: int = None,
        min: int = None,
    ):
        # 小时。
        self.hour = hour
        # 分钟。
        self.min = min

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.hour is not None:
            result['hour'] = self.hour
        if self.min is not None:
            result['min'] = self.min
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hour') is not None:
            self.hour = m.get('hour')
        if m.get('min') is not None:
            self.min = m.get('min')
        return self


class QueryClassScheduleResponseBodyConfigSectionModels(TeaModel):
    def __init__(
        self,
        section_name: str = None,
        section_type: str = None,
        section_index: int = None,
        start: QueryClassScheduleResponseBodyConfigSectionModelsStart = None,
        end: QueryClassScheduleResponseBodyConfigSectionModelsEnd = None,
    ):
        # 节次名称。
        self.section_name = section_name
        # 节次类型：  COURSE：上课节次 REST：休息节次
        self.section_type = section_type
        # 节次序列。
        self.section_index = section_index
        # 开始时间（时分级别）。
        self.start = start
        # 结束时间（时分级别）
        self.end = end

    def validate(self):
        if self.start:
            self.start.validate()
        if self.end:
            self.end.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.section_name is not None:
            result['sectionName'] = self.section_name
        if self.section_type is not None:
            result['sectionType'] = self.section_type
        if self.section_index is not None:
            result['sectionIndex'] = self.section_index
        if self.start is not None:
            result['start'] = self.start.to_map()
        if self.end is not None:
            result['end'] = self.end.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sectionName') is not None:
            self.section_name = m.get('sectionName')
        if m.get('sectionType') is not None:
            self.section_type = m.get('sectionType')
        if m.get('sectionIndex') is not None:
            self.section_index = m.get('sectionIndex')
        if m.get('start') is not None:
            temp_model = QueryClassScheduleResponseBodyConfigSectionModelsStart()
            self.start = temp_model.from_map(m['start'])
        if m.get('end') is not None:
            temp_model = QueryClassScheduleResponseBodyConfigSectionModelsEnd()
            self.end = temp_model.from_map(m['end'])
        return self


class QueryClassScheduleResponseBodyConfigEnd(TeaModel):
    def __init__(
        self,
        year: int = None,
        month: int = None,
        day_of_month: int = None,
    ):
        # 年份。
        self.year = year
        # 月份。
        self.month = month
        # 一个月中第几天
        self.day_of_month = day_of_month

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.year is not None:
            result['year'] = self.year
        if self.month is not None:
            result['month'] = self.month
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('year') is not None:
            self.year = m.get('year')
        if m.get('month') is not None:
            self.month = m.get('month')
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        return self


class QueryClassScheduleResponseBodyConfig(TeaModel):
    def __init__(
        self,
        start: QueryClassScheduleResponseBodyConfigStart = None,
        section_models: List[QueryClassScheduleResponseBodyConfigSectionModels] = None,
        end: QueryClassScheduleResponseBodyConfigEnd = None,
    ):
        # 开始时间（到日）。
        self.start = start
        # 节次模型。
        self.section_models = section_models
        # 开始时间（到日）。
        self.end = end

    def validate(self):
        if self.start:
            self.start.validate()
        if self.section_models:
            for k in self.section_models:
                if k:
                    k.validate()
        if self.end:
            self.end.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.start is not None:
            result['start'] = self.start.to_map()
        result['sectionModels'] = []
        if self.section_models is not None:
            for k in self.section_models:
                result['sectionModels'].append(k.to_map() if k else None)
        if self.end is not None:
            result['end'] = self.end.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('start') is not None:
            temp_model = QueryClassScheduleResponseBodyConfigStart()
            self.start = temp_model.from_map(m['start'])
        self.section_models = []
        if m.get('sectionModels') is not None:
            for k in m.get('sectionModels'):
                temp_model = QueryClassScheduleResponseBodyConfigSectionModels()
                self.section_models.append(temp_model.from_map(k))
        if m.get('end') is not None:
            temp_model = QueryClassScheduleResponseBodyConfigEnd()
            self.end = temp_model.from_map(m['end'])
        return self


class QueryClassScheduleResponseBodyCourseDTOSClassrooms(TeaModel):
    def __init__(
        self,
        target_id: str = None,
        interact_info: str = None,
    ):
        # 课堂唯一标识
        self.target_id = target_id
        # 交互信息
        self.interact_info = interact_info

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.target_id is not None:
            result['targetId'] = self.target_id
        if self.interact_info is not None:
            result['interactInfo'] = self.interact_info
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('targetId') is not None:
            self.target_id = m.get('targetId')
        if m.get('interactInfo') is not None:
            self.interact_info = m.get('interactInfo')
        return self


class QueryClassScheduleResponseBodyCourseDTOSEduUserModels(TeaModel):
    def __init__(
        self,
        user_id: str = None,
        uid: int = None,
        name: str = None,
    ):
        # 用户userid
        self.user_id = user_id
        # 用户uid
        self.uid = uid
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.uid is not None:
            result['uid'] = self.uid
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('uid') is not None:
            self.uid = m.get('uid')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class QueryClassScheduleResponseBodyCourseDTOS(TeaModel):
    def __init__(
        self,
        code: str = None,
        name: str = None,
        introduce: str = None,
        cover_url: str = None,
        start_time: int = None,
        end_time: int = None,
        creator_corp_id: str = None,
        creator_user_id: str = None,
        creator_user_name: str = None,
        teacher_corp_id: str = None,
        teacher_user_id: str = None,
        teacher_user_name: str = None,
        subject_code: str = None,
        course_group_code: str = None,
        status: int = None,
        classrooms: List[QueryClassScheduleResponseBodyCourseDTOSClassrooms] = None,
        edu_user_models: List[QueryClassScheduleResponseBodyCourseDTOSEduUserModels] = None,
        section_name: str = None,
        section_index: int = None,
        class_id: int = None,
        ext_info: str = None,
    ):
        # 课程编码
        self.code = code
        # 课程名称
        self.name = name
        # 课程介绍
        self.introduce = introduce
        # 课程封面地址
        self.cover_url = cover_url
        # 开始时间
        self.start_time = start_time
        # 结束时间
        self.end_time = end_time
        # 创建者组织id
        self.creator_corp_id = creator_corp_id
        # 创建者UserId
        self.creator_user_id = creator_user_id
        # 创建者UserName
        self.creator_user_name = creator_user_name
        # 老师CorpId
        self.teacher_corp_id = teacher_corp_id
        # 老师UserId
        self.teacher_user_id = teacher_user_id
        # 老师UserName
        self.teacher_user_name = teacher_user_name
        # 学科编码
        self.subject_code = subject_code
        # 课程组编码
        self.course_group_code = course_group_code
        # 课程状态
        self.status = status
        # 课堂列表
        self.classrooms = classrooms
        # 课程参与人列表
        self.edu_user_models = edu_user_models
        # 课程名称
        self.section_name = section_name
        # 课程所在节次序列号
        self.section_index = section_index
        # 课程所在班级id
        self.class_id = class_id
        # 课程扩展信息
        self.ext_info = ext_info

    def validate(self):
        if self.classrooms:
            for k in self.classrooms:
                if k:
                    k.validate()
        if self.edu_user_models:
            for k in self.edu_user_models:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.name is not None:
            result['name'] = self.name
        if self.introduce is not None:
            result['introduce'] = self.introduce
        if self.cover_url is not None:
            result['coverUrl'] = self.cover_url
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.creator_corp_id is not None:
            result['creatorCorpId'] = self.creator_corp_id
        if self.creator_user_id is not None:
            result['creatorUserId'] = self.creator_user_id
        if self.creator_user_name is not None:
            result['creatorUserName'] = self.creator_user_name
        if self.teacher_corp_id is not None:
            result['teacherCorpId'] = self.teacher_corp_id
        if self.teacher_user_id is not None:
            result['teacherUserId'] = self.teacher_user_id
        if self.teacher_user_name is not None:
            result['teacherUserName'] = self.teacher_user_name
        if self.subject_code is not None:
            result['subjectCode'] = self.subject_code
        if self.course_group_code is not None:
            result['courseGroupCode'] = self.course_group_code
        if self.status is not None:
            result['status'] = self.status
        result['classrooms'] = []
        if self.classrooms is not None:
            for k in self.classrooms:
                result['classrooms'].append(k.to_map() if k else None)
        result['eduUserModels'] = []
        if self.edu_user_models is not None:
            for k in self.edu_user_models:
                result['eduUserModels'].append(k.to_map() if k else None)
        if self.section_name is not None:
            result['sectionName'] = self.section_name
        if self.section_index is not None:
            result['sectionIndex'] = self.section_index
        if self.class_id is not None:
            result['classId'] = self.class_id
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('introduce') is not None:
            self.introduce = m.get('introduce')
        if m.get('coverUrl') is not None:
            self.cover_url = m.get('coverUrl')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('creatorCorpId') is not None:
            self.creator_corp_id = m.get('creatorCorpId')
        if m.get('creatorUserId') is not None:
            self.creator_user_id = m.get('creatorUserId')
        if m.get('creatorUserName') is not None:
            self.creator_user_name = m.get('creatorUserName')
        if m.get('teacherCorpId') is not None:
            self.teacher_corp_id = m.get('teacherCorpId')
        if m.get('teacherUserId') is not None:
            self.teacher_user_id = m.get('teacherUserId')
        if m.get('teacherUserName') is not None:
            self.teacher_user_name = m.get('teacherUserName')
        if m.get('subjectCode') is not None:
            self.subject_code = m.get('subjectCode')
        if m.get('courseGroupCode') is not None:
            self.course_group_code = m.get('courseGroupCode')
        if m.get('status') is not None:
            self.status = m.get('status')
        self.classrooms = []
        if m.get('classrooms') is not None:
            for k in m.get('classrooms'):
                temp_model = QueryClassScheduleResponseBodyCourseDTOSClassrooms()
                self.classrooms.append(temp_model.from_map(k))
        self.edu_user_models = []
        if m.get('eduUserModels') is not None:
            for k in m.get('eduUserModels'):
                temp_model = QueryClassScheduleResponseBodyCourseDTOSEduUserModels()
                self.edu_user_models.append(temp_model.from_map(k))
        if m.get('sectionName') is not None:
            self.section_name = m.get('sectionName')
        if m.get('sectionIndex') is not None:
            self.section_index = m.get('sectionIndex')
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        return self


class QueryClassScheduleResponseBody(TeaModel):
    def __init__(
        self,
        config: QueryClassScheduleResponseBodyConfig = None,
        course_dtos: List[QueryClassScheduleResponseBodyCourseDTOS] = None,
    ):
        # 课表时间节次配置。
        self.config = config
        # 课程列表
        self.course_dtos = course_dtos

    def validate(self):
        if self.config:
            self.config.validate()
        if self.course_dtos:
            for k in self.course_dtos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.config is not None:
            result['config'] = self.config.to_map()
        result['courseDTOS'] = []
        if self.course_dtos is not None:
            for k in self.course_dtos:
                result['courseDTOS'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('config') is not None:
            temp_model = QueryClassScheduleResponseBodyConfig()
            self.config = temp_model.from_map(m['config'])
        self.course_dtos = []
        if m.get('courseDTOS') is not None:
            for k in m.get('courseDTOS'):
                temp_model = QueryClassScheduleResponseBodyCourseDTOS()
                self.course_dtos.append(temp_model.from_map(k))
        return self


class QueryClassScheduleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryClassScheduleResponseBody = None,
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
            temp_model = QueryClassScheduleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateCustomClassHeaders(TeaModel):
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


class CreateCustomClassRequestCustomClass(TeaModel):
    def __init__(
        self,
        name: str = None,
    ):
        # 班级名称
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class CreateCustomClassRequest(TeaModel):
    def __init__(
        self,
        custom_class: CreateCustomClassRequestCustomClass = None,
        super_id: int = None,
        operator: str = None,
        ding_isv_org_id: int = None,
        ding_corp_id: str = None,
        ding_oauth_app_id: int = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
        ding_org_id: int = None,
    ):
        # 班级信息
        self.custom_class = custom_class
        # 上级部门ID
        self.super_id = super_id
        # 钉钉企业管理员工ID
        self.operator = operator
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_corp_id = ding_corp_id
        self.ding_oauth_app_id = ding_oauth_app_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type
        self.ding_org_id = ding_org_id

    def validate(self):
        if self.custom_class:
            self.custom_class.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.custom_class is not None:
            result['customClass'] = self.custom_class.to_map()
        if self.super_id is not None:
            result['superId'] = self.super_id
        if self.operator is not None:
            result['operator'] = self.operator
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.ding_oauth_app_id is not None:
            result['dingOauthAppId'] = self.ding_oauth_app_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customClass') is not None:
            temp_model = CreateCustomClassRequestCustomClass()
            self.custom_class = temp_model.from_map(m['customClass'])
        if m.get('superId') is not None:
            self.super_id = m.get('superId')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('dingOauthAppId') is not None:
            self.ding_oauth_app_id = m.get('dingOauthAppId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        return self


class CreateCustomClassResponseBodyResult(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
    ):
        # 班级ID
        self.dept_id = dept_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        return self


class CreateCustomClassResponseBody(TeaModel):
    def __init__(
        self,
        result: CreateCustomClassResponseBodyResult = None,
        success: bool = None,
    ):
        # result
        self.result = result
        # success
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
            temp_model = CreateCustomClassResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CreateCustomClassResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateCustomClassResponseBody = None,
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
            temp_model = CreateCustomClassResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SearchTeachersHeaders(TeaModel):
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


class SearchTeachersRequest(TeaModel):
    def __init__(
        self,
        name_keyword: str = None,
    ):
        self.name_keyword = name_keyword

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name_keyword is not None:
            result['nameKeyword'] = self.name_keyword
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nameKeyword') is not None:
            self.name_keyword = m.get('nameKeyword')
        return self


class SearchTeachersResponseBodyUsers(TeaModel):
    def __init__(
        self,
        user_id: str = None,
        name: str = None,
        class_id: int = None,
        dept_name: str = None,
    ):
        # 用户ID
        self.user_id = user_id
        # 名称
        self.name = name
        # 所在其中一个班级ID
        self.class_id = class_id
        # 所在其中一个班级名称
        self.dept_name = dept_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.name is not None:
            result['name'] = self.name
        if self.class_id is not None:
            result['classId'] = self.class_id
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        return self


class SearchTeachersResponseBody(TeaModel):
    def __init__(
        self,
        users: List[SearchTeachersResponseBodyUsers] = None,
    ):
        self.users = users

    def validate(self):
        if self.users:
            for k in self.users:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['users'] = []
        if self.users is not None:
            for k in self.users:
                result['users'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.users = []
        if m.get('users') is not None:
            for k in m.get('users'):
                temp_model = SearchTeachersResponseBodyUsers()
                self.users.append(temp_model.from_map(k))
        return self


class SearchTeachersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SearchTeachersResponseBody = None,
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
            temp_model = SearchTeachersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryOrgTypeHeaders(TeaModel):
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


class QueryOrgTypeResponseBody(TeaModel):
    def __init__(
        self,
        org_type: int = None,
    ):
        # 组织类型
        self.org_type = org_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.org_type is not None:
            result['orgType'] = self.org_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('orgType') is not None:
            self.org_type = m.get('orgType')
        return self


class QueryOrgTypeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryOrgTypeResponseBody = None,
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
            temp_model = QueryOrgTypeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetShareRoleMembersHeaders(TeaModel):
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


class GetShareRoleMembersResponseBodyResult(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        member_user_id_list_in_trunk_org: List[str] = None,
    ):
        # 分支组织corpId
        self.corp_id = corp_id
        # 角色成员在主干组织中的userId列表
        self.member_user_id_list_in_trunk_org = member_user_id_list_in_trunk_org

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.member_user_id_list_in_trunk_org is not None:
            result['memberUserIdListInTrunkOrg'] = self.member_user_id_list_in_trunk_org
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('memberUserIdListInTrunkOrg') is not None:
            self.member_user_id_list_in_trunk_org = m.get('memberUserIdListInTrunkOrg')
        return self


class GetShareRoleMembersResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetShareRoleMembersResponseBodyResult] = None,
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
                temp_model = GetShareRoleMembersResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetShareRoleMembersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetShareRoleMembersResponseBody = None,
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
            temp_model = GetShareRoleMembersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


