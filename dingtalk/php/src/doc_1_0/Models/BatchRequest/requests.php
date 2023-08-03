<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\BatchRequest;

use AlibabaCloud\Tea\Model;

class requests extends Model
{
    /**
     * @var mixed
     */
    public $body;

    /**
     * @example get
     *
     * @var string
     */
    public $method;

    /**
     * @example sheets
     *
     * @var string
     */
    public $path;
    protected $_name = [
        'body'   => 'body',
        'method' => 'method',
        'path'   => 'path',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->body) {
            $res['body'] = $this->body;
        }
        if (null !== $this->method) {
            $res['method'] = $this->method;
        }
        if (null !== $this->path) {
            $res['path'] = $this->path;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return requests
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['body'])) {
            $model->body = $map['body'];
        }
        if (isset($map['method'])) {
            $model->method = $map['method'];
        }
        if (isset($map['path'])) {
            $model->path = $map['path'];
        }

        return $model;
    }
}
