// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class UpdateObjectiveRequest extends TeaModel {
    /**
     * <p>当前 Objective 的内容。</p>
     */
    @NameInMap("content")
    public String content;

    /**
     * <p>当前用户的 userId。</p>
     */
    @NameInMap("userId")
    public String userId;

    public static UpdateObjectiveRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateObjectiveRequest self = new UpdateObjectiveRequest();
        return TeaModel.build(map, self);
    }

    public UpdateObjectiveRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public UpdateObjectiveRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
