<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\CreateInnerAppHeaders;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\CreateInnerAppRequest;
use AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\CreateInnerAppResponse;
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
     * @param CreateInnerAppRequest $request
     *
     * @return CreateInnerAppResponse
     */
    public function createInnerApp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateInnerAppHeaders([]);

        return $this->createInnerAppWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateInnerAppRequest $request
     * @param CreateInnerAppHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return CreateInnerAppResponse
     */
    public function createInnerAppWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->creatorUnionId)) {
            @$body['creatorUnionId'] = $request->creatorUnionId;
        }
        if (!Utils::isUnset($request->ecologicalCorpId)) {
            @$body['ecologicalCorpId'] = $request->ecologicalCorpId;
        }
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->desc)) {
            @$body['desc'] = $request->desc;
        }
        if (!Utils::isUnset($request->icon)) {
            @$body['icon'] = $request->icon;
        }
        if (!Utils::isUnset($request->homepageLink)) {
            @$body['homepageLink'] = $request->homepageLink;
        }
        if (!Utils::isUnset($request->pcHomepageLink)) {
            @$body['pcHomepageLink'] = $request->pcHomepageLink;
        }
        if (!Utils::isUnset($request->ompLink)) {
            @$body['ompLink'] = $request->ompLink;
        }
        if (!Utils::isUnset($request->ipWhiteList)) {
            @$body['ipWhiteList'] = $request->ipWhiteList;
        }
        if (!Utils::isUnset($request->scopeType)) {
            @$body['scopeType'] = $request->scopeType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateInnerAppResponse::fromMap($this->doROARequest('CreateInnerApp', 'microApp_1.0', 'HTTP', 'POST', 'AK', '/v1.0/microApp/apps', 'json', $req, $runtime));
    }
}
