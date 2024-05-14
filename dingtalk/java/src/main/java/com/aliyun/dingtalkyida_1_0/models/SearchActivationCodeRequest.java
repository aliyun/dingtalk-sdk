// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SearchActivationCodeRequest extends TeaModel {
    @NameInMap("accessKey")
    public String accessKey;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("callerUid")
    public String callerUid;

    public static SearchActivationCodeRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchActivationCodeRequest self = new SearchActivationCodeRequest();
        return TeaModel.build(map, self);
    }

    public SearchActivationCodeRequest setAccessKey(String accessKey) {
        this.accessKey = accessKey;
        return this;
    }
    public String getAccessKey() {
        return this.accessKey;
    }

    public SearchActivationCodeRequest setCallerUid(String callerUid) {
        this.callerUid = callerUid;
        return this;
    }
    public String getCallerUid() {
        return this.callerUid;
    }

}
