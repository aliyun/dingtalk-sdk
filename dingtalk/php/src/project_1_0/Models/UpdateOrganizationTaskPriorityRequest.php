<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateOrganizationTaskPriorityRequest extends Model
{
    /**
     * @description 是否禁止动态
     *
     * @var bool
     */
    public $disableActivity;

    /**
     * @description 是否禁止通知
     *
     * @var bool
     */
    public $disableNotification;

    /**
     * @description 优先级【-10,0,1,2】中的一个值
     *
     * @var int
     */
    public $priority;
    protected $_name = [
        'disableActivity'     => 'disableActivity',
        'disableNotification' => 'disableNotification',
        'priority'            => 'priority',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->disableActivity) {
            $res['disableActivity'] = $this->disableActivity;
        }
        if (null !== $this->disableNotification) {
            $res['disableNotification'] = $this->disableNotification;
        }
        if (null !== $this->priority) {
            $res['priority'] = $this->priority;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateOrganizationTaskPriorityRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['disableActivity'])) {
            $model->disableActivity = $map['disableActivity'];
        }
        if (isset($map['disableNotification'])) {
            $model->disableNotification = $map['disableNotification'];
        }
        if (isset($map['priority'])) {
            $model->priority = $map['priority'];
        }

        return $model;
    }
}
