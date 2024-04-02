# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, Any, List


class HrbrainImportAwardDetailHeaders(TeaModel):
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


class HrbrainImportAwardDetailRequestBody(TeaModel):
    def __init__(
        self,
        award_date: str = None,
        award_name: str = None,
        award_org: str = None,
        award_type: str = None,
        comment: str = None,
        extend_info: Dict[str, Any] = None,
        name: str = None,
        work_no: str = None,
    ):
        self.award_date = award_date
        self.award_name = award_name
        self.award_org = award_org
        self.award_type = award_type
        self.comment = comment
        self.extend_info = extend_info
        self.name = name
        self.work_no = work_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.award_date is not None:
            result['awardDate'] = self.award_date
        if self.award_name is not None:
            result['awardName'] = self.award_name
        if self.award_org is not None:
            result['awardOrg'] = self.award_org
        if self.award_type is not None:
            result['awardType'] = self.award_type
        if self.comment is not None:
            result['comment'] = self.comment
        if self.extend_info is not None:
            result['extendInfo'] = self.extend_info
        if self.name is not None:
            result['name'] = self.name
        if self.work_no is not None:
            result['workNo'] = self.work_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('awardDate') is not None:
            self.award_date = m.get('awardDate')
        if m.get('awardName') is not None:
            self.award_name = m.get('awardName')
        if m.get('awardOrg') is not None:
            self.award_org = m.get('awardOrg')
        if m.get('awardType') is not None:
            self.award_type = m.get('awardType')
        if m.get('comment') is not None:
            self.comment = m.get('comment')
        if m.get('extendInfo') is not None:
            self.extend_info = m.get('extendInfo')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('workNo') is not None:
            self.work_no = m.get('workNo')
        return self


class HrbrainImportAwardDetailRequest(TeaModel):
    def __init__(
        self,
        body: List[HrbrainImportAwardDetailRequestBody] = None,
        corp_id: str = None,
    ):
        self.body = body
        self.corp_id = corp_id

    def validate(self):
        if self.body:
            for k in self.body:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['body'] = []
        if self.body is not None:
            for k in self.body:
                result['body'].append(k.to_map() if k else None)
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.body = []
        if m.get('body') is not None:
            for k in m.get('body'):
                temp_model = HrbrainImportAwardDetailRequestBody()
                self.body.append(temp_model.from_map(k))
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        return self


class HrbrainImportAwardDetailResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: bool = None,
        success: bool = None,
    ):
        self.request_id = request_id
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class HrbrainImportAwardDetailResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: HrbrainImportAwardDetailResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = HrbrainImportAwardDetailResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class HrbrainImportDeptInfoHeaders(TeaModel):
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


class HrbrainImportDeptInfoRequestBody(TeaModel):
    def __init__(
        self,
        create_date: str = None,
        dept_name: str = None,
        dept_no: str = None,
        effective_date: str = None,
        extend_info: Dict[str, Any] = None,
        is_effective: str = None,
        super_dept_name: str = None,
        super_dept_no: str = None,
        super_emp_id: str = None,
        super_name: str = None,
    ):
        self.create_date = create_date
        self.dept_name = dept_name
        self.dept_no = dept_no
        self.effective_date = effective_date
        self.extend_info = extend_info
        self.is_effective = is_effective
        self.super_dept_name = super_dept_name
        self.super_dept_no = super_dept_no
        self.super_emp_id = super_emp_id
        self.super_name = super_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_date is not None:
            result['createDate'] = self.create_date
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.dept_no is not None:
            result['deptNo'] = self.dept_no
        if self.effective_date is not None:
            result['effectiveDate'] = self.effective_date
        if self.extend_info is not None:
            result['extendInfo'] = self.extend_info
        if self.is_effective is not None:
            result['isEffective'] = self.is_effective
        if self.super_dept_name is not None:
            result['superDeptName'] = self.super_dept_name
        if self.super_dept_no is not None:
            result['superDeptNo'] = self.super_dept_no
        if self.super_emp_id is not None:
            result['superEmpId'] = self.super_emp_id
        if self.super_name is not None:
            result['superName'] = self.super_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createDate') is not None:
            self.create_date = m.get('createDate')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('deptNo') is not None:
            self.dept_no = m.get('deptNo')
        if m.get('effectiveDate') is not None:
            self.effective_date = m.get('effectiveDate')
        if m.get('extendInfo') is not None:
            self.extend_info = m.get('extendInfo')
        if m.get('isEffective') is not None:
            self.is_effective = m.get('isEffective')
        if m.get('superDeptName') is not None:
            self.super_dept_name = m.get('superDeptName')
        if m.get('superDeptNo') is not None:
            self.super_dept_no = m.get('superDeptNo')
        if m.get('superEmpId') is not None:
            self.super_emp_id = m.get('superEmpId')
        if m.get('superName') is not None:
            self.super_name = m.get('superName')
        return self


class HrbrainImportDeptInfoRequest(TeaModel):
    def __init__(
        self,
        body: List[HrbrainImportDeptInfoRequestBody] = None,
        corp_id: str = None,
    ):
        self.body = body
        self.corp_id = corp_id

    def validate(self):
        if self.body:
            for k in self.body:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['body'] = []
        if self.body is not None:
            for k in self.body:
                result['body'].append(k.to_map() if k else None)
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.body = []
        if m.get('body') is not None:
            for k in m.get('body'):
                temp_model = HrbrainImportDeptInfoRequestBody()
                self.body.append(temp_model.from_map(k))
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        return self


class HrbrainImportDeptInfoResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: bool = None,
        success: bool = None,
    ):
        self.request_id = request_id
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class HrbrainImportDeptInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: HrbrainImportDeptInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = HrbrainImportDeptInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class HrbrainImportDimissionHeaders(TeaModel):
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


