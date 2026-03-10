// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_search_ask_1_0.models;

import com.aliyun.tea.*;

public class FetchLoginStatusDevicesRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("domain")
    public String domain;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userIdList")
    public java.util.List<String> userIdList;

    public static FetchLoginStatusDevicesRequest build(java.util.Map<String, ?> map) throws Exception {
        FetchLoginStatusDevicesRequest self = new FetchLoginStatusDevicesRequest();
        return TeaModel.build(map, self);
    }

    public FetchLoginStatusDevicesRequest setDomain(String domain) {
        this.domain = domain;
        return this;
    }
    public String getDomain() {
        return this.domain;
    }

    public FetchLoginStatusDevicesRequest setUserIdList(java.util.List<String> userIdList) {
        this.userIdList = userIdList;
        return this;
    }
    public java.util.List<String> getUserIdList() {
        return this.userIdList;
    }

}
