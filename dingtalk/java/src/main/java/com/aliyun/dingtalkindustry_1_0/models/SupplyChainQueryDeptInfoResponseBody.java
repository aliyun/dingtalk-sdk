// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyChainQueryDeptInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public SupplyChainQueryDeptInfoResponseBodyResult result;

    public static SupplyChainQueryDeptInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SupplyChainQueryDeptInfoResponseBody self = new SupplyChainQueryDeptInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public SupplyChainQueryDeptInfoResponseBody setResult(SupplyChainQueryDeptInfoResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SupplyChainQueryDeptInfoResponseBodyResult getResult() {
        return this.result;
    }

    public static class SupplyChainQueryDeptInfoResponseBodyResultPartnerTypeInfoList extends TeaModel {
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

        public static SupplyChainQueryDeptInfoResponseBodyResultPartnerTypeInfoList build(java.util.Map<String, ?> map) throws Exception {
            SupplyChainQueryDeptInfoResponseBodyResultPartnerTypeInfoList self = new SupplyChainQueryDeptInfoResponseBodyResultPartnerTypeInfoList();
            return TeaModel.build(map, self);
        }

        public SupplyChainQueryDeptInfoResponseBodyResultPartnerTypeInfoList setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public SupplyChainQueryDeptInfoResponseBodyResultPartnerTypeInfoList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SupplyChainQueryDeptInfoResponseBodyResultPartnerTypeInfoList setSuperId(Long superId) {
            this.superId = superId;
            return this;
        }
        public Long getSuperId() {
            return this.superId;
        }

        public SupplyChainQueryDeptInfoResponseBodyResultPartnerTypeInfoList setSuperName(String superName) {
            this.superName = superName;
            return this;
        }
        public String getSuperName() {
            return this.superName;
        }

    }

    public static class SupplyChainQueryDeptInfoResponseBodyResult extends TeaModel {
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
        public java.util.List<SupplyChainQueryDeptInfoResponseBodyResultPartnerTypeInfoList> partnerTypeInfoList;

        /**
         * <strong>example:</strong>
         * <p>1111</p>
         */
        @NameInMap("superId")
        public Long superId;

        public static SupplyChainQueryDeptInfoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SupplyChainQueryDeptInfoResponseBodyResult self = new SupplyChainQueryDeptInfoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SupplyChainQueryDeptInfoResponseBodyResult setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public SupplyChainQueryDeptInfoResponseBodyResult setDeptType(String deptType) {
            this.deptType = deptType;
            return this;
        }
        public String getDeptType() {
            return this.deptType;
        }

        public SupplyChainQueryDeptInfoResponseBodyResult setHasSubDept(Boolean hasSubDept) {
            this.hasSubDept = hasSubDept;
            return this;
        }
        public Boolean getHasSubDept() {
            return this.hasSubDept;
        }

        public SupplyChainQueryDeptInfoResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SupplyChainQueryDeptInfoResponseBodyResult setPartnerNumber(String partnerNumber) {
            this.partnerNumber = partnerNumber;
            return this;
        }
        public String getPartnerNumber() {
            return this.partnerNumber;
        }

        public SupplyChainQueryDeptInfoResponseBodyResult setPartnerTypeInfoList(java.util.List<SupplyChainQueryDeptInfoResponseBodyResultPartnerTypeInfoList> partnerTypeInfoList) {
            this.partnerTypeInfoList = partnerTypeInfoList;
            return this;
        }
        public java.util.List<SupplyChainQueryDeptInfoResponseBodyResultPartnerTypeInfoList> getPartnerTypeInfoList() {
            return this.partnerTypeInfoList;
        }

        public SupplyChainQueryDeptInfoResponseBodyResult setSuperId(Long superId) {
            this.superId = superId;
            return this;
        }
        public Long getSuperId() {
            return this.superId;
        }

    }

}
