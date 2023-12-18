// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocUpdateContentResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static DocUpdateContentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DocUpdateContentResponseBody self = new DocUpdateContentResponseBody();
        return TeaModel.build(map, self);
    }

    public DocUpdateContentResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
