// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class CreateFeedHeaders extends $tea.Model {
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

export class CreateFeedRequest extends $tea.Model {
  courseInfo?: CreateFeedRequestCourseInfo;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 16621*******284773
   */
  createUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  feedInfo?: CreateFeedRequestFeedInfo;
  static names(): { [key: string]: string } {
    return {
      courseInfo: 'courseInfo',
      createUserId: 'createUserId',
      feedInfo: 'feedInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseInfo: CreateFeedRequestCourseInfo,
      createUserId: 'string',
      feedInfo: CreateFeedRequestFeedInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFeedResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * c497****-8a89-****-bc9b-*****48610d3
   */
  feedId?: string;
  static names(): { [key: string]: string } {
    return {
      feedId: 'feedId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      feedId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFeedResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateFeedResponseBody;
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
      body: CreateFeedResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteVideosHeaders extends $tea.Model {
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

export class DeleteVideosRequest extends $tea.Model {
  body?: string[];
  static names(): { [key: string]: string } {
    return {
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteVideosResponseBody extends $tea.Model {
  result?: DeleteVideosResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: DeleteVideosResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteVideosResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteVideosResponseBody;
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
      body: DeleteVideosResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFeedHeaders extends $tea.Model {
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

export class GetFeedRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 50730********40554
   */
  mcnId?: string;
  static names(): { [key: string]: string } {
    return {
      mcnId: 'mcnId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mcnId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFeedResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3d******-1cd2-****-ba1d-8******3c6dc
   */
  feedId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  feedItem?: GetFeedResponseBodyFeedItem[];
  static names(): { [key: string]: string } {
    return {
      feedId: 'feedId',
      feedItem: 'feedItem',
    };
  }

  static types(): { [key: string]: any } {
    return {
      feedId: 'string',
      feedItem: { 'type': 'array', 'itemType': GetFeedResponseBodyFeedItem },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFeedResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetFeedResponseBody;
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
      body: GetFeedResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMediaCerficateHeaders extends $tea.Model {
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

export class GetMediaCerficateRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * D:\****.mp4
   */
  fileName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 87712****6723412
   */
  mcnId?: string;
  /**
   * @example
   * cd8b21090b6*********b78fa733
   */
  mediaId?: string;
  /**
   * @example
   * 视频描述。  长度不超过1024个字符。 UTF-8编码。
   */
  mediaIntroduction?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * UploadTest
   */
  mediaTitle?: string;
  /**
   * @example
   * https://*****test.cn/image/D22F553*****TEST.jpeg
   */
  thumbUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * edb2*****1090b66
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      fileName: 'fileName',
      mcnId: 'mcnId',
      mediaId: 'mediaId',
      mediaIntroduction: 'mediaIntroduction',
      mediaTitle: 'mediaTitle',
      thumbUrl: 'thumbUrl',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileName: 'string',
      mcnId: 'string',
      mediaId: 'string',
      mediaIntroduction: 'string',
      mediaTitle: 'string',
      thumbUrl: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMediaCerficateResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 378a1a01**********6fa2886313948e
   */
  mediaId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * STS.NTR**********q8LrHkgS7w97
   */
  ossAccessKeyId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * DFCXzE5r8x9d4kp**********r1N8eUeh5aU7tM9vVcu
   */
  ossAccessKeySecret?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * outin-5e342d**********8bfb00163e024c6a
   */
  ossBucketName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://oss-cn-*******.aliyuncs.com
   */
  ossEndpoint?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3000
   */
  ossExpiration?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * sv/1c****53-17a*****202/1c****53-17a*****02.mp4
   */
  ossFileName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * CAIS0AR1q6Ft5B2yfSjIr5**********+au5c1eJqHIdZ+h/2LKS***********oAO8fvvU0m2tY7PsZlrUqFMQZHBaUPJoutc0OoFL4JpfZv8u84YADi5C***********28Wf7waf+AUBXGCTm***********lQCZuW//toJV7b9MRcxClZD5dfrl/LRdjr8lo1xGzUPG2KUzSn3b3BkhlsRYe72Rk8vaHxdaAzRDcgVbmqJcSvJ+jC4C8Ys9gG519XtypvopxbbGT8CNZ5z9A9qp9kM49/izc7P6QH35b4RiNL8/Z7tQNXwhiffobHa9YrfHgmNhlvvDSj43t1ytVOeZcX0akQ5u7ku7ZHP+oLt8jaYvjP3PE3rLpMYLu4T48ZXUSODtDYcZDUHhrEk4RUjXdI6Of8UrWSQC7Wsr217otg7Fyyk3s8MaHAkWLX7SB2DwEB4c4aEokVW4RxnezW6UBaRBpbld7Bq6cV5lOdBRZoK+KzQrJTX9Ez2pLmuD6e/LOs7oDVJ37WZtKyuh4Y49d4U8rVEjPQqiykT0pFgpfTK1RzbPmNLKm9baB25/zW+PdDe0dsVgoIFKOpiGWG3RLNn+ztJ9xbkeE+sKUkaGXr8lsTAIl6t4CVFiIIIZnoVY+u/LstBnLqrPoDHnt5XR/uPugptgRuRo8I6372bTJ42WG5Ub9O/dpxJ3lP0R0WgmydnBDx/Sfu2kKvRhpkRvvZEpPtwzIij/gLZZEiazRmyhefo5XmPXFTQmn8l5pAMmy/60xXudvbE2R0EQDY9YCGoABVx6uDvU/Q1kkRe4S00MofmJkOWVwk8jVgBbmlA6LUJQm70f9nksTLYjJ2HVOFHQO8MrnE2ur/xx5jYWpCHI0Aa4sGCjZShV0NNuT8yqNmGOKUReffWW47gxKv5Hhc6j8cAKUMZivrqCCuQaEqhNnKjDH7NS3PsXXyvhNF1KS6uQ=
   */
  ossSecurityToken?: string;
  static names(): { [key: string]: string } {
    return {
      mediaId: 'mediaId',
      ossAccessKeyId: 'ossAccessKeyId',
      ossAccessKeySecret: 'ossAccessKeySecret',
      ossBucketName: 'ossBucketName',
      ossEndpoint: 'ossEndpoint',
      ossExpiration: 'ossExpiration',
      ossFileName: 'ossFileName',
      ossSecurityToken: 'ossSecurityToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mediaId: 'string',
      ossAccessKeyId: 'string',
      ossAccessKeySecret: 'string',
      ossBucketName: 'string',
      ossEndpoint: 'string',
      ossExpiration: 'string',
      ossFileName: 'string',
      ossSecurityToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMediaCerficateResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetMediaCerficateResponseBody;
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
      body: GetMediaCerficateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListItemUserDataHeaders extends $tea.Model {
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

export class ListItemUserDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  body?: string[];
  static names(): { [key: string]: string } {
    return {
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListItemUserDataResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  studyInfos?: ListItemUserDataResponseBodyStudyInfos[];
  static names(): { [key: string]: string } {
    return {
      studyInfos: 'studyInfos',
    };
  }

  static types(): { [key: string]: any } {
    return {
      studyInfos: { 'type': 'array', 'itemType': ListItemUserDataResponseBodyStudyInfos },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListItemUserDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListItemUserDataResponseBody;
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
      body: ListItemUserDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageFeedHeaders extends $tea.Model {
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

export class PageFeedRequest extends $tea.Model {
  body?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 50730********40554
   */
  mcnId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
      maxResults: 'maxResults',
      mcnId: 'mcnId',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': 'string' },
      maxResults: 'number',
      mcnId: 'string',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageFeedResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  feedList?: PageFeedResponseBodyFeedList[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  hasNext?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20
   */
  nextCursor?: number;
  static names(): { [key: string]: string } {
    return {
      feedList: 'feedList',
      hasNext: 'hasNext',
      nextCursor: 'nextCursor',
    };
  }

  static types(): { [key: string]: any } {
    return {
      feedList: { 'type': 'array', 'itemType': PageFeedResponseBodyFeedList },
      hasNext: 'boolean',
      nextCursor: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageFeedResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PageFeedResponseBody;
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
      body: PageFeedResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadVideosHeaders extends $tea.Model {
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

export class UploadVideosRequest extends $tea.Model {
  body?: UploadVideosRequestBody[];
  static names(): { [key: string]: string } {
    return {
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': UploadVideosRequestBody },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadVideosResponseBody extends $tea.Model {
  result?: UploadVideosResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UploadVideosResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadVideosResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UploadVideosResponseBody;
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
      body: UploadVideosResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFeedRequestCourseInfoLectorUserInfo extends $tea.Model {
  /**
   * @example
   * https://static.dingtalk.com/media/lA****************p_169_169.png_60x60q90.jpg?bizType=avatar
   */
  avatar?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 用户名
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 16621*******284773
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      avatar: 'avatar',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatar: 'string',
      name: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFeedRequestCourseInfoPayInfoCsUserInfo extends $tea.Model {
  /**
   * @example
   * https://static.dingtalk.com/media/lA****************p_169_169.png_60x60q90.jpg?bizType=avatar
   */
  avatar?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 用户名
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 16621*******284773
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      avatar: 'avatar',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatar: 'string',
      name: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFeedRequestCourseInfoPayInfoDiscountInfo extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1624507431777
   */
  endTimeMillis?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 100
   */
  price?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1624507431777
   */
  startTimeMillis?: number;
  static names(): { [key: string]: string } {
    return {
      endTimeMillis: 'endTimeMillis',
      price: 'price',
      startTimeMillis: 'startTimeMillis',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTimeMillis: 'number',
      price: 'number',
      startTimeMillis: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFeedRequestCourseInfoPayInfo extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  csUserInfo?: CreateFeedRequestCourseInfoPayInfoCsUserInfo;
  discountInfo?: CreateFeedRequestCourseInfoPayInfoDiscountInfo;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10000
   */
  price?: number;
  static names(): { [key: string]: string } {
    return {
      csUserInfo: 'csUserInfo',
      discountInfo: 'discountInfo',
      price: 'price',
    };
  }

  static types(): { [key: string]: any } {
    return {
      csUserInfo: CreateFeedRequestCourseInfoPayInfoCsUserInfo,
      discountInfo: CreateFeedRequestCourseInfoPayInfoDiscountInfo,
      price: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFeedRequestCourseInfo extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  lectorUserInfo?: CreateFeedRequestCourseInfoLectorUserInfo;
  payInfo?: CreateFeedRequestCourseInfoPayInfo;
  /**
   * @example
   * xx学习群
   */
  studyGroupName?: string;
  static names(): { [key: string]: string } {
    return {
      lectorUserInfo: 'lectorUserInfo',
      payInfo: 'payInfo',
      studyGroupName: 'studyGroupName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      lectorUserInfo: CreateFeedRequestCourseInfoLectorUserInfo,
      payInfo: CreateFeedRequestCourseInfoPayInfo,
      studyGroupName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFeedRequestFeedInfoMediaContents extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 378a1a0154b34**********86313948e
   */
  mediaId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 媒体标题
   */
  title?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2
   */
  type?: number;
  static names(): { [key: string]: string } {
    return {
      mediaId: 'mediaId',
      title: 'title',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mediaId: 'string',
      title: 'string',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFeedRequestFeedInfoRecommends extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * c497****-8a89-****-bc9b-*****48610d3
   */
  objectId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  type?: number;
  static names(): { [key: string]: string } {
    return {
      objectId: 'objectId',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      objectId: 'string',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFeedRequestFeedInfo extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2
   */
  actionType?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  belongsTo?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 200000257
   */
  feedCategory?: number;
  /**
   * @example
   * c497****-8a89-****-bc9b-*****48610d3
   */
  feedId?: string;
  /**
   * @example
   * 标签
   */
  feedTag?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 4
   */
  feedType?: number;
  /**
   * @example
   * 10001
   */
  industryId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 描述
   */
  introduction?: string;
  /**
   * @example
   * https://static.dingtalk.com/media/**************NAlg_600_337.jpg
   */
  introductionPicUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 50730********40554
   */
  mcnId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  mediaContents?: CreateFeedRequestFeedInfoMediaContents[];
  recommends?: CreateFeedRequestFeedInfoRecommends[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://static.dingtalk.com/media/**************NAlg_600_337.jpg
   */
  thumbUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 课程标题
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      actionType: 'actionType',
      belongsTo: 'belongsTo',
      feedCategory: 'feedCategory',
      feedId: 'feedId',
      feedTag: 'feedTag',
      feedType: 'feedType',
      industryId: 'industryId',
      introduction: 'introduction',
      introductionPicUrl: 'introductionPicUrl',
      mcnId: 'mcnId',
      mediaContents: 'mediaContents',
      recommends: 'recommends',
      thumbUrl: 'thumbUrl',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionType: 'number',
      belongsTo: 'number',
      feedCategory: 'number',
      feedId: 'string',
      feedTag: 'string',
      feedType: 'number',
      industryId: 'number',
      introduction: 'string',
      introductionPicUrl: 'string',
      mcnId: 'string',
      mediaContents: { 'type': 'array', 'itemType': CreateFeedRequestFeedInfoMediaContents },
      recommends: { 'type': 'array', 'itemType': CreateFeedRequestFeedInfoRecommends },
      thumbUrl: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteVideosResponseBodyResult extends $tea.Model {
  failed?: string[];
  success?: number;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      failed: 'failed',
      success: 'success',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      failed: { 'type': 'array', 'itemType': 'string' },
      success: 'number',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFeedResponseBodyFeedItem extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 9320
   */
  durationMillis?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  feedContentType?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 08****b5-2442-****-bd56-99cf****8861
   */
  itemId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 子内容标题
   */
  title?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://h5.dingtalk.com/live/video_lesson.htm?feedId=66****03-a825-****-9501-b1eeb****a8d&mcnId=1832**********06173&feedProperty=2&itemId=08****b5-2442-****-bd56-99c*****8861&dd_nav_bgcolor=FF2C2D2F#/video
   */
  url?: string;
  static names(): { [key: string]: string } {
    return {
      durationMillis: 'durationMillis',
      feedContentType: 'feedContentType',
      itemId: 'itemId',
      title: 'title',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      durationMillis: 'number',
      feedContentType: 'number',
      itemId: 'string',
      title: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListItemUserDataResponseBodyStudyInfos extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10000
   */
  durationMillis?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 16621*******284773
   */
  uid?: string;
  static names(): { [key: string]: string } {
    return {
      durationMillis: 'durationMillis',
      uid: 'uid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      durationMillis: 'number',
      uid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageFeedResponseBodyFeedList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 200000257
   */
  feedCategory?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3d******-1cd2-****-ba1d-8******3c6dc
   */
  feedId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 4
   */
  feedType?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 名称
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://static.dingtalk.com/media/**************NAlg_600_337.jpg
   */
  thumbUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://h5.dingtalk.com/live/video_lesson.htm?spm=a1zdd.*******.0.0.3e9617129vSDL8&feedId=5e*****-17ec-45f1-8cc0-e******4a3&mcnId=183206*******06173&feedProperty=1&itemId=5ef7*****-17ec-45f1-8cc0-e64*****954a3&dd_nav_bgcolor=FF2****F#/video
   */
  url?: string;
  static names(): { [key: string]: string } {
    return {
      feedCategory: 'feedCategory',
      feedId: 'feedId',
      feedType: 'feedType',
      name: 'name',
      thumbUrl: 'thumbUrl',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      feedCategory: 'string',
      feedId: 'string',
      feedType: 'number',
      name: 'string',
      thumbUrl: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadVideosRequestBody extends $tea.Model {
  authorIconUrl?: string;
  authorId?: string;
  authorName?: string;
  coverUrl?: string;
  jumpIconUrl?: string;
  jumpTitle?: string;
  jumpUrl?: string;
  videoDuration?: string;
  videoHeight?: string;
  videoId?: string;
  videoTitle?: string;
  videoWidth?: string;
  webpUrl?: string;
  static names(): { [key: string]: string } {
    return {
      authorIconUrl: 'authorIconUrl',
      authorId: 'authorId',
      authorName: 'authorName',
      coverUrl: 'coverUrl',
      jumpIconUrl: 'jumpIconUrl',
      jumpTitle: 'jumpTitle',
      jumpUrl: 'jumpUrl',
      videoDuration: 'videoDuration',
      videoHeight: 'videoHeight',
      videoId: 'videoId',
      videoTitle: 'videoTitle',
      videoWidth: 'videoWidth',
      webpUrl: 'webpUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authorIconUrl: 'string',
      authorId: 'string',
      authorName: 'string',
      coverUrl: 'string',
      jumpIconUrl: 'string',
      jumpTitle: 'string',
      jumpUrl: 'string',
      videoDuration: 'string',
      videoHeight: 'string',
      videoId: 'string',
      videoTitle: 'string',
      videoWidth: 'string',
      webpUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadVideosResponseBodyResult extends $tea.Model {
  failed?: string[];
  hasUploaded?: number;
  success?: number;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      failed: 'failed',
      hasUploaded: 'hasUploaded',
      success: 'success',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      failed: { 'type': 'array', 'itemType': 'string' },
      hasUploaded: 'number',
      success: 'number',
      total: 'number',
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
   * 创建内容
   * 
   * @param request - CreateFeedRequest
   * @param headers - CreateFeedHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateFeedResponse
   */
  async createFeedWithOptions(request: CreateFeedRequest, headers: CreateFeedHeaders, runtime: $Util.RuntimeOptions): Promise<CreateFeedResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.courseInfo)) {
      body["courseInfo"] = request.courseInfo;
    }

    if (!Util.isUnset(request.createUserId)) {
      body["createUserId"] = request.createUserId;
    }

    if (!Util.isUnset(request.feedInfo)) {
      body["feedInfo"] = request.feedInfo;
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
      action: "CreateFeed",
      version: "content_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/content/feeds`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CreateFeedResponse>(await this.execute(params, req, runtime), new CreateFeedResponse({}));
  }

  /**
   * 创建内容
   * 
   * @param request - CreateFeedRequest
   * @returns CreateFeedResponse
   */
  async createFeed(request: CreateFeedRequest): Promise<CreateFeedResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateFeedHeaders({ });
    return await this.createFeedWithOptions(request, headers, runtime);
  }

  /**
   * 点众下架视频接口
   * 
   * @param request - DeleteVideosRequest
   * @param headers - DeleteVideosHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteVideosResponse
   */
  async deleteVideosWithOptions(request: DeleteVideosRequest, headers: DeleteVideosHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteVideosResponse> {
    Util.validateModel(request);
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: request.body,
    });
    let params = new $OpenApi.Params({
      action: "DeleteVideos",
      version: "content_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/content/dian/videos/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteVideosResponse>(await this.execute(params, req, runtime), new DeleteVideosResponse({}));
  }

  /**
   * 点众下架视频接口
   * 
   * @param request - DeleteVideosRequest
   * @returns DeleteVideosResponse
   */
  async deleteVideos(request: DeleteVideosRequest): Promise<DeleteVideosResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteVideosHeaders({ });
    return await this.deleteVideosWithOptions(request, headers, runtime);
  }

  /**
   * 获取feed的详细信息，包括子课程的信息
   * 
   * @param request - GetFeedRequest
   * @param headers - GetFeedHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetFeedResponse
   */
  async getFeedWithOptions(feedId: string, request: GetFeedRequest, headers: GetFeedHeaders, runtime: $Util.RuntimeOptions): Promise<GetFeedResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.mcnId)) {
      query["mcnId"] = request.mcnId;
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
      action: "GetFeed",
      version: "content_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/content/feeds/${feedId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetFeedResponse>(await this.execute(params, req, runtime), new GetFeedResponse({}));
  }

  /**
   * 获取feed的详细信息，包括子课程的信息
   * 
   * @param request - GetFeedRequest
   * @returns GetFeedResponse
   */
  async getFeed(feedId: string, request: GetFeedRequest): Promise<GetFeedResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFeedHeaders({ });
    return await this.getFeedWithOptions(feedId, request, headers, runtime);
  }

  /**
   * 获取oss上传凭证
   * 
   * @param request - GetMediaCerficateRequest
   * @param headers - GetMediaCerficateHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetMediaCerficateResponse
   */
  async getMediaCerficateWithOptions(request: GetMediaCerficateRequest, headers: GetMediaCerficateHeaders, runtime: $Util.RuntimeOptions): Promise<GetMediaCerficateResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.fileName)) {
      query["fileName"] = request.fileName;
    }

    if (!Util.isUnset(request.mcnId)) {
      query["mcnId"] = request.mcnId;
    }

    if (!Util.isUnset(request.mediaId)) {
      query["mediaId"] = request.mediaId;
    }

    if (!Util.isUnset(request.mediaIntroduction)) {
      query["mediaIntroduction"] = request.mediaIntroduction;
    }

    if (!Util.isUnset(request.mediaTitle)) {
      query["mediaTitle"] = request.mediaTitle;
    }

    if (!Util.isUnset(request.thumbUrl)) {
      query["thumbUrl"] = request.thumbUrl;
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
      action: "GetMediaCerficate",
      version: "content_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/content/media/cerficates`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetMediaCerficateResponse>(await this.execute(params, req, runtime), new GetMediaCerficateResponse({}));
  }

  /**
   * 获取oss上传凭证
   * 
   * @param request - GetMediaCerficateRequest
   * @returns GetMediaCerficateResponse
   */
  async getMediaCerficate(request: GetMediaCerficateRequest): Promise<GetMediaCerficateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMediaCerficateHeaders({ });
    return await this.getMediaCerficateWithOptions(request, headers, runtime);
  }

  /**
   * 展示机构内观看内容的统计信息
   * 
   * @param request - ListItemUserDataRequest
   * @param headers - ListItemUserDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListItemUserDataResponse
   */
  async listItemUserDataWithOptions(itemId: string, request: ListItemUserDataRequest, headers: ListItemUserDataHeaders, runtime: $Util.RuntimeOptions): Promise<ListItemUserDataResponse> {
    Util.validateModel(request);
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: request.body,
    });
    let params = new $OpenApi.Params({
      action: "ListItemUserData",
      version: "content_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/content/feeds/items/${itemId}/userStatistics/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ListItemUserDataResponse>(await this.execute(params, req, runtime), new ListItemUserDataResponse({}));
  }

  /**
   * 展示机构内观看内容的统计信息
   * 
   * @param request - ListItemUserDataRequest
   * @returns ListItemUserDataResponse
   */
  async listItemUserData(itemId: string, request: ListItemUserDataRequest): Promise<ListItemUserDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListItemUserDataHeaders({ });
    return await this.listItemUserDataWithOptions(itemId, request, headers, runtime);
  }

  /**
   * 获取机构下课程列表
   * 
   * @param request - PageFeedRequest
   * @param headers - PageFeedHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PageFeedResponse
   */
  async pageFeedWithOptions(request: PageFeedRequest, headers: PageFeedHeaders, runtime: $Util.RuntimeOptions): Promise<PageFeedResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.mcnId)) {
      query["mcnId"] = request.mcnId;
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
      body: request.body,
    });
    let params = new $OpenApi.Params({
      action: "PageFeed",
      version: "content_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/content/feeds/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<PageFeedResponse>(await this.execute(params, req, runtime), new PageFeedResponse({}));
  }

  /**
   * 获取机构下课程列表
   * 
   * @param request - PageFeedRequest
   * @returns PageFeedResponse
   */
  async pageFeed(request: PageFeedRequest): Promise<PageFeedResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PageFeedHeaders({ });
    return await this.pageFeedWithOptions(request, headers, runtime);
  }

  /**
   * 点众上传视频信息
   * 
   * @param request - UploadVideosRequest
   * @param headers - UploadVideosHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UploadVideosResponse
   */
  async uploadVideosWithOptions(request: UploadVideosRequest, headers: UploadVideosHeaders, runtime: $Util.RuntimeOptions): Promise<UploadVideosResponse> {
    Util.validateModel(request);
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: Util.toArray(request.body),
    });
    let params = new $OpenApi.Params({
      action: "UploadVideos",
      version: "content_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/content/dian/videos/upload`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UploadVideosResponse>(await this.execute(params, req, runtime), new UploadVideosResponse({}));
  }

  /**
   * 点众上传视频信息
   * 
   * @param request - UploadVideosRequest
   * @returns UploadVideosResponse
   */
  async uploadVideos(request: UploadVideosRequest): Promise<UploadVideosResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UploadVideosHeaders({ });
    return await this.uploadVideosWithOptions(request, headers, runtime);
  }

}
