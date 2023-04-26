// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class BatchSaveFormDataResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<String> result;

    public static BatchSaveFormDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchSaveFormDataResponseBody self = new BatchSaveFormDataResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchSaveFormDataResponseBody setResult(java.util.List<String> result) {
        this.result = result;
        return this;
    }
    public java.util.List<String> getResult() {
        return this.result;
    }

}
