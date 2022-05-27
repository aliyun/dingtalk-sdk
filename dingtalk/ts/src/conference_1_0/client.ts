// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class CloseVideoConferenceHeaders extends $tea.Model {
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

export class CloseVideoConferenceRequest extends $tea.Model {
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CloseVideoConferenceResponseBody extends $tea.Model {
  cause?: string;
  code?: number;
  static names(): { [key: string]: string } {
    return {
      cause: 'cause',
      code: 'code',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cause: 'string',
      code: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CloseVideoConferenceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CloseVideoConferenceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CloseVideoConferenceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateVideoConferenceHeaders extends $tea.Model {
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

export class CreateVideoConferenceRequest extends $tea.Model {
  confTitle?: string;
  inviteCaller?: boolean;
  inviteUserIds?: string[];
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      confTitle: 'confTitle',
      inviteCaller: 'inviteCaller',
      inviteUserIds: 'inviteUserIds',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      confTitle: 'string',
      inviteCaller: 'boolean',
      inviteUserIds: { 'type': 'array', 'itemType': 'string' },
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateVideoConferenceResponseBody extends $tea.Model {
  conferenceId?: string;
  conferencePassword?: string;
  externalLinkUrl?: string;
  hostPassword?: string;
  phoneNumbers?: string[];
  static names(): { [key: string]: string } {
    return {
      conferenceId: 'conferenceId',
      conferencePassword: 'conferencePassword',
      externalLinkUrl: 'externalLinkUrl',
      hostPassword: 'hostPassword',
      phoneNumbers: 'phoneNumbers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conferenceId: 'string',
      conferencePassword: 'string',
      externalLinkUrl: 'string',
      hostPassword: 'string',
      phoneNumbers: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateVideoConferenceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateVideoConferenceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateVideoConferenceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCloudRecordTextHeaders extends $tea.Model {
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

export class QueryCloudRecordTextRequest extends $tea.Model {
  direction?: string;
  maxResults?: number;
  nextToken?: number;
  startTime?: number;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      direction: 'direction',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      startTime: 'startTime',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      direction: 'string',
      maxResults: 'number',
      nextToken: 'number',
      startTime: 'number',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCloudRecordTextResponseBody extends $tea.Model {
  hasMore?: boolean;
  paragraphList?: QueryCloudRecordTextResponseBodyParagraphList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      paragraphList: 'paragraphList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      paragraphList: { 'type': 'array', 'itemType': QueryCloudRecordTextResponseBodyParagraphList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCloudRecordTextResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryCloudRecordTextResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryCloudRecordTextResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCloudRecordVideoHeaders extends $tea.Model {
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

export class QueryCloudRecordVideoRequest extends $tea.Model {
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCloudRecordVideoResponseBody extends $tea.Model {
  videoList?: QueryCloudRecordVideoResponseBodyVideoList[];
  static names(): { [key: string]: string } {
    return {
      videoList: 'videoList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      videoList: { 'type': 'array', 'itemType': QueryCloudRecordVideoResponseBodyVideoList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCloudRecordVideoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryCloudRecordVideoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryCloudRecordVideoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCloudRecordVideoPlayInfoHeaders extends $tea.Model {
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

export class QueryCloudRecordVideoPlayInfoRequest extends $tea.Model {
  mediaId?: string;
  regionId?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      mediaId: 'mediaId',
      regionId: 'regionId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mediaId: 'string',
      regionId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCloudRecordVideoPlayInfoResponseBody extends $tea.Model {
  duration?: number;
  fileSize?: number;
  mp4FileUrl?: string;
  playUrl?: string;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      duration: 'duration',
      fileSize: 'fileSize',
      mp4FileUrl: 'mp4FileUrl',
      playUrl: 'playUrl',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      duration: 'number',
      fileSize: 'number',
      mp4FileUrl: 'string',
      playUrl: 'string',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCloudRecordVideoPlayInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryCloudRecordVideoPlayInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryCloudRecordVideoPlayInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConferenceInfoBatchHeaders extends $tea.Model {
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

export class QueryConferenceInfoBatchRequest extends $tea.Model {
  conferenceIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      conferenceIdList: 'conferenceIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conferenceIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConferenceInfoBatchResponseBody extends $tea.Model {
  infos?: QueryConferenceInfoBatchResponseBodyInfos[];
  static names(): { [key: string]: string } {
    return {
      infos: 'infos',
    };
  }

  static types(): { [key: string]: any } {
    return {
      infos: { 'type': 'array', 'itemType': QueryConferenceInfoBatchResponseBodyInfos },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConferenceInfoBatchResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryConferenceInfoBatchResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryConferenceInfoBatchResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCloudRecordHeaders extends $tea.Model {
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

export class StartCloudRecordRequest extends $tea.Model {
  mode?: string;
  smallWindowPosition?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      mode: 'mode',
      smallWindowPosition: 'smallWindowPosition',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mode: 'string',
      smallWindowPosition: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCloudRecordResponseBody extends $tea.Model {
  code?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCloudRecordResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: StartCloudRecordResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: StartCloudRecordResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartStreamOutHeaders extends $tea.Model {
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

export class StartStreamOutRequest extends $tea.Model {
  mode?: string;
  needHostJoin?: boolean;
  smallWindowPosition?: string;
  streamName?: string;
  streamUrlList?: string[];
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      mode: 'mode',
      needHostJoin: 'needHostJoin',
      smallWindowPosition: 'smallWindowPosition',
      streamName: 'streamName',
      streamUrlList: 'streamUrlList',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mode: 'string',
      needHostJoin: 'boolean',
      smallWindowPosition: 'string',
      streamName: 'string',
      streamUrlList: { 'type': 'array', 'itemType': 'string' },
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartStreamOutResponseBody extends $tea.Model {
  failStreamMap?: { [key: string]: any };
  successStreamMap?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      failStreamMap: 'failStreamMap',
      successStreamMap: 'successStreamMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      failStreamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      successStreamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartStreamOutResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: StartStreamOutResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: StartStreamOutResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StopCloudRecordHeaders extends $tea.Model {
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

export class StopCloudRecordRequest extends $tea.Model {
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StopCloudRecordResponseBody extends $tea.Model {
  code?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StopCloudRecordResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: StopCloudRecordResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: StopCloudRecordResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StopStreamOutHeaders extends $tea.Model {
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

export class StopStreamOutRequest extends $tea.Model {
  stopAllStream?: boolean;
  streamId?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      stopAllStream: 'stopAllStream',
      streamId: 'streamId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      stopAllStream: 'boolean',
      streamId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StopStreamOutResponseBody extends $tea.Model {
  code?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StopStreamOutResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: StopStreamOutResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: StopStreamOutResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateVideoConferenceExtInfoHeaders extends $tea.Model {
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

export class UpdateVideoConferenceExtInfoResponseBody extends $tea.Model {
  case?: string;
  code?: string;
  static names(): { [key: string]: string } {
    return {
      case: 'case',
      code: 'code',
    };
  }

  static types(): { [key: string]: any } {
    return {
      case: 'string',
      code: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateVideoConferenceExtInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateVideoConferenceExtInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateVideoConferenceExtInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateVideoConferenceSettingHeaders extends $tea.Model {
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

export class UpdateVideoConferenceSettingRequest extends $tea.Model {
  allowUnmuteSelf?: boolean;
  autoTransferHost?: boolean;
  forbiddenShareScreen?: boolean;
  lockConference?: boolean;
  muteAll?: boolean;
  onlyInternalEmployeesJoin?: boolean;
  static names(): { [key: string]: string } {
    return {
      allowUnmuteSelf: 'allowUnmuteSelf',
      autoTransferHost: 'autoTransferHost',
      forbiddenShareScreen: 'forbiddenShareScreen',
      lockConference: 'lockConference',
      muteAll: 'muteAll',
      onlyInternalEmployeesJoin: 'onlyInternalEmployeesJoin',
    };
  }

  static types(): { [key: string]: any } {
    return {
      allowUnmuteSelf: 'boolean',
      autoTransferHost: 'boolean',
      forbiddenShareScreen: 'boolean',
      lockConference: 'boolean',
      muteAll: 'boolean',
      onlyInternalEmployeesJoin: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateVideoConferenceSettingResponseBody extends $tea.Model {
  case?: string;
  code?: string;
  static names(): { [key: string]: string } {
    return {
      case: 'case',
      code: 'code',
    };
  }

  static types(): { [key: string]: any } {
    return {
      case: 'string',
      code: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateVideoConferenceSettingResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateVideoConferenceSettingResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateVideoConferenceSettingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList extends $tea.Model {
  endTime?: number;
  startTime?: number;
  word?: string;
  wordId?: string;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      startTime: 'startTime',
      word: 'word',
      wordId: 'wordId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      startTime: 'number',
      word: 'string',
      wordId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCloudRecordTextResponseBodyParagraphListSentenceList extends $tea.Model {
  endTime?: number;
  sentence?: string;
  startTime?: number;
  unionId?: string;
  wordList?: QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList[];
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      sentence: 'sentence',
      startTime: 'startTime',
      unionId: 'unionId',
      wordList: 'wordList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      sentence: 'string',
      startTime: 'number',
      unionId: 'string',
      wordList: { 'type': 'array', 'itemType': QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCloudRecordTextResponseBodyParagraphList extends $tea.Model {
  endTime?: number;
  nextTtoken?: number;
  nickName?: string;
  paragraph?: string;
  recordId?: number;
  sentenceList?: QueryCloudRecordTextResponseBodyParagraphListSentenceList[];
  startTime?: number;
  status?: number;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      nextTtoken: 'nextTtoken',
      nickName: 'nickName',
      paragraph: 'paragraph',
      recordId: 'recordId',
      sentenceList: 'sentenceList',
      startTime: 'startTime',
      status: 'status',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      nextTtoken: 'number',
      nickName: 'string',
      paragraph: 'string',
      recordId: 'number',
      sentenceList: { 'type': 'array', 'itemType': QueryCloudRecordTextResponseBodyParagraphListSentenceList },
      startTime: 'number',
      status: 'number',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCloudRecordVideoResponseBodyVideoList extends $tea.Model {
  duration?: number;
  endTime?: number;
  fileSize?: number;
  mediaId?: string;
  recordId?: string;
  recordType?: number;
  regionId?: string;
  startTime?: number;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      duration: 'duration',
      endTime: 'endTime',
      fileSize: 'fileSize',
      mediaId: 'mediaId',
      recordId: 'recordId',
      recordType: 'recordType',
      regionId: 'regionId',
      startTime: 'startTime',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      duration: 'number',
      endTime: 'number',
      fileSize: 'number',
      mediaId: 'string',
      recordId: 'string',
      recordType: 'number',
      regionId: 'string',
      startTime: 'number',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConferenceInfoBatchResponseBodyInfosUserList extends $tea.Model {
  attendStatus?: number;
  cameraStatus?: number;
  micStatus?: number;
  nick?: string;
  rejectDescription?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      attendStatus: 'attendStatus',
      cameraStatus: 'cameraStatus',
      micStatus: 'micStatus',
      nick: 'nick',
      rejectDescription: 'rejectDescription',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendStatus: 'number',
      cameraStatus: 'number',
      micStatus: 'number',
      nick: 'string',
      rejectDescription: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConferenceInfoBatchResponseBodyInfos extends $tea.Model {
  conferenceId?: string;
  mediaStatus?: number;
  startTime?: number;
  status?: number;
  title?: string;
  userList?: QueryConferenceInfoBatchResponseBodyInfosUserList[];
  static names(): { [key: string]: string } {
    return {
      conferenceId: 'conferenceId',
      mediaStatus: 'mediaStatus',
      startTime: 'startTime',
      status: 'status',
      title: 'title',
      userList: 'userList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conferenceId: 'string',
      mediaStatus: 'number',
      startTime: 'number',
      status: 'number',
      title: 'string',
      userList: { 'type': 'array', 'itemType': QueryConferenceInfoBatchResponseBodyInfosUserList },
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


  async closeVideoConference(conferenceId: string, request: CloseVideoConferenceRequest): Promise<CloseVideoConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CloseVideoConferenceHeaders({ });
    return await this.closeVideoConferenceWithOptions(conferenceId, request, headers, runtime);
  }

  async closeVideoConferenceWithOptions(conferenceId: string, request: CloseVideoConferenceRequest, headers: CloseVideoConferenceHeaders, runtime: $Util.RuntimeOptions): Promise<CloseVideoConferenceResponse> {
    Util.validateModel(request);
    conferenceId = OpenApiUtil.getEncodeParam(conferenceId);
    let query : {[key: string ]: any} = { };
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
    return $tea.cast<CloseVideoConferenceResponse>(await this.doROARequest("CloseVideoConference", "conference_1.0", "HTTP", "DELETE", "AK", `/v1.0/conference/videoConferences/${conferenceId}`, "json", req, runtime), new CloseVideoConferenceResponse({}));
  }

  async createVideoConference(request: CreateVideoConferenceRequest): Promise<CreateVideoConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateVideoConferenceHeaders({ });
    return await this.createVideoConferenceWithOptions(request, headers, runtime);
  }

  async createVideoConferenceWithOptions(request: CreateVideoConferenceRequest, headers: CreateVideoConferenceHeaders, runtime: $Util.RuntimeOptions): Promise<CreateVideoConferenceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.confTitle)) {
      body["confTitle"] = request.confTitle;
    }

    if (!Util.isUnset(request.inviteCaller)) {
      body["inviteCaller"] = request.inviteCaller;
    }

    if (!Util.isUnset(request.inviteUserIds)) {
      body["inviteUserIds"] = request.inviteUserIds;
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
    return $tea.cast<CreateVideoConferenceResponse>(await this.doROARequest("CreateVideoConference", "conference_1.0", "HTTP", "POST", "AK", `/v1.0/conference/videoConferences`, "json", req, runtime), new CreateVideoConferenceResponse({}));
  }

  async queryCloudRecordText(conferenceId: string, request: QueryCloudRecordTextRequest): Promise<QueryCloudRecordTextResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCloudRecordTextHeaders({ });
    return await this.queryCloudRecordTextWithOptions(conferenceId, request, headers, runtime);
  }

  async queryCloudRecordTextWithOptions(conferenceId: string, request: QueryCloudRecordTextRequest, headers: QueryCloudRecordTextHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCloudRecordTextResponse> {
    Util.validateModel(request);
    conferenceId = OpenApiUtil.getEncodeParam(conferenceId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.direction)) {
      query["direction"] = request.direction;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.startTime)) {
      query["startTime"] = request.startTime;
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
    return $tea.cast<QueryCloudRecordTextResponse>(await this.doROARequest("QueryCloudRecordText", "conference_1.0", "HTTP", "GET", "AK", `/v1.0/conference/videoConferences/${conferenceId}/cloudRecords/getTexts`, "json", req, runtime), new QueryCloudRecordTextResponse({}));
  }

  async queryCloudRecordVideo(conferenceId: string, request: QueryCloudRecordVideoRequest): Promise<QueryCloudRecordVideoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCloudRecordVideoHeaders({ });
    return await this.queryCloudRecordVideoWithOptions(conferenceId, request, headers, runtime);
  }

  async queryCloudRecordVideoWithOptions(conferenceId: string, request: QueryCloudRecordVideoRequest, headers: QueryCloudRecordVideoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCloudRecordVideoResponse> {
    Util.validateModel(request);
    conferenceId = OpenApiUtil.getEncodeParam(conferenceId);
    let query : {[key: string ]: any} = { };
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
    return $tea.cast<QueryCloudRecordVideoResponse>(await this.doROARequest("QueryCloudRecordVideo", "conference_1.0", "HTTP", "GET", "AK", `/v1.0/conference/videoConferences/${conferenceId}/cloudRecords/getVideos`, "json", req, runtime), new QueryCloudRecordVideoResponse({}));
  }

  async queryCloudRecordVideoPlayInfo(conferenceId: string, request: QueryCloudRecordVideoPlayInfoRequest): Promise<QueryCloudRecordVideoPlayInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCloudRecordVideoPlayInfoHeaders({ });
    return await this.queryCloudRecordVideoPlayInfoWithOptions(conferenceId, request, headers, runtime);
  }

  async queryCloudRecordVideoPlayInfoWithOptions(conferenceId: string, request: QueryCloudRecordVideoPlayInfoRequest, headers: QueryCloudRecordVideoPlayInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCloudRecordVideoPlayInfoResponse> {
    Util.validateModel(request);
    conferenceId = OpenApiUtil.getEncodeParam(conferenceId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.mediaId)) {
      query["mediaId"] = request.mediaId;
    }

    if (!Util.isUnset(request.regionId)) {
      query["regionId"] = request.regionId;
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
    return $tea.cast<QueryCloudRecordVideoPlayInfoResponse>(await this.doROARequest("QueryCloudRecordVideoPlayInfo", "conference_1.0", "HTTP", "GET", "AK", `/v1.0/conference/videoConferences/${conferenceId}/cloudRecords/videos/getPlayInfos`, "json", req, runtime), new QueryCloudRecordVideoPlayInfoResponse({}));
  }

  async queryConferenceInfoBatch(request: QueryConferenceInfoBatchRequest): Promise<QueryConferenceInfoBatchResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryConferenceInfoBatchHeaders({ });
    return await this.queryConferenceInfoBatchWithOptions(request, headers, runtime);
  }

  async queryConferenceInfoBatchWithOptions(request: QueryConferenceInfoBatchRequest, headers: QueryConferenceInfoBatchHeaders, runtime: $Util.RuntimeOptions): Promise<QueryConferenceInfoBatchResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.conferenceIdList)) {
      body["conferenceIdList"] = request.conferenceIdList;
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
    return $tea.cast<QueryConferenceInfoBatchResponse>(await this.doROARequest("QueryConferenceInfoBatch", "conference_1.0", "HTTP", "POST", "AK", `/v1.0/conference/videoConferences/query`, "json", req, runtime), new QueryConferenceInfoBatchResponse({}));
  }

  async startCloudRecord(conferenceId: string, request: StartCloudRecordRequest): Promise<StartCloudRecordResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StartCloudRecordHeaders({ });
    return await this.startCloudRecordWithOptions(conferenceId, request, headers, runtime);
  }

  async startCloudRecordWithOptions(conferenceId: string, request: StartCloudRecordRequest, headers: StartCloudRecordHeaders, runtime: $Util.RuntimeOptions): Promise<StartCloudRecordResponse> {
    Util.validateModel(request);
    conferenceId = OpenApiUtil.getEncodeParam(conferenceId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.mode)) {
      body["mode"] = request.mode;
    }

    if (!Util.isUnset(request.smallWindowPosition)) {
      body["smallWindowPosition"] = request.smallWindowPosition;
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
    return $tea.cast<StartCloudRecordResponse>(await this.doROARequest("StartCloudRecord", "conference_1.0", "HTTP", "POST", "AK", `/v1.0/conference/videoConferences/${conferenceId}/cloudRecords/start`, "json", req, runtime), new StartCloudRecordResponse({}));
  }

  async startStreamOut(conferenceId: string, request: StartStreamOutRequest): Promise<StartStreamOutResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StartStreamOutHeaders({ });
    return await this.startStreamOutWithOptions(conferenceId, request, headers, runtime);
  }

  async startStreamOutWithOptions(conferenceId: string, request: StartStreamOutRequest, headers: StartStreamOutHeaders, runtime: $Util.RuntimeOptions): Promise<StartStreamOutResponse> {
    Util.validateModel(request);
    conferenceId = OpenApiUtil.getEncodeParam(conferenceId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.mode)) {
      body["mode"] = request.mode;
    }

    if (!Util.isUnset(request.needHostJoin)) {
      body["needHostJoin"] = request.needHostJoin;
    }

    if (!Util.isUnset(request.smallWindowPosition)) {
      body["smallWindowPosition"] = request.smallWindowPosition;
    }

    if (!Util.isUnset(request.streamName)) {
      body["streamName"] = request.streamName;
    }

    if (!Util.isUnset(request.streamUrlList)) {
      body["streamUrlList"] = request.streamUrlList;
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
    return $tea.cast<StartStreamOutResponse>(await this.doROARequest("StartStreamOut", "conference_1.0", "HTTP", "POST", "AK", `/v1.0/conference/videoConferences/${conferenceId}/streamOuts/start`, "json", req, runtime), new StartStreamOutResponse({}));
  }

  async stopCloudRecord(conferenceId: string, request: StopCloudRecordRequest): Promise<StopCloudRecordResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StopCloudRecordHeaders({ });
    return await this.stopCloudRecordWithOptions(conferenceId, request, headers, runtime);
  }

  async stopCloudRecordWithOptions(conferenceId: string, request: StopCloudRecordRequest, headers: StopCloudRecordHeaders, runtime: $Util.RuntimeOptions): Promise<StopCloudRecordResponse> {
    Util.validateModel(request);
    conferenceId = OpenApiUtil.getEncodeParam(conferenceId);
    let body : {[key: string ]: any} = { };
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
    return $tea.cast<StopCloudRecordResponse>(await this.doROARequest("StopCloudRecord", "conference_1.0", "HTTP", "POST", "AK", `/v1.0/conference/videoConferences/${conferenceId}/cloudRecords/stop`, "json", req, runtime), new StopCloudRecordResponse({}));
  }

  async stopStreamOut(conferenceId: string, request: StopStreamOutRequest): Promise<StopStreamOutResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StopStreamOutHeaders({ });
    return await this.stopStreamOutWithOptions(conferenceId, request, headers, runtime);
  }

  async stopStreamOutWithOptions(conferenceId: string, request: StopStreamOutRequest, headers: StopStreamOutHeaders, runtime: $Util.RuntimeOptions): Promise<StopStreamOutResponse> {
    Util.validateModel(request);
    conferenceId = OpenApiUtil.getEncodeParam(conferenceId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.stopAllStream)) {
      body["stopAllStream"] = request.stopAllStream;
    }

    if (!Util.isUnset(request.streamId)) {
      body["streamId"] = request.streamId;
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
    return $tea.cast<StopStreamOutResponse>(await this.doROARequest("StopStreamOut", "conference_1.0", "HTTP", "POST", "AK", `/v1.0/conference/videoConferences/${conferenceId}/streamOuts/stop`, "json", req, runtime), new StopStreamOutResponse({}));
  }

  async updateVideoConferenceExtInfo(conferenceId: string): Promise<UpdateVideoConferenceExtInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateVideoConferenceExtInfoHeaders({ });
    return await this.updateVideoConferenceExtInfoWithOptions(conferenceId, headers, runtime);
  }

  async updateVideoConferenceExtInfoWithOptions(conferenceId: string, headers: UpdateVideoConferenceExtInfoHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateVideoConferenceExtInfoResponse> {
    conferenceId = OpenApiUtil.getEncodeParam(conferenceId);
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
    return $tea.cast<UpdateVideoConferenceExtInfoResponse>(await this.doROARequest("UpdateVideoConferenceExtInfo", "conference_1.0", "HTTP", "PUT", "AK", `/v1.0/conference/videoConferences/${conferenceId}/extInfo`, "json", req, runtime), new UpdateVideoConferenceExtInfoResponse({}));
  }

  async updateVideoConferenceSetting(conferenceId: string, request: UpdateVideoConferenceSettingRequest): Promise<UpdateVideoConferenceSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateVideoConferenceSettingHeaders({ });
    return await this.updateVideoConferenceSettingWithOptions(conferenceId, request, headers, runtime);
  }

  async updateVideoConferenceSettingWithOptions(conferenceId: string, request: UpdateVideoConferenceSettingRequest, headers: UpdateVideoConferenceSettingHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateVideoConferenceSettingResponse> {
    Util.validateModel(request);
    conferenceId = OpenApiUtil.getEncodeParam(conferenceId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.allowUnmuteSelf)) {
      body["allowUnmuteSelf"] = request.allowUnmuteSelf;
    }

    if (!Util.isUnset(request.autoTransferHost)) {
      body["autoTransferHost"] = request.autoTransferHost;
    }

    if (!Util.isUnset(request.forbiddenShareScreen)) {
      body["forbiddenShareScreen"] = request.forbiddenShareScreen;
    }

    if (!Util.isUnset(request.lockConference)) {
      body["lockConference"] = request.lockConference;
    }

    if (!Util.isUnset(request.muteAll)) {
      body["muteAll"] = request.muteAll;
    }

    if (!Util.isUnset(request.onlyInternalEmployeesJoin)) {
      body["onlyInternalEmployeesJoin"] = request.onlyInternalEmployeesJoin;
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
    return $tea.cast<UpdateVideoConferenceSettingResponse>(await this.doROARequest("UpdateVideoConferenceSetting", "conference_1.0", "HTTP", "PUT", "AK", `/v1.0/conference/videoConferences/${conferenceId}`, "json", req, runtime), new UpdateVideoConferenceSettingResponse({}));
  }

}
