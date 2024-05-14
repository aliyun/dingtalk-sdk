// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryConferenceInfoBatchRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("conferenceIdList")
    public java.util.List<String> conferenceIdList;

    public static QueryConferenceInfoBatchRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryConferenceInfoBatchRequest self = new QueryConferenceInfoBatchRequest();
        return TeaModel.build(map, self);
    }

    public QueryConferenceInfoBatchRequest setConferenceIdList(java.util.List<String> conferenceIdList) {
        this.conferenceIdList = conferenceIdList;
        return this;
    }
    public java.util.List<String> getConferenceIdList() {
        return this.conferenceIdList;
    }

}
