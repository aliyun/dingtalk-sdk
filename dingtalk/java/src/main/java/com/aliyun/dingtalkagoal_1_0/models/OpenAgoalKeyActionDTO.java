// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class OpenAgoalKeyActionDTO extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>6444f5e9a4261c6e699dxxxx</p>
     */
    @NameInMap("keyActionId")
    public String keyActionId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>测试</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p><a href="https://agoal.dingtalk.com">https://agoal.dingtalk.com</a></p>
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
