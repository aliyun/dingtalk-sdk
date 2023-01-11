// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SaveAcrossCloudStroageConfigsResponseBody extends TeaModel {
    /**
     * <p>密匙ID</p>
     */
    @NameInMap("accessKeyId")
    public String accessKeyId;

    /**
     * <p>存储域名地址</p>
     */
    @NameInMap("endpoint")
    public String endpoint;

    /**
     * <p>执行结果</p>
     */
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
