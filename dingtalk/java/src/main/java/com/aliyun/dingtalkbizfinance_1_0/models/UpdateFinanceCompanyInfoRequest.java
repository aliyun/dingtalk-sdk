// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateFinanceCompanyInfoRequest extends TeaModel {
    // 公司名字
    @NameInMap("companyName")
    public String companyName;

    // 纳税性质 小规模纳税人 一般纳税人
    @NameInMap("taxNature")
    public String taxNature;

    // 税号
    @NameInMap("taxNo")
    public String taxNo;

    // 用户ID
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

    public UpdateFinanceCompanyInfoRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
