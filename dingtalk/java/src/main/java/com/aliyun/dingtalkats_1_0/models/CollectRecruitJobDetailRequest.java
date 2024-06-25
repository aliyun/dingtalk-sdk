// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class CollectRecruitJobDetailRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>ddats</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <strong>example:</strong>
     * <p>zhilian</p>
     */
    @NameInMap("channel")
    public String channel;

    @NameInMap("jobInfo")
    public CollectRecruitJobDetailRequestJobInfo jobInfo;

    /**
     * <strong>example:</strong>
     * <p>corpxxxxxxxxx</p>
     */
    @NameInMap("outCorpId")
    public String outCorpId;

    /**
     * <strong>example:</strong>
     * <p>小莫科技有限公司</p>
     */
    @NameInMap("outCorpName")
    public String outCorpName;

    @NameInMap("recruitUserInfo")
    public CollectRecruitJobDetailRequestRecruitUserInfo recruitUserInfo;

    /**
     * <strong>example:</strong>
     * <p>BOSS</p>
     */
    @NameInMap("source")
    public String source;

    /**
     * <strong>example:</strong>
     * <p>1677465956008</p>
     */
    @NameInMap("updateTime")
    public Long updateTime;

    public static CollectRecruitJobDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        CollectRecruitJobDetailRequest self = new CollectRecruitJobDetailRequest();
        return TeaModel.build(map, self);
    }

    public CollectRecruitJobDetailRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public CollectRecruitJobDetailRequest setChannel(String channel) {
        this.channel = channel;
        return this;
    }
    public String getChannel() {
        return this.channel;
    }

    public CollectRecruitJobDetailRequest setJobInfo(CollectRecruitJobDetailRequestJobInfo jobInfo) {
        this.jobInfo = jobInfo;
        return this;
    }
    public CollectRecruitJobDetailRequestJobInfo getJobInfo() {
        return this.jobInfo;
    }

    public CollectRecruitJobDetailRequest setOutCorpId(String outCorpId) {
        this.outCorpId = outCorpId;
        return this;
    }
    public String getOutCorpId() {
        return this.outCorpId;
    }

    public CollectRecruitJobDetailRequest setOutCorpName(String outCorpName) {
        this.outCorpName = outCorpName;
        return this;
    }
    public String getOutCorpName() {
        return this.outCorpName;
    }

    public CollectRecruitJobDetailRequest setRecruitUserInfo(CollectRecruitJobDetailRequestRecruitUserInfo recruitUserInfo) {
        this.recruitUserInfo = recruitUserInfo;
        return this;
    }
    public CollectRecruitJobDetailRequestRecruitUserInfo getRecruitUserInfo() {
        return this.recruitUserInfo;
    }

    public CollectRecruitJobDetailRequest setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

    public CollectRecruitJobDetailRequest setUpdateTime(Long updateTime) {
        this.updateTime = updateTime;
        return this;
    }
    public Long getUpdateTime() {
        return this.updateTime;
    }

    public static class CollectRecruitJobDetailRequestJobInfoAddress extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>310000</p>
         */
        @NameInMap("cityCode")
        public String cityCode;

        /**
         * <strong>example:</strong>
         * <p>文一西路999号</p>
         */
        @NameInMap("detail")
        public String detail;

        /**
         * <strong>example:</strong>
         * <p>311000</p>
         */
        @NameInMap("districtCode")
        public String districtCode;

        /**
         * <strong>example:</strong>
         * <p>89.54613</p>
         */
        @NameInMap("latitude")
        public String latitude;

        /**
         * <strong>example:</strong>
         * <p>128.45613</p>
         */
        @NameInMap("longitude")
        public String longitude;

        /**
         * <strong>example:</strong>
         * <p>总部大楼</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>300000</p>
         */
        @NameInMap("provinceCode")
        public String provinceCode;

        public static CollectRecruitJobDetailRequestJobInfoAddress build(java.util.Map<String, ?> map) throws Exception {
            CollectRecruitJobDetailRequestJobInfoAddress self = new CollectRecruitJobDetailRequestJobInfoAddress();
            return TeaModel.build(map, self);
        }

        public CollectRecruitJobDetailRequestJobInfoAddress setCityCode(String cityCode) {
            this.cityCode = cityCode;
            return this;
        }
        public String getCityCode() {
            return this.cityCode;
        }

        public CollectRecruitJobDetailRequestJobInfoAddress setDetail(String detail) {
            this.detail = detail;
            return this;
        }
        public String getDetail() {
            return this.detail;
        }

        public CollectRecruitJobDetailRequestJobInfoAddress setDistrictCode(String districtCode) {
            this.districtCode = districtCode;
            return this;
        }
        public String getDistrictCode() {
            return this.districtCode;
        }

        public CollectRecruitJobDetailRequestJobInfoAddress setLatitude(String latitude) {
            this.latitude = latitude;
            return this;
        }
        public String getLatitude() {
            return this.latitude;
        }

        public CollectRecruitJobDetailRequestJobInfoAddress setLongitude(String longitude) {
            this.longitude = longitude;
            return this;
        }
        public String getLongitude() {
            return this.longitude;
        }

        public CollectRecruitJobDetailRequestJobInfoAddress setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CollectRecruitJobDetailRequestJobInfoAddress setProvinceCode(String provinceCode) {
            this.provinceCode = provinceCode;
            return this;
        }
        public String getProvinceCode() {
            return this.provinceCode;
        }

    }

    public static class CollectRecruitJobDetailRequestJobInfoFullTimeInfo extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>20</p>
         */
        @NameInMap("maxJobExperience")
        public String maxJobExperience;

        /**
         * <strong>example:</strong>
         * <p>2</p>
         */
        @NameInMap("minJobExperience")
        public String minJobExperience;

        /**
         * <strong>example:</strong>
         * <p>12</p>
         */
        @NameInMap("salaryMonth")
        public String salaryMonth;

        public static CollectRecruitJobDetailRequestJobInfoFullTimeInfo build(java.util.Map<String, ?> map) throws Exception {
            CollectRecruitJobDetailRequestJobInfoFullTimeInfo self = new CollectRecruitJobDetailRequestJobInfoFullTimeInfo();
            return TeaModel.build(map, self);
        }

        public CollectRecruitJobDetailRequestJobInfoFullTimeInfo setMaxJobExperience(String maxJobExperience) {
            this.maxJobExperience = maxJobExperience;
            return this;
        }
        public String getMaxJobExperience() {
            return this.maxJobExperience;
        }

        public CollectRecruitJobDetailRequestJobInfoFullTimeInfo setMinJobExperience(String minJobExperience) {
            this.minJobExperience = minJobExperience;
            return this;
        }
        public String getMinJobExperience() {
            return this.minJobExperience;
        }

        public CollectRecruitJobDetailRequestJobInfoFullTimeInfo setSalaryMonth(String salaryMonth) {
            this.salaryMonth = salaryMonth;
            return this;
        }
        public String getSalaryMonth() {
            return this.salaryMonth;
        }

    }

    public static class CollectRecruitJobDetailRequestJobInfoPartTimeInfo extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>158****8718</p>
         */
        @NameInMap("contactNumber")
        public String contactNumber;

        /**
         * <strong>example:</strong>
         * <p>MONTH</p>
         */
        @NameInMap("salaryPeriod")
        public String salaryPeriod;

        /**
         * <strong>example:</strong>
         * <p>MONTH</p>
         */
        @NameInMap("settleType")
        public String settleType;

        /**
         * <strong>example:</strong>
         * <p>N</p>
         */
        @NameInMap("specifyWorkDate")
        public String specifyWorkDate;

        /**
         * <strong>example:</strong>
         * <p>N</p>
         */
        @NameInMap("specifyWorkTime")
        public String specifyWorkTime;

        /**
         * <strong>example:</strong>
         * <p>480</p>
         */
        @NameInMap("workBeginTimeMin")
        public String workBeginTimeMin;

        /**
         * <strong>example:</strong>
         * <p>WORKDAY</p>
         */
        @NameInMap("workDateType")
        public String workDateType;

        /**
         * <strong>example:</strong>
         * <p>2024-02-18</p>
         */
        @NameInMap("workEndDate")
        public String workEndDate;

        /**
         * <strong>example:</strong>
         * <p>1080</p>
         */
        @NameInMap("workEndTimeMin")
        public String workEndTimeMin;

        /**
         * <strong>example:</strong>
         * <p>2023-02-18</p>
         */
        @NameInMap("workStartDate")
        public String workStartDate;

        public static CollectRecruitJobDetailRequestJobInfoPartTimeInfo build(java.util.Map<String, ?> map) throws Exception {
            CollectRecruitJobDetailRequestJobInfoPartTimeInfo self = new CollectRecruitJobDetailRequestJobInfoPartTimeInfo();
            return TeaModel.build(map, self);
        }

        public CollectRecruitJobDetailRequestJobInfoPartTimeInfo setContactNumber(String contactNumber) {
            this.contactNumber = contactNumber;
            return this;
        }
        public String getContactNumber() {
            return this.contactNumber;
        }

        public CollectRecruitJobDetailRequestJobInfoPartTimeInfo setSalaryPeriod(String salaryPeriod) {
            this.salaryPeriod = salaryPeriod;
            return this;
        }
        public String getSalaryPeriod() {
            return this.salaryPeriod;
        }

        public CollectRecruitJobDetailRequestJobInfoPartTimeInfo setSettleType(String settleType) {
            this.settleType = settleType;
            return this;
        }
        public String getSettleType() {
            return this.settleType;
        }

        public CollectRecruitJobDetailRequestJobInfoPartTimeInfo setSpecifyWorkDate(String specifyWorkDate) {
            this.specifyWorkDate = specifyWorkDate;
            return this;
        }
        public String getSpecifyWorkDate() {
            return this.specifyWorkDate;
        }

        public CollectRecruitJobDetailRequestJobInfoPartTimeInfo setSpecifyWorkTime(String specifyWorkTime) {
            this.specifyWorkTime = specifyWorkTime;
            return this;
        }
        public String getSpecifyWorkTime() {
            return this.specifyWorkTime;
        }

        public CollectRecruitJobDetailRequestJobInfoPartTimeInfo setWorkBeginTimeMin(String workBeginTimeMin) {
            this.workBeginTimeMin = workBeginTimeMin;
            return this;
        }
        public String getWorkBeginTimeMin() {
            return this.workBeginTimeMin;
        }

        public CollectRecruitJobDetailRequestJobInfoPartTimeInfo setWorkDateType(String workDateType) {
            this.workDateType = workDateType;
            return this;
        }
        public String getWorkDateType() {
            return this.workDateType;
        }

        public CollectRecruitJobDetailRequestJobInfoPartTimeInfo setWorkEndDate(String workEndDate) {
            this.workEndDate = workEndDate;
            return this;
        }
        public String getWorkEndDate() {
            return this.workEndDate;
        }

        public CollectRecruitJobDetailRequestJobInfoPartTimeInfo setWorkEndTimeMin(String workEndTimeMin) {
            this.workEndTimeMin = workEndTimeMin;
            return this;
        }
        public String getWorkEndTimeMin() {
            return this.workEndTimeMin;
        }

        public CollectRecruitJobDetailRequestJobInfoPartTimeInfo setWorkStartDate(String workStartDate) {
            this.workStartDate = workStartDate;
            return this;
        }
        public String getWorkStartDate() {
            return this.workStartDate;
        }

    }

    public static class CollectRecruitJobDetailRequestJobInfo extends TeaModel {
        @NameInMap("address")
        public CollectRecruitJobDetailRequestJobInfoAddress address;

        /**
         * <strong>example:</strong>
         * <p>C10001</p>
         */
        @NameInMap("category")
        public String category;

        /**
         * <strong>example:</strong>
         * <p>园艺师职位描述</p>
         */
        @NameInMap("description")
        public String description;

        @NameInMap("extInfo")
        public String extInfo;

        @NameInMap("fullTimeInfo")
        public CollectRecruitJobDetailRequestJobInfoFullTimeInfo fullTimeInfo;

        /**
         * <strong>example:</strong>
         * <p>20</p>
         */
        @NameInMap("headCount")
        public String headCount;

        /**
         * <strong>example:</strong>
         * <p>FULL-TIME</p>
         */
        @NameInMap("jobNature")
        public String jobNature;

        @NameInMap("jobTags")
        public java.util.List<String> jobTags;

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
         * <p>园艺师</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>jobIdxxxxxxx</p>
         */
        @NameInMap("outJobId")
        public String outJobId;

        @NameInMap("partTimeInfo")
        public CollectRecruitJobDetailRequestJobInfoPartTimeInfo partTimeInfo;

        /**
         * <strong>example:</strong>
         * <p>高中</p>
         */
        @NameInMap("requiredEdu")
        public String requiredEdu;

        public static CollectRecruitJobDetailRequestJobInfo build(java.util.Map<String, ?> map) throws Exception {
            CollectRecruitJobDetailRequestJobInfo self = new CollectRecruitJobDetailRequestJobInfo();
            return TeaModel.build(map, self);
        }

        public CollectRecruitJobDetailRequestJobInfo setAddress(CollectRecruitJobDetailRequestJobInfoAddress address) {
            this.address = address;
            return this;
        }
        public CollectRecruitJobDetailRequestJobInfoAddress getAddress() {
            return this.address;
        }

        public CollectRecruitJobDetailRequestJobInfo setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public CollectRecruitJobDetailRequestJobInfo setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public CollectRecruitJobDetailRequestJobInfo setExtInfo(String extInfo) {
            this.extInfo = extInfo;
            return this;
        }
        public String getExtInfo() {
            return this.extInfo;
        }

        public CollectRecruitJobDetailRequestJobInfo setFullTimeInfo(CollectRecruitJobDetailRequestJobInfoFullTimeInfo fullTimeInfo) {
            this.fullTimeInfo = fullTimeInfo;
            return this;
        }
        public CollectRecruitJobDetailRequestJobInfoFullTimeInfo getFullTimeInfo() {
            return this.fullTimeInfo;
        }

        public CollectRecruitJobDetailRequestJobInfo setHeadCount(String headCount) {
            this.headCount = headCount;
            return this;
        }
        public String getHeadCount() {
            return this.headCount;
        }

        public CollectRecruitJobDetailRequestJobInfo setJobNature(String jobNature) {
            this.jobNature = jobNature;
            return this;
        }
        public String getJobNature() {
            return this.jobNature;
        }

        public CollectRecruitJobDetailRequestJobInfo setJobTags(java.util.List<String> jobTags) {
            this.jobTags = jobTags;
            return this;
        }
        public java.util.List<String> getJobTags() {
            return this.jobTags;
        }

        public CollectRecruitJobDetailRequestJobInfo setMaxSalary(String maxSalary) {
            this.maxSalary = maxSalary;
            return this;
        }
        public String getMaxSalary() {
            return this.maxSalary;
        }

        public CollectRecruitJobDetailRequestJobInfo setMinSalary(String minSalary) {
            this.minSalary = minSalary;
            return this;
        }
        public String getMinSalary() {
            return this.minSalary;
        }

        public CollectRecruitJobDetailRequestJobInfo setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CollectRecruitJobDetailRequestJobInfo setOutJobId(String outJobId) {
            this.outJobId = outJobId;
            return this;
        }
        public String getOutJobId() {
            return this.outJobId;
        }

        public CollectRecruitJobDetailRequestJobInfo setPartTimeInfo(CollectRecruitJobDetailRequestJobInfoPartTimeInfo partTimeInfo) {
            this.partTimeInfo = partTimeInfo;
            return this;
        }
        public CollectRecruitJobDetailRequestJobInfoPartTimeInfo getPartTimeInfo() {
            return this.partTimeInfo;
        }

        public CollectRecruitJobDetailRequestJobInfo setRequiredEdu(String requiredEdu) {
            this.requiredEdu = requiredEdu;
            return this;
        }
        public String getRequiredEdu() {
            return this.requiredEdu;
        }

    }

    public static class CollectRecruitJobDetailRequestRecruitUserInfo extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>{&quot;sex&quot;:&quot;male&quot;}</p>
         */
        @NameInMap("extInfo")
        public String extInfo;

        /**
         * <strong>example:</strong>
         * <p>userxxxxx</p>
         */
        @NameInMap("outUserId")
        public String outUserId;

        /**
         * <strong>example:</strong>
         * <p>158****8717</p>
         */
        @NameInMap("userMobile")
        public String userMobile;

        /**
         * <strong>example:</strong>
         * <p>陈*</p>
         */
        @NameInMap("userName")
        public String userName;

        public static CollectRecruitJobDetailRequestRecruitUserInfo build(java.util.Map<String, ?> map) throws Exception {
            CollectRecruitJobDetailRequestRecruitUserInfo self = new CollectRecruitJobDetailRequestRecruitUserInfo();
            return TeaModel.build(map, self);
        }

        public CollectRecruitJobDetailRequestRecruitUserInfo setExtInfo(String extInfo) {
            this.extInfo = extInfo;
            return this;
        }
        public String getExtInfo() {
            return this.extInfo;
        }

        public CollectRecruitJobDetailRequestRecruitUserInfo setOutUserId(String outUserId) {
            this.outUserId = outUserId;
            return this;
        }
        public String getOutUserId() {
            return this.outUserId;
        }

        public CollectRecruitJobDetailRequestRecruitUserInfo setUserMobile(String userMobile) {
            this.userMobile = userMobile;
            return this;
        }
        public String getUserMobile() {
            return this.userMobile;
        }

        public CollectRecruitJobDetailRequestRecruitUserInfo setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

    }

}
