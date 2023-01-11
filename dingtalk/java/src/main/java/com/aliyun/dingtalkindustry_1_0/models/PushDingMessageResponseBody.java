// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class PushDingMessageResponseBody extends TeaModel {
    /**
     * <p>返回1表示当前批次成功</p>
     */
    @NameInMap("content")
    public Long content;

    @NameInMap("success")
    public Boolean success;

    public static PushDingMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PushDingMessageResponseBody self = new PushDingMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public PushDingMessageResponseBody setContent(Long content) {
        this.content = content;
        return this;
    }
    public Long getContent() {
        return this.content;
    }

    public PushDingMessageResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
