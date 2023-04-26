// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateDigitalInvoiceOrgInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static UpdateDigitalInvoiceOrgInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateDigitalInvoiceOrgInfoResponseBody self = new UpdateDigitalInvoiceOrgInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateDigitalInvoiceOrgInfoResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
