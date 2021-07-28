# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class QueryUserInfoHeaders(TeaModel):
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


class QueryUserInfoResponseBodyContentJob(TeaModel):
    def __init__(
        self,
        code: str = None,
        biz_type: str = None,
        category: str = None,
        display_name: str = None,
    ):
        # 标签Code
        self.code = code
        # 标签类型
        self.biz_type = biz_type
        # 分类
        self.category = category
        # 展示名称
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.category is not None:
            result['category'] = self.category
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class QueryUserInfoResponseBodyContentJobStatus(TeaModel):
    def __init__(
        self,
        code: str = None,
        biz_type: str = None,
        category: str = None,
        display_name: str = None,
    ):
        # 标签Code
        self.code = code
        # 标签类型
        self.biz_type = biz_type
        # 分类
        self.category = category
        # 展示名称
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.category is not None:
            result['category'] = self.category
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class QueryUserInfoResponseBodyContentUserProb(TeaModel):
    def __init__(
        self,
        code: str = None,
        biz_type: str = None,
        category: str = None,
        display_name: str = None,
    ):
        # 标签Code
        self.code = code
        # 标签类型
        self.biz_type = biz_type
        # 分类
        self.category = category
        # 展示名称
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.category is not None:
            result['category'] = self.category
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class QueryUserInfoResponseBodyContentGroup(TeaModel):
    def __init__(
        self,
        id: int = None,
        name: str = None,
        dept_id: int = None,
        dept_name: str = None,
    ):
        # 医疗组Id
        self.id = id
        # 医疗组名称
        self.name = name
        # 医疗组所在科室Id
        self.dept_id = dept_id
        # 医疗组所在科室名称
        self.dept_name = dept_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        return self


