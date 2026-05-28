// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class CreateAsrTranscriptionRequest extends TeaModel {
    @NameInMap("bizKey")
    public String bizKey;

    @NameInMap("phrases")
    public java.util.List<String> phrases;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("url")
    public String url;

    public static CreateAsrTranscriptionRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateAsrTranscriptionRequest self = new CreateAsrTranscriptionRequest();
        return TeaModel.build(map, self);
    }

    public CreateAsrTranscriptionRequest setBizKey(String bizKey) {
        this.bizKey = bizKey;
        return this;
    }
    public String getBizKey() {
        return this.bizKey;
    }

    public CreateAsrTranscriptionRequest setPhrases(java.util.List<String> phrases) {
        this.phrases = phrases;
        return this;
    }
    public java.util.List<String> getPhrases() {
        return this.phrases;
    }

    public CreateAsrTranscriptionRequest setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

}
