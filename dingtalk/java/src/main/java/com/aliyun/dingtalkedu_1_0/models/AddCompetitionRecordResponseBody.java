// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AddCompetitionRecordResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static AddCompetitionRecordResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddCompetitionRecordResponseBody self = new AddCompetitionRecordResponseBody();
        return TeaModel.build(map, self);
    }

    public AddCompetitionRecordResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
