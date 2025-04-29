// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class QueryGetContentJobResponseBody extends TeaModel {
    @NameInMap("contentKey")
    public String contentKey;

    @NameInMap("status")
    public Integer status;

    public static QueryGetContentJobResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryGetContentJobResponseBody self = new QueryGetContentJobResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryGetContentJobResponseBody setContentKey(String contentKey) {
        this.contentKey = contentKey;
        return this;
    }
    public String getContentKey() {
        return this.contentKey;
    }

    public QueryGetContentJobResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

}