class QueryUserInfoResponseBodyContentDept(TeaModel):
    def __init__(
        self,
        id: int = None,
        name: str = None,
    ):
        # 科室Id
        self.id = id
        # 科室名称
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class QueryUserInfoResponseBodyContentJobStatusList(TeaModel):
    def __init__(
        self,
        code: str = None,
        biz_type: str = None,
        category: str = None,
        display_name: str = None,
    ):
        # 标签Code
        self.code = code
        # 标签类型
        self.biz_type = biz_type
        # 分类
        self.category = category
        # 展示名称
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.category is not None:
            result['category'] = self.category
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class QueryUserInfoResponseBodyContent(TeaModel):
    def __init__(
        self,
        uid: str = None,
        user_name: str = None,
        job: QueryUserInfoResponseBodyContentJob = None,
        job_num: str = None,
        job_status: QueryUserInfoResponseBodyContentJobStatus = None,
        user_prob: QueryUserInfoResponseBodyContentUserProb = None,
        group: List[QueryUserInfoResponseBodyContentGroup] = None,
        dept: List[QueryUserInfoResponseBodyContentDept] = None,
        comments: str = None,
        job_status_list: List[QueryUserInfoResponseBodyContentJobStatusList] = None,
    ):
        # 用户Id
        self.uid = uid
        # 用户名称
        self.user_name = user_name
        # 职称标签
        self.job = job
        # 工号
        self.job_num = job_num
        # 工作状态标签, 已废弃, 请使用jobStatusList字段
        self.job_status = job_status
        # 人员属性标签
        self.user_prob = user_prob
        # 所在医疗组
        self.group = group
        # 所在科室
        self.dept = dept
        # comments
        self.comments = comments
        # 工作状态标签
        self.job_status_list = job_status_list

    def validate(self):
        if self.job:
            self.job.validate()
        if self.job_status:
            self.job_status.validate()
        if self.user_prob:
            self.user_prob.validate()
        if self.group:
            for k in self.group:
                if k:
                    k.validate()
        if self.dept:
            for k in self.dept:
                if k:
                    k.validate()
        if self.job_status_list:
            for k in self.job_status_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.uid is not None:
            result['uid'] = self.uid
        if self.user_name is not None:
            result['userName'] = self.user_name
        if self.job is not None:
            result['job'] = self.job.to_map()
        if self.job_num is not None:
            result['jobNum'] = self.job_num
        if self.job_status is not None:
            result['jobStatus'] = self.job_status.to_map()
        if self.user_prob is not None:
            result['userProb'] = self.user_prob.to_map()
        result['group'] = []
        if self.group is not None:
            for k in self.group:
                result['group'].append(k.to_map() if k else None)
        result['dept'] = []
        if self.dept is not None:
            for k in self.dept:
                result['dept'].append(k.to_map() if k else None)
        if self.comments is not None:
            result['comments'] = self.comments
        result['jobStatusList'] = []
        if self.job_status_list is not None:
            for k in self.job_status_list:
                result['jobStatusList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('uid') is not None:
            self.uid = m.get('uid')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        if m.get('job') is not None:
            temp_model = QueryUserInfoResponseBodyContentJob()
            self.job = temp_model.from_map(m['job'])
        if m.get('jobNum') is not None:
            self.job_num = m.get('jobNum')
        if m.get('jobStatus') is not None:
            temp_model = QueryUserInfoResponseBodyContentJobStatus()
            self.job_status = temp_model.from_map(m['jobStatus'])
        if m.get('userProb') is not None:
            temp_model = QueryUserInfoResponseBodyContentUserProb()
            self.user_prob = temp_model.from_map(m['userProb'])
        self.group = []
        if m.get('group') is not None:
            for k in m.get('group'):
                temp_model = QueryUserInfoResponseBodyContentGroup()
                self.group.append(temp_model.from_map(k))
        self.dept = []
        if m.get('dept') is not None:
            for k in m.get('dept'):
                temp_model = QueryUserInfoResponseBodyContentDept()
                self.dept.append(temp_model.from_map(k))
        if m.get('comments') is not None:
            self.comments = m.get('comments')
        self.job_status_list = []
        if m.get('jobStatusList') is not None:
            for k in m.get('jobStatusList'):
                temp_model = QueryUserInfoResponseBodyContentJobStatusList()
                self.job_status_list.append(temp_model.from_map(k))
        return self


class QueryUserInfoResponseBody(TeaModel):
    def __init__(
        self,
        content: QueryUserInfoResponseBodyContent = None,
    ):
        # 人员详情
        self.content = content

    def validate(self):
        if self.content:
            self.content.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            temp_model = QueryUserInfoResponseBodyContent()
            self.content = temp_model.from_map(m['content'])
        return self


class QueryUserInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryUserInfoResponseBody = None,
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
            temp_model = QueryUserInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryAllMemberByDeptHeaders(TeaModel):
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


class QueryAllMemberByDeptRequest(TeaModel):
    def __init__(
        self,
        page_size: int = None,
        page_number: int = None,
    ):
        # 分页查询页容量
        self.page_size = page_size
        # 分页查询页码
        self.page_number = page_number

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        return self


class QueryAllMemberByDeptResponseBodyContent(TeaModel):
    def __init__(
        self,
        uid: str = None,
        user_name: str = None,
        job_num: str = None,
    ):
        # 用户Id
        self.uid = uid
        # 用户名称
        self.user_name = user_name
        # 工号
        self.job_num = job_num

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.uid is not None:
            result['uid'] = self.uid
        if self.user_name is not None:
            result['userName'] = self.user_name
        if self.job_num is not None:
            result['jobNum'] = self.job_num
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('uid') is not None:
            self.uid = m.get('uid')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        if m.get('jobNum') is not None:
            self.job_num = m.get('jobNum')
        return self


class QueryAllMemberByDeptResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryAllMemberByDeptResponseBodyContent] = None,
        total_pages: int = None,
        total_count: int = None,
        current_page: int = None,
    ):
        # 人员列表
        self.content = content
        # 总页数
        self.total_pages = total_pages
        # 数据总量
        self.total_count = total_count
        # 当前页码
        self.current_page = current_page

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        if self.total_pages is not None:
            result['totalPages'] = self.total_pages
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        if self.current_page is not None:
            result['currentPage'] = self.current_page
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryAllMemberByDeptResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        if m.get('totalPages') is not None:
            self.total_pages = m.get('totalPages')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        return self


class QueryAllMemberByDeptResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryAllMemberByDeptResponseBody = None,
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
            temp_model = QueryAllMemberByDeptResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryAllMemberByGroupHeaders(TeaModel):
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


