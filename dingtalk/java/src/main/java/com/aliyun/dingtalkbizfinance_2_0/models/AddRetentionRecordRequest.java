// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class AddRetentionRecordRequest extends TeaModel {
    @NameInMap("mobile")
    public String mobile;

    @NameInMap("stateCode")
    public String stateCode;

    public static AddRetentionRecordRequest build(java.util.Map<String, ?> map) throws Exception {
        AddRetentionRecordRequest self = new AddRetentionRecordRequest();
        return TeaModel.build(map, self);
    }

    public AddRetentionRecordRequest setMobile(String mobile) {
        this.mobile = mobile;
        return this;
    }
    public String getMobile() {
        return this.mobile;
    }

    public AddRetentionRecordRequest setStateCode(String stateCode) {
        this.stateCode = stateCode;
        return this;
    }
    public String getStateCode() {
        return this.stateCode;
    }

}
