# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class AddApplicationRegFormTemplateHeaders(TeaModel):
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


class AddApplicationRegFormTemplateRequest(TeaModel):
    def __init__(
        self,
        biz_code: str = None,
        content: str = None,
        name: str = None,
        outer_id: str = None,
        op_user_id: str = None,
    ):
        # 业务标识
        self.biz_code = biz_code
        # 模板内容
        self.content = content
        # 模板名称
        self.name = name
        # 外部唯一标识
        self.outer_id = outer_id
        # 操作人员工标识
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        if self.content is not None:
            result['content'] = self.content
        if self.name is not None:
            result['name'] = self.name
        if self.outer_id is not None:
            result['outerId'] = self.outer_id
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('outerId') is not None:
            self.outer_id = m.get('outerId')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class AddApplicationRegFormTemplateResponseBody(TeaModel):
    def __init__(
        self,
        template_id: str = None,
        version: int = None,
    ):
        # 模板标识
        self.template_id = template_id
        # 模板版本
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.template_id is not None:
            result['templateId'] = self.template_id
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class AddApplicationRegFormTemplateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: AddApplicationRegFormTemplateResponseBody = None,
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
            temp_model = AddApplicationRegFormTemplateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AddFileHeaders(TeaModel):
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


class AddFileRequest(TeaModel):
    def __init__(
        self,
        biz_code: str = None,
        file_name: str = None,
        media_id: str = None,
        op_user_id: str = None,
    ):
        # 业务标识
        self.biz_code = biz_code
        # 文件名称
        self.file_name = file_name
        # 文件mediaId
        self.media_id = media_id
        # 操作人员工标识，为空时默认以企业管理员身份进行操作
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.media_id is not None:
            result['mediaId'] = self.media_id
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('mediaId') is not None:
            self.media_id = m.get('mediaId')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class AddFileResponseBody(TeaModel):
    def __init__(
        self,
        file_id: str = None,
        file_name: str = None,
        space_id: int = None,
    ):
        # 文件标识
        self.file_id = file_id
        # 文件名
        self.file_name = file_name
        # 空间标识
        self.space_id = space_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        return self


class AddFileResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: AddFileResponseBody = None,
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
            temp_model = AddFileResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AddUserAccountHeaders(TeaModel):
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


class AddUserAccountRequest(TeaModel):
    def __init__(
        self,
        biz_code: str = None,
        channel_account_name: str = None,
        channel_user_identify: str = None,
        phone_number: str = None,
        corp_id: str = None,
        user_id: str = None,
    ):
        # 业务标识
        self.biz_code = biz_code
        # 渠道账号名
        self.channel_account_name = channel_account_name
        # 渠道用户标识
        self.channel_user_identify = channel_user_identify
        # 手机号
        self.phone_number = phone_number
        # 企业标识
        self.corp_id = corp_id
        # 用户标识
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        if self.channel_account_name is not None:
            result['channelAccountName'] = self.channel_account_name
        if self.channel_user_identify is not None:
            result['channelUserIdentify'] = self.channel_user_identify
        if self.phone_number is not None:
            result['phoneNumber'] = self.phone_number
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        if m.get('channelAccountName') is not None:
            self.channel_account_name = m.get('channelAccountName')
        if m.get('channelUserIdentify') is not None:
            self.channel_user_identify = m.get('channelUserIdentify')
        if m.get('phoneNumber') is not None:
            self.phone_number = m.get('phoneNumber')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class AddUserAccountResponseBody(TeaModel):
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


class AddUserAccountResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: AddUserAccountResponseBody = None,
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
            temp_model = AddUserAccountResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CollectResumeDetailHeaders(TeaModel):
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


