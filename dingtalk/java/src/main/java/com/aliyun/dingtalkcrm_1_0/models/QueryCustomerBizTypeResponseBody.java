// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryCustomerBizTypeResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryCustomerBizTypeResponseBodyResult result;

    public static QueryCustomerBizTypeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCustomerBizTypeResponseBody self = new QueryCustomerBizTypeResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCustomerBizTypeResponseBody setResult(QueryCustomerBizTypeResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryCustomerBizTypeResponseBodyResult getResult() {
        return this.result;
    }

    public static class QueryCustomerBizTypeResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>crm_customer</p>
         */
        @NameInMap("customerBizType")
        public String customerBizType;

        public static QueryCustomerBizTypeResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryCustomerBizTypeResponseBodyResult self = new QueryCustomerBizTypeResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryCustomerBizTypeResponseBodyResult setCustomerBizType(String customerBizType) {
            this.customerBizType = customerBizType;
            return this;
        }
        public String getCustomerBizType() {
            return this.customerBizType;
        }

    }

}
