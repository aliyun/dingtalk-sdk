<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class DigitalStoreRightsInfoResponseBody extends Model
{
    /**
     * @example 1659668620000
     *
     * @var int
     */
    public $endTime;

    /**
     * @description This parameter is required.
     *
     * @example 100
     *
     * @var int
     */
    public $quantity;

    /**
     * @example RIGHT_MDT_LEVEL
     *
     * @var string
     */
    public $rightsCode;

    /**
     * @description This parameter is required.
     *
     * @example 高级版
     *
     * @var string
     */
    public $rightsName;

    /**
     * @example 1656990220000
     *
     * @var int
     */
    public $startTime;
    protected $_name = [
        'endTime'    => 'endTime',
        'quantity'   => 'quantity',
        'rightsCode' => 'rightsCode',
        'rightsName' => 'rightsName',
        'startTime'  => 'startTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->quantity) {
            $res['quantity'] = $this->quantity;
        }
        if (null !== $this->rightsCode) {
            $res['rightsCode'] = $this->rightsCode;
        }
        if (null !== $this->rightsName) {
            $res['rightsName'] = $this->rightsName;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DigitalStoreRightsInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['quantity'])) {
            $model->quantity = $map['quantity'];
        }
        if (isset($map['rightsCode'])) {
            $model->rightsCode = $map['rightsCode'];
        }
        if (isset($map['rightsName'])) {
            $model->rightsName = $map['rightsName'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }

        return $model;
    }
}
