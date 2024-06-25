// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class SearchDentriesResponseBody extends TeaModel {
    @NameInMap("items")
    public java.util.List<SearchDentriesResponseBodyItems> items;

    /**
     * <strong>example:</strong>
     * <p>next_token</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    public static SearchDentriesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchDentriesResponseBody self = new SearchDentriesResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchDentriesResponseBody setItems(java.util.List<SearchDentriesResponseBodyItems> items) {
        this.items = items;
        return this;
    }
    public java.util.List<SearchDentriesResponseBodyItems> getItems() {
        return this.items;
    }

    public SearchDentriesResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public static class SearchDentriesResponseBodyItemsCreator extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>user_name</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>staff_id</p>
         */
        @NameInMap("userId")
        public String userId;

        public static SearchDentriesResponseBodyItemsCreator build(java.util.Map<String, ?> map) throws Exception {
            SearchDentriesResponseBodyItemsCreator self = new SearchDentriesResponseBodyItemsCreator();
            return TeaModel.build(map, self);
        }

        public SearchDentriesResponseBodyItemsCreator setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SearchDentriesResponseBodyItemsCreator setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class SearchDentriesResponseBodyItemsModifier extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>user_name</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>staff_id</p>
         */
        @NameInMap("userId")
        public String userId;

        public static SearchDentriesResponseBodyItemsModifier build(java.util.Map<String, ?> map) throws Exception {
            SearchDentriesResponseBodyItemsModifier self = new SearchDentriesResponseBodyItemsModifier();
            return TeaModel.build(map, self);
        }

        public SearchDentriesResponseBodyItemsModifier setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SearchDentriesResponseBodyItemsModifier setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class SearchDentriesResponseBodyItems extends TeaModel {
        @NameInMap("creator")
        public SearchDentriesResponseBodyItemsCreator creator;

        /**
         * <strong>example:</strong>
         * <p>uuid</p>
         */
        @NameInMap("dentryUuid")
        public String dentryUuid;

        @NameInMap("modifier")
        public SearchDentriesResponseBodyItemsModifier modifier;

        /**
         * <strong>example:</strong>
         * <p>name</p>
         */
        @NameInMap("name")
        public String name;

        public static SearchDentriesResponseBodyItems build(java.util.Map<String, ?> map) throws Exception {
            SearchDentriesResponseBodyItems self = new SearchDentriesResponseBodyItems();
            return TeaModel.build(map, self);
        }

        public SearchDentriesResponseBodyItems setCreator(SearchDentriesResponseBodyItemsCreator creator) {
            this.creator = creator;
            return this;
        }
        public SearchDentriesResponseBodyItemsCreator getCreator() {
            return this.creator;
        }

        public SearchDentriesResponseBodyItems setDentryUuid(String dentryUuid) {
            this.dentryUuid = dentryUuid;
            return this;
        }
        public String getDentryUuid() {
            return this.dentryUuid;
        }

        public SearchDentriesResponseBodyItems setModifier(SearchDentriesResponseBodyItemsModifier modifier) {
            this.modifier = modifier;
            return this;
        }
        public SearchDentriesResponseBodyItemsModifier getModifier() {
            return this.modifier;
        }

        public SearchDentriesResponseBodyItems setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
