<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetJobPositionRequest extends Model
{
    /**
     * @description 职位编码
     *
     * @var string
     */
    public $jobPositionCode;
    protected $_name = [
        'jobPositionCode' => 'jobPositionCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->jobPositionCode) {
            $res['jobPositionCode'] = $this->jobPositionCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetJobPositionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['jobPositionCode'])) {
            $model->jobPositionCode = $map['jobPositionCode'];
        }

        return $model;
    }
}
