<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTaskRequest;

use AlibabaCloud\Tea\Model;

class notifyConfigs extends Model
{
    /**
     * @description ding通知配置：1钉弹框通知
     *
     * @var string
     */
    public $dingNotify;
    protected $_name = [
        'dingNotify' => 'dingNotify',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingNotify) {
            $res['dingNotify'] = $this->dingNotify;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return notifyConfigs
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingNotify'])) {
            $model->dingNotify = $map['dingNotify'];
        }

        return $model;
    }
}
