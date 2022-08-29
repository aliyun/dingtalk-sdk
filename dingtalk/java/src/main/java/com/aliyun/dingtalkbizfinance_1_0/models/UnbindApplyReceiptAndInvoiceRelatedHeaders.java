// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UnbindApplyReceiptAndInvoiceRelatedHeaders extends TeaModel {
    @NameInMap("commonHeaders")
    public java.util.Map<String, String> commonHeaders;

    @NameInMap("x-acs-dingtalk-access-token")
    public String xAcsDingtalkAccessToken;

    public static UnbindApplyReceiptAndInvoiceRelatedHeaders build(java.util.Map<String, ?> map) throws Exception {
        UnbindApplyReceiptAndInvoiceRelatedHeaders self = new UnbindApplyReceiptAndInvoiceRelatedHeaders();
        return TeaModel.build(map, self);
    }

    public UnbindApplyReceiptAndInvoiceRelatedHeaders setCommonHeaders(java.util.Map<String, String> commonHeaders) {
        this.commonHeaders = commonHeaders;
        return this;
    }
    public java.util.Map<String, String> getCommonHeaders() {
        return this.commonHeaders;
    }

    public UnbindApplyReceiptAndInvoiceRelatedHeaders setXAcsDingtalkAccessToken(String xAcsDingtalkAccessToken) {
        this.xAcsDingtalkAccessToken = xAcsDingtalkAccessToken;
        return this;
    }
    public String getXAcsDingtalkAccessToken() {
        return this.xAcsDingtalkAccessToken;
    }

}
