// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class AiVoucherResponseBody extends TeaModel {
    @NameInMap("content")
    public String content;

    public static AiVoucherResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AiVoucherResponseBody self = new AiVoucherResponseBody();
        return TeaModel.build(map, self);
    }

    public AiVoucherResponseBody setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

}
