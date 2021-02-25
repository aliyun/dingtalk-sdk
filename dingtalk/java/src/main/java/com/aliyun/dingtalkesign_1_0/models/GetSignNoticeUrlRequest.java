// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetSignNoticeUrlRequest extends TeaModel {
    @NameInMap("dingCorpId")
    public String dingCorpId;

    @NameInMap("taskId")
    public String taskId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingIsvAccessToken")
    public String dingIsvAccessToken;

    public static GetSignNoticeUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSignNoticeUrlRequest self = new GetSignNoticeUrlRequest();
        return TeaModel.build(map, self);
    }

    public GetSignNoticeUrlRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public GetSignNoticeUrlRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

    public GetSignNoticeUrlRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public GetSignNoticeUrlRequest setDingIsvAccessToken(String dingIsvAccessToken) {
        this.dingIsvAccessToken = dingIsvAccessToken;
        return this;
    }
    public String getDingIsvAccessToken() {
        return this.dingIsvAccessToken;
    }

}
