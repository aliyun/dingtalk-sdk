// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class AiVoucherRequest extends TeaModel {
    @NameInMap("chatMessages")
    public String chatMessages;

    @NameInMap("enableThinking")
    public Boolean enableThinking;

    @NameInMap("extendInfo")
    public String extendInfo;

    @NameInMap("prompt")
    public String prompt;

    public static AiVoucherRequest build(java.util.Map<String, ?> map) throws Exception {
        AiVoucherRequest self = new AiVoucherRequest();
        return TeaModel.build(map, self);
    }

    public AiVoucherRequest setChatMessages(String chatMessages) {
        this.chatMessages = chatMessages;
        return this;
    }
    public String getChatMessages() {
        return this.chatMessages;
    }

    public AiVoucherRequest setEnableThinking(Boolean enableThinking) {
        this.enableThinking = enableThinking;
        return this;
    }
    public Boolean getEnableThinking() {
        return this.enableThinking;
    }

    public AiVoucherRequest setExtendInfo(String extendInfo) {
        this.extendInfo = extendInfo;
        return this;
    }
    public String getExtendInfo() {
        return this.extendInfo;
    }

    public AiVoucherRequest setPrompt(String prompt) {
        this.prompt = prompt;
        return this;
    }
    public String getPrompt() {
        return this.prompt;
    }

}
