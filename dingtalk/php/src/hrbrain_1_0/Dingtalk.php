<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteAwardRecordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteAwardRecordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteAwardRecordsResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteDeptInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteDeptInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteDeptInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteDimissionHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteDimissionRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteDimissionResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteEduExpHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteEduExpRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteEduExpResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteEmpInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteEmpInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteEmpInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteLabelIndustryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteLabelIndustryRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteLabelIndustryResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteLabelInventoryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteLabelInventoryRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteLabelInventoryResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteLabelProfSkillHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteLabelProfSkillRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteLabelProfSkillResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeletePerfEvalHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeletePerfEvalRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeletePerfEvalResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeletePromRecordsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeletePromRecordsRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeletePromRecordsResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeletePunDetailHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeletePunDetailRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeletePunDetailResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteRegistHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteRegistRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteRegistResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteRegularHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteRegularRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteRegularResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeletetLabelBaseHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeletetLabelBaseRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeletetLabelBaseResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteTrainingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteTrainingRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteTrainingResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteTransferEvalHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteTransferEvalRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteTransferEvalResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteWorkExpHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteWorkExpRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteWorkExpResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportRegularHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportRegularRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportRegularResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportTrainingHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportTrainingRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportTrainingResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportTransferEvalHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportTransferEvalRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportTransferEvalResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportWorkExpHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportWorkExpRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportWorkExpResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\StaffLabelRecordsQueryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\StaffLabelRecordsQueryRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\StaffLabelRecordsQueryResponse;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\SyncDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\SyncDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\SyncDataResponse;
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
        $gatewayClient = new Client();
        $this->_spi = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 删除奖励记录
     *  *
     * @param HrbrainDeleteAwardRecordsRequest $request HrbrainDeleteAwardRecordsRequest
     * @param HrbrainDeleteAwardRecordsHeaders $headers HrbrainDeleteAwardRecordsHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainDeleteAwardRecordsResponse HrbrainDeleteAwardRecordsResponse
     */
    public function hrbrainDeleteAwardRecordsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->params)) {
            $body['params'] = $request->params;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'HrbrainDeleteAwardRecords',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/awardRecords/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainDeleteAwardRecordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除奖励记录
     *  *
     * @param HrbrainDeleteAwardRecordsRequest $request HrbrainDeleteAwardRecordsRequest
     *
     * @return HrbrainDeleteAwardRecordsResponse HrbrainDeleteAwardRecordsResponse
     */
    public function hrbrainDeleteAwardRecords($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainDeleteAwardRecordsHeaders([]);

        return $this->hrbrainDeleteAwardRecordsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除组织架构
     *  *
     * @param HrbrainDeleteDeptInfoRequest $request HrbrainDeleteDeptInfoRequest
     * @param HrbrainDeleteDeptInfoHeaders $headers HrbrainDeleteDeptInfoHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainDeleteDeptInfoResponse HrbrainDeleteDeptInfoResponse
     */
    public function hrbrainDeleteDeptInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->params)) {
            $body['params'] = $request->params;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'HrbrainDeleteDeptInfo',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/deptInfos/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainDeleteDeptInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除组织架构
     *  *
     * @param HrbrainDeleteDeptInfoRequest $request HrbrainDeleteDeptInfoRequest
     *
     * @return HrbrainDeleteDeptInfoResponse HrbrainDeleteDeptInfoResponse
     */
    public function hrbrainDeleteDeptInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainDeleteDeptInfoHeaders([]);

        return $this->hrbrainDeleteDeptInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除离职记录
     *  *
     * @param HrbrainDeleteDimissionRequest $request HrbrainDeleteDimissionRequest
     * @param HrbrainDeleteDimissionHeaders $headers HrbrainDeleteDimissionHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainDeleteDimissionResponse HrbrainDeleteDimissionResponse
     */
    public function hrbrainDeleteDimissionWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->params)) {
            $body['params'] = $request->params;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'HrbrainDeleteDimission',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/dimissionInfos/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainDeleteDimissionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除离职记录
     *  *
     * @param HrbrainDeleteDimissionRequest $request HrbrainDeleteDimissionRequest
     *
     * @return HrbrainDeleteDimissionResponse HrbrainDeleteDimissionResponse
     */
    public function hrbrainDeleteDimission($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainDeleteDimissionHeaders([]);

        return $this->hrbrainDeleteDimissionWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除教育经历
     *  *
     * @param HrbrainDeleteEduExpRequest $request HrbrainDeleteEduExpRequest
     * @param HrbrainDeleteEduExpHeaders $headers HrbrainDeleteEduExpHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainDeleteEduExpResponse HrbrainDeleteEduExpResponse
     */
    public function hrbrainDeleteEduExpWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->params)) {
            $body['params'] = $request->params;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'HrbrainDeleteEduExp',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/eduExperiences/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainDeleteEduExpResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除教育经历
     *  *
     * @param HrbrainDeleteEduExpRequest $request HrbrainDeleteEduExpRequest
     *
     * @return HrbrainDeleteEduExpResponse HrbrainDeleteEduExpResponse
     */
    public function hrbrainDeleteEduExp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainDeleteEduExpHeaders([]);

        return $this->hrbrainDeleteEduExpWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除人员信息
     *  *
     * @param HrbrainDeleteEmpInfoRequest $request HrbrainDeleteEmpInfoRequest
     * @param HrbrainDeleteEmpInfoHeaders $headers HrbrainDeleteEmpInfoHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainDeleteEmpInfoResponse HrbrainDeleteEmpInfoResponse
     */
    public function hrbrainDeleteEmpInfoWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->params)) {
            $body['params'] = $request->params;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'HrbrainDeleteEmpInfo',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/empInfos/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainDeleteEmpInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除人员信息
     *  *
     * @param HrbrainDeleteEmpInfoRequest $request HrbrainDeleteEmpInfoRequest
     *
     * @return HrbrainDeleteEmpInfoResponse HrbrainDeleteEmpInfoResponse
     */
    public function hrbrainDeleteEmpInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainDeleteEmpInfoHeaders([]);

        return $this->hrbrainDeleteEmpInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除领域经验
     *  *
     * @param HrbrainDeleteLabelIndustryRequest $request HrbrainDeleteLabelIndustryRequest
     * @param HrbrainDeleteLabelIndustryHeaders $headers HrbrainDeleteLabelIndustryHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainDeleteLabelIndustryResponse HrbrainDeleteLabelIndustryResponse
     */
    public function hrbrainDeleteLabelIndustryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->params)) {
            $body['params'] = $request->params;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'HrbrainDeleteLabelIndustry',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/industries/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainDeleteLabelIndustryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除领域经验
     *  *
     * @param HrbrainDeleteLabelIndustryRequest $request HrbrainDeleteLabelIndustryRequest
     *
     * @return HrbrainDeleteLabelIndustryResponse HrbrainDeleteLabelIndustryResponse
     */
    public function hrbrainDeleteLabelIndustry($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainDeleteLabelIndustryHeaders([]);

        return $this->hrbrainDeleteLabelIndustryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除盘点数据
     *  *
     * @param HrbrainDeleteLabelInventoryRequest $request HrbrainDeleteLabelInventoryRequest
     * @param HrbrainDeleteLabelInventoryHeaders $headers HrbrainDeleteLabelInventoryHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainDeleteLabelInventoryResponse HrbrainDeleteLabelInventoryResponse
     */
    public function hrbrainDeleteLabelInventoryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->params)) {
            $body['params'] = $request->params;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'HrbrainDeleteLabelInventory',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/inventories/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainDeleteLabelInventoryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除盘点数据
     *  *
     * @param HrbrainDeleteLabelInventoryRequest $request HrbrainDeleteLabelInventoryRequest
     *
     * @return HrbrainDeleteLabelInventoryResponse HrbrainDeleteLabelInventoryResponse
     */
    public function hrbrainDeleteLabelInventory($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainDeleteLabelInventoryHeaders([]);

        return $this->hrbrainDeleteLabelInventoryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除专业技能
     *  *
     * @param HrbrainDeleteLabelProfSkillRequest $request HrbrainDeleteLabelProfSkillRequest
     * @param HrbrainDeleteLabelProfSkillHeaders $headers HrbrainDeleteLabelProfSkillHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainDeleteLabelProfSkillResponse HrbrainDeleteLabelProfSkillResponse
     */
    public function hrbrainDeleteLabelProfSkillWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->params)) {
            $body['params'] = $request->params;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'HrbrainDeleteLabelProfSkill',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/profSkills/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainDeleteLabelProfSkillResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除专业技能
     *  *
     * @param HrbrainDeleteLabelProfSkillRequest $request HrbrainDeleteLabelProfSkillRequest
     *
     * @return HrbrainDeleteLabelProfSkillResponse HrbrainDeleteLabelProfSkillResponse
     */
    public function hrbrainDeleteLabelProfSkill($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainDeleteLabelProfSkillHeaders([]);

        return $this->hrbrainDeleteLabelProfSkillWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除绩效记录
     *  *
     * @param HrbrainDeletePerfEvalRequest $request HrbrainDeletePerfEvalRequest
     * @param HrbrainDeletePerfEvalHeaders $headers HrbrainDeletePerfEvalHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainDeletePerfEvalResponse HrbrainDeletePerfEvalResponse
     */
    public function hrbrainDeletePerfEvalWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->params)) {
            $body['params'] = $request->params;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'HrbrainDeletePerfEval',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/perfRecords/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainDeletePerfEvalResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除绩效记录
     *  *
     * @param HrbrainDeletePerfEvalRequest $request HrbrainDeletePerfEvalRequest
     *
     * @return HrbrainDeletePerfEvalResponse HrbrainDeletePerfEvalResponse
     */
    public function hrbrainDeletePerfEval($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainDeletePerfEvalHeaders([]);

        return $this->hrbrainDeletePerfEvalWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 数据集成晋升记录删除
     *  *
     * @param HrbrainDeletePromRecordsRequest $request HrbrainDeletePromRecordsRequest
     * @param HrbrainDeletePromRecordsHeaders $headers HrbrainDeletePromRecordsHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainDeletePromRecordsResponse HrbrainDeletePromRecordsResponse
     */
    public function hrbrainDeletePromRecordsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->params)) {
            $body['params'] = $request->params;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'HrbrainDeletePromRecords',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/promEvals/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainDeletePromRecordsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 数据集成晋升记录删除
     *  *
     * @param HrbrainDeletePromRecordsRequest $request HrbrainDeletePromRecordsRequest
     *
     * @return HrbrainDeletePromRecordsResponse HrbrainDeletePromRecordsResponse
     */
    public function hrbrainDeletePromRecords($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainDeletePromRecordsHeaders([]);

        return $this->hrbrainDeletePromRecordsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除处分记录
     *  *
     * @param HrbrainDeletePunDetailRequest $request HrbrainDeletePunDetailRequest
     * @param HrbrainDeletePunDetailHeaders $headers HrbrainDeletePunDetailHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainDeletePunDetailResponse HrbrainDeletePunDetailResponse
     */
    public function hrbrainDeletePunDetailWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->params)) {
            $body['params'] = $request->params;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'HrbrainDeletePunDetail',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/punDetails/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainDeletePunDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除处分记录
     *  *
     * @param HrbrainDeletePunDetailRequest $request HrbrainDeletePunDetailRequest
     *
     * @return HrbrainDeletePunDetailResponse HrbrainDeletePunDetailResponse
     */
    public function hrbrainDeletePunDetail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainDeletePunDetailHeaders([]);

        return $this->hrbrainDeletePunDetailWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除入职记录
     *  *
     * @param HrbrainDeleteRegistRequest $request HrbrainDeleteRegistRequest
     * @param HrbrainDeleteRegistHeaders $headers HrbrainDeleteRegistHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainDeleteRegistResponse HrbrainDeleteRegistResponse
     */
    public function hrbrainDeleteRegistWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->params)) {
            $body['params'] = $request->params;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'HrbrainDeleteRegist',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/registerInfos/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainDeleteRegistResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除入职记录
     *  *
     * @param HrbrainDeleteRegistRequest $request HrbrainDeleteRegistRequest
     *
     * @return HrbrainDeleteRegistResponse HrbrainDeleteRegistResponse
     */
    public function hrbrainDeleteRegist($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainDeleteRegistHeaders([]);

        return $this->hrbrainDeleteRegistWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除转正记录
     *  *
     * @param HrbrainDeleteRegularRequest $request HrbrainDeleteRegularRequest
     * @param HrbrainDeleteRegularHeaders $headers HrbrainDeleteRegularHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainDeleteRegularResponse HrbrainDeleteRegularResponse
     */
    public function hrbrainDeleteRegularWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->params)) {
            $body['params'] = $request->params;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'HrbrainDeleteRegular',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/regulars/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainDeleteRegularResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除转正记录
     *  *
     * @param HrbrainDeleteRegularRequest $request HrbrainDeleteRegularRequest
     *
     * @return HrbrainDeleteRegularResponse HrbrainDeleteRegularResponse
     */
    public function hrbrainDeleteRegular($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainDeleteRegularHeaders([]);

        return $this->hrbrainDeleteRegularWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除培训学习记录
     *  *
     * @param HrbrainDeleteTrainingRequest $request HrbrainDeleteTrainingRequest
     * @param HrbrainDeleteTrainingHeaders $headers HrbrainDeleteTrainingHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainDeleteTrainingResponse HrbrainDeleteTrainingResponse
     */
    public function hrbrainDeleteTrainingWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->params)) {
            $body['params'] = $request->params;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'HrbrainDeleteTraining',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/trainings/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainDeleteTrainingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除培训学习记录
     *  *
     * @param HrbrainDeleteTrainingRequest $request HrbrainDeleteTrainingRequest
     *
     * @return HrbrainDeleteTrainingResponse HrbrainDeleteTrainingResponse
     */
    public function hrbrainDeleteTraining($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainDeleteTrainingHeaders([]);

        return $this->hrbrainDeleteTrainingWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除调岗记录
     *  *
     * @param HrbrainDeleteTransferEvalRequest $request HrbrainDeleteTransferEvalRequest
     * @param HrbrainDeleteTransferEvalHeaders $headers HrbrainDeleteTransferEvalHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainDeleteTransferEvalResponse HrbrainDeleteTransferEvalResponse
     */
    public function hrbrainDeleteTransferEvalWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->params)) {
            $body['params'] = $request->params;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'HrbrainDeleteTransferEval',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/changeRecords/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainDeleteTransferEvalResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除调岗记录
     *  *
     * @param HrbrainDeleteTransferEvalRequest $request HrbrainDeleteTransferEvalRequest
     *
     * @return HrbrainDeleteTransferEvalResponse HrbrainDeleteTransferEvalResponse
     */
    public function hrbrainDeleteTransferEval($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainDeleteTransferEvalHeaders([]);

        return $this->hrbrainDeleteTransferEvalWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除工作经历
     *  *
     * @param HrbrainDeleteWorkExpRequest $request HrbrainDeleteWorkExpRequest
     * @param HrbrainDeleteWorkExpHeaders $headers HrbrainDeleteWorkExpHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainDeleteWorkExpResponse HrbrainDeleteWorkExpResponse
     */
    public function hrbrainDeleteWorkExpWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->params)) {
            $body['params'] = $request->params;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'HrbrainDeleteWorkExp',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/workExperiences/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainDeleteWorkExpResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除工作经历
     *  *
     * @param HrbrainDeleteWorkExpRequest $request HrbrainDeleteWorkExpRequest
     *
     * @return HrbrainDeleteWorkExpResponse HrbrainDeleteWorkExpResponse
     */
    public function hrbrainDeleteWorkExp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainDeleteWorkExpHeaders([]);

        return $this->hrbrainDeleteWorkExpWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除标签数据
     *  *
     * @param HrbrainDeletetLabelBaseRequest $request HrbrainDeletetLabelBaseRequest
     * @param HrbrainDeletetLabelBaseHeaders $headers HrbrainDeletetLabelBaseHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainDeletetLabelBaseResponse HrbrainDeletetLabelBaseResponse
     */
    public function hrbrainDeletetLabelBaseWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->params)) {
            $body['params'] = $request->params;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'HrbrainDeletetLabelBase',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/baseLabels/remove',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainDeletetLabelBaseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除标签数据
     *  *
     * @param HrbrainDeletetLabelBaseRequest $request HrbrainDeletetLabelBaseRequest
     *
     * @return HrbrainDeletetLabelBaseResponse HrbrainDeletetLabelBaseResponse
     */
    public function hrbrainDeletetLabelBase($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainDeletetLabelBaseHeaders([]);

        return $this->hrbrainDeletetLabelBaseWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 集成奖励记录
     *  *
     * @param HrbrainImportAwardDetailRequest $request HrbrainImportAwardDetailRequest
     * @param HrbrainImportAwardDetailHeaders $headers HrbrainImportAwardDetailHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainImportAwardDetailResponse HrbrainImportAwardDetailResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action' => 'HrbrainImportAwardDetail',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/awardDetails/import',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainImportAwardDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 集成奖励记录
     *  *
     * @param HrbrainImportAwardDetailRequest $request HrbrainImportAwardDetailRequest
     *
     * @return HrbrainImportAwardDetailResponse HrbrainImportAwardDetailResponse
     */
    public function hrbrainImportAwardDetail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportAwardDetailHeaders([]);

        return $this->hrbrainImportAwardDetailWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 集成组织架构
     *  *
     * @param HrbrainImportDeptInfoRequest $request HrbrainImportDeptInfoRequest
     * @param HrbrainImportDeptInfoHeaders $headers HrbrainImportDeptInfoHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainImportDeptInfoResponse HrbrainImportDeptInfoResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action' => 'HrbrainImportDeptInfo',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/deptInfos/import',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainImportDeptInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 集成组织架构
     *  *
     * @param HrbrainImportDeptInfoRequest $request HrbrainImportDeptInfoRequest
     *
     * @return HrbrainImportDeptInfoResponse HrbrainImportDeptInfoResponse
     */
    public function hrbrainImportDeptInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportDeptInfoHeaders([]);

        return $this->hrbrainImportDeptInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 集成离职信息
     *  *
     * @param HrbrainImportDimissionRequest $request HrbrainImportDimissionRequest
     * @param HrbrainImportDimissionHeaders $headers HrbrainImportDimissionHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainImportDimissionResponse HrbrainImportDimissionResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action' => 'HrbrainImportDimission',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/dimissionInfos/import',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainImportDimissionResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 集成离职信息
     *  *
     * @param HrbrainImportDimissionRequest $request HrbrainImportDimissionRequest
     *
     * @return HrbrainImportDimissionResponse HrbrainImportDimissionResponse
     */
    public function hrbrainImportDimission($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportDimissionHeaders([]);

        return $this->hrbrainImportDimissionWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 集成教育经历
     *  *
     * @param HrbrainImportEduExpRequest $request HrbrainImportEduExpRequest
     * @param HrbrainImportEduExpHeaders $headers HrbrainImportEduExpHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainImportEduExpResponse HrbrainImportEduExpResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action' => 'HrbrainImportEduExp',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/eduExperiences/import',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainImportEduExpResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 集成教育经历
     *  *
     * @param HrbrainImportEduExpRequest $request HrbrainImportEduExpRequest
     *
     * @return HrbrainImportEduExpResponse HrbrainImportEduExpResponse
     */
    public function hrbrainImportEduExp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportEduExpHeaders([]);

        return $this->hrbrainImportEduExpWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 集成人员信息
     *  *
     * @param HrbrainImportEmpInfoRequest $request HrbrainImportEmpInfoRequest
     * @param HrbrainImportEmpInfoHeaders $headers HrbrainImportEmpInfoHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainImportEmpInfoResponse HrbrainImportEmpInfoResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action' => 'HrbrainImportEmpInfo',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/empInfos/import',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainImportEmpInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 集成人员信息
     *  *
     * @param HrbrainImportEmpInfoRequest $request HrbrainImportEmpInfoRequest
     *
     * @return HrbrainImportEmpInfoResponse HrbrainImportEmpInfoResponse
     */
    public function hrbrainImportEmpInfo($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportEmpInfoHeaders([]);

        return $this->hrbrainImportEmpInfoWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 集成基础标签
     *  *
     * @param HrbrainImportLabelBaseRequest $request HrbrainImportLabelBaseRequest
     * @param HrbrainImportLabelBaseHeaders $headers HrbrainImportLabelBaseHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainImportLabelBaseResponse HrbrainImportLabelBaseResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action' => 'HrbrainImportLabelBase',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/baseLabels/import',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainImportLabelBaseResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 集成基础标签
     *  *
     * @param HrbrainImportLabelBaseRequest $request HrbrainImportLabelBaseRequest
     *
     * @return HrbrainImportLabelBaseResponse HrbrainImportLabelBaseResponse
     */
    public function hrbrainImportLabelBase($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportLabelBaseHeaders([]);

        return $this->hrbrainImportLabelBaseWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 集成自定义标签
     *  *
     * @param HrbrainImportLabelCustomRequest $request HrbrainImportLabelCustomRequest
     * @param HrbrainImportLabelCustomHeaders $headers HrbrainImportLabelCustomHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainImportLabelCustomResponse HrbrainImportLabelCustomResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action' => 'HrbrainImportLabelCustom',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/customLabels/import',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainImportLabelCustomResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 集成自定义标签
     *  *
     * @param HrbrainImportLabelCustomRequest $request HrbrainImportLabelCustomRequest
     *
     * @return HrbrainImportLabelCustomResponse HrbrainImportLabelCustomResponse
     */
    public function hrbrainImportLabelCustom($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportLabelCustomHeaders([]);

        return $this->hrbrainImportLabelCustomWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 集成领域经验
     *  *
     * @param HrbrainImportLabelIndustryRequest $request HrbrainImportLabelIndustryRequest
     * @param HrbrainImportLabelIndustryHeaders $headers HrbrainImportLabelIndustryHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainImportLabelIndustryResponse HrbrainImportLabelIndustryResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action' => 'HrbrainImportLabelIndustry',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/industries/import',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainImportLabelIndustryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 集成领域经验
     *  *
     * @param HrbrainImportLabelIndustryRequest $request HrbrainImportLabelIndustryRequest
     *
     * @return HrbrainImportLabelIndustryResponse HrbrainImportLabelIndustryResponse
     */
    public function hrbrainImportLabelIndustry($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportLabelIndustryHeaders([]);

        return $this->hrbrainImportLabelIndustryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 集成盘点数据
     *  *
     * @param HrbrainImportLabelInventoryRequest $request HrbrainImportLabelInventoryRequest
     * @param HrbrainImportLabelInventoryHeaders $headers HrbrainImportLabelInventoryHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainImportLabelInventoryResponse HrbrainImportLabelInventoryResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action' => 'HrbrainImportLabelInventory',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/inventories/import',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainImportLabelInventoryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 集成盘点数据
     *  *
     * @param HrbrainImportLabelInventoryRequest $request HrbrainImportLabelInventoryRequest
     *
     * @return HrbrainImportLabelInventoryResponse HrbrainImportLabelInventoryResponse
     */
    public function hrbrainImportLabelInventory($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportLabelInventoryHeaders([]);

        return $this->hrbrainImportLabelInventoryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 集成专业技能
     *  *
     * @param HrbrainImportLabelProfSkillRequest $request HrbrainImportLabelProfSkillRequest
     * @param HrbrainImportLabelProfSkillHeaders $headers HrbrainImportLabelProfSkillHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainImportLabelProfSkillResponse HrbrainImportLabelProfSkillResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action' => 'HrbrainImportLabelProfSkill',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/profSkills/import',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainImportLabelProfSkillResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 集成专业技能
     *  *
     * @param HrbrainImportLabelProfSkillRequest $request HrbrainImportLabelProfSkillRequest
     *
     * @return HrbrainImportLabelProfSkillResponse HrbrainImportLabelProfSkillResponse
     */
    public function hrbrainImportLabelProfSkill($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportLabelProfSkillHeaders([]);

        return $this->hrbrainImportLabelProfSkillWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 集成绩效记录
     *  *
     * @param HrbrainImportPerfEvalRequest $request HrbrainImportPerfEvalRequest
     * @param HrbrainImportPerfEvalHeaders $headers HrbrainImportPerfEvalHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainImportPerfEvalResponse HrbrainImportPerfEvalResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action' => 'HrbrainImportPerfEval',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/perfRecords/import',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainImportPerfEvalResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 集成绩效记录
     *  *
     * @param HrbrainImportPerfEvalRequest $request HrbrainImportPerfEvalRequest
     *
     * @return HrbrainImportPerfEvalResponse HrbrainImportPerfEvalResponse
     */
    public function hrbrainImportPerfEval($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportPerfEvalHeaders([]);

        return $this->hrbrainImportPerfEvalWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 集成晋升记录
     *  *
     * @param HrbrainImportPromEvalRequest $request HrbrainImportPromEvalRequest
     * @param HrbrainImportPromEvalHeaders $headers HrbrainImportPromEvalHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainImportPromEvalResponse HrbrainImportPromEvalResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action' => 'HrbrainImportPromEval',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/promRecords/import',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainImportPromEvalResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 集成晋升记录
     *  *
     * @param HrbrainImportPromEvalRequest $request HrbrainImportPromEvalRequest
     *
     * @return HrbrainImportPromEvalResponse HrbrainImportPromEvalResponse
     */
    public function hrbrainImportPromEval($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportPromEvalHeaders([]);

        return $this->hrbrainImportPromEvalWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 集成处分记录
     *  *
     * @param HrbrainImportPunDetailRequest $request HrbrainImportPunDetailRequest
     * @param HrbrainImportPunDetailHeaders $headers HrbrainImportPunDetailHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainImportPunDetailResponse HrbrainImportPunDetailResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action' => 'HrbrainImportPunDetail',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/punDetails/import',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainImportPunDetailResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 集成处分记录
     *  *
     * @param HrbrainImportPunDetailRequest $request HrbrainImportPunDetailRequest
     *
     * @return HrbrainImportPunDetailResponse HrbrainImportPunDetailResponse
     */
    public function hrbrainImportPunDetail($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportPunDetailHeaders([]);

        return $this->hrbrainImportPunDetailWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 集成入职信息
     *  *
     * @param HrbrainImportRegistRequest $request HrbrainImportRegistRequest
     * @param HrbrainImportRegistHeaders $headers HrbrainImportRegistHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainImportRegistResponse HrbrainImportRegistResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action' => 'HrbrainImportRegist',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/registerInfos/import',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainImportRegistResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 集成入职信息
     *  *
     * @param HrbrainImportRegistRequest $request HrbrainImportRegistRequest
     *
     * @return HrbrainImportRegistResponse HrbrainImportRegistResponse
     */
    public function hrbrainImportRegist($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportRegistHeaders([]);

        return $this->hrbrainImportRegistWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 集成转正记录
     *  *
     * @param HrbrainImportRegularRequest $request HrbrainImportRegularRequest
     * @param HrbrainImportRegularHeaders $headers HrbrainImportRegularHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainImportRegularResponse HrbrainImportRegularResponse
     */
    public function hrbrainImportRegularWithOptions($request, $headers, $runtime)
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
            'query' => OpenApiUtilClient::query($query),
            'body' => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action' => 'HrbrainImportRegular',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/regulars/import',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainImportRegularResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 集成转正记录
     *  *
     * @param HrbrainImportRegularRequest $request HrbrainImportRegularRequest
     *
     * @return HrbrainImportRegularResponse HrbrainImportRegularResponse
     */
    public function hrbrainImportRegular($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportRegularHeaders([]);

        return $this->hrbrainImportRegularWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 集成培训学习记录
     *  *
     * @param HrbrainImportTrainingRequest $request HrbrainImportTrainingRequest
     * @param HrbrainImportTrainingHeaders $headers HrbrainImportTrainingHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainImportTrainingResponse HrbrainImportTrainingResponse
     */
    public function hrbrainImportTrainingWithOptions($request, $headers, $runtime)
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
            'query' => OpenApiUtilClient::query($query),
            'body' => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action' => 'HrbrainImportTraining',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/trainings/import',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainImportTrainingResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 集成培训学习记录
     *  *
     * @param HrbrainImportTrainingRequest $request HrbrainImportTrainingRequest
     *
     * @return HrbrainImportTrainingResponse HrbrainImportTrainingResponse
     */
    public function hrbrainImportTraining($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportTrainingHeaders([]);

        return $this->hrbrainImportTrainingWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 集成异动记录
     *  *
     * @param HrbrainImportTransferEvalRequest $request HrbrainImportTransferEvalRequest
     * @param HrbrainImportTransferEvalHeaders $headers HrbrainImportTransferEvalHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainImportTransferEvalResponse HrbrainImportTransferEvalResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action' => 'HrbrainImportTransferEval',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/changeRecords/import',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainImportTransferEvalResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 集成异动记录
     *  *
     * @param HrbrainImportTransferEvalRequest $request HrbrainImportTransferEvalRequest
     *
     * @return HrbrainImportTransferEvalResponse HrbrainImportTransferEvalResponse
     */
    public function hrbrainImportTransferEval($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportTransferEvalHeaders([]);

        return $this->hrbrainImportTransferEvalWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 集成工作经历
     *  *
     * @param HrbrainImportWorkExpRequest $request HrbrainImportWorkExpRequest
     * @param HrbrainImportWorkExpHeaders $headers HrbrainImportWorkExpHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return HrbrainImportWorkExpResponse HrbrainImportWorkExpResponse
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
            'query' => OpenApiUtilClient::query($query),
            'body' => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action' => 'HrbrainImportWorkExp',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/workExperiences/import',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return HrbrainImportWorkExpResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 集成工作经历
     *  *
     * @param HrbrainImportWorkExpRequest $request HrbrainImportWorkExpRequest
     *
     * @return HrbrainImportWorkExpResponse HrbrainImportWorkExpResponse
     */
    public function hrbrainImportWorkExp($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HrbrainImportWorkExpHeaders([]);

        return $this->hrbrainImportWorkExpWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 人员标签查询
     *  *
     * @param StaffLabelRecordsQueryRequest $request StaffLabelRecordsQueryRequest
     * @param StaffLabelRecordsQueryHeaders $headers StaffLabelRecordsQueryHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return StaffLabelRecordsQueryResponse StaffLabelRecordsQueryResponse
     */
    public function staffLabelRecordsQueryWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->dingCorpId)) {
            $query['dingCorpId'] = $request->dingCorpId;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
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
            'query' => OpenApiUtilClient::query($query),
            'body' => Utils::toArray($request->body),
        ]);
        $params = new Params([
            'action' => 'StaffLabelRecordsQuery',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas/labelRecords/query',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return StaffLabelRecordsQueryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 人员标签查询
     *  *
     * @param StaffLabelRecordsQueryRequest $request StaffLabelRecordsQueryRequest
     *
     * @return StaffLabelRecordsQueryResponse StaffLabelRecordsQueryResponse
     */
    public function staffLabelRecordsQuery($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new StaffLabelRecordsQueryHeaders([]);

        return $this->staffLabelRecordsQueryWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 同步统计基础数据
     *  *
     * @param SyncDataRequest $request SyncDataRequest
     * @param SyncDataHeaders $headers SyncDataHeaders
     * @param RuntimeOptions  $runtime runtime options for this request RuntimeOptions
     *
     * @return SyncDataResponse SyncDataResponse
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'SyncData',
            'version' => 'hrbrain_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/hrbrain/datas',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'json',
            'bodyType' => 'json',
        ]);

        return SyncDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 同步统计基础数据
     *  *
     * @param SyncDataRequest $request SyncDataRequest
     *
     * @return SyncDataResponse SyncDataResponse
     */
    public function syncData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SyncDataHeaders([]);

        return $this->syncDataWithOptions($request, $headers, $runtime);
    }
}
