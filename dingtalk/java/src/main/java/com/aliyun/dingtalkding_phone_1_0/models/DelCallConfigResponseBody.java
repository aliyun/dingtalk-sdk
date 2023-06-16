// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkding_phone_1_0.models;

import com.aliyun.tea.*;

public class DelCallConfigResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static DelCallConfigResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DelCallConfigResponseBody self = new DelCallConfigResponseBody();
        return TeaModel.build(map, self);
    }

    public DelCallConfigResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
