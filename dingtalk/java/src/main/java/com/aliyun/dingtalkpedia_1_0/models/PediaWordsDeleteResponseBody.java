// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpedia_1_0.models;

import com.aliyun.tea.*;

public class PediaWordsDeleteResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    @NameInMap("uuid")
    public Long uuid;

    public static PediaWordsDeleteResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PediaWordsDeleteResponseBody self = new PediaWordsDeleteResponseBody();
        return TeaModel.build(map, self);
    }

    public PediaWordsDeleteResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public PediaWordsDeleteResponseBody setUuid(Long uuid) {
        this.uuid = uuid;
        return this;
    }
    public Long getUuid() {
        return this.uuid;
    }

}
