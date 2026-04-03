// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class ListAiMinutesRequest extends TeaModel {
    @NameInMap("fetchAll")
    public Boolean fetchAll;

    public static ListAiMinutesRequest build(java.util.Map<String, ?> map) throws Exception {
        ListAiMinutesRequest self = new ListAiMinutesRequest();
        return TeaModel.build(map, self);
    }

    public ListAiMinutesRequest setFetchAll(Boolean fetchAll) {
        this.fetchAll = fetchAll;
        return this;
    }
    public Boolean getFetchAll() {
        return this.fetchAll;
    }

}
