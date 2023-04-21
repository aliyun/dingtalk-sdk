// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpedia_1_0.models;

import com.aliyun.tea.*;

public class PediaWordsDeleteRequest extends TeaModel {
    /**
     * <p>当前操作用户编号</p>
     */
    @NameInMap("userId")
    public String userId;

    /**
     * <p>当前需要删除的词条主键编号</p>
     */
    @NameInMap("uuid")
    public Long uuid;

    public static PediaWordsDeleteRequest build(java.util.Map<String, ?> map) throws Exception {
        PediaWordsDeleteRequest self = new PediaWordsDeleteRequest();
        return TeaModel.build(map, self);
    }

    public PediaWordsDeleteRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public PediaWordsDeleteRequest setUuid(Long uuid) {
        this.uuid = uuid;
        return this;
    }
    public Long getUuid() {
        return this.uuid;
    }

}
