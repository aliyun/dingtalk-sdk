<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddCityCarApplyResponseBody extends Model
{
    /**
     * @description 商旅内部审批单ID
     *
     * @var int
     */
    public $applyId;
    protected $_name = [
        'applyId' => 'applyId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->applyId) {
            $res['applyId'] = $this->applyId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddCityCarApplyResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['applyId'])) {
            $model->applyId = $map['applyId'];
        }

        return $model;
    }
}
