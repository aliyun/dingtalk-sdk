// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportRegistRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<HrbrainImportRegistRequestBody> body;

    @NameInMap("corpId")
    public String corpId;

    public static HrbrainImportRegistRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportRegistRequest self = new HrbrainImportRegistRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainImportRegistRequest setBody(java.util.List<HrbrainImportRegistRequestBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<HrbrainImportRegistRequestBody> getBody() {
        return this.body;
    }

    public HrbrainImportRegistRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public static class HrbrainImportRegistRequestBody extends TeaModel {
        @NameInMap("deptName")
        public String deptName;

        @NameInMap("deptNo")
        public String deptNo;

        @NameInMap("empSource")
        public String empSource;

        @NameInMap("empType")
        public String empType;

        @NameInMap("extendInfo")
        public java.util.Map<String, ?> extendInfo;

        @NameInMap("jobCodeName")
        public String jobCodeName;

        @NameInMap("jobLevel")
        public String jobLevel;

        @NameInMap("name")
        public String name;

        @NameInMap("postName")
        public String postName;

        @NameInMap("registDate")
        public String registDate;

        @NameInMap("superName")
        public String superName;

        @NameInMap("workLocAddr")
        public String workLocAddr;

        @NameInMap("workNo")
        public String workNo;

        public static HrbrainImportRegistRequestBody build(java.util.Map<String, ?> map) throws Exception {
            HrbrainImportRegistRequestBody self = new HrbrainImportRegistRequestBody();
            return TeaModel.build(map, self);
        }

        public HrbrainImportRegistRequestBody setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public HrbrainImportRegistRequestBody setDeptNo(String deptNo) {
            this.deptNo = deptNo;
            return this;
        }
        public String getDeptNo() {
            return this.deptNo;
        }

        public HrbrainImportRegistRequestBody setEmpSource(String empSource) {
            this.empSource = empSource;
            return this;
        }
        public String getEmpSource() {
            return this.empSource;
        }

        public HrbrainImportRegistRequestBody setEmpType(String empType) {
            this.empType = empType;
            return this;
        }
        public String getEmpType() {
            return this.empType;
        }

        public HrbrainImportRegistRequestBody setExtendInfo(java.util.Map<String, ?> extendInfo) {
            this.extendInfo = extendInfo;
            return this;
        }
        public java.util.Map<String, ?> getExtendInfo() {
            return this.extendInfo;
        }

        public HrbrainImportRegistRequestBody setJobCodeName(String jobCodeName) {
            this.jobCodeName = jobCodeName;
            return this;
        }
        public String getJobCodeName() {
            return this.jobCodeName;
        }

        public HrbrainImportRegistRequestBody setJobLevel(String jobLevel) {
            this.jobLevel = jobLevel;
            return this;
        }
        public String getJobLevel() {
            return this.jobLevel;
        }

        public HrbrainImportRegistRequestBody setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public HrbrainImportRegistRequestBody setPostName(String postName) {
            this.postName = postName;
            return this;
        }
        public String getPostName() {
            return this.postName;
        }

        public HrbrainImportRegistRequestBody setRegistDate(String registDate) {
            this.registDate = registDate;
            return this;
        }
        public String getRegistDate() {
            return this.registDate;
        }

        public HrbrainImportRegistRequestBody setSuperName(String superName) {
            this.superName = superName;
            return this;
        }
        public String getSuperName() {
            return this.superName;
        }

        public HrbrainImportRegistRequestBody setWorkLocAddr(String workLocAddr) {
            this.workLocAddr = workLocAddr;
            return this;
        }
        public String getWorkLocAddr() {
            return this.workLocAddr;
        }

        public HrbrainImportRegistRequestBody setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
