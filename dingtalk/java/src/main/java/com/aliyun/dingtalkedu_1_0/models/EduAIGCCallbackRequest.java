// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class EduAIGCCallbackRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>test</p>
     */
    @NameInMap("channelCode")
    public String channelCode;

    @NameInMap("commitTime")
    public Long commitTime;

    @NameInMap("completeTime")
    public Long completeTime;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p><a href="http://xxxxx.doc">http://xxxxx.doc</a></p>
     */
    @NameInMap("content")
    public String content;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1500</p>
     */
    @NameInMap("contentSize")
    public Long contentSize;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>url</p>
     */
    @NameInMap("contentType")
    public String contentType;

    @NameInMap("ext")
    public String ext;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>请帮我写一篇读后感</p>
     */
    @NameInMap("prompt")
    public String prompt;

    @NameInMap("remark")
    public String remark;

    public static EduAIGCCallbackRequest build(java.util.Map<String, ?> map) throws Exception {
        EduAIGCCallbackRequest self = new EduAIGCCallbackRequest();
        return TeaModel.build(map, self);
    }

    public EduAIGCCallbackRequest setChannelCode(String channelCode) {
        this.channelCode = channelCode;
        return this;
    }
    public String getChannelCode() {
        return this.channelCode;
    }

    public EduAIGCCallbackRequest setCommitTime(Long commitTime) {
        this.commitTime = commitTime;
        return this;
    }
    public Long getCommitTime() {
        return this.commitTime;
    }

    public EduAIGCCallbackRequest setCompleteTime(Long completeTime) {
        this.completeTime = completeTime;
        return this;
    }
    public Long getCompleteTime() {
        return this.completeTime;
    }

    public EduAIGCCallbackRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public EduAIGCCallbackRequest setContentSize(Long contentSize) {
        this.contentSize = contentSize;
        return this;
    }
    public Long getContentSize() {
        return this.contentSize;
    }

    public EduAIGCCallbackRequest setContentType(String contentType) {
        this.contentType = contentType;
        return this;
    }
    public String getContentType() {
        return this.contentType;
    }

    public EduAIGCCallbackRequest setExt(String ext) {
        this.ext = ext;
        return this;
    }
    public String getExt() {
        return this.ext;
    }

    public EduAIGCCallbackRequest setPrompt(String prompt) {
        this.prompt = prompt;
        return this;
    }
    public String getPrompt() {
        return this.prompt;
    }

    public EduAIGCCallbackRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

}
