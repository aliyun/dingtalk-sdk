// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpedia_1_0.models;

import com.aliyun.tea.*;

public class PediaWordsAddResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    @NameInMap("uuid")
    public Long uuid;

    public static PediaWordsAddResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PediaWordsAddResponseBody self = new PediaWordsAddResponseBody();
        return TeaModel.build(map, self);
    }

    public PediaWordsAddResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public PediaWordsAddResponseBody setUuid(Long uuid) {
        this.uuid = uuid;
        return this;
    }
    public Long getUuid() {
        return this.uuid;
    }

}
