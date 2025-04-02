// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class ConfirmPaymentOrderResponseBody extends TeaModel {
    @NameInMap("url")
    public String url;

    public static ConfirmPaymentOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ConfirmPaymentOrderResponseBody self = new ConfirmPaymentOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public ConfirmPaymentOrderResponseBody setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

}
