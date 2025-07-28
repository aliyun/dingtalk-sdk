<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenPeriodDTO extends Model
{
    /**
     * @var int
     */
    public $endDate;

    /**
     * @var string
     */
    public $nameCn;

    /**
     * @var string
     */
    public $nameEn;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $periodId;

    /**
     * @var int
     */
    public $startDate;

    /**
     * @var int
     */
    public $status;
    protected $_name = [
        'endDate' => 'endDate',
        'nameCn' => 'nameCn',
        'nameEn' => 'nameEn',
        'periodId' => 'periodId',
        'startDate' => 'startDate',
        'status' => 'status',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->endDate) {
            $res['endDate'] = $this->endDate;
        }
        if (null !== $this->nameCn) {
            $res['nameCn'] = $this->nameCn;
        }
        if (null !== $this->nameEn) {
            $res['nameEn'] = $this->nameEn;
        }
        if (null !== $this->periodId) {
            $res['periodId'] = $this->periodId;
        }
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
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
        if (isset($map['nameCn'])) {
            $model->nameCn = $map['nameCn'];
        }
        if (isset($map['nameEn'])) {
            $model->nameEn = $map['nameEn'];
        }
        if (isset($map['periodId'])) {
            $model->periodId = $map['periodId'];
        }
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
