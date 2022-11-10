// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class SyncChannelMessageResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("result")
    public String result;

    public static SyncChannelMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SyncChannelMessageResponseBody self = new SyncChannelMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public SyncChannelMessageResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
