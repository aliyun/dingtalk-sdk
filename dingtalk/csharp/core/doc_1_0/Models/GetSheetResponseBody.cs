// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class GetSheetResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>column_count</para>
        /// </summary>
        [NameInMap("columnCount")]
        [Validation(Required=false)]
        public long? ColumnCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sheet_id</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>last_non_empty_column</para>
        /// </summary>
        [NameInMap("lastNonEmptyColumn")]
        [Validation(Required=false)]
        public long? LastNonEmptyColumn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>last_non_empty_row</para>
        /// </summary>
        [NameInMap("lastNonEmptyRow")]
        [Validation(Required=false)]
        public long? LastNonEmptyRow { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sheet_name</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>row_count</para>
        /// </summary>
        [NameInMap("rowCount")]
        [Validation(Required=false)]
        public long? RowCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>visible</para>
        /// </summary>
        [NameInMap("visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}
