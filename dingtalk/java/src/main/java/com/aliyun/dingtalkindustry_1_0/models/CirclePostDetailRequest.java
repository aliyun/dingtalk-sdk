// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CirclePostDetailRequest extends TeaModel {
    @NameInMap("postId")
    public Long postId;

    public static CirclePostDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        CirclePostDetailRequest self = new CirclePostDetailRequest();
        return TeaModel.build(map, self);
    }

    public CirclePostDetailRequest setPostId(Long postId) {
        this.postId = postId;
        return this;
    }
    public Long getPostId() {
        return this.postId;
    }

}
