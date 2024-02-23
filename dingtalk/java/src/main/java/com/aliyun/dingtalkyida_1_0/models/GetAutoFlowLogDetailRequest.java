// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetAutoFlowLogDetailRequest extends TeaModel {
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("pageNumber")
    public Integer pageNumber;

    @NameInMap("pageSize")
    public Integer pageSize;

    @NameInMap("procInstanceId")
    public String procInstanceId;

    @NameInMap("token")
    public String token;

    @NameInMap("userId")
    public String userId;

    public static GetAutoFlowLogDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        GetAutoFlowLogDetailRequest self = new GetAutoFlowLogDetailRequest();
        return TeaModel.build(map, self);
    }

    public GetAutoFlowLogDetailRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public GetAutoFlowLogDetailRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public GetAutoFlowLogDetailRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public GetAutoFlowLogDetailRequest setProcInstanceId(String procInstanceId) {
        this.procInstanceId = procInstanceId;
        return this;
    }
    public String getProcInstanceId() {
        return this.procInstanceId;
    }

    public GetAutoFlowLogDetailRequest setToken(String token) {
        this.token = token;
        return this;
    }
    public String getToken() {
        return this.token;
    }

    public GetAutoFlowLogDetailRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
