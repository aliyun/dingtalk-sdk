// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class OpenKeyResultDTO extends TeaModel {
    @NameInMap("id")
    public String id;

    @NameInMap("progress")
    public Integer progress;

    @NameInMap("status")
    public Integer status;

    @NameInMap("title")
    public String title;

    @NameInMap("titleMentions")
    public java.util.List<TitleMention> titleMentions;

    @NameInMap("type")
    public Integer type;

    public static OpenKeyResultDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenKeyResultDTO self = new OpenKeyResultDTO();
        return TeaModel.build(map, self);
    }

    public OpenKeyResultDTO setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public OpenKeyResultDTO setProgress(Integer progress) {
        this.progress = progress;
        return this;
    }
    public Integer getProgress() {
        return this.progress;
    }

    public OpenKeyResultDTO setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
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

    public OpenKeyResultDTO setType(Integer type) {
        this.type = type;
        return this;
    }
    public Integer getType() {
        return this.type;
    }

}
