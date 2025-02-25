// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SetBorderResponseBody extends TeaModel {
    @NameInMap("data")
    public Object data;

    public static SetBorderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetBorderResponseBody self = new SetBorderResponseBody();
        return TeaModel.build(map, self);
    }

    public SetBorderResponseBody setData(Object data) {
        this.data = data;
        return this;
    }
    public Object getData() {
        return this.data;
    }

}
