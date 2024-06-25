// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoFaqAddRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>办公室的电话是：13222333232</p>
     */
    @NameInMap("answer")
    public String answer;

    /**
     * <strong>example:</strong>
     * <p>aaaaa</p>
     */
    @NameInMap("bizId")
    public String bizId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>111111</p>
     */
    @NameInMap("datasetId")
    public Long datasetId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>办公室的电话是多少</p>
     */
    @NameInMap("question")
    public String question;

    /**
     * <strong>example:</strong>
     * <p><a href="https://xxxxxxx.com/xxxxxx">https://xxxxxxx.com/xxxxxx</a></p>
     */
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
