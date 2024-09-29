// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryUseNewInvoiceAppResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("useNew")
    public Boolean useNew;

    public static QueryUseNewInvoiceAppResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUseNewInvoiceAppResponseBody self = new QueryUseNewInvoiceAppResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUseNewInvoiceAppResponseBody setUseNew(Boolean useNew) {
        this.useNew = useNew;
        return this;
    }
    public Boolean getUseNew() {
        return this.useNew;
    }

}