class HrbrainImportDimissionRequestBody(TeaModel):
    def __init__(
        self,
        dept_name: str = None,
        dept_no: str = None,
        dimission_date: str = None,
        dimission_reaason_desc: str = None,
        dimission_reason: str = None,
        emp_type: str = None,
        extend_info: Dict[str, Any] = None,
        job_code_name: str = None,
        job_level: str = None,
        name: str = None,
        post_name: str = None,
        super_name: str = None,
        work_loc_addr: str = None,
        work_no: str = None,
    ):
        self.dept_name = dept_name
        self.dept_no = dept_no
        self.dimission_date = dimission_date
        self.dimission_reaason_desc = dimission_reaason_desc
        self.dimission_reason = dimission_reason
        self.emp_type = emp_type
        self.extend_info = extend_info
        self.job_code_name = job_code_name
        self.job_level = job_level
        self.name = name
        self.post_name = post_name
        self.super_name = super_name
        self.work_loc_addr = work_loc_addr
        self.work_no = work_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.dept_no is not None:
            result['deptNo'] = self.dept_no
        if self.dimission_date is not None:
            result['dimissionDate'] = self.dimission_date
        if self.dimission_reaason_desc is not None:
            result['dimissionReaasonDesc'] = self.dimission_reaason_desc
        if self.dimission_reason is not None:
            result['dimissionReason'] = self.dimission_reason
        if self.emp_type is not None:
            result['empType'] = self.emp_type
        if self.extend_info is not None:
            result['extendInfo'] = self.extend_info
        if self.job_code_name is not None:
            result['jobCodeName'] = self.job_code_name
        if self.job_level is not None:
            result['jobLevel'] = self.job_level
        if self.name is not None:
            result['name'] = self.name
        if self.post_name is not None:
            result['postName'] = self.post_name
        if self.super_name is not None:
            result['superName'] = self.super_name
        if self.work_loc_addr is not None:
            result['workLocAddr'] = self.work_loc_addr
        if self.work_no is not None:
            result['workNo'] = self.work_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('deptNo') is not None:
            self.dept_no = m.get('deptNo')
        if m.get('dimissionDate') is not None:
            self.dimission_date = m.get('dimissionDate')
        if m.get('dimissionReaasonDesc') is not None:
            self.dimission_reaason_desc = m.get('dimissionReaasonDesc')
        if m.get('dimissionReason') is not None:
            self.dimission_reason = m.get('dimissionReason')
        if m.get('empType') is not None:
            self.emp_type = m.get('empType')
        if m.get('extendInfo') is not None:
            self.extend_info = m.get('extendInfo')
        if m.get('jobCodeName') is not None:
            self.job_code_name = m.get('jobCodeName')
        if m.get('jobLevel') is not None:
            self.job_level = m.get('jobLevel')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('postName') is not None:
            self.post_name = m.get('postName')
        if m.get('superName') is not None:
            self.super_name = m.get('superName')
        if m.get('workLocAddr') is not None:
            self.work_loc_addr = m.get('workLocAddr')
        if m.get('workNo') is not None:
            self.work_no = m.get('workNo')
        return self


class HrbrainImportDimissionRequest(TeaModel):
    def __init__(
        self,
        body: List[HrbrainImportDimissionRequestBody] = None,
        corp_id: str = None,
    ):
        self.body = body
        self.corp_id = corp_id

    def validate(self):
        if self.body:
            for k in self.body:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['body'] = []
        if self.body is not None:
            for k in self.body:
                result['body'].append(k.to_map() if k else None)
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.body = []
        if m.get('body') is not None:
            for k in m.get('body'):
                temp_model = HrbrainImportDimissionRequestBody()
                self.body.append(temp_model.from_map(k))
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        return self


class HrbrainImportDimissionResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: bool = None,
        success: bool = None,
    ):
        self.request_id = request_id
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class HrbrainImportDimissionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: HrbrainImportDimissionResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = HrbrainImportDimissionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class HrbrainImportEduExpHeaders(TeaModel):
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


class HrbrainImportEduExpRequestBody(TeaModel):
    def __init__(
        self,
        edu_name: str = None,
        end_date: str = None,
        extend_info: Dict[str, Any] = None,
        major: str = None,
        name: str = None,
        school_name: str = None,
        start_date: str = None,
        work_no: str = None,
    ):
        self.edu_name = edu_name
        self.end_date = end_date
        self.extend_info = extend_info
        self.major = major
        self.name = name
        self.school_name = school_name
        self.start_date = start_date
        self.work_no = work_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.edu_name is not None:
            result['eduName'] = self.edu_name
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.extend_info is not None:
            result['extendInfo'] = self.extend_info
        if self.major is not None:
            result['major'] = self.major
        if self.name is not None:
            result['name'] = self.name
        if self.school_name is not None:
            result['schoolName'] = self.school_name
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.work_no is not None:
            result['workNo'] = self.work_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('eduName') is not None:
            self.edu_name = m.get('eduName')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('extendInfo') is not None:
            self.extend_info = m.get('extendInfo')
        if m.get('major') is not None:
            self.major = m.get('major')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('schoolName') is not None:
            self.school_name = m.get('schoolName')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('workNo') is not None:
            self.work_no = m.get('workNo')
        return self


class HrbrainImportEduExpRequest(TeaModel):
    def __init__(
        self,
        body: List[HrbrainImportEduExpRequestBody] = None,
        corp_id: str = None,
    ):
        self.body = body
        self.corp_id = corp_id

    def validate(self):
        if self.body:
            for k in self.body:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['body'] = []
        if self.body is not None:
            for k in self.body:
                result['body'].append(k.to_map() if k else None)
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.body = []
        if m.get('body') is not None:
            for k in m.get('body'):
                temp_model = HrbrainImportEduExpRequestBody()
                self.body.append(temp_model.from_map(k))
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        return self


class HrbrainImportEduExpResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: bool = None,
        success: bool = None,
    ):
        self.request_id = request_id
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class HrbrainImportEduExpResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: HrbrainImportEduExpResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = HrbrainImportEduExpResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class HrbrainImportEmpInfoHeaders(TeaModel):
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


class HrbrainImportEmpInfoRequestBody(TeaModel):
    def __init__(
        self,
        birthday: str = None,
        dept_name: str = None,
        dept_no: str = None,
        dimission_date: str = None,
        emp_source: str = None,
        emp_status: str = None,
        emp_type: str = None,
        extend_info: Dict[str, Any] = None,
        gender: str = None,
        highest_degree: str = None,
        highest_edu_name: str = None,
        is_dimission: str = None,
        job_code_name: str = None,
        job_level: str = None,
        last_school_name: str = None,
        marriage: str = None,
        name: str = None,
        nation: str = None,
        nation_ctry: str = None,
        political_status: str = None,
        post_name: str = None,
        regist_date: str = None,
        regular_date: str = None,
        super_emp_id: str = None,
        super_name: str = None,
        work_email: str = None,
        work_loc_addr: str = None,
        work_loc_city: str = None,
        work_no: str = None,
    ):
        self.birthday = birthday
        self.dept_name = dept_name
        self.dept_no = dept_no
        self.dimission_date = dimission_date
        self.emp_source = emp_source
        self.emp_status = emp_status
        self.emp_type = emp_type
        self.extend_info = extend_info
        self.gender = gender
        self.highest_degree = highest_degree
        self.highest_edu_name = highest_edu_name
        self.is_dimission = is_dimission
        self.job_code_name = job_code_name
        self.job_level = job_level
        self.last_school_name = last_school_name
        self.marriage = marriage
        self.name = name
        self.nation = nation
        self.nation_ctry = nation_ctry
        self.political_status = political_status
        self.post_name = post_name
        self.regist_date = regist_date
        self.regular_date = regular_date
        self.super_emp_id = super_emp_id
        self.super_name = super_name
        self.work_email = work_email
        self.work_loc_addr = work_loc_addr
        self.work_loc_city = work_loc_city
        self.work_no = work_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.birthday is not None:
            result['birthday'] = self.birthday
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.dept_no is not None:
            result['deptNo'] = self.dept_no
        if self.dimission_date is not None:
            result['dimissionDate'] = self.dimission_date
        if self.emp_source is not None:
            result['empSource'] = self.emp_source
        if self.emp_status is not None:
            result['empStatus'] = self.emp_status
        if self.emp_type is not None:
            result['empType'] = self.emp_type
        if self.extend_info is not None:
            result['extendInfo'] = self.extend_info
        if self.gender is not None:
            result['gender'] = self.gender
        if self.highest_degree is not None:
            result['highestDegree'] = self.highest_degree
        if self.highest_edu_name is not None:
            result['highestEduName'] = self.highest_edu_name
        if self.is_dimission is not None:
            result['isDimission'] = self.is_dimission
        if self.job_code_name is not None:
            result['jobCodeName'] = self.job_code_name
        if self.job_level is not None:
            result['jobLevel'] = self.job_level
        if self.last_school_name is not None:
            result['lastSchoolName'] = self.last_school_name
        if self.marriage is not None:
            result['marriage'] = self.marriage
        if self.name is not None:
            result['name'] = self.name
        if self.nation is not None:
            result['nation'] = self.nation
        if self.nation_ctry is not None:
            result['nationCtry'] = self.nation_ctry
        if self.political_status is not None:
            result['politicalStatus'] = self.political_status
        if self.post_name is not None:
            result['postName'] = self.post_name
        if self.regist_date is not None:
            result['registDate'] = self.regist_date
        if self.regular_date is not None:
            result['regularDate'] = self.regular_date
        if self.super_emp_id is not None:
            result['superEmpId'] = self.super_emp_id
        if self.super_name is not None:
            result['superName'] = self.super_name
        if self.work_email is not None:
            result['workEmail'] = self.work_email
        if self.work_loc_addr is not None:
            result['workLocAddr'] = self.work_loc_addr
        if self.work_loc_city is not None:
            result['workLocCity'] = self.work_loc_city
        if self.work_no is not None:
            result['workNo'] = self.work_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('birthday') is not None:
            self.birthday = m.get('birthday')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('deptNo') is not None:
            self.dept_no = m.get('deptNo')
        if m.get('dimissionDate') is not None:
            self.dimission_date = m.get('dimissionDate')
        if m.get('empSource') is not None:
            self.emp_source = m.get('empSource')
        if m.get('empStatus') is not None:
            self.emp_status = m.get('empStatus')
        if m.get('empType') is not None:
            self.emp_type = m.get('empType')
        if m.get('extendInfo') is not None:
            self.extend_info = m.get('extendInfo')
        if m.get('gender') is not None:
            self.gender = m.get('gender')
        if m.get('highestDegree') is not None:
            self.highest_degree = m.get('highestDegree')
        if m.get('highestEduName') is not None:
            self.highest_edu_name = m.get('highestEduName')
        if m.get('isDimission') is not None:
            self.is_dimission = m.get('isDimission')
        if m.get('jobCodeName') is not None:
            self.job_code_name = m.get('jobCodeName')
        if m.get('jobLevel') is not None:
            self.job_level = m.get('jobLevel')
        if m.get('lastSchoolName') is not None:
            self.last_school_name = m.get('lastSchoolName')
        if m.get('marriage') is not None:
            self.marriage = m.get('marriage')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('nation') is not None:
            self.nation = m.get('nation')
        if m.get('nationCtry') is not None:
            self.nation_ctry = m.get('nationCtry')
        if m.get('politicalStatus') is not None:
            self.political_status = m.get('politicalStatus')
        if m.get('postName') is not None:
            self.post_name = m.get('postName')
        if m.get('registDate') is not None:
            self.regist_date = m.get('registDate')
        if m.get('regularDate') is not None:
            self.regular_date = m.get('regularDate')
        if m.get('superEmpId') is not None:
            self.super_emp_id = m.get('superEmpId')
        if m.get('superName') is not None:
            self.super_name = m.get('superName')
        if m.get('workEmail') is not None:
            self.work_email = m.get('workEmail')
        if m.get('workLocAddr') is not None:
            self.work_loc_addr = m.get('workLocAddr')
        if m.get('workLocCity') is not None:
            self.work_loc_city = m.get('workLocCity')
        if m.get('workNo') is not None:
            self.work_no = m.get('workNo')
        return self


