// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class OpenAgoalKeyActionDTO extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("keyActionId")
    public String keyActionId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("url")
    public String url;

    public static OpenAgoalKeyActionDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenAgoalKeyActionDTO self = new OpenAgoalKeyActionDTO();
        return TeaModel.build(map, self);
    }

    public OpenAgoalKeyActionDTO setKeyActionId(String keyActionId) {
        this.keyActionId = keyActionId;
        return this;
    }
    public String getKeyActionId() {
        return this.keyActionId;
    }

    public OpenAgoalKeyActionDTO setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public OpenAgoalKeyActionDTO setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

}
