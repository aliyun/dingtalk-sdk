<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyun_shu_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vyun_shu_1_0\Models\SaveOpenExternalLogHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyun_shu_1_0\Models\SaveOpenExternalLogRequest;
use AlibabaCloud\SDK\Dingtalk\Vyun_shu_1_0\Models\SaveOpenExternalLogResponse;
use AlibabaCloud\Tea\Utils\Utils;
use AlibabaCloud\Tea\Utils\Utils\RuntimeOptions;
use Darabonba\GatewayDingTalk\Client as DarabonbaGatewayDingTalkClient;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\Models\Params;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    protected $_client;

    public function __construct($config)
    {
        parent::__construct($config);
        $this->_client       = new DarabonbaGatewayDingTalkClient();
        $this->_spi          = $this->_client;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @param SaveOpenExternalLogRequest $request
     * @param SaveOpenExternalLogHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return SaveOpenExternalLogResponse
     */
    public function saveOpenExternalLogWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->corpId)) {
            $body['corpId'] = $request->corpId;
        }
        if (!Utils::isUnset($request->logSource)) {
            $body['logSource'] = $request->logSource;
        }
        if (!Utils::isUnset($request->logType)) {
            $body['logType'] = $request->logType;
        }
        if (!Utils::isUnset($request->openExt)) {
            $body['openExt'] = $request->openExt;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SaveOpenExternalLog',
            'version'     => 'yunShu_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/yunShu/externalLogs/save',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SaveOpenExternalLogResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SaveOpenExternalLogRequest $request
     *
     * @return SaveOpenExternalLogResponse
     */
    public function saveOpenExternalLog($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveOpenExternalLogHeaders([]);

        return $this->saveOpenExternalLogWithOptions($request, $headers, $runtime);
    }
}
