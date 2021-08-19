// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class InsertSectionConfigResponseBody extends TeaModel {
    // 初始化是否成功。
    @NameInMap("result")
    public Boolean result;

    public static InsertSectionConfigResponseBody build(java.util.Map<String, ?> map) throws Exception {
        InsertSectionConfigResponseBody self = new InsertSectionConfigResponseBody();
        return TeaModel.build(map, self);
    }

    public InsertSectionConfigResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
