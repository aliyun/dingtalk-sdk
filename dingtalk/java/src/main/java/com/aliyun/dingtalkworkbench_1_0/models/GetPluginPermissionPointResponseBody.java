// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0.models;

import com.aliyun.tea.*;

public class GetPluginPermissionPointResponseBody extends TeaModel {
    // 插件权限点列表
    @NameInMap("permissionPointList")
    public java.util.List<String> permissionPointList;

    public static GetPluginPermissionPointResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetPluginPermissionPointResponseBody self = new GetPluginPermissionPointResponseBody();
        return TeaModel.build(map, self);
    }

    public GetPluginPermissionPointResponseBody setPermissionPointList(java.util.List<String> permissionPointList) {
        this.permissionPointList = permissionPointList;
        return this;
    }
    public java.util.List<String> getPermissionPointList() {
        return this.permissionPointList;
    }

}
