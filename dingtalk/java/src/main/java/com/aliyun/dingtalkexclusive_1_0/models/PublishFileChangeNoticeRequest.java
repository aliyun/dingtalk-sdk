// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class PublishFileChangeNoticeRequest extends TeaModel {
    // 钉盘文件id
    @NameInMap("fileId")
    public String fileId;

    // 钉盘spaceId
    @NameInMap("spaceId")
    public String spaceId;

    // 操作人unionId
    @NameInMap("operatorUnionId")
    public String operatorUnionId;

    // 操作类型: 1-添加 2-修改
    @NameInMap("operateType")
    public String operateType;

    public static PublishFileChangeNoticeRequest build(java.util.Map<String, ?> map) throws Exception {
        PublishFileChangeNoticeRequest self = new PublishFileChangeNoticeRequest();
        return TeaModel.build(map, self);
    }

    public PublishFileChangeNoticeRequest setFileId(String fileId) {
        this.fileId = fileId;
        return this;
    }
    public String getFileId() {
        return this.fileId;
    }

    public PublishFileChangeNoticeRequest setSpaceId(String spaceId) {
        this.spaceId = spaceId;
        return this;
    }
    public String getSpaceId() {
        return this.spaceId;
    }

    public PublishFileChangeNoticeRequest setOperatorUnionId(String operatorUnionId) {
        this.operatorUnionId = operatorUnionId;
        return this;
    }
    public String getOperatorUnionId() {
        return this.operatorUnionId;
    }

    public PublishFileChangeNoticeRequest setOperateType(String operateType) {
        this.operateType = operateType;
        return this;
    }
    public String getOperateType() {
        return this.operateType;
    }

}
