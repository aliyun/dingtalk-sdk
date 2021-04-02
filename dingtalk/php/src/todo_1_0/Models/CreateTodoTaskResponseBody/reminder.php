<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTaskResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTaskResponseBody\reminder\rules;
use AlibabaCloud\Tea\Model;

class reminder extends Model
{
    /**
     * @description 提醒通道
     *
     * @var int
     */
    public $channel;

    /**
     * @description 提醒规则配置
     *
     * @var rules
     */
    public $rules;
    protected $_name = [
        'channel' => 'channel',
        'rules'   => 'rules',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->channel) {
            $res['channel'] = $this->channel;
        }
        if (null !== $this->rules) {
            $res['rules'] = null !== $this->rules ? $this->rules->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return reminder
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['channel'])) {
            $model->channel = $map['channel'];
        }
        if (isset($map['rules'])) {
            $model->rules = rules::fromMap($map['rules']);
        }

        return $model;
    }
}
