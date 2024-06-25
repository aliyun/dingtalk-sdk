// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class CreateCloudFeedResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>创建好的云导播课程id</p>
     */
    @NameInMap("result")
    public String result;

    public static CreateCloudFeedResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateCloudFeedResponseBody self = new CreateCloudFeedResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateCloudFeedResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
