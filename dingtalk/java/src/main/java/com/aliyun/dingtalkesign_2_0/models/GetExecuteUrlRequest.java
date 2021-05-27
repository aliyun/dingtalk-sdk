// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetExecuteUrlRequest extends TeaModel {
    @NameInMap("taskId")
    public String taskId;

    @NameInMap("signContainer")
    public Integer signContainer;

    @NameInMap("dingCorpId")
    public String dingCorpId;

    @NameInMap("account")
    public String account;

    public static GetExecuteUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GetExecuteUrlRequest self = new GetExecuteUrlRequest();
        return TeaModel.build(map, self);
    }

    public GetExecuteUrlRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

    public GetExecuteUrlRequest setSignContainer(Integer signContainer) {
        this.signContainer = signContainer;
        return this;
    }
    public Integer getSignContainer() {
        return this.signContainer;
    }

    public GetExecuteUrlRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public GetExecuteUrlRequest setAccount(String account) {
        this.account = account;
        return this;
    }
    public String getAccount() {
        return this.account;
    }

}
