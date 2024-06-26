// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class FileStorageUpdateStorageResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>sampleKeyId1234</p>
     */
    @NameInMap("accessKeyId")
    public String accessKeyId;

    /**
     * <strong>example:</strong>
     * <p><a href="https://oss-cn-test.aliyuncs.com%5C">https://oss-cn-test.aliyuncs.com\</a></p>
     */
    @NameInMap("oss")
    public String oss;

    public static FileStorageUpdateStorageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        FileStorageUpdateStorageResponseBody self = new FileStorageUpdateStorageResponseBody();
        return TeaModel.build(map, self);
    }

    public FileStorageUpdateStorageResponseBody setAccessKeyId(String accessKeyId) {
        this.accessKeyId = accessKeyId;
        return this;
    }
    public String getAccessKeyId() {
        return this.accessKeyId;
    }

    public FileStorageUpdateStorageResponseBody setOss(String oss) {
        this.oss = oss;
        return this;
    }
    public String getOss() {
        return this.oss;
    }

}
