<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateOrganizationTaskPriorityRequest extends Model
{
    /**
     * @example true
     *
     * @var bool
     */
    public $disableActivity;

    /**
     * @example true
     *
     * @var bool
     */
    public $disableNotification;

    /**
     * @description This parameter is required.
     *
     * @example -10
     *
     * @var int
     */
    public $priority;
    protected $_name = [
        'disableActivity' => 'disableActivity',
        'disableNotification' => 'disableNotification',
        'priority' => 'priority',
    ];

    public function validate() {}

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
