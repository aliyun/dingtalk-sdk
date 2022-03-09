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
  ownerId?: Readable;
  static names(): { [key: string]: string } {
    return {
      periodId: 'periodId',
      targetId: 'targetId',
      ownerId: 'ownerId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      periodId: 'string',
      targetId: 'string',
      ownerId: 'Readable',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AlignObjectiveResponseBody extends $tea.Model {
  code?: number;
  data?: AlignObjectiveResponseBodyData;
  message?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: AlignObjectiveResponseBodyData,
      message: 'string',
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
  objectiveIds?: Readable[];
  periodId?: Readable;
  withAlign?: boolean;
  withKr?: boolean;
  withProgress?: boolean;
  ownerId?: string;
  static names(): { [key: string]: string } {
    return {
      objectiveIds: 'objectiveIds',
      periodId: 'periodId',
      withAlign: 'withAlign',
      withKr: 'withKr',
      withProgress: 'withProgress',
      ownerId: 'ownerId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      objectiveIds: { 'type': 'array', 'itemType': 'Readable' },
      periodId: 'Readable',
      withAlign: 'boolean',
      withKr: 'boolean',
      withProgress: 'boolean',
      ownerId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryObjectiveResponseBody extends $tea.Model {
  code?: string;
  data?: BatchQueryObjectiveResponseBodyData[];
  message?: Readable;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      data: { 'type': 'array', 'itemType': BatchQueryObjectiveResponseBodyData },
      message: 'Readable',
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
  content?: Readable;
  objectiveId?: Readable;
  periodId?: Readable;
  prevPosition?: number;
  weight?: number;
  ownerId?: Readable;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      objectiveId: 'objectiveId',
      periodId: 'periodId',
      prevPosition: 'prevPosition',
      weight: 'weight',
      ownerId: 'ownerId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'Readable',
      objectiveId: 'Readable',
      periodId: 'Readable',
      prevPosition: 'number',
      weight: 'number',
      ownerId: 'Readable',
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
  content?: Readable;
  periodId?: Readable;
  prevPosition?: Readable;
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
      content: 'Readable',
      periodId: 'Readable',
      prevPosition: 'Readable',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateObjectiveResponseBody extends $tea.Model {
  code?: number;
  data?: CreateObjectiveResponseBodyData;
  message?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: CreateObjectiveResponseBodyData,
      message: 'string',
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
  krId?: Readable;
  ownerId?: Readable;
  static names(): { [key: string]: string } {
    return {
      krId: 'krId',
      ownerId: 'ownerId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      krId: 'Readable',
      ownerId: 'Readable',
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
  code?: number;
  data?: DeleteObjectiveResponseBodyData;
  message?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: DeleteObjectiveResponseBodyData,
      message: 'string',
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
  ownerId?: Readable;
  pageNumber?: number;
  pageSize?: number;
  periodId?: Readable;
  static names(): { [key: string]: string } {
    return {
      ownerId: 'ownerId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      periodId: 'periodId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ownerId: 'Readable',
      pageNumber: 'number',
      pageSize: 'number',
      periodId: 'Readable',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserOkrResponseBody extends $tea.Model {
  code?: number;
  data?: GetUserOkrResponseBodyData;
  message?: Readable;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: GetUserOkrResponseBodyData,
      message: 'Readable',
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
  ownerId?: Readable;
  static names(): { [key: string]: string } {
    return {
      periodId: 'periodId',
      targetId: 'targetId',
      ownerId: 'ownerId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      periodId: 'string',
      targetId: 'string',
      ownerId: 'Readable',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnAlignObjectiveResponseBody extends $tea.Model {
  code?: number;
  data?: UnAlignObjectiveResponseBodyData;
  message?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: UnAlignObjectiveResponseBodyData,
      message: 'string',
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
  content?: Readable;
  updateQuoteList?: Readable[];
  krId?: Readable;
  operatorUid?: Readable;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      updateQuoteList: 'updateQuoteList',
      krId: 'krId',
      operatorUid: 'operatorUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'Readable',
      updateQuoteList: { 'type': 'array', 'itemType': 'Readable' },
      krId: 'Readable',
      operatorUid: 'Readable',
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
  krId?: Readable;
  ownerId?: Readable;
  static names(): { [key: string]: string } {
    return {
      score: 'score',
      krId: 'krId',
      ownerId: 'ownerId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      score: 'number',
      krId: 'Readable',
      ownerId: 'Readable',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateKROfScoreResponseBody extends $tea.Model {
  data?: number;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'number',
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
  krId?: Readable;
  ownerId?: Readable;
  static names(): { [key: string]: string } {
    return {
      weight: 'weight',
      krId: 'krId',
      ownerId: 'ownerId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      weight: 'number',
      krId: 'Readable',
      ownerId: 'Readable',
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
  content?: Readable;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'Readable',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateObjectiveResponseBody extends $tea.Model {
  code?: number;
  data?: UpdateObjectiveResponseBodyData;
  message?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: UpdateObjectiveResponseBodyData,
      message: 'string',
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

export class BatchQueryObjectiveResponseBodyDataOwnerDepartment extends $tea.Model {
  id?: Readable;
  name?: Readable;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'Readable',
      name: 'Readable',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryObjectiveResponseBodyDataOwner extends $tea.Model {
  avatarMediaId?: Readable;
  corpId?: Readable;
  department?: BatchQueryObjectiveResponseBodyDataOwnerDepartment;
  id?: Readable;
  nickname?: Readable;
  staffId?: Readable;
  static names(): { [key: string]: string } {
    return {
      avatarMediaId: 'avatarMediaId',
      corpId: 'corpId',
      department: 'department',
      id: 'id',
      nickname: 'nickname',
      staffId: 'staffId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatarMediaId: 'Readable',
      corpId: 'Readable',
      department: BatchQueryObjectiveResponseBodyDataOwnerDepartment,
      id: 'Readable',
      nickname: 'Readable',
      staffId: 'Readable',
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

export class GetUserOkrResponseBodyDataListOwnerDepartment extends $tea.Model {
  id?: Readable;
  name?: Readable;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'Readable',
      name: 'Readable',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserOkrResponseBodyDataListOwner extends $tea.Model {
  avatarMediaId?: Readable;
  corpId?: Readable;
  department?: GetUserOkrResponseBodyDataListOwnerDepartment;
  id?: Readable;
  nickname?: Readable;
  staffId?: Readable;
  static names(): { [key: string]: string } {
    return {
      avatarMediaId: 'avatarMediaId',
      corpId: 'corpId',
      department: 'department',
      id: 'id',
      nickname: 'nickname',
      staffId: 'staffId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatarMediaId: 'Readable',
      corpId: 'Readable',
      department: GetUserOkrResponseBodyDataListOwnerDepartment,
      id: 'Readable',
      nickname: 'Readable',
      staffId: 'Readable',
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
  pageNo?: number;
  pageSize?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      list: 'list',
      pageNo: 'pageNo',
      pageSize: 'pageSize',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': GetUserOkrResponseBodyDataList },
      pageNo: 'number',
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

export class UpdateKROfWeightResponseBodyDataObjectiveProgress extends $tea.Model {
  percent?: number;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      percent: 'percent',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      percent: 'number',
      status: 'number',
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
    if (!Util.isUnset(request.ownerId)) {
      query["ownerId"] = request.ownerId;
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

  async batchQueryObjective(request: BatchQueryObjectiveRequest): Promise<BatchQueryObjectiveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchQueryObjectiveHeaders({ });
    return await this.batchQueryObjectiveWithOptions(request, headers, runtime);
  }

  async batchQueryObjectiveWithOptions(request: BatchQueryObjectiveRequest, headers: BatchQueryObjectiveHeaders, runtime: $Util.RuntimeOptions): Promise<BatchQueryObjectiveResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.ownerId)) {
      query["ownerId"] = request.ownerId;
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

  async createKeyResult(request: CreateKeyResultRequest): Promise<CreateKeyResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateKeyResultHeaders({ });
    return await this.createKeyResultWithOptions(request, headers, runtime);
  }

  async createKeyResultWithOptions(request: CreateKeyResultRequest, headers: CreateKeyResultHeaders, runtime: $Util.RuntimeOptions): Promise<CreateKeyResultResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.ownerId)) {
      query["ownerId"] = request.ownerId;
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

    if (!Util.isUnset(request.ownerId)) {
      query["ownerId"] = request.ownerId;
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

  async getUserOkr(request: GetUserOkrRequest): Promise<GetUserOkrResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserOkrHeaders({ });
    return await this.getUserOkrWithOptions(request, headers, runtime);
  }

  async getUserOkrWithOptions(request: GetUserOkrRequest, headers: GetUserOkrHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserOkrResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.ownerId)) {
      query["ownerId"] = request.ownerId;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.periodId)) {
      query["periodId"] = request.periodId;
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
    if (!Util.isUnset(request.ownerId)) {
      query["ownerId"] = request.ownerId;
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

    if (!Util.isUnset(request.operatorUid)) {
      query["operatorUid"] = request.operatorUid;
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

    if (!Util.isUnset(request.ownerId)) {
      query["ownerId"] = request.ownerId;
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

    if (!Util.isUnset(request.ownerId)) {
      query["ownerId"] = request.ownerId;
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

}
