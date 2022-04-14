// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateFormDataByInstanceIdResponseBody extends TeaModel {
    // 成功更新的表单实例的id
    @NameInMap("result")
    public java.util.List<String> result;

    public static BatchUpdateFormDataByInstanceIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchUpdateFormDataByInstanceIdResponseBody self = new BatchUpdateFormDataByInstanceIdResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchUpdateFormDataByInstanceIdResponseBody setResult(java.util.List<String> result) {
        this.result = result;
        return this;
    }
    public java.util.List<String> getResult() {
        return this.result;
    }

}
