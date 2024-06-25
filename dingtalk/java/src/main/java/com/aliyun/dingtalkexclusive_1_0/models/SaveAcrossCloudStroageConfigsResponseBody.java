// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SaveAcrossCloudStroageConfigsResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>sampleKeyId1234</p>
     */
    @NameInMap("accessKeyId")
    public String accessKeyId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p><a href="https://oss-cn-test.aliyuncs.com">https://oss-cn-test.aliyuncs.com</a></p>
     */
    @NameInMap("endpoint")
    public String endpoint;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0</p>
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
