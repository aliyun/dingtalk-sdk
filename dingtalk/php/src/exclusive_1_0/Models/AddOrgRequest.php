<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddOrgRequest extends Model
{
    /**
     * @description 手机号
     *
     * @var string
     */
    public $mobileNum;

    /**
     * @description 组织名称
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'mobileNum' => 'mobileNum',
        'name'      => 'name',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->mobileNum) {
            $res['mobileNum'] = $this->mobileNum;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddOrgRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mobileNum'])) {
            $model->mobileNum = $map['mobileNum'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
