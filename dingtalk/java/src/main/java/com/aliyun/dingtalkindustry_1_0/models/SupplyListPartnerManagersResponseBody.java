// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyListPartnerManagersResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<SupplyListPartnerManagersResponseBodyResult> result;

    public static SupplyListPartnerManagersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SupplyListPartnerManagersResponseBody self = new SupplyListPartnerManagersResponseBody();
        return TeaModel.build(map, self);
    }

    public SupplyListPartnerManagersResponseBody setResult(java.util.List<SupplyListPartnerManagersResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<SupplyListPartnerManagersResponseBodyResult> getResult() {
        return this.result;
    }

    public static class SupplyListPartnerManagersResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>56789123</p>
         */
        @NameInMap("deptId")
        public String deptId;

        /**
         * <strong>example:</strong>
         * <p>对接部门名称</p>
         */
        @NameInMap("deptName")
        public String deptName;

        /**
         * <strong>example:</strong>
         * <p>user</p>
         */
        @NameInMap("interfaceType")
        public String interfaceType;

        /**
         * <strong>example:</strong>
         * <p>121234567</p>
         */
        @NameInMap("userId")
        public String userId;

        /**
         * <strong>example:</strong>
         * <p>名称</p>
         */
        @NameInMap("userName")
        public String userName;

        public static SupplyListPartnerManagersResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SupplyListPartnerManagersResponseBodyResult self = new SupplyListPartnerManagersResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SupplyListPartnerManagersResponseBodyResult setDeptId(String deptId) {
            this.deptId = deptId;
            return this;
        }
        public String getDeptId() {
            return this.deptId;
        }

        public SupplyListPartnerManagersResponseBodyResult setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public SupplyListPartnerManagersResponseBodyResult setInterfaceType(String interfaceType) {
            this.interfaceType = interfaceType;
            return this;
        }
        public String getInterfaceType() {
            return this.interfaceType;
        }

        public SupplyListPartnerManagersResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public SupplyListPartnerManagersResponseBodyResult setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

    }

}
