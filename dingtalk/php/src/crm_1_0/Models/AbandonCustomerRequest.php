<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class AbandonCustomerRequest extends Model
{
    /**
     * @description 操作人staffId，一般为企业员工
     *
     * @var string
     */
    public $operatorUserId;

    /**
     * @description 客户实例 id 数组
     *
     * @var string[]
     */
    public $instanceIdList;
    protected $_name = [
        'operatorUserId' => 'operatorUserId',
        'instanceIdList' => 'instanceIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->operatorUserId) {
            $res['operatorUserId'] = $this->operatorUserId;
        }
        if (null !== $this->instanceIdList) {
            $res['instanceIdList'] = $this->instanceIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AbandonCustomerRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operatorUserId'])) {
            $model->operatorUserId = $map['operatorUserId'];
        }
        if (isset($map['instanceIdList'])) {
            if (!empty($map['instanceIdList'])) {
                $model->instanceIdList = $map['instanceIdList'];
            }
        }

        return $model;
    }
}
