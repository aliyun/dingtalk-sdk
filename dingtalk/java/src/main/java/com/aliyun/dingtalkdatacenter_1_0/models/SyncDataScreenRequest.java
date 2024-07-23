// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class SyncDataScreenRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("screenId")
    public String screenId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ABC</p>
     */
    @NameInMap("ticket")
    public String ticket;

    public static SyncDataScreenRequest build(java.util.Map<String, ?> map) throws Exception {
        SyncDataScreenRequest self = new SyncDataScreenRequest();
        return TeaModel.build(map, self);
    }

    public SyncDataScreenRequest setScreenId(String screenId) {
        this.screenId = screenId;
        return this;
    }
    public String getScreenId() {
        return this.screenId;
    }

    public SyncDataScreenRequest setTicket(String ticket) {
        this.ticket = ticket;
        return this;
    }
    public String getTicket() {
        return this.ticket;
    }

}
