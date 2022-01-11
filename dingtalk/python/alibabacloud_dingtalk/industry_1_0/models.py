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


class QueryUserExtendValuesHeaders(TeaModel):
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


class QueryUserExtendValuesRequest(TeaModel):
    def __init__(
        self,
        ding_org_id: int = None,
        user_ids: List[str] = None,
        user_extend_key: str = None,
    ):
        self.ding_org_id = ding_org_id
        # userId列表
        self.user_ids = user_ids
        # 用户拓展key
        self.user_extend_key = user_extend_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        if self.user_extend_key is not None:
            result['userExtendKey'] = self.user_extend_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        if m.get('userExtendKey') is not None:
            self.user_extend_key = m.get('userExtendKey')
        return self


class QueryUserExtendValuesResponseBodyContent(TeaModel):
    def __init__(
        self,
        user_extend_key: str = None,
        user_extend_value: str = None,
        user_extend_display_name: str = None,
        user_code: str = None,
    ):
        # 扩展字段key
        self.user_extend_key = user_extend_key
        # 扩展字段value
        self.user_extend_value = user_extend_value
        # 扩展字段描述
        self.user_extend_display_name = user_extend_display_name
        # 用户code
        self.user_code = user_code

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
        if self.user_code is not None:
            result['userCode'] = self.user_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userExtendKey') is not None:
            self.user_extend_key = m.get('userExtendKey')
        if m.get('userExtendValue') is not None:
            self.user_extend_value = m.get('userExtendValue')
        if m.get('userExtendDisplayName') is not None:
            self.user_extend_display_name = m.get('userExtendDisplayName')
        if m.get('userCode') is not None:
            self.user_code = m.get('userCode')
        return self


class QueryUserExtendValuesResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryUserExtendValuesResponseBodyContent] = None,
        total_count: int = None,
        success: bool = None,
    ):
        # 人员列表
        self.content = content
        # 数据总量
        self.total_count = total_count
        # 是否成功
        self.success = success

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
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryUserExtendValuesResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryUserExtendValuesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryUserExtendValuesResponseBody = None,
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
            temp_model = QueryUserExtendValuesResponseBody()
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
        org_id: str = None,
        status: int = None,
        user_code: str = None,
        gmt_create: str = None,
        gmt_modified: str = None,
    ):
        # 扩展属性Key
        self.user_extend_key = user_extend_key
        # 扩展属性值
        self.user_extend_value = user_extend_value
        # 扩展属性描述
        self.user_extend_display_name = user_extend_display_name
        # 组织id
        self.org_id = org_id
        # 状态：0-有效，1-无效
        self.status = status
        # 用户标识
        self.user_code = user_code
        # 创建时间
        self.gmt_create = gmt_create
        # 修改时间
        self.gmt_modified = gmt_modified

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
        if self.org_id is not None:
            result['orgId'] = self.org_id
        if self.status is not None:
            result['status'] = self.status
        if self.user_code is not None:
            result['userCode'] = self.user_code
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userExtendKey') is not None:
            self.user_extend_key = m.get('userExtendKey')
        if m.get('userExtendValue') is not None:
            self.user_extend_value = m.get('userExtendValue')
        if m.get('userExtendDisplayName') is not None:
            self.user_extend_display_name = m.get('userExtendDisplayName')
        if m.get('orgId') is not None:
            self.org_id = m.get('orgId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userCode') is not None:
            self.user_code = m.get('userCode')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
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


class IndustryManufactureLabourCostHeaders(TeaModel):
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


