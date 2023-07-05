// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_activities_1_0.models;

import com.aliyun.tea.*;

public class SendLiveActivityResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    public static SendLiveActivityResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendLiveActivityResponseBody self = new SendLiveActivityResponseBody();
        return TeaModel.build(map, self);
    }

    public SendLiveActivityResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
