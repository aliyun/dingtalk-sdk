<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models;

use AlibabaCloud\Tea\Model;

class CfJobPositionResp extends Model
{
    /**
     * @description 职位编码
     *
     * @var string
     */
    public $jobPositionCode;

    /**
     * @description 职位名称
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'jobPositionCode' => 'jobPositionCode',
        'name'            => 'name',
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
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CfJobPositionResp
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['jobPositionCode'])) {
            $model->jobPositionCode = $map['jobPositionCode'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
