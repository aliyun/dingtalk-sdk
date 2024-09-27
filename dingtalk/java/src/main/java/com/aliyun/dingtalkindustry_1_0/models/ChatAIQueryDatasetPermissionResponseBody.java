// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatAIQueryDatasetPermissionResponseBody extends TeaModel {
    @NameInMap("permissionInfos")
    public java.util.List<ChatAIQueryDatasetPermissionResponseBodyPermissionInfos> permissionInfos;

    public static ChatAIQueryDatasetPermissionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ChatAIQueryDatasetPermissionResponseBody self = new ChatAIQueryDatasetPermissionResponseBody();
        return TeaModel.build(map, self);
    }

    public ChatAIQueryDatasetPermissionResponseBody setPermissionInfos(java.util.List<ChatAIQueryDatasetPermissionResponseBodyPermissionInfos> permissionInfos) {
        this.permissionInfos = permissionInfos;
        return this;
    }
    public java.util.List<ChatAIQueryDatasetPermissionResponseBodyPermissionInfos> getPermissionInfos() {
        return this.permissionInfos;
    }

    public static class ChatAIQueryDatasetPermissionResponseBodyPermissionInfos extends TeaModel {
        @NameInMap("permissionType")
        public String permissionType;

        @NameInMap("permissionValues")
        public java.util.List<String> permissionValues;

        public static ChatAIQueryDatasetPermissionResponseBodyPermissionInfos build(java.util.Map<String, ?> map) throws Exception {
            ChatAIQueryDatasetPermissionResponseBodyPermissionInfos self = new ChatAIQueryDatasetPermissionResponseBodyPermissionInfos();
            return TeaModel.build(map, self);
        }

        public ChatAIQueryDatasetPermissionResponseBodyPermissionInfos setPermissionType(String permissionType) {
            this.permissionType = permissionType;
            return this;
        }
        public String getPermissionType() {
            return this.permissionType;
        }

        public ChatAIQueryDatasetPermissionResponseBodyPermissionInfos setPermissionValues(java.util.List<String> permissionValues) {
            this.permissionValues = permissionValues;
            return this;
        }
        public java.util.List<String> getPermissionValues() {
            return this.permissionValues;
        }

    }

}
