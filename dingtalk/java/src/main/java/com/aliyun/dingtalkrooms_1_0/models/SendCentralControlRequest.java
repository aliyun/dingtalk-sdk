// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class SendCentralControlRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>{   &quot;version&quot;: &quot;1.0.0&quot;,    &quot;request&quot;: {     &quot;requestId&quot;: &quot;xxxx&quot;,      &quot;service&quot;: &quot;DTRooms.Meeting&quot;,      &quot;method&quot;: &quot;subscribe&quot;    } }</p>
     */
    @NameInMap("controlBody")
    public String controlBody;

    /**
     * <strong>example:</strong>
     * <p>0ffb7xxxxx</p>
     */
    @NameInMap("roomId")
    public String roomId;

    /**
     * <strong>example:</strong>
     * <p>2iPOLbpUNMLzB5LuwggiiqiPwiEiE</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static SendCentralControlRequest build(java.util.Map<String, ?> map) throws Exception {
        SendCentralControlRequest self = new SendCentralControlRequest();
        return TeaModel.build(map, self);
    }

    public SendCentralControlRequest setControlBody(String controlBody) {
        this.controlBody = controlBody;
        return this;
    }
    public String getControlBody() {
        return this.controlBody;
    }

    public SendCentralControlRequest setRoomId(String roomId) {
        this.roomId = roomId;
        return this;
    }
    public String getRoomId() {
        return this.roomId;
    }

    public SendCentralControlRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
