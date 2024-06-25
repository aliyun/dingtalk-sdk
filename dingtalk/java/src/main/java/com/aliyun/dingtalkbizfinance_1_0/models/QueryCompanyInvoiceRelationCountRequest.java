// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryCompanyInvoiceRelationCountRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>COM_DEFAULT</p>
     */
    @NameInMap("companyCode")
    public String companyCode;

    public static QueryCompanyInvoiceRelationCountRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCompanyInvoiceRelationCountRequest self = new QueryCompanyInvoiceRelationCountRequest();
        return TeaModel.build(map, self);
    }

    public QueryCompanyInvoiceRelationCountRequest setCompanyCode(String companyCode) {
        this.companyCode = companyCode;
        return this;
    }
    public String getCompanyCode() {
        return this.companyCode;
    }

}
