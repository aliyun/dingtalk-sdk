// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncInvoiceEntityResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static SyncInvoiceEntityResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SyncInvoiceEntityResponseBody self = new SyncInvoiceEntityResponseBody();
        return TeaModel.build(map, self);
    }

    public SyncInvoiceEntityResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
