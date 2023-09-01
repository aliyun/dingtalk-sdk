// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetDbConfigResponseBody extends TeaModel {
    @NameInMap("config")
    public String config;

    @NameInMap("corpId")
    public String corpId;

    @NameInMap("createTimeGMT")
    public String createTimeGMT;

    @NameInMap("creator")
    public String creator;

    @NameInMap("exclusive")
    public String exclusive;

    @NameInMap("id")
    public String id;

    @NameInMap("modifiedTimeGMT")
    public String modifiedTimeGMT;

    @NameInMap("modifier")
    public String modifier;

    @NameInMap("type")
    public String type;

    public static GetDbConfigResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDbConfigResponseBody self = new GetDbConfigResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDbConfigResponseBody setConfig(String config) {
        this.config = config;
        return this;
    }
    public String getConfig() {
        return this.config;
    }

    public GetDbConfigResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public GetDbConfigResponseBody setCreateTimeGMT(String createTimeGMT) {
        this.createTimeGMT = createTimeGMT;
        return this;
    }
    public String getCreateTimeGMT() {
        return this.createTimeGMT;
    }

    public GetDbConfigResponseBody setCreator(String creator) {
        this.creator = creator;
        return this;
    }
    public String getCreator() {
        return this.creator;
    }

    public GetDbConfigResponseBody setExclusive(String exclusive) {
        this.exclusive = exclusive;
        return this;
    }
    public String getExclusive() {
        return this.exclusive;
    }

    public GetDbConfigResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public GetDbConfigResponseBody setModifiedTimeGMT(String modifiedTimeGMT) {
        this.modifiedTimeGMT = modifiedTimeGMT;
        return this;
    }
    public String getModifiedTimeGMT() {
        return this.modifiedTimeGMT;
    }

    public GetDbConfigResponseBody setModifier(String modifier) {
        this.modifier = modifier;
        return this;
    }
    public String getModifier() {
        return this.modifier;
    }

    public GetDbConfigResponseBody setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
