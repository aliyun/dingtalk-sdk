// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkpedia_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkpedia_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        public PediaWordsAddResponse PediaWordsAdd(PediaWordsAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsAddHeaders headers = new PediaWordsAddHeaders();
            return PediaWordsAddWithOptions(request, headers, runtime);
        }

        public async Task<PediaWordsAddResponse> PediaWordsAddAsync(PediaWordsAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsAddHeaders headers = new PediaWordsAddHeaders();
            return await PediaWordsAddWithOptionsAsync(request, headers, runtime);
        }

        public PediaWordsAddResponse PediaWordsAddWithOptions(PediaWordsAddRequest request, PediaWordsAddHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactList))
            {
                body["contactList"] = request.ContactList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HighLightWordAlias))
            {
                body["highLightWordAlias"] = request.HighLightWordAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PicList))
            {
                body["picList"] = request.PicList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedDoc))
            {
                body["relatedDoc"] = request.RelatedDoc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedLink))
            {
                body["relatedLink"] = request.RelatedLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordAlias))
            {
                body["wordAlias"] = request.WordAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordName))
            {
                body["wordName"] = request.WordName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordParaphrase))
            {
                body["wordParaphrase"] = request.WordParaphrase;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<PediaWordsAddResponse>(DoROARequest("PediaWordsAdd", "pedia_1.0", "HTTP", "POST", "AK", "/v1.0/pedia/words", "json", req, runtime));
        }

        public async Task<PediaWordsAddResponse> PediaWordsAddWithOptionsAsync(PediaWordsAddRequest request, PediaWordsAddHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactList))
            {
                body["contactList"] = request.ContactList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HighLightWordAlias))
            {
                body["highLightWordAlias"] = request.HighLightWordAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PicList))
            {
                body["picList"] = request.PicList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedDoc))
            {
                body["relatedDoc"] = request.RelatedDoc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedLink))
            {
                body["relatedLink"] = request.RelatedLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordAlias))
            {
                body["wordAlias"] = request.WordAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordName))
            {
                body["wordName"] = request.WordName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordParaphrase))
            {
                body["wordParaphrase"] = request.WordParaphrase;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<PediaWordsAddResponse>(await DoROARequestAsync("PediaWordsAdd", "pedia_1.0", "HTTP", "POST", "AK", "/v1.0/pedia/words", "json", req, runtime));
        }

        public PediaWordsApproveResponse PediaWordsApprove(PediaWordsApproveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsApproveHeaders headers = new PediaWordsApproveHeaders();
            return PediaWordsApproveWithOptions(request, headers, runtime);
        }

        public async Task<PediaWordsApproveResponse> PediaWordsApproveAsync(PediaWordsApproveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsApproveHeaders headers = new PediaWordsApproveHeaders();
            return await PediaWordsApproveWithOptionsAsync(request, headers, runtime);
        }

        public PediaWordsApproveResponse PediaWordsApproveWithOptions(PediaWordsApproveRequest request, PediaWordsApproveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApproveReason))
            {
                body["approveReason"] = request.ApproveReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApproveStatus))
            {
                body["approveStatus"] = request.ApproveStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImHighLight))
            {
                body["imHighLight"] = request.ImHighLight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SimHighLight))
            {
                body["simHighLight"] = request.SimHighLight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<PediaWordsApproveResponse>(DoROARequest("PediaWordsApprove", "pedia_1.0", "HTTP", "POST", "AK", "/v1.0/pedia/words/approve", "json", req, runtime));
        }

        public async Task<PediaWordsApproveResponse> PediaWordsApproveWithOptionsAsync(PediaWordsApproveRequest request, PediaWordsApproveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApproveReason))
            {
                body["approveReason"] = request.ApproveReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApproveStatus))
            {
                body["approveStatus"] = request.ApproveStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImHighLight))
            {
                body["imHighLight"] = request.ImHighLight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SimHighLight))
            {
                body["simHighLight"] = request.SimHighLight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<PediaWordsApproveResponse>(await DoROARequestAsync("PediaWordsApprove", "pedia_1.0", "HTTP", "POST", "AK", "/v1.0/pedia/words/approve", "json", req, runtime));
        }

        public PediaWordsDeleteResponse PediaWordsDelete(PediaWordsDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsDeleteHeaders headers = new PediaWordsDeleteHeaders();
            return PediaWordsDeleteWithOptions(request, headers, runtime);
        }

        public async Task<PediaWordsDeleteResponse> PediaWordsDeleteAsync(PediaWordsDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsDeleteHeaders headers = new PediaWordsDeleteHeaders();
            return await PediaWordsDeleteWithOptionsAsync(request, headers, runtime);
        }

        public PediaWordsDeleteResponse PediaWordsDeleteWithOptions(PediaWordsDeleteRequest request, PediaWordsDeleteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["uuid"] = request.Uuid;
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
            return TeaModel.ToObject<PediaWordsDeleteResponse>(DoROARequest("PediaWordsDelete", "pedia_1.0", "HTTP", "DELETE", "AK", "/v1.0/pedia/words", "json", req, runtime));
        }

        public async Task<PediaWordsDeleteResponse> PediaWordsDeleteWithOptionsAsync(PediaWordsDeleteRequest request, PediaWordsDeleteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["uuid"] = request.Uuid;
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
            return TeaModel.ToObject<PediaWordsDeleteResponse>(await DoROARequestAsync("PediaWordsDelete", "pedia_1.0", "HTTP", "DELETE", "AK", "/v1.0/pedia/words", "json", req, runtime));
        }

        public PediaWordsQueryResponse PediaWordsQuery(PediaWordsQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsQueryHeaders headers = new PediaWordsQueryHeaders();
            return PediaWordsQueryWithOptions(request, headers, runtime);
        }

        public async Task<PediaWordsQueryResponse> PediaWordsQueryAsync(PediaWordsQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsQueryHeaders headers = new PediaWordsQueryHeaders();
            return await PediaWordsQueryWithOptionsAsync(request, headers, runtime);
        }

        public PediaWordsQueryResponse PediaWordsQueryWithOptions(PediaWordsQueryRequest request, PediaWordsQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["uuid"] = request.Uuid;
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
            return TeaModel.ToObject<PediaWordsQueryResponse>(DoROARequest("PediaWordsQuery", "pedia_1.0", "HTTP", "POST", "AK", "/v1.0/pedia/words/query", "json", req, runtime));
        }

        public async Task<PediaWordsQueryResponse> PediaWordsQueryWithOptionsAsync(PediaWordsQueryRequest request, PediaWordsQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["uuid"] = request.Uuid;
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
            return TeaModel.ToObject<PediaWordsQueryResponse>(await DoROARequestAsync("PediaWordsQuery", "pedia_1.0", "HTTP", "POST", "AK", "/v1.0/pedia/words/query", "json", req, runtime));
        }

        public PediaWordsSearchResponse PediaWordsSearch(PediaWordsSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsSearchHeaders headers = new PediaWordsSearchHeaders();
            return PediaWordsSearchWithOptions(request, headers, runtime);
        }

        public async Task<PediaWordsSearchResponse> PediaWordsSearchAsync(PediaWordsSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsSearchHeaders headers = new PediaWordsSearchHeaders();
            return await PediaWordsSearchWithOptionsAsync(request, headers, runtime);
        }

        public PediaWordsSearchResponse PediaWordsSearchWithOptions(PediaWordsSearchRequest request, PediaWordsSearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordName))
            {
                body["wordName"] = request.WordName;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<PediaWordsSearchResponse>(DoROARequest("PediaWordsSearch", "pedia_1.0", "HTTP", "POST", "AK", "/v1.0/pedia/words/search", "json", req, runtime));
        }

        public async Task<PediaWordsSearchResponse> PediaWordsSearchWithOptionsAsync(PediaWordsSearchRequest request, PediaWordsSearchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordName))
            {
                body["wordName"] = request.WordName;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<PediaWordsSearchResponse>(await DoROARequestAsync("PediaWordsSearch", "pedia_1.0", "HTTP", "POST", "AK", "/v1.0/pedia/words/search", "json", req, runtime));
        }

        public PediaWordsUpdateResponse PediaWordsUpdate(PediaWordsUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsUpdateHeaders headers = new PediaWordsUpdateHeaders();
            return PediaWordsUpdateWithOptions(request, headers, runtime);
        }

        public async Task<PediaWordsUpdateResponse> PediaWordsUpdateAsync(PediaWordsUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PediaWordsUpdateHeaders headers = new PediaWordsUpdateHeaders();
            return await PediaWordsUpdateWithOptionsAsync(request, headers, runtime);
        }

        public PediaWordsUpdateResponse PediaWordsUpdateWithOptions(PediaWordsUpdateRequest request, PediaWordsUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppLink))
            {
                body["appLink"] = request.AppLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactList))
            {
                body["contactList"] = request.ContactList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HighLightWordAlias))
            {
                body["highLightWordAlias"] = request.HighLightWordAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PicList))
            {
                body["picList"] = request.PicList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedDoc))
            {
                body["relatedDoc"] = request.RelatedDoc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedLink))
            {
                body["relatedLink"] = request.RelatedLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordAlias))
            {
                body["wordAlias"] = request.WordAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordName))
            {
                body["wordName"] = request.WordName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordParaphrase))
            {
                body["wordParaphrase"] = request.WordParaphrase;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<PediaWordsUpdateResponse>(DoROARequest("PediaWordsUpdate", "pedia_1.0", "HTTP", "PUT", "AK", "/v1.0/pedia/words", "json", req, runtime));
        }

        public async Task<PediaWordsUpdateResponse> PediaWordsUpdateWithOptionsAsync(PediaWordsUpdateRequest request, PediaWordsUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppLink))
            {
                body["appLink"] = request.AppLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactList))
            {
                body["contactList"] = request.ContactList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HighLightWordAlias))
            {
                body["highLightWordAlias"] = request.HighLightWordAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PicList))
            {
                body["picList"] = request.PicList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedDoc))
            {
                body["relatedDoc"] = request.RelatedDoc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedLink))
            {
                body["relatedLink"] = request.RelatedLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordAlias))
            {
                body["wordAlias"] = request.WordAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordName))
            {
                body["wordName"] = request.WordName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordParaphrase))
            {
                body["wordParaphrase"] = request.WordParaphrase;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<PediaWordsUpdateResponse>(await DoROARequestAsync("PediaWordsUpdate", "pedia_1.0", "HTTP", "PUT", "AK", "/v1.0/pedia/words", "json", req, runtime));
        }

    }
}
