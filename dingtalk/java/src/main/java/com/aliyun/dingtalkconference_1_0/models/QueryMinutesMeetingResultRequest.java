// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryMinutesMeetingResultRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static QueryMinutesMeetingResultRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryMinutesMeetingResultRequest self = new QueryMinutesMeetingResultRequest();
        return TeaModel.build(map, self);
    }

    public QueryMinutesMeetingResultRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
