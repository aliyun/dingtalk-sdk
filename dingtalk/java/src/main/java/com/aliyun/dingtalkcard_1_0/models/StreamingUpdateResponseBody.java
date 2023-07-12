// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class StreamingUpdateResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static StreamingUpdateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        StreamingUpdateResponseBody self = new StreamingUpdateResponseBody();
        return TeaModel.build(map, self);
    }

    public StreamingUpdateResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public StreamingUpdateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
