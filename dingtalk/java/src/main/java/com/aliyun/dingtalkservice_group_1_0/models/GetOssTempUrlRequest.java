// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class GetOssTempUrlRequest extends TeaModel {
    /**
     * <p>访问模式 AUTO(自动，例如在浏览器中如果是图片，PDF等可以在线直接查看，不能在线看时自动下载)、DOWNLOAD（直接下载）</p>
     */
    @NameInMap("fetchMode")
    public String fetchMode;

    /**
     * <p>文件名</p>
     */
    @NameInMap("fileName")
    public String fileName;

    /**
     * <p>oss文件key</p>
     */
    @NameInMap("key")
    public String key;

    /**
     * <p>团队开放ID</p>
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
