// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapp_market_1_0.models;

import com.aliyun.tea.*;

public class NotifyOnCrmDataChangeRequest extends TeaModel {
    @NameInMap("dataId")
    public String dataId;

    @NameInMap("extension")
    public java.util.Map<String, String> extension;

    @NameInMap("operate")
    public String operate;

    @NameInMap("type")
    public String type;

    public static NotifyOnCrmDataChangeRequest build(java.util.Map<String, ?> map) throws Exception {
        NotifyOnCrmDataChangeRequest self = new NotifyOnCrmDataChangeRequest();
        return TeaModel.build(map, self);
    }

    public NotifyOnCrmDataChangeRequest setDataId(String dataId) {
        this.dataId = dataId;
        return this;
    }
    public String getDataId() {
        return this.dataId;
    }

    public NotifyOnCrmDataChangeRequest setExtension(java.util.Map<String, String> extension) {
        this.extension = extension;
        return this;
    }
    public java.util.Map<String, String> getExtension() {
        return this.extension;
    }

    public NotifyOnCrmDataChangeRequest setOperate(String operate) {
        this.operate = operate;
        return this;
    }
    public String getOperate() {
        return this.operate;
    }

    public NotifyOnCrmDataChangeRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