class CollectResumeDetailRequestResumeDataBaseInfo(TeaModel):
    def __init__(
        self,
        age: int = None,
        avatar: str = None,
        begin_work_time: str = None,
        birthday: str = None,
        email: str = None,
        english_name: str = None,
        graduate_time: str = None,
        highest_education: int = None,
        job_title: str = None,
        last_school_name: str = None,
        married: int = None,
        name: str = None,
        native_place: str = None,
        now_location: str = None,
        personal_honor: str = None,
        phone_num: str = None,
        political_status: int = None,
        self_evaluation: str = None,
        sex: int = None,
        virtual_phone_num: str = None,
        working_years: int = None,
    ):
        # 年龄
        self.age = age
        # 头像cdn地址，http链接
        self.avatar = avatar
        # 初次工作时间
        self.begin_work_time = begin_work_time
        # 生日
        self.birthday = birthday
        # 邮箱地址
        self.email = email
        # 英文名称
        self.english_name = english_name
        # 毕业时间
        self.graduate_time = graduate_time
        # 最高学历
        self.highest_education = highest_education
        # 当前工作职位名称
        self.job_title = job_title
        # 最高学历毕业院校名称
        self.last_school_name = last_school_name
        # 婚姻状况
        self.married = married
        # 名称
        self.name = name
        # 籍贯地址
        self.native_place = native_place
        # 现居住地址
        self.now_location = now_location
        # 个人荣誉
        self.personal_honor = personal_honor
        # 手机号
        self.phone_num = phone_num
        # 政治面貌
        self.political_status = political_status
        # 自我评价
        self.self_evaluation = self_evaluation
        # 性别
        self.sex = sex
        # 虚拟手机号
        self.virtual_phone_num = virtual_phone_num
        # 工作年限
        self.working_years = working_years

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.age is not None:
            result['age'] = self.age
        if self.avatar is not None:
            result['avatar'] = self.avatar
        if self.begin_work_time is not None:
            result['beginWorkTime'] = self.begin_work_time
        if self.birthday is not None:
            result['birthday'] = self.birthday
        if self.email is not None:
            result['email'] = self.email
        if self.english_name is not None:
            result['englishName'] = self.english_name
        if self.graduate_time is not None:
            result['graduateTime'] = self.graduate_time
        if self.highest_education is not None:
            result['highestEducation'] = self.highest_education
        if self.job_title is not None:
            result['jobTitle'] = self.job_title
        if self.last_school_name is not None:
            result['lastSchoolName'] = self.last_school_name
        if self.married is not None:
            result['married'] = self.married
        if self.name is not None:
            result['name'] = self.name
        if self.native_place is not None:
            result['nativePlace'] = self.native_place
        if self.now_location is not None:
            result['nowLocation'] = self.now_location
        if self.personal_honor is not None:
            result['personalHonor'] = self.personal_honor
        if self.phone_num is not None:
            result['phoneNum'] = self.phone_num
        if self.political_status is not None:
            result['politicalStatus'] = self.political_status
        if self.self_evaluation is not None:
            result['selfEvaluation'] = self.self_evaluation
        if self.sex is not None:
            result['sex'] = self.sex
        if self.virtual_phone_num is not None:
            result['virtualPhoneNum'] = self.virtual_phone_num
        if self.working_years is not None:
            result['workingYears'] = self.working_years
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('age') is not None:
            self.age = m.get('age')
        if m.get('avatar') is not None:
            self.avatar = m.get('avatar')
        if m.get('beginWorkTime') is not None:
            self.begin_work_time = m.get('beginWorkTime')
        if m.get('birthday') is not None:
            self.birthday = m.get('birthday')
        if m.get('email') is not None:
            self.email = m.get('email')
        if m.get('englishName') is not None:
            self.english_name = m.get('englishName')
        if m.get('graduateTime') is not None:
            self.graduate_time = m.get('graduateTime')
        if m.get('highestEducation') is not None:
            self.highest_education = m.get('highestEducation')
        if m.get('jobTitle') is not None:
            self.job_title = m.get('jobTitle')
        if m.get('lastSchoolName') is not None:
            self.last_school_name = m.get('lastSchoolName')
        if m.get('married') is not None:
            self.married = m.get('married')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('nativePlace') is not None:
            self.native_place = m.get('nativePlace')
        if m.get('nowLocation') is not None:
            self.now_location = m.get('nowLocation')
        if m.get('personalHonor') is not None:
            self.personal_honor = m.get('personalHonor')
        if m.get('phoneNum') is not None:
            self.phone_num = m.get('phoneNum')
        if m.get('politicalStatus') is not None:
            self.political_status = m.get('politicalStatus')
        if m.get('selfEvaluation') is not None:
            self.self_evaluation = m.get('selfEvaluation')
        if m.get('sex') is not None:
            self.sex = m.get('sex')
        if m.get('virtualPhoneNum') is not None:
            self.virtual_phone_num = m.get('virtualPhoneNum')
        if m.get('workingYears') is not None:
            self.working_years = m.get('workingYears')
        return self


class CollectResumeDetailRequestResumeDataCertificates(TeaModel):
    def __init__(
        self,
        certificate_name: str = None,
        grant_time: str = None,
    ):
        # 证书名称
        self.certificate_name = certificate_name
        # 证书授予时间
        self.grant_time = grant_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.certificate_name is not None:
            result['certificateName'] = self.certificate_name
        if self.grant_time is not None:
            result['grantTime'] = self.grant_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('certificateName') is not None:
            self.certificate_name = m.get('certificateName')
        if m.get('grantTime') is not None:
            self.grant_time = m.get('grantTime')
        return self


class CollectResumeDetailRequestResumeDataEducationExperiences(TeaModel):
    def __init__(
        self,
        degree: int = None,
        department: str = None,
        description: str = None,
        end_date: str = None,
        major: str = None,
        school_name: str = None,
        start_date: str = None,
    ):
        # 学历
        self.degree = degree
        # 院系
        self.department = department
        # 详细描述
        self.description = description
        # 结束时间
        self.end_date = end_date
        # 专业
        self.major = major
        # 学校名称
        self.school_name = school_name
        # 开始时间
        self.start_date = start_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.degree is not None:
            result['degree'] = self.degree
        if self.department is not None:
            result['department'] = self.department
        if self.description is not None:
            result['description'] = self.description
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.major is not None:
            result['major'] = self.major
        if self.school_name is not None:
            result['schoolName'] = self.school_name
        if self.start_date is not None:
            result['startDate'] = self.start_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('degree') is not None:
            self.degree = m.get('degree')
        if m.get('department') is not None:
            self.department = m.get('department')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('major') is not None:
            self.major = m.get('major')
        if m.get('schoolName') is not None:
            self.school_name = m.get('schoolName')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        return self


class CollectResumeDetailRequestResumeDataJobExpect(TeaModel):
    def __init__(
        self,
        job_name: str = None,
        locations: List[str] = None,
        max_salary: str = None,
        min_salary: str = None,
        onboard_time: str = None,
    ):
        # 期望职位名称
        self.job_name = job_name
        # 期望工作地
        self.locations = locations
        # 最高期望工资
        self.max_salary = max_salary
        # 最低期望工资
        self.min_salary = min_salary
        # 期望入职时间
        self.onboard_time = onboard_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.job_name is not None:
            result['jobName'] = self.job_name
        if self.locations is not None:
            result['locations'] = self.locations
        if self.max_salary is not None:
            result['maxSalary'] = self.max_salary
        if self.min_salary is not None:
            result['minSalary'] = self.min_salary
        if self.onboard_time is not None:
            result['onboardTime'] = self.onboard_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('jobName') is not None:
            self.job_name = m.get('jobName')
        if m.get('locations') is not None:
            self.locations = m.get('locations')
        if m.get('maxSalary') is not None:
            self.max_salary = m.get('maxSalary')
        if m.get('minSalary') is not None:
            self.min_salary = m.get('minSalary')
        if m.get('onboardTime') is not None:
            self.onboard_time = m.get('onboardTime')
        return self


