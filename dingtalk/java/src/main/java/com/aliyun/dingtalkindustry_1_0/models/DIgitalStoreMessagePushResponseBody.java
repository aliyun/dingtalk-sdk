// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DIgitalStoreMessagePushResponseBody extends TeaModel {
    @NameInMap("content")
    public Boolean content;

    public static DIgitalStoreMessagePushResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DIgitalStoreMessagePushResponseBody self = new DIgitalStoreMessagePushResponseBody();
        return TeaModel.build(map, self);
    }

    public DIgitalStoreMessagePushResponseBody setContent(Boolean content) {
        this.content = content;
        return this;
    }
    public Boolean getContent() {
        return this.content;
    }

}
