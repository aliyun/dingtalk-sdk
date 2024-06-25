// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class OpenKeyResultDTO extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>65222713d0e8b868f9f9ae51</p>
     */
    @NameInMap("krId")
    public String krId;

    /**
     * <strong>example:</strong>
     * <p>80</p>
     */
    @NameInMap("progress")
    public Long progress;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("status")
    public Long status;

    /**
     * <strong>example:</strong>
     * <p>这是一个KR</p>
     */
    @NameInMap("title")
    public String title;

    @NameInMap("titleMentions")
    public java.util.List<TitleMention> titleMentions;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("type")
    public Long type;

    /**
     * <strong>example:</strong>
     * <p>10.00</p>
     */
    @NameInMap("weight")
    public Double weight;

    public static OpenKeyResultDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenKeyResultDTO self = new OpenKeyResultDTO();
        return TeaModel.build(map, self);
    }

    public OpenKeyResultDTO setKrId(String krId) {
        this.krId = krId;
        return this;
    }
    public String getKrId() {
        return this.krId;
    }

    public OpenKeyResultDTO setProgress(Long progress) {
        this.progress = progress;
        return this;
    }
    public Long getProgress() {
        return this.progress;
    }

    public OpenKeyResultDTO setStatus(Long status) {
        this.status = status;
        return this;
    }
    public Long getStatus() {
        return this.status;
    }

    public OpenKeyResultDTO setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public OpenKeyResultDTO setTitleMentions(java.util.List<TitleMention> titleMentions) {
        this.titleMentions = titleMentions;
        return this;
    }
    public java.util.List<TitleMention> getTitleMentions() {
        return this.titleMentions;
    }

    public OpenKeyResultDTO setType(Long type) {
        this.type = type;
        return this;
    }
    public Long getType() {
        return this.type;
    }

    public OpenKeyResultDTO setWeight(Double weight) {
        this.weight = weight;
        return this;
    }
    public Double getWeight() {
        return this.weight;
    }

}
