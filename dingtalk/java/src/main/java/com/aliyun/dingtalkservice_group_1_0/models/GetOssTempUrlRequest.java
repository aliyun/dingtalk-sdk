// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class GetOssTempUrlRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fetchMode")
    public String fetchMode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fileName")
    public String fileName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("key")
    public String key;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    public static GetOssTempUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GetOssTempUrlRequest self = new GetOssTempUrlRequest();
        return TeaModel.build(map, self);
    }

    public GetOssTempUrlRequest setFetchMode(String fetchMode) {
        this.fetchMode = fetchMode;
        return this;
    }
    public String getFetchMode() {
        return this.fetchMode;
    }

    public GetOssTempUrlRequest setFileName(String fileName) {
        this.fileName = fileName;
        return this;
    }
    public String getFileName() {
        return this.fileName;
    }

    public GetOssTempUrlRequest setKey(String key) {
        this.key = key;
        return this;
    }
    public String getKey() {
        return this.key;
    }

    public GetOssTempUrlRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

}