class IndustryManufactureLabourCostRequest(TeaModel):
    def __init__(
        self,
        process_no: str = None,
        material_no: str = None,
        start_time: int = None,
        end_time: int = None,
        cursor: int = None,
        page_number: int = None,
        page_size: int = None,
        token_grant_type: int = None,
        org_id: int = None,
        corp_id: str = None,
        isv_org_id: str = None,
        suite_key: str = None,
        microapp_agent_id: int = None,
        app_ids: List[int] = None,
        app_id: int = None,
        app_name: str = None,
    ):
        self.process_no = process_no
        self.material_no = material_no
        self.start_time = start_time
        self.end_time = end_time
        self.cursor = cursor
        self.page_number = page_number
        self.page_size = page_size
        self.token_grant_type = token_grant_type
        self.org_id = org_id
        self.corp_id = corp_id
        self.isv_org_id = isv_org_id
        self.suite_key = suite_key
        self.microapp_agent_id = microapp_agent_id
        self.app_ids = app_ids
        self.app_id = app_id
        self.app_name = app_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_no is not None:
            result['processNo'] = self.process_no
        if self.material_no is not None:
            result['materialNo'] = self.material_no
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.cursor is not None:
            result['cursor'] = self.cursor
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.token_grant_type is not None:
            result['tokenGrantType'] = self.token_grant_type
        if self.org_id is not None:
            result['orgId'] = self.org_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.isv_org_id is not None:
            result['isvOrgId'] = self.isv_org_id
        if self.suite_key is not None:
            result['suiteKey'] = self.suite_key
        if self.microapp_agent_id is not None:
            result['microappAgentId'] = self.microapp_agent_id
        if self.app_ids is not None:
            result['appIds'] = self.app_ids
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.app_name is not None:
            result['appName'] = self.app_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processNo') is not None:
            self.process_no = m.get('processNo')
        if m.get('materialNo') is not None:
            self.material_no = m.get('materialNo')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('cursor') is not None:
            self.cursor = m.get('cursor')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('tokenGrantType') is not None:
            self.token_grant_type = m.get('tokenGrantType')
        if m.get('orgId') is not None:
            self.org_id = m.get('orgId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('isvOrgId') is not None:
            self.isv_org_id = m.get('isvOrgId')
        if m.get('suiteKey') is not None:
            self.suite_key = m.get('suiteKey')
        if m.get('microappAgentId') is not None:
            self.microapp_agent_id = m.get('microappAgentId')
        if m.get('appIds') is not None:
            self.app_ids = m.get('appIds')
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('appName') is not None:
            self.app_name = m.get('appName')
        return self


class IndustryManufactureLabourCostResponseBodyList(TeaModel):
    def __init__(
        self,
        gmt_create: int = None,
        gmt_modified: int = None,
        corp_id: str = None,
        labour_cost_no: str = None,
        labour_cost_name: str = None,
        process_no: str = None,
        process_name: str = None,
        material_no: str = None,
        material_name: str = None,
        qualified_price: float = None,
        un_qualified_price_1: float = None,
        un_qualified_reason_1: str = None,
        instance_id: str = None,
        process_code: str = None,
        ext: str = None,
        un_qualified_reason_2: str = None,
        un_qualified_price_2: float = None,
        un_qualified_info: str = None,
    ):
        self.gmt_create = gmt_create
        self.gmt_modified = gmt_modified
        self.corp_id = corp_id
        self.labour_cost_no = labour_cost_no
        self.labour_cost_name = labour_cost_name
        self.process_no = process_no
        self.process_name = process_name
        self.material_no = material_no
        self.material_name = material_name
        self.qualified_price = qualified_price
        self.un_qualified_price_1 = un_qualified_price_1
        self.un_qualified_reason_1 = un_qualified_reason_1
        self.instance_id = instance_id
        self.process_code = process_code
        self.ext = ext
        self.un_qualified_reason_2 = un_qualified_reason_2
        self.un_qualified_price_2 = un_qualified_price_2
        self.un_qualified_info = un_qualified_info

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.labour_cost_no is not None:
            result['labourCostNo'] = self.labour_cost_no
        if self.labour_cost_name is not None:
            result['labourCostName'] = self.labour_cost_name
        if self.process_no is not None:
            result['processNo'] = self.process_no
        if self.process_name is not None:
            result['processName'] = self.process_name
        if self.material_no is not None:
            result['materialNo'] = self.material_no
        if self.material_name is not None:
            result['materialName'] = self.material_name
        if self.qualified_price is not None:
            result['qualifiedPrice'] = self.qualified_price
        if self.un_qualified_price_1 is not None:
            result['unQualifiedPrice1'] = self.un_qualified_price_1
        if self.un_qualified_reason_1 is not None:
            result['unQualifiedReason1'] = self.un_qualified_reason_1
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.ext is not None:
            result['ext'] = self.ext
        if self.un_qualified_reason_2 is not None:
            result['unQualifiedReason2'] = self.un_qualified_reason_2
        if self.un_qualified_price_2 is not None:
            result['unQualifiedPrice2'] = self.un_qualified_price_2
        if self.un_qualified_info is not None:
            result['unQualifiedInfo'] = self.un_qualified_info
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('labourCostNo') is not None:
            self.labour_cost_no = m.get('labourCostNo')
        if m.get('labourCostName') is not None:
            self.labour_cost_name = m.get('labourCostName')
        if m.get('processNo') is not None:
            self.process_no = m.get('processNo')
        if m.get('processName') is not None:
            self.process_name = m.get('processName')
        if m.get('materialNo') is not None:
            self.material_no = m.get('materialNo')
        if m.get('materialName') is not None:
            self.material_name = m.get('materialName')
        if m.get('qualifiedPrice') is not None:
            self.qualified_price = m.get('qualifiedPrice')
        if m.get('unQualifiedPrice1') is not None:
            self.un_qualified_price_1 = m.get('unQualifiedPrice1')
        if m.get('unQualifiedReason1') is not None:
            self.un_qualified_reason_1 = m.get('unQualifiedReason1')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        if m.get('unQualifiedReason2') is not None:
            self.un_qualified_reason_2 = m.get('unQualifiedReason2')
        if m.get('unQualifiedPrice2') is not None:
            self.un_qualified_price_2 = m.get('unQualifiedPrice2')
        if m.get('unQualifiedInfo') is not None:
            self.un_qualified_info = m.get('unQualifiedInfo')
        return self


class IndustryManufactureLabourCostResponseBody(TeaModel):
    def __init__(
        self,
        list: List[IndustryManufactureLabourCostResponseBodyList] = None,
        has_more: bool = None,
        next_cursor: int = None,
        total_count: int = None,
    ):
        self.list = list
        self.has_more = has_more
        self.next_cursor = next_cursor
        self.total_count = total_count

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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_cursor is not None:
            result['nextCursor'] = self.next_cursor
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = IndustryManufactureLabourCostResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextCursor') is not None:
            self.next_cursor = m.get('nextCursor')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class IndustryManufactureLabourCostResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: IndustryManufactureLabourCostResponseBody = None,
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
            temp_model = IndustryManufactureLabourCostResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryHospitalDistrictInfoHeaders(TeaModel):
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


class QueryHospitalDistrictInfoRequest(TeaModel):
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


class QueryHospitalDistrictInfoResponseBodyContent(TeaModel):
    def __init__(
        self,
        id: int = None,
        district_name: str = None,
        district_type: int = None,
        parent_district_id: int = None,
        address: str = None,
        deleted: int = None,
        gmt_create: str = None,
        gmt_modified: str = None,
    ):
        # 主键
        self.id = id
        # 院区或病区名称
        self.district_name = district_name
        # 类型，1：院区；2：病区
        self.district_type = district_type
        # 院区id
        self.parent_district_id = parent_district_id
        # 病区对应的物理地址
        self.address = address
        # 删除，0:正常，其他：已删除
        self.deleted = deleted
        # 创建时间
        self.gmt_create = gmt_create
        # 修改时间
        self.gmt_modified = gmt_modified

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.district_name is not None:
            result['districtName'] = self.district_name
        if self.district_type is not None:
            result['districtType'] = self.district_type
        if self.parent_district_id is not None:
            result['parentDistrictId'] = self.parent_district_id
        if self.address is not None:
            result['address'] = self.address
        if self.deleted is not None:
            result['deleted'] = self.deleted
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('districtName') is not None:
            self.district_name = m.get('districtName')
        if m.get('districtType') is not None:
            self.district_type = m.get('districtType')
        if m.get('parentDistrictId') is not None:
            self.parent_district_id = m.get('parentDistrictId')
        if m.get('address') is not None:
            self.address = m.get('address')
        if m.get('deleted') is not None:
            self.deleted = m.get('deleted')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        return self


class QueryHospitalDistrictInfoResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryHospitalDistrictInfoResponseBodyContent] = None,
        total_pages: int = None,
        total_count: int = None,
        current_page: int = None,
    ):
        # 院区病区详情
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
                temp_model = QueryHospitalDistrictInfoResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        if m.get('totalPages') is not None:
            self.total_pages = m.get('totalPages')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        return self


class QueryHospitalDistrictInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryHospitalDistrictInfoResponseBody = None,
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
            temp_model = QueryHospitalDistrictInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class IndustryManufactureCostRecordListGetHeaders(TeaModel):
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


