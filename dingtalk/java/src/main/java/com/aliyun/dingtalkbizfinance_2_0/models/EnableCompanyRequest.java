// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class EnableCompanyRequest extends TeaModel {
    @NameInMap("companyCode")
    public String companyCode;

    public static EnableCompanyRequest build(java.util.Map<String, ?> map) throws Exception {
        EnableCompanyRequest self = new EnableCompanyRequest();
        return TeaModel.build(map, self);
    }

    public EnableCompanyRequest setCompanyCode(String companyCode) {
        this.companyCode = companyCode;
        return this;
    }
    public String getCompanyCode() {
        return this.companyCode;
    }

}
