// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpedia_1_0.models;

import com.aliyun.tea.*;

public class PediaWordsUpdateResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    @NameInMap("uuid")
    public Long uuid;

    public static PediaWordsUpdateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PediaWordsUpdateResponseBody self = new PediaWordsUpdateResponseBody();
        return TeaModel.build(map, self);
    }

    public PediaWordsUpdateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public PediaWordsUpdateResponseBody setUuid(Long uuid) {
        this.uuid = uuid;
        return this;
    }
    public Long getUuid() {
        return this.uuid;
    }

}
