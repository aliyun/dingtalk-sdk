// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryScheduleConfMinutesRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("eventId")
    public String eventId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static QueryScheduleConfMinutesRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryScheduleConfMinutesRequest self = new QueryScheduleConfMinutesRequest();
        return TeaModel.build(map, self);
    }

    public QueryScheduleConfMinutesRequest setEventId(String eventId) {
        this.eventId = eventId;
        return this;
    }
    public String getEventId() {
        return this.eventId;
    }

    public QueryScheduleConfMinutesRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
