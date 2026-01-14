// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_global_e_c_1_0.models;

import com.aliyun.tea.*;

public class HhoCallBackRequest extends TeaModel {
    @NameInMap("data")
    public String data;

    @NameInMap("dtNotificationId")
    public String dtNotificationId;

    @NameInMap("shopId")
    public String shopId;

    @NameInMap("timestamp")
    public String timestamp;

    @NameInMap("type")
    public Integer type;

    public static HhoCallBackRequest build(java.util.Map<String, ?> map) throws Exception {
        HhoCallBackRequest self = new HhoCallBackRequest();
        return TeaModel.build(map, self);
    }

    public HhoCallBackRequest setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public HhoCallBackRequest setDtNotificationId(String dtNotificationId) {
        this.dtNotificationId = dtNotificationId;
        return this;
    }
    public String getDtNotificationId() {
        return this.dtNotificationId;
    }

    public HhoCallBackRequest setShopId(String shopId) {
        this.shopId = shopId;
        return this;
    }
    public String getShopId() {
        return this.shopId;
    }

    public HhoCallBackRequest setTimestamp(String timestamp) {
        this.timestamp = timestamp;
        return this;
    }
    public String getTimestamp() {
        return this.timestamp;
    }

    public HhoCallBackRequest setType(Integer type) {
        this.type = type;
        return this;
    }
    public Integer getType() {
        return this.type;
    }

}
