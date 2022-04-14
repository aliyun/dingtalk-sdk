// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateFormDataByInstanceMapResponseBody extends TeaModel {
    // 更新成功的表单实例ID
    @NameInMap("result")
    public java.util.List<String> result;

    public static BatchUpdateFormDataByInstanceMapResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchUpdateFormDataByInstanceMapResponseBody self = new BatchUpdateFormDataByInstanceMapResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchUpdateFormDataByInstanceMapResponseBody setResult(java.util.List<String> result) {
        this.result = result;
        return this;
    }
    public java.util.List<String> getResult() {
        return this.result;
    }

}