class QueryAllMemberByGroupRequest(TeaModel):
    def __init__(
        self,
        page_size: int = None,
        page_number: int = None,
    ):
        # 分页查询分页大小
        self.page_size = page_size
        # 分页查询页码
        self.page_number = page_number

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        return self


class QueryAllMemberByGroupResponseBodyContent(TeaModel):
    def __init__(
        self,
        uid: str = None,
        user_name: str = None,
        job_num: str = None,
    ):
        # 用户Id
        self.uid = uid
        # 用户名称
        self.user_name = user_name
        # 工号
        self.job_num = job_num

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.uid is not None:
            result['uid'] = self.uid
        if self.user_name is not None:
            result['userName'] = self.user_name
        if self.job_num is not None:
            result['jobNum'] = self.job_num
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('uid') is not None:
            self.uid = m.get('uid')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        if m.get('jobNum') is not None:
            self.job_num = m.get('jobNum')
        return self


class QueryAllMemberByGroupResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryAllMemberByGroupResponseBodyContent] = None,
        total_pages: int = None,
        total_count: int = None,
        current_page: int = None,
    ):
        # 人员列表
        self.content = content
        # 总页数
        self.total_pages = total_pages
        # 数据总量
        self.total_count = total_count
        # 当前页码
        self.current_page = current_page

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        if self.total_pages is not None:
            result['totalPages'] = self.total_pages
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        if self.current_page is not None:
            result['currentPage'] = self.current_page
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryAllMemberByGroupResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        if m.get('totalPages') is not None:
            self.total_pages = m.get('totalPages')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        return self


class QueryAllMemberByGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryAllMemberByGroupResponseBody = None,
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
            temp_model = QueryAllMemberByGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryUserRolesHeaders(TeaModel):
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


class QueryUserRolesResponseBodyContent(TeaModel):
    def __init__(
        self,
        role_code: str = None,
        role_name: str = None,
    ):
        # 角色编码
        self.role_code = role_code
        # 角色名称
        self.role_name = role_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.role_code is not None:
            result['roleCode'] = self.role_code
        if self.role_name is not None:
            result['roleName'] = self.role_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('roleCode') is not None:
            self.role_code = m.get('roleCode')
        if m.get('roleName') is not None:
            self.role_name = m.get('roleName')
        return self


class QueryUserRolesResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryUserRolesResponseBodyContent] = None,
    ):
        # 扩展属性
        self.content = content

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryUserRolesResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        return self


class QueryUserRolesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryUserRolesResponseBody = None,
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
            temp_model = QueryUserRolesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryAllGroupHeaders(TeaModel):
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


class QueryAllGroupRequest(TeaModel):
    def __init__(
        self,
        page_size: int = None,
        page_number: int = None,
    ):
        # 分页查询页容量
        self.page_size = page_size
        # 分页查询页码
        self.page_number = page_number

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        return self


class QueryAllGroupResponseBodyContent(TeaModel):
    def __init__(
        self,
        id: int = None,
        name: str = None,
        dept_id: int = None,
    ):
        # 医疗组Id
        self.id = id
        # 医疗组名称
        self.name = name
        # 所在科室Id
        self.dept_id = dept_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        return self


class QueryAllGroupResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryAllGroupResponseBodyContent] = None,
        total_pages: int = None,
        total_count: int = None,
        current_page: int = None,
    ):
        # Id of the request
        self.content = content
        # 总页数
        self.total_pages = total_pages
        # 数据总量
        self.total_count = total_count
        # 当前页码
        self.current_page = current_page

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        if self.total_pages is not None:
            result['totalPages'] = self.total_pages
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        if self.current_page is not None:
            result['currentPage'] = self.current_page
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryAllGroupResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        if m.get('totalPages') is not None:
            self.total_pages = m.get('totalPages')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        return self


class QueryAllGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryAllGroupResponseBody = None,
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
            temp_model = QueryAllGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryAllGroupsInDeptHeaders(TeaModel):
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


class QueryAllGroupsInDeptRequest(TeaModel):
    def __init__(
        self,
        page_size: int = None,
        page_number: int = None,
    ):
        # 分页查询页容量
        self.page_size = page_size
        # 分页查询页码
        self.page_number = page_number

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        return self


