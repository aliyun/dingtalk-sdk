// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpedia_1_0.models;

import com.aliyun.tea.*;

public class PediaWordsQueryRequest extends TeaModel {
    /**
     * <p>操作用户编号</p>
     */
    @NameInMap("userId")
    public String userId;

    /**
     * <p>查询主键编号</p>
     */
    @NameInMap("uuid")
    public Long uuid;

    public static PediaWordsQueryRequest build(java.util.Map<String, ?> map) throws Exception {
        PediaWordsQueryRequest self = new PediaWordsQueryRequest();
        return TeaModel.build(map, self);
    }

    public PediaWordsQueryRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public PediaWordsQueryRequest setUuid(Long uuid) {
        this.uuid = uuid;
        return this;
    }
    public Long getUuid() {
        return this.uuid;
    }

}
