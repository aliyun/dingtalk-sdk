// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class QueryItemByUrlResponseBody extends TeaModel {
    @NameInMap("bizType")
    public String bizType;

    @NameInMap("dentry")
    public DentryModel dentry;

    @NameInMap("resourceType")
    public String resourceType;

    @NameInMap("space")
    public QueryItemByUrlResponseBodySpace space;

    public static QueryItemByUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryItemByUrlResponseBody self = new QueryItemByUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryItemByUrlResponseBody setBizType(String bizType) {
        this.bizType = bizType;
        return this;
    }
    public String getBizType() {
        return this.bizType;
    }

    public QueryItemByUrlResponseBody setDentry(DentryModel dentry) {
        this.dentry = dentry;
        return this;
    }
    public DentryModel getDentry() {
        return this.dentry;
    }

    public QueryItemByUrlResponseBody setResourceType(String resourceType) {
        this.resourceType = resourceType;
        return this;
    }
    public String getResourceType() {
        return this.resourceType;
    }

    public QueryItemByUrlResponseBody setSpace(QueryItemByUrlResponseBodySpace space) {
        this.space = space;
        return this;
    }
    public QueryItemByUrlResponseBodySpace getSpace() {
        return this.space;
    }

    public static class QueryItemByUrlResponseBodySpaceOwner extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("unionId")
        public String unionId;

        public static QueryItemByUrlResponseBodySpaceOwner build(java.util.Map<String, ?> map) throws Exception {
            QueryItemByUrlResponseBodySpaceOwner self = new QueryItemByUrlResponseBodySpaceOwner();
            return TeaModel.build(map, self);
        }

        public QueryItemByUrlResponseBodySpaceOwner setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryItemByUrlResponseBodySpaceOwner setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

    public static class QueryItemByUrlResponseBodySpace extends TeaModel {
        @NameInMap("description")
        public String description;

        @NameInMap("id")
        public String id;

        @NameInMap("name")
        public String name;

        @NameInMap("owner")
        public QueryItemByUrlResponseBodySpaceOwner owner;

        @NameInMap("type")
        public Integer type;

        public static QueryItemByUrlResponseBodySpace build(java.util.Map<String, ?> map) throws Exception {
            QueryItemByUrlResponseBodySpace self = new QueryItemByUrlResponseBodySpace();
            return TeaModel.build(map, self);
        }

        public QueryItemByUrlResponseBodySpace setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public QueryItemByUrlResponseBodySpace setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public QueryItemByUrlResponseBodySpace setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryItemByUrlResponseBodySpace setOwner(QueryItemByUrlResponseBodySpaceOwner owner) {
            this.owner = owner;
            return this;
        }
        public QueryItemByUrlResponseBodySpaceOwner getOwner() {
            return this.owner;
        }

        public QueryItemByUrlResponseBodySpace setType(Integer type) {
            this.type = type;
            return this;
        }
        public Integer getType() {
            return this.type;
        }

    }

}
