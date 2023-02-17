// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class OpenAnalyzeDataDTO extends $tea.Model {
  deptCount?: number;
  noAlignObjectiveCount?: number;
  noKeyActionCount?: number;
  objectiveAlignRate?: number;
  objectiveNoSetCount?: number;
  objectiveRiskCount?: number;
  objectiveSetRate?: number;
  onlyOneKeyResultCount?: number;
  onlyOneObjectiveCount?: number;
  progressUpdateRateLast15Days?: number;
  progressUpdateRateLast30Days?: number;
  progressUpdateRateLast7Days?: number;
  static names(): { [key: string]: string } {
    return {
      deptCount: 'deptCount',
      noAlignObjectiveCount: 'noAlignObjectiveCount',
      noKeyActionCount: 'noKeyActionCount',
      objectiveAlignRate: 'objectiveAlignRate',
      objectiveNoSetCount: 'objectiveNoSetCount',
      objectiveRiskCount: 'objectiveRiskCount',
      objectiveSetRate: 'objectiveSetRate',
      onlyOneKeyResultCount: 'onlyOneKeyResultCount',
      onlyOneObjectiveCount: 'onlyOneObjectiveCount',
      progressUpdateRateLast15Days: 'progressUpdateRateLast15Days',
      progressUpdateRateLast30Days: 'progressUpdateRateLast30Days',
      progressUpdateRateLast7Days: 'progressUpdateRateLast7Days',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptCount: 'number',
      noAlignObjectiveCount: 'number',
      noKeyActionCount: 'number',
      objectiveAlignRate: 'number',
      objectiveNoSetCount: 'number',
      objectiveRiskCount: 'number',
      objectiveSetRate: 'number',
      onlyOneKeyResultCount: 'number',
      onlyOneObjectiveCount: 'number',
      progressUpdateRateLast15Days: 'number',
      progressUpdateRateLast30Days: 'number',
      progressUpdateRateLast7Days: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenKeyResultDTO extends $tea.Model {
  id?: string;
  progress?: number;
  status?: number;
  title?: string;
  titleMentions?: TitleMention[];
  type?: number;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      progress: 'progress',
      status: 'status',
      title: 'title',
      titleMentions: 'titleMentions',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      progress: 'number',
      status: 'number',
      title: 'string',
      titleMentions: { 'type': 'array', 'itemType': TitleMention },
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenObjectiveDTO extends $tea.Model {
  executor?: OpenUserDTO;
  id?: string;
  keyResults?: OpenKeyResultDTO[];
  period?: OpenPeriodDTO;
  progress?: number;
  status?: number;
  teams?: OpenTeamDTO[];
  title?: string;
  static names(): { [key: string]: string } {
    return {
      executor: 'executor',
      id: 'id',
      keyResults: 'keyResults',
      period: 'period',
      progress: 'progress',
      status: 'status',
      teams: 'teams',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      executor: OpenUserDTO,
      id: 'string',
      keyResults: { 'type': 'array', 'itemType': OpenKeyResultDTO },
      period: OpenPeriodDTO,
      progress: 'number',
      status: 'number',
      teams: { 'type': 'array', 'itemType': OpenTeamDTO },
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenPeriodDTO extends $tea.Model {
  endDate?: number;
  id?: string;
  name?: string;
  periodBizType?: string;
  startDate?: number;
  static names(): { [key: string]: string } {
    return {
      endDate: 'endDate',
      id: 'id',
      name: 'name',
      periodBizType: 'periodBizType',
      startDate: 'startDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endDate: 'number',
      id: 'string',
      name: 'string',
      periodBizType: 'string',
      startDate: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenProgressDTO extends $tea.Model {
  created?: number;
  creator?: OpenUserDTO;
  htmlContent?: string;
  id?: string;
  modifier?: OpenUserDTO;
  updated?: number;
  static names(): { [key: string]: string } {
    return {
      created: 'created',
      creator: 'creator',
      htmlContent: 'htmlContent',
      id: 'id',
      modifier: 'modifier',
      updated: 'updated',
    };
  }

  static types(): { [key: string]: any } {
    return {
      created: 'number',
      creator: OpenUserDTO,
      htmlContent: 'string',
      id: 'string',
      modifier: OpenUserDTO,
      updated: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenTeamDTO extends $tea.Model {
  id?: string;
  name?: string;
  openId?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      openId: 'openId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      name: 'string',
      openId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenUserDTO extends $tea.Model {
  id?: string;
  name?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      name: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TitleMention extends $tea.Model {
  length?: number;
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

export class GetAnalyzeDataHeaders extends $tea.Model {
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

export class GetAnalyzeDataRequest extends $tea.Model {
  periodIds?: string[];
  deptId?: string;
  static names(): { [key: string]: string } {
    return {
      periodIds: 'periodIds',
      deptId: 'deptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      periodIds: { 'type': 'array', 'itemType': 'string' },
      deptId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAnalyzeDataResponseBody extends $tea.Model {
  content?: OpenAnalyzeDataDTO;
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
      content: OpenAnalyzeDataDTO,
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAnalyzeDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetAnalyzeDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetAnalyzeDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmployeeInfoByWorkNoHeaders extends $tea.Model {
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

export class GetEmployeeInfoByWorkNoRequest extends $tea.Model {
  workNo?: string;
  static names(): { [key: string]: string } {
    return {
      workNo: 'workNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      workNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmployeeInfoByWorkNoResponseBody extends $tea.Model {
  content?: GetEmployeeInfoByWorkNoResponseBodyContent;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: GetEmployeeInfoByWorkNoResponseBodyContent,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmployeeInfoByWorkNoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetEmployeeInfoByWorkNoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetEmployeeInfoByWorkNoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserHeaders extends $tea.Model {
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

export class GetUserRequest extends $tea.Model {
  okrUserId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      okrUserId: 'okrUserId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      okrUserId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserResponseBody extends $tea.Model {
  content?: OpenUserDTO;
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
      content: OpenUserDTO,
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetUserResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetUserResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAnalyzePeriodsHeaders extends $tea.Model {
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

export class ListAnalyzePeriodsResponseBody extends $tea.Model {
  content?: OpenPeriodDTO[];
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
      content: { 'type': 'array', 'itemType': OpenPeriodDTO },
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAnalyzePeriodsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListAnalyzePeriodsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListAnalyzePeriodsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListObjectiveByIdsHeaders extends $tea.Model {
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

export class ListObjectiveByIdsRequest extends $tea.Model {
  objectiveIds?: string[];
  static names(): { [key: string]: string } {
    return {
      objectiveIds: 'objectiveIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      objectiveIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListObjectiveByIdsResponseBody extends $tea.Model {
  content?: OpenObjectiveDTO[];
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
      content: { 'type': 'array', 'itemType': OpenObjectiveDTO },
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListObjectiveByIdsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListObjectiveByIdsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListObjectiveByIdsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListObjectiveByUserHeaders extends $tea.Model {
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

export class ListObjectiveByUserRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListObjectiveByUserResponseBody extends $tea.Model {
  content?: ListObjectiveByUserResponseBodyContent;
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
      content: ListObjectiveByUserResponseBodyContent,
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListObjectiveByUserResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListObjectiveByUserResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListObjectiveByUserResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListProgressByIdsHeaders extends $tea.Model {
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

export class ListProgressByIdsRequest extends $tea.Model {
  progressIds?: string[];
  static names(): { [key: string]: string } {
    return {
      progressIds: 'progressIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      progressIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListProgressByIdsResponseBody extends $tea.Model {
  content?: OpenProgressDTO[];
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
      content: { 'type': 'array', 'itemType': OpenProgressDTO },
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListProgressByIdsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListProgressByIdsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListProgressByIdsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageListObjectiveProgressHeaders extends $tea.Model {
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

export class PageListObjectiveProgressRequest extends $tea.Model {
  objectiveId?: string;
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      objectiveId: 'objectiveId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      objectiveId: 'string',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageListObjectiveProgressResponseBody extends $tea.Model {
  content?: PageListObjectiveProgressResponseBodyContent;
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
      content: PageListObjectiveProgressResponseBodyContent,
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageListObjectiveProgressResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: PageListObjectiveProgressResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: PageListObjectiveProgressResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TransferUserObjectiveHeaders extends $tea.Model {
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

export class TransferUserObjectiveRequest extends $tea.Model {
  objectiveId?: string;
  targetUserId?: string;
  static names(): { [key: string]: string } {
    return {
      objectiveId: 'objectiveId',
      targetUserId: 'targetUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      objectiveId: 'string',
      targetUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TransferUserObjectiveResponseBody extends $tea.Model {
  content?: boolean;
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
      content: 'boolean',
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TransferUserObjectiveResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: TransferUserObjectiveResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: TransferUserObjectiveResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmployeeInfoByWorkNoResponseBodyContent extends $tea.Model {
  name?: string;
  workNo?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      workNo: 'workNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      workNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListObjectiveByUserResponseBodyContent extends $tea.Model {
  count?: number;
  objectives?: OpenObjectiveDTO[];
  static names(): { [key: string]: string } {
    return {
      count: 'count',
      objectives: 'objectives',
    };
  }

  static types(): { [key: string]: any } {
    return {
      count: 'number',
      objectives: { 'type': 'array', 'itemType': OpenObjectiveDTO },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageListObjectiveProgressResponseBodyContent extends $tea.Model {
  count?: number;
  progressList?: OpenProgressDTO[];
  static names(): { [key: string]: string } {
    return {
      count: 'count',
      progressList: 'progressList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      count: 'number',
      progressList: { 'type': 'array', 'itemType': OpenProgressDTO },
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


  async getAnalyzeData(request: GetAnalyzeDataRequest): Promise<GetAnalyzeDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAnalyzeDataHeaders({ });
    return await this.getAnalyzeDataWithOptions(request, headers, runtime);
  }

  async getAnalyzeDataWithOptions(request: GetAnalyzeDataRequest, headers: GetAnalyzeDataHeaders, runtime: $Util.RuntimeOptions): Promise<GetAnalyzeDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptId)) {
      query["deptId"] = request.deptId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.periodIds)) {
      body["periodIds"] = request.periodIds;
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
    return $tea.cast<GetAnalyzeDataResponse>(await this.doROARequest("GetAnalyzeData", "chengfeng_1.0", "HTTP", "POST", "AK", `/v1.0/chengfeng/okr/analyses/datas/query`, "json", req, runtime), new GetAnalyzeDataResponse({}));
  }

  async getEmployeeInfoByWorkNo(request: GetEmployeeInfoByWorkNoRequest): Promise<GetEmployeeInfoByWorkNoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetEmployeeInfoByWorkNoHeaders({ });
    return await this.getEmployeeInfoByWorkNoWithOptions(request, headers, runtime);
  }

  async getEmployeeInfoByWorkNoWithOptions(request: GetEmployeeInfoByWorkNoRequest, headers: GetEmployeeInfoByWorkNoHeaders, runtime: $Util.RuntimeOptions): Promise<GetEmployeeInfoByWorkNoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.workNo)) {
      query["workNo"] = request.workNo;
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
    return $tea.cast<GetEmployeeInfoByWorkNoResponse>(await this.doROARequest("GetEmployeeInfoByWorkNo", "chengfeng_1.0", "HTTP", "GET", "AK", `/v1.0/chengfeng/workNumbers/employees`, "json", req, runtime), new GetEmployeeInfoByWorkNoResponse({}));
  }

  async getUser(request: GetUserRequest): Promise<GetUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserHeaders({ });
    return await this.getUserWithOptions(request, headers, runtime);
  }

  async getUserWithOptions(request: GetUserRequest, headers: GetUserHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.okrUserId)) {
      query["okrUserId"] = request.okrUserId;
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
    return $tea.cast<GetUserResponse>(await this.doROARequest("GetUser", "chengfeng_1.0", "HTTP", "GET", "AK", `/v1.0/chengfeng/okr/users`, "json", req, runtime), new GetUserResponse({}));
  }

  async listAnalyzePeriods(): Promise<ListAnalyzePeriodsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListAnalyzePeriodsHeaders({ });
    return await this.listAnalyzePeriodsWithOptions(headers, runtime);
  }

  async listAnalyzePeriodsWithOptions(headers: ListAnalyzePeriodsHeaders, runtime: $Util.RuntimeOptions): Promise<ListAnalyzePeriodsResponse> {
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
    return $tea.cast<ListAnalyzePeriodsResponse>(await this.doROARequest("ListAnalyzePeriods", "chengfeng_1.0", "HTTP", "GET", "AK", `/v1.0/chengfeng/okr/analyses/periods`, "json", req, runtime), new ListAnalyzePeriodsResponse({}));
  }

  async listObjectiveByIds(request: ListObjectiveByIdsRequest): Promise<ListObjectiveByIdsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListObjectiveByIdsHeaders({ });
    return await this.listObjectiveByIdsWithOptions(request, headers, runtime);
  }

  async listObjectiveByIdsWithOptions(request: ListObjectiveByIdsRequest, headers: ListObjectiveByIdsHeaders, runtime: $Util.RuntimeOptions): Promise<ListObjectiveByIdsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
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
    return $tea.cast<ListObjectiveByIdsResponse>(await this.doROARequest("ListObjectiveByIds", "chengfeng_1.0", "HTTP", "POST", "AK", `/v1.0/chengfeng/okr/objectives/query`, "json", req, runtime), new ListObjectiveByIdsResponse({}));
  }

  async listObjectiveByUser(request: ListObjectiveByUserRequest): Promise<ListObjectiveByUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListObjectiveByUserHeaders({ });
    return await this.listObjectiveByUserWithOptions(request, headers, runtime);
  }

  async listObjectiveByUserWithOptions(request: ListObjectiveByUserRequest, headers: ListObjectiveByUserHeaders, runtime: $Util.RuntimeOptions): Promise<ListObjectiveByUserResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
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
    return $tea.cast<ListObjectiveByUserResponse>(await this.doROARequest("ListObjectiveByUser", "chengfeng_1.0", "HTTP", "GET", "AK", `/v1.0/chengfeng/okr/users/objectives`, "json", req, runtime), new ListObjectiveByUserResponse({}));
  }

  async listProgressByIds(request: ListProgressByIdsRequest): Promise<ListProgressByIdsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListProgressByIdsHeaders({ });
    return await this.listProgressByIdsWithOptions(request, headers, runtime);
  }

  async listProgressByIdsWithOptions(request: ListProgressByIdsRequest, headers: ListProgressByIdsHeaders, runtime: $Util.RuntimeOptions): Promise<ListProgressByIdsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.progressIds)) {
      body["progressIds"] = request.progressIds;
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
    return $tea.cast<ListProgressByIdsResponse>(await this.doROARequest("ListProgressByIds", "chengfeng_1.0", "HTTP", "POST", "AK", `/v1.0/chengfeng/okr/objectives/progresses/query`, "json", req, runtime), new ListProgressByIdsResponse({}));
  }

  async pageListObjectiveProgress(request: PageListObjectiveProgressRequest): Promise<PageListObjectiveProgressResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PageListObjectiveProgressHeaders({ });
    return await this.pageListObjectiveProgressWithOptions(request, headers, runtime);
  }

  async pageListObjectiveProgressWithOptions(request: PageListObjectiveProgressRequest, headers: PageListObjectiveProgressHeaders, runtime: $Util.RuntimeOptions): Promise<PageListObjectiveProgressResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.objectiveId)) {
      query["objectiveId"] = request.objectiveId;
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
    return $tea.cast<PageListObjectiveProgressResponse>(await this.doROARequest("PageListObjectiveProgress", "chengfeng_1.0", "HTTP", "GET", "AK", `/v1.0/chengfeng/okr/objectives/progresses/records`, "json", req, runtime), new PageListObjectiveProgressResponse({}));
  }

  async transferUserObjective(request: TransferUserObjectiveRequest): Promise<TransferUserObjectiveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TransferUserObjectiveHeaders({ });
    return await this.transferUserObjectiveWithOptions(request, headers, runtime);
  }

  async transferUserObjectiveWithOptions(request: TransferUserObjectiveRequest, headers: TransferUserObjectiveHeaders, runtime: $Util.RuntimeOptions): Promise<TransferUserObjectiveResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.objectiveId)) {
      query["objectiveId"] = request.objectiveId;
    }

    if (!Util.isUnset(request.targetUserId)) {
      query["targetUserId"] = request.targetUserId;
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
    return $tea.cast<TransferUserObjectiveResponse>(await this.doROARequest("TransferUserObjective", "chengfeng_1.0", "HTTP", "POST", "AK", `/v1.0/chengfeng/okr/objectives/transfer`, "json", req, runtime), new TransferUserObjectiveResponse({}));
  }

}
