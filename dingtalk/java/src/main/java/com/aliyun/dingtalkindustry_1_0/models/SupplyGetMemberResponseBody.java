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
        @NameInMap("dingMemberStatus")
        public String dingMemberStatus;

        @NameInMap("isActive")
        public Boolean isActive;

        @NameInMap("memberName")
        public String memberName;

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
