// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class ReleaseGrayUserIdGetResponseBody extends TeaModel {
    @NameInMap("value")
    public java.util.List<String> value;

    public static ReleaseGrayUserIdGetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ReleaseGrayUserIdGetResponseBody self = new ReleaseGrayUserIdGetResponseBody();
        return TeaModel.build(map, self);
    }

    public ReleaseGrayUserIdGetResponseBody setValue(java.util.List<String> value) {
        this.value = value;
        return this;
    }
    public java.util.List<String> getValue() {
        return this.value;
    }

}