class IndustryManufactureCostRecordListGetRequest(TeaModel):
    def __init__(
        self,
        instance_id: str = None,
        material_no: str = None,
        order_no: str = None,
        production_task_no: str = None,
        start_time: int = None,
        end_time: int = None,
        cursor: int = None,
        page_number: int = None,
        page_size: int = None,
        token_grant_type: int = None,
        org_id: int = None,
        corp_id: str = None,
        isv_org_id: int = None,
        suite_key: str = None,
        microapp_agent_id: int = None,
        app_ids: List[int] = None,
        app_id: int = None,
        app_name: str = None,
    ):
        self.instance_id = instance_id
        self.material_no = material_no
        self.order_no = order_no
        self.production_task_no = production_task_no
        self.start_time = start_time
        self.end_time = end_time
        self.cursor = cursor
        self.page_number = page_number
        self.page_size = page_size
        self.token_grant_type = token_grant_type
        self.org_id = org_id
        self.corp_id = corp_id
        self.isv_org_id = isv_org_id
        self.suite_key = suite_key
        self.microapp_agent_id = microapp_agent_id
        self.app_ids = app_ids
        self.app_id = app_id
        self.app_name = app_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.material_no is not None:
            result['materialNo'] = self.material_no
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.production_task_no is not None:
            result['productionTaskNo'] = self.production_task_no
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.cursor is not None:
            result['cursor'] = self.cursor
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.token_grant_type is not None:
            result['tokenGrantType'] = self.token_grant_type
        if self.org_id is not None:
            result['orgId'] = self.org_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.isv_org_id is not None:
            result['isvOrgId'] = self.isv_org_id
        if self.suite_key is not None:
            result['suiteKey'] = self.suite_key
        if self.microapp_agent_id is not None:
            result['microappAgentId'] = self.microapp_agent_id
        if self.app_ids is not None:
            result['appIds'] = self.app_ids
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.app_name is not None:
            result['appName'] = self.app_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('materialNo') is not None:
            self.material_no = m.get('materialNo')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('productionTaskNo') is not None:
            self.production_task_no = m.get('productionTaskNo')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('cursor') is not None:
            self.cursor = m.get('cursor')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('tokenGrantType') is not None:
            self.token_grant_type = m.get('tokenGrantType')
        if m.get('orgId') is not None:
            self.org_id = m.get('orgId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('isvOrgId') is not None:
            self.isv_org_id = m.get('isvOrgId')
        if m.get('suiteKey') is not None:
            self.suite_key = m.get('suiteKey')
        if m.get('microappAgentId') is not None:
            self.microapp_agent_id = m.get('microappAgentId')
        if m.get('appIds') is not None:
            self.app_ids = m.get('appIds')
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('appName') is not None:
            self.app_name = m.get('appName')
        return self


class IndustryManufactureCostRecordListGetResponseBodyList(TeaModel):
    def __init__(
        self,
        gmt_create: int = None,
        gmt_modified: int = None,
        corp_id: str = None,
        material_cost_record_no: str = None,
        instance_id: str = None,
        material_no: str = None,
        material_name: str = None,
        unit: str = None,
        count: float = None,
        type: str = None,
        price: float = None,
        order_no: str = None,
        production_task_no: str = None,
        is_deleted: str = None,
        ext: str = None,
        memo: str = None,
        real_count: float = None,
        real_price: float = None,
        process_code: str = None,
    ):
        self.gmt_create = gmt_create
        self.gmt_modified = gmt_modified
        self.corp_id = corp_id
        self.material_cost_record_no = material_cost_record_no
        self.instance_id = instance_id
        self.material_no = material_no
        self.material_name = material_name
        self.unit = unit
        self.count = count
        self.type = type
        self.price = price
        self.order_no = order_no
        self.production_task_no = production_task_no
        self.is_deleted = is_deleted
        self.ext = ext
        self.memo = memo
        self.real_count = real_count
        self.real_price = real_price
        self.process_code = process_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.material_cost_record_no is not None:
            result['materialCostRecordNo'] = self.material_cost_record_no
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.material_no is not None:
            result['materialNo'] = self.material_no
        if self.material_name is not None:
            result['materialName'] = self.material_name
        if self.unit is not None:
            result['unit'] = self.unit
        if self.count is not None:
            result['count'] = self.count
        if self.type is not None:
            result['type'] = self.type
        if self.price is not None:
            result['price'] = self.price
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.production_task_no is not None:
            result['productionTaskNo'] = self.production_task_no
        if self.is_deleted is not None:
            result['isDeleted'] = self.is_deleted
        if self.ext is not None:
            result['ext'] = self.ext
        if self.memo is not None:
            result['memo'] = self.memo
        if self.real_count is not None:
            result['realCount'] = self.real_count
        if self.real_price is not None:
            result['realPrice'] = self.real_price
        if self.process_code is not None:
            result['processCode'] = self.process_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('materialCostRecordNo') is not None:
            self.material_cost_record_no = m.get('materialCostRecordNo')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('materialNo') is not None:
            self.material_no = m.get('materialNo')
        if m.get('materialName') is not None:
            self.material_name = m.get('materialName')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('count') is not None:
            self.count = m.get('count')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('price') is not None:
            self.price = m.get('price')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('productionTaskNo') is not None:
            self.production_task_no = m.get('productionTaskNo')
        if m.get('isDeleted') is not None:
            self.is_deleted = m.get('isDeleted')
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        if m.get('realCount') is not None:
            self.real_count = m.get('realCount')
        if m.get('realPrice') is not None:
            self.real_price = m.get('realPrice')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        return self


class IndustryManufactureCostRecordListGetResponseBody(TeaModel):
    def __init__(
        self,
        list: List[IndustryManufactureCostRecordListGetResponseBodyList] = None,
        next_cursor: int = None,
        total_count: int = None,
        has_more: bool = None,
    ):
        self.list = list
        self.next_cursor = next_cursor
        self.total_count = total_count
        self.has_more = has_more

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
        if self.next_cursor is not None:
            result['nextCursor'] = self.next_cursor
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = IndustryManufactureCostRecordListGetResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextCursor') is not None:
            self.next_cursor = m.get('nextCursor')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        return self


class IndustryManufactureCostRecordListGetResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: IndustryManufactureCostRecordListGetResponseBody = None,
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
            temp_model = IndustryManufactureCostRecordListGetResponseBody()
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


class QueryHospitalRolesHeaders(TeaModel):
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


class QueryHospitalRolesResponseBodyContent(TeaModel):
    def __init__(
        self,
        id: int = None,
        gmt_create: str = None,
        is_deleted: int = None,
        role_code: str = None,
        role_name: str = None,
        remark: str = None,
        sort: int = None,
        read_only: int = None,
    ):
        # 主键
        self.id = id
        # 修改时间
        self.gmt_create = gmt_create
        # 是否已删除，默认0未删除，1已删除
        self.is_deleted = is_deleted
        # 角色编码
        self.role_code = role_code
        # 角色名称
        self.role_name = role_name
        # 备注
        self.remark = remark
        # 排序，数字越小越靠前，默认0
        self.sort = sort
        # 角色关联权限点是否只读
        self.read_only = read_only

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.is_deleted is not None:
            result['isDeleted'] = self.is_deleted
        if self.role_code is not None:
            result['roleCode'] = self.role_code
        if self.role_name is not None:
            result['roleName'] = self.role_name
        if self.remark is not None:
            result['remark'] = self.remark
        if self.sort is not None:
            result['sort'] = self.sort
        if self.read_only is not None:
            result['readOnly'] = self.read_only
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('isDeleted') is not None:
            self.is_deleted = m.get('isDeleted')
        if m.get('roleCode') is not None:
            self.role_code = m.get('roleCode')
        if m.get('roleName') is not None:
            self.role_name = m.get('roleName')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('sort') is not None:
            self.sort = m.get('sort')
        if m.get('readOnly') is not None:
            self.read_only = m.get('readOnly')
        return self


class QueryHospitalRolesResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryHospitalRolesResponseBodyContent] = None,
    ):
        # 角色列表
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
                temp_model = QueryHospitalRolesResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        return self


class QueryHospitalRolesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryHospitalRolesResponseBody = None,
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
            temp_model = QueryHospitalRolesResponseBody()
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


class QueryHospitalRoleUserInfoHeaders(TeaModel):
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


class QueryHospitalRoleUserInfoRequest(TeaModel):
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


