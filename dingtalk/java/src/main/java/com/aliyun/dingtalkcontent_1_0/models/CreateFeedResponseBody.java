// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class CreateFeedResponseBody extends TeaModel {
    // 创建内容的内容Id
    @NameInMap("feedId")
    public String feedId;

    public static CreateFeedResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateFeedResponseBody self = new CreateFeedResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateFeedResponseBody setFeedId(String feedId) {
        this.feedId = feedId;
        return this;
    }
    public String getFeedId() {
        return this.feedId;
    }

}
