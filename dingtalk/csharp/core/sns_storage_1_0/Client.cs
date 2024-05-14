// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalksns_storage_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalksns_storage_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {
        protected AlibabaCloud.GatewaySpi.Client _client;

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._client = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = _client;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /**
         * @summary 三方个人应用批量获取文件或文件夹信息
         *
         * @param request GetDentriesRequest
         * @param headers GetDentriesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDentriesResponse
         */
        public GetDentriesResponse GetDentriesWithOptions(string spaceId, GetDentriesRequest request, GetDentriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryIds))
            {
                body["dentryIds"] = request.DentryIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDentries",
                Version = "snsStorage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/snsStorage/spaces/" + spaceId + "/dentries/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDentriesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 三方个人应用批量获取文件或文件夹信息
         *
         * @param request GetDentriesRequest
         * @param headers GetDentriesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDentriesResponse
         */
        public async Task<GetDentriesResponse> GetDentriesWithOptionsAsync(string spaceId, GetDentriesRequest request, GetDentriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryIds))
            {
                body["dentryIds"] = request.DentryIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDentries",
                Version = "snsStorage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/snsStorage/spaces/" + spaceId + "/dentries/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDentriesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 三方个人应用批量获取文件或文件夹信息
         *
         * @param request GetDentriesRequest
         * @return GetDentriesResponse
         */
        public GetDentriesResponse GetDentries(string spaceId, GetDentriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDentriesHeaders headers = new GetDentriesHeaders();
            return GetDentriesWithOptions(spaceId, request, headers, runtime);
        }

        /**
         * @summary 三方个人应用批量获取文件或文件夹信息
         *
         * @param request GetDentriesRequest
         * @return GetDentriesResponse
         */
        public async Task<GetDentriesResponse> GetDentriesAsync(string spaceId, GetDentriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDentriesHeaders headers = new GetDentriesHeaders();
            return await GetDentriesWithOptionsAsync(spaceId, request, headers, runtime);
        }

        /**
         * @summary 三方个人应用获取文件(夹)信息
         *
         * @param request GetDentryRequest
         * @param headers GetDentryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDentryResponse
         */
        public GetDentryResponse GetDentryWithOptions(string spaceId, string dentryId, GetDentryRequest request, GetDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDentry",
                Version = "snsStorage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/snsStorage/spaces/" + spaceId + "/dentries/" + dentryId + "/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDentryResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 三方个人应用获取文件(夹)信息
         *
         * @param request GetDentryRequest
         * @param headers GetDentryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDentryResponse
         */
        public async Task<GetDentryResponse> GetDentryWithOptionsAsync(string spaceId, string dentryId, GetDentryRequest request, GetDentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDentry",
                Version = "snsStorage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/snsStorage/spaces/" + spaceId + "/dentries/" + dentryId + "/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDentryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 三方个人应用获取文件(夹)信息
         *
         * @param request GetDentryRequest
         * @return GetDentryResponse
         */
        public GetDentryResponse GetDentry(string spaceId, string dentryId, GetDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDentryHeaders headers = new GetDentryHeaders();
            return GetDentryWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        /**
         * @summary 三方个人应用获取文件(夹)信息
         *
         * @param request GetDentryRequest
         * @return GetDentryResponse
         */
        public async Task<GetDentryResponse> GetDentryAsync(string spaceId, string dentryId, GetDentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDentryHeaders headers = new GetDentryHeaders();
            return await GetDentryWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        /**
         * @summary 三方个人应用批量获取文件缩略图
         *
         * @param request GetDentryThumbnailsRequest
         * @param headers GetDentryThumbnailsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDentryThumbnailsResponse
         */
        public GetDentryThumbnailsResponse GetDentryThumbnailsWithOptions(string spaceId, GetDentryThumbnailsRequest request, GetDentryThumbnailsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryIds))
            {
                body["dentryIds"] = request.DentryIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDentryThumbnails",
                Version = "snsStorage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/snsStorage/spaces/" + spaceId + "/thumbnails/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDentryThumbnailsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 三方个人应用批量获取文件缩略图
         *
         * @param request GetDentryThumbnailsRequest
         * @param headers GetDentryThumbnailsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDentryThumbnailsResponse
         */
        public async Task<GetDentryThumbnailsResponse> GetDentryThumbnailsWithOptionsAsync(string spaceId, GetDentryThumbnailsRequest request, GetDentryThumbnailsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DentryIds))
            {
                body["dentryIds"] = request.DentryIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDentryThumbnails",
                Version = "snsStorage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/snsStorage/spaces/" + spaceId + "/thumbnails/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDentryThumbnailsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 三方个人应用批量获取文件缩略图
         *
         * @param request GetDentryThumbnailsRequest
         * @return GetDentryThumbnailsResponse
         */
        public GetDentryThumbnailsResponse GetDentryThumbnails(string spaceId, GetDentryThumbnailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDentryThumbnailsHeaders headers = new GetDentryThumbnailsHeaders();
            return GetDentryThumbnailsWithOptions(spaceId, request, headers, runtime);
        }

        /**
         * @summary 三方个人应用批量获取文件缩略图
         *
         * @param request GetDentryThumbnailsRequest
         * @return GetDentryThumbnailsResponse
         */
        public async Task<GetDentryThumbnailsResponse> GetDentryThumbnailsAsync(string spaceId, GetDentryThumbnailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDentryThumbnailsHeaders headers = new GetDentryThumbnailsHeaders();
            return await GetDentryThumbnailsWithOptionsAsync(spaceId, request, headers, runtime);
        }

        /**
         * @summary 三方个人应用获取文件下载信息
         *
         * @param request GetFileDownloadInfoRequest
         * @param headers GetFileDownloadInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFileDownloadInfoResponse
         */
        public GetFileDownloadInfoResponse GetFileDownloadInfoWithOptions(string spaceId, string dentryId, GetFileDownloadInfoRequest request, GetFileDownloadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileDownloadInfo",
                Version = "snsStorage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/snsStorage/spaces/" + spaceId + "/dentries/" + dentryId + "/downloadInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileDownloadInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 三方个人应用获取文件下载信息
         *
         * @param request GetFileDownloadInfoRequest
         * @param headers GetFileDownloadInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFileDownloadInfoResponse
         */
        public async Task<GetFileDownloadInfoResponse> GetFileDownloadInfoWithOptionsAsync(string spaceId, string dentryId, GetFileDownloadInfoRequest request, GetFileDownloadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileDownloadInfo",
                Version = "snsStorage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/snsStorage/spaces/" + spaceId + "/dentries/" + dentryId + "/downloadInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileDownloadInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 三方个人应用获取文件下载信息
         *
         * @param request GetFileDownloadInfoRequest
         * @return GetFileDownloadInfoResponse
         */
        public GetFileDownloadInfoResponse GetFileDownloadInfo(string spaceId, string dentryId, GetFileDownloadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileDownloadInfoHeaders headers = new GetFileDownloadInfoHeaders();
            return GetFileDownloadInfoWithOptions(spaceId, dentryId, request, headers, runtime);
        }

        /**
         * @summary 三方个人应用获取文件下载信息
         *
         * @param request GetFileDownloadInfoRequest
         * @return GetFileDownloadInfoResponse
         */
        public async Task<GetFileDownloadInfoResponse> GetFileDownloadInfoAsync(string spaceId, string dentryId, GetFileDownloadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileDownloadInfoHeaders headers = new GetFileDownloadInfoHeaders();
            return await GetFileDownloadInfoWithOptionsAsync(spaceId, dentryId, request, headers, runtime);
        }

        /**
         * @summary 三方个人应用获取IM会话存储空间信息
         *
         * @param request GetSpaceRequest
         * @param headers GetSpaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSpaceResponse
         */
        public GetSpaceResponse GetSpaceWithOptions(GetSpaceRequest request, GetSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSpace",
                Version = "snsStorage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/snsStorage/conversations/spaces/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSpaceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 三方个人应用获取IM会话存储空间信息
         *
         * @param request GetSpaceRequest
         * @param headers GetSpaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSpaceResponse
         */
        public async Task<GetSpaceResponse> GetSpaceWithOptionsAsync(GetSpaceRequest request, GetSpaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSpace",
                Version = "snsStorage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/snsStorage/conversations/spaces/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSpaceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 三方个人应用获取IM会话存储空间信息
         *
         * @param request GetSpaceRequest
         * @return GetSpaceResponse
         */
        public GetSpaceResponse GetSpace(GetSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpaceHeaders headers = new GetSpaceHeaders();
            return GetSpaceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 三方个人应用获取IM会话存储空间信息
         *
         * @param request GetSpaceRequest
         * @return GetSpaceResponse
         */
        public async Task<GetSpaceResponse> GetSpaceAsync(GetSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSpaceHeaders headers = new GetSpaceHeaders();
            return await GetSpaceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 三方个人应用获取全部文件或文件夹列表
         *
         * @param request ListAllDentriesRequest
         * @param headers ListAllDentriesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAllDentriesResponse
         */
        public ListAllDentriesResponse ListAllDentriesWithOptions(string spaceId, ListAllDentriesRequest request, ListAllDentriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAllDentries",
                Version = "snsStorage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/snsStorage/spaces/" + spaceId + "/dentries/listAll",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllDentriesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 三方个人应用获取全部文件或文件夹列表
         *
         * @param request ListAllDentriesRequest
         * @param headers ListAllDentriesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAllDentriesResponse
         */
        public async Task<ListAllDentriesResponse> ListAllDentriesWithOptionsAsync(string spaceId, ListAllDentriesRequest request, ListAllDentriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAllDentries",
                Version = "snsStorage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/snsStorage/spaces/" + spaceId + "/dentries/listAll",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllDentriesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 三方个人应用获取全部文件或文件夹列表
         *
         * @param request ListAllDentriesRequest
         * @return ListAllDentriesResponse
         */
        public ListAllDentriesResponse ListAllDentries(string spaceId, ListAllDentriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAllDentriesHeaders headers = new ListAllDentriesHeaders();
            return ListAllDentriesWithOptions(spaceId, request, headers, runtime);
        }

        /**
         * @summary 三方个人应用获取全部文件或文件夹列表
         *
         * @param request ListAllDentriesRequest
         * @return ListAllDentriesResponse
         */
        public async Task<ListAllDentriesResponse> ListAllDentriesAsync(string spaceId, ListAllDentriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAllDentriesHeaders headers = new ListAllDentriesHeaders();
            return await ListAllDentriesWithOptionsAsync(spaceId, request, headers, runtime);
        }

        /**
         * @summary 三方个人应用获取文件列表
         *
         * @param request ListDentriesRequest
         * @param headers ListDentriesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDentriesResponse
         */
        public ListDentriesResponse ListDentriesWithOptions(string spaceId, ListDentriesRequest request, ListDentriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["parentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithThumbnail))
            {
                query["withThumbnail"] = request.WithThumbnail;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDentries",
                Version = "snsStorage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/snsStorage/spaces/" + spaceId + "/dentries",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDentriesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 三方个人应用获取文件列表
         *
         * @param request ListDentriesRequest
         * @param headers ListDentriesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDentriesResponse
         */
        public async Task<ListDentriesResponse> ListDentriesWithOptionsAsync(string spaceId, ListDentriesRequest request, ListDentriesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["parentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithThumbnail))
            {
                query["withThumbnail"] = request.WithThumbnail;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDentries",
                Version = "snsStorage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/snsStorage/spaces/" + spaceId + "/dentries",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDentriesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 三方个人应用获取文件列表
         *
         * @param request ListDentriesRequest
         * @return ListDentriesResponse
         */
        public ListDentriesResponse ListDentries(string spaceId, ListDentriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDentriesHeaders headers = new ListDentriesHeaders();
            return ListDentriesWithOptions(spaceId, request, headers, runtime);
        }

        /**
         * @summary 三方个人应用获取文件列表
         *
         * @param request ListDentriesRequest
         * @return ListDentriesResponse
         */
        public async Task<ListDentriesResponse> ListDentriesAsync(string spaceId, ListDentriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListDentriesHeaders headers = new ListDentriesHeaders();
            return await ListDentriesWithOptionsAsync(spaceId, request, headers, runtime);
        }

        /**
         * @summary 获取会话过期文件列表
         *
         * @param request ListExpiredRequest
         * @param headers ListExpiredHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListExpiredResponse
         */
        public ListExpiredResponse ListExpiredWithOptions(ListExpiredRequest request, ListExpiredHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExpired",
                Version = "snsStorage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/snsStorage/conversations/expiredFileLists/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExpiredResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取会话过期文件列表
         *
         * @param request ListExpiredRequest
         * @param headers ListExpiredHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListExpiredResponse
         */
        public async Task<ListExpiredResponse> ListExpiredWithOptionsAsync(ListExpiredRequest request, ListExpiredHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["option"] = request.Option;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExpired",
                Version = "snsStorage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/snsStorage/conversations/expiredFileLists/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExpiredResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取会话过期文件列表
         *
         * @param request ListExpiredRequest
         * @return ListExpiredResponse
         */
        public ListExpiredResponse ListExpired(ListExpiredRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListExpiredHeaders headers = new ListExpiredHeaders();
            return ListExpiredWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取会话过期文件列表
         *
         * @param request ListExpiredRequest
         * @return ListExpiredResponse
         */
        public async Task<ListExpiredResponse> ListExpiredAsync(ListExpiredRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListExpiredHeaders headers = new ListExpiredHeaders();
            return await ListExpiredWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 三方个人应用订阅文件变更事件
         *
         * @param request SubscribeEventRequest
         * @param headers SubscribeEventHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubscribeEventResponse
         */
        public SubscribeEventResponse SubscribeEventWithOptions(SubscribeEventRequest request, SubscribeEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeId))
            {
                body["scopeId"] = request.ScopeId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubscribeEvent",
                Version = "snsStorage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/snsStorage/events/subscribe",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubscribeEventResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 三方个人应用订阅文件变更事件
         *
         * @param request SubscribeEventRequest
         * @param headers SubscribeEventHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubscribeEventResponse
         */
        public async Task<SubscribeEventResponse> SubscribeEventWithOptionsAsync(SubscribeEventRequest request, SubscribeEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeId))
            {
                body["scopeId"] = request.ScopeId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubscribeEvent",
                Version = "snsStorage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/snsStorage/events/subscribe",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubscribeEventResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 三方个人应用订阅文件变更事件
         *
         * @param request SubscribeEventRequest
         * @return SubscribeEventResponse
         */
        public SubscribeEventResponse SubscribeEvent(SubscribeEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SubscribeEventHeaders headers = new SubscribeEventHeaders();
            return SubscribeEventWithOptions(request, headers, runtime);
        }

        /**
         * @summary 三方个人应用订阅文件变更事件
         *
         * @param request SubscribeEventRequest
         * @return SubscribeEventResponse
         */
        public async Task<SubscribeEventResponse> SubscribeEventAsync(SubscribeEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SubscribeEventHeaders headers = new SubscribeEventHeaders();
            return await SubscribeEventWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 三方个人应用取消订阅文件变更事件
         *
         * @param request UnsubscribeEventRequest
         * @param headers UnsubscribeEventHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnsubscribeEventResponse
         */
        public UnsubscribeEventResponse UnsubscribeEventWithOptions(UnsubscribeEventRequest request, UnsubscribeEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeId))
            {
                body["scopeId"] = request.ScopeId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnsubscribeEvent",
                Version = "snsStorage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/snsStorage/events/unsubscribe",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnsubscribeEventResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 三方个人应用取消订阅文件变更事件
         *
         * @param request UnsubscribeEventRequest
         * @param headers UnsubscribeEventHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnsubscribeEventResponse
         */
        public async Task<UnsubscribeEventResponse> UnsubscribeEventWithOptionsAsync(UnsubscribeEventRequest request, UnsubscribeEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeId))
            {
                body["scopeId"] = request.ScopeId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnsubscribeEvent",
                Version = "snsStorage_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/snsStorage/events/unsubscribe",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnsubscribeEventResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 三方个人应用取消订阅文件变更事件
         *
         * @param request UnsubscribeEventRequest
         * @return UnsubscribeEventResponse
         */
        public UnsubscribeEventResponse UnsubscribeEvent(UnsubscribeEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnsubscribeEventHeaders headers = new UnsubscribeEventHeaders();
            return UnsubscribeEventWithOptions(request, headers, runtime);
        }

        /**
         * @summary 三方个人应用取消订阅文件变更事件
         *
         * @param request UnsubscribeEventRequest
         * @return UnsubscribeEventResponse
         */
        public async Task<UnsubscribeEventResponse> UnsubscribeEventAsync(UnsubscribeEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnsubscribeEventHeaders headers = new UnsubscribeEventHeaders();
            return await UnsubscribeEventWithOptionsAsync(request, headers, runtime);
        }

    }
}
