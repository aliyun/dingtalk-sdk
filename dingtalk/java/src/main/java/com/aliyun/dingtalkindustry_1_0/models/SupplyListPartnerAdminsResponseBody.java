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
        /**
         * <strong>example:</strong>
         * <p>负责人名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>99292111</p>
         */
        @NameInMap("unionId")
        public String unionId;

        /**
         * <strong>example:</strong>
         * <p>8782166278711</p>
         */
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
