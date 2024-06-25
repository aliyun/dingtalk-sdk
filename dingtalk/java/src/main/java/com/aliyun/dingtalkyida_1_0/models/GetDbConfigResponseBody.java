// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetDbConfigResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>{&quot;dbName&quot;:&quot;yida_exclusive_pg_db&quot;,&quot;exclusiveType&quot;:&quot;DATABASE&quot;,&quot;maxActive&quot;:1600,&quot;minIdle&quot;:160,&quot;password&quot;:&quot;xxx&quot;,&quot;sharding&quot;:true,&quot;type&quot;:&quot;POSTGRES&quot;,&quot;url&quot;:&quot;pgm-bp17c85t9363an74194040.pg.rds.aliyuncs.com:0000&quot;,&quot;username&quot;:&quot;yida_xxx&quot;}</p>
     */
    @NameInMap("config")
    public String config;

    /**
     * <strong>example:</strong>
     * <p>ding5d17e3add038d44535c2f4657eb6378f</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <strong>example:</strong>
     * <p>2022-02-23T14:46Z</p>
     */
    @NameInMap("createTimeGMT")
    public String createTimeGMT;

    /**
     * <strong>example:</strong>
     * <p>092824253426603595</p>
     */
    @NameInMap("creator")
    public String creator;

    /**
     * <strong>example:</strong>
     * <p>ding5d17e3add038d44535c2f4657eb6378f</p>
     */
    @NameInMap("exclusive")
    public String exclusive;

    /**
     * <strong>example:</strong>
     * <p>600001</p>
     */
    @NameInMap("id")
    public String id;

    /**
     * <strong>example:</strong>
     * <p>2023-08-15T10:37Z</p>
     */
    @NameInMap("modifiedTimeGMT")
    public String modifiedTimeGMT;

    /**
     * <strong>example:</strong>
     * <p>5014533041684350</p>
     */
    @NameInMap("modifier")
    public String modifier;

    /**
     * <strong>example:</strong>
     * <p>DATABASE</p>
     */
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
