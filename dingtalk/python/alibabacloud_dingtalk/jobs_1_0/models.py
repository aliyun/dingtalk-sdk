# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class CreateResumeHeaders(TeaModel):
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


class CreateResumeRequestResumeDataVOBaseInfo(TeaModel):
    def __init__(
        self,
        age: int = None,
        avatar: str = None,
        begin_work_time: str = None,
        birthday: str = None,
        candidate_background: int = None,
        ding_talk: str = None,
        email: str = None,
        english_name: str = None,
        ethnicity: str = None,
        gaduate_time: str = None,
        highest_academic: str = None,
        highest_education: int = None,
        identify: str = None,
        industry: str = None,
        industry_code: str = None,
        job_title: str = None,
        last_school_name: str = None,
        married: int = None,
        mbti_type: int = None,
        name: str = None,
        nationality: str = None,
        native_place: str = None,
        native_place_code: str = None,
        now_location: str = None,
        now_location_code: str = None,
        parent_industry: str = None,
        parent_industry_code: str = None,
        personal_honor: str = None,
        personal_urls: List[str] = None,
        phone_num: str = None,
        political_status: int = None,
        qq: str = None,
        real_avatar: int = None,
        self_evaluation: str = None,
        sex: int = None,
        skill_summary: str = None,
        state_code: str = None,
        status: str = None,
        virtual_phone_num: str = None,
        we_chat: str = None,
        weibo: str = None,
        working_years: int = None,
    ):
        self.age = age
        self.avatar = avatar
        self.begin_work_time = begin_work_time
        self.birthday = birthday
        self.candidate_background = candidate_background
        self.ding_talk = ding_talk
        self.email = email
        self.english_name = english_name
        self.ethnicity = ethnicity
        self.gaduate_time = gaduate_time
        self.highest_academic = highest_academic
        self.highest_education = highest_education
        self.identify = identify
        self.industry = industry
        self.industry_code = industry_code
        self.job_title = job_title
        self.last_school_name = last_school_name
        self.married = married
        self.mbti_type = mbti_type
        self.name = name
        self.nationality = nationality
        self.native_place = native_place
        self.native_place_code = native_place_code
        self.now_location = now_location
        self.now_location_code = now_location_code
        self.parent_industry = parent_industry
        self.parent_industry_code = parent_industry_code
        self.personal_honor = personal_honor
        self.personal_urls = personal_urls
        self.phone_num = phone_num
        self.political_status = political_status
        self.qq = qq
        self.real_avatar = real_avatar
        self.self_evaluation = self_evaluation
        self.sex = sex
        self.skill_summary = skill_summary
        self.state_code = state_code
        self.status = status
        self.virtual_phone_num = virtual_phone_num
        self.we_chat = we_chat
        self.weibo = weibo
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
        if self.candidate_background is not None:
            result['candidateBackground'] = self.candidate_background
        if self.ding_talk is not None:
            result['dingTalk'] = self.ding_talk
        if self.email is not None:
            result['email'] = self.email
        if self.english_name is not None:
            result['englishName'] = self.english_name
        if self.ethnicity is not None:
            result['ethnicity'] = self.ethnicity
        if self.gaduate_time is not None:
            result['gaduateTime'] = self.gaduate_time
        if self.highest_academic is not None:
            result['highestAcademic'] = self.highest_academic
        if self.highest_education is not None:
            result['highestEducation'] = self.highest_education
        if self.identify is not None:
            result['identify'] = self.identify
        if self.industry is not None:
            result['industry'] = self.industry
        if self.industry_code is not None:
            result['industryCode'] = self.industry_code
        if self.job_title is not None:
            result['jobTitle'] = self.job_title
        if self.last_school_name is not None:
            result['lastSchoolName'] = self.last_school_name
        if self.married is not None:
            result['married'] = self.married
        if self.mbti_type is not None:
            result['mbtiType'] = self.mbti_type
        if self.name is not None:
            result['name'] = self.name
        if self.nationality is not None:
            result['nationality'] = self.nationality
        if self.native_place is not None:
            result['nativePlace'] = self.native_place
        if self.native_place_code is not None:
            result['nativePlaceCode'] = self.native_place_code
        if self.now_location is not None:
            result['nowLocation'] = self.now_location
        if self.now_location_code is not None:
            result['nowLocationCode'] = self.now_location_code
        if self.parent_industry is not None:
            result['parentIndustry'] = self.parent_industry
        if self.parent_industry_code is not None:
            result['parentIndustryCode'] = self.parent_industry_code
        if self.personal_honor is not None:
            result['personalHonor'] = self.personal_honor
        if self.personal_urls is not None:
            result['personalUrls'] = self.personal_urls
        if self.phone_num is not None:
            result['phoneNum'] = self.phone_num
        if self.political_status is not None:
            result['politicalStatus'] = self.political_status
        if self.qq is not None:
            result['qq'] = self.qq
        if self.real_avatar is not None:
            result['realAvatar'] = self.real_avatar
        if self.self_evaluation is not None:
            result['selfEvaluation'] = self.self_evaluation
        if self.sex is not None:
            result['sex'] = self.sex
        if self.skill_summary is not None:
            result['skillSummary'] = self.skill_summary
        if self.state_code is not None:
            result['stateCode'] = self.state_code
        if self.status is not None:
            result['status'] = self.status
        if self.virtual_phone_num is not None:
            result['virtualPhoneNum'] = self.virtual_phone_num
        if self.we_chat is not None:
            result['weChat'] = self.we_chat
        if self.weibo is not None:
            result['weibo'] = self.weibo
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
        if m.get('candidateBackground') is not None:
            self.candidate_background = m.get('candidateBackground')
        if m.get('dingTalk') is not None:
            self.ding_talk = m.get('dingTalk')
        if m.get('email') is not None:
            self.email = m.get('email')
        if m.get('englishName') is not None:
            self.english_name = m.get('englishName')
        if m.get('ethnicity') is not None:
            self.ethnicity = m.get('ethnicity')
        if m.get('gaduateTime') is not None:
            self.gaduate_time = m.get('gaduateTime')
        if m.get('highestAcademic') is not None:
            self.highest_academic = m.get('highestAcademic')
        if m.get('highestEducation') is not None:
            self.highest_education = m.get('highestEducation')
        if m.get('identify') is not None:
            self.identify = m.get('identify')
        if m.get('industry') is not None:
            self.industry = m.get('industry')
        if m.get('industryCode') is not None:
            self.industry_code = m.get('industryCode')
        if m.get('jobTitle') is not None:
            self.job_title = m.get('jobTitle')
        if m.get('lastSchoolName') is not None:
            self.last_school_name = m.get('lastSchoolName')
        if m.get('married') is not None:
            self.married = m.get('married')
        if m.get('mbtiType') is not None:
            self.mbti_type = m.get('mbtiType')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('nationality') is not None:
            self.nationality = m.get('nationality')
        if m.get('nativePlace') is not None:
            self.native_place = m.get('nativePlace')
        if m.get('nativePlaceCode') is not None:
            self.native_place_code = m.get('nativePlaceCode')
        if m.get('nowLocation') is not None:
            self.now_location = m.get('nowLocation')
        if m.get('nowLocationCode') is not None:
            self.now_location_code = m.get('nowLocationCode')
        if m.get('parentIndustry') is not None:
            self.parent_industry = m.get('parentIndustry')
        if m.get('parentIndustryCode') is not None:
            self.parent_industry_code = m.get('parentIndustryCode')
        if m.get('personalHonor') is not None:
            self.personal_honor = m.get('personalHonor')
        if m.get('personalUrls') is not None:
            self.personal_urls = m.get('personalUrls')
        if m.get('phoneNum') is not None:
            self.phone_num = m.get('phoneNum')
        if m.get('politicalStatus') is not None:
            self.political_status = m.get('politicalStatus')
        if m.get('qq') is not None:
            self.qq = m.get('qq')
        if m.get('realAvatar') is not None:
            self.real_avatar = m.get('realAvatar')
        if m.get('selfEvaluation') is not None:
            self.self_evaluation = m.get('selfEvaluation')
        if m.get('sex') is not None:
            self.sex = m.get('sex')
        if m.get('skillSummary') is not None:
            self.skill_summary = m.get('skillSummary')
        if m.get('stateCode') is not None:
            self.state_code = m.get('stateCode')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('virtualPhoneNum') is not None:
            self.virtual_phone_num = m.get('virtualPhoneNum')
        if m.get('weChat') is not None:
            self.we_chat = m.get('weChat')
        if m.get('weibo') is not None:
            self.weibo = m.get('weibo')
        if m.get('workingYears') is not None:
            self.working_years = m.get('workingYears')
        return self


