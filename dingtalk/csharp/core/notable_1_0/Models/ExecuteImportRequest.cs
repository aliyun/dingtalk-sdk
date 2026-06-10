// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalknotable_1_0.Models
{
    public class ExecuteImportRequest : TeaModel {
        [NameInMap("appendConfig")]
        [Validation(Required=false)]
        public ExecuteImportRequestAppendConfig AppendConfig { get; set; }
        public class ExecuteImportRequestAppendConfig : TeaModel {
            [NameInMap("fieldMapping")]
            [Validation(Required=false)]
            public Dictionary<string, string> FieldMapping { get; set; }

            [NameInMap("headerRow")]
            [Validation(Required=false)]
            public int? HeaderRow { get; set; }

            [NameInMap("srcSheetName")]
            [Validation(Required=false)]
            public string SrcSheetName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("tableId")]
            [Validation(Required=false)]
            public string TableId { get; set; }

        }

        [NameInMap("encryption")]
        [Validation(Required=false)]
        public ExecuteImportRequestEncryption Encryption { get; set; }
        public class ExecuteImportRequestEncryption : TeaModel {
            [NameInMap("algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("encryptedAesKey")]
            [Validation(Required=false)]
            public string EncryptedAesKey { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("iv")]
            [Validation(Required=false)]
            public string Iv { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("keyVersion")]
            [Validation(Required=false)]
            public string KeyVersion { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("importId")]
        [Validation(Required=false)]
        public string ImportId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>union_id</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
