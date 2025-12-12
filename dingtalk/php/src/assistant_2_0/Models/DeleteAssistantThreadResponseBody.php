<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_2_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteAssistantThreadResponseBody extends Model
{
    /**
     * @var bool
     */
    public $deleted;

    /**
     * @var string
     */
    public $id;

    /**
     * @var string
     */
    public $object;
    protected $_name = [
        'deleted' => 'deleted',
        'id' => 'id',
        'object' => 'object',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deleted) {
            $res['deleted'] = $this->deleted;
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
     * @return DeleteAssistantThreadResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deleted'])) {
            $model->deleted = $map['deleted'];
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
