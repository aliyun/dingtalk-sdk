// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class GetStoragePolicyRequest extends TeaModel {
    // 业务类型
    @NameInMap("bizType")
    public String bizType;

    // 文件名称
    @NameInMap("fileName")
    public String fileName;

    // 文件大小，单位字节
    @NameInMap("fileSize")
    public Long fileSize;

    // 团队ID
    @NameInMap("openTeamId")
    public String openTeamId;

    public static GetStoragePolicyRequest build(java.util.Map<String, ?> map) throws Exception {
        GetStoragePolicyRequest self = new GetStoragePolicyRequest();
        return TeaModel.build(map, self);
    }

    public GetStoragePolicyRequest setBizType(String bizType) {
        this.bizType = bizType;
        return this;
    }
    public String getBizType() {
        return this.bizType;
    }

    public GetStoragePolicyRequest setFileName(String fileName) {
        this.fileName = fileName;
        return this;
    }
    public String getFileName() {
        return this.fileName;
    }

    public GetStoragePolicyRequest setFileSize(Long fileSize) {
        this.fileSize = fileSize;
        return this;
    }
    public Long getFileSize() {
        return this.fileSize;
    }

    public GetStoragePolicyRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

}