class CreateResumeRequestResumeDataVOCertificates(TeaModel):
    def __init__(
        self,
        certificate_id: str = None,
        certificate_name: str = None,
        crant_time: str = None,
    ):
        self.certificate_id = certificate_id
        self.certificate_name = certificate_name
        self.crant_time = crant_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.certificate_id is not None:
            result['certificateId'] = self.certificate_id
        if self.certificate_name is not None:
            result['certificateName'] = self.certificate_name
        if self.crant_time is not None:
            result['crantTime'] = self.crant_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('certificateId') is not None:
            self.certificate_id = m.get('certificateId')
        if m.get('certificateName') is not None:
            self.certificate_name = m.get('certificateName')
        if m.get('crantTime') is not None:
            self.crant_time = m.get('crantTime')
        return self


class CreateResumeRequestResumeDataVOJobExpectsCityList(TeaModel):
    def __init__(
        self,
        code: str = None,
        name: str = None,
    ):
        self.code = code
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class CreateResumeRequestResumeDataVOJobExpectsIndustryList(TeaModel):
    def __init__(
        self,
        code: str = None,
        name: str = None,
    ):
        self.code = code
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class CreateResumeRequestResumeDataVOJobExpectsJobList(TeaModel):
    def __init__(
        self,
        code: str = None,
        name: str = None,
    ):
        self.code = code
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class CreateResumeRequestResumeDataVOJobExpectsOtherCityList(TeaModel):
    def __init__(
        self,
        code: str = None,
        name: str = None,
    ):
        self.code = code
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class CreateResumeRequestResumeDataVOJobExpects(TeaModel):
    def __init__(
        self,
        city_list: List[CreateResumeRequestResumeDataVOJobExpectsCityList] = None,
        gmt_create: int = None,
        gmt_modified: int = None,
        industry_list: List[CreateResumeRequestResumeDataVOJobExpectsIndustryList] = None,
        job_list: List[CreateResumeRequestResumeDataVOJobExpectsJobList] = None,
        job_nature: str = None,
        max_salary: str = None,
        min_salary: str = None,
        other_city_list: List[CreateResumeRequestResumeDataVOJobExpectsOtherCityList] = None,
        salary_desc: str = None,
        salary_settle_type: str = None,
        salary_type: str = None,
        salary_year: str = None,
    ):
        self.city_list = city_list
        self.gmt_create = gmt_create
        self.gmt_modified = gmt_modified
        self.industry_list = industry_list
        self.job_list = job_list
        self.job_nature = job_nature
        self.max_salary = max_salary
        self.min_salary = min_salary
        self.other_city_list = other_city_list
        self.salary_desc = salary_desc
        self.salary_settle_type = salary_settle_type
        self.salary_type = salary_type
        self.salary_year = salary_year

    def validate(self):
        if self.city_list:
            for k in self.city_list:
                if k:
                    k.validate()
        if self.industry_list:
            for k in self.industry_list:
                if k:
                    k.validate()
        if self.job_list:
            for k in self.job_list:
                if k:
                    k.validate()
        if self.other_city_list:
            for k in self.other_city_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['cityList'] = []
        if self.city_list is not None:
            for k in self.city_list:
                result['cityList'].append(k.to_map() if k else None)
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        result['industryList'] = []
        if self.industry_list is not None:
            for k in self.industry_list:
                result['industryList'].append(k.to_map() if k else None)
        result['jobList'] = []
        if self.job_list is not None:
            for k in self.job_list:
                result['jobList'].append(k.to_map() if k else None)
        if self.job_nature is not None:
            result['jobNature'] = self.job_nature
        if self.max_salary is not None:
            result['maxSalary'] = self.max_salary
        if self.min_salary is not None:
            result['minSalary'] = self.min_salary
        result['otherCityList'] = []
        if self.other_city_list is not None:
            for k in self.other_city_list:
                result['otherCityList'].append(k.to_map() if k else None)
        if self.salary_desc is not None:
            result['salaryDesc'] = self.salary_desc
        if self.salary_settle_type is not None:
            result['salarySettleType'] = self.salary_settle_type
        if self.salary_type is not None:
            result['salaryType'] = self.salary_type
        if self.salary_year is not None:
            result['salaryYear'] = self.salary_year
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.city_list = []
        if m.get('cityList') is not None:
            for k in m.get('cityList'):
                temp_model = CreateResumeRequestResumeDataVOJobExpectsCityList()
                self.city_list.append(temp_model.from_map(k))
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        self.industry_list = []
        if m.get('industryList') is not None:
            for k in m.get('industryList'):
                temp_model = CreateResumeRequestResumeDataVOJobExpectsIndustryList()
                self.industry_list.append(temp_model.from_map(k))
        self.job_list = []
        if m.get('jobList') is not None:
            for k in m.get('jobList'):
                temp_model = CreateResumeRequestResumeDataVOJobExpectsJobList()
                self.job_list.append(temp_model.from_map(k))
        if m.get('jobNature') is not None:
            self.job_nature = m.get('jobNature')
        if m.get('maxSalary') is not None:
            self.max_salary = m.get('maxSalary')
        if m.get('minSalary') is not None:
            self.min_salary = m.get('minSalary')
        self.other_city_list = []
        if m.get('otherCityList') is not None:
            for k in m.get('otherCityList'):
                temp_model = CreateResumeRequestResumeDataVOJobExpectsOtherCityList()
                self.other_city_list.append(temp_model.from_map(k))
        if m.get('salaryDesc') is not None:
            self.salary_desc = m.get('salaryDesc')
        if m.get('salarySettleType') is not None:
            self.salary_settle_type = m.get('salarySettleType')
        if m.get('salaryType') is not None:
            self.salary_type = m.get('salaryType')
        if m.get('salaryYear') is not None:
            self.salary_year = m.get('salaryYear')
        return self


