// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class SyncDataRequest extends TeaModel {
    @NameInMap("content")
    public String content;

    @NameInMap("dataId")
    public String dataId;

    @NameInMap("etlTime")
    public String etlTime;

    @NameInMap("projectId")
    public String projectId;

    @NameInMap("schemaId")
    public String schemaId;

    public static SyncDataRequest build(java.util.Map<String, ?> map) throws Exception {
        SyncDataRequest self = new SyncDataRequest();
        return TeaModel.build(map, self);
    }

    public SyncDataRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public SyncDataRequest setDataId(String dataId) {
        this.dataId = dataId;
        return this;
    }
    public String getDataId() {
        return this.dataId;
    }

    public SyncDataRequest setEtlTime(String etlTime) {
        this.etlTime = etlTime;
        return this;
    }
    public String getEtlTime() {
        return this.etlTime;
    }

    public SyncDataRequest setProjectId(String projectId) {
        this.projectId = projectId;
        return this;
    }
    public String getProjectId() {
        return this.projectId;
    }

    public SyncDataRequest setSchemaId(String schemaId) {
        this.schemaId = schemaId;
        return this;
    }
    public String getSchemaId() {
        return this.schemaId;
    }

}
