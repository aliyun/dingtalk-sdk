// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateFinanceCompanyInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static UpdateFinanceCompanyInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateFinanceCompanyInfoResponseBody self = new UpdateFinanceCompanyInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateFinanceCompanyInfoResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
