// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryMeetingRoomRequest extends TeaModel {
    // 操作人unionId
    @NameInMap("unionId")
    public String unionId;

    public static QueryMeetingRoomRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryMeetingRoomRequest self = new QueryMeetingRoomRequest();
        return TeaModel.build(map, self);
    }

    public QueryMeetingRoomRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
