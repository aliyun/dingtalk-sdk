// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryScheduleConferenceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("requestUnionId")
    public String requestUnionId;

    public static QueryScheduleConferenceRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryScheduleConferenceRequest self = new QueryScheduleConferenceRequest();
        return TeaModel.build(map, self);
    }

    public QueryScheduleConferenceRequest setRequestUnionId(String requestUnionId) {
        this.requestUnionId = requestUnionId;
        return this;
    }
    public String getRequestUnionId() {
        return this.requestUnionId;
    }

}
