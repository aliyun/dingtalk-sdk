// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class QueryItemByUrlRequest extends TeaModel {
    @NameInMap("operatorId")
    public String operatorId;

    @NameInMap("url")
    public String url;

    @NameInMap("withStatisticalInfo")
    public Boolean withStatisticalInfo;

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

    public QueryItemByUrlRequest setWithStatisticalInfo(Boolean withStatisticalInfo) {
        this.withStatisticalInfo = withStatisticalInfo;
        return this;
    }
    public Boolean getWithStatisticalInfo() {
        return this.withStatisticalInfo;
    }

}
