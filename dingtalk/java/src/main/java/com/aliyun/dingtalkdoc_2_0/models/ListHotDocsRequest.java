// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListHotDocsRequest extends TeaModel {
    // 操作用户unionId。
    @NameInMap("operatorId")
    public String operatorId;

    public static ListHotDocsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListHotDocsRequest self = new ListHotDocsRequest();
        return TeaModel.build(map, self);
    }

    public ListHotDocsRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
