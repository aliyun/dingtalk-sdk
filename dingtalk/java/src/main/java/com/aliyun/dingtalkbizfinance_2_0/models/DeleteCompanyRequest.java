// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class DeleteCompanyRequest extends TeaModel {
    @NameInMap("companyCode")
    public String companyCode;

    public static DeleteCompanyRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteCompanyRequest self = new DeleteCompanyRequest();
        return TeaModel.build(map, self);
    }

    public DeleteCompanyRequest setCompanyCode(String companyCode) {
        this.companyCode = companyCode;
        return this;
    }
    public String getCompanyCode() {
        return this.companyCode;
    }

}