class HrbrainImportEmpInfoRequest(TeaModel):
    def __init__(
        self,
        body: List[HrbrainImportEmpInfoRequestBody] = None,
        corp_id: str = None,
    ):
        self.body = body
        self.corp_id = corp_id

    def validate(self):
        if self.body:
            for k in self.body:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['body'] = []
        if self.body is not None:
            for k in self.body:
                result['body'].append(k.to_map() if k else None)
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.body = []
        if m.get('body') is not None:
            for k in m.get('body'):
                temp_model = HrbrainImportEmpInfoRequestBody()
                self.body.append(temp_model.from_map(k))
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        return self


class HrbrainImportEmpInfoResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: bool = None,
        success: bool = None,
    ):
        self.request_id = request_id
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class HrbrainImportEmpInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: HrbrainImportEmpInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = HrbrainImportEmpInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class HrbrainImportLabelBaseHeaders(TeaModel):
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


class HrbrainImportLabelBaseRequestBody(TeaModel):
    def __init__(
        self,
        extend_info: Dict[str, Any] = None,
        name: str = None,
        work_no: str = None,
    ):
        self.extend_info = extend_info
        self.name = name
        self.work_no = work_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.extend_info is not None:
            result['extendInfo'] = self.extend_info
        if self.name is not None:
            result['name'] = self.name
        if self.work_no is not None:
            result['workNo'] = self.work_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('extendInfo') is not None:
            self.extend_info = m.get('extendInfo')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('workNo') is not None:
            self.work_no = m.get('workNo')
        return self


class HrbrainImportLabelBaseRequest(TeaModel):
    def __init__(
        self,
        body: List[HrbrainImportLabelBaseRequestBody] = None,
        corp_id: str = None,
    ):
        self.body = body
        self.corp_id = corp_id

    def validate(self):
        if self.body:
            for k in self.body:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['body'] = []
        if self.body is not None:
            for k in self.body:
                result['body'].append(k.to_map() if k else None)
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.body = []
        if m.get('body') is not None:
            for k in m.get('body'):
                temp_model = HrbrainImportLabelBaseRequestBody()
                self.body.append(temp_model.from_map(k))
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        return self


class HrbrainImportLabelBaseResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: bool = None,
        success: bool = None,
    ):
        self.request_id = request_id
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class HrbrainImportLabelBaseResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: HrbrainImportLabelBaseResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = HrbrainImportLabelBaseResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class HrbrainImportLabelCustomHeaders(TeaModel):
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


class HrbrainImportLabelCustomRequestBody(TeaModel):
    def __init__(
        self,
        extend_info: Dict[str, Any] = None,
        name: str = None,
        tag: str = None,
        work_no: str = None,
    ):
        self.extend_info = extend_info
        self.name = name
        self.tag = tag
        self.work_no = work_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.extend_info is not None:
            result['extendInfo'] = self.extend_info
        if self.name is not None:
            result['name'] = self.name
        if self.tag is not None:
            result['tag'] = self.tag
        if self.work_no is not None:
            result['workNo'] = self.work_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('extendInfo') is not None:
            self.extend_info = m.get('extendInfo')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('tag') is not None:
            self.tag = m.get('tag')
        if m.get('workNo') is not None:
            self.work_no = m.get('workNo')
        return self


class HrbrainImportLabelCustomRequest(TeaModel):
    def __init__(
        self,
        body: List[HrbrainImportLabelCustomRequestBody] = None,
        corp_id: str = None,
    ):
        self.body = body
        self.corp_id = corp_id

    def validate(self):
        if self.body:
            for k in self.body:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['body'] = []
        if self.body is not None:
            for k in self.body:
                result['body'].append(k.to_map() if k else None)
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.body = []
        if m.get('body') is not None:
            for k in m.get('body'):
                temp_model = HrbrainImportLabelCustomRequestBody()
                self.body.append(temp_model.from_map(k))
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        return self


class HrbrainImportLabelCustomResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: bool = None,
        success: bool = None,
    ):
        self.request_id = request_id
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class HrbrainImportLabelCustomResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: HrbrainImportLabelCustomResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = HrbrainImportLabelCustomResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class HrbrainImportLabelIndustryHeaders(TeaModel):
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


class HrbrainImportLabelIndustryRequestBody(TeaModel):
    def __init__(
        self,
        extend_info: Dict[str, Any] = None,
        level_1: str = None,
        level_2: str = None,
        level_3: str = None,
        name: str = None,
        work_no: str = None,
    ):
        self.extend_info = extend_info
        self.level_1 = level_1
        self.level_2 = level_2
        self.level_3 = level_3
        self.name = name
        self.work_no = work_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.extend_info is not None:
            result['extendInfo'] = self.extend_info
        if self.level_1 is not None:
            result['level1'] = self.level_1
        if self.level_2 is not None:
            result['level2'] = self.level_2
        if self.level_3 is not None:
            result['level3'] = self.level_3
        if self.name is not None:
            result['name'] = self.name
        if self.work_no is not None:
            result['workNo'] = self.work_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('extendInfo') is not None:
            self.extend_info = m.get('extendInfo')
        if m.get('level1') is not None:
            self.level_1 = m.get('level1')
        if m.get('level2') is not None:
            self.level_2 = m.get('level2')
        if m.get('level3') is not None:
            self.level_3 = m.get('level3')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('workNo') is not None:
            self.work_no = m.get('workNo')
        return self


