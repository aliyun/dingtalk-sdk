<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\InsertBlocksRequest\blocks\paragraph;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\InsertBlocksRequest\blocks\paragraph\children\text;
use AlibabaCloud\Tea\Model;

class children extends Model
{
    /**
     * @description 元素类型
     *
     * @var string
     */
    public $elementType;

    /**
     * @description 文本元素
     *
     * @var text
     */
    public $text;
    protected $_name = [
        'elementType' => 'elementType',
        'text'        => 'text',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->elementType) {
            $res['elementType'] = $this->elementType;
        }
        if (null !== $this->text) {
            $res['text'] = null !== $this->text ? $this->text->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return children
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['elementType'])) {
            $model->elementType = $map['elementType'];
        }
        if (isset($map['text'])) {
            $model->text = text::fromMap($map['text']);
        }

        return $model;
    }
}
