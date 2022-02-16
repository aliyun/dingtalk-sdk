<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models\QueryYydDingMsgWeekStatisticalDataResponseBody;

use AlibabaCloud\Tea\Model;

class metaList extends Model
{
    /**
     * @description 指标ID
     *
     * @var string
     */
    public $kpiId;

    /**
     * @description 指标名称
     *
     * @var string
     */
    public $kpiName;

    /**
     * @description 指标单位
     *
     * @var string
     */
    public $unit;

    /**
     * @description 指标口径
     *
     * @var string
     */
    public $kpiCaliber;

    /**
     * @description 指标周期
     *
     * @var string
     */
    public $period;
    protected $_name = [
        'kpiId'      => 'kpiId',
        'kpiName'    => 'kpiName',
        'unit'       => 'unit',
        'kpiCaliber' => 'kpiCaliber',
        'period'     => 'period',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->kpiId) {
            $res['kpiId'] = $this->kpiId;
        }
        if (null !== $this->kpiName) {
            $res['kpiName'] = $this->kpiName;
        }
        if (null !== $this->unit) {
            $res['unit'] = $this->unit;
        }
        if (null !== $this->kpiCaliber) {
            $res['kpiCaliber'] = $this->kpiCaliber;
        }
        if (null !== $this->period) {
            $res['period'] = $this->period;
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
        if (isset($map['kpiId'])) {
            $model->kpiId = $map['kpiId'];
        }
        if (isset($map['kpiName'])) {
            $model->kpiName = $map['kpiName'];
        }
        if (isset($map['unit'])) {
            $model->unit = $map['unit'];
        }
        if (isset($map['kpiCaliber'])) {
            $model->kpiCaliber = $map['kpiCaliber'];
        }
        if (isset($map['period'])) {
            $model->period = $map['period'];
        }

        return $model;
    }
}
