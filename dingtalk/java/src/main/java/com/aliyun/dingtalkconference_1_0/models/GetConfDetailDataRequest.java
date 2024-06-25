// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class GetConfDetailDataRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <strong>example:</strong>
     * <p>xxx9uZ0bVGoqjxxxxxxxx</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <strong>example:</strong>
     * <p>张三</p>
     */
    @NameInMap("nick")
    public String nick;

    public static GetConfDetailDataRequest build(java.util.Map<String, ?> map) throws Exception {
        GetConfDetailDataRequest self = new GetConfDetailDataRequest();
        return TeaModel.build(map, self);
    }

    public GetConfDetailDataRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetConfDetailDataRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetConfDetailDataRequest setNick(String nick) {
        this.nick = nick;
        return this;
    }
    public String getNick() {
        return this.nick;
    }

}
