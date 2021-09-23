// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class DeleteSequenceRequest extends TeaModel {
    @NameInMap("userId")
    public String userId;

    @NameInMap("sequence")
    public String sequence;

    @NameInMap("systemToken")
    public String systemToken;

    @NameInMap("language")
    public String language;

    @NameInMap("appType")
    public String appType;

    public static DeleteSequenceRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteSequenceRequest self = new DeleteSequenceRequest();
        return TeaModel.build(map, self);
    }

    public DeleteSequenceRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public DeleteSequenceRequest setSequence(String sequence) {
        this.sequence = sequence;
        return this;
    }
    public String getSequence() {
        return this.sequence;
    }

    public DeleteSequenceRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public DeleteSequenceRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public DeleteSequenceRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

}
