<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models;

use AlibabaCloud\Tea\Model;

class RetrieveAssistantThreadResponseBody extends Model
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
     * @var mixed[]
     */
    public $metadata;

    /**
     * @var string
     */
    public $object;
    protected $_name = [
        'createdAt' => 'createdAt',
        'id'        => 'id',
        'metadata'  => 'metadata',
        'object'    => 'object',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->createdAt) {
            $res['createdAt'] = $this->createdAt;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->metadata) {
            $res['metadata'] = $this->metadata;
        }
        if (null !== $this->object) {
            $res['object'] = $this->object;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RetrieveAssistantThreadResponseBody
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
        if (isset($map['metadata'])) {
            $model->metadata = $map['metadata'];
        }
        if (isset($map['object'])) {
            $model->object = $map['object'];
        }

        return $model;
    }
}
