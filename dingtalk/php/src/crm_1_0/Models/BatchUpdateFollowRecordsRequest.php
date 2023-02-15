<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchUpdateFollowRecordsRequest\instanceList;
use AlibabaCloud\Tea\Model;

class BatchUpdateFollowRecordsRequest extends Model
{
    /**
     * @description 关系数据列表。
     *
     * @var instanceList[]
     */
    public $instanceList;

    /**
     * @description 操作人userId
     *
     * @var string
     */
    public $operatorUserId;
    protected $_name = [
        'instanceList'   => 'instanceList',
        'operatorUserId' => 'operatorUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->instanceList) {
            $res['instanceList'] = [];
            if (null !== $this->instanceList && \is_array($this->instanceList)) {
                $n = 0;
                foreach ($this->instanceList as $item) {
                    $res['instanceList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->operatorUserId) {
            $res['operatorUserId'] = $this->operatorUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchUpdateFollowRecordsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['instanceList'])) {
            if (!empty($map['instanceList'])) {
                $model->instanceList = [];
                $n                   = 0;
                foreach ($map['instanceList'] as $item) {
                    $model->instanceList[$n++] = null !== $item ? instanceList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['operatorUserId'])) {
            $model->operatorUserId = $map['operatorUserId'];
        }

        return $model;
    }
}
