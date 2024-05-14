// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class StreamingUpdateRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("content")
    public String content;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("guid")
    public String guid;

    @NameInMap("isError")
    public Boolean isError;

    @NameInMap("isFinalize")
    public Boolean isFinalize;

    @NameInMap("isFull")
    public Boolean isFull;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("key")
    public String key;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("outTrackId")
    public String outTrackId;

    public static StreamingUpdateRequest build(java.util.Map<String, ?> map) throws Exception {
        StreamingUpdateRequest self = new StreamingUpdateRequest();
        return TeaModel.build(map, self);
    }

    public StreamingUpdateRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public StreamingUpdateRequest setGuid(String guid) {
        this.guid = guid;
        return this;
    }
    public String getGuid() {
        return this.guid;
    }

    public StreamingUpdateRequest setIsError(Boolean isError) {
        this.isError = isError;
        return this;
    }
    public Boolean getIsError() {
        return this.isError;
    }

    public StreamingUpdateRequest setIsFinalize(Boolean isFinalize) {
        this.isFinalize = isFinalize;
        return this;
    }
    public Boolean getIsFinalize() {
        return this.isFinalize;
    }

    public StreamingUpdateRequest setIsFull(Boolean isFull) {
        this.isFull = isFull;
        return this;
    }
    public Boolean getIsFull() {
        return this.isFull;
    }

    public StreamingUpdateRequest setKey(String key) {
        this.key = key;
        return this;
    }
    public String getKey() {
        return this.key;
    }

    public StreamingUpdateRequest setOutTrackId(String outTrackId) {
        this.outTrackId = outTrackId;
        return this;
    }
    public String getOutTrackId() {
        return this.outTrackId;
    }

}
