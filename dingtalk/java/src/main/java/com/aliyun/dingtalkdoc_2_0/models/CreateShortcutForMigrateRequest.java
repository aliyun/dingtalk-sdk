// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CreateShortcutForMigrateRequest extends TeaModel {
    @NameInMap("operatorId")
    public String operatorId;

    @NameInMap("sourceResourceId")
    public String sourceResourceId;

    @NameInMap("sourceResourceType")
    public String sourceResourceType;

    @NameInMap("targetResourceId")
    public String targetResourceId;

    @NameInMap("targetResourceName")
    public String targetResourceName;

    @NameInMap("targetResourceType")
    public String targetResourceType;

    public static CreateShortcutForMigrateRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateShortcutForMigrateRequest self = new CreateShortcutForMigrateRequest();
        return TeaModel.build(map, self);
    }

    public CreateShortcutForMigrateRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public CreateShortcutForMigrateRequest setSourceResourceId(String sourceResourceId) {
        this.sourceResourceId = sourceResourceId;
        return this;
    }
    public String getSourceResourceId() {
        return this.sourceResourceId;
    }

    public CreateShortcutForMigrateRequest setSourceResourceType(String sourceResourceType) {
        this.sourceResourceType = sourceResourceType;
        return this;
    }
    public String getSourceResourceType() {
        return this.sourceResourceType;
    }

    public CreateShortcutForMigrateRequest setTargetResourceId(String targetResourceId) {
        this.targetResourceId = targetResourceId;
        return this;
    }
    public String getTargetResourceId() {
        return this.targetResourceId;
    }

    public CreateShortcutForMigrateRequest setTargetResourceName(String targetResourceName) {
        this.targetResourceName = targetResourceName;
        return this;
    }
    public String getTargetResourceName() {
        return this.targetResourceName;
    }

    public CreateShortcutForMigrateRequest setTargetResourceType(String targetResourceType) {
        this.targetResourceType = targetResourceType;
        return this;
    }
    public String getTargetResourceType() {
        return this.targetResourceType;
    }

}