class QueryAllGroupsInDeptResponseBodyContent(TeaModel):
    def __init__(
        self,
        id: int = None,
        name: str = None,
        dept_id: int = None,
    ):
        # 医疗组Id
        self.id = id
        # 医疗组名称
        self.name = name
        # 所在科室Id
        self.dept_id = dept_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        return self


class QueryAllGroupsInDeptResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryAllGroupsInDeptResponseBodyContent] = None,
        total_pages: int = None,
        total_count: int = None,
        current_page: int = None,
    ):
        # Id of the request
        self.content = content
        # 总页数
        self.total_pages = total_pages
        # 数据总量
        self.total_count = total_count
        # 当前页码
        self.current_page = current_page

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        if self.total_pages is not None:
            result['totalPages'] = self.total_pages
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        if self.current_page is not None:
            result['currentPage'] = self.current_page
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryAllGroupsInDeptResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        if m.get('totalPages') is not None:
            self.total_pages = m.get('totalPages')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        return self


class QueryAllGroupsInDeptResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryAllGroupsInDeptResponseBody = None,
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
            temp_model = QueryAllGroupsInDeptResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryBizOptLogHeaders(TeaModel):
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


class QueryBizOptLogRequest(TeaModel):
    def __init__(
        self,
        next_token: int = None,
        max_results: int = None,
    ):
        # 拉取记录的起始位置，默认从上次拉取的最后位置开始
        self.next_token = next_token
        # 每次拉取的数据量，最大200条
        self.max_results = max_results

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        return self


class QueryBizOptLogResponseBodyContent(TeaModel):
    def __init__(
        self,
        id: int = None,
        data_type: int = None,
        biz_type: int = None,
        opt_time: int = None,
        opt_user_code: str = None,
        opt_user_name: str = None,
        opt_job_number: str = None,
        opt_type: int = None,
        opt_biz_type: int = None,
        opt_object_code: str = None,
        opt_object_user_job_no: str = None,
        opt_object_name: str = None,
        opt_success: int = None,
        remark: str = None,
        opt_before_data: str = None,
        opt_after_data: str = None,
        opt_extend: str = None,
    ):
        # 日志ID
        self.id = id
        # 数据类型
        self.data_type = data_type
        # 业务类型
        self.biz_type = biz_type
        # 操作时间 时间戳
        self.opt_time = opt_time
        # 操作用户code
        self.opt_user_code = opt_user_code
        # 操作用户名称
        self.opt_user_name = opt_user_name
        # 操作者工号
        self.opt_job_number = opt_job_number
        # 操作类型
        self.opt_type = opt_type
        # 操作业务类型
        self.opt_biz_type = opt_biz_type
        # 操作对象code，人员code，或者部门code
        self.opt_object_code = opt_object_code
        # 操作对象人员工号
        self.opt_object_user_job_no = opt_object_user_job_no
        # 操作对象名称
        self.opt_object_name = opt_object_name
        # 操作是否成功
        self.opt_success = opt_success
        # 备注
        self.remark = remark
        # 操作前对象数据快照，json格式
        self.opt_before_data = opt_before_data
        # 操作后对象数据快照，json格式
        self.opt_after_data = opt_after_data
        # 扩展信息，map json格式
        self.opt_extend = opt_extend

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.data_type is not None:
            result['dataType'] = self.data_type
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.opt_time is not None:
            result['optTime'] = self.opt_time
        if self.opt_user_code is not None:
            result['optUserCode'] = self.opt_user_code
        if self.opt_user_name is not None:
            result['optUserName'] = self.opt_user_name
        if self.opt_job_number is not None:
            result['optJobNumber'] = self.opt_job_number
        if self.opt_type is not None:
            result['optType'] = self.opt_type
        if self.opt_biz_type is not None:
            result['optBizType'] = self.opt_biz_type
        if self.opt_object_code is not None:
            result['optObjectCode'] = self.opt_object_code
        if self.opt_object_user_job_no is not None:
            result['optObjectUserJobNo'] = self.opt_object_user_job_no
        if self.opt_object_name is not None:
            result['optObjectName'] = self.opt_object_name
        if self.opt_success is not None:
            result['optSuccess'] = self.opt_success
        if self.remark is not None:
            result['remark'] = self.remark
        if self.opt_before_data is not None:
            result['optBeforeData'] = self.opt_before_data
        if self.opt_after_data is not None:
            result['optAfterData'] = self.opt_after_data
        if self.opt_extend is not None:
            result['optExtend'] = self.opt_extend
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('dataType') is not None:
            self.data_type = m.get('dataType')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('optTime') is not None:
            self.opt_time = m.get('optTime')
        if m.get('optUserCode') is not None:
            self.opt_user_code = m.get('optUserCode')
        if m.get('optUserName') is not None:
            self.opt_user_name = m.get('optUserName')
        if m.get('optJobNumber') is not None:
            self.opt_job_number = m.get('optJobNumber')
        if m.get('optType') is not None:
            self.opt_type = m.get('optType')
        if m.get('optBizType') is not None:
            self.opt_biz_type = m.get('optBizType')
        if m.get('optObjectCode') is not None:
            self.opt_object_code = m.get('optObjectCode')
        if m.get('optObjectUserJobNo') is not None:
            self.opt_object_user_job_no = m.get('optObjectUserJobNo')
        if m.get('optObjectName') is not None:
            self.opt_object_name = m.get('optObjectName')
        if m.get('optSuccess') is not None:
            self.opt_success = m.get('optSuccess')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('optBeforeData') is not None:
            self.opt_before_data = m.get('optBeforeData')
        if m.get('optAfterData') is not None:
            self.opt_after_data = m.get('optAfterData')
        if m.get('optExtend') is not None:
            self.opt_extend = m.get('optExtend')
        return self


class QueryBizOptLogResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryBizOptLogResponseBodyContent] = None,
        next_token: int = None,
    ):
        # content
        self.content = content
        # 下次拉取数据的起始位置
        self.next_token = next_token

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryBizOptLogResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class QueryBizOptLogResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryBizOptLogResponseBody = None,
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
            temp_model = QueryBizOptLogResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryUserProbCodeDictionaryHeaders(TeaModel):
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


class QueryUserProbCodeDictionaryResponseBodyContent(TeaModel):
    def __init__(
        self,
        code: str = None,
        category: str = None,
        display_name: str = None,
    ):
        # 固定字段标识
        self.code = code
        # 分类
        self.category = category
        # 展示名字
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.category is not None:
            result['category'] = self.category
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class QueryUserProbCodeDictionaryResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryUserProbCodeDictionaryResponseBodyContent] = None,
    ):
        # code列表
        self.content = content

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryUserProbCodeDictionaryResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        return self


class QueryUserProbCodeDictionaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryUserProbCodeDictionaryResponseBody = None,
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
            temp_model = QueryUserProbCodeDictionaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryJobStatusCodeDictionaryHeaders(TeaModel):
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


class QueryJobStatusCodeDictionaryResponseBodyContent(TeaModel):
    def __init__(
        self,
        code: str = None,
        category: str = None,
        display_name: str = None,
    ):
        # 固定字段标识
        self.code = code
        # 分类
        self.category = category
        # 展示名字
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.category is not None:
            result['category'] = self.category
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class QueryJobStatusCodeDictionaryResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryJobStatusCodeDictionaryResponseBodyContent] = None,
    ):
        # code列表
        self.content = content

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryJobStatusCodeDictionaryResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        return self


class QueryJobStatusCodeDictionaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryJobStatusCodeDictionaryResponseBody = None,
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
            temp_model = QueryJobStatusCodeDictionaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryDepartmentInfoHeaders(TeaModel):
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


class QueryDepartmentInfoResponseBodyContentLeaderJob(TeaModel):
    def __init__(
        self,
        code: str = None,
        biz_type: str = None,
        category: str = None,
        display_name: str = None,
    ):
        # 标签Code
        self.code = code
        # 业务类型
        self.biz_type = biz_type
        # 分类
        self.category = category
        # 展示名称
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.category is not None:
            result['category'] = self.category
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class QueryDepartmentInfoResponseBodyContentLeader(TeaModel):
    def __init__(
        self,
        name: str = None,
        user_id: str = None,
        job_number: str = None,
        job: QueryDepartmentInfoResponseBodyContentLeaderJob = None,
    ):
        # 姓名
        self.name = name
        # 人员Id
        self.user_id = user_id
        # 工号
        self.job_number = job_number
        # 工作标签
        self.job = job

    def validate(self):
        if self.job:
            self.job.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.job_number is not None:
            result['jobNumber'] = self.job_number
        if self.job is not None:
            result['job'] = self.job.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('jobNumber') is not None:
            self.job_number = m.get('jobNumber')
        if m.get('job') is not None:
            temp_model = QueryDepartmentInfoResponseBodyContentLeaderJob()
            self.job = temp_model.from_map(m['job'])
        return self


