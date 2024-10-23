// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class IssueInvoiceWithOrderResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static IssueInvoiceWithOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IssueInvoiceWithOrderResponseBody self = new IssueInvoiceWithOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public IssueInvoiceWithOrderResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
