<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchUpdateContactsRequest\relationList;
use AlibabaCloud\Tea\Model;

class BatchUpdateContactsRequest extends Model
{
    /**
     * @description 操作人userId
     *
     * @var string
     */
    public $operatorUserId;

    /**
     * @description 联系人数据列表。
     *
     * @var relationList[]
     */
    public $relationList;
    protected $_name = [
        'operatorUserId' => 'operatorUserId',
        'relationList'   => 'relationList',
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
        if (null !== $this->relationList) {
            $res['relationList'] = [];
            if (null !== $this->relationList && \is_array($this->relationList)) {
                $n = 0;
                foreach ($this->relationList as $item) {
                    $res['relationList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchUpdateContactsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operatorUserId'])) {
            $model->operatorUserId = $map['operatorUserId'];
        }
        if (isset($map['relationList'])) {
            if (!empty($map['relationList'])) {
                $model->relationList = [];
                $n                   = 0;
                foreach ($map['relationList'] as $item) {
                    $model->relationList[$n++] = null !== $item ? relationList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
