// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryUserOnGoingConferenceRequest extends TeaModel {
    @NameInMap("operatorUnionId")
    public String operatorUnionId;

    @NameInMap("unionId")
    public String unionId;

    public static QueryUserOnGoingConferenceRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryUserOnGoingConferenceRequest self = new QueryUserOnGoingConferenceRequest();
        return TeaModel.build(map, self);
    }

    public QueryUserOnGoingConferenceRequest setOperatorUnionId(String operatorUnionId) {
        this.operatorUnionId = operatorUnionId;
        return this;
    }
    public String getOperatorUnionId() {
        return this.operatorUnionId;
    }

    public QueryUserOnGoingConferenceRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
