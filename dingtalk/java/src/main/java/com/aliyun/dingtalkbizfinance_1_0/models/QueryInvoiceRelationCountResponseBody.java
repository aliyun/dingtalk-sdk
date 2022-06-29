// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryInvoiceRelationCountResponseBody extends TeaModel {
    @NameInMap("relationCountMap")
    public java.util.Map<String, Long> relationCountMap;

    public static QueryInvoiceRelationCountResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryInvoiceRelationCountResponseBody self = new QueryInvoiceRelationCountResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryInvoiceRelationCountResponseBody setRelationCountMap(java.util.Map<String, Long> relationCountMap) {
        this.relationCountMap = relationCountMap;
        return this;
    }
    public java.util.Map<String, Long> getRelationCountMap() {
        return this.relationCountMap;
    }

}
