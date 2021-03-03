<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CreateApproveHeaders;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CreateApproveRequest;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CreateApproveResponse;
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
     * @param CreateApproveRequest $request
     *
     * @return CreateApproveResponse
     */
    public function createApprove($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateApproveHeaders([]);

        return $this->createApproveWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateApproveRequest $request
     * @param CreateApproveHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return CreateApproveResponse
     */
    public function createApproveWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->userid)) {
            @$body['userid'] = $request->userid;
        }
        if (!Utils::isUnset($request->tagName)) {
            @$body['tagName'] = $request->tagName;
        }
        if (!Utils::isUnset($request->subType)) {
            @$body['subType'] = $request->subType;
        }
        if (!Utils::isUnset($request->punchParam)) {
            @$body['punchParam'] = $request->punchParam;
        }
        if (!Utils::isUnset($request->approveId)) {
            @$body['approveId'] = $request->approveId;
        }
        if (!Utils::isUnset($request->opUserid)) {
            @$body['opUserid'] = $request->opUserid;
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

        return CreateApproveResponse::fromMap($this->doROARequest('CreateApprove', 'attendance_1.0', 'HTTP', 'POST', 'AK', '/v1.0/attendance/approves', 'json', $req, $runtime));
    }
}
