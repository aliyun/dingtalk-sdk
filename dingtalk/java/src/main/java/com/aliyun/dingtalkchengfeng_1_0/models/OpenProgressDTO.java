// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class OpenProgressDTO extends TeaModel {
    /**
     * <p>创建时间戳</p>
     */
    @NameInMap("created")
    public Long created;

    /**
     * <p>创建人信息</p>
     */
    @NameInMap("creator")
    public OpenUserDTO creator;

    /**
     * <p>进展内容</p>
     */
    @NameInMap("htmlContent")
    public String htmlContent;

    /**
     * <p>主键</p>
     */
    @NameInMap("id")
    public String id;

    /**
     * <p>更新人信息</p>
     */
    @NameInMap("modifier")
    public OpenUserDTO modifier;

    /**
     * <p>更新时间戳</p>
     */
    @NameInMap("updated")
    public Long updated;

    public static OpenProgressDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenProgressDTO self = new OpenProgressDTO();
        return TeaModel.build(map, self);
    }

    public OpenProgressDTO setCreated(Long created) {
        this.created = created;
        return this;
    }
    public Long getCreated() {
        return this.created;
    }

    public OpenProgressDTO setCreator(OpenUserDTO creator) {
        this.creator = creator;
        return this;
    }
    public OpenUserDTO getCreator() {
        return this.creator;
    }

    public OpenProgressDTO setHtmlContent(String htmlContent) {
        this.htmlContent = htmlContent;
        return this;
    }
    public String getHtmlContent() {
        return this.htmlContent;
    }

    public OpenProgressDTO setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public OpenProgressDTO setModifier(OpenUserDTO modifier) {
        this.modifier = modifier;
        return this;
    }
    public OpenUserDTO getModifier() {
        return this.modifier;
    }

    public OpenProgressDTO setUpdated(Long updated) {
        this.updated = updated;
        return this;
    }
    public Long getUpdated() {
        return this.updated;
    }

}
