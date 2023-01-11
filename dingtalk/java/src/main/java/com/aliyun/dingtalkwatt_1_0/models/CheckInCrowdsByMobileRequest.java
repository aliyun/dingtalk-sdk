// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwatt_1_0.models;

import com.aliyun.tea.*;

public class CheckInCrowdsByMobileRequest extends TeaModel {
    /**
     * <p>人群id</p>
     */
    @NameInMap("crowdIds")
    public byte[] crowdIds;

    /**
     * <p>要校验的用户手机号，AES256+Base64方式加密</p>
     */
    @NameInMap("mobile")
    public String mobile;

    public static CheckInCrowdsByMobileRequest build(java.util.Map<String, ?> map) throws Exception {
        CheckInCrowdsByMobileRequest self = new CheckInCrowdsByMobileRequest();
        return TeaModel.build(map, self);
    }

    public CheckInCrowdsByMobileRequest setCrowdIds(byte[] crowdIds) {
        this.crowdIds = crowdIds;
        return this;
    }
    public byte[] getCrowdIds() {
        return this.crowdIds;
    }

    public CheckInCrowdsByMobileRequest setMobile(String mobile) {
        this.mobile = mobile;
        return this;
    }
    public String getMobile() {
        return this.mobile;
    }

}