class HrbrainImportLabelIndustryRequest(TeaModel):
    def __init__(
        self,
        body: List[HrbrainImportLabelIndustryRequestBody] = None,
        corp_id: str = None,
    ):
        self.body = body
        self.corp_id = corp_id

    def validate(self):
        if self.body:
            for k in self.body:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['body'] = []
        if self.body is not None:
            for k in self.body:
                result['body'].append(k.to_map() if k else None)
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.body = []
        if m.get('body') is not None:
            for k in m.get('body'):
                temp_model = HrbrainImportLabelIndustryRequestBody()
                self.body.append(temp_model.from_map(k))
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        return self


class HrbrainImportLabelIndustryResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: bool = None,
        success: bool = None,
    ):
        self.request_id = request_id
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class HrbrainImportLabelIndustryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: HrbrainImportLabelIndustryResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = HrbrainImportLabelIndustryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class HrbrainImportLabelInventoryHeaders(TeaModel):
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


class HrbrainImportLabelInventoryRequestBody(TeaModel):
    def __init__(
        self,
        extend_info: Dict[str, Any] = None,
        name: str = None,
        period: str = None,
        work_no: str = None,
    ):
        self.extend_info = extend_info
        self.name = name
        self.period = period
        self.work_no = work_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.extend_info is not None:
            result['extendInfo'] = self.extend_info
        if self.name is not None:
            result['name'] = self.name
        if self.period is not None:
            result['period'] = self.period
        if self.work_no is not None:
            result['workNo'] = self.work_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('extendInfo') is not None:
            self.extend_info = m.get('extendInfo')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('workNo') is not None:
            self.work_no = m.get('workNo')
        return self


class HrbrainImportLabelInventoryRequest(TeaModel):
    def __init__(
        self,
        body: List[HrbrainImportLabelInventoryRequestBody] = None,
        corp_id: str = None,
    ):
        self.body = body
        self.corp_id = corp_id

    def validate(self):
        if self.body:
            for k in self.body:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['body'] = []
        if self.body is not None:
            for k in self.body:
                result['body'].append(k.to_map() if k else None)
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.body = []
        if m.get('body') is not None:
            for k in m.get('body'):
                temp_model = HrbrainImportLabelInventoryRequestBody()
                self.body.append(temp_model.from_map(k))
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        return self


class HrbrainImportLabelInventoryResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: bool = None,
        success: bool = None,
    ):
        self.request_id = request_id
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class HrbrainImportLabelInventoryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: HrbrainImportLabelInventoryResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = HrbrainImportLabelInventoryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class HrbrainImportLabelProfSkillHeaders(TeaModel):
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


class HrbrainImportLabelProfSkillRequestBody(TeaModel):
    def __init__(
        self,
        extend_info: Dict[str, Any] = None,
        level_1: str = None,
        level_2: str = None,
        level_3: str = None,
        name: str = None,
        work_no: str = None,
    ):
        self.extend_info = extend_info
        self.level_1 = level_1
        self.level_2 = level_2
        self.level_3 = level_3
        self.name = name
        self.work_no = work_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.extend_info is not None:
            result['extendInfo'] = self.extend_info
        if self.level_1 is not None:
            result['level1'] = self.level_1
        if self.level_2 is not None:
            result['level2'] = self.level_2
        if self.level_3 is not None:
            result['level3'] = self.level_3
        if self.name is not None:
            result['name'] = self.name
        if self.work_no is not None:
            result['workNo'] = self.work_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('extendInfo') is not None:
            self.extend_info = m.get('extendInfo')
        if m.get('level1') is not None:
            self.level_1 = m.get('level1')
        if m.get('level2') is not None:
            self.level_2 = m.get('level2')
        if m.get('level3') is not None:
            self.level_3 = m.get('level3')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('workNo') is not None:
            self.work_no = m.get('workNo')
        return self


class HrbrainImportLabelProfSkillRequest(TeaModel):
    def __init__(
        self,
        body: List[HrbrainImportLabelProfSkillRequestBody] = None,
        corp_id: str = None,
    ):
        self.body = body
        self.corp_id = corp_id

    def validate(self):
        if self.body:
            for k in self.body:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['body'] = []
        if self.body is not None:
            for k in self.body:
                result['body'].append(k.to_map() if k else None)
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.body = []
        if m.get('body') is not None:
            for k in m.get('body'):
                temp_model = HrbrainImportLabelProfSkillRequestBody()
                self.body.append(temp_model.from_map(k))
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        return self


class HrbrainImportLabelProfSkillResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: bool = None,
        success: bool = None,
    ):
        self.request_id = request_id
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class HrbrainImportLabelProfSkillResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: HrbrainImportLabelProfSkillResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = HrbrainImportLabelProfSkillResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class HrbrainImportPerfEvalHeaders(TeaModel):
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


