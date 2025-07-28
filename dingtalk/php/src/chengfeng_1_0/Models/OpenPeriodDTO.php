<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenPeriodDTO extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 311212121
     *
     * @var int
     */
    public $endDate;

    /**
     * @description This parameter is required.
     *
     * @example 111
     *
     * @var string
     */
    public $id;

    /**
     * @description This parameter is required.
     *
     * @example 2023
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example FY_S1
     *
     * @var string
     */
    public $periodBizType;

    /**
     * @description This parameter is required.
     *
     * @example 8383838383
     *
     * @var int
     */
    public $startDate;
    protected $_name = [
        'endDate' => 'endDate',
        'id' => 'id',
        'name' => 'name',
        'periodBizType' => 'periodBizType',
        'startDate' => 'startDate',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->endDate) {
            $res['endDate'] = $this->endDate;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->periodBizType) {
            $res['periodBizType'] = $this->periodBizType;
        }
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenPeriodDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endDate'])) {
            $model->endDate = $map['endDate'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['periodBizType'])) {
            $model->periodBizType = $map['periodBizType'];
        }
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }

        return $model;
    }
}
