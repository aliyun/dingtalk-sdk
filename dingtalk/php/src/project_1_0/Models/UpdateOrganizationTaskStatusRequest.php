<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateOrganizationTaskStatusRequest extends Model
{
    /**
     * @example false
     *
     * @var bool
     */
    public $disableActivity;

    /**
     * @example false
     *
     * @var bool
     */
    public $disableNotification;

    /**
     * @example true
     *
     * @var bool
     */
    public $isDone;
    protected $_name = [
        'disableActivity'     => 'disableActivity',
        'disableNotification' => 'disableNotification',
        'isDone'              => 'isDone',
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
        if (null !== $this->isDone) {
            $res['isDone'] = $this->isDone;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateOrganizationTaskStatusRequest
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
        if (isset($map['isDone'])) {
            $model->isDone = $map['isDone'];
        }

        return $model;
    }
}
