<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenAgoalPeriodDTO extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1743436799000
     *
     * @var int
     */
    public $endDate;

    /**
     * @description This parameter is required.
     *
     * @example 2024年度
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example 6444f5e9a4261c6e699dxxxx
     *
     * @var string
     */
    public $periodId;

    /**
     * @description This parameter is required.
     *
     * @example season
     *
     * @var string
     */
    public $periodType;

    /**
     * @description This parameter is required.
     *
     * @example 1711900800000
     *
     * @var int
     */
    public $startDate;
    protected $_name = [
        'endDate'    => 'endDate',
        'name'       => 'name',
        'periodId'   => 'periodId',
        'periodType' => 'periodType',
        'startDate'  => 'startDate',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->endDate) {
            $res['endDate'] = $this->endDate;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->periodId) {
            $res['periodId'] = $this->periodId;
        }
        if (null !== $this->periodType) {
            $res['periodType'] = $this->periodType;
        }
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenAgoalPeriodDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endDate'])) {
            $model->endDate = $map['endDate'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['periodId'])) {
            $model->periodId = $map['periodId'];
        }
        if (isset($map['periodType'])) {
            $model->periodType = $map['periodType'];
        }
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }

        return $model;
    }
}
