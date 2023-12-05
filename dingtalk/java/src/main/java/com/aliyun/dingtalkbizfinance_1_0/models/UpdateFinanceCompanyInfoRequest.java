// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateFinanceCompanyInfoRequest extends TeaModel {
    @NameInMap("companyName")
    public String companyName;

    @NameInMap("taxNature")
    public String taxNature;

    @NameInMap("taxNo")
    public String taxNo;

    @NameInMap("taxOrInvoiceHasInit")
    public Boolean taxOrInvoiceHasInit;

    @NameInMap("userId")
    public String userId;

    public static UpdateFinanceCompanyInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateFinanceCompanyInfoRequest self = new UpdateFinanceCompanyInfoRequest();
        return TeaModel.build(map, self);
    }

    public UpdateFinanceCompanyInfoRequest setCompanyName(String companyName) {
        this.companyName = companyName;
        return this;
    }
    public String getCompanyName() {
        return this.companyName;
    }

    public UpdateFinanceCompanyInfoRequest setTaxNature(String taxNature) {
        this.taxNature = taxNature;
        return this;
    }
    public String getTaxNature() {
        return this.taxNature;
    }

    public UpdateFinanceCompanyInfoRequest setTaxNo(String taxNo) {
        this.taxNo = taxNo;
        return this;
    }
    public String getTaxNo() {
        return this.taxNo;
    }

    public UpdateFinanceCompanyInfoRequest setTaxOrInvoiceHasInit(Boolean taxOrInvoiceHasInit) {
        this.taxOrInvoiceHasInit = taxOrInvoiceHasInit;
        return this;
    }
    public Boolean getTaxOrInvoiceHasInit() {
        return this.taxOrInvoiceHasInit;
    }

    public UpdateFinanceCompanyInfoRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
