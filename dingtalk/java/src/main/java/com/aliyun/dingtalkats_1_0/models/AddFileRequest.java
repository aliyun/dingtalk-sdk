// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class AddFileRequest extends TeaModel {
    /**
     * <p>业务标识</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <p>文件名称</p>
     */
    @NameInMap("fileName")
    public String fileName;

    /**
     * <p>文件mediaId</p>
     */
    @NameInMap("mediaId")
    public String mediaId;

    /**
     * <p>操作人员工标识，为空时默认以企业管理员身份进行操作</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    public static AddFileRequest build(java.util.Map<String, ?> map) throws Exception {
        AddFileRequest self = new AddFileRequest();
        return TeaModel.build(map, self);
    }

    public AddFileRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public AddFileRequest setFileName(String fileName) {
        this.fileName = fileName;
        return this;
    }
    public String getFileName() {
        return this.fileName;
    }

    public AddFileRequest setMediaId(String mediaId) {
        this.mediaId = mediaId;
        return this;
    }
    public String getMediaId() {
        return this.mediaId;
    }

    public AddFileRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

}
