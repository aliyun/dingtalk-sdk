// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkyun_shu_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkyun_shu_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            AlibabaCloud.GatewayDingTalk.Client gatewayClient = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = gatewayClient;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /**
         * @summary 生态日志数据互通
         *
         * @param request SaveOpenExternalLogRequest
         * @param headers SaveOpenExternalLogHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveOpenExternalLogResponse
         */
        public SaveOpenExternalLogResponse SaveOpenExternalLogWithOptions(SaveOpenExternalLogRequest request, SaveOpenExternalLogHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSource))
            {
                body["logSource"] = request.LogSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogType))
            {
                body["logType"] = request.LogType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenExt))
            {
                body["openExt"] = request.OpenExt;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveOpenExternalLog",
                Version = "yunShu_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yunShu/externalLogs/save",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveOpenExternalLogResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 生态日志数据互通
         *
         * @param request SaveOpenExternalLogRequest
         * @param headers SaveOpenExternalLogHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveOpenExternalLogResponse
         */
        public async Task<SaveOpenExternalLogResponse> SaveOpenExternalLogWithOptionsAsync(SaveOpenExternalLogRequest request, SaveOpenExternalLogHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSource))
            {
                body["logSource"] = request.LogSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogType))
            {
                body["logType"] = request.LogType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenExt))
            {
                body["openExt"] = request.OpenExt;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveOpenExternalLog",
                Version = "yunShu_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/yunShu/externalLogs/save",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveOpenExternalLogResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 生态日志数据互通
         *
         * @param request SaveOpenExternalLogRequest
         * @return SaveOpenExternalLogResponse
         */
        public SaveOpenExternalLogResponse SaveOpenExternalLog(SaveOpenExternalLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveOpenExternalLogHeaders headers = new SaveOpenExternalLogHeaders();
            return SaveOpenExternalLogWithOptions(request, headers, runtime);
        }

        /**
         * @summary 生态日志数据互通
         *
         * @param request SaveOpenExternalLogRequest
         * @return SaveOpenExternalLogResponse
         */
        public async Task<SaveOpenExternalLogResponse> SaveOpenExternalLogAsync(SaveOpenExternalLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveOpenExternalLogHeaders headers = new SaveOpenExternalLogHeaders();
            return await SaveOpenExternalLogWithOptionsAsync(request, headers, runtime);
        }

    }
}
