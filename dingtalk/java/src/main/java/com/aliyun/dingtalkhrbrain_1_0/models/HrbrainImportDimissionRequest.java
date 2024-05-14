// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportDimissionRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("body")
    public java.util.List<HrbrainImportDimissionRequestBody> body;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    public static HrbrainImportDimissionRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportDimissionRequest self = new HrbrainImportDimissionRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainImportDimissionRequest setBody(java.util.List<HrbrainImportDimissionRequestBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<HrbrainImportDimissionRequestBody> getBody() {
        return this.body;
    }

    public HrbrainImportDimissionRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public static class HrbrainImportDimissionRequestBody extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("deptName")
        public String deptName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("deptNo")
        public String deptNo;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("dimissionDate")
        public String dimissionDate;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("dimissionReaasonDesc")
        public String dimissionReaasonDesc;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("dimissionReason")
        public String dimissionReason;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("empType")
        public String empType;

        @NameInMap("extendInfo")
        public java.util.Map<String, ?> extendInfo;

        @NameInMap("jobCodeName")
        public String jobCodeName;

        @NameInMap("jobLevel")
        public String jobLevel;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        @NameInMap("postName")
        public String postName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("superName")
        public String superName;

        @NameInMap("workLocAddr")
        public String workLocAddr;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("workNo")
        public String workNo;

        public static HrbrainImportDimissionRequestBody build(java.util.Map<String, ?> map) throws Exception {
            HrbrainImportDimissionRequestBody self = new HrbrainImportDimissionRequestBody();
            return TeaModel.build(map, self);
        }

        public HrbrainImportDimissionRequestBody setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public HrbrainImportDimissionRequestBody setDeptNo(String deptNo) {
            this.deptNo = deptNo;
            return this;
        }
        public String getDeptNo() {
            return this.deptNo;
        }

        public HrbrainImportDimissionRequestBody setDimissionDate(String dimissionDate) {
            this.dimissionDate = dimissionDate;
            return this;
        }
        public String getDimissionDate() {
            return this.dimissionDate;
        }

        public HrbrainImportDimissionRequestBody setDimissionReaasonDesc(String dimissionReaasonDesc) {
            this.dimissionReaasonDesc = dimissionReaasonDesc;
            return this;
        }
        public String getDimissionReaasonDesc() {
            return this.dimissionReaasonDesc;
        }

        public HrbrainImportDimissionRequestBody setDimissionReason(String dimissionReason) {
            this.dimissionReason = dimissionReason;
            return this;
        }
        public String getDimissionReason() {
            return this.dimissionReason;
        }

        public HrbrainImportDimissionRequestBody setEmpType(String empType) {
            this.empType = empType;
            return this;
        }
        public String getEmpType() {
            return this.empType;
        }

        public HrbrainImportDimissionRequestBody setExtendInfo(java.util.Map<String, ?> extendInfo) {
            this.extendInfo = extendInfo;
            return this;
        }
        public java.util.Map<String, ?> getExtendInfo() {
            return this.extendInfo;
        }

        public HrbrainImportDimissionRequestBody setJobCodeName(String jobCodeName) {
            this.jobCodeName = jobCodeName;
            return this;
        }
        public String getJobCodeName() {
            return this.jobCodeName;
        }

        public HrbrainImportDimissionRequestBody setJobLevel(String jobLevel) {
            this.jobLevel = jobLevel;
            return this;
        }
        public String getJobLevel() {
            return this.jobLevel;
        }

        public HrbrainImportDimissionRequestBody setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public HrbrainImportDimissionRequestBody setPostName(String postName) {
            this.postName = postName;
            return this;
        }
        public String getPostName() {
            return this.postName;
        }

        public HrbrainImportDimissionRequestBody setSuperName(String superName) {
            this.superName = superName;
            return this;
        }
        public String getSuperName() {
            return this.superName;
        }

        public HrbrainImportDimissionRequestBody setWorkLocAddr(String workLocAddr) {
            this.workLocAddr = workLocAddr;
            return this;
        }
        public String getWorkLocAddr() {
            return this.workLocAddr;
        }

        public HrbrainImportDimissionRequestBody setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
