// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryBenefitInventoryResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryBenefitInventoryResponseBodyResult result;

    public static QueryBenefitInventoryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryBenefitInventoryResponseBody self = new QueryBenefitInventoryResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryBenefitInventoryResponseBody setResult(QueryBenefitInventoryResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryBenefitInventoryResponseBodyResult getResult() {
        return this.result;
    }

    public static class QueryBenefitInventoryResponseBodyResult extends TeaModel {
        @NameInMap("totalQuota")
        public Long totalQuota;

        @NameInMap("usedQuota")
        public Long usedQuota;

        public static QueryBenefitInventoryResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryBenefitInventoryResponseBodyResult self = new QueryBenefitInventoryResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryBenefitInventoryResponseBodyResult setTotalQuota(Long totalQuota) {
            this.totalQuota = totalQuota;
            return this;
        }
        public Long getTotalQuota() {
            return this.totalQuota;
        }

        public QueryBenefitInventoryResponseBodyResult setUsedQuota(Long usedQuota) {
            this.usedQuota = usedQuota;
            return this;
        }
        public Long getUsedQuota() {
            return this.usedQuota;
        }

    }

}
