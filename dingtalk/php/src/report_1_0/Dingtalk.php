<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vreport_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models\CreateTemplatesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models\CreateTemplatesRequest;
use AlibabaCloud\SDK\Dingtalk\Vreport_1_0\Models\CreateTemplatesResponse;
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
     * @param CreateTemplatesRequest $request
     * @param CreateTemplatesHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return CreateTemplatesResponse
     */
    public function createTemplatesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->allowAddReceivers)) {
            $body['allowAddReceivers'] = $request->allowAddReceivers;
        }
        if (!Utils::isUnset($request->allowEdit)) {
            $body['allowEdit'] = $request->allowEdit;
        }
        if (!Utils::isUnset($request->allowGetLocation)) {
            $body['allowGetLocation'] = $request->allowGetLocation;
        }
        if (!Utils::isUnset($request->authDeptIds)) {
            $body['authDeptIds'] = $request->authDeptIds;
        }
        if (!Utils::isUnset($request->authUserIds)) {
            $body['authUserIds'] = $request->authUserIds;
        }
        if (!Utils::isUnset($request->creator)) {
            $body['creator'] = $request->creator;
        }
        if (!Utils::isUnset($request->defaultReceivedCids)) {
            $body['defaultReceivedCids'] = $request->defaultReceivedCids;
        }
        if (!Utils::isUnset($request->defaultReceivedMasterLevels)) {
            $body['defaultReceivedMasterLevels'] = $request->defaultReceivedMasterLevels;
        }
        if (!Utils::isUnset($request->defaultReceivers)) {
            $body['defaultReceivers'] = $request->defaultReceivers;
        }
        if (!Utils::isUnset($request->fields)) {
            $body['fields'] = $request->fields;
        }
        if (!Utils::isUnset($request->logo)) {
            $body['logo'] = $request->logo;
        }
        if (!Utils::isUnset($request->maxWordCount)) {
            $body['maxWordCount'] = $request->maxWordCount;
        }
        if (!Utils::isUnset($request->minWordCount)) {
            $body['minWordCount'] = $request->minWordCount;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->templateManagers)) {
            $body['templateManagers'] = $request->templateManagers;
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
            'action'      => 'CreateTemplates',
            'version'     => 'report_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/report/templates',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateTemplatesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateTemplatesRequest $request
     *
     * @return CreateTemplatesResponse
     */
    public function createTemplates($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTemplatesHeaders([]);

        return $this->createTemplatesWithOptions($request, $headers, $runtime);
    }
}