class QueryDepartmentInfoResponseBodyContentResidentLeaderJob(TeaModel):
    def __init__(
        self,
        code: str = None,
        biz_type: str = None,
        category: str = None,
        display_name: str = None,
    ):
        # 标签Code
        self.code = code
        # 业务类型
        self.biz_type = biz_type
        # 分类
        self.category = category
        # 展示名称
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.category is not None:
            result['category'] = self.category
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class QueryDepartmentInfoResponseBodyContentResidentLeader(TeaModel):
    def __init__(
        self,
        name: str = None,
        user_id: str = None,
        job_number: str = None,
        job: QueryDepartmentInfoResponseBodyContentResidentLeaderJob = None,
    ):
        # 姓名
        self.name = name
        # 人员Id
        self.user_id = user_id
        # 工号
        self.job_number = job_number
        # 工作标签
        self.job = job

    def validate(self):
        if self.job:
            self.job.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.job_number is not None:
            result['jobNumber'] = self.job_number
        if self.job is not None:
            result['job'] = self.job.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('jobNumber') is not None:
            self.job_number = m.get('jobNumber')
        if m.get('job') is not None:
            temp_model = QueryDepartmentInfoResponseBodyContentResidentLeaderJob()
            self.job = temp_model.from_map(m['job'])
        return self


class QueryDepartmentInfoResponseBodyContent(TeaModel):
    def __init__(
        self,
        id: int = None,
        name: str = None,
        leader: QueryDepartmentInfoResponseBodyContentLeader = None,
        resident_leader: QueryDepartmentInfoResponseBodyContentResidentLeader = None,
    ):
        # 科室Id
        self.id = id
        # 科室名称
        self.name = name
        # 科室主任
        self.leader = leader
        # 住院总医师
        self.resident_leader = resident_leader

    def validate(self):
        if self.leader:
            self.leader.validate()
        if self.resident_leader:
            self.resident_leader.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.leader is not None:
            result['leader'] = self.leader.to_map()
        if self.resident_leader is not None:
            result['residentLeader'] = self.resident_leader.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('leader') is not None:
            temp_model = QueryDepartmentInfoResponseBodyContentLeader()
            self.leader = temp_model.from_map(m['leader'])
        if m.get('residentLeader') is not None:
            temp_model = QueryDepartmentInfoResponseBodyContentResidentLeader()
            self.resident_leader = temp_model.from_map(m['residentLeader'])
        return self


class QueryDepartmentInfoResponseBody(TeaModel):
    def __init__(
        self,
        content: QueryDepartmentInfoResponseBodyContent = None,
    ):
        # 科室详情
        self.content = content

    def validate(self):
        if self.content:
            self.content.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            temp_model = QueryDepartmentInfoResponseBodyContent()
            self.content = temp_model.from_map(m['content'])
        return self


class QueryDepartmentInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryDepartmentInfoResponseBody = None,
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
            temp_model = QueryDepartmentInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateUserExtendInfoHeaders(TeaModel):
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


class UpdateUserExtendInfoRequest(TeaModel):
    def __init__(
        self,
        job_code: str = None,
        user_prob_code: str = None,
        job_status_code: List[str] = None,
        comments: str = None,
    ):
        # 职称code
        self.job_code = job_code
        # 用户属性code
        self.user_prob_code = user_prob_code
        # 工作状态code
        self.job_status_code = job_status_code
        # comments
        self.comments = comments

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.job_code is not None:
            result['jobCode'] = self.job_code
        if self.user_prob_code is not None:
            result['userProbCode'] = self.user_prob_code
        if self.job_status_code is not None:
            result['jobStatusCode'] = self.job_status_code
        if self.comments is not None:
            result['comments'] = self.comments
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('jobCode') is not None:
            self.job_code = m.get('jobCode')
        if m.get('userProbCode') is not None:
            self.user_prob_code = m.get('userProbCode')
        if m.get('jobStatusCode') is not None:
            self.job_status_code = m.get('jobStatusCode')
        if m.get('comments') is not None:
            self.comments = m.get('comments')
        return self


