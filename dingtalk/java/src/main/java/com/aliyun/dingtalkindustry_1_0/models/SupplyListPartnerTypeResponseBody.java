// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyListPartnerTypeResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<SupplyListPartnerTypeResponseBodyResult> result;

    public static SupplyListPartnerTypeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SupplyListPartnerTypeResponseBody self = new SupplyListPartnerTypeResponseBody();
        return TeaModel.build(map, self);
    }

    public SupplyListPartnerTypeResponseBody setResult(java.util.List<SupplyListPartnerTypeResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<SupplyListPartnerTypeResponseBodyResult> getResult() {
        return this.result;
    }

    public static class SupplyListPartnerTypeResponseBodyResult extends TeaModel {
        @NameInMap("labelId")
        public Long labelId;

        @NameInMap("name")
        public String name;

        @NameInMap("superId")
        public Long superId;

        public static SupplyListPartnerTypeResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SupplyListPartnerTypeResponseBodyResult self = new SupplyListPartnerTypeResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SupplyListPartnerTypeResponseBodyResult setLabelId(Long labelId) {
            this.labelId = labelId;
            return this;
        }
        public Long getLabelId() {
            return this.labelId;
        }

        public SupplyListPartnerTypeResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SupplyListPartnerTypeResponseBodyResult setSuperId(Long superId) {
            this.superId = superId;
            return this;
        }
        public Long getSuperId() {
            return this.superId;
        }

    }

}
