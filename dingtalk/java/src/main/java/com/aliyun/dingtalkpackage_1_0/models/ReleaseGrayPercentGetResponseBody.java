// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class ReleaseGrayPercentGetResponseBody extends TeaModel {
    @NameInMap("value")
    public Float value;

    public static ReleaseGrayPercentGetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ReleaseGrayPercentGetResponseBody self = new ReleaseGrayPercentGetResponseBody();
        return TeaModel.build(map, self);
    }

    public ReleaseGrayPercentGetResponseBody setValue(Float value) {
        this.value = value;
        return this;
    }
    public Float getValue() {
        return this.value;
    }

}
