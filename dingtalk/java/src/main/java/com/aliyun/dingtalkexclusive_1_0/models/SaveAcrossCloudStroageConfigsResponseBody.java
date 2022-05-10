// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SaveAcrossCloudStroageConfigsResponseBody extends TeaModel {
    // 密匙ID
    @NameInMap("accessKeyId")
    public String accessKeyId;

    // 存储域名地址
    @NameInMap("endpoint")
    public String endpoint;

    // 执行结果
    @NameInMap("state")
    public Integer state;

    public static SaveAcrossCloudStroageConfigsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SaveAcrossCloudStroageConfigsResponseBody self = new SaveAcrossCloudStroageConfigsResponseBody();
        return TeaModel.build(map, self);
    }

    public SaveAcrossCloudStroageConfigsResponseBody setAccessKeyId(String accessKeyId) {
        this.accessKeyId = accessKeyId;
        return this;
    }
    public String getAccessKeyId() {
        return this.accessKeyId;
    }

    public SaveAcrossCloudStroageConfigsResponseBody setEndpoint(String endpoint) {
        this.endpoint = endpoint;
        return this;
    }
    public String getEndpoint() {
        return this.endpoint;
    }

    public SaveAcrossCloudStroageConfigsResponseBody setState(Integer state) {
        this.state = state;
        return this;
    }
    public Integer getState() {
        return this.state;
    }

}