class CreateResumeRequestResumeDataVOPersonalHonors(TeaModel):
    def __init__(
        self,
        description: str = None,
        grant_time: str = None,
    ):
        self.description = description
        self.grant_time = grant_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        if self.grant_time is not None:
            result['grantTime'] = self.grant_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('grantTime') is not None:
            self.grant_time = m.get('grantTime')
        return self


class CreateResumeRequestResumeDataVOProjectExperiences(TeaModel):
    def __init__(
        self,
        achievement: str = None,
        description: str = None,
        end_date: str = None,
        name: str = None,
        project_url: str = None,
        responsibility: str = None,
        start_date: str = None,
        technology: str = None,
        title: str = None,
    ):
        self.achievement = achievement
        self.description = description
        self.end_date = end_date
        self.name = name
        self.project_url = project_url
        self.responsibility = responsibility
        self.start_date = start_date
        self.technology = technology
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.achievement is not None:
            result['achievement'] = self.achievement
        if self.description is not None:
            result['description'] = self.description
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.name is not None:
            result['name'] = self.name
        if self.project_url is not None:
            result['projectUrl'] = self.project_url
        if self.responsibility is not None:
            result['responsibility'] = self.responsibility
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.technology is not None:
            result['technology'] = self.technology
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('achievement') is not None:
            self.achievement = m.get('achievement')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('projectUrl') is not None:
            self.project_url = m.get('projectUrl')
        if m.get('responsibility') is not None:
            self.responsibility = m.get('responsibility')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('technology') is not None:
            self.technology = m.get('technology')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class CreateResumeRequestResumeDataVOTags(TeaModel):
    def __init__(
        self,
        tag: str = None,
    ):
        self.tag = tag

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.tag is not None:
            result['tag'] = self.tag
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('tag') is not None:
            self.tag = m.get('tag')
        return self


