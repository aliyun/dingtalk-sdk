// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class CreateFieldHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFieldRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  /**
   * @example
   * key: id或者name
   *     value: 对应字段值,不同类型的字段传入的value值不同
   *       - text: "TextString"          // 文本字符串
   *       - number: 123                 // 整数/浮点数均可
   *       - singleSelect: "optionIdxxx1" | "optionName1" // 单选选项Id/单选选项名
   *       - date: 1688601600000 ｜ "2023-12-20 03:00"
   *                                     // 支持传时间戳或ISO 8601字符串
   *       - user: [{
   *           uid: \"1234567\"            // 用户uid
   *         }, {
   *           uid: \"2345678\"
   *         }]
   */
  property?: { [key: string]: any };
  /**
   * @remarks
   * This parameter is required.
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      property: 'property',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      property: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFieldResponseBody extends $tea.Model {
  id?: string;
  name?: string;
  /**
   * @example
   * key: id或者name
   *     value: 对应字段值,不同类型的字段传入的value值不同
   *       - text: "TextString"          // 文本字符串
   *       - number: 123                 // 整数/浮点数均可
   *       - singleSelect: "optionIdxxx1" | "optionName1" // 单选选项Id/单选选项名
   *       - date: 1688601600000 ｜ "2023-12-20 03:00"
   *                                     // 支持传时间戳或ISO 8601字符串
   *       - user: [{
   *           uid: \"1234567\"            // 用户uid
   *         }, {
   *           uid: \"2345678\"
   *         }]
   */
  property?: { [key: string]: any };
  type?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      property: 'property',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      name: 'string',
      property: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFieldResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateFieldResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateFieldResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSheetHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSheetRequest extends $tea.Model {
  fields?: CreateSheetRequestFields[];
  name?: string;
  static names(): { [key: string]: string } {
    return {
      fields: 'fields',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fields: { 'type': 'array', 'itemType': CreateSheetRequestFields },
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSheetResponseBody extends $tea.Model {
  id?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSheetResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateSheetResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateSheetResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteFieldHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteFieldResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteFieldResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteFieldResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: DeleteFieldResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteRecordsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteRecordsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  recordIds?: string[];
  static names(): { [key: string]: string } {
    return {
      recordIds: 'recordIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      recordIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteRecordsResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteRecordsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteRecordsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: DeleteRecordsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteSheetHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteSheetResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteSheetResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteSheetResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: DeleteSheetResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllFieldsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllFieldsResponseBody extends $tea.Model {
  value?: GetAllFieldsResponseBodyValue[];
  static names(): { [key: string]: string } {
    return {
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      value: { 'type': 'array', 'itemType': GetAllFieldsResponseBodyValue },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllFieldsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetAllFieldsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetAllFieldsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllSheetsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllSheetsResponseBody extends $tea.Model {
  value?: GetAllSheetsResponseBodyValue[];
  static names(): { [key: string]: string } {
    return {
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      value: { 'type': 'array', 'itemType': GetAllSheetsResponseBodyValue },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllSheetsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetAllSheetsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetAllSheetsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecordHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecordResponseBody extends $tea.Model {
  fields?: { [key: string]: any };
  id?: string;
  static names(): { [key: string]: string } {
    return {
      fields: 'fields',
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fields: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      id: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecordResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetRecordResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetRecordResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecordsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecordsRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecordsResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  hasMore?: boolean;
  /**
   * @example
   * nextToken
   */
  nextToken?: string;
  records?: GetRecordsResponseBodyRecords[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      records: 'records',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextToken: 'string',
      records: { 'type': 'array', 'itemType': GetRecordsResponseBodyRecords },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecordsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetRecordsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetRecordsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSheetHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSheetResponseBody extends $tea.Model {
  id?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSheetResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSheetResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetSheetResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertRecordsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertRecordsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  records?: InsertRecordsRequestRecords[];
  static names(): { [key: string]: string } {
    return {
      records: 'records',
    };
  }

  static types(): { [key: string]: any } {
    return {
      records: { 'type': 'array', 'itemType': InsertRecordsRequestRecords },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertRecordsResponseBody extends $tea.Model {
  value?: InsertRecordsResponseBodyValue[];
  static names(): { [key: string]: string } {
    return {
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      value: { 'type': 'array', 'itemType': InsertRecordsResponseBodyValue },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertRecordsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: InsertRecordsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: InsertRecordsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateFieldHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateFieldRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  /**
   * @example
   * key: id或者name
   *     value: 对应字段值,不同类型的字段传入的value值不同
   *       - text: "TextString"          // 文本字符串
   *       - number: 123                 // 整数/浮点数均可
   *       - singleSelect: "optionIdxxx1" | "optionName1" // 单选选项Id/单选选项名
   *       - date: 1688601600000 ｜ "2023-12-20 03:00"
   *                                     // 支持传时间戳或ISO 8601字符串
   *       - user: [{
   *           uid: \"1234567\"            // 用户uid
   *         }, {
   *           uid: \"2345678\"
   *         }]
   */
  property?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      property: 'property',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      property: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateFieldResponseBody extends $tea.Model {
  id?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateFieldResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateFieldResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UpdateFieldResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRecordsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRecordsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  records?: UpdateRecordsRequestRecords[];
  static names(): { [key: string]: string } {
    return {
      records: 'records',
    };
  }

  static types(): { [key: string]: any } {
    return {
      records: { 'type': 'array', 'itemType': UpdateRecordsRequestRecords },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRecordsResponseBody extends $tea.Model {
  value?: UpdateRecordsResponseBodyValue[];
  static names(): { [key: string]: string } {
    return {
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      value: { 'type': 'array', 'itemType': UpdateRecordsResponseBodyValue },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRecordsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateRecordsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UpdateRecordsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateSheetHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateSheetRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateSheetResponseBody extends $tea.Model {
  id?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateSheetResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateSheetResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UpdateSheetResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSheetRequestFields extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  /**
   * @example
   * key: id或者name
   *     value: 对应字段值,不同类型的字段传入的value值不同
   *       - text: "TextString"          // 文本字符串
   *       - number: 123                 // 整数/浮点数均可
   *       - singleSelect: "optionIdxxx1" | "optionName1" // 单选选项Id/单选选项名
   *       - date: 1688601600000 ｜ "2023-12-20 03:00"
   *                                     // 支持传时间戳或ISO 8601字符串
   *       - user: [{
   *           uid: \"1234567\"            // 用户uid
   *         }, {
   *           uid: \"2345678\"
   *         }]
   */
  property?: { [key: string]: any };
  /**
   * @remarks
   * This parameter is required.
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      property: 'property',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      property: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllFieldsResponseBodyValue extends $tea.Model {
  id?: string;
  name?: string;
  /**
   * @example
   * key: id或者name
   *     value: 对应字段值,不同类型的字段传入的value值不同
   *       - text: "TextString"          // 文本字符串
   *       - number: 123                 // 整数/浮点数均可
   *       - singleSelect: "optionIdxxx1" | "optionName1" // 单选选项Id/单选选项名
   *       - date: 1688601600000 ｜ "2023-12-20 03:00"
   *                                     // 支持传时间戳或ISO 8601字符串
   *       - user: [{
   *           uid: \"1234567\"            // 用户uid
   *         }, {
   *           uid: \"2345678\"
   *         }]
   */
  property?: { [key: string]: any };
  type?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      property: 'property',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      name: 'string',
      property: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllSheetsResponseBodyValue extends $tea.Model {
  id?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetRecordsResponseBodyRecords extends $tea.Model {
  fields?: { [key: string]: any };
  id?: string;
  static names(): { [key: string]: string } {
    return {
      fields: 'fields',
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fields: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      id: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertRecordsRequestRecords extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  fields?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      fields: 'fields',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fields: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertRecordsResponseBodyValue extends $tea.Model {
  id?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRecordsRequestRecords extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  fields?: { [key: string]: any };
  /**
   * @remarks
   * This parameter is required.
   */
  id?: string;
  static names(): { [key: string]: string } {
    return {
      fields: 'fields',
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fields: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      id: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRecordsResponseBodyValue extends $tea.Model {
  id?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}


export default class Client extends OpenApi {

  constructor(config: $OpenApi.Config) {
    super(config);
    let gatewayClient = new GatewayClient();
    this._spi = gatewayClient;
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  /**
   * 新增数据表字段
   * 
   * @param request - CreateFieldRequest
   * @param headers - CreateFieldHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateFieldResponse
   */
  async createFieldWithOptions(baseId: string, sheetIdOrName: string, request: CreateFieldRequest, headers: CreateFieldHeaders, runtime: $Util.RuntimeOptions): Promise<CreateFieldResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.property)) {
      body["property"] = request.property;
    }

    if (!Util.isUnset(request.type)) {
      body["type"] = request.type;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CreateField",
      version: "notable_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/notable/bases/${baseId}/sheets/${sheetIdOrName}/fields`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateFieldResponse>(await this.execute(params, req, runtime), new CreateFieldResponse({}));
  }

  /**
   * 新增数据表字段
   * 
   * @param request - CreateFieldRequest
   * @returns CreateFieldResponse
   */
  async createField(baseId: string, sheetIdOrName: string, request: CreateFieldRequest): Promise<CreateFieldResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateFieldHeaders({ });
    return await this.createFieldWithOptions(baseId, sheetIdOrName, request, headers, runtime);
  }

  /**
   * 创建数据表
   * 
   * @param request - CreateSheetRequest
   * @param headers - CreateSheetHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateSheetResponse
   */
  async createSheetWithOptions(baseId: string, request: CreateSheetRequest, headers: CreateSheetHeaders, runtime: $Util.RuntimeOptions): Promise<CreateSheetResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.fields)) {
      body["fields"] = request.fields;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CreateSheet",
      version: "notable_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/notable/bases/${baseId}/sheets`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateSheetResponse>(await this.execute(params, req, runtime), new CreateSheetResponse({}));
  }

  /**
   * 创建数据表
   * 
   * @param request - CreateSheetRequest
   * @returns CreateSheetResponse
   */
  async createSheet(baseId: string, request: CreateSheetRequest): Promise<CreateSheetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateSheetHeaders({ });
    return await this.createSheetWithOptions(baseId, request, headers, runtime);
  }

  /**
   * 删除数据表字段
   * 
   * @param headers - DeleteFieldHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteFieldResponse
   */
  async deleteFieldWithOptions(baseId: string, sheetIdOrName: string, fieldIdOrName: string, headers: DeleteFieldHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteFieldResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    let params = new $OpenApi.Params({
      action: "DeleteField",
      version: "notable_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/notable/bases/${baseId}/sheets/${sheetIdOrName}/fields/${fieldIdOrName}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteFieldResponse>(await this.execute(params, req, runtime), new DeleteFieldResponse({}));
  }

  /**
   * 删除数据表字段
   * @returns DeleteFieldResponse
   */
  async deleteField(baseId: string, sheetIdOrName: string, fieldIdOrName: string): Promise<DeleteFieldResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteFieldHeaders({ });
    return await this.deleteFieldWithOptions(baseId, sheetIdOrName, fieldIdOrName, headers, runtime);
  }

  /**
   * 删除数据表多行记录
   * 
   * @param request - DeleteRecordsRequest
   * @param headers - DeleteRecordsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteRecordsResponse
   */
  async deleteRecordsWithOptions(baseId: string, sheetIdOrName: string, request: DeleteRecordsRequest, headers: DeleteRecordsHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteRecordsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.recordIds)) {
      body["recordIds"] = request.recordIds;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "DeleteRecords",
      version: "notable_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/notable/bases/${baseId}/sheets/${sheetIdOrName}/records/delete`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteRecordsResponse>(await this.execute(params, req, runtime), new DeleteRecordsResponse({}));
  }

  /**
   * 删除数据表多行记录
   * 
   * @param request - DeleteRecordsRequest
   * @returns DeleteRecordsResponse
   */
  async deleteRecords(baseId: string, sheetIdOrName: string, request: DeleteRecordsRequest): Promise<DeleteRecordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteRecordsHeaders({ });
    return await this.deleteRecordsWithOptions(baseId, sheetIdOrName, request, headers, runtime);
  }

  /**
   * 删除数据表
   * 
   * @param headers - DeleteSheetHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteSheetResponse
   */
  async deleteSheetWithOptions(baseId: string, sheetIdOrName: string, headers: DeleteSheetHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteSheetResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    let params = new $OpenApi.Params({
      action: "DeleteSheet",
      version: "notable_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/notable/bases/${baseId}/sheets/${sheetIdOrName}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteSheetResponse>(await this.execute(params, req, runtime), new DeleteSheetResponse({}));
  }

  /**
   * 删除数据表
   * @returns DeleteSheetResponse
   */
  async deleteSheet(baseId: string, sheetIdOrName: string): Promise<DeleteSheetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteSheetHeaders({ });
    return await this.deleteSheetWithOptions(baseId, sheetIdOrName, headers, runtime);
  }

  /**
   * 获取所有字段
   * 
   * @param headers - GetAllFieldsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetAllFieldsResponse
   */
  async getAllFieldsWithOptions(baseId: string, sheetIdOrName: string, headers: GetAllFieldsHeaders, runtime: $Util.RuntimeOptions): Promise<GetAllFieldsResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    let params = new $OpenApi.Params({
      action: "GetAllFields",
      version: "notable_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/notable/bases/${baseId}/sheets/${sheetIdOrName}/fields`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetAllFieldsResponse>(await this.execute(params, req, runtime), new GetAllFieldsResponse({}));
  }

  /**
   * 获取所有字段
   * @returns GetAllFieldsResponse
   */
  async getAllFields(baseId: string, sheetIdOrName: string): Promise<GetAllFieldsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAllFieldsHeaders({ });
    return await this.getAllFieldsWithOptions(baseId, sheetIdOrName, headers, runtime);
  }

  /**
   * 获取所有数据表
   * 
   * @param headers - GetAllSheetsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetAllSheetsResponse
   */
  async getAllSheetsWithOptions(baseId: string, headers: GetAllSheetsHeaders, runtime: $Util.RuntimeOptions): Promise<GetAllSheetsResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    let params = new $OpenApi.Params({
      action: "GetAllSheets",
      version: "notable_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/notable/bases/${baseId}/sheets`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetAllSheetsResponse>(await this.execute(params, req, runtime), new GetAllSheetsResponse({}));
  }

  /**
   * 获取所有数据表
   * @returns GetAllSheetsResponse
   */
  async getAllSheets(baseId: string): Promise<GetAllSheetsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAllSheetsHeaders({ });
    return await this.getAllSheetsWithOptions(baseId, headers, runtime);
  }

  /**
   * 获取记录
   * 
   * @param headers - GetRecordHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetRecordResponse
   */
  async getRecordWithOptions(baseId: string, sheetIdOrName: string, recordId: string, headers: GetRecordHeaders, runtime: $Util.RuntimeOptions): Promise<GetRecordResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    let params = new $OpenApi.Params({
      action: "GetRecord",
      version: "notable_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/notable/bases/${baseId}/sheets/${sheetIdOrName}/records/${recordId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetRecordResponse>(await this.execute(params, req, runtime), new GetRecordResponse({}));
  }

  /**
   * 获取记录
   * @returns GetRecordResponse
   */
  async getRecord(baseId: string, sheetIdOrName: string, recordId: string): Promise<GetRecordResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRecordHeaders({ });
    return await this.getRecordWithOptions(baseId, sheetIdOrName, recordId, headers, runtime);
  }

  /**
   * 获取多行记录
   * 
   * @param request - GetRecordsRequest
   * @param headers - GetRecordsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetRecordsResponse
   */
  async getRecordsWithOptions(baseId: string, sheetIdOrName: string, request: GetRecordsRequest, headers: GetRecordsHeaders, runtime: $Util.RuntimeOptions): Promise<GetRecordsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetRecords",
      version: "notable_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/notable/bases/${baseId}/sheets/${sheetIdOrName}/records`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetRecordsResponse>(await this.execute(params, req, runtime), new GetRecordsResponse({}));
  }

  /**
   * 获取多行记录
   * 
   * @param request - GetRecordsRequest
   * @returns GetRecordsResponse
   */
  async getRecords(baseId: string, sheetIdOrName: string, request: GetRecordsRequest): Promise<GetRecordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetRecordsHeaders({ });
    return await this.getRecordsWithOptions(baseId, sheetIdOrName, request, headers, runtime);
  }

  /**
   * 获取数据表
   * 
   * @param headers - GetSheetHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSheetResponse
   */
  async getSheetWithOptions(baseId: string, sheetIdOrName: string, headers: GetSheetHeaders, runtime: $Util.RuntimeOptions): Promise<GetSheetResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    let params = new $OpenApi.Params({
      action: "GetSheet",
      version: "notable_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/notable/bases/${baseId}/sheets/${sheetIdOrName}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSheetResponse>(await this.execute(params, req, runtime), new GetSheetResponse({}));
  }

  /**
   * 获取数据表
   * @returns GetSheetResponse
   */
  async getSheet(baseId: string, sheetIdOrName: string): Promise<GetSheetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSheetHeaders({ });
    return await this.getSheetWithOptions(baseId, sheetIdOrName, headers, runtime);
  }

  /**
   * 新增记录
   * 
   * @param request - InsertRecordsRequest
   * @param headers - InsertRecordsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns InsertRecordsResponse
   */
  async insertRecordsWithOptions(baseId: string, sheetIdOrName: string, request: InsertRecordsRequest, headers: InsertRecordsHeaders, runtime: $Util.RuntimeOptions): Promise<InsertRecordsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.records)) {
      body["records"] = request.records;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "InsertRecords",
      version: "notable_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/notable/bases/${baseId}/sheets/${sheetIdOrName}/records`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<InsertRecordsResponse>(await this.execute(params, req, runtime), new InsertRecordsResponse({}));
  }

  /**
   * 新增记录
   * 
   * @param request - InsertRecordsRequest
   * @returns InsertRecordsResponse
   */
  async insertRecords(baseId: string, sheetIdOrName: string, request: InsertRecordsRequest): Promise<InsertRecordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InsertRecordsHeaders({ });
    return await this.insertRecordsWithOptions(baseId, sheetIdOrName, request, headers, runtime);
  }

  /**
   * 更新数据表字段
   * 
   * @param request - UpdateFieldRequest
   * @param headers - UpdateFieldHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateFieldResponse
   */
  async updateFieldWithOptions(baseId: string, sheetIdOrName: string, fieldIdOrName: string, request: UpdateFieldRequest, headers: UpdateFieldHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateFieldResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.property)) {
      body["property"] = request.property;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "UpdateField",
      version: "notable_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/notable/bases/${baseId}/sheets/${sheetIdOrName}/fields/${fieldIdOrName}`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateFieldResponse>(await this.execute(params, req, runtime), new UpdateFieldResponse({}));
  }

  /**
   * 更新数据表字段
   * 
   * @param request - UpdateFieldRequest
   * @returns UpdateFieldResponse
   */
  async updateField(baseId: string, sheetIdOrName: string, fieldIdOrName: string, request: UpdateFieldRequest): Promise<UpdateFieldResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateFieldHeaders({ });
    return await this.updateFieldWithOptions(baseId, sheetIdOrName, fieldIdOrName, request, headers, runtime);
  }

  /**
   * 更新数据表多行记录
   * 
   * @param request - UpdateRecordsRequest
   * @param headers - UpdateRecordsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateRecordsResponse
   */
  async updateRecordsWithOptions(baseId: string, sheetIdOrName: string, request: UpdateRecordsRequest, headers: UpdateRecordsHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateRecordsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.records)) {
      body["records"] = request.records;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "UpdateRecords",
      version: "notable_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/notable/bases/${baseId}/sheets/${sheetIdOrName}/records`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateRecordsResponse>(await this.execute(params, req, runtime), new UpdateRecordsResponse({}));
  }

  /**
   * 更新数据表多行记录
   * 
   * @param request - UpdateRecordsRequest
   * @returns UpdateRecordsResponse
   */
  async updateRecords(baseId: string, sheetIdOrName: string, request: UpdateRecordsRequest): Promise<UpdateRecordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateRecordsHeaders({ });
    return await this.updateRecordsWithOptions(baseId, sheetIdOrName, request, headers, runtime);
  }

  /**
   * 更新数据表
   * 
   * @param request - UpdateSheetRequest
   * @param headers - UpdateSheetHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateSheetResponse
   */
  async updateSheetWithOptions(baseId: string, sheetIdOrName: string, request: UpdateSheetRequest, headers: UpdateSheetHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateSheetResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "UpdateSheet",
      version: "notable_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/notable/bases/${baseId}/sheets/${sheetIdOrName}`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateSheetResponse>(await this.execute(params, req, runtime), new UpdateSheetResponse({}));
  }

  /**
   * 更新数据表
   * 
   * @param request - UpdateSheetRequest
   * @returns UpdateSheetResponse
   */
  async updateSheet(baseId: string, sheetIdOrName: string, request: UpdateSheetRequest): Promise<UpdateSheetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateSheetHeaders({ });
    return await this.updateSheetWithOptions(baseId, sheetIdOrName, request, headers, runtime);
  }

}
