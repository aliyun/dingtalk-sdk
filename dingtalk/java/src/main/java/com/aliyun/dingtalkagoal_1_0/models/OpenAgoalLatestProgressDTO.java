// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class OpenAgoalLatestProgressDTO extends TeaModel {
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
    @NameInMap("htmldescription")
    public String htmldescription;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("progressId")
    public String progressId;

    public static OpenAgoalLatestProgressDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenAgoalLatestProgressDTO self = new OpenAgoalLatestProgressDTO();
        return TeaModel.build(map, self);
    }

    public OpenAgoalLatestProgressDTO setCreated(Long created) {
        this.created = created;
        return this;
    }
    public Long getCreated() {
        return this.created;
    }

    public OpenAgoalLatestProgressDTO setCreator(OpenAgoalUserDTO creator) {
        this.creator = creator;
        return this;
    }
    public OpenAgoalUserDTO getCreator() {
        return this.creator;
    }

    public OpenAgoalLatestProgressDTO setHtmldescription(String htmldescription) {
        this.htmldescription = htmldescription;
        return this;
    }
    public String getHtmldescription() {
        return this.htmldescription;
    }

    public OpenAgoalLatestProgressDTO setProgressId(String progressId) {
        this.progressId = progressId;
        return this;
    }
    public String getProgressId() {
        return this.progressId;
    }

}
