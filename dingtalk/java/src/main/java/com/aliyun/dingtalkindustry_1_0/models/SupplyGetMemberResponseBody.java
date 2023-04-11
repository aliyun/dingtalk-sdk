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

    public static class SupplyGetMemberResponseBodyResult extends TeaModel {
        /**
         * <p>成员状态，已进组织或者待接收邀请</p>
         */
        @NameInMap("dingMemberStatus")
        public String dingMemberStatus;

        /**
         * <p>成员是否激活</p>
         */
        @NameInMap("isActive")
        public Boolean isActive;

        /**
         * <p>成员名字</p>
         */
        @NameInMap("memberName")
        public String memberName;

        /**
         * <p>成员在上下游中的工号</p>
         */
        @NameInMap("memberWorkNumber")
        public String memberWorkNumber;

        public static SupplyGetMemberResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SupplyGetMemberResponseBodyResult self = new SupplyGetMemberResponseBodyResult();
            return TeaModel.build(map, self);
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

        public SupplyGetMemberResponseBodyResult setMemberWorkNumber(String memberWorkNumber) {
            this.memberWorkNumber = memberWorkNumber;
            return this;
        }
        public String getMemberWorkNumber() {
            return this.memberWorkNumber;
        }

    }

}
