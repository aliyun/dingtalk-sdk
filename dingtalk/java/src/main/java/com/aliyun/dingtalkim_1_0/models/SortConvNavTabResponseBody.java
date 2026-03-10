// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SortConvNavTabResponseBody extends TeaModel {
    @NameInMap("success")
    public String success;

    public static SortConvNavTabResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SortConvNavTabResponseBody self = new SortConvNavTabResponseBody();
        return TeaModel.build(map, self);
    }

    public SortConvNavTabResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

}
