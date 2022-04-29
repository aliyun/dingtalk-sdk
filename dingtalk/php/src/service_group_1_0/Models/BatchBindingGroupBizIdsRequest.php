<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\BatchBindingGroupBizIdsRequest\bindingGroupBizIds;
use AlibabaCloud\Tea\Model;

class BatchBindingGroupBizIdsRequest extends Model
{
    /**
     * @var bindingGroupBizIds[]
     */
    public $bindingGroupBizIds;

    /**
     * @description 开放团队ID
     *
     * @var string
     */
    public $openTeamId;
    protected $_name = [
        'bindingGroupBizIds' => 'bindingGroupBizIds',
        'openTeamId'         => 'openTeamId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bindingGroupBizIds) {
            $res['bindingGroupBizIds'] = [];
            if (null !== $this->bindingGroupBizIds && \is_array($this->bindingGroupBizIds)) {
                $n = 0;
                foreach ($this->bindingGroupBizIds as $item) {
                    $res['bindingGroupBizIds'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchBindingGroupBizIdsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bindingGroupBizIds'])) {
            if (!empty($map['bindingGroupBizIds'])) {
                $model->bindingGroupBizIds = [];
                $n                         = 0;
                foreach ($map['bindingGroupBizIds'] as $item) {
                    $model->bindingGroupBizIds[$n++] = null !== $item ? bindingGroupBizIds::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }

        return $model;
    }
}
