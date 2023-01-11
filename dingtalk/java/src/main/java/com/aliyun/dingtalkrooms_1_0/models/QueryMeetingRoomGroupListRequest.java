// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryMeetingRoomGroupListRequest extends TeaModel {
    /**
     * <p>操作人unionId</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static QueryMeetingRoomGroupListRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryMeetingRoomGroupListRequest self = new QueryMeetingRoomGroupListRequest();
        return TeaModel.build(map, self);
    }

    public QueryMeetingRoomGroupListRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
