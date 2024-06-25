// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class CollectResumeDetailRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>ddats</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <strong>example:</strong>
     * <p>liepin</p>
     */
    @NameInMap("channelCode")
    public String channelCode;

    /**
     * <strong>example:</strong>
     * <p>resumexxxxxxxxxx</p>
     */
    @NameInMap("channelOuterId")
    public String channelOuterId;

    /**
     * <strong>example:</strong>
     * <p>xxxxxx</p>
     */
    @NameInMap("channelTalentId")
    public String channelTalentId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>jobId8fc0d56a605d495ea0214af7axxxxxxx</p>
     */
    @NameInMap("deliverJobId")
    public String deliverJobId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2701606624233xxxxx</p>
     */
    @NameInMap("optUserId")
    public String optUserId;

    /**
     * <strong>example:</strong>
     * <p>http:<a href="http://www.xxx.com">www.xxx.com</a></p>
     */
    @NameInMap("resumeChannelUrl")
    public String resumeChannelUrl;

    /**
     * <p>This parameter is required.</p>
     */
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
        /**
         * <strong>example:</strong>
         * <p>18</p>
         */
        @NameInMap("age")
        public Integer age;

        /**
         * <strong>example:</strong>
         * <p><a href="http://www.xxxx.com">http://www.xxxx.com</a></p>
         */
        @NameInMap("avatar")
        public String avatar;

        /**
         * <strong>example:</strong>
         * <p>yyyy-MM-dd</p>
         */
        @NameInMap("beginWorkTime")
        public String beginWorkTime;

        /**
         * <strong>example:</strong>
         * <p>yyyy-MM-dd</p>
         */
        @NameInMap("birthday")
        public String birthday;

        /**
         * <strong>example:</strong>
         * <p><a href="mailto:xxxxxxx@alibaba-inc.com">xxxxxxx@alibaba-inc.com</a></p>
         */
        @NameInMap("email")
        public String email;

        /**
         * <strong>example:</strong>
         * <p>Jason</p>
         */
        @NameInMap("englishName")
        public String englishName;

        /**
         * <strong>example:</strong>
         * <p>yyyy-MM-dd</p>
         */
        @NameInMap("graduateTime")
        public String graduateTime;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("highestEducation")
        public Integer highestEducation;

        /**
         * <strong>example:</strong>
         * <p>java开发工程师</p>
         */
        @NameInMap("jobTitle")
        public String jobTitle;

        /**
         * <strong>example:</strong>
         * <p>清华大学</p>
         */
        @NameInMap("lastSchoolName")
        public String lastSchoolName;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("married")
        public Integer married;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>孙先生</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>浙江省杭州市余杭区仓前街道</p>
         */
        @NameInMap("nativePlace")
        public String nativePlace;

        /**
         * <strong>example:</strong>
         * <p>浙江省杭州市余杭区仓前街道欧美金融城</p>
         */
        @NameInMap("nowLocation")
        public String nowLocation;

        /**
         * <strong>example:</strong>
         * <p>曾获得xxx比赛xxx奖项</p>
         */
        @NameInMap("personalHonor")
        public String personalHonor;

        /**
         * <strong>example:</strong>
         * <p>187xxxxxxxx</p>
         */
        @NameInMap("phoneNum")
        public String phoneNum;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("politicalStatus")
        public Integer politicalStatus;

        /**
         * <strong>example:</strong>
         * <p>沟通能力强......</p>
         */
        @NameInMap("selfEvaluation")
        public String selfEvaluation;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("sex")
        public Integer sex;

        /**
         * <strong>example:</strong>
         * <p>187xxxxxxxx</p>
         */
        @NameInMap("virtualPhoneNum")
        public String virtualPhoneNum;

        /**
         * <strong>example:</strong>
         * <p>3</p>
         */
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
        /**
         * <strong>example:</strong>
         * <p>高级技工证书</p>
         */
        @NameInMap("certificateName")
        public String certificateName;

        /**
         * <strong>example:</strong>
         * <p>yyyy-MM-dd</p>
         */
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
        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("degree")
        public Integer degree;

        /**
         * <strong>example:</strong>
         * <p>计算机学院</p>
         */
        @NameInMap("department")
        public String department;

        /**
         * <strong>example:</strong>
         * <p>在校期间.......</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <strong>example:</strong>
         * <p>yyyy-MM-dd</p>
         */
        @NameInMap("endDate")
        public String endDate;

        /**
         * <strong>example:</strong>
         * <p>计算机科学与技术</p>
         */
        @NameInMap("major")
        public String major;

        /**
         * <strong>example:</strong>
         * <p>清华大学</p>
         */
        @NameInMap("schoolName")
        public String schoolName;

        /**
         * <strong>example:</strong>
         * <p>yyyy-MM-dd</p>
         */
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
        /**
         * <strong>example:</strong>
         * <p>Java开发工程师</p>
         */
        @NameInMap("jobName")
        public String jobName;

        @NameInMap("locations")
        public java.util.List<String> locations;

        /**
         * <strong>example:</strong>
         * <p>8000</p>
         */
        @NameInMap("maxSalary")
        public String maxSalary;

        /**
         * <strong>example:</strong>
         * <p>3000</p>
         */
        @NameInMap("minSalary")
        public String minSalary;

        /**
         * <strong>example:</strong>
         * <p>yyyy-MM-dd</p>
         */
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
        /**
         * <strong>example:</strong>
         * <p>大学英语六级</p>
         */
        @NameInMap("certificateName")
        public String certificateName;

        /**
         * <strong>example:</strong>
         * <p>英语</p>
         */
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
        /**
         * <strong>example:</strong>
         * <p>培训期间，学习了xxxx技能，获取xxxx证书。</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <strong>example:</strong>
         * <p>yyyy-MM-dd</p>
         */
        @NameInMap("endDate")
        public String endDate;

        /**
         * <strong>example:</strong>
         * <p>新东方挖掘机学校</p>
         */
        @NameInMap("institutionName")
        public String institutionName;

        /**
         * <strong>example:</strong>
         * <p>浙江省杭州市余杭区</p>
         */
        @NameInMap("location")
        public String location;

        /**
         * <strong>example:</strong>
         * <p>挖掘机专业技能培训</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>yyyy-MM-dd</p>
         */
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
        /**
         * <strong>example:</strong>
         * <p>钉钉（中国）信息技术有限公司</p>
         */
        @NameInMap("companyName")
        public String companyName;

        /**
         * <strong>example:</strong>
         * <p>智能人事</p>
         */
        @NameInMap("department")
        public String department;

        /**
         * <strong>example:</strong>
         * <p>工作期间负责......取得了......成果</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <strong>example:</strong>
         * <p>yyyy-MM-dd</p>
         */
        @NameInMap("endDate")
        public String endDate;

        /**
         * <strong>example:</strong>
         * <p>Java开发工程师</p>
         */
        @NameInMap("jobTitle")
        public String jobTitle;

        /**
         * <strong>example:</strong>
         * <p>杭州</p>
         */
        @NameInMap("location")
        public String location;

        /**
         * <strong>example:</strong>
         * <p>负责......</p>
         */
        @NameInMap("responsibility")
        public String responsibility;

        /**
         * <strong>example:</strong>
         * <p>yyyy-MM-dd</p>
         */
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
        /**
         * <p>This parameter is required.</p>
         */
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
        /**
         * <strong>example:</strong>
         * <p>http:<a href="http://www.xxx.com">www.xxx.com</a></p>
         */
        @NameInMap("downloadUrl")
        public String downloadUrl;

        /**
         * <strong>example:</strong>
         * <p>xxx.pdf</p>
         */
        @NameInMap("fileName")
        public String fileName;

        /**
         * <strong>example:</strong>
         * <p>pdf</p>
         */
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
