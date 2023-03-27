<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateTaskInvolvemembersRequest extends Model
{
    /**
     * @description 新增参与者列表。
     *
     * @var string[]
     */
    public $addInvolvers;

    /**
     * @description 移除参与者列表。
     *
     * @var string[]
     */
    public $delInvolvers;

    /**
     * @description 更新任务参与者列表。
     *
     * @var string[]
     */
    public $involveMembers;
    protected $_name = [
        'addInvolvers'   => 'addInvolvers',
        'delInvolvers'   => 'delInvolvers',
        'involveMembers' => 'involveMembers',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->addInvolvers) {
            $res['addInvolvers'] = $this->addInvolvers;
        }
        if (null !== $this->delInvolvers) {
            $res['delInvolvers'] = $this->delInvolvers;
        }
        if (null !== $this->involveMembers) {
            $res['involveMembers'] = $this->involveMembers;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateTaskInvolvemembersRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['addInvolvers'])) {
            if (!empty($map['addInvolvers'])) {
                $model->addInvolvers = $map['addInvolvers'];
            }
        }
        if (isset($map['delInvolvers'])) {
            if (!empty($map['delInvolvers'])) {
                $model->delInvolvers = $map['delInvolvers'];
            }
        }
        if (isset($map['involveMembers'])) {
            if (!empty($map['involveMembers'])) {
                $model->involveMembers = $map['involveMembers'];
            }
        }

        return $model;
    }
}
