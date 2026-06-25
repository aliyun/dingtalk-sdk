<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\SubmitCustomerSplitDataRequest;

use AlibabaCloud\Tea\Model;

class splitParams extends Model
{
    /**
     * @var int
     */
    public $endTime;

    /**
     * @var string
     */
    public $outBizData;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $startTime;
    protected $_name = [
        'endTime' => 'endTime',
        'outBizData' => 'outBizData',
        'startTime' => 'startTime',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->outBizData) {
            $res['outBizData'] = $this->outBizData;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return splitParams
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['outBizData'])) {
            $model->outBizData = $map['outBizData'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }

        return $model;
    }
}
