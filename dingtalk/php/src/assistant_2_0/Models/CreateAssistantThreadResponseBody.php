<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_2_0\Models;

use AlibabaCloud\Tea\Model;

class CreateAssistantThreadResponseBody extends Model
{
    /**
     * @var int
     */
    public $createdAt;

    /**
     * @var string
     */
    public $id;

    /**
     * @var string
     */
    public $object;
    protected $_name = [
        'createdAt' => 'createdAt',
        'id' => 'id',
        'object' => 'object',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->createdAt) {
            $res['createdAt'] = $this->createdAt;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->object) {
            $res['object'] = $this->object;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateAssistantThreadResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createdAt'])) {
            $model->createdAt = $map['createdAt'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['object'])) {
            $model->object = $map['object'];
        }

        return $model;
    }
}
