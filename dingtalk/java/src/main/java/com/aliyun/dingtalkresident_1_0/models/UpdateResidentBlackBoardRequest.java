// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateResidentBlackBoardRequest extends TeaModel {
    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingCorpId")
    public String dingCorpId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    @NameInMap("title")
    public String title;

    @NameInMap("context")
    public String context;

    @NameInMap("mediaId")
    public String mediaId;

    @NameInMap("blackboardId")
    public String blackboardId;

    public static UpdateResidentBlackBoardRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateResidentBlackBoardRequest self = new UpdateResidentBlackBoardRequest();
        return TeaModel.build(map, self);
    }

    public UpdateResidentBlackBoardRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public UpdateResidentBlackBoardRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public UpdateResidentBlackBoardRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public UpdateResidentBlackBoardRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public UpdateResidentBlackBoardRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public UpdateResidentBlackBoardRequest setContext(String context) {
        this.context = context;
        return this;
    }
    public String getContext() {
        return this.context;
    }

    public UpdateResidentBlackBoardRequest setMediaId(String mediaId) {
        this.mediaId = mediaId;
        return this;
    }
    public String getMediaId() {
        return this.mediaId;
    }

    public UpdateResidentBlackBoardRequest setBlackboardId(String blackboardId) {
        this.blackboardId = blackboardId;
        return this;
    }
    public String getBlackboardId() {
        return this.blackboardId;
    }

}
