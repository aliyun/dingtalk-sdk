// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class UninstallDeviceRobotResponseBody extends TeaModel {
    /**
     * <p>接口处理返回结果，内容为群的唯一标识。</p>
     */
    @NameInMap("result")
    public String result;

    /**
     * <p>接口处理是否成功。</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static UninstallDeviceRobotResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UninstallDeviceRobotResponseBody self = new UninstallDeviceRobotResponseBody();
        return TeaModel.build(map, self);
    }

    public UninstallDeviceRobotResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public UninstallDeviceRobotResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
