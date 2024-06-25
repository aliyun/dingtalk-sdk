// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateFinanceMultiCompanyInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>COM_DEFAULT</p>
     */
    @NameInMap("companyCode")
    public String companyCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>钉钉</p>
     */
    @NameInMap("companyName")
    public String companyName;

    /**
     * <strong>example:</strong>
     * <p>generalTaxpayer</p>
     */
    @NameInMap("taxNature")
    public String taxNature;

    /**
     * <strong>example:</strong>
     * <p>123456789012345</p>
     */
    @NameInMap("taxNo")
    public String taxNo;

    @NameInMap("taxOrInvoiceHasInit")
    public Boolean taxOrInvoiceHasInit;

    /**
     * <strong>example:</strong>
     * <p>123</p>
     */
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
