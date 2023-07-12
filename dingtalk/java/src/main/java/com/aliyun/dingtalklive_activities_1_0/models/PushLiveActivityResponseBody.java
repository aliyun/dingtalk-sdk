// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_activities_1_0.models;

import com.aliyun.tea.*;

public class PushLiveActivityResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    public static PushLiveActivityResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PushLiveActivityResponseBody self = new PushLiveActivityResponseBody();
        return TeaModel.build(map, self);
    }

    public PushLiveActivityResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
