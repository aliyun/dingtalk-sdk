<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetLatestDingIndexResponseBody extends Model
{
    /**
     * @description 绿色指数
     *
     * @var float
     */
    public $idxCarbon;

    /**
     * @description 效率指数
     *
     * @var float
     */
    public $idxEfficiency;

    /**
     * @description 钉钉指数月均分
     *
     * @var float
     */
    public $idxMonthlyAvg;

    /**
     * @description 钉钉指数
     *
     * @var float
     */
    public $idxTotal;

    /**
     * @description 日期
     *
     * @var string
     */
    public $statDate;
    protected $_name = [
        'idxCarbon'     => 'idxCarbon',
        'idxEfficiency' => 'idxEfficiency',
        'idxMonthlyAvg' => 'idxMonthlyAvg',
        'idxTotal'      => 'idxTotal',
        'statDate'      => 'statDate',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->idxCarbon) {
            $res['idxCarbon'] = $this->idxCarbon;
        }
        if (null !== $this->idxEfficiency) {
            $res['idxEfficiency'] = $this->idxEfficiency;
        }
        if (null !== $this->idxMonthlyAvg) {
            $res['idxMonthlyAvg'] = $this->idxMonthlyAvg;
        }
        if (null !== $this->idxTotal) {
            $res['idxTotal'] = $this->idxTotal;
        }
        if (null !== $this->statDate) {
            $res['statDate'] = $this->statDate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetLatestDingIndexResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['idxCarbon'])) {
            $model->idxCarbon = $map['idxCarbon'];
        }
        if (isset($map['idxEfficiency'])) {
            $model->idxEfficiency = $map['idxEfficiency'];
        }
        if (isset($map['idxMonthlyAvg'])) {
            $model->idxMonthlyAvg = $map['idxMonthlyAvg'];
        }
        if (isset($map['idxTotal'])) {
            $model->idxTotal = $map['idxTotal'];
        }
        if (isset($map['statDate'])) {
            $model->statDate = $map['statDate'];
        }

        return $model;
    }
}
