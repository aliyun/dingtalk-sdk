<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class PromptTemplatesOperateRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $bizCode;

    /**
     * @var string
     */
    public $content;

    /**
     * @var string
     */
    public $description;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $operation;
    protected $_name = [
        'bizCode' => 'bizCode',
        'content' => 'content',
        'description' => 'description',
        'operation' => 'operation',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->operation) {
            $res['operation'] = $this->operation;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PromptTemplatesOperateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['operation'])) {
            $model->operation = $map['operation'];
        }

        return $model;
    }
}
