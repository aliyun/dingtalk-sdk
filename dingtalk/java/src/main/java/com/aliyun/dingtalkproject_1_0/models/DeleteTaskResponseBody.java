// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class DeleteTaskResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.Map<String, String> result;

    public static DeleteTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteTaskResponseBody self = new DeleteTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteTaskResponseBody setResult(java.util.Map<String, String> result) {
        this.result = result;
        return this;
    }
    public java.util.Map<String, String> getResult() {
        return this.result;
    }

}
