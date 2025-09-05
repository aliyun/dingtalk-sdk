// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncTripInvoiceResponseBody extends TeaModel {
    @NameInMap("success")
    public String success;

    public static SyncTripInvoiceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SyncTripInvoiceResponseBody self = new SyncTripInvoiceResponseBody();
        return TeaModel.build(map, self);
    }

    public SyncTripInvoiceResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

}
