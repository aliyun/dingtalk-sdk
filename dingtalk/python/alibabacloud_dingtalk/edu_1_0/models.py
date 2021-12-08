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
        subject_code: str = None,
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
        # 学科code
        self.subject_code = subject_code
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
        if self.subject_code is not None:
            result['subjectCode'] = self.subject_code
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
        if m.get('subjectCode') is not None:
            self.subject_code = m.get('subjectCode')
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


class CreateUniversityStudentHeaders(TeaModel):
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


class CreateUniversityStudentRequest(TeaModel):
    def __init__(
        self,
        student_number: str = None,
        class_id: int = None,
        gender: str = None,
        mobile: str = None,
        name: str = None,
        identity_number: str = None,
        op_user_id: str = None,
    ):
        # 学号
        self.student_number = student_number
        # 班级id
        self.class_id = class_id
        # 性别
        self.gender = gender
        # 电话
        self.mobile = mobile
        # 名字
        self.name = name
        # 身份证号
        self.identity_number = identity_number
        # opUserId
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.student_number is not None:
            result['studentNumber'] = self.student_number
        if self.class_id is not None:
            result['classId'] = self.class_id
        if self.gender is not None:
            result['gender'] = self.gender
        if self.mobile is not None:
            result['mobile'] = self.mobile
        if self.name is not None:
            result['name'] = self.name
        if self.identity_number is not None:
            result['identityNumber'] = self.identity_number
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('studentNumber') is not None:
            self.student_number = m.get('studentNumber')
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        if m.get('gender') is not None:
            self.gender = m.get('gender')
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('identityNumber') is not None:
            self.identity_number = m.get('identityNumber')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class CreateUniversityStudentResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 是否成功
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


class CreateUniversityStudentResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateUniversityStudentResponseBody = None,
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
            temp_model = CreateUniversityStudentResponseBody()
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


class CreateInviteUrlHeaders(TeaModel):
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


class CreateInviteUrlRequest(TeaModel):
    def __init__(
        self,
        ding_corp_id: str = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
        ding_oauth_app_id: int = None,
        target_corp_id: str = None,
        auth_code: str = None,
        target_operator: str = None,
        ding_isv_org_id: int = None,
    ):
        self.ding_corp_id = ding_corp_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type
        self.ding_oauth_app_id = ding_oauth_app_id
        self.target_corp_id = target_corp_id
        self.auth_code = auth_code
        self.target_operator = target_operator
        self.ding_isv_org_id = ding_isv_org_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.ding_oauth_app_id is not None:
            result['dingOauthAppId'] = self.ding_oauth_app_id
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        if self.auth_code is not None:
            result['authCode'] = self.auth_code
        if self.target_operator is not None:
            result['targetOperator'] = self.target_operator
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('dingOauthAppId') is not None:
            self.ding_oauth_app_id = m.get('dingOauthAppId')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        if m.get('authCode') is not None:
            self.auth_code = m.get('authCode')
        if m.get('targetOperator') is not None:
            self.target_operator = m.get('targetOperator')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        return self


class CreateInviteUrlResponseBodyResult(TeaModel):
    def __init__(
        self,
        invite_url: str = None,
    ):
        self.invite_url = invite_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.invite_url is not None:
            result['inviteUrl'] = self.invite_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('inviteUrl') is not None:
            self.invite_url = m.get('inviteUrl')
        return self


class CreateInviteUrlResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
        result: CreateInviteUrlResponseBodyResult = None,
    ):
        self.success = success
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
            temp_model = CreateInviteUrlResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class CreateInviteUrlResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateInviteUrlResponseBody = None,
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
            temp_model = CreateInviteUrlResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PollingConfirmStatusHeaders(TeaModel):
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


class PollingConfirmStatusRequest(TeaModel):
    def __init__(
        self,
        ext: str = None,
        isv_code: str = None,
        course_code: str = None,
        op_user_id: str = None,
    ):
        # ext
        self.ext = ext
        # isvCode
        self.isv_code = isv_code
        # courseCode
        self.course_code = course_code
        # opUserId
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ext is not None:
            result['ext'] = self.ext
        if self.isv_code is not None:
            result['isvCode'] = self.isv_code
        if self.course_code is not None:
            result['courseCode'] = self.course_code
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        if m.get('isvCode') is not None:
            self.isv_code = m.get('isvCode')
        if m.get('courseCode') is not None:
            self.course_code = m.get('courseCode')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponseLivePlayInfoList(TeaModel):
    def __init__(
        self,
        live_input_url: str = None,
        live_output_url: str = None,
        live_type: int = None,
        replay_url: str = None,
    ):
        # 推流地址
        self.live_input_url = live_input_url
        # 直播拉流地址
        self.live_output_url = live_output_url
        # 视频流类型
        self.live_type = live_type
        # 视频回放地址
        self.replay_url = replay_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.live_input_url is not None:
            result['liveInputUrl'] = self.live_input_url
        if self.live_output_url is not None:
            result['liveOutputUrl'] = self.live_output_url
        if self.live_type is not None:
            result['liveType'] = self.live_type
        if self.replay_url is not None:
            result['replayUrl'] = self.replay_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('liveInputUrl') is not None:
            self.live_input_url = m.get('liveInputUrl')
        if m.get('liveOutputUrl') is not None:
            self.live_output_url = m.get('liveOutputUrl')
        if m.get('liveType') is not None:
            self.live_type = m.get('liveType')
        if m.get('replayUrl') is not None:
            self.replay_url = m.get('replayUrl')
        return self


class PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponse(TeaModel):
    def __init__(
        self,
        confirm_status: bool = None,
        course_code: str = None,
        live_play_info_list: List[PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponseLivePlayInfoList] = None,
    ):
        # 确认状态
        self.confirm_status = confirm_status
        # 课程编码
        self.course_code = course_code
        self.live_play_info_list = live_play_info_list

    def validate(self):
        if self.live_play_info_list:
            for k in self.live_play_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.confirm_status is not None:
            result['confirmStatus'] = self.confirm_status
        if self.course_code is not None:
            result['courseCode'] = self.course_code
        result['livePlayInfoList'] = []
        if self.live_play_info_list is not None:
            for k in self.live_play_info_list:
                result['livePlayInfoList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('confirmStatus') is not None:
            self.confirm_status = m.get('confirmStatus')
        if m.get('courseCode') is not None:
            self.course_code = m.get('courseCode')
        self.live_play_info_list = []
        if m.get('livePlayInfoList') is not None:
            for k in m.get('livePlayInfoList'):
                temp_model = PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponseLivePlayInfoList()
                self.live_play_info_list.append(temp_model.from_map(k))
        return self


class PollingConfirmStatusResponseBody(TeaModel):
    def __init__(
        self,
        university_polling_course_status_response: PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponse = None,
    ):
        self.university_polling_course_status_response = university_polling_course_status_response

    def validate(self):
        if self.university_polling_course_status_response:
            self.university_polling_course_status_response.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.university_polling_course_status_response is not None:
            result['universityPollingCourseStatusResponse'] = self.university_polling_course_status_response.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('universityPollingCourseStatusResponse') is not None:
            temp_model = PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponse()
            self.university_polling_course_status_response = temp_model.from_map(m['universityPollingCourseStatusResponse'])
        return self


class PollingConfirmStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: PollingConfirmStatusResponseBody = None,
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
            temp_model = PollingConfirmStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateEduAssetSpaceHeaders(TeaModel):
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


class CreateEduAssetSpaceRequest(TeaModel):
    def __init__(
        self,
        space_name: str = None,
        space_desc: str = None,
        space_icon: str = None,
        user_id: str = None,
        biz_code: str = None,
        ding_corp_id: str = None,
        ding_org_id: int = None,
    ):
        # 空间名称
        self.space_name = space_name
        # 空间描述
        self.space_desc = space_desc
        # 空间图标
        self.space_icon = space_icon
        # 用户staffId
        self.user_id = user_id
        # 业务类型编码
        self.biz_code = biz_code
        # 组织corpId
        self.ding_corp_id = ding_corp_id
        # 组织id
        self.ding_org_id = ding_org_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.space_name is not None:
            result['spaceName'] = self.space_name
        if self.space_desc is not None:
            result['spaceDesc'] = self.space_desc
        if self.space_icon is not None:
            result['spaceIcon'] = self.space_icon
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('spaceName') is not None:
            self.space_name = m.get('spaceName')
        if m.get('spaceDesc') is not None:
            self.space_desc = m.get('spaceDesc')
        if m.get('spaceIcon') is not None:
            self.space_icon = m.get('spaceIcon')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        return self


class CreateEduAssetSpaceResponseBody(TeaModel):
    def __init__(
        self,
        space_id: str = None,
        space_name: str = None,
        space_type: str = None,
        quota: int = None,
        used_quota: int = None,
        permission_mode: str = None,
        create_time_millis: int = None,
        modify_time_millis: int = None,
    ):
        # 空间id
        self.space_id = space_id
        # 空间名称
        self.space_name = space_name
        # 空间类型
        self.space_type = space_type
        # 总容量
        self.quota = quota
        # 已使用容量
        self.used_quota = used_quota
        # 权限模型
        self.permission_mode = permission_mode
        # 创建时间戳
        self.create_time_millis = create_time_millis
        # 修改时间戳
        self.modify_time_millis = modify_time_millis

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.space_name is not None:
            result['spaceName'] = self.space_name
        if self.space_type is not None:
            result['spaceType'] = self.space_type
        if self.quota is not None:
            result['quota'] = self.quota
        if self.used_quota is not None:
            result['usedQuota'] = self.used_quota
        if self.permission_mode is not None:
            result['permissionMode'] = self.permission_mode
        if self.create_time_millis is not None:
            result['createTimeMillis'] = self.create_time_millis
        if self.modify_time_millis is not None:
            result['modifyTimeMillis'] = self.modify_time_millis
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('spaceName') is not None:
            self.space_name = m.get('spaceName')
        if m.get('spaceType') is not None:
            self.space_type = m.get('spaceType')
        if m.get('quota') is not None:
            self.quota = m.get('quota')
        if m.get('usedQuota') is not None:
            self.used_quota = m.get('usedQuota')
        if m.get('permissionMode') is not None:
            self.permission_mode = m.get('permissionMode')
        if m.get('createTimeMillis') is not None:
            self.create_time_millis = m.get('createTimeMillis')
        if m.get('modifyTimeMillis') is not None:
            self.modify_time_millis = m.get('modifyTimeMillis')
        return self


class CreateEduAssetSpaceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateEduAssetSpaceResponseBody = None,
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
            temp_model = CreateEduAssetSpaceResponseBody()
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


class DeleteUniversityTeacherHeaders(TeaModel):
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


class DeleteUniversityTeacherRequest(TeaModel):
    def __init__(
        self,
        class_id: int = None,
        role: str = None,
        teacher_user_id: str = None,
        op_user_id: str = None,
    ):
        # 班级id
        self.class_id = class_id
        # 角色
        self.role = role
        # 教师用户ID
        self.teacher_user_id = teacher_user_id
        # opUserId
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_id is not None:
            result['classId'] = self.class_id
        if self.role is not None:
            result['role'] = self.role
        if self.teacher_user_id is not None:
            result['teacherUserId'] = self.teacher_user_id
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        if m.get('role') is not None:
            self.role = m.get('role')
        if m.get('teacherUserId') is not None:
            self.teacher_user_id = m.get('teacherUserId')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class DeleteUniversityTeacherResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 返回结果
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


class DeleteUniversityTeacherResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DeleteUniversityTeacherResponseBody = None,
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
            temp_model = DeleteUniversityTeacherResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteDeviceOrgHeaders(TeaModel):
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


class DeleteDeviceOrgRequest(TeaModel):
    def __init__(
        self,
        device_code: str = None,
        auth_code: str = None,
    ):
        self.device_code = device_code
        self.auth_code = auth_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_code is not None:
            result['deviceCode'] = self.device_code
        if self.auth_code is not None:
            result['authCode'] = self.auth_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceCode') is not None:
            self.device_code = m.get('deviceCode')
        if m.get('authCode') is not None:
            self.auth_code = m.get('authCode')
        return self


class DeleteDeviceOrgResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        # Id of the request
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


class DeleteDeviceOrgResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DeleteDeviceOrgResponseBody = None,
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
            temp_model = DeleteDeviceOrgResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteRemoteClassCourseHeaders(TeaModel):
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


class DeleteRemoteClassCourseRequest(TeaModel):
    def __init__(
        self,
        auth_code: str = None,
    ):
        # 免登码
        self.auth_code = auth_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auth_code is not None:
            result['authCode'] = self.auth_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authCode') is not None:
            self.auth_code = m.get('authCode')
        return self


class DeleteRemoteClassCourseResponseBody(TeaModel):
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


class DeleteRemoteClassCourseResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DeleteRemoteClassCourseResponseBody = None,
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
            temp_model = DeleteRemoteClassCourseResponseBody()
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


class CreateSectionConfigHeaders(TeaModel):
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


class CreateSectionConfigRequestSectionConfigsSectionStartDate(TeaModel):
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


class CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime(TeaModel):
    def __init__(
        self,
        min: int = None,
        hour: int = None,
    ):
        # 分
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


class CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime(TeaModel):
    def __init__(
        self,
        min: int = None,
        hour: int = None,
    ):
        # 分
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


class CreateSectionConfigRequestSectionConfigsSectionModels(TeaModel):
    def __init__(
        self,
        section_type: str = None,
        section_start_time: CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime = None,
        section_index: int = None,
        section_end_time: CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime = None,
        section_name: str = None,
    ):
        # 节次类型枚举：COURSE/REST
        self.section_type = section_type
        # 开始时间
        self.section_start_time = section_start_time
        # 第几节。
        self.section_index = section_index
        # 结束时间
        self.section_end_time = section_end_time
        # 节次名称
        self.section_name = section_name

    def validate(self):
        if self.section_start_time:
            self.section_start_time.validate()
        if self.section_end_time:
            self.section_end_time.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.section_type is not None:
            result['sectionType'] = self.section_type
        if self.section_start_time is not None:
            result['sectionStartTime'] = self.section_start_time.to_map()
        if self.section_index is not None:
            result['sectionIndex'] = self.section_index
        if self.section_end_time is not None:
            result['sectionEndTime'] = self.section_end_time.to_map()
        if self.section_name is not None:
            result['sectionName'] = self.section_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sectionType') is not None:
            self.section_type = m.get('sectionType')
        if m.get('sectionStartTime') is not None:
            temp_model = CreateSectionConfigRequestSectionConfigsSectionModelsSectionStartTime()
            self.section_start_time = temp_model.from_map(m['sectionStartTime'])
        if m.get('sectionIndex') is not None:
            self.section_index = m.get('sectionIndex')
        if m.get('sectionEndTime') is not None:
            temp_model = CreateSectionConfigRequestSectionConfigsSectionModelsSectionEndTime()
            self.section_end_time = temp_model.from_map(m['sectionEndTime'])
        if m.get('sectionName') is not None:
            self.section_name = m.get('sectionName')
        return self


class CreateSectionConfigRequestSectionConfigsSectionEndDate(TeaModel):
    def __init__(
        self,
        month: int = None,
        year: int = None,
        day_of_month: int = None,
    ):
        # 月
        self.month = month
        # 年
        self.year = year
        # 日
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


class CreateSectionConfigRequestSectionConfigsSemesterStartDate(TeaModel):
    def __init__(
        self,
        month: int = None,
        year: int = None,
        day_of_month: int = None,
    ):
        # 月
        self.month = month
        # 年
        self.year = year
        # 日
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


class CreateSectionConfigRequestSectionConfigsSemesterEndDate(TeaModel):
    def __init__(
        self,
        month: int = None,
        year: int = None,
        day_of_month: int = None,
    ):
        # 月
        self.month = month
        # 年
        self.year = year
        # 每月第几天
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


class CreateSectionConfigRequestSectionConfigs(TeaModel):
    def __init__(
        self,
        semester: int = None,
        section_start_date: CreateSectionConfigRequestSectionConfigsSectionStartDate = None,
        school_year: str = None,
        schedule_name: str = None,
        section_models: List[CreateSectionConfigRequestSectionConfigsSectionModels] = None,
        section_end_date: CreateSectionConfigRequestSectionConfigsSectionEndDate = None,
        semester_start_date: CreateSectionConfigRequestSectionConfigsSemesterStartDate = None,
        semester_end_date: CreateSectionConfigRequestSectionConfigsSemesterEndDate = None,
    ):
        # 学期
        self.semester = semester
        # 开始时间（精确到日）
        self.section_start_date = section_start_date
        # 学年
        self.school_year = school_year
        # 课表名称
        self.schedule_name = schedule_name
        # 节次模型
        self.section_models = section_models
        # 结束时间
        self.section_end_date = section_end_date
        # 学期开始时间
        self.semester_start_date = semester_start_date
        # 学期结束时间
        self.semester_end_date = semester_end_date

    def validate(self):
        if self.section_start_date:
            self.section_start_date.validate()
        if self.section_models:
            for k in self.section_models:
                if k:
                    k.validate()
        if self.section_end_date:
            self.section_end_date.validate()
        if self.semester_start_date:
            self.semester_start_date.validate()
        if self.semester_end_date:
            self.semester_end_date.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.semester is not None:
            result['semester'] = self.semester
        if self.section_start_date is not None:
            result['sectionStartDate'] = self.section_start_date.to_map()
        if self.school_year is not None:
            result['schoolYear'] = self.school_year
        if self.schedule_name is not None:
            result['scheduleName'] = self.schedule_name
        result['sectionModels'] = []
        if self.section_models is not None:
            for k in self.section_models:
                result['sectionModels'].append(k.to_map() if k else None)
        if self.section_end_date is not None:
            result['sectionEndDate'] = self.section_end_date.to_map()
        if self.semester_start_date is not None:
            result['semesterStartDate'] = self.semester_start_date.to_map()
        if self.semester_end_date is not None:
            result['semesterEndDate'] = self.semester_end_date.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('semester') is not None:
            self.semester = m.get('semester')
        if m.get('sectionStartDate') is not None:
            temp_model = CreateSectionConfigRequestSectionConfigsSectionStartDate()
            self.section_start_date = temp_model.from_map(m['sectionStartDate'])
        if m.get('schoolYear') is not None:
            self.school_year = m.get('schoolYear')
        if m.get('scheduleName') is not None:
            self.schedule_name = m.get('scheduleName')
        self.section_models = []
        if m.get('sectionModels') is not None:
            for k in m.get('sectionModels'):
                temp_model = CreateSectionConfigRequestSectionConfigsSectionModels()
                self.section_models.append(temp_model.from_map(k))
        if m.get('sectionEndDate') is not None:
            temp_model = CreateSectionConfigRequestSectionConfigsSectionEndDate()
            self.section_end_date = temp_model.from_map(m['sectionEndDate'])
        if m.get('semesterStartDate') is not None:
            temp_model = CreateSectionConfigRequestSectionConfigsSemesterStartDate()
            self.semester_start_date = temp_model.from_map(m['semesterStartDate'])
        if m.get('semesterEndDate') is not None:
            temp_model = CreateSectionConfigRequestSectionConfigsSemesterEndDate()
            self.semester_end_date = temp_model.from_map(m['semesterEndDate'])
        return self


class CreateSectionConfigRequest(TeaModel):
    def __init__(
        self,
        ext: str = None,
        section_configs: List[CreateSectionConfigRequestSectionConfigs] = None,
        op_user_id: str = None,
    ):
        # 扩展参数
        self.ext = ext
        # 课表模板信息
        self.section_configs = section_configs
        # 操作人的userid。
        self.op_user_id = op_user_id

    def validate(self):
        if self.section_configs:
            for k in self.section_configs:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ext is not None:
            result['ext'] = self.ext
        result['sectionConfigs'] = []
        if self.section_configs is not None:
            for k in self.section_configs:
                result['sectionConfigs'].append(k.to_map() if k else None)
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        self.section_configs = []
        if m.get('sectionConfigs') is not None:
            for k in m.get('sectionConfigs'):
                temp_model = CreateSectionConfigRequestSectionConfigs()
                self.section_configs.append(temp_model.from_map(k))
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class CreateSectionConfigResponseBody(TeaModel):
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


class CreateSectionConfigResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateSectionConfigResponseBody = None,
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
            temp_model = CreateSectionConfigResponseBody()
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


class QueryRemoteClassCourseHeaders(TeaModel):
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


class QueryRemoteClassCourseRequest(TeaModel):
    def __init__(
        self,
        operator: str = None,
        start_time: int = None,
        end_time: int = None,
    ):
        # 操作者用户ID
        self.operator = operator
        # 开始时间
        self.start_time = start_time
        # 结束时间
        self.end_time = end_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator is not None:
            result['operator'] = self.operator
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.end_time is not None:
            result['endTime'] = self.end_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        return self


class QueryRemoteClassCourseResponseBodyResultTeachingParticipant(TeaModel):
    def __init__(
        self,
        participant_name: str = None,
        participant_id: str = None,
        corp_id: str = None,
        org_name: str = None,
    ):
        # 参与方名称
        self.participant_name = participant_name
        # 参与方ID
        self.participant_id = participant_id
        # 组织ID
        self.corp_id = corp_id
        # 组织名称
        self.org_name = org_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.participant_name is not None:
            result['participantName'] = self.participant_name
        if self.participant_id is not None:
            result['participantId'] = self.participant_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.org_name is not None:
            result['orgName'] = self.org_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('participantName') is not None:
            self.participant_name = m.get('participantName')
        if m.get('participantId') is not None:
            self.participant_id = m.get('participantId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('orgName') is not None:
            self.org_name = m.get('orgName')
        return self


class QueryRemoteClassCourseResponseBodyResultAttendParticipants(TeaModel):
    def __init__(
        self,
        participant_name: str = None,
        participant_id: str = None,
        corp_id: str = None,
        org_name: str = None,
    ):
        # 参与方名称
        self.participant_name = participant_name
        # 参与方ID
        self.participant_id = participant_id
        # 组织ID
        self.corp_id = corp_id
        # 组织名称
        self.org_name = org_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.participant_name is not None:
            result['participantName'] = self.participant_name
        if self.participant_id is not None:
            result['participantId'] = self.participant_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.org_name is not None:
            result['orgName'] = self.org_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('participantName') is not None:
            self.participant_name = m.get('participantName')
        if m.get('participantId') is not None:
            self.participant_id = m.get('participantId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('orgName') is not None:
            self.org_name = m.get('orgName')
        return self


class QueryRemoteClassCourseResponseBodyResult(TeaModel):
    def __init__(
        self,
        course_code: str = None,
        course_name: str = None,
        status: int = None,
        start_time: int = None,
        end_time: int = None,
        can_edit: bool = None,
        teaching_participant: QueryRemoteClassCourseResponseBodyResultTeachingParticipant = None,
        attend_participants: List[QueryRemoteClassCourseResponseBodyResultAttendParticipants] = None,
        course_ways: List[str] = None,
    ):
        # 课程code
        self.course_code = course_code
        # 课程名称
        self.course_name = course_name
        # 课程状态：0: 未开始；1: 已开始；2: 已结束
        self.status = status
        # 开始时间
        self.start_time = start_time
        # 结束时间
        self.end_time = end_time
        # 课程是否可以编辑或删除
        self.can_edit = can_edit
        # 授课设备
        self.teaching_participant = teaching_participant
        # 听课设备列表
        self.attend_participants = attend_participants
        # 当前组织在课程中的角色列表：TEACHING：授课方；ATTEND：听课方
        self.course_ways = course_ways

    def validate(self):
        if self.teaching_participant:
            self.teaching_participant.validate()
        if self.attend_participants:
            for k in self.attend_participants:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_code is not None:
            result['courseCode'] = self.course_code
        if self.course_name is not None:
            result['courseName'] = self.course_name
        if self.status is not None:
            result['status'] = self.status
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.can_edit is not None:
            result['canEdit'] = self.can_edit
        if self.teaching_participant is not None:
            result['teachingParticipant'] = self.teaching_participant.to_map()
        result['attendParticipants'] = []
        if self.attend_participants is not None:
            for k in self.attend_participants:
                result['attendParticipants'].append(k.to_map() if k else None)
        if self.course_ways is not None:
            result['courseWays'] = self.course_ways
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseCode') is not None:
            self.course_code = m.get('courseCode')
        if m.get('courseName') is not None:
            self.course_name = m.get('courseName')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('canEdit') is not None:
            self.can_edit = m.get('canEdit')
        if m.get('teachingParticipant') is not None:
            temp_model = QueryRemoteClassCourseResponseBodyResultTeachingParticipant()
            self.teaching_participant = temp_model.from_map(m['teachingParticipant'])
        self.attend_participants = []
        if m.get('attendParticipants') is not None:
            for k in m.get('attendParticipants'):
                temp_model = QueryRemoteClassCourseResponseBodyResultAttendParticipants()
                self.attend_participants.append(temp_model.from_map(k))
        if m.get('courseWays') is not None:
            self.course_ways = m.get('courseWays')
        return self


class QueryRemoteClassCourseResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
        result: List[QueryRemoteClassCourseResponseBodyResult] = None,
    ):
        # 是否成功
        self.success = success
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
        if self.success is not None:
            result['success'] = self.success
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = QueryRemoteClassCourseResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class QueryRemoteClassCourseResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryRemoteClassCourseResponseBody = None,
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
            temp_model = QueryRemoteClassCourseResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreatePhysicalClassroomHeaders(TeaModel):
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


class CreatePhysicalClassroomRequest(TeaModel):
    def __init__(
        self,
        op_user_id: str = None,
        classroom_floor: str = None,
        ext: str = None,
        classroom_building: str = None,
        direct_broadcast: str = None,
        classroom_name: str = None,
        classroom_campus: str = None,
        classroom_number: str = None,
    ):
        # opUserId
        self.op_user_id = op_user_id
        # 教室楼层
        self.classroom_floor = classroom_floor
        # 扩展信息
        self.ext = ext
        # 教室教学楼
        self.classroom_building = classroom_building
        # 是否支持直播
        self.direct_broadcast = direct_broadcast
        # 教室名称
        self.classroom_name = classroom_name
        # 教室校区
        self.classroom_campus = classroom_campus
        # 教室房间号
        self.classroom_number = classroom_number

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.classroom_floor is not None:
            result['classroomFloor'] = self.classroom_floor
        if self.ext is not None:
            result['ext'] = self.ext
        if self.classroom_building is not None:
            result['classroomBuilding'] = self.classroom_building
        if self.direct_broadcast is not None:
            result['directBroadcast'] = self.direct_broadcast
        if self.classroom_name is not None:
            result['classroomName'] = self.classroom_name
        if self.classroom_campus is not None:
            result['classroomCampus'] = self.classroom_campus
        if self.classroom_number is not None:
            result['classroomNumber'] = self.classroom_number
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('classroomFloor') is not None:
            self.classroom_floor = m.get('classroomFloor')
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        if m.get('classroomBuilding') is not None:
            self.classroom_building = m.get('classroomBuilding')
        if m.get('directBroadcast') is not None:
            self.direct_broadcast = m.get('directBroadcast')
        if m.get('classroomName') is not None:
            self.classroom_name = m.get('classroomName')
        if m.get('classroomCampus') is not None:
            self.classroom_campus = m.get('classroomCampus')
        if m.get('classroomNumber') is not None:
            self.classroom_number = m.get('classroomNumber')
        return self


class CreatePhysicalClassroomResponseBody(TeaModel):
    def __init__(
        self,
        classroom_id: int = None,
    ):
        # 教室id
        self.classroom_id = classroom_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.classroom_id is not None:
            result['classroomId'] = self.classroom_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classroomId') is not None:
            self.classroom_id = m.get('classroomId')
        return self


class CreatePhysicalClassroomResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreatePhysicalClassroomResponseBody = None,
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
            temp_model = CreatePhysicalClassroomResponseBody()
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


class CreateRemoteClassCourseHeaders(TeaModel):
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


class CreateRemoteClassCourseRequestTeachingParticipant(TeaModel):
    def __init__(
        self,
        participant_id: str = None,
        corp_id: str = None,
    ):
        # 参与方ID
        self.participant_id = participant_id
        # 组织ID
        self.corp_id = corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.participant_id is not None:
            result['participantId'] = self.participant_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('participantId') is not None:
            self.participant_id = m.get('participantId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        return self


class CreateRemoteClassCourseRequestAttendParticipants(TeaModel):
    def __init__(
        self,
        participant_id: str = None,
        corp_id: str = None,
    ):
        # 参与方ID
        self.participant_id = participant_id
        # 组织ID
        self.corp_id = corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.participant_id is not None:
            result['participantId'] = self.participant_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('participantId') is not None:
            self.participant_id = m.get('participantId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        return self


class CreateRemoteClassCourseRequest(TeaModel):
    def __init__(
        self,
        course_name: str = None,
        start_time: int = None,
        end_time: int = None,
        teaching_participant: CreateRemoteClassCourseRequestTeachingParticipant = None,
        attend_participants: List[CreateRemoteClassCourseRequestAttendParticipants] = None,
        auth_code: str = None,
        ding_client_id: str = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
        ding_oauth_app_id: int = None,
        ding_isv_org_id: int = None,
        ding_corp_id: str = None,
    ):
        # 课程名称
        self.course_name = course_name
        # 开始时间
        self.start_time = start_time
        # 结束时间
        self.end_time = end_time
        # 授课设备
        self.teaching_participant = teaching_participant
        # 听课设备列表
        self.attend_participants = attend_participants
        # 免登码
        self.auth_code = auth_code
        self.ding_client_id = ding_client_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type
        self.ding_oauth_app_id = ding_oauth_app_id
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_corp_id = ding_corp_id

    def validate(self):
        if self.teaching_participant:
            self.teaching_participant.validate()
        if self.attend_participants:
            for k in self.attend_participants:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_name is not None:
            result['courseName'] = self.course_name
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.teaching_participant is not None:
            result['teachingParticipant'] = self.teaching_participant.to_map()
        result['attendParticipants'] = []
        if self.attend_participants is not None:
            for k in self.attend_participants:
                result['attendParticipants'].append(k.to_map() if k else None)
        if self.auth_code is not None:
            result['authCode'] = self.auth_code
        if self.ding_client_id is not None:
            result['dingClientId'] = self.ding_client_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.ding_oauth_app_id is not None:
            result['dingOauthAppId'] = self.ding_oauth_app_id
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseName') is not None:
            self.course_name = m.get('courseName')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('teachingParticipant') is not None:
            temp_model = CreateRemoteClassCourseRequestTeachingParticipant()
            self.teaching_participant = temp_model.from_map(m['teachingParticipant'])
        self.attend_participants = []
        if m.get('attendParticipants') is not None:
            for k in m.get('attendParticipants'):
                temp_model = CreateRemoteClassCourseRequestAttendParticipants()
                self.attend_participants.append(temp_model.from_map(k))
        if m.get('authCode') is not None:
            self.auth_code = m.get('authCode')
        if m.get('dingClientId') is not None:
            self.ding_client_id = m.get('dingClientId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('dingOauthAppId') is not None:
            self.ding_oauth_app_id = m.get('dingOauthAppId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        return self


class CreateRemoteClassCourseResponseBodyResult(TeaModel):
    def __init__(
        self,
        course_code: str = None,
    ):
        # 课程码
        self.course_code = course_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_code is not None:
            result['courseCode'] = self.course_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseCode') is not None:
            self.course_code = m.get('courseCode')
        return self


class CreateRemoteClassCourseResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
        result: CreateRemoteClassCourseResponseBodyResult = None,
    ):
        self.success = success
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
            temp_model = CreateRemoteClassCourseResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class CreateRemoteClassCourseResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateRemoteClassCourseResponseBody = None,
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
            temp_model = CreateRemoteClassCourseResponseBody()
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


class UpdatePhysicalClassroomHeaders(TeaModel):
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


class UpdatePhysicalClassroomRequest(TeaModel):
    def __init__(
        self,
        op_user_id: str = None,
        classroom_floor: str = None,
        ext: str = None,
        classroom_building: str = None,
        direct_broadcast: str = None,
        classroom_name: str = None,
        classroom_campus: str = None,
        classroom_number: str = None,
        classroom_id: int = None,
    ):
        # 操作人id
        self.op_user_id = op_user_id
        # 教室楼层
        self.classroom_floor = classroom_floor
        # 扩展信息
        self.ext = ext
        # 教室教学楼
        self.classroom_building = classroom_building
        # 是否支持直播
        self.direct_broadcast = direct_broadcast
        # 教室名称
        self.classroom_name = classroom_name
        # 教室校区
        self.classroom_campus = classroom_campus
        # 教室房间号
        self.classroom_number = classroom_number
        # 教室id
        self.classroom_id = classroom_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.classroom_floor is not None:
            result['classroomFloor'] = self.classroom_floor
        if self.ext is not None:
            result['ext'] = self.ext
        if self.classroom_building is not None:
            result['classroomBuilding'] = self.classroom_building
        if self.direct_broadcast is not None:
            result['directBroadcast'] = self.direct_broadcast
        if self.classroom_name is not None:
            result['classroomName'] = self.classroom_name
        if self.classroom_campus is not None:
            result['classroomCampus'] = self.classroom_campus
        if self.classroom_number is not None:
            result['classroomNumber'] = self.classroom_number
        if self.classroom_id is not None:
            result['classroomId'] = self.classroom_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('classroomFloor') is not None:
            self.classroom_floor = m.get('classroomFloor')
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        if m.get('classroomBuilding') is not None:
            self.classroom_building = m.get('classroomBuilding')
        if m.get('directBroadcast') is not None:
            self.direct_broadcast = m.get('directBroadcast')
        if m.get('classroomName') is not None:
            self.classroom_name = m.get('classroomName')
        if m.get('classroomCampus') is not None:
            self.classroom_campus = m.get('classroomCampus')
        if m.get('classroomNumber') is not None:
            self.classroom_number = m.get('classroomNumber')
        if m.get('classroomId') is not None:
            self.classroom_id = m.get('classroomId')
        return self


class UpdatePhysicalClassroomResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 是否成功
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


class UpdatePhysicalClassroomResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdatePhysicalClassroomResponseBody = None,
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
            temp_model = UpdatePhysicalClassroomResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class MoveStudentHeaders(TeaModel):
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


class MoveStudentRequest(TeaModel):
    def __init__(
        self,
        ding_isv_org_id: int = None,
        ding_corp_id: str = None,
        ding_oauth_app_id: int = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
        ding_org_id: int = None,
        operator: str = None,
        user_id: str = None,
        origin_class_id: int = None,
        target_class_id: int = None,
    ):
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_corp_id = ding_corp_id
        self.ding_oauth_app_id = ding_oauth_app_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type
        self.ding_org_id = ding_org_id
        # 管理员id
        self.operator = operator
        # 学生id
        self.user_id = user_id
        # 愿班级id
        self.origin_class_id = origin_class_id
        # 目标班级id
        self.target_class_id = target_class_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
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
        if self.operator is not None:
            result['operator'] = self.operator
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.origin_class_id is not None:
            result['originClassId'] = self.origin_class_id
        if self.target_class_id is not None:
            result['targetClassId'] = self.target_class_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
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
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('originClassId') is not None:
            self.origin_class_id = m.get('originClassId')
        if m.get('targetClassId') is not None:
            self.target_class_id = m.get('targetClassId')
        return self


class MoveStudentResponseBody(TeaModel):
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


class MoveStudentResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: MoveStudentResponseBody = None,
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
            temp_model = MoveStudentResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryEduAssetSpacesHeaders(TeaModel):
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


class QueryEduAssetSpacesRequest(TeaModel):
    def __init__(
        self,
        next_token: int = None,
        max_results: int = None,
        biz_code: str = None,
    ):
        # 标记当前开始读取的位置，置空表示从头开始
        self.next_token = next_token
        # 本次读取的最大数据记录数量
        self.max_results = max_results
        # 业务编码
        self.biz_code = biz_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        return self


class QueryEduAssetSpacesResponseBodySpaces(TeaModel):
    def __init__(
        self,
        space_id: str = None,
        space_name: str = None,
        space_type: str = None,
        quota: int = None,
        used_quota: int = None,
        permission_mode: str = None,
        create_time_millis: int = None,
        modify_time_millis: int = None,
    ):
        # 空间id
        self.space_id = space_id
        # 空间名称
        self.space_name = space_name
        # 空间类型
        self.space_type = space_type
        # 空间容量
        self.quota = quota
        # 已使用容量
        self.used_quota = used_quota
        # 权限类型acl：acl授权；custom：自定义授权
        self.permission_mode = permission_mode
        # 创建时间的时间戳
        self.create_time_millis = create_time_millis
        # 修改时间的时间戳
        self.modify_time_millis = modify_time_millis

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.space_name is not None:
            result['spaceName'] = self.space_name
        if self.space_type is not None:
            result['spaceType'] = self.space_type
        if self.quota is not None:
            result['quota'] = self.quota
        if self.used_quota is not None:
            result['usedQuota'] = self.used_quota
        if self.permission_mode is not None:
            result['permissionMode'] = self.permission_mode
        if self.create_time_millis is not None:
            result['createTimeMillis'] = self.create_time_millis
        if self.modify_time_millis is not None:
            result['modifyTimeMillis'] = self.modify_time_millis
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('spaceName') is not None:
            self.space_name = m.get('spaceName')
        if m.get('spaceType') is not None:
            self.space_type = m.get('spaceType')
        if m.get('quota') is not None:
            self.quota = m.get('quota')
        if m.get('usedQuota') is not None:
            self.used_quota = m.get('usedQuota')
        if m.get('permissionMode') is not None:
            self.permission_mode = m.get('permissionMode')
        if m.get('createTimeMillis') is not None:
            self.create_time_millis = m.get('createTimeMillis')
        if m.get('modifyTimeMillis') is not None:
            self.modify_time_millis = m.get('modifyTimeMillis')
        return self


class QueryEduAssetSpacesResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        has_more: bool = None,
        spaces: List[QueryEduAssetSpacesResponseBodySpaces] = None,
    ):
        # 表示当前调用返回读取到的位置，空代表数据已经读取完毕
        self.next_token = next_token
        # 是否还有数据
        self.has_more = has_more
        # 空间结果集
        self.spaces = spaces

    def validate(self):
        if self.spaces:
            for k in self.spaces:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['spaces'] = []
        if self.spaces is not None:
            for k in self.spaces:
                result['spaces'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.spaces = []
        if m.get('spaces') is not None:
            for k in m.get('spaces'):
                temp_model = QueryEduAssetSpacesResponseBodySpaces()
                self.spaces.append(temp_model.from_map(k))
        return self


class QueryEduAssetSpacesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryEduAssetSpacesResponseBody = None,
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
            temp_model = QueryEduAssetSpacesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateUniversityCourseGroupHeaders(TeaModel):
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


class CreateUniversityCourseGroupRequestTeacherInfos(TeaModel):
    def __init__(
        self,
        user_id: str = None,
        participant_role: str = None,
    ):
        # 用户id
        self.user_id = user_id
        # 角色类型
        self.participant_role = participant_role

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.participant_role is not None:
            result['participantRole'] = self.participant_role
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('participantRole') is not None:
            self.participant_role = m.get('participantRole')
        return self


class CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate(TeaModel):
    def __init__(
        self,
        month: int = None,
        year: int = None,
        day_of_month: int = None,
    ):
        # 月
        self.month = month
        # 年
        self.year = year
        # 一月的第几天
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


class CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate(TeaModel):
    def __init__(
        self,
        month: int = None,
        year: int = None,
        day_of_month: int = None,
    ):
        # 月
        self.month = month
        # 年
        self.year = year
        # 一月的第几天
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


class CreateUniversityCourseGroupRequestCourserGroupItemModels(TeaModel):
    def __init__(
        self,
        day_of_week: int = None,
        class_period_type: int = None,
        courser_group_item_start_date: CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate = None,
        section_index: List[int] = None,
        courser_group_item_end_date: CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate = None,
        course_type: int = None,
        classroom_id: int = None,
    ):
        # 一周的第几天
        self.day_of_week = day_of_week
        # 上课周期
        self.class_period_type = class_period_type
        # 课程组详细开始时间
        self.courser_group_item_start_date = courser_group_item_start_date
        # 课节
        self.section_index = section_index
        # 课程组详细结束时间
        self.courser_group_item_end_date = courser_group_item_end_date
        # 课程类型
        self.course_type = course_type
        # 教室id
        self.classroom_id = classroom_id

    def validate(self):
        if self.courser_group_item_start_date:
            self.courser_group_item_start_date.validate()
        if self.courser_group_item_end_date:
            self.courser_group_item_end_date.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_week is not None:
            result['dayOfWeek'] = self.day_of_week
        if self.class_period_type is not None:
            result['classPeriodType'] = self.class_period_type
        if self.courser_group_item_start_date is not None:
            result['courserGroupItemStartDate'] = self.courser_group_item_start_date.to_map()
        if self.section_index is not None:
            result['sectionIndex'] = self.section_index
        if self.courser_group_item_end_date is not None:
            result['courserGroupItemEndDate'] = self.courser_group_item_end_date.to_map()
        if self.course_type is not None:
            result['courseType'] = self.course_type
        if self.classroom_id is not None:
            result['classroomId'] = self.classroom_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfWeek') is not None:
            self.day_of_week = m.get('dayOfWeek')
        if m.get('classPeriodType') is not None:
            self.class_period_type = m.get('classPeriodType')
        if m.get('courserGroupItemStartDate') is not None:
            temp_model = CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate()
            self.courser_group_item_start_date = temp_model.from_map(m['courserGroupItemStartDate'])
        if m.get('sectionIndex') is not None:
            self.section_index = m.get('sectionIndex')
        if m.get('courserGroupItemEndDate') is not None:
            temp_model = CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate()
            self.courser_group_item_end_date = temp_model.from_map(m['courserGroupItemEndDate'])
        if m.get('courseType') is not None:
            self.course_type = m.get('courseType')
        if m.get('classroomId') is not None:
            self.classroom_id = m.get('classroomId')
        return self


class CreateUniversityCourseGroupRequest(TeaModel):
    def __init__(
        self,
        op_user_id: str = None,
        isv_course_group_code: str = None,
        ext: str = None,
        course_group_introduce: str = None,
        semester: int = None,
        subject_name: str = None,
        course_group_name: str = None,
        school_year: str = None,
        period_code: str = None,
        teacher_infos: List[CreateUniversityCourseGroupRequestTeacherInfos] = None,
        courser_group_item_models: List[CreateUniversityCourseGroupRequestCourserGroupItemModels] = None,
    ):
        # 操作人
        self.op_user_id = op_user_id
        # 合作方课程组code
        self.isv_course_group_code = isv_course_group_code
        # 扩展参数
        self.ext = ext
        # 课程组介绍
        self.course_group_introduce = course_group_introduce
        # 学期
        self.semester = semester
        # 学科
        self.subject_name = subject_name
        # 课程组名称
        self.course_group_name = course_group_name
        # 学年
        self.school_year = school_year
        # 学段code
        self.period_code = period_code
        # 教师信息
        self.teacher_infos = teacher_infos
        # 课程详细
        self.courser_group_item_models = courser_group_item_models

    def validate(self):
        if self.teacher_infos:
            for k in self.teacher_infos:
                if k:
                    k.validate()
        if self.courser_group_item_models:
            for k in self.courser_group_item_models:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.isv_course_group_code is not None:
            result['isvCourseGroupCode'] = self.isv_course_group_code
        if self.ext is not None:
            result['ext'] = self.ext
        if self.course_group_introduce is not None:
            result['courseGroupIntroduce'] = self.course_group_introduce
        if self.semester is not None:
            result['semester'] = self.semester
        if self.subject_name is not None:
            result['subjectName'] = self.subject_name
        if self.course_group_name is not None:
            result['courseGroupName'] = self.course_group_name
        if self.school_year is not None:
            result['schoolYear'] = self.school_year
        if self.period_code is not None:
            result['periodCode'] = self.period_code
        result['teacherInfos'] = []
        if self.teacher_infos is not None:
            for k in self.teacher_infos:
                result['teacherInfos'].append(k.to_map() if k else None)
        result['courserGroupItemModels'] = []
        if self.courser_group_item_models is not None:
            for k in self.courser_group_item_models:
                result['courserGroupItemModels'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('isvCourseGroupCode') is not None:
            self.isv_course_group_code = m.get('isvCourseGroupCode')
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        if m.get('courseGroupIntroduce') is not None:
            self.course_group_introduce = m.get('courseGroupIntroduce')
        if m.get('semester') is not None:
            self.semester = m.get('semester')
        if m.get('subjectName') is not None:
            self.subject_name = m.get('subjectName')
        if m.get('courseGroupName') is not None:
            self.course_group_name = m.get('courseGroupName')
        if m.get('schoolYear') is not None:
            self.school_year = m.get('schoolYear')
        if m.get('periodCode') is not None:
            self.period_code = m.get('periodCode')
        self.teacher_infos = []
        if m.get('teacherInfos') is not None:
            for k in m.get('teacherInfos'):
                temp_model = CreateUniversityCourseGroupRequestTeacherInfos()
                self.teacher_infos.append(temp_model.from_map(k))
        self.courser_group_item_models = []
        if m.get('courserGroupItemModels') is not None:
            for k in m.get('courserGroupItemModels'):
                temp_model = CreateUniversityCourseGroupRequestCourserGroupItemModels()
                self.courser_group_item_models.append(temp_model.from_map(k))
        return self


class CreateUniversityCourseGroupResponseBodyCourseGroupInfo(TeaModel):
    def __init__(
        self,
        course_group_code: str = None,
    ):
        # 课程组编码
        self.course_group_code = course_group_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_group_code is not None:
            result['courseGroupCode'] = self.course_group_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseGroupCode') is not None:
            self.course_group_code = m.get('courseGroupCode')
        return self


class CreateUniversityCourseGroupResponseBody(TeaModel):
    def __init__(
        self,
        course_group_info: CreateUniversityCourseGroupResponseBodyCourseGroupInfo = None,
    ):
        # 课程组信息
        self.course_group_info = course_group_info

    def validate(self):
        if self.course_group_info:
            self.course_group_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_group_info is not None:
            result['courseGroupInfo'] = self.course_group_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseGroupInfo') is not None:
            temp_model = CreateUniversityCourseGroupResponseBodyCourseGroupInfo()
            self.course_group_info = temp_model.from_map(m['courseGroupInfo'])
        return self


class CreateUniversityCourseGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateUniversityCourseGroupResponseBody = None,
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
            temp_model = CreateUniversityCourseGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetRemoteClassCourseHeaders(TeaModel):
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


class GetRemoteClassCourseRequest(TeaModel):
    def __init__(
        self,
        operator: str = None,
    ):
        # 操作者用户ID
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


class GetRemoteClassCourseResponseBodyResultTeachingParticipant(TeaModel):
    def __init__(
        self,
        participant_id: str = None,
        participant_name: str = None,
        corp_id: str = None,
        org_name: str = None,
    ):
        # 参与方ID
        self.participant_id = participant_id
        # 参与方名称
        self.participant_name = participant_name
        # 组织ID
        self.corp_id = corp_id
        # 组织名称
        self.org_name = org_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.participant_id is not None:
            result['participantId'] = self.participant_id
        if self.participant_name is not None:
            result['participantName'] = self.participant_name
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.org_name is not None:
            result['orgName'] = self.org_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('participantId') is not None:
            self.participant_id = m.get('participantId')
        if m.get('participantName') is not None:
            self.participant_name = m.get('participantName')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('orgName') is not None:
            self.org_name = m.get('orgName')
        return self


class GetRemoteClassCourseResponseBodyResultAttendParticipants(TeaModel):
    def __init__(
        self,
        participant_id: str = None,
        participant_name: str = None,
        corp_id: str = None,
        org_name: str = None,
    ):
        # 参与方ID
        self.participant_id = participant_id
        # 参与方名称
        self.participant_name = participant_name
        # 组织ID
        self.corp_id = corp_id
        # 组织名称
        self.org_name = org_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.participant_id is not None:
            result['participantId'] = self.participant_id
        if self.participant_name is not None:
            result['participantName'] = self.participant_name
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.org_name is not None:
            result['orgName'] = self.org_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('participantId') is not None:
            self.participant_id = m.get('participantId')
        if m.get('participantName') is not None:
            self.participant_name = m.get('participantName')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('orgName') is not None:
            self.org_name = m.get('orgName')
        return self


class GetRemoteClassCourseResponseBodyResultRecordInfos(TeaModel):
    def __init__(
        self,
        url: str = None,
        start_time: str = None,
        stop_time: str = None,
    ):
        # 录制文件地址（文件有效期7天）
        self.url = url
        # 录制开始时间（UTC/GMT格式）
        self.start_time = start_time
        # 录制结束时间（UTC/GMT格式）
        self.stop_time = stop_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.url is not None:
            result['url'] = self.url
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.stop_time is not None:
            result['stopTime'] = self.stop_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('stopTime') is not None:
            self.stop_time = m.get('stopTime')
        return self


class GetRemoteClassCourseResponseBodyResult(TeaModel):
    def __init__(
        self,
        course_code: str = None,
        course_name: str = None,
        start_time: int = None,
        end_time: int = None,
        status: int = None,
        room_status: int = None,
        can_edit: bool = None,
        teaching_participant: GetRemoteClassCourseResponseBodyResultTeachingParticipant = None,
        attend_participants: List[GetRemoteClassCourseResponseBodyResultAttendParticipants] = None,
        live_url: str = None,
        record_infos: List[GetRemoteClassCourseResponseBodyResultRecordInfos] = None,
    ):
        # 课程code
        self.course_code = course_code
        # 课程名称
        self.course_name = course_name
        # 开始时间
        self.start_time = start_time
        # 结束时间
        self.end_time = end_time
        # 课程状态：0: 未开始；1: 已开始；2: 已结束
        self.status = status
        # 课堂当前状态：0: 未进行；1: 进行中
        self.room_status = room_status
        # 课程是否可以编辑或删除
        self.can_edit = can_edit
        # 授课设备
        self.teaching_participant = teaching_participant
        # 听课设备列表
        self.attend_participants = attend_participants
        # 直播观看URL（如果有）
        self.live_url = live_url
        # 录制信息列表（如果有）。根据录制端的不同，有不同时长的延迟
        self.record_infos = record_infos

    def validate(self):
        if self.teaching_participant:
            self.teaching_participant.validate()
        if self.attend_participants:
            for k in self.attend_participants:
                if k:
                    k.validate()
        if self.record_infos:
            for k in self.record_infos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_code is not None:
            result['courseCode'] = self.course_code
        if self.course_name is not None:
            result['courseName'] = self.course_name
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.status is not None:
            result['status'] = self.status
        if self.room_status is not None:
            result['roomStatus'] = self.room_status
        if self.can_edit is not None:
            result['canEdit'] = self.can_edit
        if self.teaching_participant is not None:
            result['teachingParticipant'] = self.teaching_participant.to_map()
        result['attendParticipants'] = []
        if self.attend_participants is not None:
            for k in self.attend_participants:
                result['attendParticipants'].append(k.to_map() if k else None)
        if self.live_url is not None:
            result['liveUrl'] = self.live_url
        result['recordInfos'] = []
        if self.record_infos is not None:
            for k in self.record_infos:
                result['recordInfos'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseCode') is not None:
            self.course_code = m.get('courseCode')
        if m.get('courseName') is not None:
            self.course_name = m.get('courseName')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('roomStatus') is not None:
            self.room_status = m.get('roomStatus')
        if m.get('canEdit') is not None:
            self.can_edit = m.get('canEdit')
        if m.get('teachingParticipant') is not None:
            temp_model = GetRemoteClassCourseResponseBodyResultTeachingParticipant()
            self.teaching_participant = temp_model.from_map(m['teachingParticipant'])
        self.attend_participants = []
        if m.get('attendParticipants') is not None:
            for k in m.get('attendParticipants'):
                temp_model = GetRemoteClassCourseResponseBodyResultAttendParticipants()
                self.attend_participants.append(temp_model.from_map(k))
        if m.get('liveUrl') is not None:
            self.live_url = m.get('liveUrl')
        self.record_infos = []
        if m.get('recordInfos') is not None:
            for k in m.get('recordInfos'):
                temp_model = GetRemoteClassCourseResponseBodyResultRecordInfos()
                self.record_infos.append(temp_model.from_map(k))
        return self


class GetRemoteClassCourseResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
        result: GetRemoteClassCourseResponseBodyResult = None,
    ):
        # 是否成功
        self.success = success
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
            temp_model = GetRemoteClassCourseResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetRemoteClassCourseResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetRemoteClassCourseResponseBody = None,
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
            temp_model = GetRemoteClassCourseResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryUniversityCourseGroupHeaders(TeaModel):
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


class QueryUniversityCourseGroupRequest(TeaModel):
    def __init__(
        self,
        op_user_id: str = None,
        course_group_code: str = None,
    ):
        # 操作人
        self.op_user_id = op_user_id
        # 课程编码
        self.course_group_code = course_group_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.course_group_code is not None:
            result['courseGroupCode'] = self.course_group_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('courseGroupCode') is not None:
            self.course_group_code = m.get('courseGroupCode')
        return self


class QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemStartDate(TeaModel):
    def __init__(
        self,
        year: int = None,
        month: int = None,
        day_of_month: int = None,
    ):
        # 年
        self.year = year
        # 月
        self.month = month
        # 日
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


class QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemEndDate(TeaModel):
    def __init__(
        self,
        year: int = None,
        month: int = None,
        day_of_month: int = None,
    ):
        # 年
        self.year = year
        # 月
        self.month = month
        # 日
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


class QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels(TeaModel):
    def __init__(
        self,
        classroom_id: int = None,
        class_period_type: int = None,
        day_of_week: int = None,
        section_index: List[int] = None,
        courser_group_item_start_date: QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemStartDate = None,
        courser_group_item_end_date: QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemEndDate = None,
        course_type: int = None,
    ):
        # 教室主键
        self.classroom_id = classroom_id
        # 上课周期
        self.class_period_type = class_period_type
        # 一周的第几天
        self.day_of_week = day_of_week
        # 课节
        self.section_index = section_index
        # 开始时间
        self.courser_group_item_start_date = courser_group_item_start_date
        # 结束时间
        self.courser_group_item_end_date = courser_group_item_end_date
        # 课程类型
        self.course_type = course_type

    def validate(self):
        if self.courser_group_item_start_date:
            self.courser_group_item_start_date.validate()
        if self.courser_group_item_end_date:
            self.courser_group_item_end_date.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.classroom_id is not None:
            result['classroomId'] = self.classroom_id
        if self.class_period_type is not None:
            result['classPeriodType'] = self.class_period_type
        if self.day_of_week is not None:
            result['dayOfWeek'] = self.day_of_week
        if self.section_index is not None:
            result['sectionIndex'] = self.section_index
        if self.courser_group_item_start_date is not None:
            result['courserGroupItemStartDate'] = self.courser_group_item_start_date.to_map()
        if self.courser_group_item_end_date is not None:
            result['courserGroupItemEndDate'] = self.courser_group_item_end_date.to_map()
        if self.course_type is not None:
            result['courseType'] = self.course_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classroomId') is not None:
            self.classroom_id = m.get('classroomId')
        if m.get('classPeriodType') is not None:
            self.class_period_type = m.get('classPeriodType')
        if m.get('dayOfWeek') is not None:
            self.day_of_week = m.get('dayOfWeek')
        if m.get('sectionIndex') is not None:
            self.section_index = m.get('sectionIndex')
        if m.get('courserGroupItemStartDate') is not None:
            temp_model = QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemStartDate()
            self.courser_group_item_start_date = temp_model.from_map(m['courserGroupItemStartDate'])
        if m.get('courserGroupItemEndDate') is not None:
            temp_model = QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemEndDate()
            self.courser_group_item_end_date = temp_model.from_map(m['courserGroupItemEndDate'])
        if m.get('courseType') is not None:
            self.course_type = m.get('courseType')
        return self


class QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo(TeaModel):
    def __init__(
        self,
        isv_course_group_code: str = None,
        course_group_code: str = None,
        course_group_name: str = None,
        course_group_introduce: str = None,
        school_year: str = None,
        semester: int = None,
        period_code: str = None,
        subject_name: str = None,
        courser_group_item_models: List[QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels] = None,
    ):
        # 合作方课程组code
        self.isv_course_group_code = isv_course_group_code
        # 课程组编码
        self.course_group_code = course_group_code
        # 课程组名称
        self.course_group_name = course_group_name
        # 课程组介绍
        self.course_group_introduce = course_group_introduce
        # 学年
        self.school_year = school_year
        # 学期
        self.semester = semester
        # 学段编码
        self.period_code = period_code
        # 学科名称
        self.subject_name = subject_name
        # 课程组详细
        self.courser_group_item_models = courser_group_item_models

    def validate(self):
        if self.courser_group_item_models:
            for k in self.courser_group_item_models:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.isv_course_group_code is not None:
            result['isvCourseGroupCode'] = self.isv_course_group_code
        if self.course_group_code is not None:
            result['courseGroupCode'] = self.course_group_code
        if self.course_group_name is not None:
            result['courseGroupName'] = self.course_group_name
        if self.course_group_introduce is not None:
            result['courseGroupIntroduce'] = self.course_group_introduce
        if self.school_year is not None:
            result['schoolYear'] = self.school_year
        if self.semester is not None:
            result['semester'] = self.semester
        if self.period_code is not None:
            result['periodCode'] = self.period_code
        if self.subject_name is not None:
            result['subjectName'] = self.subject_name
        result['courserGroupItemModels'] = []
        if self.courser_group_item_models is not None:
            for k in self.courser_group_item_models:
                result['courserGroupItemModels'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isvCourseGroupCode') is not None:
            self.isv_course_group_code = m.get('isvCourseGroupCode')
        if m.get('courseGroupCode') is not None:
            self.course_group_code = m.get('courseGroupCode')
        if m.get('courseGroupName') is not None:
            self.course_group_name = m.get('courseGroupName')
        if m.get('courseGroupIntroduce') is not None:
            self.course_group_introduce = m.get('courseGroupIntroduce')
        if m.get('schoolYear') is not None:
            self.school_year = m.get('schoolYear')
        if m.get('semester') is not None:
            self.semester = m.get('semester')
        if m.get('periodCode') is not None:
            self.period_code = m.get('periodCode')
        if m.get('subjectName') is not None:
            self.subject_name = m.get('subjectName')
        self.courser_group_item_models = []
        if m.get('courserGroupItemModels') is not None:
            for k in m.get('courserGroupItemModels'):
                temp_model = QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels()
                self.courser_group_item_models.append(temp_model.from_map(k))
        return self


class QueryUniversityCourseGroupResponseBody(TeaModel):
    def __init__(
        self,
        university_course_group_info: QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo = None,
    ):
        # 课程组信息
        self.university_course_group_info = university_course_group_info

    def validate(self):
        if self.university_course_group_info:
            self.university_course_group_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.university_course_group_info is not None:
            result['universityCourseGroupInfo'] = self.university_course_group_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('universityCourseGroupInfo') is not None:
            temp_model = QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo()
            self.university_course_group_info = temp_model.from_map(m['universityCourseGroupInfo'])
        return self


class QueryUniversityCourseGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryUniversityCourseGroupResponseBody = None,
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
            temp_model = QueryUniversityCourseGroupResponseBody()
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


class DeleteUniversityCourseGroupHeaders(TeaModel):
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


class DeleteUniversityCourseGroupRequest(TeaModel):
    def __init__(
        self,
        op_user_id: str = None,
        course_group_code: str = None,
    ):
        # 操作人
        self.op_user_id = op_user_id
        # 课程组编码
        self.course_group_code = course_group_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.course_group_code is not None:
            result['courseGroupCode'] = self.course_group_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('courseGroupCode') is not None:
            self.course_group_code = m.get('courseGroupCode')
        return self


class DeleteUniversityCourseGroupResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 操作结果
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


class DeleteUniversityCourseGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DeleteUniversityCourseGroupResponseBody = None,
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
            temp_model = DeleteUniversityCourseGroupResponseBody()
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


class QueryDeviceListByCorpIdHeaders(TeaModel):
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


class QueryDeviceListByCorpIdRequest(TeaModel):
    def __init__(
        self,
        operator: str = None,
        page_number: int = None,
        page_size: int = None,
    ):
        self.operator = operator
        self.page_number = page_number
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator is not None:
            result['operator'] = self.operator
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class QueryDeviceListByCorpIdResponseBodyResultList(TeaModel):
    def __init__(
        self,
        app_status: int = None,
        device_code: str = None,
        device_name: str = None,
    ):
        self.app_status = app_status
        self.device_code = device_code
        self.device_name = device_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_status is not None:
            result['appStatus'] = self.app_status
        if self.device_code is not None:
            result['deviceCode'] = self.device_code
        if self.device_name is not None:
            result['deviceName'] = self.device_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appStatus') is not None:
            self.app_status = m.get('appStatus')
        if m.get('deviceCode') is not None:
            self.device_code = m.get('deviceCode')
        if m.get('deviceName') is not None:
            self.device_name = m.get('deviceName')
        return self


class QueryDeviceListByCorpIdResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QueryDeviceListByCorpIdResponseBodyResultList] = None,
    ):
        self.has_more = has_more
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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryDeviceListByCorpIdResponseBodyResultList()
                self.list.append(temp_model.from_map(k))
        return self


class QueryDeviceListByCorpIdResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
        result: QueryDeviceListByCorpIdResponseBodyResult = None,
    ):
        # Id of the request
        self.success = success
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
            temp_model = QueryDeviceListByCorpIdResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class QueryDeviceListByCorpIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryDeviceListByCorpIdResponseBody = None,
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
            temp_model = QueryDeviceListByCorpIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateUniversityCourseGroupHeaders(TeaModel):
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


class UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate(TeaModel):
    def __init__(
        self,
        month: int = None,
        year: int = None,
        day_of_month: int = None,
    ):
        # 月
        self.month = month
        # 年
        self.year = year
        # 一月的第几天
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


class UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate(TeaModel):
    def __init__(
        self,
        month: int = None,
        year: int = None,
        day_of_month: int = None,
    ):
        # 月
        self.month = month
        # 年
        self.year = year
        # 一月的第几天
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


class UpdateUniversityCourseGroupRequestCourserGroupItemModels(TeaModel):
    def __init__(
        self,
        day_of_week: int = None,
        class_period_type: int = None,
        courser_group_item_start_date: UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate = None,
        section_index: List[int] = None,
        courser_group_item_end_date: UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate = None,
        course_type: int = None,
        classroom_id: int = None,
    ):
        # 一周的第几天
        self.day_of_week = day_of_week
        # 上课周期
        self.class_period_type = class_period_type
        # 开始时间
        self.courser_group_item_start_date = courser_group_item_start_date
        # 课节
        self.section_index = section_index
        # 结束时间
        self.courser_group_item_end_date = courser_group_item_end_date
        # 课程类型
        self.course_type = course_type
        # classroomId
        self.classroom_id = classroom_id

    def validate(self):
        if self.courser_group_item_start_date:
            self.courser_group_item_start_date.validate()
        if self.courser_group_item_end_date:
            self.courser_group_item_end_date.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_week is not None:
            result['dayOfWeek'] = self.day_of_week
        if self.class_period_type is not None:
            result['classPeriodType'] = self.class_period_type
        if self.courser_group_item_start_date is not None:
            result['courserGroupItemStartDate'] = self.courser_group_item_start_date.to_map()
        if self.section_index is not None:
            result['sectionIndex'] = self.section_index
        if self.courser_group_item_end_date is not None:
            result['courserGroupItemEndDate'] = self.courser_group_item_end_date.to_map()
        if self.course_type is not None:
            result['courseType'] = self.course_type
        if self.classroom_id is not None:
            result['classroomId'] = self.classroom_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfWeek') is not None:
            self.day_of_week = m.get('dayOfWeek')
        if m.get('classPeriodType') is not None:
            self.class_period_type = m.get('classPeriodType')
        if m.get('courserGroupItemStartDate') is not None:
            temp_model = UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate()
            self.courser_group_item_start_date = temp_model.from_map(m['courserGroupItemStartDate'])
        if m.get('sectionIndex') is not None:
            self.section_index = m.get('sectionIndex')
        if m.get('courserGroupItemEndDate') is not None:
            temp_model = UpdateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate()
            self.courser_group_item_end_date = temp_model.from_map(m['courserGroupItemEndDate'])
        if m.get('courseType') is not None:
            self.course_type = m.get('courseType')
        if m.get('classroomId') is not None:
            self.classroom_id = m.get('classroomId')
        return self


class UpdateUniversityCourseGroupRequest(TeaModel):
    def __init__(
        self,
        op_user_id: str = None,
        ext: str = None,
        course_group_code: str = None,
        course_group_introduce: str = None,
        course_group_name: str = None,
        courser_group_item_models: List[UpdateUniversityCourseGroupRequestCourserGroupItemModels] = None,
    ):
        # opUserId
        self.op_user_id = op_user_id
        # 扩展信息
        self.ext = ext
        # 课程组编码
        self.course_group_code = course_group_code
        # 课程组介绍
        self.course_group_introduce = course_group_introduce
        # 课程组名称
        self.course_group_name = course_group_name
        # 课程组详细
        self.courser_group_item_models = courser_group_item_models

    def validate(self):
        if self.courser_group_item_models:
            for k in self.courser_group_item_models:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.ext is not None:
            result['ext'] = self.ext
        if self.course_group_code is not None:
            result['courseGroupCode'] = self.course_group_code
        if self.course_group_introduce is not None:
            result['courseGroupIntroduce'] = self.course_group_introduce
        if self.course_group_name is not None:
            result['courseGroupName'] = self.course_group_name
        result['courserGroupItemModels'] = []
        if self.courser_group_item_models is not None:
            for k in self.courser_group_item_models:
                result['courserGroupItemModels'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        if m.get('courseGroupCode') is not None:
            self.course_group_code = m.get('courseGroupCode')
        if m.get('courseGroupIntroduce') is not None:
            self.course_group_introduce = m.get('courseGroupIntroduce')
        if m.get('courseGroupName') is not None:
            self.course_group_name = m.get('courseGroupName')
        self.courser_group_item_models = []
        if m.get('courserGroupItemModels') is not None:
            for k in m.get('courserGroupItemModels'):
                temp_model = UpdateUniversityCourseGroupRequestCourserGroupItemModels()
                self.courser_group_item_models.append(temp_model.from_map(k))
        return self


class UpdateUniversityCourseGroupResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 是否成功
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


class UpdateUniversityCourseGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateUniversityCourseGroupResponseBody = None,
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
            temp_model = UpdateUniversityCourseGroupResponseBody()
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


class StartCoursePrepareHeaders(TeaModel):
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


class StartCoursePrepareRequest(TeaModel):
    def __init__(
        self,
        ext: str = None,
        course_group_code: str = None,
        section_index: List[int] = None,
        device_id: str = None,
        live_cover_image: str = None,
        course_date: str = None,
        isv_code: str = None,
        op_user_id: str = None,
    ):
        # 拓展信息
        self.ext = ext
        # 课程组编号
        self.course_group_code = course_group_code
        # 课节信息
        self.section_index = section_index
        # 设备id
        self.device_id = device_id
        # 封面url
        self.live_cover_image = live_cover_image
        # 上课日期
        self.course_date = course_date
        # isv编号
        self.isv_code = isv_code
        # 操作人
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ext is not None:
            result['ext'] = self.ext
        if self.course_group_code is not None:
            result['courseGroupCode'] = self.course_group_code
        if self.section_index is not None:
            result['sectionIndex'] = self.section_index
        if self.device_id is not None:
            result['deviceId'] = self.device_id
        if self.live_cover_image is not None:
            result['liveCoverImage'] = self.live_cover_image
        if self.course_date is not None:
            result['courseDate'] = self.course_date
        if self.isv_code is not None:
            result['isvCode'] = self.isv_code
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        if m.get('courseGroupCode') is not None:
            self.course_group_code = m.get('courseGroupCode')
        if m.get('sectionIndex') is not None:
            self.section_index = m.get('sectionIndex')
        if m.get('deviceId') is not None:
            self.device_id = m.get('deviceId')
        if m.get('liveCoverImage') is not None:
            self.live_cover_image = m.get('liveCoverImage')
        if m.get('courseDate') is not None:
            self.course_date = m.get('courseDate')
        if m.get('isvCode') is not None:
            self.isv_code = m.get('isvCode')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class StartCoursePrepareResponseBodyUniversityCourseCommonResponse(TeaModel):
    def __init__(
        self,
        success: bool = None,
        course_code: str = None,
    ):
        # 调用是否成功
        self.success = success
        # 课程编码
        self.course_code = course_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        if self.course_code is not None:
            result['courseCode'] = self.course_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('courseCode') is not None:
            self.course_code = m.get('courseCode')
        return self


class StartCoursePrepareResponseBody(TeaModel):
    def __init__(
        self,
        university_course_common_response: StartCoursePrepareResponseBodyUniversityCourseCommonResponse = None,
    ):
        self.university_course_common_response = university_course_common_response

    def validate(self):
        if self.university_course_common_response:
            self.university_course_common_response.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.university_course_common_response is not None:
            result['universityCourseCommonResponse'] = self.university_course_common_response.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('universityCourseCommonResponse') is not None:
            temp_model = StartCoursePrepareResponseBodyUniversityCourseCommonResponse()
            self.university_course_common_response = temp_model.from_map(m['universityCourseCommonResponse'])
        return self


class StartCoursePrepareResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: StartCoursePrepareResponseBody = None,
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
            temp_model = StartCoursePrepareResponseBody()
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


class SubscribeUniversityCourseGroupHeaders(TeaModel):
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


class SubscribeUniversityCourseGroupRequest(TeaModel):
    def __init__(
        self,
        course_group_code: str = None,
        student_user_ids: List[str] = None,
        op_user_id: str = None,
    ):
        # 课程组编号
        self.course_group_code = course_group_code
        # 学生用户Id
        self.student_user_ids = student_user_ids
        # 操作人id
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_group_code is not None:
            result['courseGroupCode'] = self.course_group_code
        if self.student_user_ids is not None:
            result['studentUserIds'] = self.student_user_ids
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseGroupCode') is not None:
            self.course_group_code = m.get('courseGroupCode')
        if m.get('studentUserIds') is not None:
            self.student_user_ids = m.get('studentUserIds')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class SubscribeUniversityCourseGroupResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 订阅结果
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


class SubscribeUniversityCourseGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SubscribeUniversityCourseGroupResponseBody = None,
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
            temp_model = SubscribeUniversityCourseGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteOrgRelationHeaders(TeaModel):
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


class DeleteOrgRelationRequest(TeaModel):
    def __init__(
        self,
        target_corp_id: str = None,
        auth_code: str = None,
    ):
        self.target_corp_id = target_corp_id
        self.auth_code = auth_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        if self.auth_code is not None:
            result['authCode'] = self.auth_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        if m.get('authCode') is not None:
            self.auth_code = m.get('authCode')
        return self


class DeleteOrgRelationResponseBody(TeaModel):
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


class DeleteOrgRelationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DeleteOrgRelationResponseBody = None,
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
            temp_model = DeleteOrgRelationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class StartCourseHeaders(TeaModel):
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


class StartCourseRequestLivePlayInfoList(TeaModel):
    def __init__(
        self,
        live_output_url: str = None,
        live_type: int = None,
        live_input_url: str = None,
        replay_url: str = None,
    ):
        # 直播拉流地址
        self.live_output_url = live_output_url
        # 直播流类型
        self.live_type = live_type
        # 直播推流地址
        self.live_input_url = live_input_url
        # 视频回放地址
        self.replay_url = replay_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.live_output_url is not None:
            result['liveOutputUrl'] = self.live_output_url
        if self.live_type is not None:
            result['liveType'] = self.live_type
        if self.live_input_url is not None:
            result['liveInputUrl'] = self.live_input_url
        if self.replay_url is not None:
            result['replayUrl'] = self.replay_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('liveOutputUrl') is not None:
            self.live_output_url = m.get('liveOutputUrl')
        if m.get('liveType') is not None:
            self.live_type = m.get('liveType')
        if m.get('liveInputUrl') is not None:
            self.live_input_url = m.get('liveInputUrl')
        if m.get('replayUrl') is not None:
            self.replay_url = m.get('replayUrl')
        return self


class StartCourseRequest(TeaModel):
    def __init__(
        self,
        op_user_id: str = None,
        ext: str = None,
        course_code: str = None,
        live_play_info_list: List[StartCourseRequestLivePlayInfoList] = None,
        isv_code: str = None,
    ):
        # opUserId
        self.op_user_id = op_user_id
        # 拓展字段
        self.ext = ext
        # 课程编码
        self.course_code = course_code
        # livePlayInfoList
        self.live_play_info_list = live_play_info_list
        # isvCode
        self.isv_code = isv_code

    def validate(self):
        if self.live_play_info_list:
            for k in self.live_play_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.ext is not None:
            result['ext'] = self.ext
        if self.course_code is not None:
            result['courseCode'] = self.course_code
        result['livePlayInfoList'] = []
        if self.live_play_info_list is not None:
            for k in self.live_play_info_list:
                result['livePlayInfoList'].append(k.to_map() if k else None)
        if self.isv_code is not None:
            result['isvCode'] = self.isv_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        if m.get('courseCode') is not None:
            self.course_code = m.get('courseCode')
        self.live_play_info_list = []
        if m.get('livePlayInfoList') is not None:
            for k in m.get('livePlayInfoList'):
                temp_model = StartCourseRequestLivePlayInfoList()
                self.live_play_info_list.append(temp_model.from_map(k))
        if m.get('isvCode') is not None:
            self.isv_code = m.get('isvCode')
        return self


class StartCourseResponseBodyUniversityCourseCommonResponse(TeaModel):
    def __init__(
        self,
        success: bool = None,
        course_code: str = None,
    ):
        # 调用是否成功
        self.success = success
        # 课程编码
        self.course_code = course_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        if self.course_code is not None:
            result['courseCode'] = self.course_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('courseCode') is not None:
            self.course_code = m.get('courseCode')
        return self


class StartCourseResponseBody(TeaModel):
    def __init__(
        self,
        university_course_common_response: StartCourseResponseBodyUniversityCourseCommonResponse = None,
    ):
        self.university_course_common_response = university_course_common_response

    def validate(self):
        if self.university_course_common_response:
            self.university_course_common_response.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.university_course_common_response is not None:
            result['universityCourseCommonResponse'] = self.university_course_common_response.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('universityCourseCommonResponse') is not None:
            temp_model = StartCourseResponseBodyUniversityCourseCommonResponse()
            self.university_course_common_response = temp_model.from_map(m['universityCourseCommonResponse'])
        return self


class StartCourseResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: StartCourseResponseBody = None,
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
            temp_model = StartCourseResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryPhysicalClassroomHeaders(TeaModel):
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


class QueryPhysicalClassroomRequest(TeaModel):
    def __init__(
        self,
        op_user_id: str = None,
        classroom_id: int = None,
    ):
        # 操作人id
        self.op_user_id = op_user_id
        # 教室id
        self.classroom_id = classroom_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.classroom_id is not None:
            result['classroomId'] = self.classroom_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('classroomId') is not None:
            self.classroom_id = m.get('classroomId')
        return self


class QueryPhysicalClassroomResponseBodyResult(TeaModel):
    def __init__(
        self,
        classroom_id: int = None,
        classroom_name: str = None,
        classroom_campus: str = None,
        classroom_building: str = None,
        classroom_floor: str = None,
        classroom_number: str = None,
        direct_broadcast: str = None,
    ):
        # 教室ID
        self.classroom_id = classroom_id
        # 教室名称
        self.classroom_name = classroom_name
        # 教室校区
        self.classroom_campus = classroom_campus
        # 教室教学楼
        self.classroom_building = classroom_building
        # 教室楼层
        self.classroom_floor = classroom_floor
        # 教室房间号
        self.classroom_number = classroom_number
        # 是否支持直播
        self.direct_broadcast = direct_broadcast

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.classroom_id is not None:
            result['classroomId'] = self.classroom_id
        if self.classroom_name is not None:
            result['classroomName'] = self.classroom_name
        if self.classroom_campus is not None:
            result['classroomCampus'] = self.classroom_campus
        if self.classroom_building is not None:
            result['classroomBuilding'] = self.classroom_building
        if self.classroom_floor is not None:
            result['classroomFloor'] = self.classroom_floor
        if self.classroom_number is not None:
            result['classroomNumber'] = self.classroom_number
        if self.direct_broadcast is not None:
            result['directBroadcast'] = self.direct_broadcast
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classroomId') is not None:
            self.classroom_id = m.get('classroomId')
        if m.get('classroomName') is not None:
            self.classroom_name = m.get('classroomName')
        if m.get('classroomCampus') is not None:
            self.classroom_campus = m.get('classroomCampus')
        if m.get('classroomBuilding') is not None:
            self.classroom_building = m.get('classroomBuilding')
        if m.get('classroomFloor') is not None:
            self.classroom_floor = m.get('classroomFloor')
        if m.get('classroomNumber') is not None:
            self.classroom_number = m.get('classroomNumber')
        if m.get('directBroadcast') is not None:
            self.direct_broadcast = m.get('directBroadcast')
        return self


class QueryPhysicalClassroomResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
        result: QueryPhysicalClassroomResponseBodyResult = None,
    ):
        # 请求是否成功
        self.success = success
        # 返回结果
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
            temp_model = QueryPhysicalClassroomResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class QueryPhysicalClassroomResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryPhysicalClassroomResponseBody = None,
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
            temp_model = QueryPhysicalClassroomResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateRemoteClassCourseHeaders(TeaModel):
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


class UpdateRemoteClassCourseRequestTeachingParticipant(TeaModel):
    def __init__(
        self,
        participant_id: str = None,
        corp_id: str = None,
    ):
        # 参与方ID
        self.participant_id = participant_id
        # 组织ID
        self.corp_id = corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.participant_id is not None:
            result['participantId'] = self.participant_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('participantId') is not None:
            self.participant_id = m.get('participantId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        return self


class UpdateRemoteClassCourseRequestAttendParticipants(TeaModel):
    def __init__(
        self,
        participant_id: str = None,
        corp_id: str = None,
    ):
        # 参与方ID
        self.participant_id = participant_id
        # 组织ID
        self.corp_id = corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.participant_id is not None:
            result['participantId'] = self.participant_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('participantId') is not None:
            self.participant_id = m.get('participantId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        return self


class UpdateRemoteClassCourseRequest(TeaModel):
    def __init__(
        self,
        course_name: str = None,
        start_time: int = None,
        end_time: int = None,
        teaching_participant: UpdateRemoteClassCourseRequestTeachingParticipant = None,
        attend_participants: List[UpdateRemoteClassCourseRequestAttendParticipants] = None,
        course_code: str = None,
        ding_client_id: str = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
        ding_oauth_app_id: int = None,
        ding_corp_id: str = None,
        ding_isv_org_id: int = None,
        auth_code: str = None,
    ):
        # 课程名称
        self.course_name = course_name
        # 课程开始时间
        self.start_time = start_time
        # 课程结束时间
        self.end_time = end_time
        # 授课设备
        self.teaching_participant = teaching_participant
        # 听课设备
        self.attend_participants = attend_participants
        # 课程码
        self.course_code = course_code
        self.ding_client_id = ding_client_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type
        self.ding_oauth_app_id = ding_oauth_app_id
        self.ding_corp_id = ding_corp_id
        self.ding_isv_org_id = ding_isv_org_id
        self.auth_code = auth_code

    def validate(self):
        if self.teaching_participant:
            self.teaching_participant.validate()
        if self.attend_participants:
            for k in self.attend_participants:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_name is not None:
            result['courseName'] = self.course_name
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.teaching_participant is not None:
            result['teachingParticipant'] = self.teaching_participant.to_map()
        result['attendParticipants'] = []
        if self.attend_participants is not None:
            for k in self.attend_participants:
                result['attendParticipants'].append(k.to_map() if k else None)
        if self.course_code is not None:
            result['courseCode'] = self.course_code
        if self.ding_client_id is not None:
            result['dingClientId'] = self.ding_client_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.ding_oauth_app_id is not None:
            result['dingOauthAppId'] = self.ding_oauth_app_id
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.auth_code is not None:
            result['authCode'] = self.auth_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseName') is not None:
            self.course_name = m.get('courseName')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('teachingParticipant') is not None:
            temp_model = UpdateRemoteClassCourseRequestTeachingParticipant()
            self.teaching_participant = temp_model.from_map(m['teachingParticipant'])
        self.attend_participants = []
        if m.get('attendParticipants') is not None:
            for k in m.get('attendParticipants'):
                temp_model = UpdateRemoteClassCourseRequestAttendParticipants()
                self.attend_participants.append(temp_model.from_map(k))
        if m.get('courseCode') is not None:
            self.course_code = m.get('courseCode')
        if m.get('dingClientId') is not None:
            self.ding_client_id = m.get('dingClientId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('dingOauthAppId') is not None:
            self.ding_oauth_app_id = m.get('dingOauthAppId')
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('authCode') is not None:
            self.auth_code = m.get('authCode')
        return self


class UpdateRemoteClassCourseResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
        result: str = None,
    ):
        # success
        self.success = success
        # result
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class UpdateRemoteClassCourseResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateRemoteClassCourseResponseBody = None,
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
            temp_model = UpdateRemoteClassCourseResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UnsubscribeUniversityCourseGroupHeaders(TeaModel):
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


class UnsubscribeUniversityCourseGroupRequest(TeaModel):
    def __init__(
        self,
        course_group_code: str = None,
        student_user_ids: List[str] = None,
        op_user_id: str = None,
    ):
        # 课程组
        self.course_group_code = course_group_code
        # 学生用户id
        self.student_user_ids = student_user_ids
        # opUserId
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.course_group_code is not None:
            result['courseGroupCode'] = self.course_group_code
        if self.student_user_ids is not None:
            result['studentUserIds'] = self.student_user_ids
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('courseGroupCode') is not None:
            self.course_group_code = m.get('courseGroupCode')
        if m.get('studentUserIds') is not None:
            self.student_user_ids = m.get('studentUserIds')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class UnsubscribeUniversityCourseGroupResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 取消订阅结果
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


class UnsubscribeUniversityCourseGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UnsubscribeUniversityCourseGroupResponseBody = None,
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
            temp_model = UnsubscribeUniversityCourseGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryOrgSecretKeyHeaders(TeaModel):
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


class QueryOrgSecretKeyRequest(TeaModel):
    def __init__(
        self,
        isv_code: str = None,
        op_user_id: str = None,
    ):
        # 合作方编码
        self.isv_code = isv_code
        # 操作人
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.isv_code is not None:
            result['isvCode'] = self.isv_code
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isvCode') is not None:
            self.isv_code = m.get('isvCode')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class QueryOrgSecretKeyResponseBodyUniversitySecretKeyInfo(TeaModel):
    def __init__(
        self,
        secret_key: str = None,
    ):
        # 秘钥key
        self.secret_key = secret_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.secret_key is not None:
            result['secretKey'] = self.secret_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('secretKey') is not None:
            self.secret_key = m.get('secretKey')
        return self


class QueryOrgSecretKeyResponseBody(TeaModel):
    def __init__(
        self,
        university_secret_key_info: QueryOrgSecretKeyResponseBodyUniversitySecretKeyInfo = None,
    ):
        # 秘钥信息
        self.university_secret_key_info = university_secret_key_info

    def validate(self):
        if self.university_secret_key_info:
            self.university_secret_key_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.university_secret_key_info is not None:
            result['universitySecretKeyInfo'] = self.university_secret_key_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('universitySecretKeyInfo') is not None:
            temp_model = QueryOrgSecretKeyResponseBodyUniversitySecretKeyInfo()
            self.university_secret_key_info = temp_model.from_map(m['universitySecretKeyInfo'])
        return self


class QueryOrgSecretKeyResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryOrgSecretKeyResponseBody = None,
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
            temp_model = QueryOrgSecretKeyResponseBody()
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


class DeletePhysicalClassroomHeaders(TeaModel):
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


class DeletePhysicalClassroomRequest(TeaModel):
    def __init__(
        self,
        op_user_id: str = None,
        classroom_id: int = None,
    ):
        # 操作人id
        self.op_user_id = op_user_id
        # 教室主键
        self.classroom_id = classroom_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.classroom_id is not None:
            result['classroomId'] = self.classroom_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('classroomId') is not None:
            self.classroom_id = m.get('classroomId')
        return self


class DeletePhysicalClassroomResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 是否成功
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


class DeletePhysicalClassroomResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DeletePhysicalClassroomResponseBody = None,
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
            temp_model = DeletePhysicalClassroomResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryOrgRelationListHeaders(TeaModel):
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


class QueryOrgRelationListRequest(TeaModel):
    def __init__(
        self,
        operator: str = None,
    ):
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


class QueryOrgRelationListResponseBodyResult(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        name: str = None,
        device_count: int = None,
    ):
        self.corp_id = corp_id
        self.name = name
        self.device_count = device_count

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.name is not None:
            result['name'] = self.name
        if self.device_count is not None:
            result['deviceCount'] = self.device_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('deviceCount') is not None:
            self.device_count = m.get('deviceCount')
        return self


class QueryOrgRelationListResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
        result: List[QueryOrgRelationListResponseBodyResult] = None,
    ):
        # Id of the request
        self.success = success
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
        if self.success is not None:
            result['success'] = self.success
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = QueryOrgRelationListResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class QueryOrgRelationListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryOrgRelationListResponseBody = None,
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
            temp_model = QueryOrgRelationListResponseBody()
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


class DeleteUniversityStudentHeaders(TeaModel):
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


class DeleteUniversityStudentRequest(TeaModel):
    def __init__(
        self,
        class_id: int = None,
        student_user_id: str = None,
        op_user_id: str = None,
    ):
        # 班级ID
        self.class_id = class_id
        # 学生用户ID
        self.student_user_id = student_user_id
        # 操作人用户ID
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_id is not None:
            result['classId'] = self.class_id
        if self.student_user_id is not None:
            result['studentUserId'] = self.student_user_id
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        if m.get('studentUserId') is not None:
            self.student_user_id = m.get('studentUserId')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class DeleteUniversityStudentResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 返回结果
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


class DeleteUniversityStudentResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DeleteUniversityStudentResponseBody = None,
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
            temp_model = DeleteUniversityStudentResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class EndCourseHeaders(TeaModel):
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


class EndCourseRequestLivePlayInfoList(TeaModel):
    def __init__(
        self,
        live_output_url: str = None,
        live_type: int = None,
        live_input_url: str = None,
        replay_url: str = None,
    ):
        # 直播拉流地址
        self.live_output_url = live_output_url
        # 直播流类型
        self.live_type = live_type
        # 直播推流地址
        self.live_input_url = live_input_url
        # 回放视频地址
        self.replay_url = replay_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.live_output_url is not None:
            result['liveOutputUrl'] = self.live_output_url
        if self.live_type is not None:
            result['liveType'] = self.live_type
        if self.live_input_url is not None:
            result['liveInputUrl'] = self.live_input_url
        if self.replay_url is not None:
            result['replayUrl'] = self.replay_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('liveOutputUrl') is not None:
            self.live_output_url = m.get('liveOutputUrl')
        if m.get('liveType') is not None:
            self.live_type = m.get('liveType')
        if m.get('liveInputUrl') is not None:
            self.live_input_url = m.get('liveInputUrl')
        if m.get('replayUrl') is not None:
            self.replay_url = m.get('replayUrl')
        return self


class EndCourseRequest(TeaModel):
    def __init__(
        self,
        op_user_id: str = None,
        ext: str = None,
        course_code: str = None,
        live_play_info_list: List[EndCourseRequestLivePlayInfoList] = None,
        isv_code: str = None,
    ):
        # 用户id
        self.op_user_id = op_user_id
        # 拓展字段
        self.ext = ext
        # 课程编码
        self.course_code = course_code
        # 直播流信息
        self.live_play_info_list = live_play_info_list
        # isv编码
        self.isv_code = isv_code

    def validate(self):
        if self.live_play_info_list:
            for k in self.live_play_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.ext is not None:
            result['ext'] = self.ext
        if self.course_code is not None:
            result['courseCode'] = self.course_code
        result['livePlayInfoList'] = []
        if self.live_play_info_list is not None:
            for k in self.live_play_info_list:
                result['livePlayInfoList'].append(k.to_map() if k else None)
        if self.isv_code is not None:
            result['isvCode'] = self.isv_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        if m.get('courseCode') is not None:
            self.course_code = m.get('courseCode')
        self.live_play_info_list = []
        if m.get('livePlayInfoList') is not None:
            for k in m.get('livePlayInfoList'):
                temp_model = EndCourseRequestLivePlayInfoList()
                self.live_play_info_list.append(temp_model.from_map(k))
        if m.get('isvCode') is not None:
            self.isv_code = m.get('isvCode')
        return self


class EndCourseResponseBodyUniversityCourseCommonResponse(TeaModel):
    def __init__(
        self,
        success: bool = None,
        course_code: str = None,
    ):
        # 调用是否成功
        self.success = success
        # 课程编码
        self.course_code = course_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        if self.course_code is not None:
            result['courseCode'] = self.course_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('courseCode') is not None:
            self.course_code = m.get('courseCode')
        return self


class EndCourseResponseBody(TeaModel):
    def __init__(
        self,
        university_course_common_response: EndCourseResponseBodyUniversityCourseCommonResponse = None,
    ):
        self.university_course_common_response = university_course_common_response

    def validate(self):
        if self.university_course_common_response:
            self.university_course_common_response.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.university_course_common_response is not None:
            result['universityCourseCommonResponse'] = self.university_course_common_response.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('universityCourseCommonResponse') is not None:
            temp_model = EndCourseResponseBodyUniversityCourseCommonResponse()
            self.university_course_common_response = temp_model.from_map(m['universityCourseCommonResponse'])
        return self


class EndCourseResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: EndCourseResponseBody = None,
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
            temp_model = EndCourseResponseBody()
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


class CreateUniversityTeacherHeaders(TeaModel):
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


class CreateUniversityTeacherRequest(TeaModel):
    def __init__(
        self,
        ding_isv_org_id: int = None,
        class_id: int = None,
        role: str = None,
        teacher_user_id: str = None,
        ding_suite_key: str = None,
        op_user_id: str = None,
        ding_org_id: int = None,
    ):
        # isvOrgId
        self.ding_isv_org_id = ding_isv_org_id
        # 班级ID
        self.class_id = class_id
        # 角色
        self.role = role
        # 教师用户ID
        self.teacher_user_id = teacher_user_id
        # suiteKey
        self.ding_suite_key = ding_suite_key
        # 操作人用户ID
        self.op_user_id = op_user_id
        # opOrgId
        self.ding_org_id = ding_org_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.class_id is not None:
            result['classId'] = self.class_id
        if self.role is not None:
            result['role'] = self.role
        if self.teacher_user_id is not None:
            result['teacherUserId'] = self.teacher_user_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        if m.get('role') is not None:
            self.role = m.get('role')
        if m.get('teacherUserId') is not None:
            self.teacher_user_id = m.get('teacherUserId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        return self


class CreateUniversityTeacherResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 返回结果
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


class CreateUniversityTeacherResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateUniversityTeacherResponseBody = None,
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
            temp_model = CreateUniversityTeacherResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


