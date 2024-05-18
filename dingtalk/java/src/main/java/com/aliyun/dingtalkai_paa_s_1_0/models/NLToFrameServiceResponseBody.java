// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class NLToFrameServiceResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    public static NLToFrameServiceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        NLToFrameServiceResponseBody self = new NLToFrameServiceResponseBody();
        return TeaModel.build(map, self);
    }

    public NLToFrameServiceResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
