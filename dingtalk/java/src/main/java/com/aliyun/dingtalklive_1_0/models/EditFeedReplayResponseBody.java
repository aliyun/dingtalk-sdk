// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class EditFeedReplayResponseBody extends TeaModel {
    // 剪辑后的视频地址（含authkey）
    @NameInMap("result")
    public String result;

    public static EditFeedReplayResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EditFeedReplayResponseBody self = new EditFeedReplayResponseBody();
        return TeaModel.build(map, self);
    }

    public EditFeedReplayResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
