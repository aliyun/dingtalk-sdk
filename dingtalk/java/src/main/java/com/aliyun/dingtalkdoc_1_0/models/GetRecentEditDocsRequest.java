// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetRecentEditDocsRequest extends TeaModel {
    // 发起操作用户unionId
    @NameInMap("operatorId")
    public String operatorId;

    // 查询size
    @NameInMap("size")
    public Integer size;

    @NameInMap("loadMoreId")
    public String loadMoreId;

    public static GetRecentEditDocsRequest build(java.util.Map<String, ?> map) throws Exception {
        GetRecentEditDocsRequest self = new GetRecentEditDocsRequest();
        return TeaModel.build(map, self);
    }

    public GetRecentEditDocsRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public GetRecentEditDocsRequest setSize(Integer size) {
        this.size = size;
        return this;
    }
    public Integer getSize() {
        return this.size;
    }

    public GetRecentEditDocsRequest setLoadMoreId(String loadMoreId) {
        this.loadMoreId = loadMoreId;
        return this;
    }
    public String getLoadMoreId() {
        return this.loadMoreId;
    }

}
