<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\AnalyzeSubjectTransactionRiskResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\AnalyzeSubjectTransactionRiskResponseBody\result\aiAnalysis;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\AnalyzeSubjectTransactionRiskResponseBody\result\currentContract;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\AnalyzeSubjectTransactionRiskResponseBody\result\historyCooperation;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\AnalyzeSubjectTransactionRiskResponseBody\result\subjectInfo;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var aiAnalysis
     */
    public $aiAnalysis;

    /**
     * @var currentContract
     */
    public $currentContract;

    /**
     * @var string
     */
    public $dataStatus;

    /**
     * @var historyCooperation
     */
    public $historyCooperation;

    /**
     * @var subjectInfo
     */
    public $subjectInfo;
    protected $_name = [
        'aiAnalysis' => 'aiAnalysis',
        'currentContract' => 'currentContract',
        'dataStatus' => 'dataStatus',
        'historyCooperation' => 'historyCooperation',
        'subjectInfo' => 'subjectInfo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->aiAnalysis) {
            $res['aiAnalysis'] = null !== $this->aiAnalysis ? $this->aiAnalysis->toMap() : null;
        }
        if (null !== $this->currentContract) {
            $res['currentContract'] = null !== $this->currentContract ? $this->currentContract->toMap() : null;
        }
        if (null !== $this->dataStatus) {
            $res['dataStatus'] = $this->dataStatus;
        }
        if (null !== $this->historyCooperation) {
            $res['historyCooperation'] = null !== $this->historyCooperation ? $this->historyCooperation->toMap() : null;
        }
        if (null !== $this->subjectInfo) {
            $res['subjectInfo'] = null !== $this->subjectInfo ? $this->subjectInfo->toMap() : null;
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
        if (isset($map['aiAnalysis'])) {
            $model->aiAnalysis = aiAnalysis::fromMap($map['aiAnalysis']);
        }
        if (isset($map['currentContract'])) {
            $model->currentContract = currentContract::fromMap($map['currentContract']);
        }
        if (isset($map['dataStatus'])) {
            $model->dataStatus = $map['dataStatus'];
        }
        if (isset($map['historyCooperation'])) {
            $model->historyCooperation = historyCooperation::fromMap($map['historyCooperation']);
        }
        if (isset($map['subjectInfo'])) {
            $model->subjectInfo = subjectInfo::fromMap($map['subjectInfo']);
        }

        return $model;
    }
}
