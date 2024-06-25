// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class StartCloudFeedResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
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
