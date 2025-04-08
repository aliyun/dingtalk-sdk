// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportRegularRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<HrbrainImportRegularRequestBody> body;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    public static HrbrainImportRegularRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportRegularRequest self = new HrbrainImportRegularRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainImportRegularRequest setBody(java.util.List<HrbrainImportRegularRequestBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<HrbrainImportRegularRequestBody> getBody() {
        return this.body;
    }

    public HrbrainImportRegularRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public static class HrbrainImportRegularRequestBody extends TeaModel {
        @NameInMap("deptName")
        public String deptName;

        @NameInMap("deptNo")
        public String deptNo;

        @NameInMap("extendInfo")
        public java.util.Map<String, ?> extendInfo;

        @NameInMap("jobCodeName")
        public String jobCodeName;

        @NameInMap("jobLevel")
        public String jobLevel;

        @NameInMap("name")
        public String name;

        @NameInMap("planRegularDate")
        public String planRegularDate;

        @NameInMap("postName")
        public String postName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("regularDate")
        public String regularDate;

        @NameInMap("superEmpId")
        public String superEmpId;

        @NameInMap("superName")
        public String superName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("workNo")
        public String workNo;

        public static HrbrainImportRegularRequestBody build(java.util.Map<String, ?> map) throws Exception {
            HrbrainImportRegularRequestBody self = new HrbrainImportRegularRequestBody();
            return TeaModel.build(map, self);
        }

        public HrbrainImportRegularRequestBody setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public HrbrainImportRegularRequestBody setDeptNo(String deptNo) {
            this.deptNo = deptNo;
            return this;
        }
        public String getDeptNo() {
            return this.deptNo;
        }

        public HrbrainImportRegularRequestBody setExtendInfo(java.util.Map<String, ?> extendInfo) {
            this.extendInfo = extendInfo;
            return this;
        }
        public java.util.Map<String, ?> getExtendInfo() {
            return this.extendInfo;
        }

        public HrbrainImportRegularRequestBody setJobCodeName(String jobCodeName) {
            this.jobCodeName = jobCodeName;
            return this;
        }
        public String getJobCodeName() {
            return this.jobCodeName;
        }

        public HrbrainImportRegularRequestBody setJobLevel(String jobLevel) {
            this.jobLevel = jobLevel;
            return this;
        }
        public String getJobLevel() {
            return this.jobLevel;
        }

        public HrbrainImportRegularRequestBody setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public HrbrainImportRegularRequestBody setPlanRegularDate(String planRegularDate) {
            this.planRegularDate = planRegularDate;
            return this;
        }
        public String getPlanRegularDate() {
            return this.planRegularDate;
        }

        public HrbrainImportRegularRequestBody setPostName(String postName) {
            this.postName = postName;
            return this;
        }
        public String getPostName() {
            return this.postName;
        }

        public HrbrainImportRegularRequestBody setRegularDate(String regularDate) {
            this.regularDate = regularDate;
            return this;
        }
        public String getRegularDate() {
            return this.regularDate;
        }

        public HrbrainImportRegularRequestBody setSuperEmpId(String superEmpId) {
            this.superEmpId = superEmpId;
            return this;
        }
        public String getSuperEmpId() {
            return this.superEmpId;
        }

        public HrbrainImportRegularRequestBody setSuperName(String superName) {
            this.superName = superName;
            return this;
        }
        public String getSuperName() {
            return this.superName;
        }

        public HrbrainImportRegularRequestBody setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
