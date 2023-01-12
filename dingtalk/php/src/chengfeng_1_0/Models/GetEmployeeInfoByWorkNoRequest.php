<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetEmployeeInfoByWorkNoRequest extends Model
{
    /**
     * @description 工号
     *
     * @var string
     */
    public $workNo;
    protected $_name = [
        'workNo' => 'workNo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->workNo) {
            $res['workNo'] = $this->workNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetEmployeeInfoByWorkNoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }

        return $model;
    }
}
