// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class CollectRecruitJobDetailRequest extends TeaModel {
    /**
     * <p>业务标识，目前固定为ddats</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <p>渠道ID</p>
     */
    @NameInMap("channel")
    public String channel;

    @NameInMap("jobInfo")
    public CollectRecruitJobDetailRequestJobInfo jobInfo;

    /**
     * <p>渠道侧外部企业唯一ID</p>
     */
    @NameInMap("outCorpId")
    public String outCorpId;

    /**
     * <p>企业名称</p>
     */
    @NameInMap("outCorpName")
    public String outCorpName;

    /**
     * <p>招聘人信息</p>
     */
    @NameInMap("recruitUserInfo")
    public CollectRecruitJobDetailRequestRecruitUserInfo recruitUserInfo;

    /**
     * <p>来源</p>
     */
    @NameInMap("source")
    public String source;

    /**
     * <p>数据源更新时间</p>
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
         * <p>城市编码</p>
         */
        @NameInMap("cityCode")
        public String cityCode;

        /**
         * <p>位置详情描述</p>
         */
        @NameInMap("detail")
        public String detail;

        /**
         * <p>区县编码</p>
         */
        @NameInMap("districtCode")
        public String districtCode;

        /**
         * <p>经度（高德地图选点）</p>
         */
        @NameInMap("latitude")
        public String latitude;

        /**
         * <p>纬度（高德地图选点）</p>
         */
        @NameInMap("longitude")
        public String longitude;

        /**
         * <p>位置名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>省份编码</p>
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
         * <p>工作经验要求最高年限</p>
         */
        @NameInMap("maxJobExperience")
        public String maxJobExperience;

        /**
         * <p>工作经验要求最低年限</p>
         */
        @NameInMap("minJobExperience")
        public String minJobExperience;

        /**
         * <p>薪资发放月数</p>
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
         * <p>联系电话</p>
         */
        @NameInMap("contactNumber")
        public String contactNumber;

        /**
         * <p>薪资发放周期</p>
         */
        @NameInMap("salaryPeriod")
        public String salaryPeriod;

        /**
         * <p>薪资结算类型</p>
         */
        @NameInMap("settleType")
        public String settleType;

        /**
         * <p>是否指定工作日期</p>
         */
        @NameInMap("specifyWorkDate")
        public String specifyWorkDate;

        /**
         * <p>是否指定工作时间</p>
         */
        @NameInMap("specifyWorkTime")
        public String specifyWorkTime;

        /**
         * <p>工作开始时间</p>
         */
        @NameInMap("workBeginTimeMin")
        public String workBeginTimeMin;

        /**
         * <p>工作日期类型</p>
         */
        @NameInMap("workDateType")
        public String workDateType;

        /**
         * <p>工作结束日期</p>
         */
        @NameInMap("workEndDate")
        public String workEndDate;

        /**
         * <p>工作结束时间</p>
         */
        @NameInMap("workEndTimeMin")
        public String workEndTimeMin;

        /**
         * <p>工作开始日期</p>
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
        /**
         * <p>地址信息</p>
         */
        @NameInMap("address")
        public CollectRecruitJobDetailRequestJobInfoAddress address;

        /**
         * <p>职位分类编码</p>
         */
        @NameInMap("category")
        public String category;

        /**
         * <p>职位描述</p>
         */
        @NameInMap("description")
        public String description;

        @NameInMap("extInfo")
        public String extInfo;

        /**
         * <p>全职信息</p>
         */
        @NameInMap("fullTimeInfo")
        public CollectRecruitJobDetailRequestJobInfoFullTimeInfo fullTimeInfo;

        /**
         * <p>招聘人数</p>
         */
        @NameInMap("headCount")
        public String headCount;

        /**
         * <p>职位性质</p>
         */
        @NameInMap("jobNature")
        public String jobNature;

        /**
         * <p>职位标签，字符串列表</p>
         */
        @NameInMap("jobTags")
        public java.util.List<String> jobTags;

        /**
         * <p>最高薪资</p>
         */
        @NameInMap("maxSalary")
        public String maxSalary;

        /**
         * <p>最低薪资</p>
         */
        @NameInMap("minSalary")
        public String minSalary;

        /**
         * <p>职位名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>渠道职位ID</p>
         */
        @NameInMap("outJobId")
        public String outJobId;

        /**
         * <p>兼职信息</p>
         */
        @NameInMap("partTimeInfo")
        public CollectRecruitJobDetailRequestJobInfoPartTimeInfo partTimeInfo;

        /**
         * <p>学历要求</p>
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
         * <p>额外信息</p>
         */
        @NameInMap("extInfo")
        public String extInfo;

        /**
         * <p>招聘员工唯一ID</p>
         */
        @NameInMap("outUserId")
        public String outUserId;

        /**
         * <p>招聘员工手机号码</p>
         */
        @NameInMap("userMobile")
        public String userMobile;

        /**
         * <p>招聘员工姓名</p>
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
