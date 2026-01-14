// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class EnableCompanyResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static EnableCompanyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EnableCompanyResponseBody self = new EnableCompanyResponseBody();
        return TeaModel.build(map, self);
    }

    public EnableCompanyResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
