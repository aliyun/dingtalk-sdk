<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTaskRequest;

use AlibabaCloud\Tea\Model;

class remindNotifyConfigs extends Model
{
    /**
     * @var string
     */
    public $dingNotify;

    /**
     * @var string
     */
    public $sendTodoApn;
    protected $_name = [
        'dingNotify' => 'dingNotify',
        'sendTodoApn' => 'sendTodoApn',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingNotify) {
            $res['dingNotify'] = $this->dingNotify;
        }
        if (null !== $this->sendTodoApn) {
            $res['sendTodoApn'] = $this->sendTodoApn;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return remindNotifyConfigs
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingNotify'])) {
            $model->dingNotify = $map['dingNotify'];
        }
        if (isset($map['sendTodoApn'])) {
            $model->sendTodoApn = $map['sendTodoApn'];
        }

        return $model;
    }
}
