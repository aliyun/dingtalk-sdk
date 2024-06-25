// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyListSubDeptResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<SupplyListSubDeptResponseBodyResult> result;

    public static SupplyListSubDeptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SupplyListSubDeptResponseBody self = new SupplyListSubDeptResponseBody();
        return TeaModel.build(map, self);
    }

    public SupplyListSubDeptResponseBody setResult(java.util.List<SupplyListSubDeptResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<SupplyListSubDeptResponseBodyResult> getResult() {
        return this.result;
    }

    public static class SupplyListSubDeptResponseBodyResultPartnerTypeInfoList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>111</p>
         */
        @NameInMap("id")
        public Long id;

        /**
         * <strong>example:</strong>
         * <p>11111</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>1111</p>
         */
        @NameInMap("superId")
        public Long superId;

        /**
         * <strong>example:</strong>
         * <p>1111</p>
         */
        @NameInMap("superName")
        public String superName;

        public static SupplyListSubDeptResponseBodyResultPartnerTypeInfoList build(java.util.Map<String, ?> map) throws Exception {
            SupplyListSubDeptResponseBodyResultPartnerTypeInfoList self = new SupplyListSubDeptResponseBodyResultPartnerTypeInfoList();
            return TeaModel.build(map, self);
        }

        public SupplyListSubDeptResponseBodyResultPartnerTypeInfoList setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public SupplyListSubDeptResponseBodyResultPartnerTypeInfoList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SupplyListSubDeptResponseBodyResultPartnerTypeInfoList setSuperId(Long superId) {
            this.superId = superId;
            return this;
        }
        public Long getSuperId() {
            return this.superId;
        }

        public SupplyListSubDeptResponseBodyResultPartnerTypeInfoList setSuperName(String superName) {
            this.superName = superName;
            return this;
        }
        public String getSuperName() {
            return this.superName;
        }

    }

    public static class SupplyListSubDeptResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1111</p>
         */
        @NameInMap("deptId")
        public Long deptId;

        /**
         * <strong>example:</strong>
         * <p>ROOT</p>
         */
        @NameInMap("deptType")
        public String deptType;

        @NameInMap("hasSubDept")
        public Boolean hasSubDept;

        /**
         * <strong>example:</strong>
         * <p>xxxx 有限公司</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>111111</p>
         */
        @NameInMap("partnerNumber")
        public String partnerNumber;

        @NameInMap("partnerTypeInfoList")
        public java.util.List<SupplyListSubDeptResponseBodyResultPartnerTypeInfoList> partnerTypeInfoList;

        /**
         * <strong>example:</strong>
         * <p>1111</p>
         */
        @NameInMap("superId")
        public Long superId;

        public static SupplyListSubDeptResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SupplyListSubDeptResponseBodyResult self = new SupplyListSubDeptResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SupplyListSubDeptResponseBodyResult setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public SupplyListSubDeptResponseBodyResult setDeptType(String deptType) {
            this.deptType = deptType;
            return this;
        }
        public String getDeptType() {
            return this.deptType;
        }

        public SupplyListSubDeptResponseBodyResult setHasSubDept(Boolean hasSubDept) {
            this.hasSubDept = hasSubDept;
            return this;
        }
        public Boolean getHasSubDept() {
            return this.hasSubDept;
        }

        public SupplyListSubDeptResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SupplyListSubDeptResponseBodyResult setPartnerNumber(String partnerNumber) {
            this.partnerNumber = partnerNumber;
            return this;
        }
        public String getPartnerNumber() {
            return this.partnerNumber;
        }

        public SupplyListSubDeptResponseBodyResult setPartnerTypeInfoList(java.util.List<SupplyListSubDeptResponseBodyResultPartnerTypeInfoList> partnerTypeInfoList) {
            this.partnerTypeInfoList = partnerTypeInfoList;
            return this;
        }
        public java.util.List<SupplyListSubDeptResponseBodyResultPartnerTypeInfoList> getPartnerTypeInfoList() {
            return this.partnerTypeInfoList;
        }

        public SupplyListSubDeptResponseBodyResult setSuperId(Long superId) {
            this.superId = superId;
            return this;
        }
        public Long getSuperId() {
            return this.superId;
        }

    }

}
