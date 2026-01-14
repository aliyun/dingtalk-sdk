// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetPrivateStoreFileInfosByPageRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>文档文件:document, 视频:video, 代码文件:text, 链接:link, 音频:audio, 图片:image, 压缩文件:archive, 安装包:app, 其他:other</p>
     */
    @NameInMap("contentType")
    public String contentType;

    @NameInMap("deptIds")
    public java.util.List<Long> deptIds;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1680493837426</p>
     */
    @NameInMap("fileCreateTime")
    public Long fileCreateTime;

    @NameInMap("fileStatus")
    public String fileStatus;

    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("name")
    public String name;

    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("order")
    public String order;

    /**
     * <strong>example:</strong>
     * <p>IM:IM, 其他:OTHER, 个人空间:PERSON, 企业内共享:ORG</p>
     */
    @NameInMap("sceneType")
    public String sceneType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("targetCorpId")
    public String targetCorpId;

    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static GetPrivateStoreFileInfosByPageRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPrivateStoreFileInfosByPageRequest self = new GetPrivateStoreFileInfosByPageRequest();
        return TeaModel.build(map, self);
    }

    public GetPrivateStoreFileInfosByPageRequest setContentType(String contentType) {
        this.contentType = contentType;
        return this;
    }
    public String getContentType() {
        return this.contentType;
    }

    public GetPrivateStoreFileInfosByPageRequest setDeptIds(java.util.List<Long> deptIds) {
        this.deptIds = deptIds;
        return this;
    }
    public java.util.List<Long> getDeptIds() {
        return this.deptIds;
    }

    public GetPrivateStoreFileInfosByPageRequest setFileCreateTime(Long fileCreateTime) {
        this.fileCreateTime = fileCreateTime;
        return this;
    }
    public Long getFileCreateTime() {
        return this.fileCreateTime;
    }

    public GetPrivateStoreFileInfosByPageRequest setFileStatus(String fileStatus) {
        this.fileStatus = fileStatus;
        return this;
    }
    public String getFileStatus() {
        return this.fileStatus;
    }

    public GetPrivateStoreFileInfosByPageRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetPrivateStoreFileInfosByPageRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetPrivateStoreFileInfosByPageRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetPrivateStoreFileInfosByPageRequest setOrder(String order) {
        this.order = order;
        return this;
    }
    public String getOrder() {
        return this.order;
    }

    public GetPrivateStoreFileInfosByPageRequest setSceneType(String sceneType) {
        this.sceneType = sceneType;
        return this;
    }
    public String getSceneType() {
        return this.sceneType;
    }

    public GetPrivateStoreFileInfosByPageRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

    public GetPrivateStoreFileInfosByPageRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
