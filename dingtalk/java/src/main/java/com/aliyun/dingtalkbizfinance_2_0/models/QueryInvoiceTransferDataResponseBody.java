// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryInvoiceTransferDataResponseBody extends TeaModel {
    @NameInMap("keyToData")
    public java.util.Map<String, String> keyToData;

    public static QueryInvoiceTransferDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryInvoiceTransferDataResponseBody self = new QueryInvoiceTransferDataResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryInvoiceTransferDataResponseBody setKeyToData(java.util.Map<String, String> keyToData) {
        this.keyToData = keyToData;
        return this;
    }
    public java.util.Map<String, String> getKeyToData() {
        return this.keyToData;
    }

}