class CreateResumeRequestResumeDataVOWorkExperiencesResumePrivacy(TeaModel):
    def __init__(
        self,
        shielded_company: bool = None,
        shielded_related_company: bool = None,
    ):
        self.shielded_company = shielded_company
        self.shielded_related_company = shielded_related_company

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.shielded_company is not None:
            result['shieldedCompany'] = self.shielded_company
        if self.shielded_related_company is not None:
            result['shieldedRelatedCompany'] = self.shielded_related_company
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('shieldedCompany') is not None:
            self.shielded_company = m.get('shieldedCompany')
        if m.get('shieldedRelatedCompany') is not None:
            self.shielded_related_company = m.get('shieldedRelatedCompany')
        return self


class CreateResumeRequestResumeDataVOWorkExperiences(TeaModel):
    def __init__(
        self,
        achievement: str = None,
        company_code: str = None,
        company_name: str = None,
        description: str = None,
        end_date: str = None,
        industry: str = None,
        industry_code: str = None,
        internship: bool = None,
        job_code: str = None,
        job_nature: str = None,
        job_title: str = None,
        leader: str = None,
        location: str = None,
        location_code: str = None,
        parent_industry: str = None,
        parent_industry_code: str = None,
        reason_of_leaving: str = None,
        responsibility: str = None,
        resume_privacy: CreateResumeRequestResumeDataVOWorkExperiencesResumePrivacy = None,
        salary: str = None,
        selected_skill_options: List[str] = None,
        start_date: str = None,
        underling_number: str = None,
    ):
        self.achievement = achievement
        self.company_code = company_code
        self.company_name = company_name
        self.description = description
        self.end_date = end_date
        self.industry = industry
        self.industry_code = industry_code
        self.internship = internship
        self.job_code = job_code
        self.job_nature = job_nature
        self.job_title = job_title
        self.leader = leader
        self.location = location
        self.location_code = location_code
        self.parent_industry = parent_industry
        self.parent_industry_code = parent_industry_code
        self.reason_of_leaving = reason_of_leaving
        self.responsibility = responsibility
        self.resume_privacy = resume_privacy
        self.salary = salary
        self.selected_skill_options = selected_skill_options
        self.start_date = start_date
        self.underling_number = underling_number

    def validate(self):
        if self.resume_privacy:
            self.resume_privacy.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.achievement is not None:
            result['achievement'] = self.achievement
        if self.company_code is not None:
            result['companyCode'] = self.company_code
        if self.company_name is not None:
            result['companyName'] = self.company_name
        if self.description is not None:
            result['description'] = self.description
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.industry is not None:
            result['industry'] = self.industry
        if self.industry_code is not None:
            result['industryCode'] = self.industry_code
        if self.internship is not None:
            result['internship'] = self.internship
        if self.job_code is not None:
            result['jobCode'] = self.job_code
        if self.job_nature is not None:
            result['jobNature'] = self.job_nature
        if self.job_title is not None:
            result['jobTitle'] = self.job_title
        if self.leader is not None:
            result['leader'] = self.leader
        if self.location is not None:
            result['location'] = self.location
        if self.location_code is not None:
            result['locationCode'] = self.location_code
        if self.parent_industry is not None:
            result['parentIndustry'] = self.parent_industry
        if self.parent_industry_code is not None:
            result['parentIndustryCode'] = self.parent_industry_code
        if self.reason_of_leaving is not None:
            result['reasonOfLeaving'] = self.reason_of_leaving
        if self.responsibility is not None:
            result['responsibility'] = self.responsibility
        if self.resume_privacy is not None:
            result['resumePrivacy'] = self.resume_privacy.to_map()
        if self.salary is not None:
            result['salary'] = self.salary
        if self.selected_skill_options is not None:
            result['selectedSkillOptions'] = self.selected_skill_options
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.underling_number is not None:
            result['underlingNumber'] = self.underling_number
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('achievement') is not None:
            self.achievement = m.get('achievement')
        if m.get('companyCode') is not None:
            self.company_code = m.get('companyCode')
        if m.get('companyName') is not None:
            self.company_name = m.get('companyName')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('industry') is not None:
            self.industry = m.get('industry')
        if m.get('industryCode') is not None:
            self.industry_code = m.get('industryCode')
        if m.get('internship') is not None:
            self.internship = m.get('internship')
        if m.get('jobCode') is not None:
            self.job_code = m.get('jobCode')
        if m.get('jobNature') is not None:
            self.job_nature = m.get('jobNature')
        if m.get('jobTitle') is not None:
            self.job_title = m.get('jobTitle')
        if m.get('leader') is not None:
            self.leader = m.get('leader')
        if m.get('location') is not None:
            self.location = m.get('location')
        if m.get('locationCode') is not None:
            self.location_code = m.get('locationCode')
        if m.get('parentIndustry') is not None:
            self.parent_industry = m.get('parentIndustry')
        if m.get('parentIndustryCode') is not None:
            self.parent_industry_code = m.get('parentIndustryCode')
        if m.get('reasonOfLeaving') is not None:
            self.reason_of_leaving = m.get('reasonOfLeaving')
        if m.get('responsibility') is not None:
            self.responsibility = m.get('responsibility')
        if m.get('resumePrivacy') is not None:
            temp_model = CreateResumeRequestResumeDataVOWorkExperiencesResumePrivacy()
            self.resume_privacy = temp_model.from_map(m['resumePrivacy'])
        if m.get('salary') is not None:
            self.salary = m.get('salary')
        if m.get('selectedSkillOptions') is not None:
            self.selected_skill_options = m.get('selectedSkillOptions')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('underlingNumber') is not None:
            self.underling_number = m.get('underlingNumber')
        return self