class UpdateUserExtendInfoResponse(TeaModel):
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


class QueryAllDoctorsHeaders(TeaModel):
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


class QueryAllDoctorsRequest(TeaModel):
    def __init__(
        self,
        page_size: int = None,
        page_num: int = None,
    ):
        # 分页查询页容量
        self.page_size = page_size
        # 分页查询页码
        self.page_num = page_num

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.page_num is not None:
            result['pageNum'] = self.page_num
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('pageNum') is not None:
            self.page_num = m.get('pageNum')
        return self


class QueryAllDoctorsResponseBodyContent(TeaModel):
    def __init__(
        self,
        uid: str = None,
        user_name: str = None,
        job_num: str = None,
    ):
        # 用户Id
        self.uid = uid
        # 用户名称
        self.user_name = user_name
        # 工号
        self.job_num = job_num

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.uid is not None:
            result['uid'] = self.uid
        if self.user_name is not None:
            result['userName'] = self.user_name
        if self.job_num is not None:
            result['jobNum'] = self.job_num
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('uid') is not None:
            self.uid = m.get('uid')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        if m.get('jobNum') is not None:
            self.job_num = m.get('jobNum')
        return self


class QueryAllDoctorsResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryAllDoctorsResponseBodyContent] = None,
        total_pages: int = None,
        total_count: int = None,
        current_page: int = None,
    ):
        # 人员列表
        self.content = content
        # 总页数
        self.total_pages = total_pages
        # 数据总量
        self.total_count = total_count
        # 当前页码
        self.current_page = current_page

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        if self.total_pages is not None:
            result['totalPages'] = self.total_pages
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        if self.current_page is not None:
            result['currentPage'] = self.current_page
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryAllDoctorsResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        if m.get('totalPages') is not None:
            self.total_pages = m.get('totalPages')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        return self


class QueryAllDoctorsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryAllDoctorsResponseBody = None,
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
            temp_model = QueryAllDoctorsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryUserExtInfoHeaders(TeaModel):
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


class QueryUserExtInfoResponseBodyContent(TeaModel):
    def __init__(
        self,
        user_extend_key: str = None,
        user_extend_value: str = None,
        user_extend_display_name: str = None,
    ):
        # 扩展属性Key
        self.user_extend_key = user_extend_key
        # 扩展属性值
        self.user_extend_value = user_extend_value
        # 扩展属性描述
        self.user_extend_display_name = user_extend_display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_extend_key is not None:
            result['userExtendKey'] = self.user_extend_key
        if self.user_extend_value is not None:
            result['userExtendValue'] = self.user_extend_value
        if self.user_extend_display_name is not None:
            result['userExtendDisplayName'] = self.user_extend_display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userExtendKey') is not None:
            self.user_extend_key = m.get('userExtendKey')
        if m.get('userExtendValue') is not None:
            self.user_extend_value = m.get('userExtendValue')
        if m.get('userExtendDisplayName') is not None:
            self.user_extend_display_name = m.get('userExtendDisplayName')
        return self


class QueryUserExtInfoResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryUserExtInfoResponseBodyContent] = None,
    ):
        # 扩展属性
        self.content = content

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryUserExtInfoResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        return self


class QueryUserExtInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryUserExtInfoResponseBody = None,
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
            temp_model = QueryUserExtInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryJobCodeDictionaryHeaders(TeaModel):
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


class QueryJobCodeDictionaryResponseBodyContent(TeaModel):
    def __init__(
        self,
        code: str = None,
        category: str = None,
        display_name: str = None,
        doctor_type: str = None,
    ):
        # 固定字段标识
        self.code = code
        # 分类
        self.category = category
        # 展示名字
        self.display_name = display_name
        # 1:医师,0:非医师,2:待补充
        self.doctor_type = doctor_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.category is not None:
            result['category'] = self.category
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.doctor_type is not None:
            result['doctorType'] = self.doctor_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('doctorType') is not None:
            self.doctor_type = m.get('doctorType')
        return self


class QueryJobCodeDictionaryResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryJobCodeDictionaryResponseBodyContent] = None,
    ):
        # code列表
        self.content = content

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryJobCodeDictionaryResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        return self


class QueryJobCodeDictionaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryJobCodeDictionaryResponseBody = None,
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
            temp_model = QueryJobCodeDictionaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryAllDepartmentHeaders(TeaModel):
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


class QueryAllDepartmentRequest(TeaModel):
    def __init__(
        self,
        page_size: int = None,
        page_number: int = None,
    ):
        # 分页查询分页大小
        self.page_size = page_size
        # 分页查询页码
        self.page_number = page_number

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        return self


class QueryAllDepartmentResponseBodyContent(TeaModel):
    def __init__(
        self,
        id: int = None,
        name: str = None,
    ):
        # 科室Id
        self.id = id
        # 科室名称
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class QueryAllDepartmentResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryAllDepartmentResponseBodyContent] = None,
        total_pages: int = None,
        total_count: int = None,
        current_page: int = None,
    ):
        # 科室列表
        self.content = content
        # 总页数
        self.total_pages = total_pages
        # 数据总量
        self.total_count = total_count
        # 当前页码
        self.current_page = current_page

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        if self.total_pages is not None:
            result['totalPages'] = self.total_pages
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        if self.current_page is not None:
            result['currentPage'] = self.current_page
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryAllDepartmentResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        if m.get('totalPages') is not None:
            self.total_pages = m.get('totalPages')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        return self


class QueryAllDepartmentResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryAllDepartmentResponseBody = None,
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
            temp_model = QueryAllDepartmentResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryGroupInfoHeaders(TeaModel):
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


class QueryGroupInfoResponseBodyContentLeaderJob(TeaModel):
    def __init__(
        self,
        code: str = None,
        biz_type: str = None,
        category: str = None,
        display_name: str = None,
    ):
        # 标签Code
        self.code = code
        # 业务类型
        self.biz_type = biz_type
        # 分类
        self.category = category
        # 展示名称
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.category is not None:
            result['category'] = self.category
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class QueryGroupInfoResponseBodyContentLeader(TeaModel):
    def __init__(
        self,
        name: str = None,
        user_id: str = None,
        job_number: str = None,
        job: QueryGroupInfoResponseBodyContentLeaderJob = None,
    ):
        # 姓名
        self.name = name
        # 人员Id
        self.user_id = user_id
        # 工号
        self.job_number = job_number
        # 工作标签
        self.job = job

    def validate(self):
        if self.job:
            self.job.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.job_number is not None:
            result['jobNumber'] = self.job_number
        if self.job is not None:
            result['job'] = self.job.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('jobNumber') is not None:
            self.job_number = m.get('jobNumber')
        if m.get('job') is not None:
            temp_model = QueryGroupInfoResponseBodyContentLeaderJob()
            self.job = temp_model.from_map(m['job'])
        return self


class QueryGroupInfoResponseBodyContent(TeaModel):
    def __init__(
        self,
        id: int = None,
        name: str = None,
        dept_id: int = None,
        leader: QueryGroupInfoResponseBodyContentLeader = None,
        start_time: int = None,
        end_time: int = None,
    ):
        # 医疗组Id
        self.id = id
        # 医疗组名称
        self.name = name
        # 科室Id
        self.dept_id = dept_id
        # 医疗组组长
        self.leader = leader
        # 有效期开始时间
        self.start_time = start_time
        # 有效期结束时间
        self.end_time = end_time

    def validate(self):
        if self.leader:
            self.leader.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.leader is not None:
            result['leader'] = self.leader.to_map()
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.end_time is not None:
            result['endTime'] = self.end_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('leader') is not None:
            temp_model = QueryGroupInfoResponseBodyContentLeader()
            self.leader = temp_model.from_map(m['leader'])
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        return self


class QueryGroupInfoResponseBody(TeaModel):
    def __init__(
        self,
        content: QueryGroupInfoResponseBodyContent = None,
    ):
        # 医疗组详情
        self.content = content

    def validate(self):
        if self.content:
            self.content.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            temp_model = QueryGroupInfoResponseBodyContent()
            self.content = temp_model.from_map(m['content'])
        return self


class QueryGroupInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryGroupInfoResponseBody = None,
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
            temp_model = QueryGroupInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


