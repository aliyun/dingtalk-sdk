// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class VoiceCloneRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>你好，我叫小智，是来自阿里云的超大规模语言模型。我是一个能够回答问题、创作文字，还能表达观点、撰写代码的全能型AI助手。如果您有任何问题或需要帮助，请随时告诉我，我会尽我所能为您提供帮助！</p>
     */
    @NameInMap("text")
    public String text;

    /**
     * <strong>example:</strong>
     * <p>manager4224</p>
     */
    @NameInMap("userId")
    public String userId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>qhtestvoice-01</p>
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
