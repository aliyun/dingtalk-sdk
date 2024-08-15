// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class OpenAgoalProgressDTO extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("created")
    public Long created;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("creator")
    public OpenAgoalUserDTO creator;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("htmlContent")
    public String htmlContent;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("modifier")
    public OpenAgoalUserDTO modifier;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("progressId")
    public String progressId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("updated")
    public Long updated;

    public static OpenAgoalProgressDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenAgoalProgressDTO self = new OpenAgoalProgressDTO();
        return TeaModel.build(map, self);
    }

    public OpenAgoalProgressDTO setCreated(Long created) {
        this.created = created;
        return this;
    }
    public Long getCreated() {
        return this.created;
    }

    public OpenAgoalProgressDTO setCreator(OpenAgoalUserDTO creator) {
        this.creator = creator;
        return this;
    }
    public OpenAgoalUserDTO getCreator() {
        return this.creator;
    }

    public OpenAgoalProgressDTO setHtmlContent(String htmlContent) {
        this.htmlContent = htmlContent;
        return this;
    }
    public String getHtmlContent() {
        return this.htmlContent;
    }

    public OpenAgoalProgressDTO setModifier(OpenAgoalUserDTO modifier) {
        this.modifier = modifier;
        return this;
    }
    public OpenAgoalUserDTO getModifier() {
        return this.modifier;
    }

    public OpenAgoalProgressDTO setProgressId(String progressId) {
        this.progressId = progressId;
        return this;
    }
    public String getProgressId() {
        return this.progressId;
    }

    public OpenAgoalProgressDTO setUpdated(Long updated) {
        this.updated = updated;
        return this;
    }
    public Long getUpdated() {
        return this.updated;
    }

}
