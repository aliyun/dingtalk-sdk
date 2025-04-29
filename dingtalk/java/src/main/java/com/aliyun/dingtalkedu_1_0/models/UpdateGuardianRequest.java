// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateGuardianRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>23434234234</p>
     */
    @NameInMap("bizId")
    public String bizId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>234324234</p>
     */
    @NameInMap("classId")
    public Long classId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>3545979</p>
     */
    @NameInMap("operator")
    public String operator;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>F</p>
     */
    @NameInMap("relation")
    public String relation;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>234234324</p>
     */
    @NameInMap("stuId")
    public String stuId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>324324324</p>
     */
    @NameInMap("userId")
    public String userId;

    public static UpdateGuardianRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateGuardianRequest self = new UpdateGuardianRequest();
        return TeaModel.build(map, self);
    }

    public UpdateGuardianRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public UpdateGuardianRequest setClassId(Long classId) {
        this.classId = classId;
        return this;
    }
    public Long getClassId() {
        return this.classId;
    }

    public UpdateGuardianRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public UpdateGuardianRequest setRelation(String relation) {
        this.relation = relation;
        return this;
    }
    public String getRelation() {
        return this.relation;
    }

    public UpdateGuardianRequest setStuId(String stuId) {
        this.stuId = stuId;
        return this;
    }
    public String getStuId() {
        return this.stuId;
    }

    public UpdateGuardianRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
