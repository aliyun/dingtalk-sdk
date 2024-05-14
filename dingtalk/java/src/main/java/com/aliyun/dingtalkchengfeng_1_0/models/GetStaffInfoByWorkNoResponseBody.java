// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetStaffInfoByWorkNoResponseBody extends TeaModel {
    @NameInMap("content")
    public GetStaffInfoByWorkNoResponseBodyContent content;

    @NameInMap("requestId")
    public String requestId;

    public static GetStaffInfoByWorkNoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetStaffInfoByWorkNoResponseBody self = new GetStaffInfoByWorkNoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetStaffInfoByWorkNoResponseBody setContent(GetStaffInfoByWorkNoResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public GetStaffInfoByWorkNoResponseBodyContent getContent() {
        return this.content;
    }

    public GetStaffInfoByWorkNoResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public static class GetStaffInfoByWorkNoResponseBodyContent extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("deptCode")
        public String deptCode;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("deptName")
        public String deptName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("email")
        public String email;

        @NameInMap("employType")
        public String employType;

        @NameInMap("employeeStatus")
        public String employeeStatus;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("jobLevelName")
        public String jobLevelName;

        @NameInMap("jobPositionCode")
        public String jobPositionCode;

        @NameInMap("jobPositionName")
        public String jobPositionName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("jobPostCode")
        public String jobPostCode;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("jobPostName")
        public String jobPostName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("mobile")
        public String mobile;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("nickName")
        public String nickName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("workNumbers")
        public String workNumbers;

        public static GetStaffInfoByWorkNoResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            GetStaffInfoByWorkNoResponseBodyContent self = new GetStaffInfoByWorkNoResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public GetStaffInfoByWorkNoResponseBodyContent setDeptCode(String deptCode) {
            this.deptCode = deptCode;
            return this;
        }
        public String getDeptCode() {
            return this.deptCode;
        }

        public GetStaffInfoByWorkNoResponseBodyContent setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public GetStaffInfoByWorkNoResponseBodyContent setEmail(String email) {
            this.email = email;
            return this;
        }
        public String getEmail() {
            return this.email;
        }

        public GetStaffInfoByWorkNoResponseBodyContent setEmployType(String employType) {
            this.employType = employType;
            return this;
        }
        public String getEmployType() {
            return this.employType;
        }

        public GetStaffInfoByWorkNoResponseBodyContent setEmployeeStatus(String employeeStatus) {
            this.employeeStatus = employeeStatus;
            return this;
        }
        public String getEmployeeStatus() {
            return this.employeeStatus;
        }

        public GetStaffInfoByWorkNoResponseBodyContent setJobLevelName(String jobLevelName) {
            this.jobLevelName = jobLevelName;
            return this;
        }
        public String getJobLevelName() {
            return this.jobLevelName;
        }

        public GetStaffInfoByWorkNoResponseBodyContent setJobPositionCode(String jobPositionCode) {
            this.jobPositionCode = jobPositionCode;
            return this;
        }
        public String getJobPositionCode() {
            return this.jobPositionCode;
        }

        public GetStaffInfoByWorkNoResponseBodyContent setJobPositionName(String jobPositionName) {
            this.jobPositionName = jobPositionName;
            return this;
        }
        public String getJobPositionName() {
            return this.jobPositionName;
        }

        public GetStaffInfoByWorkNoResponseBodyContent setJobPostCode(String jobPostCode) {
            this.jobPostCode = jobPostCode;
            return this;
        }
        public String getJobPostCode() {
            return this.jobPostCode;
        }

        public GetStaffInfoByWorkNoResponseBodyContent setJobPostName(String jobPostName) {
            this.jobPostName = jobPostName;
            return this;
        }
        public String getJobPostName() {
            return this.jobPostName;
        }

        public GetStaffInfoByWorkNoResponseBodyContent setMobile(String mobile) {
            this.mobile = mobile;
            return this;
        }
        public String getMobile() {
            return this.mobile;
        }

        public GetStaffInfoByWorkNoResponseBodyContent setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetStaffInfoByWorkNoResponseBodyContent setNickName(String nickName) {
            this.nickName = nickName;
            return this;
        }
        public String getNickName() {
            return this.nickName;
        }

        public GetStaffInfoByWorkNoResponseBodyContent setWorkNumbers(String workNumbers) {
            this.workNumbers = workNumbers;
            return this;
        }
        public String getWorkNumbers() {
            return this.workNumbers;
        }

    }

}
