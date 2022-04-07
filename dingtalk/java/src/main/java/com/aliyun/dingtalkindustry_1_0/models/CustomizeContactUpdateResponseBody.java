// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactUpdateResponseBody extends TeaModel {
    // 是否操作成功
    @NameInMap("content")
    public Boolean content;

    public static CustomizeContactUpdateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactUpdateResponseBody self = new CustomizeContactUpdateResponseBody();
        return TeaModel.build(map, self);
    }

    public CustomizeContactUpdateResponseBody setContent(Boolean content) {
        this.content = content;
        return this;
    }
    public Boolean getContent() {
        return this.content;
    }

}
