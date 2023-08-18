// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateFinanceMultiCompanyInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static UpdateFinanceMultiCompanyInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateFinanceMultiCompanyInfoResponseBody self = new UpdateFinanceMultiCompanyInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateFinanceMultiCompanyInfoResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
