// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class VoiceCloneRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("text")
    public String text;

    @NameInMap("userId")
    public String userId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("voiceId")
    public String voiceId;

    public static VoiceCloneRequest build(java.util.Map<String, ?> map) throws Exception {
        VoiceCloneRequest self = new VoiceCloneRequest();
        return TeaModel.build(map, self);
    }

    public VoiceCloneRequest setText(String text) {
        this.text = text;
        return this;
    }
    public String getText() {
        return this.text;
    }

    public VoiceCloneRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public VoiceCloneRequest setVoiceId(String voiceId) {
        this.voiceId = voiceId;
        return this;
    }
    public String getVoiceId() {
        return this.voiceId;
    }

}
