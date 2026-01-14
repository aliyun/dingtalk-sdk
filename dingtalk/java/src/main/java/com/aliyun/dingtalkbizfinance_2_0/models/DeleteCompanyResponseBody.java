// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class DeleteCompanyResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static DeleteCompanyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteCompanyResponseBody self = new DeleteCompanyResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteCompanyResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
