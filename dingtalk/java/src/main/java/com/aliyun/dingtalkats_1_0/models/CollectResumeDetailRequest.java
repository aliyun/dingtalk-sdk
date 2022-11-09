// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class CollectResumeDetailRequest extends TeaModel {
    // 业务标识，目前固定为ddats
    @NameInMap("bizCode")
    public String bizCode;

    // 渠道侧简历标识
    @NameInMap("channelOuterId")
    public String channelOuterId;

    // 简历投递职位标识
    @NameInMap("deliverJobId")
    public String deliverJobId;

    @NameInMap("optUserId")
    public String optUserId;

    // 简历详情信息
    @NameInMap("resumeData")
    public CollectResumeDetailRequestResumeData resumeData;

    public static CollectResumeDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        CollectResumeDetailRequest self = new CollectResumeDetailRequest();
        return TeaModel.build(map, self);
    }

    public CollectResumeDetailRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public CollectResumeDetailRequest setChannelOuterId(String channelOuterId) {
        this.channelOuterId = channelOuterId;
        return this;
    }
    public String getChannelOuterId() {
        return this.channelOuterId;
    }

    public CollectResumeDetailRequest setDeliverJobId(String deliverJobId) {
        this.deliverJobId = deliverJobId;
        return this;
    }
    public String getDeliverJobId() {
        return this.deliverJobId;
    }

    public CollectResumeDetailRequest setOptUserId(String optUserId) {
        this.optUserId = optUserId;
        return this;
    }
    public String getOptUserId() {
        return this.optUserId;
    }

    public CollectResumeDetailRequest setResumeData(CollectResumeDetailRequestResumeData resumeData) {
        this.resumeData = resumeData;
        return this;
    }
    public CollectResumeDetailRequestResumeData getResumeData() {
        return this.resumeData;
    }

    public static class CollectResumeDetailRequestResumeDataBaseInfo extends TeaModel {
        // 年龄
        @NameInMap("age")
        public Integer age;

        // 头像cdn地址，http链接
        @NameInMap("avatar")
        public String avatar;

        // 初次工作时间
        @NameInMap("beginWorkTime")
        public String beginWorkTime;

        // 生日
        @NameInMap("birthday")
        public String birthday;

        // 邮箱地址
        @NameInMap("email")
        public String email;

        // 英文名称
        @NameInMap("englishName")
        public String englishName;

        // 毕业时间
        @NameInMap("graduateTime")
        public String graduateTime;

        // 最高学历
        @NameInMap("highestEducation")
        public Integer highestEducation;

        // 当前工作职位名称
        @NameInMap("jobTitle")
        public String jobTitle;

        // 最高学历毕业院校名称
        @NameInMap("lastSchoolName")
        public String lastSchoolName;

        // 婚姻状况
        @NameInMap("married")
        public Integer married;

        // 名称
        @NameInMap("name")
        public String name;

        // 籍贯地址
        @NameInMap("nativePlace")
        public String nativePlace;

        // 现居住地址
        @NameInMap("nowLocation")
        public String nowLocation;

        // 个人荣誉
        @NameInMap("personalHonor")
        public String personalHonor;

        // 手机号
        @NameInMap("phoneNum")
        public String phoneNum;

        // 政治面貌
        @NameInMap("politicalStatus")
        public Integer politicalStatus;

        // 自我评价
        @NameInMap("selfEvaluation")
        public String selfEvaluation;

        // 性别
        @NameInMap("sex")
        public Integer sex;

        // 虚拟手机号
        @NameInMap("virtualPhoneNum")
        public String virtualPhoneNum;

        // 工作年限
        @NameInMap("workingYears")
        public Integer workingYears;

        public static CollectResumeDetailRequestResumeDataBaseInfo build(java.util.Map<String, ?> map) throws Exception {
            CollectResumeDetailRequestResumeDataBaseInfo self = new CollectResumeDetailRequestResumeDataBaseInfo();
            return TeaModel.build(map, self);
        }

        public CollectResumeDetailRequestResumeDataBaseInfo setAge(Integer age) {
            this.age = age;
            return this;
        }
        public Integer getAge() {
            return this.age;
        }

        public CollectResumeDetailRequestResumeDataBaseInfo setAvatar(String avatar) {
            this.avatar = avatar;
            return this;
        }
        public String getAvatar() {
            return this.avatar;
        }

        public CollectResumeDetailRequestResumeDataBaseInfo setBeginWorkTime(String beginWorkTime) {
            this.beginWorkTime = beginWorkTime;
            return this;
        }
        public String getBeginWorkTime() {
            return this.beginWorkTime;
        }

        public CollectResumeDetailRequestResumeDataBaseInfo setBirthday(String birthday) {
            this.birthday = birthday;
            return this;
        }
        public String getBirthday() {
            return this.birthday;
        }

        public CollectResumeDetailRequestResumeDataBaseInfo setEmail(String email) {
            this.email = email;
            return this;
        }
        public String getEmail() {
            return this.email;
        }

        public CollectResumeDetailRequestResumeDataBaseInfo setEnglishName(String englishName) {
            this.englishName = englishName;
            return this;
        }
        public String getEnglishName() {
            return this.englishName;
        }

        public CollectResumeDetailRequestResumeDataBaseInfo setGraduateTime(String graduateTime) {
            this.graduateTime = graduateTime;
            return this;
        }
        public String getGraduateTime() {
            return this.graduateTime;
        }

        public CollectResumeDetailRequestResumeDataBaseInfo setHighestEducation(Integer highestEducation) {
            this.highestEducation = highestEducation;
            return this;
        }
        public Integer getHighestEducation() {
            return this.highestEducation;
        }

        public CollectResumeDetailRequestResumeDataBaseInfo setJobTitle(String jobTitle) {
            this.jobTitle = jobTitle;
            return this;
        }
        public String getJobTitle() {
            return this.jobTitle;
        }

        public CollectResumeDetailRequestResumeDataBaseInfo setLastSchoolName(String lastSchoolName) {
            this.lastSchoolName = lastSchoolName;
            return this;
        }
        public String getLastSchoolName() {
            return this.lastSchoolName;
        }

        public CollectResumeDetailRequestResumeDataBaseInfo setMarried(Integer married) {
            this.married = married;
            return this;
        }
        public Integer getMarried() {
            return this.married;
        }

        public CollectResumeDetailRequestResumeDataBaseInfo setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CollectResumeDetailRequestResumeDataBaseInfo setNativePlace(String nativePlace) {
            this.nativePlace = nativePlace;
            return this;
        }
        public String getNativePlace() {
            return this.nativePlace;
        }

        public CollectResumeDetailRequestResumeDataBaseInfo setNowLocation(String nowLocation) {
            this.nowLocation = nowLocation;
            return this;
        }
        public String getNowLocation() {
            return this.nowLocation;
        }

        public CollectResumeDetailRequestResumeDataBaseInfo setPersonalHonor(String personalHonor) {
            this.personalHonor = personalHonor;
            return this;
        }
        public String getPersonalHonor() {
            return this.personalHonor;
        }

        public CollectResumeDetailRequestResumeDataBaseInfo setPhoneNum(String phoneNum) {
            this.phoneNum = phoneNum;
            return this;
        }
        public String getPhoneNum() {
            return this.phoneNum;
        }

        public CollectResumeDetailRequestResumeDataBaseInfo setPoliticalStatus(Integer politicalStatus) {
            this.politicalStatus = politicalStatus;
            return this;
        }
        public Integer getPoliticalStatus() {
            return this.politicalStatus;
        }

        public CollectResumeDetailRequestResumeDataBaseInfo setSelfEvaluation(String selfEvaluation) {
            this.selfEvaluation = selfEvaluation;
            return this;
        }
        public String getSelfEvaluation() {
            return this.selfEvaluation;
        }

        public CollectResumeDetailRequestResumeDataBaseInfo setSex(Integer sex) {
            this.sex = sex;
            return this;
        }
        public Integer getSex() {
            return this.sex;
        }

        public CollectResumeDetailRequestResumeDataBaseInfo setVirtualPhoneNum(String virtualPhoneNum) {
            this.virtualPhoneNum = virtualPhoneNum;
            return this;
        }
        public String getVirtualPhoneNum() {
            return this.virtualPhoneNum;
        }

        public CollectResumeDetailRequestResumeDataBaseInfo setWorkingYears(Integer workingYears) {
            this.workingYears = workingYears;
            return this;
        }
        public Integer getWorkingYears() {
            return this.workingYears;
        }

    }

    public static class CollectResumeDetailRequestResumeDataCertificates extends TeaModel {
        // 证书名称
        @NameInMap("certificateName")
        public String certificateName;

        // 证书授予时间
        @NameInMap("grantTime")
        public String grantTime;

        public static CollectResumeDetailRequestResumeDataCertificates build(java.util.Map<String, ?> map) throws Exception {
            CollectResumeDetailRequestResumeDataCertificates self = new CollectResumeDetailRequestResumeDataCertificates();
            return TeaModel.build(map, self);
        }

        public CollectResumeDetailRequestResumeDataCertificates setCertificateName(String certificateName) {
            this.certificateName = certificateName;
            return this;
        }
        public String getCertificateName() {
            return this.certificateName;
        }

        public CollectResumeDetailRequestResumeDataCertificates setGrantTime(String grantTime) {
            this.grantTime = grantTime;
            return this;
        }
        public String getGrantTime() {
            return this.grantTime;
        }

    }

    public static class CollectResumeDetailRequestResumeDataEducationExperiences extends TeaModel {
        // 学历
        @NameInMap("degree")
        public Integer degree;

        // 院系
        @NameInMap("department")
        public String department;

        // 详细描述
        @NameInMap("description")
        public String description;

        // 结束时间
        @NameInMap("endDate")
        public String endDate;

        // 专业
        @NameInMap("major")
        public String major;

        // 学校名称
        @NameInMap("schoolName")
        public String schoolName;

        // 开始时间
        @NameInMap("startDate")
        public String startDate;

        public static CollectResumeDetailRequestResumeDataEducationExperiences build(java.util.Map<String, ?> map) throws Exception {
            CollectResumeDetailRequestResumeDataEducationExperiences self = new CollectResumeDetailRequestResumeDataEducationExperiences();
            return TeaModel.build(map, self);
        }

        public CollectResumeDetailRequestResumeDataEducationExperiences setDegree(Integer degree) {
            this.degree = degree;
            return this;
        }
        public Integer getDegree() {
            return this.degree;
        }

        public CollectResumeDetailRequestResumeDataEducationExperiences setDepartment(String department) {
            this.department = department;
            return this;
        }
        public String getDepartment() {
            return this.department;
        }

        public CollectResumeDetailRequestResumeDataEducationExperiences setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public CollectResumeDetailRequestResumeDataEducationExperiences setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
        }

        public CollectResumeDetailRequestResumeDataEducationExperiences setMajor(String major) {
            this.major = major;
            return this;
        }
        public String getMajor() {
            return this.major;
        }

        public CollectResumeDetailRequestResumeDataEducationExperiences setSchoolName(String schoolName) {
            this.schoolName = schoolName;
            return this;
        }
        public String getSchoolName() {
            return this.schoolName;
        }

        public CollectResumeDetailRequestResumeDataEducationExperiences setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

    }

    public static class CollectResumeDetailRequestResumeDataJobExpect extends TeaModel {
        // 期望职位名称
        @NameInMap("jobName")
        public String jobName;

        // 期望工作地
        @NameInMap("locations")
        public java.util.List<String> locations;

        // 最高期望工资
        @NameInMap("maxSalary")
        public String maxSalary;

        // 最低期望工资
        @NameInMap("minSalary")
        public String minSalary;

        // 期望入职时间
        @NameInMap("onboardTime")
        public String onboardTime;

        public static CollectResumeDetailRequestResumeDataJobExpect build(java.util.Map<String, ?> map) throws Exception {
            CollectResumeDetailRequestResumeDataJobExpect self = new CollectResumeDetailRequestResumeDataJobExpect();
            return TeaModel.build(map, self);
        }

        public CollectResumeDetailRequestResumeDataJobExpect setJobName(String jobName) {
            this.jobName = jobName;
            return this;
        }
        public String getJobName() {
            return this.jobName;
        }

        public CollectResumeDetailRequestResumeDataJobExpect setLocations(java.util.List<String> locations) {
            this.locations = locations;
            return this;
        }
        public java.util.List<String> getLocations() {
            return this.locations;
        }

        public CollectResumeDetailRequestResumeDataJobExpect setMaxSalary(String maxSalary) {
            this.maxSalary = maxSalary;
            return this;
        }
        public String getMaxSalary() {
            return this.maxSalary;
        }

        public CollectResumeDetailRequestResumeDataJobExpect setMinSalary(String minSalary) {
            this.minSalary = minSalary;
            return this;
        }
        public String getMinSalary() {
            return this.minSalary;
        }

        public CollectResumeDetailRequestResumeDataJobExpect setOnboardTime(String onboardTime) {
            this.onboardTime = onboardTime;
            return this;
        }
        public String getOnboardTime() {
            return this.onboardTime;
        }

    }

    public static class CollectResumeDetailRequestResumeDataLanguageSkill extends TeaModel {
        // 证书名称
        @NameInMap("certificateName")
        public String certificateName;

        // 语言名称
        @NameInMap("languageName")
        public String languageName;

        public static CollectResumeDetailRequestResumeDataLanguageSkill build(java.util.Map<String, ?> map) throws Exception {
            CollectResumeDetailRequestResumeDataLanguageSkill self = new CollectResumeDetailRequestResumeDataLanguageSkill();
            return TeaModel.build(map, self);
        }

        public CollectResumeDetailRequestResumeDataLanguageSkill setCertificateName(String certificateName) {
            this.certificateName = certificateName;
            return this;
        }
        public String getCertificateName() {
            return this.certificateName;
        }

        public CollectResumeDetailRequestResumeDataLanguageSkill setLanguageName(String languageName) {
            this.languageName = languageName;
            return this;
        }
        public String getLanguageName() {
            return this.languageName;
        }

    }

    public static class CollectResumeDetailRequestResumeDataTrainingExperiences extends TeaModel {
        // 详细内容描述
        @NameInMap("description")
        public String description;

        // 结束时间
        @NameInMap("endDate")
        public String endDate;

        // 培训机构名称
        @NameInMap("institutionName")
        public String institutionName;

        // 培训地点
        @NameInMap("location")
        public String location;

        // 培训名称
        @NameInMap("name")
        public String name;

        // 开始时间
        @NameInMap("startDate")
        public String startDate;

        public static CollectResumeDetailRequestResumeDataTrainingExperiences build(java.util.Map<String, ?> map) throws Exception {
            CollectResumeDetailRequestResumeDataTrainingExperiences self = new CollectResumeDetailRequestResumeDataTrainingExperiences();
            return TeaModel.build(map, self);
        }

        public CollectResumeDetailRequestResumeDataTrainingExperiences setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public CollectResumeDetailRequestResumeDataTrainingExperiences setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
        }

        public CollectResumeDetailRequestResumeDataTrainingExperiences setInstitutionName(String institutionName) {
            this.institutionName = institutionName;
            return this;
        }
        public String getInstitutionName() {
            return this.institutionName;
        }

        public CollectResumeDetailRequestResumeDataTrainingExperiences setLocation(String location) {
            this.location = location;
            return this;
        }
        public String getLocation() {
            return this.location;
        }

        public CollectResumeDetailRequestResumeDataTrainingExperiences setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CollectResumeDetailRequestResumeDataTrainingExperiences setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

    }

    public static class CollectResumeDetailRequestResumeDataWorkExperiences extends TeaModel {
        // 公司名称
        @NameInMap("companyName")
        public String companyName;

        // 部门
        @NameInMap("department")
        public String department;

        // 工作详情描述
        @NameInMap("description")
        public String description;

        // 职位名称
        @NameInMap("jobTitle")
        public String jobTitle;

        // 工作地点
        @NameInMap("location")
        public String location;

        // 工作职责
        @NameInMap("responsibility")
        public String responsibility;

        public static CollectResumeDetailRequestResumeDataWorkExperiences build(java.util.Map<String, ?> map) throws Exception {
            CollectResumeDetailRequestResumeDataWorkExperiences self = new CollectResumeDetailRequestResumeDataWorkExperiences();
            return TeaModel.build(map, self);
        }

        public CollectResumeDetailRequestResumeDataWorkExperiences setCompanyName(String companyName) {
            this.companyName = companyName;
            return this;
        }
        public String getCompanyName() {
            return this.companyName;
        }

        public CollectResumeDetailRequestResumeDataWorkExperiences setDepartment(String department) {
            this.department = department;
            return this;
        }
        public String getDepartment() {
            return this.department;
        }

        public CollectResumeDetailRequestResumeDataWorkExperiences setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public CollectResumeDetailRequestResumeDataWorkExperiences setJobTitle(String jobTitle) {
            this.jobTitle = jobTitle;
            return this;
        }
        public String getJobTitle() {
            return this.jobTitle;
        }

        public CollectResumeDetailRequestResumeDataWorkExperiences setLocation(String location) {
            this.location = location;
            return this;
        }
        public String getLocation() {
            return this.location;
        }

        public CollectResumeDetailRequestResumeDataWorkExperiences setResponsibility(String responsibility) {
            this.responsibility = responsibility;
            return this;
        }
        public String getResponsibility() {
            return this.responsibility;
        }

    }

    public static class CollectResumeDetailRequestResumeData extends TeaModel {
        // 简历基础信息
        @NameInMap("baseInfo")
        public CollectResumeDetailRequestResumeDataBaseInfo baseInfo;

        // 证书信息
        @NameInMap("certificates")
        public java.util.List<CollectResumeDetailRequestResumeDataCertificates> certificates;

        // 教育经历
        @NameInMap("educationExperiences")
        public java.util.List<CollectResumeDetailRequestResumeDataEducationExperiences> educationExperiences;

        // 期望职位信息
        @NameInMap("jobExpect")
        public CollectResumeDetailRequestResumeDataJobExpect jobExpect;

        // 语言能力
        @NameInMap("languageSkill")
        public java.util.List<CollectResumeDetailRequestResumeDataLanguageSkill> languageSkill;

        // 培训经历
        @NameInMap("trainingExperiences")
        public java.util.List<CollectResumeDetailRequestResumeDataTrainingExperiences> trainingExperiences;

        // 工作经历
        @NameInMap("workExperiences")
        public java.util.List<CollectResumeDetailRequestResumeDataWorkExperiences> workExperiences;

        public static CollectResumeDetailRequestResumeData build(java.util.Map<String, ?> map) throws Exception {
            CollectResumeDetailRequestResumeData self = new CollectResumeDetailRequestResumeData();
            return TeaModel.build(map, self);
        }

        public CollectResumeDetailRequestResumeData setBaseInfo(CollectResumeDetailRequestResumeDataBaseInfo baseInfo) {
            this.baseInfo = baseInfo;
            return this;
        }
        public CollectResumeDetailRequestResumeDataBaseInfo getBaseInfo() {
            return this.baseInfo;
        }

        public CollectResumeDetailRequestResumeData setCertificates(java.util.List<CollectResumeDetailRequestResumeDataCertificates> certificates) {
            this.certificates = certificates;
            return this;
        }
        public java.util.List<CollectResumeDetailRequestResumeDataCertificates> getCertificates() {
            return this.certificates;
        }

        public CollectResumeDetailRequestResumeData setEducationExperiences(java.util.List<CollectResumeDetailRequestResumeDataEducationExperiences> educationExperiences) {
            this.educationExperiences = educationExperiences;
            return this;
        }
        public java.util.List<CollectResumeDetailRequestResumeDataEducationExperiences> getEducationExperiences() {
            return this.educationExperiences;
        }

        public CollectResumeDetailRequestResumeData setJobExpect(CollectResumeDetailRequestResumeDataJobExpect jobExpect) {
            this.jobExpect = jobExpect;
            return this;
        }
        public CollectResumeDetailRequestResumeDataJobExpect getJobExpect() {
            return this.jobExpect;
        }

        public CollectResumeDetailRequestResumeData setLanguageSkill(java.util.List<CollectResumeDetailRequestResumeDataLanguageSkill> languageSkill) {
            this.languageSkill = languageSkill;
            return this;
        }
        public java.util.List<CollectResumeDetailRequestResumeDataLanguageSkill> getLanguageSkill() {
            return this.languageSkill;
        }

        public CollectResumeDetailRequestResumeData setTrainingExperiences(java.util.List<CollectResumeDetailRequestResumeDataTrainingExperiences> trainingExperiences) {
            this.trainingExperiences = trainingExperiences;
            return this;
        }
        public java.util.List<CollectResumeDetailRequestResumeDataTrainingExperiences> getTrainingExperiences() {
            return this.trainingExperiences;
        }

        public CollectResumeDetailRequestResumeData setWorkExperiences(java.util.List<CollectResumeDetailRequestResumeDataWorkExperiences> workExperiences) {
            this.workExperiences = workExperiences;
            return this;
        }
        public java.util.List<CollectResumeDetailRequestResumeDataWorkExperiences> getWorkExperiences() {
            return this.workExperiences;
        }

    }

}
