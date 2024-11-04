<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeletePunDetailRequest;

use AlibabaCloud\Tea\Model;

class params extends Model
{
    /**
     * @var string
     */
    public $effectiveDate;

    /**
     * @var string
     */
    public $punName;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $workNo;
    protected $_name = [
        'effectiveDate' => 'effectiveDate',
        'punName'       => 'punName',
        'workNo'        => 'workNo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->effectiveDate) {
            $res['effectiveDate'] = $this->effectiveDate;
        }
        if (null !== $this->punName) {
            $res['punName'] = $this->punName;
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
        if (isset($map['effectiveDate'])) {
            $model->effectiveDate = $map['effectiveDate'];
        }
        if (isset($map['punName'])) {
            $model->punName = $map['punName'];
        }
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }

        return $model;
    }
}
