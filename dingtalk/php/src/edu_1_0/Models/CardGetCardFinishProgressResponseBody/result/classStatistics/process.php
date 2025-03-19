<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardGetCardFinishProgressResponseBody\result\classStatistics;

use AlibabaCloud\Tea\Model;

class process extends Model
{
    /**
     * @example 2023-11-01
     *
     * @var string
     */
    public $date;

    /**
     * @example 11
     *
     * @var int
     */
    public $finishedStudentsNum;

    /**
     * @example 11
     *
     * @var int
     */
    public $needFinishStudentsNum;

    /**
     * @example CARD_TASK_CODE_0
     *
     * @var string
     */
    public $taskCode;

    /**
     * @example 2023-11-01
     *
     * @var string
     */
    public $today;
    protected $_name = [
        'date' => 'date',
        'finishedStudentsNum' => 'finishedStudentsNum',
        'needFinishStudentsNum' => 'needFinishStudentsNum',
        'taskCode' => 'taskCode',
        'today' => 'today',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->date) {
            $res['date'] = $this->date;
        }
        if (null !== $this->finishedStudentsNum) {
            $res['finishedStudentsNum'] = $this->finishedStudentsNum;
        }
        if (null !== $this->needFinishStudentsNum) {
            $res['needFinishStudentsNum'] = $this->needFinishStudentsNum;
        }
        if (null !== $this->taskCode) {
            $res['taskCode'] = $this->taskCode;
        }
        if (null !== $this->today) {
            $res['today'] = $this->today;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return process
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['date'])) {
            $model->date = $map['date'];
        }
        if (isset($map['finishedStudentsNum'])) {
            $model->finishedStudentsNum = $map['finishedStudentsNum'];
        }
        if (isset($map['needFinishStudentsNum'])) {
            $model->needFinishStudentsNum = $map['needFinishStudentsNum'];
        }
        if (isset($map['taskCode'])) {
            $model->taskCode = $map['taskCode'];
        }
        if (isset($map['today'])) {
            $model->today = $map['today'];
        }

        return $model;
    }
}
