// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateFinanceMultiCompanyInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("companyCode")
    public String companyCode;

    /**
     * <p>This parameter is required.</p>
     */
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

    public static UpdateFinanceMultiCompanyInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateFinanceMultiCompanyInfoRequest self = new UpdateFinanceMultiCompanyInfoRequest();
        return TeaModel.build(map, self);
    }

    public UpdateFinanceMultiCompanyInfoRequest setCompanyCode(String companyCode) {
        this.companyCode = companyCode;
        return this;
    }
    public String getCompanyCode() {
        return this.companyCode;
    }

    public UpdateFinanceMultiCompanyInfoRequest setCompanyName(String companyName) {
        this.companyName = companyName;
        return this;
    }
    public String getCompanyName() {
        return this.companyName;
    }

    public UpdateFinanceMultiCompanyInfoRequest setTaxNature(String taxNature) {
        this.taxNature = taxNature;
        return this;
    }
    public String getTaxNature() {
        return this.taxNature;
    }

    public UpdateFinanceMultiCompanyInfoRequest setTaxNo(String taxNo) {
        this.taxNo = taxNo;
        return this;
    }
    public String getTaxNo() {
        return this.taxNo;
    }

    public UpdateFinanceMultiCompanyInfoRequest setTaxOrInvoiceHasInit(Boolean taxOrInvoiceHasInit) {
        this.taxOrInvoiceHasInit = taxOrInvoiceHasInit;
        return this;
    }
    public Boolean getTaxOrInvoiceHasInit() {
        return this.taxOrInvoiceHasInit;
    }

    public UpdateFinanceMultiCompanyInfoRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
