// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyListPartnerAdminsResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<SupplyListPartnerAdminsResponseBodyResult> result;

    public static SupplyListPartnerAdminsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SupplyListPartnerAdminsResponseBody self = new SupplyListPartnerAdminsResponseBody();
        return TeaModel.build(map, self);
    }

    public SupplyListPartnerAdminsResponseBody setResult(java.util.List<SupplyListPartnerAdminsResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<SupplyListPartnerAdminsResponseBodyResult> getResult() {
        return this.result;
    }

    public static class SupplyListPartnerAdminsResponseBodyResult extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("unionId")
        public String unionId;

        @NameInMap("userId")
        public String userId;

        public static SupplyListPartnerAdminsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SupplyListPartnerAdminsResponseBodyResult self = new SupplyListPartnerAdminsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SupplyListPartnerAdminsResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SupplyListPartnerAdminsResponseBodyResult setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public SupplyListPartnerAdminsResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
