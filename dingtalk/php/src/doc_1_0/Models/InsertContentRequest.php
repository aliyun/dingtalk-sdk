<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class InsertContentRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example content
     *
     * @var mixed[]
     */
    public $content;

    /**
     * @example index
     *
     * @var int
     */
    public $index;

    /**
     * @example path
     *
     * @var int[]
     */
    public $path;

    /**
     * @description This parameter is required.
     *
     * @example union_id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'content' => 'content',
        'index' => 'index',
        'path' => 'path',
        'operatorId' => 'operatorId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->index) {
            $res['index'] = $this->index;
        }
        if (null !== $this->path) {
            $res['path'] = $this->path;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return InsertContentRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['index'])) {
            $model->index = $map['index'];
        }
        if (isset($map['path'])) {
            if (!empty($map['path'])) {
                $model->path = $map['path'];
            }
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
