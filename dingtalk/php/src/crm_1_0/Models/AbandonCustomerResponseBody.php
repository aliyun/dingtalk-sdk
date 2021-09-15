<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class AbandonCustomerResponseBody extends Model
{
    /**
     * @description 成功退回公海的客户实例 id 数组
     *
     * @var string[]
     */
    public $instanceIdList;
    protected $_name = [
        'instanceIdList' => 'instanceIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->instanceIdList) {
            $res['instanceIdList'] = $this->instanceIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AbandonCustomerResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['instanceIdList'])) {
            if (!empty($map['instanceIdList'])) {
                $model->instanceIdList = $map['instanceIdList'];
            }
        }

        return $model;
    }
}