class CollectResumeDetailRequestResumeDataLanguageSkill(TeaModel):
    def __init__(
        self,
        certificate_name: str = None,
        language_name: str = None,
    ):
        # 证书名称
        self.certificate_name = certificate_name
        # 语言名称
        self.language_name = language_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.certificate_name is not None:
            result['certificateName'] = self.certificate_name
        if self.language_name is not None:
            result['languageName'] = self.language_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('certificateName') is not None:
            self.certificate_name = m.get('certificateName')
        if m.get('languageName') is not None:
            self.language_name = m.get('languageName')
        return self


class CollectResumeDetailRequestResumeDataTrainingExperiences(TeaModel):
    def __init__(
        self,
        description: str = None,
        end_date: str = None,
        institution_name: str = None,
        location: str = None,
        name: str = None,
        start_date: str = None,
    ):
        # 详细内容描述
        self.description = description
        # 结束时间
        self.end_date = end_date
        # 培训机构名称
        self.institution_name = institution_name
        # 培训地点
        self.location = location
        # 培训名称
        self.name = name
        # 开始时间
        self.start_date = start_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.institution_name is not None:
            result['institutionName'] = self.institution_name
        if self.location is not None:
            result['location'] = self.location
        if self.name is not None:
            result['name'] = self.name
        if self.start_date is not None:
            result['startDate'] = self.start_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('institutionName') is not None:
            self.institution_name = m.get('institutionName')
        if m.get('location') is not None:
            self.location = m.get('location')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        return self


class CollectResumeDetailRequestResumeDataWorkExperiences(TeaModel):
    def __init__(
        self,
        company_name: str = None,
        department: str = None,
        description: str = None,
        end_date: str = None,
        job_title: str = None,
        location: str = None,
        responsibility: str = None,
        start_date: str = None,
    ):
        # 公司名称
        self.company_name = company_name
        # 部门
        self.department = department
        # 工作详情描述
        self.description = description
        self.end_date = end_date
        # 职位名称
        self.job_title = job_title
        # 工作地点
        self.location = location
        # 工作职责
        self.responsibility = responsibility
        self.start_date = start_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.company_name is not None:
            result['companyName'] = self.company_name
        if self.department is not None:
            result['department'] = self.department
        if self.description is not None:
            result['description'] = self.description
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.job_title is not None:
            result['jobTitle'] = self.job_title
        if self.location is not None:
            result['location'] = self.location
        if self.responsibility is not None:
            result['responsibility'] = self.responsibility
        if self.start_date is not None:
            result['startDate'] = self.start_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('companyName') is not None:
            self.company_name = m.get('companyName')
        if m.get('department') is not None:
            self.department = m.get('department')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('jobTitle') is not None:
            self.job_title = m.get('jobTitle')
        if m.get('location') is not None:
            self.location = m.get('location')
        if m.get('responsibility') is not None:
            self.responsibility = m.get('responsibility')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        return self