class HrbrainImportPerfEvalRequestBody(TeaModel):
    def __init__(
        self,
        comment: str = None,
        extend_info: Dict[str, Any] = None,
        name: str = None,
        perf_cate: str = None,
        perf_plan_name: str = None,
        perf_score: str = None,
        period: str = None,
        period_end_date: str = None,
        period_start_date: str = None,
        score: str = None,
        work_no: str = None,
    ):
        self.comment = comment
        self.extend_info = extend_info
        self.name = name
        self.perf_cate = perf_cate
        self.perf_plan_name = perf_plan_name
        self.perf_score = perf_score
        self.period = period
        self.period_end_date = period_end_date
        self.period_start_date = period_start_date
        self.score = score
        self.work_no = work_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.comment is not None:
            result['comment'] = self.comment
        if self.extend_info is not None:
            result['extendInfo'] = self.extend_info
        if self.name is not None:
            result['name'] = self.name
        if self.perf_cate is not None:
            result['perfCate'] = self.perf_cate
        if self.perf_plan_name is not None:
            result['perfPlanName'] = self.perf_plan_name
        if self.perf_score is not None:
            result['perfScore'] = self.perf_score
        if self.period is not None:
            result['period'] = self.period
        if self.period_end_date is not None:
            result['periodEndDate'] = self.period_end_date
        if self.period_start_date is not None:
            result['periodStartDate'] = self.period_start_date
        if self.score is not None:
            result['score'] = self.score
        if self.work_no is not None:
            result['workNo'] = self.work_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('comment') is not None:
            self.comment = m.get('comment')
        if m.get('extendInfo') is not None:
            self.extend_info = m.get('extendInfo')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('perfCate') is not None:
            self.perf_cate = m.get('perfCate')
        if m.get('perfPlanName') is not None:
            self.perf_plan_name = m.get('perfPlanName')
        if m.get('perfScore') is not None:
            self.perf_score = m.get('perfScore')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('periodEndDate') is not None:
            self.period_end_date = m.get('periodEndDate')
        if m.get('periodStartDate') is not None:
            self.period_start_date = m.get('periodStartDate')
        if m.get('score') is not None:
            self.score = m.get('score')
        if m.get('workNo') is not None:
            self.work_no = m.get('workNo')
        return self


class HrbrainImportPerfEvalRequest(TeaModel):
    def __init__(
        self,
        body: List[HrbrainImportPerfEvalRequestBody] = None,
        corp_id: str = None,
    ):
        self.body = body
        self.corp_id = corp_id

    def validate(self):
        if self.body:
            for k in self.body:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['body'] = []
        if self.body is not None:
            for k in self.body:
                result['body'].append(k.to_map() if k else None)
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.body = []
        if m.get('body') is not None:
            for k in m.get('body'):
                temp_model = HrbrainImportPerfEvalRequestBody()
                self.body.append(temp_model.from_map(k))
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        return self


class HrbrainImportPerfEvalResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: bool = None,
        success: bool = None,
    ):
        self.request_id = request_id
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class HrbrainImportPerfEvalResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: HrbrainImportPerfEvalResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = HrbrainImportPerfEvalResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class HrbrainImportPromEvalHeaders(TeaModel):
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


class HrbrainImportPromEvalRequestBody(TeaModel):
    def __init__(
        self,
        comment: str = None,
        effective_date: str = None,
        extend_info: Dict[str, Any] = None,
        name: str = None,
        new_job_level: str = None,
        period: str = None,
        period_end_date: str = None,
        period_start_date: str = None,
        pre_job_level: str = None,
        work_no: str = None,
    ):
        self.comment = comment
        self.effective_date = effective_date
        self.extend_info = extend_info
        self.name = name
        self.new_job_level = new_job_level
        self.period = period
        self.period_end_date = period_end_date
        self.period_start_date = period_start_date
        self.pre_job_level = pre_job_level
        self.work_no = work_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.comment is not None:
            result['comment'] = self.comment
        if self.effective_date is not None:
            result['effectiveDate'] = self.effective_date
        if self.extend_info is not None:
            result['extendInfo'] = self.extend_info
        if self.name is not None:
            result['name'] = self.name
        if self.new_job_level is not None:
            result['newJobLevel'] = self.new_job_level
        if self.period is not None:
            result['period'] = self.period
        if self.period_end_date is not None:
            result['periodEndDate'] = self.period_end_date
        if self.period_start_date is not None:
            result['periodStartDate'] = self.period_start_date
        if self.pre_job_level is not None:
            result['preJobLevel'] = self.pre_job_level
        if self.work_no is not None:
            result['workNo'] = self.work_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('comment') is not None:
            self.comment = m.get('comment')
        if m.get('effectiveDate') is not None:
            self.effective_date = m.get('effectiveDate')
        if m.get('extendInfo') is not None:
            self.extend_info = m.get('extendInfo')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('newJobLevel') is not None:
            self.new_job_level = m.get('newJobLevel')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('periodEndDate') is not None:
            self.period_end_date = m.get('periodEndDate')
        if m.get('periodStartDate') is not None:
            self.period_start_date = m.get('periodStartDate')
        if m.get('preJobLevel') is not None:
            self.pre_job_level = m.get('preJobLevel')
        if m.get('workNo') is not None:
            self.work_no = m.get('workNo')
        return self


class HrbrainImportPromEvalRequest(TeaModel):
    def __init__(
        self,
        body: List[HrbrainImportPromEvalRequestBody] = None,
        corp_id: str = None,
    ):
        self.body = body
        self.corp_id = corp_id

    def validate(self):
        if self.body:
            for k in self.body:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['body'] = []
        if self.body is not None:
            for k in self.body:
                result['body'].append(k.to_map() if k else None)
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.body = []
        if m.get('body') is not None:
            for k in m.get('body'):
                temp_model = HrbrainImportPromEvalRequestBody()
                self.body.append(temp_model.from_map(k))
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        return self


class HrbrainImportPromEvalResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: bool = None,
        success: bool = None,
    ):
        self.request_id = request_id
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class HrbrainImportPromEvalResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: HrbrainImportPromEvalResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = HrbrainImportPromEvalResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class HrbrainImportPunDetailHeaders(TeaModel):
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


