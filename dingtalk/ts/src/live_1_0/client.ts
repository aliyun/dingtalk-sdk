// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class AddShareCidListHeaders extends $tea.Model {
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

export class AddShareCidListRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2
   */
  groupIdType?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  groupIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 214675
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      groupIdType: 'groupIdType',
      groupIds: 'groupIds',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupIdType: 'number',
      groupIds: { 'type': 'array', 'itemType': 'string' },
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddShareCidListResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  hasShareSuccess?: boolean;
  shareSuccessGroupList?: string[];
  static names(): { [key: string]: string } {
    return {
      hasShareSuccess: 'hasShareSuccess',
      shareSuccessGroupList: 'shareSuccessGroupList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasShareSuccess: 'boolean',
      shareSuccessGroupList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddShareCidListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddShareCidListResponseBody;
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
      body: AddShareCidListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCloudFeedHeaders extends $tea.Model {
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

export class CreateCloudFeedRequest extends $tea.Model {
  /**
   * @example
   * https://img.alicdn.com/tfs/TB1A7cBtYr1gK0jSZR0XXbP8XXa-750-422.png
   */
  coverUrl?: string;
  /**
   * @example
   * 这是一场云导播课程
   */
  intro?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1615260061000
   */
  startTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 课程一
   */
  title?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 214675
   */
  userId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * http/https:/xxx.mp4
   */
  videoUrl?: string;
  static names(): { [key: string]: string } {
    return {
      coverUrl: 'coverUrl',
      intro: 'intro',
      startTime: 'startTime',
      title: 'title',
      userId: 'userId',
      videoUrl: 'videoUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      coverUrl: 'string',
      intro: 'string',
      startTime: 'number',
      title: 'string',
      userId: 'string',
      videoUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCloudFeedResponseBody extends $tea.Model {
  /**
   * @example
   * 创建好的云导播课程id
   */
  result?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCloudFeedResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateCloudFeedResponseBody;
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
      body: CreateCloudFeedResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateLiveHeaders extends $tea.Model {
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

export class CreateLiveRequest extends $tea.Model {
  /**
   * @example
   * https://gw.alicdn.com/tfs/TB1thlYyAT2gK0jSZPcXXcKkpXa-1125-633.png
   */
  coverUrl?: string;
  /**
   * @example
   * 测试直播简介
   */
  introduction?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1659653648000
   */
  preEndTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1659613648000
   */
  preStartTime?: number;
  /**
   * @example
   * 2
   */
  publicType?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 测试直播
   */
  title?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * DC7wZGOSueEEIGOf3WKwWgiEiE
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      coverUrl: 'coverUrl',
      introduction: 'introduction',
      preEndTime: 'preEndTime',
      preStartTime: 'preStartTime',
      publicType: 'publicType',
      title: 'title',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      coverUrl: 'string',
      introduction: 'string',
      preEndTime: 'number',
      preStartTime: 'number',
      publicType: 'number',
      title: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateLiveResponseBody extends $tea.Model {
  result?: CreateLiveResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: CreateLiveResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateLiveResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateLiveResponseBody;
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
      body: CreateLiveResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteLiveHeaders extends $tea.Model {
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

export class DeleteLiveRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 4d383876-1ff9-4b73-a057-a8f47b346ecb
   */
  liveId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * DC7wZGOSueEEIGOf3WKwWgiEiE
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      liveId: 'liveId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      liveId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteLiveResponseBody extends $tea.Model {
  result?: DeleteLiveResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: DeleteLiveResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteLiveResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteLiveResponseBody;
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
      body: DeleteLiveResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteLiveFeedHeaders extends $tea.Model {
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

export class DeleteLiveFeedRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1206186351746728
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

export class DeleteLiveFeedResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  hasDelete?: boolean;
  static names(): { [key: string]: string } {
    return {
      hasDelete: 'hasDelete',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasDelete: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteLiveFeedResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteLiveFeedResponseBody;
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
      body: DeleteLiveFeedResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditFeedReplayHeaders extends $tea.Model {
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

export class EditFeedReplayRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1617356058000
   */
  editEndTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1617336058000
   */
  editStartTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1206186351746728
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      editEndTime: 'editEndTime',
      editStartTime: 'editStartTime',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      editEndTime: 'number',
      editStartTime: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditFeedReplayResponseBody extends $tea.Model {
  result?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditFeedReplayResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: EditFeedReplayResponseBody;
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
      body: EditFeedReplayResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLiveReplayUrlHeaders extends $tea.Model {
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

export class GetLiveReplayUrlRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 4d383876-1ff9-4b73-a057-a8f47b346ecb
   */
  liveId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * DC7wZGOSueEEIGOf3WKwWgiEiE
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      liveId: 'liveId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      liveId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLiveReplayUrlResponseBody extends $tea.Model {
  result?: GetLiveReplayUrlResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetLiveReplayUrlResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLiveReplayUrlResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetLiveReplayUrlResponseBody;
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
      body: GetLiveReplayUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserAllLiveListHeaders extends $tea.Model {
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

export class GetUserAllLiveListRequest extends $tea.Model {
  endTime?: number;
  startTime?: number;
  statuses?: number[];
  title?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 30
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 6crtQT2XOgPHviiPvXhhiP6gdhiE
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      startTime: 'startTime',
      statuses: 'statuses',
      title: 'title',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      startTime: 'number',
      statuses: { 'type': 'array', 'itemType': 'number' },
      title: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserAllLiveListResponseBody extends $tea.Model {
  result?: GetUserAllLiveListResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetUserAllLiveListResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserAllLiveListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetUserAllLiveListResponseBody;
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
      body: GetUserAllLiveListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserCreateLiveListHeaders extends $tea.Model {
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

export class GetUserCreateLiveListRequest extends $tea.Model {
  endTime?: number;
  startTime?: number;
  statuses?: number[];
  title?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20
   */
  maxResults?: number;
  /**
   * @example
   * ""
   */
  nextToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 5yAiiJDWiiCJpd3Thhx7P5fgiEiE
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      startTime: 'startTime',
      statuses: 'statuses',
      title: 'title',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      startTime: 'number',
      statuses: { 'type': 'array', 'itemType': 'number' },
      title: 'string',
      maxResults: 'number',
      nextToken: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserCreateLiveListResponseBody extends $tea.Model {
  result?: GetUserCreateLiveListResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetUserCreateLiveListResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserCreateLiveListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetUserCreateLiveListResponseBody;
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
      body: GetUserCreateLiveListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserWatchLiveListHeaders extends $tea.Model {
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

export class GetUserWatchLiveListRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  filterType?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 30
   */
  maxResults?: number;
  /**
   * @example
   * preOrStartTime_desc_1658804913000
   */
  nextToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 6crtQT2XOgPHviiPvXhhiP6gdhiE
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      filterType: 'filterType',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      filterType: 'number',
      maxResults: 'number',
      nextToken: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserWatchLiveListResponseBody extends $tea.Model {
  result?: GetUserWatchLiveListResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetUserWatchLiveListResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserWatchLiveListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetUserWatchLiveListResponseBody;
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
      body: GetUserWatchLiveListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifyFeedWhiteListHeaders extends $tea.Model {
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

export class ModifyFeedWhiteListRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  action?: number;
  modifyUserList?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1206186351746728
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      action: 'action',
      modifyUserList: 'modifyUserList',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      action: 'number',
      modifyUserList: { 'type': 'array', 'itemType': 'string' },
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifyFeedWhiteListShrinkRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  action?: number;
  modifyUserListShrink?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1206186351746728
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      action: 'action',
      modifyUserListShrink: 'modifyUserList',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      action: 'number',
      modifyUserListShrink: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifyFeedWhiteListResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifyFeedWhiteListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ModifyFeedWhiteListResponseBody;
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
      body: ModifyFeedWhiteListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryFeedWhiteListHeaders extends $tea.Model {
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

export class QueryFeedWhiteListRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1206186351746728
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

export class QueryFeedWhiteListResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryFeedWhiteListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryFeedWhiteListResponseBody;
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
      body: QueryFeedWhiteListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryLiveInfoHeaders extends $tea.Model {
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

export class QueryLiveInfoRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 4d383876-1ff9-4b73-a057-a8f47b346ecb
   */
  liveId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * DC7wZGOSueEEIGOf3WKwWgiEiE
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      liveId: 'liveId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      liveId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryLiveInfoResponseBody extends $tea.Model {
  result?: QueryLiveInfoResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryLiveInfoResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryLiveInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryLiveInfoResponseBody;
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
      body: QueryLiveInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryLiveWatchDetailHeaders extends $tea.Model {
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

export class QueryLiveWatchDetailRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1a353547-040d-4095-bb93-404bc5d47920
   */
  liveId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * DC7wZGOSueEEIGOf3WKwWgiEiE
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      liveId: 'liveId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      liveId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryLiveWatchDetailResponseBody extends $tea.Model {
  result?: QueryLiveWatchDetailResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryLiveWatchDetailResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryLiveWatchDetailResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryLiveWatchDetailResponseBody;
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
      body: QueryLiveWatchDetailResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryLiveWatchUserListHeaders extends $tea.Model {
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

export class QueryLiveWatchUserListRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1a353547-040d-4095-bb93-404bc5d47920
   */
  liveId?: string;
  pageNumber?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * DC7wZGOSueEEIGOf3WKwWgiEiE
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      liveId: 'liveId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      liveId: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryLiveWatchUserListResponseBody extends $tea.Model {
  result?: QueryLiveWatchUserListResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryLiveWatchUserListResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryLiveWatchUserListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryLiveWatchUserListResponseBody;
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
      body: QueryLiveWatchUserListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySubscribeStatusHeaders extends $tea.Model {
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

export class QuerySubscribeStatusRequest extends $tea.Model {
  body?: QuerySubscribeStatusRequestBody;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: QuerySubscribeStatusRequestBody,
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySubscribeStatusShrinkRequest extends $tea.Model {
  bodyShrink?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      bodyShrink: 'body',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bodyShrink: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySubscribeStatusResponseBody extends $tea.Model {
  result?: QuerySubscribeStatusResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QuerySubscribeStatusResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySubscribeStatusResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QuerySubscribeStatusResponseBody;
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
      body: QuerySubscribeStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCloudFeedHeaders extends $tea.Model {
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

export class StartCloudFeedRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 214675
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

export class StartCloudFeedResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCloudFeedResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: StartCloudFeedResponseBody;
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
      body: StartCloudFeedResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StopCloudFeedHeaders extends $tea.Model {
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

export class StopCloudFeedRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 214675
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

export class StopCloudFeedResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StopCloudFeedResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: StopCloudFeedResponseBody;
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
      body: StopCloudFeedResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SubscribeLiveHeaders extends $tea.Model {
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

export class SubscribeLiveRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3dd295eb-17a1-4dfg-ae1b-aa165c5007eb
   */
  liveId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  subscribe?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 6crtQT2XOgPHviiPvXhhiP6gdhiE
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      liveId: 'liveId',
      subscribe: 'subscribe',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      liveId: 'string',
      subscribe: 'boolean',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SubscribeLiveResponseBody extends $tea.Model {
  result?: SubscribeLiveResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: SubscribeLiveResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SubscribeLiveResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SubscribeLiveResponseBody;
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
      body: SubscribeLiveResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateLiveHeaders extends $tea.Model {
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

export class UpdateLiveRequest extends $tea.Model {
  /**
   * @example
   * https://gw.alicdn.com/tfs/TB1thlYyAT2gK0jSZPcXXcKkpXa-1125-633.png
   */
  coverUrl?: string;
  /**
   * @example
   * 测试直播简介
   */
  introduction?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 4d383876-1ff9-4b73-a057-a8f47b346ecb
   */
  liveId?: string;
  /**
   * @example
   * 1659653648000
   */
  preEndTime?: number;
  /**
   * @example
   * 1659613648000
   */
  preStartTime?: number;
  /**
   * @example
   * 测试直播
   */
  title?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * DC7wZGOSueEEIGOf3WKwWgiEiE
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      coverUrl: 'coverUrl',
      introduction: 'introduction',
      liveId: 'liveId',
      preEndTime: 'preEndTime',
      preStartTime: 'preStartTime',
      title: 'title',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      coverUrl: 'string',
      introduction: 'string',
      liveId: 'string',
      preEndTime: 'number',
      preStartTime: 'number',
      title: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateLiveResponseBody extends $tea.Model {
  result?: UpdateLiveResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UpdateLiveResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateLiveResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateLiveResponseBody;
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
      body: UpdateLiveResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateLiveFeedHeaders extends $tea.Model {
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

export class UpdateLiveFeedRequest extends $tea.Model {
  /**
   * @example
   * http:xxx.png
   */
  coverUrl?: string;
  /**
   * @example
   * 简介
   */
  introduction?: string;
  /**
   * @example
   * 1617436058000
   */
  startTime?: number;
  /**
   * @example
   * 标题
   */
  title?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1206186351746728
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      coverUrl: 'coverUrl',
      introduction: 'introduction',
      startTime: 'startTime',
      title: 'title',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      coverUrl: 'string',
      introduction: 'string',
      startTime: 'number',
      title: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateLiveFeedResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  hasUpdate?: boolean;
  static names(): { [key: string]: string } {
    return {
      hasUpdate: 'hasUpdate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasUpdate: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateLiveFeedResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateLiveFeedResponseBody;
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
      body: UpdateLiveFeedResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateLiveResponseBodyResult extends $tea.Model {
  /**
   * @example
   * 1a353547-040d-4095-bb93-404bc5d47920
   */
  liveId?: string;
  static names(): { [key: string]: string } {
    return {
      liveId: 'liveId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      liveId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteLiveResponseBodyResult extends $tea.Model {
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

export class GetLiveReplayUrlResponseBodyResult extends $tea.Model {
  /**
   * @example
   * http://xxx.dingtalk.com/live_hp/7c7ba32a-c92d-4524-b71e-33a72575c5a9_normal.m3u8?auth_key=xxx
   */
  replayUrl?: string;
  static names(): { [key: string]: string } {
    return {
      replayUrl: 'replayUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      replayUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserAllLiveListResponseBodyResultLiveInfoPopModelListExtraInfo extends $tea.Model {
  hasSubscribed?: boolean;
  isForecastExpired?: boolean;
  watchProgressMs?: number;
  static names(): { [key: string]: string } {
    return {
      hasSubscribed: 'hasSubscribed',
      isForecastExpired: 'isForecastExpired',
      watchProgressMs: 'watchProgressMs',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasSubscribed: 'boolean',
      isForecastExpired: 'boolean',
      watchProgressMs: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserAllLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo extends $tea.Model {
  coverUrl?: string;
  duration?: number;
  endTime?: number;
  introduction?: string;
  liveId?: string;
  livePlayUrl?: string;
  liveStatus?: number;
  startTime?: number;
  subscribeCount?: number;
  title?: string;
  unionId?: string;
  uv?: number;
  static names(): { [key: string]: string } {
    return {
      coverUrl: 'coverUrl',
      duration: 'duration',
      endTime: 'endTime',
      introduction: 'introduction',
      liveId: 'liveId',
      livePlayUrl: 'livePlayUrl',
      liveStatus: 'liveStatus',
      startTime: 'startTime',
      subscribeCount: 'subscribeCount',
      title: 'title',
      unionId: 'unionId',
      uv: 'uv',
    };
  }

  static types(): { [key: string]: any } {
    return {
      coverUrl: 'string',
      duration: 'number',
      endTime: 'number',
      introduction: 'string',
      liveId: 'string',
      livePlayUrl: 'string',
      liveStatus: 'number',
      startTime: 'number',
      subscribeCount: 'number',
      title: 'string',
      unionId: 'string',
      uv: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserAllLiveListResponseBodyResultLiveInfoPopModelList extends $tea.Model {
  extraInfo?: GetUserAllLiveListResponseBodyResultLiveInfoPopModelListExtraInfo;
  liveBasicInfo?: GetUserAllLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo;
  static names(): { [key: string]: string } {
    return {
      extraInfo: 'extraInfo',
      liveBasicInfo: 'liveBasicInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extraInfo: GetUserAllLiveListResponseBodyResultLiveInfoPopModelListExtraInfo,
      liveBasicInfo: GetUserAllLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserAllLiveListResponseBodyResult extends $tea.Model {
  hasFinish?: boolean;
  liveInfoPopModelList?: GetUserAllLiveListResponseBodyResultLiveInfoPopModelList[];
  static names(): { [key: string]: string } {
    return {
      hasFinish: 'hasFinish',
      liveInfoPopModelList: 'liveInfoPopModelList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasFinish: 'boolean',
      liveInfoPopModelList: { 'type': 'array', 'itemType': GetUserAllLiveListResponseBodyResultLiveInfoPopModelList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListHasSubscribed extends $tea.Model {
  hasSubscribed?: boolean;
  isForecastExpired?: boolean;
  watchProgressMs?: number;
  static names(): { [key: string]: string } {
    return {
      hasSubscribed: 'hasSubscribed',
      isForecastExpired: 'isForecastExpired',
      watchProgressMs: 'watchProgressMs',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasSubscribed: 'boolean',
      isForecastExpired: 'boolean',
      watchProgressMs: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo extends $tea.Model {
  coverUrl?: string;
  duration?: number;
  endTime?: number;
  introduction?: string;
  liveId?: string;
  livePlayUrl?: string;
  liveStatus?: number;
  startTime?: number;
  subscribeCount?: number;
  title?: string;
  unionId?: string;
  uv?: number;
  static names(): { [key: string]: string } {
    return {
      coverUrl: 'coverUrl',
      duration: 'duration',
      endTime: 'endTime',
      introduction: 'introduction',
      liveId: 'liveId',
      livePlayUrl: 'livePlayUrl',
      liveStatus: 'liveStatus',
      startTime: 'startTime',
      subscribeCount: 'subscribeCount',
      title: 'title',
      unionId: 'unionId',
      uv: 'uv',
    };
  }

  static types(): { [key: string]: any } {
    return {
      coverUrl: 'string',
      duration: 'number',
      endTime: 'number',
      introduction: 'string',
      liveId: 'string',
      livePlayUrl: 'string',
      liveStatus: 'number',
      startTime: 'number',
      subscribeCount: 'number',
      title: 'string',
      unionId: 'string',
      uv: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList extends $tea.Model {
  hasSubscribed?: GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListHasSubscribed;
  liveBasicInfo?: GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo;
  static names(): { [key: string]: string } {
    return {
      hasSubscribed: 'hasSubscribed',
      liveBasicInfo: 'liveBasicInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasSubscribed: GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListHasSubscribed,
      liveBasicInfo: GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserCreateLiveListResponseBodyResult extends $tea.Model {
  hasFinish?: boolean;
  liveInfoPopModelList?: GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList[];
  nextToken?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      hasFinish: 'hasFinish',
      liveInfoPopModelList: 'liveInfoPopModelList',
      nextToken: 'nextToken',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasFinish: 'boolean',
      liveInfoPopModelList: { 'type': 'array', 'itemType': GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList },
      nextToken: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListExtraInfo extends $tea.Model {
  hasSubscribed?: boolean;
  isForecastExpired?: boolean;
  watchProgressMs?: number;
  static names(): { [key: string]: string } {
    return {
      hasSubscribed: 'hasSubscribed',
      isForecastExpired: 'isForecastExpired',
      watchProgressMs: 'watchProgressMs',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasSubscribed: 'boolean',
      isForecastExpired: 'boolean',
      watchProgressMs: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo extends $tea.Model {
  coverUrl?: string;
  duration?: number;
  endTime?: number;
  introduction?: string;
  liveId?: string;
  livePlayUrl?: string;
  liveStatus?: number;
  startTime?: number;
  subscribeCount?: number;
  title?: string;
  unionId?: string;
  uv?: number;
  static names(): { [key: string]: string } {
    return {
      coverUrl: 'coverUrl',
      duration: 'duration',
      endTime: 'endTime',
      introduction: 'introduction',
      liveId: 'liveId',
      livePlayUrl: 'livePlayUrl',
      liveStatus: 'liveStatus',
      startTime: 'startTime',
      subscribeCount: 'subscribeCount',
      title: 'title',
      unionId: 'unionId',
      uv: 'uv',
    };
  }

  static types(): { [key: string]: any } {
    return {
      coverUrl: 'string',
      duration: 'number',
      endTime: 'number',
      introduction: 'string',
      liveId: 'string',
      livePlayUrl: 'string',
      liveStatus: 'number',
      startTime: 'number',
      subscribeCount: 'number',
      title: 'string',
      unionId: 'string',
      uv: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList extends $tea.Model {
  extraInfo?: GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListExtraInfo;
  liveBasicInfo?: GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo;
  static names(): { [key: string]: string } {
    return {
      extraInfo: 'extraInfo',
      liveBasicInfo: 'liveBasicInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extraInfo: GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListExtraInfo,
      liveBasicInfo: GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserWatchLiveListResponseBodyResult extends $tea.Model {
  hasFinish?: boolean;
  liveInfoPopModelList?: GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList[];
  nextToken?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      hasFinish: 'hasFinish',
      liveInfoPopModelList: 'liveInfoPopModelList',
      nextToken: 'nextToken',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasFinish: 'boolean',
      liveInfoPopModelList: { 'type': 'array', 'itemType': GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList },
      nextToken: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryLiveInfoResponseBodyResultLiveInfo extends $tea.Model {
  /**
   * @example
   * https://gw.alicdn.com/tfs/TB1thlYyAT2gK0jSZPcXXcKkpXa-1125-633.png
   */
  coverUrl?: string;
  /**
   * @example
   * 18450
   */
  duration?: number;
  /**
   * @example
   * 1659653648000
   */
  endTime?: number;
  /**
   * @example
   * 测试直播简介
   */
  introduction?: string;
  /**
   * @example
   * 1a353547-040d-4095-bb93-404bc5d47920
   */
  liveId?: string;
  /**
   * @example
   * https://h5.dingtalk.com/group-live-share/index.htm?type=2&liveFromType=6&liveUuid=1a353547-040d-4095-bb93-404bc5d47920&dd_nav_bgcolor=FF2C2D2F#/union
   */
  livePlayUrl?: string;
  /**
   * @example
   * 3
   */
  liveStatus?: number;
  /**
   * @example
   * 18430
   */
  playbackDuration?: number;
  /**
   * @example
   * 1659613648000
   */
  startTime?: number;
  /**
   * @example
   * 2
   */
  subscribeCount?: number;
  /**
   * @example
   * 测试直播
   */
  title?: string;
  /**
   * @example
   * DC7wZGOSueEEIGOf3WKwWgiEiE
   */
  unionId?: string;
  /**
   * @example
   * 3
   */
  uv?: number;
  static names(): { [key: string]: string } {
    return {
      coverUrl: 'coverUrl',
      duration: 'duration',
      endTime: 'endTime',
      introduction: 'introduction',
      liveId: 'liveId',
      livePlayUrl: 'livePlayUrl',
      liveStatus: 'liveStatus',
      playbackDuration: 'playbackDuration',
      startTime: 'startTime',
      subscribeCount: 'subscribeCount',
      title: 'title',
      unionId: 'unionId',
      uv: 'uv',
    };
  }

  static types(): { [key: string]: any } {
    return {
      coverUrl: 'string',
      duration: 'number',
      endTime: 'number',
      introduction: 'string',
      liveId: 'string',
      livePlayUrl: 'string',
      liveStatus: 'number',
      playbackDuration: 'number',
      startTime: 'number',
      subscribeCount: 'number',
      title: 'string',
      unionId: 'string',
      uv: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryLiveInfoResponseBodyResult extends $tea.Model {
  liveInfo?: QueryLiveInfoResponseBodyResultLiveInfo;
  static names(): { [key: string]: string } {
    return {
      liveInfo: 'liveInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      liveInfo: QueryLiveInfoResponseBodyResultLiveInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryLiveWatchDetailResponseBodyResult extends $tea.Model {
  /**
   * @example
   * 3560
   */
  avgWatchTime?: number;
  /**
   * @example
   * 55
   */
  liveUv?: number;
  /**
   * @example
   * 252
   */
  msgCount?: number;
  /**
   * @example
   * 72
   */
  playbackUv?: number;
  /**
   * @example
   * 500
   */
  praiseCount?: number;
  /**
   * @example
   * 120
   */
  pv?: number;
  /**
   * @example
   * 1903640
   */
  totalWatchTime?: number;
  /**
   * @example
   * 90
   */
  uv?: number;
  static names(): { [key: string]: string } {
    return {
      avgWatchTime: 'avgWatchTime',
      liveUv: 'liveUv',
      msgCount: 'msgCount',
      playbackUv: 'playbackUv',
      praiseCount: 'praiseCount',
      pv: 'pv',
      totalWatchTime: 'totalWatchTime',
      uv: 'uv',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avgWatchTime: 'number',
      liveUv: 'number',
      msgCount: 'number',
      playbackUv: 'number',
      praiseCount: 'number',
      pv: 'number',
      totalWatchTime: 'number',
      uv: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryLiveWatchUserListResponseBodyResultOrgUsesList extends $tea.Model {
  /**
   * @example
   * xxx.设计部
   */
  deptName?: string;
  /**
   * @example
   * 李四
   */
  name?: string;
  /**
   * @example
   * DC7wZGOSueEEIGOf3WKwWgiEiE
   */
  unionId?: string;
  /**
   * @example
   * 214675
   */
  userId?: string;
  /**
   * @example
   * 189930
   */
  watchLiveTime?: number;
  /**
   * @example
   * 23667
   */
  watchPlaybackTime?: number;
  /**
   * @example
   * 2330
   */
  watchProgressMs?: number;
  static names(): { [key: string]: string } {
    return {
      deptName: 'deptName',
      name: 'name',
      unionId: 'unionId',
      userId: 'userId',
      watchLiveTime: 'watchLiveTime',
      watchPlaybackTime: 'watchPlaybackTime',
      watchProgressMs: 'watchProgressMs',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptName: 'string',
      name: 'string',
      unionId: 'string',
      userId: 'string',
      watchLiveTime: 'number',
      watchPlaybackTime: 'number',
      watchProgressMs: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryLiveWatchUserListResponseBodyResultOutOrgUserList extends $tea.Model {
  /**
   * @example
   * 张三
   */
  name?: string;
  /**
   * @example
   * 23440
   */
  watchLiveTime?: number;
  /**
   * @example
   * 2330
   */
  watchPlaybackTime?: number;
  /**
   * @example
   * 150
   */
  watchProgressMs?: number;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      watchLiveTime: 'watchLiveTime',
      watchPlaybackTime: 'watchPlaybackTime',
      watchProgressMs: 'watchProgressMs',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      watchLiveTime: 'number',
      watchPlaybackTime: 'number',
      watchProgressMs: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryLiveWatchUserListResponseBodyResult extends $tea.Model {
  orgUsesList?: QueryLiveWatchUserListResponseBodyResultOrgUsesList[];
  outOrgUserList?: QueryLiveWatchUserListResponseBodyResultOutOrgUserList[];
  static names(): { [key: string]: string } {
    return {
      orgUsesList: 'orgUsesList',
      outOrgUserList: 'outOrgUserList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      orgUsesList: { 'type': 'array', 'itemType': QueryLiveWatchUserListResponseBodyResultOrgUsesList },
      outOrgUserList: { 'type': 'array', 'itemType': QueryLiveWatchUserListResponseBodyResultOutOrgUserList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySubscribeStatusRequestBody extends $tea.Model {
  liveIds?: string[];
  static names(): { [key: string]: string } {
    return {
      liveIds: 'liveIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      liveIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySubscribeStatusResponseBodyResultSubscribeStatusDTOS extends $tea.Model {
  liveId?: string;
  subscribe?: boolean;
  static names(): { [key: string]: string } {
    return {
      liveId: 'liveId',
      subscribe: 'subscribe',
    };
  }

  static types(): { [key: string]: any } {
    return {
      liveId: 'string',
      subscribe: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySubscribeStatusResponseBodyResult extends $tea.Model {
  subscribeStatusDTOS?: QuerySubscribeStatusResponseBodyResultSubscribeStatusDTOS[];
  static names(): { [key: string]: string } {
    return {
      subscribeStatusDTOS: 'subscribeStatusDTOS',
    };
  }

  static types(): { [key: string]: any } {
    return {
      subscribeStatusDTOS: { 'type': 'array', 'itemType': QuerySubscribeStatusResponseBodyResultSubscribeStatusDTOS },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SubscribeLiveResponseBodyResult extends $tea.Model {
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

export class UpdateLiveResponseBodyResult extends $tea.Model {
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
   * 添加云导播联播群列表
   * 
   * @param request - AddShareCidListRequest
   * @param headers - AddShareCidListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddShareCidListResponse
   */
  async addShareCidListWithOptions(feedId: string, request: AddShareCidListRequest, headers: AddShareCidListHeaders, runtime: $Util.RuntimeOptions): Promise<AddShareCidListResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.groupIdType)) {
      body["groupIdType"] = request.groupIdType;
    }

    if (!Util.isUnset(request.groupIds)) {
      body["groupIds"] = request.groupIds;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
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
      action: "AddShareCidList",
      version: "live_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/live/cloudFeeds/${feedId}/share`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<AddShareCidListResponse>(await this.execute(params, req, runtime), new AddShareCidListResponse({}));
  }

  /**
   * 添加云导播联播群列表
   * 
   * @param request - AddShareCidListRequest
   * @returns AddShareCidListResponse
   */
  async addShareCidList(feedId: string, request: AddShareCidListRequest): Promise<AddShareCidListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddShareCidListHeaders({ });
    return await this.addShareCidListWithOptions(feedId, request, headers, runtime);
  }

  /**
   * 创建云导播课程
   * 
   * @param request - CreateCloudFeedRequest
   * @param headers - CreateCloudFeedHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateCloudFeedResponse
   */
  async createCloudFeedWithOptions(request: CreateCloudFeedRequest, headers: CreateCloudFeedHeaders, runtime: $Util.RuntimeOptions): Promise<CreateCloudFeedResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.coverUrl)) {
      body["coverUrl"] = request.coverUrl;
    }

    if (!Util.isUnset(request.intro)) {
      body["intro"] = request.intro;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.videoUrl)) {
      body["videoUrl"] = request.videoUrl;
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
      action: "CreateCloudFeed",
      version: "live_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/live/cloudFeeds`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CreateCloudFeedResponse>(await this.execute(params, req, runtime), new CreateCloudFeedResponse({}));
  }

  /**
   * 创建云导播课程
   * 
   * @param request - CreateCloudFeedRequest
   * @returns CreateCloudFeedResponse
   */
  async createCloudFeed(request: CreateCloudFeedRequest): Promise<CreateCloudFeedResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateCloudFeedHeaders({ });
    return await this.createCloudFeedWithOptions(request, headers, runtime);
  }

  /**
   * 创建直播
   * 
   * @param request - CreateLiveRequest
   * @param headers - CreateLiveHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateLiveResponse
   */
  async createLiveWithOptions(request: CreateLiveRequest, headers: CreateLiveHeaders, runtime: $Util.RuntimeOptions): Promise<CreateLiveResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.coverUrl)) {
      body["coverUrl"] = request.coverUrl;
    }

    if (!Util.isUnset(request.introduction)) {
      body["introduction"] = request.introduction;
    }

    if (!Util.isUnset(request.preEndTime)) {
      body["preEndTime"] = request.preEndTime;
    }

    if (!Util.isUnset(request.preStartTime)) {
      body["preStartTime"] = request.preStartTime;
    }

    if (!Util.isUnset(request.publicType)) {
      body["publicType"] = request.publicType;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
      action: "CreateLive",
      version: "live_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/live/lives`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateLiveResponse>(await this.execute(params, req, runtime), new CreateLiveResponse({}));
  }

  /**
   * 创建直播
   * 
   * @param request - CreateLiveRequest
   * @returns CreateLiveResponse
   */
  async createLive(request: CreateLiveRequest): Promise<CreateLiveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateLiveHeaders({ });
    return await this.createLiveWithOptions(request, headers, runtime);
  }

  /**
   * 删除直播
   * 
   * @param request - DeleteLiveRequest
   * @param headers - DeleteLiveHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteLiveResponse
   */
  async deleteLiveWithOptions(request: DeleteLiveRequest, headers: DeleteLiveHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteLiveResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.liveId)) {
      query["liveId"] = request.liveId;
    }

    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
      action: "DeleteLive",
      version: "live_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/live/lives`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteLiveResponse>(await this.execute(params, req, runtime), new DeleteLiveResponse({}));
  }

  /**
   * 删除直播
   * 
   * @param request - DeleteLiveRequest
   * @returns DeleteLiveResponse
   */
  async deleteLive(request: DeleteLiveRequest): Promise<DeleteLiveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteLiveHeaders({ });
    return await this.deleteLiveWithOptions(request, headers, runtime);
  }

  /**
   * 删除直播培训课程
   * 
   * @param request - DeleteLiveFeedRequest
   * @param headers - DeleteLiveFeedHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteLiveFeedResponse
   */
  async deleteLiveFeedWithOptions(feedId: string, request: DeleteLiveFeedRequest, headers: DeleteLiveFeedHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteLiveFeedResponse> {
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
      action: "DeleteLiveFeed",
      version: "live_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/live/openFeeds/${feedId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<DeleteLiveFeedResponse>(await this.execute(params, req, runtime), new DeleteLiveFeedResponse({}));
  }

  /**
   * 删除直播培训课程
   * 
   * @param request - DeleteLiveFeedRequest
   * @returns DeleteLiveFeedResponse
   */
  async deleteLiveFeed(feedId: string, request: DeleteLiveFeedRequest): Promise<DeleteLiveFeedResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteLiveFeedHeaders({ });
    return await this.deleteLiveFeedWithOptions(feedId, request, headers, runtime);
  }

  /**
   * 剪辑直播课程的回放
   * 
   * @param request - EditFeedReplayRequest
   * @param headers - EditFeedReplayHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns EditFeedReplayResponse
   */
  async editFeedReplayWithOptions(feedId: string, request: EditFeedReplayRequest, headers: EditFeedReplayHeaders, runtime: $Util.RuntimeOptions): Promise<EditFeedReplayResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.editEndTime)) {
      body["editEndTime"] = request.editEndTime;
    }

    if (!Util.isUnset(request.editStartTime)) {
      body["editStartTime"] = request.editStartTime;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
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
      action: "EditFeedReplay",
      version: "live_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/live/openFeeds/${feedId}/cutReplay`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<EditFeedReplayResponse>(await this.execute(params, req, runtime), new EditFeedReplayResponse({}));
  }

  /**
   * 剪辑直播课程的回放
   * 
   * @param request - EditFeedReplayRequest
   * @returns EditFeedReplayResponse
   */
  async editFeedReplay(feedId: string, request: EditFeedReplayRequest): Promise<EditFeedReplayResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EditFeedReplayHeaders({ });
    return await this.editFeedReplayWithOptions(feedId, request, headers, runtime);
  }

  /**
   * 获取直播的可下载回放地址
   * 
   * @param request - GetLiveReplayUrlRequest
   * @param headers - GetLiveReplayUrlHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetLiveReplayUrlResponse
   */
  async getLiveReplayUrlWithOptions(request: GetLiveReplayUrlRequest, headers: GetLiveReplayUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetLiveReplayUrlResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.liveId)) {
      query["liveId"] = request.liveId;
    }

    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
      action: "GetLiveReplayUrl",
      version: "live_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/live/lives/replayUrls`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetLiveReplayUrlResponse>(await this.execute(params, req, runtime), new GetLiveReplayUrlResponse({}));
  }

  /**
   * 获取直播的可下载回放地址
   * 
   * @param request - GetLiveReplayUrlRequest
   * @returns GetLiveReplayUrlResponse
   */
  async getLiveReplayUrl(request: GetLiveReplayUrlRequest): Promise<GetLiveReplayUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetLiveReplayUrlHeaders({ });
    return await this.getLiveReplayUrlWithOptions(request, headers, runtime);
  }

  /**
   * 根据状态拉我相关的直播
   * 
   * @param request - GetUserAllLiveListRequest
   * @param headers - GetUserAllLiveListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetUserAllLiveListResponse
   */
  async getUserAllLiveListWithOptions(request: GetUserAllLiveListRequest, headers: GetUserAllLiveListHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserAllLiveListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.statuses)) {
      body["statuses"] = request.statuses;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
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
      action: "GetUserAllLiveList",
      version: "live_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/live/users/allLiveInfos/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetUserAllLiveListResponse>(await this.execute(params, req, runtime), new GetUserAllLiveListResponse({}));
  }

  /**
   * 根据状态拉我相关的直播
   * 
   * @param request - GetUserAllLiveListRequest
   * @returns GetUserAllLiveListResponse
   */
  async getUserAllLiveList(request: GetUserAllLiveListRequest): Promise<GetUserAllLiveListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserAllLiveListHeaders({ });
    return await this.getUserAllLiveListWithOptions(request, headers, runtime);
  }

  /**
   * 根据状态获取用户创建的直播
   * 
   * @param request - GetUserCreateLiveListRequest
   * @param headers - GetUserCreateLiveListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetUserCreateLiveListResponse
   */
  async getUserCreateLiveListWithOptions(request: GetUserCreateLiveListRequest, headers: GetUserCreateLiveListHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserCreateLiveListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.statuses)) {
      body["statuses"] = request.statuses;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
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
      action: "GetUserCreateLiveList",
      version: "live_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/live/users/createLiveInfos/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetUserCreateLiveListResponse>(await this.execute(params, req, runtime), new GetUserCreateLiveListResponse({}));
  }

  /**
   * 根据状态获取用户创建的直播
   * 
   * @param request - GetUserCreateLiveListRequest
   * @returns GetUserCreateLiveListResponse
   */
  async getUserCreateLiveList(request: GetUserCreateLiveListRequest): Promise<GetUserCreateLiveListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserCreateLiveListHeaders({ });
    return await this.getUserCreateLiveListWithOptions(request, headers, runtime);
  }

  /**
   * 获取用户观看直播记录
   * 
   * @param request - GetUserWatchLiveListRequest
   * @param headers - GetUserWatchLiveListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetUserWatchLiveListResponse
   */
  async getUserWatchLiveListWithOptions(request: GetUserWatchLiveListRequest, headers: GetUserWatchLiveListHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserWatchLiveListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.filterType)) {
      query["filterType"] = request.filterType;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
      action: "GetUserWatchLiveList",
      version: "live_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/live/users/watchRecords`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetUserWatchLiveListResponse>(await this.execute(params, req, runtime), new GetUserWatchLiveListResponse({}));
  }

  /**
   * 获取用户观看直播记录
   * 
   * @param request - GetUserWatchLiveListRequest
   * @returns GetUserWatchLiveListResponse
   */
  async getUserWatchLiveList(request: GetUserWatchLiveListRequest): Promise<GetUserWatchLiveListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserWatchLiveListHeaders({ });
    return await this.getUserWatchLiveListWithOptions(request, headers, runtime);
  }

  /**
   * 修改直播课程可见白名单
   * 
   * @param tmpReq - ModifyFeedWhiteListRequest
   * @param headers - ModifyFeedWhiteListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ModifyFeedWhiteListResponse
   */
  async modifyFeedWhiteListWithOptions(feedId: string, tmpReq: ModifyFeedWhiteListRequest, headers: ModifyFeedWhiteListHeaders, runtime: $Util.RuntimeOptions): Promise<ModifyFeedWhiteListResponse> {
    Util.validateModel(tmpReq);
    let request = new ModifyFeedWhiteListShrinkRequest({ });
    OpenApiUtil.convert(tmpReq, request);
    if (!Util.isUnset(tmpReq.modifyUserList)) {
      request.modifyUserListShrink = OpenApiUtil.arrayToStringWithSpecifiedStyle(tmpReq.modifyUserList, "modifyUserList", "json");
    }

    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.action)) {
      query["action"] = request.action;
    }

    if (!Util.isUnset(request.modifyUserListShrink)) {
      query["modifyUserList"] = request.modifyUserListShrink;
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
      action: "ModifyFeedWhiteList",
      version: "live_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/live/openFeeds/${feedId}/whiteList`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ModifyFeedWhiteListResponse>(await this.execute(params, req, runtime), new ModifyFeedWhiteListResponse({}));
  }

  /**
   * 修改直播课程可见白名单
   * 
   * @param request - ModifyFeedWhiteListRequest
   * @returns ModifyFeedWhiteListResponse
   */
  async modifyFeedWhiteList(feedId: string, request: ModifyFeedWhiteListRequest): Promise<ModifyFeedWhiteListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ModifyFeedWhiteListHeaders({ });
    return await this.modifyFeedWhiteListWithOptions(feedId, request, headers, runtime);
  }

  /**
   * 查询直播课程的观看白名单
   * 
   * @param request - QueryFeedWhiteListRequest
   * @param headers - QueryFeedWhiteListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryFeedWhiteListResponse
   */
  async queryFeedWhiteListWithOptions(feedId: string, request: QueryFeedWhiteListRequest, headers: QueryFeedWhiteListHeaders, runtime: $Util.RuntimeOptions): Promise<QueryFeedWhiteListResponse> {
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
      action: "QueryFeedWhiteList",
      version: "live_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/live/openFeeds/${feedId}/whiteList`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryFeedWhiteListResponse>(await this.execute(params, req, runtime), new QueryFeedWhiteListResponse({}));
  }

  /**
   * 查询直播课程的观看白名单
   * 
   * @param request - QueryFeedWhiteListRequest
   * @returns QueryFeedWhiteListResponse
   */
  async queryFeedWhiteList(feedId: string, request: QueryFeedWhiteListRequest): Promise<QueryFeedWhiteListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryFeedWhiteListHeaders({ });
    return await this.queryFeedWhiteListWithOptions(feedId, request, headers, runtime);
  }

  /**
   * 查询直播详情
   * 
   * @param request - QueryLiveInfoRequest
   * @param headers - QueryLiveInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryLiveInfoResponse
   */
  async queryLiveInfoWithOptions(request: QueryLiveInfoRequest, headers: QueryLiveInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryLiveInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.liveId)) {
      query["liveId"] = request.liveId;
    }

    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
      action: "QueryLiveInfo",
      version: "live_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/live/lives`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryLiveInfoResponse>(await this.execute(params, req, runtime), new QueryLiveInfoResponse({}));
  }

  /**
   * 查询直播详情
   * 
   * @param request - QueryLiveInfoRequest
   * @returns QueryLiveInfoResponse
   */
  async queryLiveInfo(request: QueryLiveInfoRequest): Promise<QueryLiveInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryLiveInfoHeaders({ });
    return await this.queryLiveInfoWithOptions(request, headers, runtime);
  }

  /**
   * 获取直播的观看数据
   * 
   * @param request - QueryLiveWatchDetailRequest
   * @param headers - QueryLiveWatchDetailHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryLiveWatchDetailResponse
   */
  async queryLiveWatchDetailWithOptions(request: QueryLiveWatchDetailRequest, headers: QueryLiveWatchDetailHeaders, runtime: $Util.RuntimeOptions): Promise<QueryLiveWatchDetailResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.liveId)) {
      query["liveId"] = request.liveId;
    }

    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
      action: "QueryLiveWatchDetail",
      version: "live_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/live/lives/watchDetails`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryLiveWatchDetailResponse>(await this.execute(params, req, runtime), new QueryLiveWatchDetailResponse({}));
  }

  /**
   * 获取直播的观看数据
   * 
   * @param request - QueryLiveWatchDetailRequest
   * @returns QueryLiveWatchDetailResponse
   */
  async queryLiveWatchDetail(request: QueryLiveWatchDetailRequest): Promise<QueryLiveWatchDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryLiveWatchDetailHeaders({ });
    return await this.queryLiveWatchDetailWithOptions(request, headers, runtime);
  }

  /**
   * 获取直播观看用户列表
   * 
   * @param request - QueryLiveWatchUserListRequest
   * @param headers - QueryLiveWatchUserListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryLiveWatchUserListResponse
   */
  async queryLiveWatchUserListWithOptions(request: QueryLiveWatchUserListRequest, headers: QueryLiveWatchUserListHeaders, runtime: $Util.RuntimeOptions): Promise<QueryLiveWatchUserListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.liveId)) {
      query["liveId"] = request.liveId;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
      action: "QueryLiveWatchUserList",
      version: "live_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/live/lives/watchUsers`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryLiveWatchUserListResponse>(await this.execute(params, req, runtime), new QueryLiveWatchUserListResponse({}));
  }

  /**
   * 获取直播观看用户列表
   * 
   * @param request - QueryLiveWatchUserListRequest
   * @returns QueryLiveWatchUserListResponse
   */
  async queryLiveWatchUserList(request: QueryLiveWatchUserListRequest): Promise<QueryLiveWatchUserListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryLiveWatchUserListHeaders({ });
    return await this.queryLiveWatchUserListWithOptions(request, headers, runtime);
  }

  /**
   * 批量查询直播是否订阅
   * 
   * @param tmpReq - QuerySubscribeStatusRequest
   * @param headers - QuerySubscribeStatusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QuerySubscribeStatusResponse
   */
  async querySubscribeStatusWithOptions(tmpReq: QuerySubscribeStatusRequest, headers: QuerySubscribeStatusHeaders, runtime: $Util.RuntimeOptions): Promise<QuerySubscribeStatusResponse> {
    Util.validateModel(tmpReq);
    let request = new QuerySubscribeStatusShrinkRequest({ });
    OpenApiUtil.convert(tmpReq, request);
    if (!Util.isUnset(tmpReq.body)) {
      request.bodyShrink = OpenApiUtil.arrayToStringWithSpecifiedStyle(tmpReq.body, "body", "json");
    }

    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bodyShrink)) {
      query["body"] = request.bodyShrink;
    }

    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
      action: "QuerySubscribeStatus",
      version: "live_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/live/subscribeStatuses/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QuerySubscribeStatusResponse>(await this.execute(params, req, runtime), new QuerySubscribeStatusResponse({}));
  }

  /**
   * 批量查询直播是否订阅
   * 
   * @param request - QuerySubscribeStatusRequest
   * @returns QuerySubscribeStatusResponse
   */
  async querySubscribeStatus(request: QuerySubscribeStatusRequest): Promise<QuerySubscribeStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QuerySubscribeStatusHeaders({ });
    return await this.querySubscribeStatusWithOptions(request, headers, runtime);
  }

  /**
   * 开始一场云导播
   * 
   * @param request - StartCloudFeedRequest
   * @param headers - StartCloudFeedHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns StartCloudFeedResponse
   */
  async startCloudFeedWithOptions(feedId: string, request: StartCloudFeedRequest, headers: StartCloudFeedHeaders, runtime: $Util.RuntimeOptions): Promise<StartCloudFeedResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
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
      action: "StartCloudFeed",
      version: "live_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/live/cloudFeeds/${feedId}/start`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<StartCloudFeedResponse>(await this.execute(params, req, runtime), new StartCloudFeedResponse({}));
  }

  /**
   * 开始一场云导播
   * 
   * @param request - StartCloudFeedRequest
   * @returns StartCloudFeedResponse
   */
  async startCloudFeed(feedId: string, request: StartCloudFeedRequest): Promise<StartCloudFeedResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StartCloudFeedHeaders({ });
    return await this.startCloudFeedWithOptions(feedId, request, headers, runtime);
  }

  /**
   * 结束一场云导播
   * 
   * @param request - StopCloudFeedRequest
   * @param headers - StopCloudFeedHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns StopCloudFeedResponse
   */
  async stopCloudFeedWithOptions(feedId: string, request: StopCloudFeedRequest, headers: StopCloudFeedHeaders, runtime: $Util.RuntimeOptions): Promise<StopCloudFeedResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
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
      action: "StopCloudFeed",
      version: "live_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/live/cloudFeeds/${feedId}/stop`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<StopCloudFeedResponse>(await this.execute(params, req, runtime), new StopCloudFeedResponse({}));
  }

  /**
   * 结束一场云导播
   * 
   * @param request - StopCloudFeedRequest
   * @returns StopCloudFeedResponse
   */
  async stopCloudFeed(feedId: string, request: StopCloudFeedRequest): Promise<StopCloudFeedResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StopCloudFeedHeaders({ });
    return await this.stopCloudFeedWithOptions(feedId, request, headers, runtime);
  }

  /**
   * 预约直播
   * 
   * @param request - SubscribeLiveRequest
   * @param headers - SubscribeLiveHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SubscribeLiveResponse
   */
  async subscribeLiveWithOptions(request: SubscribeLiveRequest, headers: SubscribeLiveHeaders, runtime: $Util.RuntimeOptions): Promise<SubscribeLiveResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.liveId)) {
      query["liveId"] = request.liveId;
    }

    if (!Util.isUnset(request.subscribe)) {
      query["subscribe"] = request.subscribe;
    }

    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
      action: "SubscribeLive",
      version: "live_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/live/lives/subscribe`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SubscribeLiveResponse>(await this.execute(params, req, runtime), new SubscribeLiveResponse({}));
  }

  /**
   * 预约直播
   * 
   * @param request - SubscribeLiveRequest
   * @returns SubscribeLiveResponse
   */
  async subscribeLive(request: SubscribeLiveRequest): Promise<SubscribeLiveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SubscribeLiveHeaders({ });
    return await this.subscribeLiveWithOptions(request, headers, runtime);
  }

  /**
   * 修改直播
   * 
   * @param request - UpdateLiveRequest
   * @param headers - UpdateLiveHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateLiveResponse
   */
  async updateLiveWithOptions(request: UpdateLiveRequest, headers: UpdateLiveHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateLiveResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.coverUrl)) {
      body["coverUrl"] = request.coverUrl;
    }

    if (!Util.isUnset(request.introduction)) {
      body["introduction"] = request.introduction;
    }

    if (!Util.isUnset(request.liveId)) {
      body["liveId"] = request.liveId;
    }

    if (!Util.isUnset(request.preEndTime)) {
      body["preEndTime"] = request.preEndTime;
    }

    if (!Util.isUnset(request.preStartTime)) {
      body["preStartTime"] = request.preStartTime;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
      action: "UpdateLive",
      version: "live_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/live/lives`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateLiveResponse>(await this.execute(params, req, runtime), new UpdateLiveResponse({}));
  }

  /**
   * 修改直播
   * 
   * @param request - UpdateLiveRequest
   * @returns UpdateLiveResponse
   */
  async updateLive(request: UpdateLiveRequest): Promise<UpdateLiveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateLiveHeaders({ });
    return await this.updateLiveWithOptions(request, headers, runtime);
  }

  /**
   * 修改培训课程信息
   * 
   * @param request - UpdateLiveFeedRequest
   * @param headers - UpdateLiveFeedHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateLiveFeedResponse
   */
  async updateLiveFeedWithOptions(feedId: string, request: UpdateLiveFeedRequest, headers: UpdateLiveFeedHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateLiveFeedResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.coverUrl)) {
      query["coverUrl"] = request.coverUrl;
    }

    if (!Util.isUnset(request.introduction)) {
      query["introduction"] = request.introduction;
    }

    if (!Util.isUnset(request.startTime)) {
      query["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.title)) {
      query["title"] = request.title;
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
      action: "UpdateLiveFeed",
      version: "live_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/live/openFeeds/${feedId}`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UpdateLiveFeedResponse>(await this.execute(params, req, runtime), new UpdateLiveFeedResponse({}));
  }

  /**
   * 修改培训课程信息
   * 
   * @param request - UpdateLiveFeedRequest
   * @returns UpdateLiveFeedResponse
   */
  async updateLiveFeed(feedId: string, request: UpdateLiveFeedRequest): Promise<UpdateLiveFeedResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateLiveFeedHeaders({ });
    return await this.updateLiveFeedWithOptions(feedId, request, headers, runtime);
  }

}
