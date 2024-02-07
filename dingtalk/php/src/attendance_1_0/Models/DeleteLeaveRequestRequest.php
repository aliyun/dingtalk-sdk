<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteLeaveRequestRequest extends Model
{
    /**
     * @example zxfgsdfsdfvsd
     *
     * @var string
     */
    public $outerId;
    protected $_name = [
        'outerId' => 'outerId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->outerId) {
            $res['outerId'] = $this->outerId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteLeaveRequestRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['outerId'])) {
            $model->outerId = $map['outerId'];
        }

        return $model;
    }
}
