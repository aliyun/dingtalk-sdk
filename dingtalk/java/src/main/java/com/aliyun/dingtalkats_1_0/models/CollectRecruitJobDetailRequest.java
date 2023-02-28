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
     * <p>业务标识，目前固定为ddats</p>
     */
    @NameInMap("channel")
    public String channel;

    @NameInMap("jonInfo")
    public CollectRecruitJobDetailRequestJonInfo jonInfo;

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

    public CollectRecruitJobDetailRequest setJonInfo(CollectRecruitJobDetailRequestJonInfo jonInfo) {
        this.jonInfo = jonInfo;
        return this;
    }
    public CollectRecruitJobDetailRequestJonInfo getJonInfo() {
        return this.jonInfo;
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

    public static class CollectRecruitJobDetailRequestJonInfoAddress extends TeaModel {
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

        public static CollectRecruitJobDetailRequestJonInfoAddress build(java.util.Map<String, ?> map) throws Exception {
            CollectRecruitJobDetailRequestJonInfoAddress self = new CollectRecruitJobDetailRequestJonInfoAddress();
            return TeaModel.build(map, self);
        }

        public CollectRecruitJobDetailRequestJonInfoAddress setCityCode(String cityCode) {
            this.cityCode = cityCode;
            return this;
        }
        public String getCityCode() {
            return this.cityCode;
        }

        public CollectRecruitJobDetailRequestJonInfoAddress setDetail(String detail) {
            this.detail = detail;
            return this;
        }
        public String getDetail() {
            return this.detail;
        }

        public CollectRecruitJobDetailRequestJonInfoAddress setDistrictCode(String districtCode) {
            this.districtCode = districtCode;
            return this;
        }
        public String getDistrictCode() {
            return this.districtCode;
        }

        public CollectRecruitJobDetailRequestJonInfoAddress setLatitude(String latitude) {
            this.latitude = latitude;
            return this;
        }
        public String getLatitude() {
            return this.latitude;
        }

        public CollectRecruitJobDetailRequestJonInfoAddress setLongitude(String longitude) {
            this.longitude = longitude;
            return this;
        }
        public String getLongitude() {
            return this.longitude;
        }

        public CollectRecruitJobDetailRequestJonInfoAddress setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CollectRecruitJobDetailRequestJonInfoAddress setProvinceCode(String provinceCode) {
            this.provinceCode = provinceCode;
            return this;
        }
        public String getProvinceCode() {
            return this.provinceCode;
        }

    }

    public static class CollectRecruitJobDetailRequestJonInfoFullTimeInfo extends TeaModel {
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

        public static CollectRecruitJobDetailRequestJonInfoFullTimeInfo build(java.util.Map<String, ?> map) throws Exception {
            CollectRecruitJobDetailRequestJonInfoFullTimeInfo self = new CollectRecruitJobDetailRequestJonInfoFullTimeInfo();
            return TeaModel.build(map, self);
        }

        public CollectRecruitJobDetailRequestJonInfoFullTimeInfo setMaxJobExperience(String maxJobExperience) {
            this.maxJobExperience = maxJobExperience;
            return this;
        }
        public String getMaxJobExperience() {
            return this.maxJobExperience;
        }

        public CollectRecruitJobDetailRequestJonInfoFullTimeInfo setMinJobExperience(String minJobExperience) {
            this.minJobExperience = minJobExperience;
            return this;
        }
        public String getMinJobExperience() {
            return this.minJobExperience;
        }

        public CollectRecruitJobDetailRequestJonInfoFullTimeInfo setSalaryMonth(String salaryMonth) {
            this.salaryMonth = salaryMonth;
            return this;
        }
        public String getSalaryMonth() {
            return this.salaryMonth;
        }

    }

    public static class CollectRecruitJobDetailRequestJonInfoPartTimeInfo extends TeaModel {
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

        public static CollectRecruitJobDetailRequestJonInfoPartTimeInfo build(java.util.Map<String, ?> map) throws Exception {
            CollectRecruitJobDetailRequestJonInfoPartTimeInfo self = new CollectRecruitJobDetailRequestJonInfoPartTimeInfo();
            return TeaModel.build(map, self);
        }

        public CollectRecruitJobDetailRequestJonInfoPartTimeInfo setContactNumber(String contactNumber) {
            this.contactNumber = contactNumber;
            return this;
        }
        public String getContactNumber() {
            return this.contactNumber;
        }

        public CollectRecruitJobDetailRequestJonInfoPartTimeInfo setSalaryPeriod(String salaryPeriod) {
            this.salaryPeriod = salaryPeriod;
            return this;
        }
        public String getSalaryPeriod() {
            return this.salaryPeriod;
        }

        public CollectRecruitJobDetailRequestJonInfoPartTimeInfo setSettleType(String settleType) {
            this.settleType = settleType;
            return this;
        }
        public String getSettleType() {
            return this.settleType;
        }

        public CollectRecruitJobDetailRequestJonInfoPartTimeInfo setSpecifyWorkDate(String specifyWorkDate) {
            this.specifyWorkDate = specifyWorkDate;
            return this;
        }
        public String getSpecifyWorkDate() {
            return this.specifyWorkDate;
        }

        public CollectRecruitJobDetailRequestJonInfoPartTimeInfo setSpecifyWorkTime(String specifyWorkTime) {
            this.specifyWorkTime = specifyWorkTime;
            return this;
        }
        public String getSpecifyWorkTime() {
            return this.specifyWorkTime;
        }

        public CollectRecruitJobDetailRequestJonInfoPartTimeInfo setWorkBeginTimeMin(String workBeginTimeMin) {
            this.workBeginTimeMin = workBeginTimeMin;
            return this;
        }
        public String getWorkBeginTimeMin() {
            return this.workBeginTimeMin;
        }

        public CollectRecruitJobDetailRequestJonInfoPartTimeInfo setWorkDateType(String workDateType) {
            this.workDateType = workDateType;
            return this;
        }
        public String getWorkDateType() {
            return this.workDateType;
        }

        public CollectRecruitJobDetailRequestJonInfoPartTimeInfo setWorkEndDate(String workEndDate) {
            this.workEndDate = workEndDate;
            return this;
        }
        public String getWorkEndDate() {
            return this.workEndDate;
        }

        public CollectRecruitJobDetailRequestJonInfoPartTimeInfo setWorkEndTimeMin(String workEndTimeMin) {
            this.workEndTimeMin = workEndTimeMin;
            return this;
        }
        public String getWorkEndTimeMin() {
            return this.workEndTimeMin;
        }

        public CollectRecruitJobDetailRequestJonInfoPartTimeInfo setWorkStartDate(String workStartDate) {
            this.workStartDate = workStartDate;
            return this;
        }
        public String getWorkStartDate() {
            return this.workStartDate;
        }

    }

    public static class CollectRecruitJobDetailRequestJonInfo extends TeaModel {
        /**
         * <p>地址信息</p>
         */
        @NameInMap("address")
        public CollectRecruitJobDetailRequestJonInfoAddress address;

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
        public CollectRecruitJobDetailRequestJonInfoFullTimeInfo fullTimeInfo;

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
        public CollectRecruitJobDetailRequestJonInfoPartTimeInfo partTimeInfo;

        /**
         * <p>学历要求</p>
         */
        @NameInMap("requiredEdu")
        public String requiredEdu;

        public static CollectRecruitJobDetailRequestJonInfo build(java.util.Map<String, ?> map) throws Exception {
            CollectRecruitJobDetailRequestJonInfo self = new CollectRecruitJobDetailRequestJonInfo();
            return TeaModel.build(map, self);
        }

        public CollectRecruitJobDetailRequestJonInfo setAddress(CollectRecruitJobDetailRequestJonInfoAddress address) {
            this.address = address;
            return this;
        }
        public CollectRecruitJobDetailRequestJonInfoAddress getAddress() {
            return this.address;
        }

        public CollectRecruitJobDetailRequestJonInfo setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public CollectRecruitJobDetailRequestJonInfo setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public CollectRecruitJobDetailRequestJonInfo setExtInfo(String extInfo) {
            this.extInfo = extInfo;
            return this;
        }
        public String getExtInfo() {
            return this.extInfo;
        }

        public CollectRecruitJobDetailRequestJonInfo setFullTimeInfo(CollectRecruitJobDetailRequestJonInfoFullTimeInfo fullTimeInfo) {
            this.fullTimeInfo = fullTimeInfo;
            return this;
        }
        public CollectRecruitJobDetailRequestJonInfoFullTimeInfo getFullTimeInfo() {
            return this.fullTimeInfo;
        }

        public CollectRecruitJobDetailRequestJonInfo setHeadCount(String headCount) {
            this.headCount = headCount;
            return this;
        }
        public String getHeadCount() {
            return this.headCount;
        }

        public CollectRecruitJobDetailRequestJonInfo setJobNature(String jobNature) {
            this.jobNature = jobNature;
            return this;
        }
        public String getJobNature() {
            return this.jobNature;
        }

        public CollectRecruitJobDetailRequestJonInfo setJobTags(java.util.List<String> jobTags) {
            this.jobTags = jobTags;
            return this;
        }
        public java.util.List<String> getJobTags() {
            return this.jobTags;
        }

        public CollectRecruitJobDetailRequestJonInfo setMaxSalary(String maxSalary) {
            this.maxSalary = maxSalary;
            return this;
        }
        public String getMaxSalary() {
            return this.maxSalary;
        }

        public CollectRecruitJobDetailRequestJonInfo setMinSalary(String minSalary) {
            this.minSalary = minSalary;
            return this;
        }
        public String getMinSalary() {
            return this.minSalary;
        }

        public CollectRecruitJobDetailRequestJonInfo setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CollectRecruitJobDetailRequestJonInfo setOutJobId(String outJobId) {
            this.outJobId = outJobId;
            return this;
        }
        public String getOutJobId() {
            return this.outJobId;
        }

        public CollectRecruitJobDetailRequestJonInfo setPartTimeInfo(CollectRecruitJobDetailRequestJonInfoPartTimeInfo partTimeInfo) {
            this.partTimeInfo = partTimeInfo;
            return this;
        }
        public CollectRecruitJobDetailRequestJonInfoPartTimeInfo getPartTimeInfo() {
            return this.partTimeInfo;
        }

        public CollectRecruitJobDetailRequestJonInfo setRequiredEdu(String requiredEdu) {
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
