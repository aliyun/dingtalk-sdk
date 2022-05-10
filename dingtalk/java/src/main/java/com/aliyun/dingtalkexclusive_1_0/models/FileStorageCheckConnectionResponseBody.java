// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class FileStorageCheckConnectionResponseBody extends TeaModel {
    // 密匙ID
    @NameInMap("accessKeyId")
    public String accessKeyId;

    // 检测oss状态 0正常1异常
    @NameInMap("checkState")
    public Integer checkState;

    // OSS链接
    @NameInMap("oss")
    public String oss;

    public static FileStorageCheckConnectionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        FileStorageCheckConnectionResponseBody self = new FileStorageCheckConnectionResponseBody();
        return TeaModel.build(map, self);
    }

    public FileStorageCheckConnectionResponseBody setAccessKeyId(String accessKeyId) {
        this.accessKeyId = accessKeyId;
        return this;
    }
    public String getAccessKeyId() {
        return this.accessKeyId;
    }

    public FileStorageCheckConnectionResponseBody setCheckState(Integer checkState) {
        this.checkState = checkState;
        return this;
    }
    public Integer getCheckState() {
        return this.checkState;
    }

    public FileStorageCheckConnectionResponseBody setOss(String oss) {
        this.oss = oss;
        return this;
    }
    public String getOss() {
        return this.oss;
    }

}
