<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\InsertBlocksRequest\blocks\paragraph\children;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\InsertBlocksRequest\blocks\paragraph\children\text\textStyle;
use AlibabaCloud\Tea\Model;

class text extends Model
{
    /**
     * @description 文本内容
     *
     * @var string
     */
    public $content;

    /**
     * @description 文字样式
     *
     * @var textStyle
     */
    public $textStyle;
    protected $_name = [
        'content'   => 'content',
        'textStyle' => 'textStyle',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->textStyle) {
            $res['textStyle'] = null !== $this->textStyle ? $this->textStyle->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return text
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['textStyle'])) {
            $model->textStyle = textStyle::fromMap($map['textStyle']);
        }

        return $model;
    }
}
