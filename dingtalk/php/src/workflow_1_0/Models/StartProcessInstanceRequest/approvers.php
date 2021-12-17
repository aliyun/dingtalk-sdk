<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\StartProcessInstanceRequest;

use AlibabaCloud\Tea\Model;

class approvers extends Model
{
    /**
     * @description 审批类型
     *
     * @var string
     */
    public $actionType;

    /**
     * @description 审批人列表
     *
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'actionType' => 'actionType',
        'userIds'    => 'userIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionType) {
            $res['actionType'] = $this->actionType;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return approvers
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionType'])) {
            $model->actionType = $map['actionType'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}
