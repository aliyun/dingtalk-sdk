// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class StopStreamOutRequest extends TeaModel {
    @NameInMap("stopAllStream")
    public Boolean stopAllStream;

    @NameInMap("streamId")
    public String streamId;

    @NameInMap("unionId")
    public String unionId;

    public static StopStreamOutRequest build(java.util.Map<String, ?> map) throws Exception {
        StopStreamOutRequest self = new StopStreamOutRequest();
        return TeaModel.build(map, self);
    }

    public StopStreamOutRequest setStopAllStream(Boolean stopAllStream) {
        this.stopAllStream = stopAllStream;
        return this;
    }
    public Boolean getStopAllStream() {
        return this.stopAllStream;
    }

    public StopStreamOutRequest setStreamId(String streamId) {
        this.streamId = streamId;
        return this;
    }
    public String getStreamId() {
        return this.streamId;
    }

    public StopStreamOutRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
