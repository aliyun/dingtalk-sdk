// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class BatchQueryOrgInvoiceUrlShrinkRequest extends TeaModel {
    @NameInMap("companyCode")
    public String companyCode;

    @NameInMap("invoiceKeyVOList")
    public String invoiceKeyVOListShrink;

    @NameInMap("operator")
    public String operator;

    public static BatchQueryOrgInvoiceUrlShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryOrgInvoiceUrlShrinkRequest self = new BatchQueryOrgInvoiceUrlShrinkRequest();
        return TeaModel.build(map, self);
    }

    public BatchQueryOrgInvoiceUrlShrinkRequest setCompanyCode(String companyCode) {
        this.companyCode = companyCode;
        return this;
    }
    public String getCompanyCode() {
        return this.companyCode;
    }

    public BatchQueryOrgInvoiceUrlShrinkRequest setInvoiceKeyVOListShrink(String invoiceKeyVOListShrink) {
        this.invoiceKeyVOListShrink = invoiceKeyVOListShrink;
        return this;
    }
    public String getInvoiceKeyVOListShrink() {
        return this.invoiceKeyVOListShrink;
    }

    public BatchQueryOrgInvoiceUrlShrinkRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

}