class CollectResumeDetailRequestResumeData(TeaModel):
    def __init__(
        self,
        base_info: CollectResumeDetailRequestResumeDataBaseInfo = None,
        certificates: List[CollectResumeDetailRequestResumeDataCertificates] = None,
        education_experiences: List[CollectResumeDetailRequestResumeDataEducationExperiences] = None,
        job_expect: CollectResumeDetailRequestResumeDataJobExpect = None,
        language_skill: List[CollectResumeDetailRequestResumeDataLanguageSkill] = None,
        training_experiences: List[CollectResumeDetailRequestResumeDataTrainingExperiences] = None,
        work_experiences: List[CollectResumeDetailRequestResumeDataWorkExperiences] = None,
    ):
        # 简历基础信息
        self.base_info = base_info
        # 证书信息
        self.certificates = certificates
        # 教育经历
        self.education_experiences = education_experiences
        # 期望职位信息
        self.job_expect = job_expect
        # 语言能力
        self.language_skill = language_skill
        # 培训经历
        self.training_experiences = training_experiences
        # 工作经历
        self.work_experiences = work_experiences

    def validate(self):
        if self.base_info:
            self.base_info.validate()
        if self.certificates:
            for k in self.certificates:
                if k:
                    k.validate()
        if self.education_experiences:
            for k in self.education_experiences:
                if k:
                    k.validate()
        if self.job_expect:
            self.job_expect.validate()
        if self.language_skill:
            for k in self.language_skill:
                if k:
                    k.validate()
        if self.training_experiences:
            for k in self.training_experiences:
                if k:
                    k.validate()
        if self.work_experiences:
            for k in self.work_experiences:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.base_info is not None:
            result['baseInfo'] = self.base_info.to_map()
        result['certificates'] = []
        if self.certificates is not None:
            for k in self.certificates:
                result['certificates'].append(k.to_map() if k else None)
        result['educationExperiences'] = []
        if self.education_experiences is not None:
            for k in self.education_experiences:
                result['educationExperiences'].append(k.to_map() if k else None)
        if self.job_expect is not None:
            result['jobExpect'] = self.job_expect.to_map()
        result['languageSkill'] = []
        if self.language_skill is not None:
            for k in self.language_skill:
                result['languageSkill'].append(k.to_map() if k else None)
        result['trainingExperiences'] = []
        if self.training_experiences is not None:
            for k in self.training_experiences:
                result['trainingExperiences'].append(k.to_map() if k else None)
        result['workExperiences'] = []
        if self.work_experiences is not None:
            for k in self.work_experiences:
                result['workExperiences'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('baseInfo') is not None:
            temp_model = CollectResumeDetailRequestResumeDataBaseInfo()
            self.base_info = temp_model.from_map(m['baseInfo'])
        self.certificates = []
        if m.get('certificates') is not None:
            for k in m.get('certificates'):
                temp_model = CollectResumeDetailRequestResumeDataCertificates()
                self.certificates.append(temp_model.from_map(k))
        self.education_experiences = []
        if m.get('educationExperiences') is not None:
            for k in m.get('educationExperiences'):
                temp_model = CollectResumeDetailRequestResumeDataEducationExperiences()
                self.education_experiences.append(temp_model.from_map(k))
        if m.get('jobExpect') is not None:
            temp_model = CollectResumeDetailRequestResumeDataJobExpect()
            self.job_expect = temp_model.from_map(m['jobExpect'])
        self.language_skill = []
        if m.get('languageSkill') is not None:
            for k in m.get('languageSkill'):
                temp_model = CollectResumeDetailRequestResumeDataLanguageSkill()
                self.language_skill.append(temp_model.from_map(k))
        self.training_experiences = []
        if m.get('trainingExperiences') is not None:
            for k in m.get('trainingExperiences'):
                temp_model = CollectResumeDetailRequestResumeDataTrainingExperiences()
                self.training_experiences.append(temp_model.from_map(k))
        self.work_experiences = []
        if m.get('workExperiences') is not None:
            for k in m.get('workExperiences'):
                temp_model = CollectResumeDetailRequestResumeDataWorkExperiences()
                self.work_experiences.append(temp_model.from_map(k))
        return self


class CollectResumeDetailRequest(TeaModel):
    def __init__(
        self,
        biz_code: str = None,
        channel_outer_id: str = None,
        channel_talent_id: str = None,
        deliver_job_id: str = None,
        opt_user_id: str = None,
        resume_data: CollectResumeDetailRequestResumeData = None,
    ):
        # 业务标识，目前固定为ddats
        self.biz_code = biz_code
        # 渠道侧简历标识
        self.channel_outer_id = channel_outer_id
        # 渠道侧候选人标识。
        self.channel_talent_id = channel_talent_id
        # 简历投递职位标识
        self.deliver_job_id = deliver_job_id
        self.opt_user_id = opt_user_id
        # 简历详情信息
        self.resume_data = resume_data

    def validate(self):
        if self.resume_data:
            self.resume_data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        if self.channel_outer_id is not None:
            result['channelOuterId'] = self.channel_outer_id
        if self.channel_talent_id is not None:
            result['channelTalentId'] = self.channel_talent_id
        if self.deliver_job_id is not None:
            result['deliverJobId'] = self.deliver_job_id
        if self.opt_user_id is not None:
            result['optUserId'] = self.opt_user_id
        if self.resume_data is not None:
            result['resumeData'] = self.resume_data.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        if m.get('channelOuterId') is not None:
            self.channel_outer_id = m.get('channelOuterId')
        if m.get('channelTalentId') is not None:
            self.channel_talent_id = m.get('channelTalentId')
        if m.get('deliverJobId') is not None:
            self.deliver_job_id = m.get('deliverJobId')
        if m.get('optUserId') is not None:
            self.opt_user_id = m.get('optUserId')
        if m.get('resumeData') is not None:
            temp_model = CollectResumeDetailRequestResumeData()
            self.resume_data = temp_model.from_map(m['resumeData'])
        return self


class CollectResumeDetailResponseBody(TeaModel):
    def __init__(
        self,
        resume_id: str = None,
    ):
        # 简历标识
        self.resume_id = resume_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.resume_id is not None:
            result['resumeId'] = self.resume_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('resumeId') is not None:
            self.resume_id = m.get('resumeId')
        return self


class CollectResumeDetailResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CollectResumeDetailResponseBody = None,
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
            temp_model = CollectResumeDetailResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ConfirmRightsHeaders(TeaModel):
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


class ConfirmRightsRequest(TeaModel):
    def __init__(
        self,
        biz_code: str = None,
    ):
        # 业务标识
        self.biz_code = biz_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        return self


class ConfirmRightsResponseBody(TeaModel):
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


class ConfirmRightsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ConfirmRightsResponseBody = None,
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
            temp_model = ConfirmRightsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class FinishBeginnerTaskHeaders(TeaModel):
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


class FinishBeginnerTaskRequest(TeaModel):
    def __init__(
        self,
        scope: str = None,
        user_id: str = None,
    ):
        # 任务范围
        self.scope = scope
        # 员工标识
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.scope is not None:
            result['scope'] = self.scope
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('scope') is not None:
            self.scope = m.get('scope')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class FinishBeginnerTaskResponseBody(TeaModel):
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


class FinishBeginnerTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: FinishBeginnerTaskResponseBody = None,
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
            temp_model = FinishBeginnerTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetApplicationRegFormByFlowIdHeaders(TeaModel):
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


class GetApplicationRegFormByFlowIdRequest(TeaModel):
    def __init__(
        self,
        biz_code: str = None,
    ):
        # 业务标识
        self.biz_code = biz_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        return self


class GetApplicationRegFormByFlowIdResponseBody(TeaModel):
    def __init__(
        self,
        candidate_id: str = None,
        creator_user_id: str = None,
        flow_id: str = None,
        form_id: str = None,
        gmt_create_millis: int = None,
        gmt_modified_millis: int = None,
        job_id: str = None,
        status: int = None,
        template_id: str = None,
        template_version: int = None,
    ):
        # 候选人标识
        self.candidate_id = candidate_id
        # 邀填人员工标识
        self.creator_user_id = creator_user_id
        # 招聘流程标识
        self.flow_id = flow_id
        # 表单标识
        self.form_id = form_id
        # 创建时间（邀填时间，单位：毫秒）
        self.gmt_create_millis = gmt_create_millis
        # 更新时间（填写时间，单位：毫秒），仅当表单状态为已填写时有效
        self.gmt_modified_millis = gmt_modified_millis
        # 职位标识
        self.job_id = job_id
        # 表单状态（0表示未填写，1表示已填写）
        self.status = status
        # 模板标识
        self.template_id = template_id
        # 模板版本
        self.template_version = template_version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.candidate_id is not None:
            result['candidateId'] = self.candidate_id
        if self.creator_user_id is not None:
            result['creatorUserId'] = self.creator_user_id
        if self.flow_id is not None:
            result['flowId'] = self.flow_id
        if self.form_id is not None:
            result['formId'] = self.form_id
        if self.gmt_create_millis is not None:
            result['gmtCreateMillis'] = self.gmt_create_millis
        if self.gmt_modified_millis is not None:
            result['gmtModifiedMillis'] = self.gmt_modified_millis
        if self.job_id is not None:
            result['jobId'] = self.job_id
        if self.status is not None:
            result['status'] = self.status
        if self.template_id is not None:
            result['templateId'] = self.template_id
        if self.template_version is not None:
            result['templateVersion'] = self.template_version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('candidateId') is not None:
            self.candidate_id = m.get('candidateId')
        if m.get('creatorUserId') is not None:
            self.creator_user_id = m.get('creatorUserId')
        if m.get('flowId') is not None:
            self.flow_id = m.get('flowId')
        if m.get('formId') is not None:
            self.form_id = m.get('formId')
        if m.get('gmtCreateMillis') is not None:
            self.gmt_create_millis = m.get('gmtCreateMillis')
        if m.get('gmtModifiedMillis') is not None:
            self.gmt_modified_millis = m.get('gmtModifiedMillis')
        if m.get('jobId') is not None:
            self.job_id = m.get('jobId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        if m.get('templateVersion') is not None:
            self.template_version = m.get('templateVersion')
        return self


class GetApplicationRegFormByFlowIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetApplicationRegFormByFlowIdResponseBody = None,
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
            temp_model = GetApplicationRegFormByFlowIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetCandidateByPhoneNumberHeaders(TeaModel):
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


class GetCandidateByPhoneNumberRequest(TeaModel):
    def __init__(
        self,
        biz_code: str = None,
        phone_number: str = None,
    ):
        # 业务标识
        self.biz_code = biz_code
        # 候选人手机号
        self.phone_number = phone_number

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        if self.phone_number is not None:
            result['phoneNumber'] = self.phone_number
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        if m.get('phoneNumber') is not None:
            self.phone_number = m.get('phoneNumber')
        return self


class GetCandidateByPhoneNumberResponseBody(TeaModel):
    def __init__(
        self,
        candidate_id: str = None,
        name: str = None,
    ):
        # 候选人标识
        self.candidate_id = candidate_id
        # 候选人姓名
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.candidate_id is not None:
            result['candidateId'] = self.candidate_id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('candidateId') is not None:
            self.candidate_id = m.get('candidateId')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class GetCandidateByPhoneNumberResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetCandidateByPhoneNumberResponseBody = None,
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
            temp_model = GetCandidateByPhoneNumberResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetFileUploadInfoHeaders(TeaModel):
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


class GetFileUploadInfoRequest(TeaModel):
    def __init__(
        self,
        biz_code: str = None,
        file_name: str = None,
        file_size: int = None,
        md_5: str = None,
        op_user_id: str = None,
    ):
        # 业务标识
        self.biz_code = biz_code
        # 文件名称
        self.file_name = file_name
        # 文件大小（单位：字节）
        self.file_size = file_size
        # 文件MD5摘要
        self.md_5 = md_5
        # 操作人员工标识，为空时默认以企业管理员身份进行操作
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.file_size is not None:
            result['fileSize'] = self.file_size
        if self.md_5 is not None:
            result['md5'] = self.md_5
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('fileSize') is not None:
            self.file_size = m.get('fileSize')
        if m.get('md5') is not None:
            self.md_5 = m.get('md5')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class GetFileUploadInfoResponseBody(TeaModel):
    def __init__(
        self,
        access_key_id: str = None,
        access_key_secret: str = None,
        access_token: str = None,
        access_token_expiration_millis: int = None,
        bucket: str = None,
        end_point: str = None,
        media_id: str = None,
    ):
        # OSS上传所需信息：accessKeyId
        self.access_key_id = access_key_id
        # OSS上传所需信息：accessKeySecret
        self.access_key_secret = access_key_secret
        # OSS上传所需信息：accessToken
        self.access_token = access_token
        # accessToken有效期截止时间（单位：毫秒），需要在此时间之前完成文件上传
        self.access_token_expiration_millis = access_token_expiration_millis
        # OSS上传所需信息：bucket
        self.bucket = bucket
        # OSS上传所需信息：endPoint
        self.end_point = end_point
        # 文件mediaId
        self.media_id = media_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key_id is not None:
            result['accessKeyId'] = self.access_key_id
        if self.access_key_secret is not None:
            result['accessKeySecret'] = self.access_key_secret
        if self.access_token is not None:
            result['accessToken'] = self.access_token
        if self.access_token_expiration_millis is not None:
            result['accessTokenExpirationMillis'] = self.access_token_expiration_millis
        if self.bucket is not None:
            result['bucket'] = self.bucket
        if self.end_point is not None:
            result['endPoint'] = self.end_point
        if self.media_id is not None:
            result['mediaId'] = self.media_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKeyId') is not None:
            self.access_key_id = m.get('accessKeyId')
        if m.get('accessKeySecret') is not None:
            self.access_key_secret = m.get('accessKeySecret')
        if m.get('accessToken') is not None:
            self.access_token = m.get('accessToken')
        if m.get('accessTokenExpirationMillis') is not None:
            self.access_token_expiration_millis = m.get('accessTokenExpirationMillis')
        if m.get('bucket') is not None:
            self.bucket = m.get('bucket')
        if m.get('endPoint') is not None:
            self.end_point = m.get('endPoint')
        if m.get('mediaId') is not None:
            self.media_id = m.get('mediaId')
        return self


class GetFileUploadInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetFileUploadInfoResponseBody = None,
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
            temp_model = GetFileUploadInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetFlowIdByRelationEntityIdHeaders(TeaModel):
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


class GetFlowIdByRelationEntityIdRequest(TeaModel):
    def __init__(
        self,
        biz_code: str = None,
        relation_entity: str = None,
        relation_entity_id: str = None,
    ):
        # 业务标识
        self.biz_code = biz_code
        # 招聘流程关联实体
        self.relation_entity = relation_entity
        # 招聘流程关联实体标识
        self.relation_entity_id = relation_entity_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        if self.relation_entity is not None:
            result['relationEntity'] = self.relation_entity
        if self.relation_entity_id is not None:
            result['relationEntityId'] = self.relation_entity_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        if m.get('relationEntity') is not None:
            self.relation_entity = m.get('relationEntity')
        if m.get('relationEntityId') is not None:
            self.relation_entity_id = m.get('relationEntityId')
        return self


class GetFlowIdByRelationEntityIdResponseBody(TeaModel):
    def __init__(
        self,
        flow_id: str = None,
    ):
        # 招聘流程标识
        self.flow_id = flow_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.flow_id is not None:
            result['flowId'] = self.flow_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('flowId') is not None:
            self.flow_id = m.get('flowId')
        return self


class GetFlowIdByRelationEntityIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetFlowIdByRelationEntityIdResponseBody = None,
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
            temp_model = GetFlowIdByRelationEntityIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetJobAuthHeaders(TeaModel):
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


class GetJobAuthRequest(TeaModel):
    def __init__(
        self,
        op_user_id: str = None,
    ):
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


class GetJobAuthResponseBodyJobOwners(TeaModel):
    def __init__(
        self,
        name: str = None,
        user_id: str = None,
    ):
        # 员工姓名
        self.name = name
        # 员工标识
        self.user_id = user_id

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetJobAuthResponseBody(TeaModel):
    def __init__(
        self,
        job_id: str = None,
        job_owners: List[GetJobAuthResponseBodyJobOwners] = None,
    ):
        # 职位ID
        self.job_id = job_id
        # 职位负责人
        self.job_owners = job_owners

    def validate(self):
        if self.job_owners:
            for k in self.job_owners:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.job_id is not None:
            result['jobId'] = self.job_id
        result['jobOwners'] = []
        if self.job_owners is not None:
            for k in self.job_owners:
                result['jobOwners'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('jobId') is not None:
            self.job_id = m.get('jobId')
        self.job_owners = []
        if m.get('jobOwners') is not None:
            for k in m.get('jobOwners'):
                temp_model = GetJobAuthResponseBodyJobOwners()
                self.job_owners.append(temp_model.from_map(k))
        return self


class GetJobAuthResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetJobAuthResponseBody = None,
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
            temp_model = GetJobAuthResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryInterviewsHeaders(TeaModel):
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


class QueryInterviewsRequest(TeaModel):
    def __init__(
        self,
        biz_code: str = None,
        candidate_id: str = None,
        start_time_begin_millis: int = None,
        start_time_end_millis: int = None,
        next_token: str = None,
        size: int = None,
    ):
        # 业务标识
        self.biz_code = biz_code
        # 候选人标识
        self.candidate_id = candidate_id
        # 面试开始时间的查询起始时间（单位：毫秒）
        self.start_time_begin_millis = start_time_begin_millis
        # 面试开始时间的查询结束时间（单位：毫秒）
        self.start_time_end_millis = start_time_end_millis
        # 分页游标，首次调用传空
        self.next_token = next_token
        # 分页大小
        self.size = size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        if self.candidate_id is not None:
            result['candidateId'] = self.candidate_id
        if self.start_time_begin_millis is not None:
            result['startTimeBeginMillis'] = self.start_time_begin_millis
        if self.start_time_end_millis is not None:
            result['startTimeEndMillis'] = self.start_time_end_millis
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.size is not None:
            result['size'] = self.size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        if m.get('candidateId') is not None:
            self.candidate_id = m.get('candidateId')
        if m.get('startTimeBeginMillis') is not None:
            self.start_time_begin_millis = m.get('startTimeBeginMillis')
        if m.get('startTimeEndMillis') is not None:
            self.start_time_end_millis = m.get('startTimeEndMillis')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('size') is not None:
            self.size = m.get('size')
        return self


class QueryInterviewsResponseBodyListInterviewers(TeaModel):
    def __init__(
        self,
        user_id: str = None,
    ):
        # 面试官员工标识
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryInterviewsResponseBodyList(TeaModel):
    def __init__(
        self,
        cancelled: bool = None,
        creator_user_id: str = None,
        end_time_millis: int = None,
        interview_id: str = None,
        interviewers: List[QueryInterviewsResponseBodyListInterviewers] = None,
        job_id: str = None,
        start_time_millis: int = None,
    ):
        # 面试是否已取消
        self.cancelled = cancelled
        # 面试创建人员工标识
        self.creator_user_id = creator_user_id
        # 面试结束时间（单位：毫秒）
        self.end_time_millis = end_time_millis
        # 面试标识
        self.interview_id = interview_id
        # 面试官列表
        self.interviewers = interviewers
        # 职位标识
        self.job_id = job_id
        # 面试开始时间（单位：毫秒）
        self.start_time_millis = start_time_millis

    def validate(self):
        if self.interviewers:
            for k in self.interviewers:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cancelled is not None:
            result['cancelled'] = self.cancelled
        if self.creator_user_id is not None:
            result['creatorUserId'] = self.creator_user_id
        if self.end_time_millis is not None:
            result['endTimeMillis'] = self.end_time_millis
        if self.interview_id is not None:
            result['interviewId'] = self.interview_id
        result['interviewers'] = []
        if self.interviewers is not None:
            for k in self.interviewers:
                result['interviewers'].append(k.to_map() if k else None)
        if self.job_id is not None:
            result['jobId'] = self.job_id
        if self.start_time_millis is not None:
            result['startTimeMillis'] = self.start_time_millis
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cancelled') is not None:
            self.cancelled = m.get('cancelled')
        if m.get('creatorUserId') is not None:
            self.creator_user_id = m.get('creatorUserId')
        if m.get('endTimeMillis') is not None:
            self.end_time_millis = m.get('endTimeMillis')
        if m.get('interviewId') is not None:
            self.interview_id = m.get('interviewId')
        self.interviewers = []
        if m.get('interviewers') is not None:
            for k in m.get('interviewers'):
                temp_model = QueryInterviewsResponseBodyListInterviewers()
                self.interviewers.append(temp_model.from_map(k))
        if m.get('jobId') is not None:
            self.job_id = m.get('jobId')
        if m.get('startTimeMillis') is not None:
            self.start_time_millis = m.get('startTimeMillis')
        return self


class QueryInterviewsResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QueryInterviewsResponseBodyList] = None,
        next_token: str = None,
        total_count: int = None,
    ):
        # 是否有更多数据
        self.has_more = has_more
        # 数据列表
        self.list = list
        # 下次查询的分页游标
        self.next_token = next_token
        # 总数量
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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryInterviewsResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class QueryInterviewsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryInterviewsResponseBody = None,
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
            temp_model = QueryInterviewsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ReportMessageStatusHeaders(TeaModel):
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


class ReportMessageStatusRequest(TeaModel):
    def __init__(
        self,
        biz_code: str = None,
        channel: str = None,
        error_code: str = None,
        error_msg: str = None,
        message_id: str = None,
        receiver_user_id: str = None,
        sender_user_id: str = None,
    ):
        self.biz_code = biz_code
        # 渠道标识。
        self.channel = channel
        # 错误码。
        self.error_code = error_code
        # 错误信息描述。
        self.error_msg = error_msg
        # 消息ID。
        self.message_id = message_id
        self.receiver_user_id = receiver_user_id
        self.sender_user_id = sender_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        if self.channel is not None:
            result['channel'] = self.channel
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.message_id is not None:
            result['messageId'] = self.message_id
        if self.receiver_user_id is not None:
            result['receiverUserId'] = self.receiver_user_id
        if self.sender_user_id is not None:
            result['senderUserId'] = self.sender_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        if m.get('channel') is not None:
            self.channel = m.get('channel')
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('messageId') is not None:
            self.message_id = m.get('messageId')
        if m.get('receiverUserId') is not None:
            self.receiver_user_id = m.get('receiverUserId')
        if m.get('senderUserId') is not None:
            self.sender_user_id = m.get('senderUserId')
        return self


class ReportMessageStatusResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
    ):
        # Id of the request
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


class ReportMessageStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ReportMessageStatusResponseBody = None,
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
            temp_model = ReportMessageStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SyncChannelMessageHeaders(TeaModel):
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


class SyncChannelMessageRequest(TeaModel):
    def __init__(
        self,
        biz_code: str = None,
        channel: str = None,
        content: str = None,
        create_time: int = None,
        receiver_user_id: str = None,
        sender_user_id: str = None,
        uuid: str = None,
    ):
        self.biz_code = biz_code
        # 渠道标识。
        self.channel = channel
        # 消息内容。
        self.content = content
        # 消息创建时间。
        self.create_time = create_time
        # 消息接收者ID。
        self.receiver_user_id = receiver_user_id
        # 消息发送者用户ID。
        self.sender_user_id = sender_user_id
        # 消息UUID，业务方产生用于去重。
        self.uuid = uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        if self.channel is not None:
            result['channel'] = self.channel
        if self.content is not None:
            result['content'] = self.content
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.receiver_user_id is not None:
            result['receiverUserId'] = self.receiver_user_id
        if self.sender_user_id is not None:
            result['senderUserId'] = self.sender_user_id
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        if m.get('channel') is not None:
            self.channel = m.get('channel')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('receiverUserId') is not None:
            self.receiver_user_id = m.get('receiverUserId')
        if m.get('senderUserId') is not None:
            self.sender_user_id = m.get('senderUserId')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class SyncChannelMessageResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
    ):
        # Id of the request
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


class SyncChannelMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SyncChannelMessageResponseBody = None,
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
            temp_model = SyncChannelMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateApplicationRegFormHeaders(TeaModel):
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


class UpdateApplicationRegFormRequestDingPanFile(TeaModel):
    def __init__(
        self,
        file_id: str = None,
        file_name: str = None,
        file_size: int = None,
        file_type: str = None,
        space_id: int = None,
    ):
        # 钉盘文件标识
        self.file_id = file_id
        # 文件名
        self.file_name = file_name
        # 文件大小（单位：字节）
        self.file_size = file_size
        # 文件类型（支持：pdf，doc，docx，ppt，pptx，jpg等）
        self.file_type = file_type
        # 钉盘空间标识
        self.space_id = space_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.file_size is not None:
            result['fileSize'] = self.file_size
        if self.file_type is not None:
            result['fileType'] = self.file_type
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('fileSize') is not None:
            self.file_size = m.get('fileSize')
        if m.get('fileType') is not None:
            self.file_type = m.get('fileType')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        return self


class UpdateApplicationRegFormRequest(TeaModel):
    def __init__(
        self,
        biz_code: str = None,
        content: str = None,
        ding_pan_file: UpdateApplicationRegFormRequestDingPanFile = None,
    ):
        # 业务标识
        self.biz_code = biz_code
        # 应聘登记表的表单内容
        self.content = content
        # 钉盘文件信息
        self.ding_pan_file = ding_pan_file

    def validate(self):
        if self.ding_pan_file:
            self.ding_pan_file.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        if self.content is not None:
            result['content'] = self.content
        if self.ding_pan_file is not None:
            result['dingPanFile'] = self.ding_pan_file.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('dingPanFile') is not None:
            temp_model = UpdateApplicationRegFormRequestDingPanFile()
            self.ding_pan_file = temp_model.from_map(m['dingPanFile'])
        return self