class QueryHospitalRoleUserInfoResponseBodyContent(TeaModel):
    def __init__(
        self,
        user_code: str = None,
        user_name: str = None,
        job_number: str = None,
        role_code: str = None,
        role_name: str = None,
        gmt_create: str = None,
        gmt_modified: str = None,
    ):
        # 用户编码
        self.user_code = user_code
        # 用户名称
        self.user_name = user_name
        # 用户工号
        self.job_number = job_number
        # 角色编码
        self.role_code = role_code
        # 角色名称
        self.role_name = role_name
        # gmtCreate
        self.gmt_create = gmt_create
        # 修改时间
        self.gmt_modified = gmt_modified

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_code is not None:
            result['userCode'] = self.user_code
        if self.user_name is not None:
            result['userName'] = self.user_name
        if self.job_number is not None:
            result['jobNumber'] = self.job_number
        if self.role_code is not None:
            result['roleCode'] = self.role_code
        if self.role_name is not None:
            result['roleName'] = self.role_name
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userCode') is not None:
            self.user_code = m.get('userCode')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        if m.get('jobNumber') is not None:
            self.job_number = m.get('jobNumber')
        if m.get('roleCode') is not None:
            self.role_code = m.get('roleCode')
        if m.get('roleName') is not None:
            self.role_name = m.get('roleName')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        return self


class QueryHospitalRoleUserInfoResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryHospitalRoleUserInfoResponseBodyContent] = None,
        total_pages: int = None,
        total_count: int = None,
        current_page: int = None,
    ):
        # 角色人员信息
        self.content = content
        # 总页数
        self.total_pages = total_pages
        # 总数量
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
                temp_model = QueryHospitalRoleUserInfoResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        if m.get('totalPages') is not None:
            self.total_pages = m.get('totalPages')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        return self


class QueryHospitalRoleUserInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryHospitalRoleUserInfoResponseBody = None,
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
            temp_model = QueryHospitalRoleUserInfoResponseBody()
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


class QueryMedicalEventsHeaders(TeaModel):
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


class QueryMedicalEventsResponseBodyContent(TeaModel):
    def __init__(
        self,
        event_id: int = None,
        code: str = None,
        content: str = None,
    ):
        # 事件id
        self.event_id = event_id
        # 事件code
        self.code = code
        # 事件内容
        self.content = content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.event_id is not None:
            result['eventId'] = self.event_id
        if self.code is not None:
            result['code'] = self.code
        if self.content is not None:
            result['content'] = self.content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('eventId') is not None:
            self.event_id = m.get('eventId')
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('content') is not None:
            self.content = m.get('content')
        return self


class QueryMedicalEventsResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryMedicalEventsResponseBodyContent] = None,
        total_count: int = None,
        success: bool = None,
    ):
        # 事件详情列表
        self.content = content
        # 数据总量
        self.total_count = total_count
        # 是否成功
        self.success = success

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
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryMedicalEventsResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryMedicalEventsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryMedicalEventsResponseBody = None,
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
            temp_model = QueryMedicalEventsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class IndustryManufactureMaterialListHeaders(TeaModel):
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


class IndustryManufactureMaterialListRequest(TeaModel):
    def __init__(
        self,
        token_grant_type: int = None,
        corp_id: str = None,
        page_size: int = None,
        end_time: int = None,
        instance_id: str = None,
        material_no: str = None,
        start_time: int = None,
        microapp_agent_id: int = None,
        cursor: int = None,
        app_name: str = None,
        org_id: int = None,
        app_id: int = None,
        suite_key: str = None,
        app_ids: List[int] = None,
        current_page: int = None,
        isv_org_id: int = None,
    ):
        self.token_grant_type = token_grant_type
        self.corp_id = corp_id
        self.page_size = page_size
        self.end_time = end_time
        self.instance_id = instance_id
        self.material_no = material_no
        self.start_time = start_time
        self.microapp_agent_id = microapp_agent_id
        self.cursor = cursor
        self.app_name = app_name
        self.org_id = org_id
        self.app_id = app_id
        self.suite_key = suite_key
        self.app_ids = app_ids
        self.current_page = current_page
        self.isv_org_id = isv_org_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.token_grant_type is not None:
            result['tokenGrantType'] = self.token_grant_type
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.material_no is not None:
            result['materialNo'] = self.material_no
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.microapp_agent_id is not None:
            result['microappAgentId'] = self.microapp_agent_id
        if self.cursor is not None:
            result['cursor'] = self.cursor
        if self.app_name is not None:
            result['appName'] = self.app_name
        if self.org_id is not None:
            result['orgId'] = self.org_id
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.suite_key is not None:
            result['suiteKey'] = self.suite_key
        if self.app_ids is not None:
            result['appIds'] = self.app_ids
        if self.current_page is not None:
            result['currentPage'] = self.current_page
        if self.isv_org_id is not None:
            result['isvOrgId'] = self.isv_org_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('tokenGrantType') is not None:
            self.token_grant_type = m.get('tokenGrantType')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('materialNo') is not None:
            self.material_no = m.get('materialNo')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('microappAgentId') is not None:
            self.microapp_agent_id = m.get('microappAgentId')
        if m.get('cursor') is not None:
            self.cursor = m.get('cursor')
        if m.get('appName') is not None:
            self.app_name = m.get('appName')
        if m.get('orgId') is not None:
            self.org_id = m.get('orgId')
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('suiteKey') is not None:
            self.suite_key = m.get('suiteKey')
        if m.get('appIds') is not None:
            self.app_ids = m.get('appIds')
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        if m.get('isvOrgId') is not None:
            self.isv_org_id = m.get('isvOrgId')
        return self


class IndustryManufactureMaterialListResponseBodyList(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        instance_id: str = None,
        material_no: str = None,
        material_name: str = None,
        specification: str = None,
        type: str = None,
        category: str = None,
        unit: str = None,
        ext: str = None,
        process_code: str = None,
        stock_max_warn: float = None,
        stock_min_warn: float = None,
    ):
        self.corp_id = corp_id
        self.instance_id = instance_id
        self.material_no = material_no
        self.material_name = material_name
        self.specification = specification
        self.type = type
        self.category = category
        self.unit = unit
        self.ext = ext
        self.process_code = process_code
        self.stock_max_warn = stock_max_warn
        self.stock_min_warn = stock_min_warn

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.material_no is not None:
            result['materialNo'] = self.material_no
        if self.material_name is not None:
            result['materialName'] = self.material_name
        if self.specification is not None:
            result['specification'] = self.specification
        if self.type is not None:
            result['type'] = self.type
        if self.category is not None:
            result['category'] = self.category
        if self.unit is not None:
            result['unit'] = self.unit
        if self.ext is not None:
            result['ext'] = self.ext
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.stock_max_warn is not None:
            result['stockMaxWarn'] = self.stock_max_warn
        if self.stock_min_warn is not None:
            result['stockMinWarn'] = self.stock_min_warn
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('materialNo') is not None:
            self.material_no = m.get('materialNo')
        if m.get('materialName') is not None:
            self.material_name = m.get('materialName')
        if m.get('specification') is not None:
            self.specification = m.get('specification')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('stockMaxWarn') is not None:
            self.stock_max_warn = m.get('stockMaxWarn')
        if m.get('stockMinWarn') is not None:
            self.stock_min_warn = m.get('stockMinWarn')
        return self


