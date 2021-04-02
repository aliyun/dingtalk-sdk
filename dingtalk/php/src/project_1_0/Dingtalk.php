<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTbProjectGrayHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTbProjectGrayRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTbProjectGrayResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTbProjectSourceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTbProjectSourceResponse;
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
     * @return GetTbProjectSourceResponse
     */
    public function getTbProjectSource()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTbProjectSourceHeaders([]);

        return $this->getTbProjectSourceWithOptions($headers, $runtime);
    }

    /**
     * @param GetTbProjectSourceHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetTbProjectSourceResponse
     */
    public function getTbProjectSourceWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->dingOrgId)) {
            @$realHeaders['dingOrgId'] = $headers->dingOrgId;
        }
        if (!Utils::isUnset($headers->dingIsvOrgId)) {
            @$realHeaders['dingIsvOrgId'] = $headers->dingIsvOrgId;
        }
        if (!Utils::isUnset($headers->dingCorpId)) {
            @$realHeaders['dingCorpId'] = $headers->dingCorpId;
        }
        if (!Utils::isUnset($headers->dingSuiteKey)) {
            @$realHeaders['dingSuiteKey'] = $headers->dingSuiteKey;
        }
        if (!Utils::isUnset($headers->dingAccessTokenType)) {
            @$realHeaders['dingAccessTokenType'] = $headers->dingAccessTokenType;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetTbProjectSourceResponse::fromMap($this->doROARequest('GetTbProjectSource', 'project_1.0', 'HTTP', 'POST', 'AK', '/v1.0/project/projects/source', 'json', $req, $runtime));
    }

    /**
     * @param GetTbProjectGrayRequest $request
     *
     * @return GetTbProjectGrayResponse
     */
    public function getTbProjectGray($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTbProjectGrayHeaders([]);

        return $this->getTbProjectGrayWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetTbProjectGrayRequest $request
     * @param GetTbProjectGrayHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return GetTbProjectGrayResponse
     */
    public function getTbProjectGrayWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->label)) {
            @$body['label'] = $request->label;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->dingAccessTokenType)) {
            @$realHeaders['dingAccessTokenType'] = $headers->dingAccessTokenType;
        }
        if (!Utils::isUnset($headers->dingSuiteKey)) {
            @$realHeaders['dingSuiteKey'] = $headers->dingSuiteKey;
        }
        if (!Utils::isUnset($headers->dingIsvOrgId)) {
            @$realHeaders['dingIsvOrgId'] = $headers->dingIsvOrgId;
        }
        if (!Utils::isUnset($headers->dingOrgId)) {
            @$realHeaders['dingOrgId'] = $headers->dingOrgId;
        }
        if (!Utils::isUnset($headers->dingCorpId)) {
            @$realHeaders['dingCorpId'] = $headers->dingCorpId;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GetTbProjectGrayResponse::fromMap($this->doROARequest('GetTbProjectGray', 'project_1.0', 'HTTP', 'POST', 'AK', '/v1.0/project/projects/gray', 'json', $req, $runtime));
    }
}
