// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class StartCloudFeedResponseBody extends TeaModel {
    /**
     * <p>状态更改是否成功</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static StartCloudFeedResponseBody build(java.util.Map<String, ?> map) throws Exception {
        StartCloudFeedResponseBody self = new StartCloudFeedResponseBody();
        return TeaModel.build(map, self);
    }

    public StartCloudFeedResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
