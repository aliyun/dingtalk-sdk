// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmeeting_1_0.models;

import com.aliyun.tea.*;

public class GetShanhuiByCalendarRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>VGZCWXpvTmxpQmorbUhiSXUveTB98Iok</p>
     */
    @NameInMap("eventId")
    public String eventId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>EUiSN7beu1Q2wR</p>
     */
    @NameInMap("userId")
    public String userId;

    public static GetShanhuiByCalendarRequest build(java.util.Map<String, ?> map) throws Exception {
        GetShanhuiByCalendarRequest self = new GetShanhuiByCalendarRequest();
        return TeaModel.build(map, self);
    }

    public GetShanhuiByCalendarRequest setEventId(String eventId) {
        this.eventId = eventId;
        return this;
    }
    public String getEventId() {
        return this.eventId;
    }

    public GetShanhuiByCalendarRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
