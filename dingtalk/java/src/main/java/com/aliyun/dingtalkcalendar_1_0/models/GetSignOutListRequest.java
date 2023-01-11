// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class GetSignOutListRequest extends TeaModel {
    /**
     * <p>查询返回结果数（上限200）</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>签到信息类型（sign_out，not_yet_sign_out)</p>
     */
    @NameInMap("type")
    public String type;

    public static GetSignOutListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSignOutListRequest self = new GetSignOutListRequest();
        return TeaModel.build(map, self);
    }

    public GetSignOutListRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetSignOutListRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetSignOutListRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
