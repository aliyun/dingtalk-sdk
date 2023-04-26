// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class CollectResumeDetailRequest extends TeaModel {
    @NameInMap("bizCode")
    public String bizCode;

    @NameInMap("channelCode")
    public String channelCode;

    @NameInMap("channelOuterId")
    public String channelOuterId;

    @NameInMap("channelTalentId")
    public String channelTalentId;

    @NameInMap("deliverJobId")
    public String deliverJobId;

    @NameInMap("optUserId")
    public String optUserId;

    @NameInMap("resumeChannelUrl")
    public String resumeChannelUrl;

    @NameInMap("resumeData")
    public CollectResumeDetailRequestResumeData resumeData;

    @NameInMap("resumeFile")
    public CollectResumeDetailRequestResumeFile resumeFile;

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

    public CollectResumeDetailRequest setChannelCode(String channelCode) {
        this.channelCode = channelCode;
        return this;
    }
    public String getChannelCode() {
        return this.channelCode;
    }

    public CollectResumeDetailRequest setChannelOuterId(String channelOuterId) {
        this.channelOuterId = channelOuterId;
        return this;
    }
    public String getChannelOuterId() {
        return this.channelOuterId;
    }

    public CollectResumeDetailRequest setChannelTalentId(String channelTalentId) {
        this.channelTalentId = channelTalentId;
        return this;
    }
    public String getChannelTalentId() {
        return this.channelTalentId;
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

    public CollectResumeDetailRequest setResumeChannelUrl(String resumeChannelUrl) {
        this.resumeChannelUrl = resumeChannelUrl;
        return this;
    }
    public String getResumeChannelUrl() {
        return this.resumeChannelUrl;
    }

    public CollectResumeDetailRequest setResumeData(CollectResumeDetailRequestResumeData resumeData) {
        this.resumeData = resumeData;
        return this;
    }
    public CollectResumeDetailRequestResumeData getResumeData() {
        return this.resumeData;
    }

    public CollectResumeDetailRequest setResumeFile(CollectResumeDetailRequestResumeFile resumeFile) {
        this.resumeFile = resumeFile;
        return this;
    }
    public CollectResumeDetailRequestResumeFile getResumeFile() {
        return this.resumeFile;
    }

    public static class CollectResumeDetailRequestResumeDataBaseInfo extends TeaModel {
        @NameInMap("age")
        public Integer age;

        @NameInMap("avatar")
        public String avatar;

        @NameInMap("beginWorkTime")
        public String beginWorkTime;

        @NameInMap("birthday")
        public String birthday;

        @NameInMap("email")
        public String email;

        @NameInMap("englishName")
        public String englishName;

        @NameInMap("graduateTime")
        public String graduateTime;

        @NameInMap("highestEducation")
        public Integer highestEducation;

        @NameInMap("jobTitle")
        public String jobTitle;

        @NameInMap("lastSchoolName")
        public String lastSchoolName;

        @NameInMap("married")
        public Integer married;

        @NameInMap("name")
        public String name;

        @NameInMap("nativePlace")
        public String nativePlace;

        @NameInMap("nowLocation")
        public String nowLocation;

        @NameInMap("personalHonor")
        public String personalHonor;

        @NameInMap("phoneNum")
        public String phoneNum;

        @NameInMap("politicalStatus")
        public Integer politicalStatus;

        @NameInMap("selfEvaluation")
        public String selfEvaluation;

        @NameInMap("sex")
        public Integer sex;

        @NameInMap("virtualPhoneNum")
        public String virtualPhoneNum;

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
        @NameInMap("certificateName")
        public String certificateName;

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
        @NameInMap("degree")
        public Integer degree;

        @NameInMap("department")
        public String department;

        @NameInMap("description")
        public String description;

        @NameInMap("endDate")
        public String endDate;

        @NameInMap("major")
        public String major;

        @NameInMap("schoolName")
        public String schoolName;

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
        @NameInMap("jobName")
        public String jobName;

        @NameInMap("locations")
        public java.util.List<String> locations;

        @NameInMap("maxSalary")
        public String maxSalary;

        @NameInMap("minSalary")
        public String minSalary;

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
        @NameInMap("certificateName")
        public String certificateName;

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
        @NameInMap("description")
        public String description;

        @NameInMap("endDate")
        public String endDate;

        @NameInMap("institutionName")
        public String institutionName;

        @NameInMap("location")
        public String location;

        @NameInMap("name")
        public String name;

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
        @NameInMap("companyName")
        public String companyName;

        @NameInMap("department")
        public String department;

        @NameInMap("description")
        public String description;

        @NameInMap("endDate")
        public String endDate;

        @NameInMap("jobTitle")
        public String jobTitle;

        @NameInMap("location")
        public String location;

        @NameInMap("responsibility")
        public String responsibility;

        @NameInMap("startDate")
        public String startDate;

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

        public CollectResumeDetailRequestResumeDataWorkExperiences setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
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

        public CollectResumeDetailRequestResumeDataWorkExperiences setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

    }

    public static class CollectResumeDetailRequestResumeData extends TeaModel {
        @NameInMap("baseInfo")
        public CollectResumeDetailRequestResumeDataBaseInfo baseInfo;

        @NameInMap("certificates")
        public java.util.List<CollectResumeDetailRequestResumeDataCertificates> certificates;

        @NameInMap("educationExperiences")
        public java.util.List<CollectResumeDetailRequestResumeDataEducationExperiences> educationExperiences;

        @NameInMap("jobExpect")
        public CollectResumeDetailRequestResumeDataJobExpect jobExpect;

        @NameInMap("languageSkill")
        public java.util.List<CollectResumeDetailRequestResumeDataLanguageSkill> languageSkill;

        @NameInMap("trainingExperiences")
        public java.util.List<CollectResumeDetailRequestResumeDataTrainingExperiences> trainingExperiences;

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

    public static class CollectResumeDetailRequestResumeFile extends TeaModel {
        @NameInMap("downloadUrl")
        public String downloadUrl;

        @NameInMap("fileName")
        public String fileName;

        @NameInMap("fileType")
        public String fileType;

        public static CollectResumeDetailRequestResumeFile build(java.util.Map<String, ?> map) throws Exception {
            CollectResumeDetailRequestResumeFile self = new CollectResumeDetailRequestResumeFile();
            return TeaModel.build(map, self);
        }

        public CollectResumeDetailRequestResumeFile setDownloadUrl(String downloadUrl) {
            this.downloadUrl = downloadUrl;
            return this;
        }
        public String getDownloadUrl() {
            return this.downloadUrl;
        }

        public CollectResumeDetailRequestResumeFile setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public CollectResumeDetailRequestResumeFile setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

    }

}
