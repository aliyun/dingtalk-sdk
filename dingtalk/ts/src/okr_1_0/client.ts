// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import { Readable } from 'stream';
import * as $tea from '@alicloud/tea-typescript';

export class OpenKeyResultDTO extends $tea.Model {
  /**
   * @example
   * 65222713d0e8b868f9f9ae51
   */
  krId?: string;
  /**
   * @example
   * 80
   */
  progress?: number;
  /**
   * @example
   * 1
   */
  status?: number;
  /**
   * @example
   * 这是一个KR
   */
  title?: string;
  titleMentions?: TitleMention[];
  /**
   * @example
   * 1
   */
  type?: number;
  /**
   * @example
   * 10.00
   */
  weight?: number;
  static names(): { [key: string]: string } {
    return {
      krId: 'krId',
      progress: 'progress',
      status: 'status',
      title: 'title',
      titleMentions: 'titleMentions',
      type: 'type',
      weight: 'weight',
    };
  }

  static types(): { [key: string]: any } {
    return {
      krId: 'string',
      progress: 'number',
      status: 'number',
      title: 'string',
      titleMentions: { 'type': 'array', 'itemType': TitleMention },
      type: 'number',
      weight: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenObjectiveDTO extends $tea.Model {
  executor?: OpenUserDTO;
  keyResults?: OpenKeyResultDTO[];
  /**
   * @example
   * 65222640d0e8b868f9f9ae3c
   */
  objectiveId?: string;
  period?: OpenPeriodDTO;
  /**
   * @example
   * 80
   */
  progress?: number;
  /**
   * @example
   * 1
   */
  status?: number;
  teams?: OpenTeamDTO[];
  /**
   * @example
   * 这是一个O的标题
   */
  title?: string;
  /**
   * @example
   * 10.00
   */
  weight?: number;
  static names(): { [key: string]: string } {
    return {
      executor: 'executor',
      keyResults: 'keyResults',
      objectiveId: 'objectiveId',
      period: 'period',
      progress: 'progress',
      status: 'status',
      teams: 'teams',
      title: 'title',
      weight: 'weight',
    };
  }

  static types(): { [key: string]: any } {
    return {
      executor: OpenUserDTO,
      keyResults: { 'type': 'array', 'itemType': OpenKeyResultDTO },
      objectiveId: 'string',
      period: OpenPeriodDTO,
      progress: 'number',
      status: 'number',
      teams: { 'type': 'array', 'itemType': OpenTeamDTO },
      title: 'string',
      weight: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenPeriodDTO extends $tea.Model {
  endDate?: number;
  nameCn?: string;
  nameEn?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  periodId?: string;
  startDate?: number;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      endDate: 'endDate',
      nameCn: 'nameCn',
      nameEn: 'nameEn',
      periodId: 'periodId',
      startDate: 'startDate',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endDate: 'number',
      nameCn: 'string',
      nameEn: 'string',
      periodId: 'string',
      startDate: 'number',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenTeamDTO extends $tea.Model {
  /**
   * @example
   * 0342464558835299
   */
  deptUid?: string;
  /**
   * @example
   * 64cd2e9bb80efb17244c650d
   */
  dingDeptId?: string;
  /**
   * @example
   * xx部门
   */
  name?: string;
  static names(): { [key: string]: string } {
    return {
      deptUid: 'deptUid',
      dingDeptId: 'dingDeptId',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptUid: 'string',
      dingDeptId: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenUserDTO extends $tea.Model {
  /**
   * @example
   * 0342464558835299
   */
  dingUserId?: string;
  /**
   * @example
   * 小明
   */
  name?: string;
  /**
   * @example
   * 64cd2e9bb80efb17244c650d
   */
  userUid?: string;
  /**
   * @example
   * 2639402752-1812711657
   */
  workNo?: string;
  static names(): { [key: string]: string } {
    return {
      dingUserId: 'dingUserId',
      name: 'name',
      userUid: 'userUid',
      workNo: 'workNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingUserId: 'string',
      name: 'string',
      userUid: 'string',
      workNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TitleMention extends $tea.Model {
  /**
   * @example
   * 20
   */
  length?: number;
  /**
   * @example
   * 1
   */
  offset?: number;
  user?: OpenUserDTO;
  static names(): { [key: string]: string } {
    return {
      length: 'length',
      offset: 'offset',
      user: 'user',
    };
  }

  static types(): { [key: string]: any } {
    return {
      length: 'number',
      offset: 'number',
      user: OpenUserDTO,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AlignObjectiveHeaders extends $tea.Model {
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

export class AlignObjectiveRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1006
   */
  periodId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 59YD
   */
  targetId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0115396701752283
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      periodId: 'periodId',
      targetId: 'targetId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      periodId: 'string',
      targetId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AlignObjectiveResponseBody extends $tea.Model {
  data?: AlignObjectiveResponseBodyData;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: AlignObjectiveResponseBodyData,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AlignObjectiveResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AlignObjectiveResponseBody;
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
      body: AlignObjectiveResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddPermissionHeaders extends $tea.Model {
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

export class BatchAddPermissionRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  list?: BatchAddPermissionRequestList[];
  /**
   * @remarks
   * This parameter is required.
   */
  targetId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  targetType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 当前用户 userId。
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      list: 'list',
      targetId: 'targetId',
      targetType: 'targetType',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': BatchAddPermissionRequestList },
      targetId: 'string',
      targetType: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddPermissionResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  data?: BatchAddPermissionResponseBodyData;
  /**
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: BatchAddPermissionResponseBodyData,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddPermissionResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchAddPermissionResponseBody;
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
      body: BatchAddPermissionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryObjectiveHeaders extends $tea.Model {
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

export class BatchQueryObjectiveRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  objectiveIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10056
   */
  periodId?: string;
  /**
   * @example
   * false
   */
  withAlign?: boolean;
  /**
   * @example
   * false
   */
  withKr?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  withProgress?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0115396701752283
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      objectiveIds: 'objectiveIds',
      periodId: 'periodId',
      withAlign: 'withAlign',
      withKr: 'withKr',
      withProgress: 'withProgress',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      objectiveIds: { 'type': 'array', 'itemType': 'string' },
      periodId: 'string',
      withAlign: 'boolean',
      withKr: 'boolean',
      withProgress: 'boolean',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryObjectiveResponseBody extends $tea.Model {
  data?: BatchQueryObjectiveResponseBodyData[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': BatchQueryObjectiveResponseBodyData },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryObjectiveResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchQueryObjectiveResponseBody;
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
      body: BatchQueryObjectiveResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryUserHeaders extends $tea.Model {
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

export class BatchQueryUserRequest extends $tea.Model {
  okrUserIds?: string[];
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      okrUserIds: 'okrUserIds',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      okrUserIds: { 'type': 'array', 'itemType': 'string' },
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryUserResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  data?: BatchQueryUserResponseBodyData[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': BatchQueryUserResponseBodyData },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryUserResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchQueryUserResponseBody;
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
      body: BatchQueryUserResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateKeyResultHeaders extends $tea.Model {
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

export class CreateKeyResultRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 我的内容
   */
  content?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 58Y4
   */
  objectiveId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1006
   */
  periodId?: string;
  /**
   * @example
   * 234631
   */
  prevPosition?: number;
  /**
   * @example
   * 100
   */
  weight?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 06186238011033616
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      objectiveId: 'objectiveId',
      periodId: 'periodId',
      prevPosition: 'prevPosition',
      weight: 'weight',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      objectiveId: 'string',
      periodId: 'string',
      prevPosition: 'number',
      weight: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateKeyResultResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  data?: CreateKeyResultResponseBodyData;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: CreateKeyResultResponseBodyData,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateKeyResultResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateKeyResultResponseBody;
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
      body: CreateKeyResultResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateObjectiveHeaders extends $tea.Model {
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

export class CreateObjectiveRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 我是内容
   */
  content?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1006
   */
  periodId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1334543
   */
  prevPosition?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 06186238011033616
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      periodId: 'periodId',
      prevPosition: 'prevPosition',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      periodId: 'string',
      prevPosition: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateObjectiveResponseBody extends $tea.Model {
  data?: CreateObjectiveResponseBodyData;
  /**
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: CreateObjectiveResponseBodyData,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateObjectiveResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateObjectiveResponseBody;
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
      body: CreateObjectiveResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteKeyResultHeaders extends $tea.Model {
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

export class DeleteKeyResultRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 4d2d
   */
  krId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 06186238011033616
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      krId: 'krId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      krId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteKeyResultResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * success
   */
  data?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteKeyResultResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteKeyResultResponseBody;
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
      body: DeleteKeyResultResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteObjectiveHeaders extends $tea.Model {
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

export class DeleteObjectiveRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 06186238011033616
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteObjectiveResponseBody extends $tea.Model {
  data?: DeleteObjectiveResponseBodyData;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: DeleteObjectiveResponseBodyData,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteObjectiveResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteObjectiveResponseBody;
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
      body: DeleteObjectiveResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeletePermissionHeaders extends $tea.Model {
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

export class DeletePermissionRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  policyType?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  targetId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  targetType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  type?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0115396701752283
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      policyType: 'policyType',
      targetId: 'targetId',
      targetType: 'targetType',
      type: 'type',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      policyType: 'number',
      targetId: 'string',
      targetType: 'string',
      type: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeletePermissionResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  data?: DeletePermissionResponseBodyData;
  /**
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: DeletePermissionResponseBodyData,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeletePermissionResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeletePermissionResponseBody;
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
      body: DeletePermissionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPeriodListHeaders extends $tea.Model {
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

export class GetPeriodListResponseBody extends $tea.Model {
  data?: GetPeriodListResponseBodyData;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: GetPeriodListResponseBodyData,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPeriodListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetPeriodListResponseBody;
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
      body: GetPeriodListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPermissionHeaders extends $tea.Model {
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

export class GetPermissionRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  targetId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  targetType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 当前用户 userId。
   */
  userId?: string;
  withKr?: boolean;
  withObjective?: boolean;
  static names(): { [key: string]: string } {
    return {
      targetId: 'targetId',
      targetType: 'targetType',
      userId: 'userId',
      withKr: 'withKr',
      withObjective: 'withObjective',
    };
  }

  static types(): { [key: string]: any } {
    return {
      targetId: 'string',
      targetType: 'string',
      userId: 'string',
      withKr: 'boolean',
      withObjective: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPermissionResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  data?: GetPermissionResponseBodyData;
  /**
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: GetPermissionResponseBodyData,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPermissionResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetPermissionResponseBody;
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
      body: GetPermissionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserOkrHeaders extends $tea.Model {
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

export class GetUserOkrRequest extends $tea.Model {
  /**
   * @example
   * 2
   */
  pageNumber?: number;
  /**
   * @example
   * 30
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1005
   */
  periodId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 011539670175223
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      periodId: 'periodId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      periodId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserOkrResponseBody extends $tea.Model {
  data?: GetUserOkrResponseBodyData;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: GetUserOkrResponseBodyData,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserOkrResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetUserOkrResponseBody;
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
      body: GetUserOkrResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OkrObjectivesBatchHeaders extends $tea.Model {
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

export class OkrObjectivesBatchRequest extends $tea.Model {
  /**
   * @example
   * dingOKR
   */
  goodsCode?: string;
  objectiveIds?: string[];
  static names(): { [key: string]: string } {
    return {
      goodsCode: 'goodsCode',
      objectiveIds: 'objectiveIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      goodsCode: 'string',
      objectiveIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OkrObjectivesBatchResponseBody extends $tea.Model {
  content?: OpenObjectiveDTO[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': OpenObjectiveDTO },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OkrObjectivesBatchResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: OkrObjectivesBatchResponseBody;
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
      body: OkrObjectivesBatchResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OkrObjectivesByUserHeaders extends $tea.Model {
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

export class OkrObjectivesByUserRequest extends $tea.Model {
  /**
   * @example
   * dingOKR
   */
  goodsCode?: string;
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      goodsCode: 'goodsCode',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      goodsCode: 'string',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OkrObjectivesByUserResponseBody extends $tea.Model {
  content?: OkrObjectivesByUserResponseBodyContent;
  requestId?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      requestId: 'requestId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: OkrObjectivesByUserResponseBodyContent,
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OkrObjectivesByUserResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: OkrObjectivesByUserResponseBody;
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
      body: OkrObjectivesByUserResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OkrPeriodsHeaders extends $tea.Model {
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

export class OkrPeriodsRequest extends $tea.Model {
  /**
   * @example
   * dingOKR
   */
  goodsCode?: string;
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @example
   * 0
   */
  status?: number;
  static names(): { [key: string]: string } {
    return {
      goodsCode: 'goodsCode',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      goodsCode: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OkrPeriodsResponseBody extends $tea.Model {
  content?: OkrPeriodsResponseBodyContent;
  requestId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      requestId: 'requestId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: OkrPeriodsResponseBodyContent,
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OkrPeriodsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: OkrPeriodsResponseBody;
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
      body: OkrPeriodsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnAlignObjectiveHeaders extends $tea.Model {
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

export class UnAlignObjectiveRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1006
   */
  periodId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 59YD
   */
  targetId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0115396701752283
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      periodId: 'periodId',
      targetId: 'targetId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      periodId: 'string',
      targetId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnAlignObjectiveResponseBody extends $tea.Model {
  data?: UnAlignObjectiveResponseBodyData;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: UnAlignObjectiveResponseBodyData,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnAlignObjectiveResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UnAlignObjectiveResponseBody;
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
      body: UnAlignObjectiveResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateKROfContentHeaders extends $tea.Model {
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

export class UpdateKROfContentRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 更新内容
   */
  content?: string;
  updateQuoteList?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 46GM2
   */
  krId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0115396701752283
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      updateQuoteList: 'updateQuoteList',
      krId: 'krId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      updateQuoteList: { 'type': 'array', 'itemType': 'string' },
      krId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateKROfContentResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  data?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateKROfContentResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateKROfContentResponseBody;
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
      body: UpdateKROfContentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateKROfScoreHeaders extends $tea.Model {
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

export class UpdateKROfScoreRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  score?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 46GM2
   */
  krId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0115396701752283
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      score: 'score',
      krId: 'krId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      score: 'number',
      krId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateKROfScoreResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  data?: UpdateKROfScoreResponseBodyData;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: UpdateKROfScoreResponseBodyData,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateKROfScoreResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateKROfScoreResponseBody;
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
      body: UpdateKROfScoreResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateKROfWeightHeaders extends $tea.Model {
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

export class UpdateKROfWeightRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 100
   */
  weight?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 46GM2
   */
  krId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0115396701752283
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      weight: 'weight',
      krId: 'krId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      weight: 'number',
      krId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateKROfWeightResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  data?: UpdateKROfWeightResponseBodyData;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: UpdateKROfWeightResponseBodyData,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateKROfWeightResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateKROfWeightResponseBody;
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
      body: UpdateKROfWeightResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateObjectiveHeaders extends $tea.Model {
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

export class UpdateObjectiveRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 更新的内容
   */
  content?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 06186238011033616
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateObjectiveResponseBody extends $tea.Model {
  data?: UpdateObjectiveResponseBodyData;
  /**
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: UpdateObjectiveResponseBodyData,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateObjectiveResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateObjectiveResponseBody;
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
      body: UpdateObjectiveResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdatePrivacyHeaders extends $tea.Model {
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

export class UpdatePrivacyRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * public
   */
  privacy?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3RF5
   */
  targetId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2
   */
  targetType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0115396701752283
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      privacy: 'privacy',
      targetId: 'targetId',
      targetType: 'targetType',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      privacy: 'string',
      targetId: 'string',
      targetType: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdatePrivacyResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  data?: UpdatePrivacyResponseBodyData;
  /**
   * @example
   * true
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: UpdatePrivacyResponseBodyData,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdatePrivacyResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdatePrivacyResponseBody;
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
      body: UpdatePrivacyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AlignObjectiveResponseBodyData extends $tea.Model {
  /**
   * @example
   * 59YD
   */
  alignId?: Readable;
  /**
   * @example
   * 5dAX8
   */
  id?: Readable;
  static names(): { [key: string]: string } {
    return {
      alignId: 'alignId',
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      alignId: 'Readable',
      id: 'Readable',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddPermissionRequestListMember extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddPermissionRequestList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  member?: BatchAddPermissionRequestListMember;
  /**
   * @remarks
   * This parameter is required.
   */
  policyType?: number;
  static names(): { [key: string]: string } {
    return {
      member: 'member',
      policyType: 'policyType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      member: BatchAddPermissionRequestListMember,
      policyType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddPermissionResponseBodyDataPermissionTreePolicyListMemberList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  id?: string;
  nickname?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      nickname: 'nickname',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      nickname: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddPermissionResponseBodyDataPermissionTreePolicyList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  memberList?: BatchAddPermissionResponseBodyDataPermissionTreePolicyListMemberList[];
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  type?: number;
  static names(): { [key: string]: string } {
    return {
      memberList: 'memberList',
      name: 'name',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberList: { 'type': 'array', 'itemType': BatchAddPermissionResponseBodyDataPermissionTreePolicyListMemberList },
      name: 'string',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddPermissionResponseBodyDataPermissionTree extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  policyList?: BatchAddPermissionResponseBodyDataPermissionTreePolicyList[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * public
   */
  privacy?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * period
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      policyList: 'policyList',
      privacy: 'privacy',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      policyList: { 'type': 'array', 'itemType': BatchAddPermissionResponseBodyDataPermissionTreePolicyList },
      privacy: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddPermissionResponseBodyData extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  hasInvalidUser?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  permissionTree?: BatchAddPermissionResponseBodyDataPermissionTree;
  static names(): { [key: string]: string } {
    return {
      hasInvalidUser: 'hasInvalidUser',
      permissionTree: 'permissionTree',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasInvalidUser: 'boolean',
      permissionTree: BatchAddPermissionResponseBodyDataPermissionTree,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryObjectiveResponseBodyDataKrListProgress extends $tea.Model {
  /**
   * @example
   * 30
   */
  percent?: number;
  static names(): { [key: string]: string } {
    return {
      percent: 'percent',
    };
  }

  static types(): { [key: string]: any } {
    return {
      percent: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryObjectiveResponseBodyDataKrList extends $tea.Model {
  /**
   * @example
   * 你好
   */
  content?: Readable;
  /**
   * @example
   * 1648625407694
   */
  gmtCreate?: number;
  /**
   * @example
   * 1648625407694
   */
  gmtModified?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 5w9f
   */
  id?: Readable;
  /**
   * @example
   * 5wf8
   */
  objectiveId?: Readable;
  permission?: number[];
  /**
   * @example
   * 35614536
   */
  position?: number;
  progress?: BatchQueryObjectiveResponseBodyDataKrListProgress;
  /**
   * @example
   * 44
   */
  score?: number;
  /**
   * @example
   * 44
   */
  weight?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      id: 'id',
      objectiveId: 'objectiveId',
      permission: 'permission',
      position: 'position',
      progress: 'progress',
      score: 'score',
      weight: 'weight',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'Readable',
      gmtCreate: 'number',
      gmtModified: 'number',
      id: 'Readable',
      objectiveId: 'Readable',
      permission: { 'type': 'array', 'itemType': 'number' },
      position: 'number',
      progress: BatchQueryObjectiveResponseBodyDataKrListProgress,
      score: 'number',
      weight: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryObjectiveResponseBodyDataOwner extends $tea.Model {
  /**
   * @example
   * @lADPDh0cQ_j4Mi_NBULNBUA
   */
  avatarMediaId?: Readable;
  /**
   * @example
   * ding4d1c8883ff63ee8124f2f5cc6abecb85
   */
  corpId?: Readable;
  /**
   * @example
   * K1AMgq
   */
  id?: Readable;
  /**
   * @example
   * 你好
   */
  nickname?: Readable;
  /**
   * @example
   * 06186238011033616
   */
  userId?: Readable;
  static names(): { [key: string]: string } {
    return {
      avatarMediaId: 'avatarMediaId',
      corpId: 'corpId',
      id: 'id',
      nickname: 'nickname',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatarMediaId: 'Readable',
      corpId: 'Readable',
      id: 'Readable',
      nickname: 'Readable',
      userId: 'Readable',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryObjectiveResponseBodyDataProgress extends $tea.Model {
  /**
   * @example
   * 100
   */
  percent?: number;
  static names(): { [key: string]: string } {
    return {
      percent: 'percent',
    };
  }

  static types(): { [key: string]: any } {
    return {
      percent: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryObjectiveResponseBodyData extends $tea.Model {
  alignFromIds?: Readable[];
  alignToIds?: Readable[];
  /**
   * @example
   * Objective demo
   */
  content?: Readable;
  /**
   * @example
   * 1648625407694
   */
  gmtCreate?: number;
  /**
   * @example
   * 1648625407694
   */
  gmtModified?: number;
  /**
   * @example
   * 5dAX8
   */
  id?: Readable;
  krList?: BatchQueryObjectiveResponseBodyDataKrList[];
  owner?: BatchQueryObjectiveResponseBodyDataOwner;
  /**
   * @example
   * 1006
   */
  periodId?: Readable;
  permission?: number[];
  /**
   * @example
   * 3021332
   */
  position?: number;
  progress?: BatchQueryObjectiveResponseBodyDataProgress;
  /**
   * @example
   * 100
   */
  progressPercent?: number;
  /**
   * @example
   * true
   */
  published?: boolean;
  /**
   * @example
   * 20
   */
  score?: number;
  /**
   * @example
   * 0
   */
  status?: number;
  /**
   * @example
   * s34d
   */
  userId?: Readable;
  /**
   * @example
   * 50
   */
  weight?: number;
  static names(): { [key: string]: string } {
    return {
      alignFromIds: 'alignFromIds',
      alignToIds: 'alignToIds',
      content: 'content',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      id: 'id',
      krList: 'krList',
      owner: 'owner',
      periodId: 'periodId',
      permission: 'permission',
      position: 'position',
      progress: 'progress',
      progressPercent: 'progressPercent',
      published: 'published',
      score: 'score',
      status: 'status',
      userId: 'userId',
      weight: 'weight',
    };
  }

  static types(): { [key: string]: any } {
    return {
      alignFromIds: { 'type': 'array', 'itemType': 'Readable' },
      alignToIds: { 'type': 'array', 'itemType': 'Readable' },
      content: 'Readable',
      gmtCreate: 'number',
      gmtModified: 'number',
      id: 'Readable',
      krList: { 'type': 'array', 'itemType': BatchQueryObjectiveResponseBodyDataKrList },
      owner: BatchQueryObjectiveResponseBodyDataOwner,
      periodId: 'Readable',
      permission: { 'type': 'array', 'itemType': 'number' },
      position: 'number',
      progress: BatchQueryObjectiveResponseBodyDataProgress,
      progressPercent: 'number',
      published: 'boolean',
      score: 'number',
      status: 'number',
      userId: 'Readable',
      weight: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryUserResponseBodyData extends $tea.Model {
  /**
   * @example
   * @lADPDh0cQ_j4Mi_NBULNBUA
   */
  avatarMediaId?: Readable;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://static.dingtalk.com/media/lADPEj_RiGhUdKjNC9TNC9A_3024_3028.jpg_620x10000q90.jpg
   */
  avatarUrl?: Readable;
  /**
   * @example
   * ding4d1c8883ff63ee8124f2f5cc6abecb85
   */
  corpId?: Readable;
  /**
   * @example
   * K1AMgq
   */
  id?: Readable;
  /**
   * @example
   * 你好
   */
  nickname?: Readable;
  /**
   * @example
   * 06186238011033616
   */
  userId?: Readable;
  static names(): { [key: string]: string } {
    return {
      avatarMediaId: 'avatarMediaId',
      avatarUrl: 'avatarUrl',
      corpId: 'corpId',
      id: 'id',
      nickname: 'nickname',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatarMediaId: 'Readable',
      avatarUrl: 'Readable',
      corpId: 'Readable',
      id: 'Readable',
      nickname: 'Readable',
      userId: 'Readable',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateKeyResultResponseBodyData extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * R45Y
   */
  id?: Readable;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 420983
   */
  position?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 100
   */
  weight?: number;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      position: 'position',
      weight: 'weight',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'Readable',
      position: 'number',
      weight: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateObjectiveResponseBodyData extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 58YD
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 33453
   */
  position?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      position: 'position',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      position: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteObjectiveResponseBodyData extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 58YD
   */
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

export class DeletePermissionResponseBodyDataPolicyListMemberList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  id?: string;
  nickname?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      nickname: 'nickname',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      nickname: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeletePermissionResponseBodyDataPolicyList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  memberList?: DeletePermissionResponseBodyDataPolicyListMemberList[];
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  type?: number;
  static names(): { [key: string]: string } {
    return {
      memberList: 'memberList',
      name: 'name',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberList: { 'type': 'array', 'itemType': DeletePermissionResponseBodyDataPolicyListMemberList },
      name: 'string',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeletePermissionResponseBodyData extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  policyList?: DeletePermissionResponseBodyDataPolicyList[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * public
   */
  privacy?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * period
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      policyList: 'policyList',
      privacy: 'privacy',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      policyList: { 'type': 'array', 'itemType': DeletePermissionResponseBodyDataPolicyList },
      privacy: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPeriodListResponseBodyDataPeriodList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  endTime?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  id?: Readable;
  /**
   * @remarks
   * This parameter is required.
   */
  isCurrent?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  isYearly?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  name?: Readable;
  /**
   * @remarks
   * This parameter is required.
   */
  startTime?: number;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      id: 'id',
      isCurrent: 'isCurrent',
      isYearly: 'isYearly',
      name: 'name',
      startTime: 'startTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      id: 'Readable',
      isCurrent: 'boolean',
      isYearly: 'boolean',
      name: 'Readable',
      startTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPeriodListResponseBodyData extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  periodList?: GetPeriodListResponseBodyDataPeriodList[];
  static names(): { [key: string]: string } {
    return {
      periodList: 'periodList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      periodList: { 'type': 'array', 'itemType': GetPeriodListResponseBodyDataPeriodList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPermissionResponseBodyDataPolicyListMemberList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  id?: string;
  nickname?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      nickname: 'nickname',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      nickname: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPermissionResponseBodyDataPolicyList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  memberList?: GetPermissionResponseBodyDataPolicyListMemberList[];
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  type?: number;
  static names(): { [key: string]: string } {
    return {
      memberList: 'memberList',
      name: 'name',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberList: { 'type': 'array', 'itemType': GetPermissionResponseBodyDataPolicyListMemberList },
      name: 'string',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPermissionResponseBodyData extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  policyList?: GetPermissionResponseBodyDataPolicyList[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * public
   */
  privacy?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * period
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      policyList: 'policyList',
      privacy: 'privacy',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      policyList: { 'type': 'array', 'itemType': GetPermissionResponseBodyDataPolicyList },
      privacy: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserOkrResponseBodyDataListKrListProgress extends $tea.Model {
  /**
   * @example
   * 30
   */
  percent?: number;
  static names(): { [key: string]: string } {
    return {
      percent: 'percent',
    };
  }

  static types(): { [key: string]: any } {
    return {
      percent: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserOkrResponseBodyDataListKrList extends $tea.Model {
  /**
   * @example
   * 你好
   */
  content?: Readable;
  /**
   * @example
   * 1648625407694
   */
  gmtCreate?: number;
  /**
   * @example
   * 1648625407694
   */
  gmtModified?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 5w9f
   */
  id?: Readable;
  /**
   * @example
   * 5wf8
   */
  objectiveId?: Readable;
  permission?: number[];
  /**
   * @example
   * 35614536
   */
  position?: number;
  progress?: GetUserOkrResponseBodyDataListKrListProgress;
  /**
   * @example
   * 44
   */
  score?: number;
  /**
   * @example
   * 44
   */
  weight?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      id: 'id',
      objectiveId: 'objectiveId',
      permission: 'permission',
      position: 'position',
      progress: 'progress',
      score: 'score',
      weight: 'weight',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'Readable',
      gmtCreate: 'number',
      gmtModified: 'number',
      id: 'Readable',
      objectiveId: 'Readable',
      permission: { 'type': 'array', 'itemType': 'number' },
      position: 'number',
      progress: GetUserOkrResponseBodyDataListKrListProgress,
      score: 'number',
      weight: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserOkrResponseBodyDataListOwner extends $tea.Model {
  /**
   * @example
   * @lADPDh0cQ_j4Mi_NBULNBUA
   */
  avatarMediaId?: Readable;
  /**
   * @example
   * ding4d1c8883ff63ee8124f2f5cc6abecb85
   */
  corpId?: Readable;
  /**
   * @example
   * K1AMgq
   */
  id?: Readable;
  /**
   * @example
   * 你好
   */
  nickname?: Readable;
  /**
   * @example
   * 06186238011033616
   */
  userId?: Readable;
  static names(): { [key: string]: string } {
    return {
      avatarMediaId: 'avatarMediaId',
      corpId: 'corpId',
      id: 'id',
      nickname: 'nickname',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatarMediaId: 'Readable',
      corpId: 'Readable',
      id: 'Readable',
      nickname: 'Readable',
      userId: 'Readable',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserOkrResponseBodyDataListProgress extends $tea.Model {
  /**
   * @example
   * 100
   */
  percent?: number;
  static names(): { [key: string]: string } {
    return {
      percent: 'percent',
    };
  }

  static types(): { [key: string]: any } {
    return {
      percent: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserOkrResponseBodyDataList extends $tea.Model {
  alignFromIds?: Readable[];
  alignToIds?: Readable[];
  /**
   * @example
   * Objective demo
   */
  content?: Readable;
  /**
   * @example
   * 1648625407694
   */
  gmtCreate?: number;
  /**
   * @example
   * 1648625407694
   */
  gmtModified?: number;
  /**
   * @example
   * 5dAX8
   */
  id?: Readable;
  krList?: GetUserOkrResponseBodyDataListKrList[];
  owner?: GetUserOkrResponseBodyDataListOwner;
  /**
   * @example
   * 1006
   */
  periodId?: Readable;
  permission?: number[];
  /**
   * @example
   * 3021332
   */
  position?: number;
  progress?: GetUserOkrResponseBodyDataListProgress;
  /**
   * @example
   * 100
   */
  progressPercent?: number;
  /**
   * @example
   * true
   */
  published?: boolean;
  /**
   * @example
   * 20
   */
  score?: number;
  /**
   * @example
   * 0
   */
  status?: number;
  /**
   * @example
   * s34d
   */
  userId?: Readable;
  /**
   * @example
   * 50
   */
  weight?: number;
  static names(): { [key: string]: string } {
    return {
      alignFromIds: 'alignFromIds',
      alignToIds: 'alignToIds',
      content: 'content',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      id: 'id',
      krList: 'krList',
      owner: 'owner',
      periodId: 'periodId',
      permission: 'permission',
      position: 'position',
      progress: 'progress',
      progressPercent: 'progressPercent',
      published: 'published',
      score: 'score',
      status: 'status',
      userId: 'userId',
      weight: 'weight',
    };
  }

  static types(): { [key: string]: any } {
    return {
      alignFromIds: { 'type': 'array', 'itemType': 'Readable' },
      alignToIds: { 'type': 'array', 'itemType': 'Readable' },
      content: 'Readable',
      gmtCreate: 'number',
      gmtModified: 'number',
      id: 'Readable',
      krList: { 'type': 'array', 'itemType': GetUserOkrResponseBodyDataListKrList },
      owner: GetUserOkrResponseBodyDataListOwner,
      periodId: 'Readable',
      permission: { 'type': 'array', 'itemType': 'number' },
      position: 'number',
      progress: GetUserOkrResponseBodyDataListProgress,
      progressPercent: 'number',
      published: 'boolean',
      score: 'number',
      status: 'number',
      userId: 'Readable',
      weight: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserOkrResponseBodyData extends $tea.Model {
  list?: GetUserOkrResponseBodyDataList[];
  /**
   * @example
   * 2
   */
  pageNumber?: number;
  /**
   * @example
   * 50
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      list: 'list',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': GetUserOkrResponseBodyDataList },
      pageNumber: 'number',
      pageSize: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OkrObjectivesByUserResponseBodyContent extends $tea.Model {
  result?: OpenObjectiveDTO[];
  /**
   * @example
   * 15
   */
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': OpenObjectiveDTO },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OkrPeriodsResponseBodyContent extends $tea.Model {
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  result?: OpenPeriodDTO[];
  /**
   * @example
   * 15
   */
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      result: 'result',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      result: { 'type': 'array', 'itemType': OpenPeriodDTO },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnAlignObjectiveResponseBodyData extends $tea.Model {
  /**
   * @example
   * 59YD
   */
  alignId?: Readable;
  /**
   * @example
   * 5dAX8
   */
  id?: Readable;
  static names(): { [key: string]: string } {
    return {
      alignId: 'alignId',
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      alignId: 'Readable',
      id: 'Readable',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateKROfScoreResponseBodyData extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 50
   */
  objectiveScore?: number;
  static names(): { [key: string]: string } {
    return {
      objectiveScore: 'objectiveScore',
    };
  }

  static types(): { [key: string]: any } {
    return {
      objectiveScore: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateKROfWeightResponseBodyDataObjectiveProgress extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  percent?: number;
  static names(): { [key: string]: string } {
    return {
      percent: 'percent',
    };
  }

  static types(): { [key: string]: any } {
    return {
      percent: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateKROfWeightResponseBodyData extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  objectiveProgress?: UpdateKROfWeightResponseBodyDataObjectiveProgress;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  objectiveScore?: number;
  static names(): { [key: string]: string } {
    return {
      objectiveProgress: 'objectiveProgress',
      objectiveScore: 'objectiveScore',
    };
  }

  static types(): { [key: string]: any } {
    return {
      objectiveProgress: UpdateKROfWeightResponseBodyDataObjectiveProgress,
      objectiveScore: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateObjectiveResponseBodyData extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 58YD
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 33453
   */
  position?: number;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      position: 'position',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      position: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdatePrivacyResponseBodyDataPolicyListMemberList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  id?: string;
  nickname?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      nickname: 'nickname',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      nickname: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdatePrivacyResponseBodyDataPolicyList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  memberList?: UpdatePrivacyResponseBodyDataPolicyListMemberList[];
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  type?: number;
  static names(): { [key: string]: string } {
    return {
      memberList: 'memberList',
      name: 'name',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberList: { 'type': 'array', 'itemType': UpdatePrivacyResponseBodyDataPolicyListMemberList },
      name: 'string',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdatePrivacyResponseBodyData extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  policyList?: UpdatePrivacyResponseBodyDataPolicyList[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * public
   */
  privacy?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * period
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      policyList: 'policyList',
      privacy: 'privacy',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      policyList: { 'type': 'array', 'itemType': UpdatePrivacyResponseBodyDataPolicyList },
      privacy: 'string',
      type: 'string',
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
   * 增加对齐目标
   * 
   * @param request - AlignObjectiveRequest
   * @param headers - AlignObjectiveHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AlignObjectiveResponse
   */
  async alignObjectiveWithOptions(objectiveId: string, request: AlignObjectiveRequest, headers: AlignObjectiveHeaders, runtime: $Util.RuntimeOptions): Promise<AlignObjectiveResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.periodId)) {
      body["periodId"] = request.periodId;
    }

    if (!Util.isUnset(request.targetId)) {
      body["targetId"] = request.targetId;
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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "AlignObjective",
      version: "okr_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/okr/objectives/${objectiveId}/alignments`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AlignObjectiveResponse>(await this.execute(params, req, runtime), new AlignObjectiveResponse({}));
  }

  /**
   * 增加对齐目标
   * 
   * @param request - AlignObjectiveRequest
   * @returns AlignObjectiveResponse
   */
  async alignObjective(objectiveId: string, request: AlignObjectiveRequest): Promise<AlignObjectiveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AlignObjectiveHeaders({ });
    return await this.alignObjectiveWithOptions(objectiveId, request, headers, runtime);
  }

  /**
   * 批量添加权限信息
   * 
   * @param request - BatchAddPermissionRequest
   * @param headers - BatchAddPermissionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchAddPermissionResponse
   */
  async batchAddPermissionWithOptions(request: BatchAddPermissionRequest, headers: BatchAddPermissionHeaders, runtime: $Util.RuntimeOptions): Promise<BatchAddPermissionResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.list)) {
      body["list"] = request.list;
    }

    if (!Util.isUnset(request.targetId)) {
      body["targetId"] = request.targetId;
    }

    if (!Util.isUnset(request.targetType)) {
      body["targetType"] = request.targetType;
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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "BatchAddPermission",
      version: "okr_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/okr/permissions/batch`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchAddPermissionResponse>(await this.execute(params, req, runtime), new BatchAddPermissionResponse({}));
  }

  /**
   * 批量添加权限信息
   * 
   * @param request - BatchAddPermissionRequest
   * @returns BatchAddPermissionResponse
   */
  async batchAddPermission(request: BatchAddPermissionRequest): Promise<BatchAddPermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchAddPermissionHeaders({ });
    return await this.batchAddPermissionWithOptions(request, headers, runtime);
  }

  /**
   * 批量查询目标
   * 
   * @param request - BatchQueryObjectiveRequest
   * @param headers - BatchQueryObjectiveHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchQueryObjectiveResponse
   */
  async batchQueryObjectiveWithOptions(request: BatchQueryObjectiveRequest, headers: BatchQueryObjectiveHeaders, runtime: $Util.RuntimeOptions): Promise<BatchQueryObjectiveResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.objectiveIds)) {
      body["objectiveIds"] = request.objectiveIds;
    }

    if (!Util.isUnset(request.periodId)) {
      body["periodId"] = request.periodId;
    }

    if (!Util.isUnset(request.withAlign)) {
      body["withAlign"] = request.withAlign;
    }

    if (!Util.isUnset(request.withKr)) {
      body["withKr"] = request.withKr;
    }

    if (!Util.isUnset(request.withProgress)) {
      body["withProgress"] = request.withProgress;
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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "BatchQueryObjective",
      version: "okr_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/okr/objectives/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchQueryObjectiveResponse>(await this.execute(params, req, runtime), new BatchQueryObjectiveResponse({}));
  }

  /**
   * 批量查询目标
   * 
   * @param request - BatchQueryObjectiveRequest
   * @returns BatchQueryObjectiveResponse
   */
  async batchQueryObjective(request: BatchQueryObjectiveRequest): Promise<BatchQueryObjectiveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchQueryObjectiveHeaders({ });
    return await this.batchQueryObjectiveWithOptions(request, headers, runtime);
  }

  /**
   * 批量查询用户信息
   * 
   * @param request - BatchQueryUserRequest
   * @param headers - BatchQueryUserHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchQueryUserResponse
   */
  async batchQueryUserWithOptions(request: BatchQueryUserRequest, headers: BatchQueryUserHeaders, runtime: $Util.RuntimeOptions): Promise<BatchQueryUserResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.okrUserIds)) {
      body["okrUserIds"] = request.okrUserIds;
    }

    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
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
      action: "BatchQueryUser",
      version: "okr_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/okr/users/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchQueryUserResponse>(await this.execute(params, req, runtime), new BatchQueryUserResponse({}));
  }

  /**
   * 批量查询用户信息
   * 
   * @param request - BatchQueryUserRequest
   * @returns BatchQueryUserResponse
   */
  async batchQueryUser(request: BatchQueryUserRequest): Promise<BatchQueryUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchQueryUserHeaders({ });
    return await this.batchQueryUserWithOptions(request, headers, runtime);
  }

  /**
   * 创建keyResult
   * 
   * @param request - CreateKeyResultRequest
   * @param headers - CreateKeyResultHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateKeyResultResponse
   */
  async createKeyResultWithOptions(request: CreateKeyResultRequest, headers: CreateKeyResultHeaders, runtime: $Util.RuntimeOptions): Promise<CreateKeyResultResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.objectiveId)) {
      body["objectiveId"] = request.objectiveId;
    }

    if (!Util.isUnset(request.periodId)) {
      body["periodId"] = request.periodId;
    }

    if (!Util.isUnset(request.prevPosition)) {
      body["prevPosition"] = request.prevPosition;
    }

    if (!Util.isUnset(request.weight)) {
      body["weight"] = request.weight;
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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CreateKeyResult",
      version: "okr_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/okr/keyResults`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateKeyResultResponse>(await this.execute(params, req, runtime), new CreateKeyResultResponse({}));
  }

  /**
   * 创建keyResult
   * 
   * @param request - CreateKeyResultRequest
   * @returns CreateKeyResultResponse
   */
  async createKeyResult(request: CreateKeyResultRequest): Promise<CreateKeyResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateKeyResultHeaders({ });
    return await this.createKeyResultWithOptions(request, headers, runtime);
  }

  /**
   * 创建目标
   * 
   * @param request - CreateObjectiveRequest
   * @param headers - CreateObjectiveHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateObjectiveResponse
   */
  async createObjectiveWithOptions(request: CreateObjectiveRequest, headers: CreateObjectiveHeaders, runtime: $Util.RuntimeOptions): Promise<CreateObjectiveResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.periodId)) {
      body["periodId"] = request.periodId;
    }

    if (!Util.isUnset(request.prevPosition)) {
      body["prevPosition"] = request.prevPosition;
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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CreateObjective",
      version: "okr_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/okr/objectives`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateObjectiveResponse>(await this.execute(params, req, runtime), new CreateObjectiveResponse({}));
  }

  /**
   * 创建目标
   * 
   * @param request - CreateObjectiveRequest
   * @returns CreateObjectiveResponse
   */
  async createObjective(request: CreateObjectiveRequest): Promise<CreateObjectiveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateObjectiveHeaders({ });
    return await this.createObjectiveWithOptions(request, headers, runtime);
  }

  /**
   * 删除keyresult的方法
   * 
   * @param request - DeleteKeyResultRequest
   * @param headers - DeleteKeyResultHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteKeyResultResponse
   */
  async deleteKeyResultWithOptions(request: DeleteKeyResultRequest, headers: DeleteKeyResultHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteKeyResultResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.krId)) {
      query["krId"] = request.krId;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
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
      action: "DeleteKeyResult",
      version: "okr_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/okr/keyResults`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteKeyResultResponse>(await this.execute(params, req, runtime), new DeleteKeyResultResponse({}));
  }

  /**
   * 删除keyresult的方法
   * 
   * @param request - DeleteKeyResultRequest
   * @returns DeleteKeyResultResponse
   */
  async deleteKeyResult(request: DeleteKeyResultRequest): Promise<DeleteKeyResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteKeyResultHeaders({ });
    return await this.deleteKeyResultWithOptions(request, headers, runtime);
  }

  /**
   * 删除目标
   * 
   * @param request - DeleteObjectiveRequest
   * @param headers - DeleteObjectiveHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteObjectiveResponse
   */
  async deleteObjectiveWithOptions(objectiveId: string, request: DeleteObjectiveRequest, headers: DeleteObjectiveHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteObjectiveResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
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
      action: "DeleteObjective",
      version: "okr_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/okr/objectives/${objectiveId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteObjectiveResponse>(await this.execute(params, req, runtime), new DeleteObjectiveResponse({}));
  }

  /**
   * 删除目标
   * 
   * @param request - DeleteObjectiveRequest
   * @returns DeleteObjectiveResponse
   */
  async deleteObjective(objectiveId: string, request: DeleteObjectiveRequest): Promise<DeleteObjectiveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteObjectiveHeaders({ });
    return await this.deleteObjectiveWithOptions(objectiveId, request, headers, runtime);
  }

  /**
   * 删除权限信息
   * 
   * @param request - DeletePermissionRequest
   * @param headers - DeletePermissionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeletePermissionResponse
   */
  async deletePermissionWithOptions(request: DeletePermissionRequest, headers: DeletePermissionHeaders, runtime: $Util.RuntimeOptions): Promise<DeletePermissionResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.id)) {
      query["id"] = request.id;
    }

    if (!Util.isUnset(request.policyType)) {
      query["policyType"] = request.policyType;
    }

    if (!Util.isUnset(request.targetId)) {
      query["targetId"] = request.targetId;
    }

    if (!Util.isUnset(request.targetType)) {
      query["targetType"] = request.targetType;
    }

    if (!Util.isUnset(request.type)) {
      query["type"] = request.type;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
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
      action: "DeletePermission",
      version: "okr_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/okr/permissions/delete`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeletePermissionResponse>(await this.execute(params, req, runtime), new DeletePermissionResponse({}));
  }

  /**
   * 删除权限信息
   * 
   * @param request - DeletePermissionRequest
   * @returns DeletePermissionResponse
   */
  async deletePermission(request: DeletePermissionRequest): Promise<DeletePermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeletePermissionHeaders({ });
    return await this.deletePermissionWithOptions(request, headers, runtime);
  }

  /**
   * 获取周期列表
   * 
   * @param headers - GetPeriodListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetPeriodListResponse
   */
  async getPeriodListWithOptions(headers: GetPeriodListHeaders, runtime: $Util.RuntimeOptions): Promise<GetPeriodListResponse> {
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
      action: "GetPeriodList",
      version: "okr_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/okr/periods`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetPeriodListResponse>(await this.execute(params, req, runtime), new GetPeriodListResponse({}));
  }

  /**
   * 获取周期列表
   * @returns GetPeriodListResponse
   */
  async getPeriodList(): Promise<GetPeriodListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPeriodListHeaders({ });
    return await this.getPeriodListWithOptions(headers, runtime);
  }

  /**
   * 获取权限信息
   * 
   * @param request - GetPermissionRequest
   * @param headers - GetPermissionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetPermissionResponse
   */
  async getPermissionWithOptions(request: GetPermissionRequest, headers: GetPermissionHeaders, runtime: $Util.RuntimeOptions): Promise<GetPermissionResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.targetId)) {
      query["targetId"] = request.targetId;
    }

    if (!Util.isUnset(request.targetType)) {
      query["targetType"] = request.targetType;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.withKr)) {
      query["withKr"] = request.withKr;
    }

    if (!Util.isUnset(request.withObjective)) {
      query["withObjective"] = request.withObjective;
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
      action: "GetPermission",
      version: "okr_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/okr/permissions`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetPermissionResponse>(await this.execute(params, req, runtime), new GetPermissionResponse({}));
  }

  /**
   * 获取权限信息
   * 
   * @param request - GetPermissionRequest
   * @returns GetPermissionResponse
   */
  async getPermission(request: GetPermissionRequest): Promise<GetPermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPermissionHeaders({ });
    return await this.getPermissionWithOptions(request, headers, runtime);
  }

  /**
   * 获取用户当前周期下的全部 OKR 内容
   * 
   * @param request - GetUserOkrRequest
   * @param headers - GetUserOkrHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetUserOkrResponse
   */
  async getUserOkrWithOptions(request: GetUserOkrRequest, headers: GetUserOkrHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserOkrResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.periodId)) {
      query["periodId"] = request.periodId;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
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
      action: "GetUserOkr",
      version: "okr_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/okr/users/okrs`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetUserOkrResponse>(await this.execute(params, req, runtime), new GetUserOkrResponse({}));
  }

  /**
   * 获取用户当前周期下的全部 OKR 内容
   * 
   * @param request - GetUserOkrRequest
   * @returns GetUserOkrResponse
   */
  async getUserOkr(request: GetUserOkrRequest): Promise<GetUserOkrResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserOkrHeaders({ });
    return await this.getUserOkrWithOptions(request, headers, runtime);
  }

  /**
   * 批量查询OKR
   * 
   * @param request - OkrObjectivesBatchRequest
   * @param headers - OkrObjectivesBatchHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns OkrObjectivesBatchResponse
   */
  async okrObjectivesBatchWithOptions(request: OkrObjectivesBatchRequest, headers: OkrObjectivesBatchHeaders, runtime: $Util.RuntimeOptions): Promise<OkrObjectivesBatchResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.goodsCode)) {
      body["goodsCode"] = request.goodsCode;
    }

    if (!Util.isUnset(request.objectiveIds)) {
      body["objectiveIds"] = request.objectiveIds;
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
      action: "OkrObjectivesBatch",
      version: "okr_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/okr/pro/objectives/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<OkrObjectivesBatchResponse>(await this.execute(params, req, runtime), new OkrObjectivesBatchResponse({}));
  }

  /**
   * 批量查询OKR
   * 
   * @param request - OkrObjectivesBatchRequest
   * @returns OkrObjectivesBatchResponse
   */
  async okrObjectivesBatch(request: OkrObjectivesBatchRequest): Promise<OkrObjectivesBatchResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new OkrObjectivesBatchHeaders({ });
    return await this.okrObjectivesBatchWithOptions(request, headers, runtime);
  }

  /**
   * 查询单个用户的OKR
   * 
   * @param request - OkrObjectivesByUserRequest
   * @param headers - OkrObjectivesByUserHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns OkrObjectivesByUserResponse
   */
  async okrObjectivesByUserWithOptions(dingUserId: string, request: OkrObjectivesByUserRequest, headers: OkrObjectivesByUserHeaders, runtime: $Util.RuntimeOptions): Promise<OkrObjectivesByUserResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.goodsCode)) {
      query["goodsCode"] = request.goodsCode;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
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
      action: "OkrObjectivesByUser",
      version: "okr_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/okr/pro/users/${dingUserId}/objectives`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<OkrObjectivesByUserResponse>(await this.execute(params, req, runtime), new OkrObjectivesByUserResponse({}));
  }

  /**
   * 查询单个用户的OKR
   * 
   * @param request - OkrObjectivesByUserRequest
   * @returns OkrObjectivesByUserResponse
   */
  async okrObjectivesByUser(dingUserId: string, request: OkrObjectivesByUserRequest): Promise<OkrObjectivesByUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new OkrObjectivesByUserHeaders({ });
    return await this.okrObjectivesByUserWithOptions(dingUserId, request, headers, runtime);
  }

  /**
   * 获取 OKR 周期
   * 
   * @param request - OkrPeriodsRequest
   * @param headers - OkrPeriodsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns OkrPeriodsResponse
   */
  async okrPeriodsWithOptions(request: OkrPeriodsRequest, headers: OkrPeriodsHeaders, runtime: $Util.RuntimeOptions): Promise<OkrPeriodsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.goodsCode)) {
      query["goodsCode"] = request.goodsCode;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.status)) {
      query["status"] = request.status;
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
      action: "OkrPeriods",
      version: "okr_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/okr/pro/periods`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<OkrPeriodsResponse>(await this.execute(params, req, runtime), new OkrPeriodsResponse({}));
  }

  /**
   * 获取 OKR 周期
   * 
   * @param request - OkrPeriodsRequest
   * @returns OkrPeriodsResponse
   */
  async okrPeriods(request: OkrPeriodsRequest): Promise<OkrPeriodsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new OkrPeriodsHeaders({ });
    return await this.okrPeriodsWithOptions(request, headers, runtime);
  }

  /**
   * 取消对齐Objective
   * 
   * @param request - UnAlignObjectiveRequest
   * @param headers - UnAlignObjectiveHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UnAlignObjectiveResponse
   */
  async unAlignObjectiveWithOptions(objectiveId: string, request: UnAlignObjectiveRequest, headers: UnAlignObjectiveHeaders, runtime: $Util.RuntimeOptions): Promise<UnAlignObjectiveResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.periodId)) {
      body["periodId"] = request.periodId;
    }

    if (!Util.isUnset(request.targetId)) {
      body["targetId"] = request.targetId;
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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "UnAlignObjective",
      version: "okr_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/okr/objectives/${objectiveId}/alignments/cancel`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UnAlignObjectiveResponse>(await this.execute(params, req, runtime), new UnAlignObjectiveResponse({}));
  }

  /**
   * 取消对齐Objective
   * 
   * @param request - UnAlignObjectiveRequest
   * @returns UnAlignObjectiveResponse
   */
  async unAlignObjective(objectiveId: string, request: UnAlignObjectiveRequest): Promise<UnAlignObjectiveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UnAlignObjectiveHeaders({ });
    return await this.unAlignObjectiveWithOptions(objectiveId, request, headers, runtime);
  }

  /**
   * 更改KR内容
   * 
   * @param request - UpdateKROfContentRequest
   * @param headers - UpdateKROfContentHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateKROfContentResponse
   */
  async updateKROfContentWithOptions(request: UpdateKROfContentRequest, headers: UpdateKROfContentHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateKROfContentResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.krId)) {
      query["krId"] = request.krId;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.updateQuoteList)) {
      body["updateQuoteList"] = request.updateQuoteList;
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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "UpdateKROfContent",
      version: "okr_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/okr/keyResults/contents`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateKROfContentResponse>(await this.execute(params, req, runtime), new UpdateKROfContentResponse({}));
  }

  /**
   * 更改KR内容
   * 
   * @param request - UpdateKROfContentRequest
   * @returns UpdateKROfContentResponse
   */
  async updateKROfContent(request: UpdateKROfContentRequest): Promise<UpdateKROfContentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateKROfContentHeaders({ });
    return await this.updateKROfContentWithOptions(request, headers, runtime);
  }

  /**
   * 更改KR分数
   * 
   * @param request - UpdateKROfScoreRequest
   * @param headers - UpdateKROfScoreHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateKROfScoreResponse
   */
  async updateKROfScoreWithOptions(request: UpdateKROfScoreRequest, headers: UpdateKROfScoreHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateKROfScoreResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.krId)) {
      query["krId"] = request.krId;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.score)) {
      body["score"] = request.score;
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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "UpdateKROfScore",
      version: "okr_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/okr/keyResults/scores`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateKROfScoreResponse>(await this.execute(params, req, runtime), new UpdateKROfScoreResponse({}));
  }

  /**
   * 更改KR分数
   * 
   * @param request - UpdateKROfScoreRequest
   * @returns UpdateKROfScoreResponse
   */
  async updateKROfScore(request: UpdateKROfScoreRequest): Promise<UpdateKROfScoreResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateKROfScoreHeaders({ });
    return await this.updateKROfScoreWithOptions(request, headers, runtime);
  }

  /**
   * 更改 KR 权重
   * 
   * @param request - UpdateKROfWeightRequest
   * @param headers - UpdateKROfWeightHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateKROfWeightResponse
   */
  async updateKROfWeightWithOptions(request: UpdateKROfWeightRequest, headers: UpdateKROfWeightHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateKROfWeightResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.krId)) {
      query["krId"] = request.krId;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.weight)) {
      body["weight"] = request.weight;
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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "UpdateKROfWeight",
      version: "okr_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/okr/keyResults/weights`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateKROfWeightResponse>(await this.execute(params, req, runtime), new UpdateKROfWeightResponse({}));
  }

  /**
   * 更改 KR 权重
   * 
   * @param request - UpdateKROfWeightRequest
   * @returns UpdateKROfWeightResponse
   */
  async updateKROfWeight(request: UpdateKROfWeightRequest): Promise<UpdateKROfWeightResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateKROfWeightHeaders({ });
    return await this.updateKROfWeightWithOptions(request, headers, runtime);
  }

  /**
   * 更新目标
   * 
   * @param request - UpdateObjectiveRequest
   * @param headers - UpdateObjectiveHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateObjectiveResponse
   */
  async updateObjectiveWithOptions(objectiveId: string, request: UpdateObjectiveRequest, headers: UpdateObjectiveHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateObjectiveResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "UpdateObjective",
      version: "okr_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/okr/objectives/${objectiveId}`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateObjectiveResponse>(await this.execute(params, req, runtime), new UpdateObjectiveResponse({}));
  }

  /**
   * 更新目标
   * 
   * @param request - UpdateObjectiveRequest
   * @returns UpdateObjectiveResponse
   */
  async updateObjective(objectiveId: string, request: UpdateObjectiveRequest): Promise<UpdateObjectiveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateObjectiveHeaders({ });
    return await this.updateObjectiveWithOptions(objectiveId, request, headers, runtime);
  }

  /**
   * 更新资源隐私策略
   * 
   * @param request - UpdatePrivacyRequest
   * @param headers - UpdatePrivacyHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdatePrivacyResponse
   */
  async updatePrivacyWithOptions(request: UpdatePrivacyRequest, headers: UpdatePrivacyHeaders, runtime: $Util.RuntimeOptions): Promise<UpdatePrivacyResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.privacy)) {
      body["privacy"] = request.privacy;
    }

    if (!Util.isUnset(request.targetId)) {
      body["targetId"] = request.targetId;
    }

    if (!Util.isUnset(request.targetType)) {
      body["targetType"] = request.targetType;
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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "UpdatePrivacy",
      version: "okr_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/okr/permissions/privacies`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdatePrivacyResponse>(await this.execute(params, req, runtime), new UpdatePrivacyResponse({}));
  }

  /**
   * 更新资源隐私策略
   * 
   * @param request - UpdatePrivacyRequest
   * @returns UpdatePrivacyResponse
   */
  async updatePrivacy(request: UpdatePrivacyRequest): Promise<UpdatePrivacyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdatePrivacyHeaders({ });
    return await this.updatePrivacyWithOptions(request, headers, runtime);
  }

}
