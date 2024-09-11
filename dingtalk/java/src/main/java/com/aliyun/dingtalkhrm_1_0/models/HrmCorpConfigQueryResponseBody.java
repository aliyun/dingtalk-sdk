// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmCorpConfigQueryResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    public static HrmCorpConfigQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HrmCorpConfigQueryResponseBody self = new HrmCorpConfigQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public HrmCorpConfigQueryResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
