// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class RespondEventRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("responseStatus")
    public String responseStatus;

    public static RespondEventRequest build(java.util.Map<String, ?> map) throws Exception {
        RespondEventRequest self = new RespondEventRequest();
        return TeaModel.build(map, self);
    }

    public RespondEventRequest setResponseStatus(String responseStatus) {
        this.responseStatus = responseStatus;
        return this;
    }
    public String getResponseStatus() {
        return this.responseStatus;
    }

}
