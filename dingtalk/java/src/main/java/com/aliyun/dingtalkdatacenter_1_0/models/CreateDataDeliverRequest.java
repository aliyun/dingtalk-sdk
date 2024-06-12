// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class CreateDataDeliverRequest extends TeaModel {
    @NameInMap("bizcode")
    public String bizcode;

    @NameInMap("param")
    public String param;

    @NameInMap("userId")
    public String userId;

    @NameInMap("dispatchingCycle")
    public String dispatchingCycle;

    @NameInMap("dispatchingItemType")
    public String dispatchingItemType;

    @NameInMap("dispatchingStartDate")
    public Long dispatchingStartDate;

    public static CreateDataDeliverRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateDataDeliverRequest self = new CreateDataDeliverRequest();
        return TeaModel.build(map, self);
    }

    public CreateDataDeliverRequest setBizcode(String bizcode) {
        this.bizcode = bizcode;
        return this;
    }
    public String getBizcode() {
        return this.bizcode;
    }

    public CreateDataDeliverRequest setParam(String param) {
        this.param = param;
        return this;
    }
    public String getParam() {
        return this.param;
    }

    public CreateDataDeliverRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public CreateDataDeliverRequest setDispatchingCycle(String dispatchingCycle) {
        this.dispatchingCycle = dispatchingCycle;
        return this;
    }
    public String getDispatchingCycle() {
        return this.dispatchingCycle;
    }

    public CreateDataDeliverRequest setDispatchingItemType(String dispatchingItemType) {
        this.dispatchingItemType = dispatchingItemType;
        return this;
    }
    public String getDispatchingItemType() {
        return this.dispatchingItemType;
    }

    public CreateDataDeliverRequest setDispatchingStartDate(Long dispatchingStartDate) {
        this.dispatchingStartDate = dispatchingStartDate;
        return this;
    }
    public Long getDispatchingStartDate() {
        return this.dispatchingStartDate;
    }

}
