// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmcp_1_0.models;

import com.aliyun.tea.*;

public class GetMcpDetailResponseBody extends TeaModel {
    @NameInMap("categories")
    public java.util.List<GetMcpDetailResponseBodyCategories> categories;

    @NameInMap("charged")
    public Boolean charged;

    @NameInMap("description")
    public String description;

    @NameInMap("detailUrl")
    public String detailUrl;

    @NameInMap("icon")
    public String icon;

    @NameInMap("introduction")
    public String introduction;

    @NameInMap("mcpId")
    public String mcpId;

    @NameInMap("name")
    public String name;

    @NameInMap("tools")
    public java.util.List<GetMcpDetailResponseBodyTools> tools;

    public static GetMcpDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetMcpDetailResponseBody self = new GetMcpDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public GetMcpDetailResponseBody setCategories(java.util.List<GetMcpDetailResponseBodyCategories> categories) {
        this.categories = categories;
        return this;
    }
    public java.util.List<GetMcpDetailResponseBodyCategories> getCategories() {
        return this.categories;
    }

    public GetMcpDetailResponseBody setCharged(Boolean charged) {
        this.charged = charged;
        return this;
    }
    public Boolean getCharged() {
        return this.charged;
    }

    public GetMcpDetailResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public GetMcpDetailResponseBody setDetailUrl(String detailUrl) {
        this.detailUrl = detailUrl;
        return this;
    }
    public String getDetailUrl() {
        return this.detailUrl;
    }

    public GetMcpDetailResponseBody setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public GetMcpDetailResponseBody setIntroduction(String introduction) {
        this.introduction = introduction;
        return this;
    }
    public String getIntroduction() {
        return this.introduction;
    }

    public GetMcpDetailResponseBody setMcpId(String mcpId) {
        this.mcpId = mcpId;
        return this;
    }
    public String getMcpId() {
        return this.mcpId;
    }

    public GetMcpDetailResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetMcpDetailResponseBody setTools(java.util.List<GetMcpDetailResponseBodyTools> tools) {
        this.tools = tools;
        return this;
    }
    public java.util.List<GetMcpDetailResponseBodyTools> getTools() {
        return this.tools;
    }

    public static class GetMcpDetailResponseBodyCategories extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("displayName")
        public String displayName;

        public static GetMcpDetailResponseBodyCategories build(java.util.Map<String, ?> map) throws Exception {
            GetMcpDetailResponseBodyCategories self = new GetMcpDetailResponseBodyCategories();
            return TeaModel.build(map, self);
        }

        public GetMcpDetailResponseBodyCategories setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public GetMcpDetailResponseBodyCategories setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

    }

    public static class GetMcpDetailResponseBodyTools extends TeaModel {
        @NameInMap("description")
        public String description;

        @NameInMap("displayName")
        public String displayName;

        @NameInMap("inputSchema")
        public String inputSchema;

        @NameInMap("name")
        public String name;

        @NameInMap("outputSchema")
        public String outputSchema;

        public static GetMcpDetailResponseBodyTools build(java.util.Map<String, ?> map) throws Exception {
            GetMcpDetailResponseBodyTools self = new GetMcpDetailResponseBodyTools();
            return TeaModel.build(map, self);
        }

        public GetMcpDetailResponseBodyTools setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public GetMcpDetailResponseBodyTools setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public GetMcpDetailResponseBodyTools setInputSchema(String inputSchema) {
            this.inputSchema = inputSchema;
            return this;
        }
        public String getInputSchema() {
            return this.inputSchema;
        }

        public GetMcpDetailResponseBodyTools setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetMcpDetailResponseBodyTools setOutputSchema(String outputSchema) {
            this.outputSchema = outputSchema;
            return this;
        }
        public String getOutputSchema() {
            return this.outputSchema;
        }

    }

}