class HrbrainImportPunDetailRequestBody(TeaModel):
    def __init__(
        self,
        comment: str = None,
        effective_date: str = None,
        extend_info: Dict[str, Any] = None,
        name: str = None,
        pun_name: str = None,
        pun_org: str = None,
        work_no: str = None,
    ):
        self.comment = comment
        self.effective_date = effective_date
        self.extend_info = extend_info
        self.name = name
        self.pun_name = pun_name
        self.pun_org = pun_org
        self.work_no = work_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.comment is not None:
            result['comment'] = self.comment
        if self.effective_date is not None:
            result['effectiveDate'] = self.effective_date
        if self.extend_info is not None:
            result['extendInfo'] = self.extend_info
        if self.name is not None:
            result['name'] = self.name
        if self.pun_name is not None:
            result['punName'] = self.pun_name
        if self.pun_org is not None:
            result['punOrg'] = self.pun_org
        if self.work_no is not None:
            result['workNo'] = self.work_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('comment') is not None:
            self.comment = m.get('comment')
        if m.get('effectiveDate') is not None:
            self.effective_date = m.get('effectiveDate')
        if m.get('extendInfo') is not None:
            self.extend_info = m.get('extendInfo')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('punName') is not None:
            self.pun_name = m.get('punName')
        if m.get('punOrg') is not None:
            self.pun_org = m.get('punOrg')
        if m.get('workNo') is not None:
            self.work_no = m.get('workNo')
        return self


class HrbrainImportPunDetailRequest(TeaModel):
    def __init__(
        self,
        body: List[HrbrainImportPunDetailRequestBody] = None,
        corp_id: str = None,
    ):
        self.body = body
        self.corp_id = corp_id

    def validate(self):
        if self.body:
            for k in self.body:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['body'] = []
        if self.body is not None:
            for k in self.body:
                result['body'].append(k.to_map() if k else None)
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.body = []
        if m.get('body') is not None:
            for k in m.get('body'):
                temp_model = HrbrainImportPunDetailRequestBody()
                self.body.append(temp_model.from_map(k))
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        return self


class HrbrainImportPunDetailResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: bool = None,
        success: bool = None,
    ):
        self.request_id = request_id
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class HrbrainImportPunDetailResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: HrbrainImportPunDetailResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = HrbrainImportPunDetailResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class HrbrainImportRegistHeaders(TeaModel):
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


class HrbrainImportRegistRequestBody(TeaModel):
    def __init__(
        self,
        dept_name: str = None,
        dept_no: str = None,
        emp_source: str = None,
        emp_type: str = None,
        extend_info: Dict[str, Any] = None,
        job_code_name: str = None,
        job_level: str = None,
        name: str = None,
        post_name: str = None,
        regist_date: str = None,
        super_name: str = None,
        work_loc_addr: str = None,
        work_no: str = None,
    ):
        self.dept_name = dept_name
        self.dept_no = dept_no
        self.emp_source = emp_source
        self.emp_type = emp_type
        self.extend_info = extend_info
        self.job_code_name = job_code_name
        self.job_level = job_level
        self.name = name
        self.post_name = post_name
        self.regist_date = regist_date
        self.super_name = super_name
        self.work_loc_addr = work_loc_addr
        self.work_no = work_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.dept_no is not None:
            result['deptNo'] = self.dept_no
        if self.emp_source is not None:
            result['empSource'] = self.emp_source
        if self.emp_type is not None:
            result['empType'] = self.emp_type
        if self.extend_info is not None:
            result['extendInfo'] = self.extend_info
        if self.job_code_name is not None:
            result['jobCodeName'] = self.job_code_name
        if self.job_level is not None:
            result['jobLevel'] = self.job_level
        if self.name is not None:
            result['name'] = self.name
        if self.post_name is not None:
            result['postName'] = self.post_name
        if self.regist_date is not None:
            result['registDate'] = self.regist_date
        if self.super_name is not None:
            result['superName'] = self.super_name
        if self.work_loc_addr is not None:
            result['workLocAddr'] = self.work_loc_addr
        if self.work_no is not None:
            result['workNo'] = self.work_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('deptNo') is not None:
            self.dept_no = m.get('deptNo')
        if m.get('empSource') is not None:
            self.emp_source = m.get('empSource')
        if m.get('empType') is not None:
            self.emp_type = m.get('empType')
        if m.get('extendInfo') is not None:
            self.extend_info = m.get('extendInfo')
        if m.get('jobCodeName') is not None:
            self.job_code_name = m.get('jobCodeName')
        if m.get('jobLevel') is not None:
            self.job_level = m.get('jobLevel')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('postName') is not None:
            self.post_name = m.get('postName')
        if m.get('registDate') is not None:
            self.regist_date = m.get('registDate')
        if m.get('superName') is not None:
            self.super_name = m.get('superName')
        if m.get('workLocAddr') is not None:
            self.work_loc_addr = m.get('workLocAddr')
        if m.get('workNo') is not None:
            self.work_no = m.get('workNo')
        return self


class HrbrainImportRegistRequest(TeaModel):
    def __init__(
        self,
        body: List[HrbrainImportRegistRequestBody] = None,
        corp_id: str = None,
    ):
        self.body = body
        self.corp_id = corp_id

    def validate(self):
        if self.body:
            for k in self.body:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['body'] = []
        if self.body is not None:
            for k in self.body:
                result['body'].append(k.to_map() if k else None)
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.body = []
        if m.get('body') is not None:
            for k in m.get('body'):
                temp_model = HrbrainImportRegistRequestBody()
                self.body.append(temp_model.from_map(k))
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        return self


class HrbrainImportRegistResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: bool = None,
        success: bool = None,
    ):
        self.request_id = request_id
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class HrbrainImportRegistResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: HrbrainImportRegistResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = HrbrainImportRegistResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class HrbrainImportTransferEvalHeaders(TeaModel):
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


