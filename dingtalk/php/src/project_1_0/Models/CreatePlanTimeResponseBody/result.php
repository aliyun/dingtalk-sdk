<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreatePlanTimeResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreatePlanTimeResponseBody\result\body;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var body[]
     */
    public $body;

    /**
     * @description 执行结果描述
     *
     * @var string
     */
    public $message;

    /**
     * @var bool
     */
    public $ok;
    protected $_name = [
        'body'    => 'body',
        'message' => 'message',
        'ok'      => 'ok',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->body) {
            $res['body'] = [];
            if (null !== $this->body && \is_array($this->body)) {
                $n = 0;
                foreach ($this->body as $item) {
                    $res['body'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->message) {
            $res['message'] = $this->message;
        }
        if (null !== $this->ok) {
            $res['ok'] = $this->ok;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['body'])) {
            if (!empty($map['body'])) {
                $model->body = [];
                $n           = 0;
                foreach ($map['body'] as $item) {
                    $model->body[$n++] = null !== $item ? body::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['message'])) {
            $model->message = $map['message'];
        }
        if (isset($map['ok'])) {
            $model->ok = $map['ok'];
        }

        return $model;
    }
}