class IndustryManufactureMaterialListResponseBody(TeaModel):
    def __init__(
        self,
        list: List[IndustryManufactureMaterialListResponseBodyList] = None,
        next_cursor: int = None,
        total_count: int = None,
        has_more: bool = None,
    ):
        self.list = list
        self.next_cursor = next_cursor
        self.total_count = total_count
        self.has_more = has_more

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
        if self.next_cursor is not None:
            result['nextCursor'] = self.next_cursor
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = IndustryManufactureMaterialListResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextCursor') is not None:
            self.next_cursor = m.get('nextCursor')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        return self


class IndustryManufactureMaterialListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: IndustryManufactureMaterialListResponseBody = None,
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
            temp_model = IndustryManufactureMaterialListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class IndustryMmanufactureMaterialCostGetHeaders(TeaModel):
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


class IndustryMmanufactureMaterialCostGetRequest(TeaModel):
    def __init__(
        self,
        instance_id: str = None,
        material_no: str = None,
        start_time: int = None,
        end_time: int = None,
        cursor: int = None,
        page_number: int = None,
        page_size: int = None,
        token_grant_type: int = None,
        org_id: int = None,
        corp_id: str = None,
        isv_org_id: int = None,
        suite_key: str = None,
        microapp_agent_id: int = None,
        app_ids: List[int] = None,
        app_id: int = None,
        app_name: str = None,
    ):
        self.instance_id = instance_id
        self.material_no = material_no
        self.start_time = start_time
        self.end_time = end_time
        self.cursor = cursor
        self.page_number = page_number
        self.page_size = page_size
        self.token_grant_type = token_grant_type
        self.org_id = org_id
        self.corp_id = corp_id
        self.isv_org_id = isv_org_id
        self.suite_key = suite_key
        self.microapp_agent_id = microapp_agent_id
        self.app_ids = app_ids
        self.app_id = app_id
        self.app_name = app_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.material_no is not None:
            result['materialNo'] = self.material_no
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.cursor is not None:
            result['cursor'] = self.cursor
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.token_grant_type is not None:
            result['tokenGrantType'] = self.token_grant_type
        if self.org_id is not None:
            result['orgId'] = self.org_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.isv_org_id is not None:
            result['isvOrgId'] = self.isv_org_id
        if self.suite_key is not None:
            result['suiteKey'] = self.suite_key
        if self.microapp_agent_id is not None:
            result['microappAgentId'] = self.microapp_agent_id
        if self.app_ids is not None:
            result['appIds'] = self.app_ids
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.app_name is not None:
            result['appName'] = self.app_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('materialNo') is not None:
            self.material_no = m.get('materialNo')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('cursor') is not None:
            self.cursor = m.get('cursor')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('tokenGrantType') is not None:
            self.token_grant_type = m.get('tokenGrantType')
        if m.get('orgId') is not None:
            self.org_id = m.get('orgId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('isvOrgId') is not None:
            self.isv_org_id = m.get('isvOrgId')
        if m.get('suiteKey') is not None:
            self.suite_key = m.get('suiteKey')
        if m.get('microappAgentId') is not None:
            self.microapp_agent_id = m.get('microappAgentId')
        if m.get('appIds') is not None:
            self.app_ids = m.get('appIds')
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('appName') is not None:
            self.app_name = m.get('appName')
        return self


class IndustryMmanufactureMaterialCostGetResponseBodyList(TeaModel):
    def __init__(
        self,
        gmt_create: int = None,
        gmt_modified: int = None,
        corp_id: str = None,
        material_cost_no: str = None,
        instance_id: str = None,
        material_no: str = None,
        material_name: str = None,
        unit: str = None,
        count: float = None,
        price: float = None,
        act_price: float = None,
        ext: str = None,
        process_code: str = None,
        memo: str = None,
    ):
        self.gmt_create = gmt_create
        self.gmt_modified = gmt_modified
        self.corp_id = corp_id
        self.material_cost_no = material_cost_no
        self.instance_id = instance_id
        self.material_no = material_no
        self.material_name = material_name
        self.unit = unit
        self.count = count
        self.price = price
        self.act_price = act_price
        self.ext = ext
        self.process_code = process_code
        self.memo = memo

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.material_cost_no is not None:
            result['materialCostNo'] = self.material_cost_no
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.material_no is not None:
            result['materialNo'] = self.material_no
        if self.material_name is not None:
            result['materialName'] = self.material_name
        if self.unit is not None:
            result['unit'] = self.unit
        if self.count is not None:
            result['count'] = self.count
        if self.price is not None:
            result['price'] = self.price
        if self.act_price is not None:
            result['actPrice'] = self.act_price
        if self.ext is not None:
            result['ext'] = self.ext
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.memo is not None:
            result['memo'] = self.memo
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('materialCostNo') is not None:
            self.material_cost_no = m.get('materialCostNo')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('materialNo') is not None:
            self.material_no = m.get('materialNo')
        if m.get('materialName') is not None:
            self.material_name = m.get('materialName')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('count') is not None:
            self.count = m.get('count')
        if m.get('price') is not None:
            self.price = m.get('price')
        if m.get('actPrice') is not None:
            self.act_price = m.get('actPrice')
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        return self


class IndustryMmanufactureMaterialCostGetResponseBody(TeaModel):
    def __init__(
        self,
        list: List[IndustryMmanufactureMaterialCostGetResponseBodyList] = None,
        total_count: int = None,
        next_cursor: int = None,
        has_more: bool = None,
    ):
        self.list = list
        self.total_count = total_count
        self.next_cursor = next_cursor
        self.has_more = has_more

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
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        if self.next_cursor is not None:
            result['nextCursor'] = self.next_cursor
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = IndustryMmanufactureMaterialCostGetResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        if m.get('nextCursor') is not None:
            self.next_cursor = m.get('nextCursor')
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        return self


class IndustryMmanufactureMaterialCostGetResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: IndustryMmanufactureMaterialCostGetResponseBody = None,
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
            temp_model = IndustryMmanufactureMaterialCostGetResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class IndustryManufactureFeeListGetHeaders(TeaModel):
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


class IndustryManufactureFeeListGetRequest(TeaModel):
    def __init__(
        self,
        production_task_no: str = None,
        material_no: str = None,
        type: str = None,
        start_time: int = None,
        end_time: int = None,
        cursor: int = None,
        page_number: int = None,
        page_size: int = None,
        token_grant_type: int = None,
        org_id: int = None,
        corp_id: str = None,
        isv_org_id: int = None,
        suite_key: str = None,
        microapp_agent_id: int = None,
        app_ids: List[int] = None,
        app_id: int = None,
        app_name: str = None,
    ):
        self.production_task_no = production_task_no
        self.material_no = material_no
        self.type = type
        self.start_time = start_time
        self.end_time = end_time
        self.cursor = cursor
        self.page_number = page_number
        self.page_size = page_size
        self.token_grant_type = token_grant_type
        self.org_id = org_id
        self.corp_id = corp_id
        self.isv_org_id = isv_org_id
        self.suite_key = suite_key
        self.microapp_agent_id = microapp_agent_id
        self.app_ids = app_ids
        self.app_id = app_id
        self.app_name = app_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.production_task_no is not None:
            result['productionTaskNo'] = self.production_task_no
        if self.material_no is not None:
            result['materialNo'] = self.material_no
        if self.type is not None:
            result['type'] = self.type
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.cursor is not None:
            result['cursor'] = self.cursor
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.token_grant_type is not None:
            result['tokenGrantType'] = self.token_grant_type
        if self.org_id is not None:
            result['orgId'] = self.org_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.isv_org_id is not None:
            result['isvOrgId'] = self.isv_org_id
        if self.suite_key is not None:
            result['suiteKey'] = self.suite_key
        if self.microapp_agent_id is not None:
            result['microappAgentId'] = self.microapp_agent_id
        if self.app_ids is not None:
            result['appIds'] = self.app_ids
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.app_name is not None:
            result['appName'] = self.app_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('productionTaskNo') is not None:
            self.production_task_no = m.get('productionTaskNo')
        if m.get('materialNo') is not None:
            self.material_no = m.get('materialNo')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('cursor') is not None:
            self.cursor = m.get('cursor')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('tokenGrantType') is not None:
            self.token_grant_type = m.get('tokenGrantType')
        if m.get('orgId') is not None:
            self.org_id = m.get('orgId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('isvOrgId') is not None:
            self.isv_org_id = m.get('isvOrgId')
        if m.get('suiteKey') is not None:
            self.suite_key = m.get('suiteKey')
        if m.get('microappAgentId') is not None:
            self.microapp_agent_id = m.get('microappAgentId')
        if m.get('appIds') is not None:
            self.app_ids = m.get('appIds')
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('appName') is not None:
            self.app_name = m.get('appName')
        return self


class IndustryManufactureFeeListGetResponseBodyList(TeaModel):
    def __init__(
        self,
        id: int = None,
        gmt_create: int = None,
        gmt_modified: int = None,
        corp_id: str = None,
        production_task_no: str = None,
        material_no: str = None,
        material_name: str = None,
        count: float = None,
        unit: str = None,
        type: str = None,
        amount: str = None,
        per_amount: float = None,
        is_deleted: str = None,
        instance_id: str = None,
        process_code: str = None,
        ext: str = None,
        title: str = None,
    ):
        self.id = id
        self.gmt_create = gmt_create
        self.gmt_modified = gmt_modified
        self.corp_id = corp_id
        self.production_task_no = production_task_no
        self.material_no = material_no
        self.material_name = material_name
        self.count = count
        self.unit = unit
        self.type = type
        self.amount = amount
        self.per_amount = per_amount
        self.is_deleted = is_deleted
        self.instance_id = instance_id
        self.process_code = process_code
        self.ext = ext
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.production_task_no is not None:
            result['productionTaskNo'] = self.production_task_no
        if self.material_no is not None:
            result['materialNo'] = self.material_no
        if self.material_name is not None:
            result['materialName'] = self.material_name
        if self.count is not None:
            result['count'] = self.count
        if self.unit is not None:
            result['unit'] = self.unit
        if self.type is not None:
            result['type'] = self.type
        if self.amount is not None:
            result['amount'] = self.amount
        if self.per_amount is not None:
            result['perAmount'] = self.per_amount
        if self.is_deleted is not None:
            result['isDeleted'] = self.is_deleted
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.ext is not None:
            result['ext'] = self.ext
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('productionTaskNo') is not None:
            self.production_task_no = m.get('productionTaskNo')
        if m.get('materialNo') is not None:
            self.material_no = m.get('materialNo')
        if m.get('materialName') is not None:
            self.material_name = m.get('materialName')
        if m.get('count') is not None:
            self.count = m.get('count')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('perAmount') is not None:
            self.per_amount = m.get('perAmount')
        if m.get('isDeleted') is not None:
            self.is_deleted = m.get('isDeleted')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class IndustryManufactureFeeListGetResponseBody(TeaModel):
    def __init__(
        self,
        list: List[IndustryManufactureFeeListGetResponseBodyList] = None,
        next_cursor: int = None,
        total_count: int = None,
        has_more: bool = None,
    ):
        self.list = list
        self.next_cursor = next_cursor
        self.total_count = total_count
        self.has_more = has_more

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
        if self.next_cursor is not None:
            result['nextCursor'] = self.next_cursor
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = IndustryManufactureFeeListGetResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextCursor') is not None:
            self.next_cursor = m.get('nextCursor')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        return self


class IndustryManufactureFeeListGetResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: IndustryManufactureFeeListGetResponseBody = None,
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
            temp_model = IndustryManufactureFeeListGetResponseBody()
            self.body = temp_model.from_map(m['body'])
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
        id: int = None,
        gmt_create_str: str = None,
        gmt_modified_str: str = None,
        corp_id: str = None,
        user_code: str = None,
        dept_code: str = None,
        status: int = None,
        assess_group_id: str = None,
        assess_group_name: str = None,
    ):
        # 租户下staffId
        self.uid = uid
        # 用户名称
        self.user_name = user_name
        # 工号
        self.job_num = job_num
        # 用户id
        self.id = id
        # 用户创建时间
        self.gmt_create_str = gmt_create_str
        # 用户最后修改时间
        self.gmt_modified_str = gmt_modified_str
        # 租户CorpId
        self.corp_id = corp_id
        # 租户内staffId
        self.user_code = user_code
        # 关联的部门id
        self.dept_code = dept_code
        # 状态0-有效，1-删除
        self.status = status
        # 考核医疗组id
        self.assess_group_id = assess_group_id
        # 考核医疗组名称
        self.assess_group_name = assess_group_name

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
        if self.id is not None:
            result['id'] = self.id
        if self.gmt_create_str is not None:
            result['gmtCreateStr'] = self.gmt_create_str
        if self.gmt_modified_str is not None:
            result['gmtModifiedStr'] = self.gmt_modified_str
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.user_code is not None:
            result['userCode'] = self.user_code
        if self.dept_code is not None:
            result['deptCode'] = self.dept_code
        if self.status is not None:
            result['status'] = self.status
        if self.assess_group_id is not None:
            result['assessGroupId'] = self.assess_group_id
        if self.assess_group_name is not None:
            result['assessGroupName'] = self.assess_group_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('uid') is not None:
            self.uid = m.get('uid')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        if m.get('jobNum') is not None:
            self.job_num = m.get('jobNum')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('gmtCreateStr') is not None:
            self.gmt_create_str = m.get('gmtCreateStr')
        if m.get('gmtModifiedStr') is not None:
            self.gmt_modified_str = m.get('gmtModifiedStr')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('userCode') is not None:
            self.user_code = m.get('userCode')
        if m.get('deptCode') is not None:
            self.dept_code = m.get('deptCode')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('assessGroupId') is not None:
            self.assess_group_id = m.get('assessGroupId')
        if m.get('assessGroupName') is not None:
            self.assess_group_name = m.get('assessGroupName')
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


class QueryAllDepartmentResponseBodyContentDeptAndExtDepartmentWardIdList(TeaModel):
    def __init__(
        self,
        id: int = None,
    ):
        # 病区id
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class QueryAllDepartmentResponseBodyContentDeptAndExtDepartment(TeaModel):
    def __init__(
        self,
        id: int = None,
        gmt_create_str: str = None,
        gmt_modified_str: str = None,
        corp_id: str = None,
        dept_code: str = None,
        dept_type: int = None,
        dept_status: int = None,
        parent_dept_code: str = None,
        dept_order: int = None,
        remark: str = None,
        dept_name: str = None,
        name: str = None,
        ward_id_list: List[QueryAllDepartmentResponseBodyContentDeptAndExtDepartmentWardIdList] = None,
    ):
        # 科室ID
        self.id = id
        # 创建时间
        self.gmt_create_str = gmt_create_str
        # 修改时间
        self.gmt_modified_str = gmt_modified_str
        # 租户CorpID
        self.corp_id = corp_id
        # 部门code
        self.dept_code = dept_code
        # 部门类型：1-科室，2-医疗组
        self.dept_type = dept_type
        # 部门状态：0-正常，1-删除
        self.dept_status = dept_status
        # 父部门code（与dept_code来源保持一致）
        self.parent_dept_code = parent_dept_code
        # 排序
        self.dept_order = dept_order
        # 备注
        self.remark = remark
        # 科室名称，同name
        self.dept_name = dept_name
        # 科室名称，同deptName
        self.name = name
        # 病区id列表
        self.ward_id_list = ward_id_list

    def validate(self):
        if self.ward_id_list:
            for k in self.ward_id_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.gmt_create_str is not None:
            result['gmtCreateStr'] = self.gmt_create_str
        if self.gmt_modified_str is not None:
            result['gmtModifiedStr'] = self.gmt_modified_str
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.dept_code is not None:
            result['deptCode'] = self.dept_code
        if self.dept_type is not None:
            result['deptType'] = self.dept_type
        if self.dept_status is not None:
            result['deptStatus'] = self.dept_status
        if self.parent_dept_code is not None:
            result['parentDeptCode'] = self.parent_dept_code
        if self.dept_order is not None:
            result['deptOrder'] = self.dept_order
        if self.remark is not None:
            result['remark'] = self.remark
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.name is not None:
            result['name'] = self.name
        result['wardIdList'] = []
        if self.ward_id_list is not None:
            for k in self.ward_id_list:
                result['wardIdList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('gmtCreateStr') is not None:
            self.gmt_create_str = m.get('gmtCreateStr')
        if m.get('gmtModifiedStr') is not None:
            self.gmt_modified_str = m.get('gmtModifiedStr')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('deptCode') is not None:
            self.dept_code = m.get('deptCode')
        if m.get('deptType') is not None:
            self.dept_type = m.get('deptType')
        if m.get('deptStatus') is not None:
            self.dept_status = m.get('deptStatus')
        if m.get('parentDeptCode') is not None:
            self.parent_dept_code = m.get('parentDeptCode')
        if m.get('deptOrder') is not None:
            self.dept_order = m.get('deptOrder')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('name') is not None:
            self.name = m.get('name')
        self.ward_id_list = []
        if m.get('wardIdList') is not None:
            for k in m.get('wardIdList'):
                temp_model = QueryAllDepartmentResponseBodyContentDeptAndExtDepartmentWardIdList()
                self.ward_id_list.append(temp_model.from_map(k))
        return self


class QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos(TeaModel):
    def __init__(
        self,
        id: int = None,
        gmt_create_str: str = None,
        gmt_modified_str: str = None,
        corp_id: str = None,
        dept_code: str = None,
        dept_extend_key: str = None,
        dept_extend_value: str = None,
        dept_extend_display_name: str = None,
        status: int = None,
    ):
        # 扩展信息id
        self.id = id
        # 创建时间
        self.gmt_create_str = gmt_create_str
        # 修改时间
        self.gmt_modified_str = gmt_modified_str
        # 租户CorpID
        self.corp_id = corp_id
        # 部门code
        self.dept_code = dept_code
        # 科室扩展字段key
        self.dept_extend_key = dept_extend_key
        # 科室扩展字段value
        self.dept_extend_value = dept_extend_value
        # 科室扩展字段描述
        self.dept_extend_display_name = dept_extend_display_name
        # 0-有效 ，1-无效
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.gmt_create_str is not None:
            result['gmtCreateStr'] = self.gmt_create_str
        if self.gmt_modified_str is not None:
            result['gmtModifiedStr'] = self.gmt_modified_str
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.dept_code is not None:
            result['deptCode'] = self.dept_code
        if self.dept_extend_key is not None:
            result['deptExtendKey'] = self.dept_extend_key
        if self.dept_extend_value is not None:
            result['deptExtendValue'] = self.dept_extend_value
        if self.dept_extend_display_name is not None:
            result['deptExtendDisplayName'] = self.dept_extend_display_name
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('gmtCreateStr') is not None:
            self.gmt_create_str = m.get('gmtCreateStr')
        if m.get('gmtModifiedStr') is not None:
            self.gmt_modified_str = m.get('gmtModifiedStr')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('deptCode') is not None:
            self.dept_code = m.get('deptCode')
        if m.get('deptExtendKey') is not None:
            self.dept_extend_key = m.get('deptExtendKey')
        if m.get('deptExtendValue') is not None:
            self.dept_extend_value = m.get('deptExtendValue')
        if m.get('deptExtendDisplayName') is not None:
            self.dept_extend_display_name = m.get('deptExtendDisplayName')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class QueryAllDepartmentResponseBodyContentDeptAndExt(TeaModel):
    def __init__(
        self,
        department: QueryAllDepartmentResponseBodyContentDeptAndExtDepartment = None,
        extend_infos: List[QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos] = None,
    ):
        # 科室详情
        self.department = department
        # 科室扩展信息列表
        self.extend_infos = extend_infos

    def validate(self):
        if self.department:
            self.department.validate()
        if self.extend_infos:
            for k in self.extend_infos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.department is not None:
            result['department'] = self.department.to_map()
        result['extendInfos'] = []
        if self.extend_infos is not None:
            for k in self.extend_infos:
                result['extendInfos'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('department') is not None:
            temp_model = QueryAllDepartmentResponseBodyContentDeptAndExtDepartment()
            self.department = temp_model.from_map(m['department'])
        self.extend_infos = []
        if m.get('extendInfos') is not None:
            for k in m.get('extendInfos'):
                temp_model = QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos()
                self.extend_infos.append(temp_model.from_map(k))
        return self


class QueryAllDepartmentResponseBodyContentGroupAndExtListGroupLeader(TeaModel):
    def __init__(
        self,
        name: str = None,
        user_id: str = None,
        job_number: str = None,
    ):
        # 姓名
        self.name = name
        # 用户ID
        self.user_id = user_id
        # 用户工号
        self.job_number = job_number

    def validate(self):
        pass

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('jobNumber') is not None:
            self.job_number = m.get('jobNumber')
        return self


class QueryAllDepartmentResponseBodyContentGroupAndExtListGroup(TeaModel):
    def __init__(
        self,
        id: int = None,
        name: str = None,
        dept_id: int = None,
        gmt_create_str: str = None,
        gmt_modified_str: str = None,
        corp_id: str = None,
        leader: QueryAllDepartmentResponseBodyContentGroupAndExtListGroupLeader = None,
        dept_status: int = None,
        parent_dept_code: str = None,
        remark: str = None,
    ):
        # 医疗组ID
        self.id = id
        # 医疗组名称
        self.name = name
        # 科室ID，同parentDeptCode，这里保留是做兼容，原来定义成Long不太好改成了String了
        self.dept_id = dept_id
        # 创建时间
        self.gmt_create_str = gmt_create_str
        # 修改时间
        self.gmt_modified_str = gmt_modified_str
        # 租户CorpID
        self.corp_id = corp_id
        # 医疗组组长信息
        self.leader = leader
        # 部门状态：0-正常，1-删除
        self.dept_status = dept_status
        # 父级组织id，这里医疗组的父级就是科室
        self.parent_dept_code = parent_dept_code
        # 备注
        self.remark = remark

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
        if self.gmt_create_str is not None:
            result['gmtCreateStr'] = self.gmt_create_str
        if self.gmt_modified_str is not None:
            result['gmtModifiedStr'] = self.gmt_modified_str
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.leader is not None:
            result['leader'] = self.leader.to_map()
        if self.dept_status is not None:
            result['deptStatus'] = self.dept_status
        if self.parent_dept_code is not None:
            result['parentDeptCode'] = self.parent_dept_code
        if self.remark is not None:
            result['remark'] = self.remark
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('gmtCreateStr') is not None:
            self.gmt_create_str = m.get('gmtCreateStr')
        if m.get('gmtModifiedStr') is not None:
            self.gmt_modified_str = m.get('gmtModifiedStr')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('leader') is not None:
            temp_model = QueryAllDepartmentResponseBodyContentGroupAndExtListGroupLeader()
            self.leader = temp_model.from_map(m['leader'])
        if m.get('deptStatus') is not None:
            self.dept_status = m.get('deptStatus')
        if m.get('parentDeptCode') is not None:
            self.parent_dept_code = m.get('parentDeptCode')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        return self


class QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos(TeaModel):
    def __init__(
        self,
        id: int = None,
        gmt_create_str: str = None,
        gmt_modified_str: str = None,
        corp_id: str = None,
        dept_code: str = None,
        dept_extend_key: str = None,
        dept_extend_value: str = None,
        dept_extend_display_name: str = None,
        status: int = None,
    ):
        # 扩展信息id
        self.id = id
        # 创建时间
        self.gmt_create_str = gmt_create_str
        # 修改时间
        self.gmt_modified_str = gmt_modified_str
        # 租户CorpID
        self.corp_id = corp_id
        # 部门code
        self.dept_code = dept_code
        # 医疗组扩展字段key
        self.dept_extend_key = dept_extend_key
        # 医疗组扩展字段value
        self.dept_extend_value = dept_extend_value
        # 医疗组扩展字段描述
        self.dept_extend_display_name = dept_extend_display_name
        # 0-有效 ，1-无效
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.gmt_create_str is not None:
            result['gmtCreateStr'] = self.gmt_create_str
        if self.gmt_modified_str is not None:
            result['gmtModifiedStr'] = self.gmt_modified_str
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.dept_code is not None:
            result['deptCode'] = self.dept_code
        if self.dept_extend_key is not None:
            result['deptExtendKey'] = self.dept_extend_key
        if self.dept_extend_value is not None:
            result['deptExtendValue'] = self.dept_extend_value
        if self.dept_extend_display_name is not None:
            result['deptExtendDisplayName'] = self.dept_extend_display_name
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('gmtCreateStr') is not None:
            self.gmt_create_str = m.get('gmtCreateStr')
        if m.get('gmtModifiedStr') is not None:
            self.gmt_modified_str = m.get('gmtModifiedStr')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('deptCode') is not None:
            self.dept_code = m.get('deptCode')
        if m.get('deptExtendKey') is not None:
            self.dept_extend_key = m.get('deptExtendKey')
        if m.get('deptExtendValue') is not None:
            self.dept_extend_value = m.get('deptExtendValue')
        if m.get('deptExtendDisplayName') is not None:
            self.dept_extend_display_name = m.get('deptExtendDisplayName')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class QueryAllDepartmentResponseBodyContentGroupAndExtList(TeaModel):
    def __init__(
        self,
        group: QueryAllDepartmentResponseBodyContentGroupAndExtListGroup = None,
        extend_infos: List[QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos] = None,
    ):
        # 医疗组详细信息
        self.group = group
        # 医疗组扩展信息列表
        self.extend_infos = extend_infos

    def validate(self):
        if self.group:
            self.group.validate()
        if self.extend_infos:
            for k in self.extend_infos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group is not None:
            result['group'] = self.group.to_map()
        result['extendInfos'] = []
        if self.extend_infos is not None:
            for k in self.extend_infos:
                result['extendInfos'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('group') is not None:
            temp_model = QueryAllDepartmentResponseBodyContentGroupAndExtListGroup()
            self.group = temp_model.from_map(m['group'])
        self.extend_infos = []
        if m.get('extendInfos') is not None:
            for k in m.get('extendInfos'):
                temp_model = QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos()
                self.extend_infos.append(temp_model.from_map(k))
        return self


class QueryAllDepartmentResponseBodyContent(TeaModel):
    def __init__(
        self,
        id: int = None,
        name: str = None,
        dept_and_ext: QueryAllDepartmentResponseBodyContentDeptAndExt = None,
        group_and_ext_list: List[QueryAllDepartmentResponseBodyContentGroupAndExtList] = None,
    ):
        # 科室ID
        self.id = id
        # 科室名称
        self.name = name
        # 科室详情
        self.dept_and_ext = dept_and_ext
        # 医疗组列表
        self.group_and_ext_list = group_and_ext_list

    def validate(self):
        if self.dept_and_ext:
            self.dept_and_ext.validate()
        if self.group_and_ext_list:
            for k in self.group_and_ext_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.dept_and_ext is not None:
            result['deptAndExt'] = self.dept_and_ext.to_map()
        result['groupAndExtList'] = []
        if self.group_and_ext_list is not None:
            for k in self.group_and_ext_list:
                result['groupAndExtList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('deptAndExt') is not None:
            temp_model = QueryAllDepartmentResponseBodyContentDeptAndExt()
            self.dept_and_ext = temp_model.from_map(m['deptAndExt'])
        self.group_and_ext_list = []
        if m.get('groupAndExtList') is not None:
            for k in m.get('groupAndExtList'):
                temp_model = QueryAllDepartmentResponseBodyContentGroupAndExtList()
                self.group_and_ext_list.append(temp_model.from_map(k))
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


class SaveUserExtendValuesHeaders(TeaModel):
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


class SaveUserExtendValuesRequest(TeaModel):
    def __init__(
        self,
        user_extend_key: str = None,
        user_extend_value: str = None,
        user_display_name: str = None,
    ):
        # 用户拓展字段key
        self.user_extend_key = user_extend_key
        # 用户扩展字段value
        self.user_extend_value = user_extend_value
        # 字段展示名称
        self.user_display_name = user_display_name

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
        if self.user_display_name is not None:
            result['userDisplayName'] = self.user_display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userExtendKey') is not None:
            self.user_extend_key = m.get('userExtendKey')
        if m.get('userExtendValue') is not None:
            self.user_extend_value = m.get('userExtendValue')
        if m.get('userDisplayName') is not None:
            self.user_display_name = m.get('userDisplayName')
        return self


class SaveUserExtendValuesResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        # 是否成功
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


class SaveUserExtendValuesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SaveUserExtendValuesResponseBody = None,
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
            temp_model = SaveUserExtendValuesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


