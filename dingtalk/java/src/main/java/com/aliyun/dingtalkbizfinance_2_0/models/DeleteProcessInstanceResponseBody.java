// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class DeleteProcessInstanceResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static DeleteProcessInstanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteProcessInstanceResponseBody self = new DeleteProcessInstanceResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteProcessInstanceResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
