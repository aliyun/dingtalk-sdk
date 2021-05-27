// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class CancelCorpAuthResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static CancelCorpAuthResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CancelCorpAuthResponseBody self = new CancelCorpAuthResponseBody();
        return TeaModel.build(map, self);
    }

    public CancelCorpAuthResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
