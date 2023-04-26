// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class StartStreamOutResponseBody extends TeaModel {
    @NameInMap("failStreamMap")
    public java.util.Map<String, ?> failStreamMap;

    @NameInMap("successStreamMap")
    public java.util.Map<String, ?> successStreamMap;

    public static StartStreamOutResponseBody build(java.util.Map<String, ?> map) throws Exception {
        StartStreamOutResponseBody self = new StartStreamOutResponseBody();
        return TeaModel.build(map, self);
    }

    public StartStreamOutResponseBody setFailStreamMap(java.util.Map<String, ?> failStreamMap) {
        this.failStreamMap = failStreamMap;
        return this;
    }
    public java.util.Map<String, ?> getFailStreamMap() {
        return this.failStreamMap;
    }

    public StartStreamOutResponseBody setSuccessStreamMap(java.util.Map<String, ?> successStreamMap) {
        this.successStreamMap = successStreamMap;
        return this;
    }
    public java.util.Map<String, ?> getSuccessStreamMap() {
        return this.successStreamMap;
    }

}
