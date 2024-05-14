// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class TransferEventRequest extends TeaModel {
    @NameInMap("isExitCalendar")
    public Boolean isExitCalendar;

    @NameInMap("needNotifyViaO2O")
    public Boolean needNotifyViaO2O;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("newOrganizerId")
    public String newOrganizerId;

    public static TransferEventRequest build(java.util.Map<String, ?> map) throws Exception {
        TransferEventRequest self = new TransferEventRequest();
        return TeaModel.build(map, self);
    }

    public TransferEventRequest setIsExitCalendar(Boolean isExitCalendar) {
        this.isExitCalendar = isExitCalendar;
        return this;
    }
    public Boolean getIsExitCalendar() {
        return this.isExitCalendar;
    }

    public TransferEventRequest setNeedNotifyViaO2O(Boolean needNotifyViaO2O) {
        this.needNotifyViaO2O = needNotifyViaO2O;
        return this;
    }
    public Boolean getNeedNotifyViaO2O() {
        return this.needNotifyViaO2O;
    }

    public TransferEventRequest setNewOrganizerId(String newOrganizerId) {
        this.newOrganizerId = newOrganizerId;
        return this;
    }
    public String getNewOrganizerId() {
        return this.newOrganizerId;
    }

}
