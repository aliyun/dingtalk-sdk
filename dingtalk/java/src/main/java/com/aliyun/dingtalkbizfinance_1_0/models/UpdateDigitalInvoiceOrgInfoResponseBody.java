// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateDigitalInvoiceOrgInfoResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     */
    @NameInMap("resulte")
    public Boolean resulte;

    public static UpdateDigitalInvoiceOrgInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateDigitalInvoiceOrgInfoResponseBody self = new UpdateDigitalInvoiceOrgInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateDigitalInvoiceOrgInfoResponseBody setResulte(Boolean resulte) {
        this.resulte = resulte;
        return this;
    }
    public Boolean getResulte() {
        return this.resulte;
    }

}
