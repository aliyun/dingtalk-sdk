<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteTransferEvalRequest;

use AlibabaCloud\Tea\Model;

class params extends Model
{
    /**
     * @var string
     */
    public $transferDate;

    /**
     * @var string
     */
    public $transferType;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $workNo;
    protected $_name = [
        'transferDate' => 'transferDate',
        'transferType' => 'transferType',
        'workNo' => 'workNo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->transferDate) {
            $res['transferDate'] = $this->transferDate;
        }
        if (null !== $this->transferType) {
            $res['transferType'] = $this->transferType;
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
        if (isset($map['transferDate'])) {
            $model->transferDate = $map['transferDate'];
        }
        if (isset($map['transferType'])) {
            $model->transferType = $map['transferType'];
        }
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }

        return $model;
    }
}
