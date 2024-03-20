// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_interaction_1_0.models;

import com.aliyun.tea.*;

public class PrepareRequest extends TeaModel {
    @NameInMap("content")
    public String content;

    @NameInMap("contentType")
    public String contentType;

    @NameInMap("conversationType")
    public String conversationType;

    @NameInMap("corpId")
    public String corpId;

    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("unifiedAppId")
    public String unifiedAppId;

    @NameInMap("unionId")
    public String unionId;

    public static PrepareRequest build(java.util.Map<String, ?> map) throws Exception {
        PrepareRequest self = new PrepareRequest();
        return TeaModel.build(map, self);
    }

    public PrepareRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public PrepareRequest setContentType(String contentType) {
        this.contentType = contentType;
        return this;
    }
    public String getContentType() {
        return this.contentType;
    }

    public PrepareRequest setConversationType(String conversationType) {
        this.conversationType = conversationType;
        return this;
    }
    public String getConversationType() {
        return this.conversationType;
    }

    public PrepareRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public PrepareRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public PrepareRequest setUnifiedAppId(String unifiedAppId) {
        this.unifiedAppId = unifiedAppId;
        return this;
    }
    public String getUnifiedAppId() {
        return this.unifiedAppId;
    }

    public PrepareRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
