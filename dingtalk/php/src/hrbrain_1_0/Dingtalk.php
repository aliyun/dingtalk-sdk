<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportAwardDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportAwardDetailRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportAwardDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportDeptInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportDeptInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportDeptInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportDimissionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportDimissionRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportDimissionResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportEduExpHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportEduExpRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportEduExpResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportEmpInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportEmpInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportEmpInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportLabelBaseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportLabelBaseRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportLabelBaseResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportLabelCustomHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportLabelCustomRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportLabelCustomResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportLabelIndustryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportLabelIndustryRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportLabelIndustryResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportLabelInventoryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportLabelInventoryRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportLabelInventoryResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportLabelProfSkillHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportLabelProfSkillRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportLabelProfSkillResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportPerfEvalHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportPerfEvalRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportPerfEvalResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportPromEvalHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportPromEvalRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportPromEvalResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportPunDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportPunDetailRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportPunDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportRegistHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportRegistRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportRegistResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportTransferEvalHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportTransferEvalRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportTransferEvalResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportWorkExpHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportWorkExpRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportWorkExpResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\SyncDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\SyncDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\SyncDataResponse;
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
     * @param HrbrainImportAwardDetailRequest $request
     * @param HrbrainImportAwardDetailHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return HrbrainImportAwardDetailResponse
     */
    public function hrbrainImportAwardDetailWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
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
            'body'    => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action'      => 'HrbrainImportAwardDetail',
            'version'     => 'hrbrain_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/hrbrain/datas/awardDetails/import',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return HrbrainImportAwardDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param HrbrainImportAwardDetailRequest $request
     *
     * @return HrbrainImportAwardDetailResponse
     */
    public function hrbrainImportAwardDetail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportAwardDetailHeaders([]);

        return $this->hrbrainImportAwardDetailWithOptions($request, $headers, $runtime);
    }

    /**
     * @param HrbrainImportDeptInfoRequest $request
     * @param HrbrainImportDeptInfoHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return HrbrainImportDeptInfoResponse
     */
    public function hrbrainImportDeptInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
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
            'body'    => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action'      => 'HrbrainImportDeptInfo',
            'version'     => 'hrbrain_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/hrbrain/datas/deptInfos/import',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return HrbrainImportDeptInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param HrbrainImportDeptInfoRequest $request
     *
     * @return HrbrainImportDeptInfoResponse
     */
    public function hrbrainImportDeptInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportDeptInfoHeaders([]);

        return $this->hrbrainImportDeptInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param HrbrainImportDimissionRequest $request
     * @param HrbrainImportDimissionHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return HrbrainImportDimissionResponse
     */
    public function hrbrainImportDimissionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
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
            'body'    => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action'      => 'HrbrainImportDimission',
            'version'     => 'hrbrain_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/hrbrain/datas/dimissionInfos/import',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return HrbrainImportDimissionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param HrbrainImportDimissionRequest $request
     *
     * @return HrbrainImportDimissionResponse
     */
    public function hrbrainImportDimission($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportDimissionHeaders([]);

        return $this->hrbrainImportDimissionWithOptions($request, $headers, $runtime);
    }

    /**
     * @param HrbrainImportEduExpRequest $request
     * @param HrbrainImportEduExpHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return HrbrainImportEduExpResponse
     */
    public function hrbrainImportEduExpWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
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
            'body'    => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action'      => 'HrbrainImportEduExp',
            'version'     => 'hrbrain_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/hrbrain/datas/eduExperiences/import',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return HrbrainImportEduExpResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param HrbrainImportEduExpRequest $request
     *
     * @return HrbrainImportEduExpResponse
     */
    public function hrbrainImportEduExp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportEduExpHeaders([]);

        return $this->hrbrainImportEduExpWithOptions($request, $headers, $runtime);
    }

    /**
     * @param HrbrainImportEmpInfoRequest $request
     * @param HrbrainImportEmpInfoHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return HrbrainImportEmpInfoResponse
     */
    public function hrbrainImportEmpInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
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
            'body'    => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action'      => 'HrbrainImportEmpInfo',
            'version'     => 'hrbrain_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/hrbrain/datas/empInfos/import',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return HrbrainImportEmpInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param HrbrainImportEmpInfoRequest $request
     *
     * @return HrbrainImportEmpInfoResponse
     */
    public function hrbrainImportEmpInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportEmpInfoHeaders([]);

        return $this->hrbrainImportEmpInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @param HrbrainImportLabelBaseRequest $request
     * @param HrbrainImportLabelBaseHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return HrbrainImportLabelBaseResponse
     */
    public function hrbrainImportLabelBaseWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
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
            'body'    => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action'      => 'HrbrainImportLabelBase',
            'version'     => 'hrbrain_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/hrbrain/datas/baseLabels/import',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return HrbrainImportLabelBaseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param HrbrainImportLabelBaseRequest $request
     *
     * @return HrbrainImportLabelBaseResponse
     */
    public function hrbrainImportLabelBase($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportLabelBaseHeaders([]);

        return $this->hrbrainImportLabelBaseWithOptions($request, $headers, $runtime);
    }

    /**
     * @param HrbrainImportLabelCustomRequest $request
     * @param HrbrainImportLabelCustomHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return HrbrainImportLabelCustomResponse
     */
    public function hrbrainImportLabelCustomWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
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
            'body'    => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action'      => 'HrbrainImportLabelCustom',
            'version'     => 'hrbrain_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/hrbrain/datas/customLabels/import',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return HrbrainImportLabelCustomResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param HrbrainImportLabelCustomRequest $request
     *
     * @return HrbrainImportLabelCustomResponse
     */
    public function hrbrainImportLabelCustom($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportLabelCustomHeaders([]);

        return $this->hrbrainImportLabelCustomWithOptions($request, $headers, $runtime);
    }

    /**
     * @param HrbrainImportLabelIndustryRequest $request
     * @param HrbrainImportLabelIndustryHeaders $headers
     * @param RuntimeOptions                    $runtime
     *
     * @return HrbrainImportLabelIndustryResponse
     */
    public function hrbrainImportLabelIndustryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
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
            'body'    => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action'      => 'HrbrainImportLabelIndustry',
            'version'     => 'hrbrain_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/hrbrain/datas/industries/import',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return HrbrainImportLabelIndustryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param HrbrainImportLabelIndustryRequest $request
     *
     * @return HrbrainImportLabelIndustryResponse
     */
    public function hrbrainImportLabelIndustry($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportLabelIndustryHeaders([]);

        return $this->hrbrainImportLabelIndustryWithOptions($request, $headers, $runtime);
    }

    /**
     * @param HrbrainImportLabelInventoryRequest $request
     * @param HrbrainImportLabelInventoryHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return HrbrainImportLabelInventoryResponse
     */
    public function hrbrainImportLabelInventoryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
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
            'body'    => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action'      => 'HrbrainImportLabelInventory',
            'version'     => 'hrbrain_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/hrbrain/datas/inventories/import',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return HrbrainImportLabelInventoryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param HrbrainImportLabelInventoryRequest $request
     *
     * @return HrbrainImportLabelInventoryResponse
     */
    public function hrbrainImportLabelInventory($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportLabelInventoryHeaders([]);

        return $this->hrbrainImportLabelInventoryWithOptions($request, $headers, $runtime);
    }

    /**
     * @param HrbrainImportLabelProfSkillRequest $request
     * @param HrbrainImportLabelProfSkillHeaders $headers
     * @param RuntimeOptions                     $runtime
     *
     * @return HrbrainImportLabelProfSkillResponse
     */
    public function hrbrainImportLabelProfSkillWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
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
            'body'    => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action'      => 'HrbrainImportLabelProfSkill',
            'version'     => 'hrbrain_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/hrbrain/datas/profSkills/import',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return HrbrainImportLabelProfSkillResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param HrbrainImportLabelProfSkillRequest $request
     *
     * @return HrbrainImportLabelProfSkillResponse
     */
    public function hrbrainImportLabelProfSkill($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportLabelProfSkillHeaders([]);

        return $this->hrbrainImportLabelProfSkillWithOptions($request, $headers, $runtime);
    }

    /**
     * @param HrbrainImportPerfEvalRequest $request
     * @param HrbrainImportPerfEvalHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return HrbrainImportPerfEvalResponse
     */
    public function hrbrainImportPerfEvalWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
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
            'body'    => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action'      => 'HrbrainImportPerfEval',
            'version'     => 'hrbrain_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/hrbrain/datas/perfRecords/import',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return HrbrainImportPerfEvalResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param HrbrainImportPerfEvalRequest $request
     *
     * @return HrbrainImportPerfEvalResponse
     */
    public function hrbrainImportPerfEval($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportPerfEvalHeaders([]);

        return $this->hrbrainImportPerfEvalWithOptions($request, $headers, $runtime);
    }

    /**
     * @param HrbrainImportPromEvalRequest $request
     * @param HrbrainImportPromEvalHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return HrbrainImportPromEvalResponse
     */
    public function hrbrainImportPromEvalWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
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
            'body'    => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action'      => 'HrbrainImportPromEval',
            'version'     => 'hrbrain_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/hrbrain/datas/promRecords/import',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return HrbrainImportPromEvalResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param HrbrainImportPromEvalRequest $request
     *
     * @return HrbrainImportPromEvalResponse
     */
    public function hrbrainImportPromEval($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportPromEvalHeaders([]);

        return $this->hrbrainImportPromEvalWithOptions($request, $headers, $runtime);
    }

    /**
     * @param HrbrainImportPunDetailRequest $request
     * @param HrbrainImportPunDetailHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return HrbrainImportPunDetailResponse
     */
    public function hrbrainImportPunDetailWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
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
            'body'    => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action'      => 'HrbrainImportPunDetail',
            'version'     => 'hrbrain_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/hrbrain/datas/punDetails/import',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return HrbrainImportPunDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param HrbrainImportPunDetailRequest $request
     *
     * @return HrbrainImportPunDetailResponse
     */
    public function hrbrainImportPunDetail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportPunDetailHeaders([]);

        return $this->hrbrainImportPunDetailWithOptions($request, $headers, $runtime);
    }

    /**
     * @param HrbrainImportRegistRequest $request
     * @param HrbrainImportRegistHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return HrbrainImportRegistResponse
     */
    public function hrbrainImportRegistWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
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
            'body'    => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action'      => 'HrbrainImportRegist',
            'version'     => 'hrbrain_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/hrbrain/datas/registerInfos/import',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return HrbrainImportRegistResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param HrbrainImportRegistRequest $request
     *
     * @return HrbrainImportRegistResponse
     */
    public function hrbrainImportRegist($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportRegistHeaders([]);

        return $this->hrbrainImportRegistWithOptions($request, $headers, $runtime);
    }

    /**
     * @param HrbrainImportTransferEvalRequest $request
     * @param HrbrainImportTransferEvalHeaders $headers
     * @param RuntimeOptions                   $runtime
     *
     * @return HrbrainImportTransferEvalResponse
     */
    public function hrbrainImportTransferEvalWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
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
            'body'    => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action'      => 'HrbrainImportTransferEval',
            'version'     => 'hrbrain_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/hrbrain/datas/changeRecords/import',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return HrbrainImportTransferEvalResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param HrbrainImportTransferEvalRequest $request
     *
     * @return HrbrainImportTransferEvalResponse
     */
    public function hrbrainImportTransferEval($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportTransferEvalHeaders([]);

        return $this->hrbrainImportTransferEvalWithOptions($request, $headers, $runtime);
    }

    /**
     * @param HrbrainImportWorkExpRequest $request
     * @param HrbrainImportWorkExpHeaders $headers
     * @param RuntimeOptions              $runtime
     *
     * @return HrbrainImportWorkExpResponse
     */
    public function hrbrainImportWorkExpWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->corpId)) {
            $query['corpId'] = $request->corpId;
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
            'body'    => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action'      => 'HrbrainImportWorkExp',
            'version'     => 'hrbrain_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/hrbrain/datas/workExperiences/import',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return HrbrainImportWorkExpResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param HrbrainImportWorkExpRequest $request
     *
     * @return HrbrainImportWorkExpResponse
     */
    public function hrbrainImportWorkExp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportWorkExpHeaders([]);

        return $this->hrbrainImportWorkExpWithOptions($request, $headers, $runtime);
    }

    /**
     * @param SyncDataRequest $request
     * @param SyncDataHeaders $headers
     * @param RuntimeOptions  $runtime
     *
     * @return SyncDataResponse
     */
    public function syncDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->content)) {
            $body['content'] = $request->content;
        }
        if (!Utils::isUnset($request->dataId)) {
            $body['dataId'] = $request->dataId;
        }
        if (!Utils::isUnset($request->etlTime)) {
            $body['etlTime'] = $request->etlTime;
        }
        if (!Utils::isUnset($request->projectId)) {
            $body['projectId'] = $request->projectId;
        }
        if (!Utils::isUnset($request->schemaId)) {
            $body['schemaId'] = $request->schemaId;
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
            'action'      => 'SyncData',
            'version'     => 'hrbrain_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/hrbrain/datas',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'json',
            'bodyType'    => 'json',
        ]);

        return SyncDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SyncDataRequest $request
     *
     * @return SyncDataResponse
     */
    public function syncData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SyncDataHeaders([]);

        return $this->syncDataWithOptions($request, $headers, $runtime);
    }
}