class CreateResumeRequestResumeDataVO(TeaModel):
    def __init__(
        self,
        base_info: CreateResumeRequestResumeDataVOBaseInfo = None,
        certificates: List[CreateResumeRequestResumeDataVOCertificates] = None,
        job_expects: List[CreateResumeRequestResumeDataVOJobExpects] = None,
        personal_honors: List[CreateResumeRequestResumeDataVOPersonalHonors] = None,
        project_experiences: List[CreateResumeRequestResumeDataVOProjectExperiences] = None,
        tags: List[CreateResumeRequestResumeDataVOTags] = None,
        work_experiences: List[CreateResumeRequestResumeDataVOWorkExperiences] = None,
    ):
        self.base_info = base_info
        self.certificates = certificates
        self.job_expects = job_expects
        self.personal_honors = personal_honors
        self.project_experiences = project_experiences
        self.tags = tags
        self.work_experiences = work_experiences

    def validate(self):
        if self.base_info:
            self.base_info.validate()
        if self.certificates:
            for k in self.certificates:
                if k:
                    k.validate()
        if self.job_expects:
            for k in self.job_expects:
                if k:
                    k.validate()
        if self.personal_honors:
            for k in self.personal_honors:
                if k:
                    k.validate()
        if self.project_experiences:
            for k in self.project_experiences:
                if k:
                    k.validate()
        if self.tags:
            for k in self.tags:
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
        result['jobExpects'] = []
        if self.job_expects is not None:
            for k in self.job_expects:
                result['jobExpects'].append(k.to_map() if k else None)
        result['personalHonors'] = []
        if self.personal_honors is not None:
            for k in self.personal_honors:
                result['personalHonors'].append(k.to_map() if k else None)
        result['projectExperiences'] = []
        if self.project_experiences is not None:
            for k in self.project_experiences:
                result['projectExperiences'].append(k.to_map() if k else None)
        result['tags'] = []
        if self.tags is not None:
            for k in self.tags:
                result['tags'].append(k.to_map() if k else None)
        result['workExperiences'] = []
        if self.work_experiences is not None:
            for k in self.work_experiences:
                result['workExperiences'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('baseInfo') is not None:
            temp_model = CreateResumeRequestResumeDataVOBaseInfo()
            self.base_info = temp_model.from_map(m['baseInfo'])
        self.certificates = []
        if m.get('certificates') is not None:
            for k in m.get('certificates'):
                temp_model = CreateResumeRequestResumeDataVOCertificates()
                self.certificates.append(temp_model.from_map(k))
        self.job_expects = []
        if m.get('jobExpects') is not None:
            for k in m.get('jobExpects'):
                temp_model = CreateResumeRequestResumeDataVOJobExpects()
                self.job_expects.append(temp_model.from_map(k))
        self.personal_honors = []
        if m.get('personalHonors') is not None:
            for k in m.get('personalHonors'):
                temp_model = CreateResumeRequestResumeDataVOPersonalHonors()
                self.personal_honors.append(temp_model.from_map(k))
        self.project_experiences = []
        if m.get('projectExperiences') is not None:
            for k in m.get('projectExperiences'):
                temp_model = CreateResumeRequestResumeDataVOProjectExperiences()
                self.project_experiences.append(temp_model.from_map(k))
        self.tags = []
        if m.get('tags') is not None:
            for k in m.get('tags'):
                temp_model = CreateResumeRequestResumeDataVOTags()
                self.tags.append(temp_model.from_map(k))
        self.work_experiences = []
        if m.get('workExperiences') is not None:
            for k in m.get('workExperiences'):
                temp_model = CreateResumeRequestResumeDataVOWorkExperiences()
                self.work_experiences.append(temp_model.from_map(k))
        return self


class CreateResumeRequest(TeaModel):
    def __init__(
        self,
        biz_code: str = None,
        ext: str = None,
        resume_data_vo: CreateResumeRequestResumeDataVO = None,
        scene: str = None,
        types: List[str] = None,
        user_identify: str = None,
    ):
        self.biz_code = biz_code
        self.ext = ext
        self.resume_data_vo = resume_data_vo
        self.scene = scene
        self.types = types
        self.user_identify = user_identify

    def validate(self):
        if self.resume_data_vo:
            self.resume_data_vo.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        if self.ext is not None:
            result['ext'] = self.ext
        if self.resume_data_vo is not None:
            result['resumeDataVO'] = self.resume_data_vo.to_map()
        if self.scene is not None:
            result['scene'] = self.scene
        if self.types is not None:
            result['types'] = self.types
        if self.user_identify is not None:
            result['userIdentify'] = self.user_identify
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        if m.get('resumeDataVO') is not None:
            temp_model = CreateResumeRequestResumeDataVO()
            self.resume_data_vo = temp_model.from_map(m['resumeDataVO'])
        if m.get('scene') is not None:
            self.scene = m.get('scene')
        if m.get('types') is not None:
            self.types = m.get('types')
        if m.get('userIdentify') is not None:
            self.user_identify = m.get('userIdentify')
        return self


class CreateResumeResponseBodyResult(TeaModel):
    def __init__(
        self,
        resume_id: str = None,
    ):
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


class CreateResumeResponseBody(TeaModel):
    def __init__(
        self,
        result: CreateResumeResponseBodyResult = None,
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
            temp_model = CreateResumeResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CreateResumeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateResumeResponseBody = None,
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
            temp_model = CreateResumeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PostResumeHeaders(TeaModel):
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


class PostResumeRequest(TeaModel):
    def __init__(
        self,
        job_id: int = None,
        user_identify: str = None,
    ):
        self.job_id = job_id
        self.user_identify = user_identify

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.job_id is not None:
            result['jobId'] = self.job_id
        if self.user_identify is not None:
            result['userIdentify'] = self.user_identify
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('jobId') is not None:
            self.job_id = m.get('jobId')
        if m.get('userIdentify') is not None:
            self.user_identify = m.get('userIdentify')
        return self


class PostResumeResponseBody(TeaModel):
    def __init__(
        self,
        job_id: int = None,
        user_identify: str = None,
    ):
        self.job_id = job_id
        self.user_identify = user_identify

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.job_id is not None:
            result['jobId'] = self.job_id
        if self.user_identify is not None:
            result['userIdentify'] = self.user_identify
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('jobId') is not None:
            self.job_id = m.get('jobId')
        if m.get('userIdentify') is not None:
            self.user_identify = m.get('userIdentify')
        return self


class PostResumeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PostResumeResponseBody = None,
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
            temp_model = PostResumeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


