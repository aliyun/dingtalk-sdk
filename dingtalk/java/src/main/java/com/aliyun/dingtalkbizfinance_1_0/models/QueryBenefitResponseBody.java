// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryBenefitResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryBenefitResponseBodyResult result;

    public static QueryBenefitResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryBenefitResponseBody self = new QueryBenefitResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryBenefitResponseBody setResult(QueryBenefitResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryBenefitResponseBodyResult getResult() {
        return this.result;
    }

    public static class QueryBenefitResponseBodyResult extends TeaModel {
        @NameInMap("remainQuota")
        public Long remainQuota;

        @NameInMap("totalQuota")
        public Long totalQuota;

        public static QueryBenefitResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryBenefitResponseBodyResult self = new QueryBenefitResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryBenefitResponseBodyResult setRemainQuota(Long remainQuota) {
            this.remainQuota = remainQuota;
            return this;
        }
        public Long getRemainQuota() {
            return this.remainQuota;
        }

        public QueryBenefitResponseBodyResult setTotalQuota(Long totalQuota) {
            this.totalQuota = totalQuota;
            return this;
        }
        public Long getTotalQuota() {
            return this.totalQuota;
        }

    }

}
