// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncInvoiceResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static SyncInvoiceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SyncInvoiceResponseBody self = new SyncInvoiceResponseBody();
        return TeaModel.build(map, self);
    }

    public SyncInvoiceResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
