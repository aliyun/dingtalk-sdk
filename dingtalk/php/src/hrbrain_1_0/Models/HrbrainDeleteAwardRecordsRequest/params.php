<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteAwardRecordsRequest;

use AlibabaCloud\Tea\Model;

class params extends Model
{
    /**
     * @var string
     */
    public $awardDate;

    /**
     * @var string
     */
    public $awardName;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $workNo;
    protected $_name = [
        'awardDate' => 'awardDate',
        'awardName' => 'awardName',
        'workNo'    => 'workNo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->awardDate) {
            $res['awardDate'] = $this->awardDate;
        }
        if (null !== $this->awardName) {
            $res['awardName'] = $this->awardName;
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
        if (isset($map['awardDate'])) {
            $model->awardDate = $map['awardDate'];
        }
        if (isset($map['awardName'])) {
            $model->awardName = $map['awardName'];
        }
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }

        return $model;
    }
}
