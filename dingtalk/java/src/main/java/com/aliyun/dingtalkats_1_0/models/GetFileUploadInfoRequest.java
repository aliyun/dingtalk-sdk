// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class GetFileUploadInfoRequest extends TeaModel {
    // 业务标识
    @NameInMap("bizCode")
    public String bizCode;

    // 文件名称
    @NameInMap("fileName")
    public String fileName;

    // 文件大小（单位：字节）
    @NameInMap("fileSize")
    public Long fileSize;

    // 文件MD5摘要
    @NameInMap("md5")
    public String md5;

    // 操作人员工标识，为空时默认以企业管理员身份进行操作
    @NameInMap("opUserId")
    public String opUserId;

    public static GetFileUploadInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFileUploadInfoRequest self = new GetFileUploadInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetFileUploadInfoRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public GetFileUploadInfoRequest setFileName(String fileName) {
        this.fileName = fileName;
        return this;
    }
    public String getFileName() {
        return this.fileName;
    }

    public GetFileUploadInfoRequest setFileSize(Long fileSize) {
        this.fileSize = fileSize;
        return this;
    }
    public Long getFileSize() {
        return this.fileSize;
    }

    public GetFileUploadInfoRequest setMd5(String md5) {
        this.md5 = md5;
        return this;
    }
    public String getMd5() {
        return this.md5;
    }

    public GetFileUploadInfoRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

}
