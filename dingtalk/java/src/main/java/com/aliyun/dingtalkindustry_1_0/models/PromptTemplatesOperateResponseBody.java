// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class PromptTemplatesOperateResponseBody extends TeaModel {
    @NameInMap("bizCode")
    public String bizCode;

    @NameInMap("content")
    public String content;

    @NameInMap("description")
    public String description;

    @NameInMap("placeholderCount")
    public Integer placeholderCount;

    @NameInMap("source")
    public String source;

    public static PromptTemplatesOperateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PromptTemplatesOperateResponseBody self = new PromptTemplatesOperateResponseBody();
        return TeaModel.build(map, self);
    }

    public PromptTemplatesOperateResponseBody setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public PromptTemplatesOperateResponseBody setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public PromptTemplatesOperateResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public PromptTemplatesOperateResponseBody setPlaceholderCount(Integer placeholderCount) {
        this.placeholderCount = placeholderCount;
        return this;
    }
    public Integer getPlaceholderCount() {
        return this.placeholderCount;
    }

    public PromptTemplatesOperateResponseBody setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

}
