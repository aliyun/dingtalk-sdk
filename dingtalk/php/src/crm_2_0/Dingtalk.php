<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_2_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vcrm_2_0\Models\GetRelationUkSettingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vcrm_2_0\Models\GetRelationUkSettingRequest;
use AlibabaCloud\SDK\Dingtalk\Vcrm_2_0\Models\GetRelationUkSettingResponse;
use AlibabaCloud\Tea\Utils\Utils;
use AlibabaCloud\Tea\Utils\Utils\RuntimeOptions;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    public function __construct($config)
    {
        parent::__construct($config);
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
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
            @$query['relationType'] = $request->relationType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetRelationUkSettingResponse::fromMap($this->doROARequest('GetRelationUkSetting', 'crm_2.0', 'HTTP', 'GET', 'AK', '/v2.0/crm/relationUkSettings', 'json', $req, $runtime));
    }
}
