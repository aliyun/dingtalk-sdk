<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateOrganizationTaskNoteRequest extends Model
{
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
     * @description 任务备注
     *
     * @var string
     */
    public $note;
    protected $_name = [
        'disableActivity'     => 'disableActivity',
        'disableNotification' => 'disableNotification',
        'note'                => 'note',
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
        if (null !== $this->note) {
            $res['note'] = $this->note;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateOrganizationTaskNoteRequest
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
        if (isset($map['note'])) {
            $model->note = $map['note'];
        }

        return $model;
    }
}
