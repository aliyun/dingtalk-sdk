// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoFaqAddRequest extends TeaModel {
    @NameInMap("answer")
    public String answer;

    @NameInMap("bizId")
    public String bizId;

    @NameInMap("datasetId")
    public Long datasetId;

    @NameInMap("question")
    public String question;

    @NameInMap("redirection")
    public String redirection;

    public static ChatMemoFaqAddRequest build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoFaqAddRequest self = new ChatMemoFaqAddRequest();
        return TeaModel.build(map, self);
    }

    public ChatMemoFaqAddRequest setAnswer(String answer) {
        this.answer = answer;
        return this;
    }
    public String getAnswer() {
        return this.answer;
    }

    public ChatMemoFaqAddRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public ChatMemoFaqAddRequest setDatasetId(Long datasetId) {
        this.datasetId = datasetId;
        return this;
    }
    public Long getDatasetId() {
        return this.datasetId;
    }

    public ChatMemoFaqAddRequest setQuestion(String question) {
        this.question = question;
        return this;
    }
    public String getQuestion() {
        return this.question;
    }

    public ChatMemoFaqAddRequest setRedirection(String redirection) {
        this.redirection = redirection;
        return this;
    }
    public String getRedirection() {
        return this.redirection;
    }

}
