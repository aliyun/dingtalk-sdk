// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetWorkspaceResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("isDeleted")
    public Boolean isDeleted;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("owner")
    public String owner;

    @NameInMap("rootDentryUuid")
    public String rootDentryUuid;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("url")
    public String url;

    public static GetWorkspaceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetWorkspaceResponseBody self = new GetWorkspaceResponseBody();
        return TeaModel.build(map, self);
    }

    public GetWorkspaceResponseBody setIsDeleted(Boolean isDeleted) {
        this.isDeleted = isDeleted;
        return this;
    }
    public Boolean getIsDeleted() {
        return this.isDeleted;
    }

    public GetWorkspaceResponseBody setOwner(String owner) {
        this.owner = owner;
        return this;
    }
    public String getOwner() {
        return this.owner;
    }

    public GetWorkspaceResponseBody setRootDentryUuid(String rootDentryUuid) {
        this.rootDentryUuid = rootDentryUuid;
        return this;
    }
    public String getRootDentryUuid() {
        return this.rootDentryUuid;
    }

    public GetWorkspaceResponseBody setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

}
