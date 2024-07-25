// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class UploadVideosShrinkRequest extends TeaModel {
    @NameInMap("videoList")
    public String videoListShrink;

    public static UploadVideosShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        UploadVideosShrinkRequest self = new UploadVideosShrinkRequest();
        return TeaModel.build(map, self);
    }

    public UploadVideosShrinkRequest setVideoListShrink(String videoListShrink) {
        this.videoListShrink = videoListShrink;
        return this;
    }
    public String getVideoListShrink() {
        return this.videoListShrink;
    }

}
