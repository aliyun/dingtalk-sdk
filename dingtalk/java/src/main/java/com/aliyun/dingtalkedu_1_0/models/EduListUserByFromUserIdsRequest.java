// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class EduListUserByFromUserIdsRequest extends TeaModel {
    @NameInMap("classId")
    public Long classId;

    @NameInMap("corpId")
    public String corpId;

    @NameInMap("guardianUserId")
    public String guardianUserId;

    public static EduListUserByFromUserIdsRequest build(java.util.Map<String, ?> map) throws Exception {
        EduListUserByFromUserIdsRequest self = new EduListUserByFromUserIdsRequest();
        return TeaModel.build(map, self);
    }

    public EduListUserByFromUserIdsRequest setClassId(Long classId) {
        this.classId = classId;
        return this;
    }
    public Long getClassId() {
        return this.classId;
    }

    public EduListUserByFromUserIdsRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public EduListUserByFromUserIdsRequest setGuardianUserId(String guardianUserId) {
        this.guardianUserId = guardianUserId;
        return this;
    }
    public String getGuardianUserId() {
        return this.guardianUserId;
    }

}
