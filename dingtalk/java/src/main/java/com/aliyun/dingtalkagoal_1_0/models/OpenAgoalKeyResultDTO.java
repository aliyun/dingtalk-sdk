// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class OpenAgoalKeyResultDTO extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("keyActions")
    public java.util.List<OpenAgoalKeyActionDTO> keyActions;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("keyResultId")
    public String keyResultId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("progress")
    public Integer progress;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("status")
    public Integer status;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("titleMentions")
    public java.util.List<TitleMention> titleMentions;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("type")
    public Integer type;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("weight")
    public Double weight;

    public static OpenAgoalKeyResultDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenAgoalKeyResultDTO self = new OpenAgoalKeyResultDTO();
        return TeaModel.build(map, self);
    }

    public OpenAgoalKeyResultDTO setKeyActions(java.util.List<OpenAgoalKeyActionDTO> keyActions) {
        this.keyActions = keyActions;
        return this;
    }
    public java.util.List<OpenAgoalKeyActionDTO> getKeyActions() {
        return this.keyActions;
    }

    public OpenAgoalKeyResultDTO setKeyResultId(String keyResultId) {
        this.keyResultId = keyResultId;
        return this;
    }
    public String getKeyResultId() {
        return this.keyResultId;
    }

    public OpenAgoalKeyResultDTO setProgress(Integer progress) {
        this.progress = progress;
        return this;
    }
    public Integer getProgress() {
        return this.progress;
    }

    public OpenAgoalKeyResultDTO setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public OpenAgoalKeyResultDTO setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public OpenAgoalKeyResultDTO setTitleMentions(java.util.List<TitleMention> titleMentions) {
        this.titleMentions = titleMentions;
        return this;
    }
    public java.util.List<TitleMention> getTitleMentions() {
        return this.titleMentions;
    }

    public OpenAgoalKeyResultDTO setType(Integer type) {
        this.type = type;
        return this;
    }
    public Integer getType() {
        return this.type;
    }

    public OpenAgoalKeyResultDTO setWeight(Double weight) {
        this.weight = weight;
        return this;
    }
    public Double getWeight() {
        return this.weight;
    }

}
