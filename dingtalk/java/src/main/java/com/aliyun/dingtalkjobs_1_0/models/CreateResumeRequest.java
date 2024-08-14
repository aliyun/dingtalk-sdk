// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjobs_1_0.models;

import com.aliyun.tea.*;

public class CreateResumeRequest extends TeaModel {
    @NameInMap("bizCode")
    public String bizCode;

    @NameInMap("ext")
    public String ext;

    @NameInMap("resumeDataVO")
    public CreateResumeRequestResumeDataVO resumeDataVO;

    @NameInMap("scene")
    public String scene;

    @NameInMap("types")
    public java.util.List<String> types;

    /**
     * <strong>if can be null:</strong>
     * <p>false</p>
     */
    @NameInMap("userIdentify")
    public String userIdentify;

    public static CreateResumeRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateResumeRequest self = new CreateResumeRequest();
        return TeaModel.build(map, self);
    }

    public CreateResumeRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public CreateResumeRequest setExt(String ext) {
        this.ext = ext;
        return this;
    }
    public String getExt() {
        return this.ext;
    }

    public CreateResumeRequest setResumeDataVO(CreateResumeRequestResumeDataVO resumeDataVO) {
        this.resumeDataVO = resumeDataVO;
        return this;
    }
    public CreateResumeRequestResumeDataVO getResumeDataVO() {
        return this.resumeDataVO;
    }

    public CreateResumeRequest setScene(String scene) {
        this.scene = scene;
        return this;
    }
    public String getScene() {
        return this.scene;
    }

    public CreateResumeRequest setTypes(java.util.List<String> types) {
        this.types = types;
        return this;
    }
    public java.util.List<String> getTypes() {
        return this.types;
    }

    public CreateResumeRequest setUserIdentify(String userIdentify) {
        this.userIdentify = userIdentify;
        return this;
    }
    public String getUserIdentify() {
        return this.userIdentify;
    }

    public static class CreateResumeRequestResumeDataVOBaseInfo extends TeaModel {
        @NameInMap("age")
        public Long age;

        @NameInMap("avatar")
        public String avatar;

        @NameInMap("beginWorkTime")
        public String beginWorkTime;

        @NameInMap("birthday")
        public String birthday;

        @NameInMap("candidateBackground")
        public Integer candidateBackground;

        @NameInMap("dingTalk")
        public String dingTalk;

        @NameInMap("email")
        public String email;

        @NameInMap("englishName")
        public String englishName;

        @NameInMap("ethnicity")
        public String ethnicity;

        @NameInMap("gaduateTime")
        public String gaduateTime;

        @NameInMap("highestAcademic")
        public String highestAcademic;

        @NameInMap("highestEducation")
        public Integer highestEducation;

        @NameInMap("identify")
        public String identify;

        @NameInMap("industry")
        public String industry;

        @NameInMap("industryCode")
        public String industryCode;

        @NameInMap("jobTitle")
        public String jobTitle;

        @NameInMap("lastSchoolName")
        public String lastSchoolName;

        @NameInMap("married")
        public Long married;

        @NameInMap("mbtiType")
        public Integer mbtiType;

        @NameInMap("name")
        public String name;

        @NameInMap("nationality")
        public String nationality;

        @NameInMap("nativePlace")
        public String nativePlace;

        @NameInMap("nativePlaceCode")
        public String nativePlaceCode;

        @NameInMap("nowLocation")
        public String nowLocation;

        @NameInMap("nowLocationCode")
        public String nowLocationCode;

        @NameInMap("parentIndustry")
        public String parentIndustry;

        @NameInMap("parentIndustryCode")
        public String parentIndustryCode;

        @NameInMap("personalHonor")
        public String personalHonor;

        @NameInMap("personalUrls")
        public java.util.List<String> personalUrls;

        @NameInMap("phoneNum")
        public String phoneNum;

        @NameInMap("politicalStatus")
        public Integer politicalStatus;

        @NameInMap("qq")
        public String qq;

        @NameInMap("realAvatar")
        public Integer realAvatar;

        @NameInMap("selfEvaluation")
        public String selfEvaluation;

        @NameInMap("sex")
        public Integer sex;

        @NameInMap("skillSummary")
        public String skillSummary;

        @NameInMap("stateCode")
        public String stateCode;

        @NameInMap("status")
        public String status;

        @NameInMap("virtualPhoneNum")
        public String virtualPhoneNum;

        @NameInMap("weChat")
        public String weChat;

        @NameInMap("weibo")
        public String weibo;

        @NameInMap("workingYears")
        public Integer workingYears;

        public static CreateResumeRequestResumeDataVOBaseInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateResumeRequestResumeDataVOBaseInfo self = new CreateResumeRequestResumeDataVOBaseInfo();
            return TeaModel.build(map, self);
        }

        public CreateResumeRequestResumeDataVOBaseInfo setAge(Long age) {
            this.age = age;
            return this;
        }
        public Long getAge() {
            return this.age;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setAvatar(String avatar) {
            this.avatar = avatar;
            return this;
        }
        public String getAvatar() {
            return this.avatar;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setBeginWorkTime(String beginWorkTime) {
            this.beginWorkTime = beginWorkTime;
            return this;
        }
        public String getBeginWorkTime() {
            return this.beginWorkTime;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setBirthday(String birthday) {
            this.birthday = birthday;
            return this;
        }
        public String getBirthday() {
            return this.birthday;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setCandidateBackground(Integer candidateBackground) {
            this.candidateBackground = candidateBackground;
            return this;
        }
        public Integer getCandidateBackground() {
            return this.candidateBackground;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setDingTalk(String dingTalk) {
            this.dingTalk = dingTalk;
            return this;
        }
        public String getDingTalk() {
            return this.dingTalk;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setEmail(String email) {
            this.email = email;
            return this;
        }
        public String getEmail() {
            return this.email;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setEnglishName(String englishName) {
            this.englishName = englishName;
            return this;
        }
        public String getEnglishName() {
            return this.englishName;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setEthnicity(String ethnicity) {
            this.ethnicity = ethnicity;
            return this;
        }
        public String getEthnicity() {
            return this.ethnicity;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setGaduateTime(String gaduateTime) {
            this.gaduateTime = gaduateTime;
            return this;
        }
        public String getGaduateTime() {
            return this.gaduateTime;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setHighestAcademic(String highestAcademic) {
            this.highestAcademic = highestAcademic;
            return this;
        }
        public String getHighestAcademic() {
            return this.highestAcademic;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setHighestEducation(Integer highestEducation) {
            this.highestEducation = highestEducation;
            return this;
        }
        public Integer getHighestEducation() {
            return this.highestEducation;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setIdentify(String identify) {
            this.identify = identify;
            return this;
        }
        public String getIdentify() {
            return this.identify;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setIndustry(String industry) {
            this.industry = industry;
            return this;
        }
        public String getIndustry() {
            return this.industry;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setIndustryCode(String industryCode) {
            this.industryCode = industryCode;
            return this;
        }
        public String getIndustryCode() {
            return this.industryCode;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setJobTitle(String jobTitle) {
            this.jobTitle = jobTitle;
            return this;
        }
        public String getJobTitle() {
            return this.jobTitle;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setLastSchoolName(String lastSchoolName) {
            this.lastSchoolName = lastSchoolName;
            return this;
        }
        public String getLastSchoolName() {
            return this.lastSchoolName;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setMarried(Long married) {
            this.married = married;
            return this;
        }
        public Long getMarried() {
            return this.married;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setMbtiType(Integer mbtiType) {
            this.mbtiType = mbtiType;
            return this;
        }
        public Integer getMbtiType() {
            return this.mbtiType;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setNationality(String nationality) {
            this.nationality = nationality;
            return this;
        }
        public String getNationality() {
            return this.nationality;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setNativePlace(String nativePlace) {
            this.nativePlace = nativePlace;
            return this;
        }
        public String getNativePlace() {
            return this.nativePlace;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setNativePlaceCode(String nativePlaceCode) {
            this.nativePlaceCode = nativePlaceCode;
            return this;
        }
        public String getNativePlaceCode() {
            return this.nativePlaceCode;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setNowLocation(String nowLocation) {
            this.nowLocation = nowLocation;
            return this;
        }
        public String getNowLocation() {
            return this.nowLocation;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setNowLocationCode(String nowLocationCode) {
            this.nowLocationCode = nowLocationCode;
            return this;
        }
        public String getNowLocationCode() {
            return this.nowLocationCode;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setParentIndustry(String parentIndustry) {
            this.parentIndustry = parentIndustry;
            return this;
        }
        public String getParentIndustry() {
            return this.parentIndustry;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setParentIndustryCode(String parentIndustryCode) {
            this.parentIndustryCode = parentIndustryCode;
            return this;
        }
        public String getParentIndustryCode() {
            return this.parentIndustryCode;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setPersonalHonor(String personalHonor) {
            this.personalHonor = personalHonor;
            return this;
        }
        public String getPersonalHonor() {
            return this.personalHonor;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setPersonalUrls(java.util.List<String> personalUrls) {
            this.personalUrls = personalUrls;
            return this;
        }
        public java.util.List<String> getPersonalUrls() {
            return this.personalUrls;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setPhoneNum(String phoneNum) {
            this.phoneNum = phoneNum;
            return this;
        }
        public String getPhoneNum() {
            return this.phoneNum;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setPoliticalStatus(Integer politicalStatus) {
            this.politicalStatus = politicalStatus;
            return this;
        }
        public Integer getPoliticalStatus() {
            return this.politicalStatus;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setQq(String qq) {
            this.qq = qq;
            return this;
        }
        public String getQq() {
            return this.qq;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setRealAvatar(Integer realAvatar) {
            this.realAvatar = realAvatar;
            return this;
        }
        public Integer getRealAvatar() {
            return this.realAvatar;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setSelfEvaluation(String selfEvaluation) {
            this.selfEvaluation = selfEvaluation;
            return this;
        }
        public String getSelfEvaluation() {
            return this.selfEvaluation;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setSex(Integer sex) {
            this.sex = sex;
            return this;
        }
        public Integer getSex() {
            return this.sex;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setSkillSummary(String skillSummary) {
            this.skillSummary = skillSummary;
            return this;
        }
        public String getSkillSummary() {
            return this.skillSummary;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setStateCode(String stateCode) {
            this.stateCode = stateCode;
            return this;
        }
        public String getStateCode() {
            return this.stateCode;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setVirtualPhoneNum(String virtualPhoneNum) {
            this.virtualPhoneNum = virtualPhoneNum;
            return this;
        }
        public String getVirtualPhoneNum() {
            return this.virtualPhoneNum;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setWeChat(String weChat) {
            this.weChat = weChat;
            return this;
        }
        public String getWeChat() {
            return this.weChat;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setWeibo(String weibo) {
            this.weibo = weibo;
            return this;
        }
        public String getWeibo() {
            return this.weibo;
        }

        public CreateResumeRequestResumeDataVOBaseInfo setWorkingYears(Integer workingYears) {
            this.workingYears = workingYears;
            return this;
        }
        public Integer getWorkingYears() {
            return this.workingYears;
        }

    }

    public static class CreateResumeRequestResumeDataVOCertificates extends TeaModel {
        @NameInMap("certificateId")
        public String certificateId;

        @NameInMap("certificateName")
        public String certificateName;

        @NameInMap("crantTime")
        public String crantTime;

        public static CreateResumeRequestResumeDataVOCertificates build(java.util.Map<String, ?> map) throws Exception {
            CreateResumeRequestResumeDataVOCertificates self = new CreateResumeRequestResumeDataVOCertificates();
            return TeaModel.build(map, self);
        }

        public CreateResumeRequestResumeDataVOCertificates setCertificateId(String certificateId) {
            this.certificateId = certificateId;
            return this;
        }
        public String getCertificateId() {
            return this.certificateId;
        }

        public CreateResumeRequestResumeDataVOCertificates setCertificateName(String certificateName) {
            this.certificateName = certificateName;
            return this;
        }
        public String getCertificateName() {
            return this.certificateName;
        }

        public CreateResumeRequestResumeDataVOCertificates setCrantTime(String crantTime) {
            this.crantTime = crantTime;
            return this;
        }
        public String getCrantTime() {
            return this.crantTime;
        }

    }

    public static class CreateResumeRequestResumeDataVOJobExpectsCityList extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("name")
        public String name;

        public static CreateResumeRequestResumeDataVOJobExpectsCityList build(java.util.Map<String, ?> map) throws Exception {
            CreateResumeRequestResumeDataVOJobExpectsCityList self = new CreateResumeRequestResumeDataVOJobExpectsCityList();
            return TeaModel.build(map, self);
        }

        public CreateResumeRequestResumeDataVOJobExpectsCityList setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public CreateResumeRequestResumeDataVOJobExpectsCityList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class CreateResumeRequestResumeDataVOJobExpectsIndustryList extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("name")
        public String name;

        public static CreateResumeRequestResumeDataVOJobExpectsIndustryList build(java.util.Map<String, ?> map) throws Exception {
            CreateResumeRequestResumeDataVOJobExpectsIndustryList self = new CreateResumeRequestResumeDataVOJobExpectsIndustryList();
            return TeaModel.build(map, self);
        }

        public CreateResumeRequestResumeDataVOJobExpectsIndustryList setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public CreateResumeRequestResumeDataVOJobExpectsIndustryList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class CreateResumeRequestResumeDataVOJobExpectsJobList extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("name")
        public String name;

        public static CreateResumeRequestResumeDataVOJobExpectsJobList build(java.util.Map<String, ?> map) throws Exception {
            CreateResumeRequestResumeDataVOJobExpectsJobList self = new CreateResumeRequestResumeDataVOJobExpectsJobList();
            return TeaModel.build(map, self);
        }

        public CreateResumeRequestResumeDataVOJobExpectsJobList setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public CreateResumeRequestResumeDataVOJobExpectsJobList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class CreateResumeRequestResumeDataVOJobExpectsOtherCityList extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("name")
        public String name;

        public static CreateResumeRequestResumeDataVOJobExpectsOtherCityList build(java.util.Map<String, ?> map) throws Exception {
            CreateResumeRequestResumeDataVOJobExpectsOtherCityList self = new CreateResumeRequestResumeDataVOJobExpectsOtherCityList();
            return TeaModel.build(map, self);
        }

        public CreateResumeRequestResumeDataVOJobExpectsOtherCityList setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public CreateResumeRequestResumeDataVOJobExpectsOtherCityList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class CreateResumeRequestResumeDataVOJobExpects extends TeaModel {
        @NameInMap("cityList")
        public java.util.List<CreateResumeRequestResumeDataVOJobExpectsCityList> cityList;

        @NameInMap("gmtCreate")
        public Long gmtCreate;

        @NameInMap("gmtModified")
        public Long gmtModified;

        @NameInMap("industryList")
        public java.util.List<CreateResumeRequestResumeDataVOJobExpectsIndustryList> industryList;

        @NameInMap("jobList")
        public java.util.List<CreateResumeRequestResumeDataVOJobExpectsJobList> jobList;

        @NameInMap("jobNature")
        public String jobNature;

        @NameInMap("maxSalary")
        public String maxSalary;

        @NameInMap("minSalary")
        public String minSalary;

        @NameInMap("otherCityList")
        public java.util.List<CreateResumeRequestResumeDataVOJobExpectsOtherCityList> otherCityList;

        @NameInMap("salaryDesc")
        public String salaryDesc;

        @NameInMap("salarySettleType")
        public String salarySettleType;

        @NameInMap("salaryType")
        public String salaryType;

        @NameInMap("salaryYear")
        public String salaryYear;

        public static CreateResumeRequestResumeDataVOJobExpects build(java.util.Map<String, ?> map) throws Exception {
            CreateResumeRequestResumeDataVOJobExpects self = new CreateResumeRequestResumeDataVOJobExpects();
            return TeaModel.build(map, self);
        }

        public CreateResumeRequestResumeDataVOJobExpects setCityList(java.util.List<CreateResumeRequestResumeDataVOJobExpectsCityList> cityList) {
            this.cityList = cityList;
            return this;
        }
        public java.util.List<CreateResumeRequestResumeDataVOJobExpectsCityList> getCityList() {
            return this.cityList;
        }

        public CreateResumeRequestResumeDataVOJobExpects setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public CreateResumeRequestResumeDataVOJobExpects setGmtModified(Long gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public Long getGmtModified() {
            return this.gmtModified;
        }

        public CreateResumeRequestResumeDataVOJobExpects setIndustryList(java.util.List<CreateResumeRequestResumeDataVOJobExpectsIndustryList> industryList) {
            this.industryList = industryList;
            return this;
        }
        public java.util.List<CreateResumeRequestResumeDataVOJobExpectsIndustryList> getIndustryList() {
            return this.industryList;
        }

        public CreateResumeRequestResumeDataVOJobExpects setJobList(java.util.List<CreateResumeRequestResumeDataVOJobExpectsJobList> jobList) {
            this.jobList = jobList;
            return this;
        }
        public java.util.List<CreateResumeRequestResumeDataVOJobExpectsJobList> getJobList() {
            return this.jobList;
        }

        public CreateResumeRequestResumeDataVOJobExpects setJobNature(String jobNature) {
            this.jobNature = jobNature;
            return this;
        }
        public String getJobNature() {
            return this.jobNature;
        }

        public CreateResumeRequestResumeDataVOJobExpects setMaxSalary(String maxSalary) {
            this.maxSalary = maxSalary;
            return this;
        }
        public String getMaxSalary() {
            return this.maxSalary;
        }

        public CreateResumeRequestResumeDataVOJobExpects setMinSalary(String minSalary) {
            this.minSalary = minSalary;
            return this;
        }
        public String getMinSalary() {
            return this.minSalary;
        }

        public CreateResumeRequestResumeDataVOJobExpects setOtherCityList(java.util.List<CreateResumeRequestResumeDataVOJobExpectsOtherCityList> otherCityList) {
            this.otherCityList = otherCityList;
            return this;
        }
        public java.util.List<CreateResumeRequestResumeDataVOJobExpectsOtherCityList> getOtherCityList() {
            return this.otherCityList;
        }

        public CreateResumeRequestResumeDataVOJobExpects setSalaryDesc(String salaryDesc) {
            this.salaryDesc = salaryDesc;
            return this;
        }
        public String getSalaryDesc() {
            return this.salaryDesc;
        }

        public CreateResumeRequestResumeDataVOJobExpects setSalarySettleType(String salarySettleType) {
            this.salarySettleType = salarySettleType;
            return this;
        }
        public String getSalarySettleType() {
            return this.salarySettleType;
        }

        public CreateResumeRequestResumeDataVOJobExpects setSalaryType(String salaryType) {
            this.salaryType = salaryType;
            return this;
        }
        public String getSalaryType() {
            return this.salaryType;
        }

        public CreateResumeRequestResumeDataVOJobExpects setSalaryYear(String salaryYear) {
            this.salaryYear = salaryYear;
            return this;
        }
        public String getSalaryYear() {
            return this.salaryYear;
        }

    }

    public static class CreateResumeRequestResumeDataVOPersonalHonors extends TeaModel {
        @NameInMap("description")
        public String description;

        @NameInMap("grantTime")
        public String grantTime;

        public static CreateResumeRequestResumeDataVOPersonalHonors build(java.util.Map<String, ?> map) throws Exception {
            CreateResumeRequestResumeDataVOPersonalHonors self = new CreateResumeRequestResumeDataVOPersonalHonors();
            return TeaModel.build(map, self);
        }

        public CreateResumeRequestResumeDataVOPersonalHonors setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public CreateResumeRequestResumeDataVOPersonalHonors setGrantTime(String grantTime) {
            this.grantTime = grantTime;
            return this;
        }
        public String getGrantTime() {
            return this.grantTime;
        }

    }

    public static class CreateResumeRequestResumeDataVOProjectExperiences extends TeaModel {
        @NameInMap("achievement")
        public String achievement;

        @NameInMap("description")
        public String description;

        @NameInMap("endDate")
        public String endDate;

        @NameInMap("name")
        public String name;

        @NameInMap("projectUrl")
        public String projectUrl;

        @NameInMap("responsibility")
        public String responsibility;

        @NameInMap("startDate")
        public String startDate;

        @NameInMap("technology")
        public String technology;

        @NameInMap("title")
        public String title;

        public static CreateResumeRequestResumeDataVOProjectExperiences build(java.util.Map<String, ?> map) throws Exception {
            CreateResumeRequestResumeDataVOProjectExperiences self = new CreateResumeRequestResumeDataVOProjectExperiences();
            return TeaModel.build(map, self);
        }

        public CreateResumeRequestResumeDataVOProjectExperiences setAchievement(String achievement) {
            this.achievement = achievement;
            return this;
        }
        public String getAchievement() {
            return this.achievement;
        }

        public CreateResumeRequestResumeDataVOProjectExperiences setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public CreateResumeRequestResumeDataVOProjectExperiences setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
        }

        public CreateResumeRequestResumeDataVOProjectExperiences setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CreateResumeRequestResumeDataVOProjectExperiences setProjectUrl(String projectUrl) {
            this.projectUrl = projectUrl;
            return this;
        }
        public String getProjectUrl() {
            return this.projectUrl;
        }

        public CreateResumeRequestResumeDataVOProjectExperiences setResponsibility(String responsibility) {
            this.responsibility = responsibility;
            return this;
        }
        public String getResponsibility() {
            return this.responsibility;
        }

        public CreateResumeRequestResumeDataVOProjectExperiences setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

        public CreateResumeRequestResumeDataVOProjectExperiences setTechnology(String technology) {
            this.technology = technology;
            return this;
        }
        public String getTechnology() {
            return this.technology;
        }

        public CreateResumeRequestResumeDataVOProjectExperiences setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class CreateResumeRequestResumeDataVOTags extends TeaModel {
        @NameInMap("tag")
        public String tag;

        public static CreateResumeRequestResumeDataVOTags build(java.util.Map<String, ?> map) throws Exception {
            CreateResumeRequestResumeDataVOTags self = new CreateResumeRequestResumeDataVOTags();
            return TeaModel.build(map, self);
        }

        public CreateResumeRequestResumeDataVOTags setTag(String tag) {
            this.tag = tag;
            return this;
        }
        public String getTag() {
            return this.tag;
        }

    }

    public static class CreateResumeRequestResumeDataVOWorkExperiencesResumePrivacy extends TeaModel {
        @NameInMap("shieldedCompany")
        public Boolean shieldedCompany;

        @NameInMap("shieldedRelatedCompany")
        public Boolean shieldedRelatedCompany;

        public static CreateResumeRequestResumeDataVOWorkExperiencesResumePrivacy build(java.util.Map<String, ?> map) throws Exception {
            CreateResumeRequestResumeDataVOWorkExperiencesResumePrivacy self = new CreateResumeRequestResumeDataVOWorkExperiencesResumePrivacy();
            return TeaModel.build(map, self);
        }

        public CreateResumeRequestResumeDataVOWorkExperiencesResumePrivacy setShieldedCompany(Boolean shieldedCompany) {
            this.shieldedCompany = shieldedCompany;
            return this;
        }
        public Boolean getShieldedCompany() {
            return this.shieldedCompany;
        }

        public CreateResumeRequestResumeDataVOWorkExperiencesResumePrivacy setShieldedRelatedCompany(Boolean shieldedRelatedCompany) {
            this.shieldedRelatedCompany = shieldedRelatedCompany;
            return this;
        }
        public Boolean getShieldedRelatedCompany() {
            return this.shieldedRelatedCompany;
        }

    }

    public static class CreateResumeRequestResumeDataVOWorkExperiences extends TeaModel {
        @NameInMap("achievement")
        public String achievement;

        @NameInMap("companyCode")
        public String companyCode;

        @NameInMap("companyName")
        public String companyName;

        @NameInMap("description")
        public String description;

        @NameInMap("endDate")
        public String endDate;

        @NameInMap("industry")
        public String industry;

        @NameInMap("industryCode")
        public String industryCode;

        @NameInMap("internship")
        public Boolean internship;

        @NameInMap("jobCode")
        public String jobCode;

        @NameInMap("jobNature")
        public String jobNature;

        @NameInMap("jobTitle")
        public String jobTitle;

        @NameInMap("leader")
        public String leader;

        @NameInMap("location")
        public String location;

        @NameInMap("locationCode")
        public String locationCode;

        @NameInMap("parentIndustry")
        public String parentIndustry;

        @NameInMap("parentIndustryCode")
        public String parentIndustryCode;

        @NameInMap("reasonOfLeaving")
        public String reasonOfLeaving;

        @NameInMap("responsibility")
        public String responsibility;

        @NameInMap("resumePrivacy")
        public CreateResumeRequestResumeDataVOWorkExperiencesResumePrivacy resumePrivacy;

        @NameInMap("salary")
        public String salary;

        @NameInMap("selectedSkillOptions")
        public java.util.List<String> selectedSkillOptions;

        @NameInMap("startDate")
        public String startDate;

        @NameInMap("underlingNumber")
        public String underlingNumber;

        public static CreateResumeRequestResumeDataVOWorkExperiences build(java.util.Map<String, ?> map) throws Exception {
            CreateResumeRequestResumeDataVOWorkExperiences self = new CreateResumeRequestResumeDataVOWorkExperiences();
            return TeaModel.build(map, self);
        }

        public CreateResumeRequestResumeDataVOWorkExperiences setAchievement(String achievement) {
            this.achievement = achievement;
            return this;
        }
        public String getAchievement() {
            return this.achievement;
        }

        public CreateResumeRequestResumeDataVOWorkExperiences setCompanyCode(String companyCode) {
            this.companyCode = companyCode;
            return this;
        }
        public String getCompanyCode() {
            return this.companyCode;
        }

        public CreateResumeRequestResumeDataVOWorkExperiences setCompanyName(String companyName) {
            this.companyName = companyName;
            return this;
        }
        public String getCompanyName() {
            return this.companyName;
        }

        public CreateResumeRequestResumeDataVOWorkExperiences setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public CreateResumeRequestResumeDataVOWorkExperiences setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
        }

        public CreateResumeRequestResumeDataVOWorkExperiences setIndustry(String industry) {
            this.industry = industry;
            return this;
        }
        public String getIndustry() {
            return this.industry;
        }

        public CreateResumeRequestResumeDataVOWorkExperiences setIndustryCode(String industryCode) {
            this.industryCode = industryCode;
            return this;
        }
        public String getIndustryCode() {
            return this.industryCode;
        }

        public CreateResumeRequestResumeDataVOWorkExperiences setInternship(Boolean internship) {
            this.internship = internship;
            return this;
        }
        public Boolean getInternship() {
            return this.internship;
        }

        public CreateResumeRequestResumeDataVOWorkExperiences setJobCode(String jobCode) {
            this.jobCode = jobCode;
            return this;
        }
        public String getJobCode() {
            return this.jobCode;
        }

        public CreateResumeRequestResumeDataVOWorkExperiences setJobNature(String jobNature) {
            this.jobNature = jobNature;
            return this;
        }
        public String getJobNature() {
            return this.jobNature;
        }

        public CreateResumeRequestResumeDataVOWorkExperiences setJobTitle(String jobTitle) {
            this.jobTitle = jobTitle;
            return this;
        }
        public String getJobTitle() {
            return this.jobTitle;
        }

        public CreateResumeRequestResumeDataVOWorkExperiences setLeader(String leader) {
            this.leader = leader;
            return this;
        }
        public String getLeader() {
            return this.leader;
        }

        public CreateResumeRequestResumeDataVOWorkExperiences setLocation(String location) {
            this.location = location;
            return this;
        }
        public String getLocation() {
            return this.location;
        }

        public CreateResumeRequestResumeDataVOWorkExperiences setLocationCode(String locationCode) {
            this.locationCode = locationCode;
            return this;
        }
        public String getLocationCode() {
            return this.locationCode;
        }

        public CreateResumeRequestResumeDataVOWorkExperiences setParentIndustry(String parentIndustry) {
            this.parentIndustry = parentIndustry;
            return this;
        }
        public String getParentIndustry() {
            return this.parentIndustry;
        }

        public CreateResumeRequestResumeDataVOWorkExperiences setParentIndustryCode(String parentIndustryCode) {
            this.parentIndustryCode = parentIndustryCode;
            return this;
        }
        public String getParentIndustryCode() {
            return this.parentIndustryCode;
        }

        public CreateResumeRequestResumeDataVOWorkExperiences setReasonOfLeaving(String reasonOfLeaving) {
            this.reasonOfLeaving = reasonOfLeaving;
            return this;
        }
        public String getReasonOfLeaving() {
            return this.reasonOfLeaving;
        }

        public CreateResumeRequestResumeDataVOWorkExperiences setResponsibility(String responsibility) {
            this.responsibility = responsibility;
            return this;
        }
        public String getResponsibility() {
            return this.responsibility;
        }

        public CreateResumeRequestResumeDataVOWorkExperiences setResumePrivacy(CreateResumeRequestResumeDataVOWorkExperiencesResumePrivacy resumePrivacy) {
            this.resumePrivacy = resumePrivacy;
            return this;
        }
        public CreateResumeRequestResumeDataVOWorkExperiencesResumePrivacy getResumePrivacy() {
            return this.resumePrivacy;
        }

        public CreateResumeRequestResumeDataVOWorkExperiences setSalary(String salary) {
            this.salary = salary;
            return this;
        }
        public String getSalary() {
            return this.salary;
        }

        public CreateResumeRequestResumeDataVOWorkExperiences setSelectedSkillOptions(java.util.List<String> selectedSkillOptions) {
            this.selectedSkillOptions = selectedSkillOptions;
            return this;
        }
        public java.util.List<String> getSelectedSkillOptions() {
            return this.selectedSkillOptions;
        }

        public CreateResumeRequestResumeDataVOWorkExperiences setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

        public CreateResumeRequestResumeDataVOWorkExperiences setUnderlingNumber(String underlingNumber) {
            this.underlingNumber = underlingNumber;
            return this;
        }
        public String getUnderlingNumber() {
            return this.underlingNumber;
        }

    }

    public static class CreateResumeRequestResumeDataVO extends TeaModel {
        @NameInMap("baseInfo")
        public CreateResumeRequestResumeDataVOBaseInfo baseInfo;

        @NameInMap("certificates")
        public java.util.List<CreateResumeRequestResumeDataVOCertificates> certificates;

        @NameInMap("jobExpects")
        public java.util.List<CreateResumeRequestResumeDataVOJobExpects> jobExpects;

        @NameInMap("personalHonors")
        public java.util.List<CreateResumeRequestResumeDataVOPersonalHonors> personalHonors;

        @NameInMap("projectExperiences")
        public java.util.List<CreateResumeRequestResumeDataVOProjectExperiences> projectExperiences;

        @NameInMap("tags")
        public java.util.List<CreateResumeRequestResumeDataVOTags> tags;

        @NameInMap("workExperiences")
        public java.util.List<CreateResumeRequestResumeDataVOWorkExperiences> workExperiences;

        public static CreateResumeRequestResumeDataVO build(java.util.Map<String, ?> map) throws Exception {
            CreateResumeRequestResumeDataVO self = new CreateResumeRequestResumeDataVO();
            return TeaModel.build(map, self);
        }

        public CreateResumeRequestResumeDataVO setBaseInfo(CreateResumeRequestResumeDataVOBaseInfo baseInfo) {
            this.baseInfo = baseInfo;
            return this;
        }
        public CreateResumeRequestResumeDataVOBaseInfo getBaseInfo() {
            return this.baseInfo;
        }

        public CreateResumeRequestResumeDataVO setCertificates(java.util.List<CreateResumeRequestResumeDataVOCertificates> certificates) {
            this.certificates = certificates;
            return this;
        }
        public java.util.List<CreateResumeRequestResumeDataVOCertificates> getCertificates() {
            return this.certificates;
        }

        public CreateResumeRequestResumeDataVO setJobExpects(java.util.List<CreateResumeRequestResumeDataVOJobExpects> jobExpects) {
            this.jobExpects = jobExpects;
            return this;
        }
        public java.util.List<CreateResumeRequestResumeDataVOJobExpects> getJobExpects() {
            return this.jobExpects;
        }

        public CreateResumeRequestResumeDataVO setPersonalHonors(java.util.List<CreateResumeRequestResumeDataVOPersonalHonors> personalHonors) {
            this.personalHonors = personalHonors;
            return this;
        }
        public java.util.List<CreateResumeRequestResumeDataVOPersonalHonors> getPersonalHonors() {
            return this.personalHonors;
        }

        public CreateResumeRequestResumeDataVO setProjectExperiences(java.util.List<CreateResumeRequestResumeDataVOProjectExperiences> projectExperiences) {
            this.projectExperiences = projectExperiences;
            return this;
        }
        public java.util.List<CreateResumeRequestResumeDataVOProjectExperiences> getProjectExperiences() {
            return this.projectExperiences;
        }

        public CreateResumeRequestResumeDataVO setTags(java.util.List<CreateResumeRequestResumeDataVOTags> tags) {
            this.tags = tags;
            return this;
        }
        public java.util.List<CreateResumeRequestResumeDataVOTags> getTags() {
            return this.tags;
        }

        public CreateResumeRequestResumeDataVO setWorkExperiences(java.util.List<CreateResumeRequestResumeDataVOWorkExperiences> workExperiences) {
            this.workExperiences = workExperiences;
            return this;
        }
        public java.util.List<CreateResumeRequestResumeDataVOWorkExperiences> getWorkExperiences() {
            return this.workExperiences;
        }

    }

}
