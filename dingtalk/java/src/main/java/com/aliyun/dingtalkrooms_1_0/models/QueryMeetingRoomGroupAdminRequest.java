// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryMeetingRoomGroupAdminRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>2iPOLbpUNMLzB5LuwggiiqiPwiEiE</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static QueryMeetingRoomGroupAdminRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryMeetingRoomGroupAdminRequest self = new QueryMeetingRoomGroupAdminRequest();
        return TeaModel.build(map, self);
    }

    public QueryMeetingRoomGroupAdminRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
