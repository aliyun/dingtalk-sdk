<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class PushHistoricalReceiptsRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $bizId;

    /**
     * @var int
     */
    public $endTime;

    /**
     * @var bool
     */
    public $forcedIgnoreDup;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $formCodeList;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $startTime;
    protected $_name = [
        'bizId' => 'bizId',
        'endTime' => 'endTime',
        'forcedIgnoreDup' => 'forcedIgnoreDup',
        'formCodeList' => 'formCodeList',
        'startTime' => 'startTime',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->forcedIgnoreDup) {
            $res['forcedIgnoreDup'] = $this->forcedIgnoreDup;
        }
        if (null !== $this->formCodeList) {
            $res['formCodeList'] = $this->formCodeList;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PushHistoricalReceiptsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['forcedIgnoreDup'])) {
            $model->forcedIgnoreDup = $map['forcedIgnoreDup'];
        }
        if (isset($map['formCodeList'])) {
            if (!empty($map['formCodeList'])) {
                $model->formCodeList = $map['formCodeList'];
            }
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }

        return $model;
    }
}
