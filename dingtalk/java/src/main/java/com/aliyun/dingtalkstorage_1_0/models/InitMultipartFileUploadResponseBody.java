// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class InitMultipartFileUploadResponseBody extends TeaModel {
    // 文件存储类型
    // 枚举值:
    // 	DINGTALK: 钉钉统一存储驱动
    // 	ALIDOC: 钉钉文档存储驱动
    // 	SHANJI: 闪记存储驱动
    // 	UNKNOWN: 未知驱动
    @NameInMap("storageDriver")
    public String storageDriver;

    // 上传唯一标识
    @NameInMap("uploadKey")
    public String uploadKey;

    public static InitMultipartFileUploadResponseBody build(java.util.Map<String, ?> map) throws Exception {
        InitMultipartFileUploadResponseBody self = new InitMultipartFileUploadResponseBody();
        return TeaModel.build(map, self);
    }

    public InitMultipartFileUploadResponseBody setStorageDriver(String storageDriver) {
        this.storageDriver = storageDriver;
        return this;
    }
    public String getStorageDriver() {
        return this.storageDriver;
    }

    public InitMultipartFileUploadResponseBody setUploadKey(String uploadKey) {
        this.uploadKey = uploadKey;
        return this;
    }
    public String getUploadKey() {
        return this.uploadKey;
    }

}
