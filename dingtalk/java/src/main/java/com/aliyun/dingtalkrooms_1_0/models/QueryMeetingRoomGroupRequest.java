// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryMeetingRoomGroupRequest extends TeaModel {
    /**
     * <p>操作人unionId</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static QueryMeetingRoomGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryMeetingRoomGroupRequest self = new QueryMeetingRoomGroupRequest();
        return TeaModel.build(map, self);
    }

    public QueryMeetingRoomGroupRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
