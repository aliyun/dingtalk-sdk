<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjobs_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vjobs_1_0\Models\CreateResumeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vjobs_1_0\Models\CreateResumeRequest;
use AlibabaCloud\SDK\Dingtalk\Vjobs_1_0\Models\CreateResumeResponse;
use AlibabaCloud\SDK\Dingtalk\Vjobs_1_0\Models\PostResumeHeaders;
use AlibabaCloud\SDK\Dingtalk\Vjobs_1_0\Models\PostResumeRequest;
use AlibabaCloud\SDK\Dingtalk\Vjobs_1_0\Models\PostResumeResponse;
use AlibabaCloud\Tea\Utils\Utils;
use AlibabaCloud\Tea\Utils\Utils\RuntimeOptions;
use Darabonba\GatewayDingTalk\Client;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\Models\Params;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    public function __construct($config)
    {
        parent::__construct($config);
        $gatewayClient       = new Client();
        $this->_spi          = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 创建简历
     *  *
     * @param CreateResumeRequest $request CreateResumeRequest
     * @param CreateResumeHeaders $headers CreateResumeHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateResumeResponse CreateResumeResponse
     */
    public function createResumeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizCode)) {
            $body['bizCode'] = $request->bizCode;
        }
        if (!Utils::isUnset($request->ext)) {
            $body['ext'] = $request->ext;
        }
        if (!Utils::isUnset($request->resumeDataVO)) {
            $body['resumeDataVO'] = $request->resumeDataVO;
        }
        if (!Utils::isUnset($request->scene)) {
            $body['scene'] = $request->scene;
        }
        if (!Utils::isUnset($request->types)) {
            $body['types'] = $request->types;
        }
        if (!Utils::isUnset($request->userIdentify)) {
            $body['userIdentify'] = $request->userIdentify;
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
            'action'      => 'CreateResume',
            'version'     => 'jobs_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/jobs/resumes',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateResumeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建简历
     *  *
     * @param CreateResumeRequest $request CreateResumeRequest
     *
     * @return CreateResumeResponse CreateResumeResponse
     */
    public function createResume($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateResumeHeaders([]);

        return $this->createResumeWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 投递简历
     *  *
     * @param PostResumeRequest $request PostResumeRequest
     * @param PostResumeHeaders $headers PostResumeHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return PostResumeResponse PostResumeResponse
     */
    public function postResumeWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->jobId)) {
            $body['jobId'] = $request->jobId;
        }
        if (!Utils::isUnset($request->userIdentify)) {
            $body['userIdentify'] = $request->userIdentify;
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
            'action'      => 'PostResume',
            'version'     => 'jobs_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/jobs/resumes/post',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PostResumeResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 投递简历
     *  *
     * @param PostResumeRequest $request PostResumeRequest
     *
     * @return PostResumeResponse PostResumeResponse
     */
    public function postResume($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PostResumeHeaders([]);

        return $this->postResumeWithOptions($request, $headers, $runtime);
    }
}
