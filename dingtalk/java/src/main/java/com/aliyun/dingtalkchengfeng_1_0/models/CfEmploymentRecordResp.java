// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class CfEmploymentRecordResp extends TeaModel {
    /**
     * <p>部门编码</p>
     */
    @NameInMap("deptCode")
    public String deptCode;

    /**
     * <p>部门名称</p>
     */
    @NameInMap("deptName")
    public String deptName;

    /**
     * <p>人员状态(2:试用,3:正式)</p>
     */
    @NameInMap("employeeStatus")
    public String employeeStatus;

    /**
     * <p>结束时间</p>
     */
    @NameInMap("endDate")
    public String endDate;

    /**
     * <p>是否是最新任职</p>
     */
    @NameInMap("isLatestRecord")
    public Boolean isLatestRecord;

    /**
     * <p>职级名称</p>
     */
    @NameInMap("jobLevelName")
    public String jobLevelName;

    /**
     * <p>职位编码</p>
     */
    @NameInMap("jobPositionCode")
    public String jobPositionCode;

    /**
     * <p>职位名称</p>
     */
    @NameInMap("jobPositionName")
    public String jobPositionName;

    /**
     * <p>职务编码</p>
     */
    @NameInMap("jobPostCode")
    public String jobPostCode;

    /**
     * <p>职务名称</p>
     */
    @NameInMap("jobPostName")
    public String jobPostName;

    /**
     * <p>任职状态(1:任职中,2:任职结束)</p>
     */
    @NameInMap("serviceStatus")
    public String serviceStatus;

    /**
     * <p>任职类型(5:主职, 6:兼职)</p>
     */
    @NameInMap("serviceType")
    public String serviceType;

    /**
     * <p>开始时间</p>
     */
    @NameInMap("startDate")
    public String startDate;

    /**
     * <p>工号</p>
     */
    @NameInMap("workNumbers")
    public String workNumbers;

    public static CfEmploymentRecordResp build(java.util.Map<String, ?> map) throws Exception {
        CfEmploymentRecordResp self = new CfEmploymentRecordResp();
        return TeaModel.build(map, self);
    }

    public CfEmploymentRecordResp setDeptCode(String deptCode) {
        this.deptCode = deptCode;
        return this;
    }
    public String getDeptCode() {
        return this.deptCode;
    }

    public CfEmploymentRecordResp setDeptName(String deptName) {
        this.deptName = deptName;
        return this;
    }
    public String getDeptName() {
        return this.deptName;
    }

    public CfEmploymentRecordResp setEmployeeStatus(String employeeStatus) {
        this.employeeStatus = employeeStatus;
        return this;
    }
    public String getEmployeeStatus() {
        return this.employeeStatus;
    }

    public CfEmploymentRecordResp setEndDate(String endDate) {
        this.endDate = endDate;
        return this;
    }
    public String getEndDate() {
        return this.endDate;
    }

    public CfEmploymentRecordResp setIsLatestRecord(Boolean isLatestRecord) {
        this.isLatestRecord = isLatestRecord;
        return this;
    }
    public Boolean getIsLatestRecord() {
        return this.isLatestRecord;
    }

    public CfEmploymentRecordResp setJobLevelName(String jobLevelName) {
        this.jobLevelName = jobLevelName;
        return this;
    }
    public String getJobLevelName() {
        return this.jobLevelName;
    }

    public CfEmploymentRecordResp setJobPositionCode(String jobPositionCode) {
        this.jobPositionCode = jobPositionCode;
        return this;
    }
    public String getJobPositionCode() {
        return this.jobPositionCode;
    }

    public CfEmploymentRecordResp setJobPositionName(String jobPositionName) {
        this.jobPositionName = jobPositionName;
        return this;
    }
    public String getJobPositionName() {
        return this.jobPositionName;
    }

    public CfEmploymentRecordResp setJobPostCode(String jobPostCode) {
        this.jobPostCode = jobPostCode;
        return this;
    }
    public String getJobPostCode() {
        return this.jobPostCode;
    }

    public CfEmploymentRecordResp setJobPostName(String jobPostName) {
        this.jobPostName = jobPostName;
        return this;
    }
    public String getJobPostName() {
        return this.jobPostName;
    }

    public CfEmploymentRecordResp setServiceStatus(String serviceStatus) {
        this.serviceStatus = serviceStatus;
        return this;
    }
    public String getServiceStatus() {
        return this.serviceStatus;
    }

    public CfEmploymentRecordResp setServiceType(String serviceType) {
        this.serviceType = serviceType;
        return this;
    }
    public String getServiceType() {
        return this.serviceType;
    }

    public CfEmploymentRecordResp setStartDate(String startDate) {
        this.startDate = startDate;
        return this;
    }
    public String getStartDate() {
        return this.startDate;
    }

    public CfEmploymentRecordResp setWorkNumbers(String workNumbers) {
        this.workNumbers = workNumbers;
        return this;
    }
    public String getWorkNumbers() {
        return this.workNumbers;
    }

}
