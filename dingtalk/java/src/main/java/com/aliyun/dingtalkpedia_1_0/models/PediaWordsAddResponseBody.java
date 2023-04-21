// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpedia_1_0.models;

import com.aliyun.tea.*;

public class PediaWordsAddResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     * <p>false，失败</p>
     * <p>true，成功</p>
     */
    @NameInMap("success")
    public Boolean success;

    /**
     * <p>插入成功后的编号主键ID</p>
     * <br>
     */
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
