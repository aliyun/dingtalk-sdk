<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateOrganizationTaskNoteRequest extends Model
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
     * @example 我是一条备注哦
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
