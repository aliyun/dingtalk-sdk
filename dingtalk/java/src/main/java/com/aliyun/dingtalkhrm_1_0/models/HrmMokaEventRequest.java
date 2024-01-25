// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmMokaEventRequest extends TeaModel {
    @NameInMap("bizId")
    public String bizId;

    @NameInMap("content")
    public String content;

    public static HrmMokaEventRequest build(java.util.Map<String, ?> map) throws Exception {
        HrmMokaEventRequest self = new HrmMokaEventRequest();
        return TeaModel.build(map, self);
    }

    public HrmMokaEventRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public HrmMokaEventRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

}
