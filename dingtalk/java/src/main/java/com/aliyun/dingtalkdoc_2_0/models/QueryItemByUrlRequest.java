// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class QueryItemByUrlRequest extends TeaModel {
    // 操作用户unionId。
    @NameInMap("operatorId")
    public String operatorId;

    // 链接url。
    @NameInMap("url")
    public String url;

    public static QueryItemByUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryItemByUrlRequest self = new QueryItemByUrlRequest();
        return TeaModel.build(map, self);
    }

    public QueryItemByUrlRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public QueryItemByUrlRequest setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

}
