// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryInvoiceTransferDataRequest extends TeaModel {
    @NameInMap("body")
    public QueryInvoiceTransferDataRequestBody body;

    public static QueryInvoiceTransferDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryInvoiceTransferDataRequest self = new QueryInvoiceTransferDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryInvoiceTransferDataRequest setBody(QueryInvoiceTransferDataRequestBody body) {
        this.body = body;
        return this;
    }
    public QueryInvoiceTransferDataRequestBody getBody() {
        return this.body;
    }

    public static class QueryInvoiceTransferDataRequestBody extends TeaModel {
        @NameInMap("keys")
        public java.util.List<String> keys;

        public static QueryInvoiceTransferDataRequestBody build(java.util.Map<String, ?> map) throws Exception {
            QueryInvoiceTransferDataRequestBody self = new QueryInvoiceTransferDataRequestBody();
            return TeaModel.build(map, self);
        }

        public QueryInvoiceTransferDataRequestBody setKeys(java.util.List<String> keys) {
            this.keys = keys;
            return this;
        }
        public java.util.List<String> getKeys() {
            return this.keys;
        }

    }

}
