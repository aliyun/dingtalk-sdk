// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SaveAndSubmitAuthInfoResponseBody extends TeaModel {
    // 密匙ID
    @NameInMap("accessKeyId")
    public String accessKeyId;

    // OSS链接
    @NameInMap("oss")
    public String oss;

    public static SaveAndSubmitAuthInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SaveAndSubmitAuthInfoResponseBody self = new SaveAndSubmitAuthInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public SaveAndSubmitAuthInfoResponseBody setAccessKeyId(String accessKeyId) {
        this.accessKeyId = accessKeyId;
        return this;
    }
    public String getAccessKeyId() {
        return this.accessKeyId;
    }

    public SaveAndSubmitAuthInfoResponseBody setOss(String oss) {
        this.oss = oss;
        return this;
    }
    public String getOss() {
        return this.oss;
    }

}
