<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListJoinOrgInfoRequest extends Model
{
    /**
     * @description 手机号码，企业内必须唯一，不可重复。如果是国际号码，请使用+xx-xxxxxx的格式。
     *
     * @var string
     */
    public $mobile;
    protected $_name = [
        'mobile' => 'mobile',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListJoinOrgInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }

        return $model;
    }
}
