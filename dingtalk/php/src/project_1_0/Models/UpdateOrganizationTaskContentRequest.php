<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateOrganizationTaskContentRequest extends Model
{
    /**
     * @description 任务标题
     *
     * @var string
     */
    public $content;

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
    protected $_name = [
        'content'             => 'content',
        'disableActivity'     => 'disableActivity',
        'disableNotification' => 'disableNotification',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->disableActivity) {
            $res['disableActivity'] = $this->disableActivity;
        }
        if (null !== $this->disableNotification) {
            $res['disableNotification'] = $this->disableNotification;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateOrganizationTaskContentRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['disableActivity'])) {
            $model->disableActivity = $map['disableActivity'];
        }
        if (isset($map['disableNotification'])) {
            $model->disableNotification = $map['disableNotification'];
        }

        return $model;
    }
}
