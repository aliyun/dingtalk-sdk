// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class FileStorageGetQuotaDataRequest extends TeaModel {
    @NameInMap("endTime")
    public String endTime;

    @NameInMap("startTime")
    public String startTime;

    @NameInMap("targetCorpId")
    public String targetCorpId;

    @NameInMap("type")
    public String type;

    public static FileStorageGetQuotaDataRequest build(java.util.Map<String, ?> map) throws Exception {
        FileStorageGetQuotaDataRequest self = new FileStorageGetQuotaDataRequest();
        return TeaModel.build(map, self);
    }

    public FileStorageGetQuotaDataRequest setEndTime(String endTime) {
        this.endTime = endTime;
        return this;
    }
    public String getEndTime() {
        return this.endTime;
    }

    public FileStorageGetQuotaDataRequest setStartTime(String startTime) {
        this.startTime = startTime;
        return this;
    }
    public String getStartTime() {
        return this.startTime;
    }

    public FileStorageGetQuotaDataRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

    public FileStorageGetQuotaDataRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
