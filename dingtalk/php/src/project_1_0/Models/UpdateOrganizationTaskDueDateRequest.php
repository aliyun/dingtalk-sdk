<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateOrganizationTaskDueDateRequest extends Model
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
     * @description 任务截止时间
     *
     * @var string
     */
    public $dueDate;
    protected $_name = [
        'disableActivity'     => 'disableActivity',
        'disableNotification' => 'disableNotification',
        'dueDate'             => 'dueDate',
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
        if (null !== $this->dueDate) {
            $res['dueDate'] = $this->dueDate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateOrganizationTaskDueDateRequest
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
        if (isset($map['dueDate'])) {
            $model->dueDate = $map['dueDate'];
        }

        return $model;
    }
}
