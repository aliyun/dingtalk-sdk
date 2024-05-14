// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportDeptInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("body")
    public java.util.List<HrbrainImportDeptInfoRequestBody> body;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    public static HrbrainImportDeptInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportDeptInfoRequest self = new HrbrainImportDeptInfoRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainImportDeptInfoRequest setBody(java.util.List<HrbrainImportDeptInfoRequestBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<HrbrainImportDeptInfoRequestBody> getBody() {
        return this.body;
    }

    public HrbrainImportDeptInfoRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public static class HrbrainImportDeptInfoRequestBody extends TeaModel {
        @NameInMap("createDate")
        public String createDate;

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

        @NameInMap("effectiveDate")
        public String effectiveDate;

        @NameInMap("extendInfo")
        public java.util.Map<String, ?> extendInfo;

        @NameInMap("isEffective")
        public String isEffective;

        @NameInMap("superDeptName")
        public String superDeptName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("superDeptNo")
        public String superDeptNo;

        @NameInMap("superEmpId")
        public String superEmpId;

        @NameInMap("superName")
        public String superName;

        public static HrbrainImportDeptInfoRequestBody build(java.util.Map<String, ?> map) throws Exception {
            HrbrainImportDeptInfoRequestBody self = new HrbrainImportDeptInfoRequestBody();
            return TeaModel.build(map, self);
        }

        public HrbrainImportDeptInfoRequestBody setCreateDate(String createDate) {
            this.createDate = createDate;
            return this;
        }
        public String getCreateDate() {
            return this.createDate;
        }

        public HrbrainImportDeptInfoRequestBody setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public HrbrainImportDeptInfoRequestBody setDeptNo(String deptNo) {
            this.deptNo = deptNo;
            return this;
        }
        public String getDeptNo() {
            return this.deptNo;
        }

        public HrbrainImportDeptInfoRequestBody setEffectiveDate(String effectiveDate) {
            this.effectiveDate = effectiveDate;
            return this;
        }
        public String getEffectiveDate() {
            return this.effectiveDate;
        }

        public HrbrainImportDeptInfoRequestBody setExtendInfo(java.util.Map<String, ?> extendInfo) {
            this.extendInfo = extendInfo;
            return this;
        }
        public java.util.Map<String, ?> getExtendInfo() {
            return this.extendInfo;
        }

        public HrbrainImportDeptInfoRequestBody setIsEffective(String isEffective) {
            this.isEffective = isEffective;
            return this;
        }
        public String getIsEffective() {
            return this.isEffective;
        }

        public HrbrainImportDeptInfoRequestBody setSuperDeptName(String superDeptName) {
            this.superDeptName = superDeptName;
            return this;
        }
        public String getSuperDeptName() {
            return this.superDeptName;
        }

        public HrbrainImportDeptInfoRequestBody setSuperDeptNo(String superDeptNo) {
            this.superDeptNo = superDeptNo;
            return this;
        }
        public String getSuperDeptNo() {
            return this.superDeptNo;
        }

        public HrbrainImportDeptInfoRequestBody setSuperEmpId(String superEmpId) {
            this.superEmpId = superEmpId;
            return this;
        }
        public String getSuperEmpId() {
            return this.superEmpId;
        }

        public HrbrainImportDeptInfoRequestBody setSuperName(String superName) {
            this.superName = superName;
            return this;
        }
        public String getSuperName() {
            return this.superName;
        }

    }

}
