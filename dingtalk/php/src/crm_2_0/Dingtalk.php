<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_2_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vcrm_2_0\Models\GetRelationUkSettingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_2_0\Models\GetRelationUkSettingRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_2_0\Models\GetRelationUkSettingResponse;
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
     * @param GetRelationUkSettingRequest $request
     * @param GetRelationUkSettingHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return GetRelationUkSettingResponse
     */
    public function getRelationUkSettingWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->relationType)) {
            $query['relationType'] = $request->relationType;
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
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetRelationUkSetting',
            'version'     => 'crm_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/crm/relationUkSettings',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetRelationUkSettingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetRelationUkSettingRequest $request
     *
     * @return GetRelationUkSettingResponse
     */
    public function getRelationUkSetting($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRelationUkSettingHeaders([]);

        return $this->getRelationUkSettingWithOptions($request, $headers, $runtime);
    }
}
