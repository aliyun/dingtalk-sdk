// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyGetMemberResponseBody extends TeaModel {
    @NameInMap("result")
    public SupplyGetMemberResponseBodyResult result;

    public static SupplyGetMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SupplyGetMemberResponseBody self = new SupplyGetMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public SupplyGetMemberResponseBody setResult(SupplyGetMemberResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SupplyGetMemberResponseBodyResult getResult() {
        return this.result;
    }

    public static class SupplyGetMemberResponseBodyResultRoleInfoList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("roleId")
        public String roleId;

        /**
         * <strong>example:</strong>
         * <p>老板</p>
         */
        @NameInMap("roleName")
        public String roleName;

        public static SupplyGetMemberResponseBodyResultRoleInfoList build(java.util.Map<String, ?> map) throws Exception {
            SupplyGetMemberResponseBodyResultRoleInfoList self = new SupplyGetMemberResponseBodyResultRoleInfoList();
            return TeaModel.build(map, self);
        }

        public SupplyGetMemberResponseBodyResultRoleInfoList setRoleId(String roleId) {
            this.roleId = roleId;
            return this;
        }
        public String getRoleId() {
            return this.roleId;
        }

        public SupplyGetMemberResponseBodyResultRoleInfoList setRoleName(String roleName) {
            this.roleName = roleName;
            return this;
        }
        public String getRoleName() {
            return this.roleName;
        }

    }

    public static class SupplyGetMemberResponseBodyResult extends TeaModel {
        @NameInMap("deptIdList")
        public java.util.List<Long> deptIdList;

        /**
         * <strong>example:</strong>
         * <p>NORMAL</p>
         */
        @NameInMap("dingMemberStatus")
        public String dingMemberStatus;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("isActive")
        public Boolean isActive;

        /**
         * <strong>example:</strong>
         * <p>李白</p>
         */
        @NameInMap("memberName")
        public String memberName;

        /**
         * <strong>example:</strong>
         * <p>经理</p>
         */
        @NameInMap("memberTitle")
        public String memberTitle;

        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("memberWorkNumber")
        public String memberWorkNumber;

        @NameInMap("roleInfoList")
        public java.util.List<SupplyGetMemberResponseBodyResultRoleInfoList> roleInfoList;

        @NameInMap("supplyNodeList")
        public java.util.List<Long> supplyNodeList;

        public static SupplyGetMemberResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SupplyGetMemberResponseBodyResult self = new SupplyGetMemberResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SupplyGetMemberResponseBodyResult setDeptIdList(java.util.List<Long> deptIdList) {
            this.deptIdList = deptIdList;
            return this;
        }
        public java.util.List<Long> getDeptIdList() {
            return this.deptIdList;
        }

        public SupplyGetMemberResponseBodyResult setDingMemberStatus(String dingMemberStatus) {
            this.dingMemberStatus = dingMemberStatus;
            return this;
        }
        public String getDingMemberStatus() {
            return this.dingMemberStatus;
        }

        public SupplyGetMemberResponseBodyResult setIsActive(Boolean isActive) {
            this.isActive = isActive;
            return this;
        }
        public Boolean getIsActive() {
            return this.isActive;
        }

        public SupplyGetMemberResponseBodyResult setMemberName(String memberName) {
            this.memberName = memberName;
            return this;
        }
        public String getMemberName() {
            return this.memberName;
        }

        public SupplyGetMemberResponseBodyResult setMemberTitle(String memberTitle) {
            this.memberTitle = memberTitle;
            return this;
        }
        public String getMemberTitle() {
            return this.memberTitle;
        }

        public SupplyGetMemberResponseBodyResult setMemberWorkNumber(String memberWorkNumber) {
            this.memberWorkNumber = memberWorkNumber;
            return this;
        }
        public String getMemberWorkNumber() {
            return this.memberWorkNumber;
        }

        public SupplyGetMemberResponseBodyResult setRoleInfoList(java.util.List<SupplyGetMemberResponseBodyResultRoleInfoList> roleInfoList) {
            this.roleInfoList = roleInfoList;
            return this;
        }
        public java.util.List<SupplyGetMemberResponseBodyResultRoleInfoList> getRoleInfoList() {
            return this.roleInfoList;
        }

        public SupplyGetMemberResponseBodyResult setSupplyNodeList(java.util.List<Long> supplyNodeList) {
            this.supplyNodeList = supplyNodeList;
            return this;
        }
        public java.util.List<Long> getSupplyNodeList() {
            return this.supplyNodeList;
        }

    }

}
