// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class StopCloudFeedResponseBody extends TeaModel {
    // 状态更改是否成功
    @NameInMap("result")
    public Boolean result;

    public static StopCloudFeedResponseBody build(java.util.Map<String, ?> map) throws Exception {
        StopCloudFeedResponseBody self = new StopCloudFeedResponseBody();
        return TeaModel.build(map, self);
    }

    public StopCloudFeedResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
