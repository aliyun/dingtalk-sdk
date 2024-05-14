<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ProcessApproveCreateResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 3534654765756234
     *
     * @var string
     */
    public $dingtalkApproveId;
    protected $_name = [
        'dingtalkApproveId' => 'dingtalkApproveId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingtalkApproveId) {
            $res['dingtalkApproveId'] = $this->dingtalkApproveId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingtalkApproveId'])) {
            $model->dingtalkApproveId = $map['dingtalkApproveId'];
        }

        return $model;
    }
}
