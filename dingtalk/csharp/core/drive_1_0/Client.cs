// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkdrive_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkdrive_1_0
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


        public GetDownloadInfoResponse GetDownloadInfo(string userId, string spaceId, string fileId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDownloadInfoHeaders headers = new GetDownloadInfoHeaders();
            return GetDownloadInfoWithOptions(userId, spaceId, fileId, headers, runtime);
        }

        public async Task<GetDownloadInfoResponse> GetDownloadInfoAsync(string userId, string spaceId, string fileId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDownloadInfoHeaders headers = new GetDownloadInfoHeaders();
            return await GetDownloadInfoWithOptionsAsync(userId, spaceId, fileId, headers, runtime);
        }

        public GetDownloadInfoResponse GetDownloadInfoWithOptions(string userId, string spaceId, string fileId, GetDownloadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<GetDownloadInfoResponse>(DoROARequest("GetDownloadInfo", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/users/" + userId + "/spaces/" + spaceId + "/files/" + fileId + "/downloadInfo", "json", req, runtime));
        }

        public async Task<GetDownloadInfoResponse> GetDownloadInfoWithOptionsAsync(string userId, string spaceId, string fileId, GetDownloadInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<GetDownloadInfoResponse>(await DoROARequestAsync("GetDownloadInfo", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/users/" + userId + "/spaces/" + spaceId + "/files/" + fileId + "/downloadInfo", "json", req, runtime));
        }

    }
}
