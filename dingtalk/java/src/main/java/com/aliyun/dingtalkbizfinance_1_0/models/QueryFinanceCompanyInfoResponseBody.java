// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryFinanceCompanyInfoResponseBody extends TeaModel {
    @NameInMap("companyName")
    public String companyName;

    @NameInMap("taxNature")
    public String taxNature;

    @NameInMap("taxNo")
    public String taxNo;

    public static QueryFinanceCompanyInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryFinanceCompanyInfoResponseBody self = new QueryFinanceCompanyInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryFinanceCompanyInfoResponseBody setCompanyName(String companyName) {
        this.companyName = companyName;
        return this;
    }
    public String getCompanyName() {
        return this.companyName;
    }

    public QueryFinanceCompanyInfoResponseBody setTaxNature(String taxNature) {
        this.taxNature = taxNature;
        return this;
    }
    public String getTaxNature() {
        return this.taxNature;
    }

    public QueryFinanceCompanyInfoResponseBody setTaxNo(String taxNo) {
        this.taxNo = taxNo;
        return this;
    }
    public String getTaxNo() {
        return this.taxNo;
    }

}
