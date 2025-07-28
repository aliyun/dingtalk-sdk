<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteTrainingRequest;

use AlibabaCloud\Tea\Model;

class params extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $trainEndDate;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $trainName;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $trainStartDate;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $workNo;
    protected $_name = [
        'trainEndDate' => 'trainEndDate',
        'trainName' => 'trainName',
        'trainStartDate' => 'trainStartDate',
        'workNo' => 'workNo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->trainEndDate) {
            $res['trainEndDate'] = $this->trainEndDate;
        }
        if (null !== $this->trainName) {
            $res['trainName'] = $this->trainName;
        }
        if (null !== $this->trainStartDate) {
            $res['trainStartDate'] = $this->trainStartDate;
        }
        if (null !== $this->workNo) {
            $res['workNo'] = $this->workNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return params
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['trainEndDate'])) {
            $model->trainEndDate = $map['trainEndDate'];
        }
        if (isset($map['trainName'])) {
            $model->trainName = $map['trainName'];
        }
        if (isset($map['trainStartDate'])) {
            $model->trainStartDate = $map['trainStartDate'];
        }
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }

        return $model;
    }
}
