<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteRegularRequest;

use AlibabaCloud\Tea\Model;

class params extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $regularDate;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $workNo;
    protected $_name = [
        'regularDate' => 'regularDate',
        'workNo' => 'workNo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->regularDate) {
            $res['regularDate'] = $this->regularDate;
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
        if (isset($map['regularDate'])) {
            $model->regularDate = $map['regularDate'];
        }
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }

        return $model;
    }
}
