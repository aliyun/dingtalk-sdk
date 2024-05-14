<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydTotalDayStatisticalDataResponseBody;

use AlibabaCloud\Tea\Model;

class metaList extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $kpiCaliber;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $kpiId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $kpiName;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $period;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $unit;
    protected $_name = [
        'kpiCaliber' => 'kpiCaliber',
        'kpiId'      => 'kpiId',
        'kpiName'    => 'kpiName',
        'period'     => 'period',
        'unit'       => 'unit',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->kpiCaliber) {
            $res['kpiCaliber'] = $this->kpiCaliber;
        }
        if (null !== $this->kpiId) {
            $res['kpiId'] = $this->kpiId;
        }
        if (null !== $this->kpiName) {
            $res['kpiName'] = $this->kpiName;
        }
        if (null !== $this->period) {
            $res['period'] = $this->period;
        }
        if (null !== $this->unit) {
            $res['unit'] = $this->unit;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return metaList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['kpiCaliber'])) {
            $model->kpiCaliber = $map['kpiCaliber'];
        }
        if (isset($map['kpiId'])) {
            $model->kpiId = $map['kpiId'];
        }
        if (isset($map['kpiName'])) {
            $model->kpiName = $map['kpiName'];
        }
        if (isset($map['period'])) {
            $model->period = $map['period'];
        }
        if (isset($map['unit'])) {
            $model->unit = $map['unit'];
        }

        return $model;
    }
}
