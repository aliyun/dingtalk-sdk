// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class CfEmploymentRecordResp extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>666</p>
     */
    @NameInMap("deptCode")
    public String deptCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>开发部</p>
     */
    @NameInMap("deptName")
    public String deptName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>3</p>
     */
    @NameInMap("employeeStatus")
    public String employeeStatus;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1652198400000</p>
     */
    @NameInMap("endDate")
    public String endDate;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("isLatestRecord")
    public Boolean isLatestRecord;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>P1</p>
     */
    @NameInMap("jobLevelName")
    public String jobLevelName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>23</p>
     */
    @NameInMap("jobPositionCode")
    public String jobPositionCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>Java开发工程师</p>
     */
    @NameInMap("jobPositionName")
    public String jobPositionName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>343</p>
     */
    @NameInMap("jobPostCode")
    public String jobPostCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>技术岗位</p>
     */
    @NameInMap("jobPostName")
    public String jobPostName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("serviceStatus")
    public String serviceStatus;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>5</p>
     */
    @NameInMap("serviceType")
    public String serviceType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1638892800000</p>
     */
    @NameInMap("startDate")
    public String startDate;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123456</p>
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