class UpdateApplicationRegFormResponseBody(TeaModel):
    def __init__(
        self,
        creator_user_id: str = None,
        form_id: str = None,
        gmt_create_millis: int = None,
        gmt_modified_millis: int = None,
        status: int = None,
        template_id: str = None,
        template_version: int = None,
    ):
        # 邀填人员工标识
        self.creator_user_id = creator_user_id
        # 表单标识
        self.form_id = form_id
        # 创建时间（邀填时间，单位：毫秒）
        self.gmt_create_millis = gmt_create_millis
        # 更新时间（填写时间，单位：毫秒），仅当表单状态为已填写时有效
        self.gmt_modified_millis = gmt_modified_millis
        # 表单状态（0表示未填写，1表示已填写）
        self.status = status
        # 模板标识
        self.template_id = template_id
        # 模板版本
        self.template_version = template_version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.creator_user_id is not None:
            result['creatorUserId'] = self.creator_user_id
        if self.form_id is not None:
            result['formId'] = self.form_id
        if self.gmt_create_millis is not None:
            result['gmtCreateMillis'] = self.gmt_create_millis
        if self.gmt_modified_millis is not None:
            result['gmtModifiedMillis'] = self.gmt_modified_millis
        if self.status is not None:
            result['status'] = self.status
        if self.template_id is not None:
            result['templateId'] = self.template_id
        if self.template_version is not None:
            result['templateVersion'] = self.template_version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('creatorUserId') is not None:
            self.creator_user_id = m.get('creatorUserId')
        if m.get('formId') is not None:
            self.form_id = m.get('formId')
        if m.get('gmtCreateMillis') is not None:
            self.gmt_create_millis = m.get('gmtCreateMillis')
        if m.get('gmtModifiedMillis') is not None:
            self.gmt_modified_millis = m.get('gmtModifiedMillis')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        if m.get('templateVersion') is not None:
            self.template_version = m.get('templateVersion')
        return self


class UpdateApplicationRegFormResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateApplicationRegFormResponseBody = None,
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
            temp_model = UpdateApplicationRegFormResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateInterviewSignInInfoHeaders(TeaModel):
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


class UpdateInterviewSignInInfoRequest(TeaModel):
    def __init__(
        self,
        biz_code: str = None,
        sign_in_time_millis: int = None,
    ):
        # 业务标识
        self.biz_code = biz_code
        # 面试签到时间（单位：毫秒）
        self.sign_in_time_millis = sign_in_time_millis

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        if self.sign_in_time_millis is not None:
            result['signInTimeMillis'] = self.sign_in_time_millis
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        if m.get('signInTimeMillis') is not None:
            self.sign_in_time_millis = m.get('signInTimeMillis')
        return self


class UpdateInterviewSignInInfoResponse(TeaModel):
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


class UpdateJobDeliverHeaders(TeaModel):
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


class UpdateJobDeliverRequest(TeaModel):
    def __init__(
        self,
        biz_code: str = None,
        channel_outer_id: str = None,
        deliver_user_id: str = None,
        error_code: str = None,
        error_msg: str = None,
        op_time: int = None,
        op_user_id: str = None,
        status: int = None,
        job_id: str = None,
    ):
        # 招聘业务标识，目前固定ddats
        self.biz_code = biz_code
        # 渠道侧职位唯一标识
        self.channel_outer_id = channel_outer_id
        # 职位投递人userId
        self.deliver_user_id = deliver_user_id
        # 渠道侧错误码
        self.error_code = error_code
        # 渠道侧错误信息
        self.error_msg = error_msg
        # 操作时间
        self.op_time = op_time
        # 操作人userId
        self.op_user_id = op_user_id
        # 职位投递状态
        self.status = status
        # 钉钉侧职位唯一标识
        self.job_id = job_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        if self.channel_outer_id is not None:
            result['channelOuterId'] = self.channel_outer_id
        if self.deliver_user_id is not None:
            result['deliverUserId'] = self.deliver_user_id
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.op_time is not None:
            result['opTime'] = self.op_time
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.status is not None:
            result['status'] = self.status
        if self.job_id is not None:
            result['jobId'] = self.job_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        if m.get('channelOuterId') is not None:
            self.channel_outer_id = m.get('channelOuterId')
        if m.get('deliverUserId') is not None:
            self.deliver_user_id = m.get('deliverUserId')
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('opTime') is not None:
            self.op_time = m.get('opTime')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('jobId') is not None:
            self.job_id = m.get('jobId')
        return self


class UpdateJobDeliverResponseBody(TeaModel):
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


class UpdateJobDeliverResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateJobDeliverResponseBody = None,
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
            temp_model = UpdateJobDeliverResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


