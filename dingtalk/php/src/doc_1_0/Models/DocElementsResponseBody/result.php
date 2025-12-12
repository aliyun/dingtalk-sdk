<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DocElementsResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string[]
     */
    public $elements;

    /**
     * @var bool
     */
    public $hasMore;

    /**
     * @var string
     */
    public $nextCursor;
    protected $_name = [
        'elements' => 'elements',
        'hasMore' => 'hasMore',
        'nextCursor' => 'nextCursor',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->elements) {
            $res['elements'] = $this->elements;
        }
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->nextCursor) {
            $res['nextCursor'] = $this->nextCursor;
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
        if (isset($map['elements'])) {
            if (!empty($map['elements'])) {
                $model->elements = $map['elements'];
            }
        }
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['nextCursor'])) {
            $model->nextCursor = $map['nextCursor'];
        }

        return $model;
    }
}
