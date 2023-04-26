// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class FileStorageGetStorageStateResponseBody extends TeaModel {
    @NameInMap("accessKeyId")
    public String accessKeyId;

    @NameInMap("createDate")
    public String createDate;

    @NameInMap("fileStorageOpenStatus")
    public Integer fileStorageOpenStatus;

    @NameInMap("oss")
    public String oss;

    @NameInMap("storageStatus")
    public Integer storageStatus;

    @NameInMap("usedQuota")
    public Long usedQuota;

    public static FileStorageGetStorageStateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        FileStorageGetStorageStateResponseBody self = new FileStorageGetStorageStateResponseBody();
        return TeaModel.build(map, self);
    }

    public FileStorageGetStorageStateResponseBody setAccessKeyId(String accessKeyId) {
        this.accessKeyId = accessKeyId;
        return this;
    }
    public String getAccessKeyId() {
        return this.accessKeyId;
    }

    public FileStorageGetStorageStateResponseBody setCreateDate(String createDate) {
        this.createDate = createDate;
        return this;
    }
    public String getCreateDate() {
        return this.createDate;
    }

    public FileStorageGetStorageStateResponseBody setFileStorageOpenStatus(Integer fileStorageOpenStatus) {
        this.fileStorageOpenStatus = fileStorageOpenStatus;
        return this;
    }
    public Integer getFileStorageOpenStatus() {
        return this.fileStorageOpenStatus;
    }

    public FileStorageGetStorageStateResponseBody setOss(String oss) {
        this.oss = oss;
        return this;
    }
    public String getOss() {
        return this.oss;
    }

    public FileStorageGetStorageStateResponseBody setStorageStatus(Integer storageStatus) {
        this.storageStatus = storageStatus;
        return this;
    }
    public Integer getStorageStatus() {
        return this.storageStatus;
    }

    public FileStorageGetStorageStateResponseBody setUsedQuota(Long usedQuota) {
        this.usedQuota = usedQuota;
        return this;
    }
    public Long getUsedQuota() {
        return this.usedQuota;
    }

}
