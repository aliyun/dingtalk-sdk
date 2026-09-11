<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\QueryStaffStatisticDataResponseBody\result;

use AlibabaCloud\Tea\Model;

class qualityInspectL1Data extends Model
{
    /**
     * @var string
     */
    public $hitRate;

    /**
     * @var string
     */
    public $level1Code;

    /**
     * @var string
     */
    public $level1Name;

    /**
     * @var string
     */
    public $recordCount;

    /**
     * @var string
     */
    public $sceneCode;

    /**
     * @var string
     */
    public $totalScore;
    protected $_name = [
        'hitRate' => 'hitRate',
        'level1Code' => 'level1Code',
        'level1Name' => 'level1Name',
        'recordCount' => 'recordCount',
        'sceneCode' => 'sceneCode',
        'totalScore' => 'totalScore',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->hitRate) {
            $res['hitRate'] = $this->hitRate;
        }
        if (null !== $this->level1Code) {
            $res['level1Code'] = $this->level1Code;
        }
        if (null !== $this->level1Name) {
            $res['level1Name'] = $this->level1Name;
        }
        if (null !== $this->recordCount) {
            $res['recordCount'] = $this->recordCount;
        }
        if (null !== $this->sceneCode) {
            $res['sceneCode'] = $this->sceneCode;
        }
        if (null !== $this->totalScore) {
            $res['totalScore'] = $this->totalScore;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return qualityInspectL1Data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hitRate'])) {
            $model->hitRate = $map['hitRate'];
        }
        if (isset($map['level1Code'])) {
            $model->level1Code = $map['level1Code'];
        }
        if (isset($map['level1Name'])) {
            $model->level1Name = $map['level1Name'];
        }
        if (isset($map['recordCount'])) {
            $model->recordCount = $map['recordCount'];
        }
        if (isset($map['sceneCode'])) {
            $model->sceneCode = $map['sceneCode'];
        }
        if (isset($map['totalScore'])) {
            $model->totalScore = $map['totalScore'];
        }

        return $model;
    }
}
