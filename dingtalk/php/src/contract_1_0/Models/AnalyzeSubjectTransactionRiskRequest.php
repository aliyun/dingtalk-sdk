<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\Tea\Model;

class AnalyzeSubjectTransactionRiskRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $contractId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $corpId;

    /**
     * @var int
     */
    public $historyEndTime;

    /**
     * @var int
     */
    public $historyStartTime;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $staffId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $subjectUniqueCode;
    protected $_name = [
        'contractId' => 'contractId',
        'corpId' => 'corpId',
        'historyEndTime' => 'historyEndTime',
        'historyStartTime' => 'historyStartTime',
        'staffId' => 'staffId',
        'subjectUniqueCode' => 'subjectUniqueCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->contractId) {
            $res['contractId'] = $this->contractId;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->historyEndTime) {
            $res['historyEndTime'] = $this->historyEndTime;
        }
        if (null !== $this->historyStartTime) {
            $res['historyStartTime'] = $this->historyStartTime;
        }
        if (null !== $this->staffId) {
            $res['staffId'] = $this->staffId;
        }
        if (null !== $this->subjectUniqueCode) {
            $res['subjectUniqueCode'] = $this->subjectUniqueCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AnalyzeSubjectTransactionRiskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contractId'])) {
            $model->contractId = $map['contractId'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['historyEndTime'])) {
            $model->historyEndTime = $map['historyEndTime'];
        }
        if (isset($map['historyStartTime'])) {
            $model->historyStartTime = $map['historyStartTime'];
        }
        if (isset($map['staffId'])) {
            $model->staffId = $map['staffId'];
        }
        if (isset($map['subjectUniqueCode'])) {
            $model->subjectUniqueCode = $map['subjectUniqueCode'];
        }

        return $model;
    }
}
