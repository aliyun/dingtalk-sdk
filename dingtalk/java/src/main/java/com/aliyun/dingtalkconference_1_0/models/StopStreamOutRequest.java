// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class StopStreamOutRequest extends TeaModel {
    // 流id
    @NameInMap("streamId")
    public String streamId;

    // 是否停止所有流，为true时，则不理会streamId字段
    @NameInMap("stopAllStream")
    public Boolean stopAllStream;

    // 用户id
    @NameInMap("unionId")
    public String unionId;

    public static StopStreamOutRequest build(java.util.Map<String, ?> map) throws Exception {
        StopStreamOutRequest self = new StopStreamOutRequest();
        return TeaModel.build(map, self);
    }

    public StopStreamOutRequest setStreamId(String streamId) {
        this.streamId = streamId;
        return this;
    }
    public String getStreamId() {
        return this.streamId;
    }

    public StopStreamOutRequest setStopAllStream(Boolean stopAllStream) {
        this.stopAllStream = stopAllStream;
        return this;
    }
    public Boolean getStopAllStream() {
        return this.stopAllStream;
    }

    public StopStreamOutRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
