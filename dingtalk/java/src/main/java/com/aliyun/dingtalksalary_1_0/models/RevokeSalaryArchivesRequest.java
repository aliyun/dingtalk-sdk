// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksalary_1_0.models;

import com.aliyun.tea.*;

public class RevokeSalaryArchivesRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2025-06-01</p>
     */
    @NameInMap("effectiveDate")
    public String effectiveDate;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>user001</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>user001</p>
     */
    @NameInMap("userId")
    public String userId;

    public static RevokeSalaryArchivesRequest build(java.util.Map<String, ?> map) throws Exception {
        RevokeSalaryArchivesRequest self = new RevokeSalaryArchivesRequest();
        return TeaModel.build(map, self);
    }

    public RevokeSalaryArchivesRequest setEffectiveDate(String effectiveDate) {
        this.effectiveDate = effectiveDate;
        return this;
    }
    public String getEffectiveDate() {
        return this.effectiveDate;
    }

    public RevokeSalaryArchivesRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public RevokeSalaryArchivesRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
