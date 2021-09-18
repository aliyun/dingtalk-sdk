// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  unionId?: string;
  startTime?: number;
  direction?: string;
  maxResults?: number;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
      startTime: 'startTime',
      direction: 'direction',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
      startTime: 'number',
      direction: 'string',
      maxResults: 'number',
      nextToken: 'number',
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
  userId?: string;
  confTitle?: string;
  inviteUserIds?: string[];
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      confTitle: 'confTitle',
      inviteUserIds: 'inviteUserIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      confTitle: 'string',
      inviteUserIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateVideoConferenceResponseBody extends $tea.Model {
  conferenceId?: string;
  conferencePassword?: string;
  hostPassword?: string;
  externalLinkUrl?: string;
  phoneNumbers?: string[];
  static names(): { [key: string]: string } {
    return {
      conferenceId: 'conferenceId',
      conferencePassword: 'conferencePassword',
      hostPassword: 'hostPassword',
      externalLinkUrl: 'externalLinkUrl',
      phoneNumbers: 'phoneNumbers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conferenceId: 'string',
      conferencePassword: 'string',
      hostPassword: 'string',
      externalLinkUrl: 'string',
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
  unionId?: string;
  mediaId?: string;
  regionId?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
      mediaId: 'mediaId',
      regionId: 'regionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
      mediaId: 'string',
      regionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCloudRecordVideoPlayInfoResponseBody extends $tea.Model {
  playUrl?: string;
  mp4FileUrl?: string;
  fileSize?: number;
  duration?: number;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      playUrl: 'playUrl',
      mp4FileUrl: 'mp4FileUrl',
      fileSize: 'fileSize',
      duration: 'duration',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      playUrl: 'string',
      mp4FileUrl: 'string',
      fileSize: 'number',
      duration: 'number',
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
  cause?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      cause: 'cause',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      cause: 'string',
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
  code?: number;
  cause?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      cause: 'cause',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      cause: 'string',
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
  streamId?: string;
  stopAllStream?: boolean;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      streamId: 'streamId',
      stopAllStream: 'stopAllStream',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      streamId: 'string',
      stopAllStream: 'boolean',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StopStreamOutResponseBody extends $tea.Model {
  code?: string;
  cause?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      cause: 'cause',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      cause: 'string',
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
  unionId?: string;
  smallWindowPosition?: string;
  mode?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
      smallWindowPosition: 'smallWindowPosition',
      mode: 'mode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
      smallWindowPosition: 'string',
      mode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCloudRecordResponseBody extends $tea.Model {
  code?: string;
  cause?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      cause: 'cause',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      cause: 'string',
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
  unionId?: string;
  needHostJoin?: boolean;
  streamUrlList?: string[];
  streamName?: string;
  mode?: string;
  smallWindowPosition?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
      needHostJoin: 'needHostJoin',
      streamUrlList: 'streamUrlList',
      streamName: 'streamName',
      mode: 'mode',
      smallWindowPosition: 'smallWindowPosition',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
      needHostJoin: 'boolean',
      streamUrlList: { 'type': 'array', 'itemType': 'string' },
      streamName: 'string',
      mode: 'string',
      smallWindowPosition: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartStreamOutResponseBody extends $tea.Model {
  successStreamMap?: { [key: string]: any };
  failStreamMap?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      successStreamMap: 'successStreamMap',
      failStreamMap: 'failStreamMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      successStreamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      failStreamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
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

export class QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList extends $tea.Model {
  word?: string;
  startTime?: number;
  endTime?: number;
  wordId?: string;
  static names(): { [key: string]: string } {
    return {
      word: 'word',
      startTime: 'startTime',
      endTime: 'endTime',
      wordId: 'wordId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      word: 'string',
      startTime: 'number',
      endTime: 'number',
      wordId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCloudRecordTextResponseBodyParagraphListSentenceList extends $tea.Model {
  unionId?: string;
  sentence?: string;
  startTime?: number;
  endTime?: number;
  wordList?: QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList[];
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
      sentence: 'sentence',
      startTime: 'startTime',
      endTime: 'endTime',
      wordList: 'wordList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
      sentence: 'string',
      startTime: 'number',
      endTime: 'number',
      wordList: { 'type': 'array', 'itemType': QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCloudRecordTextResponseBodyParagraphList extends $tea.Model {
  nextTtoken?: number;
  status?: number;
  unionId?: string;
  nickName?: string;
  recordId?: number;
  startTime?: number;
  endTime?: number;
  paragraph?: string;
  sentenceList?: QueryCloudRecordTextResponseBodyParagraphListSentenceList[];
  static names(): { [key: string]: string } {
    return {
      nextTtoken: 'nextTtoken',
      status: 'status',
      unionId: 'unionId',
      nickName: 'nickName',
      recordId: 'recordId',
      startTime: 'startTime',
      endTime: 'endTime',
      paragraph: 'paragraph',
      sentenceList: 'sentenceList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextTtoken: 'number',
      status: 'number',
      unionId: 'string',
      nickName: 'string',
      recordId: 'number',
      startTime: 'number',
      endTime: 'number',
      paragraph: 'string',
      sentenceList: { 'type': 'array', 'itemType': QueryCloudRecordTextResponseBodyParagraphListSentenceList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConferenceInfoBatchResponseBodyInfosUserList extends $tea.Model {
  userId?: string;
  nick?: string;
  attendStatus?: number;
  cameraStatus?: number;
  micStatus?: number;
  rejectDescription?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      nick: 'nick',
      attendStatus: 'attendStatus',
      cameraStatus: 'cameraStatus',
      micStatus: 'micStatus',
      rejectDescription: 'rejectDescription',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      nick: 'string',
      attendStatus: 'number',
      cameraStatus: 'number',
      micStatus: 'number',
      rejectDescription: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConferenceInfoBatchResponseBodyInfos extends $tea.Model {
  conferenceId?: string;
  title?: string;
  startTime?: number;
  status?: number;
  mediaStatus?: number;
  userList?: QueryConferenceInfoBatchResponseBodyInfosUserList[];
  static names(): { [key: string]: string } {
    return {
      conferenceId: 'conferenceId',
      title: 'title',
      startTime: 'startTime',
      status: 'status',
      mediaStatus: 'mediaStatus',
      userList: 'userList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conferenceId: 'string',
      title: 'string',
      startTime: 'number',
      status: 'number',
      mediaStatus: 'number',
      userList: { 'type': 'array', 'itemType': QueryConferenceInfoBatchResponseBodyInfosUserList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCloudRecordVideoResponseBodyVideoList extends $tea.Model {
  recordId?: string;
  unionId?: string;
  startTime?: number;
  recordType?: number;
  duration?: number;
  fileSize?: number;
  endTime?: number;
  mediaId?: string;
  regionId?: string;
  static names(): { [key: string]: string } {
    return {
      recordId: 'recordId',
      unionId: 'unionId',
      startTime: 'startTime',
      recordType: 'recordType',
      duration: 'duration',
      fileSize: 'fileSize',
      endTime: 'endTime',
      mediaId: 'mediaId',
      regionId: 'regionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      recordId: 'string',
      unionId: 'string',
      startTime: 'number',
      recordType: 'number',
      duration: 'number',
      fileSize: 'number',
      endTime: 'number',
      mediaId: 'string',
      regionId: 'string',
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


  async queryCloudRecordText(conferenceId: string, request: QueryCloudRecordTextRequest): Promise<QueryCloudRecordTextResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCloudRecordTextHeaders({ });
    return await this.queryCloudRecordTextWithOptions(conferenceId, request, headers, runtime);
  }

  async queryCloudRecordTextWithOptions(conferenceId: string, request: QueryCloudRecordTextRequest, headers: QueryCloudRecordTextHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCloudRecordTextResponse> {
    Util.validateModel(request);
    conferenceId = OpenApiUtil.getEncodeParam(conferenceId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    if (!Util.isUnset(request.startTime)) {
      query["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.direction)) {
      query["direction"] = request.direction;
    }

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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryCloudRecordTextResponse>(await this.doROARequest("QueryCloudRecordText", "conference_1.0", "HTTP", "GET", "AK", `/v1.0/conference/videoConferences/${conferenceId}/cloudRecords/getTexts`, "json", req, runtime), new QueryCloudRecordTextResponse({}));
  }

  async createVideoConference(request: CreateVideoConferenceRequest): Promise<CreateVideoConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateVideoConferenceHeaders({ });
    return await this.createVideoConferenceWithOptions(request, headers, runtime);
  }

  async createVideoConferenceWithOptions(request: CreateVideoConferenceRequest, headers: CreateVideoConferenceHeaders, runtime: $Util.RuntimeOptions): Promise<CreateVideoConferenceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.confTitle)) {
      body["confTitle"] = request.confTitle;
    }

    if (!Util.isUnset(request.inviteUserIds)) {
      body["inviteUserIds"] = request.inviteUserIds;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<CreateVideoConferenceResponse>(await this.doROARequest("CreateVideoConference", "conference_1.0", "HTTP", "POST", "AK", `/v1.0/conference/videoConferences`, "json", req, runtime), new CreateVideoConferenceResponse({}));
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
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    if (!Util.isUnset(request.mediaId)) {
      query["mediaId"] = request.mediaId;
    }

    if (!Util.isUnset(request.regionId)) {
      query["regionId"] = request.regionId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<QueryConferenceInfoBatchResponse>(await this.doROARequest("QueryConferenceInfoBatch", "conference_1.0", "HTTP", "POST", "AK", `/v1.0/conference/videoConferences/query`, "json", req, runtime), new QueryConferenceInfoBatchResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<StopCloudRecordResponse>(await this.doROARequest("StopCloudRecord", "conference_1.0", "HTTP", "POST", "AK", `/v1.0/conference/videoConferences/${conferenceId}/cloudRecords/stop`, "json", req, runtime), new StopCloudRecordResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<UpdateVideoConferenceExtInfoResponse>(await this.doROARequest("UpdateVideoConferenceExtInfo", "conference_1.0", "HTTP", "PUT", "AK", `/v1.0/conference/videoConferences/${conferenceId}/extInfo`, "json", req, runtime), new UpdateVideoConferenceExtInfoResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<CloseVideoConferenceResponse>(await this.doROARequest("CloseVideoConference", "conference_1.0", "HTTP", "DELETE", "AK", `/v1.0/conference/videoConferences/${conferenceId}`, "json", req, runtime), new CloseVideoConferenceResponse({}));
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
    if (!Util.isUnset(request.streamId)) {
      body["streamId"] = request.streamId;
    }

    if (!Util.isUnset(request.stopAllStream)) {
      body["stopAllStream"] = request.stopAllStream;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<StopStreamOutResponse>(await this.doROARequest("StopStreamOut", "conference_1.0", "HTTP", "POST", "AK", `/v1.0/conference/videoConferences/${conferenceId}/streamOuts/stop`, "json", req, runtime), new StopStreamOutResponse({}));
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
    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
    }

    if (!Util.isUnset(request.smallWindowPosition)) {
      body["smallWindowPosition"] = request.smallWindowPosition;
    }

    if (!Util.isUnset(request.mode)) {
      body["mode"] = request.mode;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
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
    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
    }

    if (!Util.isUnset(request.needHostJoin)) {
      body["needHostJoin"] = request.needHostJoin;
    }

    if (!Util.isUnset(request.streamUrlList)) {
      body["streamUrlList"] = request.streamUrlList;
    }

    if (!Util.isUnset(request.streamName)) {
      body["streamName"] = request.streamName;
    }

    if (!Util.isUnset(request.mode)) {
      body["mode"] = request.mode;
    }

    if (!Util.isUnset(request.smallWindowPosition)) {
      body["smallWindowPosition"] = request.smallWindowPosition;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<StartStreamOutResponse>(await this.doROARequest("StartStreamOut", "conference_1.0", "HTTP", "POST", "AK", `/v1.0/conference/videoConferences/${conferenceId}/streamOuts/start`, "json", req, runtime), new StartStreamOutResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryCloudRecordVideoResponse>(await this.doROARequest("QueryCloudRecordVideo", "conference_1.0", "HTTP", "GET", "AK", `/v1.0/conference/videoConferences/${conferenceId}/cloudRecords/getVideos`, "json", req, runtime), new QueryCloudRecordVideoResponse({}));
  }

}
