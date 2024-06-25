// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyQueryPartnerTypeResponseBody extends TeaModel {
    @NameInMap("result")
    public SupplyQueryPartnerTypeResponseBodyResult result;

    public static SupplyQueryPartnerTypeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SupplyQueryPartnerTypeResponseBody self = new SupplyQueryPartnerTypeResponseBody();
        return TeaModel.build(map, self);
    }

    public SupplyQueryPartnerTypeResponseBody setResult(SupplyQueryPartnerTypeResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SupplyQueryPartnerTypeResponseBodyResult getResult() {
        return this.result;
    }

    public static class SupplyQueryPartnerTypeResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>21</p>
         */
        @NameInMap("labelId")
        public Long labelId;

        /**
         * <strong>example:</strong>
         * <p>标签1</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("superId")
        public Long superId;

        public static SupplyQueryPartnerTypeResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SupplyQueryPartnerTypeResponseBodyResult self = new SupplyQueryPartnerTypeResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SupplyQueryPartnerTypeResponseBodyResult setLabelId(Long labelId) {
            this.labelId = labelId;
            return this;
        }
        public Long getLabelId() {
            return this.labelId;
        }

        public SupplyQueryPartnerTypeResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SupplyQueryPartnerTypeResponseBodyResult setSuperId(Long superId) {
            this.superId = superId;
            return this;
        }
        public Long getSuperId() {
            return this.superId;
        }

    }

}
