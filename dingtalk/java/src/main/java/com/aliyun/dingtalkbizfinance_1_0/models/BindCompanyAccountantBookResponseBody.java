// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class BindCompanyAccountantBookResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static BindCompanyAccountantBookResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BindCompanyAccountantBookResponseBody self = new BindCompanyAccountantBookResponseBody();
        return TeaModel.build(map, self);
    }

    public BindCompanyAccountantBookResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
