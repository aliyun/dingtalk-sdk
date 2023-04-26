<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendAgentOTOMessageRequest\detail\messageBody;

use AlibabaCloud\Tea\Model;

class text extends Model
{
    /**
     * @example 你好，欢迎使用服务窗。
     *
     * @var string
     */
    public $content;
    protected $_name = [
        'content' => 'content',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return text
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }

        return $model;
    }
}
