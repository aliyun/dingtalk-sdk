// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class GetSignInListRequest extends TeaModel {
    // 查询返回结果数（上限200）
    @NameInMap("maxResults")
    public Long maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    // 签到信息类型（check_in，not_yet_check_in)
    @NameInMap("type")
    public String type;

    public static GetSignInListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSignInListRequest self = new GetSignInListRequest();
        return TeaModel.build(map, self);
    }

    public GetSignInListRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public GetSignInListRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetSignInListRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
