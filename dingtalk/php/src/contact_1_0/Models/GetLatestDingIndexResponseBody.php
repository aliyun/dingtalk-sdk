<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetLatestDingIndexResponseBody extends Model
{
    /**
     * @description 日期
     *
     * @var string
     */
    public $statDate;

    /**
     * @description 钉钉指数
     *
     * @var float
     */
    public $idxTotal;

    /**
     * @description 效率指数
     *
     * @var float
     */
    public $idxEfficiency;

    /**
     * @description 绿色指数
     *
     * @var float
     */
    public $idxCarbon;

    /**
     * @description 钉钉指数月均分
     *
     * @var float
     */
    public $idxMonthlyAvg;
    protected $_name = [
        'statDate'      => 'statDate',
        'idxTotal'      => 'idxTotal',
        'idxEfficiency' => 'idxEfficiency',
        'idxCarbon'     => 'idxCarbon',
        'idxMonthlyAvg' => 'idxMonthlyAvg',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->statDate) {
            $res['statDate'] = $this->statDate;
        }
        if (null !== $this->idxTotal) {
            $res['idxTotal'] = $this->idxTotal;
        }
        if (null !== $this->idxEfficiency) {
            $res['idxEfficiency'] = $this->idxEfficiency;
        }
        if (null !== $this->idxCarbon) {
            $res['idxCarbon'] = $this->idxCarbon;
        }
        if (null !== $this->idxMonthlyAvg) {
            $res['idxMonthlyAvg'] = $this->idxMonthlyAvg;
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
        if (isset($map['statDate'])) {
            $model->statDate = $map['statDate'];
        }
        if (isset($map['idxTotal'])) {
            $model->idxTotal = $map['idxTotal'];
        }
        if (isset($map['idxEfficiency'])) {
            $model->idxEfficiency = $map['idxEfficiency'];
        }
        if (isset($map['idxCarbon'])) {
            $model->idxCarbon = $map['idxCarbon'];
        }
        if (isset($map['idxMonthlyAvg'])) {
            $model->idxMonthlyAvg = $map['idxMonthlyAvg'];
        }

        return $model;
    }
}
