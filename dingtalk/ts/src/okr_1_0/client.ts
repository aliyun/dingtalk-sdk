// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import { Readable } from 'stream';
import * as $tea from '@alicloud/tea-typescript';

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
  periodId?: string;
  targetId?: string;
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
  headers: { [key: string]: string };
  body: AlignObjectiveResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  list?: BatchAddPermissionRequestList[];
  targetId?: string;
  targetType?: string;
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
  data?: BatchAddPermissionResponseBodyData;
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
  headers: { [key: string]: string };
  body: BatchAddPermissionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  objectiveIds?: string[];
  periodId?: string;
  withAlign?: boolean;
  withKr?: boolean;
  withProgress?: boolean;
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
  headers: { [key: string]: string };
  body: BatchQueryObjectiveResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  data?: BatchQueryUserResponseBodyData[];
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
  headers: { [key: string]: string };
  body: BatchQueryUserResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  content?: string;
  objectiveId?: string;
  periodId?: string;
  prevPosition?: number;
  weight?: number;
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
  data?: CreateKeyResultResponseBodyData;
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
  headers: { [key: string]: string };
  body: CreateKeyResultResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  content?: string;
  periodId?: string;
  prevPosition?: string;
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
  headers: { [key: string]: string };
  body: CreateObjectiveResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  krId?: string;
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
  data?: boolean;
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
  headers: { [key: string]: string };
  body: DeleteKeyResultResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  headers: { [key: string]: string };
  body: DeleteObjectiveResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  id?: string;
  policyType?: number;
  targetId?: string;
  targetType?: string;
  type?: string;
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
  data?: DeletePermissionResponseBodyData;
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
  headers: { [key: string]: string };
  body: DeletePermissionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  headers: { [key: string]: string };
  body: GetPeriodListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  targetId?: string;
  targetType?: string;
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
  data?: GetPermissionResponseBodyData;
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
  headers: { [key: string]: string };
  body: GetPermissionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  pageNumber?: number;
  pageSize?: number;
  periodId?: string;
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
  headers: { [key: string]: string };
  body: GetUserOkrResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetUserOkrResponseBody,
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
  periodId?: string;
  targetId?: string;
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
  headers: { [key: string]: string };
  body: UnAlignObjectiveResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  content?: string;
  updateQuoteList?: string[];
  krId?: string;
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
  data?: boolean;
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
  headers: { [key: string]: string };
  body: UpdateKROfContentResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  score?: number;
  krId?: string;
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
  data?: UpdateKROfScoreResponseBodyData;
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
  headers: { [key: string]: string };
  body: UpdateKROfScoreResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  weight?: number;
  krId?: string;
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
  data?: UpdateKROfWeightResponseBodyData;
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
  headers: { [key: string]: string };
  body: UpdateKROfWeightResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  content?: string;
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
  headers: { [key: string]: string };
  body: UpdateObjectiveResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  privacy?: string;
  targetId?: string;
  targetType?: string;
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
  data?: UpdatePrivacyResponseBodyData;
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
  headers: { [key: string]: string };
  body: UpdatePrivacyResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdatePrivacyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AlignObjectiveResponseBodyData extends $tea.Model {
  alignId?: Readable;
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
  id?: string;
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
  member?: BatchAddPermissionRequestListMember;
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
  id?: string;
  nickname?: string;
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
  memberList?: BatchAddPermissionResponseBodyDataPermissionTreePolicyListMemberList[];
  name?: string;
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
  id?: string;
  policyList?: BatchAddPermissionResponseBodyDataPermissionTreePolicyList[];
  privacy?: string;
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
  hasInvalidUser?: boolean;
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
  content?: Readable;
  gmtCreate?: number;
  gmtModified?: number;
  id?: Readable;
  objectiveId?: Readable;
  permission?: number[];
  position?: number;
  progress?: BatchQueryObjectiveResponseBodyDataKrListProgress;
  score?: number;
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
  avatarMediaId?: Readable;
  corpId?: Readable;
  id?: Readable;
  nickname?: Readable;
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
  content?: Readable;
  gmtCreate?: number;
  gmtModified?: number;
  id?: Readable;
  krList?: BatchQueryObjectiveResponseBodyDataKrList[];
  owner?: BatchQueryObjectiveResponseBodyDataOwner;
  periodId?: Readable;
  permission?: number[];
  position?: number;
  progress?: BatchQueryObjectiveResponseBodyDataProgress;
  progressPercent?: number;
  published?: boolean;
  score?: number;
  status?: number;
  userId?: Readable;
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
  avatarMediaId?: Readable;
  avatarUrl?: Readable;
  corpId?: Readable;
  id?: Readable;
  nickname?: Readable;
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
  id?: Readable;
  position?: number;
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
  id?: string;
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
  id?: string;
  nickname?: string;
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
  memberList?: DeletePermissionResponseBodyDataPolicyListMemberList[];
  name?: string;
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
  id?: string;
  policyList?: DeletePermissionResponseBodyDataPolicyList[];
  privacy?: string;
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
  endTime?: number;
  id?: Readable;
  isCurrent?: boolean;
  isYearly?: boolean;
  name?: Readable;
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
  id?: string;
  nickname?: string;
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
  memberList?: GetPermissionResponseBodyDataPolicyListMemberList[];
  name?: string;
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
  id?: string;
  policyList?: GetPermissionResponseBodyDataPolicyList[];
  privacy?: string;
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
  content?: Readable;
  gmtCreate?: number;
  gmtModified?: number;
  id?: Readable;
  objectiveId?: Readable;
  permission?: number[];
  position?: number;
  progress?: GetUserOkrResponseBodyDataListKrListProgress;
  score?: number;
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
  avatarMediaId?: Readable;
  corpId?: Readable;
  id?: Readable;
  nickname?: Readable;
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
  content?: Readable;
  gmtCreate?: number;
  gmtModified?: number;
  id?: Readable;
  krList?: GetUserOkrResponseBodyDataListKrList[];
  owner?: GetUserOkrResponseBodyDataListOwner;
  periodId?: Readable;
  permission?: number[];
  position?: number;
  progress?: GetUserOkrResponseBodyDataListProgress;
  progressPercent?: number;
  published?: boolean;
  score?: number;
  status?: number;
  userId?: Readable;
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
  pageNumber?: number;
  pageSize?: number;
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

export class UnAlignObjectiveResponseBodyData extends $tea.Model {
  alignId?: Readable;
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
  objectiveProgress?: UpdateKROfWeightResponseBodyDataObjectiveProgress;
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
  id?: string;
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
  id?: string;
  nickname?: string;
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
  memberList?: UpdatePrivacyResponseBodyDataPolicyListMemberList[];
  name?: string;
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
  id?: string;
  policyList?: UpdatePrivacyResponseBodyDataPolicyList[];
  privacy?: string;
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
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async alignObjective(objectiveId: string, request: AlignObjectiveRequest): Promise<AlignObjectiveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AlignObjectiveHeaders({ });
    return await this.alignObjectiveWithOptions(objectiveId, request, headers, runtime);
  }

  async alignObjectiveWithOptions(objectiveId: string, request: AlignObjectiveRequest, headers: AlignObjectiveHeaders, runtime: $Util.RuntimeOptions): Promise<AlignObjectiveResponse> {
    Util.validateModel(request);
    objectiveId = OpenApiUtil.getEncodeParam(objectiveId);
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
    return $tea.cast<AlignObjectiveResponse>(await this.doROARequest("AlignObjective", "okr_1.0", "HTTP", "POST", "AK", `/v1.0/okr/objectives/${objectiveId}/alignments`, "json", req, runtime), new AlignObjectiveResponse({}));
  }

  async batchAddPermission(request: BatchAddPermissionRequest): Promise<BatchAddPermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchAddPermissionHeaders({ });
    return await this.batchAddPermissionWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<BatchAddPermissionResponse>(await this.doROARequest("BatchAddPermission", "okr_1.0", "HTTP", "POST", "AK", `/v1.0/okr/permissions/batch`, "json", req, runtime), new BatchAddPermissionResponse({}));
  }

  async batchQueryObjective(request: BatchQueryObjectiveRequest): Promise<BatchQueryObjectiveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchQueryObjectiveHeaders({ });
    return await this.batchQueryObjectiveWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<BatchQueryObjectiveResponse>(await this.doROARequest("BatchQueryObjective", "okr_1.0", "HTTP", "POST", "AK", `/v1.0/okr/objectives/query`, "json", req, runtime), new BatchQueryObjectiveResponse({}));
  }

  async batchQueryUser(request: BatchQueryUserRequest): Promise<BatchQueryUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchQueryUserHeaders({ });
    return await this.batchQueryUserWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<BatchQueryUserResponse>(await this.doROARequest("BatchQueryUser", "okr_1.0", "HTTP", "POST", "AK", `/v1.0/okr/users/query`, "json", req, runtime), new BatchQueryUserResponse({}));
  }

  async createKeyResult(request: CreateKeyResultRequest): Promise<CreateKeyResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateKeyResultHeaders({ });
    return await this.createKeyResultWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<CreateKeyResultResponse>(await this.doROARequest("CreateKeyResult", "okr_1.0", "HTTP", "POST", "AK", `/v1.0/okr/keyResults`, "json", req, runtime), new CreateKeyResultResponse({}));
  }

  async createObjective(request: CreateObjectiveRequest): Promise<CreateObjectiveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateObjectiveHeaders({ });
    return await this.createObjectiveWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<CreateObjectiveResponse>(await this.doROARequest("CreateObjective", "okr_1.0", "HTTP", "POST", "AK", `/v1.0/okr/objectives`, "json", req, runtime), new CreateObjectiveResponse({}));
  }

  async deleteKeyResult(request: DeleteKeyResultRequest): Promise<DeleteKeyResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteKeyResultHeaders({ });
    return await this.deleteKeyResultWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<DeleteKeyResultResponse>(await this.doROARequest("DeleteKeyResult", "okr_1.0", "HTTP", "DELETE", "AK", `/v1.0/okr/keyResults`, "json", req, runtime), new DeleteKeyResultResponse({}));
  }

  async deleteObjective(objectiveId: string, request: DeleteObjectiveRequest): Promise<DeleteObjectiveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteObjectiveHeaders({ });
    return await this.deleteObjectiveWithOptions(objectiveId, request, headers, runtime);
  }

  async deleteObjectiveWithOptions(objectiveId: string, request: DeleteObjectiveRequest, headers: DeleteObjectiveHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteObjectiveResponse> {
    Util.validateModel(request);
    objectiveId = OpenApiUtil.getEncodeParam(objectiveId);
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
    return $tea.cast<DeleteObjectiveResponse>(await this.doROARequest("DeleteObjective", "okr_1.0", "HTTP", "DELETE", "AK", `/v1.0/okr/objectives/${objectiveId}`, "json", req, runtime), new DeleteObjectiveResponse({}));
  }

  async deletePermission(request: DeletePermissionRequest): Promise<DeletePermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeletePermissionHeaders({ });
    return await this.deletePermissionWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<DeletePermissionResponse>(await this.doROARequest("DeletePermission", "okr_1.0", "HTTP", "DELETE", "AK", `/v1.0/okr/permissions/delete`, "json", req, runtime), new DeletePermissionResponse({}));
  }

  async getPeriodList(): Promise<GetPeriodListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPeriodListHeaders({ });
    return await this.getPeriodListWithOptions(headers, runtime);
  }

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
    return $tea.cast<GetPeriodListResponse>(await this.doROARequest("GetPeriodList", "okr_1.0", "HTTP", "GET", "AK", `/v1.0/okr/periods`, "json", req, runtime), new GetPeriodListResponse({}));
  }

  async getPermission(request: GetPermissionRequest): Promise<GetPermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPermissionHeaders({ });
    return await this.getPermissionWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<GetPermissionResponse>(await this.doROARequest("GetPermission", "okr_1.0", "HTTP", "GET", "AK", `/v1.0/okr/permissions`, "json", req, runtime), new GetPermissionResponse({}));
  }

  async getUserOkr(request: GetUserOkrRequest): Promise<GetUserOkrResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserOkrHeaders({ });
    return await this.getUserOkrWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<GetUserOkrResponse>(await this.doROARequest("GetUserOkr", "okr_1.0", "HTTP", "GET", "AK", `/v1.0/okr/users/okrs`, "json", req, runtime), new GetUserOkrResponse({}));
  }

  async unAlignObjective(objectiveId: string, request: UnAlignObjectiveRequest): Promise<UnAlignObjectiveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UnAlignObjectiveHeaders({ });
    return await this.unAlignObjectiveWithOptions(objectiveId, request, headers, runtime);
  }

  async unAlignObjectiveWithOptions(objectiveId: string, request: UnAlignObjectiveRequest, headers: UnAlignObjectiveHeaders, runtime: $Util.RuntimeOptions): Promise<UnAlignObjectiveResponse> {
    Util.validateModel(request);
    objectiveId = OpenApiUtil.getEncodeParam(objectiveId);
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
    return $tea.cast<UnAlignObjectiveResponse>(await this.doROARequest("UnAlignObjective", "okr_1.0", "HTTP", "POST", "AK", `/v1.0/okr/objectives/${objectiveId}/alignments/cancel`, "json", req, runtime), new UnAlignObjectiveResponse({}));
  }

  async updateKROfContent(request: UpdateKROfContentRequest): Promise<UpdateKROfContentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateKROfContentHeaders({ });
    return await this.updateKROfContentWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<UpdateKROfContentResponse>(await this.doROARequest("UpdateKROfContent", "okr_1.0", "HTTP", "PUT", "AK", `/v1.0/okr/keyResults/contents`, "json", req, runtime), new UpdateKROfContentResponse({}));
  }

  async updateKROfScore(request: UpdateKROfScoreRequest): Promise<UpdateKROfScoreResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateKROfScoreHeaders({ });
    return await this.updateKROfScoreWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<UpdateKROfScoreResponse>(await this.doROARequest("UpdateKROfScore", "okr_1.0", "HTTP", "PUT", "AK", `/v1.0/okr/keyResults/scores`, "json", req, runtime), new UpdateKROfScoreResponse({}));
  }

  async updateKROfWeight(request: UpdateKROfWeightRequest): Promise<UpdateKROfWeightResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateKROfWeightHeaders({ });
    return await this.updateKROfWeightWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<UpdateKROfWeightResponse>(await this.doROARequest("UpdateKROfWeight", "okr_1.0", "HTTP", "PUT", "AK", `/v1.0/okr/keyResults/weights`, "json", req, runtime), new UpdateKROfWeightResponse({}));
  }

  async updateObjective(objectiveId: string, request: UpdateObjectiveRequest): Promise<UpdateObjectiveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateObjectiveHeaders({ });
    return await this.updateObjectiveWithOptions(objectiveId, request, headers, runtime);
  }

  async updateObjectiveWithOptions(objectiveId: string, request: UpdateObjectiveRequest, headers: UpdateObjectiveHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateObjectiveResponse> {
    Util.validateModel(request);
    objectiveId = OpenApiUtil.getEncodeParam(objectiveId);
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
    return $tea.cast<UpdateObjectiveResponse>(await this.doROARequest("UpdateObjective", "okr_1.0", "HTTP", "PUT", "AK", `/v1.0/okr/objectives/${objectiveId}`, "json", req, runtime), new UpdateObjectiveResponse({}));
  }

  async updatePrivacy(request: UpdatePrivacyRequest): Promise<UpdatePrivacyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdatePrivacyHeaders({ });
    return await this.updatePrivacyWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<UpdatePrivacyResponse>(await this.doROARequest("UpdatePrivacy", "okr_1.0", "HTTP", "PUT", "AK", `/v1.0/okr/permissions/privacies`, "json", req, runtime), new UpdatePrivacyResponse({}));
  }

}
