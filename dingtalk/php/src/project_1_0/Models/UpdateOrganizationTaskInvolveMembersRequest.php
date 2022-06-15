<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateOrganizationTaskInvolveMembersRequest extends Model
{
    /**
     * @description 增加的参与者uid
     *
     * @var string[]
     */
    public $addInvolvers;

    /**
     * @description 删除的参与者uid
     *
     * @var string[]
     */
    public $delInvolvers;

    /**
     * @description 是否禁用动态
     *
     * @var bool
     */
    public $disableActivity;

    /**
     * @description 是否禁用通知
     *
     * @var bool
     */
    public $disableNotification;

    /**
     * @description 所有参与者uid
     *
     * @var string[]
     */
    public $involveMembers;
    protected $_name = [
        'addInvolvers'        => 'addInvolvers',
        'delInvolvers'        => 'delInvolvers',
        'disableActivity'     => 'disableActivity',
        'disableNotification' => 'disableNotification',
        'involveMembers'      => 'involveMembers',
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
        if (null !== $this->disableActivity) {
            $res['disableActivity'] = $this->disableActivity;
        }
        if (null !== $this->disableNotification) {
            $res['disableNotification'] = $this->disableNotification;
        }
        if (null !== $this->involveMembers) {
            $res['involveMembers'] = $this->involveMembers;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateOrganizationTaskInvolveMembersRequest
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
        if (isset($map['disableActivity'])) {
            $model->disableActivity = $map['disableActivity'];
        }
        if (isset($map['disableNotification'])) {
            $model->disableNotification = $map['disableNotification'];
        }
        if (isset($map['involveMembers'])) {
            if (!empty($map['involveMembers'])) {
                $model->involveMembers = $map['involveMembers'];
            }
        }

        return $model;
    }
}
