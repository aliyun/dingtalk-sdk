// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyAddMemberResponseBody extends TeaModel {
    @NameInMap("result")
    public SupplyAddMemberResponseBodyResult result;

    public static SupplyAddMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SupplyAddMemberResponseBody self = new SupplyAddMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public SupplyAddMemberResponseBody setResult(SupplyAddMemberResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SupplyAddMemberResponseBodyResult getResult() {
        return this.result;
    }

    public static class SupplyAddMemberResponseBodyResult extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("dingMemberStatus")
        public String dingMemberStatus;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("unionId")
        public String unionId;

        @NameInMap("userId")
        public String userId;

        public static SupplyAddMemberResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SupplyAddMemberResponseBodyResult self = new SupplyAddMemberResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SupplyAddMemberResponseBodyResult setDingMemberStatus(String dingMemberStatus) {
            this.dingMemberStatus = dingMemberStatus;
            return this;
        }
        public String getDingMemberStatus() {
            return this.dingMemberStatus;
        }

        public SupplyAddMemberResponseBodyResult setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public SupplyAddMemberResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
