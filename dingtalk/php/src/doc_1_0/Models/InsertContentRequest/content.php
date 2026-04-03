<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\InsertContentRequest;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example content
     *
     * @var string
     */
    public $content;

    /**
     * @description This parameter is required.
     *
     * @example markdown
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'content' => 'content',
        'type' => 'type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
