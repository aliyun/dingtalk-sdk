// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpedia_1_0.models;

import com.aliyun.tea.*;

public class PediaWordsUpdateResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     * <p>false，失败</p>
     * <p>true,成功</p>
     */
    @NameInMap("success")
    public Boolean success;

    /**
     * <p>更新后待审核词条编号</p>
     */
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
