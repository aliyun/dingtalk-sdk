// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class LiandanTextImageGetResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<java.util.Map<String, ?>> result;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static LiandanTextImageGetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        LiandanTextImageGetResponseBody self = new LiandanTextImageGetResponseBody();
        return TeaModel.build(map, self);
    }

    public LiandanTextImageGetResponseBody setResult(java.util.List<java.util.Map<String, ?>> result) {
        this.result = result;
        return this;
    }
    public java.util.List<java.util.Map<String, ?>> getResult() {
        return this.result;
    }

    public LiandanTextImageGetResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
