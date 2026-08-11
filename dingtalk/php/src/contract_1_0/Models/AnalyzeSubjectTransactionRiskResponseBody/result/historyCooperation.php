<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\AnalyzeSubjectTransactionRiskResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\AnalyzeSubjectTransactionRiskResponseBody\result\historyCooperation\expenseAmounts;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\AnalyzeSubjectTransactionRiskResponseBody\result\historyCooperation\incomeAmounts;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\AnalyzeSubjectTransactionRiskResponseBody\result\historyCooperation\relatedContracts;
use AlibabaCloud\Tea\Model;

class historyCooperation extends Model
{
    /**
     * @var expenseAmounts
     */
    public $expenseAmounts;

    /**
     * @var string
     */
    public $historyDataStatus;

    /**
     * @var int
     */
    public $historyEndTime;

    /**
     * @var int
     */
    public $historyStartTime;

    /**
     * @var incomeAmounts
     */
    public $incomeAmounts;

    /**
     * @var string[]
     */
    public $performanceAnomalies;

    /**
     * @var string
     */
    public $performanceDataStatus;

    /**
     * @var int
     */
    public $periodContractCount;

    /**
     * @var relatedContracts[]
     */
    public $relatedContracts;

    /**
     * @var int
     */
    public $totalRelatedContractCount;
    protected $_name = [
        'expenseAmounts' => 'expenseAmounts',
        'historyDataStatus' => 'historyDataStatus',
        'historyEndTime' => 'historyEndTime',
        'historyStartTime' => 'historyStartTime',
        'incomeAmounts' => 'incomeAmounts',
        'performanceAnomalies' => 'performanceAnomalies',
        'performanceDataStatus' => 'performanceDataStatus',
        'periodContractCount' => 'periodContractCount',
        'relatedContracts' => 'relatedContracts',
        'totalRelatedContractCount' => 'totalRelatedContractCount',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->expenseAmounts) {
            $res['expenseAmounts'] = null !== $this->expenseAmounts ? $this->expenseAmounts->toMap() : null;
        }
        if (null !== $this->historyDataStatus) {
            $res['historyDataStatus'] = $this->historyDataStatus;
        }
        if (null !== $this->historyEndTime) {
            $res['historyEndTime'] = $this->historyEndTime;
        }
        if (null !== $this->historyStartTime) {
            $res['historyStartTime'] = $this->historyStartTime;
        }
        if (null !== $this->incomeAmounts) {
            $res['incomeAmounts'] = null !== $this->incomeAmounts ? $this->incomeAmounts->toMap() : null;
        }
        if (null !== $this->performanceAnomalies) {
            $res['performanceAnomalies'] = $this->performanceAnomalies;
        }
        if (null !== $this->performanceDataStatus) {
            $res['performanceDataStatus'] = $this->performanceDataStatus;
        }
        if (null !== $this->periodContractCount) {
            $res['periodContractCount'] = $this->periodContractCount;
        }
        if (null !== $this->relatedContracts) {
            $res['relatedContracts'] = [];
            if (null !== $this->relatedContracts && \is_array($this->relatedContracts)) {
                $n = 0;
                foreach ($this->relatedContracts as $item) {
                    $res['relatedContracts'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->totalRelatedContractCount) {
            $res['totalRelatedContractCount'] = $this->totalRelatedContractCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return historyCooperation
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['expenseAmounts'])) {
            $model->expenseAmounts = expenseAmounts::fromMap($map['expenseAmounts']);
        }
        if (isset($map['historyDataStatus'])) {
            $model->historyDataStatus = $map['historyDataStatus'];
        }
        if (isset($map['historyEndTime'])) {
            $model->historyEndTime = $map['historyEndTime'];
        }
        if (isset($map['historyStartTime'])) {
            $model->historyStartTime = $map['historyStartTime'];
        }
        if (isset($map['incomeAmounts'])) {
            $model->incomeAmounts = incomeAmounts::fromMap($map['incomeAmounts']);
        }
        if (isset($map['performanceAnomalies'])) {
            if (!empty($map['performanceAnomalies'])) {
                $model->performanceAnomalies = $map['performanceAnomalies'];
            }
        }
        if (isset($map['performanceDataStatus'])) {
            $model->performanceDataStatus = $map['performanceDataStatus'];
        }
        if (isset($map['periodContractCount'])) {
            $model->periodContractCount = $map['periodContractCount'];
        }
        if (isset($map['relatedContracts'])) {
            if (!empty($map['relatedContracts'])) {
                $model->relatedContracts = [];
                $n = 0;
                foreach ($map['relatedContracts'] as $item) {
                    $model->relatedContracts[$n++] = null !== $item ? relatedContracts::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['totalRelatedContractCount'])) {
            $model->totalRelatedContractCount = $map['totalRelatedContractCount'];
        }

        return $model;
    }
}
