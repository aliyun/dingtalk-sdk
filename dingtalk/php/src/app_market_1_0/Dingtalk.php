<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\UserTaskReportHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\UserTaskReportRequest;
use AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models\UserTaskReportResponse;
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
     * @param UserTaskReportRequest $request
     *
     * @return UserTaskReportResponse
     */
    public function userTaskReport($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UserTaskReportHeaders([]);

        return $this->userTaskReportWithOptions($request, $headers, $runtime);
    }

    /**
     * @param UserTaskReportRequest $request
     * @param UserTaskReportHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return UserTaskReportResponse
     */
    public function userTaskReportWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dingCorpId)) {
            @$body['dingCorpId'] = $request->dingCorpId;
        }
        if (!Utils::isUnset($request->taskTag)) {
            @$body['taskTag'] = $request->taskTag;
        }
        if (!Utils::isUnset($request->operateDate)) {
            @$body['operateDate'] = $request->operateDate;
        }
        if (!Utils::isUnset($request->userid)) {
            @$body['userid'] = $request->userid;
        }
        if (!Utils::isUnset($request->bizNo)) {
            @$body['bizNo'] = $request->bizNo;
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

        return UserTaskReportResponse::fromMap($this->doROARequest('UserTaskReport', 'appMarket_1.0', 'HTTP', 'POST', 'AK', '/v1.0/appMarket/tasks', 'boolean', $req, $runtime));
    }
}
