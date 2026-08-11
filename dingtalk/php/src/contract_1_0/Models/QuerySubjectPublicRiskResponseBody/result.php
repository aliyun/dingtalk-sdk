<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySubjectPublicRiskResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySubjectPublicRiskResponseBody\result\companyInfo;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySubjectPublicRiskResponseBody\result\risks;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $aiRiskSummary;

    /**
     * @var int
     */
    public $aiSampleRiskCount;

    /**
     * @var string
     */
    public $aiSummaryStatus;

    /**
     * @var string
     */
    public $bizId;

    /**
     * @var companyInfo
     */
    public $companyInfo;

    /**
     * @var string
     */
    public $dataStatus;

    /**
     * @var int
     */
    public $dataUpdatedAt;

    /**
     * @var bool
     */
    public $freeBenefitRestEnough;

    /**
     * @var string[]
     */
    public $riskTypes;

    /**
     * @var risks
     */
    public $risks;

    /**
     * @var bool
     */
    public $subjectExist;

    /**
     * @var int
     */
    public $totalRiskNumber;
    protected $_name = [
        'aiRiskSummary' => 'aiRiskSummary',
        'aiSampleRiskCount' => 'aiSampleRiskCount',
        'aiSummaryStatus' => 'aiSummaryStatus',
        'bizId' => 'bizId',
        'companyInfo' => 'companyInfo',
        'dataStatus' => 'dataStatus',
        'dataUpdatedAt' => 'dataUpdatedAt',
        'freeBenefitRestEnough' => 'freeBenefitRestEnough',
        'riskTypes' => 'riskTypes',
        'risks' => 'risks',
        'subjectExist' => 'subjectExist',
        'totalRiskNumber' => 'totalRiskNumber',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->aiRiskSummary) {
            $res['aiRiskSummary'] = $this->aiRiskSummary;
        }
        if (null !== $this->aiSampleRiskCount) {
            $res['aiSampleRiskCount'] = $this->aiSampleRiskCount;
        }
        if (null !== $this->aiSummaryStatus) {
            $res['aiSummaryStatus'] = $this->aiSummaryStatus;
        }
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->companyInfo) {
            $res['companyInfo'] = null !== $this->companyInfo ? $this->companyInfo->toMap() : null;
        }
        if (null !== $this->dataStatus) {
            $res['dataStatus'] = $this->dataStatus;
        }
        if (null !== $this->dataUpdatedAt) {
            $res['dataUpdatedAt'] = $this->dataUpdatedAt;
        }
        if (null !== $this->freeBenefitRestEnough) {
            $res['freeBenefitRestEnough'] = $this->freeBenefitRestEnough;
        }
        if (null !== $this->riskTypes) {
            $res['riskTypes'] = $this->riskTypes;
        }
        if (null !== $this->risks) {
            $res['risks'] = null !== $this->risks ? $this->risks->toMap() : null;
        }
        if (null !== $this->subjectExist) {
            $res['subjectExist'] = $this->subjectExist;
        }
        if (null !== $this->totalRiskNumber) {
            $res['totalRiskNumber'] = $this->totalRiskNumber;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['aiRiskSummary'])) {
            $model->aiRiskSummary = $map['aiRiskSummary'];
        }
        if (isset($map['aiSampleRiskCount'])) {
            $model->aiSampleRiskCount = $map['aiSampleRiskCount'];
        }
        if (isset($map['aiSummaryStatus'])) {
            $model->aiSummaryStatus = $map['aiSummaryStatus'];
        }
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['companyInfo'])) {
            $model->companyInfo = companyInfo::fromMap($map['companyInfo']);
        }
        if (isset($map['dataStatus'])) {
            $model->dataStatus = $map['dataStatus'];
        }
        if (isset($map['dataUpdatedAt'])) {
            $model->dataUpdatedAt = $map['dataUpdatedAt'];
        }
        if (isset($map['freeBenefitRestEnough'])) {
            $model->freeBenefitRestEnough = $map['freeBenefitRestEnough'];
        }
        if (isset($map['riskTypes'])) {
            if (!empty($map['riskTypes'])) {
                $model->riskTypes = $map['riskTypes'];
            }
        }
        if (isset($map['risks'])) {
            $model->risks = risks::fromMap($map['risks']);
        }
        if (isset($map['subjectExist'])) {
            $model->subjectExist = $map['subjectExist'];
        }
        if (isset($map['totalRiskNumber'])) {
            $model->totalRiskNumber = $map['totalRiskNumber'];
        }

        return $model;
    }
}
