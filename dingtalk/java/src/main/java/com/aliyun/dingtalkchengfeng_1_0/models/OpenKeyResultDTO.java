// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class OpenKeyResultDTO extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("id")
    public String id;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>33</p>
     */
    @NameInMap("progress")
    public Integer progress;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("status")
    public Integer status;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>完成数据迁移</p>
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
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
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