class HrbrainImportTransferEvalRequestBody(TeaModel):
    def __init__(
        self,
        curr_info: Dict[str, Any] = None,
        extend_info: Dict[str, Any] = None,
        name: str = None,
        pre_info: Dict[str, Any] = None,
        transfer_date: str = None,
        transfer_reason: str = None,
        transfer_type: str = None,
        work_no: str = None,
    ):
        self.curr_info = curr_info
        self.extend_info = extend_info
        self.name = name
        self.pre_info = pre_info
        self.transfer_date = transfer_date
        self.transfer_reason = transfer_reason
        self.transfer_type = transfer_type
        self.work_no = work_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.curr_info is not None:
            result['currInfo'] = self.curr_info
        if self.extend_info is not None:
            result['extendInfo'] = self.extend_info
        if self.name is not None:
            result['name'] = self.name
        if self.pre_info is not None:
            result['preInfo'] = self.pre_info
        if self.transfer_date is not None:
            result['transferDate'] = self.transfer_date
        if self.transfer_reason is not None:
            result['transferReason'] = self.transfer_reason
        if self.transfer_type is not None:
            result['transferType'] = self.transfer_type
        if self.work_no is not None:
            result['workNo'] = self.work_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('currInfo') is not None:
            self.curr_info = m.get('currInfo')
        if m.get('extendInfo') is not None:
            self.extend_info = m.get('extendInfo')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('preInfo') is not None:
            self.pre_info = m.get('preInfo')
        if m.get('transferDate') is not None:
            self.transfer_date = m.get('transferDate')
        if m.get('transferReason') is not None:
            self.transfer_reason = m.get('transferReason')
        if m.get('transferType') is not None:
            self.transfer_type = m.get('transferType')
        if m.get('workNo') is not None:
            self.work_no = m.get('workNo')
        return self


class HrbrainImportTransferEvalRequest(TeaModel):
    def __init__(
        self,
        body: List[HrbrainImportTransferEvalRequestBody] = None,
        corp_id: str = None,
    ):
        self.body = body
        self.corp_id = corp_id

    def validate(self):
        if self.body:
            for k in self.body:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['body'] = []
        if self.body is not None:
            for k in self.body:
                result['body'].append(k.to_map() if k else None)
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.body = []
        if m.get('body') is not None:
            for k in m.get('body'):
                temp_model = HrbrainImportTransferEvalRequestBody()
                self.body.append(temp_model.from_map(k))
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        return self


class HrbrainImportTransferEvalResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: bool = None,
        success: bool = None,
    ):
        self.request_id = request_id
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class HrbrainImportTransferEvalResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: HrbrainImportTransferEvalResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = HrbrainImportTransferEvalResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class HrbrainImportWorkExpHeaders(TeaModel):
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


class HrbrainImportWorkExpRequestBody(TeaModel):
    def __init__(
        self,
        company_name: str = None,
        end_date: str = None,
        extend_info: Dict[str, Any] = None,
        job_desc: str = None,
        name: str = None,
        post_name: str = None,
        start_date: str = None,
        work_no: str = None,
    ):
        self.company_name = company_name
        self.end_date = end_date
        self.extend_info = extend_info
        self.job_desc = job_desc
        self.name = name
        self.post_name = post_name
        self.start_date = start_date
        self.work_no = work_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.company_name is not None:
            result['companyName'] = self.company_name
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.extend_info is not None:
            result['extendInfo'] = self.extend_info
        if self.job_desc is not None:
            result['jobDesc'] = self.job_desc
        if self.name is not None:
            result['name'] = self.name
        if self.post_name is not None:
            result['postName'] = self.post_name
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.work_no is not None:
            result['workNo'] = self.work_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('companyName') is not None:
            self.company_name = m.get('companyName')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('extendInfo') is not None:
            self.extend_info = m.get('extendInfo')
        if m.get('jobDesc') is not None:
            self.job_desc = m.get('jobDesc')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('postName') is not None:
            self.post_name = m.get('postName')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('workNo') is not None:
            self.work_no = m.get('workNo')
        return self


class HrbrainImportWorkExpRequest(TeaModel):
    def __init__(
        self,
        body: List[HrbrainImportWorkExpRequestBody] = None,
        corp_id: str = None,
    ):
        self.body = body
        self.corp_id = corp_id

    def validate(self):
        if self.body:
            for k in self.body:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['body'] = []
        if self.body is not None:
            for k in self.body:
                result['body'].append(k.to_map() if k else None)
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.body = []
        if m.get('body') is not None:
            for k in m.get('body'):
                temp_model = HrbrainImportWorkExpRequestBody()
                self.body.append(temp_model.from_map(k))
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        return self


class HrbrainImportWorkExpResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: bool = None,
        success: bool = None,
    ):
        self.request_id = request_id
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class HrbrainImportWorkExpResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: HrbrainImportWorkExpResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = HrbrainImportWorkExpResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SyncDataHeaders(TeaModel):
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


class SyncDataRequest(TeaModel):
    def __init__(
        self,
        content: str = None,
        data_id: str = None,
        etl_time: str = None,
        project_id: str = None,
        schema_id: str = None,
    ):
        self.content = content
        self.data_id = data_id
        self.etl_time = etl_time
        self.project_id = project_id
        self.schema_id = schema_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.data_id is not None:
            result['dataId'] = self.data_id
        if self.etl_time is not None:
            result['etlTime'] = self.etl_time
        if self.project_id is not None:
            result['projectId'] = self.project_id
        if self.schema_id is not None:
            result['schemaId'] = self.schema_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('dataId') is not None:
            self.data_id = m.get('dataId')
        if m.get('etlTime') is not None:
            self.etl_time = m.get('etlTime')
        if m.get('projectId') is not None:
            self.project_id = m.get('projectId')
        if m.get('schemaId') is not None:
            self.schema_id = m.get('schemaId')
        return self


class SyncDataResponseBody(TeaModel):
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


class SyncDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SyncDataResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = SyncDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


