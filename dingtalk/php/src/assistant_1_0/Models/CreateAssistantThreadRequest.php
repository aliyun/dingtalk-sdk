<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateAssistantThreadRequest extends Model
{
    /**
     * @var string[]
     */
    public $metadata;
    protected $_name = [
        'metadata' => 'metadata',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->metadata) {
            $res['metadata'] = $this->metadata;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateAssistantThreadRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['metadata'])) {
            $model->metadata = $map['metadata'];
        }

        return $model;
    }
}
